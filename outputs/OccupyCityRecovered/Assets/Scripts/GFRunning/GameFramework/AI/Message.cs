using System;
using Il2CppDummyDll;

namespace GameFramework.AI
{
	[Serializable]
	[Token(Token = "0x20004F8")]
	internal class Message
	{
		[Token(Token = "0x4002046")]
		[FieldOffset(Offset = "0x10")]
		public string role;

		[Token(Token = "0x4002047")]
		[FieldOffset(Offset = "0x18")]
		public string content;

		[Token(Token = "0x600756B")]
		[Address(RVA = "0x7309044", Offset = "0x7305044", VA = "0x7309044")]
		public Message()
		{
		}
	}
}
