using System;
using Il2CppDummyDll;

namespace SDKModule
{
	[Serializable]
	[Token(Token = "0x2000144")]
	public class ChainRewardsIAPClass
	{
		[Token(Token = "0x4001A1A")]
		[FieldOffset(Offset = "0x10")]
		public int ChainRewardsIAP = -1;

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x3F7365C", Offset = "0x3F6F65C", VA = "0x3F7365C")]
		public ChainRewardsIAPClass()
		{
		}
	}
}
