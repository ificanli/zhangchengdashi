using Il2CppDummyDll;

namespace DBT.StartupGift
{
	[Token(Token = "0x2000F72")]
	public static class StartupGiftEditorStorage
	{
		[Token(Token = "0x4006A8C")]
		private const string KeyPrefix = "DBT_STARTUP_GIFT_REWARD_";

		[Token(Token = "0x6005CAC")]
		[Address(RVA = "0x43B22B0", Offset = "0x43AE2B0", VA = "0x43B22B0")]
		public static void SetReward(string providerId, string rewardStr)
		{
		}

		[Token(Token = "0x6005CAD")]
		[Address(RVA = "0x43B22B4", Offset = "0x43AE2B4", VA = "0x43B22B4")]
		public static bool HasReward(string providerId)
		{
			return default;
		}

		[Token(Token = "0x6005CAE")]
		[Address(RVA = "0x43B22BC", Offset = "0x43AE2BC", VA = "0x43B22BC")]
		public static string GetReward(string providerId)
		{
			return null;
		}

		[Token(Token = "0x6005CAF")]
		[Address(RVA = "0x43B2304", Offset = "0x43AE304", VA = "0x43B2304")]
		public static void ClearReward(string providerId)
		{
		}

		[Token(Token = "0x6005CB0")]
		[Address(RVA = "0x43B2308", Offset = "0x43AE308", VA = "0x43B2308")]
		public static void ClearAllDefaultRewards()
		{
		}

		[Token(Token = "0x6005CB1")]
		[Address(RVA = "0x43B230C", Offset = "0x43AE30C", VA = "0x43B230C")]
		private static string BuildRewardKey(string providerId)
		{
			return null;
		}
	}
}
