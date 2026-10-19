using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x2000009")]
public class MB_TexArraySlice
{
	[Token(Token = "0x4000029")]
	[FieldOffset(Offset = "0x10")]
	public bool considerMeshUVs;

	[Token(Token = "0x400002A")]
	[FieldOffset(Offset = "0x18")]
	[NonReorderable]
	public List<MB_TexArraySliceRendererMatPair> sourceMaterials;

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x743B994", Offset = "0x7437994", VA = "0x743B994")]
	public bool ContainsMaterial(Material mat)
	{
		return default;
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x743BA74", Offset = "0x7437A74", VA = "0x743BA74")]
	public HashSet<Material> GetDistinctMaterials()
	{
		return null;
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x743BB68", Offset = "0x7437B68", VA = "0x743BB68")]
	public bool ContainsMaterialAndMesh(Material mat, Mesh mesh)
	{
		return default;
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x743BCA4", Offset = "0x7437CA4", VA = "0x743BCA4")]
	public List<Material> GetAllUsedMaterials(List<Material> usedMats)
	{
		return null;
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x743BDD4", Offset = "0x7437DD4", VA = "0x743BDD4")]
	public List<GameObject> GetAllUsedRenderers(List<GameObject> allObjsFromTextureBaker)
	{
		return null;
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x743BF18", Offset = "0x7437F18", VA = "0x743BF18")]
	public MB_TexArraySlice()
	{
	}
}
