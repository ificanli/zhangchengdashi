using Il2CppDummyDll;

namespace DBTSDK
{
	[Token(Token = "0x20001E1")]
	internal class RefundProduct
	{
		[Token(Token = "0x4000680")]
		[FieldOffset(Offset = "0x10")]
		public string orderNo;

		[Token(Token = "0x4000681")]
		[FieldOffset(Offset = "0x18")]
		public string prodId;

		[Token(Token = "0x4000682")]
		[FieldOffset(Offset = "0x20")]
		public string quantity;

		[Token(Token = "0x60018F2")]
		[Address(RVA = "0x70A7F0C", Offset = "0x70A3F0C", VA = "0x70A7F0C")]
		public RefundProduct()
		{
		}
	}
}
