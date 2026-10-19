using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x20005CF")]
	public static class SubGameChaosTrailsRewardBuilder
	{
		[Token(Token = "0x6001E59")]
		[Address(RVA = "0x3EF5EB8", Offset = "0x3EF1EB8", VA = "0x3EF5EB8")]
		private static string ResolveBattleArenaId()
		{
			return null;
		}

		[Token(Token = "0x6001E5A")]
		[Address(RVA = "0x3EF6044", Offset = "0x3EF2044", VA = "0x3EF6044")]
		private static void SyncNowPlayArenaId()
		{
		}

		[Token(Token = "0x6001E5B")]
		[Address(RVA = "0x3EF60A4", Offset = "0x3EF20A4", VA = "0x3EF60A4")]
		public static RewardConfig Build(bool win)
		{
			return null;
		}

		[Token(Token = "0x6001E5C")]
		[Address(RVA = "0x3EF6C1C", Offset = "0x3EF2C1C", VA = "0x3EF6C1C")]
		public static void ApplyChaosTrailsRewardRatio(RewardConfig rewardConfig, bool isVictory)
		{
		}

		[Token(Token = "0x6001E5D")]
		[Address(RVA = "0x3EF6CF0", Offset = "0x3EF2CF0", VA = "0x3EF6CF0")]
		private static void ScaleRewardsByChaosTrailsRatios(RewardConfig rewardConfig)
		{
		}

		[Token(Token = "0x6001E5E")]
		[Address(RVA = "0x3EF724C", Offset = "0x3EF324C", VA = "0x3EF724C")]
		private static float GetExpRatio()
		{
			return default;
		}

		[Token(Token = "0x6001E5F")]
		[Address(RVA = "0x3EF72FC", Offset = "0x3EF32FC", VA = "0x3EF72FC")]
		private static float GetTrophyRatio()
		{
			return default;
		}

		[Token(Token = "0x6001E60")]
		[Address(RVA = "0x3EF7468", Offset = "0x3EF3468", VA = "0x3EF7468")]
		public static int ScaleTrophyForPanelPopCheck(int rawTrophy)
		{
			return default;
		}

		[Token(Token = "0x6001E61")]
		[Address(RVA = "0x3EF7568", Offset = "0x3EF3568", VA = "0x3EF7568")]
		public static int ScaleExpForPanelPopCheck(int rawExp)
		{
			return default;
		}

		[Token(Token = "0x6001E62")]
		[Address(RVA = "0x3EF73AC", Offset = "0x3EF33AC", VA = "0x3EF73AC")]
		private static float GetBaseRewardRatio()
		{
			return default;
		}

		[Token(Token = "0x6001E63")]
		[Address(RVA = "0x3EF61F0", Offset = "0x3EF21F0", VA = "0x3EF61F0")]
		private static void BuildWinReward(RewardConfig rewardConfig, string arenaId)
		{
		}

		[Token(Token = "0x6001E64")]
		[Address(RVA = "0x3EF684C", Offset = "0x3EF284C", VA = "0x3EF684C")]
		private static void BuildLoseReward(RewardConfig rewardConfig, string arenaId)
		{
		}

		[Token(Token = "0x6001E65")]
		[Address(RVA = "0x3EF6EB8", Offset = "0x3EF2EB8", VA = "0x3EF6EB8")]
		private static void ApplyWinSideEffects(RewardConfig rewardConfig, string arenaId)
		{
		}

		[Token(Token = "0x6001E66")]
		[Address(RVA = "0x3EF7150", Offset = "0x3EF3150", VA = "0x3EF7150")]
		private static void ApplyLoseSideEffects(RewardConfig rewardConfig, string arenaId)
		{
		}
	}
}
