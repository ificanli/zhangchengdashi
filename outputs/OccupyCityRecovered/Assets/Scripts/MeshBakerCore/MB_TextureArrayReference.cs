using System;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x200000A")]
public class MB_TextureArrayReference
{
	[Token(Token = "0x400002B")]
	[FieldOffset(Offset = "0x10")]
	public string texFromatSetName;

	[Token(Token = "0x400002C")]
	[FieldOffset(Offset = "0x18")]
	public Texture2DArray texArray;

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x743BF94", Offset = "0x7437F94", VA = "0x743BF94")]
	public MB_TextureArrayReference(string formatSetName, Texture2DArray ta)
	{
	}
}
