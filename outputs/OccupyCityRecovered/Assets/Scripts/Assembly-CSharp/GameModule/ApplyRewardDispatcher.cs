using System;
using System.Collections.Generic;
using DataModule;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x200057B")]
	public static class ApplyRewardDispatcher
	{
		[Token(Token = "0x4003028")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<string, Func<ApplyRewardBase>> _rewardHandlerFactories;

		[Token(Token = "0x6001C54")]
		[Address(RVA = "0x3ECF814", Offset = "0x3ECB814", VA = "0x3ECF814")]
		private static ApplyRewardBase CreateHandler(string rewardClassKey)
		{
			return null;
		}

		[Token(Token = "0x6001C55")]
		[Address(RVA = "0x3ECF8C8", Offset = "0x3ECB8C8", VA = "0x3ECF8C8")]
		public static void ApplyReward(IGlobalAssetsInfo info, bool isFirst, string num, List<string> moreArgs)
		{
		}

		[Token(Token = "0x6001C56")]
		[Address(RVA = "0x3ECF9E4", Offset = "0x3ECB9E4", VA = "0x3ECF9E4")]
		public static void RemoveReward(IGlobalAssetsInfo info, string num, List<string> moreArgs)
		{
		}

		[Token(Token = "0x6001C57")]
		[Address(RVA = "0x3ECFAF0", Offset = "0x3ECBAF0", VA = "0x3ECFAF0")]
		public static string GetContent(IGlobalAssetsInfo info, List<string> args)
		{
			return null;
		}
	}
}
