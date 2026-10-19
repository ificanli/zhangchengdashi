using GameFramework.Net.Http;
using Il2CppDummyDll;

namespace CommonGameModule.Email
{
	[Token(Token = "0x2000FF7")]
	public class EmailQueryCountRequest : IRequesData
	{
		[Token(Token = "0x4006C88")]
		[FieldOffset(Offset = "0x10")]
		public string uid;

		[Token(Token = "0x6005FCA")]
		[Address(RVA = "0x440C0C8", Offset = "0x44080C8", VA = "0x440C0C8")]
		public EmailQueryCountRequest()
		{
		}
	}
}
