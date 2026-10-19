using System.Collections.Generic;
using System.Numerics;
using DataModule;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x2000588")]
	public class ApplyRewardResources : ApplyRewardBase
	{
		[Token(Token = "0x6001CA5")]
		[Address(RVA = "0x3ED2BB8", Offset = "0x3ECEBB8", VA = "0x3ED2BB8")]
		private CurrencyTransactionSceneType GetSceneType(List<string> moreArgs)
		{
			return default;
		}

		[Token(Token = "0x6001CA6")]
		[Address(RVA = "0x3ED2CFC", Offset = "0x3ECECFC", VA = "0x3ED2CFC", Slot = "7")]
		public override string GetContent(IGlobalAssetsInfo info, List<string> moreArgs)
		{
			return null;
		}

		[Token(Token = "0x6001CA7")]
		[Address(RVA = "0x3ED2D44", Offset = "0x3ECED44", VA = "0x3ED2D44", Slot = "4")]
		protected override void ApplyRewardInFirst(IGlobalAssetsInfo info, string num, List<string> moreArgs)
		{
		}

		[Token(Token = "0x6001CA8")]
		[Address(RVA = "0x3ED3274", Offset = "0x3ECF274", VA = "0x3ED3274", Slot = "5")]
		protected override void ApplyReward(IGlobalAssetsInfo info, string num, List<string> moreArgs)
		{
		}

		[Token(Token = "0x6001CA9")]
		[Address(RVA = "0x3ED3354", Offset = "0x3ECF354", VA = "0x3ED3354", Slot = "6")]
		public override void RemoveReward(IGlobalAssetsInfo info, string num, List<string> moreArgs)
		{
		}

		[Token(Token = "0x6001CAA")]
		[Address(RVA = "0x3ED2FB0", Offset = "0x3ECEFB0", VA = "0x3ED2FB0")]
		private void ApplyReward(string resourceId, BigInteger count, CurrencyTransactionSceneType sceneType)
		{
		}

		[Token(Token = "0x6001CAB")]
		[Address(RVA = "0x3ED3358", Offset = "0x3ECF358", VA = "0x3ED3358")]
		private static void ApplyMysteryAdventureDice(BigInteger count)
		{
		}

		[Token(Token = "0x6001CAC")]
		[Address(RVA = "0x3ED34A0", Offset = "0x3ECF4A0", VA = "0x3ED34A0")]
		private static void ApplyWorldCupFootball(BigInteger count)
		{
		}

		[Token(Token = "0x6001CAD")]
		[Address(RVA = "0x3ED01A0", Offset = "0x3ECC1A0", VA = "0x3ED01A0")]
		public ApplyRewardResources()
		{
		}
	}
}
