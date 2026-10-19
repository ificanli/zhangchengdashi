using System.IO;
using Il2CppDummyDll;
using Pathfinding.Ionic.Crc;

namespace Pathfinding.Ionic.BZip2
{
	[Token(Token = "0x200003F")]
	public class BZip2InputStream : Stream
	{
		[Token(Token = "0x2000040")]
		private enum CState
		{
			[Token(Token = "0x40001C5")]
			EOF = 0,
			[Token(Token = "0x40001C6")]
			START_BLOCK = 1,
			[Token(Token = "0x40001C7")]
			RAND_PART_A = 2,
			[Token(Token = "0x40001C8")]
			RAND_PART_B = 3,
			[Token(Token = "0x40001C9")]
			RAND_PART_C = 4,
			[Token(Token = "0x40001CA")]
			NO_RAND_PART_A = 5,
			[Token(Token = "0x40001CB")]
			NO_RAND_PART_B = 6,
			[Token(Token = "0x40001CC")]
			NO_RAND_PART_C = 7
		}

		[Token(Token = "0x2000041")]
		private sealed class DecompressionState
		{
			[Token(Token = "0x40001CD")]
			[FieldOffset(Offset = "0x10")]
			public readonly bool[] inUse;

			[Token(Token = "0x40001CE")]
			[FieldOffset(Offset = "0x18")]
			public readonly byte[] seqToUnseq;

			[Token(Token = "0x40001CF")]
			[FieldOffset(Offset = "0x20")]
			public readonly byte[] selector;

			[Token(Token = "0x40001D0")]
			[FieldOffset(Offset = "0x28")]
			public readonly byte[] selectorMtf;

			[Token(Token = "0x40001D1")]
			[FieldOffset(Offset = "0x30")]
			public readonly int[] unzftab;

			[Token(Token = "0x40001D2")]
			[FieldOffset(Offset = "0x38")]
			public readonly int[][] gLimit;

			[Token(Token = "0x40001D3")]
			[FieldOffset(Offset = "0x40")]
			public readonly int[][] gBase;

			[Token(Token = "0x40001D4")]
			[FieldOffset(Offset = "0x48")]
			public readonly int[][] gPerm;

			[Token(Token = "0x40001D5")]
			[FieldOffset(Offset = "0x50")]
			public readonly int[] gMinlen;

			[Token(Token = "0x40001D6")]
			[FieldOffset(Offset = "0x58")]
			public readonly int[] cftab;

			[Token(Token = "0x40001D7")]
			[FieldOffset(Offset = "0x60")]
			public readonly byte[] getAndMoveToFrontDecode_yy;

			[Token(Token = "0x40001D8")]
			[FieldOffset(Offset = "0x68")]
			public readonly char[][] temp_charArray2d;

			[Token(Token = "0x40001D9")]
			[FieldOffset(Offset = "0x70")]
			public readonly byte[] recvDecodingTables_pos;

			[Token(Token = "0x40001DA")]
			[FieldOffset(Offset = "0x78")]
			public int[] tt;

			[Token(Token = "0x40001DB")]
			[FieldOffset(Offset = "0x80")]
			public byte[] ll8;

			[Token(Token = "0x6000334")]
			[Address(RVA = "0x7861C7C", Offset = "0x785DC7C", VA = "0x7861C7C")]
			public DecompressionState(int blockSize100k)
			{
			}

			[Token(Token = "0x6000335")]
			[Address(RVA = "0x7863224", Offset = "0x785F224", VA = "0x7863224")]
			public int[] initTT(int length)
			{
				return null;
			}
		}

		[Token(Token = "0x40001A8")]
		[FieldOffset(Offset = "0x28")]
		private bool _disposed;

		[Token(Token = "0x40001A9")]
		[FieldOffset(Offset = "0x29")]
		private bool _leaveOpen;

		[Token(Token = "0x40001AA")]
		[FieldOffset(Offset = "0x30")]
		private long totalBytesRead;

		[Token(Token = "0x40001AB")]
		[FieldOffset(Offset = "0x38")]
		private int last;

		[Token(Token = "0x40001AC")]
		[FieldOffset(Offset = "0x3C")]
		private int origPtr;

		[Token(Token = "0x40001AD")]
		[FieldOffset(Offset = "0x40")]
		private int blockSize100k;

		[Token(Token = "0x40001AE")]
		[FieldOffset(Offset = "0x44")]
		private bool blockRandomised;

		[Token(Token = "0x40001AF")]
		[FieldOffset(Offset = "0x48")]
		private int bsBuff;

		[Token(Token = "0x40001B0")]
		[FieldOffset(Offset = "0x4C")]
		private int bsLive;

		[Token(Token = "0x40001B1")]
		[FieldOffset(Offset = "0x50")]
		private readonly CRC32 crc;

		[Token(Token = "0x40001B2")]
		[FieldOffset(Offset = "0x58")]
		private int nInUse;

		[Token(Token = "0x40001B3")]
		[FieldOffset(Offset = "0x60")]
		private Stream input;

		[Token(Token = "0x40001B4")]
		[FieldOffset(Offset = "0x68")]
		private int currentChar;

		[Token(Token = "0x40001B5")]
		[FieldOffset(Offset = "0x6C")]
		private CState currentState;

		[Token(Token = "0x40001B6")]
		[FieldOffset(Offset = "0x70")]
		private uint storedBlockCRC;

		[Token(Token = "0x40001B7")]
		[FieldOffset(Offset = "0x74")]
		private uint storedCombinedCRC;

		[Token(Token = "0x40001B8")]
		[FieldOffset(Offset = "0x78")]
		private uint computedBlockCRC;

		[Token(Token = "0x40001B9")]
		[FieldOffset(Offset = "0x7C")]
		private uint computedCombinedCRC;

		[Token(Token = "0x40001BA")]
		[FieldOffset(Offset = "0x80")]
		private int su_count;

		[Token(Token = "0x40001BB")]
		[FieldOffset(Offset = "0x84")]
		private int su_ch2;

		[Token(Token = "0x40001BC")]
		[FieldOffset(Offset = "0x88")]
		private int su_chPrev;

		[Token(Token = "0x40001BD")]
		[FieldOffset(Offset = "0x8C")]
		private int su_i2;

		[Token(Token = "0x40001BE")]
		[FieldOffset(Offset = "0x90")]
		private int su_j2;

		[Token(Token = "0x40001BF")]
		[FieldOffset(Offset = "0x94")]
		private int su_rNToGo;

		[Token(Token = "0x40001C0")]
		[FieldOffset(Offset = "0x98")]
		private int su_rTPos;

		[Token(Token = "0x40001C1")]
		[FieldOffset(Offset = "0x9C")]
		private int su_tPos;

		[Token(Token = "0x40001C2")]
		[FieldOffset(Offset = "0xA0")]
		private char su_z;

		[Token(Token = "0x40001C3")]
		[FieldOffset(Offset = "0xA8")]
		private DecompressionState data;

		[Token(Token = "0x170000C9")]
		public override bool CanRead
		{
			[Token(Token = "0x6000313")]
			[Address(RVA = "0x786104C", Offset = "0x785D04C", VA = "0x786104C", Slot = "7")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000CA")]
		public override bool CanSeek
		{
			[Token(Token = "0x6000314")]
			[Address(RVA = "0x78610BC", Offset = "0x785D0BC", VA = "0x78610BC", Slot = "8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000CB")]
		public override bool CanWrite
		{
			[Token(Token = "0x6000315")]
			[Address(RVA = "0x78610C4", Offset = "0x785D0C4", VA = "0x78610C4", Slot = "10")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000CC")]
		public override long Length
		{
			[Token(Token = "0x6000317")]
			[Address(RVA = "0x78611A8", Offset = "0x785D1A8", VA = "0x78611A8", Slot = "11")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000CD")]
		public override long Position
		{
			[Token(Token = "0x6000318")]
			[Address(RVA = "0x78611E0", Offset = "0x785D1E0", VA = "0x78611E0", Slot = "12")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000319")]
			[Address(RVA = "0x78611E8", Offset = "0x785D1E8", VA = "0x78611E8", Slot = "13")]
			set
			{
			}
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x7860818", Offset = "0x785C818", VA = "0x7860818")]
		public BZip2InputStream(Stream input)
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x7860820", Offset = "0x785C820", VA = "0x7860820")]
		public BZip2InputStream(Stream input, bool leaveOpen)
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x7860A54", Offset = "0x785CA54", VA = "0x7860A54", Slot = "34")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default;
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x7860C74", Offset = "0x785CC74", VA = "0x7860C74")]
		private void MakeMaps()
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x7860CE8", Offset = "0x785CCE8", VA = "0x7860CE8", Slot = "36")]
		public override int ReadByte()
		{
			return default;
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x7861134", Offset = "0x785D134", VA = "0x7861134", Slot = "22")]
		public override void Flush()
		{
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x7861220", Offset = "0x785D220", VA = "0x7861220", Slot = "32")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default;
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x7861258", Offset = "0x785D258", VA = "0x7861258", Slot = "33")]
		public override void SetLength(long value)
		{
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x7861290", Offset = "0x785D290", VA = "0x7861290", Slot = "37")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x78612C8", Offset = "0x785D2C8", VA = "0x78612C8", Slot = "21")]
		protected override void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x78608E0", Offset = "0x785C8E0", VA = "0x78608E0")]
		private void init()
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x7861394", Offset = "0x785D394", VA = "0x7861394")]
		private void CheckMagicChar(char expected, int position)
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x7861498", Offset = "0x785D498", VA = "0x7861498")]
		private void InitBlock()
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x7862788", Offset = "0x785E788", VA = "0x7862788")]
		private void EndBlock()
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x7861A80", Offset = "0x785DA80", VA = "0x7861A80")]
		private void complete()
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x786286C", Offset = "0x785E86C", VA = "0x786286C", Slot = "20")]
		public override void Close()
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x7861BB8", Offset = "0x785DBB8", VA = "0x7861BB8")]
		private int GetBits(int n)
		{
			return default;
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x78628FC", Offset = "0x785E8FC", VA = "0x78628FC")]
		private bool bsGetBit()
		{
			return default;
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x7861A6C", Offset = "0x785DA6C", VA = "0x7861A6C")]
		private char bsGetUByte()
		{
			return default;
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x7861B50", Offset = "0x785DB50", VA = "0x7861B50")]
		private uint bsGetInt()
		{
			return default;
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x7862918", Offset = "0x785E918", VA = "0x7862918")]
		private static void hbCreateDecodeTables(int[] limit, int[] bbase, int[] perm, char[] length, int minLen, int maxLen, int alphaSize)
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x7862BE8", Offset = "0x785EBE8", VA = "0x7862BE8")]
		private void recvDecodingTables()
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x7862F08", Offset = "0x785EF08", VA = "0x7862F08")]
		private void createHuffmanDecodingTables(int alphaSize, int nGroups)
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x7861E8C", Offset = "0x785DE8C", VA = "0x7861E8C")]
		private void getAndMoveToFrontDecode()
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x7863044", Offset = "0x785F044", VA = "0x7863044")]
		private int getAndMoveToFrontDecode0(int groupNo)
		{
			return default;
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x78616E0", Offset = "0x785D6E0", VA = "0x78616E0")]
		private void SetupBlock()
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x786328C", Offset = "0x785F28C", VA = "0x786328C")]
		private void SetupRandPartA()
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x78633CC", Offset = "0x785F3CC", VA = "0x78633CC")]
		private void SetupNoRandPartA()
		{
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x7860D94", Offset = "0x785CD94", VA = "0x7860D94")]
		private void SetupRandPartB()
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x7860EE0", Offset = "0x785CEE0", VA = "0x7860EE0")]
		private void SetupRandPartC()
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x7860F4C", Offset = "0x785CF4C", VA = "0x7860F4C")]
		private void SetupNoRandPartB()
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x7860FE0", Offset = "0x785CFE0", VA = "0x7860FE0")]
		private void SetupNoRandPartC()
		{
		}
	}
}
