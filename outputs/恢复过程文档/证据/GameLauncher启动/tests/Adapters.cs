using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public static class Env
{
    public static readonly List<string> Trace=new();
    public static readonly Dictionary<string,TaskCompletionSource> Held=new();
    public static readonly List<Task> Forgotten=new();
    public static Task Begin(string name) { Trace.Add(name); return Held.TryGetValue(name,out var task)?task.Task:Task.CompletedTask; }
    public static void Hold(params string[] names) { foreach(var name in names) Held[name]=new(); }
    public static void Release(string name) => Held[name].SetResult();
    public static void Reset() { Trace.Clear(); Held.Clear(); Forgotten.Clear(); TestTasks.Pending.Clear(); DataModule.DataManager.Instance.LoadDataCompleted=true; LocalizationModule.Runtime.CustomBundlesManager.Instance.PreloadTaskCompleted=true; L_Tools.LoginControl.I.Curloginstate=L_Tools.LoginState.Pending; DbtSaveDataManager_PlayerCoreData.I.Data.firstEnterGameTime=new DateTime(2020,1,1); DbtSaveDataManager_PlayerGuideData.I.Data.isFirstThroghGame=true; EventModule.EventManager.Instance.Callback=null; UnityEngine.SystemInfo.systemMemorySize=4096; UnityEngine.SystemInfo.supportsComputeShaders=true; UnityEngine.Rendering.GraphicsSettings.currentRenderPipeline=null; UnityEngine.Camera.Cameras=Array.Empty<UnityEngine.Camera>(); }
}
public static class TestTasks
{
    public static readonly List<(Func<bool> predicate,TaskCompletionSource source)> Pending=new();
    public static Task WaitUntil(Func<bool> predicate) { var source=new TaskCompletionSource(); Pending.Add((predicate,source)); Env.Trace.Add("WaitUntil"); return source.Task; }
    public static void Tick() { foreach(var item in Pending.ToArray()) if(item.predicate()) { Pending.Remove(item); item.source.SetResult(); } }
    public static void Forget(this Task task) => Env.Forgotten.Add(task);
}
namespace UnityEngine
{
    public class Object { public string name; }
    public class Transform { public Transform Parent; public void SetParent(Transform parent) { Parent=parent; Env.Trace.Add("SetParent"); } }
    public class MonoBehaviour : Object { public Transform transform=new(); }
    public static class Debug { public static void Log(object value) => Env.Trace.Add("Log:"+value); public static void LogWarning(object value) => Env.Trace.Add("Warn:"+value); }
    public static class Time { public static float time=3f; }
    public static class SystemInfo { public static int systemMemorySize; public static bool supportsComputeShaders; }
    public static class Application { public static int targetFrameRate; }
    public static class Mathf { public static float Max(float a,float b)=>Math.Max(a,b); public static int Min(int a,int b)=>Math.Min(a,b); }
    public class Camera : Object { public static Camera[] Cameras=Array.Empty<Camera>(); public static int allCamerasCount=>Cameras.Length; public static int GetAllCameras(Camera[] result) { Cameras.CopyTo(result,0); return Cameras.Length; } public Rendering.Universal.UniversalAdditionalCameraData Data=new(); }
}
namespace UnityEngine.Rendering { public static class GraphicsSettings { public static object currentRenderPipeline; } }
namespace UnityEngine.Rendering.Universal
{
    public class UniversalRenderPipelineAsset : UnityEngine.Object
    {
        public float renderScale; public int msaaSampleCount; public float shadowDistance;
        public ScriptableRendererData Direct;
        internal ScriptableRendererData scriptableRendererData=>Direct;
        private ScriptableRendererData[] m_RendererDataList;
        private int m_DefaultRendererIndex;
        private bool m_MainLightShadowsSupported=true,m_AdditionalLightShadowsSupported=true,m_SoftShadowsSupported=true,m_AnyShadowsSupported=true;
        public void SetFallback(ScriptableRendererData[] list,int index) {m_RendererDataList=list;m_DefaultRendererIndex=index;}
        public bool AnyShadow=>m_MainLightShadowsSupported||m_AdditionalLightShadowsSupported||m_SoftShadowsSupported||m_AnyShadowsSupported;
    }
    public class ScriptableRendererData : UnityEngine.Object { public List<ScriptableRendererFeature> rendererFeatures=new(); }
    public class ScriptableRendererFeature : UnityEngine.Object {public bool active=true; public void SetActive(bool value)=>active=value;}
    public enum AntialiasingMode {None, FXAA}
    public class UniversalAdditionalCameraData { public bool renderPostProcessing=true; public AntialiasingMode antialiasing=AntialiasingMode.FXAA; }
    public static class CameraExtensions { public static UniversalAdditionalCameraData GetUniversalAdditionalCameraData(this UnityEngine.Camera camera)=>camera.Data; }
}
public class CheatControl { public static CheatControl Instance {get;}=new(); public void Init()=>Env.Trace.Add("CheatControl"); }
public class DbtSaveDataManager_PlayerCoreData { public static DbtSaveDataManager_PlayerCoreData I {get;}=new(); public DataModule.PlayerCoreData Data=new(); public void Save()=>Env.Trace.Add("Save"); }
public class DbtSaveDataManager_PlayerGuideData {public static DbtSaveDataManager_PlayerGuideData I {get;}=new(); public DataModule.PlayerGuideData Data=new();}
namespace DataModule
{
    public class PlayerCoreData {public DateTime firstEnterGameTime;}
    public class PlayerGuideData {public bool isFirstThroghGame;}
    public class DataManager {public static DataManager Instance {get;}=new(); public bool LoadDataCompleted; public Task Init()=>Env.Begin("DataManager"); public Task LoadConfig()=>Env.Begin("LoadConfig"); public Task LoadData()=>Env.Begin("LoadData");}
}
namespace AssetsModule { public class AssetsManager : UnityEngine.MonoBehaviour { public static AssetsManager Instance {get;}=new(); public bool initcomplete; } }
namespace EventModule
{
    public class EventManager { public static EventManager Instance {get;}=new(); public Action<object> Callback; public Task Init()=>Env.Begin("EventManager"); public void StartListening(string name,Action<object> callback) {Env.Trace.Add("Listen:"+name);Callback+=callback;} public void StopListening(string name,Action<object> callback) {Env.Trace.Add("Stop:"+name);Callback-=callback;} public void Fire()=>Callback?.Invoke(null); }
}
namespace L_Tools {public enum LoginState {Pending,Success,Fail} public class LoginControl { public static LoginControl I {get;}=new(); public LoginState Curloginstate;}}
namespace LoadingModule {public class LoadingManager {public static LoadingManager Instance {get;}=new(); public void StartLoading()=>Env.Trace.Add("StartLoading"); public void AddCurrentMaxProgress(float value)=>Env.Trace.Add("Progress:"+value.ToString("0.00",System.Globalization.CultureInfo.InvariantCulture));}}
namespace SDKModule {public class ABTestManager {public static ABTestManager Instance {get;}=new(); public Task Init(params object[] args) { if(args.Length!=0) throw new Exception("ABTest args"); return Env.Begin("ABTestManager"); }}}
namespace LocalizationModule.Runtime {public class CustomBundlesManager {public static CustomBundlesManager Instance {get;}=new(); public bool PreloadTaskCompleted; public Task Init()=>Env.Begin("CustomBundlesManager");}}
namespace TimeModuleO {public class TimeManager {public static TimeManager Instance {get;}=new(); public Task Init()=>Env.Begin("TimeManager"); public DateTime GetNetworkTime(bool flag) {Env.Trace.Add("NetworkTime:"+flag);return new DateTime(2026,10,19,10,0,0,DateTimeKind.Utc);}}}
namespace UIFramework {public class UIPanel {} public class UIManager {public static UIManager Instance {get;}=new(); public Task Init()=>Env.Begin("UIManager"); public async Task<UIPanel> GetPanel(string path) {Env.Trace.Add("PanelPath:"+path);await Env.Begin("GetPanel");return new();}}}
