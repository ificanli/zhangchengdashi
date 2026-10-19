using System;
using System.IO;
using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace OccupyCity.Recovery.Editor
{
    // A task-local command file lets the coordinator reuse the user's open Editor.
    // Only fixed recovery diagnostics are exposed; no arbitrary method execution.
    [InitializeOnLoad]
    public static class RecoveryEditorCommands
    {
        private const string LastCommandKey = "OccupyCity.Recovery.LastEditorCommand";
        private static double _nextCheck;

        [Serializable] public sealed class Request
        {
            public string id;
            public string action;
            public string reportFile;
            public double duration = 30;
        }

        [Serializable] public sealed class Receipt
        {
            public string id;
            public string action;
            public string status;
            public string utc;
            public int editorProcessId;
            public string projectPath;
            public string activeScene;
            public string unityVersion;
            public bool batchMode;
            public bool playing;
            public string observationReport;
            public string error;
            public string[] dirtyScenes;
            public string bridgeRevision;
            public bool authorizedDiscard;
        }

        static RecoveryEditorCommands()
        {
            EditorApplication.update += Tick;
        }

        private static void Tick()
        {
            if (EditorApplication.timeSinceStartup < _nextCheck) return;
            _nextCheck = EditorApplication.timeSinceStartup + 2;
            if (EditorApplication.isCompiling || EditorApplication.isUpdating) return;
            string project = Directory.GetParent(Application.dataPath).FullName;
            string workspace = Directory.GetParent(Directory.GetParent(project).FullName).FullName;
            string ledger = Path.Combine(workspace, "work", "recovery-ledger");
            string command = Path.Combine(ledger, "editor-command.json");
            if (!File.Exists(command)) return;
            Request request;
            try { request = JsonUtility.FromJson<Request>(File.ReadAllText(command)); }
            catch (Exception) { return; } // An incomplete atomic-file replacement is retried.
            if (request == null || !Guid.TryParseExact(request.id, "N", out _)
                || request.id == SessionState.GetString(LastCommandKey, "")) return;
            // User PlayMode is left alone. The request remains pending until the Editor is idle.
            if (EditorApplication.isPlayingOrWillChangePlaymode) return;
            var receipt = new Receipt
            {
                id = request.id, action = request.action, status = "accepted",
                utc = DateTime.UtcNow.ToString("o"), editorProcessId = System.Diagnostics.Process.GetCurrentProcess().Id,
                projectPath = project, activeScene = SceneManager.GetActiveScene().path,
                unityVersion = Application.unityVersion, batchMode = Application.isBatchMode,
                playing = EditorApplication.isPlaying,
                bridgeRevision = "2026-10-19-render-readback-v1",
                authorizedDiscard = request.action == "ObserveOriginalMainDiscardUnsaved",
                dirtyScenes = Enumerable.Range(0, SceneManager.sceneCount)
                    .Select(i => SceneManager.GetSceneAt(i)).Where(scene => scene.isDirty)
                    .Select(scene => string.IsNullOrEmpty(scene.path) ? scene.name : scene.path).ToArray()
            };
            SessionState.SetString(LastCommandKey, request.id);
            string receiptPath = Path.Combine(ledger, "editor-command-" + request.id + ".json");
            try
            {
                if (request.action == "Snapshot") receipt.status = "completed";
                else if (request.action == "ValidateRenderBindings")
                {
                    if (string.IsNullOrEmpty(request.reportFile) || Path.GetFileName(request.reportFile) != request.reportFile
                        || !request.reportFile.StartsWith("unity-render-", StringComparison.Ordinal)
                        || !request.reportFile.EndsWith(".json", StringComparison.Ordinal))
                        throw new ArgumentException("Expected a task-ledger render report filename.");
                    receipt.observationReport = Path.Combine(ledger, request.reportFile);
                    ValidateRecoveryRenderBindings.RunConfigured(receipt.observationReport);
                    receipt.status = "render_readback_completed";
                }
                else if (request.action == "ValidateLocalResources")
                {
                    if (string.IsNullOrEmpty(request.reportFile) || Path.GetFileName(request.reportFile) != request.reportFile
                        || !request.reportFile.StartsWith("unity-resources-", StringComparison.Ordinal)
                        || !request.reportFile.EndsWith(".json", StringComparison.Ordinal))
                        throw new ArgumentException("Expected a task-ledger resource probe report filename.");
                    Type probe = Type.GetType("OccupyCity.Recovery.LocalResources.Editor.ObserveLocalResourcesInEditor, OccupyCity.Recovery.LocalResources.Editor", true);
                    MethodInfo begin = probe.GetMethod("Begin", BindingFlags.Public | BindingFlags.Static, null, new[] { typeof(string) }, null);
                    if (begin == null) throw new MissingMethodException(probe.FullName, "Begin(string)");
                    receipt.observationReport = Path.Combine(ledger, request.reportFile);
                    begin.Invoke(null, new object[] { receipt.observationReport });
                    receipt.status = "resource_probe_started";
                }
                else if (request.action == "ObserveOriginalMain" || request.action == "ObserveOriginalMainDiscardUnsaved")
                {
                    if (string.IsNullOrEmpty(request.reportFile) || Path.GetFileName(request.reportFile) != request.reportFile
                        || !request.reportFile.StartsWith("unity-play-", StringComparison.Ordinal)
                        || !request.reportFile.EndsWith(".json", StringComparison.Ordinal))
                        throw new ArgumentException("Expected a task-ledger observation report filename.");
                    receipt.observationReport = Path.Combine(ledger, request.reportFile);
                    File.WriteAllText(receiptPath, JsonUtility.ToJson(receipt, true));
                    ObserveRecoveryPlayMode.RunConfigured("Assets/gameres/bundleres/Scene/MineGameMain.unity",
                        receipt.observationReport, request.duration, receipt.authorizedDiscard);
                    receipt.status = "observation_started";
                }
                else throw new ArgumentException("Unsupported recovery command: " + request.action);
            }
            catch (Exception exception)
            {
                receipt.status = "command_not_run";
                receipt.error = exception.GetType().Name + ": " + exception.Message;
            }
            Directory.CreateDirectory(ledger);
            File.WriteAllText(receiptPath, JsonUtility.ToJson(receipt, true));
        }
    }
}
