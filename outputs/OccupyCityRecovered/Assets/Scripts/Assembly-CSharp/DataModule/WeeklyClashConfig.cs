using System;
using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000E98")]
	public class WeeklyClashConfig : GlobalInfoBase
	{
		[Token(Token = "0x40065B5")]
		[FieldOffset(Offset = "0x18")]
		public int weeklyClashIndex;

		[Token(Token = "0x40065B6")]
		[FieldOffset(Offset = "0x1C")]
		public int weeklyClashIndexInSeason;

		[Token(Token = "0x40065B7")]
		[FieldOffset(Offset = "0x20")]
		public string belongingSeasonId;

		[Token(Token = "0x40065B8")]
		[FieldOffset(Offset = "0x28")]
		private DateTime? _startTime;

		[Token(Token = "0x40065B9")]
		[FieldOffset(Offset = "0x38")]
		private DateTime? _endTime;

		[Token(Token = "0x40065BA")]
		[FieldOffset(Offset = "0x48")]
		private DateTime? _battleStartTime;

		[Token(Token = "0x40065BB")]
		[FieldOffset(Offset = "0x58")]
		private DateTime? _battleEndTime;

		[Token(Token = "0x60058C7")]
		[Address(RVA = "0x436568C", Offset = "0x436168C", VA = "0x436568C")]
		public string GetLeaderboardId()
		{
			return null;
		}

		[Token(Token = "0x60058C8")]
		[Address(RVA = "0x43658CC", Offset = "0x43618CC", VA = "0x43658CC")]
		public string GetName()
		{
			return null;
		}

		[Token(Token = "0x60058C9")]
		[Address(RVA = "0x4365998", Offset = "0x4361998", VA = "0x4365998")]
		public DateTime GetStartTime()
		{
			return default;
		}

		[Token(Token = "0x60058CA")]
		[Address(RVA = "0x4365AF4", Offset = "0x4361AF4", VA = "0x4365AF4")]
		public DateTime GetEndTime()
		{
			return default;
		}

		[Token(Token = "0x60058CB")]
		[Address(RVA = "0x4365C04", Offset = "0x4361C04", VA = "0x4365C04")]
		public DateTime GetBattleStartTime()
		{
			return default;
		}

		[Token(Token = "0x60058CC")]
		[Address(RVA = "0x4365CFC", Offset = "0x4361CFC", VA = "0x4365CFC")]
		public DateTime GetBattleEndTime()
		{
			return default;
		}

		[Token(Token = "0x60058CD")]
		[Address(RVA = "0x4365DF4", Offset = "0x4361DF4", VA = "0x4365DF4")]
		public WeeklyClashConfig()
		{
		}
	}
}
