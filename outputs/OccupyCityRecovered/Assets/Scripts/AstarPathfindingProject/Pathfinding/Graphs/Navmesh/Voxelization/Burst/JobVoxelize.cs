using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

namespace Pathfinding.Graphs.Navmesh.Voxelization.Burst
{
	[Token(Token = "0x20001E8")]
	[BurstCompile(CompileSynchronously = true)]
	public struct JobVoxelize : IJob
	{
		[Token(Token = "0x4000902")]
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public NativeArray<RasterizationMesh> inputMeshes;

		[Token(Token = "0x4000903")]
		[FieldOffset(Offset = "0x10")]
		[ReadOnly]
		public NativeArray<int> bucket;

		[Token(Token = "0x4000904")]
		[FieldOffset(Offset = "0x20")]
		public int voxelWalkableClimb;

		[Token(Token = "0x4000905")]
		[FieldOffset(Offset = "0x24")]
		public uint voxelWalkableHeight;

		[Token(Token = "0x4000906")]
		[FieldOffset(Offset = "0x28")]
		public float cellSize;

		[Token(Token = "0x4000907")]
		[FieldOffset(Offset = "0x2C")]
		public float cellHeight;

		[Token(Token = "0x4000908")]
		[FieldOffset(Offset = "0x30")]
		public float maxSlope;

		[Token(Token = "0x4000909")]
		[FieldOffset(Offset = "0x34")]
		public Matrix4x4 graphTransform;

		[Token(Token = "0x400090A")]
		[FieldOffset(Offset = "0x74")]
		public Bounds graphSpaceBounds;

		[Token(Token = "0x400090B")]
		[FieldOffset(Offset = "0x8C")]
		public Vector2 graphSpaceLimits;

		[Token(Token = "0x400090C")]
		[FieldOffset(Offset = "0x98")]
		public LinkedVoxelField voxelArea;

		[Token(Token = "0x6000D60")]
		[Address(RVA = "0x446A874", Offset = "0x4466874", VA = "0x446A874", Slot = "4")]
		public void Execute()
		{
		}
	}
}
