using System;
using Il2CppDummyDll;

namespace GameFramework
{
	[Serializable]
	[Token(Token = "0x2000339")]
	internal class DomainConfig
	{
		[Token(Token = "0x40019A8")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		[Token(Token = "0x40019A9")]
		[FieldOffset(Offset = "0x18")]
		public string GN;

		[Token(Token = "0x40019AA")]
		[FieldOffset(Offset = "0x20")]
		public string BN;

		[Token(Token = "0x40019AB")]
		[FieldOffset(Offset = "0x28")]
		public string D;

		[Token(Token = "0x40019AC")]
		[FieldOffset(Offset = "0x30")]
		public string TD;

		[Token(Token = "0x40019AD")]
		[FieldOffset(Offset = "0x38")]
		public string RD;

		[Token(Token = "0x6005651")]
		[Address(RVA = "0x7161C8C", Offset = "0x715DC8C", VA = "0x7161C8C")]
		public DomainConfig()
		{
		}
	}
}
