using System;
using Il2CppDummyDll;

namespace GameFramework.AI
{
	[Serializable]
	[Token(Token = "0x20004F9")]
	internal class Usage
	{
		[Token(Token = "0x4002048")]
		[FieldOffset(Offset = "0x10")]
		public int completion_tokens;

		[Token(Token = "0x4002049")]
		[FieldOffset(Offset = "0x14")]
		public int prompt_tokens;

		[Token(Token = "0x400204A")]
		[FieldOffset(Offset = "0x18")]
		public int total_tokens;

		[Token(Token = "0x600756C")]
		[Address(RVA = "0x730904C", Offset = "0x730504C", VA = "0x730904C")]
		public Usage()
		{
		}
	}
}
