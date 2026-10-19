using System.Collections.Generic;
using DigitalOpus.MB.Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000004")]
[ExecuteInEditMode]
public class MB3_AtlasPackerRenderTexture : MonoBehaviour
{
	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x20")]
	private MB_TextureCombinerRenderTexture fastRenderer;

	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x28")]
	private bool _doRenderAtlas;

	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x2C")]
	public int width;

	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x30")]
	public int height;

	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0x34")]
	public int padding;

	[Token(Token = "0x4000014")]
	[FieldOffset(Offset = "0x38")]
	public bool isNormalMap;

	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x39")]
	public bool fixOutOfBoundsUVs;

	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x3A")]
	public bool considerNonTextureProperties;

	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0x40")]
	public MB3_TextureCombinerNonTextureProperties resultMaterialTextureBlender;

	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0x48")]
	public Rect[] rects;

	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0x50")]
	public Texture2D tex1;

	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0x58")]
	public List<MB_TexSet> textureSets;

	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0x60")]
	public int indexOfTexSetToRender;

	[Token(Token = "0x400001C")]
	[FieldOffset(Offset = "0x68")]
	public ShaderTextureProperty texPropertyName;

	[Token(Token = "0x400001D")]
	[FieldOffset(Offset = "0x70")]
	public MB2_LogLevel LOG_LEVEL;

	[Token(Token = "0x400001E")]
	[FieldOffset(Offset = "0x78")]
	public Texture2D testTex;

	[Token(Token = "0x400001F")]
	[FieldOffset(Offset = "0x80")]
	public Material testMat;

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x743B800", Offset = "0x7437800", VA = "0x743B800")]
	public Texture2D OnRenderAtlas(MB3_TextureCombiner combiner)
	{
		return null;
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x743B8C4", Offset = "0x74378C4", VA = "0x743B8C4")]
	private void OnRenderObject()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x743B8F0", Offset = "0x74378F0", VA = "0x743B8F0")]
	public MB3_AtlasPackerRenderTexture()
	{
	}
}
