using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering;

namespace OccupyCity.Recovery.Editor
{
    public static class ValidateRecoveryRenderBindings
    {
        [Serializable] public sealed class ShaderState
        {
            public string path, guid, shaderName, localFileId;
            public int instanceId, passCount;
            public bool supported, hdrKeyword;
            public string[] passNames, compilerMessages;
            public int compilerErrors;
        }
        [Serializable] public sealed class Binding
        {
            public string rendererPath, field, shaderPath, shaderGuid;
            public int shaderInstanceId;
        }
        [Serializable] public sealed class Report
        {
            public string status, utc, unityVersion, graphicsApi, activePipelinePath, activeRendererPath;
            public bool sceneUnchanged, originalStartupAccepted, coreGameplayAccepted;
            public List<ShaderState> shaders = new List<ShaderState>();
            public List<Binding> bindings = new List<Binding>();
            public List<string> failures = new List<string>();
        }

        public static void RunConfigured(string reportPath)
        {
            string project = Directory.GetParent(Application.dataPath).FullName;
            string workspace = Directory.GetParent(Directory.GetParent(project).FullName).FullName;
            string ledger = Path.GetFullPath(Path.Combine(workspace, "work", "recovery-ledger"));
            reportPath = Path.GetFullPath(reportPath);
            if (!reportPath.StartsWith(ledger + Path.DirectorySeparatorChar, StringComparison.OrdinalIgnoreCase))
                throw new ArgumentException("Render readback report must stay in this task ledger.");
            var scene = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
            int originalHandle = scene.handle;
            bool originalDirty = scene.isDirty;
            var report = new Report { utc = DateTime.UtcNow.ToString("o"), unityVersion = Application.unityVersion,
                graphicsApi = SystemInfo.graphicsDeviceType.ToString(), status = "checking_actual_shader_import" };
            string[] paths = {
                "Assets/Shader/Hidden_Universal_CoreBlit.shader", "Assets/Shader/Hidden_Universal_CoreBlit_0.shader",
                "Assets/Shader/Hidden_Universal_CoreBlitColorAndDepth.shader", "Assets/Shader/Hidden_Universal_CoreBlitColorAndDepth_0.shader"
            };
            foreach (string path in paths)
            {
                Shader shader = AssetDatabase.LoadAssetAtPath<Shader>(path);
                if (shader == null) { report.failures.Add("Shader did not import: " + path); continue; }
                AssetDatabase.TryGetGUIDAndLocalFileIdentifier(shader, out string guid, out long fileId);
                var messages = ShaderUtil.GetShaderMessages(shader);
                var state = new ShaderState { path = path, guid = guid, shaderName = shader.name,
                    localFileId = fileId.ToString(), instanceId = shader.GetInstanceID(), passCount = shader.passCount,
                    supported = shader.isSupported,
                    hdrKeyword = shader.keywordSpace.keywords.Any(keyword => keyword.name == "BLIT_DECODE_HDR"),
                    compilerErrors = messages.Count(message => message.severity.ToString() == "Error"),
                    compilerMessages = messages.Select(message => message.severity + ": " + message.message).ToArray() };
                Material material = null;
                try
                {
                    material = new Material(shader) { hideFlags = HideFlags.HideAndDontSave };
                    state.passNames = Enumerable.Range(0, material.passCount).Select(material.GetPassName).ToArray();
                }
                finally { if (material != null) UnityEngine.Object.DestroyImmediate(material); }
                bool blit = path.Contains("CoreBlit.") || path.Contains("CoreBlit_0.");
                if (!state.supported || state.compilerErrors != 0 || state.passCount != (blit ? 25 : 2) || (blit && !state.hdrKeyword))
                    report.failures.Add("Imported shader contract differs from required official implementation: " + path);
                report.shaders.Add(state);
            }
            string[] renderers = { "Assets/MonoBehaviour/SamplesForwardRenderer.asset",
                "Assets/_Res/Addressable/01FirstBundle/Config/SamplesForwardRenderer.asset" };
            foreach (string renderer in renderers) ReadBindings(renderer, report);
            RenderPipelineAsset pipeline = GraphicsSettings.currentRenderPipeline;
            if (pipeline != null)
            {
                report.activePipelinePath = AssetDatabase.GetAssetPath(pipeline);
                var serialized = new SerializedObject(pipeline);
                var list = serialized.FindProperty("m_RendererDataList");
                var selected = serialized.FindProperty("m_DefaultRendererIndex");
                int index = selected != null ? selected.intValue : 0;
                if (list != null && list.isArray && index >= 0 && index < list.arraySize)
                    report.activeRendererPath = AssetDatabase.GetAssetPath(list.GetArrayElementAtIndex(index).objectReferenceValue);
            }
            if (string.IsNullOrEmpty(report.activeRendererPath) || !renderers.Contains(report.activeRendererPath))
                report.failures.Add("Current pipeline/default Renderer identity is not one of the reviewed original bindings.");
            scene = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
            report.sceneUnchanged = scene.handle == originalHandle && scene.isDirty == originalDirty;
            if (!report.sceneUnchanged) report.failures.Add("Scene state changed during readback.");
            report.originalStartupAccepted = false;
            report.coreGameplayAccepted = false;
            report.status = report.failures.Count == 0 ? "actual_shader_import_and_binding_readback_passed" : "actual_shader_readback_failed";
            Directory.CreateDirectory(ledger);
            File.WriteAllText(reportPath, JsonUtility.ToJson(report, true));
        }

        private static void ReadBindings(string path, Report report)
        {
            var renderer = AssetDatabase.LoadAssetAtPath<ScriptableObject>(path);
            if (renderer == null) { report.failures.Add("Renderer asset did not import: " + path); return; }
            var serialized = new SerializedObject(renderer);
            var iterator = serialized.GetIterator();
            int count = 0;
            while (iterator.Next(true))
            {
                if (iterator.name != "coreBlitPS" && iterator.name != "coreBlitColorAndDepthPS") continue;
                Shader shader = iterator.objectReferenceValue as Shader;
                if (shader == null) { report.failures.Add("Actual Renderer shader binding is null: " + path + ":" + iterator.propertyPath); continue; }
                AssetDatabase.TryGetGUIDAndLocalFileIdentifier(shader, out string guid, out long ignored);
                string actualPath = AssetDatabase.GetAssetPath(shader);
                bool alternate = path.Contains("/Addressable/");
                string expected = "Assets/Shader/Hidden_Universal_" + (iterator.name == "coreBlitPS" ? "CoreBlit" : "CoreBlitColorAndDepth")
                    + (alternate ? "_0" : "") + ".shader";
                if (actualPath != expected) report.failures.Add("Renderer binding points to unexpected asset: " + path + ":" + iterator.propertyPath + " -> " + actualPath);
                report.bindings.Add(new Binding { rendererPath = path, field = iterator.propertyPath, shaderPath = actualPath,
                    shaderGuid = guid, shaderInstanceId = shader.GetInstanceID() });
                ++count;
            }
            if (count != 2) report.failures.Add("Expected two actual blit bindings in Renderer: " + path);
        }
    }
}
