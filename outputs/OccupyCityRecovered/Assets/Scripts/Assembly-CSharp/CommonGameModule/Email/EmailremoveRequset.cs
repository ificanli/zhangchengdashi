using System.Collections.Generic;
using GameFramework.Net.Http;
using Il2CppDummyDll;

namespace CommonGameModule.Email
{
	[Token(Token = "0x2000FFA")]
	public class EmailremoveRequset : IRequesData
	{
		[Token(Token = "0x4006C8D")]
		[FieldOffset(Offset = "0x10")]
		public string uid;

		[Token(Token = "0x4006C8E")]
		[FieldOffset(Offset = "0x18")]
		public List<long> list;

		[Token(Token = "0x6005FCD")]
		[Address(RVA = "0x440C0E0", Offset = "0x44080E0", VA = "0x440C0E0")]
		public EmailremoveRequset()
		{
		}
	}
}
