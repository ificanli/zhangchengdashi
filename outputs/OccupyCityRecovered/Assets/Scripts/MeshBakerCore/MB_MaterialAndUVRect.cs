using System;
using System.Collections.Generic;
using DigitalOpus.MB.Core;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

[Serializable]
[Token(Token = "0x200000F")]
public class MB_MaterialAndUVRect
{
	[Token(Token = "0x4000039")]
	[FieldOffset(Offset = "0x10")]
	public Material material;

	[Token(Token = "0x400003A")]
	[FieldOffset(Offset = "0x18")]
	public Rect atlasRect;

	[Token(Token = "0x400003B")]
	[FieldOffset(Offset = "0x28")]
	public string srcObjName;

	[Token(Token = "0x400003C")]
	[FieldOffset(Offset = "0x30")]
	public int textureArraySliceIdx;

	[Token(Token = "0x400003D")]
	[FieldOffset(Offset = "0x34")]
	public bool allPropsUseSameTiling;

	[Token(Token = "0x400003E")]
	[FieldOffset(Offset = "0x38")]
	[FormerlySerializedAs("sourceMaterialTiling")]
	public Rect allPropsUseSameTiling_sourceMaterialTiling;

	[Token(Token = "0x400003F")]
	[FieldOffset(Offset = "0x48")]
	[FormerlySerializedAs("samplingEncapsulatinRect")]
	public Rect allPropsUseSameTiling_samplingEncapsulatinRect;

	[Token(Token = "0x4000040")]
	[FieldOffset(Offset = "0x58")]
	public Rect propsUseDifferntTiling_srcUVsamplingRect;

	[NonSerialized]
	[Token(Token = "0x4000041")]
	[FieldOffset(Offset = "0x68")]
	public List<GameObject> objectsThatUse;

	[Token(Token = "0x4000042")]
	[FieldOffset(Offset = "0x70")]
	public MB_TextureTilingTreatment tilingTreatment;

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x743C558", Offset = "0x7438558", VA = "0x743C558")]
	public MB_MaterialAndUVRect(Material mat, Rect destRect, bool allPropsUseSameTiling, Rect sourceMaterialTiling, Rect samplingEncapsulatingRect, Rect srcUVsamplingRect, MB_TextureTilingTreatment treatment, string objName)
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x743C630", Offset = "0x7438630", VA = "0x743C630", Slot = "2")]
	public override int GetHashCode()
	{
		return default;
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x743C684", Offset = "0x7438684", VA = "0x743C684", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default;
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x743C820", Offset = "0x7438820", VA = "0x743C820")]
	public Rect GetEncapsulatingRect()
	{
		return default;
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x743C860", Offset = "0x7438860", VA = "0x743C860")]
	public Rect GetMaterialTilingRect()
	{
		return default;
	}
}
