using Il2CppDummyDll;
using Unity.Burst;
using Unity.Jobs;

namespace Pathfinding.Graphs.Navmesh.Voxelization.Burst
{
	[Token(Token = "0x20001EB")]
	[BurstCompile(CompileSynchronously = true)]
	internal struct JobErodeWalkableArea : IJob
	{
		[Token(Token = "0x4000912")]
		[FieldOffset(Offset = "0x0")]
		public CompactVoxelField field;

		[Token(Token = "0x4000913")]
		[FieldOffset(Offset = "0x28")]
		public int radius;

		[Token(Token = "0x6000D63")]
		[Address(RVA = "0x446BE14", Offset = "0x4467E14", VA = "0x446BE14", Slot = "4")]
		public void Execute()
		{
		}
	}
}
