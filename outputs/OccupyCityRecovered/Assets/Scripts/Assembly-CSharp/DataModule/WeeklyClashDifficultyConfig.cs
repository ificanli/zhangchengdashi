using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000E99")]
	public class WeeklyClashDifficultyConfig : GlobalInfoBase
	{
		[Token(Token = "0x40065BC")]
		[FieldOffset(Offset = "0x18")]
		public int score;

		[Token(Token = "0x40065BD")]
		[FieldOffset(Offset = "0x1C")]
		public int difficultyLevel;

		[Token(Token = "0x40065BE")]
		[FieldOffset(Offset = "0x20")]
		public string battleWinReward;

		[Token(Token = "0x40065BF")]
		[FieldOffset(Offset = "0x28")]
		public string battleLoseReward;

		[Token(Token = "0x60058CE")]
		[Address(RVA = "0x4365DFC", Offset = "0x4361DFC", VA = "0x4365DFC")]
		public WeeklyClashDifficultyConfig()
		{
		}
	}
}
