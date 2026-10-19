using System.Collections.Generic;
using DataModule;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x2000580")]
	public class ApplyRewardFloatBoost : ApplyRewardBase
	{
		[Token(Token = "0x6001C77")]
		[Address(RVA = "0x3ED0D98", Offset = "0x3ECCD98", VA = "0x3ED0D98", Slot = "5")]
		protected override void ApplyReward(IGlobalAssetsInfo info, string num, List<string> moreArgs)
		{
		}

		[Token(Token = "0x6001C78")]
		[Address(RVA = "0x3ED0E4C", Offset = "0x3ECCE4C", VA = "0x3ED0E4C", Slot = "4")]
		protected override void ApplyRewardInFirst(IGlobalAssetsInfo info, string num, List<string> moreArgs)
		{
		}

		[Token(Token = "0x6001C79")]
		[Address(RVA = "0x3ED0E6C", Offset = "0x3ECCE6C", VA = "0x3ED0E6C", Slot = "6")]
		public override void RemoveReward(IGlobalAssetsInfo info, string num, List<string> moreArgs)
		{
		}

		[Token(Token = "0x6001C7A")]
		[Address(RVA = "0x3ED0E90", Offset = "0x3ECCE90", VA = "0x3ED0E90", Slot = "7")]
		public override string GetContent(IGlobalAssetsInfo info, List<string> moreArgs)
		{
			return null;
		}

		[Token(Token = "0x6001C7B")]
		[Address(RVA = "0x3ED0DB8", Offset = "0x3ECCDB8", VA = "0x3ED0DB8")]
		private void ApplyReward(float num, List<string> moreArgs)
		{
		}

		[Token(Token = "0x6001C7C")]
		[Address(RVA = "0x3ED0478", Offset = "0x3ECC478", VA = "0x3ED0478")]
		public ApplyRewardFloatBoost()
		{
		}
	}
}
