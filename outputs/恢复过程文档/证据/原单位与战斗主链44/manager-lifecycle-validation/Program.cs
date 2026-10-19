using System.Text.Json;
int checks=0,failures=0,scenarios=0;var results=new List<object>();
void Check(string n,bool ok){checks++;if(!ok){failures++;if(failures<=24)Console.WriteLine("FAIL "+n);}}
bool Trace(params string[] expected)=>Env.Trace.SequenceEqual(expected);
async Task Case(string name,Func<Task> test){scenarios++;int before=failures;try{await test();}catch(Exception e){Check(name+" unexpected "+e,false);}results.Add(new{name,failures=failures-before,trace=Env.Trace.ToArray(),observations=Env.Observations.ToArray()});}
await Case("Init awaits success and preserves 13 listener+4 dictionary order",async()=>{
 var s=Env.Fresh();var task=s.Init();Check("Init gated",!task.IsCompleted);Check("Init no premature side effects",Trace("floating:init")&&s.roleAllDamageDic==null&&s.GameDeadUnitInfoDic==null);
 Env.InitGate.SetResult();await task;
 string[] listeners={"CoinChangeUpdateGamePanel:CoinChangeUpdateGamePanel","HasHexDestroy:GameEndCheck","PlayerBeginOpenHex:PlayerOpenHexCountAdd","PlayerHornEmitIng:PlayerHornEmitIng","OnGameOver:ShowInterstitial","PlayerHornEmitEnd:PlayerHornEmitEnd","SettlementAnimationEnd:SettlementAnimationEnd","BetStartGame:BetRecordRewardNum","GameSteerEndShowCardProbabilityPanel:BeginStartCountDown","GameSteerEndShowCardProbabilityPanel:GuidOneEndAddCoin","CloseMatchPanel:CloseMatchPanel","PauseGame:OnPauseGame","ResumeGame:OnResumeGame"};
 Check("13 exact listeners/order",Env.Trace.SequenceEqual(new[]{"floating:init"}.Concat(listeners.Select(x=>"listen:"+x)).Concat(new[]{"dict:role","dict:tower","dict:card","dict:dead"})));
 Check("all dictionaries after listeners",Env.Observations.Count==13&&Env.Observations.All(x=>x=="listen:dictsNull=True"));Check("four allocated empty dictionaries",s.roleAllDamageDic?.Count==0&&s.towerAllDamageDic?.Count==0&&s.cardOpenCount?.Count==0&&s.GameDeadUnitInfoDic?.Count==0);Check("separate string dictionaries",!ReferenceEquals(s.roleAllDamageDic,s.towerAllDamageDic)&&!ReferenceEquals(s.roleAllDamageDic,s.cardOpenCount));
});
await Case("Init floating failure never registers or creates",async()=>{
 var s=Env.Fresh();var task=s.Init();Env.InitGate.SetException(new InvalidOperationException("floating failed"));bool threw=false;try{await task;}catch(InvalidOperationException){threw=true;}Check("Init dependency fault preserved",threw);Check("Init fault side effects",Trace("floating:init")&&EventModule.EventManager.Instance.Listeners.Count==0&&s.roleAllDamageDic==null&&s.cardOpenCount==null);
});
await Case("Init listener failure stops at exact registration",async()=>{
 var s=Env.Fresh();Env.ListenerFailAt=6;Env.InitGate.SetResult();bool threw=false;try{await s.Init();}catch(InvalidOperationException){threw=true;}Check("listener fault propagated",threw);Check("sixth listener stops remaining",EventModule.EventManager.Instance.Listeners.Count==6);Check("listener fault no dictionaries",s.roleAllDamageDic==null&&s.towerAllDamageDic==null&&s.cardOpenCount==null&&s.GameDeadUnitInfoDic==null);
});
foreach(bool victory in new[]{false,true})foreach(bool weekly in new[]{false,true})foreach(bool animation in new[]{false,true})foreach(bool showing in new[]{false,true})foreach(bool coroutine in new[]{false,true}){
 var label=$"GameEnd v={victory} weekly={weekly} ani={animation} panel={showing} coroutine={coroutine}";
 await Case(label,async()=>{
  var s=Env.Fresh();Env.Weekly=weekly;Env.PanelShowing=showing;s.isCountDowning=true;s._myCoroutine=coroutine?new object():null;
  var task=s.GameEnd(victory,animation);Check("GameEnd delay gate",task.IsCompleted==!animation);Check("HidePanel returned task remains pending",!Env.HideGate.Task.IsCompleted);
  var expected=new List<string>();if(victory){expected.Add("weekly:check");if(weekly)expected.Add("event:WeeklyCardActivityTaskTrigger");}if(animation)expected.Add("panel:ani");expected.Add("gaming:False");expected.Add("event:GameEnd");if(coroutine)expected.Add("stop-coroutine");expected.Add("tutorial:close");expected.Add("ui:is-showing");if(showing)expected.Add("ui:hide");if(animation)expected.Add("delay:2.3");else expected.Add("settlement:"+victory);
  Check("GameEnd exact before-await sequence",Env.Trace.SequenceEqual(expected));Check("GameEnd state before settlement",s.isVictory==victory&&!s.isCountDowning&&!CoreGameManager.RawGaming);Check("GameEnd event pre-stop observation",Env.Observations.Contains("event:gaming=False:victory="+victory+":counting=True"));if(coroutine)Check("stop sees counting already false",Env.Observations.Contains("stop:counting=False"));if(victory&&weekly)Check("weekly original enum+amount",Env.Observations.Contains("weekly:1:1"));
  if(animation){Check("settlement waits 2.3",!Env.Trace.Any(x=>x.StartsWith("settlement:")));Env.DelayGate.SetResult();await task;expected.Add("settlement:"+victory);Check("GameEnd settlement after delay",Env.Trace.SequenceEqual(expected));}else await task;
  Check("GameEnd never awaits HidePanel",task.IsCompletedSuccessfully&&!Env.HideGate.Task.IsCompleted);Check("settlement observes end state",Env.Observations.Contains("settlement:counting=False:gaming=False"));
 });
}
await Case("GameEnd event fault stops later side effects",async()=>{
 var s=Env.Fresh();s.isCountDowning=true;s._myCoroutine=new();Env.ThrowEvent="GameEnd";bool fault=false;try{await s.GameEnd(false,true);}catch(InvalidOperationException){fault=true;}Check("GameEnd event failure observable",fault);Check("event failure exact prefix",Trace("panel:ani","gaming:False","event:GameEnd"));Check("event failure preserves later state",s.isCountDowning&&!Env.Trace.Contains("stop-coroutine")&&!Env.Trace.Any(x=>x.StartsWith("settlement:")));
});
foreach(string arena in new string[]{null,"","   ","2042"})foreach(bool guided in new[]{false,true})foreach(bool first in new[]{false,true})foreach(bool existing in new[]{false,true})foreach(bool fps in new[]{false,true}){
 await Case($"StartGame arena={arena??"null"} guided={guided} first={first} existing={existing} fps={fps}",()=>{
  var s=Env.Fresh();CoreGameManager.NowPlayEdArenaID=arena;Env.Guided=guided;Env.FirstThrough=first;Env.BuffAdd=13;s.hasCoin=7;s.battleTotalCost=901;s._isGamePaused=true;s._pausedRoleAnimationSnapshots[5]=2;if(!fps)BattleFPSController.Instance=null;
  string chosen=string.IsNullOrWhiteSpace(arena)?"1001":arena;DataModule.DataManager.Instance.GlobalInfo.arenaInfoDic[chosen]=new(){countDownTime="347"};DataModule.DataManager.Instance.GlobalInfo.arenaInfoDic["unused"]=new(){countDownTime="999"};
  if(existing){s.cardOpenCount=new(){["101"]=7,["303"]=9};Env.Trace.Clear();}var oldCard=s.cardOpenCount;Action<bool> end=_=>{};Action<bool> reward=_=>{};var context=new BattleContext{GameType=27,gameEndCallBack=end,gameEndApplyRewardCallBack=reward};
  s.StartGame(context);int coin=guided?777:first?150:50;
  Check("StartGame actual config consumed and buff",s.countDownTime==360&&s._timeLeft==360&&s._timeString=="formatted:360");Check("StartGame selected arena",Env.Trace.Contains("config:arena:"+chosen)&&!Env.Trace.Contains("config:arena:unused"));
  Check("StartGame buff before clock/UI",Env.Trace.IndexOf("buff:time:347")<Env.Trace.IndexOf("format:360")&&Env.Trace.IndexOf("format:360")<Env.Trace.FindIndex(x=>x.StartsWith("panel:update:")));
  Check("UI receives pre-init coin",GamePanelManager.Instance.Calls.Count==1&&(int)GamePanelManager.Instance.Calls[0][0]==7&&(string)GamePanelManager.Instance.Calls[0][1]=="formatted:360");Check("initial coins/counters",s.hasCoin==coin&&s.battleInitCoin==coin&&s.battleTotalEarned==coin&&s.battleTotalCost==0&&s._isAddCoining);
  Check("tutorial gate preserved",Env.Trace.Contains("begin-countdown:null")==!first);Check("context and callback identity",s.GameType==27&&ReferenceEquals(s._battleContext,context)&&ReferenceEquals(s.gameEndCallBack,end)&&ReferenceEquals(s.applyRewardCallBack,reward));Check("pause fields reset and snapshots clear",!s._isGamePaused&&s._pausedRoleAnimationSnapshots.Count==0);
  Check("pause/perf/fps order",Env.Trace.IndexOf("paused:False")<Env.Trace.IndexOf("snapshots:clear")&&Env.Trace.IndexOf("snapshots:clear")<Env.Trace.IndexOf("perf:reset")&&(!fps||Env.Trace.IndexOf("perf:reset")<Env.Trace.IndexOf("fps:start")));
  Check("fps optional",Env.Trace.Contains("fps:start")==fps);Check("cards after initialization",Env.Trace.IndexOf("perf:reset")<Env.Trace.IndexOf("card:get-list"));
  Check("duplicate card does not reset",s.cardOpenCount!=null&&s.cardOpenCount.TryGetValue("101",out int count101)&&count101==(existing?7:0)&&s.cardOpenCount.TryGetValue("202",out int count202)&&count202==0&&(!existing||(s.cardOpenCount.TryGetValue("303",out int count303)&&count303==9)));Check("existing dictionary identity retained",!existing||ReferenceEquals(oldCard,s.cardOpenCount));Check("dictionary created only as needed",Env.Trace.Contains("dict:card")==!existing);return Task.CompletedTask;
 });
}
await Case("StartGame missing arena fails before buff/UI/coins",()=>{
 var s=Env.Fresh();s.hasCoin=8;CoreGameManager.NowPlayEdArenaID="missing";bool fault=false;try{s.StartGame(new());}catch(KeyNotFoundException){fault=true;}Check("missing config remains failure",fault);Check("missing config no invented fallback",s.hasCoin==8&&!Env.Trace.Any(x=>x.StartsWith("buff:")||x.StartsWith("panel:")));return Task.CompletedTask;
});
await Case("StartGame null context preserves native partial order",()=>{
 var s=Env.Fresh();s.hasCoin=7;DataModule.DataManager.Instance.GlobalInfo.arenaInfoDic["1001"]=new(){countDownTime="121"};bool fault=false;try{s.StartGame(null);}catch(NullReferenceException){fault=true;}Check("null context remains failure",fault);Check("null context fails after original pre-context operations",s.hasCoin==50&&s.battleInitCoin==50&&s._isAddCoining&&Env.Trace.Contains("begin-countdown:null"));Check("null context before pause/perf",!Env.Trace.Contains("paused:False")&&!Env.Trace.Contains("perf:reset"));return Task.CompletedTask;
});
var summary=new{scenarios,checks,failures};Console.WriteLine(JsonSerializer.Serialize(summary));File.WriteAllText(args[0],JsonSerializer.Serialize(new{summary,results},new JsonSerializerOptions{WriteIndented=true}));Environment.ExitCode=failures==0?0:1;

