using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x20005FD")]
	public static class WorldCupUnlockHelper
	{
		[Token(Token = "0x4003218")]
		public const int RequiredUnlockArenaLevel = 3;

		[Token(Token = "0x6001FC8")]
		[Address(RVA = "0x3F08FD0", Offset = "0x3F04FD0", VA = "0x3F08FD0")]
		public static bool IsPlayerProgressUnlocked()
		{
			return default;
		}

		[Token(Token = "0x6001FC9")]
		[Address(RVA = "0x3F0A88C", Offset = "0x3F0688C", VA = "0x3F0A88C")]
		public static string GetProgressUnlockTip()
		{
			return null;
		}

		[Token(Token = "0x6001FCA")]
		[Address(RVA = "0x3F093B8", Offset = "0x3F053B8", VA = "0x3F093B8")]
		public static bool TryShowProgressUnlockTip()
		{
			return default;
		}
	}
}
