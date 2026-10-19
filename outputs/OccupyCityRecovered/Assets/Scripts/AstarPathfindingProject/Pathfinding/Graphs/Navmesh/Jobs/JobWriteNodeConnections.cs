using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Unity.Collections;
using Unity.Jobs;

namespace Pathfinding.Graphs.Navmesh.Jobs
{
	[Token(Token = "0x20001FF")]
	public struct JobWriteNodeConnections : IJob
	{
		[Token(Token = "0x4000992")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public NativeArray<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe> nodeConnections;

		[Token(Token = "0x4000993")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GCHandle tiles;

		[Token(Token = "0x6000D87")]
		[Address(RVA = "0x4472108", Offset = "0x446E108", VA = "0x4472108", Slot = "4")]
		public void Execute()
		{
		}

		[Token(Token = "0x6000D88")]
		[Address(RVA = "0x4472238", Offset = "0x446E238", VA = "0x4472238")]
		private void Apply(TriangleMeshNode[] nodes, JobCalculateTriangleConnections.TileNodeConnectionsUnsafe connections)
		{
		}
	}
}
