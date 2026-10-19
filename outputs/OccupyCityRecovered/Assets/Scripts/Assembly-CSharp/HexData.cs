using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200009B")]
public class HexData
{
	[Token(Token = "0x400031C")]
	[FieldOffset(Offset = "0x10")]
	public string key;

	[Token(Token = "0x400031D")]
	[FieldOffset(Offset = "0x18")]
	private bool hadSetQR;

	[Token(Token = "0x400031E")]
	[FieldOffset(Offset = "0x1C")]
	private int q;

	[Token(Token = "0x400031F")]
	[FieldOffset(Offset = "0x20")]
	private int r;

	[Token(Token = "0x600030A")]
	[Address(RVA = "0x3D278AC", Offset = "0x3D238AC", VA = "0x3D278AC")]
	public void SetKey(Vector3 worldPos)
	{
	}

	[Token(Token = "0x600030B")]
	[Address(RVA = "0x3D27D18", Offset = "0x3D23D18", VA = "0x3D27D18")]
	public Vector3 GetPosition()
	{
		return default;
	}

	[Token(Token = "0x600030C")]
	[Address(RVA = "0x3D27EB8", Offset = "0x3D23EB8", VA = "0x3D27EB8")]
	public HexData()
	{
	}
}
