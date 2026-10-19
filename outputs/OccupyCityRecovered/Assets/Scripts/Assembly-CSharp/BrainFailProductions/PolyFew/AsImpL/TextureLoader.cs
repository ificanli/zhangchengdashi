using System.IO;
using Il2CppDummyDll;
using UnityEngine;

namespace BrainFailProductions.PolyFew.AsImpL
{
	[Token(Token = "0x2000D04")]
	public class TextureLoader : MonoBehaviour
	{
		[Token(Token = "0x2000D05")]
		private class TgaHeader
		{
			[Token(Token = "0x4005D27")]
			[FieldOffset(Offset = "0x10")]
			public byte identSize;

			[Token(Token = "0x4005D28")]
			[FieldOffset(Offset = "0x11")]
			public byte colorMapType;

			[Token(Token = "0x4005D29")]
			[FieldOffset(Offset = "0x12")]
			public byte imageType;

			[Token(Token = "0x4005D2A")]
			[FieldOffset(Offset = "0x14")]
			public ushort colorMapStart;

			[Token(Token = "0x4005D2B")]
			[FieldOffset(Offset = "0x16")]
			public ushort colorMapLength;

			[Token(Token = "0x4005D2C")]
			[FieldOffset(Offset = "0x18")]
			public byte colorMapBits;

			[Token(Token = "0x4005D2D")]
			[FieldOffset(Offset = "0x1A")]
			public ushort xStart;

			[Token(Token = "0x4005D2E")]
			[FieldOffset(Offset = "0x1C")]
			public ushort ySstart;

			[Token(Token = "0x4005D2F")]
			[FieldOffset(Offset = "0x1E")]
			public ushort width;

			[Token(Token = "0x4005D30")]
			[FieldOffset(Offset = "0x20")]
			public ushort height;

			[Token(Token = "0x4005D31")]
			[FieldOffset(Offset = "0x22")]
			public byte bits;

			[Token(Token = "0x4005D32")]
			[FieldOffset(Offset = "0x23")]
			public byte descriptor;

			[Token(Token = "0x600511B")]
			[Address(RVA = "0x42D871C", Offset = "0x42D471C", VA = "0x42D871C")]
			public TgaHeader()
			{
			}
		}

		[Token(Token = "0x6005114")]
		[Address(RVA = "0x42D767C", Offset = "0x42D367C", VA = "0x42D767C")]
		public static Texture2D LoadTextureFromUrl(string url)
		{
			return null;
		}

		[Token(Token = "0x6005115")]
		[Address(RVA = "0x42D7724", Offset = "0x42D3724", VA = "0x42D7724")]
		public static Texture2D LoadTexture(string fileName)
		{
			return null;
		}

		[Token(Token = "0x6005116")]
		[Address(RVA = "0x42D7C28", Offset = "0x42D3C28", VA = "0x42D7C28")]
		public static Texture2D LoadTGA(string fileName)
		{
			return null;
		}

		[Token(Token = "0x6005117")]
		[Address(RVA = "0x42D7904", Offset = "0x42D3904", VA = "0x42D7904")]
		public static Texture2D LoadDDSManual(string ddsPath)
		{
			return null;
		}

		[Token(Token = "0x6005118")]
		[Address(RVA = "0x42D7DA0", Offset = "0x42D3DA0", VA = "0x42D7DA0")]
		public static Texture2D LoadTGA(Stream TGAStream)
		{
			return null;
		}

		[Token(Token = "0x6005119")]
		[Address(RVA = "0x42D8344", Offset = "0x42D4344", VA = "0x42D8344")]
		private static TgaHeader LoadTgaHeader(BinaryReader r)
		{
			return null;
		}

		[Token(Token = "0x600511A")]
		[Address(RVA = "0x42D8724", Offset = "0x42D4724", VA = "0x42D8724")]
		public TextureLoader()
		{
		}
	}
}
