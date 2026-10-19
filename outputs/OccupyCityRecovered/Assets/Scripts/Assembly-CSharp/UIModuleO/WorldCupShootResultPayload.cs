using Il2CppDummyDll;

namespace UIModuleO
{
	[Token(Token = "0x2000688")]
	public class WorldCupShootResultPayload
	{
		[Token(Token = "0x40034C5")]
		[FieldOffset(Offset = "0x10")]
		public WorldCupShootOutcome Outcome;

		[Token(Token = "0x40034C6")]
		[FieldOffset(Offset = "0x14")]
		public bool IsGoal;

		[Token(Token = "0x40034C7")]
		[FieldOffset(Offset = "0x18")]
		public int FootballCost;

		[Token(Token = "0x40034C8")]
		[FieldOffset(Offset = "0x20")]
		public string ExtraRewardRaw;

		[Token(Token = "0x40034C9")]
		[FieldOffset(Offset = "0x28")]
		public int ScoreGain;

		[Token(Token = "0x6002280")]
		[Address(RVA = "0x3F3A850", Offset = "0x3F36850", VA = "0x3F3A850")]
		public WorldCupShootResultPayload()
		{
		}
	}
}
