using System;
using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000E8F")]
	public class SeasonConfig : GlobalInfoBase
	{
		[Token(Token = "0x4006583")]
		[FieldOffset(Offset = "0x18")]
		public int seasonIndex;

		[Token(Token = "0x4006584")]
		[FieldOffset(Offset = "0x20")]
		private DateTime? _startTime;

		[Token(Token = "0x4006585")]
		[FieldOffset(Offset = "0x30")]
		private DateTime? _endTime;

		[Token(Token = "0x4006586")]
		[FieldOffset(Offset = "0x40")]
		private DateTime? _rewardEndTime;

		[Token(Token = "0x60058B8")]
		[Address(RVA = "0x436503C", Offset = "0x436103C", VA = "0x436503C")]
		public string GetLeaderboardId()
		{
			return null;
		}

		[Token(Token = "0x60058B9")]
		[Address(RVA = "0x4365168", Offset = "0x4361168", VA = "0x4365168")]
		public string GetName()
		{
			return null;
		}

		[Token(Token = "0x60058BA")]
		[Address(RVA = "0x4365278", Offset = "0x4361278", VA = "0x4365278")]
		public DateTime GetStartTime()
		{
			return default;
		}

		[Token(Token = "0x60058BB")]
		[Address(RVA = "0x43653BC", Offset = "0x43613BC", VA = "0x43653BC")]
		public DateTime GetEndTime()
		{
			return default;
		}

		[Token(Token = "0x60058BC")]
		[Address(RVA = "0x43654CC", Offset = "0x43614CC", VA = "0x43654CC")]
		public DateTime GetRewardEndTime()
		{
			return default;
		}

		[Token(Token = "0x60058BD")]
		[Address(RVA = "0x43655DC", Offset = "0x43615DC", VA = "0x43655DC")]
		public SeasonConfig()
		{
		}
	}
}
