using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Token(Token = "0x20000DD")]
	public class MB2_TexturePackerHorizontalVert : MB2_TexturePacker
	{
		[Token(Token = "0x20000DE")]
		public enum TexturePackingOrientation
		{
			[Token(Token = "0x4000319")]
			horizontal = 0,
			[Token(Token = "0x400031A")]
			vertical = 1
		}

		[Token(Token = "0x4000316")]
		[FieldOffset(Offset = "0x18")]
		public TexturePackingOrientation packingOrientation;

		[Token(Token = "0x4000317")]
		[FieldOffset(Offset = "0x1C")]
		public bool stretchImagesToEdges;

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x748C754", Offset = "0x7488754", VA = "0x748C754", Slot = "4")]
		public override AtlasPackingResult[] GetRects(List<Vector2> imgWidthHeights, int maxDimensionX, int maxDimensionY, int padding)
		{
			return null;
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x748C8B0", Offset = "0x74888B0", VA = "0x748C8B0", Slot = "5")]
		public override AtlasPackingResult[] GetRects(List<Vector2> imgWidthHeights, List<AtlasPadding> paddings, int maxDimensionX, int maxDimensionY, bool doMultiAtlas)
		{
			return null;
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x748E004", Offset = "0x748A004", VA = "0x748E004")]
		private AtlasPackingResult _GetRectsSingleAtlas(List<Vector2> imgWidthHeights, List<AtlasPadding> paddings, int maxDimensionX, int maxDimensionY, int minImageSizeX, int minImageSizeY, int masterImageSizeX, int masterImageSizeY, int recursionDepth)
		{
			return null;
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x748CA9C", Offset = "0x7488A9C", VA = "0x748CA9C")]
		private AtlasPackingResult[] _GetRectsMultiAtlasVertical(List<Vector2> imgWidthHeights, List<AtlasPadding> paddings, int maxDimensionPassedX, int maxDimensionPassedY, int minImageSizeX, int minImageSizeY, int masterImageSizeX, int masterImageSizeY)
		{
			return null;
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x748D57C", Offset = "0x748957C", VA = "0x748D57C")]
		private AtlasPackingResult[] _GetRectsMultiAtlasHorizontal(List<Vector2> imgWidthHeights, List<AtlasPadding> paddings, int maxDimensionPassedX, int maxDimensionPassedY, int minImageSizeX, int minImageSizeY, int masterImageSizeX, int masterImageSizeY)
		{
			return null;
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x748EC5C", Offset = "0x748AC5C", VA = "0x748EC5C")]
		private Image PopLargestThatFits(List<Image> images, int spaceRemaining, int maxDim, bool emptyAtlas)
		{
			return null;
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x748EDA8", Offset = "0x748ADA8", VA = "0x748EDA8")]
		public MB2_TexturePackerHorizontalVert()
		{
		}
	}
}
