using GameModule;
using Il2CppDummyDll;

namespace UIModuleO
{
	[Token(Token = "0x20009E2")]
	public class MysteryAdventureLapRewardPopupData
	{
		[Token(Token = "0x400497C")]
		[FieldOffset(Offset = "0x10")]
		public bool ShowUpgrade;

		[Token(Token = "0x400497D")]
		[FieldOffset(Offset = "0x11")]
		public bool ShowLap;

		[Token(Token = "0x400497E")]
		[FieldOffset(Offset = "0x14")]
		public int LapLevel;

		[Token(Token = "0x400497F")]
		[FieldOffset(Offset = "0x18")]
		public string BonusPercentText;

		[Token(Token = "0x4004980")]
		[FieldOffset(Offset = "0x20")]
		public string LevelUpRewardRaw;

		[Token(Token = "0x4004981")]
		[FieldOffset(Offset = "0x28")]
		public string LapRewardRaw;

		[Token(Token = "0x4004982")]
		[FieldOffset(Offset = "0x30")]
		public int LapRewardCount;

		[Token(Token = "0x4004983")]
		[FieldOffset(Offset = "0x34")]
		public int LapReportLevel;

		[Token(Token = "0x4004984")]
		[FieldOffset(Offset = "0x38")]
		public int LapReportLapCount;

		[Token(Token = "0x4004985")]
		[FieldOffset(Offset = "0x3C")]
		public int LapReportMultiplier;

		[Token(Token = "0x6003AE6")]
		[Address(RVA = "0x41209F8", Offset = "0x411C9F8", VA = "0x41209F8")]
		public static MysteryAdventureLapRewardPopupData FromSegment(MysteryAdventureMoveSegment segment)
		{
			return null;
		}

		[Token(Token = "0x6003AE7")]
		[Address(RVA = "0x4120B78", Offset = "0x411CB78", VA = "0x4120B78")]
		public MysteryAdventureLapRewardPopupData()
		{
		}
	}
}
