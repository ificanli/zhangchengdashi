using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	[Token(Token = "0x2000D85")]
	public class LocalizationReader
	{
		[Token(Token = "0x60053A0")]
		[Address(RVA = "0x431B398", Offset = "0x4317398", VA = "0x431B398")]
		public static Dictionary<string, string> ReadTextAsset(TextAsset asset)
		{
			return null;
		}

		[Token(Token = "0x60053A1")]
		[Address(RVA = "0x431B618", Offset = "0x4317618", VA = "0x431B618")]
		public static bool TextAsset_ReadLine(string line, out string key, out string value, out string category, out string comment, out string termType)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED LocalizationReader.TextAsset_ReadLine RVA=0x431B618 Token=0x60053A1");
}

		[Token(Token = "0x60053A2")]
		[Address(RVA = "0x431B9F4", Offset = "0x43179F4", VA = "0x431B9F4")]
		public static string ReadCSVfile(string Path, Encoding encoding)
		{
			return null;
		}

		[Token(Token = "0x60053A3")]
		[Address(RVA = "0x431BC28", Offset = "0x4317C28", VA = "0x431BC28")]
		public static List<string[]> ReadCSV(string Text, char Separator = ',')
		{
			return null;
		}

		[Token(Token = "0x60053A4")]
		[Address(RVA = "0x431BD50", Offset = "0x4317D50", VA = "0x431BD50")]
		private static string[] ParseCSVline(string Line, ref int iStart, char Separator)
		{
			return null;
		}

		[Token(Token = "0x60053A5")]
		[Address(RVA = "0x431BF34", Offset = "0x4317F34", VA = "0x431BF34")]
		private static void AddCSVtoken(ref List<string> list, ref string Line, int iEnd, ref int iWordStart)
		{
		}

		[Token(Token = "0x60053A6")]
		[Address(RVA = "0x431C0B4", Offset = "0x43180B4", VA = "0x431C0B4")]
		public static List<string[]> ReadI2CSV(string Text)
		{
			return null;
		}

		[Token(Token = "0x60053A7")]
		[Address(RVA = "0x431B968", Offset = "0x4317968", VA = "0x431B968")]
		public static void ValidateFullTerm(ref string Term)
		{
		}

		[Token(Token = "0x60053A8")]
		[Address(RVA = "0x431C284", Offset = "0x4318284", VA = "0x431C284")]
		public static string EncodeString(string str)
		{
			return null;
		}

		[Token(Token = "0x60053A9")]
		[Address(RVA = "0x431B8C0", Offset = "0x43178C0", VA = "0x431B8C0")]
		public static string DecodeString(string str)
		{
			return null;
		}

		[Token(Token = "0x60053AA")]
		[Address(RVA = "0x431C37C", Offset = "0x431837C", VA = "0x431C37C")]
		public LocalizationReader()
		{
		}
	}
}
