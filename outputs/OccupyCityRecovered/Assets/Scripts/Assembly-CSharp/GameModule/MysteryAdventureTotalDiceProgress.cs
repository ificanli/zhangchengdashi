using Il2CppDummyDll;
using ljzs_lt;

namespace GameModule
{
	[Token(Token = "0x2000539")]
	public class MysteryAdventureTotalDiceProgress
	{
		[Token(Token = "0x4002ED5")]
		[FieldOffset(Offset = "0x10")]
		public int Consumed;

		[Token(Token = "0x4002ED6")]
		[FieldOffset(Offset = "0x14")]
		public int PreviousThreshold;

		[Token(Token = "0x4002ED7")]
		[FieldOffset(Offset = "0x18")]
		public int NextThreshold;

		[Token(Token = "0x4002ED8")]
		[FieldOffset(Offset = "0x20")]
		public TotalDiceConfig NextConfig;

		[Token(Token = "0x4002ED9")]
		[FieldOffset(Offset = "0x28")]
		public bool HasClaimable;

		[Token(Token = "0x4002EDA")]
		[FieldOffset(Offset = "0x29")]
		public bool AllClaimed;

		[Token(Token = "0x4002EDB")]
		[FieldOffset(Offset = "0x2C")]
		public int ClaimableCount;

		[Token(Token = "0x6001B18")]
		[Address(RVA = "0x3EB380C", Offset = "0x3EAF80C", VA = "0x3EB380C")]
		public MysteryAdventureTotalDiceProgress()
		{
		}
	}
}
