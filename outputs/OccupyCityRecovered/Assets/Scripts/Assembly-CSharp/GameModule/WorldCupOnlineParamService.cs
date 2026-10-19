using System;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x20005ED")]
	public static class WorldCupOnlineParamService
	{
		[Token(Token = "0x40031B5")]
		public const string SwitchKey = "worldCupSwitch";

		[Token(Token = "0x40031B6")]
		public const string OpenTimeKey = "worldCupOpenTime";

		[Token(Token = "0x40031B7")]
		public const string PlayDurationKey = "worldCupDuration";

		[Token(Token = "0x40031B8")]
		public const int DefaultPlayDurationDays = 18;

		[Token(Token = "0x40031B9")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string[] OpenTimeFormats;

		[Token(Token = "0x6001F3F")]
		[Address(RVA = "0x3F02D48", Offset = "0x3EFED48", VA = "0x3F02D48")]
		public static WorldCupActivityWindow Resolve(DateTime now)
		{
			return default;
		}

		[Token(Token = "0x6001F40")]
		[Address(RVA = "0x3F04F00", Offset = "0x3F00F00", VA = "0x3F04F00")]
		private static int ParseDurationDays(string key, int defaultDays)
		{
			return default;
		}

		[Token(Token = "0x6001F41")]
		[Address(RVA = "0x3F05170", Offset = "0x3F01170", VA = "0x3F05170")]
		private static bool TryParseOpenTime(out DateTime openTime)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED WorldCupOnlineParamService.TryParseOpenTime RVA=0x3F05170 Token=0x6001F41");
}
	}
}
