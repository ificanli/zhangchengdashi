using System;
using Il2CppDummyDll;

namespace DataModule
{
	[Serializable]
	[Token(Token = "0x2000EE4")]
	public class UserDataBase
	{
		[Token(Token = "0x400675A")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		[Token(Token = "0x60059F0")]
		[Address(RVA = "0x4367E04", Offset = "0x4363E04", VA = "0x4367E04")]
		public UserDataBase()
		{
		}
	}
}
