using System;
using Beebyte.Obfuscator;
using GameFramework;
using Il2CppDummyDll;

namespace ljzs_lt
{
	[Serializable]
	[Token(Token = "0x2000F3E")]
	[Skip]
	public class WordEmojiConfig : BaseConfig
	{
		[Token(Token = "0x4006980")]
		[FieldOffset(Offset = "0x10")]
		public int ID;

		[Token(Token = "0x4006981")]
		[FieldOffset(Offset = "0x18")]
		public string Name;

		[Token(Token = "0x17000F69")]
		public override object UniqueID
		{
			[Token(Token = "0x6005B36")]
			[Address(RVA = "0x439B7B4", Offset = "0x43977B4", VA = "0x439B7B4", Slot = "4")]
			get
			{
				return ID;
			}
		}

		[Token(Token = "0x6005B37")]
		[Address(RVA = "0x439B810", Offset = "0x4397810", VA = "0x439B810")]
		public WordEmojiConfig()
		{
		}
	}
}
