using Il2CppDummyDll;

namespace DBTSDK.Iap
{
	[Token(Token = "0x20002C6")]
	public struct NonConsumableState
	{
		[Token(Token = "0x4001733")]
		[FieldOffset(Offset = "0x0")]
		public string Gamekey;

		[Token(Token = "0x4001734")]
		[FieldOffset(Offset = "0x8")]
		public int state;

		[Token(Token = "0x4001735")]
		[FieldOffset(Offset = "0xC")]
		public CommdityChannel channel;

		[Token(Token = "0x4001736")]
		[FieldOffset(Offset = "0x10")]
		public bool isAcknowled;

		[Token(Token = "0x4001737")]
		[FieldOffset(Offset = "0x18")]
		public string orderId;
	}
}
