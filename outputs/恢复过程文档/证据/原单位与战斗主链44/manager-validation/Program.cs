using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
class Program {
 static int checks,failures,scenarios;
 static void Check(bool b,string name){checks++;if(!b){failures++;if(failures<15)Console.WriteLine("FAIL "+name);}}
 static State Fresh(){QuickTutor.TutorialManager.Instance=new();EventModule.EventManager.ThrowOn=null;BattleGameSceneManager.Instance=new();Time.timeScale=1;Time.deltaTime=.2f;Time.DeltaReads=0;GamePanelManager.Instance=new();UniTask.Predicate=null;UniTask.Gate=null;return new State();}
 static string Json(object x)=>JsonSerializer.Serialize(x);
 static async Task Main(string[] args){
 foreach(var row in JsonDocument.Parse(File.ReadAllText(args[0])).RootElement.EnumerateArray()){
  scenarios++;try {
  var s=Fresh();string kind=row.GetProperty("kind").GetString();
  if(kind=="coin"){
   s.hasCoin=row.GetProperty("has").GetInt32();s.battleTotalEarned=row.GetProperty("earned").GetInt32();s.battleTotalCost=row.GetProperty("cost").GetInt32();s.ChangeCoin(row.GetProperty("delta").GetInt32());
   Check(new[]{s.hasCoin,s.battleTotalEarned,s.battleTotalCost}.SequenceEqual(row.GetProperty("after").EnumerateArray().Select(x=>x.GetInt32())),"coin fields");
  } else {
   var scene=BattleGameSceneManager.Instance;scene.PlayerHasHex=row.GetProperty("pHex").GetInt32();scene.EnemyHasHex=row.GetProperty("eHex").GetInt32();
   scene.allPlayerRoleObj.AddRange(Enumerable.Range(0,row.GetProperty("pRole").GetInt32()).Select(_=>new GameObject()));scene.allEnemyRoleObj.AddRange(Enumerable.Range(0,row.GetProperty("eRole").GetInt32()).Select(_=>new GameObject()));
   Time.timeScale=BitConverter.Int32BitsToSingle(row.GetProperty("scaleBits").GetInt32());if(row.GetProperty("coroutine").GetBoolean())s._myCoroutine=new();s.CountDownEnd();
   Check(BitConverter.SingleToInt32Bits(s._timeLeft)==row.GetProperty("timeBits").GetInt32(),"countdown time");Check(s.isCountDowning==row.GetProperty("isCountDowning").GetBoolean(),"countdown gate");
  }
  Check(Json(s.Trace)==JsonSerializer.Serialize(row.GetProperty("trace")),kind+" native calls");
  }catch(Exception e){failures++;Console.WriteLine("FAIL oracle exception "+e.GetType().Name);}
 }
 if(args.Length>1&&args[1]=="baseline") { Console.WriteLine(Json(new{scenarios,checks,failures,negativeControl=true}));Environment.ExitCode=failures==0?0:1;return; }
 foreach(var row in JsonDocument.Parse(File.ReadAllText(Path.Combine(Path.GetDirectoryName(args[0]),"../manager-review-validation/update-native.json"))).RootElement.GetProperty("cases").EnumerateArray()) {
  scenarios++;var s=Fresh();s.isCountDowning=row.GetProperty("isCountDowning").GetBoolean();s.hornIng=row.GetProperty("hornIng").GetBoolean();s.hornTime=BitConverter.Int32BitsToSingle(unchecked((int)row.GetProperty("hornTimeBits").GetUInt32()));Time.deltaTime=BitConverter.Int32BitsToSingle(row.GetProperty("deltaTimeBits").GetInt32());s.Update();
  Check(unchecked((uint)BitConverter.SingleToInt32Bits(s.hornTime))==row.GetProperty("afterBits").GetUInt32(),"Update native float bits");Check(Time.DeltaReads==row.GetProperty("deltaTimeCalls").GetInt32(),"Update deltaTime gate");
 }
 // Exceptions and reentrancy reveal order, not just final field values.
 {scenarios++;var s=Fresh();s.hasCoin=5;EventModule.EventManager.ThrowOn="PlayerGameCostCoin";try{s.ChangeCoin(-8);Check(false,"cost event must throw");}catch(InvalidOperationException){}Check(s.hasCoin==5&&s.battleTotalCost==0,"cost event before mutation");}
 {scenarios++;var s=Fresh();s.RecordDamage("a",int.MaxValue);s.RecordDamage("a",1);s.RecordBuildDamage("a",4);s.RecordCardCount("x");s.RecordCardCount("x");Check(s.roleAllDamageDic["a"]==int.MinValue&&s.towerAllDamageDic["a"]==4&&s.cardOpenCount["x"]==2,"records+wrap");}
 {scenarios++;var s=Fresh();var first=new DeadUnitInfo();s.AddDeadUnit(9,first);s.AddDeadUnit(9,new());Check(ReferenceEquals(s.GameDeadUnitInfoDic[9],first),"dead duplicate keeps first");s.RemoveDeadUnit(8);s.RemoveDeadUnit(9);Check(s.GameDeadUnitInfoDic.Count==0,"remove absent/present");}
 {scenarios++;var s=Fresh();s._timeLeft=65.9f;s.countDownTime=180;Check(s.GetTimeCutDownString()=="1:05"&&s.ElapseTime==180-65.9f,"time formatting");s._timeLeft=60;Check(s.GetTimeCutDownString()=="1:00","zero seconds");}
 {scenarios++;var s=Fresh();s.hornTime=.1f;s.hornIng=true;s.isCountDowning=true;s.Update();Check(s.hornTime<0,"horn no clamp");s.Update();Check(s.hornTime<0,"horn stop after crossing");}
 {scenarios++;var s=Fresh();Check(!s.IsGamePaused,"unpaused");QuickTutor.TutorialManager.Instance.tutorialing=true;Check(s.IsGamePaused,"tutorial pause");}
 {scenarios++;var s=Fresh();var task=s.BeginStartCountDown(null);Check(!task.IsCompleted&&!s.isCountDowning,"wait remains pending");s.CloseMatchPanel(null);UniTask.Tick();await task;Check(s.isCountDowning&&s.Trace.Count==2,"start after true predicate");s.Trace.Clear();await s.BeginStartCountDown(null);Check(s.Trace.Count==0,"repeat start gate");}
 {scenarios++;var s=Fresh();s._timeLeft=11;s._isGamePaused=true;var it=s.Countdown();Check(it.MoveNext()&&((WaitForSeconds)it.Current).seconds==.1f,"paused polling yield");Check(s._timeLeft==11,"pause no time decrement");s._isGamePaused=false;Check(it.MoveNext()&&((WaitForSeconds)it.Current).seconds==1,"one second yield");UnityEngine.Random.Value=79;it.MoveNext();Check(s._timeLeft==10&&s.Trace.Any(t=>(string)t[0]=="CountDownIsTen"),"decrement after yield and random inclusive79");}
 {scenarios++;var s=Fresh();s._timeLeft=1;s._isGamePaused=true;var it=s.Countdown();it.MoveNext();s._timeLeft=0;s._isGamePaused=false;Check(it.MoveNext()&&((WaitForSeconds)it.Current).seconds==1,"paused resume skips outer time gate exactly as native state1");}
 {scenarios++;var s=Fresh();s.gameEndCallBack=x=>{s.EndTrace.Add("callback");Check(s.hasCoin==13,"callback before reset");};s.hasCoin=13;s.cardOpenCount["x"]=1;s.EndGame();Check(s.EndTrace[0]=="callback"&&s.hasCoin==0&&s.cardOpenCount.Count==0&&s.hornTime==5,"end reset order");}
 {scenarios++;var s=Fresh();s.hasCoin=14;s.gameEndCallBack=x=>throw new InvalidOperationException();try{s.EndGame();Check(false,"callback throws");}catch(InvalidOperationException){}Check(s.hasCoin==14&&s.gameEndCallBack!=null,"exception prevents cleanup");}
 {scenarios++;var s=Fresh();HWGPUInstancerManager.Supported=false;var a=new Animator{speed=1.7f};var go=new GameObject{Animators=new[]{a}};BattleGameSceneManager.Instance.allPlayerRoleObj.Add(go);s.SetGamePaused(true);Check(a.speed==0&&s._pausedRoleAnimationSnapshots.Count==1,"animator paused");s.SetGamePaused(true);s.SetGamePaused(false);Check(a.speed==1.7f&&s._pausedRoleAnimationSnapshots.Count==0,"repeat pause keeps original speed");}
 {scenarios++;var s=Fresh();var a=new Animator{speed=2};var go=new GameObject{Animators=new[]{a}};s.ApplyAnimationPauseToSingleRole(go,true);var added=new Animator{speed=0};go.Animators=new[]{a,added};s.ApplyAnimationPauseToSingleRole(go,false);Check(a.speed==2&&added.speed==1,"resume new animator fallback");}
 {scenarios++;var s=Fresh();HWGPUInstancerManager.Supported=true;var ani=new AnimationInstancing.AnimationInstancing{Alive=false};var role=new RoleBehaviour{Animation=ani,Driver=RoleAnimationDriverType.AniInstancing};var crowd=new GPUInstancer.CrowdAnimations.GPUICrowdPrefab();var go=new GameObject();go.Parts[typeof(RoleBehaviour)]=role;go.Parts[typeof(GPUInstancer.CrowdAnimations.GPUICrowdPrefab)]=crowd;s.ApplyAnimationPauseToSingleRole(go,true);Check(crowd.Calls==0&&ani.PauseCalls==0,"destroyed instancing keeps managed type branch, no GPU fallback");}
 {scenarios++;var s=Fresh();HWGPUInstancerManager.Supported=true;var animation=new GPUInstanceAnimationBehaviour{speed=1.4f};var role=new RoleBehaviour{Animation=animation};var crowd=new GPUInstancer.CrowdAnimations.GPUICrowdPrefab();var go=new GameObject();go.Parts[typeof(RoleBehaviour)]=role;go.Parts[typeof(GPUInstancer.CrowdAnimations.GPUICrowdPrefab)]=crowd;s.ApplyAnimationPauseToSingleRole(go,true);Check(crowd.Speed==0,"GPU paused");s.ApplyAnimationPauseToSingleRole(go,false);Check(crowd.Speed==1.4f,"GPU speed restored");}
 Console.WriteLine(Json(new{scenarios,checks,failures}));Environment.ExitCode=failures==0?0:1;
 }
}
