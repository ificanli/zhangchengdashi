using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace ToolModule
{
	[Token(Token = "0x200019A")]
	public static class FontTool
	{
		[Token(Token = "0x4001AB8")]
		[FieldOffset(Offset = "0x0")]
		private static TMP_FontAsset _systemFontAsset;

		[Token(Token = "0x4001AB9")]
		[FieldOffset(Offset = "0x8")]
		private static readonly string[] ChineseKeywords;

		[Token(Token = "0x4001ABA")]
		[FieldOffset(Offset = "0x10")]
		private static readonly string[] JapaneseKeywords;

		[Token(Token = "0x4001ABB")]
		[FieldOffset(Offset = "0x18")]
		private static readonly string[] KoreanKeywords;

		[Token(Token = "0x4001ABC")]
		[FieldOffset(Offset = "0x20")]
		private static readonly string[] ArabicKeywords;

		[Token(Token = "0x4001ABD")]
		[FieldOffset(Offset = "0x28")]
		private static readonly string[] ThaiKeywords;

		[Token(Token = "0x4001ABE")]
		[FieldOffset(Offset = "0x30")]
		private static readonly string[] DefaultKeywords;

		[Token(Token = "0x600068A")]
		[Address(RVA = "0x3F7E1A4", Offset = "0x3F7A1A4", VA = "0x3F7E1A4")]
		public static TMP_FontAsset GetSystemFontAsset()
		{
			return null;
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0x3F7ED38", Offset = "0x3F7AD38", VA = "0x3F7ED38")]
		private static string[] GetFontKeywordsForLanguage()
		{
			return null;
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0x3F7E304", Offset = "0x3F7A304", VA = "0x3F7E304")]
		private static Font LoadOSFont()
		{
			return null;
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0x3F7EEB0", Offset = "0x3F7AEB0", VA = "0x3F7EEB0")]
		private static Font TryCreateFontFromPath(string path)
		{
			return null;
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0x3F7E974", Offset = "0x3F7A974", VA = "0x3F7E974")]
		private static TMP_FontAsset CreateTMPFontAsset(Font sourceFont)
		{
			return null;
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0x3F7EFC0", Offset = "0x3F7AFC0", VA = "0x3F7EFC0")]
		public static void SetSystemFontFallbackForInputField(TMP_InputField inputField)
		{
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0x3F7F1F0", Offset = "0x3F7B1F0", VA = "0x3F7F1F0")]
		public static void SetSystemFontForInputField(TMP_InputField inputField)
		{
		}
	}
}
