using System.Collections.Generic;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x200052B")]
	public class MysteryAdventureMoveSegment
	{
		[Token(Token = "0x4002E6E")]
		[FieldOffset(Offset = "0x10")]
		public int FromCellId;

		[Token(Token = "0x4002E6F")]
		[FieldOffset(Offset = "0x18")]
		public List<int> PathCellIds;

		[Token(Token = "0x4002E70")]
		[FieldOffset(Offset = "0x20")]
		public string StatusHint;

		[Token(Token = "0x4002E71")]
		[FieldOffset(Offset = "0x28")]
		public string LapRewardConfigRaw;

		[Token(Token = "0x4002E72")]
		[FieldOffset(Offset = "0x30")]
		public int LapRewardCount;

		[Token(Token = "0x4002E73")]
		[FieldOffset(Offset = "0x34")]
		public int LapReportLevel;

		[Token(Token = "0x4002E74")]
		[FieldOffset(Offset = "0x38")]
		public int LapReportLapCount;

		[Token(Token = "0x4002E75")]
		[FieldOffset(Offset = "0x3C")]
		public int LapReportMultiplier;

		[Token(Token = "0x4002E76")]
		[FieldOffset(Offset = "0x40")]
		public MysteryAdventureLapLevelUpPopupInfo LevelUpInfo;

		[Token(Token = "0x6001AD9")]
		[Address(RVA = "0x3EB0F48", Offset = "0x3EACF48", VA = "0x3EB0F48")]
		public MysteryAdventureMoveSegment()
		{
		}
	}
}
