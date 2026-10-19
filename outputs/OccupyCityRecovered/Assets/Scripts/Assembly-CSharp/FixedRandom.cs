using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000061")]
public class FixedRandom
{
	[Token(Token = "0x40001FA")]
	[FieldOffset(Offset = "0x10")]
	private string key;

	[Token(Token = "0x40001FB")]
	[FieldOffset(Offset = "0x18")]
	private int min;

	[Token(Token = "0x40001FC")]
	[FieldOffset(Offset = "0x1C")]
	private int max;

	[Token(Token = "0x40001FD")]
	[FieldOffset(Offset = "0x20")]
	private int minValueNum;

	[Token(Token = "0x40001FE")]
	[FieldOffset(Offset = "0x24")]
	private int addValueNum;

	[Token(Token = "0x40001FF")]
	[FieldOffset(Offset = "0x28")]
	private List<int> savedValue;

	[Token(Token = "0x4000200")]
	[FieldOffset(Offset = "0x30")]
	private bool isInit;

	[Token(Token = "0x600023C")]
	[Address(RVA = "0x3D1B6E8", Offset = "0x3D176E8", VA = "0x3D1B6E8")]
	public FixedRandom(string key, int minValueNum, int addValueNum)
	{
	}

	[Token(Token = "0x600023D")]
	[Address(RVA = "0x3D1BB6C", Offset = "0x3D17B6C", VA = "0x3D1BB6C")]
	public int Range(int startvalue, int EndValue)
	{
		return default;
	}

	[Token(Token = "0x600023E")]
	[Address(RVA = "0x3D1B7E8", Offset = "0x3D177E8", VA = "0x3D1B7E8")]
	private void Load()
	{
	}

	[Token(Token = "0x600023F")]
	[Address(RVA = "0x3D1BE64", Offset = "0x3D17E64", VA = "0x3D1BE64")]
	private bool CheckLength()
	{
		return default;
	}

	[Token(Token = "0x6000240")]
	[Address(RVA = "0x3D1BF84", Offset = "0x3D17F84", VA = "0x3D1BF84")]
	private void Save()
	{
	}
}
