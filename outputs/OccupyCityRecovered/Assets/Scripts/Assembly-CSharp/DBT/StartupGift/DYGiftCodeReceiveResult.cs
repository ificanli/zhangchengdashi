using Il2CppDummyDll;

namespace DBT.StartupGift
{
	[Token(Token = "0x2000F6E")]
	public class DYGiftCodeReceiveResult
	{
		[Token(Token = "0x4006A84")]
		[FieldOffset(Offset = "0x10")]
		public bool Success;

		[Token(Token = "0x4006A85")]
		[FieldOffset(Offset = "0x18")]
		public string GiftCode;

		[Token(Token = "0x4006A86")]
		[FieldOffset(Offset = "0x20")]
		public string RewardStr;

		[Token(Token = "0x4006A87")]
		[FieldOffset(Offset = "0x28")]
		public string ErrorMessage;

		[Token(Token = "0x4006A88")]
		[FieldOffset(Offset = "0x30")]
		public string Response;

		[Token(Token = "0x6005C9E")]
		[Address(RVA = "0x43B1FD8", Offset = "0x43ADFD8", VA = "0x43B1FD8")]
		public DYGiftCodeReceiveResult()
		{
		}
	}
}
