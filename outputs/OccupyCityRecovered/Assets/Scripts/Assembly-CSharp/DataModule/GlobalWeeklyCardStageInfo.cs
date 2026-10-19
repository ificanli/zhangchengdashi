using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000E81")]
	public class GlobalWeeklyCardStageInfo : GlobalInfoBase
	{
		[Token(Token = "0x4006520")]
		[FieldOffset(Offset = "0x18")]
		public string reachStageRequire;

		[Token(Token = "0x4006521")]
		[FieldOffset(Offset = "0x20")]
		public string reward;

		[Token(Token = "0x60058A7")]
		[Address(RVA = "0x436485C", Offset = "0x436085C", VA = "0x436485C")]
		public GlobalWeeklyCardStageInfo()
		{
		}
	}
}
