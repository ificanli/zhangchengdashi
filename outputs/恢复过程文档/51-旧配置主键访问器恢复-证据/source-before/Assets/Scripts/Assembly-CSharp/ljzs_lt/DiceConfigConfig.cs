using System;
using Beebyte.Obfuscator;
using GameFramework;
using Il2CppDummyDll;

namespace ljzs_lt
{
	[Serializable]
	[Token(Token = "0x2000F29")]
	[Skip]
	public class DiceConfigConfig : BaseConfig
	{
		[Token(Token = "0x400690F")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		[Token(Token = "0x4006910")]
		[FieldOffset(Offset = "0x14")]
		public int weight;

		[Token(Token = "0x17000F54")]
		public override object UniqueID
		{
			[Token(Token = "0x6005B0C")]
			[Address(RVA = "0x439AF80", Offset = "0x4396F80", VA = "0x439AF80", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005B0D")]
		[Address(RVA = "0x439AFDC", Offset = "0x4396FDC", VA = "0x439AFDC")]
		public DiceConfigConfig()
		{
		}
	}
}
