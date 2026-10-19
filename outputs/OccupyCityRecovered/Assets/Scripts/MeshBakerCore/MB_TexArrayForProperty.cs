using System;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x200000B")]
public class MB_TexArrayForProperty
{
	[Token(Token = "0x400002D")]
	[FieldOffset(Offset = "0x10")]
	public string texPropertyName;

	[Token(Token = "0x400002E")]
	[FieldOffset(Offset = "0x18")]
	[NonReorderable]
	public MB_TextureArrayReference[] formats;

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x743BFC0", Offset = "0x7437FC0", VA = "0x743BFC0")]
	public MB_TexArrayForProperty(string name, MB_TextureArrayReference[] texRefs)
	{
	}
}
