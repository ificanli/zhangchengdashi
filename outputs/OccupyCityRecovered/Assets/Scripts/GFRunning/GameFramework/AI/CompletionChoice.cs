using System;
using Il2CppDummyDll;

namespace GameFramework.AI
{
	[Serializable]
	[Token(Token = "0x20004F7")]
	internal class CompletionChoice
	{
		[Token(Token = "0x4002043")]
		[FieldOffset(Offset = "0x10")]
		public int index;

		[Token(Token = "0x4002044")]
		[FieldOffset(Offset = "0x18")]
		public string finish_reason;

		[Token(Token = "0x4002045")]
		[FieldOffset(Offset = "0x20")]
		public Message message;

		[Token(Token = "0x600756A")]
		[Address(RVA = "0x730903C", Offset = "0x730503C", VA = "0x730903C")]
		public CompletionChoice()
		{
		}
	}
}
