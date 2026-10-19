using System.Collections.Generic;
using System.Numerics;
using DataModule;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x2000582")]
	public class ApplyRewardHeroCard : ApplyRewardBase
	{
		[Token(Token = "0x6001C84")]
		[Address(RVA = "0x3ED1008", Offset = "0x3ECD008", VA = "0x3ED1008", Slot = "7")]
		public override string GetContent(IGlobalAssetsInfo info, List<string> moreArgs)
		{
			return null;
		}

		[Token(Token = "0x6001C85")]
		[Address(RVA = "0x3ED1050", Offset = "0x3ECD050", VA = "0x3ED1050", Slot = "4")]
		protected override void ApplyRewardInFirst(IGlobalAssetsInfo info, string num, List<string> moreArgs)
		{
		}

		[Token(Token = "0x6001C86")]
		[Address(RVA = "0x3ED13C8", Offset = "0x3ECD3C8", VA = "0x3ED13C8", Slot = "5")]
		protected override void ApplyReward(IGlobalAssetsInfo info, string num, List<string> moreArgs)
		{
		}

		[Token(Token = "0x6001C87")]
		[Address(RVA = "0x3ED13CC", Offset = "0x3ECD3CC", VA = "0x3ED13CC", Slot = "6")]
		public override void RemoveReward(IGlobalAssetsInfo info, string num, List<string> moreArgs)
		{
		}

		[Token(Token = "0x6001C88")]
		[Address(RVA = "0x3ED1114", Offset = "0x3ECD114", VA = "0x3ED1114")]
		private void ApplyReward(string resourceId, BigInteger count)
		{
		}

		[Token(Token = "0x6001C89")]
		[Address(RVA = "0x3ED01FC", Offset = "0x3ECC1FC", VA = "0x3ED01FC")]
		public ApplyRewardHeroCard()
		{
		}
	}
}
