using System;
using Beebyte.Obfuscator;
using GameFramework;
using Il2CppDummyDll;

namespace ljzs_lt
{
	[Serializable]
	[Token(Token = "0x2000F22")]
	[Skip]
	public class ChessboardConfig : BaseConfig
	{
		[Token(Token = "0x40068E2")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		[Token(Token = "0x40068E3")]
		[FieldOffset(Offset = "0x14")]
		public int build_id;

		[Token(Token = "0x17000F4D")]
		public override object UniqueID
		{
			[Token(Token = "0x6005AFE")]
			[Address(RVA = "0x439ACC4", Offset = "0x4396CC4", VA = "0x439ACC4", Slot = "4")]
			get
			{
				return id;
			}
		}

		[Token(Token = "0x6005AFF")]
		[Address(RVA = "0x439AD20", Offset = "0x4396D20", VA = "0x439AD20")]
		public ChessboardConfig()
		{
		}
	}
}
