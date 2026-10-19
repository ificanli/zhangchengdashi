using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x200000C")]
public class MB_MultiMaterialTexArray
{
	[Token(Token = "0x400002F")]
	[FieldOffset(Offset = "0x10")]
	public Material combinedMaterial;

	[Token(Token = "0x4000030")]
	[FieldOffset(Offset = "0x18")]
	[NonReorderable]
	public List<MB_TexArraySlice> slices;

	[Token(Token = "0x4000031")]
	[FieldOffset(Offset = "0x20")]
	[NonReorderable]
	public List<MB_TexArrayForProperty> textureProperties;

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x743C030", Offset = "0x7438030", VA = "0x743C030")]
	public MB_MultiMaterialTexArray()
	{
	}
}
