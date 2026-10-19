using Il2CppDummyDll;

namespace DBTSDK
{
	[Token(Token = "0x20001C2")]
	public class CDNDomain
	{
		[Token(Token = "0x40005BF")]
		[FieldOffset(Offset = "0x10")]
		public string cdn_key;

		[Token(Token = "0x40005C0")]
		[FieldOffset(Offset = "0x18")]
		public string domain;

		[Token(Token = "0x600154D")]
		[Address(RVA = "0x7385408", Offset = "0x7381408", VA = "0x7385408")]
		public CDNDomain()
		{
		}
	}
}
