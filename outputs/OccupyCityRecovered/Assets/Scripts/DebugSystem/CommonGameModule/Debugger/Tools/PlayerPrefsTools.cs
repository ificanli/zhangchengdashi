using System;
using Il2CppDummyDll;

namespace CommonGameModule.Debugger.Tools
{
	[Token(Token = "0x200002E")]
	public static class PlayerPrefsTools
	{
		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0x0")]
		private static bool isInit;

		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0x8")]
		private static Type typeUtils_PlayerPrefs;

		[Token(Token = "0x17000020")]
		private static bool IsXYX
		{
			[Token(Token = "0x60000B6")]
			[Address(RVA = "0x463C8B0", Offset = "0x46388B0", VA = "0x463C8B0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x463CA04", Offset = "0x4638A04", VA = "0x463CA04")]
		public static bool HasKey(string key)
		{
			return default;
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x463CB4C", Offset = "0x4638B4C", VA = "0x463CB4C")]
		public static void DeleteKey(string key)
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x463CC54", Offset = "0x4638C54", VA = "0x463CC54")]
		public static void DeleteAll()
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x463CCE0", Offset = "0x4638CE0", VA = "0x463CCE0")]
		public static void SetString(string key, string value)
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x463CE24", Offset = "0x4638E24", VA = "0x463CE24")]
		public static string GetString(string key, string defaultValue = "")
		{
			return null;
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x463CF98", Offset = "0x4638F98", VA = "0x463CF98")]
		public static void SetInt(string key, int value)
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x463D108", Offset = "0x4639108", VA = "0x463D108")]
		public static int GetInt(string key, int defaultValue = 0)
		{
			return default;
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x463D2A0", Offset = "0x46392A0", VA = "0x463D2A0")]
		public static void SetFloat(string key, float value)
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x463D410", Offset = "0x4639410", VA = "0x463D410")]
		public static float GetFloat(string key, float defaultValue = 0f)
		{
			return default;
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x463D5C0", Offset = "0x46395C0", VA = "0x463D5C0")]
		public static void Save()
		{
		}
	}
}
