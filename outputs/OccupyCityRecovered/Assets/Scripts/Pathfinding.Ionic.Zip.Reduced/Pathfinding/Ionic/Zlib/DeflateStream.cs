using System.IO;
using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zlib
{
	[Token(Token = "0x200004F")]
	public class DeflateStream : Stream
	{
		[Token(Token = "0x4000277")]
		[FieldOffset(Offset = "0x28")]
		internal ZlibBaseStream _baseStream;

		[Token(Token = "0x4000278")]
		[FieldOffset(Offset = "0x30")]
		internal Stream _innerStream;

		[Token(Token = "0x4000279")]
		[FieldOffset(Offset = "0x38")]
		private bool _disposed;

		[Token(Token = "0x170000E1")]
		public virtual FlushType FlushMode
		{
			[Token(Token = "0x60003AC")]
			[Address(RVA = "0x786A8B8", Offset = "0x78668B8", VA = "0x786A8B8", Slot = "40")]
			get
			{
				return default;
			}
			[Token(Token = "0x60003AD")]
			[Address(RVA = "0x786A8D4", Offset = "0x78668D4", VA = "0x786A8D4", Slot = "41")]
			set
			{
			}
		}

		[Token(Token = "0x170000E2")]
		public int BufferSize
		{
			[Token(Token = "0x60003AE")]
			[Address(RVA = "0x786A940", Offset = "0x7866940", VA = "0x786A940")]
			get
			{
				return default;
			}
			[Token(Token = "0x60003AF")]
			[Address(RVA = "0x786A95C", Offset = "0x786695C", VA = "0x786A95C")]
			set
			{
			}
		}

		[Token(Token = "0x170000E3")]
		public CompressionStrategy Strategy
		{
			[Token(Token = "0x60003B0")]
			[Address(RVA = "0x786AAA8", Offset = "0x7866AA8", VA = "0x786AAA8")]
			get
			{
				return default;
			}
			[Token(Token = "0x60003B1")]
			[Address(RVA = "0x786AAC4", Offset = "0x7866AC4", VA = "0x786AAC4")]
			set
			{
			}
		}

		[Token(Token = "0x170000E4")]
		public virtual long TotalIn
		{
			[Token(Token = "0x60003B2")]
			[Address(RVA = "0x786AB30", Offset = "0x7866B30", VA = "0x786AB30", Slot = "42")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000E5")]
		public virtual long TotalOut
		{
			[Token(Token = "0x60003B3")]
			[Address(RVA = "0x786AB54", Offset = "0x7866B54", VA = "0x786AB54", Slot = "43")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000E6")]
		public override bool CanRead
		{
			[Token(Token = "0x60003B5")]
			[Address(RVA = "0x786AC44", Offset = "0x7866C44", VA = "0x786AC44", Slot = "7")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000E7")]
		public override bool CanSeek
		{
			[Token(Token = "0x60003B6")]
			[Address(RVA = "0x786ACBC", Offset = "0x7866CBC", VA = "0x786ACBC", Slot = "8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000E8")]
		public override bool CanWrite
		{
			[Token(Token = "0x60003B7")]
			[Address(RVA = "0x786ACC4", Offset = "0x7866CC4", VA = "0x786ACC4", Slot = "10")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000E9")]
		public override long Length
		{
			[Token(Token = "0x60003B9")]
			[Address(RVA = "0x786ADB0", Offset = "0x7866DB0", VA = "0x786ADB0", Slot = "11")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000EA")]
		public override long Position
		{
			[Token(Token = "0x60003BA")]
			[Address(RVA = "0x786ADE8", Offset = "0x7866DE8", VA = "0x786ADE8", Slot = "12")]
			get
			{
				return default;
			}
			[Token(Token = "0x60003BB")]
			[Address(RVA = "0x786AE38", Offset = "0x7866E38", VA = "0x786AE38", Slot = "13")]
			set
			{
			}
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x786A7D8", Offset = "0x78667D8", VA = "0x786A7D8")]
		public DeflateStream(Stream stream, CompressionMode mode)
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x786A8A4", Offset = "0x78668A4", VA = "0x786A8A4")]
		public DeflateStream(Stream stream, CompressionMode mode, CompressionLevel level)
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x786A8AC", Offset = "0x78668AC", VA = "0x786A8AC")]
		public DeflateStream(Stream stream, CompressionMode mode, bool leaveOpen)
		{
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x786A7E4", Offset = "0x78667E4", VA = "0x786A7E4")]
		public DeflateStream(Stream stream, CompressionMode mode, CompressionLevel level, bool leaveOpen)
		{
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x786AB78", Offset = "0x7866B78", VA = "0x786AB78", Slot = "21")]
		protected override void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x786AD3C", Offset = "0x7866D3C", VA = "0x786AD3C", Slot = "22")]
		public override void Flush()
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x786AE70", Offset = "0x7866E70", VA = "0x786AE70", Slot = "34")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default;
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x786AEE4", Offset = "0x7866EE4", VA = "0x786AEE4", Slot = "32")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default;
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x786AF1C", Offset = "0x7866F1C", VA = "0x786AF1C", Slot = "33")]
		public override void SetLength(long value)
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x786AF54", Offset = "0x7866F54", VA = "0x786AF54", Slot = "37")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x786AFC8", Offset = "0x7866FC8", VA = "0x786AFC8")]
		public static byte[] CompressString(string s)
		{
			return null;
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x786B1BC", Offset = "0x78671BC", VA = "0x786B1BC")]
		public static byte[] CompressBuffer(byte[] b)
		{
			return null;
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x786B3B0", Offset = "0x78673B0", VA = "0x786B3B0")]
		public static string UncompressString(byte[] compressed)
		{
			return null;
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x786B588", Offset = "0x7867588", VA = "0x786B588")]
		public static byte[] UncompressBuffer(byte[] compressed)
		{
			return null;
		}
	}
}
