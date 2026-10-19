using System;
using Il2CppDummyDll;

namespace SDKModule
{
	[Serializable]
	[Token(Token = "0x200013B")]
	public class DynamicCoinsClass
	{
		[Token(Token = "0x4001A11")]
		[FieldOffset(Offset = "0x10")]
		public int DynamicCoins;

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x3F735CC", Offset = "0x3F6F5CC", VA = "0x3F735CC")]
		public DynamicCoinsClass()
		{
		}
	}
}
