using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using BadgeGraph;
using DataModule;
using EventModule;
using SDKModule;
using QuickTutor;
using UIFramework;
using ljzs_lt;
using Debug = UnityEngine.Debug;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using TimeModuleO;
using ToolModule;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x2000464")]
	public class GameManager : ManagerBase<GameManager>
	{
		[Token(Token = "0x2000466")]
		[CompilerGenerated]
		private sealed class _003CCheckNetworkState_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4002ADC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4002ADD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4002ADE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GameManager _003C_003E4__this;

			[Token(Token = "0x17000143")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600159C")]
				[Address(RVA = "0x3E1CF4C", Offset = "0x3E18F4C", VA = "0x3E1CF4C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000144")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600159E")]
				[Address(RVA = "0x3E1CF8C", Offset = "0x3E18F8C", VA = "0x3E1CF8C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6001599")]
			[Address(RVA = "0x3E19988", Offset = "0x3E15988", VA = "0x3E19988")]
			[DebuggerHidden]
			public _003CCheckNetworkState_003Ed__14(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600159A")]
			[Address(RVA = "0x3E1CAF0", Offset = "0x3E18AF0", VA = "0x3E1CAF0", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600159B")]
			[Address(RVA = "0x3E1CAF4", Offset = "0x3E18AF4", VA = "0x3E1CAF4", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600159C")]
			[Address(RVA = "0x3E1CF4C", Offset = "0x3E18F4C", VA = "0x3E1CF4C", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600159D")]
			[Address(RVA = "0x3E1CF54", Offset = "0x3E18F54", VA = "0x3E1CF54", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600159E")]
			[Address(RVA = "0x3E1CF8C", Offset = "0x3E18F8C", VA = "0x3E1CF8C", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000467")]
		[CompilerGenerated]
		private struct _003CEnterMeta_003Ed__20 : IAsyncStateMachine
		{
			[Token(Token = "0x4002ADF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002AE0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002AE1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public object obj;

			[Token(Token = "0x600159F")]
			[Address(RVA = "0x3E1CF94", Offset = "0x3E18F94", VA = "0x3E1CF94", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60015A0")]
			[Address(RVA = "0x3E1D2E4", Offset = "0x3E192E4", VA = "0x3E1D2E4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000468")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__9 : IAsyncStateMachine
		{
			[Token(Token = "0x4002AE2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002AE3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002AE4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GameManager _003C_003E4__this;

			[Token(Token = "0x4002AE5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60015A1")]
			[Address(RVA = "0x3E1D2F0", Offset = "0x3E192F0", VA = "0x3E1D2F0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60015A2")]
			[Address(RVA = "0x3E1F2C4", Offset = "0x3E1B2C4", VA = "0x3E1F2C4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000469")]
		[CompilerGenerated]
		private struct _003CShowCardProbabilityPanel_003Ed__24 : IAsyncStateMachine
		{
			[Token(Token = "0x4002AE6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002AE7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002AE8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60015A3")]
			[Address(RVA = "0x3E1F2D0", Offset = "0x3E1B2D0", VA = "0x3E1F2D0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60015A4")]
			[Address(RVA = "0x3E1F66C", Offset = "0x3E1B66C", VA = "0x3E1F66C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4002AC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool InitComplete;

		[Token(Token = "0x4002AC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		private bool _isFirstThroghGame;

		[Token(Token = "0x4002AC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateController updateController = new UpdateController();

		[Token(Token = "0x4002AC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private GameObject APostProcess;

		[Token(Token = "0x4002AC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private GameObject BPostProcess;

		[Token(Token = "0x4002AC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TimeManager.Timer canPushGiftPackTimer;

		[Token(Token = "0x4002ACA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TimeManager.Timer pushGiftPackCutDownTimer;

		[Token(Token = "0x4002ACB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TimeManager.Timer pushGiftPackCdTimer;

		[Token(Token = "0x4002ACC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Action onGameManagerInitComplete;

		[Token(Token = "0x4002ACD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool showNoInternetPanel;

		[Token(Token = "0x4002ACE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool _cheatGamePaused;

		[Token(Token = "0x4002ACF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private TimeManager.Timer monthPass;

		[Token(Token = "0x4002AD0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool closeLoadPanel;

		[Token(Token = "0x600157A")]
		[Address(RVA = "0x3E197C0", Offset = "0x3E157C0", VA = "0x3E197C0", Slot = "4")]
		public override async UniTask Init()
		{
		    if (!PlayerPrefs.HasKey("VibratorEnable"))
		        PlayerPrefs.SetInt("VibratorEnable", 0);
		    _ = HWLeaderboardManager.Instance.Init();
		    _ = HomelLandCtrl.Instance.Init();
		    _ = HomelLandCtrlNew.Instance.Init();
		    _ = BadgeManager.Instance.Init();
		    _ = BoxManager.Instance.Init();
		    _ = ArenaManager.Instance.Init();
		    _ = ArenaProgressManager.Instance.Init();
		    _ = TrainingGroundManager.Instance.Init();
		    _ = TrophyProgressManager.Instance.Init();
		    _ = PlayerCustomizationManager.Instance.Init();
		    _ = PlayerLevelManager.Instance.Init();
		    _ = UserLableManager.Instance.Init();
		    _ = UserLablePushPackManager.Instance.Init();
		    _ = MetaBtnSecondClickManager.Instance.Init();
		    _ = SkinManager.Instance.Init();
		    _ = MonthlyPassManager.Instance.Init();
		    _ = DailyBlessManager.Instance.Init();
		    _ = SynergyEffectManager.Instance.Init();
		    _ = RoleShadowManager.Instance.Init();
		    _ = GameCenterManager.Instance.Init();
		    APostProcess = GameObject.Find("Base/ATestPostProcess");
		    BPostProcess = GameObject.Find("Base/BTestPostProcess");
		    APostProcess.SetActive(!ABTestManager.Instance.WeeklyClashImprove02IsBTest);
		    BPostProcess.SetActive(ABTestManager.Instance.WeeklyClashImprove02IsBTest);
		    _isFirstThroghGame = DbtSaveDataManager_PlayerGuideData.I.Data.isFirstThroghGame;
		    RegisterOnTimeToZero();
		    RegisterOnTimeToMonDayZero();
		    if (DbtSaveDataManager_PlayerShopData.I.Data.timingPushGiftPackageCdIng)
		    {
		        DbtSaveDataManager_PlayerShopData.I.Data.timingPushGiftPackageCdIng = false;
		        DbtSaveDataManager_PlayerShopData.I.Save();
		    }
		    if (!DbtSaveDataManager_PlayerShopData.I.Data.hadHandleTwoSixOneBug)
		    {
		        if (DbtSaveDataManager_PlayerShopData.I.Data.isShowNewBieGiftPack)
		        {
		            TimeManager.Timer timer = TimeManager.Instance.GetTimer("NewBieGiftPackKey");
		            if (timer != null && (timer.StartTime.Year < 2025 || timer.TargetEndTime.Year <= 2024))
		                timer.Restart(TimeSpan.FromDays(2), true);
		        }
		        if (DbtSaveDataManager_PlayerShopData.I.Data.canTimingPushGiftPackage)
		        {
		            TimeManager.Timer timer = TimeManager.Instance.GetTimer("GiftPackagePushCountdownKey");
		            if (timer != null && (timer.StartTime.Year < 2025 || timer.TargetEndTime.Year <= 2024))
		                timer.Restart(TimeSpan.FromDays(2), true);
		        }
		        else
		        {
		            TimeManager.Timer timer = TimeManager.Instance.GetTimer("CanGiftPackagePushKey");
		            if (timer != null && (timer.StartTime.Year < 2025 || timer.TargetEndTime.Year <= 2024))
		                timer.Restart(TimeSpan.FromDays(4), true);
		        }
		        DbtSaveDataManager_PlayerShopData.I.Data.hadHandleTwoSixOneBug = true;
		        DbtSaveDataManager_PlayerShopData.I.Save();
		        DbtSaveDataManager_PlayerTimeData.I.Save();
		    }
		    if (ABTestManager.Instance.SelectableOfferIsOn)
		    {
		        Debug.Log("ZZZZ进入定时礼包判断");
		        if (_isFirstThroghGame)
		        {
		            canPushGiftPackTimer = TimeManager.Instance.CreateTimer("CanGiftPackagePushKey", TimeSpan.FromDays(4), true, false);
		            DbtSaveDataManager_PlayerShopData.I.Save();
		            DbtSaveDataManager_PlayerTimeData.I.Save();
		        }
		        else if (!DbtSaveDataManager_PlayerShopData.I.Data.isShowNewBieGiftPack)
		        {
		            canPushGiftPackTimer = TimeManager.Instance.GetTimer("CanGiftPackagePushKey");
		            if (canPushGiftPackTimer == null && !DbtSaveDataManager_PlayerShopData.I.Data.canTimingPushGiftPackage)
		            {
		                DbtSaveDataManager_PlayerShopData.I.Data.canTimingPushGiftPackage = true;
		                _ = TimeManager.Instance.GetTimer("GiftPackagePushOffsetKey");
		                Debug.Log("ZZZZ不是第一次进游戏，新手礼包不在，直接可以推送礼包");
		                DbtSaveDataManager_PlayerShopData.I.Save();
		            }
		        }
		        else
		        {
		            canPushGiftPackTimer = TimeManager.Instance.GetTimer("CanGiftPackagePushKey");
		            if (canPushGiftPackTimer == null && !DbtSaveDataManager_PlayerShopData.I.Data.canTimingPushGiftPackage)
		            {
		                TimeManager.Timer newbieTimer = TimeManager.Instance.GetTimer("NewBieGiftPackKey");
		                canPushGiftPackTimer = TimeManager.Instance.CreateTimer("CanGiftPackagePushKey",
		                    TimeSpan.FromDays(4) - (newbieTimer != null ? newbieTimer.GetRemainingTime() : TimeSpan.Zero), true, false);
		                Debug.Log(string.Format("ZZZZ不是第一次进游戏，新手礼包在，创建倒计时,begintime{0},endtime{1}",
		                    canPushGiftPackTimer.StartTime, canPushGiftPackTimer.TargetEndTime));
		                DbtSaveDataManager_PlayerShopData.I.Save();
		                DbtSaveDataManager_PlayerTimeData.I.Save();
		            }
		        }
		    }
		    await MetaGameManager.Instance.Init();
		    _ = GetNewCardPanelManager.Instance.Init();
		    if (!_isFirstThroghGame)
		    {
		        _ = UIManager.Instance.GetPanel("Assets/_Res/Addressable/Prefabs/UI/Panels/ClimbRankPanel.prefab");
		        MetaGameManager.Instance.ShowMetaSwitchPanel(2);
		        EventManager.Instance.TriggerEvent("InitGameEndCheckIsHasLegacyBox", null);
		    }
		    _ = UIManager.Instance.GetPanel("Assets/_Res/Addressable/02CoreGameBundle/Prefabs/UI/Panels/FoundEnemyPanel.prefab");
		    await CoreGameManager.Instance.Init();
		    _ = SeasonManager.Instance.Init();
		    _ = FundManager.Instance.Init();
		    GiftPackageManager.Instance.Init();
		    _ = GiftChainManager.Instance.Init();
		    _ = GiftChainManager2.Instance.Init();
		    _ = MultistageNewcomerPackageManager.Instance.Init();
		    _ = UpgradeRewardManager.Instance.Init();
		    _ = MysteriousStoreManager.Instance.Init();
		    _ = BackpackManager.Instance.Init();
		    _ = WeeklyCardActivityManager.Instance.Init();
		    Debug.Log("金卡周管理器初始化完成");
		    _ = MysteryAdventureManager.Instance.Init();
		    Debug.Log("秘境大冒险管理器初始化完成");
		    _ = WorldCupActivityManager.Instance.Init();
		    Debug.Log("世界杯狂欢管理器初始化完成");
		    ReportEventsManager.Instance.ArenaUnLockRbi();
		    EventManager.Instance.StartListening("GameSteerEndShowCardProbabilityPanel", ShowCardProbabilityPanel);
		    if (!TutorialManager.Instance.IsStepComplete("1009"))
		        EventManager.Instance.StartListening("CardSteerEnd", CardSteerEnd);
		    if (!TutorialManager.Instance.IsStepComplete("1016"))
		        EventManager.Instance.StartListening("FetterSteerEnd", FetterSteerEnd);
		    EventManager.Instance.StartListening("DanChange", DanChangeUpdateInfo);
		    if (_isFirstThroghGame)
		        EventManager.Instance.TriggerEvent("DanChange", null);
		    EventManager.Instance.StartListening("OnArenaUIBGItemStartBtnClicked", StartCoreGame);
		    EventManager.Instance.StartListening("OnGameOver", EnterMeta);
		    EventManager.Instance.StartListening("CloseLoadPanel", CloseLoadPanel);
		    EventManager.Instance.StartListening("LoadEnd", LoadEnd);
		    onGameManagerInitComplete?.Invoke();
		    InitComplete = true;
		    ReportEventsManager.Instance.AppOpenEvent();
		    LTEmailControl.Instance.InitEmail();
		    FixedRandomTools.Load();
		    StartCoroutine(CheckNetworkState());
		}

		[Token(Token = "0x600157B")]
		[Address(RVA = "0x3E1984C", Offset = "0x3E1584C", VA = "0x3E1984C")]
		public void RegisterOnGameManagerInitComplete(Action action)
		{
		    if (InitComplete)
		        action?.Invoke();
		    else
		        onGameManagerInitComplete += action;
		}

		[Token(Token = "0x600157C")]
		[Address(RVA = "0x3E198F0", Offset = "0x3E158F0", VA = "0x3E198F0")]
		private void Update()
		{
		    if (InitComplete)
		        updateController?.ToUpdate(Time.deltaTime);
		}

		[Token(Token = "0x600157D")]
		[Address(RVA = "0x3E19928", Offset = "0x3E15928", VA = "0x3E19928")]
		private IEnumerator CheckNetworkState()
		{
		    while (this != null)
		    {
		        if (InitComplete && TimeManager.Instance.initComplete && DataManager.Instance.LoadDataCompleted)
		        {
		            yield return new WaitForSeconds(0.02f);
		            if (!TutorialManager.Instance.IsStepComplete("1008"))
		                continue;
		            if (!TimeManager.Instance.IsNetworkConnected && !showNoInternetPanel)
		            {
		                if (UIManager.Instance.IsPanelShowing("Assets/_Res/Addressable/Prefabs/UI/Panels/MaskPanel.prefab", out UIPanel panel))
		                    yield break;
		                yield return UIManager.Instance.ShowPanel("Assets/_Res/Addressable/01FirstBundle/Prefabs/UI/Panels/NoInternetPanel.prefab", Array.Empty<object>());
		                showNoInternetPanel = true;
		                if (CoreGameManager.Gaming)
		                    PauseGame();
		            }
		            else if (TimeManager.Instance.IsNetworkConnected && showNoInternetPanel)
		            {
		                yield return UIManager.Instance.HidePanel("Assets/_Res/Addressable/01FirstBundle/Prefabs/UI/Panels/NoInternetPanel.prefab");
		                showNoInternetPanel = false;
		                if (CoreGameManager.Gaming)
		                    ResumeGame();
		            }
		        }
		    }
		}

		[Token(Token = "0x600157E")]
		[Address(RVA = "0x3E199B0", Offset = "0x3E159B0", VA = "0x3E199B0")]
		private void PauseGame()
		{
		    if (BattleGameManager.Instance != null)
		        BattleGameManager.Instance.SetGamePaused(true);
		    if (AIBehaviourManager.Instance != null)
		        AIBehaviourManager.Instance.SetGamePaused(true);
		}

		[Token(Token = "0x600157F")]
		[Address(RVA = "0x3E19AB8", Offset = "0x3E15AB8", VA = "0x3E19AB8")]
		private void ResumeGame()
		{
		    if (BattleGameManager.Instance != null)
		        BattleGameManager.Instance.SetGamePaused(false);
		    if (AIBehaviourManager.Instance != null)
		        AIBehaviourManager.Instance.SetGamePaused(false);
		}

		[Token(Token = "0x6001580")]
		[Address(RVA = "0x3E19924", Offset = "0x3E15924", VA = "0x3E19924")]
		private void CheckMonthPass()
		{
		}

		[Token(Token = "0x6001581")]
		[Address(RVA = "0x3E19BC0", Offset = "0x3E15BC0", VA = "0x3E19BC0")]
		private void StartCoreGame(object obj)
		{
		    Func<bool, RewardConfig> rewardCallback = null;
		    rewardCallback += win =>
		    {
		        RewardConfig config = null;
		        if (TrainingGroundManager.IsInTrainingGround)
		        {
		            config = new RewardConfig(CurrencyTransactionSceneType.game_finish);
		            int exp = GameConfigModule.GameConfigManager.Instance.GetConfigInt(win ? "NormalPVPWinExp" : "NormalPVPLoseExp");
		            config.AddAssetDataList(new List<RewardConfigSingle> { new RewardConfigSingle("20007", exp.ToString(), null) });
		        }
		        if (TrainingGroundManager.IsInGuidedGame)
		            TrainingGroundManager.Instance.OnTrainingGameComplete(win);
		        if (config == null)
		        {
		            config = new RewardConfig(CurrencyTransactionSceneType.game_finish);
		            List<RewardConfigSingle> assets;
		            if (win)
		            {
		                string trophies = BattleGameManager.Instance.GameSuccessGetTrophyNumber();
		                string gold = DataManager.Instance.GlobalInfo.arenaInfoDic[CoreGameManager.NowPlayEdArenaID].diamondReward;
		                string keys = DataManager.Instance.GlobalInfo.arenaInfoDic[CoreGameManager.NowPlayEdArenaID].keyReward;
		                int exp = GameConfigModule.GameConfigManager.Instance.GetConfigInt("NormalPVPWinExp");
		                if (ABTestManager.Instance.NoBetIsBTest)
		                {
		                    gold = BattleGameManager.Instance.BetRewardNum;
		                    ArenaManager.Instance.ApplyNoBetVictoryGold(StringTool.ToInt(gold));
		                }
		                else if (!StringTool.IsNullOrEmpty(CoreGameManager.NowPlayEdArenaID, true) && CoreGameManager.NowPlayEdArenaID != "1001")
		                {
		                    gold = BattleGameManager.Instance.BetRewardNum;
		                }
		                if (MonthlyPassManager.Instance.HadBuyMonthPass())
		                {
		                    float bonusGold = (float)StringTool.ToInt(gold) * 1.2f;
		                    int scaledGold = float.IsNaN(bonusGold) ? 0 : bonusGold >= 2147483648f ? int.MaxValue
		                        : bonusGold <= -2147483648f ? int.MinValue : (int)bonusGold;
		                    gold = scaledGold.ToString();
		                }
		                assets = new List<RewardConfigSingle>
		                {
		                    new RewardConfigSingle("20005", gold, null),
		                    new RewardConfigSingle("20006", keys, null),
		                    new RewardConfigSingle("20007", exp.ToString(), null)
		                };
		                if (!ArenaManager.Instance.GetArenaIsCollectAllTrophy(CoreGameManager.NowPlayEdArenaID))
		                {
		                    assets.Add(new RewardConfigSingle("20004", trophies, null));
		                    if (ABTestManager.Instance.NewArenaProcessIsBTest)
		                    {
		                        int currentTrophies = ArenaManager.Instance.GetArenaTrophyNumber(CoreGameManager.NowPlayEdArenaID);
		                        int remaining = unchecked(StringTool.ToInt(DataManager.Instance.GlobalInfo.arenaInfoDic[CoreGameManager.NowPlayEdArenaID].completeTrophyRequire) - currentTrophies);
		                        int wonTrophies = StringTool.ToInt(trophies);
		                        if (wonTrophies > remaining)
		                            UserResourcesManager.Instance.LoseResourceCount("20004", new System.Numerics.BigInteger(unchecked(wonTrophies - remaining)), false, CurrencyTransactionSceneType.none);
		                    }
		                    ArenaManager.Instance.ChangeArenaTrophy(CoreGameManager.NowPlayEdArenaID, StringTool.ToInt(trophies), false);
		                }
		                if (ABTestManager.Instance.SeasonIsBTest)
		                {
		                    int seasonExp = SeasonManager.Instance.CalculatePVPWinSeasonPassExpReward();
		                    if (seasonExp > 0)
		                        assets.Add(new RewardConfigSingle("20017", seasonExp.ToString(), null));
		                }
		            }
		            else
		            {
		                string trophyPunish = DataManager.Instance.GlobalInfo.arenaInfoDic[CoreGameManager.NowPlayEdArenaID].trophyPunish;
		                int exp = GameConfigModule.GameConfigManager.Instance.GetConfigInt("NormalPVPLoseExp");
		                assets = new List<RewardConfigSingle> { new RewardConfigSingle("20007", exp.ToString(), null) };
		                if (!ArenaManager.Instance.GetArenaIsCollectAllTrophy(CoreGameManager.NowPlayEdArenaID) && BattleGameManager.Instance.ElapseTime > 10f)
		                {
		                    string loss;
		                    if (ABTestManager.Instance.NewArenaProcessIsBTest)
		                    {
		                        int currentTrophies = ArenaManager.Instance.GetArenaTrophyNumber(CoreGameManager.NowPlayEdArenaID);
		                        if (currentTrophies > 0)
		                        {
		                            loss = Mathf.Min(StringTool.ToInt(trophyPunish), currentTrophies).ToString();
		                            assets.Add(new RewardConfigSingle("20004", "-" + loss, null));
		                            ArenaManager.Instance.ChangeArenaTrophy(CoreGameManager.NowPlayEdArenaID, unchecked(-StringTool.ToInt(trophyPunish)), false);
		                        }
		                    }
		                    else
		                    {
		                        loss = trophyPunish;
		                        assets.Add(new RewardConfigSingle("20004", "-" + loss, null));
		                        ArenaManager.Instance.ChangeArenaTrophy(CoreGameManager.NowPlayEdArenaID, unchecked(-StringTool.ToInt(trophyPunish)), false);
		                    }
		                }
		            }
		            config.AddAssetDataList(assets);
		            BattleGameManager.Instance.rewardConfig = config;
		            BattleGameManager.Instance.tempConfig = config;
		            ReportEventsManager.Instance.OnGameFinish(win, 0, GameType.PVP);
		        }
		        return config;
		    };
		    BattleContext context = new BattleContext(true, null, rewardCallback, null, null);
		    context.GameType = GameType.PVP;
		    CoreGameManager.Instance.StartGame(context);
		}

		[Token(Token = "0x6001582")]
		[Address(RVA = "0x3E19D38", Offset = "0x3E15D38", VA = "0x3E19D38")]
		private async void EnterMeta(object obj)
		{
		    if (TrainingGroundManager.IsInTrainingGround)
		    {
		        MetaGameManager.Instance.ShowMetaSwitchPanel(2);
		        PanelPopHandleManager.Instance.PanelPopPlay();
		    }
		    else
		    {
		        switch (BattleGameManager.Instance.GameType)
		        {
		            case GameType.PVP:
		                MetaGameManager.Instance.ShowMetaSwitchPanel(2);
		                PanelPopHandleManager.Instance.PanelPopPlay();
		                break;
		            case GameType.PVE:
		                MetaGameManager.Instance.ShowMetaSwitchPanel(3);
		                break;
		            case GameType.SeasonPVP:
		                MetaGameManager.Instance.ShowMetaSwitchPanel(2);
		                break;
		            case GameType.SubGamePVP:
		                MetaGameManager.Instance.ShowMetaSwitchPanel(2);
		                PanelPopHandleManager.Instance.PanelPopPlay();
		                if (SubGameChaosTrailsManager.Instance != null)
		                    SubGameChaosTrailsManager.Instance.TryReturnToPanelAfterEnterMeta(obj as BattleResult);
		                break;
		        }
		    }
		}

		[Token(Token = "0x6001583")]
		[Address(RVA = "0x3E19DC4", Offset = "0x3E15DC4", VA = "0x3E19DC4")]
		private void RegisterOnTimeToZero()
		{
		    TimeManager.Instance.RegisterOnTimeToZero(ShopManager.Instance.RefreshUserUniversalCardData);
		    TimeManager.Instance.RegisterOnTimeToZero(ShopManager.Instance.ResetWatchAdCount);
		    TimeManager.Instance.RegisterOnTimeToZero(ShopManager.Instance.ResetPopPacks);
		    TimeManager.Instance.RegisterOnTimeToZero(() =>
		    {
		        DbtSaveDataManager_PlayerAdData.I.Data.InitializeVideosNumber();
		        DbtSaveDataManager_PlayerAdData.I.Save();
		        ShopManager.Instance.redDotThrottleTrigger?.RegisterOneTrigger();
		        EventManager.Instance.TriggerEvent("TimeToZeroRefreshFreeResUI", null);
		    });
		    TimeManager.Instance.RegisterOnTimeToZero(() =>
		    {
		        DbtSaveDataManager_PlayerCoreData.I.Data.nowLingquReward = false;
		        DbtSaveDataManager_PlayerAdData.I.Save();
		        EventManager.Instance.TriggerEvent("TimeToZeroRefreshSubscription", null);
		    });
		    TimeManager.Instance.RegisterOnTimeToZero(() =>
		    {
		        DbtSaveDataManager_PlayerAdData.I.Data.ShowInterstitialEd = false;
		        DbtSaveDataManager_PlayerAdData.I.Save();
		    });
		    TimeManager.Instance.RegisterOnTimeToZero(() =>
		    {
		        DbtSaveDataManager_PlayerChestData.I.Data.userGetBoxCount = 0;
		        DbtSaveDataManager_PlayerChestData.I.Save();
		    });
		    if (DailyBlessManager.Instance.IsBTest())
		    {
		        TimeManager.Instance.RegisterOnTimeToZero(() =>
		        {
		            DailyBlessManager.Instance.RefreshDailyBless();
		            EventManager.Instance.TriggerEvent("DailyBlessBtnActive", true);
		            if (UIManager.Instance.IsPanelShowing("Assets/_Res/Addressable/04MetaGameBundle/Prefabs/UI/Panels/DailyBlessPanel.prefab", out UIPanel panel))
		                _ = UIManager.Instance.HidePanel("Assets/_Res/Addressable/04MetaGameBundle/Prefabs/UI/Panels/DailyBlessPanel.prefab");
		        });
		    }
		}

		[Token(Token = "0x6001584")]
		[Address(RVA = "0x3E1A2C4", Offset = "0x3E162C4", VA = "0x3E1A2C4")]
		private void RegisterOnTimeToMonDayZero()
		{
		    TimeManager.Instance.RegisterOnWeekPassed(() =>
		    {
		        Dictionary<string, int> counts = DbtSaveDataManager_PlayerShopData.I.Data.cardPackBuyCountNowWeek;
		        foreach (string key in counts.Keys.ToList())
		            counts[key] = 0;
		        DbtSaveDataManager_PlayerShopData.I.Save();
		    });
		    TimeManager.Instance.RegisterOnTimeToZero(() =>
		    {
		        DbtSaveDataManager_PlayerCoreData.I.Data.PlayerDailyPlayGameCount = 0;
		        DbtSaveDataManager_PlayerCoreData.I.Data.PlayerDailyWonGameCount = 0;
		        DbtSaveDataManager_PlayerCoreData.I.Data.seasonData.PlayerDailyGetSeasonPassCount = 0;
		        DbtSaveDataManager_PlayerCoreData.I.Data.seasonData.PlayerDailyGetSeasonPassScore = 0;
		        DbtSaveDataManager_PlayerCoreData.I.Data.DailyNoBetGoldEarned = 0;
		        DbtSaveDataManager_PlayerCoreData.I.Save();
		    });
		    TimeManager.Instance.RegisterOnWeekPassed(() =>
		    {
		        DbtSaveDataManager_PlayerCoreData.I.Data.PlayerWeeklyPlayGameCount = 0;
		        DbtSaveDataManager_PlayerCoreData.I.Data.PlayerWeeklyWonGameCount = 0;
		        DbtSaveDataManager_PlayerCoreData.I.Save();
		    });
		    TimeManager.Instance.RegisterOnWeekPassed(() =>
		    {
		        Dictionary<string, bool> states = DbtSaveDataManager_PlayerShopData.I.Data.playerRuneStoneBuyState;
		        foreach (string key in states.Keys.ToList())
		            states[key] = false;
		        DbtSaveDataManager_PlayerShopData.I.Save();
		        EventManager.Instance.TriggerEvent("RefreshRuneStonePack", null);
		    });
		}

		[Token(Token = "0x6001585")]
		[Address(RVA = "0x3E1A5B8", Offset = "0x3E165B8", VA = "0x3E1A5B8")]
		private void DanChangeUpdateInfo(object o)
		{
		    RankManager.Instance.UpdateRankInfo();
		}

		[Token(Token = "0x6001586")]
		[Address(RVA = "0x3E1A608", Offset = "0x3E16608", VA = "0x3E1A608")]
		private async void ShowCardProbabilityPanel(object o)
		{
		    await UniTask.WaitForSeconds(0.05f);
		    _ = UIManager.Instance.ShowPanel("Assets/_Res/Addressable/02CoreGameBundle/Prefabs/UI/Panels/HexDescribesPanel.prefab", Array.Empty<object>());
		}

		[Token(Token = "0x6001587")]
		[Address(RVA = "0x3E1A690", Offset = "0x3E16690", VA = "0x3E1A690")]
		private void CardSteerEnd(object o)
		{
		}

		[Token(Token = "0x6001588")]
		[Address(RVA = "0x3E1A694", Offset = "0x3E16694", VA = "0x3E1A694")]
		public void ShowConfirmPanel(string titleStr, string contentStr, string buttonTextStr, bool canCancelPanel, Action<bool> onClick)
		{
		    _ = UIManager.Instance.ShowPanel("Assets/_Res/Addressable/Prefabs/UI/Panels/ConfirmPanel.prefab",
		        new object[] { titleStr, contentStr, buttonTextStr, canCancelPanel, onClick });
		}

		[Token(Token = "0x6001589")]
		[Address(RVA = "0x3E1A864", Offset = "0x3E16864", VA = "0x3E1A864")]
		private void FetterSteerEnd(object o)
		{
		    if (ABTestManager.Instance.GameCenterIsBTest)
		        GameCenterManager.Instance.AllowGameCenter().Forget();
		}

		[Token(Token = "0x600158A")]
		[Address(RVA = "0x3E1A918", Offset = "0x3E16918", VA = "0x3E1A918")]
		private void CloseLoadPanel(object o)
		{
		    closeLoadPanel = true;
		    DBTSDK.SDKToolManager.Instance.ReportGameInteractive("");
		    if (!_isFirstThroghGame)
		        PacksTipManager.Instance.FirstPopPacks();
		    DBT.StartupGift.StartupGiftSystem.CheckAndGrantGift();
		}

		[Token(Token = "0x600158B")]
		[Address(RVA = "0x3E1A9EC", Offset = "0x3E169EC", VA = "0x3E1A9EC")]
		private void LoadEnd(object o)
		{
		    if (_isFirstThroghGame)
		        EventManager.Instance.TriggerEvent("OnArenaUIBGItemStartBtnClicked", null);
		}

		[Token(Token = "0x600158C")]
		[Address(RVA = "0x3E1AA70", Offset = "0x3E16A70", VA = "0x3E1AA70")]
		public GameManager()
		{
		}
	}
}
