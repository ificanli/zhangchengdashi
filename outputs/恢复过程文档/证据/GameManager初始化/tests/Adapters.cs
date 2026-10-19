using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
public static class Env
{
 public static readonly List<string> Trace=new();public static readonly Dictionary<string,TaskCompletionSource> Held=new();public static readonly Dictionary<string,Action> Hooks=new();public static readonly List<IEnumerator> Coroutines=new();
 public static Task Begin(string name){Trace.Add("Init:"+name);if(Hooks.TryGetValue(name,out var hook))hook();return Held.TryGetValue(name,out var t)?t.Task:Task.CompletedTask;}
 public static void Hold(params string[] names){foreach(var name in names)Held[name]=new();}public static void Release(string name)=>Held[name].SetResult();
 public static void Reset()
 {
  Trace.Clear();Held.Clear();Hooks.Clear();Coroutines.Clear();UnityEngine.PlayerPrefs.Values.Clear();EventModule.EventManager.Instance.Listeners.Clear();TimeModuleO.TimeManager.Instance.Reset();QuickTutor.TutorialManager.Instance.Complete.Clear();SDKModule.ABTestManager.Instance.Reset();DbtSaveDataManager_PlayerGuideData.I.Data.isFirstThroghGame=true;DbtSaveDataManager_PlayerShopData.I.Data=new();DbtSaveDataManager_PlayerCoreData.I.Data=new();DbtSaveDataManager_PlayerAdData.I.Data=new();DbtSaveDataManager_PlayerChestData.I.Data=new();UIFramework.UIManager.Instance.Mask=false;GameModule.CoreGameManager.Gaming=false;GameModule.CoreGameManager.NowPlayEdArenaID="1001";GameModule.CoreGameManager.Context=null;GameModule.TrainingGroundManager.IsInTrainingGround=false;GameModule.TrainingGroundManager.IsInGuidedGame=false;GameModule.DailyBlessManager.Instance.Test=false;GameModule.BattleGameManager.Instance.Reset();GameModule.ArenaManager.Instance.Reset();GameModule.MonthlyPassManager.Instance.Bought=false;GameModule.SeasonManager.Instance.Exp=0;GameModule.DataNoOp.Reset();GameModule.SubGameChaosTrailsManager.Instance.Last=null;GameConfigModule.GameConfigManager.Instance.Values.Clear();GameConfigModule.GameConfigManager.Instance.Values["NormalPVPWinExp"]=12;GameConfigModule.GameConfigManager.Instance.Values["NormalPVPLoseExp"]=5;GameModule.ReportEventsManager.Instance.ThrowAppOpen=false;GameModule.UpdateController.Constructions=0;
 }
}
public static class TestTasks {public static Task WaitForSeconds(float value){Env.Trace.Add("Wait:"+value);return Env.Begin("WaitForSeconds");}public static void Forget(this Task t)=>Env.Trace.Add("Forget");}
public static class FixedRandomTools {public static void Load()=>Env.Trace.Add("FixedRandom.Load");}
namespace UnityEngine
{
 public class Object {public bool Destroyed;public static bool operator==(Object a,Object b)=>ReferenceEquals(a,b)||(ReferenceEquals(a,null)&&!ReferenceEquals(b,null)&&b.Destroyed)||(ReferenceEquals(b,null)&&!ReferenceEquals(a,null)&&a.Destroyed);public static bool operator!=(Object a,Object b)=>!(a==b);public override bool Equals(object o)=>ReferenceEquals(this,o);public override int GetHashCode()=>base.GetHashCode();}
 public class MonoBehaviour:Object {public void StartCoroutine(IEnumerator e){Env.Trace.Add("StartCoroutine");Env.Coroutines.Add(e);}}
 public class GameObject:Object {public string Name;public bool Active;public static GameObject Find(string n){Env.Trace.Add("Find:"+n);return new(){Name=n};}public void SetActive(bool value){Active=value;Env.Trace.Add("Active:"+Name+":"+value);}}
 public class WaitForSeconds {public float Value;public WaitForSeconds(float value)=>Value=value;}
 public static class Time {public static float deltaTime=.02f;}
 public static class Debug {public static void Log(object value)=>Env.Trace.Add("Log:"+value);}
 public static class Mathf {public static int Min(int a,int b)=>Math.Min(a,b);}
 public static class PlayerPrefs {public static Dictionary<string,int> Values=new();public static bool HasKey(string key){Env.Trace.Add("HasKey:"+key);return Values.ContainsKey(key);}public static void SetInt(string key,int value){Env.Trace.Add("SetInt:"+key+":"+value);Values[key]=value;}}
}
namespace EventModule {public class EventManager {public static EventManager Instance{get;}=new();public readonly Dictionary<string,Action<object>> Listeners=new();public void StartListening(string name,Action<object> action){Env.Trace.Add("Listen:"+name);Listeners.TryGetValue(name,out var prev);Listeners[name]=prev+action;}public void TriggerEvent(string name,object value=null){Env.Trace.Add("Event:"+name);if(Listeners.TryGetValue(name,out var action))action?.Invoke(value);}}}
namespace QuickTutor {public class TutorialManager {public static TutorialManager Instance{get;}=new();public HashSet<string> Complete=new();public bool IsStepComplete(string key){Env.Trace.Add("Tutorial:"+key);return Complete.Contains(key);}}}
namespace SDKModule {public class ABTestManager {public static ABTestManager Instance{get;}=new();public bool WeeklyClashImprove02IsBTest,SelectableOfferIsOn,GameCenterIsBTest,NoBetIsBTest,NewArenaProcessIsBTest,SeasonIsBTest;public void Reset(){WeeklyClashImprove02IsBTest=SelectableOfferIsOn=GameCenterIsBTest=NoBetIsBTest=NewArenaProcessIsBTest=SeasonIsBTest=false;}}public class GameCenterManager {public static GameCenterManager Instance{get;}=new();public Task Init()=>Env.Begin("GameCenterManager");public Task AllowGameCenter()=>Env.Begin("AllowGameCenter");}}
namespace TimeModuleO
{
 public class TimeManager
 {
  public class Timer {public DateTime StartTime=new(2026,1,1),TargetEndTime=new(2026,1,3);public TimeSpan Remaining=TimeSpan.FromDays(1);public readonly string Key;public Timer(string key)=>Key=key;public void Restart(TimeSpan d,bool down){Env.Trace.Add("Restart:"+Key+":"+d.TotalDays+":"+down);}public TimeSpan GetRemainingTime()=>Remaining;}
  public static TimeManager Instance{get;}=new();public readonly Dictionary<string,Timer> Timers=new();public readonly List<Action> Daily=new(),Weekly=new();public bool initComplete=true,IsNetworkConnected=true;
  public void Reset(){Timers.Clear();Daily.Clear();Weekly.Clear();initComplete=true;IsNetworkConnected=true;}
  public Timer GetTimer(string key){Env.Trace.Add("GetTimer:"+key);return Timers.GetValueOrDefault(key);}
  public Timer CreateTimer(string key,TimeSpan d,bool down,bool network){Env.Trace.Add("CreateTimer:"+key+":"+d.TotalDays+":"+down+":"+network);var t=new Timer(key);t.Remaining=d;Timers[key]=t;return t;}
  public void RegisterOnTimeToZero(Action action){Env.Trace.Add("RegisterDaily");Daily.Add(action);}public void RegisterOnWeekPassed(Action action){Env.Trace.Add("RegisterWeekly");Weekly.Add(action);}
 }
}
namespace DataModule
{
 public class PlayerGuideData {public bool isFirstThroghGame;}
 public class PlayerShopData {public bool timingPushGiftPackageCdIng,hadHandleTwoSixOneBug,isShowNewBieGiftPack,canTimingPushGiftPackage;public Dictionary<string,int> cardPackBuyCountNowWeek=new();public Dictionary<string,bool> playerRuneStoneBuyState=new();}
 public class SeasonData {public int PlayerDailyGetSeasonPassCount,PlayerDailyGetSeasonPassScore;}
 public class PlayerCoreData {public bool nowLingquReward;public int PlayerDailyPlayGameCount,PlayerDailyWonGameCount,PlayerWeeklyPlayGameCount,PlayerWeeklyWonGameCount,DailyNoBetGoldEarned;public SeasonData seasonData=new();}
 public class PlayerAdData {public bool ShowInterstitialEd;public void InitializeVideosNumber()=>Env.Trace.Add("InitializeVideos");}
 public class PlayerChestData {public int userGetBoxCount;}
 public class GlobalArenaInfo {public string diamondReward="10",keyReward="2",completeTrophyRequire="100",trophyPunish="7";}
 public class GlobalInfo {public Dictionary<string,GlobalArenaInfo> arenaInfoDic=new(){["1001"]=new(),["1002"]=new()};}
 public class DataManager {public static DataManager Instance{get;}=new();public bool LoadDataCompleted=true;public GlobalInfo GlobalInfo=new();}
}
public class DbtSaveDataManager_PlayerGuideData {public static DbtSaveDataManager_PlayerGuideData I{get;}=new();public DataModule.PlayerGuideData Data=new();}
public class DbtSaveDataManager_PlayerShopData {public static DbtSaveDataManager_PlayerShopData I{get;}=new();public DataModule.PlayerShopData Data=new();public void Save()=>Env.Trace.Add("Save:Shop");}
public class DbtSaveDataManager_PlayerTimeData {public static DbtSaveDataManager_PlayerTimeData I{get;}=new();public void Save()=>Env.Trace.Add("Save:Time");}
public class DbtSaveDataManager_PlayerCoreData {public static DbtSaveDataManager_PlayerCoreData I{get;}=new();public DataModule.PlayerCoreData Data=new();public void Save()=>Env.Trace.Add("Save:Core");}
public class DbtSaveDataManager_PlayerAdData {public static DbtSaveDataManager_PlayerAdData I{get;}=new();public DataModule.PlayerAdData Data=new();public void Save()=>Env.Trace.Add("Save:Ad");}
public class DbtSaveDataManager_PlayerChestData {public static DbtSaveDataManager_PlayerChestData I{get;}=new();public DataModule.PlayerChestData Data=new();public void Save()=>Env.Trace.Add("Save:Chest");}
namespace GameModule
{
 public enum GameType {PVP,PVE,SeasonPVP,SubGamePVP}
 public enum CurrencyTransactionSceneType {none,cheat,shop_related,fetter_giftpack,allfetter_giftpack,game_finish}
 public class BattleResult{}
 public class BattleContext {public bool Show;public Func<bool,RewardConfig> Callback;public GameType GameType;public BattleContext(bool show,object enemy,Func<bool,RewardConfig> callback,object end,object apply){Show=show;Callback=callback;}}
 public class RewardConfigSingle {public string Id,Num;public RewardConfigSingle(string id,string num,List<string> args){Id=id;Num=num;}}
 public class RewardConfig {public CurrencyTransactionSceneType Type;public List<RewardConfigSingle> Assets=new();public RewardConfig(CurrencyTransactionSceneType type)=>Type=type;public void AddAssetDataList(List<RewardConfigSingle> list)=>Assets.AddRange(list);}
 public class CoreGameManager {public static CoreGameManager Instance{get;}=new();public static bool Gaming;public static string NowPlayEdArenaID="1001";public static BattleContext Context;public Task Init()=>Env.Begin("CoreGameManager");public void StartGame(BattleContext context){Context=context;Env.Trace.Add("Core.StartGame");}}
 public class MetaGameManager {public static MetaGameManager Instance{get;}=new();public Task Init()=>Env.Begin("MetaGameManager");public void ShowMetaSwitchPanel(int index)=>Env.Trace.Add("MetaPanel:"+index);}
 public class BattleGameManager:UnityEngine.Object {public static BattleGameManager Instance{get;}=new();public GameType GameType;public string BetRewardNum="50",Trophies="9";public float ElapseTime=20;public RewardConfig rewardConfig,tempConfig;public bool Paused;public void Reset(){GameType=GameType.PVP;BetRewardNum="50";Trophies="9";ElapseTime=20;rewardConfig=tempConfig=null;Paused=false;Destroyed=false;}public void SetGamePaused(bool value){Paused=value;Env.Trace.Add("BattlePause:"+value);}public string GameSuccessGetTrophyNumber()=>Trophies;}
 public class AIBehaviourManager:UnityEngine.Object {public static AIBehaviourManager Instance{get;}=new();public void SetGamePaused(bool value)=>Env.Trace.Add("AIPause:"+value);}
 public class TrainingGroundManager {public static TrainingGroundManager Instance{get;}=new();public static bool IsInTrainingGround,IsInGuidedGame;public Task Init()=>Env.Begin("TrainingGroundManager");public void OnTrainingGameComplete(bool win)=>Env.Trace.Add("TrainingComplete:"+win);}
 public class ArenaManager {public static ArenaManager Instance{get;}=new();public bool Collected;public int Trophies=40;public void Reset(){Collected=false;Trophies=40;}public Task Init()=>Env.Begin("ArenaManager");public bool GetArenaIsCollectAllTrophy(string id)=>Collected;public int GetArenaTrophyNumber(string id)=>Trophies;public void ApplyNoBetVictoryGold(int value)=>Env.Trace.Add("NoBetGold:"+value);public void ChangeArenaTrophy(string id,int value,bool cheat)=>Env.Trace.Add("ChangeTrophy:"+id+":"+value+":"+cheat);}
 public class MonthlyPassManager {public static MonthlyPassManager Instance{get;}=new();public bool Bought;public Task Init()=>Env.Begin("MonthlyPassManager");public bool HadBuyMonthPass()=>Bought;}
 public class SeasonManager {public static SeasonManager Instance{get;}=new();public int Exp;public Task Init()=>Env.Begin("SeasonManager");public int CalculatePVPWinSeasonPassExpReward()=>Exp;}
 public class UserResourcesManager {public static UserResourcesManager Instance{get;}=new();public void LoseResourceCount(string id,BigInteger count,bool cheat,CurrencyTransactionSceneType type)=>Env.Trace.Add("Lose:"+id+":"+count+":"+cheat+":"+type);}
 public class ReportEventsManager {public static ReportEventsManager Instance{get;}=new();public bool ThrowAppOpen;public void ArenaUnLockRbi()=>Env.Trace.Add("ArenaUnlock");public void AppOpenEvent(){Env.Trace.Add("AppOpen");if(ThrowAppOpen)throw new ApplicationException("AppOpen");}public void OnGameFinish(bool win,int score,GameType type)=>Env.Trace.Add("GameFinish:"+win+":"+score+":"+type);}
 public class UpdateController {public static int Constructions;public UpdateController()=>Constructions++;public void ToUpdate(float d)=>Env.Trace.Add("Update:"+d);}
 public class GetNewCardPanelManager {public static GetNewCardPanelManager Instance{get;}=new();public Task Init()=>Env.Begin("GetNewCardPanelManager");}
 public class GiftPackageManager {public static GiftPackageManager Instance{get;}=new();public void Init()=>Env.Trace.Add("Init:GiftPackageManager");}
 public class DailyBlessManager {public static DailyBlessManager Instance{get;}=new();public bool Test;public Task Init()=>Env.Begin("DailyBlessManager");public bool IsBTest()=>Test;public void RefreshDailyBless()=>Env.Trace.Add("RefreshDailyBless");}
 public class ShopManager {public static ShopManager Instance{get;}=new();public BadgeGraph.ThrottleTrigger redDotThrottleTrigger=new();public void RefreshUserUniversalCardData()=>Env.Trace.Add("RefreshUniversal");public void ResetWatchAdCount()=>Env.Trace.Add("ResetWatchAd");public void ResetPopPacks()=>Env.Trace.Add("ResetPop");}
 public class PanelPopHandleManager {public static PanelPopHandleManager Instance{get;}=new();public void PanelPopPlay()=>Env.Trace.Add("PanelPop");}
 public class SubGameChaosTrailsManager:UnityEngine.Object {public static SubGameChaosTrailsManager Instance{get;}=new();public BattleResult Last;public void TryReturnToPanelAfterEnterMeta(BattleResult result){Last=result;Env.Trace.Add("SubReturn");}}
 public class RankManager {public static RankManager Instance{get;}=new();public void UpdateRankInfo()=>Env.Trace.Add("RankUpdate");}
 public class PacksTipManager {public static PacksTipManager Instance{get;}=new();public void FirstPopPacks()=>Env.Trace.Add("FirstPopPacks");}
 public static class DataNoOp {public static void Reset(){DataModule.DataManager.Instance.LoadDataCompleted=true;DataModule.DataManager.Instance.GlobalInfo=new();}}
}
namespace BadgeGraph {public class ThrottleTrigger {public void RegisterOneTrigger()=>Env.Trace.Add("BadgeTrigger");}}
namespace UIFramework {public class UIPanel{} public class UIManager {public static UIManager Instance{get;}=new();public bool Mask;public Task GetPanel(string p){Env.Trace.Add("GetPanel:"+p);return Task.CompletedTask;}public Task ShowPanel(string p,params object[] args){Env.Trace.Add("ShowPanel:"+p);return Env.Begin("ShowPanel");}public Task HidePanel(string p){Env.Trace.Add("HidePanel:"+p);return Env.Begin("HidePanel");}public bool IsPanelShowing(string p,out UIPanel panel){panel=null;Env.Trace.Add("IsPanel:"+p);return Mask;}}}
namespace GameConfigModule {public class GameConfigManager {public static GameConfigManager Instance{get;}=new();public Dictionary<string,int> Values=new();public int GetConfigInt(string key)=>Values[key];}}
namespace DBTSDK {public class SDKToolManager {public static SDKToolManager Instance{get;}=new();public void ReportGameInteractive(string text)=>Env.Trace.Add("Interactive:"+text);}}
namespace DBT.StartupGift {public static class StartupGiftSystem {public static void CheckAndGrantGift()=>Env.Trace.Add("CheckStartupGift");}}
namespace ljzs_lt {public class LTEmailControl {public static LTEmailControl Instance{get;}=new();public void InitEmail()=>Env.Trace.Add("Email");}}
