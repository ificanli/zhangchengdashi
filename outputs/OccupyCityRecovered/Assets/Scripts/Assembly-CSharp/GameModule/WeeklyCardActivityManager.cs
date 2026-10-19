using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;
using ToolModule;

namespace GameModule
{
	[Token(Token = "0x20004B1")]
	public class WeeklyCardActivityManager : ManagerBase<WeeklyCardActivityManager>
	{
		[Token(Token = "0x20004B2")]
		public enum WeekLyTaskType
		{
			[Token(Token = "0x4002BBF")]
			PlayGames = 0,
			[Token(Token = "0x4002BC0")]
			GameWin = 1,
			[Token(Token = "0x4002BC1")]
			CostDiamonds = 2,
			[Token(Token = "0x4002BC2")]
			CostCoin = 3,
			[Token(Token = "0x4002BC3")]
			CostWood = 4
		}

		[Token(Token = "0x20004B3")]
		public enum CycleCardType
		{
			[Token(Token = "0x4002BC5")]
			DeathKnight = 0,
			[Token(Token = "0x4002BC6")]
			Chief = 1,
			[Token(Token = "0x4002BC7")]
			DemonLord = 2,
			[Token(Token = "0x4002BC8")]
			Panda = 3
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20004B8")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__5 : IAsyncStateMachine
		{
			[Token(Token = "0x4002BD2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002BD3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002BD4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public WeeklyCardActivityManager _003C_003E4__this;

			[Token(Token = "0x6001798")]
			[Address(RVA = "0x3E5EA48", Offset = "0x3E5AA48", VA = "0x3E5EA48", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001799")]
			[Address(RVA = "0x3E5F430", Offset = "0x3E5B430", VA = "0x3E5F430", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20004B9")]
		[CompilerGenerated]
		private struct _003CShowWeeklyCardActivityPanel_003Ed__37 : IAsyncStateMachine
		{
			[Token(Token = "0x4002BD5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002BD6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002BD7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string giftPackPlacementFromEntry;

			[Token(Token = "0x4002BD8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600179A")]
			[Address(RVA = "0x3E5F43C", Offset = "0x3E5B43C", VA = "0x3E5F43C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600179B")]
			[Address(RVA = "0x3E5F7CC", Offset = "0x3E5B7CC", VA = "0x3E5F7CC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4002BBB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GoldCardGiftPackController goldCardGiftPackController;

		[Token(Token = "0x4002BBC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private WeeklyCardTrackCustomEventController trackEventController;

		[Token(Token = "0x4002BBD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<string> cycleCardIdList;

		[Token(Token = "0x600175F")]
		[Address(RVA = "0x3E5B4D4", Offset = "0x3E574D4", VA = "0x3E5B4D4", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__5))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x6001760")]
		[Address(RVA = "0x3E5B558", Offset = "0x3E57558", VA = "0x3E5B558")]
		private void HandleTaskProgress(object o)
		{
		}

		[Token(Token = "0x6001761")]
		[Address(RVA = "0x3E5BA6C", Offset = "0x3E57A6C", VA = "0x3E5BA6C")]
		private static DateTime GetScheduledUnlockTime(DateTime firstEnterGameTime)
		{
			return default;
		}

		[Token(Token = "0x6001762")]
		[Address(RVA = "0x3E5BAE4", Offset = "0x3E57AE4", VA = "0x3E5BAE4")]
		private void TryUnlockGoldCardWeekIfDue()
		{
		}

		[Token(Token = "0x6001763")]
		[Address(RVA = "0x3E5BC1C", Offset = "0x3E57C1C", VA = "0x3E5BC1C")]
		private void BeginGoldCardWeekActivity(bool isInitBegin)
		{
		}

		[Token(Token = "0x6001764")]
		[Address(RVA = "0x3E5BE44", Offset = "0x3E57E44", VA = "0x3E5BE44")]
		private void CheckAndCycleIfNeeded()
		{
		}

		[Token(Token = "0x6001765")]
		[Address(RVA = "0x3E5BF74", Offset = "0x3E57F74", VA = "0x3E5BF74")]
		private void CycleCard()
		{
		}

		[Token(Token = "0x6001766")]
		[Address(RVA = "0x3E5C178", Offset = "0x3E58178", VA = "0x3E5C178")]
		private void ReportTaskCompletionSummary()
		{
		}

		[Token(Token = "0x6001767")]
		[Address(RVA = "0x3E5C4C0", Offset = "0x3E584C0", VA = "0x3E5C4C0")]
		public void ClaimDailyTaskReward(string taskID)
		{
		}

		[Token(Token = "0x6001768")]
		[Address(RVA = "0x3E5C714", Offset = "0x3E58714", VA = "0x3E5C714")]
		public bool HasClaimableStageReward()
		{
			return default;
		}

		[Token(Token = "0x6001769")]
		[Address(RVA = "0x3E5C894", Offset = "0x3E58894", VA = "0x3E5C894")]
		public void ClaimStageReward()
		{
		}

		[Token(Token = "0x600176A")]
		[Address(RVA = "0x3E5C388", Offset = "0x3E58388", VA = "0x3E5C388")]
		private void RefreshActivityPanelIfShowing()
		{
		}

		[Token(Token = "0x600176B")]
		[Address(RVA = "0x3E5CD3C", Offset = "0x3E58D3C", VA = "0x3E5CD3C")]
		private void ResetDailyTaskProgress()
		{
		}

		[Token(Token = "0x600176C")]
		[Address(RVA = "0x3E5C308", Offset = "0x3E58308", VA = "0x3E5C308")]
		private void ResetWeeklyProgress()
		{
		}

		[Token(Token = "0x600176D")]
		[Address(RVA = "0x3E5CE38", Offset = "0x3E58E38", VA = "0x3E5CE38")]
		public bool IsCycleCardId(string cardId)
		{
			return default;
		}

		[Token(Token = "0x600176E")]
		[Address(RVA = "0x3E5CE90", Offset = "0x3E58E90", VA = "0x3E5CE90")]
		public int GetDailyTaskProgress(string taskId)
		{
			return default;
		}

		[Token(Token = "0x600176F")]
		[Address(RVA = "0x3E5CFB0", Offset = "0x3E58FB0", VA = "0x3E5CFB0")]
		public string GetMonDayCutDownStr()
		{
			return null;
		}

		[Token(Token = "0x6001770")]
		[Address(RVA = "0x3E5D09C", Offset = "0x3E5909C", VA = "0x3E5D09C")]
		public string GetGoldCardWeeklyActivityCutDownStr()
		{
			return null;
		}

		[Token(Token = "0x6001771")]
		[Address(RVA = "0x3E5B8BC", Offset = "0x3E578BC", VA = "0x3E5B8BC")]
		public WeekLyTaskType GetTaskEnum(string taskId)
		{
			return default;
		}

		[Token(Token = "0x6001772")]
		[Address(RVA = "0x3E5B95C", Offset = "0x3E5795C", VA = "0x3E5B95C")]
		public int GetTaskRequireNum(string taskId)
		{
			return default;
		}

		[Token(Token = "0x6001773")]
		[Address(RVA = "0x3E5CC44", Offset = "0x3E58C44", VA = "0x3E5CC44")]
		public string GetNowCycleCardID()
		{
			return null;
		}

		[Token(Token = "0x6001774")]
		[Address(RVA = "0x3E5D2A0", Offset = "0x3E592A0", VA = "0x3E5D2A0")]
		public static bool IsInNextWeek(DateTime firstTime, DateTime secondTime)
		{
			return default;
		}

		[Token(Token = "0x6001775")]
		[Address(RVA = "0x3E5D378", Offset = "0x3E59378", VA = "0x3E5D378")]
		public static DateTime GetStartOfWeek(DateTime date, DayOfWeek startOfWeek = DayOfWeek.Monday)
		{
			return default;
		}

		[Token(Token = "0x6001776")]
		[Address(RVA = "0x3E5D434", Offset = "0x3E59434", VA = "0x3E5D434")]
		private DateTime GetStartOfWeek(DateTime dt)
		{
			return default;
		}

		[Token(Token = "0x6001777")]
		[Address(RVA = "0x3E5D4E4", Offset = "0x3E594E4", VA = "0x3E5D4E4")]
		public List<GlobalWeeklyCardDailyTaskInfo> GetSortedTasks()
		{
			return null;
		}

		[Token(Token = "0x6001778")]
		[Address(RVA = "0x3E5D6FC", Offset = "0x3E596FC", VA = "0x3E5D6FC")]
		public bool GetDailyTaskIsComplete(string taskId)
		{
			return default;
		}

		[Token(Token = "0x6001779")]
		[Address(RVA = "0x3E5D80C", Offset = "0x3E5980C", VA = "0x3E5D80C")]
		public bool GetDailyTaskIsClaim(string taskId)
		{
			return default;
		}

		[Token(Token = "0x600177A")]
		[Address(RVA = "0x3E5B9EC", Offset = "0x3E579EC", VA = "0x3E5B9EC")]
		public void CheckActivityBtnRedDot()
		{
		}

		[Token(Token = "0x600177B")]
		[Address(RVA = "0x3E5D91C", Offset = "0x3E5991C", VA = "0x3E5D91C")]
		private bool GetHasCanClaimReward()
		{
			return default;
		}

		[Token(Token = "0x600177C")]
		[Address(RVA = "0x3E5DAE8", Offset = "0x3E59AE8", VA = "0x3E5DAE8")]
		public bool GetStageIsCanClaim(int stageNum, int id)
		{
			return default;
		}

		[Token(Token = "0x600177D")]
		[Address(RVA = "0x3E5DBB0", Offset = "0x3E59BB0", VA = "0x3E5DBB0")]
		public bool IsBTest()
		{
			return default;
		}

		[Token(Token = "0x600177E")]
		[Address(RVA = "0x3E5DC24", Offset = "0x3E59C24", VA = "0x3E5DC24")]
		public bool ShouldShowEntryButton()
		{
			return default;
		}

		[Token(Token = "0x600177F")]
		[Address(RVA = "0x3E5DCA4", Offset = "0x3E59CA4", VA = "0x3E5DCA4")]
		[AsyncStateMachine(typeof(_003CShowWeeklyCardActivityPanel_003Ed__37))]
		public void ShowWeeklyCardActivityPanel([Optional] string giftPackPlacementFromEntry)
		{
		}

		[Token(Token = "0x6001780")]
		[Address(RVA = "0x3E5DD30", Offset = "0x3E59D30", VA = "0x3E5DD30")]
		public WeeklyCardTrackCustomEventController GetTrackEventController()
		{
			return null;
		}

		[Token(Token = "0x6001781")]
		[Address(RVA = "0x3E5DD38", Offset = "0x3E59D38", VA = "0x3E5DD38")]
		public string GetSkillVideoPath(CycleCardType cycleCardType)
		{
			return null;
		}

		[Token(Token = "0x6001782")]
		[Address(RVA = "0x3E5DD84", Offset = "0x3E59D84", VA = "0x3E5DD84")]
		public List<GlobalIAPInfo> GetGiftPackIapInfo()
		{
			return null;
		}

		[Token(Token = "0x6001783")]
		[Address(RVA = "0x3E5DD9C", Offset = "0x3E59D9C", VA = "0x3E5DD9C")]
		public void ShowGoldCardWeekGiftPackPanel([Optional][DefaultParameterValue(false)] bool fromGameEnd, [Optional] string placement)
		{
		}

		[Token(Token = "0x6001784")]
		[Address(RVA = "0x3E5DDB8", Offset = "0x3E59DB8", VA = "0x3E5DDB8")]
		public bool GetEnemyCardDeckHasCycleCard()
		{
			return default;
		}

		[Token(Token = "0x6001785")]
		[Address(RVA = "0x3E5DE94", Offset = "0x3E59E94", VA = "0x3E5DE94")]
		public bool GetPlayerCardDeckHasCycleCard()
		{
			return default;
		}

		[Token(Token = "0x6001786")]
		[Address(RVA = "0x3E5DF74", Offset = "0x3E59F74", VA = "0x3E5DF74")]
		public bool TryPopupWeeklyCard()
		{
			return default;
		}

		[Token(Token = "0x6001787")]
		[Address(RVA = "0x3E5E1CC", Offset = "0x3E5A1CC", VA = "0x3E5E1CC")]
		public WeeklyCardActivityManager()
		{
		}
	}
}
