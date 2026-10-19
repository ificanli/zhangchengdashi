using System;
using Beebyte.Obfuscator;
using GameFramework;
using Il2CppDummyDll;

namespace ljzs_lt
{
	[Serializable]
	[Token(Token = "0x2000F31")]
	[Skip]
	public class PoolConfigConfig : BaseConfig
	{
		[Token(Token = "0x4006935")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		[Token(Token = "0x4006936")]
		[FieldOffset(Offset = "0x14")]
		public int pool_id;

		[Token(Token = "0x4006937")]
		[FieldOffset(Offset = "0x18")]
		public int itemType1;

		[Token(Token = "0x4006938")]
		[FieldOffset(Offset = "0x1C")]
		public int item1;

		[Token(Token = "0x4006939")]
		[FieldOffset(Offset = "0x20")]
		public int count1;

		[Token(Token = "0x400693A")]
		[FieldOffset(Offset = "0x24")]
		public int itemType2;

		[Token(Token = "0x400693B")]
		[FieldOffset(Offset = "0x28")]
		public int item2;

		[Token(Token = "0x400693C")]
		[FieldOffset(Offset = "0x2C")]
		public int count2;

		[Token(Token = "0x400693D")]
		[FieldOffset(Offset = "0x30")]
		public int weight;

		[Token(Token = "0x17000F5C")]
		public override object UniqueID
		{
			[Token(Token = "0x6005B1C")]
			[Address(RVA = "0x439B2A0", Offset = "0x43972A0", VA = "0x439B2A0", Slot = "4")]
			get
			{
				return id;
			}
		}

		[Token(Token = "0x6005B1D")]
		[Address(RVA = "0x439B2FC", Offset = "0x43972FC", VA = "0x439B2FC")]
		public PoolConfigConfig()
		{
		}
	}
}
