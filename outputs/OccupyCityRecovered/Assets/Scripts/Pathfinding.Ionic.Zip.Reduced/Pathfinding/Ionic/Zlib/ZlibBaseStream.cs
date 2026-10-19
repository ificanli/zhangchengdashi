using System;
using System.IO;
using Il2CppDummyDll;
using Pathfinding.Ionic.Crc;

namespace Pathfinding.Ionic.Zlib
{
	[Token(Token = "0x2000066")]
	internal class ZlibBaseStream : Stream
	{
		[Token(Token = "0x2000067")]
		internal enum StreamMode
		{
			[Token(Token = "0x400037F")]
			Writer = 0,
			[Token(Token = "0x4000380")]
			Reader = 1,
			[Token(Token = "0x4000381")]
			Undefined = 2
		}

		[Token(Token = "0x400036C")]
		[FieldOffset(Offset = "0x28")]
		protected internal ZlibCodec _z;

		[Token(Token = "0x400036D")]
		[FieldOffset(Offset = "0x30")]
		protected internal StreamMode _streamMode;

		[Token(Token = "0x400036E")]
		[FieldOffset(Offset = "0x34")]
		protected internal FlushType _flushMode;

		[Token(Token = "0x400036F")]
		[FieldOffset(Offset = "0x38")]
		protected internal ZlibStreamFlavor _flavor;

		[Token(Token = "0x4000370")]
		[FieldOffset(Offset = "0x3C")]
		protected internal CompressionMode _compressionMode;

		[Token(Token = "0x4000371")]
		[FieldOffset(Offset = "0x40")]
		protected internal CompressionLevel _level;

		[Token(Token = "0x4000372")]
		[FieldOffset(Offset = "0x44")]
		protected internal bool _leaveOpen;

		[Token(Token = "0x4000373")]
		[FieldOffset(Offset = "0x48")]
		protected internal byte[] _workingBuffer;

		[Token(Token = "0x4000374")]
		[FieldOffset(Offset = "0x50")]
		protected internal int _bufferSize;

		[Token(Token = "0x4000375")]
		[FieldOffset(Offset = "0x58")]
		protected internal byte[] _buf1;

		[Token(Token = "0x4000376")]
		[FieldOffset(Offset = "0x60")]
		protected internal Stream _stream;

		[Token(Token = "0x4000377")]
		[FieldOffset(Offset = "0x68")]
		protected internal CompressionStrategy Strategy;

		[Token(Token = "0x4000378")]
		[FieldOffset(Offset = "0x70")]
		private CRC32 crc;

		[Token(Token = "0x4000379")]
		[FieldOffset(Offset = "0x78")]
		protected internal string _GzipFileName;

		[Token(Token = "0x400037A")]
		[FieldOffset(Offset = "0x80")]
		protected internal string _GzipComment;

		[Token(Token = "0x400037B")]
		[FieldOffset(Offset = "0x88")]
		protected internal DateTime _GzipMtime;

		[Token(Token = "0x400037C")]
		[FieldOffset(Offset = "0x90")]
		protected internal int _gzipHeaderByteCount;

		[Token(Token = "0x400037D")]
		[FieldOffset(Offset = "0x94")]
		private bool nomoreinput;

		[Token(Token = "0x17000102")]
		internal int Crc32
		{
			[Token(Token = "0x600043F")]
			[Address(RVA = "0x787451C", Offset = "0x787051C", VA = "0x787451C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000103")]
		protected internal bool _wantCompress
		{
			[Token(Token = "0x6000440")]
			[Address(RVA = "0x7874538", Offset = "0x7870538", VA = "0x7874538")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000104")]
		private ZlibCodec z
		{
			[Token(Token = "0x6000441")]
			[Address(RVA = "0x7874548", Offset = "0x7870548", VA = "0x7874548")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000105")]
		private byte[] workingBuffer
		{
			[Token(Token = "0x6000442")]
			[Address(RVA = "0x7874620", Offset = "0x7870620", VA = "0x7874620")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000106")]
		public override bool CanRead
		{
			[Token(Token = "0x600044D")]
			[Address(RVA = "0x787597C", Offset = "0x787197C", VA = "0x787597C", Slot = "7")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000107")]
		public override bool CanSeek
		{
			[Token(Token = "0x600044E")]
			[Address(RVA = "0x787599C", Offset = "0x787199C", VA = "0x787599C", Slot = "8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000108")]
		public override bool CanWrite
		{
			[Token(Token = "0x600044F")]
			[Address(RVA = "0x78759BC", Offset = "0x78719BC", VA = "0x78759BC", Slot = "10")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000109")]
		public override long Length
		{
			[Token(Token = "0x6000450")]
			[Address(RVA = "0x78759DC", Offset = "0x78719DC", VA = "0x78759DC", Slot = "11")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700010A")]
		public override long Position
		{
			[Token(Token = "0x6000451")]
			[Address(RVA = "0x78759FC", Offset = "0x78719FC", VA = "0x78759FC", Slot = "12")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000452")]
			[Address(RVA = "0x7875A34", Offset = "0x7871A34", VA = "0x7875A34", Slot = "13")]
			set
			{
			}
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x78743FC", Offset = "0x78703FC", VA = "0x78743FC")]
		public ZlibBaseStream(Stream stream, CompressionMode compressionMode, CompressionLevel level, ZlibStreamFlavor flavor, bool leaveOpen)
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x7874678", Offset = "0x7870678", VA = "0x7874678", Slot = "37")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x78748FC", Offset = "0x78708FC", VA = "0x78748FC")]
		private void finish()
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x7874E30", Offset = "0x7870E30", VA = "0x7874E30")]
		private void end()
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x7874EEC", Offset = "0x7870EEC", VA = "0x7874EEC", Slot = "20")]
		public override void Close()
		{
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x7874FC4", Offset = "0x7870FC4", VA = "0x7874FC4", Slot = "22")]
		public override void Flush()
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x7874FE8", Offset = "0x7870FE8", VA = "0x7874FE8", Slot = "32")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default;
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x7875020", Offset = "0x7871020", VA = "0x7875020", Slot = "33")]
		public override void SetLength(long value)
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x7875044", Offset = "0x7871044", VA = "0x7875044")]
		private string ReadZeroTerminatedString()
		{
			return null;
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x7875230", Offset = "0x7871230", VA = "0x7875230")]
		private int _ReadAndValidateGzipHeader()
		{
			return default;
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x787553C", Offset = "0x787153C", VA = "0x787553C", Slot = "34")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default;
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x7875A6C", Offset = "0x7871A6C", VA = "0x7875A6C")]
		public static void CompressString(string s, Stream compressor)
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x7875C18", Offset = "0x7871C18", VA = "0x7875C18")]
		public static void CompressBuffer(byte[] b, Stream compressor)
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x7875DA0", Offset = "0x7871DA0", VA = "0x7875DA0")]
		public static string UncompressString(byte[] compressed, Stream decompressor)
		{
			return null;
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x7876168", Offset = "0x7872168", VA = "0x7876168")]
		public static byte[] UncompressBuffer(byte[] compressed, Stream decompressor)
		{
			return null;
		}
	}
}
