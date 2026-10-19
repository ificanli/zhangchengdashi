using System;
using Il2CppDummyDll;

namespace L_Tools
{
	[Serializable]
	[Token(Token = "0x2000FAC")]
	public class StringStringKV
	{
		[Token(Token = "0x4006B7A")]
		[FieldOffset(Offset = "0x10")]
		public string k;

		[Token(Token = "0x4006B7B")]
		[FieldOffset(Offset = "0x18")]
		public string v;

		[Token(Token = "0x6005DCF")]
		[Address(RVA = "0x43BCD7C", Offset = "0x43B8D7C", VA = "0x43BCD7C")]
		public StringStringKV()
		{
		}

		[Token(Token = "0x6005DD0")]
		[Address(RVA = "0x43BCA48", Offset = "0x43B8A48", VA = "0x43BCA48")]
		public StringStringKV(string key, string i)
		{
		}
	}
}
