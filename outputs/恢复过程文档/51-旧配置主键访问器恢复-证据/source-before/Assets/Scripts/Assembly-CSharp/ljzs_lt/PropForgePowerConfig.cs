using System;
using Beebyte.Obfuscator;
using GameFramework;
using Il2CppDummyDll;

namespace ljzs_lt
{
	[Serializable]
	[Token(Token = "0x2000F35")]
	[Skip]
	public class PropForgePowerConfig : BaseConfig
	{
		[Token(Token = "0x4006949")]
		[FieldOffset(Offset = "0x10")]
		public int Type;

		[Token(Token = "0x400694A")]
		[FieldOffset(Offset = "0x14")]
		public float Factor;

		[Token(Token = "0x17000F60")]
		public override object UniqueID
		{
			[Token(Token = "0x6005B24")]
			[Address(RVA = "0x439B430", Offset = "0x4397430", VA = "0x439B430", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005B25")]
		[Address(RVA = "0x439B48C", Offset = "0x439748C", VA = "0x439B48C")]
		public PropForgePowerConfig()
		{
		}
	}
}
