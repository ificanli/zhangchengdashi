using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using BadgeGraph;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using ToolModule;
using ljzs_lt;

[Token(Token = "0x20000B1")]
public class CheckInRewardManager : ManagerBase<CheckInRewardManager>
{
	[Token(Token = "0x20000B2")]
	public enum CheckInDayState
	{
		[Token(Token = "0x40003A7")]
		NotOpen = 0,
		[Token(Token = "0x40003A8")]
		NotReached = 1,
		[Token(Token = "0x40003A9")]
		CanCheckIn = 2,
		[Token(Token = "0x40003AA")]
		CanReCheckIn = 3,
		[Token(Token = "0x40003AB")]
		Missed = 4,
		[Token(Token = "0x40003AC")]
		Claimed = 5
	}

	[Serializable]
	[Token(Token = "0x20000B3")]
	private class CheckInRewardSaveData
	{
		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public long unlockTicks;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int round;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public long cycleStartTicks;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int checkInRewardsIndexId;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool isFeatureUnlocked;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public List<int> signedDays;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public List<int> claimedDailyRewardIds;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<int> claimedCumulativeRewardIds;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string lastSignDate;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string lastReCheckDate;

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x3E32688", Offset = "0x3E2E688", VA = "0x3E32688")]
		public CheckInRewardSaveData()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private struct _003CEnsureUnlockBattleCountReady_003Ed__68 : IAsyncStateMachine
	{
		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CheckInRewardManager _003C_003E4__this;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private UniTask<bool>.Awaiter _003C_003Eu__1;

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x3E33B00", Offset = "0x3E2FB00", VA = "0x3E33B00", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x3E340C8", Offset = "0x3E300C8", VA = "0x3E340C8", Slot = "5")]
		[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private struct _003CInit_003Ed__23 : IAsyncStateMachine
	{
		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CheckInRewardManager _003C_003E4__this;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private UniTask.Awaiter _003C_003Eu__1;

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x3E340D4", Offset = "0x3E300D4", VA = "0x3E340D4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x3E3460C", Offset = "0x3E3060C", VA = "0x3E3460C", Slot = "5")]
		[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private struct _003CRestartNextDayTimerNextFrame_003Ed__54 : IAsyncStateMachine
	{
		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CheckInRewardManager _003C_003E4__this;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x3E34618", Offset = "0x3E30618", VA = "0x3E34618", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x3E347CC", Offset = "0x3E307CC", VA = "0x3E347CC", Slot = "5")]
		[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x4000398")]
	private const string SaveKey = "CheckInReward_SaveData";

	[Token(Token = "0x4000399")]
	private const string NextDayTimerKey = "CheckInReward_NextDay";

	[Token(Token = "0x400039A")]
	private const string UnlockBattleCountKey = "CheckInUnlockBattleCount";

	[Token(Token = "0x400039B")]
	private const int DefaultUnlockBattleCount = 0;

	[Token(Token = "0x400039C")]
	private const int OnlineParamWaitTimeoutSeconds = 10;

	[Token(Token = "0x400039D")]
	private const int RewardTypeBaseRes = 0;

	[Token(Token = "0x400039E")]
	private const int RewardTypeCard = 1;

	[Token(Token = "0x400039F")]
	public const int LogicCycleDays = 30;

	[Token(Token = "0x40003A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private CheckInRewardSaveData _saveData;

	[Token(Token = "0x40003A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool _isSaveLoaded;

	[Token(Token = "0x40003A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	private bool _isUnlockBattleCountReady;

	[Token(Token = "0x40003A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
	private bool _isFeatureOpen;

	[Token(Token = "0x40003A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private int _unlockBattleCount;

	[Token(Token = "0x40003A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private ThrottleTrigger _redDotThrottleTrigger;

	[Token(Token = "0x17000031")]
	public bool IsFeatureUnlocked
	{
		[Token(Token = "0x6000394")]
		[Address(RVA = "0x3E2FAAC", Offset = "0x3E2BAAC", VA = "0x3E2FAAC")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x17000032")]
	public int CurrentDay
	{
		[Token(Token = "0x6000395")]
		[Address(RVA = "0x3E2FCF4", Offset = "0x3E2BCF4", VA = "0x3E2FCF4")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x17000033")]
	public int SignedDaysCount
	{
		[Token(Token = "0x6000396")]
		[Address(RVA = "0x3E2FEC0", Offset = "0x3E2BEC0", VA = "0x3E2FEC0")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x17000034")]
	public int CurrentCycleDays
	{
		[Token(Token = "0x6000397")]
		[Address(RVA = "0x3E2FF38", Offset = "0x3E2BF38", VA = "0x3E2FF38")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x6000398")]
	[Address(RVA = "0x3E2FF78", Offset = "0x3E2BF78", VA = "0x3E2FF78")]
	public TimeSpan GetCycleRemainingTime()
	{
		return default;
	}

	[Token(Token = "0x6000399")]
	[Address(RVA = "0x3E303F0", Offset = "0x3E2C3F0", VA = "0x3E303F0", Slot = "4")]
	[AsyncStateMachine(typeof(_003CInit_003Ed__23))]
	public override UniTask Init()
	{
		return default;
	}

	[Token(Token = "0x600039A")]
	[Address(RVA = "0x3E3047C", Offset = "0x3E2C47C", VA = "0x3E3047C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600039B")]
	[Address(RVA = "0x3E30648", Offset = "0x3E2C648", VA = "0x3E30648")]
	public bool RefreshFeatureUnlockState()
	{
		return default;
	}

	[Token(Token = "0x600039C")]
	[Address(RVA = "0x3E30D40", Offset = "0x3E2CD40", VA = "0x3E30D40")]
	public List<CheckInRewardsConfig> GetDailyRewards()
	{
		return null;
	}

	[Token(Token = "0x600039D")]
	[Address(RVA = "0x3E311A0", Offset = "0x3E2D1A0", VA = "0x3E311A0")]
	public List<CumulativeRewardConfig> GetCumulativeRewards()
	{
		return null;
	}

	[Token(Token = "0x600039E")]
	[Address(RVA = "0x3E314DC", Offset = "0x3E2D4DC", VA = "0x3E314DC")]
	public bool CanCheckInToday()
	{
		return default;
	}

	[Token(Token = "0x600039F")]
	[Address(RVA = "0x3E31610", Offset = "0x3E2D610", VA = "0x3E31610")]
	public bool CanReCheckInToday()
	{
		return default;
	}

	[Token(Token = "0x60003A0")]
	[Address(RVA = "0x3E316E4", Offset = "0x3E2D6E4", VA = "0x3E316E4")]
	public CheckInDayState GetDayState(int day)
	{
		return default;
	}

	[Token(Token = "0x60003A1")]
	[Address(RVA = "0x3E31774", Offset = "0x3E2D774", VA = "0x3E31774")]
	public CheckInDayState GetDayState(int day, int currentDay, bool canCheckInToday, bool canReCheckInToday)
	{
		return default;
	}

	[Token(Token = "0x60003A2")]
	[Address(RVA = "0x3E319E4", Offset = "0x3E2D9E4", VA = "0x3E319E4")]
	public bool IsCumulativeRewardClaimed(int rewardId)
	{
		return default;
	}

	[Token(Token = "0x60003A3")]
	[Address(RVA = "0x3E31A74", Offset = "0x3E2DA74", VA = "0x3E31A74")]
	public bool CanClaimCumulativeReward(int rewardId)
	{
		return default;
	}

	[Token(Token = "0x60003A4")]
	[Address(RVA = "0x3E31B58", Offset = "0x3E2DB58", VA = "0x3E31B58")]
	public bool TryCheckInToday()
	{
		return default;
	}

	[Token(Token = "0x60003A5")]
	[Address(RVA = "0x3E31F2C", Offset = "0x3E2DF2C", VA = "0x3E31F2C")]
	public bool TryReCheckInDay(int day)
	{
		return default;
	}

	[Token(Token = "0x60003A6")]
	[Address(RVA = "0x3E3224C", Offset = "0x3E2E24C", VA = "0x3E3224C")]
	public bool TryClaimCumulativeReward(int rewardId)
	{
		return default;
	}

	[Token(Token = "0x60003A7")]
	[Address(RVA = "0x3E3242C", Offset = "0x3E2E42C", VA = "0x3E3242C")]
	public bool CheatRebuildSaveData()
	{
		return default;
	}

	[Token(Token = "0x60003A8")]
	[Address(RVA = "0x3E32580", Offset = "0x3E2E580", VA = "0x3E32580")]
	private void OnGameEnd(object obj)
	{
	}

	[Token(Token = "0x60003A9")]
	[Address(RVA = "0x3E2FD28", Offset = "0x3E2BD28", VA = "0x3E2FD28")]
	private bool IsReadyForUse()
	{
		return default;
	}

	[Token(Token = "0x60003AA")]
	[Address(RVA = "0x3E2FB68", Offset = "0x3E2BB68", VA = "0x3E2FB68")]
	private void EnsureLoadSaveData(bool createIfMissing)
	{
	}

	[Token(Token = "0x60003AB")]
	[Address(RVA = "0x3E30C18", Offset = "0x3E2CC18", VA = "0x3E30C18")]
	private CheckInRewardSaveData CreateSaveData()
	{
		return null;
	}

	[Token(Token = "0x60003AC")]
	[Address(RVA = "0x3E32584", Offset = "0x3E2E584", VA = "0x3E32584")]
	private void NormalizeSaveData()
	{
	}

	[Token(Token = "0x60003AD")]
	[Address(RVA = "0x3E30874", Offset = "0x3E2C874", VA = "0x3E30874")]
	private bool InitCycleIfNeeded(bool isFirstUnlock)
	{
		return default;
	}

	[Token(Token = "0x60003AE")]
	[Address(RVA = "0x3E300D4", Offset = "0x3E2C0D4", VA = "0x3E300D4")]
	private bool RefreshCycleIfNeeded()
	{
		return default;
	}

	[Token(Token = "0x60003AF")]
	[Address(RVA = "0x3E314F4", Offset = "0x3E2D4F4", VA = "0x3E314F4")]
	private bool CanCheckInTodayInternal()
	{
		return default;
	}

	[Token(Token = "0x60003B0")]
	[Address(RVA = "0x3E31614", Offset = "0x3E2D614", VA = "0x3E31614")]
	private bool CanReCheckInTodayInternal()
	{
		return default;
	}

	[Token(Token = "0x60003B1")]
	[Address(RVA = "0x3E30858", Offset = "0x3E2C858", VA = "0x3E30858")]
	private void RegisterCheckInRewardRedDotTrigger()
	{
	}

	[Token(Token = "0x60003B2")]
	[Address(RVA = "0x3E32880", Offset = "0x3E2E880", VA = "0x3E32880")]
	private void CheckRedDot()
	{
	}

	[Token(Token = "0x60003B3")]
	[Address(RVA = "0x3E32900", Offset = "0x3E2E900", VA = "0x3E32900")]
	private bool HasCheckInRewardRedDot()
	{
		return default;
	}

	[Token(Token = "0x60003B4")]
	[Address(RVA = "0x3E32974", Offset = "0x3E2E974", VA = "0x3E32974")]
	private bool HasCanClaimCumulativeReward()
	{
		return default;
	}

	[Token(Token = "0x60003B5")]
	[Address(RVA = "0x3E30A58", Offset = "0x3E2CA58", VA = "0x3E30A58")]
	private void StartNextDayTimer()
	{
	}

	[Token(Token = "0x60003B6")]
	[Address(RVA = "0x3E30590", Offset = "0x3E2C590", VA = "0x3E30590")]
	private void StopNextDayTimer()
	{
	}

	[Token(Token = "0x60003B7")]
	[Address(RVA = "0x3E33130", Offset = "0x3E2F130", VA = "0x3E33130")]
	private void OnNextDayTimerEnd()
	{
	}

	[Token(Token = "0x60003B8")]
	[Address(RVA = "0x3E33298", Offset = "0x3E2F298", VA = "0x3E33298")]
	[AsyncStateMachine(typeof(_003CRestartNextDayTimerNextFrame_003Ed__54))]
	private UniTaskVoid RestartNextDayTimerNextFrame()
	{
		return default;
	}

	[Token(Token = "0x60003B9")]
	[Address(RVA = "0x3E2FD5C", Offset = "0x3E2BD5C", VA = "0x3E2FD5C")]
	private int GetCurrentDayInternal()
	{
		return default;
	}

	[Token(Token = "0x60003BA")]
	[Address(RVA = "0x3E2FF70", Offset = "0x3E2BF70", VA = "0x3E2FF70")]
	private int GetCurrentCycleDaysInternal()
	{
		return default;
	}

	[Token(Token = "0x60003BB")]
	[Address(RVA = "0x3E3330C", Offset = "0x3E2F30C", VA = "0x3E3330C")]
	public int GetDailyRewardDisplayCount()
	{
		return default;
	}

	[Token(Token = "0x60003BC")]
	[Address(RVA = "0x3E32690", Offset = "0x3E2E690", VA = "0x3E32690")]
	private int SelectIndexConfigId(bool isFirstRound)
	{
		return default;
	}

	[Token(Token = "0x60003BD")]
	[Address(RVA = "0x3E30F3C", Offset = "0x3E2CF3C", VA = "0x3E30F3C")]
	private CheckInRewardsIndexConfig GetCurrentIndexConfig()
	{
		return null;
	}

	[Token(Token = "0x60003BE")]
	[Address(RVA = "0x3E31DF0", Offset = "0x3E2DDF0", VA = "0x3E31DF0")]
	private CheckInRewardsConfig GetDailyRewardByDay(int day)
	{
		return null;
	}

	[Token(Token = "0x60003BF")]
	[Address(RVA = "0x3E31084", Offset = "0x3E2D084", VA = "0x3E31084")]
	private CheckInRewardsConfig GetDailyRewardConfig(int id)
	{
		return null;
	}

	[Token(Token = "0x60003C0")]
	[Address(RVA = "0x3E313C0", Offset = "0x3E2D3C0", VA = "0x3E313C0")]
	private CumulativeRewardConfig GetCumulativeRewardConfig(int id)
	{
		return null;
	}

	[Token(Token = "0x60003C1")]
	[Address(RVA = "0x3E31F10", Offset = "0x3E2DF10", VA = "0x3E31F10")]
	private bool GrantReward(CheckInRewardsConfig rewardConfig)
	{
		return default;
	}

	[Token(Token = "0x60003C2")]
	[Address(RVA = "0x3E32410", Offset = "0x3E2E410", VA = "0x3E32410")]
	private bool GrantReward(CumulativeRewardConfig rewardConfig)
	{
		return default;
	}

	[Token(Token = "0x60003C3")]
	[Address(RVA = "0x3E33364", Offset = "0x3E2F364", VA = "0x3E33364")]
	private bool GrantReward(int rewardType, int rewardId, int num)
	{
		return default;
	}

	[Token(Token = "0x60003C4")]
	[Address(RVA = "0x3E3187C", Offset = "0x3E2D87C", VA = "0x3E3187C")]
	private bool IsGmIgnoreDayLimit()
	{
		return default;
	}

	[Token(Token = "0x60003C5")]
	[Address(RVA = "0x3E31998", Offset = "0x3E2D998", VA = "0x3E31998")]
	private bool IsDaySignableInGm(int day)
	{
		return default;
	}

	[Token(Token = "0x60003C6")]
	[Address(RVA = "0x3E33530", Offset = "0x3E2F530", VA = "0x3E33530")]
	[AsyncStateMachine(typeof(_003CEnsureUnlockBattleCountReady_003Ed__68))]
	private UniTask EnsureUnlockBattleCountReady()
	{
		return default;
	}

	[Token(Token = "0x60003C7")]
	[Address(RVA = "0x3E335BC", Offset = "0x3E2F5BC", VA = "0x3E335BC")]
	private void ParseUnlockBattleCount()
	{
	}

	[Token(Token = "0x60003C8")]
	[Address(RVA = "0x3E3386C", Offset = "0x3E2F86C", VA = "0x3E3386C")]
	private void UseDefaultUnlockParam(string raw)
	{
	}

	[Token(Token = "0x60003C9")]
	[Address(RVA = "0x3E2FC64", Offset = "0x3E2BC64", VA = "0x3E2FC64")]
	private bool IsReachUnlockBattleCount()
	{
		return default;
	}

	[Token(Token = "0x60003CA")]
	[Address(RVA = "0x3E30328", Offset = "0x3E2C328", VA = "0x3E30328")]
	private DateTime GetNow()
	{
		return default;
	}

	[Token(Token = "0x60003CB")]
	[Address(RVA = "0x3E3096C", Offset = "0x3E2C96C", VA = "0x3E3096C")]
	private void Save()
	{
	}

	[Token(Token = "0x60003CC")]
	[Address(RVA = "0x3E339D0", Offset = "0x3E2F9D0", VA = "0x3E339D0")]
	public CheckInRewardManager()
	{
	}
}
