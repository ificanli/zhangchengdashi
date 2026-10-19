using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000E2D")]
	public class ArenaEnemyBalanceInfo : GlobalInfoBase
	{
		[Token(Token = "0x40062C6")]
		[FieldOffset(Offset = "0x18")]
		public string arnenaID;

		[Token(Token = "0x40062C7")]
		[FieldOffset(Offset = "0x20")]
		public string difficultLevel;

		[Token(Token = "0x40062C8")]
		[FieldOffset(Offset = "0x28")]
		public string weight;

		[Token(Token = "0x40062C9")]
		[FieldOffset(Offset = "0x30")]
		public string arnenaLevel;

		[Token(Token = "0x40062CA")]
		[FieldOffset(Offset = "0x38")]
		public string trophyCount;

		[Token(Token = "0x6005745")]
		[Address(RVA = "0x4350CF8", Offset = "0x434CCF8", VA = "0x4350CF8")]
		public ArenaEnemyBalanceInfo()
		{
		}
	}
}
