using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000BF")]
public class WarningFilterLogHandler : ILogHandler
{
	[Token(Token = "0x40003F6")]
	[FieldOffset(Offset = "0x10")]
	private readonly ILogHandler defaultHandler;

	[Token(Token = "0x6000406")]
	[Address(RVA = "0x3E39E10", Offset = "0x3E35E10", VA = "0x3E39E10", Slot = "5")]
	public void LogException(Exception exception, UnityEngine.Object context)
	{
	}

	[Token(Token = "0x6000407")]
	[Address(RVA = "0x3E39ECC", Offset = "0x3E35ECC", VA = "0x3E39ECC", Slot = "4")]
	public void LogFormat(LogType logType, UnityEngine.Object context, string format, params object[] args)
	{
	}

	[Token(Token = "0x6000408")]
	[Address(RVA = "0x3E39CF8", Offset = "0x3E35CF8", VA = "0x3E39CF8")]
	public WarningFilterLogHandler()
	{
	}
}
