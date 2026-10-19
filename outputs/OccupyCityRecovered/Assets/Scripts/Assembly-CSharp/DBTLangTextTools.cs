using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000018")]
public class DBTLangTextTools
{
	[Token(Token = "0x4000080")]
	private const string sourceTxt = "Lang/source";

	[Token(Token = "0x4000081")]
	private const string transTxt = "Lang/trans";

	[Token(Token = "0x4000082")]
	private const string unityNewhLine1 = "\r\n";

	[Token(Token = "0x4000083")]
	private const string unityNewhLine2 = "\n";

	[Token(Token = "0x4000084")]
	private const string myNewLine1 = "换行符rn";

	[Token(Token = "0x4000085")]
	private const string myNewLine2 = "换行符n";

	[Token(Token = "0x4000086")]
	[FieldOffset(Offset = "0x0")]
	private static string myNewLine;

	[Token(Token = "0x4000087")]
	[FieldOffset(Offset = "0x8")]
	private static List<string> untranslated;

	[Token(Token = "0x4000088")]
	[FieldOffset(Offset = "0x10")]
	private static Dictionary<string, string> dic;

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x3D01D68", Offset = "0x3CFDD68", VA = "0x3D01D68")]
	private static void BuildDic()
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x3D01EF4", Offset = "0x3CFDEF4", VA = "0x3D01EF4")]
	public static List<string> GetUntranslated()
	{
		return null;
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x3D01F90", Offset = "0x3CFDF90", VA = "0x3D01F90")]
	public static string GetLangText(string source)
	{
		return null;
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x3D02094", Offset = "0x3CFE094", VA = "0x3D02094")]
	public DBTLangTextTools()
	{
	}
}
