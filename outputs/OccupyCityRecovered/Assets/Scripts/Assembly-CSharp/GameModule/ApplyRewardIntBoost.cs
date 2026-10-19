using System.Collections.Generic;
using DataModule;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x2000583")]
	public class ApplyRewardIntBoost : ApplyRewardBase
	{
		[Token(Token = "0x6001C8A")]
		[Address(RVA = "0x3ED13D0", Offset = "0x3ECD3D0", VA = "0x3ED13D0", Slot = "5")]
		protected override void ApplyReward(IGlobalAssetsInfo info, string num, List<string> moreArgs)
		{
		}

		[Token(Token = "0x6001C8B")]
		[Address(RVA = "0x3ED1480", Offset = "0x3ECD480", VA = "0x3ED1480", Slot = "4")]
		protected override void ApplyRewardInFirst(IGlobalAssetsInfo info, string num, List<string> moreArgs)
		{
		}

		[Token(Token = "0x6001C8C")]
		[Address(RVA = "0x3ED14A4", Offset = "0x3ECD4A4", VA = "0x3ED14A4", Slot = "6")]
		public override void RemoveReward(IGlobalAssetsInfo info, string num, List<string> moreArgs)
		{
		}

		[Token(Token = "0x6001C8D")]
		[Address(RVA = "0x3ED14C8", Offset = "0x3ECD4C8", VA = "0x3ED14C8", Slot = "7")]
		public override string GetContent(IGlobalAssetsInfo info, List<string> moreArgs)
		{
			return null;
		}

		[Token(Token = "0x6001C8E")]
		[Address(RVA = "0x3ED13F4", Offset = "0x3ECD3F4", VA = "0x3ED13F4")]
		private void ApplyReward(int num, List<string> moreArgs)
		{
		}

		[Token(Token = "0x6001C8F")]
		[Address(RVA = "0x3ED041C", Offset = "0x3ECC41C", VA = "0x3ED041C")]
		public ApplyRewardIntBoost()
		{
		}
	}
}
