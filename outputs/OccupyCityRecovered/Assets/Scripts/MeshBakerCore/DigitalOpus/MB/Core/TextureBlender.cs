using Il2CppDummyDll;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Token(Token = "0x200012F")]
	public interface TextureBlender
	{
		[Token(Token = "0x6000680")]
		bool DoesShaderNameMatch(string shaderName);

		[Token(Token = "0x6000681")]
		void OnBeforeTintTexture(Material sourceMat, string shaderTexturePropertyName);

		[Token(Token = "0x6000682")]
		Color OnBlendTexturePixel(string shaderPropertyName, Color pixelColor);

		[Token(Token = "0x6000683")]
		bool NonTexturePropertiesAreEqual(Material a, Material b);

		[Token(Token = "0x6000684")]
		void SetNonTexturePropertyValuesOnResultMaterial(Material resultMaterial);

		[Token(Token = "0x6000685")]
		Color GetColorIfNoTexture(Material m, ShaderTextureProperty texPropertyName);
	}
}
