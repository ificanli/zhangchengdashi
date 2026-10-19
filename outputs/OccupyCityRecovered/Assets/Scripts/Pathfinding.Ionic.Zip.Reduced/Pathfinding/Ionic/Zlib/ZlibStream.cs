using System.IO;
using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zlib
{
	[Token(Token = "0x200006A")]
	public class ZlibStream : Stream
	{
		[Token(Token = "0x400039B")]
		[FieldOffset(Offset = "0x28")]
		internal ZlibBaseStream _baseStream;

		[Token(Token = "0x400039C")]
		[FieldOffset(Offset = "0x30")]
		private bool _disposed;

		[Token(Token = "0x1700010C")]
		public virtual FlushType FlushMode
		{
			[Token(Token = "0x6000472")]
			[Address(RVA = "0x7876C30", Offset = "0x7872C30", VA = "0x7876C30", Slot = "40")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000473")]
			[Address(RVA = "0x7876C4C", Offset = "0x7872C4C", VA = "0x7876C4C", Slot = "41")]
			set
			{
			}
		}

		[Token(Token = "0x1700010D")]
		public int BufferSize
		{
			[Token(Token = "0x6000474")]
			[Address(RVA = "0x7876CB8", Offset = "0x7872CB8", VA = "0x7876CB8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000475")]
			[Address(RVA = "0x7876CD4", Offset = "0x7872CD4", VA = "0x7876CD4")]
			set
			{
			}
		}

		[Token(Token = "0x1700010E")]
		public virtual long TotalIn
		{
			[Token(Token = "0x6000476")]
			[Address(RVA = "0x7876E18", Offset = "0x7872E18", VA = "0x7876E18", Slot = "42")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700010F")]
		public virtual long TotalOut
		{
			[Token(Token = "0x6000477")]
			[Address(RVA = "0x7876E3C", Offset = "0x7872E3C", VA = "0x7876E3C", Slot = "43")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000110")]
		public override bool CanRead
		{
			[Token(Token = "0x6000479")]
			[Address(RVA = "0x7876F2C", Offset = "0x7872F2C", VA = "0x7876F2C", Slot = "7")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000111")]
		public override bool CanSeek
		{
			[Token(Token = "0x600047A")]
			[Address(RVA = "0x7876FA4", Offset = "0x7872FA4", VA = "0x7876FA4", Slot = "8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000112")]
		public override bool CanWrite
		{
			[Token(Token = "0x600047B")]
			[Address(RVA = "0x7876FAC", Offset = "0x7872FAC", VA = "0x7876FAC", Slot = "10")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000113")]
		public override long Length
		{
			[Token(Token = "0x600047D")]
			[Address(RVA = "0x7877098", Offset = "0x7873098", VA = "0x7877098", Slot = "11")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000114")]
		public override long Position
		{
			[Token(Token = "0x600047E")]
			[Address(RVA = "0x78770D0", Offset = "0x78730D0", VA = "0x78770D0", Slot = "12")]
			get
			{
				return default;
			}
			[Token(Token = "0x600047F")]
			[Address(RVA = "0x7877120", Offset = "0x7873120", VA = "0x7877120", Slot = "13")]
			set
			{
			}
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x7876B58", Offset = "0x7872B58", VA = "0x7876B58")]
		public ZlibStream(Stream stream, CompressionMode mode)
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x7876C1C", Offset = "0x7872C1C", VA = "0x7876C1C")]
		public ZlibStream(Stream stream, CompressionMode mode, CompressionLevel level)
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x7876C24", Offset = "0x7872C24", VA = "0x7876C24")]
		public ZlibStream(Stream stream, CompressionMode mode, bool leaveOpen)
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x7876B64", Offset = "0x7872B64", VA = "0x7876B64")]
		public ZlibStream(Stream stream, CompressionMode mode, CompressionLevel level, bool leaveOpen)
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x7876E60", Offset = "0x7872E60", VA = "0x7876E60", Slot = "21")]
		protected override void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x7877024", Offset = "0x7873024", VA = "0x7877024", Slot = "22")]
		public override void Flush()
		{
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x7877158", Offset = "0x7873158", VA = "0x7877158", Slot = "34")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default;
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x78771CC", Offset = "0x78731CC", VA = "0x78771CC", Slot = "32")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default;
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x7877204", Offset = "0x7873204", VA = "0x7877204", Slot = "33")]
		public override void SetLength(long value)
		{
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x787723C", Offset = "0x787323C", VA = "0x787723C", Slot = "37")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x78772B0", Offset = "0x78732B0", VA = "0x78772B0")]
		public static byte[] CompressString(string s)
		{
			return null;
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x78774A0", Offset = "0x78734A0", VA = "0x78774A0")]
		public static byte[] CompressBuffer(byte[] b)
		{
			return null;
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x7877690", Offset = "0x7873690", VA = "0x7877690")]
		public static string UncompressString(byte[] compressed)
		{
			return null;
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x7877860", Offset = "0x7873860", VA = "0x7877860")]
		public static byte[] UncompressBuffer(byte[] compressed)
		{
			return null;
		}
	}
}
