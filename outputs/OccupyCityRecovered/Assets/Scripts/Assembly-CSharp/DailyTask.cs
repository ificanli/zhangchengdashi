using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x200000C")]
public class DailyTask
{
	[Token(Token = "0x4000040")]
	[FieldOffset(Offset = "0x10")]
	public string taskname;

	[Token(Token = "0x17000005")]
	public DailyTaskStatus Status
	{
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x3CFF22C", Offset = "0x3CFB22C", VA = "0x3CFF22C")]
		get
		{
			return default;
		}
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x3CFF2BC", Offset = "0x3CFB2BC", VA = "0x3CFF2BC")]
		set
		{
		}
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x3CFEF7C", Offset = "0x3CFAF7C", VA = "0x3CFEF7C")]
	public DailyTask()
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x3CFEFD4", Offset = "0x3CFAFD4", VA = "0x3CFEFD4")]
	public DailyTask(string taskname)
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x3CFF180", Offset = "0x3CFB180", VA = "0x3CFF180")]
	public void ForceRefresh()
	{
	}
}
