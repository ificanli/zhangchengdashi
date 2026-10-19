using System.Collections.Generic;
using System.Numerics;
using DataModule;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x2000584")]
	public class ApplyRewardProp : ApplyRewardBase
	{
		[Token(Token = "0x6001C90")]
		[Address(RVA = "0x3ED1510", Offset = "0x3ECD510", VA = "0x3ED1510", Slot = "7")]
		public override string GetContent(IGlobalAssetsInfo info, List<string> moreArgs)
		{
			return null;
		}

		[Token(Token = "0x6001C91")]
		[Address(RVA = "0x3ED1558", Offset = "0x3ECD558", VA = "0x3ED1558", Slot = "4")]
		protected override void ApplyRewardInFirst(IGlobalAssetsInfo info, string num, List<string> moreArgs)
		{
		}

		[Token(Token = "0x6001C92")]
		[Address(RVA = "0x3ED1830", Offset = "0x3ECD830", VA = "0x3ED1830", Slot = "5")]
		protected override void ApplyReward(IGlobalAssetsInfo info, string num, List<string> moreArgs)
		{
		}

		[Token(Token = "0x6001C93")]
		[Address(RVA = "0x3ED1834", Offset = "0x3ECD834", VA = "0x3ED1834", Slot = "6")]
		public override void RemoveReward(IGlobalAssetsInfo info, string num, List<string> moreArgs)
		{
		}

		[Token(Token = "0x6001C94")]
		[Address(RVA = "0x3ED161C", Offset = "0x3ECD61C", VA = "0x3ED161C")]
		private void ApplyReward(string resourceId, BigInteger count)
		{
		}

		[Token(Token = "0x6001C95")]
		[Address(RVA = "0x3ED02B4", Offset = "0x3ECC2B4", VA = "0x3ED02B4")]
		public ApplyRewardProp()
		{
		}
	}
}
