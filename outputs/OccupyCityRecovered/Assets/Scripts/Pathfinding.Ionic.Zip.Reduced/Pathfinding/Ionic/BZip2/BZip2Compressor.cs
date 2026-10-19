using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Pathfinding.Ionic.Crc;

namespace Pathfinding.Ionic.BZip2
{
	[Token(Token = "0x200003D")]
	internal class BZip2Compressor
	{
		[Token(Token = "0x200003E")]
		private class CompressionState
		{
			[Token(Token = "0x400018D")]
			[FieldOffset(Offset = "0x10")]
			public readonly bool[] inUse;

			[Token(Token = "0x400018E")]
			[FieldOffset(Offset = "0x18")]
			public readonly byte[] unseqToSeq;

			[Token(Token = "0x400018F")]
			[FieldOffset(Offset = "0x20")]
			public readonly int[] mtfFreq;

			[Token(Token = "0x4000190")]
			[FieldOffset(Offset = "0x28")]
			public readonly byte[] selector;

			[Token(Token = "0x4000191")]
			[FieldOffset(Offset = "0x30")]
			public readonly byte[] selectorMtf;

			[Token(Token = "0x4000192")]
			[FieldOffset(Offset = "0x38")]
			public readonly byte[] generateMTFValues_yy;

			[Token(Token = "0x4000193")]
			[FieldOffset(Offset = "0x40")]
			public byte[][] sendMTFValues_len;

			[Token(Token = "0x4000194")]
			[FieldOffset(Offset = "0x48")]
			public int[][] sendMTFValues_rfreq;

			[Token(Token = "0x4000195")]
			[FieldOffset(Offset = "0x50")]
			public readonly int[] sendMTFValues_fave;

			[Token(Token = "0x4000196")]
			[FieldOffset(Offset = "0x58")]
			public readonly short[] sendMTFValues_cost;

			[Token(Token = "0x4000197")]
			[FieldOffset(Offset = "0x60")]
			public int[][] sendMTFValues_code;

			[Token(Token = "0x4000198")]
			[FieldOffset(Offset = "0x68")]
			public readonly byte[] sendMTFValues2_pos;

			[Token(Token = "0x4000199")]
			[FieldOffset(Offset = "0x70")]
			public readonly bool[] sentMTFValues4_inUse16;

			[Token(Token = "0x400019A")]
			[FieldOffset(Offset = "0x78")]
			public readonly int[] stack_ll;

			[Token(Token = "0x400019B")]
			[FieldOffset(Offset = "0x80")]
			public readonly int[] stack_hh;

			[Token(Token = "0x400019C")]
			[FieldOffset(Offset = "0x88")]
			public readonly int[] stack_dd;

			[Token(Token = "0x400019D")]
			[FieldOffset(Offset = "0x90")]
			public readonly int[] mainSort_runningOrder;

			[Token(Token = "0x400019E")]
			[FieldOffset(Offset = "0x98")]
			public readonly int[] mainSort_copy;

			[Token(Token = "0x400019F")]
			[FieldOffset(Offset = "0xA0")]
			public readonly bool[] mainSort_bigDone;

			[Token(Token = "0x40001A0")]
			[FieldOffset(Offset = "0xA8")]
			public int[] heap;

			[Token(Token = "0x40001A1")]
			[FieldOffset(Offset = "0xB0")]
			public int[] weight;

			[Token(Token = "0x40001A2")]
			[FieldOffset(Offset = "0xB8")]
			public int[] parent;

			[Token(Token = "0x40001A3")]
			[FieldOffset(Offset = "0xC0")]
			public readonly int[] ftab;

			[Token(Token = "0x40001A4")]
			[FieldOffset(Offset = "0xC8")]
			public byte[] block;

			[Token(Token = "0x40001A5")]
			[FieldOffset(Offset = "0xD0")]
			public int[] fmap;

			[Token(Token = "0x40001A6")]
			[FieldOffset(Offset = "0xD8")]
			public char[] sfmap;

			[Token(Token = "0x40001A7")]
			[FieldOffset(Offset = "0xE0")]
			public char[] quadrant;

			[Token(Token = "0x600030D")]
			[Address(RVA = "0x78604C4", Offset = "0x785C4C4", VA = "0x78604C4")]
			public CompressionState(int blockSize100k)
			{
			}
		}

		[Token(Token = "0x4000173")]
		[FieldOffset(Offset = "0x10")]
		private int blockSize100k;

		[Token(Token = "0x4000174")]
		[FieldOffset(Offset = "0x14")]
		private int currentByte;

		[Token(Token = "0x4000175")]
		[FieldOffset(Offset = "0x18")]
		private int runLength;

		[Token(Token = "0x4000176")]
		[FieldOffset(Offset = "0x1C")]
		private int last;

		[Token(Token = "0x4000177")]
		[FieldOffset(Offset = "0x20")]
		private int outBlockFillThreshold;

		[Token(Token = "0x4000178")]
		[FieldOffset(Offset = "0x28")]
		private CompressionState cstate;

		[Token(Token = "0x4000179")]
		[FieldOffset(Offset = "0x30")]
		private readonly CRC32 crc;

		[Token(Token = "0x400017A")]
		[FieldOffset(Offset = "0x38")]
		private BitWriter bw;

		[Token(Token = "0x400017B")]
		[FieldOffset(Offset = "0x40")]
		private int runs;

		[Token(Token = "0x400017C")]
		[FieldOffset(Offset = "0x44")]
		private int workDone;

		[Token(Token = "0x400017D")]
		[FieldOffset(Offset = "0x48")]
		private int workLimit;

		[Token(Token = "0x400017E")]
		[FieldOffset(Offset = "0x4C")]
		private bool firstAttempt;

		[Token(Token = "0x400017F")]
		[FieldOffset(Offset = "0x4D")]
		private bool blockRandomised;

		[Token(Token = "0x4000180")]
		[FieldOffset(Offset = "0x50")]
		private int origPtr;

		[Token(Token = "0x4000181")]
		[FieldOffset(Offset = "0x54")]
		private int nInUse;

		[Token(Token = "0x4000182")]
		[FieldOffset(Offset = "0x58")]
		private int nMTF;

		[Token(Token = "0x4000183")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int SETMASK;

		[Token(Token = "0x4000184")]
		[FieldOffset(Offset = "0x4")]
		private static readonly int CLEARMASK;

		[Token(Token = "0x4000185")]
		[FieldOffset(Offset = "0x8")]
		private static readonly byte GREATER_ICOST;

		[Token(Token = "0x4000186")]
		[FieldOffset(Offset = "0x9")]
		private static readonly byte LESSER_ICOST;

		[Token(Token = "0x4000187")]
		[FieldOffset(Offset = "0xC")]
		private static readonly int SMALL_THRESH;

		[Token(Token = "0x4000188")]
		[FieldOffset(Offset = "0x10")]
		private static readonly int DEPTH_THRESH;

		[Token(Token = "0x4000189")]
		[FieldOffset(Offset = "0x14")]
		private static readonly int WORK_FACTOR;

		[Token(Token = "0x400018A")]
		[FieldOffset(Offset = "0x18")]
		private static readonly int[] increments;

		[Token(Token = "0x170000C5")]
		public int BlockSize
		{
			[Token(Token = "0x60002EF")]
			[Address(RVA = "0x785CAC8", Offset = "0x7858AC8", VA = "0x785CAC8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000C6")]
		public uint Crc32
		{
			[Token(Token = "0x60002F0")]
			[Address(RVA = "0x785CAD0", Offset = "0x7858AD0", VA = "0x785CAD0")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x60002F1")]
			[Address(RVA = "0x785CAD8", Offset = "0x7858AD8", VA = "0x785CAD8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000C7")]
		public int AvailableBytesOut
		{
			[Token(Token = "0x60002F2")]
			[Address(RVA = "0x785CAE0", Offset = "0x7858AE0", VA = "0x785CAE0")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x60002F3")]
			[Address(RVA = "0x785CAE8", Offset = "0x7858AE8", VA = "0x785CAE8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000C8")]
		public int UncompressedBytes
		{
			[Token(Token = "0x60002F4")]
			[Address(RVA = "0x785CAF0", Offset = "0x7858AF0", VA = "0x785CAF0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x785C828", Offset = "0x7858828", VA = "0x785C828")]
		public BZip2Compressor(BitWriter writer)
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x785C898", Offset = "0x7858898", VA = "0x785C898")]
		public BZip2Compressor(BitWriter writer, int blockSize)
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x785C998", Offset = "0x7858998", VA = "0x785C998")]
		private void Reset()
		{
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x785CAFC", Offset = "0x7858AFC", VA = "0x785CAFC")]
		public int Fill(byte[] buffer, int offset, int count)
		{
			return default;
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x785CB98", Offset = "0x7858B98", VA = "0x785CB98")]
		private int write0(byte b)
		{
			return default;
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x785CC40", Offset = "0x7858C40", VA = "0x785CC40")]
		private bool AddRunToOutputBlock(bool final)
		{
			return default;
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x785CEF8", Offset = "0x7858EF8", VA = "0x785CEF8")]
		public void CompressAndWrite()
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x785D154", Offset = "0x7859154", VA = "0x785D154")]
		private void randomiseBlock()
		{
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x785D298", Offset = "0x7859298", VA = "0x785D298")]
		private void mainSort()
		{
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x785D018", Offset = "0x7859018", VA = "0x785D018")]
		private void blockSort()
		{
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x785E10C", Offset = "0x785A10C", VA = "0x785E10C")]
		private bool mainSimpleSort(CompressionState dataShadow, int lo, int hi, int d)
		{
			return default;
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x785E6D8", Offset = "0x785A6D8", VA = "0x785E6D8")]
		private static void vswap(int[] fmap, int p1, int p2, int n)
		{
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x785E744", Offset = "0x785A744", VA = "0x785E744")]
		private static byte med3(byte a, byte b, byte c)
		{
			return default;
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x785DBA8", Offset = "0x7859BA8", VA = "0x785DBA8")]
		private void mainQSort3(CompressionState dataShadow, int loSt, int hiSt, int dSt)
		{
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x785E78C", Offset = "0x785A78C", VA = "0x785E78C")]
		private void generateMTFValues()
		{
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x785EB94", Offset = "0x785AB94", VA = "0x785EB94")]
		private static void hbAssignCodes(int[] code, byte[] length, int minLen, int maxLen, int alphaSize)
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x785EC1C", Offset = "0x785AC1C", VA = "0x785EC1C")]
		private void sendMTFValues()
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x785EDE0", Offset = "0x785ADE0", VA = "0x785EDE0")]
		private void sendMTFValues0(int nGroups, int alphaSize)
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x785FEE4", Offset = "0x785BEE4", VA = "0x785FEE4")]
		private static void hbMakeCodeLengths(byte[] len, int[] freq, CompressionState state1, int alphaSize, int maxLen)
		{
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x785F00C", Offset = "0x785B00C", VA = "0x785F00C")]
		private int sendMTFValues1(int nGroups, int alphaSize)
		{
			return default;
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x785F738", Offset = "0x785B738", VA = "0x785F738")]
		private void sendMTFValues2(int nGroups, int nSelectors)
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x785F830", Offset = "0x785B830", VA = "0x785F830")]
		private void sendMTFValues3(int nGroups, int alphaSize)
		{
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x785F978", Offset = "0x785B978", VA = "0x785F978")]
		private void sendMTFValues4()
		{
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x785FB00", Offset = "0x785BB00", VA = "0x785FB00")]
		private void sendMTFValues5(int nGroups, int nSelectors)
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x785FBD8", Offset = "0x785BBD8", VA = "0x785FBD8")]
		private void sendMTFValues6(int nGroups, int alphaSize)
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x785FD1C", Offset = "0x785BD1C", VA = "0x785FD1C")]
		private void sendMTFValues7(int nSelectors)
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x785D11C", Offset = "0x785911C", VA = "0x785D11C")]
		private void moveToFrontCodeAndSend()
		{
		}
	}
}
