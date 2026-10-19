using Il2CppDummyDll;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Token(Token = "0x2000130")]
	public class TextureBlenderFallback : TextureBlender
	{
		[Token(Token = "0x4000484")]
		[FieldOffset(Offset = "0x10")]
		private bool m_doTintColor;

		[Token(Token = "0x4000485")]
		[FieldOffset(Offset = "0x14")]
		private Color m_tintColor;

		[Token(Token = "0x4000486")]
		[FieldOffset(Offset = "0x24")]
		private Color m_defaultColor;

		[Token(Token = "0x6000686")]
		[Address(RVA = "0x74B7694", Offset = "0x74B3694", VA = "0x74B7694", Slot = "4")]
		public bool DoesShaderNameMatch(string shaderName)
		{
			return default;
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0x74B769C", Offset = "0x74B369C", VA = "0x74B769C", Slot = "5")]
		public void OnBeforeTintTexture(Material sourceMat, string shaderTexturePropertyName)
		{
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0x74B778C", Offset = "0x74B378C", VA = "0x74B778C", Slot = "6")]
		public Color OnBlendTexturePixel(string shaderPropertyName, Color pixelColor)
		{
			return default;
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0x74B77B0", Offset = "0x74B37B0", VA = "0x74B77B0", Slot = "7")]
		public bool NonTexturePropertiesAreEqual(Material a, Material b)
		{
			return default;
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0x74B7978", Offset = "0x74B3978", VA = "0x74B7978", Slot = "8")]
		public void SetNonTexturePropertyValuesOnResultMaterial(Material resultMaterial)
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0x74B7A20", Offset = "0x74B3A20", VA = "0x74B7A20")]
		public static Color GetDefaultNormalMapColor()
		{
			return default;
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0x74B7A50", Offset = "0x74B3A50", VA = "0x74B7A50", Slot = "9")]
		public Color GetColorIfNoTexture(Material mat, ShaderTextureProperty texProperty)
		{
			return default;
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0x74B786C", Offset = "0x74B386C", VA = "0x74B786C")]
		public static bool _compareColor(Material a, Material b, Color defaultVal, string propertyName)
		{
			return default;
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0x74B8334", Offset = "0x74B4334", VA = "0x74B8334")]
		public static bool _compareFloat(Material a, Material b, float defaultVal, string propertyName)
		{
			return default;
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0x74B83C4", Offset = "0x74B43C4", VA = "0x74B83C4")]
		public TextureBlenderFallback()
		{
		}
	}
}
