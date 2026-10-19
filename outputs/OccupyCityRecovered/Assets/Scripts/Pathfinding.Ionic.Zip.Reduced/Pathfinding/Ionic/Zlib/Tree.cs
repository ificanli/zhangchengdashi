using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zlib
{
	[Token(Token = "0x200005B")]
	internal sealed class Tree
	{
		[Token(Token = "0x4000329")]
		internal const int Buf_size = 16;

		[Token(Token = "0x400032A")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int HEAP_SIZE;

		[Token(Token = "0x400032B")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly int[] ExtraLengthBits;

		[Token(Token = "0x400032C")]
		[FieldOffset(Offset = "0x10")]
		internal static readonly int[] ExtraDistanceBits;

		[Token(Token = "0x400032D")]
		[FieldOffset(Offset = "0x18")]
		internal static readonly int[] extra_blbits;

		[Token(Token = "0x400032E")]
		[FieldOffset(Offset = "0x20")]
		internal static readonly sbyte[] bl_order;

		[Token(Token = "0x400032F")]
		[FieldOffset(Offset = "0x28")]
		private static readonly sbyte[] _dist_code;

		[Token(Token = "0x4000330")]
		[FieldOffset(Offset = "0x30")]
		internal static readonly sbyte[] LengthCode;

		[Token(Token = "0x4000331")]
		[FieldOffset(Offset = "0x38")]
		internal static readonly int[] LengthBase;

		[Token(Token = "0x4000332")]
		[FieldOffset(Offset = "0x40")]
		internal static readonly int[] DistanceBase;

		[Token(Token = "0x4000333")]
		[FieldOffset(Offset = "0x10")]
		internal short[] dyn_tree;

		[Token(Token = "0x4000334")]
		[FieldOffset(Offset = "0x18")]
		internal int max_code;

		[Token(Token = "0x4000335")]
		[FieldOffset(Offset = "0x20")]
		internal StaticTree staticTree;

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x78731BC", Offset = "0x786F1BC", VA = "0x78731BC")]
		public Tree()
		{
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x787346C", Offset = "0x786F46C", VA = "0x787346C")]
		internal static int DistanceCode(int dist)
		{
			return default;
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x7873510", Offset = "0x786F510", VA = "0x7873510")]
		internal void gen_bitlen(DeflateManager s)
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x7873898", Offset = "0x786F898", VA = "0x7873898")]
		internal void build_tree(DeflateManager s)
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x7873D28", Offset = "0x786FD28", VA = "0x7873D28")]
		internal static void gen_codes(short[] tree, int max_code, short[] bl_count)
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x7873F00", Offset = "0x786FF00", VA = "0x7873F00")]
		internal static int bi_reverse(int code, int len)
		{
			return default;
		}
	}
}
