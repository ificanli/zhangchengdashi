using System.Collections.Generic;
using Il2CppDummyDll;

namespace DBTSDK
{
	[Token(Token = "0x20001BF")]
	public class Game
	{
		[Token(Token = "0x20001C0")]
		public class Domains
		{
			[Token(Token = "0x40005B7")]
			[FieldOffset(Offset = "0x10")]
			public string biz;

			[Token(Token = "0x40005B8")]
			[FieldOffset(Offset = "0x18")]
			public string domain;

			[Token(Token = "0x40005B9")]
			[FieldOffset(Offset = "0x20")]
			public int port;

			[Token(Token = "0x40005BA")]
			[FieldOffset(Offset = "0x28")]
			public string protocol;

			[Token(Token = "0x600154B")]
			[Address(RVA = "0x73853F8", Offset = "0x73813F8", VA = "0x73853F8")]
			public Domains()
			{
			}
		}

		[Token(Token = "0x40005B5")]
		[FieldOffset(Offset = "0x10")]
		public string game_key;

		[Token(Token = "0x40005B6")]
		[FieldOffset(Offset = "0x18")]
		public List<Domains> domains;

		[Token(Token = "0x600154A")]
		[Address(RVA = "0x73853F0", Offset = "0x73813F0", VA = "0x73853F0")]
		public Game()
		{
		}
	}
}
