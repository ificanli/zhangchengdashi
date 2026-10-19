using System;
using Il2CppDummyDll;

namespace L_Tools
{
	[Serializable]
	[Token(Token = "0x2000FAD")]
	public class stringIntKV
	{
		[Token(Token = "0x4006B7C")]
		[FieldOffset(Offset = "0x10")]
		public string n;

		[Token(Token = "0x4006B7D")]
		[FieldOffset(Offset = "0x18")]
		public int v;

		[Token(Token = "0x6005DD1")]
		[Address(RVA = "0x43BCD84", Offset = "0x43B8D84", VA = "0x43BCD84")]
		public stringIntKV()
		{
		}

		[Token(Token = "0x6005DD2")]
		[Address(RVA = "0x43BBB38", Offset = "0x43B7B38", VA = "0x43BBB38")]
		public stringIntKV(string str, int i)
		{
		}
	}
}
