using System.Collections;
using System.Reflection;
using System.Text.Json;
using Cysharp.Threading.Tasks;
using DataModule;
using L_Tools;
using TimeModuleO;
using Timer=TimeModuleO.TimeManager.Timer;
var passed=new List<string>();
void Check(bool ok,string name){if(!ok)throw new Exception(name);passed.Add(name);}
void Set(object target,string key,object value)=>target.GetType().GetField(key,BindingFlags.NonPublic|BindingFlags.Public|BindingFlags.Instance).SetValue(target,value);
object Get(object target,string key)=>target.GetType().GetField(key,BindingFlags.NonPublic|BindingFlags.Public|BindingFlags.Instance).GetValue(target);
object Call(object target,string name,params object[] args)=>target.GetType().GetMethod(name,BindingFlags.NonPublic|BindingFlags.Public|BindingFlags.Instance).Invoke(target,args);
void Cache(DateTime local,DateTime utc){typeof(DateTools).GetField("m_Now",BindingFlags.Static|BindingFlags.NonPublic).SetValue(null,local);typeof(DateTools).GetField("m_UTCNow",BindingFlags.Static|BindingFlags.NonPublic).SetValue(null,utc);}
TimeManager New(TimeManager.TimeSource source=TimeManager.TimeSource.NetworkTime)
{
 var m=new TimeManager();ToolModule.ManagerBase<TimeManager>.Instance=m;
 Set(m,"_currentTimeSource",source);Set(m,"_timers",new Dictionary<string,Timer>());
 Set(m,"_cutdownTimerEvents",new Dictionary<string,Action>());Set(m,"_cutdownTimers",new Dictionary<string,Timer>());Set(m,"_toRemoveTimerKeys",new List<string>());
 DbtSaveDataManager_PlayerTimeData.I=new();DbtSaveDataManager_PlayerCoreData.I=new();DataManager.Instance=new();LoadingModule.LoadingManager.Instance=new();
 ServerTimeMgr.I=new();ServerTimeMgr.IsUpdateFinish=false;UniTask.Waits.Clear();UnityEngine.Debug.Logs.Clear();DBTSDK.AppInfoManager.Instance=new();OnlineParamControl.Instance=new();
 return m;
}
var epoch=new DateTime(1970,1,1,0,0,0,DateTimeKind.Utc);
Check(DateTools.StartTime_UTC==epoch&&DateTools.StartTime==epoch.AddHours(8),"DateTools original epoch cctor");
Check(!DateTools.NowIsServerTime()&&DateTools.GetNow()==default&&DateTools.GetUTCNow()==default,"DateTools caches remain default until server producer");
Check(DateTools.StampToDatetime(123)==epoch.AddSeconds(123)&&DateTools.StampToDatetime(123,true)==epoch.AddMilliseconds(123),"Timestamp seconds and milliseconds");
DateTools.UpdateTime(3600);
Check(DateTools.NowIsServerTime()&&DateTools.GetUTCNow()==epoch.AddHours(1)&&DateTools.GetNow()==epoch.AddHours(1).ToLocalTime(),"Server update stores UTC and local cache without extrapolation");
var fixedNow=new DateTime(2026,10,19,14,30,0);Cache(fixedNow,fixedNow.AddHours(-8));
var m=New();
Check(m.GetNetworkTime()==fixedNow&&m.GetNetworkTime(true)==fixedNow.AddHours(-8),"Network getters read distinct original cache providers");
Set(m,"_offsetHours",3);
Check(m.GetLocalNetworkTime()==fixedNow.AddHours(3)&&m.GetStandardNetworkTime()==fixedNow.AddHours(-5),"Offset applied to both providers");
m=New(TimeManager.TimeSource.LocalTime);
DateTime before=DateTime.Now;var local=m.GetLocalNetworkTime();DateTime after=DateTime.Now;
Check(local>=before&&local<=after,"Original LocalTime getter reads live DateTime.Now");
before=DateTime.UtcNow;var utc=m.GetStandardNetworkTime();after=DateTime.UtcNow;
Check(utc>=before&&utc<=after,"Original LocalTime standard getter reads live DateTime.UtcNow");
m=New();Cache(fixedNow,fixedNow.AddHours(-8));
Check(m.GetTimer(null)==null&&m.GetTimer("   ")==null&&m.CreateTimer(" ",TimeSpan.FromHours(1),true)==null,"Null and whitespace timer keys rejected");
var timer=m.CreateTimer("one",TimeSpan.FromHours(2),true,true);
Check(timer.Key=="one"&&timer.useStandardNetTime&&timer.StartTime==fixedNow.AddHours(-8)&&timer.TargetEndTime==fixedNow.AddHours(-6),"Timer ctor and restart preserve key source start end");
Check(ReferenceEquals(m.GetTimer("one"),timer)&&m.CreateTimer("one",TimeSpan.Zero,true)==null,"Timer duplicate rejected and lookup preserved");
Check(DbtSaveDataManager_PlayerTimeData.I.Saves==3&&DbtSaveDataManager_PlayerTimeData.I.Data.timeInfoDic["one"].TargetEndTime==timer.TargetEndTime,"Original triple save side effects retained on CreateTimer");
Check(!DbtSaveDataManager_PlayerTimeData.I.Data.timeInfoDic["one"].useStandardNetTime,"Original new TimeInfo does not persist standard flag");
timer.Restart(TimeSpan.Zero,true);Check(timer.IsCompleted()&&timer.GetRemainingTime()==TimeSpan.Zero,"Completion and remaining time use selected provider");
timer.Restart(TimeSpan.Zero,false);Check(timer.TargetEndTime==DateTime.MaxValue&&!timer.IsCompleted(),"Noncountdown original MaxValue end");
var record=new TimeInfo{Key="loaded",StartTime=fixedNow.AddDays(-2),TargetEndTime=fixedNow.AddDays(3),useStandardNetTime=true};
var loaded=new Timer(record);Check(loaded.Key==record.Key&&loaded.StartTime==record.StartTime&&loaded.TargetEndTime==record.TargetEndTime&&loaded.useStandardNetTime,"Persisted timer ctor restores all four fields");
int saves=DbtSaveDataManager_PlayerTimeData.I.Saves;TimeManager.ChangeTimeInfoEndTime("one",fixedNow.AddDays(1));
Check(timer.TargetEndTime==fixedNow.AddDays(1)&&DbtSaveDataManager_PlayerTimeData.I.Saves==saves+1,"End time update reaches record and live timer");
DbtSaveDataManager_PlayerTimeData.I.Data.timeInfoDic=null;TimeManager.ChangeTimeInfoEndTime("absent",fixedNow);
Check(DbtSaveDataManager_PlayerTimeData.I.Data.timeInfoDic==null,"Original null dictionary helper does not assign replacement");
m=New();Cache(fixedNow,fixedNow.AddHours(-8));
Check(m.GetTimeSpanToZero()==TimeSpan.FromHours(9.5)&&m.GetTimeSpanToZeroStandardNetworkTime()==TimeSpan.FromHours(17.5),"Day boundary uses each actual time provider");
Check(m.GetTimeSpanToWeek()==TimeSpan.FromDays(7)-TimeSpan.FromHours(14.5),"Monday timer selects next Monday");
Cache(fixedNow.AddDays(-1),fixedNow.AddHours(-8));Check(m.GetTimeSpanToWeek()==TimeSpan.FromHours(9.5),"Sunday timer selects following Monday");
Check((DateTime)Call(m,"GetStartOfWeekForTimeManager",fixedNow.AddDays(-1))==new DateTime(2026,10,12),"Week start maps Sunday to preceding Monday");
m=New(TimeManager.TimeSource.LocalTime);var sync=(IEnumerator)Call(m,"SyncServerTimeCoroutine");
Check(!sync.MoveNext()&&m.IsNetworkConnected&&ServerTimeMgr.I.Checks==0,"Local sync connects through original branch with no server request");
m=New();sync=(IEnumerator)Call(m,"SyncServerTimeCoroutine");UnityEngine.Time.deltaTime=1f;
Check(sync.MoveNext()&&!m.IsNetworkConnected&&(bool)Get(m,"_isFetchingNetworkTime")&&ServerTimeMgr.I.Checks==1,"Network sync remains pending after actual request");
sync.MoveNext();sync.MoveNext();sync.MoveNext();
Check(!m.IsNetworkConnected&&ServerTimeMgr.I.Checks==2,"Network sync retries only after greater than three seconds");
ServerTimeMgr.IsUpdateFinish=true;
Check(!sync.MoveNext()&&m.IsNetworkConnected&&!(bool)Get(m,"_isFetchingNetworkTime"),"Network response readiness ends original sync");
m=New(TimeManager.TimeSource.LocalTime);var load=(IEnumerator)Call(m,"LoadTimers");
Check(load.MoveNext()&&m.toWeekTimer==null,"LoadTimers waits network readiness");
((IEnumerator)Call(m,"SyncServerTimeCoroutine")).MoveNext();
Check(load.MoveNext()&&!DbtSaveDataManager_PlayerCoreData.I.Data.playerTimeInfoConverted,"LoadTimers waits data readiness");
DataManager.Instance.LoadDataCompleted=true;
Check(load.MoveNext()&&DbtSaveDataManager_PlayerCoreData.I.Data.playerTimeInfoConverted&&m.toWeekTimer==null,"LoadTimers conversion precedes separate loading gate");
Check(m.Started.Count==0,"No watcher starts while LoadingManager incomplete");
LoadingModule.LoadingManager.Instance.IsLoadingCompleted=true;
Check(!load.MoveNext()&&m.toZeroTimer!=null&&m.toZeroStandardNetworkTime!=null&&m.toWeekTimer!=null&&m.Started.Count==3,"LoadTimers creates original three timers and watchers after all gates");
Check(m.Started.All(c=>c.Routine.Current is UnityEngine.WaitForSeconds w&&w.seconds==1f),"All watcher coroutines initially wait one second");
m=New(TimeManager.TimeSource.LocalTime);((IEnumerator)Call(m,"SyncServerTimeCoroutine")).MoveNext();DataManager.Instance.LoadDataCompleted=true;
DbtSaveDataManager_PlayerCoreData.I.Data.playerTimeInfoConverted=true;DbtSaveDataManager_PlayerTimeData.I.Data.timeInfoDic.Add("loaded",record);
load=(IEnumerator)Call(m,"LoadTimers");load.MoveNext();
Check(m.GetTimer("loaded")?.StartTime==record.StartTime&&DbtSaveDataManager_PlayerCoreData.I.Saves==0,"Converted records restore instead of rewriting migration flag");
m=New();Cache(fixedNow,fixedNow);timer=m.CreateTimer("callback",TimeSpan.Zero,true);int calls=0;
m._cutdownTimers.Add("callback",timer);m._cutdownTimerEvents.Add("callback",()=>calls++);Call(m,"CheckTimerEndEvent");Call(m,"CheckTimerEndEvent");
Check(calls==1&&!m._cutdownTimers.ContainsKey("callback")&&!m._cutdownTimerEvents.ContainsKey("callback"),"End callback fires once and removes only callback tracking");
Check(m.GetTimer("callback")!=null&&DbtSaveDataManager_PlayerTimeData.I.Data.timeInfoDic.ContainsKey("callback"),"End callback preserves persisted and live timer");
m=New();Cache(fixedNow,fixedNow);m.SaveLastExitTime();Check(DbtSaveDataManager_PlayerTimeData.I.Data.lastExitGameTime==fixedNow&&DbtSaveDataManager_PlayerTimeData.I.Saves==1,"Last exit time persists actual selected clock");
m=New();UnityEngine.Application.isEditor=true;
var select=(UniTask)Call(m,"InitializeTimeSource");
#if UNITY_EDITOR
select.GetAwaiter().GetResult();
Check((TimeManager.TimeSource)Get(m,"_currentTimeSource")==TimeManager.TimeSource.LocalTime&&UnityEngine.Debug.Logs.Any(x=>x.Contains("LocalEditor")),"Editor adapter selects original LocalTime with explicit LocalEditor label");
Check(DBTSDK.AppInfoManager.Instance.Calls==0&&OnlineParamControl.Instance.Calls==0&&!m.IsNetworkConnected&&!m.initComplete&&ServerTimeMgr.I.Checks==0,"Editor adapter leaves server and init readiness untouched");
m=New();PlayerPrefs2Center.Value=2;var init=m.Init();
Check(m.initComplete&&m.IsNetworkConnected&&m.OffsetHours==2&&!init.Task.IsCompleted&&m.Started.Count==2,"Init reaches original flags only after source sync load and offset");
m.toWeekTimer=new Timer(new TimeInfo{Key="week",StartTime=DateTime.Now,TargetEndTime=DateTime.MaxValue});UniTask.CompleteFirst();init.GetAwaiter().GetResult();
Check(init.Task.IsCompletedSuccessfully,"Init retains final 0.1 second async boundary");
#else
Check(!select.Task.IsCompleted&&!m.initComplete&&DBTSDK.AppInfoManager.Instance.Calls==1,"APK selection waits original online readiness predicate");
UniTask.TimeoutSource.SetResult(true);select.GetAwaiter().GetResult();
Check((TimeManager.TimeSource)Get(m,"_currentTimeSource")==TimeManager.TimeSource.NetworkTime&&OnlineParamControl.Instance.Calls==0,"APK timeout chooses NetworkTime without online query");
foreach(var value in new[]{"1","0","",null})
{
 m=New();OnlineParamControl.Instance.Value=value;select=(UniTask)Call(m,"InitializeTimeSource");UniTask.TimeoutSource.SetResult(false);select.GetAwaiter().GetResult();
 Check((TimeManager.TimeSource)Get(m,"_currentTimeSource")== (value=="1"?TimeManager.TimeSource.LocalTime:TimeManager.TimeSource.NetworkTime),"APK online param exact 1 selection: "+(value??"null"));
}
m=New();var init=m.Init();Check(!m.initComplete&&!init.Task.IsCompleted&&Get(m,"_timers")!=null,"Init awaits source selection before completion flag");
UniTask.TimeoutSource.SetResult(true);
Check(m.initComplete&&!m.IsNetworkConnected&&!init.Task.IsCompleted,"Init original flag placement does not fake network readiness");
for(int i=0;i<100;i++)UniTask.CompleteFirst();
Check(DBTSDK.SDKToolManager.Instance.Toasts.SequenceEqual(new[]{"服务器时间同步异常"})&&!init.Task.IsCompleted,"Init network polling reports original toast every 100 waits");
#endif
Console.WriteLine(JsonSerializer.Serialize(new{mode=
#if UNITY_EDITOR
"Editor",
#else
"APK",
#endif
passed=passed.Count,tests=passed},new JsonSerializerOptions{WriteIndented=true}));
