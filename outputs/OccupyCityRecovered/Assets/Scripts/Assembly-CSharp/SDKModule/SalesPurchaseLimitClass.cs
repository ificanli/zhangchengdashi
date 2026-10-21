using System;
using Il2CppDummyDll;

namespace SDKModule
{
	[Serializable]
	[Token(Token = "0x2000142")]
	public class SalesPurchaseLimitClass
	{
		[Token(Token = "0x4001A18")]
		[FieldOffset(Offset = "0x10")]
		public int SalesPurchaseLimit = -1;

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x3F7363C", Offset = "0x3F6F63C", VA = "0x3F7363C")]
		public SalesPurchaseLimitClass()
		{
		}
	}
}
