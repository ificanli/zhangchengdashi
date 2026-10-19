using System.IO;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zip
{
	[Token(Token = "0x200003B")]
	internal class ZipSegmentedStream : Stream
	{
		[Token(Token = "0x200003C")]
		private enum RwMode
		{
			[Token(Token = "0x4000170")]
			None = 0,
			[Token(Token = "0x4000171")]
			ReadOnly = 1,
			[Token(Token = "0x4000172")]
			Write = 2
		}

		[Token(Token = "0x4000164")]
		[FieldOffset(Offset = "0x28")]
		private RwMode rwMode;

		[Token(Token = "0x4000165")]
		[FieldOffset(Offset = "0x2C")]
		private bool _exceptionPending;

		[Token(Token = "0x4000166")]
		[FieldOffset(Offset = "0x30")]
		private string _baseName;

		[Token(Token = "0x4000167")]
		[FieldOffset(Offset = "0x38")]
		private string _baseDir;

		[Token(Token = "0x4000168")]
		[FieldOffset(Offset = "0x40")]
		private string _currentName;

		[Token(Token = "0x4000169")]
		[FieldOffset(Offset = "0x48")]
		private string _currentTempName;

		[Token(Token = "0x400016A")]
		[FieldOffset(Offset = "0x50")]
		private uint _currentDiskNumber;

		[Token(Token = "0x400016B")]
		[FieldOffset(Offset = "0x54")]
		private uint _maxDiskNumber;

		[Token(Token = "0x400016C")]
		[FieldOffset(Offset = "0x58")]
		private int _maxSegmentSize;

		[Token(Token = "0x400016D")]
		[FieldOffset(Offset = "0x60")]
		private Stream _innerStream;

		[Token(Token = "0x170000BC")]
		public bool ContiguousWrite
		{
			[Token(Token = "0x60002D3")]
			[Address(RVA = "0x785BCAC", Offset = "0x7857CAC", VA = "0x785BCAC")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x60002D4")]
			[Address(RVA = "0x785BCB4", Offset = "0x7857CB4", VA = "0x785BCB4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000BD")]
		public uint CurrentSegment
		{
			[Token(Token = "0x60002D5")]
			[Address(RVA = "0x785BCC0", Offset = "0x7857CC0", VA = "0x785BCC0")]
			get
			{
				return default;
			}
			[Token(Token = "0x60002D6")]
			[Address(RVA = "0x785B998", Offset = "0x7857998", VA = "0x785B998")]
			private set
			{
			}
		}

		[Token(Token = "0x170000BE")]
		public string CurrentName
		{
			[Token(Token = "0x60002D7")]
			[Address(RVA = "0x785BCC8", Offset = "0x7857CC8", VA = "0x785BCC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BF")]
		public string CurrentTempName
		{
			[Token(Token = "0x60002D8")]
			[Address(RVA = "0x785BE38", Offset = "0x7857E38", VA = "0x785BE38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C0")]
		public override bool CanRead
		{
			[Token(Token = "0x60002E1")]
			[Address(RVA = "0x785C5EC", Offset = "0x78585EC", VA = "0x785C5EC", Slot = "7")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000C1")]
		public override bool CanSeek
		{
			[Token(Token = "0x60002E2")]
			[Address(RVA = "0x785C614", Offset = "0x7858614", VA = "0x785C614", Slot = "8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000C2")]
		public override bool CanWrite
		{
			[Token(Token = "0x60002E3")]
			[Address(RVA = "0x785C62C", Offset = "0x785862C", VA = "0x785C62C", Slot = "10")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000C3")]
		public override long Length
		{
			[Token(Token = "0x60002E5")]
			[Address(RVA = "0x785C678", Offset = "0x7858678", VA = "0x785C678", Slot = "11")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000C4")]
		public override long Position
		{
			[Token(Token = "0x60002E6")]
			[Address(RVA = "0x785C698", Offset = "0x7858698", VA = "0x785C698", Slot = "12")]
			get
			{
				return default;
			}
			[Token(Token = "0x60002E7")]
			[Address(RVA = "0x785C6B8", Offset = "0x78586B8", VA = "0x785C6B8", Slot = "13")]
			set
			{
			}
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x785B938", Offset = "0x7857938", VA = "0x785B938")]
		private ZipSegmentedStream()
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x7858A64", Offset = "0x7854A64", VA = "0x7858A64")]
		public static ZipSegmentedStream ForReading(string name, uint initialDiskNumber, uint maxDiskNumber)
		{
			return null;
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x7858D0C", Offset = "0x7854D0C", VA = "0x7858D0C")]
		public static ZipSegmentedStream ForWriting(string name, int maxSegmentSize)
		{
			return null;
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x785BB60", Offset = "0x7857B60", VA = "0x785BB60")]
		public static Stream ForUpdate(string name, uint diskNumber)
		{
			return null;
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x785BCF0", Offset = "0x7857CF0", VA = "0x785BCF0")]
		private string _NameForSegment(uint diskNumber)
		{
			return null;
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x7859980", Offset = "0x7855980", VA = "0x7859980")]
		public uint ComputeSegment(int length)
		{
			return default;
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x785BE40", Offset = "0x7857E40", VA = "0x785BE40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x785B9A4", Offset = "0x78579A4", VA = "0x785B9A4")]
		private void _SetReadStream()
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x785C014", Offset = "0x7858014", VA = "0x785C014", Slot = "34")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default;
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x785BA04", Offset = "0x7857A04", VA = "0x785BA04")]
		private void _SetWriteStream(uint increment)
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x785C1D8", Offset = "0x78581D8", VA = "0x785C1D8", Slot = "37")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x785C338", Offset = "0x7858338", VA = "0x785C338")]
		public long TruncateBackward(uint diskNumber, long offset)
		{
			return default;
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x785C654", Offset = "0x7858654", VA = "0x785C654", Slot = "22")]
		public override void Flush()
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x785C6DC", Offset = "0x78586DC", VA = "0x785C6DC", Slot = "32")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default;
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x785C700", Offset = "0x7858700", VA = "0x785C700", Slot = "33")]
		public override void SetLength(long value)
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x785C76C", Offset = "0x785876C", VA = "0x785C76C", Slot = "21")]
		protected override void Dispose(bool disposing)
		{
		}
	}
}
