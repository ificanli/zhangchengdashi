using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace GameFramework.AI
{
	[Serializable]
	[Token(Token = "0x20004F4")]
	internal class AIPostData
	{
		[Serializable]
		[Token(Token = "0x20004F5")]
		internal class MessagesData
		{
			[Token(Token = "0x400203B")]
			[FieldOffset(Offset = "0x10")]
			public string role;

			[Token(Token = "0x400203C")]
			[FieldOffset(Offset = "0x18")]
			public string content;

			[Token(Token = "0x6007568")]
			[Address(RVA = "0x730902C", Offset = "0x730502C", VA = "0x730902C")]
			public MessagesData()
			{
			}
		}

		[Token(Token = "0x400203A")]
		[FieldOffset(Offset = "0x10")]
		public List<MessagesData> messages;

		[Token(Token = "0x6007567")]
		[Address(RVA = "0x7309024", Offset = "0x7305024", VA = "0x7309024")]
		public AIPostData()
		{
		}
	}
}
