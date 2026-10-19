using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Token(Token = "0x20000D2")]
	public abstract class MB2_TexturePacker
	{
		[Token(Token = "0x20000D3")]
		internal enum NodeType
		{
			[Token(Token = "0x40002F9")]
			Container = 0,
			[Token(Token = "0x40002FA")]
			maxDim = 1,
			[Token(Token = "0x40002FB")]
			regular = 2
		}

		[Token(Token = "0x20000D4")]
		internal class PixRect
		{
			[Token(Token = "0x40002FC")]
			[FieldOffset(Offset = "0x10")]
			public int x;

			[Token(Token = "0x40002FD")]
			[FieldOffset(Offset = "0x14")]
			public int y;

			[Token(Token = "0x40002FE")]
			[FieldOffset(Offset = "0x18")]
			public int w;

			[Token(Token = "0x40002FF")]
			[FieldOffset(Offset = "0x1C")]
			public int h;

			[Token(Token = "0x600045B")]
			[Address(RVA = "0x7488480", Offset = "0x7484480", VA = "0x7488480")]
			public PixRect()
			{
			}

			[Token(Token = "0x600045C")]
			[Address(RVA = "0x7488488", Offset = "0x7484488", VA = "0x7488488")]
			public PixRect(int xx, int yy, int ww, int hh)
			{
			}

			[Token(Token = "0x600045D")]
			[Address(RVA = "0x74884C8", Offset = "0x74844C8", VA = "0x74884C8", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Token(Token = "0x20000D5")]
		internal class Image
		{
			[Token(Token = "0x4000300")]
			[FieldOffset(Offset = "0x10")]
			public int imgId;

			[Token(Token = "0x4000301")]
			[FieldOffset(Offset = "0x14")]
			public int w;

			[Token(Token = "0x4000302")]
			[FieldOffset(Offset = "0x18")]
			public int h;

			[Token(Token = "0x4000303")]
			[FieldOffset(Offset = "0x1C")]
			public int x;

			[Token(Token = "0x4000304")]
			[FieldOffset(Offset = "0x20")]
			public int y;

			[Token(Token = "0x600045E")]
			[Address(RVA = "0x7488674", Offset = "0x7484674", VA = "0x7488674")]
			public Image(int id, int tw, int th, AtlasPadding padding, int minImageSizeX, int minImageSizeY)
			{
			}

			[Token(Token = "0x600045F")]
			[Address(RVA = "0x74886E4", Offset = "0x74846E4", VA = "0x74886E4")]
			public Image(Image im)
			{
			}
		}

		[Token(Token = "0x20000D6")]
		internal class ImgIDComparer : IComparer<Image>
		{
			[Token(Token = "0x6000460")]
			[Address(RVA = "0x7488720", Offset = "0x7484720", VA = "0x7488720", Slot = "4")]
			public int Compare(Image x, Image y)
			{
				return default;
			}

			[Token(Token = "0x6000461")]
			[Address(RVA = "0x7488754", Offset = "0x7484754", VA = "0x7488754")]
			public ImgIDComparer()
			{
			}
		}

		[Token(Token = "0x20000D7")]
		internal class ImageHeightComparer : IComparer<Image>
		{
			[Token(Token = "0x6000462")]
			[Address(RVA = "0x748875C", Offset = "0x748475C", VA = "0x748875C", Slot = "4")]
			public int Compare(Image x, Image y)
			{
				return default;
			}

			[Token(Token = "0x6000463")]
			[Address(RVA = "0x7488790", Offset = "0x7484790", VA = "0x7488790")]
			public ImageHeightComparer()
			{
			}
		}

		[Token(Token = "0x20000D8")]
		internal class ImageWidthComparer : IComparer<Image>
		{
			[Token(Token = "0x6000464")]
			[Address(RVA = "0x7488798", Offset = "0x7484798", VA = "0x7488798", Slot = "4")]
			public int Compare(Image x, Image y)
			{
				return default;
			}

			[Token(Token = "0x6000465")]
			[Address(RVA = "0x74887CC", Offset = "0x74847CC", VA = "0x74887CC")]
			public ImageWidthComparer()
			{
			}
		}

		[Token(Token = "0x20000D9")]
		internal class ImageAreaComparer : IComparer<Image>
		{
			[Token(Token = "0x6000466")]
			[Address(RVA = "0x74887D4", Offset = "0x74847D4", VA = "0x74887D4", Slot = "4")]
			public int Compare(Image x, Image y)
			{
				return default;
			}

			[Token(Token = "0x6000467")]
			[Address(RVA = "0x7488810", Offset = "0x7484810", VA = "0x7488810")]
			public ImageAreaComparer()
			{
			}
		}

		[Token(Token = "0x40002F4")]
		public const int MAX_ATLAS_SIZE = 8192;

		[Token(Token = "0x40002F5")]
		[FieldOffset(Offset = "0x10")]
		public MB2_LogLevel LOG_LEVEL;

		[Token(Token = "0x40002F6")]
		internal const int MAX_RECURSION_DEPTH = 10;

		[Token(Token = "0x40002F7")]
		[FieldOffset(Offset = "0x14")]
		public bool atlasMustBePowerOfTwo;

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x7487D68", Offset = "0x7483D68", VA = "0x7487D68")]
		public static int RoundToNearestPositivePowerOfTwo(int x)
		{
			return default;
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x7487E80", Offset = "0x7483E80", VA = "0x7487E80")]
		public static int CeilToNearestPowerOfTwo(int x)
		{
			return default;
		}

		[Token(Token = "0x6000456")]
		public abstract AtlasPackingResult[] GetRects(List<Vector2> imgWidthHeights, int maxDimensionX, int maxDimensionY, int padding);

		[Token(Token = "0x6000457")]
		public abstract AtlasPackingResult[] GetRects(List<Vector2> imgWidthHeights, List<AtlasPadding> paddings, int maxDimensionX, int maxDimensionY, bool doMultiAtlas);

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x7487ECC", Offset = "0x7483ECC", VA = "0x7487ECC")]
		internal bool ScaleAtlasToFitMaxDim(Vector2 rootWH, List<Image> images, int maxDimensionX, int maxDimensionY, AtlasPadding padding, int minImageSizeX, int minImageSizeY, int masterImageSizeX, int masterImageSizeY, ref int outW, ref int outH, out float padX, out float padY, out int newMinSizeX, out int newMinSizeY)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED MB2_TexturePacker.ScaleAtlasToFitMaxDim RVA=0x7487ECC Token=0x6000458");
}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x74883D0", Offset = "0x74843D0", VA = "0x74883D0")]
		public void ConvertToRectsWithoutPaddingAndNormalize01(AtlasPackingResult rr, AtlasPadding padding)
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x7488468", Offset = "0x7484468", VA = "0x7488468")]
		protected MB2_TexturePacker()
		{
		}
	}
}
