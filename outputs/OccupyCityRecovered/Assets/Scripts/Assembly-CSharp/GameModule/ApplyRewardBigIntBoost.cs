using System.Collections.Generic;
using System.Numerics;
using DataModule;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x200057D")]
	public class ApplyRewardBigIntBoost : ApplyRewardBase
	{
		[Token(Token = "0x6001C65")]
		[Address(RVA = "0x3ED04DC", Offset = "0x3ECC4DC", VA = "0x3ED04DC", Slot = "5")]
		protected override void ApplyReward(IGlobalAssetsInfo info, string num, List<string> moreArgs)
		{
		}

		[Token(Token = "0x6001C66")]
		[Address(RVA = "0x3ED05A0", Offset = "0x3ECC5A0", VA = "0x3ED05A0", Slot = "4")]
		protected override void ApplyRewardInFirst(IGlobalAssetsInfo info, string num, List<string> moreArgs)
		{
		}

		[Token(Token = "0x6001C67")]
		[Address(RVA = "0x3ED05C8", Offset = "0x3ECC5C8", VA = "0x3ED05C8", Slot = "6")]
		public override void RemoveReward(IGlobalAssetsInfo info, string num, List<string> moreArgs)
		{
		}

		[Token(Token = "0x6001C68")]
		[Address(RVA = "0x3ED0654", Offset = "0x3ECC654", VA = "0x3ED0654", Slot = "7")]
		public override string GetContent(IGlobalAssetsInfo info, List<string> moreArgs)
		{
			return null;
		}

		[Token(Token = "0x6001C69")]
		[Address(RVA = "0x3ED0504", Offset = "0x3ECC504", VA = "0x3ED0504")]
		private void ApplyReward(BigInteger num, List<string> moreArgs)
		{
		}

		[Token(Token = "0x6001C6A")]
		[Address(RVA = "0x3ED04D4", Offset = "0x3ECC4D4", VA = "0x3ED04D4")]
		public ApplyRewardBigIntBoost()
		{
		}
	}
}
