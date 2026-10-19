using System;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x2000600")]
	internal static class WorldCupDailyDateHelper
	{
		[Token(Token = "0x6001FCE")]
		[Address(RVA = "0x3F0ABC0", Offset = "0x3F06BC0", VA = "0x3F0ABC0")]
		public static string GetDateKey()
		{
			return null;
		}

		[Token(Token = "0x6001FCF")]
		[Address(RVA = "0x3F0AC78", Offset = "0x3F06C78", VA = "0x3F0AC78")]
		public static bool ShouldResetForDateChange(string storedDateKey, string newDateKey)
		{
			return default;
		}

		[Token(Token = "0x6001FD0")]
		[Address(RVA = "0x3F0AD54", Offset = "0x3F06D54", VA = "0x3F0AD54")]
		private static bool TryParseDateKey(string dateKey, out DateTime date)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED WorldCupDailyDateHelper.TryParseDateKey RVA=0x3F0AD54 Token=0x6001FD0");
}
	}
}
