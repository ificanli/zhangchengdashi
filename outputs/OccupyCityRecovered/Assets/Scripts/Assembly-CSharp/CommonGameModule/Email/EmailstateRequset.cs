using System.Collections.Generic;
using GameFramework.Net.Http;
using Il2CppDummyDll;

namespace CommonGameModule.Email
{
	[Token(Token = "0x2000FF9")]
	public class EmailstateRequset : IRequesData
	{
		[Token(Token = "0x4006C8B")]
		[FieldOffset(Offset = "0x10")]
		public string uid;

		[Token(Token = "0x4006C8C")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, int> states;

		[Token(Token = "0x6005FCC")]
		[Address(RVA = "0x440C0D8", Offset = "0x44080D8", VA = "0x440C0D8")]
		public EmailstateRequset()
		{
		}
	}
}
