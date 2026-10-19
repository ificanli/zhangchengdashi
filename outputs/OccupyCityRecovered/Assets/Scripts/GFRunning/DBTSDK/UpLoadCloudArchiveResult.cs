using Il2CppDummyDll;

namespace DBTSDK
{
	[Token(Token = "0x20001F3")]
	public class UpLoadCloudArchiveResult
	{
		[Token(Token = "0x40006DF")]
		[FieldOffset(Offset = "0x10")]
		public int code;

		[Token(Token = "0x40006E0")]
		[FieldOffset(Offset = "0x18")]
		public string key;

		[Token(Token = "0x40006E1")]
		[FieldOffset(Offset = "0x20")]
		public string msg;

		[Token(Token = "0x60019D5")]
		[Address(RVA = "0x70B8330", Offset = "0x70B4330", VA = "0x70B8330")]
		public UpLoadCloudArchiveResult()
		{
		}
	}
}
