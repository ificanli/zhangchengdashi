using System.Collections.Generic;
using Il2CppDummyDll;

namespace I2.Loc
{
	[Token(Token = "0x2000D67")]
	public static class GoogleLanguages
	{
		[Token(Token = "0x2000D68")]
		public struct LanguageCodeDef
		{
			[Token(Token = "0x4005F48")]
			[FieldOffset(Offset = "0x0")]
			public string Code;

			[Token(Token = "0x4005F49")]
			[FieldOffset(Offset = "0x8")]
			public string GoogleCode;

			[Token(Token = "0x4005F4A")]
			[FieldOffset(Offset = "0x10")]
			public bool HasJoinedWords;

			[Token(Token = "0x4005F4B")]
			[FieldOffset(Offset = "0x14")]
			public int PluralRule;
		}

		[Token(Token = "0x4005F47")]
		[FieldOffset(Offset = "0x0")]
		public static Dictionary<string, LanguageCodeDef> mLanguageDef;

		[Token(Token = "0x60052D3")]
		[Address(RVA = "0x43060A0", Offset = "0x43020A0", VA = "0x43060A0")]
		public static string GetLanguageCode(string Filter, bool ShowWarnings = false)
		{
			return null;
		}

		[Token(Token = "0x60052D4")]
		[Address(RVA = "0x43064E4", Offset = "0x43024E4", VA = "0x43064E4")]
		public static List<string> GetLanguagesForDropdown(string Filter, string CodesToExclude)
		{
			return null;
		}

		[Token(Token = "0x60052D5")]
		[Address(RVA = "0x430637C", Offset = "0x430237C", VA = "0x430637C")]
		private static bool LanguageMatchesFilter(string Language, string[] Filters)
		{
			return default;
		}

		[Token(Token = "0x60052D6")]
		[Address(RVA = "0x4306A64", Offset = "0x4302A64", VA = "0x4306A64")]
		public static string GetFormatedLanguageName(string Language)
		{
			return null;
		}

		[Token(Token = "0x60052D7")]
		[Address(RVA = "0x4306BB0", Offset = "0x4302BB0", VA = "0x4306BB0")]
		public static string GetCodedLanguage(string Language, string code)
		{
			return null;
		}

		[Token(Token = "0x60052D8")]
		[Address(RVA = "0x4306C80", Offset = "0x4302C80", VA = "0x4306C80")]
		public static void UnPackCodeFromLanguageName(string CodedLanguage, out string Language, out string code)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED GoogleLanguages.UnPackCodeFromLanguageName RVA=0x4306C80 Token=0x60052D8");
}

		[Token(Token = "0x60052D9")]
		[Address(RVA = "0x4306DDC", Offset = "0x4302DDC", VA = "0x4306DDC")]
		public static string GetGoogleLanguageCode(string InternationalCode)
		{
			return null;
		}

		[Token(Token = "0x60052DA")]
		[Address(RVA = "0x4306FB8", Offset = "0x4302FB8", VA = "0x4306FB8")]
		public static string GetLanguageName(string code, bool useParenthesesForRegion = false, bool allowDiscardRegion = true)
		{
			return null;
		}

		[Token(Token = "0x60052DB")]
		[Address(RVA = "0x43072B0", Offset = "0x43032B0", VA = "0x43072B0")]
		public static List<string> GetAllInternationalCodes()
		{
			return null;
		}

		[Token(Token = "0x60052DC")]
		[Address(RVA = "0x4307544", Offset = "0x4303544", VA = "0x4307544")]
		public static bool LanguageCode_HasJoinedWord(string languageCode)
		{
			return default;
		}

		[Token(Token = "0x60052DD")]
		[Address(RVA = "0x4307704", Offset = "0x4303704", VA = "0x4307704")]
		private static int GetPluralRule(string langCode)
		{
			return default;
		}

		[Token(Token = "0x60052DE")]
		[Address(RVA = "0x43078D8", Offset = "0x43038D8", VA = "0x43078D8")]
		public static bool LanguageHasPluralType(string langCode, string pluralType)
		{
			return default;
		}

		[Token(Token = "0x60052DF")]
		[Address(RVA = "0x4307A98", Offset = "0x4303A98", VA = "0x4307A98")]
		public static ePluralType GetPluralType(string langCode, int n)
		{
			return default;
		}

		[Token(Token = "0x60052E0")]
		[Address(RVA = "0x4308124", Offset = "0x4304124", VA = "0x4308124")]
		public static int GetPluralTestNumber(string langCode, ePluralType pluralType)
		{
			return default;
		}

		[Token(Token = "0x60052E1")]
		[Address(RVA = "0x430810C", Offset = "0x430410C", VA = "0x430810C")]
		private static bool inRange(int amount, int min, int max)
		{
			return default;
		}
	}
}
