using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ToonyColorsPro.Runtime
{
	[Token(Token = "0x2000008")]
	public static class TCP2_RuntimeUtils
	{
		[Token(Token = "0x4000040")]
		private const string BASE_SHADER_PATH = "Toony Colors Pro 2/";

		[Token(Token = "0x4000041")]
		private const string VARIANT_SHADER_PATH = "Hidden/Toony Colors Pro 2/Variants/";

		[Token(Token = "0x4000042")]
		private const string BASE_SHADER_NAME = "Desktop";

		[Token(Token = "0x4000043")]
		private const string BASE_SHADER_NAME_MOB = "Mobile";

		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x0")]
		private static List<string[]> ShaderVariants;

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x7D63500", Offset = "0x7D5F500", VA = "0x7D63500")]
		public static Shader GetShaderWithKeywords(Material material)
		{
			return null;
		}
	}
}
