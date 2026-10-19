using System;
using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;
using ljzs_lt;

namespace GameModule
{
	[Token(Token = "0x20005EB")]
	public static class WorldCupConfigService
	{
		[Token(Token = "0x40031A3")]
		[FieldOffset(Offset = "0x0")]
		private static IReadOnlyList<WorldCupdailyTaskConfig> _dailyTasks;

		[Token(Token = "0x40031A4")]
		[FieldOffset(Offset = "0x8")]
		private static Dictionary<int, WorldCupdailyTaskConfig> _dailyTaskById;

		[Token(Token = "0x40031A5")]
		[FieldOffset(Offset = "0x10")]
		private static IReadOnlyList<WorldCupdailyPriceConfig> _dailyPacks;

		[Token(Token = "0x40031A6")]
		[FieldOffset(Offset = "0x18")]
		private static Dictionary<int, WorldCupdailyPriceConfig> _dailyPackById;

		[Token(Token = "0x40031A7")]
		[FieldOffset(Offset = "0x20")]
		private static IReadOnlyList<GoalRewardConfig> _goalRewards;

		[Token(Token = "0x40031A8")]
		[FieldOffset(Offset = "0x28")]
		private static IReadOnlyList<PointShopConfig> _pointShopGoods;

		[Token(Token = "0x40031A9")]
		[FieldOffset(Offset = "0x30")]
		private static Dictionary<int, PointShopConfig> _pointShopById;

		[Token(Token = "0x40031AA")]
		private const int PoolRandomCardItemType = 5;

		[Token(Token = "0x40031AB")]
		private const int PoolRandomCardConfigIdOffset = 45000;

		[Token(Token = "0x6001F18")]
		[Address(RVA = "0x3F02C78", Offset = "0x3EFEC78", VA = "0x3F02C78")]
		public static void InvalidateCache()
		{
		}

		[Token(Token = "0x6001F19")]
		[Address(RVA = "0x3F02CD8", Offset = "0x3EFECD8", VA = "0x3F02CD8")]
		public static WorldCupActivityWindow GetActivityWindow(DateTime now)
		{
			return default;
		}

		[Token(Token = "0x6001F1A")]
		[Address(RVA = "0x3F02F18", Offset = "0x3EFEF18", VA = "0x3F02F18")]
		public static WorldCupbaseConfigConfig GetBaseConfig()
		{
			return null;
		}

		[Token(Token = "0x6001F1B")]
		[Address(RVA = "0x3F02F34", Offset = "0x3EFEF34", VA = "0x3F02F34")]
		public static int GetInitFootballCount()
		{
			return default;
		}

		[Token(Token = "0x6001F1C")]
		[Address(RVA = "0x3F02F6C", Offset = "0x3EFEF6C", VA = "0x3F02F6C")]
		public static int GetGoalProbabilityPercent()
		{
			return default;
		}

		[Token(Token = "0x6001F1D")]
		[Address(RVA = "0x3F02FA4", Offset = "0x3EFEFA4", VA = "0x3F02FA4")]
		public static float GetGoalProbability()
		{
			return default;
		}

		[Token(Token = "0x6001F1E")]
		[Address(RVA = "0x3F02FF0", Offset = "0x3EFEFF0", VA = "0x3F02FF0")]
		public static int GetGoalPointsBase()
		{
			return default;
		}

		[Token(Token = "0x6001F1F")]
		[Address(RVA = "0x3F0301C", Offset = "0x3EFF01C", VA = "0x3F0301C")]
		public static int GetUngoalPointsBase()
		{
			return default;
		}

		[Token(Token = "0x6001F20")]
		[Address(RVA = "0x3F03048", Offset = "0x3EFF048", VA = "0x3F03048")]
		public static IReadOnlyList<WorldCupdailyTaskConfig> GetDailyTasks()
		{
			return null;
		}

		[Token(Token = "0x6001F21")]
		[Address(RVA = "0x3F03308", Offset = "0x3EFF308", VA = "0x3F03308")]
		public static IReadOnlyList<WorldCupdailyPriceConfig> GetDailyPacks()
		{
			return null;
		}

		[Token(Token = "0x6001F22")]
		[Address(RVA = "0x3F035C8", Offset = "0x3EFF5C8", VA = "0x3F035C8")]
		public static IReadOnlyList<GoalRewardConfig> GetGoalRewards()
		{
			return null;
		}

		[Token(Token = "0x6001F23")]
		[Address(RVA = "0x3F037CC", Offset = "0x3EFF7CC", VA = "0x3F037CC")]
		public static int CalculateShootScore(bool isGoal, int multiplier)
		{
			return default;
		}

		[Token(Token = "0x6001F24")]
		[Address(RVA = "0x3F03844", Offset = "0x3EFF844", VA = "0x3F03844")]
		public static int ScaleShootRewardCount(int baseCount, int multiplier)
		{
			return default;
		}

		[Token(Token = "0x6001F25")]
		[Address(RVA = "0x3F03858", Offset = "0x3EFF858", VA = "0x3F03858")]
		public static string FormatGoalReward(GoalRewardConfig config, int multiplier)
		{
			return null;
		}

		[Token(Token = "0x6001F26")]
		[Address(RVA = "0x3F03A20", Offset = "0x3EFFA20", VA = "0x3F03A20")]
		public static GoalRewardConfig RollGoalReward()
		{
			return null;
		}

		[Token(Token = "0x6001F27")]
		[Address(RVA = "0x3F0394C", Offset = "0x3EFF94C", VA = "0x3F0394C")]
		public static bool IsFootballItemId(int itemId)
		{
			return default;
		}

		[Token(Token = "0x6001F28")]
		[Address(RVA = "0x3F041A0", Offset = "0x3F001A0", VA = "0x3F041A0")]
		public static bool IsActivityScoreBuyItem(int buyItem)
		{
			return default;
		}

		[Token(Token = "0x6001F29")]
		[Address(RVA = "0x3F041FC", Offset = "0x3F001FC", VA = "0x3F041FC")]
		public static IReadOnlyList<PointShopConfig> GetPointShopGoods()
		{
			return null;
		}

		[Token(Token = "0x6001F2A")]
		[Address(RVA = "0x3F044BC", Offset = "0x3F004BC", VA = "0x3F044BC")]
		public static PointShopConfig GetPointShopConfig(int configId)
		{
			return null;
		}

		[Token(Token = "0x6001F2B")]
		[Address(RVA = "0x3F0454C", Offset = "0x3F0054C", VA = "0x3F0454C")]
		public static int GetPointShopSaleLimit(PointShopConfig config)
		{
			return default;
		}

		[Token(Token = "0x6001F2C")]
		[Address(RVA = "0x3F045BC", Offset = "0x3F005BC", VA = "0x3F045BC")]
		public static string FormatPointShopReward(PointShopConfig config)
		{
			return null;
		}

		[Token(Token = "0x6001F2D")]
		[Address(RVA = "0x3F045D4", Offset = "0x3F005D4", VA = "0x3F045D4")]
		public static WorldCupdailyTaskConfig GetDailyTaskConfig(int configId)
		{
			return null;
		}

		[Token(Token = "0x6001F2E")]
		[Address(RVA = "0x3F04664", Offset = "0x3F00664", VA = "0x3F04664")]
		public static WorldCupdailyPriceConfig GetDailyPackConfig(int configId)
		{
			return null;
		}

		[Token(Token = "0x6001F2F")]
		[Address(RVA = "0x3F046F4", Offset = "0x3F006F4", VA = "0x3F046F4")]
		public static int GetDailyTaskTargetProgress(WorldCupdailyTaskConfig config)
		{
			return default;
		}

		[Token(Token = "0x6001F30")]
		[Address(RVA = "0x3F04710", Offset = "0x3F00710", VA = "0x3F04710")]
		public static string FormatDailyTaskReward(WorldCupdailyTaskConfig config)
		{
			return null;
		}

		[Token(Token = "0x6001F31")]
		[Address(RVA = "0x3F0395C", Offset = "0x3EFF95C", VA = "0x3F0395C")]
		public static string FormatDailyGiftRewardItem(int itemType, int itemId, int count)
		{
			return null;
		}

		[Token(Token = "0x6001F32")]
		[Address(RVA = "0x3F04898", Offset = "0x3F00898", VA = "0x3F04898")]
		private static string ResolvePoolRewardAssetId(int itemType, int itemId)
		{
			return null;
		}

		[Token(Token = "0x6001F33")]
		[Address(RVA = "0x3F047EC", Offset = "0x3F007EC", VA = "0x3F047EC")]
		private static void AppendRewardItem(StringBuilder sb, int itemType, int itemId, int count)
		{
		}

		[Token(Token = "0x6001F34")]
		[Address(RVA = "0x3F048E8", Offset = "0x3F008E8", VA = "0x3F048E8")]
		public static string GetHow2PlayDescription()
		{
			return null;
		}
	}
}
