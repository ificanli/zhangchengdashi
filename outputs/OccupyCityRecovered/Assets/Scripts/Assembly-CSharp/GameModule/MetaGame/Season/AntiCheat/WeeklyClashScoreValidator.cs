using System.Collections.Generic;
using DataModule;
using Il2CppDummyDll;

namespace GameModule.MetaGame.Season.AntiCheat
{
	[Token(Token = "0x2000611")]
	public static class WeeklyClashScoreValidator
	{
		[Token(Token = "0x600206A")]
		[Address(RVA = "0x3F10010", Offset = "0x3F0C010", VA = "0x3F10010")]
		private static int ParseRewardValue(string rewardStr, string resourceId)
		{
			return default;
		}

		[Token(Token = "0x600206B")]
		[Address(RVA = "0x3F10158", Offset = "0x3F0C158", VA = "0x3F10158")]
		private static WeeklyClashDifficultyConfig GetConfigByScore(int currentScore, List<WeeklyClashDifficultyConfig> configs)
		{
			return null;
		}

		[Token(Token = "0x600206C")]
		[Address(RVA = "0x3F10280", Offset = "0x3F0C280", VA = "0x3F10280")]
		public static int CalculateMaxPossibleScore(bool isSeasonLeaderboard = false)
		{
			return default;
		}
	}
}
