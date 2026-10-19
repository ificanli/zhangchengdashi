using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace BrainFailProductions.PolyFew.UnityMeshSimplifier
{
	[Token(Token = "0x2000017")]
	internal class BorderVertexComparer : IComparer<BorderVertex>
	{
		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0x0")]
		public static readonly BorderVertexComparer instance;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x8569108", Offset = "0x8565108", VA = "0x8569108", Slot = "4")]
		public int Compare(BorderVertex x, BorderVertex y)
		{
			return default;
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x856912C", Offset = "0x856512C", VA = "0x856912C")]
		public BorderVertexComparer()
		{
		}
	}
}
