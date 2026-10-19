using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000012")]
public static class GameStatistic
{
	[Token(Token = "0x400005E")]
	[FieldOffset(Offset = "0x0")]
	public static int StartTimePoint;

	[Token(Token = "0x400005F")]
	[FieldOffset(Offset = "0x4")]
	public static int GameStartPlayTime;

	[Token(Token = "0x4000060")]
	[FieldOffset(Offset = "0x8")]
	public static Dictionary<int, int> GameUseItem;

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x3CFFAC0", Offset = "0x3CFBAC0", VA = "0x3CFFAC0")]
	public static void ReportStartMode(string modeName)
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x3CFFB2C", Offset = "0x3CFBB2C", VA = "0x3CFFB2C")]
	public static void ReportEndMode()
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x3CFFB94", Offset = "0x3CFBB94", VA = "0x3CFFB94")]
	public static void AddGameUseItem(int itemId, int num)
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x3CFFD4C", Offset = "0x3CFBD4C", VA = "0x3CFFD4C")]
	public static void ReportGameUseItem(string modelName, int levelId)
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x3D00190", Offset = "0x3CFC190", VA = "0x3D00190")]
	public static void ReportGameEvents(ReportGameEvent gameEvent, string modelName, int levelId, int gold = 0)
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x3D007C4", Offset = "0x3CFC7C4", VA = "0x3D007C4")]
	public static void ReportActivityEvents(ReportActivityEvent ae, string activityName, string activity_param = "", string activity_mode1 = "", string activity_mode2 = "")
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x3D00C88", Offset = "0x3CFCC88", VA = "0x3D00C88")]
	public static void ReportItemEvents(ReportItemEvent ie, int itemId, int num, int count, string getway = "")
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x3CFEB94", Offset = "0x3CFAB94", VA = "0x3CFEB94")]
	public static void ReportVideoEvent(VideoEvent videoEvent, string videoID, string reportLable)
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x3CFE9A8", Offset = "0x3CFA9A8", VA = "0x3CFE9A8")]
	public static void ReportVideoEvent(VideoEvent videoEvent, string reportLable)
	{
	}
}
