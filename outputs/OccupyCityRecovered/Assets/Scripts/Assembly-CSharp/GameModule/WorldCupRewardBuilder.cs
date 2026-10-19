using System.Collections.Generic;
using DataModule;
using Il2CppDummyDll;
using ljzs_lt;

namespace GameModule
{
	[Token(Token = "0x20005FA")]
	internal static class WorldCupRewardBuilder
	{
		[Token(Token = "0x6001FBB")]
		[Address(RVA = "0x3F0975C", Offset = "0x3F0575C", VA = "0x3F0975C")]
		public static bool TryBuildValidReward(string rewardRaw, out RewardConfig rewardConfig, out string errorMessage)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED WorldCupRewardBuilder.TryBuildValidReward RVA=0x3F0975C Token=0x6001FBB");
}

		[Token(Token = "0x6001FBC")]
		[Address(RVA = "0x3F098B4", Offset = "0x3F058B4", VA = "0x3F098B4")]
		public static bool TryBuildShootRewardConfig(GoalRewardConfig config, int multiplier, out RewardConfig rewardConfig, out string rewardRaw, out bool rewardAlreadyGranted)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED WorldCupRewardBuilder.TryBuildShootRewardConfig RVA=0x3F098B4 Token=0x6001FBC");
}

		[Token(Token = "0x6001FBD")]
		[Address(RVA = "0x3F09E18", Offset = "0x3F05E18", VA = "0x3F09E18")]
		public static int GrantPackConfigRewards(WorldCupdailyPriceConfig config, out string errorMessage)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED WorldCupRewardBuilder.GrantPackConfigRewards RVA=0x3F09E18 Token=0x6001FBD");
}

		[Token(Token = "0x6001FBE")]
		[Address(RVA = "0x3F09F54", Offset = "0x3F05F54", VA = "0x3F09F54")]
		private static void AppendPackRewardSlot(RewardConfig rewardConfig, int itemType, int itemId, int count, ref int footballTotal)
		{
		}

		[Token(Token = "0x6001FBF")]
		[Address(RVA = "0x3F099B0", Offset = "0x3F059B0", VA = "0x3F099B0")]
		private static bool ReplaceRandomHeroCardRewards(RewardConfig rewardConfig)
		{
			return default;
		}

		[Token(Token = "0x6001FC0")]
		[Address(RVA = "0x3F0A0F0", Offset = "0x3F060F0", VA = "0x3F0A0F0")]
		private static List<UserHeroCardData> DrawSingleRandomHeroCard(GlobalRandomHeroCardInfo randomCardConfig, int count)
		{
			return null;
		}

		[Token(Token = "0x6001FC1")]
		[Address(RVA = "0x3F0A558", Offset = "0x3F06558", VA = "0x3F0A558")]
		private static string SelectRandomCardRarity(Dictionary<string, int> rarityProbabilities)
		{
			return null;
		}

		[Token(Token = "0x6001FC2")]
		[Address(RVA = "0x3F09C14", Offset = "0x3F05C14", VA = "0x3F09C14")]
		private static string BuildRewardRaw(RewardConfig rewardConfig)
		{
			return null;
		}
	}
}
