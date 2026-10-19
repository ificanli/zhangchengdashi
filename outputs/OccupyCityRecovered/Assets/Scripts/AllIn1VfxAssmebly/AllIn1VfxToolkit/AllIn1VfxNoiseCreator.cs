using Il2CppDummyDll;
using UnityEngine;

namespace AllIn1VfxToolkit
{
	[Token(Token = "0x2000014")]
	public static class AllIn1VfxNoiseCreator
	{
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x3CEDAAC", Offset = "0x3CE9AAC", VA = "0x3CEDAAC")]
		public static Texture2D PerlinNoise(Texture2D tex, float scale, int randomSeed, bool tileable)
		{
			return null;
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x3CEDCBC", Offset = "0x3CE9CBC", VA = "0x3CEDCBC")]
		private static Color CalculatePerlinColor(int x, int y, float scale, float offset, int width, int height)
		{
			return default;
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x3CEDD04", Offset = "0x3CE9D04", VA = "0x3CEDD04")]
		private static Color PerlinBorderless(int x, int y, float scale, float offset, int width, int height, Texture2D previousPerlin)
		{
			return default;
		}
	}
}
