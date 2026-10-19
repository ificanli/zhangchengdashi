using System;
using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000023")]
public class NewGameObjectStack<T> where T : PoolObjectBase
{
	[Token(Token = "0x400009C")]
	[FieldOffset(Offset = "0x0")]
	private T prefab;

	[Token(Token = "0x400009D")]
	[FieldOffset(Offset = "0x0")]
	private readonly Stack<T> m_Stack;

	[Token(Token = "0x400009E")]
	[FieldOffset(Offset = "0x0")]
	private readonly Action<T> m_ActionOnGet;

	[Token(Token = "0x400009F")]
	[FieldOffset(Offset = "0x0")]
	private readonly Action<T> m_ActionOnRelease;

	[Token(Token = "0x40000A0")]
	[FieldOffset(Offset = "0x0")]
	private int PoolID;

	[Token(Token = "0x6000097")]
	public NewGameObjectStack(int PoolID, T objectBase, Action<T> ActionOnGet, Action<T> ActionOnRelease)
	{
	}

	[Token(Token = "0x6000098")]
	public T Get()
	{
		return null;
	}

	[Token(Token = "0x6000099")]
	public void Release(T objectBase)
	{
	}

	[Token(Token = "0x600009A")]
	public void Clear()
	{
	}
}
