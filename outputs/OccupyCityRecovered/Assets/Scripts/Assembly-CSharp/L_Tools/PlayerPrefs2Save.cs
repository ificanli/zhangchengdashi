using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace L_Tools
{
	[Serializable]
	[Token(Token = "0x2000FAF")]
	public class PlayerPrefs2Save
	{
		[Token(Token = "0x4006B86")]
		[FieldOffset(Offset = "0x10")]
		public string XXX;

		[Token(Token = "0x4006B87")]
		[FieldOffset(Offset = "0x18")]
		public List<StringStringKV> _ssData;

		[Token(Token = "0x4006B88")]
		[FieldOffset(Offset = "0x20")]
		public List<stringIntKV> _siData;

		[Token(Token = "0x6005DF1")]
		[Address(RVA = "0x43F7748", Offset = "0x43F3748", VA = "0x43F7748")]
		public PlayerPrefs2Save()
		{
		}
	}
}
