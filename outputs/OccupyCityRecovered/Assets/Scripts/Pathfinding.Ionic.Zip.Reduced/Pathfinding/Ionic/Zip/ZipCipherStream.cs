using System.IO;
using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zip
{
	[Token(Token = "0x2000029")]
	internal class ZipCipherStream : Stream
	{
		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x28")]
		private ZipCrypto _cipher;

		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x30")]
		private Stream _s;

		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x38")]
		private CryptoMode _mode;

		[Token(Token = "0x17000022")]
		public override bool CanRead
		{
			[Token(Token = "0x60000D3")]
			[Address(RVA = "0x78406C8", Offset = "0x783C6C8", VA = "0x78406C8", Slot = "7")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000023")]
		public override bool CanSeek
		{
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0x78406D8", Offset = "0x783C6D8", VA = "0x78406D8", Slot = "8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000024")]
		public override bool CanWrite
		{
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0x78406E0", Offset = "0x783C6E0", VA = "0x78406E0", Slot = "10")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000025")]
		public override long Length
		{
			[Token(Token = "0x60000D7")]
			[Address(RVA = "0x78406F4", Offset = "0x783C6F4", VA = "0x78406F4", Slot = "11")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000026")]
		public override long Position
		{
			[Token(Token = "0x60000D8")]
			[Address(RVA = "0x784072C", Offset = "0x783C72C", VA = "0x784072C", Slot = "12")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000D9")]
			[Address(RVA = "0x7840764", Offset = "0x783C764", VA = "0x7840764", Slot = "13")]
			set
			{
			}
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x7840318", Offset = "0x783C318", VA = "0x7840318")]
		public ZipCipherStream(Stream s, ZipCrypto cipher, CryptoMode mode)
		{
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x7840398", Offset = "0x783C398", VA = "0x7840398", Slot = "34")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default;
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x7840530", Offset = "0x783C530", VA = "0x7840530", Slot = "37")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x78406F0", Offset = "0x783C6F0", VA = "0x78406F0", Slot = "22")]
		public override void Flush()
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x784079C", Offset = "0x783C79C", VA = "0x784079C", Slot = "32")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default;
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x78407D4", Offset = "0x783C7D4", VA = "0x78407D4", Slot = "33")]
		public override void SetLength(long value)
		{
		}
	}
}
