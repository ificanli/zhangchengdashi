using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace BrainFailProductions.PolyFew.UnityMeshSimplifier
{
	[Token(Token = "0x2000016")]
	internal struct BorderVertex
	{
		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0x0")]
		public int index;

		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0x4")]
		public int hash;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x8569100", Offset = "0x8565100", VA = "0x8569100")]
		public BorderVertex(int index, int hash)
		{
			// Recovered from ARM64 RVA 0x8569100.
			this.index = index;
			this.hash = hash;
		}
	}
}
