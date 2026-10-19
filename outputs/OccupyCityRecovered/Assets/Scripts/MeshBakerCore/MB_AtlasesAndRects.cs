using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x2000005")]
public class MB_AtlasesAndRects
{
	[Token(Token = "0x4000020")]
	[FieldOffset(Offset = "0x10")]
	public Texture2D[] atlases;

	[NonSerialized]
	[Token(Token = "0x4000021")]
	[FieldOffset(Offset = "0x18")]
	public List<MB_MaterialAndUVRect> mat2rect_map;

	[Token(Token = "0x4000022")]
	[FieldOffset(Offset = "0x20")]
	public string[] texPropertyNames;

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x743B900", Offset = "0x7437900", VA = "0x743B900")]
	public MB_AtlasesAndRects()
	{
	}
}
