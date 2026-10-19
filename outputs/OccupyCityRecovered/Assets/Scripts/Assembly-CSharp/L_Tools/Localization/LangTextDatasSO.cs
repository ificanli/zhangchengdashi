using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace L_Tools.Localization
{
	[Token(Token = "0x2000FBD")]
	public class LangTextDatasSO : DailiScriptObject<LangTextDatasSO>
	{
		[Token(Token = "0x4006BA9")]
		[FieldOffset(Offset = "0x18")]
		public Font font;

		[Token(Token = "0x4006BAA")]
		[FieldOffset(Offset = "0x20")]
		public TMP_FontAsset tmp_font;

		[Token(Token = "0x4006BAB")]
		[FieldOffset(Offset = "0x28")]
		public TMP_FontAsset tmp_fontUGUI;

		[Token(Token = "0x4006BAC")]
		[FieldOffset(Offset = "0x30")]
		public LangDataGroup LangDataGroup;

		[Token(Token = "0x6005E49")]
		[Address(RVA = "0x43FB8FC", Offset = "0x43F78FC", VA = "0x43FB8FC")]
		public LangTextDatasSO()
		{
		}
	}
}
