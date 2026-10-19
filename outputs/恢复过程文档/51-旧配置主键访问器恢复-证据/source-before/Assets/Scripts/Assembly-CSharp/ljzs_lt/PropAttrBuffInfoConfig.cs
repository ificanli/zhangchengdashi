using System;
using Beebyte.Obfuscator;
using GameFramework;
using Il2CppDummyDll;

namespace ljzs_lt
{
	[Serializable]
	[Token(Token = "0x2000F32")]
	[Skip]
	public class PropAttrBuffInfoConfig : BaseConfig
	{
		[Token(Token = "0x400693E")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		[Token(Token = "0x400693F")]
		[FieldOffset(Offset = "0x14")]
		public int Rare;

		[Token(Token = "0x4006940")]
		[FieldOffset(Offset = "0x18")]
		public int[] Attr;

		[Token(Token = "0x17000F5D")]
		public override object UniqueID
		{
			[Token(Token = "0x6005B1E")]
			[Address(RVA = "0x439B304", Offset = "0x4397304", VA = "0x439B304", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005B1F")]
		[Address(RVA = "0x439B360", Offset = "0x4397360", VA = "0x439B360")]
		public PropAttrBuffInfoConfig()
		{
		}
	}
}
