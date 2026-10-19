using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;
using Pathfinding.Ionic.Zlib;

namespace Pathfinding.Ionic.Zip
{
	[Token(Token = "0x2000031")]
	[ComVisible(true)]
	[Guid("ebc25cf6-9120-4283-b972-0e5520d00005")]
	[ClassInterface(ClassInterfaceType.AutoDispatch)]
	public class ZipFile : IEnumerable<ZipEntry>, IDisposable, IEnumerable
	{
		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private long _lengthOfReadStream;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TextWriter _StatusMessageTextWriter;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool _CaseSensitiveRetrieval;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Stream _readstream;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Stream _writestream;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ushort _versionMadeBy;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
		private ushort _versionNeededToExtract;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private uint _diskNumberWithCd;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int _maxOutputSegmentSize;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private uint _numberOfSegmentsForMostRecentSave;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ZipErrorAction _zipErrorAction;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool _disposed;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Dictionary<string, ZipEntry> _entries;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<ZipEntry> _zipEntriesAsList;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private string _name;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private string _readName;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private string _Comment;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		internal string _Password;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool _emitNtfsTimes;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
		private bool _emitUnixTimes;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private CompressionStrategy _Strategy;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private CompressionMethod _compressionMethod;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private bool _fileAlreadyExists;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private string _temporaryFileName;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool _contentsChanged;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
		private bool _hasBeenSaved;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private string _TempFileFolder;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private bool _ReadStreamIsOurs;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private object LOCK;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool _saveOperationCanceled;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB9")]
		private bool _extractOperationCanceled;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBA")]
		private bool _addOperationCanceled;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private EncryptionAlgorithm _Encryption;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool _JustSaved;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private long _locEndOfCDS;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private uint _OffsetOfCentralDirectory;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private long _OffsetOfCentralDirectory64;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool? _OutputUsesZip64;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE2")]
		internal bool _inExtractAll;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Encoding _defaultEncoding;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Encoding _alternateEncoding;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private ZipOption _alternateEncodingUsage;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private int _BufferSize;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		internal ParallelDeflateOutputStream ParallelDeflater;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private long _ParallelDeflateThreshold;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private int _maxBufferPairs;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		internal Zip64Option _zip64;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private bool _SavingSfx;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly int BufferSizeDefault;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private EventHandler<SaveProgressEventArgs> m_SaveProgress;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private EventHandler<ReadProgressEventArgs> m_ReadProgress;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private EventHandler<ExtractProgressEventArgs> m_ExtractProgress;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private EventHandler<AddProgressEventArgs> m_AddProgress;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private EventHandler<ZipErrorEventArgs> m_ZipError;

		[Token(Token = "0x17000055")]
		public string Info
		{
			[Token(Token = "0x60001BD")]
			[Address(RVA = "0x784FD3C", Offset = "0x784BD3C", VA = "0x784FD3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000056")]
		private string ArchiveNameForEvent
		{
			[Token(Token = "0x60001BE")]
			[Address(RVA = "0x78504FC", Offset = "0x784C4FC", VA = "0x78504FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000057")]
		private long LengthOfReadStream
		{
			[Token(Token = "0x60001C8")]
			[Address(RVA = "0x7850B84", Offset = "0x784CB84", VA = "0x7850B84")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000058")]
		public bool FullScan
		{
			[Token(Token = "0x6000200")]
			[Address(RVA = "0x7857F4C", Offset = "0x7853F4C", VA = "0x7857F4C")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6000201")]
			[Address(RVA = "0x7857F54", Offset = "0x7853F54", VA = "0x7857F54")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000059")]
		public bool SortEntriesBeforeSaving
		{
			[Token(Token = "0x6000202")]
			[Address(RVA = "0x7857F60", Offset = "0x7853F60", VA = "0x7857F60")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6000203")]
			[Address(RVA = "0x7857F68", Offset = "0x7853F68", VA = "0x7857F68")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700005A")]
		public bool AddDirectoryWillTraverseReparsePoints
		{
			[Token(Token = "0x6000204")]
			[Address(RVA = "0x7857F74", Offset = "0x7853F74", VA = "0x7857F74")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6000205")]
			[Address(RVA = "0x7857F7C", Offset = "0x7853F7C", VA = "0x7857F7C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700005B")]
		public int BufferSize
		{
			[Token(Token = "0x6000206")]
			[Address(RVA = "0x7857F88", Offset = "0x7853F88", VA = "0x7857F88")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000207")]
			[Address(RVA = "0x7857F90", Offset = "0x7853F90", VA = "0x7857F90")]
			set
			{
			}
		}

		[Token(Token = "0x1700005C")]
		public int CodecBufferSize
		{
			[Token(Token = "0x6000208")]
			[Address(RVA = "0x7857F98", Offset = "0x7853F98", VA = "0x7857F98")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6000209")]
			[Address(RVA = "0x7857FA0", Offset = "0x7853FA0", VA = "0x7857FA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700005D")]
		public bool FlattenFoldersOnExtract
		{
			[Token(Token = "0x600020A")]
			[Address(RVA = "0x7857FA8", Offset = "0x7853FA8", VA = "0x7857FA8")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x600020B")]
			[Address(RVA = "0x7857FB0", Offset = "0x7853FB0", VA = "0x7857FB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700005E")]
		public CompressionStrategy Strategy
		{
			[Token(Token = "0x600020C")]
			[Address(RVA = "0x7857FBC", Offset = "0x7853FBC", VA = "0x7857FBC")]
			get
			{
				return default;
			}
			[Token(Token = "0x600020D")]
			[Address(RVA = "0x7857FC4", Offset = "0x7853FC4", VA = "0x7857FC4")]
			set
			{
			}
		}

		[Token(Token = "0x1700005F")]
		public string Name
		{
			[Token(Token = "0x600020E")]
			[Address(RVA = "0x7857FCC", Offset = "0x7853FCC", VA = "0x7857FCC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600020F")]
			[Address(RVA = "0x7857FD4", Offset = "0x7853FD4", VA = "0x7857FD4")]
			set
			{
			}
		}

		[Token(Token = "0x17000060")]
		public CompressionLevel CompressionLevel
		{
			[Token(Token = "0x6000210")]
			[Address(RVA = "0x7857FDC", Offset = "0x7853FDC", VA = "0x7857FDC")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6000211")]
			[Address(RVA = "0x7857FE4", Offset = "0x7853FE4", VA = "0x7857FE4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000061")]
		public CompressionMethod CompressionMethod
		{
			[Token(Token = "0x6000212")]
			[Address(RVA = "0x7857FEC", Offset = "0x7853FEC", VA = "0x7857FEC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000213")]
			[Address(RVA = "0x7857FF4", Offset = "0x7853FF4", VA = "0x7857FF4")]
			set
			{
			}
		}

		[Token(Token = "0x17000062")]
		public string Comment
		{
			[Token(Token = "0x6000214")]
			[Address(RVA = "0x7857FFC", Offset = "0x7853FFC", VA = "0x7857FFC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000215")]
			[Address(RVA = "0x785354C", Offset = "0x784F54C", VA = "0x785354C")]
			set
			{
			}
		}

		[Token(Token = "0x17000063")]
		public bool EmitTimesInWindowsFormatWhenSaving
		{
			[Token(Token = "0x6000216")]
			[Address(RVA = "0x7858004", Offset = "0x7854004", VA = "0x7858004")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000217")]
			[Address(RVA = "0x785800C", Offset = "0x785400C", VA = "0x785800C")]
			set
			{
			}
		}

		[Token(Token = "0x17000064")]
		public bool EmitTimesInUnixFormatWhenSaving
		{
			[Token(Token = "0x6000218")]
			[Address(RVA = "0x7858018", Offset = "0x7854018", VA = "0x7858018")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000219")]
			[Address(RVA = "0x7858020", Offset = "0x7854020", VA = "0x7858020")]
			set
			{
			}
		}

		[Token(Token = "0x17000065")]
		internal bool Verbose
		{
			[Token(Token = "0x600021A")]
			[Address(RVA = "0x784C318", Offset = "0x7848318", VA = "0x784C318")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000066")]
		public bool CaseSensitiveRetrieval
		{
			[Token(Token = "0x600021C")]
			[Address(RVA = "0x78580C0", Offset = "0x78540C0", VA = "0x78580C0")]
			get
			{
				return default;
			}
			[Token(Token = "0x600021D")]
			[Address(RVA = "0x78580C8", Offset = "0x78540C8", VA = "0x78580C8")]
			set
			{
			}
		}

		[Token(Token = "0x17000067")]
		[Obsolete("Beginning with v1.9.1.6 of DotNetZip, this property is obsolete.  It will be removed in a future version of the library. Your applications should  use AlternateEncoding and AlternateEncodingUsage instead.")]
		public bool UseUnicodeAsNecessary
		{
			[Token(Token = "0x600021E")]
			[Address(RVA = "0x7858244", Offset = "0x7854244", VA = "0x7858244")]
			get
			{
				return default;
			}
			[Token(Token = "0x600021F")]
			[Address(RVA = "0x78582B0", Offset = "0x78542B0", VA = "0x78582B0")]
			set
			{
			}
		}

		[Token(Token = "0x17000068")]
		public Zip64Option UseZip64WhenSaving
		{
			[Token(Token = "0x6000220")]
			[Address(RVA = "0x785837C", Offset = "0x785437C", VA = "0x785837C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000221")]
			[Address(RVA = "0x7858384", Offset = "0x7854384", VA = "0x7858384")]
			set
			{
			}
		}

		[Token(Token = "0x17000069")]
		public bool? RequiresZip64
		{
			[Token(Token = "0x6000222")]
			[Address(RVA = "0x785838C", Offset = "0x785438C", VA = "0x785838C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006A")]
		public bool? OutputUsedZip64
		{
			[Token(Token = "0x6000223")]
			[Address(RVA = "0x78585EC", Offset = "0x78545EC", VA = "0x78585EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006B")]
		public bool? InputUsesZip64
		{
			[Token(Token = "0x6000224")]
			[Address(RVA = "0x78501A8", Offset = "0x784C1A8", VA = "0x78501A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006C")]
		[Obsolete("use AlternateEncoding instead.")]
		public Encoding ProvisionalAlternateEncoding
		{
			[Token(Token = "0x6000225")]
			[Address(RVA = "0x78585F4", Offset = "0x78545F4", VA = "0x78585F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000226")]
			[Address(RVA = "0x7858610", Offset = "0x7854610", VA = "0x7858610")]
			set
			{
			}
		}

		[Token(Token = "0x1700006D")]
		public Encoding AlternateEncoding
		{
			[Token(Token = "0x6000227")]
			[Address(RVA = "0x7858620", Offset = "0x7854620", VA = "0x7858620")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000228")]
			[Address(RVA = "0x7858628", Offset = "0x7854628", VA = "0x7858628")]
			set
			{
			}
		}

		[Token(Token = "0x1700006E")]
		public ZipOption AlternateEncodingUsage
		{
			[Token(Token = "0x6000229")]
			[Address(RVA = "0x7858630", Offset = "0x7854630", VA = "0x7858630")]
			get
			{
				return default;
			}
			[Token(Token = "0x600022A")]
			[Address(RVA = "0x7858638", Offset = "0x7854638", VA = "0x7858638")]
			set
			{
			}
		}

		[Token(Token = "0x1700006F")]
		public static Encoding DefaultEncoding
		{
			[Token(Token = "0x600022B")]
			[Address(RVA = "0x7858640", Offset = "0x7854640", VA = "0x7858640")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000070")]
		public TextWriter StatusMessageTextWriter
		{
			[Token(Token = "0x600022C")]
			[Address(RVA = "0x7858698", Offset = "0x7854698", VA = "0x7858698")]
			get
			{
				return null;
			}
			[Token(Token = "0x600022D")]
			[Address(RVA = "0x78586A0", Offset = "0x78546A0", VA = "0x78586A0")]
			set
			{
			}
		}

		[Token(Token = "0x17000071")]
		public string TempFileFolder
		{
			[Token(Token = "0x600022E")]
			[Address(RVA = "0x78586A8", Offset = "0x78546A8", VA = "0x78586A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600022F")]
			[Address(RVA = "0x78586B0", Offset = "0x78546B0", VA = "0x78586B0")]
			set
			{
			}
		}

		[Token(Token = "0x17000072")]
		public string Password
		{
			[Token(Token = "0x6000231")]
			[Address(RVA = "0x78587BC", Offset = "0x78547BC", VA = "0x78587BC")]
			private get
			{
				return null;
			}
			[Token(Token = "0x6000230")]
			[Address(RVA = "0x7858734", Offset = "0x7854734", VA = "0x7858734")]
			set
			{
			}
		}

		[Token(Token = "0x17000073")]
		public ExtractExistingFileAction ExtractExistingFile
		{
			[Token(Token = "0x6000232")]
			[Address(RVA = "0x78587C4", Offset = "0x78547C4", VA = "0x78587C4")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6000233")]
			[Address(RVA = "0x78587CC", Offset = "0x78547CC", VA = "0x78587CC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000074")]
		public ZipErrorAction ZipErrorAction
		{
			[Token(Token = "0x6000234")]
			[Address(RVA = "0x784DF78", Offset = "0x7849F78", VA = "0x784DF78")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000235")]
			[Address(RVA = "0x78587D4", Offset = "0x78547D4", VA = "0x78587D4")]
			set
			{
			}
		}

		[Token(Token = "0x17000075")]
		public EncryptionAlgorithm Encryption
		{
			[Token(Token = "0x6000236")]
			[Address(RVA = "0x78587F0", Offset = "0x78547F0", VA = "0x78587F0")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000237")]
			[Address(RVA = "0x785875C", Offset = "0x785475C", VA = "0x785875C")]
			set
			{
			}
		}

		[Token(Token = "0x17000076")]
		public SetCompressionCallback SetCompression
		{
			[Token(Token = "0x6000238")]
			[Address(RVA = "0x78587F8", Offset = "0x78547F8", VA = "0x78587F8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000239")]
			[Address(RVA = "0x7858800", Offset = "0x7854800", VA = "0x7858800")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000077")]
		public int MaxOutputSegmentSize
		{
			[Token(Token = "0x600023A")]
			[Address(RVA = "0x7858808", Offset = "0x7854808", VA = "0x7858808")]
			get
			{
				return default;
			}
			[Token(Token = "0x600023B")]
			[Address(RVA = "0x7858810", Offset = "0x7854810", VA = "0x7858810")]
			set
			{
			}
		}

		[Token(Token = "0x17000078")]
		public int NumberOfSegmentsForMostRecentSave
		{
			[Token(Token = "0x600023C")]
			[Address(RVA = "0x7858874", Offset = "0x7854874", VA = "0x7858874")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000079")]
		public long ParallelDeflateThreshold
		{
			[Token(Token = "0x600023E")]
			[Address(RVA = "0x78588EC", Offset = "0x78548EC", VA = "0x78588EC")]
			get
			{
				return default;
			}
			[Token(Token = "0x600023D")]
			[Address(RVA = "0x7858880", Offset = "0x7854880", VA = "0x7858880")]
			set
			{
			}
		}

		[Token(Token = "0x1700007A")]
		public int ParallelDeflateMaxBufferPairs
		{
			[Token(Token = "0x600023F")]
			[Address(RVA = "0x78588F4", Offset = "0x78548F4", VA = "0x78588F4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000240")]
			[Address(RVA = "0x78588FC", Offset = "0x78548FC", VA = "0x78588FC")]
			set
			{
			}
		}

		[Token(Token = "0x1700007B")]
		public static Version LibraryVersion
		{
			[Token(Token = "0x6000242")]
			[Address(RVA = "0x78589C4", Offset = "0x78549C4", VA = "0x78589C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007C")]
		private List<ZipEntry> ZipEntriesAsList
		{
			[Token(Token = "0x6000249")]
			[Address(RVA = "0x7858AEC", Offset = "0x7854AEC", VA = "0x7858AEC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007D")]
		public ZipEntry this[int ix]
		{
			[Token(Token = "0x600024A")]
			[Address(RVA = "0x7858B98", Offset = "0x7854B98", VA = "0x7858B98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007E")]
		public ZipEntry this[string fileName]
		{
			[Token(Token = "0x600024B")]
			[Address(RVA = "0x784D794", Offset = "0x7849794", VA = "0x784D794")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007F")]
		public ICollection<string> EntryFileNames
		{
			[Token(Token = "0x600024C")]
			[Address(RVA = "0x7858BF4", Offset = "0x7854BF4", VA = "0x7858BF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000080")]
		public ICollection<ZipEntry> Entries
		{
			[Token(Token = "0x600024D")]
			[Address(RVA = "0x78556A4", Offset = "0x78516A4", VA = "0x78556A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000081")]
		public ICollection<ZipEntry> EntriesSorted
		{
			[Token(Token = "0x600024E")]
			[Address(RVA = "0x7855300", Offset = "0x7851300", VA = "0x7855300")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000082")]
		public int Count
		{
			[Token(Token = "0x600024F")]
			[Address(RVA = "0x7858C44", Offset = "0x7854C44", VA = "0x7858C44")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000083")]
		internal Stream ReadStream
		{
			[Token(Token = "0x6000254")]
			[Address(RVA = "0x7850B34", Offset = "0x784CB34", VA = "0x7850B34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000084")]
		private Stream WriteStream
		{
			[Token(Token = "0x6000255")]
			[Address(RVA = "0x7854B60", Offset = "0x7850B60", VA = "0x7854B60")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000256")]
			[Address(RVA = "0x7858E14", Offset = "0x7854E14", VA = "0x7858E14")]
			set
			{
			}
		}

		[Token(Token = "0x14000001")]
		public event EventHandler<SaveProgressEventArgs> SaveProgress
		{
			[Token(Token = "0x6000189")]
			[Address(RVA = "0x784B998", Offset = "0x7847998", VA = "0x784B998")]
			add
			{
			}
			[Token(Token = "0x600018A")]
			[Address(RVA = "0x784BA58", Offset = "0x7847A58", VA = "0x784BA58")]
			remove
			{
			}
		}

		[Token(Token = "0x14000002")]
		public event EventHandler<ReadProgressEventArgs> ReadProgress
		{
			[Token(Token = "0x600018B")]
			[Address(RVA = "0x784BB18", Offset = "0x7847B18", VA = "0x784BB18")]
			add
			{
			}
			[Token(Token = "0x600018C")]
			[Address(RVA = "0x784BBD8", Offset = "0x7847BD8", VA = "0x784BBD8")]
			remove
			{
			}
		}

		[Token(Token = "0x14000003")]
		public event EventHandler<ExtractProgressEventArgs> ExtractProgress
		{
			[Token(Token = "0x600018D")]
			[Address(RVA = "0x784BC98", Offset = "0x7847C98", VA = "0x784BC98")]
			add
			{
			}
			[Token(Token = "0x600018E")]
			[Address(RVA = "0x784BD58", Offset = "0x7847D58", VA = "0x784BD58")]
			remove
			{
			}
		}

		[Token(Token = "0x14000004")]
		public event EventHandler<AddProgressEventArgs> AddProgress
		{
			[Token(Token = "0x600018F")]
			[Address(RVA = "0x784BE18", Offset = "0x7847E18", VA = "0x784BE18")]
			add
			{
			}
			[Token(Token = "0x6000190")]
			[Address(RVA = "0x784BED8", Offset = "0x7847ED8", VA = "0x784BED8")]
			remove
			{
			}
		}

		[Token(Token = "0x14000005")]
		public event EventHandler<ZipErrorEventArgs> ZipError
		{
			[Token(Token = "0x6000191")]
			[Address(RVA = "0x784BF98", Offset = "0x7847F98", VA = "0x784BF98")]
			add
			{
			}
			[Token(Token = "0x6000192")]
			[Address(RVA = "0x784C058", Offset = "0x7848058", VA = "0x784C058")]
			remove
			{
			}
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x784AF90", Offset = "0x7846F90", VA = "0x784AF90")]
		public ZipFile(string fileName)
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x784B204", Offset = "0x7847204", VA = "0x784B204")]
		public ZipFile(string fileName, Encoding encoding)
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x784B3D0", Offset = "0x78473D0", VA = "0x784B3D0")]
		public ZipFile()
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x784B4B4", Offset = "0x78474B4", VA = "0x784B4B4")]
		public ZipFile(Encoding encoding)
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x784B5A8", Offset = "0x78475A8", VA = "0x784B5A8")]
		public ZipFile(string fileName, TextWriter statusMessageWriter)
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x784B768", Offset = "0x7847768", VA = "0x784B768")]
		public ZipFile(string fileName, TextWriter statusMessageWriter, Encoding encoding)
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x784C118", Offset = "0x7848118", VA = "0x784C118", Slot = "5")]
IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x784C180", Offset = "0x7848180", VA = "0x784C180")]
		public ZipEntry AddItem(string fileOrDirectoryName)
		{
			return null;
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x784C188", Offset = "0x7848188", VA = "0x784C188")]
		public ZipEntry AddItem(string fileOrDirectoryName, string directoryPathInArchive)
		{
			return null;
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x784C310", Offset = "0x7848310", VA = "0x784C310")]
		public ZipEntry AddFile(string fileName)
		{
			return null;
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x784C244", Offset = "0x7848244", VA = "0x784C244")]
		public ZipEntry AddFile(string fileName, string directoryPathInArchive)
		{
			return null;
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x784C450", Offset = "0x7848450", VA = "0x784C450")]
		public void RemoveEntries(ICollection<ZipEntry> entriesToRemove)
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x784C854", Offset = "0x7848854", VA = "0x784C854")]
		public void RemoveEntries(ICollection<string> entriesToRemove)
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x784CC38", Offset = "0x7848C38", VA = "0x784CC38")]
		public void AddFiles(IEnumerable<string> fileNames)
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x784CC50", Offset = "0x7848C50", VA = "0x784CC50")]
		public void UpdateFiles(IEnumerable<string> fileNames)
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x784CC44", Offset = "0x7848C44", VA = "0x784CC44")]
		public void AddFiles(IEnumerable<string> fileNames, string directoryPathInArchive)
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x784CFB0", Offset = "0x7848FB0", VA = "0x784CFB0")]
		public void AddFiles(IEnumerable<string> fileNames, bool preserveDirHierarchy, string directoryPathInArchive)
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x784CC58", Offset = "0x7848C58", VA = "0x784CC58")]
		public void UpdateFiles(IEnumerable<string> fileNames, string directoryPathInArchive)
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x784D78C", Offset = "0x784978C", VA = "0x784D78C")]
		public ZipEntry UpdateFile(string fileName)
		{
			return null;
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x784D6F0", Offset = "0x78496F0", VA = "0x784D6F0")]
		public ZipEntry UpdateFile(string fileName, string directoryPathInArchive)
		{
			return null;
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x784D8CC", Offset = "0x78498CC", VA = "0x784D8CC")]
		public ZipEntry UpdateDirectory(string directoryName)
		{
			return null;
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x784D8D8", Offset = "0x78498D8", VA = "0x784D8D8")]
		public ZipEntry UpdateDirectory(string directoryName, string directoryPathInArchive)
		{
			return null;
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x784D95C", Offset = "0x784995C", VA = "0x784D95C")]
		public void UpdateItem(string itemName)
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x784D964", Offset = "0x7849964", VA = "0x784D964")]
		public void UpdateItem(string itemName, string directoryPathInArchive)
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x784DA20", Offset = "0x7849A20", VA = "0x784DA20")]
		public ZipEntry AddEntry(string entryName, string content)
		{
			return null;
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x784DA58", Offset = "0x7849A58", VA = "0x784DA58")]
		public ZipEntry AddEntry(string entryName, string content, Encoding encoding)
		{
			return null;
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x784DB54", Offset = "0x7849B54", VA = "0x784DB54")]
		public ZipEntry AddEntry(string entryName, Stream stream)
		{
			return null;
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x784DC6C", Offset = "0x7849C6C", VA = "0x784DC6C")]
		public ZipEntry AddEntry(string entryName, WriteDelegate writer)
		{
			return null;
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x784DD20", Offset = "0x7849D20", VA = "0x784DD20")]
		public ZipEntry AddEntry(string entryName, OpenDelegate opener, CloseDelegate closer)
		{
			return null;
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x784C328", Offset = "0x7848328", VA = "0x784C328")]
		private ZipEntry _InternalAddEntry(ZipEntry ze)
		{
			return null;
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x784E0F8", Offset = "0x784A0F8", VA = "0x784E0F8")]
		public ZipEntry UpdateEntry(string entryName, string content)
		{
			return null;
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x784E148", Offset = "0x784A148", VA = "0x784E148")]
		public ZipEntry UpdateEntry(string entryName, string content, Encoding encoding)
		{
			return null;
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x784E2E4", Offset = "0x784A2E4", VA = "0x784E2E4")]
		public ZipEntry UpdateEntry(string entryName, WriteDelegate writer)
		{
			return null;
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x784E314", Offset = "0x784A314", VA = "0x784E314")]
		public ZipEntry UpdateEntry(string entryName, OpenDelegate opener, CloseDelegate closer)
		{
			return null;
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x784E354", Offset = "0x784A354", VA = "0x784E354")]
		public ZipEntry UpdateEntry(string entryName, Stream stream)
		{
			return null;
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x784E188", Offset = "0x784A188", VA = "0x784E188")]
		private void RemoveEntryForUpdate(string entryName)
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x784E384", Offset = "0x784A384", VA = "0x784E384")]
		public ZipEntry AddEntry(string entryName, byte[] byteContent)
		{
			return null;
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x784E458", Offset = "0x784A458", VA = "0x784E458")]
		public ZipEntry UpdateEntry(string entryName, byte[] byteContent)
		{
			return null;
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x784E488", Offset = "0x784A488", VA = "0x784E488")]
		public ZipEntry AddDirectory(string directoryName)
		{
			return null;
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x784C308", Offset = "0x7848308", VA = "0x784C308")]
		public ZipEntry AddDirectory(string directoryName, string directoryPathInArchive)
		{
			return null;
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x784E494", Offset = "0x784A494", VA = "0x784E494")]
		public ZipEntry AddDirectoryByName(string directoryNameInArchive)
		{
			return null;
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x784D8E0", Offset = "0x78498E0", VA = "0x784D8E0")]
		private ZipEntry AddOrUpdateDirectoryImpl(string directoryName, string rootDirectoryPathInArchive, AddOrUpdateAction action)
		{
			return null;
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x784DF98", Offset = "0x7849F98", VA = "0x784DF98")]
		internal void InternalAddEntry(string name, ZipEntry entry)
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x784E5F8", Offset = "0x784A5F8", VA = "0x784E5F8")]
		private ZipEntry AddOrUpdateDirectoryImpl(string directoryName, string rootDirectoryPathInArchive, AddOrUpdateAction action, bool recurse, int level)
		{
			return null;
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x784E9CC", Offset = "0x784A9CC", VA = "0x784E9CC")]
		public static bool CheckZip(string zipFileName)
		{
			return default;
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x784EA28", Offset = "0x784AA28", VA = "0x784EA28")]
		public static bool CheckZip(string zipFileName, bool fixIfNecessary, TextWriter writer)
		{
			return default;
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x784F6E8", Offset = "0x784B6E8", VA = "0x784F6E8")]
		public static void FixZipDirectory(string zipFileName)
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x784F890", Offset = "0x784B890", VA = "0x784F890")]
		public static bool CheckZipPassword(string zipFileName, string password)
		{
			return default;
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x785054C", Offset = "0x784C54C", VA = "0x785054C")]
		internal bool OnSaveBlock(ZipEntry entry, long bytesXferred, long totalBytesToXfer)
		{
			return default;
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x7850610", Offset = "0x784C610", VA = "0x7850610")]
		private void OnSaveEntry(int current, ZipEntry entry, bool before)
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x7850738", Offset = "0x784C738", VA = "0x7850738")]
		private void OnSaveEvent(ZipProgressEventType eventFlavor)
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x7850818", Offset = "0x784C818", VA = "0x7850818")]
		private void OnSaveStarted()
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x78508B8", Offset = "0x784C8B8", VA = "0x78508B8")]
		private void OnSaveCompleted()
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x7850948", Offset = "0x784C948", VA = "0x7850948")]
		private void OnReadStarted()
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x78509D8", Offset = "0x784C9D8", VA = "0x78509D8")]
		private void OnReadCompleted()
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x7850A68", Offset = "0x784CA68", VA = "0x7850A68")]
		internal void OnReadBytes(ZipEntry entry)
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x7850C04", Offset = "0x784CC04", VA = "0x7850C04")]
		internal void OnReadEntry(bool before, ZipEntry entry)
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x7850D00", Offset = "0x784CD00", VA = "0x7850D00")]
		private void OnExtractEntry(int current, bool before, ZipEntry currentEntry, string path)
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x7850E30", Offset = "0x784CE30", VA = "0x7850E30")]
		internal bool OnExtractBlock(ZipEntry entry, long bytesWritten, long totalBytesToWrite)
		{
			return default;
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x7850EF4", Offset = "0x784CEF4", VA = "0x7850EF4")]
		internal bool OnSingleEntryExtract(ZipEntry entry, string path, bool before)
		{
			return default;
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x7850FBC", Offset = "0x784CFBC", VA = "0x7850FBC")]
		internal bool OnExtractExisting(ZipEntry entry, string path)
		{
			return default;
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x7851078", Offset = "0x784D078", VA = "0x7851078")]
		private void OnExtractAllCompleted(string path)
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x7851110", Offset = "0x784D110", VA = "0x7851110")]
		private void OnExtractAllStarted(string path)
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x784D5C0", Offset = "0x78495C0", VA = "0x784D5C0")]
		private void OnAddStarted()
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x784D660", Offset = "0x7849660", VA = "0x784D660")]
		private void OnAddCompleted()
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x784E010", Offset = "0x784A010", VA = "0x784E010")]
		internal void AfterAddEntry(ZipEntry entry)
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x78511A8", Offset = "0x784D1A8", VA = "0x78511A8")]
		internal bool OnZipErrorSaving(ZipEntry entry, Exception exc)
		{
			return default;
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x78512B8", Offset = "0x784D2B8", VA = "0x78512B8")]
		public void ExtractAll(string path)
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x7851CF4", Offset = "0x784DCF4", VA = "0x7851CF4")]
		public void ExtractAll(string path, ExtractExistingFileAction extractExistingFile)
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x78512C0", Offset = "0x784D2C0", VA = "0x78512C0")]
		private void _InternalExtractAll(string path, bool overrideExtractExistingProperty)
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x784F52C", Offset = "0x784B52C", VA = "0x784F52C")]
		public static ZipFile Read(string fileName)
		{
			return null;
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x7851E3C", Offset = "0x784DE3C", VA = "0x7851E3C")]
		public static ZipFile Read(string fileName, ReadOptions options)
		{
			return null;
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x7851D04", Offset = "0x784DD04", VA = "0x7851D04")]
		private static ZipFile Read(string fileName, TextWriter statusMessageWriter, Encoding encoding, EventHandler<ReadProgressEventArgs> readProgress)
		{
			return null;
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x78523C4", Offset = "0x784E3C4", VA = "0x78523C4")]
		public static ZipFile Read(Stream zipStream)
		{
			return null;
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x78525EC", Offset = "0x784E5EC", VA = "0x78525EC")]
		public static ZipFile Read(Stream zipStream, ReadOptions options)
		{
			return null;
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x7852424", Offset = "0x784E424", VA = "0x7852424")]
		private static ZipFile Read(Stream zipStream, TextWriter statusMessageWriter, Encoding encoding, EventHandler<ReadProgressEventArgs> readProgress)
		{
			return null;
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x7851EFC", Offset = "0x784DEFC", VA = "0x7851EFC")]
		private static void ReadIntoInstance(ZipFile zf)
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x7852B28", Offset = "0x784EB28", VA = "0x7852B28")]
		private static void Zip64SeekToCentralDirectory(ZipFile zf)
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x7852AD0", Offset = "0x784EAD0", VA = "0x7852AD0")]
		private static uint ReadFirstFourBytes(Stream s)
		{
			return default;
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x7852D9C", Offset = "0x784ED9C", VA = "0x7852D9C")]
		private static void ReadCentralDirectory(ZipFile zf)
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x78526AC", Offset = "0x784E6AC", VA = "0x78526AC")]
		private static void ReadIntoInstance_Orig(ZipFile zf)
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x7853070", Offset = "0x784F070", VA = "0x7853070")]
		private static void ReadCentralDirectoryFooter(ZipFile zf)
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x7853430", Offset = "0x784F430", VA = "0x7853430")]
		private static void ReadZipFileComment(ZipFile zf)
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x785355C", Offset = "0x784F55C", VA = "0x785355C")]
		public static bool IsZipFile(string fileName)
		{
			return default;
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x78535B4", Offset = "0x784F5B4", VA = "0x78535B4")]
		public static bool IsZipFile(string fileName, bool testExtract)
		{
			return default;
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x7853848", Offset = "0x784F848", VA = "0x7853848")]
		public static bool IsZipFile(Stream stream, bool testExtract)
		{
			return default;
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x7853D80", Offset = "0x784FD80", VA = "0x7853D80")]
		private void DeleteFileWithRetry(string filename)
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x7853E84", Offset = "0x784FE84", VA = "0x7853E84")]
		public void Save()
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x7855FE8", Offset = "0x7851FE8", VA = "0x7855FE8")]
		private static void NotifyEntriesSaveComplete(ICollection<ZipEntry> c)
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x78562B8", Offset = "0x78522B8", VA = "0x78562B8")]
		private void RemoveTempFile()
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x78563B4", Offset = "0x78523B4", VA = "0x78563B4")]
		private void CleanupAfterSaveOperation()
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x784F5F8", Offset = "0x784B5F8", VA = "0x784F5F8")]
		public void Save(string fileName)
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x785646C", Offset = "0x785246C", VA = "0x785646C")]
		public void Save(Stream outputStream)
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x7856588", Offset = "0x7852588", VA = "0x7856588")]
		public void AddSelectedFiles(string selectionCriteria)
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x78565F8", Offset = "0x78525F8", VA = "0x78565F8")]
		public void AddSelectedFiles(string selectionCriteria, bool recurseDirectories)
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x7856660", Offset = "0x7852660", VA = "0x7856660")]
		public void AddSelectedFiles(string selectionCriteria, string directoryOnDisk)
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x7856670", Offset = "0x7852670", VA = "0x7856670")]
		public void AddSelectedFiles(string selectionCriteria, string directoryOnDisk, bool recurseDirectories)
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x7856680", Offset = "0x7852680", VA = "0x7856680")]
		public void AddSelectedFiles(string selectionCriteria, string directoryOnDisk, string directoryPathInArchive)
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x78565EC", Offset = "0x78525EC", VA = "0x78565EC")]
		public void AddSelectedFiles(string selectionCriteria, string directoryOnDisk, string directoryPathInArchive, bool recurseDirectories)
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x7856C28", Offset = "0x7852C28", VA = "0x7856C28")]
		public void UpdateSelectedFiles(string selectionCriteria, string directoryOnDisk, string directoryPathInArchive, bool recurseDirectories)
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x7856C34", Offset = "0x7852C34", VA = "0x7856C34")]
		private string EnsureendInSlash(string s)
		{
			return null;
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x785668C", Offset = "0x785268C", VA = "0x785668C")]
		private void _AddOrUpdateSelectedFiles(string selectionCriteria, string directoryOnDisk, string directoryPathInArchive, bool recurseDirectories, bool wantUpdate)
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x7856CAC", Offset = "0x7852CAC", VA = "0x7856CAC")]
		private static string ReplaceLeadingDirectory(string original, string pattern, string replacement)
		{
			return null;
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x7856D48", Offset = "0x7852D48", VA = "0x7856D48")]
		public ICollection<ZipEntry> SelectEntries(string selectionCriteria)
		{
			return null;
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x7856DC8", Offset = "0x7852DC8", VA = "0x7856DC8")]
		public ICollection<ZipEntry> SelectEntries(string selectionCriteria, string directoryPathInArchive)
		{
			return null;
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x7856E50", Offset = "0x7852E50", VA = "0x7856E50")]
		public int RemoveSelectedEntries(string selectionCriteria)
		{
			return default;
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x7856F0C", Offset = "0x7852F0C", VA = "0x7856F0C")]
		public int RemoveSelectedEntries(string selectionCriteria, string directoryPathInArchive)
		{
			return default;
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x7856FD8", Offset = "0x7852FD8", VA = "0x7856FD8")]
		public void ExtractSelectedEntries(string selectionCriteria)
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x78572E0", Offset = "0x78532E0", VA = "0x78572E0")]
		public void ExtractSelectedEntries(string selectionCriteria, ExtractExistingFileAction extractExistingFile)
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x78575F4", Offset = "0x78535F4", VA = "0x78575F4")]
		public void ExtractSelectedEntries(string selectionCriteria, string directoryPathInArchive)
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x7857904", Offset = "0x7853904", VA = "0x7857904")]
		public void ExtractSelectedEntries(string selectionCriteria, string directoryInArchive, string extractDirectory)
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x7857C20", Offset = "0x7853C20", VA = "0x7857C20")]
		public void ExtractSelectedEntries(string selectionCriteria, string directoryPathInArchive, string extractDirectory, ExtractExistingFileAction extractExistingFile)
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x785802C", Offset = "0x785402C", VA = "0x785802C")]
		public bool ContainsEntry(string name)
		{
			return default;
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x7858978", Offset = "0x7854978", VA = "0x7858978", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x7858A28", Offset = "0x7854A28", VA = "0x7858A28")]
		internal void NotifyEntryChanged()
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x7858A34", Offset = "0x7854A34", VA = "0x7858A34")]
		internal Stream StreamForDiskNumber(uint diskNumber)
		{
			return null;
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x7854C48", Offset = "0x7850C48", VA = "0x7854C48")]
		internal void Reset(bool whileSaving)
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x784F444", Offset = "0x784B444", VA = "0x784F444")]
		public void Initialize(string fileName)
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x78580E4", Offset = "0x78540E4", VA = "0x78580E4")]
		private void _initEntriesDictionary()
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x784B144", Offset = "0x7847144", VA = "0x784B144")]
		private void _InitInstance(string zipFileName, TextWriter statusMessageWriter)
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x784C768", Offset = "0x7848768", VA = "0x784C768")]
		public void RemoveEntry(ZipEntry entry)
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x784CB6C", Offset = "0x7848B6C", VA = "0x784CB6C")]
		public void RemoveEntry(string fileName)
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x784F58C", Offset = "0x784B58C", VA = "0x784F58C", Slot = "6")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x7858C94", Offset = "0x7854C94", VA = "0x7858C94", Slot = "7")]
		protected virtual void Dispose(bool disposeManagedResources)
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x784C11C", Offset = "0x784811C", VA = "0x784C11C", Slot = "4")]
		[DebuggerHidden]
		public IEnumerator<ZipEntry> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x7858E78", Offset = "0x7854E78", VA = "0x7858E78")]
		[DispId(-4)]
		public IEnumerator GetNewEnum()
		{
			return null;
		}
	}
}
