using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000E5E")]
	public class GlobalCardTalent2Info : GlobalInfoBase
	{
		[Token(Token = "0x400640A")]
		[FieldOffset(Offset = "0x18")]
		public string cardHaveTalent;

		[Token(Token = "0x400640B")]
		[FieldOffset(Offset = "0x20")]
		public string cardEpicTalent;

		[Token(Token = "0x400640C")]
		[FieldOffset(Offset = "0x28")]
		public string cardGoldTalent;

		[Token(Token = "0x6005802")]
		[Address(RVA = "0x435A6BC", Offset = "0x43566BC", VA = "0x435A6BC")]
		public GlobalCardTalent2Info()
		{
		}
	}
}
