using Il2CppDummyDll;

namespace DBTSDK
{
	[Token(Token = "0x20001D5")]
	public class ImmersiveAdConfig
	{
		[Token(Token = "0x400063E")]
		[FieldOffset(Offset = "0x10")]
		public string pid;

		[Token(Token = "0x400063F")]
		[FieldOffset(Offset = "0x18")]
		public string appid;

		[Token(Token = "0x4000640")]
		[FieldOffset(Offset = "0x20")]
		public int isClick;

		[Token(Token = "0x4000641")]
		[FieldOffset(Offset = "0x24")]
		public int splashTime;

		[Token(Token = "0x60017F9")]
		[Address(RVA = "0x739C6C8", Offset = "0x73986C8", VA = "0x739C6C8")]
		public ImmersiveAdConfig()
		{
		}
	}
}
