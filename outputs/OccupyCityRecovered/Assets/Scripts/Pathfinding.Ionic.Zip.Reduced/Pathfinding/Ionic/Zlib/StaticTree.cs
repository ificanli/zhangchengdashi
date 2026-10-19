using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zlib
{
	[Token(Token = "0x2000063")]
	internal sealed class StaticTree
	{
		[Token(Token = "0x400035C")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly short[] lengthAndLiteralsTreeCodes;

		[Token(Token = "0x400035D")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly short[] distTreeCodes;

		[Token(Token = "0x400035E")]
		[FieldOffset(Offset = "0x10")]
		internal static readonly StaticTree Literals;

		[Token(Token = "0x400035F")]
		[FieldOffset(Offset = "0x18")]
		internal static readonly StaticTree Distances;

		[Token(Token = "0x4000360")]
		[FieldOffset(Offset = "0x20")]
		internal static readonly StaticTree BitLengths;

		[Token(Token = "0x4000361")]
		[FieldOffset(Offset = "0x10")]
		internal short[] treeCodes;

		[Token(Token = "0x4000362")]
		[FieldOffset(Offset = "0x18")]
		internal int[] extraBits;

		[Token(Token = "0x4000363")]
		[FieldOffset(Offset = "0x20")]
		internal int extraBase;

		[Token(Token = "0x4000364")]
		[FieldOffset(Offset = "0x24")]
		internal int elems;

		[Token(Token = "0x4000365")]
		[FieldOffset(Offset = "0x28")]
		internal int maxLength;

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x7874148", Offset = "0x7870148", VA = "0x7874148")]
		private StaticTree(short[] treeCodes, int[] extraBits, int extraBase, int elems, int maxLength)
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x7874198", Offset = "0x7870198", VA = "0x7874198")]
		static StaticTree()
		{
		}
	}
}
