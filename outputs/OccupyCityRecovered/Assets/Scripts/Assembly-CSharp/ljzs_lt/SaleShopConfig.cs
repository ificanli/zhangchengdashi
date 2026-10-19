using System;
using Beebyte.Obfuscator;
using GameFramework;
using Il2CppDummyDll;

namespace ljzs_lt
{
	[Serializable]
	[Token(Token = "0x2000F3A")]
	[Skip]
	public class SaleShopConfig : BaseConfig
	{
		[Token(Token = "0x400696B")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		[Token(Token = "0x400696C")]
		[FieldOffset(Offset = "0x14")]
		public int itemType;

		[Token(Token = "0x400696D")]
		[FieldOffset(Offset = "0x18")]
		public int item;

		[Token(Token = "0x400696E")]
		[FieldOffset(Offset = "0x1C")]
		public int count;

		[Token(Token = "0x400696F")]
		[FieldOffset(Offset = "0x20")]
		public int buyItem;

		[Token(Token = "0x4006970")]
		[FieldOffset(Offset = "0x24")]
		public int buyCount;

		[Token(Token = "0x4006971")]
		[FieldOffset(Offset = "0x28")]
		public string saleTag;

		[Token(Token = "0x4006972")]
		[FieldOffset(Offset = "0x30")]
		public int weight;

		[Token(Token = "0x17000F65")]
		public override object UniqueID
		{
			[Token(Token = "0x6005B2E")]
			[Address(RVA = "0x439B624", Offset = "0x4397624", VA = "0x439B624", Slot = "4")]
			get
			{
				return id;
			}
		}

		[Token(Token = "0x6005B2F")]
		[Address(RVA = "0x439B680", Offset = "0x4397680", VA = "0x439B680")]
		public SaleShopConfig()
		{
		}
	}
}
