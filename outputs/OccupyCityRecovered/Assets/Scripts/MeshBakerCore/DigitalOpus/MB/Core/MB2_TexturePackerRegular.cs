using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Token(Token = "0x20000DA")]
	public class MB2_TexturePackerRegular : MB2_TexturePacker
	{
		[Token(Token = "0x20000DB")]
		private class ProbeResult
		{
			[Token(Token = "0x4000307")]
			[FieldOffset(Offset = "0x10")]
			public int w;

			[Token(Token = "0x4000308")]
			[FieldOffset(Offset = "0x14")]
			public int h;

			[Token(Token = "0x4000309")]
			[FieldOffset(Offset = "0x18")]
			public int outW;

			[Token(Token = "0x400030A")]
			[FieldOffset(Offset = "0x1C")]
			public int outH;

			[Token(Token = "0x400030B")]
			[FieldOffset(Offset = "0x20")]
			public Node root;

			[Token(Token = "0x400030C")]
			[FieldOffset(Offset = "0x28")]
			public bool largerOrEqualToMaxDim;

			[Token(Token = "0x400030D")]
			[FieldOffset(Offset = "0x2C")]
			public float efficiency;

			[Token(Token = "0x400030E")]
			[FieldOffset(Offset = "0x30")]
			public float squareness;

			[Token(Token = "0x400030F")]
			[FieldOffset(Offset = "0x34")]
			public float totalAtlasArea;

			[Token(Token = "0x4000310")]
			[FieldOffset(Offset = "0x38")]
			public int numAtlases;

			[Token(Token = "0x6000475")]
			[Address(RVA = "0x7489784", Offset = "0x7485784", VA = "0x7489784")]
			public void Set(int ww, int hh, int outw, int outh, Node r, bool fits, float e, float sq)
			{
			}

			[Token(Token = "0x6000476")]
			[Address(RVA = "0x748C674", Offset = "0x7488674", VA = "0x748C674")]
			public float GetScore(bool doPowerOfTwoScore)
			{
				return default;
			}

			[Token(Token = "0x6000477")]
			[Address(RVA = "0x748C6C4", Offset = "0x74886C4", VA = "0x748C6C4")]
			public void PrintTree()
			{
			}

			[Token(Token = "0x6000478")]
			[Address(RVA = "0x748C66C", Offset = "0x748866C", VA = "0x748C66C")]
			public ProbeResult()
			{
			}
		}

		[Token(Token = "0x20000DC")]
		internal class Node
		{
			[Token(Token = "0x4000311")]
			[FieldOffset(Offset = "0x10")]
			internal NodeType isFullAtlas;

			[Token(Token = "0x4000312")]
			[FieldOffset(Offset = "0x18")]
			internal Node[] child;

			[Token(Token = "0x4000313")]
			[FieldOffset(Offset = "0x20")]
			internal PixRect r;

			[Token(Token = "0x4000314")]
			[FieldOffset(Offset = "0x28")]
			internal Image img;

			[Token(Token = "0x4000315")]
			[FieldOffset(Offset = "0x30")]
			private ProbeResult bestRoot;

			[Token(Token = "0x6000479")]
			[Address(RVA = "0x74892C8", Offset = "0x74852C8", VA = "0x74892C8")]
			internal Node(NodeType rootType)
			{
			}

			[Token(Token = "0x600047A")]
			[Address(RVA = "0x748C70C", Offset = "0x748870C", VA = "0x748C70C")]
			private bool isLeaf()
			{
				return default;
			}

			[Token(Token = "0x600047B")]
			[Address(RVA = "0x7489334", Offset = "0x7485334", VA = "0x7489334")]
			internal Node Insert(Image im, bool handed)
			{
				return null;
			}
		}

		[Token(Token = "0x4000305")]
		[FieldOffset(Offset = "0x18")]
		private ProbeResult bestRoot;

		[Token(Token = "0x4000306")]
		[FieldOffset(Offset = "0x20")]
		public int atlasY;

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x7488818", Offset = "0x7484818", VA = "0x7488818")]
		private static void printTree(Node r, string spc)
		{
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x7488A10", Offset = "0x7484A10", VA = "0x7488A10")]
		private static void flattenTree(Node r, List<Image> putHere)
		{
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x7488B0C", Offset = "0x7484B0C", VA = "0x7488B0C")]
		private static void drawGizmosNode(Node r)
		{
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x7488CF4", Offset = "0x7484CF4", VA = "0x7488CF4")]
		public void DrawGizmos()
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x7488D74", Offset = "0x7484D74", VA = "0x7488D74")]
		private bool ProbeSingleAtlas(Image[] imgsToAdd, int idealAtlasW, int idealAtlasH, float imgArea, int maxAtlasDimX, int maxAtlasDimY, ProbeResult pr)
		{
			return default;
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x74897A0", Offset = "0x74857A0", VA = "0x74897A0")]
		private bool ProbeMultiAtlas(Image[] imgsToAdd, int idealAtlasW, int idealAtlasH, float imgArea, int maxAtlasDimX, int maxAtlasDimY, ProbeResult pr)
		{
			return default;
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x74896C0", Offset = "0x74856C0", VA = "0x74896C0")]
		internal void GetExtent(Node r, ref int x, ref int y)
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x7489B48", Offset = "0x7485B48", VA = "0x7489B48")]
		private int StepWidthHeight(int oldVal, int step, int maxDim)
		{
			return default;
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x7489B78", Offset = "0x7485B78", VA = "0x7489B78", Slot = "4")]
		public override AtlasPackingResult[] GetRects(List<Vector2> imgWidthHeights, int maxDimensionX, int maxDimensionY, int atPadding)
		{
			return null;
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x7489CD0", Offset = "0x7485CD0", VA = "0x7489CD0", Slot = "5")]
		public override AtlasPackingResult[] GetRects(List<Vector2> imgWidthHeights, List<AtlasPadding> paddings, int maxDimensionX, int maxDimensionY, bool doMultiAtlas)
		{
			return null;
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x748AF94", Offset = "0x7486F94", VA = "0x748AF94")]
		private AtlasPackingResult _GetRectsSingleAtlas(List<Vector2> imgWidthHeights, List<AtlasPadding> paddings, int maxDimensionX, int maxDimensionY, int minImageSizeX, int minImageSizeY, int masterImageSizeX, int masterImageSizeY, int recursionDepth)
		{
			return null;
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x7489E90", Offset = "0x7485E90", VA = "0x7489E90")]
		private AtlasPackingResult[] _GetRectsMultiAtlas(List<Vector2> imgWidthHeights, List<AtlasPadding> paddings, int maxDimensionPassedX, int maxDimensionPassedY, int minImageSizeX, int minImageSizeY, int masterImageSizeX, int masterImageSizeY)
		{
			return null;
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x748C6AC", Offset = "0x74886AC", VA = "0x748C6AC")]
		public MB2_TexturePackerRegular()
		{
		}
	}
}
