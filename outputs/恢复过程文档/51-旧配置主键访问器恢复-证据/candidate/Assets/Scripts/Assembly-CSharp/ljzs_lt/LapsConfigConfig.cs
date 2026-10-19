using System;
using Beebyte.Obfuscator;
using GameFramework;
using Il2CppDummyDll;

namespace ljzs_lt
{
	[Serializable]
	[Token(Token = "0x2000F2C")]
	[Skip]
	public class LapsConfigConfig : BaseConfig
	{
		[Token(Token = "0x4006919")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		[Token(Token = "0x400691A")]
		[FieldOffset(Offset = "0x14")]
		public int needExp;

		[Token(Token = "0x400691B")]
		[FieldOffset(Offset = "0x18")]
		public int itemType;

		[Token(Token = "0x400691C")]
		[FieldOffset(Offset = "0x1C")]
		public int item;

		[Token(Token = "0x400691D")]
		[FieldOffset(Offset = "0x20")]
		public int count;

		[Token(Token = "0x400691E")]
		[FieldOffset(Offset = "0x24")]
		public int resourcesUp;

		[Token(Token = "0x17000F57")]
		public override object UniqueID
		{
			[Token(Token = "0x6005B12")]
			[Address(RVA = "0x439B0AC", Offset = "0x43970AC", VA = "0x439B0AC", Slot = "4")]
			get
			{
				return id;
			}
		}

		[Token(Token = "0x6005B13")]
		[Address(RVA = "0x439B108", Offset = "0x4397108", VA = "0x439B108")]
		public LapsConfigConfig()
		{
		}
	}
}
