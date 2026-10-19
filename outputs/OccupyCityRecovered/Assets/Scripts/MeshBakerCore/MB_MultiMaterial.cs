using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x2000007")]
public class MB_MultiMaterial
{
	[Token(Token = "0x4000024")]
	[FieldOffset(Offset = "0x10")]
	public Material combinedMaterial;

	[Token(Token = "0x4000025")]
	[FieldOffset(Offset = "0x18")]
	public bool considerMeshUVs;

	[Token(Token = "0x4000026")]
	[FieldOffset(Offset = "0x20")]
	[NonReorderable]
	public List<Material> sourceMaterials;

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x743B910", Offset = "0x7437910", VA = "0x743B910")]
	public MB_MultiMaterial()
	{
	}
}
