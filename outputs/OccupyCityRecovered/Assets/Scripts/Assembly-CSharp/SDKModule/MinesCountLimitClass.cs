using System;
using Il2CppDummyDll;

namespace SDKModule
{
	[Serializable]
	[Token(Token = "0x2000136")]
	public class MinesCountLimitClass
	{
		[Token(Token = "0x4001A0C")]
		[FieldOffset(Offset = "0x10")]
		public int MinesCountLimit = -1;

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x3F7357C", Offset = "0x3F6F57C", VA = "0x3F7357C")]
		public MinesCountLimitClass()
		{
		}
	}
}
