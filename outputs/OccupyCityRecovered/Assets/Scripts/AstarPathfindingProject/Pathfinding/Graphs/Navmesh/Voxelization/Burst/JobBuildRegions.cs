using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

namespace Pathfinding.Graphs.Navmesh.Voxelization.Burst
{
	[Token(Token = "0x20001EF")]
	[BurstCompile(CompileSynchronously = true)]
	public struct JobBuildRegions : IJob
	{
		[Token(Token = "0x20001F0")]
		public struct RelevantGraphSurfaceInfo
		{
			[Token(Token = "0x4000929")]
			[FieldOffset(Offset = "0x0")]
			public float3 position;

			[Token(Token = "0x400092A")]
			[FieldOffset(Offset = "0xC")]
			public float range;
		}

		[Token(Token = "0x400091D")]
		[FieldOffset(Offset = "0x0")]
		public CompactVoxelField field;

		[Token(Token = "0x400091E")]
		[FieldOffset(Offset = "0x28")]
		public NativeList<ushort> distanceField;

		[Token(Token = "0x400091F")]
		[FieldOffset(Offset = "0x30")]
		public int borderSize;

		[Token(Token = "0x4000920")]
		[FieldOffset(Offset = "0x34")]
		public int minRegionSize;

		[Token(Token = "0x4000921")]
		[FieldOffset(Offset = "0x38")]
		public NativeQueue<Int3> srcQue;

		[Token(Token = "0x4000922")]
		[FieldOffset(Offset = "0x40")]
		public NativeQueue<Int3> dstQue;

		[Token(Token = "0x4000923")]
		[FieldOffset(Offset = "0x48")]
		public RecastGraph.RelevantGraphSurfaceMode relevantGraphSurfaceMode;

		[Token(Token = "0x4000924")]
		[FieldOffset(Offset = "0x50")]
		public NativeArray<RelevantGraphSurfaceInfo> relevantGraphSurfaces;

		[Token(Token = "0x4000925")]
		[FieldOffset(Offset = "0x60")]
		public float cellSize;

		[Token(Token = "0x4000926")]
		[FieldOffset(Offset = "0x64")]
		public float cellHeight;

		[Token(Token = "0x4000927")]
		[FieldOffset(Offset = "0x68")]
		public Matrix4x4 graphTransform;

		[Token(Token = "0x4000928")]
		[FieldOffset(Offset = "0xA8")]
		public Bounds graphSpaceBounds;

		[Token(Token = "0x6000D67")]
		[Address(RVA = "0x446D2D8", Offset = "0x44692D8", VA = "0x446D2D8")]
		private void MarkRectWithRegion(int minx, int maxx, int minz, int maxz, ushort region, NativeArray<ushort> srcReg)
		{
		}

		[Token(Token = "0x6000D68")]
		[Address(RVA = "0x446D43C", Offset = "0x446943C", VA = "0x446D43C")]
		public static bool FloodRegion(int x, int z, int i, uint level, ushort r, CompactVoxelField field, NativeArray<ushort> distanceField, NativeArray<ushort> srcReg, NativeArray<ushort> srcDist, NativeArray<Int3> stack, NativeArray<int> flags, NativeArray<bool> closed)
		{
			return default;
		}

		[Token(Token = "0x6000D69")]
		[Address(RVA = "0x446DA30", Offset = "0x4469A30", VA = "0x446DA30", Slot = "4")]
		public void Execute()
		{
		}

		[Token(Token = "0x6000D6A")]
		[Address(RVA = "0x446EFB8", Offset = "0x446AFB8", VA = "0x446EFB8")]
		private static int union_find_find(NativeArray<int> arr, int x)
		{
			return default;
		}

		[Token(Token = "0x6000D6B")]
		[Address(RVA = "0x446EFF0", Offset = "0x446AFF0", VA = "0x446EFF0")]
		private static void union_find_union(NativeArray<int> arr, int a, int b)
		{
		}

		[Token(Token = "0x6000D6C")]
		[Address(RVA = "0x446E874", Offset = "0x446A874", VA = "0x446E874")]
		public static void FilterSmallRegions(CompactVoxelField field, NativeArray<ushort> reg, int minRegionSize, int maxRegions, NativeArray<RelevantGraphSurfaceInfo> relevantGraphSurfaces, RecastGraph.RelevantGraphSurfaceMode relevantGraphSurfaceMode, float4x4 voxel2worldMatrix)
		{
		}
	}
}
