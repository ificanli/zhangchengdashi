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

namespace GameModule
{
	[Token(Token = "0x20005C7")]
	public class SubGameChaosTrailsManager : ManagerBase<SubGameChaosTrailsManager>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20005C9")]
		[CompilerGenerated]
		private struct _003CEnsureOnlineParamReady_003Ed__68 : IAsyncStateMachine
		{
			[Token(Token = "0x4003133")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003134")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003135")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SubGameChaosTrailsManager _003C_003E4__this;

			[Token(Token = "0x4003136")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask<bool>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001E4D")]
			[Address(RVA = "0x3EF45EC", Offset = "0x3EF05EC", VA = "0x3EF45EC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001E4E")]
			[Address(RVA = "0x3EF4BB4", Offset = "0x3EF0BB4", VA = "0x3EF4BB4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20005CA")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__38 : IAsyncStateMachine
		{
			[Token(Token = "0x4003137")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003138")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003139")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SubGameChaosTrailsManager _003C_003E4__this;

			[Token(Token = "0x400313A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001E4F")]
			[Address(RVA = "0x3EF4BC0", Offset = "0x3EF0BC0", VA = "0x3EF4BC0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001E50")]
			[Address(RVA = "0x3EF5108", Offset = "0x3EF1108", VA = "0x3EF5108", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20005CB")]
		[CompilerGenerated]
		private struct _003CRestartNextOpenRefreshTimerNextFrame_003Ed__81 : IAsyncStateMachine
		{
			[Token(Token = "0x400313B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400313C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400313D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SubGameChaosTrailsManager _003C_003E4__this;

			[Token(Token = "0x400313E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001E51")]
			[Address(RVA = "0x3EF5114", Offset = "0x3EF1114", VA = "0x3EF5114", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001E52")]
			[Address(RVA = "0x3EF52C8", Offset = "0x3EF12C8", VA = "0x3EF52C8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20005CC")]
		[CompilerGenerated]
		private struct _003CRestartWindowEndTimerNextFrame_003Ed__82 : IAsyncStateMachine
		{
			[Token(Token = "0x400313F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003140")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003141")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SubGameChaosTrailsManager _003C_003E4__this;

			[Token(Token = "0x4003142")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001E53")]
			[Address(RVA = "0x3EF52D4", Offset = "0x3EF12D4", VA = "0x3EF52D4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001E54")]
			[Address(RVA = "0x3EF5488", Offset = "0x3EF1488", VA = "0x3EF5488", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20005CD")]
		[CompilerGenerated]
		private struct _003CShowPanelAsync_003Ed__57 : IAsyncStateMachine
		{
			[Token(Token = "0x4003143")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003144")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003145")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SubGameChaosTrailsManager _003C_003E4__this;

			[Token(Token = "0x4003146")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001E55")]
			[Address(RVA = "0x3EF5494", Offset = "0x3EF1494", VA = "0x3EF5494", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001E56")]
			[Address(RVA = "0x3EF59B4", Offset = "0x3EF19B4", VA = "0x3EF59B4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20005CE")]
		[CompilerGenerated]
		private struct _003CTryReturnToPanelAfterEnterMetaAsync_003Ed__59 : IAsyncStateMachine
		{
			[Token(Token = "0x4003147")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003148")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003149")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SubGameChaosTrailsManager _003C_003E4__this;

			[Token(Token = "0x400314A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001E57")]
			[Address(RVA = "0x3EF59C0", Offset = "0x3EF19C0", VA = "0x3EF59C0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001E58")]
			[Address(RVA = "0x3EF5EAC", Offset = "0x3EF1EAC", VA = "0x3EF5EAC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003118")]
		private const string SaveKey = "SubGameChaosTrails_SaveData";

		[Token(Token = "0x4003119")]
		private const string OnlineParamKey = "Sub_Chaos";

		[Token(Token = "0x400311A")]
		private const string DefaultOnlineParam = "1_5_0_0_1_3_18_22_5";

		[Token(Token = "0x400311B")]
		private const int DefaultMaxDailyBaseRewardPlayCount = 5;

		[Token(Token = "0x400311C")]
		private const int DefaultMaxDailyDiamondRefreshCount = 50;

		[Token(Token = "0x400311D")]
		private const int OnlineParamWaitTimeoutSeconds = 10;

		[Token(Token = "0x400311E")]
		private const int BuffRollCount = 3;

		[Token(Token = "0x400311F")]
		private const string NotInOpenTimeTipText = "活动不在开放时间段";

		[Token(Token = "0x4003120")]
		public const int DiamondRefreshCost = 20;

		[Token(Token = "0x4003121")]
		private const string NextOpenRefreshTimerKey = "SubGameChaosTrails_NextOpenRefresh";

		[Token(Token = "0x4003122")]
		private const string WindowEndTimerKey = "SubGameChaosTrails_WindowEnd";

		[Token(Token = "0x4003123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private SubGameChaosTrailsSaveData _saveData;

		[Token(Token = "0x4003124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _isSaveLoaded;

		[Token(Token = "0x4003125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		private bool _hasSaveData;

		[Token(Token = "0x4003126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		private bool _isOnlineParamReady;

		[Token(Token = "0x4003127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
		private bool _isFeatureOpen;

		[Token(Token = "0x4003128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int _unlockArenaIndex;

		[Token(Token = "0x4003129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float _expRatio;

		[Token(Token = "0x400312A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float _trophyRatio;

		[Token(Token = "0x400312B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float _baseRewardRatio;

		[Token(Token = "0x400312C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int _maxDailyRefreshCount;

		[Token(Token = "0x400312D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int _openHourStart;

		[Token(Token = "0x400312E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int _openHourEnd;

		[Token(Token = "0x400312F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int _maxDailyBaseRewardPlayCount;

		[Token(Token = "0x4003130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private ThrottleTrigger _redDotThrottleTrigger;

		[Token(Token = "0x17000181")]
		public float ExpRatio
		{
			[Token(Token = "0x6001E0E")]
			[Address(RVA = "0x3EF0ADC", Offset = "0x3EECADC", VA = "0x3EF0ADC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000182")]
		public float TrophyRatio
		{
			[Token(Token = "0x6001E0F")]
			[Address(RVA = "0x3EF0AF8", Offset = "0x3EECAF8", VA = "0x3EF0AF8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000183")]
		public float BaseRewardRatio
		{
			[Token(Token = "0x6001E10")]
			[Address(RVA = "0x3EF0B14", Offset = "0x3EECB14", VA = "0x3EF0B14")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000184")]
		public int MaxDailyRefreshCount
		{
			[Token(Token = "0x6001E11")]
			[Address(RVA = "0x3EF0B84", Offset = "0x3EECB84", VA = "0x3EF0B84")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000185")]
		public int MaxDailyDiamondRefreshCount
		{
			[Token(Token = "0x6001E12")]
			[Address(RVA = "0x3EF0B8C", Offset = "0x3EECB8C", VA = "0x3EF0B8C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000186")]
		public int MaxDailyBaseRewardPlayCount
		{
			[Token(Token = "0x6001E13")]
			[Address(RVA = "0x3EF0B94", Offset = "0x3EECB94", VA = "0x3EF0B94")]
			get
			{
				return _maxDailyBaseRewardPlayCount;
			}
		}

		[Token(Token = "0x6001E14")]
		[Address(RVA = "0x3EF0B9C", Offset = "0x3EECB9C", VA = "0x3EF0B9C")]
		public int GetRemainingDailyBaseRewardPlayCount()
		{
			return default;
		}

		[Token(Token = "0x6001E15")]
		[Address(RVA = "0x3EF0D94", Offset = "0x3EECD94", VA = "0x3EF0D94", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__38))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x6001E16")]
		[Address(RVA = "0x3EF0E20", Offset = "0x3EECE20", VA = "0x3EF0E20")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6001E17")]
		[Address(RVA = "0x3EF0F40", Offset = "0x3EECF40", VA = "0x3EF0F40")]
		private void OnEntranceStateMaybeChanged(object obj)
		{
		}

		[Token(Token = "0x6001E18")]
		[Address(RVA = "0x3EF0F44", Offset = "0x3EECF44", VA = "0x3EF0F44")]
		public void RegisterRedDotTrigger()
		{
		}

		[Token(Token = "0x6001E19")]
		[Address(RVA = "0x3EF0F58", Offset = "0x3EECF58", VA = "0x3EF0F58")]
		private void CheckRedDot()
		{
		}

		[Token(Token = "0x6001E1A")]
		[Address(RVA = "0x3EF1018", Offset = "0x3EED018", VA = "0x3EF1018")]
		public bool IsFeatureVisible()
		{
			return default;
		}

		[Token(Token = "0x6001E1B")]
		[Address(RVA = "0x3EF1020", Offset = "0x3EED020", VA = "0x3EF1020")]
		public bool IsUnlockConditionMet()
		{
			return default;
		}

		[Token(Token = "0x6001E1C")]
		[Address(RVA = "0x3EF10DC", Offset = "0x3EED0DC", VA = "0x3EF10DC")]
		public bool IsEntranceVisible()
		{
			return default;
		}

		[Token(Token = "0x6001E1D")]
		[Address(RVA = "0x3EF10F8", Offset = "0x3EED0F8", VA = "0x3EF10F8")]
		public bool IsInOpenTimeWindow()
		{
			return default;
		}

		[Token(Token = "0x6001E1E")]
		[Address(RVA = "0x3EF12C8", Offset = "0x3EED2C8", VA = "0x3EF12C8")]
		public bool CanPerformGameplayActions()
		{
			return default;
		}

		[Token(Token = "0x6001E1F")]
		[Address(RVA = "0x3EF12CC", Offset = "0x3EED2CC", VA = "0x3EF12CC")]
		public bool CanOpenPanel()
		{
			return default;
		}

		[Token(Token = "0x6001E20")]
		[Address(RVA = "0x3EF1384", Offset = "0x3EED384", VA = "0x3EF1384")]
		public bool HasSaveData()
		{
			return default;
		}

		[Token(Token = "0x6001E21")]
		[Address(RVA = "0x3EF13B8", Offset = "0x3EED3B8", VA = "0x3EF13B8")]
		public List<int> GetDisplayBuffIds()
		{
			return null;
		}

		[Token(Token = "0x6001E22")]
		[Address(RVA = "0x3EF147C", Offset = "0x3EED47C", VA = "0x3EF147C")]
		public int GetRemainingRefreshCount()
		{
			return default;
		}

		[Token(Token = "0x6001E23")]
		[Address(RVA = "0x3EF14BC", Offset = "0x3EED4BC", VA = "0x3EF14BC")]
		public int GetRemainingDiamondRefreshCount()
		{
			return default;
		}

		[Token(Token = "0x6001E24")]
		[Address(RVA = "0x3EF14FC", Offset = "0x3EED4FC", VA = "0x3EF14FC")]
		public string GetOpenTimeDisplayText()
		{
			return null;
		}

		[Token(Token = "0x6001E25")]
		[Address(RVA = "0x3EF15D4", Offset = "0x3EED5D4", VA = "0x3EF15D4")]
		public TimeSpan GetTimeSpanToNextOpenWindow()
		{
			return default;
		}

		[Token(Token = "0x6001E26")]
		[Address(RVA = "0x3EF1734", Offset = "0x3EED734", VA = "0x3EF1734")]
		public string GetCardBgSpritePath(int rare)
		{
			return null;
		}

		[Token(Token = "0x6001E27")]
		[Address(RVA = "0x3EF17B8", Offset = "0x3EED7B8", VA = "0x3EF17B8")]
		public void TryShowNotInOpenTimeTip()
		{
		}

		[Token(Token = "0x6001E28")]
		[Address(RVA = "0x3EF17FC", Offset = "0x3EED7FC", VA = "0x3EF17FC")]
		[AsyncStateMachine(typeof(_003CShowPanelAsync_003Ed__57))]
		public UniTask ShowPanelAsync()
		{
			return default;
		}

		[Token(Token = "0x6001E29")]
		[Address(RVA = "0x3EF1888", Offset = "0x3EED888", VA = "0x3EF1888")]
		public void TryReturnToPanelAfterEnterMeta(BattleResult battleResult)
		{
		}

		[Token(Token = "0x6001E2A")]
		[Address(RVA = "0x3EF18BC", Offset = "0x3EED8BC", VA = "0x3EF18BC")]
		[AsyncStateMachine(typeof(_003CTryReturnToPanelAfterEnterMetaAsync_003Ed__59))]
		private UniTaskVoid TryReturnToPanelAfterEnterMetaAsync()
		{
			return default;
		}

		[Token(Token = "0x6001E2B")]
		[Address(RVA = "0x3EF1934", Offset = "0x3EED934", VA = "0x3EF1934")]
		private bool CanReturnToPanelAfterEnterMeta()
		{
			return default;
		}

		[Token(Token = "0x6001E2C")]
		[Address(RVA = "0x3EF1A54", Offset = "0x3EEDA54", VA = "0x3EF1A54")]
		public bool TryBeginRefreshByAd()
		{
			return default;
		}

		[Token(Token = "0x6001E2D")]
		[Address(RVA = "0x3EF1AA8", Offset = "0x3EEDAA8", VA = "0x3EF1AA8")]
		public bool TryRefreshByDiamond(out bool insufficientDiamond)
		{
			return default;
		}

		[Token(Token = "0x6001E2E")]
		[Address(RVA = "0x3EF26A0", Offset = "0x3EEE6A0", VA = "0x3EF26A0")]
		public void OnRefreshAdSuccess()
		{
		}

		[Token(Token = "0x6001E2F")]
		[Address(RVA = "0x3EF26F0", Offset = "0x3EEE6F0", VA = "0x3EF26F0")]
		public void StartBattle()
		{
		}

		[Token(Token = "0x6001E30")]
		[Address(RVA = "0x3EF2B28", Offset = "0x3EEEB28", VA = "0x3EF2B28")]
		public static bool ValidateBuffIds(List<int> buffIds, out string errorMessage)
		{
			return default;
		}

		[Token(Token = "0x6001E31")]
		[Address(RVA = "0x3EF2DBC", Offset = "0x3EEEDBC", VA = "0x3EF2DBC")]
		public void RecordDailyBaseRewardPlay()
		{
		}

		[Token(Token = "0x6001E32")]
		[Address(RVA = "0x3EF0B44", Offset = "0x3EECB44", VA = "0x3EF0B44")]
		private bool IsDailyBaseRewardPlayLimitReached()
		{
			return default;
		}

		[Token(Token = "0x6001E33")]
		[Address(RVA = "0x3EF2F38", Offset = "0x3EEEF38", VA = "0x3EF2F38")]
		[AsyncStateMachine(typeof(_003CEnsureOnlineParamReady_003Ed__68))]
		private UniTask EnsureOnlineParamReady()
		{
			return default;
		}

		[Token(Token = "0x6001E34")]
		[Address(RVA = "0x3EF2FC4", Offset = "0x3EEEFC4", VA = "0x3EF2FC4")]
		private void ParseSubChaosOnlineParam()
		{
		}

		[Token(Token = "0x6001E35")]
		[Address(RVA = "0x3EF34F8", Offset = "0x3EEF4F8", VA = "0x3EF34F8")]
		private void UseDefaultOnlineParam()
		{
		}

		[Token(Token = "0x6001E36")]
		[Address(RVA = "0x3EF0BDC", Offset = "0x3EECBDC", VA = "0x3EF0BDC")]
		private void EnsureLoadSaveData(bool createIfMissing)
		{
		}

		[Token(Token = "0x6001E37")]
		[Address(RVA = "0x3EF3528", Offset = "0x3EEF528", VA = "0x3EF3528")]
		private void EnsureSaveOnFirstEntry()
		{
		}

		[Token(Token = "0x6001E38")]
		[Address(RVA = "0x3EF24DC", Offset = "0x3EEE4DC", VA = "0x3EF24DC")]
		private void Save()
		{
		}

		[Token(Token = "0x6001E39")]
		[Address(RVA = "0x3EF2490", Offset = "0x3EEE490", VA = "0x3EF2490")]
		private void RollNewBuffsToSave()
		{
		}

		[Token(Token = "0x6001E3A")]
		[Address(RVA = "0x3EF35B8", Offset = "0x3EEF5B8", VA = "0x3EF35B8")]
		private List<int> RollBuffIds(int count)
		{
			return null;
		}

		[Token(Token = "0x6001E3B")]
		[Address(RVA = "0x3EF29CC", Offset = "0x3EEE9CC", VA = "0x3EF29CC")]
		private bool TryCopyBattleBuffIds(out List<int> battleBuffIds)
		{
			return default;
		}

		[Token(Token = "0x6001E3C")]
		[Address(RVA = "0x3EF2E0C", Offset = "0x3EEEE0C", VA = "0x3EF2E0C")]
		private void TryRefreshOnOpenTimeIfNeeded()
		{
		}

		[Token(Token = "0x6001E3D")]
		[Address(RVA = "0x3EF3B78", Offset = "0x3EEFB78", VA = "0x3EF3B78")]
		private void PerformOpenCycleRefresh(string cycleKey)
		{
		}

		[Token(Token = "0x6001E3E")]
		[Address(RVA = "0x3EF3BEC", Offset = "0x3EEFBEC", VA = "0x3EF3BEC")]
		private void OnOpenTimeRefreshTimerEnd()
		{
		}

		[Token(Token = "0x6001E3F")]
		[Address(RVA = "0x3EF3E58", Offset = "0x3EEFE58", VA = "0x3EF3E58")]
		private void OnWindowEndTimerEnd()
		{
		}

		[Token(Token = "0x6001E40")]
		[Address(RVA = "0x3EF3DE4", Offset = "0x3EEFDE4", VA = "0x3EF3DE4")]
		[AsyncStateMachine(typeof(_003CRestartNextOpenRefreshTimerNextFrame_003Ed__81))]
		private UniTaskVoid RestartNextOpenRefreshTimerNextFrame()
		{
			return default;
		}

		[Token(Token = "0x6001E41")]
		[Address(RVA = "0x3EF3F34", Offset = "0x3EEFF34", VA = "0x3EF3F34")]
		[AsyncStateMachine(typeof(_003CRestartWindowEndTimerNextFrame_003Ed__82))]
		private UniTaskVoid RestartWindowEndTimerNextFrame()
		{
			return default;
		}

		[Token(Token = "0x6001E42")]
		[Address(RVA = "0x3EF3FA8", Offset = "0x3EEFFA8", VA = "0x3EF3FA8")]
		private void StartTimers()
		{
		}

		[Token(Token = "0x6001E43")]
		[Address(RVA = "0x3EF3FC0", Offset = "0x3EEFFC0", VA = "0x3EF3FC0")]
		private void ScheduleNextOpenRefreshTimer()
		{
		}

		[Token(Token = "0x6001E44")]
		[Address(RVA = "0x3EF4244", Offset = "0x3EF0244", VA = "0x3EF4244")]
		private void ScheduleWindowEndTimer()
		{
		}

		[Token(Token = "0x6001E45")]
		[Address(RVA = "0x3EF3A1C", Offset = "0x3EEFA1C", VA = "0x3EF3A1C")]
		private string GetCurrentOpenCycleKey(DateTime now)
		{
			return null;
		}

		[Token(Token = "0x6001E46")]
		[Address(RVA = "0x3EF11FC", Offset = "0x3EED1FC", VA = "0x3EF11FC")]
		private DateTime GetNow()
		{
			return default;
		}

		[Token(Token = "0x6001E47")]
		[Address(RVA = "0x3EF25C8", Offset = "0x3EEE5C8", VA = "0x3EF25C8")]
		private void NotifyDataChanged()
		{
		}

		[Token(Token = "0x6001E48")]
		[Address(RVA = "0x3EF3D24", Offset = "0x3EEFD24", VA = "0x3EF3D24")]
		private void NotifyOpenWindowStateChanged()
		{
		}

		[Token(Token = "0x6001E49")]
		[Address(RVA = "0x3EF44C8", Offset = "0x3EF04C8", VA = "0x3EF44C8")]
		public SubGameChaosTrailsManager()
		{
		}
	}
}
