using System.Collections.Generic;
using DigitalOpus.MB.Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000003")]
public class MB_TextureCombinerRenderTexture
{
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x10")]
	public MB2_LogLevel LOG_LEVEL;

	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x18")]
	private Material mat;

	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x20")]
	private RenderTexture _destinationTexture;

	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x28")]
	private Camera myCamera;

	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x30")]
	private int _padding;

	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x34")]
	private bool _isNormalMap;

	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x35")]
	private bool _fixOutOfBoundsUVs;

	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x36")]
	private bool _doRenderAtlas;

	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x38")]
	private Rect[] rs;

	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x40")]
	private List<MB_TexSet> textureSets;

	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x48")]
	private int indexOfTexSetToRender;

	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x50")]
	private ShaderTextureProperty _texPropertyName;

	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x58")]
	private MB3_TextureCombinerNonTextureProperties _resultMaterialTextureBlender;

	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x60")]
	private Texture2D targTex;

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x7439678", Offset = "0x7435678", VA = "0x7439678")]
	public Texture2D DoRenderAtlas(GameObject gameObject, int width, int height, int padding, Rect[] rss, List<MB_TexSet> textureSetss, int indexOfTexSetToRenders, ShaderTextureProperty texPropertyname, MB3_TextureCombinerNonTextureProperties resultMaterialTextureBlender, bool isNormalMap, bool fixOutOfBoundsUVs, bool considerNonTextureProperties, MB3_TextureCombiner texCombiner, MB2_LogLevel LOG_LEV)
	{
		return null;
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x7439D94", Offset = "0x7435D94", VA = "0x7439D94")]
	public void OnRenderObject()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x743AF5C", Offset = "0x7436F5C", VA = "0x743AF5C")]
	public static void ConvertRenderTextureToTexture2D(RenderTexture _destinationTexture, bool yIsFlipped, bool doLinearColorSpace, MB2_LogLevel LOG_LEVEL, Texture2D tempTexture)
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x743B650", Offset = "0x7437650", VA = "0x743B650")]
	private Color32 ConvertNormalFormatFromUnity_ToStandard(Color32 c)
	{
		return default;
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x743A544", Offset = "0x7436544", VA = "0x743A544")]
	public static bool YisFlipped(MB2_LogLevel LOG_LEVEL)
	{
		return default;
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x743A65C", Offset = "0x743665C", VA = "0x743A65C")]
	private void CopyScaledAndTiledToAtlas(MB_TexSet texSet, MeshBakerMaterialTexture source, Vector2 obUVoffset, Vector2 obUVscale, Rect rec, ShaderTextureProperty texturePropertyName, MB3_TextureCombinerNonTextureProperties resultMatTexBlender, bool yIsFlipped)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x743B32C", Offset = "0x743732C", VA = "0x743B32C")]
	private static void _printTexture(Texture2D t)
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x743B7F0", Offset = "0x74377F0", VA = "0x743B7F0")]
	public MB_TextureCombinerRenderTexture()
	{
	}
}
