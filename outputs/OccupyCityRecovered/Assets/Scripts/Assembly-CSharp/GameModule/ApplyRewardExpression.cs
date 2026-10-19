using System.Collections.Generic;
using DataModule;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x200057F")]
	public class ApplyRewardExpression : ApplyRewardBase
	{
		[Token(Token = "0x6001C72")]
		[Address(RVA = "0x3ED0B10", Offset = "0x3ECCB10", VA = "0x3ED0B10", Slot = "4")]
		protected override void ApplyRewardInFirst(IGlobalAssetsInfo info, string num, List<string> moreArgs)
		{
		}

		[Token(Token = "0x6001C73")]
		[Address(RVA = "0x3ED0D48", Offset = "0x3ECCD48", VA = "0x3ED0D48", Slot = "5")]
		protected override void ApplyReward(IGlobalAssetsInfo info, string num, List<string> moreArgs)
		{
		}

		[Token(Token = "0x6001C74")]
		[Address(RVA = "0x3ED0D4C", Offset = "0x3ECCD4C", VA = "0x3ED0D4C", Slot = "6")]
		public override void RemoveReward(IGlobalAssetsInfo info, string num, List<string> moreArgs)
		{
		}

		[Token(Token = "0x6001C75")]
		[Address(RVA = "0x3ED0D50", Offset = "0x3ECCD50", VA = "0x3ED0D50", Slot = "7")]
		public override string GetContent(IGlobalAssetsInfo info, List<string> moreArgs)
		{
			return null;
		}

		[Token(Token = "0x6001C76")]
		[Address(RVA = "0x3ED03C0", Offset = "0x3ECC3C0", VA = "0x3ED03C0")]
		public ApplyRewardExpression()
		{
		}
	}
}
