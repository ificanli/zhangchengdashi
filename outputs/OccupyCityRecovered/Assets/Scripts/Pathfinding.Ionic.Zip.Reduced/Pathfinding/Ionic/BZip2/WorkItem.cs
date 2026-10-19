using System.IO;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Pathfinding.Ionic.BZip2
{
	[Token(Token = "0x2000046")]
	internal class WorkItem
	{
		[Token(Token = "0x40001FA")]
		[FieldOffset(Offset = "0x10")]
		public int index;

		[Token(Token = "0x40001FB")]
		[FieldOffset(Offset = "0x18")]
		public MemoryStream ms;

		[Token(Token = "0x40001FC")]
		[FieldOffset(Offset = "0x20")]
		public int ordinal;

		[Token(Token = "0x40001FD")]
		[FieldOffset(Offset = "0x28")]
		public BitWriter bw;

		[Token(Token = "0x170000D7")]
		public BZip2Compressor Compressor
		{
			[Token(Token = "0x6000358")]
			[Address(RVA = "0x78643AC", Offset = "0x78603AC", VA = "0x78643AC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000359")]
			[Address(RVA = "0x78643B4", Offset = "0x78603B4", VA = "0x78643B4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x78642C8", Offset = "0x78602C8", VA = "0x78642C8")]
		public WorkItem(int ix, int blockSize)
		{
		}
	}
}
