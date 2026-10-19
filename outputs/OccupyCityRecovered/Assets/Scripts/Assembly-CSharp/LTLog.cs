using Il2CppDummyDll;

[Token(Token = "0x2000020")]
public class LTLog
{
	[Token(Token = "0x6000081")]
	[Address(RVA = "0x3D03160", Offset = "0x3CFF160", VA = "0x3D03160")]
	private static string BuildMessage(string message)
	{
		return null;
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x3D031AC", Offset = "0x3CFF1AC", VA = "0x3D031AC")]
	public static void Log(string message)
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x3D03270", Offset = "0x3CFF270", VA = "0x3D03270")]
	public static void LogWarning(string message)
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x3D03334", Offset = "0x3CFF334", VA = "0x3D03334")]
	public static void LogError(string message)
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x3D033F8", Offset = "0x3CFF3F8", VA = "0x3D033F8")]
	public LTLog()
	{
	}
}
