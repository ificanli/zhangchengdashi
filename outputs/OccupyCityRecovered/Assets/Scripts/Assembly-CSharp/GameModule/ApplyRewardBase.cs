using System.Collections.Generic;
using DataModule;
using Il2CppDummyDll;
using JetBrains.Annotations;

namespace GameModule
{
	[Token(Token = "0x200057A")]
	public abstract class ApplyRewardBase
	{
		[Token(Token = "0x6001C4E")]
		[Address(RVA = "0x3ECF7F0", Offset = "0x3ECB7F0", VA = "0x3ECF7F0")]
		[UsedImplicitly]
		public void ApplyReward(IGlobalAssetsInfo info, bool isFirst, string num, List<string> moreArgs)
		{
		}

		[Token(Token = "0x6001C4F")]
		protected abstract void ApplyRewardInFirst(IGlobalAssetsInfo info, string num, List<string> moreArgs);

		[Token(Token = "0x6001C50")]
		protected abstract void ApplyReward(IGlobalAssetsInfo info, string num, List<string> moreArgs);

		[Token(Token = "0x6001C51")]
		[UsedImplicitly]
		public abstract void RemoveReward(IGlobalAssetsInfo info, string num, List<string> moreArgs);

		[Token(Token = "0x6001C52")]
		[UsedImplicitly]
		public abstract string GetContent(IGlobalAssetsInfo info, List<string> moreArgs);

		[Token(Token = "0x6001C53")]
		[Address(RVA = "0x3ECF7E8", Offset = "0x3ECB7E8", VA = "0x3ECF7E8")]
		protected ApplyRewardBase()
		{
		}
	}
}
