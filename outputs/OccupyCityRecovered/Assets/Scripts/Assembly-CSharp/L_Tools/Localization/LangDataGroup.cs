using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace L_Tools.Localization
{
	[Serializable]
	[Token(Token = "0x2000FBE")]
	public class LangDataGroup
	{
		[Token(Token = "0x4006BAD")]
		[FieldOffset(Offset = "0x10")]
		public List<LangData> Datas;

		[Token(Token = "0x6005E4A")]
		[Address(RVA = "0x43FB944", Offset = "0x43F7944", VA = "0x43FB944")]
		public LangDataGroup()
		{
		}
	}
}
