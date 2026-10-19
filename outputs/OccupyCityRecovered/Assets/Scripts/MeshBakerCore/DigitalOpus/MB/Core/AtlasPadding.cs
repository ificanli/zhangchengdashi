using System;
using Il2CppDummyDll;

namespace DigitalOpus.MB.Core
{
	[Serializable]
	[Token(Token = "0x20000D0")]
	public struct AtlasPadding
	{
		[Token(Token = "0x40002EA")]
		[FieldOffset(Offset = "0x0")]
		public int topBottom;

		[Token(Token = "0x40002EB")]
		[FieldOffset(Offset = "0x4")]
		public int leftRight;

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x748795C", Offset = "0x748395C", VA = "0x748795C")]
		public AtlasPadding(int p)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED AtlasPadding..ctor RVA=0x748795C Token=0x600044F");
}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x7487964", Offset = "0x7483964", VA = "0x7487964")]
		public AtlasPadding(int px, int py)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED AtlasPadding..ctor RVA=0x7487964 Token=0x6000450");
}
	}
}
