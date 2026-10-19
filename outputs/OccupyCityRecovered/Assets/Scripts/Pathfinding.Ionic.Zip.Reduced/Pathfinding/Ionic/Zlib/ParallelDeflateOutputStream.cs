using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using Il2CppDummyDll;
using Pathfinding.Ionic.Crc;

namespace Pathfinding.Ionic.Zlib
{
	[Token(Token = "0x2000059")]
	public class ParallelDeflateOutputStream : Stream
	{
		[Token(Token = "0x200005A")]
		[Flags]
		private enum TraceBits : uint
		{
			[Token(Token = "0x4000317")]
			None = 0u,
			[Token(Token = "0x4000318")]
			NotUsed1 = 1u,
			[Token(Token = "0x4000319")]
			EmitLock = 2u,
			[Token(Token = "0x400031A")]
			EmitEnter = 4u,
			[Token(Token = "0x400031B")]
			EmitBegin = 8u,
			[Token(Token = "0x400031C")]
			EmitDone = 0x10u,
			[Token(Token = "0x400031D")]
			EmitSkip = 0x20u,
			[Token(Token = "0x400031E")]
			EmitAll = EmitLock | EmitBegin | EmitDone | EmitSkip,
			[Token(Token = "0x400031F")]
			Flush = 0x40u,
			[Token(Token = "0x4000320")]
			Lifecycle = 0x80u,
			[Token(Token = "0x4000321")]
			Session = 0x100u,
			[Token(Token = "0x4000322")]
			Synch = 0x200u,
			[Token(Token = "0x4000323")]
			Instance = 0x400u,
			[Token(Token = "0x4000324")]
			Compress = 0x800u,
			[Token(Token = "0x4000325")]
			Write = 0x1000u,
			[Token(Token = "0x4000326")]
			WriteEnter = 0x2000u,
			[Token(Token = "0x4000327")]
			WriteTake = 0x4000u,
			[Token(Token = "0x4000328")]
			All = uint.MaxValue
		}

		[Token(Token = "0x40002FA")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int IO_BUFFER_SIZE_DEFAULT;

		[Token(Token = "0x40002FB")]
		[FieldOffset(Offset = "0x4")]
		private static readonly int BufferPairsPerCore;

		[Token(Token = "0x40002FC")]
		[FieldOffset(Offset = "0x28")]
		private List<WorkItem> _pool;

		[Token(Token = "0x40002FD")]
		[FieldOffset(Offset = "0x30")]
		private bool _leaveOpen;

		[Token(Token = "0x40002FE")]
		[FieldOffset(Offset = "0x31")]
		private bool emitting;

		[Token(Token = "0x40002FF")]
		[FieldOffset(Offset = "0x38")]
		private Stream _outStream;

		[Token(Token = "0x4000300")]
		[FieldOffset(Offset = "0x40")]
		private int _maxBufferPairs;

		[Token(Token = "0x4000301")]
		[FieldOffset(Offset = "0x44")]
		private int _bufferSize;

		[Token(Token = "0x4000302")]
		[FieldOffset(Offset = "0x48")]
		private AutoResetEvent _newlyCompressedBlob;

		[Token(Token = "0x4000303")]
		[FieldOffset(Offset = "0x50")]
		private object _outputLock;

		[Token(Token = "0x4000304")]
		[FieldOffset(Offset = "0x58")]
		private bool _isClosed;

		[Token(Token = "0x4000305")]
		[FieldOffset(Offset = "0x59")]
		private bool _firstWriteDone;

		[Token(Token = "0x4000306")]
		[FieldOffset(Offset = "0x5C")]
		private int _currentlyFilling;

		[Token(Token = "0x4000307")]
		[FieldOffset(Offset = "0x60")]
		private int _lastFilled;

		[Token(Token = "0x4000308")]
		[FieldOffset(Offset = "0x64")]
		private int _lastWritten;

		[Token(Token = "0x4000309")]
		[FieldOffset(Offset = "0x68")]
		private int _latestCompressed;

		[Token(Token = "0x400030A")]
		[FieldOffset(Offset = "0x6C")]
		private int _Crc32;

		[Token(Token = "0x400030B")]
		[FieldOffset(Offset = "0x70")]
		private CRC32 _runningCrc;

		[Token(Token = "0x400030C")]
		[FieldOffset(Offset = "0x78")]
		private object _latestLock;

		[Token(Token = "0x400030D")]
		[FieldOffset(Offset = "0x80")]
		private Queue<int> _toWrite;

		[Token(Token = "0x400030E")]
		[FieldOffset(Offset = "0x88")]
		private Queue<int> _toFill;

		[Token(Token = "0x400030F")]
		[FieldOffset(Offset = "0x90")]
		private long _totalBytesProcessed;

		[Token(Token = "0x4000310")]
		[FieldOffset(Offset = "0x98")]
		private CompressionLevel _compressLevel;

		[Token(Token = "0x4000311")]
		[FieldOffset(Offset = "0xA0")]
		private Exception _pendingException;

		[Token(Token = "0x4000312")]
		[FieldOffset(Offset = "0xA8")]
		private bool _handlingException;

		[Token(Token = "0x4000313")]
		[FieldOffset(Offset = "0xB0")]
		private object _eLock;

		[Token(Token = "0x4000314")]
		[FieldOffset(Offset = "0xB8")]
		private TraceBits _DesiredTrace;

		[Token(Token = "0x170000F8")]
		public CompressionStrategy Strategy
		{
			[Token(Token = "0x600040C")]
			[Address(RVA = "0x7871828", Offset = "0x786D828", VA = "0x7871828")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x600040D")]
			[Address(RVA = "0x7871830", Offset = "0x786D830", VA = "0x7871830")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000F9")]
		public int MaxBufferPairs
		{
			[Token(Token = "0x600040E")]
			[Address(RVA = "0x7871838", Offset = "0x786D838", VA = "0x7871838")]
			get
			{
				return default;
			}
			[Token(Token = "0x600040F")]
			[Address(RVA = "0x787175C", Offset = "0x786D75C", VA = "0x787175C")]
			set
			{
			}
		}

		[Token(Token = "0x170000FA")]
		public int BufferSize
		{
			[Token(Token = "0x6000410")]
			[Address(RVA = "0x7871840", Offset = "0x786D840", VA = "0x7871840")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000411")]
			[Address(RVA = "0x7871848", Offset = "0x786D848", VA = "0x7871848")]
			set
			{
			}
		}

		[Token(Token = "0x170000FB")]
		public int Crc32
		{
			[Token(Token = "0x6000412")]
			[Address(RVA = "0x78718C4", Offset = "0x786D8C4", VA = "0x78718C4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000FC")]
		public long BytesProcessed
		{
			[Token(Token = "0x6000413")]
			[Address(RVA = "0x78718CC", Offset = "0x786D8CC", VA = "0x78718CC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000FD")]
		public override bool CanSeek
		{
			[Token(Token = "0x6000421")]
			[Address(RVA = "0x7873054", Offset = "0x786F054", VA = "0x7873054", Slot = "8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000FE")]
		public override bool CanRead
		{
			[Token(Token = "0x6000422")]
			[Address(RVA = "0x787305C", Offset = "0x786F05C", VA = "0x787305C", Slot = "7")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000FF")]
		public override bool CanWrite
		{
			[Token(Token = "0x6000423")]
			[Address(RVA = "0x7873064", Offset = "0x786F064", VA = "0x7873064", Slot = "10")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000100")]
		public override long Length
		{
			[Token(Token = "0x6000424")]
			[Address(RVA = "0x7873084", Offset = "0x786F084", VA = "0x7873084", Slot = "11")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000101")]
		public override long Position
		{
			[Token(Token = "0x6000425")]
			[Address(RVA = "0x78730BC", Offset = "0x786F0BC", VA = "0x78730BC", Slot = "12")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000426")]
			[Address(RVA = "0x78730DC", Offset = "0x786F0DC", VA = "0x78730DC", Slot = "13")]
			set
			{
			}
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x78715E8", Offset = "0x786D5E8", VA = "0x78715E8")]
		public ParallelDeflateOutputStream(Stream stream)
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x7871730", Offset = "0x786D730", VA = "0x7871730")]
		public ParallelDeflateOutputStream(Stream stream, CompressionLevel level)
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x787173C", Offset = "0x786D73C", VA = "0x787173C")]
		public ParallelDeflateOutputStream(Stream stream, bool leaveOpen)
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x787174C", Offset = "0x786D74C", VA = "0x787174C")]
		public ParallelDeflateOutputStream(Stream stream, CompressionLevel level, bool leaveOpen)
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x78715F8", Offset = "0x786D5F8", VA = "0x78715F8")]
		public ParallelDeflateOutputStream(Stream stream, CompressionLevel level, CompressionStrategy strategy, bool leaveOpen)
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x78718D4", Offset = "0x786D8D4", VA = "0x78718D4")]
		private void _InitializePoolOfWorkItems()
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x7871BDC", Offset = "0x786DBDC", VA = "0x7871BDC", Slot = "37")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x78721B8", Offset = "0x786E1B8", VA = "0x78721B8")]
		private void _FlushFinish()
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x7872404", Offset = "0x786E404", VA = "0x7872404")]
		private void _Flush(bool lastInput)
		{
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x787281C", Offset = "0x786E81C", VA = "0x787281C", Slot = "22")]
		public override void Flush()
		{
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x787288C", Offset = "0x786E88C", VA = "0x787288C", Slot = "20")]
		public override void Close()
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x7872928", Offset = "0x786E928", VA = "0x7872928", Slot = "40")]
		public new void Dispose()
		{
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x7872960", Offset = "0x786E960", VA = "0x7872960", Slot = "21")]
		protected override void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x787296C", Offset = "0x786E96C", VA = "0x787296C")]
		public void Reset(Stream stream)
		{
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x7871E6C", Offset = "0x786DE6C", VA = "0x7871E6C")]
		private void EmitPendingBuffers(bool doAll, bool mustWait)
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x78724F8", Offset = "0x786E4F8", VA = "0x78724F8")]
		private void _DeflateOne(object wi)
		{
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x7872DF0", Offset = "0x786EDF0", VA = "0x7872DF0")]
		private bool DeflateOneSegment(WorkItem workitem)
		{
			return default;
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x7872ED4", Offset = "0x786EED4", VA = "0x7872ED4")]
		[Conditional("Trace")]
		private void TraceOutput(TraceBits bits, string format, params object[] varParams)
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x7873114", Offset = "0x786F114", VA = "0x7873114", Slot = "34")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default;
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x787314C", Offset = "0x786F14C", VA = "0x787314C", Slot = "32")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default;
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x7873184", Offset = "0x786F184", VA = "0x7873184", Slot = "33")]
		public override void SetLength(long value)
		{
		}
	}
}
