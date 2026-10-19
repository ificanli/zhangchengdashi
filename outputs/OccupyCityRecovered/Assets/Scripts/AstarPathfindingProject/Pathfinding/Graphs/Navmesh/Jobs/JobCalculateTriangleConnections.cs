using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;

namespace Pathfinding.Graphs.Navmesh.Jobs
{
	[Token(Token = "0x20001F8")]
	[BurstCompile]
	public struct JobCalculateTriangleConnections : IJob
	{
		[Token(Token = "0x20001F9")]
		public struct TileNodeConnectionsUnsafe
		{
			[Token(Token = "0x4000975")]
			[FieldOffset(Offset = "0x0")]
			public UnsafeAppendBuffer neighbours;

			[Token(Token = "0x4000976")]
			[FieldOffset(Offset = "0x18")]
			public UnsafeAppendBuffer neighbourCounts;
		}

		[Token(Token = "0x4000973")]
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public NativeArray<TileMesh.TileMeshUnsafe> tileMeshes;

		[Token(Token = "0x4000974")]
		[FieldOffset(Offset = "0x10")]
		[WriteOnly]
		public NativeArray<TileNodeConnectionsUnsafe> nodeConnections;

		[Token(Token = "0x6000D7E")]
		[Address(RVA = "0x44710A4", Offset = "0x446D0A4", VA = "0x44710A4", Slot = "4")]
		public void Execute()
		{
		}
	}
}
