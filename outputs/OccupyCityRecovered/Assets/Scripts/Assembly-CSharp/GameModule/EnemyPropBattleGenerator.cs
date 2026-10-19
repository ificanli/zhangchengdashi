using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using ljzs_lt;

namespace GameModule
{
	[Token(Token = "0x20002FA")]
	public static class EnemyPropBattleGenerator
	{
		[Token(Token = "0x20002FB")]
		private struct AIPropInfoRow
		{
			[Token(Token = "0x40022E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int arnenaLevel;

			[Token(Token = "0x40022E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int[] AIPropUpgrade1;

			[Token(Token = "0x40022E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int[] AIPropUpgrade2;

			[Token(Token = "0x40022E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int[] AIPropUpgrade3;

			[Token(Token = "0x40022E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int[] AIPropUpgrade4;

			[Token(Token = "0x40022E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int[] AIPropRank1;

			[Token(Token = "0x40022E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int[] AIPropRank2;

			[Token(Token = "0x40022EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public int[] AIPropRank3;

			[Token(Token = "0x40022EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public int[] AIPropRank4;

			[Token(Token = "0x40022EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public int[] AIPropNum1;

			[Token(Token = "0x40022ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public int[] AIPropNum2;

			[Token(Token = "0x40022EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public int[] AIPropNum3;

			[Token(Token = "0x40022EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public int[] AIPropNum4;
		}

		[Token(Token = "0x40022E1")]
		private const string LogTag = "[敌方神器]";

		[Token(Token = "0x40022E2")]
		private const string HighRankAIDifficultyOnlineParamKey = "HighRankAIDifficulty";

		[Token(Token = "0x6000D3E")]
		[Address(RVA = "0x3D5877C", Offset = "0x3D5477C", VA = "0x3D5877C")]
		public static int ResolveArenaLevel()
		{
			return default;
		}

		[Token(Token = "0x6000D3F")]
		[Address(RVA = "0x3D5896C", Offset = "0x3D5496C", VA = "0x3D5896C")]
		public static List<EnemyPropBattleEntry> BuildEnemyPropDataList(int arenaLevel, GameType gameType, [Optional] EnemyPropBuildContext context)
		{
			return null;
		}

		[Token(Token = "0x6000D40")]
		[Address(RVA = "0x3D59F14", Offset = "0x3D55F14", VA = "0x3D59F14")]
		public static PropAttrSnapshot BuildPropAttrSnapshot(IReadOnlyList<EnemyPropBattleEntry> list)
		{
			return null;
		}

		[Token(Token = "0x6000D41")]
		[Address(RVA = "0x3D5A738", Offset = "0x3D56738", VA = "0x3D5A738")]
		public static string PickEquippedPropId(IReadOnlyList<EnemyPropBattleEntry> list, int propRareNum)
		{
			return null;
		}

		[Token(Token = "0x6000D42")]
		[Address(RVA = "0x3D5AEB0", Offset = "0x3D56EB0", VA = "0x3D5AEB0")]
		public static void EnsureEquipInList(List<EnemyPropBattleEntry> list, string equipId, int arenaLevel)
		{
		}

		[Token(Token = "0x6000D43")]
		[Address(RVA = "0x3D5AFF0", Offset = "0x3D56FF0", VA = "0x3D5AFF0")]
		public static void LogGenerateSummary(int arenaLevel, int difficultLevel, GameType gameType, string enemyArtifactCofig, int propRareNum, IReadOnlyList<EnemyPropBattleEntry> list, string equipId, PropAttrSnapshot snapshot)
		{
		}

		[Token(Token = "0x6000D44")]
		[Address(RVA = "0x3D58F68", Offset = "0x3D54F68", VA = "0x3D58F68")]
		private static EnemyPropBattleEntry CreateEntry(string propId, int arenaLevel, [Optional] RareLevel? rareOverride, bool forceUnlockedLevel = false)
		{
			return null;
		}

		[Token(Token = "0x6000D45")]
		[Address(RVA = "0x3D5BBB8", Offset = "0x3D57BB8", VA = "0x3D5BBB8")]
		private static void RandomLevelAndStar(string propId, RareLevel rare, int arenaLevel, bool requirePositiveLevel, out int level, out int startLevel)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED EnemyPropBattleGenerator.RandomLevelAndStar RVA=0x3D5BBB8 Token=0x6000D45");
}

		[Token(Token = "0x6000D46")]
		[Address(RVA = "0x3D5BF34", Offset = "0x3D57F34", VA = "0x3D5BF34")]
		private static int GetMaxLevelAllowedByStar(int startLevel)
		{
			return default;
		}

		[Token(Token = "0x6000D47")]
		[Address(RVA = "0x3D5BF74", Offset = "0x3D57F74", VA = "0x3D5BF74")]
		private static int GetLevelNeedRank(int level)
		{
			return default;
		}

		[Token(Token = "0x6000D48")]
		[Address(RVA = "0x3D5BEF0", Offset = "0x3D57EF0", VA = "0x3D5BEF0")]
		private static void GetClosedIntervalBounds(int[] interval, out int min, out int max)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED EnemyPropBattleGenerator.GetClosedIntervalBounds RVA=0x3D5BEF0 Token=0x6000D48");
}

		[Token(Token = "0x6000D49")]
		[Address(RVA = "0x3D5BA84", Offset = "0x3D57A84", VA = "0x3D5BA84")]
		private static int GetHighRankAIDifficultyTableGroup()
		{
			return default;
		}

		[Token(Token = "0x6000D4A")]
		[Address(RVA = "0x3D5BDDC", Offset = "0x3D57DDC", VA = "0x3D5BDDC")]
		private static string GetHighRankAIDifficultyTableName()
		{
			return null;
		}

		[Token(Token = "0x6000D4B")]
		[Address(RVA = "0x3D5C028", Offset = "0x3D58028", VA = "0x3D5C028")]
		private static AIPropInfoRow MapFromConfig(AIPropInfoConfig cfg)
		{
			return default;
		}

		[Token(Token = "0x6000D4C")]
		[Address(RVA = "0x3D5C074", Offset = "0x3D58074", VA = "0x3D5C074")]
		private static AIPropInfoRow MapFromConfig(AIPropInfoBConfig cfg)
		{
			return default;
		}

		[Token(Token = "0x6000D4D")]
		[Address(RVA = "0x3D5C0C0", Offset = "0x3D580C0", VA = "0x3D5C0C0")]
		private static AIPropInfoRow MapFromConfig(AIPropInfoCConfig cfg)
		{
			return default;
		}

		[Token(Token = "0x6000D4E")]
		[Address(RVA = "0x3D59074", Offset = "0x3D55074", VA = "0x3D59074")]
		private static AIPropInfoRow? ResolveAIPropConfig(int arenaLevel)
		{
			return null;
		}

		[Token(Token = "0x6000D4F")]
		private static AIPropInfoRow? ResolveAIPropRowFromDic<T>(Dictionary<object, T> dic, int arenaLevel, string tableName, Func<T, AIPropInfoRow> map)
		{
			return null;
		}

		[Token(Token = "0x6000D50")]
		[Address(RVA = "0x3D5BE60", Offset = "0x3D57E60", VA = "0x3D5BE60")]
		private static int[] GetUpgradeInterval(AIPropInfoRow cfg, int rareIndex)
		{
			return null;
		}

		[Token(Token = "0x6000D51")]
		[Address(RVA = "0x3D5BEA8", Offset = "0x3D57EA8", VA = "0x3D5BEA8")]
		private static int[] GetRankInterval(AIPropInfoRow cfg, int rareIndex)
		{
			return null;
		}

		[Token(Token = "0x6000D52")]
		[Address(RVA = "0x3D59384", Offset = "0x3D55384", VA = "0x3D59384")]
		private static int[] GetNumInterval(AIPropInfoRow cfg, int rareIndex)
		{
			return null;
		}

		[Token(Token = "0x6000D53")]
		[Address(RVA = "0x3D59404", Offset = "0x3D55404", VA = "0x3D59404")]
		private static List<string> PickGreenTierIds(string[] pool, int unlockCount, HashSet<string> selectedIds)
		{
			return null;
		}

		[Token(Token = "0x6000D54")]
		[Address(RVA = "0x3D59658", Offset = "0x3D55658", VA = "0x3D59658")]
		private static List<string> PickRandomPropIds(string[] pool, int count, HashSet<string> selectedIds)
		{
			return null;
		}

		[Token(Token = "0x6000D55")]
		[Address(RVA = "0x3D5990C", Offset = "0x3D5590C", VA = "0x3D5990C")]
		private static void EnsureChongFengHaoJiaoInList(List<EnemyPropBattleEntry> list, int arenaLevel, HashSet<string> selectedIds)
		{
		}

		[Token(Token = "0x6000D56")]
		[Address(RVA = "0x3D59B1C", Offset = "0x3D55B1C", VA = "0x3D59B1C")]
		private static void EnsureLegendaryUnlockedInList(List<EnemyPropBattleEntry> list, int arenaLevel, HashSet<string> selectedIds, EnemyPropBuildContext context)
		{
		}

		[Token(Token = "0x6000D57")]
		[Address(RVA = "0x3D593CC", Offset = "0x3D553CC", VA = "0x3D593CC")]
		private static int RandomInClosedInterval(int[] interval)
		{
			return default;
		}

		[Token(Token = "0x6000D58")]
		[Address(RVA = "0x3D5A9A0", Offset = "0x3D569A0", VA = "0x3D5A9A0")]
		private static List<EnemyPropBattleEntry> FilterEquipCandidates(IReadOnlyList<EnemyPropBattleEntry> list, int propRareNum)
		{
			return null;
		}

		[Token(Token = "0x6000D59")]
		[Address(RVA = "0x3D5AC64", Offset = "0x3D56C64", VA = "0x3D5AC64")]
		private static List<EnemyPropBattleEntry> FilterUnlockedEntries(IReadOnlyList<EnemyPropBattleEntry> list)
		{
			return null;
		}

		[Token(Token = "0x6000D5A")]
		[Address(RVA = "0x3D5ABB0", Offset = "0x3D56BB0", VA = "0x3D5ABB0")]
		private static int GetPropRareLevel(string propId)
		{
			return default;
		}
	}
}
