using DataModule;
namespace UnityEngine
{
 public static class Application{public static string dataPath;public static bool isEditor=true;}
 public static class Debug{public static List<string> Logs=new();public static void Log(object s)=>Logs.Add(s.ToString());public static void LogWarning(object s)=>Logs.Add(s.ToString());public static void LogError(object s)=>Logs.Add(s.ToString());}
}
namespace GameFramework
{
 public static class AppSetting{public static string MineGameName="ljzs_lt";}
 public static class CLog
 {public static List<string> Logs=new();public static void Log(params object[] args)=>Logs.Add(string.Join("",args));public static void Warning(params object[] args)=>Log(args);public static void Error(params object[] args)=>Log(args);internal static void _009Ay_0097Eo_007D(params object[] args)=>Log(args);}
 public static class Utils{public static string DecompressData(string key,string str)=>throw new NotImplementedException("Unrestored native external codec");}
 public static class MsgDispatcher
 {public delegate void EventHandler(object[] args);public static Dictionary<string,EventHandler> Requests=new();public static void AddEventListener(string key,EventHandler action)=>Requests[key]=action;}
}
namespace GameFramework.GameData
{public class GameDataVersionMgr{public static GameDataVersionMgr Instance=new();public int Requests;internal void Á_0090_0090_00B8_00B9_0086(params string[] keys)=>Requests++;}}
namespace GameFramework.Login{public abstract class ILoginProcedure{public static int accountType=10;}}
namespace DBTSDK
{
 public class AppUserManager{public static AppUserManager Instance=new();internal bool IsUseServer;}
 public class ReportManager
 {public static ReportManager Instance=new();public object Last;public T GetNewReportJsonData<T>(bool clear,bool isNew)where T:new()=>new();public void NewReport_activity_complete(NewReport.JsonProperties.activity_complete data)=>Last=data;}
}
namespace DBTSDK.NewReport.JsonProperties{public class activity_complete{public string game_name,activity_name,activity_mode1;}}
namespace L_Tools{public class LoginControl{public static LoginControl I;public bool IsProxyLogin;}public static class PlayerPrefs2RunTime{public static bool IsBindingAccount;}}
namespace LoadingModule{public static class LoadingManager{public static bool EnterHome;}}
public static class UpdateManager{public delegate void UpdateHandle();public static List<UpdateHandle> Requests=new();public static int AddHandle(UpdateHandle action){Requests.Add(action);return Requests.Count;}}
internal class _00A5_0091_007FQ_0080_00A6{}
internal struct _00B4bv_00B0C_00BE{}
