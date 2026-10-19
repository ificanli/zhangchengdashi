using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Pathfinding.Collections;
using Pathfinding.Graphs.Navmesh.Voxelization.Burst;
using Pathfinding.Jobs;
using Pathfinding.Sync;
using Unity.Burst;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;

namespace Pathfinding.Graphs.Navmesh
{
	[Token(Token = "0x20001BB")]
	[BurstCompile]
	public struct TileBuilder
	{
		[Token(Token = "0x20001BC")]
		public class TileBuilderOutput : IProgress, IDisposable
		{
			[Token(Token = "0x400086A")]
			[FieldOffset(Offset = "0x10")]
			public NativeReference<int> currentTileCounter;

			[Token(Token = "0x400086B")]
			[FieldOffset(Offset = "0x20")]
			public TileMeshesUnsafe tileMeshes;

			[Token(Token = "0x17000200")]
			public float Progress
			{
				[Token(Token = "0x6000C9A")]
				[Address(RVA = "0x45959B4", Offset = "0x45919B4", VA = "0x45959B4", Slot = "4")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x6000C9B")]
			[Address(RVA = "0x4595A34", Offset = "0x4591A34", VA = "0x4595A34", Slot = "5")]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000C9C")]
			[Address(RVA = "0x45950C0", Offset = "0x45910C0", VA = "0x45950C0")]
			public TileBuilderOutput()
			{
			}
		}

		[Token(Token = "0x20001BD")]
		public struct BucketMapping
		{
			[Token(Token = "0x400086C")]
			[FieldOffset(Offset = "0x0")]
			public NativeArray<RasterizationMesh> meshes;

			[Token(Token = "0x400086D")]
			[FieldOffset(Offset = "0x10")]
			public NativeArray<int> pointers;

			[Token(Token = "0x400086E")]
			[FieldOffset(Offset = "0x20")]
			public NativeArray<int> bucketRanges;
		}

		[Token(Token = "0x20001BE")]
		public delegate void PutMeshesIntoTileBuckets_00000BA5_0024PostfixBurstDelegate(ref UnsafeSpan<RasterizationMesh> meshes, ref IntRect tileBuckets, ref float4x4 worldToGraphMatrix, ref float2 tileSize, int borderExpansion, out UnsafeSpan<int> bucketRanges, out UnsafeSpan<int> pointers);

		[Token(Token = "0x20001BF")]
		internal static class PutMeshesIntoTileBuckets_00000BA5_0024BurstDirectCall
		{
			[Token(Token = "0x400086F")]
			[FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			[Token(Token = "0x4000870")]
			[FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;

			[Token(Token = "0x6000CA1")]
			[Address(RVA = "0x4595E08", Offset = "0x4591E08", VA = "0x4595E08")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
			}

			[Token(Token = "0x6000CA2")]
			[Address(RVA = "0x4595F24", Offset = "0x4591F24", VA = "0x4595F24")]
			private static IntPtr GetFunctionPointer()
			{
				return default;
			}

			[Token(Token = "0x6000CA3")]
			[Address(RVA = "0x4595F80", Offset = "0x4591F80", VA = "0x4595F80")]
			public static void Constructor()
			{
			}

			[Token(Token = "0x6000CA4")]
			[Address(RVA = "0x4596028", Offset = "0x4592028", VA = "0x4596028")]
			public static void Initialize()
			{
			}

			[Token(Token = "0x6000CA6")]
			[Address(RVA = "0x4594178", Offset = "0x4590178", VA = "0x4594178")]
			public static void Invoke(ref UnsafeSpan<RasterizationMesh> meshes, ref IntRect tileBuckets, ref float4x4 worldToGraphMatrix, ref float2 tileSize, int borderExpansion, out UnsafeSpan<int> bucketRanges, out UnsafeSpan<int> pointers)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED TileBuilder.PutMeshesIntoTileBuckets_00000BA5_0024BurstDirectCall.Invoke RVA=0x4594178 Token=0x6000CA6");
}
		}

		[Token(Token = "0x400085A")]
		[FieldOffset(Offset = "0x0")]
		public float walkableClimb;

		[Token(Token = "0x400085B")]
		[FieldOffset(Offset = "0x8")]
		public RecastGraph.CollectionSettings collectionSettings;

		[Token(Token = "0x400085C")]
		[FieldOffset(Offset = "0x10")]
		public RecastGraph.RelevantGraphSurfaceMode relevantGraphSurfaceMode;

		[Token(Token = "0x400085D")]
		[FieldOffset(Offset = "0x14")]
		public RecastGraph.DimensionMode dimensionMode;

		[Token(Token = "0x400085E")]
		[FieldOffset(Offset = "0x18")]
		public RecastGraph.BackgroundTraversability backgroundTraversability;

		[Token(Token = "0x400085F")]
		[FieldOffset(Offset = "0x1C")]
		public int tileBorderSizeInVoxels;

		[Token(Token = "0x4000860")]
		[FieldOffset(Offset = "0x20")]
		public float walkableHeight;

		[Token(Token = "0x4000861")]
		[FieldOffset(Offset = "0x24")]
		public float maxSlope;

		[Token(Token = "0x4000862")]
		[FieldOffset(Offset = "0x28")]
		public int characterRadiusInVoxels;

		[Token(Token = "0x4000863")]
		[FieldOffset(Offset = "0x2C")]
		public int minRegionSize;

		[Token(Token = "0x4000864")]
		[FieldOffset(Offset = "0x30")]
		public float maxEdgeLength;

		[Token(Token = "0x4000865")]
		[FieldOffset(Offset = "0x34")]
		public float contourMaxError;

		[Token(Token = "0x4000866")]
		[FieldOffset(Offset = "0x38")]
		public TileLayout tileLayout;

		[Token(Token = "0x4000867")]
		[FieldOffset(Offset = "0x60")]
		public IntRect tileRect;

		[Token(Token = "0x4000868")]
		[FieldOffset(Offset = "0x70")]
		public List<RecastGraph.PerLayerModification> perLayerModifications;

		[Token(Token = "0x4000869")]
		[FieldOffset(Offset = "0x78")]
		public List<RecastGraph.PerTerrainLayerModification> perTerrainLayerModifications;

		[Token(Token = "0x170001FE")]
		private int TileBorderSizeInVoxels
		{
			[Token(Token = "0x6000C93")]
			[Address(RVA = "0x4593BB4", Offset = "0x458FBB4", VA = "0x4593BB4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170001FF")]
		private float TileBorderSizeInWorldUnits
		{
			[Token(Token = "0x6000C94")]
			[Address(RVA = "0x4593BC0", Offset = "0x458FBC0", VA = "0x4593BC0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000C92")]
		[Address(RVA = "0x459391C", Offset = "0x458F91C", VA = "0x459391C")]
		public TileBuilder(RecastGraph graph, TileLayout tileLayout, IntRect tileRect)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED TileBuilder..ctor RVA=0x459391C Token=0x6000C92");
}

		[Token(Token = "0x6000C95")]
		[Address(RVA = "0x4593BD8", Offset = "0x458FBD8", VA = "0x4593BD8")]
		public Bounds GetWorldSpaceBounds(float xzPadding = 0f)
		{
			return default;
		}

		[Token(Token = "0x6000C96")]
		[Address(RVA = "0x4593D68", Offset = "0x458FD68", VA = "0x4593D68")]
		public RecastMeshGatherer.MeshCollection CollectMeshes(Bounds bounds)
		{
			return default;
		}

		[Token(Token = "0x6000C97")]
		[Address(RVA = "0x45940DC", Offset = "0x45900DC", VA = "0x45940DC")]
		[BurstCompile]
		private static void PutMeshesIntoTileBuckets(ref UnsafeSpan<RasterizationMesh> meshes, ref IntRect tileBuckets, ref float4x4 worldToGraphMatrix, ref float2 tileSize, int borderExpansion, out UnsafeSpan<int> bucketRanges, out UnsafeSpan<int> pointers)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED TileBuilder.PutMeshesIntoTileBuckets RVA=0x45940DC Token=0x6000C97");
}

		[Token(Token = "0x6000C98")]
		[Address(RVA = "0x4594288", Offset = "0x4590288", VA = "0x4594288")]
		public Promise<TileBuilderOutput> Schedule(DisposeArena arena)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000C99")]
		[Address(RVA = "0x4595100", Offset = "0x4591100", VA = "0x4595100")]
		[BurstCompile]
		public static void PutMeshesIntoTileBuckets_0024BurstManaged(ref UnsafeSpan<RasterizationMesh> meshes, ref IntRect tileBuckets, ref float4x4 worldToGraphMatrix, ref float2 tileSize, int borderExpansion, out UnsafeSpan<int> bucketRanges, out UnsafeSpan<int> pointers)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED TileBuilder.PutMeshesIntoTileBuckets_0024BurstManaged RVA=0x4595100 Token=0x6000C99");
}
	}
}
