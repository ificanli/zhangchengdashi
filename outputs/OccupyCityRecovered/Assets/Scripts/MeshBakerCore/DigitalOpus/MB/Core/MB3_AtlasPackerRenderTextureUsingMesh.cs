using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Token(Token = "0x2000107")]
	public class MB3_AtlasPackerRenderTextureUsingMesh
	{
		[Token(Token = "0x2000108")]
		public class MeshRectInfo
		{
			[Token(Token = "0x40003F3")]
			[FieldOffset(Offset = "0x10")]
			public int vertIdx;

			[Token(Token = "0x40003F4")]
			[FieldOffset(Offset = "0x14")]
			public int triIdx;

			[Token(Token = "0x40003F5")]
			[FieldOffset(Offset = "0x18")]
			public int atlasIdx;

			[Token(Token = "0x60005AF")]
			[Address(RVA = "0x74A0FEC", Offset = "0x749CFEC", VA = "0x74A0FEC")]
			public MeshRectInfo()
			{
			}
		}

		[Token(Token = "0x2000109")]
		public class MeshAtlas
		{
			[Token(Token = "0x60005B0")]
			[Address(RVA = "0x749FE74", Offset = "0x749BE74", VA = "0x749FE74")]
			internal static void BuildAtlas(AtlasPackingResult packedAtlasRects, List<MB_TexSet> distinctMaterialTextures, int propIdx, int atlasSizeX, int atlasSizeY, Mesh m, List<Material> generatedMats, ShaderTextureProperty property, MB3_TextureCombinerPipeline.TexturePipelineData data, MB3_TextureCombiner combiner, MB2_EditorMethodsInterface textureEditorMethods, MB2_LogLevel LOG_LEVEL)
			{
			}

			[Token(Token = "0x60005B1")]
			[Address(RVA = "0x74A12F8", Offset = "0x749D2F8", VA = "0x74A12F8")]
			private static void ConfigureMaterial_DefaultPipeline(Material mt, Texture2D t, bool isSavingAsANormalMapAssetThatWillBeImported, MB2_LogLevel LOG_LEVEL)
			{
			}

			[Token(Token = "0x60005B2")]
			[Address(RVA = "0x74A147C", Offset = "0x749D47C", VA = "0x74A147C")]
			public static MeshRectInfo AddQuad(Rect wldRect, Rect uvRect, List<Vector3> verts, List<Vector2> uvs, List<int> tris)
			{
				return null;
			}

			[Token(Token = "0x60005B3")]
			[Address(RVA = "0x74A0FF4", Offset = "0x749CFF4", VA = "0x74A0FF4")]
			public static void AddNineSlicedRect(Rect atlasRectRaw, float paddingX, float paddingY, Rect srcUVRectt, List<Vector3> verts, List<Vector2> uvs, List<int> tris, float srcTexWidth, float srcTexHeight, string texName)
			{
			}

			[Token(Token = "0x60005B4")]
			[Address(RVA = "0x74A1AE0", Offset = "0x749DAE0", VA = "0x74A1AE0")]
			public MeshAtlas()
			{
			}
		}

		[Token(Token = "0x40003EC")]
		[FieldOffset(Offset = "0x10")]
		public int camMaskLayer;

		[Token(Token = "0x40003ED")]
		[FieldOffset(Offset = "0x14")]
		public int width;

		[Token(Token = "0x40003EE")]
		[FieldOffset(Offset = "0x18")]
		public int height;

		[Token(Token = "0x40003EF")]
		[FieldOffset(Offset = "0x1C")]
		public int padding;

		[Token(Token = "0x40003F0")]
		[FieldOffset(Offset = "0x20")]
		public MB2_LogLevel LOG_LEVEL;

		[Token(Token = "0x40003F1")]
		[FieldOffset(Offset = "0x24")]
		private bool _initialized;

		[Token(Token = "0x40003F2")]
		[FieldOffset(Offset = "0x25")]
		private bool _camSetup;

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x749EC04", Offset = "0x749AC04", VA = "0x749EC04")]
		public void Initialize(int camMaskLayer, int width, int height, int padding, MB2_LogLevel LOG_LEVEL = MB2_LogLevel.info)
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x749EC1C", Offset = "0x749AC1C", VA = "0x749EC1C")]
		internal void SetupCameraGameObject(GameObject camGameObject)
		{
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x74A09E8", Offset = "0x749C9E8", VA = "0x74A09E8")]
		internal Texture2D DoRenderAtlas(GameObject go, int width, int height, bool isNormalMap, ShaderTextureProperty propertyName)
		{
			return null;
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x749FE64", Offset = "0x749BE64", VA = "0x749FE64")]
		public MB3_AtlasPackerRenderTextureUsingMesh()
		{
		}
	}
}
