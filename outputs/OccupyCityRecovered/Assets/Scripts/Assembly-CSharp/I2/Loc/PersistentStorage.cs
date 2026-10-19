using Il2CppDummyDll;

namespace I2.Loc
{
	[Token(Token = "0x2000D57")]
	public static class PersistentStorage
	{
		[Token(Token = "0x2000D58")]
		public enum eFileType
		{
			[Token(Token = "0x4005F2E")]
			Raw = 0,
			[Token(Token = "0x4005F2F")]
			Persistent = 1,
			[Token(Token = "0x4005F30")]
			Temporal = 2,
			[Token(Token = "0x4005F31")]
			Streaming = 3
		}

		[Token(Token = "0x4005F2C")]
		[FieldOffset(Offset = "0x0")]
		private static I2CustomPersistentStorage mStorage;

		[Token(Token = "0x600528B")]
		[Address(RVA = "0x4301B04", Offset = "0x42FDB04", VA = "0x4301B04")]
		public static void SetSetting_String(string key, string value)
		{
		}

		[Token(Token = "0x600528C")]
		[Address(RVA = "0x4301BC0", Offset = "0x42FDBC0", VA = "0x4301BC0")]
		public static string GetSetting_String(string key, string defaultValue)
		{
			return null;
		}

		[Token(Token = "0x600528D")]
		[Address(RVA = "0x4301C74", Offset = "0x42FDC74", VA = "0x4301C74")]
		public static void DeleteSetting(string key)
		{
		}

		[Token(Token = "0x600528E")]
		[Address(RVA = "0x4301D18", Offset = "0x42FDD18", VA = "0x4301D18")]
		public static bool HasSetting(string key)
		{
			return default;
		}

		[Token(Token = "0x600528F")]
		[Address(RVA = "0x4301DBC", Offset = "0x42FDDBC", VA = "0x4301DBC")]
		public static void ForceSaveSettings()
		{
		}

		[Token(Token = "0x6005290")]
		[Address(RVA = "0x4301E58", Offset = "0x42FDE58", VA = "0x4301E58")]
		public static bool CanAccessFiles()
		{
			return default;
		}

		[Token(Token = "0x6005291")]
		[Address(RVA = "0x4301EF4", Offset = "0x42FDEF4", VA = "0x4301EF4")]
		public static bool SaveFile(eFileType fileType, string fileName, string data, bool logExceptions = true)
		{
			return default;
		}

		[Token(Token = "0x6005292")]
		[Address(RVA = "0x4301FC0", Offset = "0x42FDFC0", VA = "0x4301FC0")]
		public static string LoadFile(eFileType fileType, string fileName, bool logExceptions = true)
		{
			return null;
		}

		[Token(Token = "0x6005293")]
		[Address(RVA = "0x430207C", Offset = "0x42FE07C", VA = "0x430207C")]
		public static bool DeleteFile(eFileType fileType, string fileName, bool logExceptions = true)
		{
			return default;
		}

		[Token(Token = "0x6005294")]
		[Address(RVA = "0x4302138", Offset = "0x42FE138", VA = "0x4302138")]
		public static bool HasFile(eFileType fileType, string fileName, bool logExceptions = true)
		{
			return default;
		}
	}
}
