using Il2CppDummyDll;

namespace DBTSDK
{
	[Token(Token = "0x20001F4")]
	public class PullCloudArchiveResult
	{
		[Token(Token = "0x40006E2")]
		[FieldOffset(Offset = "0x10")]
		public int code;

		[Token(Token = "0x40006E3")]
		[FieldOffset(Offset = "0x18")]
		public string key;

		[Token(Token = "0x40006E4")]
		[FieldOffset(Offset = "0x20")]
		public string value;

		[Token(Token = "0x40006E5")]
		[FieldOffset(Offset = "0x28")]
		public string msg;

		[Token(Token = "0x60019D6")]
		[Address(RVA = "0x70B8338", Offset = "0x70B4338", VA = "0x70B8338")]
		public PullCloudArchiveResult()
		{
		}
	}
}
