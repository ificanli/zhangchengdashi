using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001A6")]
internal abstract class _008F_00A9_008B_008DMQ : IEnumerator
{
	[Token(Token = "0x400053C")]
	[FieldOffset(Offset = "0x10")]
	public AssetBundle m_assetBundle;

	[Token(Token = "0x170000D9")]
	public object Current
	{
		[Token(Token = "0x60013CB")]
		[Address(RVA = "0x7362138", Offset = "0x735E138", VA = "0x7362138", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60013CC")]
	[Address(RVA = "0x7362140", Offset = "0x735E140", VA = "0x7362140", Slot = "4")]
	public bool MoveNext()
	{
		return default;
	}

	[Token(Token = "0x60013CD")]
	[Address(RVA = "0x7362160", Offset = "0x735E160", VA = "0x7362160", Slot = "6")]
	public void Reset()
	{
	}

	[Token(Token = "0x60013CE")]
	public abstract bool IsDone();

	[Token(Token = "0x60013CF")]
	public abstract bool IsError();

	[Token(Token = "0x60013D0")]
	public abstract float Progress();

	[Token(Token = "0x60013D1")]
	[Address(RVA = "0x7362164", Offset = "0x735E164", VA = "0x7362164")]
	protected _008F_00A9_008B_008DMQ()
	{
	}
}
