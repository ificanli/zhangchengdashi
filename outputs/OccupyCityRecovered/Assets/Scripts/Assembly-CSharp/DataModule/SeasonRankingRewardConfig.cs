using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000E91")]
	public class SeasonRankingRewardConfig : GlobalInfoBase
	{
		[Token(Token = "0x4006589")]
		[FieldOffset(Offset = "0x18")]
		public int rankHigh;

		[Token(Token = "0x400658A")]
		[FieldOffset(Offset = "0x1C")]
		public int rankLow;

		[Token(Token = "0x400658B")]
		[FieldOffset(Offset = "0x20")]
		public string weeklyClashRewards;

		[Token(Token = "0x400658C")]
		[FieldOffset(Offset = "0x28")]
		public string seasonRewards;

		[Token(Token = "0x60058BF")]
		[Address(RVA = "0x43655EC", Offset = "0x43615EC", VA = "0x43655EC")]
		public SeasonRankingRewardConfig()
		{
		}
	}
}
