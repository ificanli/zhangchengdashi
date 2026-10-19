using System;
using System.Collections.Generic;
using System.Text;
using DataModule;
using Il2CppDummyDll;
using ljzs_lt;

namespace GameModule
{
	[Token(Token = "0x2000508")]
	public static class MysteryAdventureConfigService
	{
		[Token(Token = "0x4002D67")]
		[FieldOffset(Offset = "0x0")]
		private static List<TotalDiceConfig> _cachedTotalDiceConfigs;

		[Token(Token = "0x4002D68")]
		[FieldOffset(Offset = "0x8")]
		private static List<LapsConfigConfig> _cachedLapsConfigs;

		[Token(Token = "0x4002D69")]
		[FieldOffset(Offset = "0x10")]
		private static List<DailyTaskConfig> _cachedDailyTaskConfigs;

		[Token(Token = "0x4002D6A")]
		[FieldOffset(Offset = "0x18")]
		private static List<DailyPriceConfig> _cachedDailyGiftConfigs;

		[Token(Token = "0x4002D6B")]
		[FieldOffset(Offset = "0x20")]
		private static List<RuinsConfigConfig> _cachedRuinsConfigs;

		[Token(Token = "0x4002D6C")]
		[FieldOffset(Offset = "0x28")]
		private static List<SaleShopConfig> _cachedSaleShopConfigs;

		[Token(Token = "0x4002D6D")]
		private const int PoolRandomCardItemType = 5;

		[Token(Token = "0x4002D6E")]
		private const int PoolRandomCardConfigIdOffset = 45000;

		[Token(Token = "0x600195D")]
		[Address(RVA = "0x3E92B00", Offset = "0x3E8EB00", VA = "0x3E92B00")]
		public static BaseConfigConfig GetBaseConfig()
		{
			return null;
		}

		[Token(Token = "0x600195E")]
		[Address(RVA = "0x3E92B1C", Offset = "0x3E8EB1C", VA = "0x3E92B1C")]
		public static int GetActivityConfigId()
		{
			return default;
		}

		[Token(Token = "0x600195F")]
		[Address(RVA = "0x3E92B48", Offset = "0x3E8EB48", VA = "0x3E92B48")]
		public static int GetActivityDurationDays()
		{
			return default;
		}

		[Token(Token = "0x6001960")]
		[Address(RVA = "0x3E92B80", Offset = "0x3E8EB80", VA = "0x3E92B80")]
		public static int GetMinDiceFace()
		{
			return default;
		}

		[Token(Token = "0x6001961")]
		[Address(RVA = "0x3E92BB4", Offset = "0x3E8EBB4", VA = "0x3E92BB4")]
		public static int GetMaxDiceFace()
		{
			return default;
		}

		[Token(Token = "0x6001962")]
		[Address(RVA = "0x3E92BEC", Offset = "0x3E8EBEC", VA = "0x3E92BEC")]
		public static int GetNaturalDiceCap()
		{
			return default;
		}

		[Token(Token = "0x6001963")]
		[Address(RVA = "0x3E92C24", Offset = "0x3E8EC24", VA = "0x3E92C24")]
		public static TimeSpan GetDiceRecoverInterval()
		{
			return default;
		}

		[Token(Token = "0x6001964")]
		[Address(RVA = "0x3E92CA8", Offset = "0x3E8ECA8", VA = "0x3E92CA8")]
		public static int GetInitialDiceCount()
		{
			return default;
		}

		[Token(Token = "0x6001965")]
		[Address(RVA = "0x3E92CE0", Offset = "0x3E8ECE0", VA = "0x3E92CE0")]
		public static int RollDiceFace()
		{
			return default;
		}

		[Token(Token = "0x6001966")]
		[Address(RVA = "0x3E93064", Offset = "0x3E8F064", VA = "0x3E93064")]
		public static IReadOnlyList<TotalDiceConfig> GetTotalDiceConfigs()
		{
			return null;
		}

		[Token(Token = "0x6001967")]
		[Address(RVA = "0x3E933C8", Offset = "0x3E8F3C8", VA = "0x3E933C8")]
		public static string FormatTotalDiceReward(TotalDiceConfig config)
		{
			return null;
		}

		[Token(Token = "0x6001968")]
		[Address(RVA = "0x3E93488", Offset = "0x3E8F488", VA = "0x3E93488")]
		public static IReadOnlyList<DailyTaskConfig> GetDailyTaskConfigs()
		{
			return null;
		}

		[Token(Token = "0x6001969")]
		[Address(RVA = "0x3E93750", Offset = "0x3E8F750", VA = "0x3E93750")]
		public static DailyTaskConfig GetDailyTaskConfig(int configId)
		{
			return null;
		}

		[Token(Token = "0x600196A")]
		[Address(RVA = "0x3E93900", Offset = "0x3E8F900", VA = "0x3E93900")]
		public static int GetDailyTaskTargetProgress(DailyTaskConfig config)
		{
			return default;
		}

		[Token(Token = "0x600196B")]
		[Address(RVA = "0x3E9391C", Offset = "0x3E8F91C", VA = "0x3E9391C")]
		public static string FormatDailyTaskReward(DailyTaskConfig config)
		{
			return null;
		}

		[Token(Token = "0x600196C")]
		[Address(RVA = "0x3E939DC", Offset = "0x3E8F9DC", VA = "0x3E939DC")]
		public static IReadOnlyList<DailyPriceConfig> GetDailyGiftConfigs()
		{
			return null;
		}

		[Token(Token = "0x600196D")]
		[Address(RVA = "0x3E93CA4", Offset = "0x3E8FCA4", VA = "0x3E93CA4")]
		public static DailyPriceConfig GetDailyGiftConfig(int configId)
		{
			return null;
		}

		[Token(Token = "0x600196E")]
		[Address(RVA = "0x3E93E54", Offset = "0x3E8FE54", VA = "0x3E93E54")]
		public static IReadOnlyList<RuinsConfigConfig> GetRuinsConfigs()
		{
			return null;
		}

		[Token(Token = "0x600196F")]
		[Address(RVA = "0x3E9411C", Offset = "0x3E9011C", VA = "0x3E9411C")]
		public static RuinsConfigConfig GetRuinsConfig(int configId)
		{
			return null;
		}

		[Token(Token = "0x6001970")]
		[Address(RVA = "0x3E942CC", Offset = "0x3E902CC", VA = "0x3E942CC")]
		public static RuinsConfigConfig RollRuinsEvent()
		{
			return null;
		}

		[Token(Token = "0x6001971")]
		[Address(RVA = "0x3E94714", Offset = "0x3E90714", VA = "0x3E94714")]
		public static string FormatRuinsReward(RuinsConfigConfig config, int rewardIndex)
		{
			return null;
		}

		[Token(Token = "0x6001972")]
		[Address(RVA = "0x3E948E4", Offset = "0x3E908E4", VA = "0x3E948E4")]
		public static string FormatRuinsRpsReward(RuinsConfigConfig config, int choiceIndex, MysteryAdventureRpsOutcome outcome)
		{
			return null;
		}

		[Token(Token = "0x6001973")]
		[Address(RVA = "0x3E94AF8", Offset = "0x3E90AF8", VA = "0x3E94AF8")]
		public static string FormatRuinsBanditBattleReward(RuinsConfigConfig config, MysteryAdventureRpsOutcome outcome)
		{
			return null;
		}

		[Token(Token = "0x6001974")]
		[Address(RVA = "0x3E94B04", Offset = "0x3E90B04", VA = "0x3E94B04")]
		public static string FormatRuinsBanditBattleReward(string baseRewardRaw, MysteryAdventureRpsOutcome outcome)
		{
			return null;
		}

		[Token(Token = "0x6001975")]
		[Address(RVA = "0x3E9491C", Offset = "0x3E9091C", VA = "0x3E9491C")]
		private static string FormatRuinsRewardWithOutcomeMultiplier(string rewardRaw, MysteryAdventureRpsOutcome outcome)
		{
			return null;
		}

		[Token(Token = "0x6001976")]
		[Address(RVA = "0x3E94748", Offset = "0x3E90748", VA = "0x3E94748")]
		public static string FormatRuinsRewardRaw(string rewardRaw)
		{
			return null;
		}

		[Token(Token = "0x6001977")]
		[Address(RVA = "0x3E94BB4", Offset = "0x3E90BB4", VA = "0x3E94BB4")]
		public static string FormatDailyGiftReward(DailyPriceConfig config)
		{
			return null;
		}

		[Token(Token = "0x6001978")]
		[Address(RVA = "0x3E94C74", Offset = "0x3E90C74", VA = "0x3E94C74")]
		public static string FormatDailyGiftRewardItem(int itemType, int itemId, int count)
		{
			return null;
		}

		[Token(Token = "0x6001979")]
		[Address(RVA = "0x3E94D38", Offset = "0x3E90D38", VA = "0x3E94D38")]
		public static PurchaseConfig GetDailyGiftPurchaseConfig(DailyPriceConfig config)
		{
			return null;
		}

		[Token(Token = "0x600197A")]
		[Address(RVA = "0x3E94F04", Offset = "0x3E90F04", VA = "0x3E94F04")]
		public static IReadOnlyList<SaleShopConfig> GetSaleShopConfigs()
		{
			return null;
		}

		[Token(Token = "0x600197B")]
		[Address(RVA = "0x3E951CC", Offset = "0x3E911CC", VA = "0x3E951CC")]
		public static SaleShopConfig GetSaleShopConfig(int configId)
		{
			return null;
		}

		[Token(Token = "0x600197C")]
		[Address(RVA = "0x3E9537C", Offset = "0x3E9137C", VA = "0x3E9537C")]
		public static string FormatSaleShopReward(SaleShopConfig config)
		{
			return null;
		}

		[Token(Token = "0x600197D")]
		[Address(RVA = "0x3E95394", Offset = "0x3E91394", VA = "0x3E95394")]
		public static List<int> RollSaleShopItemIds(int count = 4)
		{
			return null;
		}

		[Token(Token = "0x600197E")]
		[Address(RVA = "0x3E95684", Offset = "0x3E91684", VA = "0x3E95684")]
		public static IReadOnlyList<LapsConfigConfig> GetLapsConfigs()
		{
			return null;
		}

		[Token(Token = "0x600197F")]
		[Address(RVA = "0x3E95938", Offset = "0x3E91938", VA = "0x3E95938")]
		public static LapsConfigConfig GetLapsConfigByLevel(int level)
		{
			return null;
		}

		[Token(Token = "0x6001980")]
		[Address(RVA = "0x3E95AF0", Offset = "0x3E91AF0", VA = "0x3E95AF0")]
		public static LapsConfigConfig GetLapsConfigForLapCount(int lapCount)
		{
			return null;
		}

		[Token(Token = "0x6001981")]
		[Address(RVA = "0x3E95C8C", Offset = "0x3E91C8C", VA = "0x3E95C8C")]
		public static int GetLapLevelFromExp(int lapExp)
		{
			return default;
		}

		[Token(Token = "0x6001982")]
		[Address(RVA = "0x3E95F28", Offset = "0x3E91F28", VA = "0x3E95F28")]
		public static MysteryAdventureLapsProgressInfo GetLapsProgressInfo(int lapExp)
		{
			return default;
		}

		[Token(Token = "0x6001983")]
		[Address(RVA = "0x3E9622C", Offset = "0x3E9222C", VA = "0x3E9622C")]
		public static string BuildLapCompleteReward(int lapCountBeforeComplete)
		{
			return null;
		}

		[Token(Token = "0x6001984")]
		[Address(RVA = "0x3E963F0", Offset = "0x3E923F0", VA = "0x3E963F0")]
		public static int GetLapCompleteRewardCount(int lapCountBeforeComplete)
		{
			return default;
		}

		[Token(Token = "0x6001985")]
		[Address(RVA = "0x3E96418", Offset = "0x3E92418", VA = "0x3E96418")]
		public static string FormatLapHeroFragmentRewardCountText(int count)
		{
			return null;
		}

		[Token(Token = "0x6001986")]
		[Address(RVA = "0x3E964BC", Offset = "0x3E924BC", VA = "0x3E964BC")]
		public static int GetRewardTotalCount(string rewardRaw)
		{
			return default;
		}

		[Token(Token = "0x6001987")]
		[Address(RVA = "0x3E965C4", Offset = "0x3E925C4", VA = "0x3E965C4")]
		public static int ResolveLapRewardDisplayCount(string rewardRaw, int fallbackCount)
		{
			return default;
		}

		[Token(Token = "0x6001988")]
		[Address(RVA = "0x3E965E4", Offset = "0x3E925E4", VA = "0x3E965E4")]
		public static string FormatResourcesUpRange(int prevPercent, int newPercent)
		{
			return null;
		}

		[Token(Token = "0x6001989")]
		[Address(RVA = "0x3E966DC", Offset = "0x3E926DC", VA = "0x3E966DC")]
		public static bool TryBuildLevelUpPopupInfo(int lapExpBeforeIncrement, int lapExpAfterIncrement, PlayerMysteryAdventureData data, out MysteryAdventureLapLevelUpPopupInfo info)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MysteryAdventureConfigService.TryBuildLevelUpPopupInfo RVA=0x3E966DC Token=0x6001989");
}

		[Token(Token = "0x600198A")]
		[Address(RVA = "0x3E96808", Offset = "0x3E92808", VA = "0x3E96808")]
		public static string ApplyResourcesUpToReward(string rewardRaw, int resourcesUpPercent)
		{
			return null;
		}

		[Token(Token = "0x600198B")]
		[Address(RVA = "0x3E96B5C", Offset = "0x3E92B5C", VA = "0x3E96B5C")]
		private static void AppendRewardSegment(StringBuilder sb, string segment)
		{
		}

		[Token(Token = "0x600198C")]
		[Address(RVA = "0x3E96BCC", Offset = "0x3E92BCC", VA = "0x3E96BCC")]
		public static string ApplyRewardCountMultiplier(string rewardRaw, int multiplier)
		{
			return null;
		}

		[Token(Token = "0x600198D")]
		[Address(RVA = "0x3E96330", Offset = "0x3E92330", VA = "0x3E96330")]
		public static string FormatLapsReward(LapsConfigConfig config)
		{
			return null;
		}

		[Token(Token = "0x600198E")]
		[Address(RVA = "0x3E96E08", Offset = "0x3E92E08", VA = "0x3E96E08")]
		public static IReadOnlyList<MysteryAdventureCellConfig> BuildCells()
		{
			return null;
		}

		[Token(Token = "0x600198F")]
		[Address(RVA = "0x3E971AC", Offset = "0x3E931AC", VA = "0x3E971AC")]
		public static List<int> GetCellIdsByBuildId(int buildId)
		{
			return null;
		}

		[Token(Token = "0x6001990")]
		[Address(RVA = "0x3E97438", Offset = "0x3E93438", VA = "0x3E97438")]
		public static int GetBuildIdByCellId(int cellId)
		{
			return default;
		}

		[Token(Token = "0x6001991")]
		[Address(RVA = "0x3E974F4", Offset = "0x3E934F4", VA = "0x3E974F4")]
		public static bool IsForcedMoveBoardCell(int cellId)
		{
			return default;
		}

		[Token(Token = "0x6001992")]
		[Address(RVA = "0x3E97510", Offset = "0x3E93510", VA = "0x3E97510")]
		public static bool IsSupportedStopBuild(int buildId)
		{
			return default;
		}

		[Token(Token = "0x6001993")]
		[Address(RVA = "0x3E97520", Offset = "0x3E93520", VA = "0x3E97520")]
		public static string RollBuildPoolReward(int buildId)
		{
			return null;
		}

		[Token(Token = "0x6001994")]
		[Address(RVA = "0x3E97648", Offset = "0x3E93648", VA = "0x3E97648")]
		public static string RollPoolReward(int poolId)
		{
			return null;
		}

		[Token(Token = "0x6001995")]
		[Address(RVA = "0x3E97A8C", Offset = "0x3E93A8C", VA = "0x3E97A8C")]
		public static string RollRuinsRandomRewardRaw()
		{
			return null;
		}

		[Token(Token = "0x6001996")]
		[Address(RVA = "0x3E97664", Offset = "0x3E93664", VA = "0x3E97664")]
		public static PoolConfigConfig RollPoolEntry(int poolId)
		{
			return null;
		}

		[Token(Token = "0x6001997")]
		[Address(RVA = "0x3E97B94", Offset = "0x3E93B94", VA = "0x3E97B94")]
		public static MysteryAdventureCellType MapBuildIdToCellType(int buildId)
		{
			return default;
		}

		[Token(Token = "0x6001998")]
		[Address(RVA = "0x3E96F18", Offset = "0x3E92F18", VA = "0x3E96F18")]
		private static MysteryAdventureCellConfig BuildCellConfig(ConfigMgr mgr, int cellId)
		{
			return null;
		}

		[Token(Token = "0x6001999")]
		[Address(RVA = "0x3E97BA8", Offset = "0x3E93BA8", VA = "0x3E97BA8")]
		private static MysteryAdventureCellConfig BuildFallbackCell(int cellId, int buildId = 0)
		{
			return null;
		}

		[Token(Token = "0x600199A")]
		[Address(RVA = "0x3E97AAC", Offset = "0x3E93AAC", VA = "0x3E97AAC")]
		private static string FormatPoolEntryAsRuinsRaw(PoolConfigConfig entry)
		{
			return null;
		}

		[Token(Token = "0x600199B")]
		[Address(RVA = "0x3E979DC", Offset = "0x3E939DC", VA = "0x3E979DC")]
		private static string FormatPoolEntryReward(PoolConfigConfig entry)
		{
			return null;
		}

		[Token(Token = "0x600199C")]
		[Address(RVA = "0x3E97C24", Offset = "0x3E93C24", VA = "0x3E97C24")]
		private static string ResolvePoolRewardAssetId(int itemType, int itemId)
		{
			return null;
		}

		[Token(Token = "0x600199D")]
		[Address(RVA = "0x3E94B08", Offset = "0x3E90B08", VA = "0x3E94B08")]
		private static void AppendRewardItem(StringBuilder sb, int itemType, int itemId, int count)
		{
		}
	}
}
