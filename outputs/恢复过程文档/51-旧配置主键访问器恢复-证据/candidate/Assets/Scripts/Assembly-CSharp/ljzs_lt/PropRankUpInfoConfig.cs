using System;
using Beebyte.Obfuscator;
using GameFramework;
using Il2CppDummyDll;

namespace ljzs_lt
{
	[Serializable]
	[Token(Token = "0x2000F36")]
	[Skip]
	public class PropRankUpInfoConfig : BaseConfig
	{
		[Token(Token = "0x400694B")]
		[FieldOffset(Offset = "0x10")]
		public int Level;

		[Token(Token = "0x400694C")]
		[FieldOffset(Offset = "0x14")]
		public int Star;

		[Token(Token = "0x400694D")]
		[FieldOffset(Offset = "0x18")]
		public int Rank;

		[Token(Token = "0x400694E")]
		[FieldOffset(Offset = "0x1C")]
		public int Cost;

		[Token(Token = "0x400694F")]
		[FieldOffset(Offset = "0x20")]
		public float RankUpAttrCurve;

		[Token(Token = "0x4006950")]
		[FieldOffset(Offset = "0x24")]
		public float R;

		[Token(Token = "0x4006951")]
		[FieldOffset(Offset = "0x28")]
		public float SR;

		[Token(Token = "0x4006952")]
		[FieldOffset(Offset = "0x2C")]
		public float SSR;

		[Token(Token = "0x4006953")]
		[FieldOffset(Offset = "0x30")]
		public float SSSR;

		[Token(Token = "0x17000F61")]
		public override object UniqueID
		{
			[Token(Token = "0x6005B26")]
			[Address(RVA = "0x439B494", Offset = "0x4397494", VA = "0x439B494", Slot = "4")]
			get
			{
				return Level;
			}
		}

		[Token(Token = "0x6005B27")]
		[Address(RVA = "0x439B4F0", Offset = "0x43974F0", VA = "0x439B4F0")]
		public PropRankUpInfoConfig()
		{
		}
	}
}
