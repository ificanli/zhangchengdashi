using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Token(Token = "0x200010A")]
	internal class MB3_TextureCombinerPackerMeshBakerHorizontalVertical : MB3_TextureCombinerPackerMeshBaker
	{
		[Token(Token = "0x200010B")]
		private interface IPipeline
		{
			[Token(Token = "0x60005BA")]
			MB2_PackingAlgorithmEnum GetPackingAlg();

			[Token(Token = "0x60005BB")]
			void SortTexSetIntoBins(MB_TexSet texSet, List<MB_TexSet> horizontalVert, List<MB_TexSet> regular, int maxAtlasWidth, int maxAtlasHeight);

			[Token(Token = "0x60005BC")]
			MB_TextureTilingTreatment GetEdge2EdgeTreatment();

			[Token(Token = "0x60005BD")]
			void InitializeAtlasPadding(ref AtlasPadding padding, int paddingValue);

			[Token(Token = "0x60005BE")]
			void MergeAtlasPackingResultStackBonAInternal(AtlasPackingResult a, AtlasPackingResult b, out Rect AatlasToFinal, out Rect BatlasToFinal, bool stretchBToAtlasWidth, int maxWidthDim, int maxHeightDim, out int atlasX, out int atlasY);

			[Token(Token = "0x60005BF")]
			void GetExtraRoomForRegularAtlas(int usedHorizontalVertWidth, int usedHorizontalVertHeight, int maxAtlasWidth, int maxAtlasHeight, out int atlasRegularMaxWidth, out int atlasRegularMaxHeight);
		}

		[Token(Token = "0x200010C")]
		private class VerticalPipeline : IPipeline
		{
			[Token(Token = "0x60005C0")]
			[Address(RVA = "0x74A3168", Offset = "0x749F168", VA = "0x74A3168", Slot = "4")]
			public MB2_PackingAlgorithmEnum GetPackingAlg()
			{
				return default;
			}

			[Token(Token = "0x60005C1")]
			[Address(RVA = "0x74A3170", Offset = "0x749F170", VA = "0x74A3170", Slot = "5")]
			public void SortTexSetIntoBins(MB_TexSet texSet, List<MB_TexSet> horizontalVert, List<MB_TexSet> regular, int maxAtlasWidth, int maxAtlasHeight)
			{
			}

			[Token(Token = "0x60005C2")]
			[Address(RVA = "0x74A32AC", Offset = "0x749F2AC", VA = "0x74A32AC", Slot = "6")]
			public MB_TextureTilingTreatment GetEdge2EdgeTreatment()
			{
				return default;
			}

			[Token(Token = "0x60005C3")]
			[Address(RVA = "0x74A32B4", Offset = "0x749F2B4", VA = "0x74A32B4", Slot = "7")]
			public void InitializeAtlasPadding(ref AtlasPadding padding, int paddingValue)
			{
			}

			[Token(Token = "0x60005C4")]
			[Address(RVA = "0x74A32BC", Offset = "0x749F2BC", VA = "0x74A32BC", Slot = "8")]
			public void MergeAtlasPackingResultStackBonAInternal(AtlasPackingResult a, AtlasPackingResult b, out Rect AatlasToFinal, out Rect BatlasToFinal, bool stretchBToAtlasWidth, int maxWidthDim, int maxHeightDim, out int atlasX, out int atlasY)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MB3_TextureCombinerPackerMeshBakerHorizontalVertical.VerticalPipeline.MergeAtlasPackingResultStackBonAInternal RVA=0x74A32BC Token=0x60005C4");
}

			[Token(Token = "0x60005C5")]
			[Address(RVA = "0x74A345C", Offset = "0x749F45C", VA = "0x74A345C", Slot = "9")]
			public void GetExtraRoomForRegularAtlas(int usedHorizontalVertWidth, int usedHorizontalVertHeight, int maxAtlasWidth, int maxAtlasHeight, out int atlasRegularMaxWidth, out int atlasRegularMaxHeight)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MB3_TextureCombinerPackerMeshBakerHorizontalVertical.VerticalPipeline.GetExtraRoomForRegularAtlas RVA=0x74A345C Token=0x60005C5");
}

			[Token(Token = "0x60005C6")]
			[Address(RVA = "0x74A2C44", Offset = "0x749EC44", VA = "0x74A2C44")]
			public VerticalPipeline()
			{
			}
		}

		[Token(Token = "0x200010D")]
		private class HorizontalPipeline : IPipeline
		{
			[Token(Token = "0x60005C7")]
			[Address(RVA = "0x74A346C", Offset = "0x749F46C", VA = "0x74A346C", Slot = "4")]
			public MB2_PackingAlgorithmEnum GetPackingAlg()
			{
				return default;
			}

			[Token(Token = "0x60005C8")]
			[Address(RVA = "0x74A3474", Offset = "0x749F474", VA = "0x74A3474", Slot = "5")]
			public void SortTexSetIntoBins(MB_TexSet texSet, List<MB_TexSet> horizontalVert, List<MB_TexSet> regular, int maxAtlasWidth, int maxAtlasHeight)
			{
			}

			[Token(Token = "0x60005C9")]
			[Address(RVA = "0x74A35B0", Offset = "0x749F5B0", VA = "0x74A35B0", Slot = "6")]
			public MB_TextureTilingTreatment GetEdge2EdgeTreatment()
			{
				return default;
			}

			[Token(Token = "0x60005CA")]
			[Address(RVA = "0x74A35B8", Offset = "0x749F5B8", VA = "0x74A35B8", Slot = "7")]
			public void InitializeAtlasPadding(ref AtlasPadding padding, int paddingValue)
			{
			}

			[Token(Token = "0x60005CB")]
			[Address(RVA = "0x74A35C0", Offset = "0x749F5C0", VA = "0x74A35C0", Slot = "8")]
			public void MergeAtlasPackingResultStackBonAInternal(AtlasPackingResult a, AtlasPackingResult b, out Rect AatlasToFinal, out Rect BatlasToFinal, bool stretchBToAtlasWidth, int maxWidthDim, int maxHeightDim, out int atlasX, out int atlasY)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MB3_TextureCombinerPackerMeshBakerHorizontalVertical.HorizontalPipeline.MergeAtlasPackingResultStackBonAInternal RVA=0x74A35C0 Token=0x60005CB");
}

			[Token(Token = "0x60005CC")]
			[Address(RVA = "0x74A3760", Offset = "0x749F760", VA = "0x74A3760", Slot = "9")]
			public void GetExtraRoomForRegularAtlas(int usedHorizontalVertWidth, int usedHorizontalVertHeight, int maxAtlasWidth, int maxAtlasHeight, out int atlasRegularMaxWidth, out int atlasRegularMaxHeight)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MB3_TextureCombinerPackerMeshBakerHorizontalVertical.HorizontalPipeline.GetExtraRoomForRegularAtlas RVA=0x74A3760 Token=0x60005CC");
}

			[Token(Token = "0x60005CD")]
			[Address(RVA = "0x74A2C3C", Offset = "0x749EC3C", VA = "0x74A2C3C")]
			public HorizontalPipeline()
			{
			}
		}

		[Token(Token = "0x200010E")]
		public enum AtlasDirection
		{
			[Token(Token = "0x40003F8")]
			horizontal = 0,
			[Token(Token = "0x40003F9")]
			vertical = 1
		}

		[Token(Token = "0x40003F6")]
		[FieldOffset(Offset = "0x10")]
		private AtlasDirection _atlasDirection;

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x74A1AE8", Offset = "0x749DAE8", VA = "0x74A1AE8")]
		public MB3_TextureCombinerPackerMeshBakerHorizontalVertical(AtlasDirection ad)
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x74A1B10", Offset = "0x749DB10", VA = "0x74A1B10", Slot = "10")]
		public override AtlasPackingResult[] CalculateAtlasRectangles(MB3_TextureCombinerPipeline.TexturePipelineData data, bool doMultiAtlas, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x74A3050", Offset = "0x749F050", VA = "0x74A3050")]
		public static AtlasPackingResult TestStackRectanglesHorizontal(AtlasPackingResult a, AtlasPackingResult b, int maxHeightDim, int maxWidthDim, bool stretchBToAtlasWidth)
		{
			return null;
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x74A30DC", Offset = "0x749F0DC", VA = "0x74A30DC")]
		public static AtlasPackingResult TestStackRectanglesVertical(AtlasPackingResult a, AtlasPackingResult b, int maxHeightDim, int maxWidthDim, bool stretchBToAtlasWidth)
		{
			return null;
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x74A2C4C", Offset = "0x749EC4C", VA = "0x74A2C4C")]
		private static AtlasPackingResult MergeAtlasPackingResultStackBonA(AtlasPackingResult a, AtlasPackingResult b, int maxWidthDim, int maxHeightDim, bool stretchBToAtlasWidth, IPipeline pipeline)
		{
			return null;
		}
	}
}
