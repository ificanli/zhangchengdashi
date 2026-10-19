using Il2CppDummyDll;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Token(Token = "0x2000134")]
	public class TextureBlenderLegacyBumpDiffuse : TextureBlender
	{
		[Token(Token = "0x40004A7")]
		[FieldOffset(Offset = "0x10")]
		private bool doColor;

		[Token(Token = "0x40004A8")]
		[FieldOffset(Offset = "0x14")]
		private Color m_tintColor;

		[Token(Token = "0x40004A9")]
		[FieldOffset(Offset = "0x24")]
		private Color m_defaultTintColor;

		[Token(Token = "0x6000699")]
		[Address(RVA = "0x74B98F0", Offset = "0x74B58F0", VA = "0x74B98F0", Slot = "4")]
		public bool DoesShaderNameMatch(string shaderName)
		{
			return default;
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0x74B997C", Offset = "0x74B597C", VA = "0x74B997C", Slot = "5")]
		public void OnBeforeTintTexture(Material sourceMat, string shaderTexturePropertyName)
		{
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0x74B9A28", Offset = "0x74B5A28", VA = "0x74B9A28", Slot = "6")]
		public Color OnBlendTexturePixel(string propertyToDoshaderPropertyName, Color pixelColor)
		{
			return default;
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0x74B9A4C", Offset = "0x74B5A4C", VA = "0x74B9A4C", Slot = "7")]
		public bool NonTexturePropertiesAreEqual(Material a, Material b)
		{
			return default;
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0x74B9AB0", Offset = "0x74B5AB0", VA = "0x74B9AB0", Slot = "8")]
		public void SetNonTexturePropertyValuesOnResultMaterial(Material resultMaterial)
		{
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0x74B9B14", Offset = "0x74B5B14", VA = "0x74B9B14", Slot = "9")]
		public Color GetColorIfNoTexture(Material m, ShaderTextureProperty texPropertyName)
		{
			return default;
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0x74B9BD8", Offset = "0x74B5BD8", VA = "0x74B9BD8")]
		public TextureBlenderLegacyBumpDiffuse()
		{
		}
	}
}
