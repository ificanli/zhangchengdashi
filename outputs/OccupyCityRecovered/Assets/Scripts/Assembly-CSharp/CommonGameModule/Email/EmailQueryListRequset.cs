using GameFramework.Net.Http;
using Il2CppDummyDll;

namespace CommonGameModule.Email
{
	[Token(Token = "0x2000FF6")]
	public class EmailQueryListRequset : IRequesData
	{
		[Token(Token = "0x4006C85")]
		[FieldOffset(Offset = "0x10")]
		public string uid;

		[Token(Token = "0x4006C86")]
		[FieldOffset(Offset = "0x18")]
		public int index;

		[Token(Token = "0x4006C87")]
		[FieldOffset(Offset = "0x1C")]
		public int count;

		[Token(Token = "0x6005FC9")]
		[Address(RVA = "0x440C0C0", Offset = "0x44080C0", VA = "0x440C0C0")]
		public EmailQueryListRequset()
		{
		}
	}
}
