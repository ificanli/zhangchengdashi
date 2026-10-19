using GameFramework.Net.Http;
using Il2CppDummyDll;

namespace CommonGameModule.Email
{
	[Token(Token = "0x2000FF8")]
	public class EmailQueryNewRequset : IRequesData
	{
		[Token(Token = "0x4006C89")]
		[FieldOffset(Offset = "0x10")]
		public string uid;

		[Token(Token = "0x4006C8A")]
		[FieldOffset(Offset = "0x18")]
		public string tag;

		[Token(Token = "0x6005FCB")]
		[Address(RVA = "0x440C0D0", Offset = "0x44080D0", VA = "0x440C0D0")]
		public EmailQueryNewRequset()
		{
		}
	}
}
