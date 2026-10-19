using System.Collections.Generic;
using Il2CppDummyDll;
using L_Tools;

[Token(Token = "0x200000D")]
public class DailyTaskManager : Singleton<DailyTaskManager>
{
	[Token(Token = "0x4000041")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<string, DailyTask> taskDic;

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x3CFF0C0", Offset = "0x3CFB0C0", VA = "0x3CFF0C0")]
	public void Regiest(DailyTask dailyTask)
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x3CFF45C", Offset = "0x3CFB45C", VA = "0x3CFF45C")]
	public void Regiest(string taskname)
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x3CFF51C", Offset = "0x3CFB51C", VA = "0x3CFF51C")]
	public void CheckAllTaskNewDay()
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x3CFF350", Offset = "0x3CFB350", VA = "0x3CFF350")]
	public void CheckTaskNewDay(DailyTask dailyTask)
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x3CFF668", Offset = "0x3CFB668", VA = "0x3CFF668")]
	public void ResetAllTask()
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x3CFF7C4", Offset = "0x3CFB7C4", VA = "0x3CFF7C4")]
	public bool CheckTaskRefresh(string taskname)
	{
		return default;
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x3CFF864", Offset = "0x3CFB864", VA = "0x3CFF864")]
	public bool CheckTaskRefresh(DailyTask dailyTask)
	{
		return default;
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x3CFF888", Offset = "0x3CFB888", VA = "0x3CFF888")]
	public DailyTaskManager()
	{
	}
}
