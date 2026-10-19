using Il2CppDummyDll;
using Unity.Burst;
using Unity.Jobs;

namespace Pathfinding.Graphs.Navmesh.Voxelization.Burst
{
	[Token(Token = "0x20001ED")]
	[BurstCompile(CompileSynchronously = true)]
	internal struct JobFilterLowHeightSpans : IJob
	{
		[Token(Token = "0x4000916")]
		[FieldOffset(Offset = "0x0")]
		public LinkedVoxelField field;

		[Token(Token = "0x4000917")]
		[FieldOffset(Offset = "0x28")]
		public uint voxelWalkableHeight;

		[Token(Token = "0x6000D65")]
		[Address(RVA = "0x446CBD8", Offset = "0x4468BD8", VA = "0x446CBD8", Slot = "4")]
		public void Execute()
		{
		}
	}
}
