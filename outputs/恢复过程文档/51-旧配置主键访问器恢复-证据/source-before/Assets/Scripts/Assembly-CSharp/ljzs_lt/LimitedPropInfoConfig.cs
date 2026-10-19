using System;
using Beebyte.Obfuscator;
using GameFramework;
using Il2CppDummyDll;

namespace ljzs_lt
{
	[Serializable]
	[Token(Token = "0x2000F2D")]
	[Skip]
	public class LimitedPropInfoConfig : BaseConfig
	{
		[Token(Token = "0x400691F")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		[Token(Token = "0x4006920")]
		[FieldOffset(Offset = "0x14")]
		public int Weight;

		[Token(Token = "0x4006921")]
		[FieldOffset(Offset = "0x18")]
		public int ShowWeight;

		[Token(Token = "0x4006922")]
		[FieldOffset(Offset = "0x1C")]
		public int Item;

		[Token(Token = "0x4006923")]
		[FieldOffset(Offset = "0x20")]
		public int Number;

		[Token(Token = "0x17000F58")]
		public override object UniqueID
		{
			[Token(Token = "0x6005B14")]
			[Address(RVA = "0x439B110", Offset = "0x4397110", VA = "0x439B110", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005B15")]
		[Address(RVA = "0x439B16C", Offset = "0x439716C", VA = "0x439B16C")]
		public LimitedPropInfoConfig()
		{
		}
	}
}
