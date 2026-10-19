using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;

namespace Pathfinding.Graphs.Navmesh.Voxelization.Burst
{
	[Token(Token = "0x20001E4")]
	[BurstCompile(CompileSynchronously = true)]
	public struct JobBuildContours : IJob
	{
		[Token(Token = "0x40008EB")]
		[FieldOffset(Offset = "0x0")]
		public CompactVoxelField field;

		[Token(Token = "0x40008EC")]
		[FieldOffset(Offset = "0x28")]
		public float maxError;

		[Token(Token = "0x40008ED")]
		[FieldOffset(Offset = "0x2C")]
		public float maxEdgeLength;

		[Token(Token = "0x40008EE")]
		[FieldOffset(Offset = "0x30")]
		public int buildFlags;

		[Token(Token = "0x40008EF")]
		[FieldOffset(Offset = "0x34")]
		public float cellSize;

		[Token(Token = "0x40008F0")]
		[FieldOffset(Offset = "0x38")]
		public NativeList<VoxelContour> outputContours;

		[Token(Token = "0x40008F1")]
		[FieldOffset(Offset = "0x40")]
		public NativeList<int> outputVerts;

		[Token(Token = "0x6000D41")]
		[Address(RVA = "0x45A5020", Offset = "0x45A1020", VA = "0x45A5020", Slot = "4")]
		public void Execute()
		{
		}

		[Token(Token = "0x6000D42")]
		[Address(RVA = "0x45A71E4", Offset = "0x45A31E4", VA = "0x45A71E4")]
		private void GetClosestIndices(NativeArray<int> verts, int vertexStartIndexA, int nvertsa, int vertexStartIndexB, int nvertsb, out int ia, out int ib)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED JobBuildContours.GetClosestIndices RVA=0x45A71E4 Token=0x6000D42");
}

		[Token(Token = "0x6000D43")]
		[Address(RVA = "0x45A7370", Offset = "0x45A3370", VA = "0x45A7370")]
		public static bool MergeContours(NativeList<int> verts, ref VoxelContour ca, ref VoxelContour cb, int ia, int ib)
		{
			return default;
		}

		[Token(Token = "0x6000D44")]
		[Address(RVA = "0x45A5DAC", Offset = "0x45A1DAC", VA = "0x45A5DAC")]
		public void SimplifyContour(NativeList<int> verts, NativeList<int> simplified, float maxError, int buildFlags)
		{
		}

		[Token(Token = "0x6000D45")]
		[Address(RVA = "0x45A5924", Offset = "0x45A1924", VA = "0x45A5924")]
		public void WalkContour(int x, int z, int i, NativeArray<ushort> flags, NativeList<int> verts)
		{
		}

		[Token(Token = "0x6000D46")]
		[Address(RVA = "0x45A76A4", Offset = "0x45A36A4", VA = "0x45A76A4")]
		public int GetCornerHeight(int x, int z, int i, int dir, ref bool isBorderVertex)
		{
			return default;
		}

		[Token(Token = "0x6000D47")]
		[Address(RVA = "0x45A7CB4", Offset = "0x45A3CB4", VA = "0x45A7CB4")]
		private static void RemoveRange(NativeList<int> arr, int index, int count)
		{
		}

		[Token(Token = "0x6000D48")]
		[Address(RVA = "0x45A6FD4", Offset = "0x45A2FD4", VA = "0x45A6FD4")]
		private static void RemoveDegenerateSegments(NativeList<int> simplified)
		{
		}

		[Token(Token = "0x6000D49")]
		[Address(RVA = "0x45A7168", Offset = "0x45A3168", VA = "0x45A7168")]
		private int CalcAreaOfPolygon2D(NativeArray<int> verts, int vertexStartIndex, int nverts)
		{
			return default;
		}

		[Token(Token = "0x6000D4A")]
		[Address(RVA = "0x45A765C", Offset = "0x45A365C", VA = "0x45A765C")]
		private static bool Ileft(NativeArray<int> verts, int a, int b, int c)
		{
			return default;
		}
	}
}
