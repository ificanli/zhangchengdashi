using System;
using Il2CppDummyDll;

namespace L_Tools
{
	[Serializable]
	[Token(Token = "0x2000FA4")]
	public class OnlineParamData
	{
		[Token(Token = "0x4006B62")]
		[FieldOffset(Offset = "0x10")]
		public ABGroupType abGroup;

		[Token(Token = "0x4006B63")]
		[FieldOffset(Offset = "0x18")]
		public string value;

		[Token(Token = "0x6005DA0")]
		[Address(RVA = "0x43BA38C", Offset = "0x43B638C", VA = "0x43BA38C")]
		public OnlineParamData()
		{
		}
	}
}
