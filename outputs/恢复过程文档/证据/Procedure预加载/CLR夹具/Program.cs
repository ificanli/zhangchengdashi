using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using GameFramework.Fsm;
using ljzs_lt.Procedure;

public sealed class CaptureContext:SynchronizationContext
{
 readonly ConcurrentQueue<Tuple<SendOrPostCallback,object>> queue=new ConcurrentQueue<Tuple<SendOrPostCallback,object>>();
 public readonly List<Exception> Errors=new List<Exception>();
 public override void Post(SendOrPostCallback callback,object state){queue.Enqueue(Tuple.Create(callback,state));}
 public void Pump(){Tuple<SendOrPostCallback,object> item;while(queue.TryDequeue(out item)){try{item.Item1(item.Item2);}catch(Exception ex){Errors.Add(ex);}}}
}
public static class Program
{
 static readonly List<object> Results=new List<object>();static CaptureContext context;
 public static int Main()
 {
  Test("pending_init_still_changes_state_immediately","0x439F890 + 0x43A01BC",()=>{
   var init=new TaskCompletionSource<int>();var localization=new TaskCompletionSource<int>();Reset(init.Task,localization.Task);var owner=new Owner();var p=new ProcedurePreLoad();p.OnInit(owner);p.OnEnter(owner);
   Assert(Probe.Trace.Contains("Assets.Init")&&Probe.Trace.Contains("Log:预加载完成")&&Probe.LastState==typeof(ProcedureStarGame),"Native caller must log and switch while Init is pending");Assert(Probe.Logins.Count==0&&!Probe.Trace.Contains("localization.Preload"),"Post-await calls ran too early");Assert(ReferenceEquals(Probe.LastOwner,owner)&&Probe.LastStateArgs.Length==0,"Original owner and empty state args not forwarded");
   init.SetResult(1);context.Pump();Assert(Probe.Logins.Count==1,"Init continuation did not resume");Assert(Index("ChangeState:ProcedureStarGame")<Index("localization.Preload"),"Source changed native asynchronous initiation order");Assert(!localization.Task.IsCompleted,"Localization fixture must still be pending");
  });
  Test("completed_init_runs_synchronous_prefix_before_state_change","0x439F890 + 0x43A01BC",()=>{
   var localization=new TaskCompletionSource<int>();Reset(Task.CompletedTask,localization.Task);var p=new ProcedurePreLoad();p.OnInit(new Owner());p.OnEnter(new Owner());Assert(Index("Login:False")<Index("Log:预加载完成")&&Index("Log:预加载完成")<Index("ChangeState:ProcedureStarGame"),"Completed await must retain synchronous continuation semantics");Assert(!localization.Task.IsCompleted&&Probe.Logins.Count==1,"Forget was accidentally awaited or login skipped");Assert(System.Globalization.CultureInfo.CurrentCulture.Name=="en-US"&&System.Globalization.CultureInfo.CurrentUICulture.Name=="en-US"&&System.Globalization.CultureInfo.DefaultThreadCurrentCulture.Name=="en-US"&&System.Globalization.CultureInfo.DefaultThreadCurrentUICulture.Name=="en-US","Culture setup incomplete");
  });
  Test("faulted_init_posts_asyncvoid_error_without_skipping_caller_transition","Native async-void builder shape; source CLR failure semantics only",()=>{
   Reset(Task.FromException(new InvalidOperationException("init-failed")),Task.CompletedTask);var p=new ProcedurePreLoad();p.OnInit(new Owner());p.OnEnter(new Owner());context.Pump();Assert(context.Errors.Count==1&&context.Errors[0].Message=="init-failed","async void failure did not remain visible");Assert(Probe.LastState==typeof(ProcedureStarGame)&&Probe.Logins.Count==0,"Caller order changed or continuation ran after failed init");
  });
  foreach(var channel in new string[]{null,"","ordinary-channel","HUAWEI-distribution"})
  {
   string captured=channel;Test("channel_flags_"+(captured??"null"),"0x43A01BC native bool writes at 0x28 and 0x51",()=>{
    Reset(Task.CompletedTask,Task.CompletedTask,captured);var p=new ProcedurePreLoad();p.OnInit(new Owner());p.OnEnter(new Owner());var login=Probe.Logins.Single();bool huawei=captured!=null&&captured.ToLower().Contains("huawei");Assert(login.FlagWrites.SequenceEqual(huawei?new[]{"Tourist=False","Cache=False"}:Array.Empty<string>()),"Channel branch writes do not match native");Assert(login.Calls==1&&!login.LastForce,"TryLogin must call Login(callback,false)");
   });
  }
  foreach(int code in new[]{1019,3302,9876})
  {
   int captured=code;Test("validation_error_"+captured,"0x439FB50",()=>{
    Reset(Task.CompletedTask,Task.CompletedTask);Invoke(new ProcedurePreLoad(),"OnLoginValid",captured);var panel=AccountMsgCanvas.Panels.Single();Assert(panel.Button=="Exit_Game"&&panel.Callback==AccountMsgCanvas.ExitGame,"Validation action is not original ExitGame");if(captured==1019)Assert(panel.Title=="Login_Vaild"&&panel.Message=="Login_Vaild_Message"&&!panel.Flag1&&!panel.Flag2,"1019 branch mismatch");else if(captured==3302)Assert(panel.Title=="Login_Vaild"&&panel.Message=="该账号已被封禁,如有疑问请联系客服反馈"&&panel.Flag1&&panel.Flag2,"3302 branch mismatch");else Assert(panel.Title=="Login_Failed"&&panel.Message=="Error Code : 9876"&&!panel.Flag1&&!panel.Flag2,"Fallback branch mismatch");panel.Callback();Assert(Probe.Trace.Last()=="ExitGame","Validation callback mismatch");
   });
  }
  Test("failed_login_retry_reuses_original_closure_and_false_force_flag","0x439FF74 + 0x439FEE0",()=>{
   Reset(Task.CompletedTask,Task.CompletedTask);var p=new ProcedurePreLoad();p.OnInit(new Owner());p.OnEnter(new Owner());var login=Probe.Logins.Single();var closure=login.LastCallback.Target;login.LastCallback(false);var panel=AccountMsgCanvas.Panels.Single();Assert(panel.Title=="Login_Failed"&&panel.Message=="Login_Failed_Message"&&panel.Button=="重试"&&!panel.Flag1&&!panel.Flag2,"Login failure UI mismatch");Assert(ReferenceEquals(panel.Callback.Target,closure),"Retry callback lost closure");panel.Callback();Assert(login.Calls==2&&!login.LastForce,"Retry must invoke the same LoginControl with force=false");login.LastCallback(true);Assert(Probe.Trace.Last()=="CLog:Login 登录成功","Success log mismatch");Assert(Probe.Trace.Count(x=>x=="ChangeState:ProcedureStarGame")==1,"Login success must not add a new transition gate");
  });
  Test("optional_after_login_action_called_after_success_log","0x439FF74 conditional delegate invoke",()=>{
   Reset(Task.CompletedTask,Task.CompletedTask);var p=new ProcedurePreLoad();p.OnInit(new Owner());p.OnEnter(new Owner());var login=Probe.Logins.Single();var closure=login.LastCallback.Target;closure.GetType().GetField("afterLoginAction").SetValue(closure,(Action)(()=>Probe.Add("afterLoginAction")));login.LastCallback(true);Assert(Probe.Trace.TakeLast(2).SequenceEqual(new[]{"CLog:Login 登录成功","afterLoginAction"}),"Optional after-login order mismatch");
  });
  Test("star_enter_original_scene_and_setup_order","0x43A07CC + 0x43A09D4",()=>{
   Reset(Task.CompletedTask,Task.CompletedTask);var star=new ProcedureStarGame();star.OnInit(new Owner());Probe.Trace.Clear();star.OnEnter(new Owner());Assert(Probe.Trace.SequenceEqual(new[]{"base.OnEnter","AddEvent:ReadyExitGame","AddLoopTimer:30,true,true,false","StartGameModel:None","EnterGame:True","CheckNewDay","Log:显示主UI","LoadScene:Assets/_Scene/Game.unity"}),"StarGame enter sequence differs from native calls");Assert(Probe.LastMode==UnityEngine.SceneManagement.LoadSceneMode.Single&&Probe.LastActivate&&Probe.LastPriority==100,"Original scene load arguments changed");Probe.AddedTimer(30);Assert(Probe.Trace.Last()=="ReportGamePlayTime:30","Timer report forwarding mismatch");
  });
  Test("ready_exit_dispatches_before_original_exit_state","0x43A0B7C",()=>{
   Reset(Task.CompletedTask,Task.CompletedTask);var star=new ProcedureStarGame();var owner=new Owner();star.OnInit(owner);star.OnEnter(owner);Probe.Trace.Clear();Probe.AddedEvent(new object[]{"ignored"});Assert(Probe.Trace.SequenceEqual(new[]{"SendMessage:MineGameExitLogic","ChangeState:ProcedureExitGame"}),"Exit event/state order mismatch");Assert(ReferenceEquals(Probe.LastOwner,owner)&&Probe.LastStateArgs.Length==0,"Exit owner/args mismatch");
  });
  Test("leave_removes_saved_timer_and_installs_original_reporting_lambda","0x43A0C60 + 0x43A0DD0",()=>{
   Reset(Task.CompletedTask,Task.CompletedTask);var star=new ProcedureStarGame();var owner=new Owner();star.OnInit(owner);star.OnEnter(owner);var registered=Probe.AddedTimer;var eventRegistered=Probe.AddedEvent;Probe.Trace.Clear();star.OnLeave(owner,true);Assert(Probe.Trace.SequenceEqual(new[]{"base.OnLeave:True","RemoveLoopTimer:77","RemoveEvent:ReadyExitGame"}),"Original removal ordering mismatch");Assert(Probe.RemovedId==77&&Probe.RemovedEvent==eventRegistered,"Saved timer id or event identity changed");Assert(Probe.RemovedTimer.Method!=registered.Method&&ReferenceEquals(Probe.RemovedTimer.Target,registered.Target),"Native removal uses a distinct lambda on the same instance");Probe.RemovedTimer(53);Assert(Probe.Trace.Last()=="ReportGamePlayTime:53","Removal completion callback does not forward report");
  });
  Test("unused_test_scene_path_kept_separate","0x43A0B08",()=>{Reset(Task.CompletedTask,Task.CompletedTask);Invoke(new ProcedureStarGame(),"GotoTestScene");Assert(Probe.Trace.SequenceEqual(new[]{"TestScene:MineGameTest"})&&Probe.LastScene==null,"Test-only scene method changed the production request");});
  Test("base_lifecycle_forwarders_are_retained","0x439FEBC/0x439FEC4/0x439FED0/0x43A0C58/0x43A0DC8",()=>{Reset(Task.CompletedTask,Task.CompletedTask);var owner=new Owner();var pre=new ProcedurePreLoad();pre.OnUpdate(owner,1,2);pre.OnLeave(owner,false);pre.OnDestroy(owner);var star=new ProcedureStarGame();star.OnUpdate(owner,3,4);star.OnDestroy(owner);Assert(Probe.Trace.SequenceEqual(new[]{"base.OnUpdate","base.OnLeave:False","base.OnDestroy","base.OnUpdate","base.OnDestroy"}),"Base lifecycle forwarding mismatch");});
  var result=new{scope="Actual two Procedure source files with instrumented CLR boundaries; no Unity/SDK/network execution; not original gameplay acceptance",tests=Results,passed=Results.Count,failed=0,unityRuntimeAccepted=false};System.IO.File.WriteAllText(System.IO.Path.Combine(AppContext.BaseDirectory,"../../../../clr-control-flow-results.json"),JsonSerializer.Serialize(result,new JsonSerializerOptions{WriteIndented=true}));Console.WriteLine("PASS "+Results.Count+" native-grounded CLR control-flow cases; actual Procedure source copies; Unity not run");return 0;
 }
 static void Reset(Task init,Task loc,string channel="ordinary"){context=new CaptureContext();SynchronizationContext.SetSynchronizationContext(context);Probe.Reset(init,loc,channel);}
 static int Index(string text){return Probe.Trace.IndexOf(text);}
 static void Assert(bool value,string message){if(!value)throw new Exception(message);}
 static void Invoke(object target,string name,params object[] args){target.GetType().GetMethod(name,BindingFlags.Instance|BindingFlags.NonPublic).Invoke(target,args);}
 static void Test(string name,string native,Action action){try{action();Results.Add(new{name,nativeBasis=native,passed=true,trace=Probe.Trace.ToArray()});}catch(Exception ex){Console.Error.WriteLine("FAIL "+name+": "+ex);throw;}}
}
