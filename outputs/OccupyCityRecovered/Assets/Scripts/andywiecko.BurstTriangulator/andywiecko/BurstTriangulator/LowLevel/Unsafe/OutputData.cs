using Il2CppDummyDll;
using Unity.Collections;

namespace andywiecko.BurstTriangulator.LowLevel.Unsafe
{
	[Token(Token = "0x2000016")]
	public struct OutputData<T2> where T2 : unmanaged
	{
		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x0")]
		public NativeList<T2> Positions;

		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x0")]
		public NativeList<int> Triangles;

		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x0")]
		public NativeReference<Status> Status;

		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x0")]
		public NativeList<int> Halfedges;

		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x0")]
		public NativeList<HalfedgeState> ConstrainedHalfedges;
	}
}
