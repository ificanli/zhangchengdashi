using System.Text.RegularExpressions;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

namespace I2.Loc
{
	[Token(Token = "0x2000DB2")]
	public static class I2Utils
	{
		[Token(Token = "0x4006059")]
		public const string ValidChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789_";

		[Token(Token = "0x400605A")]
		public const string NumberChars = "0123456789";

		[Token(Token = "0x400605B")]
		public const string ValidNameSymbols = ".-_$#@*()[]{}+:?!&',^=<>~`";

		[Token(Token = "0x60054F5")]
		[Address(RVA = "0x4323370", Offset = "0x431F370", VA = "0x4323370")]
		public static string ReverseText(string source)
		{
			return null;
		}

		[Token(Token = "0x60054F6")]
		[Address(RVA = "0x432AC00", Offset = "0x4326C00", VA = "0x432AC00")]
		public static string RemoveNonASCII(string text, bool allowCategory = false)
		{
			return null;
		}

		[Token(Token = "0x60054F7")]
		[Address(RVA = "0x431DDA4", Offset = "0x4319DA4", VA = "0x431DDA4")]
		public static string GetValidTermName(string text, bool allowCategory = false)
		{
			return null;
		}

		[Token(Token = "0x60054F8")]
		[Address(RVA = "0x4322E90", Offset = "0x431EE90", VA = "0x4322E90")]
		public static string SplitLine(string line, int maxCharacters)
		{
			return null;
		}

		[Token(Token = "0x60054F9")]
		[Address(RVA = "0x4322D0C", Offset = "0x431ED0C", VA = "0x4322D0C")]
		public static bool FindNextTag(string line, int iStart, out int tagStart, out int tagEnd)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED I2Utils.FindNextTag RVA=0x4322D0C Token=0x60054F9");
}

		[Token(Token = "0x60054FA")]
		[Address(RVA = "0x432AE24", Offset = "0x4326E24", VA = "0x432AE24")]
		public static string RemoveTags(string text)
		{
			return null;
		}

		[Token(Token = "0x60054FB")]
		[Address(RVA = "0x432AEAC", Offset = "0x4326EAC", VA = "0x432AEAC")]
		public static bool RemoveResourcesPath(ref string sPath)
		{
			return default;
		}

		[Token(Token = "0x60054FC")]
		[Address(RVA = "0x431D7B4", Offset = "0x43197B4", VA = "0x431D7B4")]
		public static bool IsPlaying()
		{
			return default;
		}

		[Token(Token = "0x60054FD")]
		[Address(RVA = "0x432B138", Offset = "0x4327138", VA = "0x432B138")]
		public static string GetPath(this Transform tr)
		{
			return null;
		}

		[Token(Token = "0x60054FE")]
		[Address(RVA = "0x432B208", Offset = "0x4327208", VA = "0x432B208")]
		public static Transform FindObject(string objectPath)
		{
			return null;
		}

		[Token(Token = "0x60054FF")]
		[Address(RVA = "0x432B268", Offset = "0x4327268", VA = "0x432B268")]
		public static Transform FindObject(Scene scene, string objectPath)
		{
			return null;
		}

		[Token(Token = "0x6005500")]
		[Address(RVA = "0x432B3A8", Offset = "0x43273A8", VA = "0x432B3A8")]
		public static Transform FindObject(Transform root, string objectPath)
		{
			return null;
		}

		[Token(Token = "0x6005501")]
		public static H FindInParents<H>(Transform tr) where H : Component
		{
			return null;
		}

		[Token(Token = "0x6005502")]
		[Address(RVA = "0x432B4D0", Offset = "0x43274D0", VA = "0x432B4D0")]
		public static string GetCaptureMatch(Match match)
		{
			return null;
		}

		[Token(Token = "0x6005503")]
		[Address(RVA = "0x432B57C", Offset = "0x432757C", VA = "0x432B57C")]
		public static void SendWebRequest(UnityWebRequest www)
		{
		}
	}
}
