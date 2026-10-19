using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using Il2CppDummyDll;

namespace Pathfinding.Ionic.BZip2
{
	[Token(Token = "0x2000047")]
	public class ParallelBZip2OutputStream : Stream
	{
		[Token(Token = "0x2000048")]
		[Flags]
		private enum TraceBits : uint
		{
			[Token(Token = "0x4000219")]
			None = 0u,
			[Token(Token = "0x400021A")]
			Crc = 1u,
			[Token(Token = "0x400021B")]
			Write = 2u,
			[Token(Token = "0x400021C")]
			All = uint.MaxValue
		}

		[Token(Token = "0x40001FF")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int BufferPairsPerCore;

		[Token(Token = "0x4000200")]
		[FieldOffset(Offset = "0x28")]
		private int _maxWorkers;

		[Token(Token = "0x4000201")]
		[FieldOffset(Offset = "0x2C")]
		private bool firstWriteDone;

		[Token(Token = "0x4000202")]
		[FieldOffset(Offset = "0x30")]
		private int lastFilled;

		[Token(Token = "0x4000203")]
		[FieldOffset(Offset = "0x34")]
		private int lastWritten;

		[Token(Token = "0x4000204")]
		[FieldOffset(Offset = "0x38")]
		private int latestCompressed;

		[Token(Token = "0x4000205")]
		[FieldOffset(Offset = "0x3C")]
		private int currentlyFilling;

		[Token(Token = "0x4000206")]
		[FieldOffset(Offset = "0x40")]
		private Exception pendingException;

		[Token(Token = "0x4000207")]
		[FieldOffset(Offset = "0x48")]
		private bool handlingException;

		[Token(Token = "0x4000208")]
		[FieldOffset(Offset = "0x49")]
		private bool emitting;

		[Token(Token = "0x4000209")]
		[FieldOffset(Offset = "0x50")]
		private Queue<int> toWrite;

		[Token(Token = "0x400020A")]
		[FieldOffset(Offset = "0x58")]
		private Queue<int> toFill;

		[Token(Token = "0x400020B")]
		[FieldOffset(Offset = "0x60")]
		private List<WorkItem> pool;

		[Token(Token = "0x400020C")]
		[FieldOffset(Offset = "0x68")]
		private object latestLock;

		[Token(Token = "0x400020D")]
		[FieldOffset(Offset = "0x70")]
		private object eLock;

		[Token(Token = "0x400020E")]
		[FieldOffset(Offset = "0x78")]
		private object outputLock;

		[Token(Token = "0x400020F")]
		[FieldOffset(Offset = "0x80")]
		private AutoResetEvent newlyCompressedBlob;

		[Token(Token = "0x4000210")]
		[FieldOffset(Offset = "0x88")]
		private long totalBytesWrittenIn;

		[Token(Token = "0x4000211")]
		[FieldOffset(Offset = "0x90")]
		private long totalBytesWrittenOut;

		[Token(Token = "0x4000212")]
		[FieldOffset(Offset = "0x98")]
		private bool leaveOpen;

		[Token(Token = "0x4000213")]
		[FieldOffset(Offset = "0x9C")]
		private uint combinedCRC;

		[Token(Token = "0x4000214")]
		[FieldOffset(Offset = "0xA0")]
		private Stream output;

		[Token(Token = "0x4000215")]
		[FieldOffset(Offset = "0xA8")]
		private BitWriter bw;

		[Token(Token = "0x4000216")]
		[FieldOffset(Offset = "0xB0")]
		private int blockSize100k;

		[Token(Token = "0x4000217")]
		[FieldOffset(Offset = "0xB4")]
		private TraceBits desiredTrace;

		[Token(Token = "0x170000D8")]
		public int MaxWorkers
		{
			[Token(Token = "0x6000360")]
			[Address(RVA = "0x7864BB8", Offset = "0x7860BB8", VA = "0x7864BB8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000361")]
			[Address(RVA = "0x78647C4", Offset = "0x78607C4", VA = "0x78647C4")]
			set
			{
			}
		}

		[Token(Token = "0x170000D9")]
		public int BlockSize
		{
			[Token(Token = "0x6000367")]
			[Address(RVA = "0x78655C8", Offset = "0x78615C8", VA = "0x78655C8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000DA")]
		public override bool CanRead
		{
			[Token(Token = "0x600036B")]
			[Address(RVA = "0x786598C", Offset = "0x786198C", VA = "0x786598C", Slot = "7")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000DB")]
		public override bool CanSeek
		{
			[Token(Token = "0x600036C")]
			[Address(RVA = "0x7865994", Offset = "0x7861994", VA = "0x7865994", Slot = "8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000DC")]
		public override bool CanWrite
		{
			[Token(Token = "0x600036D")]
			[Address(RVA = "0x786599C", Offset = "0x786199C", VA = "0x786599C", Slot = "10")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000DD")]
		public override long Length
		{
			[Token(Token = "0x600036E")]
			[Address(RVA = "0x7865A00", Offset = "0x7861A00", VA = "0x7865A00", Slot = "11")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000DE")]
		public override long Position
		{
			[Token(Token = "0x600036F")]
			[Address(RVA = "0x7865A38", Offset = "0x7861A38", VA = "0x7865A38", Slot = "12")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000370")]
			[Address(RVA = "0x7865A40", Offset = "0x7861A40", VA = "0x7865A40", Slot = "13")]
			set
			{
			}
		}

		[Token(Token = "0x170000DF")]
		public long BytesWrittenOut
		{
			[Token(Token = "0x6000371")]
			[Address(RVA = "0x7865A78", Offset = "0x7861A78", VA = "0x7865A78")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x78643BC", Offset = "0x78603BC", VA = "0x78643BC")]
		public ParallelBZip2OutputStream(Stream output)
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x7864744", Offset = "0x7860744", VA = "0x7864744")]
		public ParallelBZip2OutputStream(Stream output, int blockSize)
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x786474C", Offset = "0x786074C", VA = "0x786474C")]
		public ParallelBZip2OutputStream(Stream output, bool leaveOpen)
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x7864430", Offset = "0x7860430", VA = "0x7864430")]
		public ParallelBZip2OutputStream(Stream output, int blockSize, bool leaveOpen)
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x7864944", Offset = "0x7860944", VA = "0x7864944")]
		private void InitializePoolOfWorkItems()
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x7864BC0", Offset = "0x7860BC0", VA = "0x7864BC0", Slot = "20")]
		public override void Close()
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x7864CBC", Offset = "0x7860CBC", VA = "0x7864CBC")]
		private void FlushOutput(bool lastInput)
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x7865574", Offset = "0x7861574", VA = "0x7865574", Slot = "22")]
		public override void Flush()
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x7864840", Offset = "0x7860840", VA = "0x7864840")]
		private void EmitHeader()
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x78654D0", Offset = "0x78614D0", VA = "0x78654D0")]
		private void EmitTrailer()
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x78655D0", Offset = "0x78615D0", VA = "0x78655D0", Slot = "37")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x7865034", Offset = "0x7861034", VA = "0x7865034")]
		private void EmitPendingBuffers(bool doAll, bool mustWait)
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x7864D74", Offset = "0x7860D74", VA = "0x7864D74")]
		private void CompressOne(object wi)
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x7865A80", Offset = "0x7861A80", VA = "0x7865A80", Slot = "32")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default;
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x7865AB8", Offset = "0x7861AB8", VA = "0x7865AB8", Slot = "33")]
		public override void SetLength(long value)
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x7865AF0", Offset = "0x7861AF0", VA = "0x7865AF0", Slot = "34")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default;
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x7865B28", Offset = "0x7861B28", VA = "0x7865B28")]
		[Conditional("Trace")]
		private void TraceOutput(TraceBits bits, string format, params object[] varParams)
		{
		}
	}
}
