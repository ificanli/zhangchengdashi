using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zlib
{
	[Token(Token = "0x2000051")]
	internal sealed class InfTree
	{
		[Token(Token = "0x4000284")]
		private const int MANY = 1440;

		[Token(Token = "0x4000285")]
		private const int Z_OK = 0;

		[Token(Token = "0x4000286")]
		private const int Z_STREAM_END = 1;

		[Token(Token = "0x4000287")]
		private const int Z_NEED_DICT = 2;

		[Token(Token = "0x4000288")]
		private const int Z_ERRNO = -1;

		[Token(Token = "0x4000289")]
		private const int Z_STREAM_ERROR = -2;

		[Token(Token = "0x400028A")]
		private const int Z_DATA_ERROR = -3;

		[Token(Token = "0x400028B")]
		private const int Z_MEM_ERROR = -4;

		[Token(Token = "0x400028C")]
		private const int Z_BUF_ERROR = -5;

		[Token(Token = "0x400028D")]
		private const int Z_VERSION_ERROR = -6;

		[Token(Token = "0x400028E")]
		internal const int fixed_bl = 9;

		[Token(Token = "0x400028F")]
		internal const int fixed_bd = 5;

		[Token(Token = "0x4000290")]
		internal const int BMAX = 15;

		[Token(Token = "0x4000291")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly int[] fixed_tl;

		[Token(Token = "0x4000292")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly int[] fixed_td;

		[Token(Token = "0x4000293")]
		[FieldOffset(Offset = "0x10")]
		internal static readonly int[] cplens;

		[Token(Token = "0x4000294")]
		[FieldOffset(Offset = "0x18")]
		internal static readonly int[] cplext;

		[Token(Token = "0x4000295")]
		[FieldOffset(Offset = "0x20")]
		internal static readonly int[] cpdist;

		[Token(Token = "0x4000296")]
		[FieldOffset(Offset = "0x28")]
		internal static readonly int[] cpdext;

		[Token(Token = "0x4000297")]
		[FieldOffset(Offset = "0x10")]
		internal int[] hn;

		[Token(Token = "0x4000298")]
		[FieldOffset(Offset = "0x18")]
		internal int[] v;

		[Token(Token = "0x4000299")]
		[FieldOffset(Offset = "0x20")]
		internal int[] c;

		[Token(Token = "0x400029A")]
		[FieldOffset(Offset = "0x28")]
		internal int[] r;

		[Token(Token = "0x400029B")]
		[FieldOffset(Offset = "0x30")]
		internal int[] u;

		[Token(Token = "0x400029C")]
		[FieldOffset(Offset = "0x38")]
		internal int[] x;

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x786CDE4", Offset = "0x7868DE4", VA = "0x786CDE4")]
		public InfTree()
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x786CFBC", Offset = "0x7868FBC", VA = "0x786CFBC")]
		private int huft_build(int[] b, int bindex, int n, int s, int[] d, int[] e, int[] t, int[] m, int[] hp, int[] hn, int[] v)
		{
			return default;
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x786D744", Offset = "0x7869744", VA = "0x786D744")]
		internal int inflate_trees_bits(int[] c, int[] bb, int[] tb, int[] hp, ZlibCodec z)
		{
			return default;
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x786D9B8", Offset = "0x78699B8", VA = "0x786D9B8")]
		internal int inflate_trees_dynamic(int nl, int nd, int[] c, int[] bl, int[] bd, int[] tl, int[] td, int[] hp, ZlibCodec z)
		{
			return default;
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x786DC04", Offset = "0x7869C04", VA = "0x786DC04")]
		internal static int inflate_trees_fixed(int[] bl, int[] bd, int[][] tl, int[][] td, ZlibCodec z)
		{
			return default;
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x786D858", Offset = "0x7869858", VA = "0x786D858")]
		private void initWorkArea(int vsize)
		{
		}
	}
}
