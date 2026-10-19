using System;
using System.Collections.Generic;
using DataModule;
using Il2CppDummyDll;
using ljzs_lt;

namespace GameModule
{
	[Token(Token = "0x2000602")]
	public class WorldCupDailySideService
	{
		[Token(Token = "0x400321D")]
		[FieldOffset(Offset = "0x10")]
		private readonly WorldCupActivityState _state;

		[Token(Token = "0x400321E")]
		[FieldOffset(Offset = "0x18")]
		private readonly WorldCupDailyTaskService _taskService;

		[Token(Token = "0x400321F")]
		[FieldOffset(Offset = "0x20")]
		private readonly WorldCupDailyGiftService _giftService;

		[Token(Token = "0x6001FDD")]
		[Address(RVA = "0x3F05890", Offset = "0x3F01890", VA = "0x3F05890")]
		public WorldCupDailySideService(WorldCupActivityState state, Action refreshAll)
		{
		}

		[Token(Token = "0x6001FDE")]
		[Address(RVA = "0x3F080D0", Offset = "0x3F040D0", VA = "0x3F080D0")]
		public void RegisterEventListeners()
		{
		}

		[Token(Token = "0x6001FDF")]
		[Address(RVA = "0x3F05ED4", Offset = "0x3F01ED4", VA = "0x3F05ED4")]
		public void UnregisterEventListeners()
		{
		}

		[Token(Token = "0x6001FE0")]
		[Address(RVA = "0x3F0708C", Offset = "0x3F0308C", VA = "0x3F0708C")]
		public WorldCupDailyTaskRecord GetDailyTaskRecord(int configId)
		{
			return null;
		}

		[Token(Token = "0x6001FE1")]
		[Address(RVA = "0x3F070E0", Offset = "0x3F030E0", VA = "0x3F070E0")]
		public IReadOnlyList<WorldCupDailyTaskRecord> GetDailyTaskRecords()
		{
			return null;
		}

		[Token(Token = "0x6001FE2")]
		[Address(RVA = "0x3F07110", Offset = "0x3F03110", VA = "0x3F07110")]
		public string GetDailyRefreshCountdownStr()
		{
			return null;
		}

		[Token(Token = "0x6001FE3")]
		[Address(RVA = "0x3F071C8", Offset = "0x3F031C8", VA = "0x3F071C8")]
		public void EnsureDailyRefreshData()
		{
		}

		[Token(Token = "0x6001FE4")]
		[Address(RVA = "0x3F07210", Offset = "0x3F03210", VA = "0x3F07210")]
		public bool HasClaimableDailyTaskReward()
		{
			return default;
		}

		[Token(Token = "0x6001FE5")]
		[Address(RVA = "0x3F07248", Offset = "0x3F03248", VA = "0x3F07248")]
		public int GetPackDailyBuyCount(int packId)
		{
			return default;
		}

		[Token(Token = "0x6001FE6")]
		[Address(RVA = "0x3F07280", Offset = "0x3F03280", VA = "0x3F07280")]
		public bool HasClaimableDailyGift()
		{
			return default;
		}

		[Token(Token = "0x6001FE7")]
		[Address(RVA = "0x3F072B0", Offset = "0x3F032B0", VA = "0x3F072B0")]
		public bool HasDailySideEntryRedDot()
		{
			return default;
		}

		[Token(Token = "0x6001FE8")]
		[Address(RVA = "0x3F0736C", Offset = "0x3F0336C", VA = "0x3F0736C")]
		public string GetDailyGiftPlacement()
		{
			return null;
		}

		[Token(Token = "0x6001FE9")]
		[Address(RVA = "0x3F073C4", Offset = "0x3F033C4", VA = "0x3F073C4")]
		public int GetPackRemainBuyCount(WorldCupdailyPriceConfig config)
		{
			return default;
		}

		[Token(Token = "0x6001FEA")]
		[Address(RVA = "0x3F07420", Offset = "0x3F03420", VA = "0x3F07420")]
		public bool TryClaimFreeDailyGift(int configId, out string errorMessage)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED WorldCupDailySideService.TryClaimFreeDailyGift RVA=0x3F07420 Token=0x6001FEA");
}

		[Token(Token = "0x6001FEB")]
		[Address(RVA = "0x3F07458", Offset = "0x3F03458", VA = "0x3F07458")]
		public bool TryGrantPurchasedDailyGift(int configId, out string errorMessage)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED WorldCupDailySideService.TryGrantPurchasedDailyGift RVA=0x3F07458 Token=0x6001FEB");
}

		[Token(Token = "0x6001FEC")]
		[Address(RVA = "0x3F07490", Offset = "0x3F03490", VA = "0x3F07490")]
		public bool TryClaimDailyTaskReward(int configId, out string errorMessage)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED WorldCupDailySideService.TryClaimDailyTaskReward RVA=0x3F07490 Token=0x6001FEC");
}

		[Token(Token = "0x6001FED")]
		[Address(RVA = "0x3F06C40", Offset = "0x3F02C40", VA = "0x3F06C40")]
		public void RecordDailyTaskFootballCost(int count)
		{
		}

		[Token(Token = "0x6001FEE")]
		[Address(RVA = "0x3F0C534", Offset = "0x3F08534", VA = "0x3F0C534")]
		public void GmResetDailyTasks()
		{
		}

		[Token(Token = "0x6001FEF")]
		[Address(RVA = "0x3F0C5A0", Offset = "0x3F085A0", VA = "0x3F0C5A0")]
		public void GmCompleteDailyTask(int configId)
		{
		}

		[Token(Token = "0x6001FF0")]
		[Address(RVA = "0x3F0C5F0", Offset = "0x3F085F0", VA = "0x3F0C5F0")]
		public void GmAddDailyTaskProgress(int taskType, int delta, int normalParam = 0)
		{
		}

		[Token(Token = "0x6001FF1")]
		[Address(RVA = "0x3F06130", Offset = "0x3F02130", VA = "0x3F06130")]
		public void RefreshDailyDataAtServerMidnight()
		{
		}

		[Token(Token = "0x6001FF2")]
		[Address(RVA = "0x3F0C87C", Offset = "0x3F0887C", VA = "0x3F0C87C")]
		internal void ResetDailyTasksForToday()
		{
		}
	}
}
