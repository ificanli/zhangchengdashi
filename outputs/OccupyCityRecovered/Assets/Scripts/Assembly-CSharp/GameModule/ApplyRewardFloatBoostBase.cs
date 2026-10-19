using System.Collections.Generic;
using DataModule;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x2000581")]
	public abstract class ApplyRewardFloatBoostBase : ApplyRewardBase
	{
		[Token(Token = "0x17000178")]
		protected abstract string Key
		{
			[Token(Token = "0x6001C7D")]
			get;
		}

		[Token(Token = "0x6001C7E")]
		[Address(RVA = "0x3ED0ED8", Offset = "0x3ECCED8", VA = "0x3ED0ED8", Slot = "5")]
		protected override void ApplyReward(IGlobalAssetsInfo info, string num, List<string> moreArgs)
		{
		}

		[Token(Token = "0x6001C7F")]
		[Address(RVA = "0x3ED0F74", Offset = "0x3ECCF74", VA = "0x3ED0F74", Slot = "4")]
		protected override void ApplyRewardInFirst(IGlobalAssetsInfo info, string num, List<string> moreArgs)
		{
		}

		[Token(Token = "0x6001C80")]
		[Address(RVA = "0x3ED0F94", Offset = "0x3ECCF94", VA = "0x3ED0F94", Slot = "6")]
		public override void RemoveReward(IGlobalAssetsInfo info, string num, List<string> moreArgs)
		{
		}

		[Token(Token = "0x6001C81")]
		[Address(RVA = "0x3ED0FB8", Offset = "0x3ECCFB8", VA = "0x3ED0FB8", Slot = "7")]
		public override string GetContent(IGlobalAssetsInfo info, List<string> moreArgs)
		{
			return null;
		}

		[Token(Token = "0x6001C82")]
		[Address(RVA = "0x3ED0EF8", Offset = "0x3ECCEF8", VA = "0x3ED0EF8")]
		private void ApplyReward(float num)
		{
		}

		[Token(Token = "0x6001C83")]
		[Address(RVA = "0x3ED1000", Offset = "0x3ECD000", VA = "0x3ED1000")]
		protected ApplyRewardFloatBoostBase()
		{
		}
	}
}
