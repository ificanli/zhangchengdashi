using Il2CppDummyDll;

namespace DBTSDK
{
	[Token(Token = "0x20001F1")]
	public class NotifyData
	{
		[Token(Token = "0x40006D4")]
		[FieldOffset(Offset = "0x10")]
		public string notifyId;

		[Token(Token = "0x40006D5")]
		[FieldOffset(Offset = "0x18")]
		public string content;

		[Token(Token = "0x40006D6")]
		[FieldOffset(Offset = "0x20")]
		public string startTimeStr;

		[Token(Token = "0x40006D7")]
		[FieldOffset(Offset = "0x28")]
		public int repeatType;

		[Token(Token = "0x40006D8")]
		[FieldOffset(Offset = "0x30")]
		public string endTimeStr;

		[Token(Token = "0x40006D9")]
		[FieldOffset(Offset = "0x38")]
		public string title;

		[Token(Token = "0x40006DA")]
		[FieldOffset(Offset = "0x40")]
		public string imgUrl;

		[Token(Token = "0x40006DB")]
		[FieldOffset(Offset = "0x48")]
		public string mParams;

		[Token(Token = "0x60019D3")]
		[Address(RVA = "0x70B8328", Offset = "0x70B4328", VA = "0x70B8328")]
		public NotifyData()
		{
		}
	}
}
