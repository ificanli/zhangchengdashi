using Il2CppDummyDll;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Token(Token = "0x2000138")]
	public class TextureBlenderStandardMetallic : TextureBlender
	{
		[Token(Token = "0x2000139")]
		private enum Prop
		{
			[Token(Token = "0x40004C9")]
			doColor = 0,
			[Token(Token = "0x40004CA")]
			doMetallic = 1,
			[Token(Token = "0x40004CB")]
			doEmission = 2,
			[Token(Token = "0x40004CC")]
			doBump = 3,
			[Token(Token = "0x40004CD")]
			doNone = 4
		}

		[Token(Token = "0x40004B0")]
		[FieldOffset(Offset = "0x0")]
		private static Color NeutralNormalMap;

		[Token(Token = "0x40004B1")]
		[FieldOffset(Offset = "0x10")]
		private TextureBlenderMaterialPropertyCacheHelper sourceMaterialPropertyCache;

		[Token(Token = "0x40004B2")]
		[FieldOffset(Offset = "0x18")]
		private Color m_tintColor;

		[Token(Token = "0x40004B3")]
		[FieldOffset(Offset = "0x28")]
		private bool m_doScaleAlphaCutoff;

		[Token(Token = "0x40004B4")]
		[FieldOffset(Offset = "0x2C")]
		private float m_alphaCutoff;

		[Token(Token = "0x40004B5")]
		[FieldOffset(Offset = "0x30")]
		private float m_glossiness;

		[Token(Token = "0x40004B6")]
		[FieldOffset(Offset = "0x34")]
		private float m_glossMapScale;

		[Token(Token = "0x40004B7")]
		[FieldOffset(Offset = "0x38")]
		private float m_metallic;

		[Token(Token = "0x40004B8")]
		[FieldOffset(Offset = "0x3C")]
		private bool m_hasMetallicGlossMap;

		[Token(Token = "0x40004B9")]
		[FieldOffset(Offset = "0x40")]
		private float m_bumpScale;

		[Token(Token = "0x40004BA")]
		[FieldOffset(Offset = "0x44")]
		private bool m_shaderDoesEmission;

		[Token(Token = "0x40004BB")]
		[FieldOffset(Offset = "0x48")]
		private Color m_emissionColor;

		[Token(Token = "0x40004BC")]
		[FieldOffset(Offset = "0x58")]
		private Prop propertyToDo;

		[Token(Token = "0x40004BD")]
		[FieldOffset(Offset = "0x5C")]
		private Color m_generatingTintedAtlasColor;

		[Token(Token = "0x40004BE")]
		[FieldOffset(Offset = "0x6C")]
		private float m_generatingTintedAtlasMetallic;

		[Token(Token = "0x40004BF")]
		[FieldOffset(Offset = "0x70")]
		private float m_generatingTintedAtlasGlossiness;

		[Token(Token = "0x40004C0")]
		[FieldOffset(Offset = "0x74")]
		private float m_generatingTintedAtlasGlossMapScale;

		[Token(Token = "0x40004C1")]
		[FieldOffset(Offset = "0x78")]
		private float m_generatingTintedAtlasBumpScale;

		[Token(Token = "0x40004C2")]
		[FieldOffset(Offset = "0x7C")]
		private Color m_generatingTintedAtlasEmission;

		[Token(Token = "0x40004C3")]
		private const float m_generatedAlphaCutoff = 0.5f;

		[Token(Token = "0x40004C4")]
		[FieldOffset(Offset = "0x8C")]
		private Color m_notGeneratingAtlasDefaultColor;

		[Token(Token = "0x40004C5")]
		[FieldOffset(Offset = "0x9C")]
		private float m_notGeneratingAtlasDefaultMetallic;

		[Token(Token = "0x40004C6")]
		[FieldOffset(Offset = "0xA0")]
		private float m_notGeneratingAtlasDefaultGlossiness;

		[Token(Token = "0x40004C7")]
		[FieldOffset(Offset = "0xA4")]
		private Color m_notGeneratingAtlasDefaultEmisionColor;

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x74BA544", Offset = "0x74B6544", VA = "0x74BA544", Slot = "4")]
		public bool DoesShaderNameMatch(string shaderName)
		{
			return default;
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x74BA5D0", Offset = "0x74B65D0", VA = "0x74BA5D0", Slot = "5")]
		public void OnBeforeTintTexture(Material sourceMat, string shaderTexturePropertyName)
		{
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x74BA9E8", Offset = "0x74B69E8", VA = "0x74BA9E8", Slot = "6")]
		public Color OnBlendTexturePixel(string propertyToDoshaderPropertyName, Color pixelColor)
		{
			return default;
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x74BAB90", Offset = "0x74B6B90", VA = "0x74BAB90", Slot = "7")]
		public bool NonTexturePropertiesAreEqual(Material a, Material b)
		{
			return default;
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x74BAEF8", Offset = "0x74B6EF8", VA = "0x74BAEF8", Slot = "8")]
		public void SetNonTexturePropertyValuesOnResultMaterial(Material resultMaterial)
		{
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x74BB404", Offset = "0x74B7404", VA = "0x74BB404", Slot = "9")]
		public Color GetColorIfNoTexture(Material mat, ShaderTextureProperty texPropertyName)
		{
			return default;
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x74BBA24", Offset = "0x74B7A24", VA = "0x74BBA24")]
		public TextureBlenderStandardMetallic()
		{
		}
	}
}
