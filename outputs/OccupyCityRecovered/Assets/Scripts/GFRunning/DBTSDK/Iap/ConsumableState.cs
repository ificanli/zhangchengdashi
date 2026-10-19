using Il2CppDummyDll;

namespace DBTSDK.Iap
{
	[Token(Token = "0x20002C7")]
	public struct ConsumableState
	{
		[Token(Token = "0x4001738")]
		[FieldOffset(Offset = "0x0")]
		public string gamekey;

		[Token(Token = "0x4001739")]
		[FieldOffset(Offset = "0x8")]
		public int offerType;

		[Token(Token = "0x400173A")]
		[FieldOffset(Offset = "0xC")]
		public CommdityChannel commdityChannel;

		[Token(Token = "0x400173B")]
		[FieldOffset(Offset = "0x10")]
		public string orderid;
	}
}
