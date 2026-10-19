using System;
using Beebyte.Obfuscator;
using GameFramework;
using Il2CppDummyDll;

namespace ljzs_lt
{
	[Serializable]
	[Token(Token = "0x2000F2B")]
	[Skip]
	public class How2PlayConfig : BaseConfig
	{
		[Token(Token = "0x4006916")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		[Token(Token = "0x4006917")]
		[FieldOffset(Offset = "0x18")]
		public string image;

		[Token(Token = "0x4006918")]
		[FieldOffset(Offset = "0x20")]
		public string des;

		[Token(Token = "0x17000F56")]
		public override object UniqueID
		{
			[Token(Token = "0x6005B10")]
			[Address(RVA = "0x439B048", Offset = "0x4397048", VA = "0x439B048", Slot = "4")]
			get
			{
				return id;
			}
		}

		[Token(Token = "0x6005B11")]
		[Address(RVA = "0x439B0A4", Offset = "0x43970A4", VA = "0x439B0A4")]
		public How2PlayConfig()
		{
		}
	}
}
