using System;
using Beebyte.Obfuscator;
using GameFramework;
using Il2CppDummyDll;

namespace ljzs_lt
{
	[Serializable]
	[Token(Token = "0x2000F40")]
	[Skip]
	public class WorldCupdailyPriceConfig : BaseConfig
	{
		[Token(Token = "0x4006987")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		[Token(Token = "0x4006988")]
		[FieldOffset(Offset = "0x18")]
		public string PriceId;

		[Token(Token = "0x4006989")]
		[FieldOffset(Offset = "0x20")]
		public string PriceName;

		[Token(Token = "0x400698A")]
		[FieldOffset(Offset = "0x28")]
		public int itemType1;

		[Token(Token = "0x400698B")]
		[FieldOffset(Offset = "0x2C")]
		public int item1;

		[Token(Token = "0x400698C")]
		[FieldOffset(Offset = "0x30")]
		public int count1;

		[Token(Token = "0x400698D")]
		[FieldOffset(Offset = "0x34")]
		public int itemType2;

		[Token(Token = "0x400698E")]
		[FieldOffset(Offset = "0x38")]
		public int item2;

		[Token(Token = "0x400698F")]
		[FieldOffset(Offset = "0x3C")]
		public int count2;

		[Token(Token = "0x4006990")]
		[FieldOffset(Offset = "0x40")]
		public int itemType3;

		[Token(Token = "0x4006991")]
		[FieldOffset(Offset = "0x44")]
		public int item3;

		[Token(Token = "0x4006992")]
		[FieldOffset(Offset = "0x48")]
		public int count3;

		[Token(Token = "0x4006993")]
		[FieldOffset(Offset = "0x4C")]
		public int PayLimit;

		[Token(Token = "0x4006994")]
		[FieldOffset(Offset = "0x50")]
		public string saleTag;

		[Token(Token = "0x4006995")]
		[FieldOffset(Offset = "0x58")]
		public int showType;

		[Token(Token = "0x17000F6B")]
		public override object UniqueID
		{
			[Token(Token = "0x6005B3A")]
			[Address(RVA = "0x439B87C", Offset = "0x439787C", VA = "0x439B87C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005B3B")]
		[Address(RVA = "0x439B8D8", Offset = "0x43978D8", VA = "0x439B8D8")]
		public WorldCupdailyPriceConfig()
		{
		}
	}
}
