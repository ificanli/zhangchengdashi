using System.Collections;
using System.Runtime.CompilerServices;
using TimeModuleO;
namespace UnityEngine
{
 public class Coroutine{public IEnumerator Routine;public Coroutine(IEnumerator r){Routine=r;}}
 public class MonoBehaviour
 {
  public List<Coroutine> Started=new();public List<Coroutine> Stopped=new();
  public Coroutine StartCoroutine(IEnumerator r){var c=new Coroutine(r);Started.Add(c);r.MoveNext();return c;}
  public void StopCoroutine(Coroutine c){Stopped.Add(c);}
 }
 public static class Application{public static bool isEditor=true;}
 public static class Time{public static float deltaTime=1f;}
 public class WaitForSeconds{public float seconds;public WaitForSeconds(float s){seconds=s;}}
 public static class Debug{public static List<string> Logs=new();public static void Log(object s){Logs.Add(s.ToString());}}
}
namespace Cysharp.Threading.Tasks
{
 [AsyncMethodBuilder(typeof(UniTaskBuilder))]
 public struct UniTask
 {
  public Task Task;public UniTask(Task t){Task=t;}public TaskAwaiter GetAwaiter()=>(Task??System.Threading.Tasks.Task.CompletedTask).GetAwaiter();
  public static List<(float seconds,TaskCompletionSource source)> Waits=new();public static Func<bool> LastPredicate;
  public static TaskCompletionSource PredicateSource;public static TaskCompletionSource<bool> TimeoutSource;
  public static UniTask WaitForSeconds(float seconds){var s=new TaskCompletionSource();Waits.Add((seconds,s));return new UniTask(s.Task);}
  public static UniTask Yield()=>WaitForSeconds(-1);
  public static UniTask WaitUntil(Func<bool> predicate){LastPredicate=predicate;PredicateSource=new();if(predicate())PredicateSource.SetResult();return new UniTask(PredicateSource.Task);}
  public static void CompleteFirst(){var w=Waits[0];Waits.RemoveAt(0);w.source.SetResult();}
 }
 public struct UniTaskBuilder
 {
  AsyncTaskMethodBuilder b;public static UniTaskBuilder Create()=>new(){b=AsyncTaskMethodBuilder.Create()};
  public UniTask Task=>new(b.Task);public void SetResult()=>b.SetResult();public void SetException(Exception e)=>b.SetException(e);
  public void SetStateMachine(IAsyncStateMachine s)=>b.SetStateMachine(s);
  public void Start<T>(ref T s)where T:IAsyncStateMachine=>b.Start(ref s);
  public void AwaitOnCompleted<TA,TS>(ref TA a,ref TS s)where TA:INotifyCompletion where TS:IAsyncStateMachine=>b.AwaitOnCompleted(ref a,ref s);
  public void AwaitUnsafeOnCompleted<TA,TS>(ref TA a,ref TS s)where TA:ICriticalNotifyCompletion where TS:IAsyncStateMachine=>b.AwaitUnsafeOnCompleted(ref a,ref s);
 }
 public static class UniTaskExtensions
 {
  public static Task<bool> TimeoutWithoutException(this UniTask task,TimeSpan time)
  {if(time!=TimeSpan.FromSeconds(10))throw new Exception("Timeout changed");UniTask.TimeoutSource=new();return UniTask.TimeoutSource.Task;}
 }
}
namespace ToolModule
{
 public abstract class ManagerBase<T>:UnityEngine.MonoBehaviour
 {public static T Instance;public abstract Cysharp.Threading.Tasks.UniTask Init();}
 public static class StringTool{public static bool IsNullOrEmpty(string s,bool trimSpaces=true)=>s==null||(trimSpaces?s.Trim():s).Length==0;}
}
namespace DataModule
{
 public class TimeInfo{public string Key;public DateTime StartTime,TargetEndTime;public bool useStandardNetTime;}
 public class PlayerTimeData{public Dictionary<string,TimeInfo> timeInfoDic=new();public DateTime lastExitGameTime;}
 public class PlayerCoreData{public bool playerTimeInfoConverted;}
 public class DataManager{public static DataManager Instance=new();public bool LoadDataCompleted;}
}
public class DbtSaveDataManager_PlayerTimeData
{public static DbtSaveDataManager_PlayerTimeData I=new();public DataModule.PlayerTimeData Data=new();public int Saves;public void Save(){Saves++;}}
public class DbtSaveDataManager_PlayerCoreData
{public static DbtSaveDataManager_PlayerCoreData I=new();public DataModule.PlayerCoreData Data=new();public int Saves;public void Save(){Saves++;}}
namespace L_Tools
{
 public static class PlayerPrefs2Center{public static int Value;public static int GetInt(string key,int value){if(key!="OffsetHours"||value!=0)throw new Exception();return Value;}}
 public class OnlineParamControl{public static OnlineParamControl Instance=new();public string Value;public int Calls;public string GetOnlineParam(string key,string defaultValue=""){Calls++;if(key!="UseLocalTime"||defaultValue!="")throw new Exception();return Value;}}
 public class ServerTimeMgr{public static ServerTimeMgr I=new();public static bool IsUpdateFinish;public int Checks;public void TryCheck(bool force){if(!force)throw new Exception();Checks++;}}
}
namespace DBTSDK
{
 public class AppInfoManager{public static AppInfoManager Instance=new();public bool Ready;public int Calls;public bool IsOnlineParamReady_Override(){Calls++;return Ready;}}
 public class SDKToolManager{public static SDKToolManager Instance=new();public List<string> Toasts=new();public void ShowToast(string msg){Toasts.Add(msg);}}
}
namespace LoadingModule{public class LoadingManager{public static LoadingManager Instance=new();public bool IsLoadingCompleted;}}
namespace EventModule{public class EventManager{public static EventManager Instance=new();public List<string> Events=new();public void TriggerEvent(string key,object value){Events.Add(key);}}}
