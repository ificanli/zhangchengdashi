using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;

namespace Pathfinding.Graphs.Navmesh.Voxelization.Burst
{
	[Token(Token = "0x20001EC")]
	[BurstCompile(CompileSynchronously = true)]
	internal struct JobBuildDistanceField : IJob
	{
		[Token(Token = "0x4000914")]
		[FieldOffset(Offset = "0x0")]
		public CompactVoxelField field;

		[Token(Token = "0x4000915")]
		[FieldOffset(Offset = "0x28")]
		public NativeList<ushort> output;

		[Token(Token = "0x6000D64")]
		[Address(RVA = "0x446C75C", Offset = "0x446875C", VA = "0x446C75C", Slot = "4")]
		public void Execute()
		{
		}
	}
}
