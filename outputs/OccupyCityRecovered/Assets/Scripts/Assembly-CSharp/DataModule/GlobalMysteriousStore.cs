using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000E72")]
	public class GlobalMysteriousStore : GlobalInfoBase
	{
		[Token(Token = "0x40064B4")]
		[FieldOffset(Offset = "0x18")]
		public string TypeOfMerchandise;

		[Token(Token = "0x40064B5")]
		[FieldOffset(Offset = "0x20")]
		public int Weight;

		[Token(Token = "0x40064B6")]
		[FieldOffset(Offset = "0x24")]
		public int Price;

		[Token(Token = "0x40064B7")]
		[FieldOffset(Offset = "0x28")]
		public int MinCommodityCount;

		[Token(Token = "0x40064B8")]
		[FieldOffset(Offset = "0x2C")]
		public int MaxCommodityCount;

		[Token(Token = "0x40064B9")]
		[FieldOffset(Offset = "0x30")]
		public double MinDiscount;

		[Token(Token = "0x40064BA")]
		[FieldOffset(Offset = "0x38")]
		public double MaxDiscount;

		[Token(Token = "0x6005881")]
		[Address(RVA = "0x4361290", Offset = "0x435D290", VA = "0x4361290")]
		public GlobalMysteriousStore()
		{
		}
	}
}
