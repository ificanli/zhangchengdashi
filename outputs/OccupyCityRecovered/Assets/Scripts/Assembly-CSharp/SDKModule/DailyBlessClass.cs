using System;
using Il2CppDummyDll;

namespace SDKModule
{
	[Serializable]
	[Token(Token = "0x2000147")]
	public class DailyBlessClass
	{
		[Token(Token = "0x4001A1D")]
		[FieldOffset(Offset = "0x10")]
		public int DailyBless = -1;

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x3F7368C", Offset = "0x3F6F68C", VA = "0x3F7368C")]
		public DailyBlessClass()
		{
		}
	}
}
