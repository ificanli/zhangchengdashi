using Il2CppDummyDll;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Token(Token = "0x2000135")]
	public class TextureBlenderLegacyDiffuse : TextureBlender
	{
		[Token(Token = "0x40004AA")]
		[FieldOffset(Offset = "0x10")]
		private bool doColor;

		[Token(Token = "0x40004AB")]
		[FieldOffset(Offset = "0x14")]
		private Color m_tintColor;

		[Token(Token = "0x40004AC")]
		[FieldOffset(Offset = "0x24")]
		private Color m_defaultTintColor;

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x74B9BE8", Offset = "0x74B5BE8", VA = "0x74B9BE8", Slot = "4")]
		public bool DoesShaderNameMatch(string shaderName)
		{
			return default;
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x74B9C74", Offset = "0x74B5C74", VA = "0x74B9C74", Slot = "5")]
		public void OnBeforeTintTexture(Material sourceMat, string shaderTexturePropertyName)
		{
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x74B9D20", Offset = "0x74B5D20", VA = "0x74B9D20", Slot = "6")]
		public Color OnBlendTexturePixel(string propertyToDoshaderPropertyName, Color pixelColor)
		{
			return default;
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x74B9D44", Offset = "0x74B5D44", VA = "0x74B9D44", Slot = "7")]
		public bool NonTexturePropertiesAreEqual(Material a, Material b)
		{
			return default;
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x74B9DAC", Offset = "0x74B5DAC", VA = "0x74B9DAC", Slot = "8")]
		public void SetNonTexturePropertyValuesOnResultMaterial(Material resultMaterial)
		{
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x74B9E10", Offset = "0x74B5E10", VA = "0x74B9E10", Slot = "9")]
		public Color GetColorIfNoTexture(Material m, ShaderTextureProperty texPropertyName)
		{
			return default;
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x74B9EEC", Offset = "0x74B5EEC", VA = "0x74B9EEC")]
		public TextureBlenderLegacyDiffuse()
		{
		}
	}
}
