using System.Collections.Generic;
using System.Numerics;
using DataModule;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x2000585")]
	public class ApplyRewardRandomHeroCard : ApplyRewardBase
	{
		[Token(Token = "0x6001C96")]
		[Address(RVA = "0x3ED1838", Offset = "0x3ECD838", VA = "0x3ED1838", Slot = "7")]
		public override string GetContent(IGlobalAssetsInfo info, List<string> moreArgs)
		{
			return null;
		}

		[Token(Token = "0x6001C97")]
		[Address(RVA = "0x3ED1880", Offset = "0x3ECD880", VA = "0x3ED1880", Slot = "4")]
		protected override void ApplyRewardInFirst(IGlobalAssetsInfo info, string num, List<string> moreArgs)
		{
		}

		[Token(Token = "0x6001C98")]
		[Address(RVA = "0x3ED20B4", Offset = "0x3ECE0B4", VA = "0x3ED20B4", Slot = "5")]
		protected override void ApplyReward(IGlobalAssetsInfo info, string num, List<string> moreArgs)
		{
		}

		[Token(Token = "0x6001C99")]
		[Address(RVA = "0x3ED20B8", Offset = "0x3ECE0B8", VA = "0x3ED20B8", Slot = "6")]
		public override void RemoveReward(IGlobalAssetsInfo info, string num, List<string> moreArgs)
		{
		}

		[Token(Token = "0x6001C9A")]
		[Address(RVA = "0x3ED1AAC", Offset = "0x3ECDAAC", VA = "0x3ED1AAC")]
		private void ApplyReward(string resourceId, BigInteger count, CurrencyTransactionSceneType sceneType)
		{
		}

		[Token(Token = "0x6001C9B")]
		[Address(RVA = "0x3ED1968", Offset = "0x3ECD968", VA = "0x3ED1968")]
		private static CurrencyTransactionSceneType GetSceneType(List<string> moreArgs)
		{
			return default;
		}

		[Token(Token = "0x6001C9C")]
		[Address(RVA = "0x3ED20C4", Offset = "0x3ECE0C4", VA = "0x3ED20C4")]
		private string SelectRarity(Dictionary<string, int> rarityProbabilities)
		{
			return null;
		}

		[Token(Token = "0x6001C9D")]
		[Address(RVA = "0x3ED22C0", Offset = "0x3ECE2C0", VA = "0x3ED22C0")]
		private void AddOrUpdateCard(UserHeroCardData card, Dictionary<string, UserHeroCardData> dict, List<UserHeroCardData> list)
		{
		}

		[Token(Token = "0x6001C9E")]
		[Address(RVA = "0x3ED23E8", Offset = "0x3ECE3E8", VA = "0x3ED23E8")]
		private void ProcessRewards(string resourceId, List<UserHeroCardData> cards, Dictionary<string, int> giftPackOwnedPoolDrawCounts, CurrencyTransactionSceneType sceneType)
		{
		}

		[Token(Token = "0x6001C9F")]
		[Address(RVA = "0x3ED0258", Offset = "0x3ECC258", VA = "0x3ED0258")]
		public ApplyRewardRandomHeroCard()
		{
		}
	}
}
