using System.Collections.Generic;
using Il2CppDummyDll;

namespace I2.Loc
{
	[Token(Token = "0x2000DC3")]
	internal class RTLFixerTool
	{
		[Token(Token = "0x40060C7")]
		[FieldOffset(Offset = "0x0")]
		internal static bool showTashkeel;

		[Token(Token = "0x40060C8")]
		[FieldOffset(Offset = "0x1")]
		internal static bool useHinduNumbers;

		[Token(Token = "0x6005530")]
		[Address(RVA = "0x432ED04", Offset = "0x432AD04", VA = "0x432ED04")]
		internal static string RemoveTashkeel(string str, out List<TashkeelLocation> tashkeelLocation)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED RTLFixerTool.RemoveTashkeel RVA=0x432ED04 Token=0x6005530");
}

		[Token(Token = "0x6005531")]
		[Address(RVA = "0x432F1F4", Offset = "0x432B1F4", VA = "0x432F1F4")]
		internal static char[] ReturnTashkeel(char[] letters, List<TashkeelLocation> tashkeelLocation)
		{
			return null;
		}

		[Token(Token = "0x6005532")]
		[Address(RVA = "0x432C484", Offset = "0x4328484", VA = "0x432C484")]
		internal static string FixLine(string str)
		{
			return null;
		}

		[Token(Token = "0x6005533")]
		[Address(RVA = "0x432F41C", Offset = "0x432B41C", VA = "0x432F41C")]
		internal static bool IsIgnoredCharacter(char ch)
		{
			return default;
		}

		[Token(Token = "0x6005534")]
		[Address(RVA = "0x432FA18", Offset = "0x432BA18", VA = "0x432FA18")]
		internal static bool IsLeadingLetter(char[] letters, int index)
		{
			return default;
		}

		[Token(Token = "0x6005535")]
		[Address(RVA = "0x432F8D4", Offset = "0x432B8D4", VA = "0x432F8D4")]
		internal static bool IsFinishingLetter(char[] letters, int index)
		{
			return default;
		}

		[Token(Token = "0x6005536")]
		[Address(RVA = "0x432F5A4", Offset = "0x432B5A4", VA = "0x432F5A4")]
		internal static bool IsMiddleLetter(char[] letters, int index)
		{
			return default;
		}

		[Token(Token = "0x6005537")]
		[Address(RVA = "0x432FDF0", Offset = "0x432BDF0", VA = "0x432FDF0")]
		public RTLFixerTool()
		{
		}
	}
}
