using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000EAF")]
	public class WeeklyClashBattleLog
	{
		[Token(Token = "0x400660C")]
		[FieldOffset(Offset = "0x10")]
		public bool isWin;

		[Token(Token = "0x400660D")]
		[FieldOffset(Offset = "0x18")]
		public string difficultyConfigId;

		[Token(Token = "0x400660E")]
		[FieldOffset(Offset = "0x20")]
		public long battleTimestamp;

		[Token(Token = "0x6005920")]
		[Address(RVA = "0x4368D70", Offset = "0x4364D70", VA = "0x4368D70")]
		public WeeklyClashBattleLog()
		{
		}
	}
}
