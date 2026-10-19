using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x200052D")]
	public static class MysteryAdventureOnlineParamService
	{
		[Token(Token = "0x200052E")]
		private readonly struct MysteryAdventureOnlineParamCache
		{
			[Token(Token = "0x17000161")]
			public bool SwitchOn
			{
				[Token(Token = "0x6001AEA")]
				[Address(RVA = "0x3EB1C78", Offset = "0x3EADC78", VA = "0x3EB1C78")]
				[CompilerGenerated]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000162")]
			public DateTime OpenTime
			{
				[Token(Token = "0x6001AEB")]
				[Address(RVA = "0x3EB1C80", Offset = "0x3EADC80", VA = "0x3EB1C80")]
				[CompilerGenerated]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000163")]
			public int DurationDays
			{
				[Token(Token = "0x6001AEC")]
				[Address(RVA = "0x3EB1C88", Offset = "0x3EADC88", VA = "0x3EB1C88")]
				[CompilerGenerated]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000164")]
			public bool IsValid
			{
				[Token(Token = "0x6001AED")]
				[Address(RVA = "0x3EB1C90", Offset = "0x3EADC90", VA = "0x3EB1C90")]
				[CompilerGenerated]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x6001AEE")]
			[Address(RVA = "0x3EB1BA0", Offset = "0x3EADBA0", VA = "0x3EB1BA0")]
			public MysteryAdventureOnlineParamCache(bool switchOn, DateTime openTime, int durationDays, bool isValid)
			{
			}
		}

		[Token(Token = "0x4002E7D")]
		public const string SwitchKey = "dfwSwitch";

		[Token(Token = "0x4002E7E")]
		public const string OpenTimeKey = "dfwOpenTime";

		[Token(Token = "0x4002E7F")]
		public const string DurationKey = "dfwDuration";

		[Token(Token = "0x4002E80")]
		public const int DefaultDurationDays = 7;

		[Token(Token = "0x4002E81")]
		private const int OnlineParamRetryIntervalSeconds = 60;

		[Token(Token = "0x4002E82")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string[] OpenTimeFormats;

		[Token(Token = "0x4002E83")]
		[FieldOffset(Offset = "0x8")]
		private static MysteryAdventureOnlineParamCache _cachedParam;

		[Token(Token = "0x4002E84")]
		[FieldOffset(Offset = "0x20")]
		private static bool _hasCachedParam;

		[Token(Token = "0x4002E85")]
		[FieldOffset(Offset = "0x21")]
		private static bool _isCachedParamFinal;

		[Token(Token = "0x4002E86")]
		[FieldOffset(Offset = "0x28")]
		private static DateTime _nextOnlineParamRetryTime;

		[Token(Token = "0x6001AE1")]
		[Address(RVA = "0x3EB1020", Offset = "0x3EAD020", VA = "0x3EB1020")]
		public static MysteryAdventureOnlineActivityWindow Resolve(DateTime now)
		{
			return default;
		}

		[Token(Token = "0x6001AE2")]
		[Address(RVA = "0x3EB1458", Offset = "0x3EAD458", VA = "0x3EB1458")]
		public static bool IsActivityOpen(DateTime now)
		{
			return default;
		}

		[Token(Token = "0x6001AE3")]
		[Address(RVA = "0x3EB14D8", Offset = "0x3EAD4D8", VA = "0x3EB14D8")]
		private static int ParseDurationDays()
		{
			return default;
		}

		[Token(Token = "0x6001AE4")]
		[Address(RVA = "0x3EB1760", Offset = "0x3EAD760", VA = "0x3EB1760")]
		private static bool TryParseOpenTime(out DateTime openTime)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MysteryAdventureOnlineParamService.TryParseOpenTime RVA=0x3EB1760 Token=0x6001AE4");
}

		[Token(Token = "0x6001AE5")]
		[Address(RVA = "0x3EB11C8", Offset = "0x3EAD1C8", VA = "0x3EB11C8")]
		private static MysteryAdventureOnlineParamCache GetOnlineParamCache(DateTime now)
		{
			return default;
		}

		[Token(Token = "0x6001AE6")]
		[Address(RVA = "0x3EB198C", Offset = "0x3EAD98C", VA = "0x3EB198C")]
		private static MysteryAdventureOnlineParamCache LoadOnlineParamCache()
		{
			return default;
		}

		[Token(Token = "0x6001AE7")]
		[Address(RVA = "0x3EB1AF8", Offset = "0x3EADAF8", VA = "0x3EB1AF8")]
		private static bool IsOnlineParamReady()
		{
			return default;
		}

		[Token(Token = "0x6001AE8")]
		[Address(RVA = "0x3EB13C0", Offset = "0x3EAD3C0", VA = "0x3EB13C0")]
		private static TimeSpan GetMaxDuration(int durationDays)
		{
			return default;
		}
	}
}
