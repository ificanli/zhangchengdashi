using Il2CppDummyDll;

namespace DBTSDK
{
	[Token(Token = "0x20001C1")]
	public class SdkDomain
	{
		[Token(Token = "0x40005BB")]
		[FieldOffset(Offset = "0x10")]
		public string biz;

		[Token(Token = "0x40005BC")]
		[FieldOffset(Offset = "0x18")]
		public string domain;

		[Token(Token = "0x40005BD")]
		[FieldOffset(Offset = "0x20")]
		public string accelerate;

		[Token(Token = "0x40005BE")]
		[FieldOffset(Offset = "0x28")]
		public string ip;

		[Token(Token = "0x600154C")]
		[Address(RVA = "0x7385400", Offset = "0x7381400", VA = "0x7385400")]
		public SdkDomain()
		{
		}
	}
}
