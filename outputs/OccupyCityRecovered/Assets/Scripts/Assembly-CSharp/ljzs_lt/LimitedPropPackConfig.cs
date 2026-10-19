using System;
using Beebyte.Obfuscator;
using GameFramework;
using Il2CppDummyDll;

namespace ljzs_lt
{
	[Serializable]
	[Token(Token = "0x2000F2F")]
	[Skip]
	public class LimitedPropPackConfig : BaseConfig
	{
		[Token(Token = "0x4006926")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		[Token(Token = "0x4006927")]
		[FieldOffset(Offset = "0x18")]
		public string PackDes;

		[Token(Token = "0x4006928")]
		[FieldOffset(Offset = "0x20")]
		public int Benefit;

		[Token(Token = "0x4006929")]
		[FieldOffset(Offset = "0x28")]
		public string PackID;

		[Token(Token = "0x400692A")]
		[FieldOffset(Offset = "0x30")]
		public int Type;

		[Token(Token = "0x400692B")]
		[FieldOffset(Offset = "0x34")]
		public int LimitType;

		[Token(Token = "0x400692C")]
		[FieldOffset(Offset = "0x38")]
		public int DailyCount;

		[Token(Token = "0x400692D")]
		[FieldOffset(Offset = "0x40")]
		public string[] rewards;

		[Token(Token = "0x17000F5A")]
		public override object UniqueID
		{
			[Token(Token = "0x6005B18")]
			[Address(RVA = "0x439B1D8", Offset = "0x43971D8", VA = "0x439B1D8", Slot = "4")]
			get
			{
				return id;
			}
		}

		[Token(Token = "0x6005B19")]
		[Address(RVA = "0x439B234", Offset = "0x4397234", VA = "0x439B234")]
		public LimitedPropPackConfig()
		{
		}
	}
}
