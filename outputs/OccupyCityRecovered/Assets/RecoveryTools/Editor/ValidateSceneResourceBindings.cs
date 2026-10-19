using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace OccupyCity.Recovery.Editor
{
    public static class ValidateSceneResourceBindings
    {
        [Serializable] public sealed class Target
        {
            public string scene;
            public string localizeObject;
            public string localizeType;
            public string targetType;
            public string textType;
            public string textObject;
            public bool targetIsPersistent;
            public bool textBelongsToSameScene;
            public bool passed;
            public string error;
        }
        [Serializable] public sealed class Atlas
        {
            public string path;
            public string guid;
            public int textBytes;
            public bool passed;
        }
        [Serializable] public sealed class Report
        {
            public string unityVersion;
            public bool playMode;
            public bool coreGameplayAccepted;
            public bool passed;
            public List<Target> targets = new List<Target>();
            public List<Atlas> atlasTexts = new List<Atlas>();
        }

        public static void Run()
        {
            if (EditorApplication.isPlayingOrWillChangePlaymode) throw new InvalidOperationException("Requires idle Edit Mode.");
            var report = new Report { unityVersion = Application.unityVersion, playMode = false, coreGameplayAccepted = false };
            string[] scenes = { "Assets/gameres/bundleres/Scene/MineGameMain.unity", "Assets/_Scene/Game.unity" };
            foreach (string path in scenes)
            {
                Scene scene = EditorSceneManager.OpenScene(path, OpenSceneMode.Single);
                foreach (GameObject root in scene.GetRootGameObjects())
                foreach (MonoBehaviour component in root.GetComponentsInChildren<MonoBehaviour>(true))
                {
                    if (component == null || component.GetType().FullName != "I2.Loc.Localize") continue;
                    var target = new Target { scene = path, localizeObject = component.name, localizeType = component.GetType().FullName };
                    try
                    {
                        object localTarget = component.GetType().GetField("mLocalizeTarget").GetValue(component);
                        if (localTarget == null) throw new InvalidOperationException("Original Localize target is null.");
                        target.targetType = localTarget.GetType().FullName;
                        target.targetIsPersistent = EditorUtility.IsPersistent((UnityEngine.Object)localTarget);
                        object text = localTarget.GetType().GetField("mTarget", BindingFlags.Instance | BindingFlags.Public).GetValue(localTarget);
                        var textComponent = text as Component;
                        target.textType = text == null ? "null" : text.GetType().FullName;
                        target.textObject = textComponent == null ? "" : textComponent.name;
                        target.textBelongsToSameScene = textComponent != null && textComponent.gameObject.scene == scene;
                        target.passed = target.targetType == "I2.Loc.LocalizeTarget_TextMeshPro_UGUI"
                            && target.textType == "TMPro.TextMeshProUGUI" && !target.targetIsPersistent && target.textBelongsToSameScene;
                    }
                    catch (Exception error) { target.error = error.ToString(); target.passed = false; }
                    report.targets.Add(target);
                }
            }
            foreach (string path in new[] { "Assets/Resources/logo/logo.atlas.txt", "Assets/Resources/season/loading_season6/Loading-zsj.atlas.txt" })
            {
                var text = AssetDatabase.LoadAssetAtPath<TextAsset>(path);
                report.atlasTexts.Add(new Atlas { path = path, guid = AssetDatabase.AssetPathToGUID(path),
                    textBytes = text == null ? -1 : text.bytes.Length, passed = text != null && text.bytes.Length > 0 });
            }
            report.passed = report.targets.Count == 4 && report.targets.TrueForAll(t => t.passed) && report.atlasTexts.TrueForAll(t => t.passed);
            string workspace = Directory.GetParent(Directory.GetParent(Application.dataPath).FullName).Parent.FullName;
            string output = Path.Combine(workspace, "work", "recovery-ledger", "scene-resource-bindings.json");
            File.WriteAllText(output, JsonUtility.ToJson(report, true));
            if (!report.passed) throw new InvalidOperationException("Scene resource reference validation failed; inspect " + output);
            Debug.Log("Validated four original scene-local localization targets and two original Spine TextAssets; gameplay not accepted.");
        }
    }
}
