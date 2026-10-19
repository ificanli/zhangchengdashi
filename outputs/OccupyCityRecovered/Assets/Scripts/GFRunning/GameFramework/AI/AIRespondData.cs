using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace GameFramework.AI
{
	[Serializable]
	[Token(Token = "0x20004F6")]
	internal class AIRespondData
	{
		[Token(Token = "0x400203D")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		[Token(Token = "0x400203E")]
		[FieldOffset(Offset = "0x18")]
		public string @object;

		[Token(Token = "0x400203F")]
		[FieldOffset(Offset = "0x20")]
		public long created;

		[Token(Token = "0x4002040")]
		[FieldOffset(Offset = "0x28")]
		public string model;

		[Token(Token = "0x4002041")]
		[FieldOffset(Offset = "0x30")]
		public List<CompletionChoice> choices;

		[Token(Token = "0x4002042")]
		[FieldOffset(Offset = "0x38")]
		public Usage usage;

		[Token(Token = "0x6007569")]
		[Address(RVA = "0x7309034", Offset = "0x7305034", VA = "0x7309034")]
		public AIRespondData()
		{
		}
	}
}
