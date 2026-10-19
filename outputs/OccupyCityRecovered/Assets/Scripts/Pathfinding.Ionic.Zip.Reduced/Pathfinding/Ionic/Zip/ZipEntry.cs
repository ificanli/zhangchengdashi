using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using Il2CppDummyDll;
using Pathfinding.Ionic.Crc;
using Pathfinding.Ionic.Zlib;

namespace Pathfinding.Ionic.Zip
{
	[Token(Token = "0x200002A")]
	[ClassInterface(ClassInterfaceType.AutoDispatch)]
	[ComVisible(true)]
	[Guid("ebc25cf6-9120-4283-b972-0e5520d00004")]
	public class ZipEntry
	{
		[Token(Token = "0x200002B")]
		private class CopyHelper
		{
			[Token(Token = "0x40000C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static Regex re;

			[Token(Token = "0x40000C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static int callCount;

			[Token(Token = "0x600017B")]
			[Address(RVA = "0x784AB84", Offset = "0x7846B84", VA = "0x784AB84")]
			public CopyHelper()
			{
			}

			[Token(Token = "0x600017D")]
			[Address(RVA = "0x784AC28", Offset = "0x7846C28", VA = "0x784AC28")]
			internal static string AppendCopyToFileName(string f)
			{
				return null;
			}
		}

		[Token(Token = "0x200002C")]
		private delegate T Func<T>();

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private short _VersionMadeBy;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		private short _InternalFileAttrs;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private int _ExternalFileAttrs;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private short _filenameLength;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		private short _extraFieldLength;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private short _commentLength;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Stream _inputDecryptorStream;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int _readExtraDepth;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private object _outputLock;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ZipCrypto _zipCrypto_forExtract;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ZipCrypto _zipCrypto_forWrite;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal DateTime _LastModified;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private DateTime _Mtime;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private DateTime _Atime;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private DateTime _Ctime;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool _ntfsTimesAreSet;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool _emitNtfsTimes;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
		private bool _emitUnixTimes;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B")]
		private bool _TrimVolumeFromFullyQualifiedPaths;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		internal string _LocalFileName;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private string _FileNameInArchive;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		internal short _VersionNeeded;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x82")]
		internal short _BitField;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		internal short _CompressionMethod;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x86")]
		private short _CompressionMethod_FromZipFile;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private CompressionLevel _CompressionLevel;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		internal string _Comment;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool _IsDirectory;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private byte[] _CommentBytes;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		internal long _CompressedSize;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		internal long _CompressedFileDataSize;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		internal long _UncompressedSize;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		internal int _TimeBlob;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private bool _crcCalculated;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		internal int _Crc32;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		internal byte[] _Extra;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool _metadataChanged;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD9")]
		private bool _restreamRequiredOnSave;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDA")]
		private bool _sourceIsEncrypted;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDB")]
		private bool _skippedDuringSave;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private uint _diskNumber;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Encoding ibm437;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Encoding _actualEncoding;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		internal ZipContainer _container;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private long __FileDataPosition;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private byte[] _EntryHeader;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		internal long _RelativeOffsetOfLocalHeader;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private long _future_ROLH;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private long _TotalEntrySize;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private int _LengthOfHeader;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private int _LengthOfTrailer;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		internal bool _InputUsesZip64;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private uint _UnsupportedAlgorithmId;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		internal string _Password;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		internal ZipEntrySource _Source;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		internal EncryptionAlgorithm _Encryption;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		internal EncryptionAlgorithm _Encryption_FromZipFile;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		internal byte[] _WeakEncryptionHeader;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		internal Stream _archiveStream;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Stream _sourceStream;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private long? _sourceStreamOriginalPosition;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private bool _sourceWasJitProvided;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x169")]
		private bool _ioOperationCanceled;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16A")]
		private bool _presumeZip64;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16B")]
		private bool? _entryRequiresZip64;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16D")]
		private bool? _OutputUsesZip64;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16F")]
		private bool _IsText;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private ZipEntryTimestamp _timestamp;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DateTime _unixEpoch;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DateTime _win32Epoch;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DateTime _zeroHour;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private WriteDelegate _WriteDelegate;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private OpenDelegate _OpenDelegate;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private CloseDelegate _CloseDelegate;

		[Token(Token = "0x17000027")]
		internal bool AttributesIndicateDirectory
		{
			[Token(Token = "0x60000DE")]
			[Address(RVA = "0x78409B4", Offset = "0x783C9B4", VA = "0x78409B4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000028")]
		public string Info
		{
			[Token(Token = "0x60000E0")]
			[Address(RVA = "0x78409E0", Offset = "0x783C9E0", VA = "0x78409E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000029")]
		private string UnsupportedAlgorithm
		{
			[Token(Token = "0x60000FE")]
			[Address(RVA = "0x7843634", Offset = "0x783F634", VA = "0x7843634")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002A")]
		private string UnsupportedCompressionMethod
		{
			[Token(Token = "0x60000FF")]
			[Address(RVA = "0x784383C", Offset = "0x783F83C", VA = "0x784383C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002B")]
		public DateTime LastModified
		{
			[Token(Token = "0x600012E")]
			[Address(RVA = "0x7846AEC", Offset = "0x7842AEC", VA = "0x7846AEC")]
			get
			{
				return default;
			}
			[Token(Token = "0x600012F")]
			[Address(RVA = "0x78497CC", Offset = "0x78457CC", VA = "0x78497CC")]
			set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		private int BufferSize
		{
			[Token(Token = "0x6000130")]
			[Address(RVA = "0x7843618", Offset = "0x783F618", VA = "0x7843618")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700002D")]
		public DateTime ModifiedTime
		{
			[Token(Token = "0x6000131")]
			[Address(RVA = "0x78498EC", Offset = "0x78458EC", VA = "0x78498EC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000132")]
			[Address(RVA = "0x78498F4", Offset = "0x78458F4", VA = "0x78498F4")]
			set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		public DateTime AccessedTime
		{
			[Token(Token = "0x6000133")]
			[Address(RVA = "0x7849C00", Offset = "0x7845C00", VA = "0x7849C00")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000134")]
			[Address(RVA = "0x7849C08", Offset = "0x7845C08", VA = "0x7849C08")]
			set
			{
			}
		}

		[Token(Token = "0x1700002F")]
		public DateTime CreationTime
		{
			[Token(Token = "0x6000135")]
			[Address(RVA = "0x7849C1C", Offset = "0x7845C1C", VA = "0x7849C1C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000136")]
			[Address(RVA = "0x7849C24", Offset = "0x7845C24", VA = "0x7849C24")]
			set
			{
			}
		}

		[Token(Token = "0x17000030")]
		public bool EmitTimesInWindowsFormatWhenSaving
		{
			[Token(Token = "0x6000138")]
			[Address(RVA = "0x7849C2C", Offset = "0x7845C2C", VA = "0x7849C2C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000139")]
			[Address(RVA = "0x7849C34", Offset = "0x7845C34", VA = "0x7849C34")]
			set
			{
			}
		}

		[Token(Token = "0x17000031")]
		public bool EmitTimesInUnixFormatWhenSaving
		{
			[Token(Token = "0x600013A")]
			[Address(RVA = "0x7849C48", Offset = "0x7845C48", VA = "0x7849C48")]
			get
			{
				return default;
			}
			[Token(Token = "0x600013B")]
			[Address(RVA = "0x7849C50", Offset = "0x7845C50", VA = "0x7849C50")]
			set
			{
			}
		}

		[Token(Token = "0x17000032")]
		public ZipEntryTimestamp Timestamp
		{
			[Token(Token = "0x600013C")]
			[Address(RVA = "0x7849C64", Offset = "0x7845C64", VA = "0x7849C64")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000033")]
		public FileAttributes Attributes
		{
			[Token(Token = "0x600013D")]
			[Address(RVA = "0x7849C6C", Offset = "0x7845C6C", VA = "0x7849C6C")]
			get
			{
				return default;
			}
			[Token(Token = "0x600013E")]
			[Address(RVA = "0x7849C74", Offset = "0x7845C74", VA = "0x7849C74")]
			set
			{
			}
		}

		[Token(Token = "0x17000034")]
		internal string LocalFileName
		{
			[Token(Token = "0x600013F")]
			[Address(RVA = "0x7849C8C", Offset = "0x7845C8C", VA = "0x7849C8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000035")]
		public string FileName
		{
			[Token(Token = "0x6000140")]
			[Address(RVA = "0x7849C94", Offset = "0x7845C94", VA = "0x7849C94")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000141")]
			[Address(RVA = "0x7849C9C", Offset = "0x7845C9C", VA = "0x7849C9C")]
			set
			{
			}
		}

		[Token(Token = "0x17000036")]
		public Stream InputStream
		{
			[Token(Token = "0x6000142")]
			[Address(RVA = "0x7849EC4", Offset = "0x7845EC4", VA = "0x7849EC4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000143")]
			[Address(RVA = "0x7849ECC", Offset = "0x7845ECC", VA = "0x7849ECC")]
			set
			{
			}
		}

		[Token(Token = "0x17000037")]
		public bool InputStreamWasJitProvided
		{
			[Token(Token = "0x6000144")]
			[Address(RVA = "0x7849F34", Offset = "0x7845F34", VA = "0x7849F34")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000038")]
		public ZipEntrySource Source
		{
			[Token(Token = "0x6000145")]
			[Address(RVA = "0x7849F3C", Offset = "0x7845F3C", VA = "0x7849F3C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000039")]
		public short VersionNeeded
		{
			[Token(Token = "0x6000146")]
			[Address(RVA = "0x7849F44", Offset = "0x7845F44", VA = "0x7849F44")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700003A")]
		public string Comment
		{
			[Token(Token = "0x6000147")]
			[Address(RVA = "0x7849F4C", Offset = "0x7845F4C", VA = "0x7849F4C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000148")]
			[Address(RVA = "0x7849F54", Offset = "0x7845F54", VA = "0x7849F54")]
			set
			{
			}
		}

		[Token(Token = "0x1700003B")]
		public bool? RequiresZip64
		{
			[Token(Token = "0x6000149")]
			[Address(RVA = "0x7849F64", Offset = "0x7845F64", VA = "0x7849F64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003C")]
		public bool? OutputUsedZip64
		{
			[Token(Token = "0x600014A")]
			[Address(RVA = "0x7849F70", Offset = "0x7845F70", VA = "0x7849F70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003D")]
		public short BitField
		{
			[Token(Token = "0x600014B")]
			[Address(RVA = "0x7849F7C", Offset = "0x7845F7C", VA = "0x7849F7C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700003E")]
		public CompressionMethod CompressionMethod
		{
			[Token(Token = "0x600014C")]
			[Address(RVA = "0x7849F84", Offset = "0x7845F84", VA = "0x7849F84")]
			get
			{
				return default;
			}
			[Token(Token = "0x600014D")]
			[Address(RVA = "0x7846F30", Offset = "0x7842F30", VA = "0x7846F30")]
			set
			{
			}
		}

		[Token(Token = "0x1700003F")]
		public CompressionLevel CompressionLevel
		{
			[Token(Token = "0x600014E")]
			[Address(RVA = "0x7849F8C", Offset = "0x7845F8C", VA = "0x7849F8C")]
			get
			{
				return default;
			}
			[Token(Token = "0x600014F")]
			[Address(RVA = "0x7846180", Offset = "0x7842180", VA = "0x7846180")]
			set
			{
			}
		}

		[Token(Token = "0x17000040")]
		public long CompressedSize
		{
			[Token(Token = "0x6000150")]
			[Address(RVA = "0x7849F94", Offset = "0x7845F94", VA = "0x7849F94")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000041")]
		public long UncompressedSize
		{
			[Token(Token = "0x6000151")]
			[Address(RVA = "0x7849F9C", Offset = "0x7845F9C", VA = "0x7849F9C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000042")]
		public double CompressionRatio
		{
			[Token(Token = "0x6000152")]
			[Address(RVA = "0x7849FA4", Offset = "0x7845FA4", VA = "0x7849FA4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000043")]
		public int Crc
		{
			[Token(Token = "0x6000153")]
			[Address(RVA = "0x7849FDC", Offset = "0x7845FDC", VA = "0x7849FDC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000044")]
		public bool IsDirectory
		{
			[Token(Token = "0x6000154")]
			[Address(RVA = "0x7849FE4", Offset = "0x7845FE4", VA = "0x7849FE4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000045")]
		public bool UsesEncryption
		{
			[Token(Token = "0x6000155")]
			[Address(RVA = "0x7849FEC", Offset = "0x7845FEC", VA = "0x7849FEC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000046")]
		public EncryptionAlgorithm Encryption
		{
			[Token(Token = "0x6000156")]
			[Address(RVA = "0x7849FFC", Offset = "0x7845FFC", VA = "0x7849FFC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000157")]
			[Address(RVA = "0x78468A8", Offset = "0x78428A8", VA = "0x78468A8")]
			set
			{
			}
		}

		[Token(Token = "0x17000047")]
		public string Password
		{
			[Token(Token = "0x6000159")]
			[Address(RVA = "0x784A004", Offset = "0x7846004", VA = "0x784A004")]
			private get
			{
				return null;
			}
			[Token(Token = "0x6000158")]
			[Address(RVA = "0x784693C", Offset = "0x784293C", VA = "0x784693C")]
			set
			{
			}
		}

		[Token(Token = "0x17000048")]
		internal bool IsChanged
		{
			[Token(Token = "0x600015A")]
			[Address(RVA = "0x784A00C", Offset = "0x784600C", VA = "0x784A00C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000049")]
		public ExtractExistingFileAction ExtractExistingFile
		{
			[Token(Token = "0x600015B")]
			[Address(RVA = "0x784A01C", Offset = "0x784601C", VA = "0x784A01C")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x600015C")]
			[Address(RVA = "0x784A024", Offset = "0x7846024", VA = "0x784A024")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public ZipErrorAction ZipErrorAction
		{
			[Token(Token = "0x600015D")]
			[Address(RVA = "0x784A02C", Offset = "0x784602C", VA = "0x784A02C")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x600015E")]
			[Address(RVA = "0x784A034", Offset = "0x7846034", VA = "0x784A034")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public bool IncludedInMostRecentSave
		{
			[Token(Token = "0x600015F")]
			[Address(RVA = "0x784A03C", Offset = "0x784603C", VA = "0x784A03C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700004C")]
		public SetCompressionCallback SetCompression
		{
			[Token(Token = "0x6000160")]
			[Address(RVA = "0x784A04C", Offset = "0x784604C", VA = "0x784A04C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000161")]
			[Address(RVA = "0x784A054", Offset = "0x7846054", VA = "0x784A054")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700004D")]
		[Obsolete("Beginning with v1.9.1.6 of DotNetZip, this property is obsolete.  It will be removed in a future version of the library. Your applications should  use AlternateEncoding and AlternateEncodingUsage instead.")]
		public bool UseUnicodeAsNecessary
		{
			[Token(Token = "0x6000162")]
			[Address(RVA = "0x784A05C", Offset = "0x784605C", VA = "0x784A05C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000163")]
			[Address(RVA = "0x784A0C8", Offset = "0x78460C8", VA = "0x784A0C8")]
			set
			{
			}
		}

		[Token(Token = "0x1700004E")]
		[Obsolete("This property is obsolete since v1.9.1.6. Use AlternateEncoding and AlternateEncodingUsage instead.", true)]
		public Encoding ProvisionalAlternateEncoding
		{
			[Token(Token = "0x6000164")]
			[Address(RVA = "0x784A194", Offset = "0x7846194", VA = "0x784A194")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000165")]
			[Address(RVA = "0x784A19C", Offset = "0x784619C", VA = "0x784A19C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700004F")]
		public Encoding AlternateEncoding
		{
			[Token(Token = "0x6000166")]
			[Address(RVA = "0x784A1A4", Offset = "0x78461A4", VA = "0x784A1A4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000167")]
			[Address(RVA = "0x784A1AC", Offset = "0x78461AC", VA = "0x784A1AC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000050")]
		public ZipOption AlternateEncodingUsage
		{
			[Token(Token = "0x6000168")]
			[Address(RVA = "0x784A1B4", Offset = "0x78461B4", VA = "0x784A1B4")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6000169")]
			[Address(RVA = "0x784A1BC", Offset = "0x78461BC", VA = "0x784A1BC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000051")]
		public bool IsText
		{
			[Token(Token = "0x6000173")]
			[Address(RVA = "0x784A838", Offset = "0x7846838", VA = "0x784A838")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000174")]
			[Address(RVA = "0x784A840", Offset = "0x7846840", VA = "0x784A840")]
			set
			{
			}
		}

		[Token(Token = "0x17000052")]
		internal Stream ArchiveStream
		{
			[Token(Token = "0x6000176")]
			[Address(RVA = "0x7842948", Offset = "0x783E948", VA = "0x7842948")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000053")]
		internal long FileDataPosition
		{
			[Token(Token = "0x6000179")]
			[Address(RVA = "0x78429B0", Offset = "0x783E9B0", VA = "0x78429B0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000054")]
		private int LengthOfHeader
		{
			[Token(Token = "0x600017A")]
			[Address(RVA = "0x7848FD8", Offset = "0x7844FD8", VA = "0x7848FD8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x784080C", Offset = "0x783C80C", VA = "0x784080C")]
		public ZipEntry()
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x78409D0", Offset = "0x783C9D0", VA = "0x78409D0")]
		internal void ResetDirEntry()
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x78410C0", Offset = "0x783D0C0", VA = "0x78410C0")]
		internal static ZipEntry ReadDirEntry(ZipFile zf, Dictionary<string, object> previouslySeen)
		{
			return null;
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x78418D8", Offset = "0x783D8D8", VA = "0x78418D8")]
		internal static bool IsNotValidZipDirEntrySig(int signature)
		{
			return default;
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x7841B58", Offset = "0x783DB58", VA = "0x7841B58")]
		public void Extract()
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x784235C", Offset = "0x783E35C", VA = "0x784235C")]
		public void Extract(ExtractExistingFileAction extractExistingFile)
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x78423BC", Offset = "0x783E3BC", VA = "0x78423BC")]
		public void Extract(Stream stream)
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x78423CC", Offset = "0x783E3CC", VA = "0x78423CC")]
		public void Extract(string baseDirectory)
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x78423D8", Offset = "0x783E3D8", VA = "0x78423D8")]
		public void Extract(string baseDirectory, ExtractExistingFileAction extractExistingFile)
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x78423E8", Offset = "0x783E3E8", VA = "0x78423E8")]
		public void ExtractWithPassword(string password)
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x7842444", Offset = "0x783E444", VA = "0x7842444")]
		public void ExtractWithPassword(string baseDirectory, string password)
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x7842450", Offset = "0x783E450", VA = "0x7842450")]
		public void ExtractWithPassword(ExtractExistingFileAction extractExistingFile, string password)
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x78424B4", Offset = "0x783E4B4", VA = "0x78424B4")]
		public void ExtractWithPassword(string baseDirectory, ExtractExistingFileAction extractExistingFile, string password)
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x78424C0", Offset = "0x783E4C0", VA = "0x78424C0")]
		public void ExtractWithPassword(Stream stream, string password)
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x78424D0", Offset = "0x783E4D0", VA = "0x78424D0")]
		public CrcCalculatorStream OpenReader()
		{
			return null;
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x78426B4", Offset = "0x783E6B4", VA = "0x78426B4")]
		public CrcCalculatorStream OpenReader(string password)
		{
			return null;
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x7842550", Offset = "0x783E550", VA = "0x7842550")]
		internal CrcCalculatorStream InternalOpenReader(string password)
		{
			return null;
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x7842AD4", Offset = "0x783EAD4", VA = "0x7842AD4")]
		private void OnExtractProgress(long bytesWritten, long totalBytesToWrite)
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x7842B14", Offset = "0x783EB14", VA = "0x7842B14")]
		private void OnBeforeExtract(string path)
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x7842B5C", Offset = "0x783EB5C", VA = "0x7842B5C")]
		private void OnAfterExtract(string path)
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x7842BA0", Offset = "0x783EBA0", VA = "0x7842BA0")]
		private void OnExtractExisting(string path)
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x7842BDC", Offset = "0x783EBDC", VA = "0x7842BDC")]
		private static void ReallyDelete(string fileName)
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x7842BE4", Offset = "0x783EBE4", VA = "0x7842BE4")]
		private void WriteStatus(string format, params object[] args)
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x7841BA8", Offset = "0x783DBA8", VA = "0x7841BA8")]
		private void InternalExtract(string baseDir, Stream outstream, string password)
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x78434DC", Offset = "0x783F4DC", VA = "0x78434DC")]
		internal void VerifyCrcAfterExtract(int actualCrc32)
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x7842EBC", Offset = "0x783EEBC", VA = "0x7842EBC")]
		private int CheckExtractExistingFile(string baseDir, string targetFileName)
		{
			return default;
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x78435B4", Offset = "0x783F5B4", VA = "0x78435B4")]
		private void _CheckRead(int nbytes)
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x7843090", Offset = "0x783F090", VA = "0x7843090")]
		private int ExtractOne(Stream output)
		{
			return default;
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x7842A50", Offset = "0x783EA50", VA = "0x7842A50")]
		internal Stream GetExtractDecompressor(Stream input2)
		{
			return null;
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x78429D8", Offset = "0x783E9D8", VA = "0x78429D8")]
		internal Stream GetExtractDecryptor(Stream input)
		{
			return null;
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x78435B0", Offset = "0x783F5B0", VA = "0x78435B0")]
		internal void _SetTimes(string fileOrDirectory, bool isFile)
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x78427D4", Offset = "0x783E7D4", VA = "0x78427D4")]
		internal void ValidateEncryption()
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x784271C", Offset = "0x783E71C", VA = "0x784271C")]
		private void ValidateCompression()
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x7842884", Offset = "0x783E884", VA = "0x7842884")]
		private void SetupCryptoForExtract(string password)
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x7842C5C", Offset = "0x783EC5C", VA = "0x7842C5C")]
		private bool ValidateOutput(string basedir, Stream outstream, out string outFileName)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED ZipEntry.ValidateOutput RVA=0x7842C5C Token=0x6000103");
}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x78439D4", Offset = "0x783F9D4", VA = "0x78439D4")]
		private void ReadExtraField()
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x7843B60", Offset = "0x783FB60", VA = "0x7843B60")]
		private static bool ReadHeader(ZipEntry ze, Encoding defaultEncoding)
		{
			return default;
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x783FE60", Offset = "0x783BE60", VA = "0x783FE60")]
		internal static int ReadWeakEncryptionHeader(Stream s, byte[] buffer)
		{
			return default;
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x78443B8", Offset = "0x78403B8", VA = "0x78443B8")]
		private static bool IsNotValidSig(int signature)
		{
			return default;
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x78443CC", Offset = "0x78403CC", VA = "0x78443CC")]
		internal static ZipEntry ReadEntry(ZipContainer zc, bool first)
		{
			return null;
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x784454C", Offset = "0x784054C", VA = "0x784454C")]
		internal static void HandlePK00Prefix(Stream s)
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x78445E0", Offset = "0x78405E0", VA = "0x78445E0")]
		private static void HandleUnexpectedDataDescriptor(ZipEntry entry)
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x78446F0", Offset = "0x78406F0", VA = "0x78446F0")]
		internal static int FindExtraFieldSegment(byte[] extra, int offx, ushort targetHeaderId)
		{
			return default;
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x7841964", Offset = "0x783D964", VA = "0x7841964")]
		internal int ProcessExtraField(Stream s, short extraFieldLength)
		{
			return default;
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x7844CD4", Offset = "0x7840CD4", VA = "0x7844CD4")]
		private int ProcessExtraFieldPkwareStrongEncryption(byte[] Buffer, int j)
		{
			return default;
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x7844C10", Offset = "0x7840C10", VA = "0x7844C10")]
		private int ProcessExtraFieldZip64(byte[] buffer, int j, short dataSize, long posn)
		{
			return default;
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x7844A4C", Offset = "0x7840A4C", VA = "0x7844A4C")]
		private int ProcessExtraFieldInfoZipTimes(byte[] buffer, int j, short dataSize, long posn)
		{
			return default;
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x7844988", Offset = "0x7840988", VA = "0x7844988")]
		private int ProcessExtraFieldUnixTimes(byte[] buffer, int j, short dataSize, long posn)
		{
			return default;
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x784478C", Offset = "0x784078C", VA = "0x784478C")]
		private int ProcessExtraFieldWindowsTimes(byte[] buffer, int j, short dataSize, long posn)
		{
			return default;
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x7844D30", Offset = "0x7840D30", VA = "0x7844D30")]
		internal void WriteCentralDirectoryEntry(Stream s)
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x7845618", Offset = "0x7841618", VA = "0x7845618")]
		private byte[] ConstructExtraField(bool forCentralDirectory)
		{
			return null;
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x7845DF4", Offset = "0x7841DF4", VA = "0x7845DF4")]
		private string NormalizeFileName()
		{
			return null;
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x7845310", Offset = "0x7841310", VA = "0x7845310")]
		private byte[] GetEncodedFileNameBytes()
		{
			return null;
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x7845FEC", Offset = "0x7841FEC", VA = "0x7845FEC")]
		private bool WantReadAgain()
		{
			return default;
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x7846074", Offset = "0x7842074", VA = "0x7846074")]
		private void MaybeUnsetCompressionMethodForWriting(int cycle)
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x78461F0", Offset = "0x78421F0", VA = "0x78461F0")]
		internal void WriteHeader(Stream s, int cycle)
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x7846B44", Offset = "0x7842B44", VA = "0x7846B44")]
		private int FigureCrc32()
		{
			return default;
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x7846CF4", Offset = "0x7842CF4", VA = "0x7846CF4")]
		private void PrepSourceStream()
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x7846EA4", Offset = "0x7842EA4", VA = "0x7846EA4")]
		internal void CopyMetaData(ZipEntry source)
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x7846FE8", Offset = "0x7842FE8", VA = "0x7846FE8")]
		private void OnWriteBlock(long bytesXferred, long totalBytesToXfer)
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x7847028", Offset = "0x7843028", VA = "0x7847028")]
		private void _WriteEntryData(Stream s)
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x7847474", Offset = "0x7843474", VA = "0x7847474")]
		private long SetInputAndFigureFileLength(ref Stream input)
		{
			return default;
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x78479B0", Offset = "0x78439B0", VA = "0x78479B0")]
		internal void FinishOutputStream(Stream s, CountingStream entryCounter, Stream encryptor, Stream compressor, CrcCalculatorStream output)
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x7847B08", Offset = "0x7843B08", VA = "0x7847B08")]
		internal void PostProcessOutput(Stream s)
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x7846980", Offset = "0x7842980", VA = "0x7846980")]
		private void SetZip64Flags()
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x784850C", Offset = "0x784450C", VA = "0x784850C")]
		internal void PrepOutputStream(Stream s, long streamLength, out CountingStream outputCounter, out Stream encryptor, out Stream compressor, out CrcCalculatorStream output)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED ZipEntry.PrepOutputStream RVA=0x784850C Token=0x6000122");
}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x784771C", Offset = "0x784371C", VA = "0x784771C")]
		private Stream MaybeApplyCompression(Stream s, long streamLength)
		{
			return null;
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x78476A4", Offset = "0x78436A4", VA = "0x78476A4")]
		private Stream MaybeApplyEncryption(Stream s)
		{
			return null;
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x7848604", Offset = "0x7844604", VA = "0x7848604")]
		private void OnZipErrorWhileSaving(Exception e)
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x7848640", Offset = "0x7844640", VA = "0x7848640")]
		internal void Write(Stream s)
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x7848500", Offset = "0x7844500", VA = "0x7848500")]
		internal void StoreRelativeOffset()
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x7848FB8", Offset = "0x7844FB8", VA = "0x7848FB8")]
		internal void NotifySaveComplete()
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x7848DFC", Offset = "0x7844DFC", VA = "0x7848DFC")]
		internal void WriteSecurityMetadata(Stream outstream)
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x7848BC8", Offset = "0x7844BC8", VA = "0x7848BC8")]
		private void CopyThroughOneEntry(Stream outStream)
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x7848FFC", Offset = "0x7844FFC", VA = "0x7848FFC")]
		private void CopyThroughWithRecompute(Stream outstream)
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x784944C", Offset = "0x784544C", VA = "0x784944C")]
		private void CopyThroughWithNoChange(Stream outstream)
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x7849664", Offset = "0x7845664", VA = "0x7849664")]
		[Conditional("Trace")]
		private void TraceWriteLine(string format, params object[] varParams)
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x7849904", Offset = "0x7845904", VA = "0x7849904")]
		public void SetEntryTimes(DateTime created, DateTime accessed, DateTime modified)
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x7849E00", Offset = "0x7845E00", VA = "0x7849E00")]
		internal static string NameInArchive(string filename, string directoryPathInArchive)
		{
			return null;
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x784A1C4", Offset = "0x78461C4", VA = "0x784A1C4")]
		internal static ZipEntry CreateFromNothing(string nameInArchive)
		{
			return null;
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x784A624", Offset = "0x7846624", VA = "0x784A624")]
		internal static ZipEntry CreateFromFile(string filename, string nameInArchive)
		{
			return null;
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x784A690", Offset = "0x7846690", VA = "0x784A690")]
		internal static ZipEntry CreateForStream(string entryName, Stream s)
		{
			return null;
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x784A6FC", Offset = "0x78466FC", VA = "0x784A6FC")]
		internal static ZipEntry CreateForWriter(string entryName, WriteDelegate d)
		{
			return null;
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x784A768", Offset = "0x7846768", VA = "0x784A768")]
		internal static ZipEntry CreateForJitStreamProvider(string nameInArchive, OpenDelegate opener, CloseDelegate closer)
		{
			return null;
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x784A7D8", Offset = "0x78467D8", VA = "0x784A7D8")]
		internal static ZipEntry CreateForZipOutputStream(string nameInArchive)
		{
			return null;
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x784A224", Offset = "0x7846224", VA = "0x784A224")]
		private static ZipEntry Create(string nameInArchive, ZipEntrySource source, object arg1, object arg2)
		{
			return null;
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x78418EC", Offset = "0x783D8EC", VA = "0x78418EC")]
		internal void MarkAsDirectory()
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x784A84C", Offset = "0x784684C", VA = "0x784A84C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x784A898", Offset = "0x7846898", VA = "0x784A898")]
		private void SetFdpLoh()
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x7849608", Offset = "0x7845608", VA = "0x7849608")]
		internal static int GetLengthOfCryptoHeaderBytes(EncryptionAlgorithm a)
		{
			return default;
		}
	}
}
