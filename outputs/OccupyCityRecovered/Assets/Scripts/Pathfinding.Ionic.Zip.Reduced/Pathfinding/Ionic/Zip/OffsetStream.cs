using System;
using System.IO;
using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zip
{
	[Token(Token = "0x2000023")]
	internal class OffsetStream : Stream, IDisposable
	{
		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x28")]
		private long _originalPosition;

		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x30")]
		private Stream _innerStream;

		[Token(Token = "0x17000013")]
		public override bool CanRead
		{
			[Token(Token = "0x6000097")]
			[Address(RVA = "0x783DB70", Offset = "0x7839B70", VA = "0x783DB70", Slot = "7")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000014")]
		public override bool CanSeek
		{
			[Token(Token = "0x6000098")]
			[Address(RVA = "0x783DB90", Offset = "0x7839B90", VA = "0x783DB90", Slot = "8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000015")]
		public override bool CanWrite
		{
			[Token(Token = "0x6000099")]
			[Address(RVA = "0x783DBB0", Offset = "0x7839BB0", VA = "0x783DBB0", Slot = "10")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000016")]
		public override long Length
		{
			[Token(Token = "0x600009B")]
			[Address(RVA = "0x783DBDC", Offset = "0x7839BDC", VA = "0x783DBDC", Slot = "11")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000017")]
		public override long Position
		{
			[Token(Token = "0x600009C")]
			[Address(RVA = "0x783DBFC", Offset = "0x7839BFC", VA = "0x783DBFC", Slot = "12")]
			get
			{
				return default;
			}
			[Token(Token = "0x600009D")]
			[Address(RVA = "0x783DC2C", Offset = "0x7839C2C", VA = "0x783DC2C", Slot = "13")]
			set
			{
			}
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x783DA80", Offset = "0x7839A80", VA = "0x783DA80")]
		public OffsetStream(Stream s)
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x783DB04", Offset = "0x7839B04", VA = "0x783DB04", Slot = "6")]
void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x783DB14", Offset = "0x7839B14", VA = "0x783DB14", Slot = "34")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default;
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x783DB38", Offset = "0x7839B38", VA = "0x783DB38", Slot = "37")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x783DBB8", Offset = "0x7839BB8", VA = "0x783DBB8", Slot = "22")]
		public override void Flush()
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x783DC5C", Offset = "0x7839C5C", VA = "0x783DC5C", Slot = "32")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default;
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x783DC98", Offset = "0x7839C98", VA = "0x783DC98", Slot = "33")]
		public override void SetLength(long value)
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x783DCD0", Offset = "0x7839CD0", VA = "0x783DCD0", Slot = "20")]
		public override void Close()
		{
		}
	}
}
