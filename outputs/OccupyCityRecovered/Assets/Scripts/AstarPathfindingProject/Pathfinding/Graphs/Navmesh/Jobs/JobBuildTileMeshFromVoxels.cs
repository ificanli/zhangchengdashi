using Il2CppDummyDll;
using Pathfinding.Graphs.Navmesh.Voxelization.Burst;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Profiling;
using UnityEngine;

namespace Pathfinding.Graphs.Navmesh.Jobs
{
	[Token(Token = "0x20001F7")]
	[BurstCompile(CompileSynchronously = true)]
	public struct JobBuildTileMeshFromVoxels : IJob
	{
		[Token(Token = "0x400094F")]
		[FieldOffset(Offset = "0x0")]
		public TileBuilderBurst tileBuilder;

		[Token(Token = "0x4000950")]
		[FieldOffset(Offset = "0x90")]
		[ReadOnly]
		public TileBuilder.BucketMapping inputMeshes;

		[Token(Token = "0x4000951")]
		[FieldOffset(Offset = "0xC0")]
		[ReadOnly]
		public NativeArray<Bounds> tileGraphSpaceBounds;

		[Token(Token = "0x4000952")]
		[FieldOffset(Offset = "0xD0")]
		public Matrix4x4 voxelToTileSpace;

		[Token(Token = "0x4000953")]
		[FieldOffset(Offset = "0x110")]
		public Vector2 graphSpaceLimits;

		[Token(Token = "0x4000954")]
		[FieldOffset(Offset = "0x118")]
		[NativeDisableUnsafePtrRestriction]
		public unsafe TileMesh.TileMeshUnsafe* outputMeshes;

		[Token(Token = "0x4000955")]
		[FieldOffset(Offset = "0x120")]
		public int maxTiles;

		[Token(Token = "0x4000956")]
		[FieldOffset(Offset = "0x124")]
		public int voxelWalkableClimb;

		[Token(Token = "0x4000957")]
		[FieldOffset(Offset = "0x128")]
		public uint voxelWalkableHeight;

		[Token(Token = "0x4000958")]
		[FieldOffset(Offset = "0x12C")]
		public float cellSize;

		[Token(Token = "0x4000959")]
		[FieldOffset(Offset = "0x130")]
		public float cellHeight;

		[Token(Token = "0x400095A")]
		[FieldOffset(Offset = "0x134")]
		public float maxSlope;

		[Token(Token = "0x400095B")]
		[FieldOffset(Offset = "0x138")]
		public RecastGraph.DimensionMode dimensionMode;

		[Token(Token = "0x400095C")]
		[FieldOffset(Offset = "0x13C")]
		public RecastGraph.BackgroundTraversability backgroundTraversability;

		[Token(Token = "0x400095D")]
		[FieldOffset(Offset = "0x140")]
		public Matrix4x4 graphToWorldSpace;

		[Token(Token = "0x400095E")]
		[FieldOffset(Offset = "0x180")]
		public int characterRadiusInVoxels;

		[Token(Token = "0x400095F")]
		[FieldOffset(Offset = "0x184")]
		public int tileBorderSizeInVoxels;

		[Token(Token = "0x4000960")]
		[FieldOffset(Offset = "0x188")]
		public int minRegionSize;

		[Token(Token = "0x4000961")]
		[FieldOffset(Offset = "0x18C")]
		public float maxEdgeLength;

		[Token(Token = "0x4000962")]
		[FieldOffset(Offset = "0x190")]
		public float contourMaxError;

		[Token(Token = "0x4000963")]
		[FieldOffset(Offset = "0x198")]
		[ReadOnly]
		public NativeArray<JobBuildRegions.RelevantGraphSurfaceInfo> relevantGraphSurfaces;

		[Token(Token = "0x4000964")]
		[FieldOffset(Offset = "0x1A8")]
		public RecastGraph.RelevantGraphSurfaceMode relevantGraphSurfaceMode;

		[Token(Token = "0x4000965")]
		[FieldOffset(Offset = "0x1B0")]
		[NativeDisableUnsafePtrRestriction]
		public unsafe int* currentTileCounter;

		[Token(Token = "0x4000966")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ProfilerMarker MarkerVoxelize;

		[Token(Token = "0x4000967")]
		[FieldOffset(Offset = "0x8")]
		private static readonly ProfilerMarker MarkerFilterLedges;

		[Token(Token = "0x4000968")]
		[FieldOffset(Offset = "0x10")]
		private static readonly ProfilerMarker MarkerFilterLowHeightSpans;

		[Token(Token = "0x4000969")]
		[FieldOffset(Offset = "0x18")]
		private static readonly ProfilerMarker MarkerBuildCompactField;

		[Token(Token = "0x400096A")]
		[FieldOffset(Offset = "0x20")]
		private static readonly ProfilerMarker MarkerBuildConnections;

		[Token(Token = "0x400096B")]
		[FieldOffset(Offset = "0x28")]
		private static readonly ProfilerMarker MarkerErodeWalkableArea;

		[Token(Token = "0x400096C")]
		[FieldOffset(Offset = "0x30")]
		private static readonly ProfilerMarker MarkerBuildDistanceField;

		[Token(Token = "0x400096D")]
		[FieldOffset(Offset = "0x38")]
		private static readonly ProfilerMarker MarkerBuildRegions;

		[Token(Token = "0x400096E")]
		[FieldOffset(Offset = "0x40")]
		private static readonly ProfilerMarker MarkerBuildContours;

		[Token(Token = "0x400096F")]
		[FieldOffset(Offset = "0x48")]
		private static readonly ProfilerMarker MarkerBuildMesh;

		[Token(Token = "0x4000970")]
		[FieldOffset(Offset = "0x50")]
		private static readonly ProfilerMarker MarkerConvertAreasToTags;

		[Token(Token = "0x4000971")]
		[FieldOffset(Offset = "0x58")]
		private static readonly ProfilerMarker MarkerRemoveDuplicateVertices;

		[Token(Token = "0x4000972")]
		[FieldOffset(Offset = "0x60")]
		private static readonly ProfilerMarker MarkerTransformTileCoordinates;

		[Token(Token = "0x6000D7A")]
		[Address(RVA = "0x44702EC", Offset = "0x446C2EC", VA = "0x44702EC")]
		public void SetOutputMeshes(NativeArray<TileMesh.TileMeshUnsafe> arr)
		{
		}

		[Token(Token = "0x6000D7B")]
		[Address(RVA = "0x4470350", Offset = "0x446C350", VA = "0x4470350")]
		public void SetCounter(NativeReference<int> counter)
		{
		}

		[Token(Token = "0x6000D7C")]
		[Address(RVA = "0x4470390", Offset = "0x446C390", VA = "0x4470390", Slot = "4")]
		public void Execute()
		{
		}
	}
}
