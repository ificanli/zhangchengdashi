using System;
using Il2CppDummyDll;

namespace L_Tools.FakeMediation
{
	[Token(Token = "0x2000FC8")]
	internal abstract class FakeClosableAd : FakeAd
	{
		[Token(Token = "0x4006BBE")]
		[FieldOffset(Offset = "0x38")]
		public Action onClose;

		[Token(Token = "0x6005E66")]
		[Address(RVA = "0x43FC1C8", Offset = "0x43F81C8", VA = "0x43FC1C8")]
		protected void Close()
		{
		}

		[Token(Token = "0x6005E67")]
		[Address(RVA = "0x43FC154", Offset = "0x43F8154", VA = "0x43FC154")]
		protected FakeClosableAd()
		{
		}
	}
}
