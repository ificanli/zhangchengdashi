using Il2CppDummyDll;

namespace DBTSDK
{
	[Token(Token = "0x20001F0")]
	public class CDKInfo
	{
		[Token(Token = "0x40006C9")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		[Token(Token = "0x40006CA")]
		[FieldOffset(Offset = "0x14")]
		public int rewardType;

		[Token(Token = "0x40006CB")]
		[FieldOffset(Offset = "0x18")]
		public int status;

		[Token(Token = "0x40006CC")]
		[FieldOffset(Offset = "0x20")]
		public string codeType;

		[Token(Token = "0x40006CD")]
		[FieldOffset(Offset = "0x28")]
		public string createTime;

		[Token(Token = "0x40006CE")]
		[FieldOffset(Offset = "0x30")]
		public string dateType;

		[Token(Token = "0x40006CF")]
		[FieldOffset(Offset = "0x38")]
		public string deviceId;

		[Token(Token = "0x40006D0")]
		[FieldOffset(Offset = "0x40")]
		public string endDate;

		[Token(Token = "0x40006D1")]
		[FieldOffset(Offset = "0x48")]
		public string extraParam;

		[Token(Token = "0x40006D2")]
		[FieldOffset(Offset = "0x50")]
		public string name;

		[Token(Token = "0x40006D3")]
		[FieldOffset(Offset = "0x58")]
		public string startDate;

		[Token(Token = "0x60019D2")]
		[Address(RVA = "0x70AD13C", Offset = "0x70A913C", VA = "0x70AD13C")]
		public CDKInfo()
		{
		}
	}
}
