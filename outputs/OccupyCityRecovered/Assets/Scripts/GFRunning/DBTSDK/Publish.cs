using Il2CppDummyDll;

namespace DBTSDK
{
	[Token(Token = "0x20001BE")]
	public class Publish
	{
		[Token(Token = "0x40005B2")]
		[FieldOffset(Offset = "0x10")]
		public string keyword;

		[Token(Token = "0x40005B3")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x40005B4")]
		[FieldOffset(Offset = "0x20")]
		public string domain;

		[Token(Token = "0x6001549")]
		[Address(RVA = "0x73853E8", Offset = "0x73813E8", VA = "0x73853E8")]
		public Publish()
		{
		}
	}
}
