using Il2CppDummyDll;
using Unity.Collections;

namespace andywiecko.BurstTriangulator.LowLevel.Unsafe
{
	[Token(Token = "0x2000015")]
	public struct InputData<T2> where T2 : unmanaged
	{
		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0x0")]
		public NativeArray<T2> Positions;

		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x0")]
		public NativeArray<int> ConstraintEdges;

		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x0")]
		public NativeArray<ConstraintType> ConstraintEdgeTypes;

		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x0")]
		public NativeArray<T2> HoleSeeds;
	}
}
