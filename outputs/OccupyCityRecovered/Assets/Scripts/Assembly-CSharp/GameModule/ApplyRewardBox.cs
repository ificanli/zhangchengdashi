using System.Collections.Generic;
using System.Numerics;
using DataModule;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x200057E")]
	public class ApplyRewardBox : ApplyRewardBase
	{
		[Token(Token = "0x6001C6B")]
		[Address(RVA = "0x3ED0694", Offset = "0x3ECC694", VA = "0x3ED0694")]
		private CurrencyTransactionSceneType GetSceneType(List<string> moreArgs)
		{
			return default;
		}

		[Token(Token = "0x6001C6C")]
		[Address(RVA = "0x3ED07D8", Offset = "0x3ECC7D8", VA = "0x3ED07D8", Slot = "7")]
		public override string GetContent(IGlobalAssetsInfo info, List<string> moreArgs)
		{
			return null;
		}

		[Token(Token = "0x6001C6D")]
		[Address(RVA = "0x3ED0820", Offset = "0x3ECC820", VA = "0x3ED0820", Slot = "4")]
		protected override void ApplyRewardInFirst(IGlobalAssetsInfo info, string num, List<string> moreArgs)
		{
		}

		[Token(Token = "0x6001C6E")]
		[Address(RVA = "0x3ED0B08", Offset = "0x3ECCB08", VA = "0x3ED0B08", Slot = "5")]
		protected override void ApplyReward(IGlobalAssetsInfo info, string num, List<string> moreArgs)
		{
		}

		[Token(Token = "0x6001C6F")]
		[Address(RVA = "0x3ED0B0C", Offset = "0x3ECCB0C", VA = "0x3ED0B0C", Slot = "6")]
		public override void RemoveReward(IGlobalAssetsInfo info, string num, List<string> moreArgs)
		{
		}

		[Token(Token = "0x6001C70")]
		[Address(RVA = "0x3ED08F0", Offset = "0x3ECC8F0", VA = "0x3ED08F0")]
		private void ApplyReward(string resourceId, BigInteger count, CurrencyTransactionSceneType sceneType)
		{
		}

		[Token(Token = "0x6001C71")]
		[Address(RVA = "0x3ED0310", Offset = "0x3ECC310", VA = "0x3ED0310")]
		public ApplyRewardBox()
		{
		}
	}
}
