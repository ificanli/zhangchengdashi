using System;
using System.IO;
using Il2CppDummyDll;

namespace Pathfinding.Ionic.Crc
{
	[Token(Token = "0x200006C")]
	public class CrcCalculatorStream : Stream, IDisposable
	{
		[Token(Token = "0x40003A3")]
		[FieldOffset(Offset = "0x0")]
		private static readonly long UnsetLengthLimit;

		[Token(Token = "0x40003A4")]
		[FieldOffset(Offset = "0x28")]
		internal Stream _innerStream;

		[Token(Token = "0x40003A5")]
		[FieldOffset(Offset = "0x30")]
		private CRC32 _Crc32;

		[Token(Token = "0x40003A6")]
		[FieldOffset(Offset = "0x38")]
		private long _lengthLimit;

		[Token(Token = "0x40003A7")]
		[FieldOffset(Offset = "0x40")]
		private bool _leaveOpen;

		[Token(Token = "0x17000117")]
		public long TotalBytesSlurped
		{
			[Token(Token = "0x60004A3")]
			[Address(RVA = "0x7878354", Offset = "0x7874354", VA = "0x7878354")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000118")]
		public int Crc
		{
			[Token(Token = "0x60004A4")]
			[Address(RVA = "0x7878370", Offset = "0x7874370", VA = "0x7878370")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000119")]
		public bool LeaveOpen
		{
			[Token(Token = "0x60004A5")]
			[Address(RVA = "0x7878390", Offset = "0x7874390", VA = "0x7878390")]
			get
			{
				return default;
			}
			[Token(Token = "0x60004A6")]
			[Address(RVA = "0x7878398", Offset = "0x7874398", VA = "0x7878398")]
			set
			{
			}
		}

		[Token(Token = "0x1700011A")]
		public override bool CanRead
		{
			[Token(Token = "0x60004A9")]
			[Address(RVA = "0x7878510", Offset = "0x7874510", VA = "0x7878510", Slot = "7")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700011B")]
		public override bool CanSeek
		{
			[Token(Token = "0x60004AA")]
			[Address(RVA = "0x7878530", Offset = "0x7874530", VA = "0x7878530", Slot = "8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700011C")]
		public override bool CanWrite
		{
			[Token(Token = "0x60004AB")]
			[Address(RVA = "0x7878538", Offset = "0x7874538", VA = "0x7878538", Slot = "10")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700011D")]
		public override long Length
		{
			[Token(Token = "0x60004AD")]
			[Address(RVA = "0x787857C", Offset = "0x787457C", VA = "0x787857C", Slot = "11")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700011E")]
		public override long Position
		{
			[Token(Token = "0x60004AE")]
			[Address(RVA = "0x7878608", Offset = "0x7874608", VA = "0x7878608", Slot = "12")]
			get
			{
				return default;
			}
			[Token(Token = "0x60004AF")]
			[Address(RVA = "0x7878624", Offset = "0x7874624", VA = "0x7878624", Slot = "13")]
			set
			{
			}
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x7877FDC", Offset = "0x7873FDC", VA = "0x7877FDC")]
		public CrcCalculatorStream(Stream stream)
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x7878134", Offset = "0x7874134", VA = "0x7878134")]
		public CrcCalculatorStream(Stream stream, bool leaveOpen)
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x78781B0", Offset = "0x78741B0", VA = "0x78781B0")]
		public CrcCalculatorStream(Stream stream, long length)
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x787821C", Offset = "0x787421C", VA = "0x787821C")]
		public CrcCalculatorStream(Stream stream, long length, bool leaveOpen)
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x787828C", Offset = "0x787428C", VA = "0x787828C")]
		public CrcCalculatorStream(Stream stream, long length, bool leaveOpen, CRC32 crc32)
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x7878054", Offset = "0x7874054", VA = "0x7878054")]
		private CrcCalculatorStream(bool leaveOpen, long length, Stream stream, CRC32 crc32)
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x7878344", Offset = "0x7874344", VA = "0x7878344", Slot = "6")]
void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x78783A4", Offset = "0x78743A4", VA = "0x78783A4", Slot = "34")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default;
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x78784A0", Offset = "0x78744A0", VA = "0x78784A0", Slot = "37")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x7878558", Offset = "0x7874558", VA = "0x7878558", Slot = "22")]
		public override void Flush()
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x787865C", Offset = "0x787465C", VA = "0x787865C", Slot = "32")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default;
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x7878694", Offset = "0x7874694", VA = "0x7878694", Slot = "33")]
		public override void SetLength(long value)
		{
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x78786CC", Offset = "0x78746CC", VA = "0x78786CC", Slot = "20")]
		public override void Close()
		{
		}
	}
}
