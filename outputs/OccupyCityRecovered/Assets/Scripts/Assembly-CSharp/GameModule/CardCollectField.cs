using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x200056A")]
	public class CardCollectField
	{
		[Token(Token = "0x4002FE4")]
		[FieldOffset(Offset = "0x10")]
		public string card_name;

		[Token(Token = "0x4002FE5")]
		[FieldOffset(Offset = "0x18")]
		public int card_level;

		[Token(Token = "0x4002FE6")]
		[FieldOffset(Offset = "0x1C")]
		public int quantity;

		[Token(Token = "0x4002FE7")]
		[FieldOffset(Offset = "0x20")]
		public bool can_be_upgraded;

		[Token(Token = "0x6001BEE")]
		[Address(RVA = "0x3EC8000", Offset = "0x3EC4000", VA = "0x3EC8000")]
		public CardCollectField()
		{
		}
	}
}
