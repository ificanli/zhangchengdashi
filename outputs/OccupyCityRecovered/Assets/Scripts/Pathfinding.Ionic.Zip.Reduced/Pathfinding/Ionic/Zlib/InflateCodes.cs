using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zlib
{
	[Token(Token = "0x2000055")]
	internal sealed class InflateCodes
	{
		[Token(Token = "0x40002BF")]
		private const int START = 0;

		[Token(Token = "0x40002C0")]
		private const int LEN = 1;

		[Token(Token = "0x40002C1")]
		private const int LENEXT = 2;

		[Token(Token = "0x40002C2")]
		private const int DIST = 3;

		[Token(Token = "0x40002C3")]
		private const int DISTEXT = 4;

		[Token(Token = "0x40002C4")]
		private const int COPY = 5;

		[Token(Token = "0x40002C5")]
		private const int LIT = 6;

		[Token(Token = "0x40002C6")]
		private const int WASH = 7;

		[Token(Token = "0x40002C7")]
		private const int END = 8;

		[Token(Token = "0x40002C8")]
		private const int BADCODE = 9;

		[Token(Token = "0x40002C9")]
		[FieldOffset(Offset = "0x10")]
		internal int mode;

		[Token(Token = "0x40002CA")]
		[FieldOffset(Offset = "0x14")]
		internal int len;

		[Token(Token = "0x40002CB")]
		[FieldOffset(Offset = "0x18")]
		internal int[] tree;

		[Token(Token = "0x40002CC")]
		[FieldOffset(Offset = "0x20")]
		internal int tree_index;

		[Token(Token = "0x40002CD")]
		[FieldOffset(Offset = "0x24")]
		internal int need;

		[Token(Token = "0x40002CE")]
		[FieldOffset(Offset = "0x28")]
		internal int lit;

		[Token(Token = "0x40002CF")]
		[FieldOffset(Offset = "0x2C")]
		internal int bitsToGet;

		[Token(Token = "0x40002D0")]
		[FieldOffset(Offset = "0x30")]
		internal int dist;

		[Token(Token = "0x40002D1")]
		[FieldOffset(Offset = "0x34")]
		internal byte lbits;

		[Token(Token = "0x40002D2")]
		[FieldOffset(Offset = "0x35")]
		internal byte dbits;

		[Token(Token = "0x40002D3")]
		[FieldOffset(Offset = "0x38")]
		internal int[] ltree;

		[Token(Token = "0x40002D4")]
		[FieldOffset(Offset = "0x40")]
		internal int ltree_index;

		[Token(Token = "0x40002D5")]
		[FieldOffset(Offset = "0x48")]
		internal int[] dtree;

		[Token(Token = "0x40002D6")]
		[FieldOffset(Offset = "0x50")]
		internal int dtree_index;

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x786F16C", Offset = "0x786B16C", VA = "0x786F16C")]
		internal InflateCodes()
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x786F174", Offset = "0x786B174", VA = "0x786F174")]
		internal void Init(int bl, int bd, int[] tl, int tl_index, int[] td, int td_index)
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x786F198", Offset = "0x786B198", VA = "0x786F198")]
		internal int Process(InflateBlocks blocks, int r)
		{
			return default;
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x786FBBC", Offset = "0x786BBBC", VA = "0x786FBBC")]
		internal int InflateFast(int bl, int bd, int[] tl, int tl_index, int[] td, int td_index, InflateBlocks s, ZlibCodec z)
		{
			return default;
		}
	}
}
