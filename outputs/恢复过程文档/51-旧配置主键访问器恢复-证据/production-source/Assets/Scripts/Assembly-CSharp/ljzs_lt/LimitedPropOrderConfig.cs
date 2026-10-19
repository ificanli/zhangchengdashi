using System;
using Beebyte.Obfuscator;
using GameFramework;
using Il2CppDummyDll;

namespace ljzs_lt
{
	[Serializable]
	[Token(Token = "0x2000F2E")]
	[Skip]
	public class LimitedPropOrderConfig : BaseConfig
	{
		[Token(Token = "0x4006924")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		[Token(Token = "0x4006925")]
		[FieldOffset(Offset = "0x14")]
		public int PropID;

		[Token(Token = "0x17000F59")]
		public override object UniqueID
		{
			[Token(Token = "0x6005B16")]
			[Address(RVA = "0x439B174", Offset = "0x4397174", VA = "0x439B174", Slot = "4")]
			get
			{
				return id;
			}
		}

		[Token(Token = "0x6005B17")]
		[Address(RVA = "0x439B1D0", Offset = "0x43971D0", VA = "0x439B1D0")]
		public LimitedPropOrderConfig()
		{
		}
	}
}
