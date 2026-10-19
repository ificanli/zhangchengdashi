using System;
using Beebyte.Obfuscator;
using GameFramework;
using Il2CppDummyDll;

namespace ljzs_lt
{
	[Serializable]
	[Token(Token = "0x2000F33")]
	[Skip]
	public class PropAttrEnumInfoConfig : BaseConfig
	{
		[Token(Token = "0x4006941")]
		[FieldOffset(Offset = "0x10")]
		public int ID;

		[Token(Token = "0x4006942")]
		[FieldOffset(Offset = "0x14")]
		public int Type;

		[Token(Token = "0x4006943")]
		[FieldOffset(Offset = "0x18")]
		public float UpgradeFactor;

		[Token(Token = "0x4006944")]
		[FieldOffset(Offset = "0x1C")]
		public float RankUpFactor;

		[Token(Token = "0x4006945")]
		[FieldOffset(Offset = "0x20")]
		public float Max;

		[Token(Token = "0x17000F5E")]
		public override object UniqueID
		{
			[Token(Token = "0x6005B20")]
			[Address(RVA = "0x439B368", Offset = "0x4397368", VA = "0x439B368", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005B21")]
		[Address(RVA = "0x439B3C4", Offset = "0x43973C4", VA = "0x439B3C4")]
		public PropAttrEnumInfoConfig()
		{
		}
	}
}
