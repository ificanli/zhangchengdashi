using Il2CppDummyDll;

namespace DBTSDK
{
	[Token(Token = "0x20001DF")]
	internal class DynamicLinksData
	{
		[Token(Token = "0x4000679")]
		[FieldOffset(Offset = "0x10")]
		public string title;

		[Token(Token = "0x400067A")]
		[FieldOffset(Offset = "0x18")]
		public string content;

		[Token(Token = "0x400067B")]
		[FieldOffset(Offset = "0x20")]
		public string urlparam;

		[Token(Token = "0x60018C4")]
		[Address(RVA = "0x70A2EB8", Offset = "0x709EEB8", VA = "0x70A2EB8")]
		public DynamicLinksData()
		{
		}
	}
}
