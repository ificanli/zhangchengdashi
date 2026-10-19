using Il2CppDummyDll;
using Unity.Burst;
using Unity.Jobs;

namespace Pathfinding.Graphs.Navmesh.Voxelization.Burst
{
	[Token(Token = "0x20001EA")]
	[BurstCompile(CompileSynchronously = true)]
	internal struct JobBuildConnections : IJob
	{
		[Token(Token = "0x400090F")]
		[FieldOffset(Offset = "0x0")]
		public CompactVoxelField field;

		[Token(Token = "0x4000910")]
		[FieldOffset(Offset = "0x28")]
		public int voxelWalkableHeight;

		[Token(Token = "0x4000911")]
		[FieldOffset(Offset = "0x2C")]
		public int voxelWalkableClimb;

		[Token(Token = "0x6000D62")]
		[Address(RVA = "0x446BA90", Offset = "0x4467A90", VA = "0x446BA90", Slot = "4")]
		public void Execute()
		{
		}
	}
}
