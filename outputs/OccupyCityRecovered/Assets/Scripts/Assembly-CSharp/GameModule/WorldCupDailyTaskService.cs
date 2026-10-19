using System;
using System.Collections.Generic;
using DataModule;
using Il2CppDummyDll;
using ljzs_lt;

namespace GameModule
{
	[Token(Token = "0x2000603")]
	internal sealed class WorldCupDailyTaskService
	{
		[Token(Token = "0x4003220")]
		[FieldOffset(Offset = "0x10")]
		private readonly WorldCupActivityState _state;

		[Token(Token = "0x4003221")]
		[FieldOffset(Offset = "0x18")]
		private readonly Action _refreshAll;

		[Token(Token = "0x4003222")]
		[FieldOffset(Offset = "0x20")]
		private bool _eventListenersRegistered;

		[Token(Token = "0x6001FF3")]
		[Address(RVA = "0x3F0BC0C", Offset = "0x3F07C0C", VA = "0x3F0BC0C")]
		public WorldCupDailyTaskService(WorldCupActivityState state, Action refreshAll)
		{
		}

		[Token(Token = "0x6001FF4")]
		[Address(RVA = "0x3F0BC38", Offset = "0x3F07C38", VA = "0x3F0BC38")]
		public void RegisterEventListeners()
		{
		}

		[Token(Token = "0x6001FF5")]
		[Address(RVA = "0x3F0BE34", Offset = "0x3F07E34", VA = "0x3F0BE34")]
		public void UnregisterEventListeners()
		{
		}

		[Token(Token = "0x6001FF6")]
		[Address(RVA = "0x3F0C02C", Offset = "0x3F0802C", VA = "0x3F0C02C")]
		public WorldCupDailyTaskRecord GetRecord(int configId)
		{
			return null;
		}

		[Token(Token = "0x6001FF7")]
		[Address(RVA = "0x3F0C054", Offset = "0x3F08054", VA = "0x3F0C054")]
		public IReadOnlyList<WorldCupDailyTaskRecord> GetRecords()
		{
			return null;
		}

		[Token(Token = "0x6001FF8")]
		[Address(RVA = "0x3F0C11C", Offset = "0x3F0811C", VA = "0x3F0C11C")]
		public bool HasClaimableReward()
		{
			return default;
		}

		[Token(Token = "0x6001FF9")]
		[Address(RVA = "0x3F0C2A4", Offset = "0x3F082A4", VA = "0x3F0C2A4")]
		public bool TryClaimReward(int configId, out string errorMessage)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED WorldCupDailyTaskService.TryClaimReward RVA=0x3F0C2A4 Token=0x6001FF9");
}

		[Token(Token = "0x6001FFA")]
		[Address(RVA = "0x3F0C524", Offset = "0x3F08524", VA = "0x3F0C524")]
		public void RecordFootballCost(int count)
		{
		}

		[Token(Token = "0x6001FFB")]
		[Address(RVA = "0x3F0C570", Offset = "0x3F08570", VA = "0x3F0C570")]
		public void GmReset()
		{
		}

		[Token(Token = "0x6001FFC")]
		[Address(RVA = "0x3F0C5B8", Offset = "0x3F085B8", VA = "0x3F0C5B8")]
		public void GmComplete(int configId)
		{
		}

		[Token(Token = "0x6001FFD")]
		[Address(RVA = "0x3F0C608", Offset = "0x3F08608", VA = "0x3F0C608")]
		public void GmAddProgress(int taskType, int delta, int normalParam = 0)
		{
		}

		[Token(Token = "0x6001FFE")]
		[Address(RVA = "0x3F0C080", Offset = "0x3F08080", VA = "0x3F0C080")]
		public void EnsureData()
		{
		}

		[Token(Token = "0x6001FFF")]
		[Address(RVA = "0x3F0C60C", Offset = "0x3F0860C", VA = "0x3F0C60C")]
		public void ResetForToday()
		{
		}

		[Token(Token = "0x6002000")]
		[Address(RVA = "0x3F0D054", Offset = "0x3F09054", VA = "0x3F0D054")]
		private void RecordDailyTaskItemCost(int itemId, int count)
		{
		}

		[Token(Token = "0x6002001")]
		[Address(RVA = "0x3F0D060", Offset = "0x3F09060", VA = "0x3F0D060")]
		private void RecordDailyTaskItemCost(string itemId, int count)
		{
		}

		[Token(Token = "0x6002002")]
		[Address(RVA = "0x3F0D0AC", Offset = "0x3F090AC", VA = "0x3F0D0AC")]
		private void RecordDailyTaskBattleEnter(int count = 1)
		{
		}

		[Token(Token = "0x6002003")]
		[Address(RVA = "0x3F0D0BC", Offset = "0x3F090BC", VA = "0x3F0D0BC")]
		private void RecordDailyTaskBattleWin(int count = 1)
		{
		}

		[Token(Token = "0x6002004")]
		[Address(RVA = "0x3F0CA94", Offset = "0x3F08A94", VA = "0x3F0CA94")]
		private void RecordProgress(WorldCupDailyTaskType taskType, int delta, int normalParam = 0)
		{
		}

		[Token(Token = "0x6002005")]
		[Address(RVA = "0x3F0C968", Offset = "0x3F08968", VA = "0x3F0C968")]
		private static bool IsTaskClaimable(WorldCupdailyTaskConfig config, WorldCupDailyTaskRecord record)
		{
			return default;
		}

		[Token(Token = "0x6002006")]
		[Address(RVA = "0x3F0D0CC", Offset = "0x3F090CC", VA = "0x3F0D0CC")]
		private static bool IsTaskMatched(WorldCupdailyTaskConfig config, WorldCupDailyTaskType taskType, int normalParam)
		{
			return default;
		}

		[Token(Token = "0x6002007")]
		[Address(RVA = "0x3F0D114", Offset = "0x3F09114", VA = "0x3F0D114")]
		private void OnDailyTaskBattleEnter(object _)
		{
		}

		[Token(Token = "0x6002008")]
		[Address(RVA = "0x3F0D124", Offset = "0x3F09124", VA = "0x3F0D124")]
		private void OnDailyTaskBattleWin(object _)
		{
		}

		[Token(Token = "0x6002009")]
		[Address(RVA = "0x3F0D134", Offset = "0x3F09134", VA = "0x3F0D134")]
		private void OnDailyTaskItemCost(object arg)
		{
		}

		[Token(Token = "0x600200A")]
		[Address(RVA = "0x3F0CCDC", Offset = "0x3F08CDC", VA = "0x3F0CCDC")]
		private void SyncRecordsWithConfig()
		{
		}

		[Token(Token = "0x600200B")]
		[Address(RVA = "0x3F0C9A4", Offset = "0x3F089A4", VA = "0x3F0C9A4")]
		private void SaveData()
		{
		}

		[Token(Token = "0x600200C")]
		[Address(RVA = "0x3F0C894", Offset = "0x3F08894", VA = "0x3F0C894")]
		private WorldCupDailyTaskRecord FindRecord(int configId)
		{
			return null;
		}

		[Token(Token = "0x600200D")]
		[Address(RVA = "0x3F0CA78", Offset = "0x3F08A78", VA = "0x3F0CA78")]
		private void NotifyRefresh()
		{
		}

		[Token(Token = "0x600200E")]
		[Address(RVA = "0x3F0D1EC", Offset = "0x3F091EC", VA = "0x3F0D1EC")]
		private static bool TryGetInt(object value, out int result)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED WorldCupDailyTaskService.TryGetInt RVA=0x3F0D1EC Token=0x600200E");
}
	}
}
