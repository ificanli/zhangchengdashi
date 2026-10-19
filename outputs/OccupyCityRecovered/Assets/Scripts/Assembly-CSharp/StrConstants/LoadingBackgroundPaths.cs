using Il2CppDummyDll;

namespace StrConstants
{
	[Token(Token = "0x200010D")]
	public static class LoadingBackgroundPaths
	{
		[Token(Token = "0x4000E10")]
		private const string LoadingBgSpineBasePath = "Assets/_Res/Addressable/01FirstBundle/Spines/LoadingModule/BG/Loading_Season{0}/LoadingBGSpine_Season{1}.asset";

		[Token(Token = "0x4000E11")]
		private const string LoadingBgSpriteBasePath = "Assets/_Res/Addressable/01FirstBundle/Sprites/LoadingModule/BG/LoadingBG_Season{0}.JPG";

		[Token(Token = "0x4000E12")]
		private const string SeasonPassIconBasePath = "Assets/_Res/Addressable/01FirstBundle/Sprites/MainPanel/SeasonPassBtn/SeasonPassIcon{0}.png";

		[Token(Token = "0x4000E13")]
		private const string SeasonPassIconSpinePath = "Assets/_Res/Addressable/Spine/SeasonPass/SeasonPass{0}/SeasonPassIconSpine.asset";

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x3F7149C", Offset = "0x3F6D49C", VA = "0x3F7149C")]
		public static string GetSeasonBackgroundSpinePath(int seasonNumber)
		{
			return null;
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x3F71534", Offset = "0x3F6D534", VA = "0x3F71534")]
		public static string GetSeasonBackgroundSpritePath(int seasonNumber)
		{
			return null;
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x3F715B4", Offset = "0x3F6D5B4", VA = "0x3F715B4")]
		public static string GetSeasonBackgroundSpineFolderPath(int seasonNumber)
		{
			return null;
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x3F71634", Offset = "0x3F6D634", VA = "0x3F71634")]
		public static string GetSeasonPassIconSpineFolderPath(int seasonNumber)
		{
			return null;
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x3F716B4", Offset = "0x3F6D6B4", VA = "0x3F716B4")]
		public static string GetSeasonPassIconPath(int seasonNumber)
		{
			return null;
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x3F71734", Offset = "0x3F6D734", VA = "0x3F71734")]
		public static string GetSeasonPassIconSpinePath(int seasonNumber)
		{
			return null;
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x3F717B4", Offset = "0x3F6D7B4", VA = "0x3F717B4")]
		public static string GetSeasonPassCharacterIllustrationPath(int seasonNumber)
		{
			return null;
		}
	}
}
