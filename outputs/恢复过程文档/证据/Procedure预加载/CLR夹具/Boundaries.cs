using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

// Instrumented dependency boundaries only. The two Procedure source files are copied byte for byte.
public static class Probe
{
 public static readonly List<string> Trace=new List<string>();
 public static readonly List<L_Tools.LoginControl> Logins=new List<L_Tools.LoginControl>();
 public static Action<int> AddedTimer,RemovedTimer;
 public static GameFramework.MsgDispatcher.EventHandler AddedEvent,RemovedEvent;
 public static int RemovedId,LastPriority;public static string LastScene;public static bool LastActivate;public static UnityEngine.SceneManagement.LoadSceneMode LastMode;
 public static object LastOwner;public static object[] LastStateArgs;public static Type LastState;public static string Channel;
 public static void Add(string s){Trace.Add(s);}
 public static void Reset(Task init,Task localization,string channel="ordinary")
 {
  AssetsModule.AssetsManager.Instance=new AssetsModule.AssetsManager{InitTask=init};LocalizationModule.Runtime.CustomBundlesManager.Instance=new LocalizationModule.Runtime.CustomBundlesManager{PreloadTask=localization};Channel=channel;Trace.Clear();Logins.Clear();AccountMsgCanvas.Panels.Clear();AddedTimer=null;RemovedTimer=null;AddedEvent=null;RemovedEvent=null;LastOwner=null;LastState=null;LastStateArgs=null;LastScene=null;RemovedId=0;GameFramework.Base.GameStartEntry.Reset();
 }
}
namespace Il2CppDummyDll
{
 [AttributeUsage(AttributeTargets.All)]public sealed class TokenAttribute:Attribute{public string Token;}
 [AttributeUsage(AttributeTargets.All)]public sealed class AddressAttribute:Attribute{public string RVA,Offset,VA,Slot;}
 [AttributeUsage(AttributeTargets.All)]public sealed class FieldOffsetAttribute:Attribute{public string Offset;}
}
namespace Cysharp.Threading.Tasks
{
 public readonly struct UniTask
 {
  readonly Task task;public UniTask(Task task){this.task=task;}public Awaiter GetAwaiter(){return new Awaiter(task.GetAwaiter());}
  public readonly struct Awaiter:ICriticalNotifyCompletion
  {readonly TaskAwaiter a;public Awaiter(TaskAwaiter a){this.a=a;}public bool IsCompleted{get{return a.IsCompleted;}}public void GetResult(){a.GetResult();}public void OnCompleted(Action c){a.OnCompleted(c);}public void UnsafeOnCompleted(Action c){a.UnsafeOnCompleted(c);}}
 }
 public static class Extensions{public static void Forget(this UniTask task){Probe.Add("localization.Forget");}}
}
namespace GameFramework.Fsm{public interface IFsm<T>{}public sealed class Owner:IFsm<GameFramework.Procedure.IProcedureManager>{}}
namespace GameFramework.Procedure
{
 public interface IProcedureManager{}
 public class ProcedureBase
 {
  public virtual void OnInit(GameFramework.Fsm.IFsm<IProcedureManager> owner){Probe.Add("base.OnInit");}
  public virtual void OnEnter(GameFramework.Fsm.IFsm<IProcedureManager> owner){Probe.Add("base.OnEnter");}
  public virtual void OnUpdate(GameFramework.Fsm.IFsm<IProcedureManager> owner,float a,float b){Probe.Add("base.OnUpdate");}
  public virtual void OnLeave(GameFramework.Fsm.IFsm<IProcedureManager> owner,bool shutdown){Probe.Add("base.OnLeave:"+shutdown);}
  public virtual void OnDestroy(GameFramework.Fsm.IFsm<IProcedureManager> owner){Probe.Add("base.OnDestroy");}
  protected void ChangeState<T>(GameFramework.Fsm.IFsm<IProcedureManager> owner,object[] args){Probe.LastState=typeof(T);Probe.LastOwner=owner;Probe.LastStateArgs=args;Probe.Add("ChangeState:"+typeof(T).Name);}
 }
}
namespace UnityEngine
{
 public class Object{public static void DontDestroyOnLoad(Object value){Probe.Add("DontDestroyOnLoad");}}
 public class GameObject:Object{public string name;public GameObject(string name):this(name,true){}public GameObject(string name,bool log){this.name=name;if(log)Probe.Add("GameObject:"+name);}public T AddComponent<T>()where T:new(){Probe.Add("AddComponent:"+typeof(T).Name);return new T();}}
 public static class Debug{public static void Log(object value){Probe.Add("Log:"+value);}}
}
namespace UnityEngine.SceneManagement{public enum LoadSceneMode{Single=0,Additive=1}}
namespace UnityEngine.AddressableAssets{public static class Addressables{public static object LoadSceneAsync(string address,UnityEngine.SceneManagement.LoadSceneMode mode,bool activate,int priority){Probe.LastScene=address;Probe.LastMode=mode;Probe.LastActivate=activate;Probe.LastPriority=priority;Probe.Add("LoadScene:"+address);return null;}}}
namespace AssetsModule{public sealed class AssetsManager{public static AssetsManager Instance;public Task InitTask;public UnityEngine.GameObject gameObject=new UnityEngine.GameObject("AssetsManager",false);public Cysharp.Threading.Tasks.UniTask Init(){Probe.Add("Assets.Init");return new Cysharp.Threading.Tasks.UniTask(InitTask);}}}
namespace LocalizationModule
{
 public static class StartupLanguageHelper{public static void EnsureStartupLanguage(){Probe.Add("EnsureStartupLanguage");}}
 namespace Runtime{public sealed class CustomBundlesManager{public static CustomBundlesManager Instance;public Task PreloadTask;public Cysharp.Threading.Tasks.UniTask Preload(){Probe.Add("localization.Preload");return new Cysharp.Threading.Tasks.UniTask(PreloadTask);}}}
}
namespace DataModule{public class DataCompareMgr{}}
namespace ToolModule{public static class LitJsonExtent{public static void Init(){Probe.Add("LitJson.Init");}}}
namespace L_Tools
{
 public sealed class LoginControl
 {
  public readonly Action<int> Validation;public Action<bool> LastCallback;public bool LastForce;public int Calls;public readonly List<string> FlagWrites=new List<string>();
  public LoginControl(Action<int> validation){Validation=validation;Probe.Logins.Add(this);Probe.Add("LoginControl.ctor");}
  public bool IsDefaultTouristLogin{set{FlagWrites.Add("Tourist="+value);}}
  public bool UseLoginCache{set{FlagWrites.Add("Cache="+value);}}
  public void Login(Action<bool> callback,bool forceLogin=false){LastCallback=callback;LastForce=forceLogin;Calls++;Probe.Add("Login:"+forceLogin);}
 }
}
namespace DBTSDK
{
 public sealed class AppInfoManager{public static AppInfoManager Instance=new AppInfoManager();public string GetAppChannelGroup(){Probe.Add("GetAppChannelGroup");return Probe.Channel;}}
 public sealed class ReportManager{public static ReportManager Instance=new ReportManager();public void StartGameModel(MineGameModel model){Probe.Add("StartGameModel:"+model);}public void ReportGamePlayTime(int times){Probe.Add("ReportGamePlayTime:"+times);}}
}
public enum MineGameModel{None=0}
namespace I2.Loc
{
 public static class LocalizationManager
 {public static void EnableChangingCultureInfo(bool value){Probe.Add("EnableCulture:"+value);}public static string GetTranslation(string term,bool a,int b,bool c,bool d,object e,object f,bool g){if(!a||b!=0||!c||d||e!=null||f!=null||!g)throw new Exception("Translation flags changed");return term;}}
}
public static class AccountMsgCanvas
{
 public sealed class Panel{public string Title,Message,Button;public Action Callback;public bool Flag1,Flag2;}
 public static readonly List<Panel> Panels=new List<Panel>();public static void SetContent(string title,string message,string button,Action callback,bool flag1,bool flag2){Panels.Add(new Panel{Title=title,Message=message,Button=button,Callback=callback,Flag1=flag1,Flag2=flag2});Probe.Add("Panel:"+title);}public static void ExitGame(){Probe.Add("ExitGame");}
}
namespace GameFramework
{
 public static class CLog{public static void Log(params object[] args){Probe.Add("CLog:"+args[0]);}}
 public static class MsgDispatcher
 {public delegate void EventHandler(object[] args);public static void AddEventListener(string name,EventHandler cb){Probe.AddedEvent=cb;Probe.Add("AddEvent:"+name);}public static void RemoveEventListener(string name,EventHandler cb){Probe.RemovedEvent=cb;Probe.Add("RemoveEvent:"+name);}public static void SendMessage(string name,object[] args){if(args!=null)throw new Exception("Native exit message payload was null");Probe.Add("SendMessage:"+name);}}
 public sealed class TimeModule
 {public int AddLoopTimer(int seconds,bool pause,Action<int> callback,bool auto,bool scale){if(seconds!=30||!pause||!auto||scale)throw new Exception("Native timer args changed");Probe.AddedTimer=callback;Probe.Add("AddLoopTimer:30,true,true,false");return 77;}public void RemoveLoopTimer(int id,Action<int> callback){Probe.RemovedId=id;Probe.RemovedTimer=callback;Probe.Add("RemoveLoopTimer:"+id);}}
 public static class GameFrameEntry{public static T GetModule<T>()where T:new(){return new T();}}
 public static class GlobalData{public static void CheckNewDay(){Probe.Add("CheckNewDay");}}
 public static class ResLoadHelper{public static void LoadScene(string name,object a,bool b,object c){if(a!=null||b||c!=null)throw new Exception("Test scene original args changed");Probe.Add("TestScene:"+name);}}
 namespace Base{public static class GameStartEntry{static bool enter;public static bool EnterGame{get{return enter;}set{enter=value;Probe.Add("EnterGame:"+value);}}public static void Reset(){enter=false;}}}
}
namespace ljzs_lt.Procedure{public sealed class ProcedureExitGame:GameFramework.Procedure.ProcedureBase{}}
