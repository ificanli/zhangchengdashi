using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000ED9")]
	public class TrophyProgressRewardData
	{
		[Token(Token = "0x4006704")]
		[FieldOffset(Offset = "0x10")]
		public string ConfigId;

		[Token(Token = "0x4006705")]
		[FieldOffset(Offset = "0x18")]
		public string ClaimedCardId;

		[Token(Token = "0x4006706")]
		[FieldOffset(Offset = "0x20")]
		public bool IsExpressionRewardClaimed;

		[Token(Token = "0x4006707")]
		[FieldOffset(Offset = "0x21")]
		public bool IsNormalRewardClaimed;

		[Token(Token = "0x60059C6")]
		[Address(RVA = "0x4376B98", Offset = "0x4372B98", VA = "0x4376B98")]
		public GlobalTrophyProgressInfo GetConfig()
		{
			return null;
		}

		[Token(Token = "0x60059C7")]
		[Address(RVA = "0x4376C80", Offset = "0x4372C80", VA = "0x4376C80")]
		public bool IsCardRewardClaimed()
		{
			return default;
		}

		[Token(Token = "0x60059C8")]
		[Address(RVA = "0x4376CA0", Offset = "0x4372CA0", VA = "0x4376CA0")]
		public bool IsCardClaimed(string cardId)
		{
			return default;
		}

		[Token(Token = "0x60059C9")]
		[Address(RVA = "0x4376CE8", Offset = "0x4372CE8", VA = "0x4376CE8")]
		public void MarkCardRewardClaimed(string cardId)
		{
		}

		[Token(Token = "0x60059CA")]
		[Address(RVA = "0x4376D18", Offset = "0x4372D18", VA = "0x4376D18")]
		public void MarkExpressionRewardClaimed()
		{
		}

		[Token(Token = "0x60059CB")]
		[Address(RVA = "0x4376D24", Offset = "0x4372D24", VA = "0x4376D24")]
		public void MarkNormalRewardClaimed()
		{
		}

		[Token(Token = "0x60059CC")]
		[Address(RVA = "0x4376D30", Offset = "0x4372D30", VA = "0x4376D30")]
		public bool AreAllRewardsClaimed()
		{
			return default;
		}

		[Token(Token = "0x60059CD")]
		[Address(RVA = "0x4376D98", Offset = "0x4372D98", VA = "0x4376D98")]
		public bool HasCardReward()
		{
			return default;
		}

		[Token(Token = "0x60059CE")]
		[Address(RVA = "0x4376DC8", Offset = "0x4372DC8", VA = "0x4376DC8")]
		public bool HasExpressionReward()
		{
			return default;
		}

		[Token(Token = "0x60059CF")]
		[Address(RVA = "0x4376DF8", Offset = "0x4372DF8", VA = "0x4376DF8")]
		public bool HasNormalReward()
		{
			return default;
		}

		[Token(Token = "0x60059D0")]
		[Address(RVA = "0x4376E38", Offset = "0x4372E38", VA = "0x4376E38")]
		public bool IsCardRewardClaimable(int currentTrophy)
		{
			return default;
		}

		[Token(Token = "0x60059D1")]
		[Address(RVA = "0x4376E90", Offset = "0x4372E90", VA = "0x4376E90")]
		public bool IsExpressionRewardClaimable(int currentTrophy)
		{
			return default;
		}

		[Token(Token = "0x60059D2")]
		[Address(RVA = "0x4376EE4", Offset = "0x4372EE4", VA = "0x4376EE4")]
		public bool IsNormalRewardClaimable(int currentTrophy)
		{
			return default;
		}

		[Token(Token = "0x60059D3")]
		[Address(RVA = "0x4376F38", Offset = "0x4372F38", VA = "0x4376F38")]
		public bool HasAnyClaimableReward(int currentTrophy)
		{
			return default;
		}

		[Token(Token = "0x60059D4")]
		[Address(RVA = "0x4376F84", Offset = "0x4372F84", VA = "0x4376F84")]
		public TrophyProgressRewardData()
		{
		}
	}
}
