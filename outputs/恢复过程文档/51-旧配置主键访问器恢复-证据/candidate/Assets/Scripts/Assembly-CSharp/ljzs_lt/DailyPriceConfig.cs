using System;
using Beebyte.Obfuscator;
using GameFramework;
using Il2CppDummyDll;

namespace ljzs_lt
{
	[Serializable]
	[Token(Token = "0x2000F27")]
	[Skip]
	public class DailyPriceConfig : BaseConfig
	{
		[Token(Token = "0x40068F7")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		[Token(Token = "0x40068F8")]
		[FieldOffset(Offset = "0x18")]
		public string PriceId;

		[Token(Token = "0x40068F9")]
		[FieldOffset(Offset = "0x20")]
		public string PriceName;

		[Token(Token = "0x40068FA")]
		[FieldOffset(Offset = "0x28")]
		public int itemType1;

		[Token(Token = "0x40068FB")]
		[FieldOffset(Offset = "0x2C")]
		public int item1;

		[Token(Token = "0x40068FC")]
		[FieldOffset(Offset = "0x30")]
		public int count1;

		[Token(Token = "0x40068FD")]
		[FieldOffset(Offset = "0x34")]
		public int itemType2;

		[Token(Token = "0x40068FE")]
		[FieldOffset(Offset = "0x38")]
		public int item2;

		[Token(Token = "0x40068FF")]
		[FieldOffset(Offset = "0x3C")]
		public int count2;

		[Token(Token = "0x4006900")]
		[FieldOffset(Offset = "0x40")]
		public int itemType3;

		[Token(Token = "0x4006901")]
		[FieldOffset(Offset = "0x44")]
		public int item3;

		[Token(Token = "0x4006902")]
		[FieldOffset(Offset = "0x48")]
		public int count3;

		[Token(Token = "0x4006903")]
		[FieldOffset(Offset = "0x4C")]
		public int PayLimit;

		[Token(Token = "0x4006904")]
		[FieldOffset(Offset = "0x50")]
		public string saleTag;

		[Token(Token = "0x4006905")]
		[FieldOffset(Offset = "0x58")]
		public int showType;

		[Token(Token = "0x17000F52")]
		public override object UniqueID
		{
			[Token(Token = "0x6005B08")]
			[Address(RVA = "0x439AEB8", Offset = "0x4396EB8", VA = "0x439AEB8", Slot = "4")]
			get
			{
				return id;
			}
		}

		[Token(Token = "0x6005B09")]
		[Address(RVA = "0x439AF14", Offset = "0x4396F14", VA = "0x439AF14")]
		public DailyPriceConfig()
		{
		}
	}
}
