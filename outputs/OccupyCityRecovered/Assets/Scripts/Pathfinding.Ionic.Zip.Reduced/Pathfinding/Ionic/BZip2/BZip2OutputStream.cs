using System;
using System.Diagnostics;
using System.IO;
using Il2CppDummyDll;

namespace Pathfinding.Ionic.BZip2
{
	[Token(Token = "0x2000043")]
	public class BZip2OutputStream : Stream
	{
		[Token(Token = "0x2000044")]
		[Flags]
		private enum TraceBits : uint
		{
			[Token(Token = "0x40001F2")]
			None = 0u,
			[Token(Token = "0x40001F3")]
			Crc = 1u,
			[Token(Token = "0x40001F4")]
			Write = 2u,
			[Token(Token = "0x40001F5")]
			All = uint.MaxValue
		}

		[Token(Token = "0x40001E9")]
		[FieldOffset(Offset = "0x28")]
		private int totalBytesWrittenIn;

		[Token(Token = "0x40001EA")]
		[FieldOffset(Offset = "0x2C")]
		private bool leaveOpen;

		[Token(Token = "0x40001EB")]
		[FieldOffset(Offset = "0x30")]
		private BZip2Compressor compressor;

		[Token(Token = "0x40001EC")]
		[FieldOffset(Offset = "0x38")]
		private uint combinedCRC;

		[Token(Token = "0x40001ED")]
		[FieldOffset(Offset = "0x40")]
		private Stream output;

		[Token(Token = "0x40001EE")]
		[FieldOffset(Offset = "0x48")]
		private BitWriter bw;

		[Token(Token = "0x40001EF")]
		[FieldOffset(Offset = "0x50")]
		private int blockSize100k;

		[Token(Token = "0x40001F0")]
		[FieldOffset(Offset = "0x54")]
		private TraceBits desiredTrace;

		[Token(Token = "0x170000CE")]
		public int BlockSize
		{
			[Token(Token = "0x6000341")]
			[Address(RVA = "0x7863CE8", Offset = "0x785FCE8", VA = "0x7863CE8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000CF")]
		public override bool CanRead
		{
			[Token(Token = "0x6000343")]
			[Address(RVA = "0x7863F38", Offset = "0x785FF38", VA = "0x7863F38", Slot = "7")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000D0")]
		public override bool CanSeek
		{
			[Token(Token = "0x6000344")]
			[Address(RVA = "0x7863F40", Offset = "0x785FF40", VA = "0x7863F40", Slot = "8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000D1")]
		public override bool CanWrite
		{
			[Token(Token = "0x6000345")]
			[Address(RVA = "0x7863F48", Offset = "0x785FF48", VA = "0x7863F48", Slot = "10")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000D2")]
		public override long Length
		{
			[Token(Token = "0x6000346")]
			[Address(RVA = "0x7863FAC", Offset = "0x785FFAC", VA = "0x7863FAC", Slot = "11")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000D3")]
		public override long Position
		{
			[Token(Token = "0x6000347")]
			[Address(RVA = "0x7863FE4", Offset = "0x785FFE4", VA = "0x7863FE4", Slot = "12")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000348")]
			[Address(RVA = "0x7863FEC", Offset = "0x785FFEC", VA = "0x7863FEC", Slot = "13")]
			set
			{
			}
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x7863578", Offset = "0x785F578", VA = "0x7863578")]
		public BZip2OutputStream(Stream output)
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x78638C8", Offset = "0x785F8C8", VA = "0x78638C8")]
		public BZip2OutputStream(Stream output, int blockSize)
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x78638D0", Offset = "0x785F8D0", VA = "0x78638D0")]
		public BZip2OutputStream(Stream output, bool leaveOpen)
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x78635EC", Offset = "0x785F5EC", VA = "0x78635EC")]
		public BZip2OutputStream(Stream output, int blockSize, bool leaveOpen)
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x7863A28", Offset = "0x785FA28", VA = "0x7863A28", Slot = "20")]
		public override void Close()
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x7863B38", Offset = "0x785FB38", VA = "0x7863B38", Slot = "22")]
		public override void Flush()
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x7863970", Offset = "0x785F970", VA = "0x7863970")]
		private void EmitHeader()
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x7863B90", Offset = "0x785FB90", VA = "0x7863B90")]
		private void EmitTrailer()
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x7863A70", Offset = "0x785FA70", VA = "0x7863A70")]
		private void Finish()
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x7863CF0", Offset = "0x785FCF0", VA = "0x7863CF0", Slot = "37")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x7864024", Offset = "0x7860024", VA = "0x7864024", Slot = "32")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default;
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x786405C", Offset = "0x786005C", VA = "0x786405C", Slot = "33")]
		public override void SetLength(long value)
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x7864094", Offset = "0x7860094", VA = "0x7864094", Slot = "34")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default;
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x78640CC", Offset = "0x78600CC", VA = "0x78640CC")]
		[Conditional("Trace")]
		private void TraceOutput(TraceBits bits, string format, params object[] varParams)
		{
		}
	}
}
