using System;
using System.Collections.Generic;
using System.Threading.Tasks;
public static class Env {
 public static State Current;public static List<string> Trace=new();public static List<string> Observations=new();
 public static TaskCompletionSource InitGate,DelayGate,HideGate;public static int ListenerFailAt;public static string ThrowEvent;
 public static int BuffAdd;public static bool Guided,FirstThrough,Weekly,PanelShowing;public static List<int> Cards=new();public static int GuidedCoin;
 public static void Log(string s)=>Trace.Add(s);public static string N(object o)=>o?.ToString()??"null";
 public static TaskCompletionSource Gate()=>new(TaskCreationOptions.RunContinuationsAsynchronously);
 public static State Fresh(){Trace=new();Observations=new();InitGate=Gate();DelayGate=Gate();HideGate=Gate();ListenerFailAt=0;ThrowEvent=null;BuffAdd=0;Guided=false;FirstThrough=false;Weekly=false;PanelShowing=true;Cards=new(){101,101,202};GuidedCoin=777;CoreGameManager.RawGaming=true;CoreGameManager.NowPlayEdArenaID=null;DataModule.DataManager.Instance=new();GamePanelManager.Instance=new();BattleFPSController.Instance=new();EventModule.EventManager.Instance=new();Current=new State();return Current;}
}
public class DeadUnitInfo { }
public class BattleContext {public int GameType;public Action<bool> gameEndCallBack,gameEndApplyRewardCallBack;}
public class SnapshotMap:Dictionary<int,int> {public new void Clear(){Env.Log("snapshots:clear");base.Clear();}}
public partial class State {
 public int hasCoin,battleInitCoin,battleTotalEarned,battleTotalCost,countDownTime,GameType;
 public bool isVictory,isCountDowning,_isAddCoining,_isGamePaused;public float _timeLeft;public string _timeString;public object _myCoroutine;
 public BattleContext _battleContext;public Action<bool> gameEndCallBack,applyRewardCallBack;public SnapshotMap _pausedRoleAnimationSnapshots=new();
 Dictionary<string,int> role,tower,card;Dictionary<int,DeadUnitInfo> dead;
 public Dictionary<string,int> roleAllDamageDic{get=>role;set{role=value;Env.Log("dict:role");}}
 public Dictionary<string,int> towerAllDamageDic{get=>tower;set{tower=value;Env.Log("dict:tower");}}
 public Dictionary<string,int> cardOpenCount{get=>card;set{card=value;Env.Log("dict:card");}}
 public Dictionary<int,DeadUnitInfo> GameDeadUnitInfoDic{get=>dead;set{dead=value;Env.Log("dict:dead");}}
 public bool IsGamePaused{get=>_isGamePaused;set{_isGamePaused=value;Env.Log("paused:"+value);}}
 public string GetTimeCutDownString(){Env.Log("format:"+_timeLeft);return "formatted:"+_timeLeft;}
 public void BeginStartCountDown(object o){Env.Log("begin-countdown:"+Env.N(o));}
 public void StopCoroutine(object c){Env.Log("stop-coroutine");Env.Observations.Add("stop:counting="+isCountDowning);}
 public void CoinChangeUpdateGamePanel(object o){}public void GameEndCheck(object o){}public void PlayerOpenHexCountAdd(object o){}public void PlayerHornEmitIng(object o){}public void ShowInterstitial(object o){}public void PlayerHornEmitEnd(object o){}public void SettlementAnimationEnd(object o){}public void BetRecordRewardNum(object o){}public void GuidOneEndAddCoin(object o){}public void CloseMatchPanel(object o){}public void OnPauseGame(object o){}public void OnResumeGame(object o){}
}
public class FloatingTextManager {public static FloatingTextManager Instance=new();public Task Init(){Env.Log("floating:init");return Env.InitGate.Task;}}
namespace EventModule {public class EventManager {public static EventManager Instance=new();public List<(string,Action<object>)> Listeners=new();public void StartListening(string name,Action<object> callback){Env.Log("listen:"+name+":"+callback.Method.Name);Env.Observations.Add("listen:dictsNull="+(Env.Current.roleAllDamageDic==null&&Env.Current.towerAllDamageDic==null&&Env.Current.cardOpenCount==null&&Env.Current.GameDeadUnitInfoDic==null));Listeners.Add((name,callback));if(Env.ListenerFailAt>0&&Listeners.Count==Env.ListenerFailAt)throw new InvalidOperationException("listener");}public void TriggerEvent(string name,object arg=null){Env.Log("event:"+name);if(name=="WeeklyCardActivityTaskTrigger"){var a=(object[])arg;Env.Observations.Add("weekly:"+(int)(WeeklyCardActivityManager.WeekLyTaskType)a[0]+":"+a[1]);}if(name=="GameEnd")Env.Observations.Add("event:gaming="+CoreGameManager.RawGaming+":victory="+Env.Current.isVictory+":counting="+Env.Current.isCountDowning);if(Env.ThrowEvent==name)throw new InvalidOperationException("event");}}}
public class WeeklyCardActivityManager {public enum WeekLyTaskType{PlayGames,GameWin}public static WeeklyCardActivityManager Instance=new();public bool IsBTest(){Env.Log("weekly:check");return Env.Weekly;}}
public class GamePanelManager {public static GamePanelManager Instance=new();public List<object[]> Calls=new();public void DoAni(){Env.Log("panel:ani");Env.Observations.Add("ani:victory="+Env.Current.isVictory);}public void UpdateInfo(object[] a){Env.Log("panel:update:"+a[0]+":"+a[1]);Calls.Add((object[])a.Clone());}}
public static class CoreGameManager {public static string NowPlayEdArenaID;public static bool RawGaming;public static bool Gaming{get=>RawGaming;set{RawGaming=value;Env.Log("gaming:"+value);}}}
namespace QuickTutor {public class TutorialManager {public static TutorialManager Instance=new();public void ForceCloseTutorial(){Env.Log("tutorial:close");}}}
namespace UIFramework {public class UIManager {public static UIManager Instance=new();public const string Panel="Assets/_Res/Addressable/02CoreGameBundle/Prefabs/UI/Panels/HexDescribesPanel.prefab";public bool IsPanelShowing(string path,out object panel){if(path!=Panel)throw new InvalidOperationException("panel path");Env.Log("ui:is-showing");panel=new object();return Env.PanelShowing;}public Task HidePanel(string path){if(path!=Panel)throw new InvalidOperationException("panel path");Env.Log("ui:hide");return Env.HideGate.Task;}}}
public static class UniTask {public static Task WaitForSeconds(float seconds){Env.Log("delay:"+seconds);if(BitConverter.SingleToInt32Bits(seconds)!=BitConverter.SingleToInt32Bits(2.3f))throw new InvalidOperationException("delay ABI");return Env.DelayGate.Task;}}
public class BattleGameSceneManager {public static BattleGameSceneManager Instance=new();public void SettlementAnimation(bool victory){Env.Log("settlement:"+victory);Env.Observations.Add("settlement:counting="+Env.Current.isCountDowning+":gaming="+CoreGameManager.RawGaming);}}
namespace ToolModule {public static class StringTool {public static bool IsNullOrEmpty(string s,bool trimSpaces=true){Env.Log("string:null-check:"+Env.N(s));return string.IsNullOrEmpty(trimSpaces?s?.Trim():s);}public static int ToInt(string s){Env.Log("string:parse:"+s);return int.Parse(s);}}}
namespace DataModule {public class GlobalArenaInfo {public string countDownTime;}public class ArenaMap:Dictionary<string,GlobalArenaInfo>{public new GlobalArenaInfo this[string id]{get{Env.Log("config:arena:"+id);return base[id];}set=>base[id]=value;}}public class GlobalInfo {public ArenaMap arenaInfoDic=new();}public class DataManager {public static DataManager Instance=new();public GlobalInfo GlobalInfo=new();}}
public class SubGameBuffManager {public static SubGameBuffManager Instance=new();public void ModifyCountDownTime(ref int t){Env.Log("buff:time:"+t);t+=Env.BuffAdd;}}
public class TrainingGroundManager {public static TrainingGroundManager Instance=new();public static bool IsInGuidedGame{get{Env.Log("training:check");return Env.Guided;}}public int GetPlayerInitialCoin(){Env.Log("training:coin");return Env.GuidedCoin;}}
public class GuideData {public bool isFirstThroghGame{get{Env.Log("guide:first-through");return Env.FirstThrough;}}}
public class DbtSaveDataManager_PlayerGuideData {public static DbtSaveDataManager_PlayerGuideData I=new();public GuideData Data=new();}
public class CardData {public List<int> GetBattleCardIDList(){Env.Log("card:get-list");return Env.Cards;}}
public class DbtSaveDataManager_PlayerCardData {public static DbtSaveDataManager_PlayerCardData I=new();public CardData Data=new();}
public static class CheatControl {public static void ResetPerfStates(){Env.Log("perf:reset");}}
public class BattleFPSController {public static BattleFPSController Instance=new();public void StartMonitoring(){Env.Log("fps:start");}}
