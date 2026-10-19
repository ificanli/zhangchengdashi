using Il2CppDummyDll;

namespace ToolModule.Web
{
	[Token(Token = "0x20001B4")]
	public struct WebResponse
	{
		[Token(Token = "0x4001AFE")]
		[FieldOffset(Offset = "0x0")]
		public bool success;

		[Token(Token = "0x4001AFF")]
		[FieldOffset(Offset = "0x8")]
		public long status;

		[Token(Token = "0x4001B00")]
		[FieldOffset(Offset = "0x10")]
		public string data;

		[Token(Token = "0x4001B01")]
		[FieldOffset(Offset = "0x18")]
		public string error;

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x407BEA8", Offset = "0x4077EA8", VA = "0x407BEA8")]
		public ulong GetInt64()
		{
			return default;
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x407BED4", Offset = "0x4077ED4", VA = "0x407BED4")]
		public int GetInt()
		{
			return default;
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x407BF00", Offset = "0x4077F00", VA = "0x407BF00")]
		public bool GetBool()
		{
			return default;
		}

		[Token(Token = "0x60006FB")]
		public T GetData<T>()
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED WebResponse.GetData RVA= Token=0x60006FB");
}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x407BF80", Offset = "0x4077F80", VA = "0x407BF80")]
		public string GetError()
		{
			return null;
		}
	}
}
