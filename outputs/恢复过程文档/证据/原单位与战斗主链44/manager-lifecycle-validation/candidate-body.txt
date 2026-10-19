// Generated from actual source. No gameplay implementation is maintained in this fixture.
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ToolModule;
public partial class State {
public async Task Init()
{
			await FloatingTextManager.Instance.Init();
			EventModule.EventManager.Instance.StartListening("CoinChangeUpdateGamePanel", CoinChangeUpdateGamePanel);
			EventModule.EventManager.Instance.StartListening("HasHexDestroy", GameEndCheck);
			EventModule.EventManager.Instance.StartListening("PlayerBeginOpenHex", PlayerOpenHexCountAdd);
			EventModule.EventManager.Instance.StartListening("PlayerHornEmitIng", PlayerHornEmitIng);
			EventModule.EventManager.Instance.StartListening("OnGameOver", ShowInterstitial);
			EventModule.EventManager.Instance.StartListening("PlayerHornEmitEnd", PlayerHornEmitEnd);
			EventModule.EventManager.Instance.StartListening("SettlementAnimationEnd", SettlementAnimationEnd);
			EventModule.EventManager.Instance.StartListening("BetStartGame", BetRecordRewardNum);
			EventModule.EventManager.Instance.StartListening("GameSteerEndShowCardProbabilityPanel", BeginStartCountDown);
			EventModule.EventManager.Instance.StartListening("GameSteerEndShowCardProbabilityPanel", GuidOneEndAddCoin);
			EventModule.EventManager.Instance.StartListening("CloseMatchPanel", CloseMatchPanel);
			EventModule.EventManager.Instance.StartListening("PauseGame", OnPauseGame);
			EventModule.EventManager.Instance.StartListening("ResumeGame", OnResumeGame);
			roleAllDamageDic = new Dictionary<string, int>();
			towerAllDamageDic = new Dictionary<string, int>();
			cardOpenCount = new Dictionary<string, int>();
			GameDeadUnitInfoDic = new Dictionary<int, DeadUnitInfo>();
		
}
public async Task GameEnd(bool isVictory, bool doTxtAni)
{
			if (isVictory && WeeklyCardActivityManager.Instance.IsBTest())
			    EventModule.EventManager.Instance.TriggerEvent("WeeklyCardActivityTaskTrigger", new object[] { WeeklyCardActivityManager.WeekLyTaskType.GameWin, 1 });
			this.isVictory = isVictory;
			if (doTxtAni) GamePanelManager.Instance.DoAni();
			CoreGameManager.Gaming = false;
			EventModule.EventManager.Instance.TriggerEvent("GameEnd");
			isCountDowning = false;
			if (_myCoroutine != null) StopCoroutine(_myCoroutine);
			QuickTutor.TutorialManager.Instance.ForceCloseTutorial();
			const string panel = "Assets/_Res/Addressable/02CoreGameBundle/Prefabs/UI/Panels/HexDescribesPanel.prefab";
			if (UIFramework.UIManager.Instance.IsPanelShowing(panel, out _)) UIFramework.UIManager.Instance.HidePanel(panel);
			if (doTxtAni) await UniTask.WaitForSeconds(2.3f);
			BattleGameSceneManager.Instance.SettlementAnimation(isVictory);
		
}
public void StartGame(BattleContext battleContext)
{
			string arenaID = StringTool.IsNullOrEmpty(CoreGameManager.NowPlayEdArenaID) ? "1001" : CoreGameManager.NowPlayEdArenaID;
			countDownTime = StringTool.ToInt(DataModule.DataManager.Instance.GlobalInfo.arenaInfoDic[arenaID].countDownTime);
			SubGameBuffManager.Instance.ModifyCountDownTime(ref countDownTime);
			_timeLeft = countDownTime;
			_timeString = GetTimeCutDownString();
			GamePanelManager.Instance.UpdateInfo(new object[] { hasCoin, _timeString });
			if (TrainingGroundManager.IsInGuidedGame) hasCoin = TrainingGroundManager.Instance.GetPlayerInitialCoin();
			else hasCoin = global::DbtSaveDataManager_PlayerGuideData.I.Data.isFirstThroghGame ? 150 : 50;
			battleInitCoin = hasCoin;
			battleTotalEarned = hasCoin;
			battleTotalCost = 0;
			_isAddCoining = true;
			if (!global::DbtSaveDataManager_PlayerGuideData.I.Data.isFirstThroghGame) BeginStartCountDown(null);
			GameType = battleContext.GameType;
			_battleContext = battleContext;
			IsGamePaused = false;
			gameEndCallBack = battleContext.gameEndCallBack;
			applyRewardCallBack = battleContext.gameEndApplyRewardCallBack;
			_pausedRoleAnimationSnapshots.Clear();
			CheatControl.ResetPerfStates();
			if (BattleFPSController.Instance != null) BattleFPSController.Instance.StartMonitoring();
			List<int> ids = global::DbtSaveDataManager_PlayerCardData.I.Data.GetBattleCardIDList();
			if (cardOpenCount == null) cardOpenCount = new Dictionary<string, int>();
			for (int i = 0; i < ids.Count; ++i) cardOpenCount.TryAdd(ids[i].ToString(), 0);
		
}
}