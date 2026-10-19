using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Il2CppDummyDll;
using Pathfinding.Ionic.Crc;

namespace Pathfinding.Ionic.Zip
{
	[Token(Token = "0x2000038")]
	public class ZipInputStream : Stream
	{
		[Token(Token = "0x4000133")]
		[FieldOffset(Offset = "0x28")]
		private Stream _inputStream;

		[Token(Token = "0x4000134")]
		[FieldOffset(Offset = "0x30")]
		private Encoding _provisionalAlternateEncoding;

		[Token(Token = "0x4000135")]
		[FieldOffset(Offset = "0x38")]
		private ZipEntry _currentEntry;

		[Token(Token = "0x4000136")]
		[FieldOffset(Offset = "0x40")]
		private bool _firstEntry;

		[Token(Token = "0x4000137")]
		[FieldOffset(Offset = "0x41")]
		private bool _needSetup;

		[Token(Token = "0x4000138")]
		[FieldOffset(Offset = "0x48")]
		private ZipContainer _container;

		[Token(Token = "0x4000139")]
		[FieldOffset(Offset = "0x50")]
		private CrcCalculatorStream _crcStream;

		[Token(Token = "0x400013A")]
		[FieldOffset(Offset = "0x58")]
		private long _LeftToRead;

		[Token(Token = "0x400013B")]
		[FieldOffset(Offset = "0x60")]
		internal string _Password;

		[Token(Token = "0x400013C")]
		[FieldOffset(Offset = "0x68")]
		private long _endOfEntry;

		[Token(Token = "0x400013D")]
		[FieldOffset(Offset = "0x70")]
		private string _name;

		[Token(Token = "0x400013E")]
		[FieldOffset(Offset = "0x78")]
		private bool _leaveUnderlyingStreamOpen;

		[Token(Token = "0x400013F")]
		[FieldOffset(Offset = "0x79")]
		private bool _closed;

		[Token(Token = "0x4000140")]
		[FieldOffset(Offset = "0x7A")]
		private bool _findRequired;

		[Token(Token = "0x4000141")]
		[FieldOffset(Offset = "0x7B")]
		private bool _exceptionPending;

		[Token(Token = "0x1700008A")]
		public Encoding ProvisionalAlternateEncoding
		{
			[Token(Token = "0x6000270")]
			[Address(RVA = "0x7859E70", Offset = "0x7855E70", VA = "0x7859E70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000271")]
			[Address(RVA = "0x7859E78", Offset = "0x7855E78", VA = "0x7859E78")]
			set
			{
			}
		}

		[Token(Token = "0x1700008B")]
		public int CodecBufferSize
		{
			[Token(Token = "0x6000272")]
			[Address(RVA = "0x7859E80", Offset = "0x7855E80", VA = "0x7859E80")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6000273")]
			[Address(RVA = "0x7859E88", Offset = "0x7855E88", VA = "0x7859E88")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700008C")]
		public string Password
		{
			[Token(Token = "0x6000274")]
			[Address(RVA = "0x7859E90", Offset = "0x7855E90", VA = "0x7859E90")]
			set
			{
			}
		}

		[Token(Token = "0x1700008D")]
		internal Stream ReadStream
		{
			[Token(Token = "0x6000276")]
			[Address(RVA = "0x7859F3C", Offset = "0x7855F3C", VA = "0x7859F3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008E")]
		public override bool CanRead
		{
			[Token(Token = "0x600027A")]
			[Address(RVA = "0x785A1F0", Offset = "0x78561F0", VA = "0x785A1F0", Slot = "7")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700008F")]
		public override bool CanSeek
		{
			[Token(Token = "0x600027B")]
			[Address(RVA = "0x785A1F8", Offset = "0x78561F8", VA = "0x785A1F8", Slot = "8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000090")]
		public override bool CanWrite
		{
			[Token(Token = "0x600027C")]
			[Address(RVA = "0x785A218", Offset = "0x7856218", VA = "0x785A218", Slot = "10")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000091")]
		public override long Length
		{
			[Token(Token = "0x600027D")]
			[Address(RVA = "0x785A220", Offset = "0x7856220", VA = "0x785A220", Slot = "11")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000092")]
		public override long Position
		{
			[Token(Token = "0x600027E")]
			[Address(RVA = "0x785A240", Offset = "0x7856240", VA = "0x785A240", Slot = "12")]
			get
			{
				return default;
			}
			[Token(Token = "0x600027F")]
			[Address(RVA = "0x785A260", Offset = "0x7856260", VA = "0x785A260", Slot = "13")]
			set
			{
			}
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x7859BBC", Offset = "0x7855BBC", VA = "0x7859BBC")]
		public ZipInputStream(Stream stream)
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x7859C40", Offset = "0x7855C40", VA = "0x7859C40")]
		public ZipInputStream(string fileName)
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x7859BC4", Offset = "0x7855BC4", VA = "0x7859BC4")]
		public ZipInputStream(Stream stream, bool leaveOpen)
		{
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x7859CD0", Offset = "0x7855CD0", VA = "0x7859CD0")]
		private void _Init(Stream stream, bool leaveOpen, string name)
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x7859DE4", Offset = "0x7855DE4", VA = "0x7859DE4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x7859EF8", Offset = "0x7855EF8", VA = "0x7859EF8")]
		private void SetupStream()
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x7859F44", Offset = "0x7855F44", VA = "0x7859F44", Slot = "34")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default;
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x785A074", Offset = "0x7856074", VA = "0x785A074")]
		public ZipEntry GetNextEntry()
		{
			return null;
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x785A1A8", Offset = "0x78561A8", VA = "0x785A1A8", Slot = "21")]
		protected override void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x785A274", Offset = "0x7856274", VA = "0x785A274", Slot = "22")]
		public override void Flush()
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x785A2C0", Offset = "0x78562C0", VA = "0x785A2C0", Slot = "37")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x785A30C", Offset = "0x785630C", VA = "0x785A30C", Slot = "32")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default;
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x785A33C", Offset = "0x785633C", VA = "0x785A33C", Slot = "33")]
		public override void SetLength(long value)
		{
		}
	}
}
