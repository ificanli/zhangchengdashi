using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;
using ToolModule;

namespace GameModule
{
	[Token(Token = "0x2000592")]
	public class SeasonManager : ManagerBase<SeasonManager>
	{
		[Token(Token = "0x2000593")]
		public enum WeeklyClashStatus
		{
			[Token(Token = "0x400304C")]
			NoClash = 0,
			[Token(Token = "0x400304D")]
			Preparation = 1,
			[Token(Token = "0x400304E")]
			Battle = 2,
			[Token(Token = "0x400304F")]
			Settlement = 3
		}

		[Token(Token = "0x2000594")]
		public enum SeasonStatus
		{
			[Token(Token = "0x4003051")]
			NoSeason = 0,
			[Token(Token = "0x4003052")]
			Preparation = 1,
			[Token(Token = "0x4003053")]
			InProgress = 2,
			[Token(Token = "0x4003054")]
			Settlement = 3
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20005A0")]
		[CompilerGenerated]
		private struct _003CGetSeasonLeaderboardData_003Ed__69 : IAsyncStateMachine
		{
			[Token(Token = "0x400308A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400308B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400308C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SeasonManager _003C_003E4__this;

			[Token(Token = "0x400308D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action failCallback;

			[Token(Token = "0x400308E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001D57")]
			[Address(RVA = "0x3EDCD14", Offset = "0x3ED8D14", VA = "0x3EDCD14", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001D58")]
			[Address(RVA = "0x3EDD118", Offset = "0x3ED9118", VA = "0x3EDD118", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20005A1")]
		[CompilerGenerated]
		private struct _003CGetWeeklyClashLeaderboardData_003Ed__70 : IAsyncStateMachine
		{
			[Token(Token = "0x400308F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003090")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003091")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SeasonManager _003C_003E4__this;

			[Token(Token = "0x4003092")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action failCallback;

			[Token(Token = "0x4003093")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001D59")]
			[Address(RVA = "0x3EDD124", Offset = "0x3ED9124", VA = "0x3EDD124", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001D5A")]
			[Address(RVA = "0x3EDD528", Offset = "0x3ED9528", VA = "0x3EDD528", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20005A2")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__12 : IAsyncStateMachine
		{
			[Token(Token = "0x4003094")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003095")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003096")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SeasonManager _003C_003E4__this;

			[Token(Token = "0x6001D5B")]
			[Address(RVA = "0x3EDD534", Offset = "0x3ED9534", VA = "0x3EDD534", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001D5C")]
			[Address(RVA = "0x3EDDDD8", Offset = "0x3ED9DD8", VA = "0x3EDDDD8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20005A3")]
		[CompilerGenerated]
		private struct _003CUpdateSeasonLeaderboardScore_003Ed__71 : IAsyncStateMachine
		{
			[Token(Token = "0x4003097")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003098")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003099")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SeasonManager _003C_003E4__this;

			[Token(Token = "0x400309A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action failCallback;

			[Token(Token = "0x400309B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001D5D")]
			[Address(RVA = "0x3EDDDE4", Offset = "0x3ED9DE4", VA = "0x3EDDDE4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001D5E")]
			[Address(RVA = "0x3EDE1E8", Offset = "0x3EDA1E8", VA = "0x3EDE1E8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20005A4")]
		[CompilerGenerated]
		private struct _003CUpdateWeeklyClashLeaderboardScore_003Ed__72 : IAsyncStateMachine
		{
			[Token(Token = "0x400309C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400309D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400309E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SeasonManager _003C_003E4__this;

			[Token(Token = "0x400309F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action failCallback;

			[Token(Token = "0x40030A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001D5F")]
			[Address(RVA = "0x3EDE1F4", Offset = "0x3EDA1F4", VA = "0x3EDE1F4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001D60")]
			[Address(RVA = "0x3EDE5F8", Offset = "0x3EDA5F8", VA = "0x3EDE5F8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400303E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<SeasonConfig> seasonConfigs;

		[Token(Token = "0x400303F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<WeeklyClashConfig> weeklyClashConfigs;

		[Token(Token = "0x4003040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public SeasonTrackCustomEventController seasonTrackCustomEventController;

		[Token(Token = "0x4003041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int needBattleNumber;

		[Token(Token = "0x4003042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int WeeklyClashMaxBattleNumber;

		[Token(Token = "0x4003043")]
		private const int SeasonDurationDays = 28;

		[Token(Token = "0x4003044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool UseSeasonContentChanges;

		[Token(Token = "0x4003045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private SeasonConfig _currentSeason;

		[Token(Token = "0x4003046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private WeeklyClashConfig _currentWeeklyClash;

		[Token(Token = "0x4003047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool hadInit;

		[Token(Token = "0x4003048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Regex EndIntRegex;

		[Token(Token = "0x4003049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly DateTime ExcelBaseDate;

		[Token(Token = "0x400304A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float startMatchedEnemyTime;

		[Token(Token = "0x6001CE9")]
		[Address(RVA = "0x3ED5F3C", Offset = "0x3ED1F3C", VA = "0x3ED5F3C", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__12))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x6001CEA")]
		[Address(RVA = "0x3ED5FC0", Offset = "0x3ED1FC0", VA = "0x3ED5FC0")]
		public void InitializeWeeklyClashConfigs()
		{
		}

		[Token(Token = "0x6001CEB")]
		[Address(RVA = "0x3ED6348", Offset = "0x3ED2348", VA = "0x3ED6348")]
		public void InitializeSeasonConfigs()
		{
		}

		[Token(Token = "0x6001CEC")]
		[Address(RVA = "0x3ED6554", Offset = "0x3ED2554", VA = "0x3ED6554")]
		private int CalculateCurrentSeasonIndex(DateTime season1Start, DateTime currentTime)
		{
			return default;
		}

		[Token(Token = "0x6001CED")]
		[Address(RVA = "0x3ED6630", Offset = "0x3ED2630", VA = "0x3ED6630")]
		public SeasonConfig GetOrCreateSeasonConfig(int seasonIndex)
		{
			return null;
		}

		[Token(Token = "0x6001CEE")]
		[Address(RVA = "0x3ED626C", Offset = "0x3ED226C", VA = "0x3ED626C")]
		private int CalculateCurrentWeeklyIndex(DateTime season1Start, DateTime currentTime)
		{
			return default;
		}

		[Token(Token = "0x6001CEF")]
		[Address(RVA = "0x3ED67C0", Offset = "0x3ED27C0", VA = "0x3ED67C0")]
		public static int CalculateCurrentSeason(DateTime currentDate)
		{
			return default;
		}

		[Token(Token = "0x6001CF0")]
		[Address(RVA = "0x3ED6984", Offset = "0x3ED2984", VA = "0x3ED6984")]
		public static int GetCurrentSeasonNumber()
		{
			return default;
		}

		[Token(Token = "0x6001CF1")]
		[Address(RVA = "0x3ED698C", Offset = "0x3ED298C", VA = "0x3ED698C")]
		public static int GetTrailingInt(string input, int defaultValue = -1)
		{
			return default;
		}

		[Token(Token = "0x6001CF2")]
		[Address(RVA = "0x3ED6A44", Offset = "0x3ED2A44", VA = "0x3ED6A44")]
		public string GetSeasonBannerId([Optional] int? seasonIndex)
		{
			return null;
		}

		[Token(Token = "0x6001CF3")]
		[Address(RVA = "0x3ED6C58", Offset = "0x3ED2C58", VA = "0x3ED6C58")]
		public static int CalculateCurrentWeeklyTournament(DateTime currentDate)
		{
			return default;
		}

		[Token(Token = "0x6001CF4")]
		[Address(RVA = "0x3ED6830", Offset = "0x3ED2830", VA = "0x3ED6830")]
		private static int CalculateTotalWeeksSinceEpoch(DateTime currentDate)
		{
			return default;
		}

		[Token(Token = "0x6001CF5")]
		[Address(RVA = "0x3ED6D74", Offset = "0x3ED2D74", VA = "0x3ED6D74")]
		public void UpdateWeeklyClashPanel()
		{
		}

		[Token(Token = "0x6001CF6")]
		[Address(RVA = "0x3ED6E78", Offset = "0x3ED2E78", VA = "0x3ED6E78")]
		public SeasonConfig GetCurrentSeasonConfig()
		{
			return null;
		}

		[Token(Token = "0x6001CF7")]
		[Address(RVA = "0x3ED6E80", Offset = "0x3ED2E80", VA = "0x3ED6E80")]
		public DateTime GetCurrentSeasonStartTime()
		{
			return default;
		}

		[Token(Token = "0x6001CF8")]
		[Address(RVA = "0x3ED6EF4", Offset = "0x3ED2EF4", VA = "0x3ED6EF4")]
		public DateTime GetCurrentSeasonEndTime()
		{
			return default;
		}

		[Token(Token = "0x6001CF9")]
		[Address(RVA = "0x3ED6F68", Offset = "0x3ED2F68", VA = "0x3ED6F68")]
		public DateTime GetCurrentSeasonClaimRewardEndTime()
		{
			return default;
		}

		[Token(Token = "0x6001CFA")]
		[Address(RVA = "0x3ED6FDC", Offset = "0x3ED2FDC", VA = "0x3ED6FDC")]
		public DateTime GetCurrentWeeklyClashSeasonStartTime()
		{
			return default;
		}

		[Token(Token = "0x6001CFB")]
		[Address(RVA = "0x3ED70F0", Offset = "0x3ED30F0", VA = "0x3ED70F0")]
		public DateTime GetCurrentWeeklyClashSeasonEndTime()
		{
			return default;
		}

		[Token(Token = "0x6001CFC")]
		[Address(RVA = "0x3ED717C", Offset = "0x3ED317C", VA = "0x3ED717C")]
		public DateTime GetCurrentWeeklyClashSeasonClaimRewardEndTime()
		{
			return default;
		}

		[Token(Token = "0x6001CFD")]
		[Address(RVA = "0x3ED7208", Offset = "0x3ED3208", VA = "0x3ED7208")]
		public TimeSpan GetCurrentSeasonRemainingTime()
		{
			return default;
		}

		[Token(Token = "0x6001CFE")]
		[Address(RVA = "0x3ED730C", Offset = "0x3ED330C", VA = "0x3ED730C")]
		public bool IsSeasonActive()
		{
			return default;
		}

		[Token(Token = "0x6001CFF")]
		[Address(RVA = "0x3ED7404", Offset = "0x3ED3404", VA = "0x3ED7404")]
		public SeasonStatus GetCurrentSeasonStatus()
		{
			return default;
		}

		[Token(Token = "0x6001D00")]
		[Address(RVA = "0x3ED7544", Offset = "0x3ED3544", VA = "0x3ED7544")]
		public string GetSeasonStatusName()
		{
			return null;
		}

		[Token(Token = "0x6001D01")]
		[Address(RVA = "0x3ED7718", Offset = "0x3ED3718", VA = "0x3ED7718")]
		public TimeSpan GetCurrentSeasonPhaseRemainingTime()
		{
			return default;
		}

		[Token(Token = "0x6001D02")]
		[Address(RVA = "0x3ED7820", Offset = "0x3ED3820", VA = "0x3ED7820")]
		public bool IsSeasonRewardClaimed(string seasonId)
		{
			return default;
		}

		[Token(Token = "0x6001D03")]
		[Address(RVA = "0x3ED78C8", Offset = "0x3ED38C8", VA = "0x3ED78C8")]
		public bool IsCurrentWeeklyClashSeasonRewardClaimed()
		{
			return default;
		}

		[Token(Token = "0x6001D04")]
		[Address(RVA = "0x3ED78F4", Offset = "0x3ED38F4", VA = "0x3ED78F4")]
		public void RefreshCurrentSeason()
		{
		}

		[Token(Token = "0x6001D05")]
		[Address(RVA = "0x3ED7FE4", Offset = "0x3ED3FE4", VA = "0x3ED7FE4")]
		public string GetSeasonLeaderboardIdByWeeklyClash()
		{
			return null;
		}

		[Token(Token = "0x6001D06")]
		[Address(RVA = "0x3ED8088", Offset = "0x3ED4088", VA = "0x3ED8088")]
		public SingleSeasonData GetCurrentSeasonData()
		{
			return null;
		}

		[Token(Token = "0x6001D07")]
		[Address(RVA = "0x3ED80F8", Offset = "0x3ED40F8", VA = "0x3ED80F8")]
		public WeeklyClashConfig GetCurrentWeeklyClash()
		{
			return null;
		}

		[Token(Token = "0x6001D08")]
		[Address(RVA = "0x3ED8100", Offset = "0x3ED4100", VA = "0x3ED8100")]
		public DateTime GetCurrentWeeklyClashStartTime()
		{
			return default;
		}

		[Token(Token = "0x6001D09")]
		[Address(RVA = "0x3ED8174", Offset = "0x3ED4174", VA = "0x3ED8174")]
		public DateTime GetCurrentWeeklyClashEndTime()
		{
			return default;
		}

		[Token(Token = "0x6001D0A")]
		[Address(RVA = "0x3ED81E8", Offset = "0x3ED41E8", VA = "0x3ED81E8")]
		public DateTime GetCurrentWeeklyClashBattleStartTime()
		{
			return default;
		}

		[Token(Token = "0x6001D0B")]
		[Address(RVA = "0x3ED825C", Offset = "0x3ED425C", VA = "0x3ED825C")]
		public DateTime GetCurrentWeeklyClashBattleEndTime()
		{
			return default;
		}

		[Token(Token = "0x6001D0C")]
		[Address(RVA = "0x3ED82D0", Offset = "0x3ED42D0", VA = "0x3ED82D0")]
		public TimeSpan GetCurrentWeeklyClashRemainingTime()
		{
			return default;
		}

		[Token(Token = "0x6001D0D")]
		[Address(RVA = "0x3ED83D4", Offset = "0x3ED43D4", VA = "0x3ED83D4")]
		public bool IsWeeklyClashActive()
		{
			return default;
		}

		[Token(Token = "0x6001D0E")]
		[Address(RVA = "0x3ED84CC", Offset = "0x3ED44CC", VA = "0x3ED84CC")]
		public bool IsEligibleForCurrentWeeklyClash()
		{
			return default;
		}

		[Token(Token = "0x6001D0F")]
		[Address(RVA = "0x3ED8590", Offset = "0x3ED4590", VA = "0x3ED8590")]
		public TimeSpan GetTimeUntilBattleStart()
		{
			return default;
		}

		[Token(Token = "0x6001D10")]
		[Address(RVA = "0x3ED86D4", Offset = "0x3ED46D4", VA = "0x3ED86D4")]
		public TimeSpan GetTimeUntilBattleEnd()
		{
			return default;
		}

		[Token(Token = "0x6001D11")]
		[Address(RVA = "0x3ED8818", Offset = "0x3ED4818", VA = "0x3ED8818")]
		public bool IsShowWeeklyClashEnterBtn()
		{
			return default;
		}

		[Token(Token = "0x6001D12")]
		[Address(RVA = "0x3ED881C", Offset = "0x3ED481C", VA = "0x3ED881C")]
		public bool IsInWeeklyClashBattleTime()
		{
			return default;
		}

		[Token(Token = "0x6001D13")]
		[Address(RVA = "0x3ED8914", Offset = "0x3ED4914", VA = "0x3ED8914")]
		public void RefreshCurrentWeeklyClash()
		{
		}

		[Token(Token = "0x6001D14")]
		[Address(RVA = "0x3ED8CF8", Offset = "0x3ED4CF8", VA = "0x3ED8CF8")]
		public WeeklyClashStatus GetWeeklyClashStatus()
		{
			return default;
		}

		[Token(Token = "0x6001D15")]
		[Address(RVA = "0x3ED8FDC", Offset = "0x3ED4FDC", VA = "0x3ED8FDC")]
		public string GetWeeklyClashStatusName()
		{
			return null;
		}

		[Token(Token = "0x6001D16")]
		[Address(RVA = "0x3ED91B0", Offset = "0x3ED51B0", VA = "0x3ED91B0")]
		public int GetWeeklyClashIndexInSeason()
		{
			return default;
		}

		[Token(Token = "0x6001D17")]
		[Address(RVA = "0x3ED930C", Offset = "0x3ED530C", VA = "0x3ED930C")]
		public TimeSpan GetCurrentWeeklyClashPhaseRemainingTime()
		{
			return default;
		}

		[Token(Token = "0x6001D18")]
		[Address(RVA = "0x3ED9448", Offset = "0x3ED5448", VA = "0x3ED9448")]
		public bool IsWeeklyClashRewardClaimed(string weeklyClashId)
		{
			return default;
		}

		[Token(Token = "0x6001D19")]
		[Address(RVA = "0x3ED94EC", Offset = "0x3ED54EC", VA = "0x3ED94EC")]
		public bool IsCurrentWeeklyClashRewardClaimed()
		{
			return default;
		}

		[Token(Token = "0x6001D1A")]
		[Address(RVA = "0x3ED9504", Offset = "0x3ED5504", VA = "0x3ED9504")]
		public bool ClaimWeeklyClashReward(string weeklyClashId, int rank)
		{
			return default;
		}

		[Token(Token = "0x6001D1B")]
		[Address(RVA = "0x3ED97B8", Offset = "0x3ED57B8", VA = "0x3ED97B8")]
		public bool ClaimCurrentWeeklyClashReward(int rank)
		{
			return default;
		}

		[Token(Token = "0x6001D1C")]
		[Address(RVA = "0x3ED97D4", Offset = "0x3ED57D4", VA = "0x3ED97D4")]
		public bool ClaimSeasonReward(string seasonId, int rank)
		{
			return default;
		}

		[Token(Token = "0x6001D1D")]
		[Address(RVA = "0x3ED992C", Offset = "0x3ED592C", VA = "0x3ED992C")]
		public bool ClaimCurrentWeeklyClashSeasonReward(int rank)
		{
			return default;
		}

		[Token(Token = "0x6001D1E")]
		[Address(RVA = "0x3ED9968", Offset = "0x3ED5968", VA = "0x3ED9968")]
		public string GetCurrentWeeklyClashLeaderboardId()
		{
			return null;
		}

		[Token(Token = "0x6001D1F")]
		[Address(RVA = "0x3ED7BB0", Offset = "0x3ED3BB0", VA = "0x3ED7BB0")]
		private void InitializeNewSeasonData(string newSeasonId)
		{
		}

		[Token(Token = "0x6001D20")]
		[Address(RVA = "0x3ED8BFC", Offset = "0x3ED4BFC", VA = "0x3ED8BFC")]
		private void InitializeNewWeeklyClashData(string newWeeklyClashId)
		{
		}

		[Token(Token = "0x6001D21")]
		[Address(RVA = "0x3ED99C8", Offset = "0x3ED59C8", VA = "0x3ED99C8")]
		[AsyncStateMachine(typeof(_003CGetSeasonLeaderboardData_003Ed__69))]
		public UniTask GetSeasonLeaderboardData(int topCount, Action successCallback, Action failCallback)
		{
			return default;
		}

		[Token(Token = "0x6001D22")]
		[Address(RVA = "0x3ED9A64", Offset = "0x3ED5A64", VA = "0x3ED9A64")]
		[AsyncStateMachine(typeof(_003CGetWeeklyClashLeaderboardData_003Ed__70))]
		public UniTask GetWeeklyClashLeaderboardData(int topCount, Action successCallback, Action failCallback)
		{
			return default;
		}

		[Token(Token = "0x6001D23")]
		[Address(RVA = "0x3ED9B00", Offset = "0x3ED5B00", VA = "0x3ED9B00")]
		[AsyncStateMachine(typeof(_003CUpdateSeasonLeaderboardScore_003Ed__71))]
		public UniTask UpdateSeasonLeaderboardScore(int score, Action successCallback, Action failCallback)
		{
			return default;
		}

		[Token(Token = "0x6001D24")]
		[Address(RVA = "0x3ED9B9C", Offset = "0x3ED5B9C", VA = "0x3ED9B9C")]
		[AsyncStateMachine(typeof(_003CUpdateWeeklyClashLeaderboardScore_003Ed__72))]
		public UniTask UpdateWeeklyClashLeaderboardScore(int score, Action successCallback, Action failCallback)
		{
			return default;
		}

		[Token(Token = "0x6001D25")]
		[Address(RVA = "0x3ED9C38", Offset = "0x3ED5C38", VA = "0x3ED9C38")]
		public void ChangeWeeklyClashScores(bool isWin, string difficultyConfigId)
		{
		}

		[Token(Token = "0x6001D26")]
		[Address(RVA = "0x3EDA1C8", Offset = "0x3ED61C8", VA = "0x3EDA1C8")]
		[Obsolete("此方法仅用于测试，实际游戏应使用 ChangeWeeklyClashScores(bool, string)")]
		public void ChangeWeeklyClashScores(int scoreDelta)
		{
		}

		[Token(Token = "0x6001D27")]
		[Address(RVA = "0x3ED9660", Offset = "0x3ED5660", VA = "0x3ED9660")]
		public string GetRewardStringByRank(int rank, bool isWeeklyClash = true)
		{
			return null;
		}

		[Token(Token = "0x6001D28")]
		[Address(RVA = "0x3ED8018", Offset = "0x3ED4018", VA = "0x3ED8018")]
		public SingleWeeklyClashData GetCurrentWeeklyClashData()
		{
			return null;
		}

		[Token(Token = "0x6001D29")]
		[Address(RVA = "0x3ED7068", Offset = "0x3ED3068", VA = "0x3ED7068")]
		public SingleSeasonData GetCurrentWeeklyClashSeasonData()
		{
			return null;
		}

		[Token(Token = "0x6001D2A")]
		[Address(RVA = "0x3EDA614", Offset = "0x3ED6614", VA = "0x3EDA614")]
		public void StartWeeklyClashBattle()
		{
		}

		[Token(Token = "0x6001D2B")]
		[Address(RVA = "0x3EDA71C", Offset = "0x3ED671C", VA = "0x3EDA71C")]
		private void MatchedEnemy()
		{
		}

		[Token(Token = "0x6001D2C")]
		[Address(RVA = "0x3EDA720", Offset = "0x3ED6720", VA = "0x3EDA720")]
		public int CalculatePVPWinSeasonPassExpReward()
		{
			return default;
		}

		[Token(Token = "0x6001D2D")]
		[Address(RVA = "0x3EDA914", Offset = "0x3ED6914", VA = "0x3EDA914")]
		public string GetDailySeasonPassScoreString()
		{
			return null;
		}

		[Token(Token = "0x6001D2E")]
		[Address(RVA = "0x3ED8E60", Offset = "0x3ED4E60", VA = "0x3ED8E60")]
		private void CheckWeeklyClashRedDot()
		{
		}

		[Token(Token = "0x6001D2F")]
		[Address(RVA = "0x3EDA9FC", Offset = "0x3ED69FC", VA = "0x3EDA9FC")]
		public SeasonManager()
		{
		}
	}
}
