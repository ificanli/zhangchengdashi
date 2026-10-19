using System;
using Il2CppDummyDll;

namespace L_Tools
{
	[Serializable]
	[Token(Token = "0x2000FA7")]
	public class IntIntKV
	{
		[Token(Token = "0x4006B6F")]
		[FieldOffset(Offset = "0x10")]
		public int k;

		[Token(Token = "0x4006B70")]
		[FieldOffset(Offset = "0x14")]
		public int v;

		[Token(Token = "0x6005DAD")]
		[Address(RVA = "0x43BAFBC", Offset = "0x43B6FBC", VA = "0x43BAFBC")]
		public IntIntKV()
		{
		}

		[Token(Token = "0x6005DAE")]
		[Address(RVA = "0x43BADC4", Offset = "0x43B6DC4", VA = "0x43BADC4")]
		public IntIntKV(int key, int i)
		{
		}
	}
}
