using Il2CppDummyDll;
using Unity.Burst;
using Unity.Jobs;

namespace Pathfinding.Graphs.Navmesh.Voxelization.Burst
{
	[Token(Token = "0x20001EE")]
	[BurstCompile(CompileSynchronously = true)]
	internal struct JobFilterLedges : IJob
	{
		[Token(Token = "0x4000918")]
		[FieldOffset(Offset = "0x0")]
		public LinkedVoxelField field;

		[Token(Token = "0x4000919")]
		[FieldOffset(Offset = "0x28")]
		public uint voxelWalkableHeight;

		[Token(Token = "0x400091A")]
		[FieldOffset(Offset = "0x2C")]
		public int voxelWalkableClimb;

		[Token(Token = "0x400091B")]
		[FieldOffset(Offset = "0x30")]
		public float cellSize;

		[Token(Token = "0x400091C")]
		[FieldOffset(Offset = "0x34")]
		public float cellHeight;

		[Token(Token = "0x6000D66")]
		[Address(RVA = "0x446CDE0", Offset = "0x4468DE0", VA = "0x446CDE0", Slot = "4")]
		public void Execute()
		{
		}
	}
}
