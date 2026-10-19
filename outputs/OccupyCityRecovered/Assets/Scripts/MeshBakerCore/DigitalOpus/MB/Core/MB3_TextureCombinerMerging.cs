using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Token(Token = "0x20000F2")]
	public class MB3_TextureCombinerMerging
	{
		[Token(Token = "0x400038F")]
		[FieldOffset(Offset = "0x0")]
		public static bool DO_INTEGRITY_CHECKS;

		[Token(Token = "0x4000390")]
		[FieldOffset(Offset = "0x10")]
		private bool _HasBeenInitialized;

		[Token(Token = "0x4000391")]
		[FieldOffset(Offset = "0x11")]
		private bool _considerNonTextureProperties;

		[Token(Token = "0x4000392")]
		[FieldOffset(Offset = "0x18")]
		private MB3_TextureCombinerNonTextureProperties resultMaterialTextureBlender;

		[Token(Token = "0x4000393")]
		[FieldOffset(Offset = "0x20")]
		private bool fixOutOfBoundsUVs;

		[Token(Token = "0x4000394")]
		[FieldOffset(Offset = "0x24")]
		public MB2_LogLevel LOG_LEVEL;

		[Token(Token = "0x4000395")]
		[FieldOffset(Offset = "0x1")]
		private static bool LOG_LEVEL_TRACE_MERGE_MAT_SUBRECTS;

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x749683C", Offset = "0x749283C", VA = "0x749683C")]
		public static Rect BuildTransformMeshUV2AtlasRect(bool considerMeshUVs, Rect _atlasRect, Rect _obUVRect, Rect _sourceMaterialTiling, Rect _encapsulatingRect)
		{
			return default;
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x7496A1C", Offset = "0x7492A1C", VA = "0x7496A1C")]
		public MB3_TextureCombinerMerging(bool considerNonTextureProps, MB3_TextureCombinerNonTextureProperties resultMaterialTexBlender, bool fixObUVs, MB2_LogLevel logLevel)
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x7496A74", Offset = "0x7492A74", VA = "0x7496A74")]
		public void MergeOverlappingDistinctMaterialTexturesAndCalcMaterialSubrects(List<MB_TexSet> distinctMaterialTextures)
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x7498358", Offset = "0x7494358", VA = "0x7498358")]
		public void MergeDistinctMaterialTexturesThatWouldExceedMaxAtlasSizeAndCalcMaterialSubrects(List<MB_TexSet> distinctMaterialTextures, int maxAtlasSize)
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x7497C40", Offset = "0x7493C40", VA = "0x7497C40")]
		public void DoIntegrityCheckMergedEncapsulatingSamplingRects(List<MB_TexSet> distinctMaterialTextures)
		{
		}
	}
}
