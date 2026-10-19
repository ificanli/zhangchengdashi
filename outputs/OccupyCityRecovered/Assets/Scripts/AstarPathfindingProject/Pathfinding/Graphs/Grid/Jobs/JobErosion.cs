using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;

namespace Pathfinding.Graphs.Grid.Jobs
{
	[Token(Token = "0x2000229")]
	[BurstCompile]
	public struct JobErosion<AdjacencyMapper> : IJob where AdjacencyMapper : GridAdjacencyMapper, new()
	{
		[Token(Token = "0x4000A3A")]
		[FieldOffset(Offset = "0x0")]
		public IntBounds bounds;

		[Token(Token = "0x4000A3B")]
		[FieldOffset(Offset = "0x0")]
		public IntBounds writeMask;

		[Token(Token = "0x4000A3C")]
		[FieldOffset(Offset = "0x0")]
		public NumNeighbours neighbours;

		[Token(Token = "0x4000A3D")]
		[FieldOffset(Offset = "0x0")]
		public int erosion;

		[Token(Token = "0x4000A3E")]
		[FieldOffset(Offset = "0x0")]
		public bool erosionUsesTags;

		[Token(Token = "0x4000A3F")]
		[FieldOffset(Offset = "0x0")]
		public int erosionStartTag;

		[Token(Token = "0x4000A40")]
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public NativeArray<ulong> nodeConnections;

		[Token(Token = "0x4000A41")]
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public NativeArray<bool> nodeWalkable;

		[Token(Token = "0x4000A42")]
		[FieldOffset(Offset = "0x0")]
		[WriteOnly]
		public NativeArray<bool> outNodeWalkable;

		[Token(Token = "0x4000A43")]
		[FieldOffset(Offset = "0x0")]
		public NativeArray<int> nodeTags;

		[Token(Token = "0x4000A44")]
		[FieldOffset(Offset = "0x0")]
		public int erosionTagsPrecedenceMask;

		[Token(Token = "0x4000A45")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int[] hexagonNeighbourIndices;

		[Token(Token = "0x6000E0C")]
		public void Execute()
		{
		}
	}
}
