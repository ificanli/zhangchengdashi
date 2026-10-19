using System;
using Il2CppDummyDll;

namespace L_Tools
{
	[Serializable]
	[Token(Token = "0x2000F93")]
	public class KeyValues
	{
		[Token(Token = "0x4006B2F")]
		[FieldOffset(Offset = "0x10")]
		public string key;

		[Token(Token = "0x4006B30")]
		[FieldOffset(Offset = "0x18")]
		public string value;

		[Token(Token = "0x6005D5B")]
		[Address(RVA = "0x43B8E0C", Offset = "0x43B4E0C", VA = "0x43B8E0C")]
		public KeyValues(string key, string value = "{}")
		{
		}
	}
}
