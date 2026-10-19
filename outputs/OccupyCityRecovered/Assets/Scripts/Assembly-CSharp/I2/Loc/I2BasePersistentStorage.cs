using Il2CppDummyDll;

namespace I2.Loc
{
	[Token(Token = "0x2000D59")]
	public abstract class I2BasePersistentStorage
	{
		[Token(Token = "0x6005295")]
		[Address(RVA = "0x43021F8", Offset = "0x42FE1F8", VA = "0x43021F8", Slot = "4")]
		public virtual void SetSetting_String(string key, string value)
		{
		}

		[Token(Token = "0x6005296")]
		[Address(RVA = "0x4302494", Offset = "0x42FE494", VA = "0x4302494", Slot = "5")]
		public virtual string GetSetting_String(string key, string defaultValue)
		{
			return null;
		}

		[Token(Token = "0x6005297")]
		[Address(RVA = "0x4302710", Offset = "0x42FE710", VA = "0x4302710", Slot = "6")]
		public virtual void DeleteSetting(string key)
		{
		}

		[Token(Token = "0x6005298")]
		[Address(RVA = "0x4302950", Offset = "0x42FE950", VA = "0x4302950", Slot = "7")]
		public virtual void ForceSaveSettings()
		{
		}

		[Token(Token = "0x6005299")]
		[Address(RVA = "0x4302958", Offset = "0x42FE958", VA = "0x4302958", Slot = "8")]
		public virtual bool HasSetting(string key)
		{
			return default;
		}

		[Token(Token = "0x600529A")]
		[Address(RVA = "0x4302964", Offset = "0x42FE964", VA = "0x4302964", Slot = "9")]
		public virtual bool CanAccessFiles()
		{
			return default;
		}

		[Token(Token = "0x600529B")]
		[Address(RVA = "0x430296C", Offset = "0x42FE96C", VA = "0x430296C")]
		private string UpdateFilename(PersistentStorage.eFileType fileType, string fileName)
		{
			return null;
		}

		[Token(Token = "0x600529C")]
		[Address(RVA = "0x4302A58", Offset = "0x42FEA58", VA = "0x4302A58", Slot = "10")]
		public virtual bool SaveFile(PersistentStorage.eFileType fileType, string fileName, string data, bool logExceptions = true)
		{
			return default;
		}

		[Token(Token = "0x600529D")]
		[Address(RVA = "0x4302BCC", Offset = "0x42FEBCC", VA = "0x4302BCC", Slot = "11")]
		public virtual string LoadFile(PersistentStorage.eFileType fileType, string fileName, bool logExceptions = true)
		{
			return null;
		}

		[Token(Token = "0x600529E")]
		[Address(RVA = "0x4302D34", Offset = "0x42FED34", VA = "0x4302D34", Slot = "12")]
		public virtual bool DeleteFile(PersistentStorage.eFileType fileType, string fileName, bool logExceptions = true)
		{
			return default;
		}

		[Token(Token = "0x600529F")]
		[Address(RVA = "0x4302E90", Offset = "0x42FEE90", VA = "0x4302E90", Slot = "13")]
		public virtual bool HasFile(PersistentStorage.eFileType fileType, string fileName, bool logExceptions = true)
		{
			return default;
		}

		[Token(Token = "0x60052A0")]
		[Address(RVA = "0x4302FEC", Offset = "0x42FEFEC", VA = "0x4302FEC")]
		protected I2BasePersistentStorage()
		{
		}
	}
}
