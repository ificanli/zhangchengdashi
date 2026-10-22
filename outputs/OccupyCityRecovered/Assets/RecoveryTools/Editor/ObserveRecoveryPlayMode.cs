using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Rendering;

namespace OccupyCity.Recovery.Editor
{
    // This observer never invokes game methods or changes an initialization gate.
    // SessionState keeps the observation alive across the normal PlayMode domain reload.
    [InitializeOnLoad]
    public static class ObserveRecoveryPlayMode
    {
        private const string SessionKey = "OccupyCity.Recovery.PlayObservation";
        private static Observation _report;
        private static string _path;
        private static bool _hooked;
        private static double _nextSnapshot;
        private static double _nextCapturePoll;
        private const string OriginalGameScene = "Assets/_Scene/Game.unity";
        private const int MaxGameViewCaptures = 4;
        private const double GameViewCaptureTimeout = 8;
        private static GameViewCapture _synchronousCapture;
        private sealed class RenderCounter { public int begins, ends, lastBegin = -1, lastEnd = -1; }
        private static readonly Dictionary<int, RenderCounter> RenderCounters = new Dictionary<int, RenderCounter>();

        [Serializable] public sealed class GameViewCapture
        {
            public string requestedUtc, completedUtc, scenePath, path, status, diagnostic, requestError;
            public double requestedEditorTime;
            public int requestedFrame, completedFrame, width, height;
            public float requestedGameTime;
            public bool editorApplicationActive, applicationFocused, runInBackground;
            public string[] cameras;
            public long fileBytes;
        }

        [Serializable] public sealed class Message
        {
            public string type;
            public string message;
            public string stackTrace;
            public int frame;
        }

        [Serializable] public sealed class ComponentState
        {
            public string type;
            public string objectName;
            public string scene;
            public bool active;
            public bool enabled;
            public string[] primitiveFields;
            public string[] existingCollectionFields;
        }

        [Serializable] public sealed class Snapshot
        {
            public double editorElapsed;
            public int frame;
            public float gameTime;
            public float timeScale;
            public bool editorPlaying;
            public bool editorPaused;
            public bool editorApplicationActive;
            public bool applicationFocused;
            public bool runInBackground;
            public string[] existingResourceDiagnostics;
            public string[] scenes;
            public string[] cameras;
            public string[] existingGameplayObjectCounts;
            public string[] existingMapAndTowerFields;
            public string[] existingInteractionFields;
            public string[] existingUIRenderLayers;
            public string[] editorWindows;
            public string[] cameraRenderCounters;
            public ComponentState[] managers;
            public FrameworkState framework;
        }

        [Serializable] public sealed class ModuleState
        {
            public string type;
            public string[] fields;
        }

        [Serializable] public sealed class FrameworkState
        {
            public bool observedExistingEntry;
            public string diagnostic;
            public string[] entryFields;
            public ModuleState[] modules;
            public string[] existingAudioAndConfigFields;
            public string[] existingTimeFields;
            public string[] existingLocalSessionFields;
            public string[] existingSaveModelFields;
        }

        [Serializable] public sealed class Observation
        {
            public string startedUtc;
            public string reportStem;
            public string scenePath;
            public string unityVersion;
            public string status;
            public string editorGameViewRequest;
            public double startedEditorTime;
            public double enteredPlayEditorTime;
            public double duration;
            public bool batchMode;
            public bool coreGameplayAccepted;
            public AssemblyObservation[] assembliesAtLaunch;
            public AssemblyObservation[] assembliesInPlay;
            public List<Message> errors = new List<Message>();
            public List<Snapshot> snapshots = new List<Snapshot>();
            public List<GameViewCapture> captures = new List<GameViewCapture>();
            public double firstGameEditorTime = -1;
            public double nextGameViewCaptureEditorTime;
        }

        [Serializable] public sealed class AssemblyObservation
        {
            public string name, loadedModuleVersionId, location, diskSha256, diskWriteUtc, diagnostic;
        }

        static ObserveRecoveryPlayMode()
        {
            _path = SessionState.GetString(SessionKey, "");
            if (string.IsNullOrEmpty(_path) || !File.Exists(_path)) return;
            _report = JsonUtility.FromJson<Observation>(File.ReadAllText(_path));
            if (_report != null) Hook();
        }

        // Launch without -quit: this method exits batchmode after leaving PlayMode.
        public static void Run()
        {
            string[] args = Environment.GetCommandLineArgs();
            string scene = Argument(args, "-recoveryScene", "Assets/gameres/bundleres/Scene/MineGameMain.unity");
            string workspace = Directory.GetParent(Directory.GetParent(Application.dataPath).FullName).Parent.FullName;
            string ledger = Path.Combine(workspace, "work", "recovery-ledger");
            string path = Argument(args, "-recoveryReportPath", Path.Combine(ledger, "unity-play-observation.json"));
            if (!double.TryParse(Argument(args, "-recoveryPlaySeconds", "30"), NumberStyles.Float,
                    CultureInfo.InvariantCulture, out double duration))
                throw new ArgumentException("Observation duration must be a number.");
            RunConfigured(scene, path, duration);
        }

        // The interactive Editor bridge uses the same observation and normal domain reload.
        // A separate name keeps Unity's parameterless executeMethod lookup unambiguous.
        public static void RunConfigured(string scene, string path, double duration, bool discardUnsavedEdits = false)
        {
            if (EditorApplication.isPlayingOrWillChangePlaymode)
                throw new InvalidOperationException("A PlayMode session is already active.");
            string workspace = Directory.GetParent(Directory.GetParent(Application.dataPath).FullName).Parent.FullName;
            string ledger = Path.Combine(workspace, "work", "recovery-ledger");
            _path = Path.GetFullPath(path);
            if (!_path.StartsWith(Path.GetFullPath(ledger) + Path.DirectorySeparatorChar, StringComparison.OrdinalIgnoreCase))
                throw new ArgumentException("Observation report must stay inside the recovery work ledger.");
            if (!scene.StartsWith("Assets/", StringComparison.Ordinal) || !scene.EndsWith(".unity", StringComparison.Ordinal)
                || !File.Exists(Path.Combine(Directory.GetParent(Application.dataPath).FullName, scene)))
                throw new ArgumentException("The requested original scene does not exist: " + scene);
            if (double.IsNaN(duration) || double.IsInfinity(duration) || duration < 10 || duration > 600)
                throw new ArgumentException("Observation duration must be from 10 to 600 seconds.");
            if (!discardUnsavedEdits && !Application.isBatchMode && Enumerable.Range(0, SceneManager.sceneCount)
                    .Any(i => SceneManager.GetSceneAt(i).isDirty))
                throw new InvalidOperationException("An open scene has unsaved edits; interactive observation was not started.");
            _report = new Observation
            {
                startedUtc = DateTime.UtcNow.ToString("o"), scenePath = scene,
                reportStem = Path.GetFileNameWithoutExtension(_path) + "-"
                    + DateTime.UtcNow.ToString("yyyyMMddTHHmmssfffZ", CultureInfo.InvariantCulture)
                    + "-" + Guid.NewGuid().ToString("N"),
                unityVersion = Application.unityVersion, status = "entering_playmode",
                startedEditorTime = EditorApplication.timeSinceStartup, duration = duration,
                batchMode = Application.isBatchMode, coreGameplayAccepted = false,
                assembliesAtLaunch = ObserveLoadedAssemblies()
            };
            Directory.CreateDirectory(ledger);
            SessionState.SetString(SessionKey, _path);
            Save();
            Hook();
            EditorSceneManager.OpenScene(scene, OpenSceneMode.Single);
            // Normal Editor presentation only; no scene object or game state is changed.
            _report.editorGameViewRequest = "Window/General/Game="
                + EditorApplication.ExecuteMenuItem("Window/General/Game");
            Save();
            EditorApplication.EnterPlaymode();
        }

        private static string Argument(string[] args, string key, string fallback)
        {
            int index = Array.IndexOf(args, key);
            return index >= 0 && index + 1 < args.Length ? args[index + 1] : fallback;
        }

        private static void Hook()
        {
            if (_hooked) return;
            _hooked = true;
            Application.logMessageReceived += OnMessage;
            EditorApplication.playModeStateChanged += OnPlayModeState;
            EditorApplication.update += Update;
            RenderPipelineManager.beginCameraRendering += OnBeginCameraRendering;
            RenderPipelineManager.endCameraRendering += OnEndCameraRendering;
        }

        private static void OnBeginCameraRendering(ScriptableRenderContext context, Camera camera)
        {
            if (_report == null || camera == null || !camera.gameObject.scene.IsValid()) return;
            if (!RenderCounters.TryGetValue(camera.GetInstanceID(), out RenderCounter counter))
                RenderCounters.Add(camera.GetInstanceID(), counter = new RenderCounter());
            counter.begins++; counter.lastBegin = Time.frameCount;
        }

        private static void OnEndCameraRendering(ScriptableRenderContext context, Camera camera)
        {
            if (_report == null || camera == null || !camera.gameObject.scene.IsValid()) return;
            if (!RenderCounters.TryGetValue(camera.GetInstanceID(), out RenderCounter counter))
                RenderCounters.Add(camera.GetInstanceID(), counter = new RenderCounter());
            counter.ends++; counter.lastEnd = Time.frameCount;
        }

        private static void OnMessage(string message, string stackTrace, LogType type)
        {
            if (_report == null || _report.errors.Count >= 50) return;
            if (type != LogType.Error && type != LogType.Exception && type != LogType.Assert) return;
            if (_synchronousCapture != null)
            {
                _synchronousCapture.requestError = type + ": " + message;
                return;
            }
            _report.errors.Add(new Message { type = type.ToString(), message = message,
                stackTrace = stackTrace, frame = Time.frameCount });
        }

        private static void OnPlayModeState(PlayModeStateChange state)
        {
            if (_report == null) return;
            if (state == PlayModeStateChange.EnteredPlayMode)
            {
                _report.enteredPlayEditorTime = EditorApplication.timeSinceStartup;
                _report.status = "observing";
                _report.assembliesInPlay = ObserveLoadedAssemblies();
                Save();
            }
            else if (state == PlayModeStateChange.ExitingPlayMode)
            {
                if (_report.status == "observing") _report.status = "playmode_ended_early";
                Save();
            }
        }

        private static void Update()
        {
            if (_report == null) return;
            double now = EditorApplication.timeSinceStartup;
            if (now >= _nextCapturePoll)
            {
                if (PollGameViewCaptures(now)) Save();
                _nextCapturePoll = now + 0.5;
            }
            if (_report.status == "entering_playmode")
            {
                if (now - _report.startedEditorTime > 90) Finish("playmode_entry_timeout");
                return;
            }
            if (_report.status == "observing")
            {
                if (now >= _nextSnapshot)
                {
                    Capture(now);
                    _nextSnapshot = now + 2;
                    Save();
                }
                if (_report.errors.Count > 0)
                {
                    Capture(now); // Preserve the reached modules at the actual failure boundary.
                    Finish("runtime_error_observed");
                }
                else if (now - _report.enteredPlayEditorTime >= _report.duration)
                    Finish("observation_completed_core_gameplay_not_accepted");
                return;
            }
            if (EditorApplication.isPlayingOrWillChangePlaymode) return;
            bool batch = _report.batchMode;
            int exit = _report.status == "observation_completed_core_gameplay_not_accepted" ? 0 : 2;
            Save();
            SessionState.EraseString(SessionKey);
            Application.logMessageReceived -= OnMessage;
            EditorApplication.playModeStateChanged -= OnPlayModeState;
            EditorApplication.update -= Update;
            RenderPipelineManager.beginCameraRendering -= OnBeginCameraRendering;
            RenderPipelineManager.endCameraRendering -= OnEndCameraRendering;
            _hooked = false;
            _report = null;
            if (batch) EditorApplication.Exit(exit);
        }

        private static void Finish(string status)
        {
            PollGameViewCaptures(EditorApplication.timeSinceStartup);
            _report.status = status;
            _report.coreGameplayAccepted = false;
            Save();
            if (EditorApplication.isPlaying) EditorApplication.ExitPlaymode();
            else if (EditorApplication.isPlayingOrWillChangePlaymode) EditorApplication.isPlaying = false;
        }

        private static void Capture(double now)
        {
            PollGameViewCaptures(now);
            string[] scenes = Enumerable.Range(0, SceneManager.sceneCount)
                .Select(i => SceneManager.GetSceneAt(i).path).ToArray();
            var managers = Resources.FindObjectsOfTypeAll<MonoBehaviour>()
                .Where(c => c != null && c.gameObject.scene.IsValid() && c.gameObject.scene.isLoaded)
                .Where(c => c.GetType().Name.Contains("Manager") || c.GetType().Name == "GameLauncher"
                    || c.GetType().Name == "LoginControl" || c.GetType().Name == "GameStartEntry"
                    || c.GetType().Name == "CameraMoveBehaviour" || c.GetType().Name == "BattleFPSController")
                .Select(c => new ComponentState { type = c.GetType().FullName, objectName = c.name,
                    scene = c.gameObject.scene.path, active = c.gameObject.activeInHierarchy,
                    enabled = c.enabled, primitiveFields = PrimitiveFields(c),
                    existingCollectionFields = ExistingCollectionFields(c) }).ToArray();
            var snapshot = new Snapshot { editorElapsed = now - _report.startedEditorTime,
                frame = Time.frameCount, gameTime = Time.time, timeScale = Time.timeScale,
                existingGameplayObjectCounts = Resources.FindObjectsOfTypeAll<MonoBehaviour>()
                    .Where(c => c != null && c.gameObject.scene.IsValid() && c.gameObject.scene.isLoaded)
                    .Where(c => c.GetType().Name == "HexBehaviour" || c.GetType().Name == "GenerateHexBehaviour"
                        || c.GetType().Name.EndsWith("RoleBehaviour", StringComparison.Ordinal)
                        || c.GetType().Name.EndsWith("ArchitectureBehaviour", StringComparison.Ordinal)
                        || c.GetType().Name == "MainTowerBehaviour")
                    .GroupBy(c => c.GetType().FullName).Select(g => g.Key + ".Count=" + g.Count()).ToArray(),
                cameras = Resources.FindObjectsOfTypeAll<Camera>().Where(c => c != null && c.gameObject.scene.IsValid() && c.gameObject.scene.isLoaded)
                    .Select(c => c.name + ";enabled=" + c.enabled + ";orthographic=" + c.orthographic
                        + ";size=" + c.orthographicSize.ToString("R", CultureInfo.InvariantCulture)
                        + ";near=" + c.nearClipPlane.ToString("R", CultureInfo.InvariantCulture)
                        + ";far=" + c.farClipPlane.ToString("R", CultureInfo.InvariantCulture)
                        + ";depth=" + c.depth + ";clear=" + c.clearFlags + ";culling=" + c.cullingMask
                        + ";display=" + c.targetDisplay + ";target=" + (c.targetTexture == null ? "<null>" : c.targetTexture.name)
                        + ";pixelRect=" + c.pixelRect).ToArray(),
                editorPlaying = EditorApplication.isPlaying, editorPaused = EditorApplication.isPaused,
                editorApplicationActive = UnityEditorInternal.InternalEditorUtility.isApplicationActive,
                applicationFocused = Application.isFocused, runInBackground = Application.runInBackground,
                existingResourceDiagnostics = ObserveExistingResourceOperation(),
                existingMapAndTowerFields = ObserveExistingMapAndTowers(),
                existingInteractionFields = ObserveExistingInteractionFields(),
                existingUIRenderLayers = ObserveExistingUIRenderLayers(),
                editorWindows = ObserveExistingEditorWindows(),
                cameraRenderCounters = ObserveCameraRenderCounters(),
                scenes = scenes, managers = managers, framework = ObserveExistingFramework() };
            _report.snapshots.Add(snapshot);
            RequestGameViewCapture(now, snapshot);
        }

        private static string[] ObserveExistingUIRenderLayers()
        {
            var rows = new List<string>();
            foreach (Canvas canvas in Resources.FindObjectsOfTypeAll<Canvas>()
                .Where(c => c != null && c.gameObject.scene.IsValid() && c.gameObject.scene.isLoaded)
                .OrderByDescending(c => c.sortingOrder).Take(100))
                rows.Add("Canvas=" + ExistingTransformPath(canvas.transform)
                    + ";scene=" + canvas.gameObject.scene.name + ";enabled=" + canvas.enabled
                    + ";active=" + canvas.gameObject.activeInHierarchy + ";mode=" + canvas.renderMode
                    + ";sorting=" + canvas.sortingOrder + ";overrideSorting=" + canvas.overrideSorting
                    + ";lossyScale=" + canvas.transform.lossyScale
                    + ";camera=" + (canvas.worldCamera == null ? "<null>" : canvas.worldCamera.name));
            // Inspect existing Unity component fields only. This does not call
            // game getters, hide a loading object, or alter a completion gate.
            foreach (MonoBehaviour component in Resources.FindObjectsOfTypeAll<MonoBehaviour>()
                .Where(c => c != null && c.gameObject.scene.IsValid() && c.gameObject.scene.isLoaded))
            {
                string path = ExistingTransformPath(component.transform);
                if (path.IndexOf("load", StringComparison.OrdinalIgnoreCase) < 0
                    && path.IndexOf("splash", StringComparison.OrdinalIgnoreCase) < 0) continue;
                rows.Add("LoadingComponent=" + component.GetType().FullName + ";path=" + path
                    + ";scene=" + component.gameObject.scene.name + ";enabled=" + component.enabled
                    + ";active=" + component.gameObject.activeInHierarchy);
                foreach (string fieldName in new[] { "m_Sprite", "m_Texture" })
                {
                    FieldInfo field = component.GetType().GetField(fieldName,
                        BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                    if (field == null) continue;
                    var value = field.GetValue(component) as UnityEngine.Object;
                    rows.Add("LoadingGraphic=" + path + ";" + fieldName + "="
                        + (value == null ? "<null>" : value.name));
                }
                if (rows.Count >= 300) break;
            }
            int graphicCount = 0;
            foreach (MonoBehaviour component in Resources.FindObjectsOfTypeAll<MonoBehaviour>()
                .Where(c => c != null && c.gameObject.scene.IsValid() && c.gameObject.scene.isLoaded
                    && c.gameObject.activeInHierarchy && c.enabled))
            {
                bool graphic = false;
                for (Type type = component.GetType(); type != null; type = type.BaseType)
                    if (type.FullName == "UnityEngine.UI.Graphic") { graphic = true; break; }
                if (!graphic) continue;
                CanvasRenderer renderer = component.GetComponent<CanvasRenderer>();
                string detail = "ActiveGraphic=" + ExistingTransformPath(component.transform)
                    + ";type=" + component.GetType().FullName + ";lossyScale=" + component.transform.lossyScale
                    + ";cull=" + (renderer == null ? "<none>" : renderer.cull.ToString());
                foreach (string name in new[] { "m_Sprite", "m_OverrideSprite", "m_Texture", "m_Material" })
                    for (Type type = component.GetType(); type != null; type = type.BaseType)
                    {
                        FieldInfo field = type.GetField(name, BindingFlags.Instance | BindingFlags.Public
                            | BindingFlags.NonPublic | BindingFlags.DeclaredOnly);
                        if (field == null) continue;
                        var value = field.GetValue(component) as UnityEngine.Object;
                        detail += ";" + name + "=" + (value == null ? "<null>" : value.name);
                        break;
                    }
                rows.Add(detail);
                if (++graphicCount >= 200) break;
            }
            return rows.ToArray();
        }

        private static string[] ObserveCameraRenderCounters()
        {
            var rows = new List<string>();
            rows.Add("PipelineAsset=" + (GraphicsSettings.currentRenderPipeline == null ? "<null>" : GraphicsSettings.currentRenderPipeline.name)
                + ";pipelineType=" + (RenderPipelineManager.currentPipeline == null ? "<null>" : RenderPipelineManager.currentPipeline.GetType().FullName)
                + ";quality=" + QualitySettings.GetQualityLevel());
            foreach (Camera camera in Resources.FindObjectsOfTypeAll<Camera>()
                .Where(c => c != null && c.gameObject.scene.IsValid() && c.gameObject.scene.isLoaded))
            {
                RenderCounters.TryGetValue(camera.GetInstanceID(), out RenderCounter counter);
                string detail = "Camera=" + ExistingTransformPath(camera.transform) + "#" + camera.GetInstanceID()
                    + ";beginCount=" + (counter == null ? 0 : counter.begins)
                    + ";endCount=" + (counter == null ? 0 : counter.ends)
                    + ";lastBeginFrame=" + (counter == null ? -1 : counter.lastBegin)
                    + ";lastEndFrame=" + (counter == null ? -1 : counter.lastEnd);
                foreach (Component component in camera.GetComponents<Component>())
                {
                    if (component == null || component.GetType().FullName != "UnityEngine.Rendering.Universal.UniversalAdditionalCameraData") continue;
                    foreach (string name in new[] { "m_CameraType", "m_RendererIndex", "m_ClearDepth", "m_Cameras" })
                    {
                        FieldInfo field = component.GetType().GetField(name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                        object value = field?.GetValue(component);
                        if (value is System.Collections.IList cameras)
                            detail += ";" + name + "=" + string.Join(",", cameras.Cast<object>().Select(c => c is Camera cam ? ExistingTransformPath(cam.transform) : "<null>"));
                        else detail += ";" + name + "=" + (value == null ? "<null>" : Convert.ToString(value, CultureInfo.InvariantCulture));
                    }
                }
                rows.Add(detail);
            }
            return rows.ToArray();
        }

        private static string[] ObserveExistingEditorWindows()
        {
            var rows = new List<string>();
            foreach (EditorWindow window in Resources.FindObjectsOfTypeAll<EditorWindow>())
            {
                if (window == null) continue;
                object host = typeof(EditorWindow).GetField("m_Parent", BindingFlags.Instance | BindingFlags.NonPublic)?.GetValue(window);
                object selected = host?.GetType().GetProperty("actualView",
                    BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)?.GetValue(host);
                rows.Add(window.GetType().FullName + ";title=" + window.titleContent.text
                    + ";focused=" + ReferenceEquals(EditorWindow.focusedWindow, window)
                    + ";selectedHostView=" + ReferenceEquals(selected, window)
                    + ";position=" + window.position);
            }
            return rows.ToArray();
        }

        private static string ExistingTransformPath(Transform transform)
        {
            string path = transform.name;
            for (Transform parent = transform.parent; parent != null; parent = parent.parent)
                path = parent.name + "/" + path;
            return path;
        }

        private static void RequestGameViewCapture(double now, Snapshot snapshot)
        {
            // Observe the original scene only; this request never renders a camera,
            // changes a scene/gate, or waits for Game View/end-of-frame completion.
            if (!snapshot.editorPlaying || snapshot.editorPaused || string.IsNullOrEmpty(_report.reportStem)
                || !snapshot.scenes.Contains(OriginalGameScene)
                || !SceneManager.GetSceneByPath(OriginalGameScene).isLoaded) return;
            if (_report.firstGameEditorTime < 0)
            {
                _report.firstGameEditorTime = now;
                _report.nextGameViewCaptureEditorTime = now + 2;
                return;
            }
            // Preserve the first three existing captures and add one later real Game View image.
            if (_report.captures.Count == 3 && now - _report.firstGameEditorTime < 60) return;
            if (_report.captures.Count >= MaxGameViewCaptures || now < _report.nextGameViewCaptureEditorTime
                || _report.captures.Any(c => c.status == "capture_pending")) return;
            var capture = new GameViewCapture
            {
                requestedUtc = DateTime.UtcNow.ToString("o"), requestedEditorTime = now,
                requestedFrame = snapshot.frame, requestedGameTime = snapshot.gameTime,
                scenePath = OriginalGameScene, cameras = snapshot.cameras,
                editorApplicationActive = snapshot.editorApplicationActive,
                applicationFocused = snapshot.applicationFocused, runInBackground = snapshot.runInBackground,
                path = Path.Combine(Path.GetDirectoryName(_path), _report.reportStem
                    + "-gameview-" + (_report.captures.Count + 1).ToString("00") + ".png"),
                status = "capture_pending", diagnostic = "Waiting for Unity Game View PNG."
            };
            _report.captures.Add(capture);
            _report.nextGameViewCaptureEditorTime = now + 4;
            try
            {
                _synchronousCapture = capture;
                ReadOnlyRenderTargetProbe108.RequestPair(capture.path, captureAction =>
                {
                    try { _synchronousCapture = capture; captureAction(); }
                    catch (Exception exception)
                    {
                        capture.requestError = exception.GetType().Name + ": " + exception.Message;
                        capture.diagnostic = "Paired capture failed: " + capture.requestError;
                    }
                    finally { _synchronousCapture = null; }
                });
            }
            catch (Exception exception)
            {
                // A diagnostic failure must never stop original initialization or Finish.
                capture.requestError = exception.GetType().Name + ": " + exception.Message;
                capture.diagnostic = "Request failed; awaiting bounded file poll: " + capture.requestError;
            }
            finally { _synchronousCapture = null; }
        }

        private static bool PollGameViewCaptures(double now)
        {
            if (_report.captures == null) return false;
            bool changed = false;
            foreach (GameViewCapture capture in _report.captures.Where(c => c.status == "capture_pending"))
            {
                Texture2D decoded = null;
                string diagnostic = string.IsNullOrEmpty(capture.requestError) ? "Waiting for Unity Game View PNG."
                    : "CaptureScreenshot request failed: " + capture.requestError;
                try
                {
                    if (File.Exists(capture.path))
                    {
                        var info = new FileInfo(capture.path);
                        // File availability is asynchronous. Avoid decoding an empty,
                        // partially written or unexpectedly large file on Editor update.
                        if (info.Length > 0 && info.Length <= 64 * 1024 * 1024)
                        {
                            byte[] png = File.ReadAllBytes(capture.path);
                            byte[] signature = { 137, 80, 78, 71, 13, 10, 26, 10 };
                            byte[] end = { 0, 0, 0, 0, 73, 69, 78, 68, 174, 66, 96, 130 };
                            if (png.Length >= 33 && png.Take(8).SequenceEqual(signature)
                                && png.Skip(png.Length - 12).SequenceEqual(end))
                            {
                                decoded = new Texture2D(2, 2, TextureFormat.RGBA32, false);
                                bool decodedImage;
                                try
                                {
                                    _synchronousCapture = capture;
                                    decodedImage = ImageConversion.LoadImage(decoded, png, true);
                                }
                                finally { _synchronousCapture = null; }
                                if (decodedImage && decoded.width > 0 && decoded.height > 0)
                                {
                                    capture.width = decoded.width; capture.height = decoded.height;
                                    capture.fileBytes = png.LongLength;
                                    capture.completedUtc = DateTime.UtcNow.ToString("o");
                                    capture.completedFrame = Time.frameCount;
                                    capture.status = "capture_complete";
                                    capture.diagnostic = "Existing PNG decoded successfully; no gameplay acceptance inferred.";
                                    changed = true;
                                    continue;
                                }
                                diagnostic = "PNG exists but Unity has not decoded it successfully.";
                            }
                            else diagnostic = "PNG file exists but is incomplete or has an invalid signature.";
                        }
                        else diagnostic = "PNG file is empty or exceeds the 64 MiB observation limit.";
                    }
                }
                catch (Exception exception) { diagnostic = exception.GetType().Name + ": " + exception.Message; }
                finally { if (decoded != null) UnityEngine.Object.DestroyImmediate(decoded); }
                if (now - capture.requestedEditorTime >= GameViewCaptureTimeout)
                {
                    capture.status = "capture_timeout";
                    diagnostic = "No decodable PNG within 8 editor seconds. " + diagnostic;
                    changed = true;
                }
                if (capture.diagnostic != diagnostic) { capture.diagnostic = diagnostic; changed = true; }
            }
            return changed;
        }

        private static string[] ObserveExistingMapAndTowers()
        {
            var rows = new List<string>();
            const BindingFlags fields = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
            MonoBehaviour[] existing = Resources.FindObjectsOfTypeAll<MonoBehaviour>()
                .Where(c => c != null && c.gameObject.scene.IsValid() && c.gameObject.scene.isLoaded).ToArray();
            foreach (MonoBehaviour component in existing.Where(c => c.GetType().Name == "GenerateHexBehaviour"
                || c.GetType().Name == "MainTowerBehaviour" || c.GetType().Name == "FoundEnemyPanel"
                || c.GetType().Name == "LoadingPanel"))
            {
                string prefix = component.GetType().Name + "#" + component.GetInstanceID();
                rows.Add(prefix + ".active=" + component.gameObject.activeInHierarchy);
                rows.AddRange(PrimitiveFields(component).Select(v => prefix + "." + v));
            }
            MonoBehaviour scene = existing.FirstOrDefault(c => c.GetType().Name == "BattleGameSceneManager");
            if (scene == null) return rows.ToArray();
            string player = scene.GetType().GetField("playerMainTowerKey", fields)?.GetValue(scene) as string;
            string enemy = scene.GetType().GetField("enemyMainTowerKey", fields)?.GetValue(scene) as string;
            foreach (MonoBehaviour hex in existing.Where(c => c.GetType().Name == "HexBehaviour"))
            {
                string key = hex.GetType().GetField("key", fields)?.GetValue(hex) as string;
                if (key != player && key != enemy) continue;
                string prefix = "TowerHex[" + key + "]";
                rows.AddRange(PrimitiveFields(hex).Select(v => prefix + "." + v));
                rows.Add(prefix + ".position=" + hex.transform.position);
                foreach (string name in new[] { "_obj", "_mainTowerRes" })
                {
                    object value = hex.GetType().GetField(name, fields)?.GetValue(hex);
                    GameObject go = value as GameObject;
                    rows.Add(prefix + "." + name + "=" + (go == null ? "<null>" : go.name));
                    if (go != null) rows.Add(prefix + "." + name + ".components="
                        + string.Join(",", go.GetComponents<MonoBehaviour>().Where(c => c != null).Select(c => c.GetType().Name)));
                }
            }
            return rows.ToArray();
        }

        // Read existing fields and engine geometry only. No game getter, business method,
        // input dispatch, focus change, or gameplay state write is performed here.
        private static object InteractionRaw(object owner, string name)
        {
            if (owner == null) return null;
            for (Type type = owner.GetType(); type != null; type = type.BaseType)
            {
                FieldInfo field = type.GetField(name, BindingFlags.Instance | BindingFlags.Static
                    | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly);
                if (field != null) return field.GetValue(field.IsStatic ? null : owner);
            }
            return null;
        }

        private static string[] ObserveExistingInteractionFields()
        {
            var rows = new List<string>();
            try
            {
                MonoBehaviour[] all = Resources.FindObjectsOfTypeAll<MonoBehaviour>()
                    .Where(c => c != null && c.gameObject.scene.IsValid() && c.gameObject.scene.isLoaded).ToArray();
                MonoBehaviour core = all.FirstOrDefault(c => c.GetType().FullName == "GameModule.CoreGameManager");
                MonoBehaviour battle = all.FirstOrDefault(c => c.GetType().FullName == "GameModule.BattleGameManager");
                rows.Add("Interaction.Core.Gaming=" + (InteractionRaw(core, "_003CGaming_003Ek__BackingField") ?? "<missing>"));
                rows.Add("Interaction.Core.ShowHexDesPanel=" + (InteractionRaw(core, "ShowHexDesPanel") ?? "<missing>"));
                rows.Add("Interaction.Battle.hasCoin=" + (InteractionRaw(battle, "hasCoin") ?? "<missing>"));
                rows.Add("Interaction.Battle.openHexCount=" + (InteractionRaw(battle, "openHexCount") ?? "<missing>"));
                foreach (EditorWindow view in Resources.FindObjectsOfTypeAll<EditorWindow>()
                    .Where(v => v != null && v.GetType().FullName == "UnityEditor.GameView"))
                    rows.Add("Interaction.GameView.instanceId=" + view.GetInstanceID()
                        + ";focused=" + (EditorWindow.focusedWindow == view) + ";position=" + view.position);
                rows.Add("Interaction.Screen=" + Screen.width + "x" + Screen.height);
                MonoBehaviour manager = all.FirstOrDefault(c => c.GetType().FullName == "CameraModule.CameraManager");
                Camera camera = InteractionRaw(manager, "_mainCamera") as Camera;
                rows.Add("Interaction.RawMainCamera=" + (camera == null ? "<null>" : camera.GetInstanceID().ToString(CultureInfo.InvariantCulture)));
                var targets = all.Where(c => c.GetType().FullName == "GameModule.HexBehaviour"
                    && c.gameObject.activeInHierarchy && InteractionRaw(c, "canOpen") is bool canOpen && canOpen
                    && InteractionRaw(c, "isOpened") is bool opened && !opened
                    && InteractionRaw(c, "isEnemyHex") is bool enemy && !enemy)
                    .OrderBy(c => InteractionRaw(c, "key") as string, StringComparer.Ordinal).Take(24).ToArray();
                rows.Add("Interaction.OpenableOwnSampleCount=" + targets.Length);
                foreach (MonoBehaviour hex in targets)
                {
                    string prefix = "Interaction.Hex[" + InteractionRaw(hex, "key") + "]";
                    foreach (string name in new[] { "key", "_id", "price", "canOpen", "isOpened", "isEnemyHex", "isBridge", "trainingLocked", "hexUIType", "hexBuildType" })
                        rows.Add(prefix + "." + name + "=" + (InteractionRaw(hex, name) ?? "<null>"));
                    Collider collider = hex.GetComponent<Collider>();
                    rows.Add(prefix + ".collider=" + (collider != null && collider.enabled) + ";layer=" + hex.gameObject.layer);
                    if (camera == null) continue;
                    Vector3 screen = camera.WorldToScreenPoint(hex.transform.position);
                    rows.Add(prefix + ".screen=" + screen.ToString("R", CultureInfo.InvariantCulture));
                    bool hit = Physics.Raycast(camera.ScreenPointToRay(screen), out RaycastHit rayHit, 100f, 1 << 13);
                    bool same = hit && rayHit.collider != null && rayHit.collider.gameObject == hex.gameObject;
                    rows.Add(prefix + ".projectionRaySameHex=" + same);
                }
                foreach (MonoBehaviour loading in all.Where(c => c.gameObject.activeInHierarchy
                    && (c.GetType().Name.IndexOf("Loading", StringComparison.OrdinalIgnoreCase) >= 0
                        || c.name.Equals("Loading", StringComparison.OrdinalIgnoreCase))).Take(12))
                    rows.Add("Interaction.ActiveLoading=" + loading.GetType().FullName + ";path=" + ExistingTransformPath(loading.transform));
            }
            catch (Exception exception) { rows.Add("Interaction.ReadOnlyError=" + exception.GetType().Name + ":" + exception.Message); }
            return rows.ToArray();
        }

        private static string[] ObserveExistingResourceOperation()
        {
            // Only fields of the provider/lease/iterator that already exist are read.
            // Task.Status is a BCL diagnostic, never a game getter or a task wait.
            var result = new List<string>();
            try
            {
                const BindingFlags instanceFields = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
                Type bridge = AppDomain.CurrentDomain.GetAssemblies()
                    .Select(a => a.GetType("GameFramework.Recovery.LocalEditorResourceBridge", false))
                    .FirstOrDefault(t => t != null);
                object provider = bridge?.GetField("<Provider>k__BackingField", BindingFlags.Static | BindingFlags.NonPublic)?.GetValue(null);
                if (provider == null) return new[] { "ExistingProvider=<null>" };
                result.AddRange(provider.GetType().GetFields(instanceFields)
                    .Where(f => f.FieldType == typeof(bool) || f.Name == "_receiptPath").Select(f => DescribeField(f, provider)));
                object lease = provider.GetType().GetField("_initializationLease", instanceFields)?.GetValue(provider);
                if (lease == null) { result.Add("ExistingLease=<null>"); return result.ToArray(); }
                result.AddRange(lease.GetType().GetFields(instanceFields)
                    .Where(f => f.FieldType.IsPrimitive || f.FieldType == typeof(string)).Select(f => DescribeField(f, lease)));
                object operation = lease.GetType().GetField("Operation", instanceFields)?.GetValue(lease);
                if (operation != null)
                    foreach (FieldInfo field in operation.GetType().GetFields(instanceFields))
                        if (field.GetValue(operation) is System.Threading.Tasks.Task task)
                            result.Add("ExistingTask." + field.Name + ".Status=" + task.Status);
            }
            catch (Exception exception) { result.Add("Diagnostic=" + exception.GetType().Name + ": " + exception.Message); }
            return result.ToArray();
        }

        private static AssemblyObservation[] ObserveLoadedAssemblies()
        {
            string[] wanted = { "GFRunning", "Assembly-CSharp", "AstarPathfindingProject", "OccupyCity.Recovery.Editor", "OccupyCity.Recovery.LocalResources.Editor" };
            var result = new List<AssemblyObservation>();
            foreach (Assembly assembly in AppDomain.CurrentDomain.GetAssemblies().Where(a => wanted.Contains(a.GetName().Name)))
            {
                var row = new AssemblyObservation { name = assembly.GetName().Name };
                try
                {
                    row.loadedModuleVersionId = assembly.ManifestModule.ModuleVersionId.ToString();
                    row.location = assembly.Location;
                    if (File.Exists(row.location))
                    {
                        using (var stream = File.OpenRead(row.location))
                        using (var hash = System.Security.Cryptography.SHA256.Create())
                            row.diskSha256 = BitConverter.ToString(hash.ComputeHash(stream)).Replace("-", "").ToLowerInvariant();
                        row.diskWriteUtc = File.GetLastWriteTimeUtc(row.location).ToString("o");
                    }
                }
                catch (Exception exception) { row.diagnostic = exception.GetType().Name + ": " + exception.Message; }
                result.Add(row);
            }
            return result.ToArray();
        }

        private static FrameworkState ObserveExistingFramework()
        {
            var state = new FrameworkState { modules = Array.Empty<ModuleState>(), entryFields = Array.Empty<string>() };
            // Inspect only the framework already reached by the original scene's Awake.
            // No GetModule/Instance/property/method invocation and no gate writes are allowed here.
            var entry = Resources.FindObjectsOfTypeAll<MonoBehaviour>().FirstOrDefault(c => c != null
                && c.gameObject.scene.IsValid() && c.GetType().FullName == "GameFramework.Base.GameStartEntry");
            if (entry == null) { state.diagnostic = "No existing GameStartEntry"; return state; }
            try
            {
                Type type = entry.GetType().Assembly.GetType("GameFramework.GameFrameEntry", false);
                if (type == null) { state.diagnostic = "GameFrameEntry type absent"; return state; }
                FieldInfo listField = type.GetField("y_0086A_0094F_0083", BindingFlags.Static | BindingFlags.NonPublic);
                var list = listField?.GetValue(null) as System.Collections.IEnumerable;
                if (list == null) { state.diagnostic = "Existing module list absent"; return state; }
                state.observedExistingEntry = true;
                state.entryFields = type.GetFields(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic)
                    .Where(f => f.FieldType.IsPrimitive || f.FieldType.IsEnum || f.FieldType == typeof(string))
                    .Select(f => DescribeField(f, null)).ToArray();
                var modules = new List<ModuleState>();
                object existingTime = null;
                foreach (object module in list)
                {
                    if (module == null || modules.Count >= 64) break;
                    if (module.GetType().FullName == "GameFramework.TimeModule") existingTime = module;
                    var fields = new List<string>();
                    for (Type current = module.GetType(); current != null && current != typeof(object); current = current.BaseType)
                        fields.AddRange(current.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly)
                            .Take(80).Select(f => DescribeField(f, module)));
                    modules.Add(new ModuleState { type = module.GetType().FullName, fields = fields.ToArray() });
                }
                state.modules = modules.ToArray();
                state.existingTimeFields = ObserveExistingTime(existingTime);
                state.existingLocalSessionFields = ObserveExistingLocalSession();
                state.existingSaveModelFields = ObserveExistingSaveModels(type.Assembly);
                state.existingAudioAndConfigFields = ObserveExistingAudioAndConfig(type.Assembly);
                state.diagnostic = "Existing BCL module collection and fields only";
            }
            catch (Exception exception)
            {
                state.diagnostic = exception.GetType().Name + ": " + exception.Message;
            }
            return state;
        }

        private static string[] ObserveExistingTime(object module)
        {
            if (module == null) return new[] { "ExistingTimeModule=<null>" };
            var rows = new List<string>();
            const BindingFlags instanceFields = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
            // Only inspect the instance already produced by the original module list.
            // Its original constructor has run; no singleton or business getter is called.
            foreach (FieldInfo field in module.GetType().GetFields(instanceFields))
            {
                object value = field.GetValue(module);
                if (value is System.Collections.ICollection collection)
                    rows.Add(field.Name + ".Count=" + collection.Count);
                if (field.Name != "loopTimers" || !(value is System.Collections.IDictionary timers)) continue;
                foreach (System.Collections.DictionaryEntry timer in timers)
                {
                    if (timer.Value == null) continue;
                    foreach (FieldInfo timerField in timer.Value.GetType().GetFields(instanceFields))
                        rows.Add("loopTimers[" + timer.Key + "]." + DescribeField(timerField, timer.Value));
                }
            }
            foreach (FieldInfo field in module.GetType().GetFields(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic))
            {
                object value = field.GetValue(null);
                if (value is DateTime date)
                    rows.Add("TimeModule." + field.Name + "=" + date.ToString("o", CultureInfo.InvariantCulture));
                else if (field.FieldType.IsPrimitive) rows.Add(DescribeField(field, null));
            }
            return rows.ToArray();
        }

        private static string[] ObserveExistingLocalSession()
        {
            var rows = new List<string>();
            const BindingFlags staticFields = BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;
            // This is reached after the original scene Awake. The explicit local
            // bootstrap has already run BeforeSceneLoad; inspect raw fields only.
            Type readySession = null;
            foreach (Assembly assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                Type session = assembly.GetType("GameFramework.Recovery.LocalEditorSession", false);
                if (session?.GetField("<IsReady>k__BackingField", staticFields)?.GetValue(null) is bool ready && ready)
                    readySession = session;
            }
            foreach (Assembly assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                Type session = assembly.GetType("GameFramework.Recovery.LocalEditorSession", false);
                if (session != null)
                    foreach (FieldInfo field in session.GetFields(staticFields))
                        if (field.FieldType.IsPrimitive || field.FieldType == typeof(string)) rows.Add(DescribeField(field, null));
                // IsReady is published by the already completed local bootstrap. Only
                // then read metadata raw fields; never call its getters or initialize it.
                Type metadata = readySession == null ? null : assembly.GetType("GameFramework.Recovery.LocalEditorPlatformMetadata", false);
                if (metadata != null)
                {
                    foreach (string name in new[] { "initialized", "designMode", "configurationPath", "configurationSha256" })
                    {
                        FieldInfo field = metadata.GetField(name, staticFields);
                        if (field != null) rows.Add(DescribeField(field, null));
                    }
                    string owner = metadata.GetField("ownerId", staticFields)?.GetValue(null) as string;
                    string sessionOwner = readySession.GetField("<LocalPlayerId>k__BackingField", staticFields)?.GetValue(null) as string;
                    rows.Add("LocalEditorPlatformMetadata.ownerMatchesSession="
                        + (owner != null && sessionOwner != null && string.Equals(owner, sessionOwner, StringComparison.Ordinal)));
                }
                Type appInfo = assembly.GetType("DBTSDK.AppInfoManager", false);
                if (appInfo != null && appInfo.TypeInitializer == null)
                {
                    var existing = appInfo.GetField("Instance", staticFields)?.GetValue(null) as UnityEngine.Component;
                    bool live = existing != null;
                    rows.Add("OriginalAppInfoManager.Instance.live=" + live);
                    if (live)
                    {
                        UnityEngine.GameObject actual = existing.gameObject;
                        rows.Add("OriginalAppInfoManager.Instance.instanceID=" + existing.GetInstanceID());
                        rows.Add("OriginalAppInfoManager.Instance.objectName=" + actual.name);
                        rows.Add("OriginalAppInfoManager.Instance.scene=" + actual.scene.name);
                        rows.Add("OriginalAppInfoManager.Instance.activeSelf=" + actual.activeSelf);
                        rows.Add("OriginalAppInfoManager.Instance.activeInHierarchy=" + actual.activeInHierarchy);
                    }
                }
                Type login = assembly.GetType("L_Tools.LoginControl", false);
                if (login != null && login.TypeInitializer == null)
                {
                    object existing = login.GetField("I", staticFields)?.GetValue(null);
                    rows.Add("OriginalLoginControl.I=" + (existing == null ? "<null>" : "existing:" + existing.GetType().FullName));
                }
                Type data = assembly.GetType("DataModule.DataManager", false);
                if (data != null && data.TypeInitializer == null)
                    foreach (FieldInfo field in data.GetFields(staticFields | BindingFlags.DeclaredOnly))
                        if (field.FieldType.IsPrimitive || field.FieldType.IsEnum) rows.Add("Original" + DescribeField(field, null));
            }
            return rows.ToArray();
        }

        private static string[] ObserveExistingSaveModels(Assembly frameworkAssembly)
        {
            var rows = new List<string>();
            const BindingFlags instanceFields = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
            // Registration precedes the currently observed framework startup. Read
            // only its original raw pool and auto-property backing fields, never I/Data.
            Type poolType = frameworkAssembly.GetType("GameFramework.DataManagerPool", false);
            object pool = poolType?.GetField("_0060_0083_00A4_00A6_0095t", BindingFlags.Static | BindingFlags.NonPublic)?.GetValue(null);
            if (pool == null) return new[] { "ExistingDataManagerPool=<null>" };
            var models = poolType.GetField("_00A3_00A3_0094ÁD_0083", instanceFields)?.GetValue(pool) as System.Collections.IDictionary;
            if (models == null) return new[] { "ExistingRegisteredModels=<null>" };
            rows.Add("ExistingRegisteredModels.Count=" + models.Count);
            foreach (System.Collections.DictionaryEntry entry in models)
            {
                object model = entry.Value;
                if (model == null || !model.GetType().Name.StartsWith("DbtSaveDataManager_", StringComparison.Ordinal)) continue;
                object data = null;
                for (Type current = model.GetType(); current != null && current != typeof(object); current = current.BaseType)
                {
                    FieldInfo backing = current.GetField("<Data>k__BackingField", instanceFields | BindingFlags.DeclaredOnly);
                    if (backing != null) { data = backing.GetValue(model); break; }
                }
                string prefix = model.GetType().Name + ".Data";
                if (data == null) { rows.Add(prefix + "=<null>"); continue; }
                rows.Add(prefix + "=" + data.GetType().FullName);
                foreach (FieldInfo field in data.GetType().GetFields(instanceFields))
                {
                    object value = field.GetValue(data);
                    if (value is System.Collections.ICollection collection)
                        rows.Add(prefix + "." + field.Name + ".Count=" + collection.Count);
                    else if (!field.FieldType.IsValueType && field.FieldType != typeof(string))
                        rows.Add(prefix + "." + field.Name + "=" + (value == null ? "<null>" : "existing:" + value.GetType().Name));
                    if ((field.Name == "userArenaDataList" || field.Name == "userResourcesDataList")
                        && value is System.Collections.IList list)
                    {
                        for (int i = 0; i < list.Count && i < 30; i++)
                        {
                            object item = list[i];
                            if (item == null) continue;
                            foreach (FieldInfo itemField in item.GetType().GetFields(instanceFields))
                                if (new[] { "arenaID", "isUnLock", "infoId", "count", "get", "use", "B_C", "B_G", "B_U" }.Contains(itemField.Name))
                                    rows.Add(prefix + "." + field.Name + "[" + i + "]." + itemField.Name + "="
                                        + Convert.ToString(itemField.GetValue(item), CultureInfo.InvariantCulture));
                        }
                    }
                }
            }
            return rows.ToArray();
        }

        private static string[] ObserveExistingAudioAndConfig(Assembly frameworkAssembly)
        {
            var rows = new List<string>();
            const BindingFlags allStatic = BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;
            const BindingFlags allInstance = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
            Type audioType = frameworkAssembly.GetType("GameFramework.AudioManager", false);
            // The reviewed AudioManager has no static constructor. Reading its raw
            // singleton field cannot allocate it or initialize a game service.
            if (audioType == null || audioType.TypeInitializer != null)
                return new[] { "AudioObserver=skipped_unproven_static_initializer" };
            object audio = audioType.GetField("r_009A_008Bn_00BC_0088", allStatic)?.GetValue(null);
            if (audio == null) return new[] { "ExistingAudioManager=<null>" };
            rows.Add("ExistingAudioManager=" + audio.GetType().FullName);
            foreach (FieldInfo field in audioType.GetFields(allInstance))
            {
                object value = field.GetValue(audio);
                rows.Add(DescribeField(field, audio));
                if (value is System.Collections.IDictionary dictionary)
                    rows.Add("AudioManager." + field.Name + ".Count=" + dictionary.Count);
                if (value is UnityEngine.GameObject go)
                    rows.Add("AudioManager." + field.Name + ".ActualObject=" + go.name + ";scene=" + go.scene.name);
                if (value is UnityEngine.AudioListener listener)
                    rows.Add("AudioManager." + field.Name + ".ActualListener=" + listener.name + ";parent="
                        + (listener.transform.parent == null ? "<null>" : listener.transform.parent.name));
            }
            // A nonnull original AudioManager has been reached only after the
            // original InitConfig callback; these two classes are already used.
            Type settingType = frameworkAssembly.GetType("GameFramework.AppSetting", false);
            FieldInfo memoryMode = settingType?.GetField("_00A0f_0085YIY", allStatic);
            if (memoryMode != null) rows.Add(DescribeField(memoryMode, null));
            Type configType = frameworkAssembly.GetType("GameFramework.ConfigRead", false);
            FieldInfo jsonMode = configType?.GetField("IsUserJsonUtility", allStatic);
            if (jsonMode != null) rows.Add(DescribeField(jsonMode, null));
            return rows.ToArray();
        }

        private static string DescribeField(FieldInfo field, object instance)
        {
            object value = field.GetValue(instance);
            string label = field.DeclaringType.Name + "." + field.Name + "=";
            if (value == null) return label + "<null>";
            if (field.FieldType.IsPrimitive || field.FieldType.IsEnum || field.FieldType == typeof(string))
                return label + Convert.ToString(value, CultureInfo.InvariantCulture);
            if (value is Delegate callback)
                return label + "delegate:" + callback.Method.DeclaringType.FullName + "." + callback.Method.Name;
            return label + "reference:" + value.GetType().FullName;
        }

        private static string[] PrimitiveFields(MonoBehaviour component)
        {
            // Reading fields does not execute game property getters or singleton accessors.
            return component.GetType().GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                .Where(f => f.FieldType.IsPrimitive || f.FieldType.IsEnum || f.FieldType == typeof(string))
                .Take(40).Select(f => f.Name + "=" + Convert.ToString(f.GetValue(component), CultureInfo.InvariantCulture)).ToArray();
        }

        private static string[] ExistingCollectionFields(MonoBehaviour component)
        {
            // Only count existing BCL collections. Do not enumerate game objects,
            // invoke game getters, or create a singleton to obtain a diagnostic.
            var rows = new List<string>();
            foreach (FieldInfo field in component.GetType().GetFields(
                BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
            {
                if (!typeof(System.Collections.ICollection).IsAssignableFrom(field.FieldType)) continue;
                object value = field.GetValue(component);
                if (value == null) rows.Add(field.Name + "=<null>");
                else if (value.GetType().IsArray || value.GetType().Assembly == typeof(List<>).Assembly)
                    rows.Add(field.Name + ".Count=" + ((System.Collections.ICollection)value).Count);
            }
            return rows.ToArray();
        }

        private static void Save()
        {
            if (_report != null && !string.IsNullOrEmpty(_path))
                File.WriteAllText(_path, JsonUtility.ToJson(_report, true));
        }
    }
}
