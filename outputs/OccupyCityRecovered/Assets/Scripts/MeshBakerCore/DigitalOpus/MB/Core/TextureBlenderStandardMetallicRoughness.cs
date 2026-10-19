using Il2CppDummyDll;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Token(Token = "0x200013A")]
	public class TextureBlenderStandardMetallicRoughness : TextureBlender
	{
		[Token(Token = "0x200013B")]
		private enum Prop
		{
			[Token(Token = "0x40004E3")]
			doColor = 0,
			[Token(Token = "0x40004E4")]
			doMetallic = 1,
			[Token(Token = "0x40004E5")]
			doRoughness = 2,
			[Token(Token = "0x40004E6")]
			doEmission = 3,
			[Token(Token = "0x40004E7")]
			doBump = 4,
			[Token(Token = "0x40004E8")]
			doNone = 5
		}

		[Token(Token = "0x40004CE")]
		[FieldOffset(Offset = "0x0")]
		private static Color NeutralNormalMap;

		[Token(Token = "0x40004CF")]
		[FieldOffset(Offset = "0x10")]
		private TextureBlenderMaterialPropertyCacheHelper sourceMaterialPropertyCache;

		[Token(Token = "0x40004D0")]
		[FieldOffset(Offset = "0x18")]
		private Color m_tintColor;

		[Token(Token = "0x40004D1")]
		[FieldOffset(Offset = "0x28")]
		private float m_roughness;

		[Token(Token = "0x40004D2")]
		[FieldOffset(Offset = "0x2C")]
		private float m_metallic;

		[Token(Token = "0x40004D3")]
		[FieldOffset(Offset = "0x30")]
		private bool m_hasMetallicGlossMap;

		[Token(Token = "0x40004D4")]
		[FieldOffset(Offset = "0x31")]
		private bool m_hasSpecGlossMap;

		[Token(Token = "0x40004D5")]
		[FieldOffset(Offset = "0x34")]
		private float m_bumpScale;

		[Token(Token = "0x40004D6")]
		[FieldOffset(Offset = "0x38")]
		private bool m_shaderDoesEmission;

		[Token(Token = "0x40004D7")]
		[FieldOffset(Offset = "0x3C")]
		private Color m_emissionColor;

		[Token(Token = "0x40004D8")]
		[FieldOffset(Offset = "0x4C")]
		private Prop propertyToDo;

		[Token(Token = "0x40004D9")]
		[FieldOffset(Offset = "0x50")]
		private Color m_generatingTintedAtlasColor;

		[Token(Token = "0x40004DA")]
		[FieldOffset(Offset = "0x60")]
		private float m_generatingTintedAtlasMetallic;

		[Token(Token = "0x40004DB")]
		[FieldOffset(Offset = "0x64")]
		private float m_generatingTintedAtlasRoughness;

		[Token(Token = "0x40004DC")]
		[FieldOffset(Offset = "0x68")]
		private float m_generatingTintedAtlasBumpScale;

		[Token(Token = "0x40004DD")]
		[FieldOffset(Offset = "0x6C")]
		private Color m_generatingTintedAtlasEmission;

		[Token(Token = "0x40004DE")]
		[FieldOffset(Offset = "0x7C")]
		private Color m_notGeneratingAtlasDefaultColor;

		[Token(Token = "0x40004DF")]
		[FieldOffset(Offset = "0x8C")]
		private float m_notGeneratingAtlasDefaultMetallic;

		[Token(Token = "0x40004E0")]
		[FieldOffset(Offset = "0x90")]
		private float m_notGeneratingAtlasDefaultGlossiness;

		[Token(Token = "0x40004E1")]
		[FieldOffset(Offset = "0x94")]
		private Color m_notGeneratingAtlasDefaultEmisionColor;

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x74BBB04", Offset = "0x74B7B04", VA = "0x74BBB04", Slot = "4")]
		public bool DoesShaderNameMatch(string shaderName)
		{
			return default;
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x74BBB58", Offset = "0x74B7B58", VA = "0x74BBB58", Slot = "5")]
		public void OnBeforeTintTexture(Material sourceMat, string shaderTexturePropertyName)
		{
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x74BBF0C", Offset = "0x74B7F0C", VA = "0x74BBF0C", Slot = "6")]
		public Color OnBlendTexturePixel(string propertyToDoshaderPropertyName, Color pixelColor)
		{
			return default;
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x74BC048", Offset = "0x74B8048", VA = "0x74BC048", Slot = "7")]
		public bool NonTexturePropertiesAreEqual(Material a, Material b)
		{
			return default;
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x74BC3E4", Offset = "0x74B83E4", VA = "0x74BC3E4", Slot = "8")]
		public void SetNonTexturePropertyValuesOnResultMaterial(Material resultMaterial)
		{
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x74BC8A8", Offset = "0x74B88A8", VA = "0x74BC8A8", Slot = "9")]
		public Color GetColorIfNoTexture(Material mat, ShaderTextureProperty texPropertyName)
		{
			return default;
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x74BCF84", Offset = "0x74B8F84", VA = "0x74BCF84")]
		public TextureBlenderStandardMetallicRoughness()
		{
		}
	}
}
