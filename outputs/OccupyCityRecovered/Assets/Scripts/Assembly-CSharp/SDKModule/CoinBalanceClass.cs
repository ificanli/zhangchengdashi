using System;
using Il2CppDummyDll;

namespace SDKModule
{
	[Serializable]
	[Token(Token = "0x200015B")]
	public class CoinBalanceClass
	{
		[Token(Token = "0x4001A31")]
		[FieldOffset(Offset = "0x10")]
		public int CoinBalance = -1;

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x3F737CC", Offset = "0x3F6F7CC", VA = "0x3F737CC")]
		public CoinBalanceClass()
		{
		}
	}
}
