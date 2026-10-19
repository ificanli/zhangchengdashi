using System;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Serializable]
	[Token(Token = "0x20000D1")]
	public class AtlasPackingResult
	{
		[Token(Token = "0x40002EC")]
		[FieldOffset(Offset = "0x10")]
		public int atlasX;

		[Token(Token = "0x40002ED")]
		[FieldOffset(Offset = "0x14")]
		public int atlasY;

		[Token(Token = "0x40002EE")]
		[FieldOffset(Offset = "0x18")]
		public int usedW;

		[Token(Token = "0x40002EF")]
		[FieldOffset(Offset = "0x1C")]
		public int usedH;

		[Token(Token = "0x40002F0")]
		[FieldOffset(Offset = "0x20")]
		public Rect[] rects;

		[Token(Token = "0x40002F1")]
		[FieldOffset(Offset = "0x28")]
		public AtlasPadding[] padding;

		[Token(Token = "0x40002F2")]
		[FieldOffset(Offset = "0x30")]
		public int[] srcImgIdxs;

		[Token(Token = "0x40002F3")]
		[FieldOffset(Offset = "0x38")]
		public object data;

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x748796C", Offset = "0x748396C", VA = "0x748796C")]
		public AtlasPackingResult(AtlasPadding[] pds)
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x7487994", Offset = "0x7483994", VA = "0x7487994")]
		public void CalcUsedWidthAndHeight()
		{
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x7487B74", Offset = "0x7483B74", VA = "0x7487B74", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
