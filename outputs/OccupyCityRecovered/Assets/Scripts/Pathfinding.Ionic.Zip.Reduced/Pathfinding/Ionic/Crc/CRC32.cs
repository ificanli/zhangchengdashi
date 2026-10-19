using System.IO;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Pathfinding.Ionic.Crc
{
	[Token(Token = "0x200006B")]
	[Guid("ebc25cf6-9120-4283-b972-0e5520d0000C")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.AutoDispatch)]
	public class CRC32
	{
		[Token(Token = "0x400039D")]
		private const int BUFFER_SIZE = 8192;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private uint dwPolynomial;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private long _TotalBytesRead;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool reverseBits;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private uint[] crc32Table;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private uint _register;

		[Token(Token = "0x17000115")]
		public long TotalBytesRead
		{
			[Token(Token = "0x600048B")]
			[Address(RVA = "0x7877BDC", Offset = "0x7873BDC", VA = "0x7877BDC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000116")]
		public int Crc32Result
		{
			[Token(Token = "0x600048C")]
			[Address(RVA = "0x78723F8", Offset = "0x786E3F8", VA = "0x78723F8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x7871BA8", Offset = "0x786DBA8", VA = "0x7871BA8")]
		public CRC32()
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x7877A30", Offset = "0x7873A30", VA = "0x7877A30")]
		public CRC32(bool reverseBits)
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x7877A70", Offset = "0x7873A70", VA = "0x7877A70")]
		public CRC32(int polynomial, bool reverseBits)
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x7877BE4", Offset = "0x7873BE4", VA = "0x7877BE4")]
		public int GetCrc32(Stream input)
		{
			return default;
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x7877BEC", Offset = "0x7873BEC", VA = "0x7877BEC")]
		public int GetCrc32AndCopy(Stream input, Stream output)
		{
			return default;
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x7877D70", Offset = "0x7873D70", VA = "0x7877D70")]
		public int ComputeCrc32(int W, byte B)
		{
			return default;
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x7877D74", Offset = "0x7873D74", VA = "0x7877D74")]
		internal int _InternalComputeCrc32(uint W, byte B)
		{
			return default;
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x7872CF0", Offset = "0x786ECF0", VA = "0x7872CF0")]
		public void SlurpBlock(byte[] block, int offset, int count)
		{
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x7877DB0", Offset = "0x7873DB0", VA = "0x7877DB0")]
		public void UpdateCRC(byte b)
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x7877E28", Offset = "0x7873E28", VA = "0x7877E28")]
		public void UpdateCRC(byte b, int n)
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x7877EB4", Offset = "0x7873EB4", VA = "0x7877EB4")]
		private static uint ReverseBits(uint data)
		{
			return default;
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x7877EBC", Offset = "0x7873EBC", VA = "0x7877EBC")]
		private static byte ReverseBits(byte data)
		{
			return default;
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x7877AAC", Offset = "0x7873AAC", VA = "0x7877AAC")]
		private void GenerateLookupTable()
		{
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x7877F08", Offset = "0x7873F08", VA = "0x7877F08")]
		private uint gf2_matrix_times(uint[] matrix, uint vec)
		{
			return default;
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x7877F5C", Offset = "0x7873F5C", VA = "0x7877F5C")]
		private void gf2_matrix_square(uint[] square, uint[] mat)
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x7872BA8", Offset = "0x786EBA8", VA = "0x7872BA8")]
		public void Combine(int crc, int length)
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x7877FD0", Offset = "0x7873FD0", VA = "0x7877FD0")]
		public void Reset()
		{
		}
	}
}
