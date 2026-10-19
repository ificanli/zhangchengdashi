using System.Collections.Generic;
using DataModule;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x2000579")]
	public class ApplyRewardBanner : ApplyRewardBase
	{
		[Token(Token = "0x6001C49")]
		[Address(RVA = "0x3ECF558", Offset = "0x3ECB558", VA = "0x3ECF558", Slot = "4")]
		protected override void ApplyRewardInFirst(IGlobalAssetsInfo info, string num, List<string> moreArgs)
		{
		}

		[Token(Token = "0x6001C4A")]
		[Address(RVA = "0x3ECF790", Offset = "0x3ECB790", VA = "0x3ECF790", Slot = "5")]
		protected override void ApplyReward(IGlobalAssetsInfo info, string num, List<string> moreArgs)
		{
		}

		[Token(Token = "0x6001C4B")]
		[Address(RVA = "0x3ECF794", Offset = "0x3ECB794", VA = "0x3ECF794", Slot = "6")]
		public override void RemoveReward(IGlobalAssetsInfo info, string num, List<string> moreArgs)
		{
		}

		[Token(Token = "0x6001C4C")]
		[Address(RVA = "0x3ECF798", Offset = "0x3ECB798", VA = "0x3ECF798", Slot = "7")]
		public override string GetContent(IGlobalAssetsInfo info, List<string> moreArgs)
		{
			return null;
		}

		[Token(Token = "0x6001C4D")]
		[Address(RVA = "0x3ECF7E0", Offset = "0x3ECB7E0", VA = "0x3ECF7E0")]
		public ApplyRewardBanner()
		{
		}
	}
}
