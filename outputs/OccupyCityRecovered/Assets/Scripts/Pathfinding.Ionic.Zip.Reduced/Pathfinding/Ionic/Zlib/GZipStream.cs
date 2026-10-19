using System;
using System.IO;
using System.Text;
using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zlib
{
	[Token(Token = "0x2000050")]
	public class GZipStream : Stream
	{
		[Token(Token = "0x400027A")]
		[FieldOffset(Offset = "0x28")]
		public DateTime? LastModified;

		[Token(Token = "0x400027B")]
		[FieldOffset(Offset = "0x38")]
		private int _headerByteCount;

		[Token(Token = "0x400027C")]
		[FieldOffset(Offset = "0x40")]
		internal ZlibBaseStream _baseStream;

		[Token(Token = "0x400027D")]
		[FieldOffset(Offset = "0x48")]
		private bool _disposed;

		[Token(Token = "0x400027E")]
		[FieldOffset(Offset = "0x49")]
		private bool _firstReadDone;

		[Token(Token = "0x400027F")]
		[FieldOffset(Offset = "0x50")]
		private string _FileName;

		[Token(Token = "0x4000280")]
		[FieldOffset(Offset = "0x58")]
		private string _Comment;

		[Token(Token = "0x4000281")]
		[FieldOffset(Offset = "0x60")]
		private int _Crc32;

		[Token(Token = "0x4000282")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly DateTime _unixEpoch;

		[Token(Token = "0x4000283")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly Encoding iso8859dash1;

		[Token(Token = "0x170000EB")]
		public string Comment
		{
			[Token(Token = "0x60003C9")]
			[Address(RVA = "0x786B8E4", Offset = "0x78678E4", VA = "0x786B8E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003CA")]
			[Address(RVA = "0x786B8EC", Offset = "0x78678EC", VA = "0x786B8EC")]
			set
			{
			}
		}

		[Token(Token = "0x170000EC")]
		public string FileName
		{
			[Token(Token = "0x60003CB")]
			[Address(RVA = "0x786B94C", Offset = "0x786794C", VA = "0x786B94C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003CC")]
			[Address(RVA = "0x786B954", Offset = "0x7867954", VA = "0x786B954")]
			set
			{
			}
		}

		[Token(Token = "0x170000ED")]
		public int Crc32
		{
			[Token(Token = "0x60003CD")]
			[Address(RVA = "0x786BAEC", Offset = "0x7867AEC", VA = "0x786BAEC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000EE")]
		public virtual FlushType FlushMode
		{
			[Token(Token = "0x60003CE")]
			[Address(RVA = "0x786BAF4", Offset = "0x7867AF4", VA = "0x786BAF4", Slot = "40")]
			get
			{
				return default;
			}
			[Token(Token = "0x60003CF")]
			[Address(RVA = "0x786BB10", Offset = "0x7867B10", VA = "0x786BB10", Slot = "41")]
			set
			{
			}
		}

		[Token(Token = "0x170000EF")]
		public int BufferSize
		{
			[Token(Token = "0x60003D0")]
			[Address(RVA = "0x786BB7C", Offset = "0x7867B7C", VA = "0x786BB7C")]
			get
			{
				return default;
			}
			[Token(Token = "0x60003D1")]
			[Address(RVA = "0x786BB98", Offset = "0x7867B98", VA = "0x786BB98")]
			set
			{
			}
		}

		[Token(Token = "0x170000F0")]
		public virtual long TotalIn
		{
			[Token(Token = "0x60003D2")]
			[Address(RVA = "0x786BCE4", Offset = "0x7867CE4", VA = "0x786BCE4", Slot = "42")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000F1")]
		public virtual long TotalOut
		{
			[Token(Token = "0x60003D3")]
			[Address(RVA = "0x786BD08", Offset = "0x7867D08", VA = "0x786BD08", Slot = "43")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000F2")]
		public override bool CanRead
		{
			[Token(Token = "0x60003D5")]
			[Address(RVA = "0x786BE18", Offset = "0x7867E18", VA = "0x786BE18", Slot = "7")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000F3")]
		public override bool CanSeek
		{
			[Token(Token = "0x60003D6")]
			[Address(RVA = "0x786BE90", Offset = "0x7867E90", VA = "0x786BE90", Slot = "8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000F4")]
		public override bool CanWrite
		{
			[Token(Token = "0x60003D7")]
			[Address(RVA = "0x786BE98", Offset = "0x7867E98", VA = "0x786BE98", Slot = "10")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000F5")]
		public override long Length
		{
			[Token(Token = "0x60003D9")]
			[Address(RVA = "0x786BF84", Offset = "0x7867F84", VA = "0x786BF84", Slot = "11")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000F6")]
		public override long Position
		{
			[Token(Token = "0x60003DA")]
			[Address(RVA = "0x786BFBC", Offset = "0x7867FBC", VA = "0x786BFBC", Slot = "12")]
			get
			{
				return default;
			}
			[Token(Token = "0x60003DB")]
			[Address(RVA = "0x786C01C", Offset = "0x786801C", VA = "0x786C01C", Slot = "13")]
			set
			{
			}
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x786B760", Offset = "0x7867760", VA = "0x786B760")]
		public GZipStream(Stream stream, CompressionMode mode)
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x786B828", Offset = "0x7867828", VA = "0x786B828")]
		public GZipStream(Stream stream, CompressionMode mode, CompressionLevel level)
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x786B830", Offset = "0x7867830", VA = "0x786B830")]
		public GZipStream(Stream stream, CompressionMode mode, bool leaveOpen)
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x786B76C", Offset = "0x786776C", VA = "0x786B76C")]
		public GZipStream(Stream stream, CompressionMode mode, CompressionLevel level, bool leaveOpen)
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x786BD2C", Offset = "0x7867D2C", VA = "0x786BD2C", Slot = "21")]
		protected override void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x786BF10", Offset = "0x7867F10", VA = "0x786BF10", Slot = "22")]
		public override void Flush()
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x786C054", Offset = "0x7868054", VA = "0x786C054", Slot = "34")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default;
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x786C118", Offset = "0x7868118", VA = "0x786C118", Slot = "32")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default;
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x786C150", Offset = "0x7868150", VA = "0x786C150", Slot = "33")]
		public override void SetLength(long value)
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x786C188", Offset = "0x7868188", VA = "0x786C188", Slot = "37")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x786C27C", Offset = "0x786827C", VA = "0x786C27C")]
		private int EmitHeader()
		{
			return default;
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x786C64C", Offset = "0x786864C", VA = "0x786C64C")]
		public static byte[] CompressString(string s)
		{
			return null;
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x786C840", Offset = "0x7868840", VA = "0x786C840")]
		public static byte[] CompressBuffer(byte[] b)
		{
			return null;
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x786CA34", Offset = "0x7868A34", VA = "0x786CA34")]
		public static string UncompressString(byte[] compressed)
		{
			return null;
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x786CC0C", Offset = "0x7868C0C", VA = "0x786CC0C")]
		public static byte[] UncompressBuffer(byte[] compressed)
		{
			return null;
		}
	}
}
