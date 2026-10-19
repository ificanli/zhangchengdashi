using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x2000510")]
	public struct MysteryAdventureLapsProgressInfo
	{
		[Token(Token = "0x4002DB4")]
		[FieldOffset(Offset = "0x0")]
		public int LapExp;

		[Token(Token = "0x4002DB5")]
		[FieldOffset(Offset = "0x4")]
		public int LapLevel;

		[Token(Token = "0x4002DB6")]
		[FieldOffset(Offset = "0x8")]
		public int CurrentSegmentExp;

		[Token(Token = "0x4002DB7")]
		[FieldOffset(Offset = "0xC")]
		public int RequiredSegmentExp;

		[Token(Token = "0x4002DB8")]
		[FieldOffset(Offset = "0x10")]
		public float FillAmount;

		[Token(Token = "0x4002DB9")]
		[FieldOffset(Offset = "0x14")]
		public bool IsMaxLevel;

		[Token(Token = "0x4002DBA")]
		[FieldOffset(Offset = "0x18")]
		public int ResourcesUpPercent;
	}
}
