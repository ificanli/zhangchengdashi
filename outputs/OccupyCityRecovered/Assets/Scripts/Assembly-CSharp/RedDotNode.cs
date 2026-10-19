using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x2000080")]
public class RedDotNode
{
	[Token(Token = "0x4000286")]
	[FieldOffset(Offset = "0x10")]
	public string name;

	[Token(Token = "0x4000287")]
	[FieldOffset(Offset = "0x18")]
	public string redDotClassName;

	[Token(Token = "0x4000288")]
	[FieldOffset(Offset = "0x20")]
	public string collectionClassName;

	[Token(Token = "0x4000289")]
	[FieldOffset(Offset = "0x28")]
	public string varKey;

	[Token(Token = "0x400028A")]
	[FieldOffset(Offset = "0x30")]
	public string comment;

	[Token(Token = "0x400028B")]
	[FieldOffset(Offset = "0x38")]
	public RedDotNode[] children;

	[NonSerialized]
	[Token(Token = "0x400028C")]
	[FieldOffset(Offset = "0x40")]
	public bool isExpanded;

	[Token(Token = "0x60002AA")]
	[Address(RVA = "0x3D22520", Offset = "0x3D1E520", VA = "0x3D22520")]
	public RedDotNode()
	{
	}
}
