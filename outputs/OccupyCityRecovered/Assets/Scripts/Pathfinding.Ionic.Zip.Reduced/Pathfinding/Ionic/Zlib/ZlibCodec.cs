using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zlib
{
	[Token(Token = "0x2000068")]
	[ClassInterface(ClassInterfaceType.AutoDispatch)]
	[ComVisible(true)]
	[Guid("ebc25cf6-9120-4283-b972-0e5520d0000D")]
	public sealed class ZlibCodec
	{
		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public byte[] InputBuffer;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int NextIn;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int AvailableBytesIn;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public long TotalBytesIn;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public byte[] OutputBuffer;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int NextOut;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int AvailableBytesOut;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public long TotalBytesOut;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string Message;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal DeflateManager dstate;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		internal InflateManager istate;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		internal uint _Adler32;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public CompressionLevel CompressLevel;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public int WindowBits;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public CompressionStrategy Strategy;

		[Token(Token = "0x1700010B")]
		public int Adler32
		{
			[Token(Token = "0x6000459")]
			[Address(RVA = "0x78765B0", Offset = "0x78725B0", VA = "0x78765B0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x78715C4", Offset = "0x786D5C4", VA = "0x78715C4")]
		public ZlibCodec()
		{
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x78764C4", Offset = "0x78724C4", VA = "0x78764C4")]
		public ZlibCodec(CompressionMode mode)
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x7876594", Offset = "0x7872594", VA = "0x7876594")]
		public int InitializeInflate()
		{
			return default;
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x7874600", Offset = "0x7870600", VA = "0x7874600")]
		public int InitializeInflate(bool expectRfc1950Header)
		{
			return default;
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x78765B8", Offset = "0x78725B8", VA = "0x78765B8")]
		public int InitializeInflate(int windowBits)
		{
			return default;
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x78765D4", Offset = "0x78725D4", VA = "0x78765D4")]
		public int InitializeInflate(int windowBits, bool expectRfc1950Header)
		{
			return default;
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x78748A4", Offset = "0x78708A4", VA = "0x78748A4")]
		public int Inflate(FlushType flush)
		{
			return default;
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x7874E6C", Offset = "0x7870E6C", VA = "0x7874E6C")]
		public int EndInflate()
		{
			return default;
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x78766B0", Offset = "0x78726B0", VA = "0x78766B0")]
		public int SyncInflate()
		{
			return default;
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x787658C", Offset = "0x787258C", VA = "0x787658C")]
		public int InitializeDeflate()
		{
			return default;
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x78767D4", Offset = "0x78727D4", VA = "0x78767D4")]
		public int InitializeDeflate(CompressionLevel level)
		{
			return default;
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x78715D8", Offset = "0x786D5D8", VA = "0x78715D8")]
		public int InitializeDeflate(CompressionLevel level, bool wantRfc1950Header)
		{
			return default;
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x78767E4", Offset = "0x78727E4", VA = "0x78767E4")]
		public int InitializeDeflate(CompressionLevel level, int bits)
		{
			return default;
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x78767F0", Offset = "0x78727F0", VA = "0x78767F0")]
		public int InitializeDeflate(CompressionLevel level, int bits, bool wantRfc1950Header)
		{
			return default;
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x7876708", Offset = "0x7872708", VA = "0x7876708")]
		private int _InternalInitializeDeflate(bool wantRfc1950Header)
		{
			return default;
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x787233C", Offset = "0x786E33C", VA = "0x787233C")]
		public int Deflate(FlushType flush)
		{
			return default;
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x7872398", Offset = "0x786E398", VA = "0x7872398")]
		public int EndDeflate()
		{
			return default;
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x7872E78", Offset = "0x786EE78", VA = "0x7872E78")]
		public void ResetDeflate()
		{
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x7876800", Offset = "0x7872800", VA = "0x7876800")]
		public int SetDeflateParams(CompressionLevel level, CompressionStrategy strategy)
		{
			return default;
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x787685C", Offset = "0x787285C", VA = "0x787685C")]
		public int SetDictionary(byte[] dictionary)
		{
			return default;
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x78768CC", Offset = "0x78728CC", VA = "0x78768CC")]
		internal void flush_pending()
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x7876A64", Offset = "0x7872A64", VA = "0x7876A64")]
		internal int read_buf(byte[] buf, int start, int size)
		{
			return default;
		}
	}
}
