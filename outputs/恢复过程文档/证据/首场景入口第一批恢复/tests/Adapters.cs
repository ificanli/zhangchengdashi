using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

internal static class Rig {
    internal static readonly List<string> Trace=new List<string>();
    internal static readonly List<string> ModuleCalls=new List<string>();
    internal static bool ThrowModuleStart,ThrowConfig,ThrowBefore,ThrowAudio;
    internal static void Reset() {
        Trace.Clear();ModuleCalls.Clear();ThrowModuleStart=ThrowConfig=ThrowBefore=ThrowAudio=false;
        UnityEngine.Object.Persisted=null;UnityEngine.Debug.Messages.Clear();
        GameFramework.AppSetting.AutoSaveData=false;GameFramework.AppSetting.gameCode=null;GameFramework.AppSetting.MineGameName=null;
        GameFramework.AppSetting.UseNewRes=GameFramework.AppSetting.IsKeWan=GameFramework.AppSetting.IsXYXEnvironment=GameFramework.AppSetting.IsXYXNativeMode=GameFramework.AppSetting.IsGameColletion=false;
        GameFramework.GlobalData.IsReleaseVersion=false;GameFramework.GlobalData.MineAppName=null;
        GameFramework.NewResLoadHelper.Backend=new GameFramework.BackendModule();GameFramework.NewResLoadHelper.Callback=null;
        GameFramework.ResLoadHelper.Callback=null;GameFramework.ResLoadHelper.Path=null;
        DBTSDK.SDKToolManager.Instance=new DBTSDK.SDKToolManager();DBTSDK.ReportManager.Instance=new DBTSDK.ReportManager();
        var list=typeof(GameFramework.GameFrameEntry).GetField("y_0086A_0094F_0083",BindingFlags.NonPublic|BindingFlags.Static).GetValue(null) as LinkedList<GameFramework.GameFrameModule>;
        list?.Clear();typeof(GameFramework.GameFrameEntry).GetField("O_00B8_005D_00A1_008B_005E",BindingFlags.NonPublic|BindingFlags.Static).SetValue(null,false);
    }
}
namespace UnityEngine {
    public class Object {
        public bool Destroyed;
        public static Object Persisted;
        public static bool operator ==(Object a,Object b)=>ReferenceEquals(a,b)||((ReferenceEquals(a,null)||a.Destroyed)&&(ReferenceEquals(b,null)||b.Destroyed));
        public static bool operator !=(Object a,Object b)=>!(a==b);
        public override bool Equals(object o)=>ReferenceEquals(this,o);public override int GetHashCode()=>base.GetHashCode();
        public static void DontDestroyOnLoad(Object obj){Persisted=obj;Rig.Trace.Add("persist");}
    }
    public class Component:Object {public object AttachedComponent;public int GetCalls;public T GetComponent<T>() where T:class {GetCalls++;Rig.Trace.Add("get-component");return AttachedComponent as T;}}
    public class MonoBehaviour:Component {public IEnumerator Coroutine;public object StartCoroutine(IEnumerator iterator){Coroutine=iterator;Rig.Trace.Add("start-coroutine");return new object();}}
    public static class Time {public static float deltaTime=0.25f,unscaledDeltaTime=0.5f;}
    public static class Debug {public static readonly List<object> Messages=new List<object>();public static void Log(object value){Messages.Add(value);Rig.Trace.Add("debug:"+value);}}
    [AttributeUsage(AttributeTargets.Field)]public sealed class HeaderAttribute:Attribute {public HeaderAttribute(string value){}}
    [AttributeUsage(AttributeTargets.Field)]public sealed class SerializeField:Attribute {}
}
[AttributeUsage(AttributeTargets.Field)]public sealed class EnumFlagsAttribute:Attribute {}
namespace YooAsset {public enum EPlayMode {EditorSimulateMode=0,OfflinePlayMode=1,HostPlayMode=2,WebPlayMode=4}public class AllAssetsOperationHandle {}}
namespace GameFramework {
    public enum LocalELangLibrary {ZH_CN=1,EN=4}public enum ELangType {ZH_CN=0,EN=2}public enum TeamType {Team2=0,Team3=1}
    public static class AppSetting {
        public static bool AutoSaveData,UseNewRes,IsKeWan,IsXYXEnvironment,IsXYXNativeMode,IsGameColletion;
        public static string gameCode,MineGameName;
        public static void SetCultureBasedOnSetting(){Rig.Trace.Add("culture");}
    }
    public static class GlobalData {public static string MineAppName;public static LocalELangLibrary localELangLibrary;public static ELangType appDefaultLangType;public static bool IsReleaseVersion;}
    public static class UserDataPrefs {public static void OnInit()=>Rig.Trace.Add("prefs-init");}
    public static class CLog {
        public static void Error(params object[] values)=>Rig.Trace.Add("error:"+values[0]);
        public static void Log(params object[] values)=>Rig.Trace.Add("log:"+values[0]);
        internal static void d_00B0e_00A1_00B2_005B(params object[] values)=>Rig.Trace.Add("module-log:"+values[0]);
        public static void SetIsShowLog(bool value)=>Rig.Trace.Add("show-log:"+value);
    }
    public class DependencyModule:GameFrameModule {
        internal object[] Args;
        internal override void Initialize(params object[] args){Args=args;Rig.ModuleCalls.Add("init:"+GetType().Name);}
        internal override void Start(){Rig.ModuleCalls.Add("start:"+GetType().Name);if(Rig.ThrowModuleStart&&GetType()==typeof(MiddleModule))throw new InvalidOperationException("start");}
        internal override void Update(float dt,float real){Rig.ModuleCalls.Add("update:"+GetType().Name+":"+dt+":"+real);}
        internal override void U_0095_008Bd_008A_00AC()=>Rig.ModuleCalls.Add("late:"+GetType().Name);
        internal override void Shutdown(){}
        public void Complete()=>Àª_00A6_00A3_00BDE?.Invoke();
    }
    public class HighModule:DependencyModule {internal override int Priority=>10;}
    public class MiddleModule:DependencyModule {internal override int Priority=>5;}
    public class EqualModule:DependencyModule {internal override int Priority=>5;}
    public class LowModule:DependencyModule {internal override int Priority=>-3;}
    public class NestedContainer {public class Child:DependencyModule{}}
    public class VersionMondule:DependencyModule{}
    public class AssetbundleModule:DependencyModule{}
    public class BackendModule:DependencyModule{}
    public class UIModule:DependencyModule{}
    public class LangModule:DependencyModule {public void SetLocalLangLibrary(LocalELangLibrary library,ELangType language)=>Rig.Trace.Add("language:"+library+":"+language);}
    public class TimeModule:DependencyModule{}
    public class EffectModule:DependencyModule{}
    public class MineGameLogicModule:DependencyModule {
        public void RegisterLogicCtr(object control,bool autoInit=false)=>Rig.Trace.Add("register-control:"+control.GetType().Name+":"+autoInit);
        public void InitCtrl(bool autoInit=true){Rig.Trace.Add("init-controls:"+autoInit);}
    }
    public static class NewResLoadHelper {
        public static GameFrameModule Backend;public static Action Callback;public static YooAsset.EPlayMode Mode;public static TeamType Team;
        public static GameFrameModule GetNewResModule(bool keWan){Rig.Trace.Add("backend:"+keWan);return Backend;}
        public static void Initialize(GameFrameModule module,Action callback,YooAsset.EPlayMode mode,TeamType team){Rig.Trace.Add("backend-init");Callback=callback;Mode=mode;Team=team;}
        public static bool GetIsDeepObf()=>false;
    }
    public static class ResLoadHelper {public static string Path;public static Resources.ResourcesModule.LoadAssetCompleteHandler Callback;public static void LoadAsset(string path,Resources.ResourcesModule.LoadAssetCompleteHandler callback,params object[] args){Path=path;Callback=callback;Rig.Trace.Add("load:"+path);}}
    public class AudioManager {public static AudioManager Instance=new AudioManager();public void InitAudioManager(){Rig.Trace.Add("audio");if(Rig.ThrowAudio)throw new InvalidOperationException("audio");}}
    public static class MsgDispatcher {public delegate void EventHandler(object[] args);public static void SendMessage(string name)=>Rig.Trace.Add("message:"+name);public static void AddEventListener(string name,EventHandler handler)=>Rig.Trace.Add("listen:"+name);}
}
namespace GameFramework.Fsm {public class FsmManager:GameFramework.DependencyModule{}}
namespace GameFramework.ObjectPool {public class ObjectPoolManager:GameFramework.DependencyModule{}}
namespace GameFramework.Resources {public class ResourcesInfo{}public class ResourcesModule:GameFramework.DependencyModule {public delegate void LoadAssetCompleteHandler(ResourcesInfo resource);}}
namespace GameFramework.Procedure {
    public class ProcedureBase{}
    public class ProcedureManager:GameFramework.DependencyModule {
        public ProcedureBase[] Registered;public Type Started;
        public void Register(params ProcedureBase[] procedures){Registered=procedures;Rig.Trace.Add("procedures:"+string.Join(",",Array.ConvertAll(procedures,p=>p.GetType().Name)));}
        public void StartProcedure<T>() where T:ProcedureBase {Started=typeof(T);Rig.Trace.Add("procedure-start:"+typeof(T).Name);}
    }
}
public class GamePath {public static GamePath Instance=new GamePath();public void FindMineGamePath()=>Rig.Trace.Add("find-path");}
namespace DBTSDK {
    public class SDKToolManager {public static SDKToolManager Instance;public bool SupportLog=true;public bool IsSupportLogStatic(){Rig.Trace.Add("sdk-support-log");return SupportLog;}public void ShowToast(string value)=>Rig.Trace.Add("toast:"+value);public void U3DGameStart_Override()=>Rig.Trace.Add("sdk-game-start");}
    public class ReportManager {public static ReportManager Instance;public void ReportGMLogOpen()=>Rig.Trace.Add("report-log-open");public void StartMineGame()=>Rig.Trace.Add("report-start-game");}
}
namespace L_Tools {public class ServerTimeMgr {public static ServerTimeMgr I=new ServerTimeMgr();}}
namespace CommonGameModule.Email {public class EmailControl {public static EmailControl I=new EmailControl();}}
namespace ljzs_lt {
    public class PurchaseControl {public static PurchaseControl I=new PurchaseControl();}
    public class ConfigMgr {public static ConfigMgr Instance=new ConfigMgr();public void SetConfigABRes(GameFramework.Resources.ResourcesInfo resource)=>Rig.Trace.Add("set-config");public void Initialize(){Rig.Trace.Add("initialize-config");if(Rig.ThrowConfig)throw new InvalidOperationException("config");}}
}
namespace ljzs_lt.Procedure {public class ProcedurePreLoad:GameFramework.Procedure.ProcedureBase{}public class ProcedureStarGame:GameFramework.Procedure.ProcedureBase{}public class ProcedureExitGame:GameFramework.Procedure.ProcedureBase{}}
