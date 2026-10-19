using Il2CppDummyDll;

namespace I2.Loc
{
	[Token(Token = "0x2000D6E")]
	public struct TranslationQuery
	{
		[Token(Token = "0x4005F54")]
		[FieldOffset(Offset = "0x0")]
		public string OrigText;

		[Token(Token = "0x4005F55")]
		[FieldOffset(Offset = "0x8")]
		public string Text;

		[Token(Token = "0x4005F56")]
		[FieldOffset(Offset = "0x10")]
		public string LanguageCode;

		[Token(Token = "0x4005F57")]
		[FieldOffset(Offset = "0x18")]
		public string[] TargetLanguagesCode;

		[Token(Token = "0x4005F58")]
		[FieldOffset(Offset = "0x20")]
		public string[] Results;

		[Token(Token = "0x4005F59")]
		[FieldOffset(Offset = "0x28")]
		public string[] Tags;
	}
}
