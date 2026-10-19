using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Il2CppDummyDll;
using Pathfinding.Ionic.Crc;
using Pathfinding.Ionic.Zlib;

namespace Pathfinding.Ionic.Zip
{
	[Token(Token = "0x2000039")]
	public class ZipOutputStream : Stream
	{
		[Token(Token = "0x4000143")]
		[FieldOffset(Offset = "0x28")]
		private EncryptionAlgorithm _encryption;

		[Token(Token = "0x4000144")]
		[FieldOffset(Offset = "0x2C")]
		private ZipEntryTimestamp _timestamp;

		[Token(Token = "0x4000145")]
		[FieldOffset(Offset = "0x30")]
		internal string _password;

		[Token(Token = "0x4000146")]
		[FieldOffset(Offset = "0x38")]
		private string _comment;

		[Token(Token = "0x4000147")]
		[FieldOffset(Offset = "0x40")]
		private Stream _outputStream;

		[Token(Token = "0x4000148")]
		[FieldOffset(Offset = "0x48")]
		private ZipEntry _currentEntry;

		[Token(Token = "0x4000149")]
		[FieldOffset(Offset = "0x50")]
		internal Zip64Option _zip64;

		[Token(Token = "0x400014A")]
		[FieldOffset(Offset = "0x58")]
		private Dictionary<string, ZipEntry> _entriesWritten;

		[Token(Token = "0x400014B")]
		[FieldOffset(Offset = "0x60")]
		private int _entryCount;

		[Token(Token = "0x400014C")]
		[FieldOffset(Offset = "0x64")]
		private ZipOption _alternateEncodingUsage;

		[Token(Token = "0x400014D")]
		[FieldOffset(Offset = "0x68")]
		private Encoding _alternateEncoding;

		[Token(Token = "0x400014E")]
		[FieldOffset(Offset = "0x70")]
		private bool _leaveUnderlyingStreamOpen;

		[Token(Token = "0x400014F")]
		[FieldOffset(Offset = "0x71")]
		private bool _disposed;

		[Token(Token = "0x4000150")]
		[FieldOffset(Offset = "0x72")]
		private bool _exceptionPending;

		[Token(Token = "0x4000151")]
		[FieldOffset(Offset = "0x73")]
		private bool _anyEntriesUsedZip64;

		[Token(Token = "0x4000152")]
		[FieldOffset(Offset = "0x74")]
		private bool _directoryNeededZip64;

		[Token(Token = "0x4000153")]
		[FieldOffset(Offset = "0x78")]
		private CountingStream _outputCounter;

		[Token(Token = "0x4000154")]
		[FieldOffset(Offset = "0x80")]
		private Stream _encryptor;

		[Token(Token = "0x4000155")]
		[FieldOffset(Offset = "0x88")]
		private Stream _deflater;

		[Token(Token = "0x4000156")]
		[FieldOffset(Offset = "0x90")]
		private CrcCalculatorStream _entryOutputStream;

		[Token(Token = "0x4000157")]
		[FieldOffset(Offset = "0x98")]
		private bool _needToWriteEntryHeader;

		[Token(Token = "0x4000158")]
		[FieldOffset(Offset = "0xA0")]
		private string _name;

		[Token(Token = "0x4000159")]
		[FieldOffset(Offset = "0xA8")]
		private bool _DontIgnoreCase;

		[Token(Token = "0x400015A")]
		[FieldOffset(Offset = "0xB0")]
		internal ParallelDeflateOutputStream ParallelDeflater;

		[Token(Token = "0x400015B")]
		[FieldOffset(Offset = "0xB8")]
		private long _ParallelDeflateThreshold;

		[Token(Token = "0x400015C")]
		[FieldOffset(Offset = "0xC0")]
		private int _maxBufferPairs;

		[Token(Token = "0x17000093")]
		public string Password
		{
			[Token(Token = "0x6000289")]
			[Address(RVA = "0x785A73C", Offset = "0x785673C", VA = "0x785A73C")]
			set
			{
			}
		}

		[Token(Token = "0x17000094")]
		public EncryptionAlgorithm Encryption
		{
			[Token(Token = "0x600028A")]
			[Address(RVA = "0x785A7C0", Offset = "0x78567C0", VA = "0x785A7C0")]
			get
			{
				return default;
			}
			[Token(Token = "0x600028B")]
			[Address(RVA = "0x785A7C8", Offset = "0x78567C8", VA = "0x785A7C8")]
			set
			{
			}
		}

		[Token(Token = "0x17000095")]
		public int CodecBufferSize
		{
			[Token(Token = "0x600028C")]
			[Address(RVA = "0x785A860", Offset = "0x7856860", VA = "0x785A860")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x600028D")]
			[Address(RVA = "0x785A868", Offset = "0x7856868", VA = "0x785A868")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000096")]
		public CompressionStrategy Strategy
		{
			[Token(Token = "0x600028E")]
			[Address(RVA = "0x785A870", Offset = "0x7856870", VA = "0x785A870")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x600028F")]
			[Address(RVA = "0x785A878", Offset = "0x7856878", VA = "0x785A878")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000097")]
		public ZipEntryTimestamp Timestamp
		{
			[Token(Token = "0x6000290")]
			[Address(RVA = "0x785A880", Offset = "0x7856880", VA = "0x785A880")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000291")]
			[Address(RVA = "0x785A888", Offset = "0x7856888", VA = "0x785A888")]
			set
			{
			}
		}

		[Token(Token = "0x17000098")]
		public CompressionLevel CompressionLevel
		{
			[Token(Token = "0x6000292")]
			[Address(RVA = "0x785A8F0", Offset = "0x78568F0", VA = "0x785A8F0")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6000293")]
			[Address(RVA = "0x785A8F8", Offset = "0x78568F8", VA = "0x785A8F8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000099")]
		public CompressionMethod CompressionMethod
		{
			[Token(Token = "0x6000294")]
			[Address(RVA = "0x785A900", Offset = "0x7856900", VA = "0x785A900")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6000295")]
			[Address(RVA = "0x785A908", Offset = "0x7856908", VA = "0x785A908")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700009A")]
		public string Comment
		{
			[Token(Token = "0x6000296")]
			[Address(RVA = "0x785A910", Offset = "0x7856910", VA = "0x785A910")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000297")]
			[Address(RVA = "0x785A918", Offset = "0x7856918", VA = "0x785A918")]
			set
			{
			}
		}

		[Token(Token = "0x1700009B")]
		public Zip64Option EnableZip64
		{
			[Token(Token = "0x6000298")]
			[Address(RVA = "0x785A980", Offset = "0x7856980", VA = "0x785A980")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000299")]
			[Address(RVA = "0x785A988", Offset = "0x7856988", VA = "0x785A988")]
			set
			{
			}
		}

		[Token(Token = "0x1700009C")]
		public bool OutputUsedZip64
		{
			[Token(Token = "0x600029A")]
			[Address(RVA = "0x785A9F0", Offset = "0x78569F0", VA = "0x785A9F0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700009D")]
		public bool IgnoreCase
		{
			[Token(Token = "0x600029B")]
			[Address(RVA = "0x785AA10", Offset = "0x7856A10", VA = "0x785AA10")]
			get
			{
				return default;
			}
			[Token(Token = "0x600029C")]
			[Address(RVA = "0x785AA20", Offset = "0x7856A20", VA = "0x785AA20")]
			set
			{
			}
		}

		[Token(Token = "0x1700009E")]
		[Obsolete("Beginning with v1.9.1.6 of DotNetZip, this property is obsolete. It will be removed in a future version of the library. Use AlternateEncoding and AlternateEncodingUsage instead.")]
		public bool UseUnicodeAsNecessary
		{
			[Token(Token = "0x600029D")]
			[Address(RVA = "0x785AA30", Offset = "0x7856A30", VA = "0x785AA30")]
			get
			{
				return default;
			}
			[Token(Token = "0x600029E")]
			[Address(RVA = "0x785AA70", Offset = "0x7856A70", VA = "0x785AA70")]
			set
			{
			}
		}

		[Token(Token = "0x1700009F")]
		[Obsolete("use AlternateEncoding and AlternateEncodingUsage instead.")]
		public Encoding ProvisionalAlternateEncoding
		{
			[Token(Token = "0x600029F")]
			[Address(RVA = "0x785AAA8", Offset = "0x7856AA8", VA = "0x785AAA8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002A0")]
			[Address(RVA = "0x785AAC4", Offset = "0x7856AC4", VA = "0x785AAC4")]
			set
			{
			}
		}

		[Token(Token = "0x170000A0")]
		public Encoding AlternateEncoding
		{
			[Token(Token = "0x60002A1")]
			[Address(RVA = "0x785AAD4", Offset = "0x7856AD4", VA = "0x785AAD4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002A2")]
			[Address(RVA = "0x785AADC", Offset = "0x7856ADC", VA = "0x785AADC")]
			set
			{
			}
		}

		[Token(Token = "0x170000A1")]
		public ZipOption AlternateEncodingUsage
		{
			[Token(Token = "0x60002A3")]
			[Address(RVA = "0x785AAE4", Offset = "0x7856AE4", VA = "0x785AAE4")]
			get
			{
				return default;
			}
			[Token(Token = "0x60002A4")]
			[Address(RVA = "0x785AAEC", Offset = "0x7856AEC", VA = "0x785AAEC")]
			set
			{
			}
		}

		[Token(Token = "0x170000A2")]
		public static Encoding DefaultEncoding
		{
			[Token(Token = "0x60002A5")]
			[Address(RVA = "0x785AAA0", Offset = "0x7856AA0", VA = "0x785AAA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A3")]
		public long ParallelDeflateThreshold
		{
			[Token(Token = "0x60002A7")]
			[Address(RVA = "0x785AAF4", Offset = "0x7856AF4", VA = "0x785AAF4")]
			get
			{
				return default;
			}
			[Token(Token = "0x60002A6")]
			[Address(RVA = "0x785A644", Offset = "0x7856644", VA = "0x785A644")]
			set
			{
			}
		}

		[Token(Token = "0x170000A4")]
		public int ParallelDeflateMaxBufferPairs
		{
			[Token(Token = "0x60002A8")]
			[Address(RVA = "0x785AAFC", Offset = "0x7856AFC", VA = "0x785AAFC")]
			get
			{
				return default;
			}
			[Token(Token = "0x60002A9")]
			[Address(RVA = "0x785AB04", Offset = "0x7856B04", VA = "0x785AB04")]
			set
			{
			}
		}

		[Token(Token = "0x170000A5")]
		internal Stream OutputStream
		{
			[Token(Token = "0x60002AB")]
			[Address(RVA = "0x785AC4C", Offset = "0x7856C4C", VA = "0x785AC4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A6")]
		internal string Name
		{
			[Token(Token = "0x60002AC")]
			[Address(RVA = "0x785AC54", Offset = "0x7856C54", VA = "0x785AC54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A7")]
		public override bool CanRead
		{
			[Token(Token = "0x60002B3")]
			[Address(RVA = "0x785B4A4", Offset = "0x78574A4", VA = "0x785B4A4", Slot = "7")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000A8")]
		public override bool CanSeek
		{
			[Token(Token = "0x60002B4")]
			[Address(RVA = "0x785B4AC", Offset = "0x78574AC", VA = "0x785B4AC", Slot = "8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000A9")]
		public override bool CanWrite
		{
			[Token(Token = "0x60002B5")]
			[Address(RVA = "0x785B4B4", Offset = "0x78574B4", VA = "0x785B4B4", Slot = "10")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000AA")]
		public override long Length
		{
			[Token(Token = "0x60002B6")]
			[Address(RVA = "0x785B4BC", Offset = "0x78574BC", VA = "0x785B4BC", Slot = "11")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000AB")]
		public override long Position
		{
			[Token(Token = "0x60002B7")]
			[Address(RVA = "0x785B4F4", Offset = "0x78574F4", VA = "0x785B4F4", Slot = "12")]
			get
			{
				return default;
			}
			[Token(Token = "0x60002B8")]
			[Address(RVA = "0x785B514", Offset = "0x7857514", VA = "0x785B514", Slot = "13")]
			set
			{
			}
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x785A374", Offset = "0x7856374", VA = "0x785A374")]
		public ZipOutputStream(Stream stream)
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x785A40C", Offset = "0x785640C", VA = "0x785A40C")]
		public ZipOutputStream(string fileName)
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x785A37C", Offset = "0x785637C", VA = "0x785A37C")]
		public ZipOutputStream(Stream stream, bool leaveOpen)
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x785A4B0", Offset = "0x78564B0", VA = "0x785A4B0")]
		private void _Init(Stream stream, bool leaveOpen, string name)
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x785A6B0", Offset = "0x78566B0", VA = "0x785A6B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x785AB80", Offset = "0x7856B80", VA = "0x785AB80")]
		private void InsureUniqueEntry(ZipEntry ze1)
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x785AC5C", Offset = "0x7856C5C", VA = "0x785AC5C")]
		public bool ContainsEntry(string name)
		{
			return default;
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x785ACF0", Offset = "0x7856CF0", VA = "0x785ACF0", Slot = "37")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x785AFB0", Offset = "0x7856FB0", VA = "0x785AFB0")]
		public ZipEntry PutNextEntry(string entryName)
		{
			return null;
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x785AE60", Offset = "0x7856E60", VA = "0x785AE60")]
		private void _InitiateCurrentEntry(bool finishing)
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x785B254", Offset = "0x7857254", VA = "0x785B254")]
		private void _FinishCurrentEntry()
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x785B340", Offset = "0x7857340", VA = "0x785B340", Slot = "21")]
		protected override void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x785B54C", Offset = "0x785754C", VA = "0x785B54C", Slot = "22")]
		public override void Flush()
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x785B550", Offset = "0x7857550", VA = "0x785B550", Slot = "34")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default;
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x785B59C", Offset = "0x785759C", VA = "0x785B59C", Slot = "32")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default;
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x785B5E8", Offset = "0x78575E8", VA = "0x785B5E8", Slot = "33")]
		public override void SetLength(long value)
		{
		}
	}
}
