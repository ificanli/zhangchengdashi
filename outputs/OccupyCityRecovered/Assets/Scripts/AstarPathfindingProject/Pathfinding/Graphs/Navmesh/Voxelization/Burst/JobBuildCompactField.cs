using Il2CppDummyDll;
using Unity.Burst;
using Unity.Jobs;

namespace Pathfinding.Graphs.Navmesh.Voxelization.Burst
{
	[Token(Token = "0x20001E9")]
	[BurstCompile(CompileSynchronously = true)]
	internal struct JobBuildCompactField : IJob
	{
		[Token(Token = "0x400090D")]
		[FieldOffset(Offset = "0x0")]
		public LinkedVoxelField input;

		[Token(Token = "0x400090E")]
		[FieldOffset(Offset = "0x28")]
		public CompactVoxelField output;

		[Token(Token = "0x6000D61")]
		[Address(RVA = "0x446BA5C", Offset = "0x4467A5C", VA = "0x446BA5C", Slot = "4")]
		public void Execute()
		{
		}
	}
}
