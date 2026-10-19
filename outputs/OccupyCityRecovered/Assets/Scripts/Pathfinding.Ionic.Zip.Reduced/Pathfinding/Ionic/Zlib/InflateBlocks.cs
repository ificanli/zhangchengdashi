using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zlib
{
	[Token(Token = "0x2000052")]
	internal sealed class InflateBlocks
	{
		[Token(Token = "0x2000053")]
		private enum InflateBlockMode
		{
			[Token(Token = "0x40002B4")]
			TYPE = 0,
			[Token(Token = "0x40002B5")]
			LENS = 1,
			[Token(Token = "0x40002B6")]
			STORED = 2,
			[Token(Token = "0x40002B7")]
			TABLE = 3,
			[Token(Token = "0x40002B8")]
			BTREE = 4,
			[Token(Token = "0x40002B9")]
			DTREE = 5,
			[Token(Token = "0x40002BA")]
			CODES = 6,
			[Token(Token = "0x40002BB")]
			DRY = 7,
			[Token(Token = "0x40002BC")]
			DONE = 8,
			[Token(Token = "0x40002BD")]
			BAD = 9
		}

		[Token(Token = "0x400029D")]
		private const int MANY = 1440;

		[Token(Token = "0x400029E")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly int[] border;

		[Token(Token = "0x400029F")]
		[FieldOffset(Offset = "0x10")]
		private InflateBlockMode mode;

		[Token(Token = "0x40002A0")]
		[FieldOffset(Offset = "0x14")]
		internal int left;

		[Token(Token = "0x40002A1")]
		[FieldOffset(Offset = "0x18")]
		internal int table;

		[Token(Token = "0x40002A2")]
		[FieldOffset(Offset = "0x1C")]
		internal int index;

		[Token(Token = "0x40002A3")]
		[FieldOffset(Offset = "0x20")]
		internal int[] blens;

		[Token(Token = "0x40002A4")]
		[FieldOffset(Offset = "0x28")]
		internal int[] bb;

		[Token(Token = "0x40002A5")]
		[FieldOffset(Offset = "0x30")]
		internal int[] tb;

		[Token(Token = "0x40002A6")]
		[FieldOffset(Offset = "0x38")]
		internal InflateCodes codes;

		[Token(Token = "0x40002A7")]
		[FieldOffset(Offset = "0x40")]
		internal int last;

		[Token(Token = "0x40002A8")]
		[FieldOffset(Offset = "0x48")]
		internal ZlibCodec _codec;

		[Token(Token = "0x40002A9")]
		[FieldOffset(Offset = "0x50")]
		internal int bitk;

		[Token(Token = "0x40002AA")]
		[FieldOffset(Offset = "0x54")]
		internal int bitb;

		[Token(Token = "0x40002AB")]
		[FieldOffset(Offset = "0x58")]
		internal int[] hufts;

		[Token(Token = "0x40002AC")]
		[FieldOffset(Offset = "0x60")]
		internal byte[] window;

		[Token(Token = "0x40002AD")]
		[FieldOffset(Offset = "0x68")]
		internal int end;

		[Token(Token = "0x40002AE")]
		[FieldOffset(Offset = "0x6C")]
		internal int readAt;

		[Token(Token = "0x40002AF")]
		[FieldOffset(Offset = "0x70")]
		internal int writeAt;

		[Token(Token = "0x40002B0")]
		[FieldOffset(Offset = "0x78")]
		internal object checkfn;

		[Token(Token = "0x40002B1")]
		[FieldOffset(Offset = "0x80")]
		internal uint check;

		[Token(Token = "0x40002B2")]
		[FieldOffset(Offset = "0x88")]
		internal InfTree inftree;

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x786DCD4", Offset = "0x7869CD4", VA = "0x786DCD4")]
		internal InflateBlocks(ZlibCodec codec, object checkfn, int w)
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x786DE04", Offset = "0x7869E04", VA = "0x786DE04")]
		internal uint Reset()
		{
			return default;
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x786DF34", Offset = "0x7869F34", VA = "0x786DF34")]
		internal int Process(int r)
		{
			return default;
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x786F070", Offset = "0x786B070", VA = "0x786F070")]
		internal void Free()
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x786F088", Offset = "0x786B088", VA = "0x786F088")]
		internal void SetDictionary(byte[] d, int start, int n)
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x786F0C8", Offset = "0x786B0C8", VA = "0x786F0C8")]
		internal int SyncPoint()
		{
			return default;
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x786EED8", Offset = "0x786AED8", VA = "0x786EED8")]
		internal int Flush(int r)
		{
			return default;
		}
	}
}
