using System.Collections.Generic;
using Il2CppDummyDll;

namespace DBT_Adapte
{
	[Token(Token = "0x2000F68")]
	public static class RemoteConfig
	{
		[Token(Token = "0x4006A68")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<string, List<object>> _cfg;

		[Token(Token = "0x4006A69")]
		[FieldOffset(Offset = "0x8")]
		private static bool _isInit;

		[Token(Token = "0x6005C84")]
		[Address(RVA = "0x43B0770", Offset = "0x43AC770", VA = "0x43B0770")]
		public static void Init()
		{
		}

		[Token(Token = "0x6005C85")]
		public static T GetItemOrDefault<T>() where T : class, new()
		{
			return null;
		}

		[Token(Token = "0x6005C86")]
		public static T GetFireBaseObjectValue<T>(string key) where T : class
		{
			return null;
		}

		[Token(Token = "0x6005C87")]
		public static T GetFireBaseValue<T>(string key) where T : struct
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED RemoteConfig.GetFireBaseValue RVA= Token=0x6005C87");
}

		[Token(Token = "0x6005C88")]
		public static List<T> GetAllItems<T>() where T : class, new()
		{
			return null;
		}

		[Token(Token = "0x6005C89")]
		[Address(RVA = "0x43B0E70", Offset = "0x43ACE70", VA = "0x43B0E70")]
		public static List<object> GetAllItems()
		{
			return null;
		}
	}
}
