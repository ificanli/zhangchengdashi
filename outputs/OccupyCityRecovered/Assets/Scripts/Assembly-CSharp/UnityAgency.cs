using System;
using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x200001C")]
public class UnityAgency
{
	[Token(Token = "0x400008B")]
	[FieldOffset(Offset = "0x10")]
	public UME ume;

	[Token(Token = "0x400008C")]
	[FieldOffset(Offset = "0x18")]
	public List<Action> actions1;

	[Token(Token = "0x400008D")]
	[FieldOffset(Offset = "0x20")]
	public List<Action<bool>> actions2;

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x3D025AC", Offset = "0x3CFE5AC", VA = "0x3D025AC")]
	public UnityAgency(UME ume)
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x3D0267C", Offset = "0x3CFE67C", VA = "0x3D0267C")]
	public void Add(Action action)
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x3D0274C", Offset = "0x3CFE74C", VA = "0x3D0274C")]
	public void Add(Action<bool> action)
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x3D0281C", Offset = "0x3CFE81C", VA = "0x3D0281C")]
	public void Remove(Action action)
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x3D028AC", Offset = "0x3CFE8AC", VA = "0x3D028AC")]
	public void Remove(Action<bool> action)
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x3D0293C", Offset = "0x3CFE93C", VA = "0x3D0293C")]
	public void Run()
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x3D02A88", Offset = "0x3CFEA88", VA = "0x3D02A88")]
	public void Run(bool arg)
	{
	}
}
