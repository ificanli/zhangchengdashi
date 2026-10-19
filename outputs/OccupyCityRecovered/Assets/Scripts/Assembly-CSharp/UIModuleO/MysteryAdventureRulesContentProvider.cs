using System.Collections.Generic;
using Il2CppDummyDll;

namespace UIModuleO
{
	[Token(Token = "0x2000A46")]
	public static class MysteryAdventureRulesContentProvider
	{
		[Token(Token = "0x4004C19")]
		private const int ItemsPerPage = 3;

		[Token(Token = "0x17000949")]
		public static int ItemsPerPageCount
		{
			[Token(Token = "0x6003D68")]
			[Address(RVA = "0x415C9E0", Offset = "0x41589E0", VA = "0x415C9E0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6003D69")]
		[Address(RVA = "0x415C9E8", Offset = "0x41589E8", VA = "0x415C9E8")]
		public static IReadOnlyList<MysteryAdventureRulesEntry> GetRuleEntries()
		{
			return null;
		}

		[Token(Token = "0x6003D6A")]
		[Address(RVA = "0x415CC88", Offset = "0x4158C88", VA = "0x415CC88")]
		public static IReadOnlyList<MysteryAdventureRulesEntry> GetBuildingEntries()
		{
			return null;
		}

		[Token(Token = "0x6003D6B")]
		[Address(RVA = "0x415CFE0", Offset = "0x4158FE0", VA = "0x415CFE0")]
		public static int GetPageCount(IReadOnlyList<MysteryAdventureRulesEntry> entries)
		{
			return default;
		}

		[Token(Token = "0x6003D6C")]
		[Address(RVA = "0x415D148", Offset = "0x4159148", VA = "0x415D148")]
		public static void GetPageSlice(IReadOnlyList<MysteryAdventureRulesEntry> entries, int pageIndex, MysteryAdventureRulesEntry[] buffer)
		{
		}

		[Token(Token = "0x6003D6D")]
		[Address(RVA = "0x415D394", Offset = "0x4159394", VA = "0x415D394")]
		public static string FormatRichText(string title, string description)
		{
			return null;
		}
	}
}
