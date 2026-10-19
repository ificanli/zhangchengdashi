using System;
using Beebyte.Obfuscator;
using GameFramework;
using Il2CppDummyDll;

namespace ljzs_lt
{
	[Serializable]
	[Token(Token = "0x2000F3D")]
	[Skip]
	public class TotalDiceConfig : BaseConfig
	{
		[Token(Token = "0x400697A")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		[Token(Token = "0x400697B")]
		[FieldOffset(Offset = "0x14")]
		public int totalCost;

		[Token(Token = "0x400697C")]
		[FieldOffset(Offset = "0x18")]
		public int itemType;

		[Token(Token = "0x400697D")]
		[FieldOffset(Offset = "0x1C")]
		public int item;

		[Token(Token = "0x400697E")]
		[FieldOffset(Offset = "0x20")]
		public int count;

		[Token(Token = "0x400697F")]
		[FieldOffset(Offset = "0x24")]
		public int isBig;

		[Token(Token = "0x17000F68")]
		public override object UniqueID
		{
			[Token(Token = "0x6005B34")]
			[Address(RVA = "0x439B750", Offset = "0x4397750", VA = "0x439B750", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005B35")]
		[Address(RVA = "0x439B7AC", Offset = "0x43977AC", VA = "0x439B7AC")]
		public TotalDiceConfig()
		{
		}
	}
}
