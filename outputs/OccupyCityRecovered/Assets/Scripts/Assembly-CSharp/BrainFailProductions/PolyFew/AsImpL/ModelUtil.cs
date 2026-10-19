using Il2CppDummyDll;
using UnityEngine;

namespace BrainFailProductions.PolyFew.AsImpL
{
	[Token(Token = "0x2000CDE")]
	public class ModelUtil
	{
		[Token(Token = "0x2000CDF")]
		public enum MtlBlendMode
		{
			[Token(Token = "0x4005C13")]
			OPAQUE = 0,
			[Token(Token = "0x4005C14")]
			CUTOUT = 1,
			[Token(Token = "0x4005C15")]
			FADE = 2,
			[Token(Token = "0x4005C16")]
			TRANSPARENT = 3
		}

		[Token(Token = "0x600505C")]
		[Address(RVA = "0x42C4C78", Offset = "0x42C0C78", VA = "0x42C4C78")]
		public static void SetupMaterialWithBlendMode(Material mtl, MtlBlendMode mode)
		{
		}

		[Token(Token = "0x600505D")]
		[Address(RVA = "0x42C5114", Offset = "0x42C1114", VA = "0x42C5114")]
		public static bool ScanTransparentPixels(Texture2D texture, ref MtlBlendMode mode)
		{
			return default;
		}

		[Token(Token = "0x600505E")]
		[Address(RVA = "0x42C52C8", Offset = "0x42C12C8", VA = "0x42C52C8")]
		public static void DetectMtlBlendFadeOrCutout(float alpha, ref MtlBlendMode mode, ref bool noDoubt)
		{
		}

		[Token(Token = "0x600505F")]
		[Address(RVA = "0x42C5310", Offset = "0x42C1310", VA = "0x42C5310")]
		public static Texture2D HeightToNormalMap(Texture2D bumpMap, float amount = 1f)
		{
			return null;
		}

		[Token(Token = "0x6005060")]
		[Address(RVA = "0x42C56B4", Offset = "0x42C16B4", VA = "0x42C56B4")]
		private static int WrapInt(int pos, int boundary)
		{
			return default;
		}

		[Token(Token = "0x6005061")]
		[Address(RVA = "0x42C56D0", Offset = "0x42C16D0", VA = "0x42C56D0")]
		public ModelUtil()
		{
		}
	}
}
