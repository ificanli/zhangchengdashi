using System;
using Il2CppDummyDll;
using MemoryPack;
using MemoryPack.Internal;

namespace GameFramework
{
	[Serializable]
	[Token(Token = "0x2000373")]
	[MemoryPackable(GenerateType.Object)]
	public class ImageData : BaseConfig, IMemoryPackable<ImageData>, IMemoryPackFormatterRegister
	{
		[Token(Token = "0x2000374")]
		[Preserve]
		private sealed class ImageDataFormatter : MemoryPackFormatter<ImageData>
		{
			[Token(Token = "0x6005A08")]
			[Address(RVA = "0x719F700", Offset = "0x719B700", VA = "0x719F700", Slot = "8")]
			[Preserve]
			public override void Serialize(ref MemoryPackWriter writer, ref ImageData value)
			{
			}

			[Token(Token = "0x6005A09")]
			[Address(RVA = "0x719F764", Offset = "0x719B764", VA = "0x719F764", Slot = "9")]
			[Preserve]
			public override void Deserialize(ref MemoryPackReader reader, ref ImageData value)
			{
			}

			[Token(Token = "0x6005A0A")]
			[Address(RVA = "0x719E290", Offset = "0x719A290", VA = "0x719E290")]
			public ImageDataFormatter()
			{
			}
		}

		[Token(Token = "0x4001AAB")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		[Token(Token = "0x4001AAC")]
		[FieldOffset(Offset = "0x18")]
		public string[] zh_cn;

		[Token(Token = "0x4001AAD")]
		[FieldOffset(Offset = "0x20")]
		public string[] zh_tw;

		[Token(Token = "0x4001AAE")]
		[FieldOffset(Offset = "0x28")]
		public string[] en;

		[Token(Token = "0x4001AAF")]
		[FieldOffset(Offset = "0x30")]
		public string[] ja;

		[Token(Token = "0x4001AB0")]
		[FieldOffset(Offset = "0x38")]
		public string[] ko;

		[Token(Token = "0x4001AB1")]
		[FieldOffset(Offset = "0x40")]
		public string[] ru;

		[Token(Token = "0x4001AB2")]
		[FieldOffset(Offset = "0x48")]
		public string[] sp;

		[Token(Token = "0x4001AB3")]
		[FieldOffset(Offset = "0x50")]
		public string[] fr;

		[Token(Token = "0x4001AB4")]
		[FieldOffset(Offset = "0x58")]
		public string[] po;

		[Token(Token = "0x4001AB5")]
		[FieldOffset(Offset = "0x60")]
		public string[] ge;

		[Token(Token = "0x4001AB6")]
		[FieldOffset(Offset = "0x68")]
		public string[] ar;

		[Token(Token = "0x4001AB7")]
		[FieldOffset(Offset = "0x70")]
		public string[] It;

		[Token(Token = "0x4001AB8")]
		[FieldOffset(Offset = "0x78")]
		public string[] Ma;

		[Token(Token = "0x4001AB9")]
		[FieldOffset(Offset = "0x80")]
		public string[] Vi;

		[Token(Token = "0x4001ABA")]
		[FieldOffset(Offset = "0x88")]
		public string[] In;

		[Token(Token = "0x4001ABB")]
		[FieldOffset(Offset = "0x90")]
		public string[] Th;

		[Token(Token = "0x4001ABC")]
		[FieldOffset(Offset = "0x98")]
		public string[] PL;

		[Token(Token = "0x4001ABD")]
		[FieldOffset(Offset = "0xA0")]
		public string[] Tr;

		[Token(Token = "0x4001ABE")]
		[FieldOffset(Offset = "0xA8")]
		public string[] Sv;

		[Token(Token = "0x4001ABF")]
		[FieldOffset(Offset = "0xB0")]
		public string[] Ro;

		[Token(Token = "0x4001AC0")]
		[FieldOffset(Offset = "0xB8")]
		public string[] Nl;

		[Token(Token = "0x4001AC1")]
		[FieldOffset(Offset = "0xC0")]
		public string[] Nb;

		[Token(Token = "0x4001AC2")]
		[FieldOffset(Offset = "0xC8")]
		public string[] Fi;

		[Token(Token = "0x4001AC3")]
		[FieldOffset(Offset = "0xD0")]
		public string[] Hu;

		[Token(Token = "0x4001AC4")]
		[FieldOffset(Offset = "0xD8")]
		public string[] Cs;

		[Token(Token = "0x4001AC5")]
		[FieldOffset(Offset = "0xE0")]
		public string[] Hi;

		[Token(Token = "0x4001AC6")]
		[FieldOffset(Offset = "0xE8")]
		public string[] Bn;

		[Token(Token = "0x6005A03")]
		[Address(RVA = "0x719E014", Offset = "0x719A014", VA = "0x719E014")]
		static ImageData()
		{
		}

		[Token(Token = "0x6005A04")]
		[Address(RVA = "0x719E018", Offset = "0x719A018", VA = "0x719E018")]
		[Preserve]
		public static void RegisterFormatter()
		{
		}

		[Token(Token = "0x6005A05")]
		[Address(RVA = "0x719E2D8", Offset = "0x719A2D8", VA = "0x719E2D8")]
		[Preserve]
		public static void Serialize(ref MemoryPackWriter writer, ref ImageData? value)
		{
		}

		[Token(Token = "0x6005A06")]
		[Address(RVA = "0x719E5F8", Offset = "0x719A5F8", VA = "0x719E5F8")]
		[Preserve]
		public static void Deserialize(ref MemoryPackReader reader, ref ImageData? value)
		{
		}

		[Token(Token = "0x6005A07")]
		[Address(RVA = "0x719F6F8", Offset = "0x719B6F8", VA = "0x719F6F8")]
		public ImageData()
		{
		}
	}
}
