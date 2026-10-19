using Il2CppDummyDll;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Token(Token = "0x200013C")]
	public class TextureBlenderStandardSpecular : TextureBlender
	{
		[Token(Token = "0x200013D")]
		private enum Prop
		{
			[Token(Token = "0x4000502")]
			doColor = 0,
			[Token(Token = "0x4000503")]
			doSpecular = 1,
			[Token(Token = "0x4000504")]
			doEmission = 2,
			[Token(Token = "0x4000505")]
			doBump = 3,
			[Token(Token = "0x4000506")]
			doNone = 4
		}

		[Token(Token = "0x40004E9")]
		[FieldOffset(Offset = "0x0")]
		private static Color NeutralNormalMap;

		[Token(Token = "0x40004EA")]
		[FieldOffset(Offset = "0x10")]
		private TextureBlenderMaterialPropertyCacheHelper sourceMaterialPropertyCache;

		[Token(Token = "0x40004EB")]
		[FieldOffset(Offset = "0x18")]
		private Color m_tintColor;

		[Token(Token = "0x40004EC")]
		[FieldOffset(Offset = "0x28")]
		private bool m_doScaleAlphaCutoff;

		[Token(Token = "0x40004ED")]
		[FieldOffset(Offset = "0x2C")]
		private float m_alphaCutoff;

		[Token(Token = "0x40004EE")]
		[FieldOffset(Offset = "0x30")]
		private float m_glossiness;

		[Token(Token = "0x40004EF")]
		[FieldOffset(Offset = "0x34")]
		private float m_SpecGlossMapScale;

		[Token(Token = "0x40004F0")]
		[FieldOffset(Offset = "0x38")]
		private Color m_specColor;

		[Token(Token = "0x40004F1")]
		[FieldOffset(Offset = "0x48")]
		private bool m_hasSpecGlossMap;

		[Token(Token = "0x40004F2")]
		[FieldOffset(Offset = "0x4C")]
		private float m_bumpScale;

		[Token(Token = "0x40004F3")]
		[FieldOffset(Offset = "0x50")]
		private bool m_shaderDoesEmission;

		[Token(Token = "0x40004F4")]
		[FieldOffset(Offset = "0x54")]
		private Color m_emissionColor;

		[Token(Token = "0x40004F5")]
		[FieldOffset(Offset = "0x64")]
		private Prop propertyToDo;

		[Token(Token = "0x40004F6")]
		[FieldOffset(Offset = "0x68")]
		private Color m_generatingTintedAtlaColor;

		[Token(Token = "0x40004F7")]
		[FieldOffset(Offset = "0x78")]
		private Color m_generatingTintedAtlaSpecular;

		[Token(Token = "0x40004F8")]
		[FieldOffset(Offset = "0x88")]
		private float m_generatingTintedAtlaGlossiness;

		[Token(Token = "0x40004F9")]
		[FieldOffset(Offset = "0x8C")]
		private float m_generatingTintedAtlaSpecGlossMapScale;

		[Token(Token = "0x40004FA")]
		[FieldOffset(Offset = "0x90")]
		private float m_generatingTintedAtlaBumpScale;

		[Token(Token = "0x40004FB")]
		[FieldOffset(Offset = "0x94")]
		private Color m_generatingTintedAtlaEmission;

		[Token(Token = "0x40004FC")]
		private const float m_generatedAlphaCutoff = 0.5f;

		[Token(Token = "0x40004FD")]
		[FieldOffset(Offset = "0xA4")]
		private Color m_notGeneratingAtlasDefaultColor;

		[Token(Token = "0x40004FE")]
		[FieldOffset(Offset = "0xB4")]
		private Color m_notGeneratingAtlasDefaultSpecularColor;

		[Token(Token = "0x40004FF")]
		[FieldOffset(Offset = "0xC4")]
		private float m_notGeneratingAtlasDefaultGlossiness;

		[Token(Token = "0x4000500")]
		[FieldOffset(Offset = "0xC8")]
		private Color m_notGeneratingAtlasDefaultEmisionColor;

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x74BD06C", Offset = "0x74B906C", VA = "0x74BD06C", Slot = "4")]
		public bool DoesShaderNameMatch(string shaderName)
		{
			return default;
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x74BD0C0", Offset = "0x74B90C0", VA = "0x74BD0C0", Slot = "5")]
		public void OnBeforeTintTexture(Material sourceMat, string shaderTexturePropertyName)
		{
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x74BD4F4", Offset = "0x74B94F4", VA = "0x74BD4F4", Slot = "6")]
		public Color OnBlendTexturePixel(string propertyToDoshaderPropertyName, Color pixelColor)
		{
			return default;
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x74BD698", Offset = "0x74B9698", VA = "0x74BD698", Slot = "7")]
		public bool NonTexturePropertiesAreEqual(Material a, Material b)
		{
			return default;
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x74BDA34", Offset = "0x74B9A34", VA = "0x74BDA34", Slot = "8")]
		public void SetNonTexturePropertyValuesOnResultMaterial(Material resultMaterial)
		{
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x74BDF54", Offset = "0x74B9F54", VA = "0x74BDF54", Slot = "9")]
		public Color GetColorIfNoTexture(Material mat, ShaderTextureProperty texPropertyName)
		{
			return default;
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x74BE57C", Offset = "0x74BA57C", VA = "0x74BE57C")]
		public TextureBlenderStandardSpecular()
		{
		}
	}
}
