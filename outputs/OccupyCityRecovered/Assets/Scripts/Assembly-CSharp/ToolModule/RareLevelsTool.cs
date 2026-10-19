using Il2CppDummyDll;

namespace ToolModule
{
	[Token(Token = "0x20001A2")]
	public static class RareLevelsTool
	{
		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x3F81C74", Offset = "0x3F7DC74", VA = "0x3F81C74")]
		public static int GetRareLevelInt(string rareLevelStr)
		{
			return default;
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x3F81D90", Offset = "0x3F7DD90", VA = "0x3F81D90")]
		public static string GetRareLevelStr(int rareLevelInt)
		{
			return null;
		}
	}
}
