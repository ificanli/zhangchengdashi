using Il2CppDummyDll;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Token(Token = "0x2000131")]
	public class TextureBlenderHDRPLit : TextureBlender
	{
		[Token(Token = "0x2000132")]
		private enum Prop
		{
			[Token(Token = "0x400049A")]
			doColor = 0,
			[Token(Token = "0x400049B")]
			doMask = 1,
			[Token(Token = "0x400049C")]
			doSpecular = 2,
			[Token(Token = "0x400049D")]
			doEmission = 3,
			[Token(Token = "0x400049E")]
			doNone = 4
		}

		[Token(Token = "0x2000133")]
		private enum MaterialType
		{
			[Token(Token = "0x40004A0")]
			unknown = 0,
			[Token(Token = "0x40004A1")]
			subsurfaceScattering = 1,
			[Token(Token = "0x40004A2")]
			standard = 2,
			[Token(Token = "0x40004A3")]
			anisotropy = 3,
			[Token(Token = "0x40004A4")]
			iridescence = 4,
			[Token(Token = "0x40004A5")]
			specularColor = 5,
			[Token(Token = "0x40004A6")]
			translucent = 6
		}

		[Token(Token = "0x4000487")]
		[FieldOffset(Offset = "0x10")]
		private TextureBlenderMaterialPropertyCacheHelper sourceMaterialPropertyCache;

		[Token(Token = "0x4000488")]
		[FieldOffset(Offset = "0x18")]
		private MaterialType m_materialType;

		[Token(Token = "0x4000489")]
		[FieldOffset(Offset = "0x1C")]
		private Color m_tintColor;

		[Token(Token = "0x400048A")]
		[FieldOffset(Offset = "0x2C")]
		private bool m_hasMaskMap;

		[Token(Token = "0x400048B")]
		[FieldOffset(Offset = "0x30")]
		private float m_smoothness;

		[Token(Token = "0x400048C")]
		[FieldOffset(Offset = "0x34")]
		private float m_metallic;

		[Token(Token = "0x400048D")]
		[FieldOffset(Offset = "0x38")]
		private bool m_hasSpecMap;

		[Token(Token = "0x400048E")]
		[FieldOffset(Offset = "0x3C")]
		private Color m_specularColor;

		[Token(Token = "0x400048F")]
		[FieldOffset(Offset = "0x4C")]
		private Color m_emissiveColor;

		[Token(Token = "0x4000490")]
		[FieldOffset(Offset = "0x5C")]
		private Prop propertyToDo;

		[Token(Token = "0x4000491")]
		[FieldOffset(Offset = "0x60")]
		private Color m_generatingTintedAtlaColor;

		[Token(Token = "0x4000492")]
		[FieldOffset(Offset = "0x70")]
		private Color m_generatingTintedAtlaSpecular;

		[Token(Token = "0x4000493")]
		[FieldOffset(Offset = "0x80")]
		private Color m_generatingTintedAtlaEmission;

		[Token(Token = "0x4000494")]
		[FieldOffset(Offset = "0x90")]
		private Color m_notGeneratingAtlasDefaultColor;

		[Token(Token = "0x4000495")]
		[FieldOffset(Offset = "0xA0")]
		private float m_notGeneratingAtlasDefaultMetallic;

		[Token(Token = "0x4000496")]
		[FieldOffset(Offset = "0xA4")]
		private float m_notGeneratingAtlasDefaultSmoothness;

		[Token(Token = "0x4000497")]
		[FieldOffset(Offset = "0xA8")]
		private Color m_notGeneratingAtlasDefaultSpecular;

		[Token(Token = "0x4000498")]
		[FieldOffset(Offset = "0xB8")]
		private Color m_notGeneratingAtlasDefaultEmissiveColor;

		[Token(Token = "0x6000690")]
		[Address(RVA = "0x74B83D4", Offset = "0x74B43D4", VA = "0x74B83D4", Slot = "4")]
		public bool DoesShaderNameMatch(string shaderName)
		{
			return default;
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0x74B8428", Offset = "0x74B4428", VA = "0x74B8428")]
		private MaterialType _MapFloatToMaterialType(float materialType)
		{
			return default;
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0x74B84A4", Offset = "0x74B44A4", VA = "0x74B84A4")]
		private float _MapMaterialTypeToFloat(MaterialType materialType)
		{
			return default;
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0x74B84C8", Offset = "0x74B44C8", VA = "0x74B84C8", Slot = "5")]
		public void OnBeforeTintTexture(Material sourceMat, string shaderTexturePropertyName)
		{
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0x74B89D4", Offset = "0x74B49D4", VA = "0x74B89D4", Slot = "6")]
		public Color OnBlendTexturePixel(string propertyToDoshaderPropertyName, Color pixelColor)
		{
			return default;
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0x74B8A84", Offset = "0x74B4A84", VA = "0x74B8A84", Slot = "7")]
		public bool NonTexturePropertiesAreEqual(Material a, Material b)
		{
			return default;
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0x74B8CC4", Offset = "0x74B4CC4", VA = "0x74B8CC4", Slot = "8")]
		public void SetNonTexturePropertyValuesOnResultMaterial(Material resultMaterial)
		{
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0x74B91D0", Offset = "0x74B51D0", VA = "0x74B91D0", Slot = "9")]
		public Color GetColorIfNoTexture(Material mat, ShaderTextureProperty texPropertyName)
		{
			return default;
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0x74B985C", Offset = "0x74B585C", VA = "0x74B985C")]
		public TextureBlenderHDRPLit()
		{
		}
	}
}
