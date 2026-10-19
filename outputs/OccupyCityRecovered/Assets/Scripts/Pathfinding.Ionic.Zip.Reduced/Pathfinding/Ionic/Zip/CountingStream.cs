using System.IO;
using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zip
{
	[Token(Token = "0x2000025")]
	public class CountingStream : Stream
	{
		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x28")]
		private Stream _s;

		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x30")]
		private long _bytesWritten;

		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x38")]
		private long _bytesRead;

		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x40")]
		private long _initialOffset;

		[Token(Token = "0x17000018")]
		public Stream WrappedStream
		{
			[Token(Token = "0x60000B8")]
			[Address(RVA = "0x783F814", Offset = "0x783B814", VA = "0x783F814")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000019")]
		public long BytesWritten
		{
			[Token(Token = "0x60000B9")]
			[Address(RVA = "0x783F81C", Offset = "0x783B81C", VA = "0x783F81C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700001A")]
		public long BytesRead
		{
			[Token(Token = "0x60000BA")]
			[Address(RVA = "0x783F824", Offset = "0x783B824", VA = "0x783F824")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700001B")]
		public override bool CanRead
		{
			[Token(Token = "0x60000BE")]
			[Address(RVA = "0x783F978", Offset = "0x783B978", VA = "0x783F978", Slot = "7")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700001C")]
		public override bool CanSeek
		{
			[Token(Token = "0x60000BF")]
			[Address(RVA = "0x783F998", Offset = "0x783B998", VA = "0x783F998", Slot = "8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700001D")]
		public override bool CanWrite
		{
			[Token(Token = "0x60000C0")]
			[Address(RVA = "0x783F9B8", Offset = "0x783B9B8", VA = "0x783F9B8", Slot = "10")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700001E")]
		public override long Length
		{
			[Token(Token = "0x60000C2")]
			[Address(RVA = "0x783F9FC", Offset = "0x783B9FC", VA = "0x783F9FC", Slot = "11")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700001F")]
		public long ComputedPosition
		{
			[Token(Token = "0x60000C3")]
			[Address(RVA = "0x783FA1C", Offset = "0x783BA1C", VA = "0x783FA1C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000020")]
		public override long Position
		{
			[Token(Token = "0x60000C4")]
			[Address(RVA = "0x783FA2C", Offset = "0x783BA2C", VA = "0x783FA2C", Slot = "12")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000C5")]
			[Address(RVA = "0x783FA4C", Offset = "0x783BA4C", VA = "0x783FA4C", Slot = "13")]
			set
			{
			}
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x783F704", Offset = "0x783B704", VA = "0x783F704")]
		public CountingStream(Stream stream)
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x783F82C", Offset = "0x783B82C", VA = "0x783F82C")]
		public void Adjust(long delta)
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x783F8F8", Offset = "0x783B8F8", VA = "0x783F8F8", Slot = "34")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default;
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x783F930", Offset = "0x783B930", VA = "0x783F930", Slot = "37")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x783F9D8", Offset = "0x783B9D8", VA = "0x783F9D8", Slot = "22")]
		public override void Flush()
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x783FA74", Offset = "0x783BA74", VA = "0x783FA74", Slot = "32")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default;
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x783FA98", Offset = "0x783BA98", VA = "0x783FA98", Slot = "33")]
		public override void SetLength(long value)
		{
		}
	}
}
