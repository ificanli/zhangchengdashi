using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Pathfinding.Collections;
using Pathfinding.Graphs.Navmesh.Voxelization.Burst;
using Pathfinding.Jobs;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine;

namespace Pathfinding.Graphs.Navmesh
{
	[Token(Token = "0x20001AA")]
	[BurstCompile]
	public class RecastMeshGatherer
	{
		[Token(Token = "0x20001AB")]
		private static class Markers
		{
			[Token(Token = "0x4000825")]
			[FieldOffset(Offset = "0x0")]
			public static readonly ProfilerMarker MarkerCalculateBounds;

			[Token(Token = "0x4000826")]
			[FieldOffset(Offset = "0x8")]
			public static readonly ProfilerMarker MarkerGetMissingMeshDataAndBounds;

			[Token(Token = "0x4000827")]
			[FieldOffset(Offset = "0x10")]
			public static readonly ProfilerMarker MarkerPatchMissingMeshDataAndBounds;

			[Token(Token = "0x4000828")]
			[FieldOffset(Offset = "0x18")]
			public static readonly ProfilerMarker MarkerCreateRasterizationMeshes;
		}

		[Token(Token = "0x20001AC")]
		private struct TreeInfo
		{
			[Token(Token = "0x4000829")]
			[FieldOffset(Offset = "0x0")]
			public UnsafeList<int> submeshIndices;

			[Token(Token = "0x400082A")]
			[FieldOffset(Offset = "0x18")]
			public Vector3 localScale;

			[Token(Token = "0x400082B")]
			[FieldOffset(Offset = "0x24")]
			public bool supportsRotation;
		}

		[Token(Token = "0x20001AD")]
		public struct MeshCollection : IArenaDisposable
		{
			[Token(Token = "0x400082C")]
			[FieldOffset(Offset = "0x0")]
			private UnsafeList<UnsafeSpan<Vector3>> vertexBuffers;

			[Token(Token = "0x400082D")]
			[FieldOffset(Offset = "0x18")]
			private UnsafeList<UnsafeSpan<int>> triangleBuffers;

			[Token(Token = "0x400082E")]
			[FieldOffset(Offset = "0x30")]
			private UnsafeList<UnsafeSpan<int>> tagsBuffers;

			[Token(Token = "0x400082F")]
			[FieldOffset(Offset = "0x48")]
			public NativeArray<RasterizationMesh> meshes;

			[Token(Token = "0x6000C60")]
			[Address(RVA = "0x4588F8C", Offset = "0x4584F8C", VA = "0x4588F8C")]
			public MeshCollection(UnsafeList<UnsafeSpan<Vector3>> vertexBuffers, UnsafeList<UnsafeSpan<int>> triangleBuffers, UnsafeList<UnsafeSpan<int>> tagsBuffers, NativeArray<RasterizationMesh> meshes)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED RecastMeshGatherer.MeshCollection..ctor RVA=0x4588F8C Token=0x6000C60");
}

			[Token(Token = "0x6000C61")]
			[Address(RVA = "0x458FDF8", Offset = "0x458BDF8", VA = "0x458FDF8", Slot = "4")]
void IArenaDisposable.DisposeWith(DisposeArena arena)
			{
			}
		}

		[Token(Token = "0x20001AE")]
		public struct GatheredMesh
		{
			[Token(Token = "0x4000830")]
			[FieldOffset(Offset = "0x0")]
			public int meshDataIndex;

			[Token(Token = "0x4000831")]
			[FieldOffset(Offset = "0x4")]
			public int area;

			[Token(Token = "0x4000832")]
			[FieldOffset(Offset = "0x8")]
			public int tagDataIndex;

			[Token(Token = "0x4000833")]
			[FieldOffset(Offset = "0xC")]
			public int indexStart;

			[Token(Token = "0x4000834")]
			[FieldOffset(Offset = "0x10")]
			public int indexEnd;

			[Token(Token = "0x4000835")]
			[FieldOffset(Offset = "0x14")]
			public Bounds bounds;

			[Token(Token = "0x4000836")]
			[FieldOffset(Offset = "0x2C")]
			public Matrix4x4 matrix;

			[Token(Token = "0x4000837")]
			[FieldOffset(Offset = "0x6C")]
			public bool solid;

			[Token(Token = "0x4000838")]
			[FieldOffset(Offset = "0x6D")]
			public bool doubleSided;

			[Token(Token = "0x4000839")]
			[FieldOffset(Offset = "0x6E")]
			public bool flatten;

			[Token(Token = "0x400083A")]
			[FieldOffset(Offset = "0x6F")]
			public bool areaIsTag;

			[Token(Token = "0x6000C62")]
			[Address(RVA = "0x458CF38", Offset = "0x4588F38", VA = "0x458CF38")]
			public void RecalculateBounds()
			{
			}

			[Token(Token = "0x6000C63")]
			[Address(RVA = "0x458A764", Offset = "0x4586764", VA = "0x458A764")]
			public void ApplyNavmeshModifier(RecastNavmeshModifier navmeshModifier)
			{
			}

			[Token(Token = "0x6000C64")]
			[Address(RVA = "0x4589FC0", Offset = "0x4585FC0", VA = "0x4589FC0")]
			public void ApplyLayerModification(RecastGraph.PerLayerModification modification)
			{
			}
		}

		[Token(Token = "0x20001AF")]
		private enum MeshType
		{
			[Token(Token = "0x400083C")]
			Mesh = 0,
			[Token(Token = "0x400083D")]
			Box = 1,
			[Token(Token = "0x400083E")]
			Capsule = 2
		}

		[Token(Token = "0x20001B0")]
		private struct MeshCacheItem : IEquatable<MeshCacheItem>
		{
			[Token(Token = "0x400083F")]
			[FieldOffset(Offset = "0x0")]
			public MeshType type;

			[Token(Token = "0x4000840")]
			[FieldOffset(Offset = "0x8")]
			public Mesh mesh;

			[Token(Token = "0x4000841")]
			[FieldOffset(Offset = "0x10")]
			public int rows;

			[Token(Token = "0x4000842")]
			[FieldOffset(Offset = "0x14")]
			public int quantizedHeight;

			[Token(Token = "0x4000843")]
			[FieldOffset(Offset = "0x0")]
			public static readonly MeshCacheItem Box;

			[Token(Token = "0x6000C65")]
			[Address(RVA = "0x4589904", Offset = "0x4585904", VA = "0x4589904")]
			public MeshCacheItem(Mesh mesh)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED RecastMeshGatherer.MeshCacheItem..ctor RVA=0x4589904 Token=0x6000C65");
}

			[Token(Token = "0x6000C66")]
			[Address(RVA = "0x458FFFC", Offset = "0x458BFFC", VA = "0x458FFFC", Slot = "4")]
			public bool Equals(MeshCacheItem other)
			{
				return default;
			}

			[Token(Token = "0x6000C67")]
			[Address(RVA = "0x45900AC", Offset = "0x458C0AC", VA = "0x45900AC", Slot = "2")]
			public override int GetHashCode()
			{
				return default;
			}
		}

		[Token(Token = "0x20001B1")]
		[BurstCompile]
		private struct JobGenerateHeightmapChunk : IJobFor
		{
			[Token(Token = "0x20001B2")]
			public struct TerrainChunk
			{
				[Token(Token = "0x400084F")]
				[FieldOffset(Offset = "0x0")]
				public UnsafeSpan<Vector3> verts;

				[Token(Token = "0x4000850")]
				[FieldOffset(Offset = "0x10")]
				public UnsafeSpan<int> tris;

				[Token(Token = "0x4000851")]
				[FieldOffset(Offset = "0x20")]
				public UnsafeSpan<int> tags;
			}

			[Token(Token = "0x4000844")]
			[FieldOffset(Offset = "0x0")]
			public UnsafeSpan<float> heights;

			[Token(Token = "0x4000845")]
			[FieldOffset(Offset = "0x10")]
			public UnsafeSpan<bool> holes;

			[Token(Token = "0x4000846")]
			[FieldOffset(Offset = "0x20")]
			public IntRect sampleRect;

			[Token(Token = "0x4000847")]
			[FieldOffset(Offset = "0x30")]
			public Vector2Int chunkSize;

			[Token(Token = "0x4000848")]
			[FieldOffset(Offset = "0x38")]
			public Vector2Int chunks;

			[Token(Token = "0x4000849")]
			[FieldOffset(Offset = "0x40")]
			public int stride;

			[Token(Token = "0x400084A")]
			[FieldOffset(Offset = "0x44")]
			public float alphamapScale;

			[Token(Token = "0x400084B")]
			[FieldOffset(Offset = "0x48")]
			public UnsafeSpan<UnsafeSpan<byte>> alphaMaps;

			[Token(Token = "0x400084C")]
			[FieldOffset(Offset = "0x58")]
			public UnsafeSpan<int> areaMapping;

			[Token(Token = "0x400084D")]
			[FieldOffset(Offset = "0x68")]
			public UnsafeSpan<float> areaMappingThresholds;

			[Token(Token = "0x400084E")]
			[FieldOffset(Offset = "0x78")]
			public NativeArray<TerrainChunk> output;

			[Token(Token = "0x6000C69")]
			[Address(RVA = "0x45901B8", Offset = "0x458C1B8", VA = "0x45901B8", Slot = "4")]
			public void Execute(int index)
			{
			}
		}

		[Token(Token = "0x20001B3")]
		public delegate void CalculateBounds_00000B72_0024PostfixBurstDelegate(ref UnsafeSpan<float3> vertices, ref float4x4 localToWorldMatrix, out Bounds bounds);

		[Token(Token = "0x20001B4")]
		internal static class CalculateBounds_00000B72_0024BurstDirectCall
		{
			[Token(Token = "0x4000852")]
			[FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			[Token(Token = "0x4000853")]
			[FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;

			[Token(Token = "0x6000C6E")]
			[Address(RVA = "0x4592684", Offset = "0x458E684", VA = "0x4592684")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
			}

			[Token(Token = "0x6000C6F")]
			[Address(RVA = "0x45927A0", Offset = "0x458E7A0", VA = "0x45927A0")]
			private static IntPtr GetFunctionPointer()
			{
				return default;
			}

			[Token(Token = "0x6000C70")]
			[Address(RVA = "0x45927FC", Offset = "0x458E7FC", VA = "0x45927FC")]
			public static void Constructor()
			{
			}

			[Token(Token = "0x6000C71")]
			[Address(RVA = "0x45928A4", Offset = "0x458E8A4", VA = "0x45928A4")]
			public static void Initialize()
			{
			}

			[Token(Token = "0x6000C73")]
			[Address(RVA = "0x45928AC", Offset = "0x458E8AC", VA = "0x45928AC")]
			public static void Invoke(ref UnsafeSpan<float3> vertices, ref float4x4 localToWorldMatrix, out Bounds bounds)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED RecastMeshGatherer.CalculateBounds_00000B72_0024BurstDirectCall.Invoke RVA=0x45928AC Token=0x6000C73");
}
		}

		[Token(Token = "0x20001B5")]
		public delegate void PatchMissingMeshDataAndBounds_00000B74_0024PostfixBurstDelegate(ref UnsafeList<GatheredMesh> gatheredMeshes, ref UnsafeList<UnsafeSpan<Vector3>> vertexBuffers, int meshBufferOffset);

		[Token(Token = "0x20001B6")]
		internal static class PatchMissingMeshDataAndBounds_00000B74_0024BurstDirectCall
		{
			[Token(Token = "0x4000854")]
			[FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			[Token(Token = "0x4000855")]
			[FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;

			[Token(Token = "0x6000C78")]
			[Address(RVA = "0x4592B44", Offset = "0x458EB44", VA = "0x4592B44")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
			}

			[Token(Token = "0x6000C79")]
			[Address(RVA = "0x4592C60", Offset = "0x458EC60", VA = "0x4592C60")]
			private static IntPtr GetFunctionPointer()
			{
				return default;
			}

			[Token(Token = "0x6000C7A")]
			[Address(RVA = "0x4592CBC", Offset = "0x458ECBC", VA = "0x4592CBC")]
			public static void Constructor()
			{
			}

			[Token(Token = "0x6000C7B")]
			[Address(RVA = "0x4592D64", Offset = "0x458ED64", VA = "0x4592D64")]
			public static void Initialize()
			{
			}

			[Token(Token = "0x6000C7D")]
			[Address(RVA = "0x4592D6C", Offset = "0x458ED6C", VA = "0x4592D6C")]
			public static void Invoke(ref UnsafeList<GatheredMesh> gatheredMeshes, ref UnsafeList<UnsafeSpan<Vector3>> vertexBuffers, int meshBufferOffset)
			{
			}
		}

		[Token(Token = "0x20001B7")]
		public delegate void CreateRasterizationMeshes_00000B76_0024PostfixBurstDelegate(ref UnsafeList<GatheredMesh> meshes, ref UnsafeList<UnsafeSpan<Vector3>> vertexBuffers, ref UnsafeList<UnsafeSpan<int>> triangleBuffers, ref UnsafeList<UnsafeSpan<int>> tagsBuffers, ref UnsafeSpan<RasterizationMesh> rasterizationMeshesOutput);

		[Token(Token = "0x20001B8")]
		internal static class CreateRasterizationMeshes_00000B76_0024BurstDirectCall
		{
			[Token(Token = "0x4000856")]
			[FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			[Token(Token = "0x4000857")]
			[FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;

			[Token(Token = "0x6000C82")]
			[Address(RVA = "0x4593050", Offset = "0x458F050", VA = "0x4593050")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
			}

			[Token(Token = "0x6000C83")]
			[Address(RVA = "0x459316C", Offset = "0x458F16C", VA = "0x459316C")]
			private static IntPtr GetFunctionPointer()
			{
				return default;
			}

			[Token(Token = "0x6000C84")]
			[Address(RVA = "0x45931C8", Offset = "0x458F1C8", VA = "0x45931C8")]
			public static void Constructor()
			{
			}

			[Token(Token = "0x6000C85")]
			[Address(RVA = "0x4593270", Offset = "0x458F270", VA = "0x4593270")]
			public static void Initialize()
			{
			}

			[Token(Token = "0x6000C87")]
			[Address(RVA = "0x4593278", Offset = "0x458F278", VA = "0x4593278")]
			public static void Invoke(ref UnsafeList<GatheredMesh> meshes, ref UnsafeList<UnsafeSpan<Vector3>> vertexBuffers, ref UnsafeList<UnsafeSpan<int>> triangleBuffers, ref UnsafeList<UnsafeSpan<int>> tagsBuffers, ref UnsafeSpan<RasterizationMesh> rasterizationMeshesOutput)
			{
			}
		}

		[Token(Token = "0x20001B9")]
		private delegate void ConvertTreesToMeshes_00000B89_0024PostfixBurstDelegate(ref UnsafeSpan<TreeInstance> treeInstances, ref float3 terrainPos, ref float3 terrainSize, ref UnsafeSpan<TreeInfo> treeInfos, ref UnsafeList<GatheredMesh> allSubmeshes, ref Bounds graphBounds, ref UnsafeList<GatheredMesh> meshes);

		[Token(Token = "0x20001BA")]
		internal static class ConvertTreesToMeshes_00000B89_0024BurstDirectCall
		{
			[Token(Token = "0x4000858")]
			[FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			[Token(Token = "0x4000859")]
			[FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;

			[Token(Token = "0x6000C8C")]
			[Address(RVA = "0x45935C0", Offset = "0x458F5C0", VA = "0x45935C0")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
			}

			[Token(Token = "0x6000C8D")]
			[Address(RVA = "0x45936DC", Offset = "0x458F6DC", VA = "0x45936DC")]
			private static IntPtr GetFunctionPointer()
			{
				return default;
			}

			[Token(Token = "0x6000C8E")]
			[Address(RVA = "0x4593738", Offset = "0x458F738", VA = "0x4593738")]
			public static void Constructor()
			{
			}

			[Token(Token = "0x6000C8F")]
			[Address(RVA = "0x45937E0", Offset = "0x458F7E0", VA = "0x45937E0")]
			public static void Initialize()
			{
			}

			[Token(Token = "0x6000C91")]
			[Address(RVA = "0x45937E8", Offset = "0x458F7E8", VA = "0x45937E8")]
			private static void Invoke(ref UnsafeSpan<TreeInstance> treeInstances, ref float3 terrainPos, ref float3 terrainSize, ref UnsafeSpan<TreeInfo> treeInfos, ref UnsafeList<GatheredMesh> allSubmeshes, ref Bounds graphBounds, ref UnsafeList<GatheredMesh> meshes)
			{
			}
		}

		[Token(Token = "0x4000811")]
		[FieldOffset(Offset = "0x10")]
		private readonly int terrainDownsamplingFactor;

		[Token(Token = "0x4000812")]
		[FieldOffset(Offset = "0x14")]
		public readonly LayerMask mask;

		[Token(Token = "0x4000813")]
		[FieldOffset(Offset = "0x18")]
		public readonly List<string> tagMask;

		[Token(Token = "0x4000814")]
		[FieldOffset(Offset = "0x20")]
		private readonly float maxColliderApproximationError;

		[Token(Token = "0x4000815")]
		[FieldOffset(Offset = "0x24")]
		public readonly Bounds bounds;

		[Token(Token = "0x4000816")]
		[FieldOffset(Offset = "0x3C")]
		public readonly PhysicsScene physicsScene;

		[Token(Token = "0x4000817")]
		[FieldOffset(Offset = "0x40")]
		public readonly PhysicsScene2D physicsScene2D;

		[Token(Token = "0x4000818")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<MeshCacheItem, int> cachedMeshes;

		[Token(Token = "0x4000819")]
		[FieldOffset(Offset = "0x50")]
		private UnsafeList<UnsafeSpan<Vector3>> vertexBuffers;

		[Token(Token = "0x400081A")]
		[FieldOffset(Offset = "0x68")]
		private UnsafeList<UnsafeSpan<int>> triangleBuffers;

		[Token(Token = "0x400081B")]
		[FieldOffset(Offset = "0x80")]
		private UnsafeList<UnsafeSpan<int>> tagsBuffers;

		[Token(Token = "0x400081C")]
		[FieldOffset(Offset = "0x98")]
		private List<Mesh> meshData;

		[Token(Token = "0x400081D")]
		[FieldOffset(Offset = "0xA0")]
		private readonly RecastGraph.PerLayerModification[] modificationsByLayer;

		[Token(Token = "0x400081E")]
		[FieldOffset(Offset = "0xA8")]
		private readonly RecastGraph.PerLayerModification[] modificationsByLayer2D;

		[Token(Token = "0x400081F")]
		[FieldOffset(Offset = "0xB0")]
		private readonly List<RecastGraph.PerTerrainLayerModification> perTerrainLayerModifications;

		[Token(Token = "0x4000820")]
		[FieldOffset(Offset = "0xB8")]
		private bool anyNonReadableMesh;

		[Token(Token = "0x4000821")]
		[FieldOffset(Offset = "0xC0")]
		private UnsafeList<GatheredMesh> meshes;

		[Token(Token = "0x4000822")]
		[FieldOffset(Offset = "0xD8")]
		private List<Material> dummyMaterials;

		[Token(Token = "0x4000823")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int[] BoxColliderTris;

		[Token(Token = "0x4000824")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Vector3[] BoxColliderVerts;

		[Token(Token = "0x6000C37")]
		[Address(RVA = "0x4588534", Offset = "0x4584534", VA = "0x4588534")]
		public RecastMeshGatherer(PhysicsScene physicsScene, PhysicsScene2D physicsScene2D, Bounds bounds, int terrainDownsamplingFactor, LayerMask mask, List<string> tagMask, List<RecastGraph.PerLayerModification> perLayerModifications, List<RecastGraph.PerTerrainLayerModification> perTerrainLayerModifications, float maxColliderApproximationError)
		{
		}

		[Token(Token = "0x6000C38")]
		[Address(RVA = "0x45888DC", Offset = "0x45848DC", VA = "0x45888DC")]
		[BurstCompile]
		private static void CalculateBounds(ref UnsafeSpan<float3> vertices, ref float4x4 localToWorldMatrix, out Bounds bounds)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED RecastMeshGatherer.CalculateBounds RVA=0x45888DC Token=0x6000C38");
}

		[Token(Token = "0x6000C39")]
		[Address(RVA = "0x458894C", Offset = "0x458494C", VA = "0x458894C")]
		private static void GetMissingMeshDataAndBounds(List<Mesh> meshData, ref UnsafeList<GatheredMesh> gatheredMeshes, ref UnsafeList<UnsafeSpan<Vector3>> vertexBuffers, ref UnsafeList<UnsafeSpan<int>> triangleBuffers)
		{
		}

		[Token(Token = "0x6000C3A")]
		[Address(RVA = "0x4588C08", Offset = "0x4584C08", VA = "0x4588C08")]
		[BurstCompile]
		private static void PatchMissingMeshDataAndBounds(ref UnsafeList<GatheredMesh> gatheredMeshes, ref UnsafeList<UnsafeSpan<Vector3>> vertexBuffers, int meshBufferOffset)
		{
		}

		[Token(Token = "0x6000C3B")]
		[Address(RVA = "0x4588C78", Offset = "0x4584C78", VA = "0x4588C78")]
		public MeshCollection Finalize()
		{
			return default;
		}

		[Token(Token = "0x6000C3C")]
		[Address(RVA = "0x4588F04", Offset = "0x4584F04", VA = "0x4588F04")]
		[BurstCompile]
		private static void CreateRasterizationMeshes(ref UnsafeList<GatheredMesh> meshes, ref UnsafeList<UnsafeSpan<Vector3>> vertexBuffers, ref UnsafeList<UnsafeSpan<int>> triangleBuffers, ref UnsafeList<UnsafeSpan<int>> tagsBuffers, ref UnsafeSpan<RasterizationMesh> rasterizationMeshesOutput)
		{
		}

		[Token(Token = "0x6000C3D")]
		[Address(RVA = "0x4588FC4", Offset = "0x4584FC4", VA = "0x4588FC4")]
		public int AddMeshBuffers(Vector3[] vertices, int[] triangles)
		{
			return default;
		}

		[Token(Token = "0x6000C3E")]
		[Address(RVA = "0x4589078", Offset = "0x4585078", VA = "0x4589078")]
		public int AddMeshBuffers(UnsafeSpan<Vector3> vertices, UnsafeSpan<int> triangles)
		{
			return default;
		}

		[Token(Token = "0x6000C3F")]
		[Address(RVA = "0x45891DC", Offset = "0x45851DC", VA = "0x45891DC")]
		public void AddMesh(Renderer renderer, Mesh gatheredMesh)
		{
		}

		[Token(Token = "0x6000C40")]
		[Address(RVA = "0x458968C", Offset = "0x458568C", VA = "0x458968C")]
		public void AddMesh(GatheredMesh gatheredMesh)
		{
		}

		[Token(Token = "0x6000C41")]
		[Address(RVA = "0x4589768", Offset = "0x4585768", VA = "0x4589768")]
		private bool MeshFilterShouldBeIncluded(MeshFilter filter)
		{
			return default;
		}

		[Token(Token = "0x6000C42")]
		[Address(RVA = "0x45892E4", Offset = "0x45852E4", VA = "0x45892E4")]
		private bool ConvertMeshToGatheredMesh(Renderer renderer, Mesh mesh, out GatheredMesh gatheredMesh)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED RecastMeshGatherer.ConvertMeshToGatheredMesh RVA=0x45892E4 Token=0x6000C42");
}

		[Token(Token = "0x6000C43")]
		[Address(RVA = "0x4589910", Offset = "0x4585910", VA = "0x4589910")]
		private GatheredMesh? GetColliderMesh(MeshCollider collider, Matrix4x4 localToWorldMatrix)
		{
			return null;
		}

		[Token(Token = "0x6000C44")]
		[Address(RVA = "0x4589C6C", Offset = "0x4585C6C", VA = "0x4589C6C")]
		public void CollectSceneMeshes()
		{
		}

		[Token(Token = "0x6000C45")]
		[Address(RVA = "0x458A054", Offset = "0x4586054", VA = "0x458A054")]
		private static int AreaFromSurfaceMode(RecastNavmeshModifier.Mode mode, int surfaceID)
		{
			return default;
		}

		[Token(Token = "0x6000C46")]
		[Address(RVA = "0x458A084", Offset = "0x4586084", VA = "0x458A084")]
		public void CollectRecastNavmeshModifiers()
		{
		}

		[Token(Token = "0x6000C47")]
		[Address(RVA = "0x458A1F4", Offset = "0x45861F4", VA = "0x458A1F4")]
		private void AddNavmeshModifier(RecastNavmeshModifier navmeshModifier)
		{
		}

		[Token(Token = "0x6000C48")]
		[Address(RVA = "0x458A89C", Offset = "0x458689C", VA = "0x458A89C")]
		public void CollectTerrainMeshes(bool rasterizeTrees, float desiredChunkSize)
		{
		}

		[Token(Token = "0x6000C49")]
		[Address(RVA = "0x458BFB4", Offset = "0x4587FB4", VA = "0x458BFB4")]
		private static int NonNegativeModulus(int x, int m)
		{
			return default;
		}

		[Token(Token = "0x6000C4A")]
		[Address(RVA = "0x458BFC8", Offset = "0x4587FC8", VA = "0x458BFC8")]
		private static int CeilDivision(int lhs, int rhs)
		{
			return default;
		}

		[Token(Token = "0x6000C4B")]
		[Address(RVA = "0x458BFD8", Offset = "0x4587FD8", VA = "0x458BFD8")]
		private static void GetAlphamaps(List<RecastGraph.PerTerrainLayerModification> perTerrainLayerModifications, out UnsafeSpan<UnsafeSpan<byte>> alphamaps, out UnsafeSpan<int> areaMapping, out UnsafeSpan<float> areaMappingThresholds, out float alphamapScale, TerrainData terrainData, int terrainDownsamplingFactor)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED RecastMeshGatherer.GetAlphamaps RVA=0x458BFD8 Token=0x6000C4B");
}

		[Token(Token = "0x6000C4C")]
		[Address(RVA = "0x458C4D8", Offset = "0x45884D8", VA = "0x458C4D8")]
		private static void CalculateTerrainChunkLayout(float desiredChunkSize, Vector3 sampleSize, int terrainDownsamplingFactor, int heightmapResolution, Bounds bounds, Vector3 offset, out IntRect sampleRect, out Vector2Int chunks, out Vector2Int chunkSize)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED RecastMeshGatherer.CalculateTerrainChunkLayout RVA=0x458C4D8 Token=0x6000C4C");
}

		[Token(Token = "0x6000C4D")]
		[Address(RVA = "0x458A9E4", Offset = "0x45869E4", VA = "0x458A9E4")]
		private bool GenerateTerrainChunks(Terrain terrain, Bounds bounds, float desiredChunkSize)
		{
			return default;
		}

		[Token(Token = "0x6000C4E")]
		[Address(RVA = "0x458B4E0", Offset = "0x45874E0", VA = "0x458B4E0")]
		private void CollectTreeMeshes(Terrain terrain)
		{
		}

		[Token(Token = "0x6000C4F")]
		[Address(RVA = "0x458CF48", Offset = "0x4588F48", VA = "0x458CF48")]
		[BurstCompile]
		private static void ConvertTreesToMeshes(ref UnsafeSpan<TreeInstance> treeInstances, ref float3 terrainPos, ref float3 terrainSize, ref UnsafeSpan<TreeInfo> treeInfos, ref UnsafeList<GatheredMesh> allSubmeshes, ref Bounds graphBounds, ref UnsafeList<GatheredMesh> meshes)
		{
		}

		[Token(Token = "0x6000C50")]
		[Address(RVA = "0x458CFE8", Offset = "0x4588FE8", VA = "0x458CFE8")]
		private bool ShouldIncludeCollider(Collider collider)
		{
			return default;
		}

		[Token(Token = "0x6000C51")]
		[Address(RVA = "0x458D1EC", Offset = "0x45891EC", VA = "0x458D1EC")]
		public void CollectColliderMeshes()
		{
		}

		[Token(Token = "0x6000C52")]
		[Address(RVA = "0x458A814", Offset = "0x4586814", VA = "0x458A814")]
		private GatheredMesh? ConvertColliderToGatheredMesh(Collider col)
		{
			return null;
		}

		[Token(Token = "0x6000C53")]
		[Address(RVA = "0x458C9AC", Offset = "0x45889AC", VA = "0x458C9AC")]
		public GatheredMesh? ConvertColliderToGatheredMesh(Collider col, Matrix4x4 localToWorldMatrix)
		{
			return null;
		}

		[Token(Token = "0x6000C54")]
		[Address(RVA = "0x458D66C", Offset = "0x458966C", VA = "0x458D66C")]
		private GatheredMesh RasterizeBoxCollider(BoxCollider collider, Matrix4x4 localToWorldMatrix)
		{
			return default;
		}

		[Token(Token = "0x6000C55")]
		[Address(RVA = "0x458E18C", Offset = "0x458A18C", VA = "0x458E18C")]
		private static int CircleSteps(Matrix4x4 matrix, float radius, float maxError)
		{
			return default;
		}

		[Token(Token = "0x6000C56")]
		[Address(RVA = "0x458E358", Offset = "0x458A358", VA = "0x458E358")]
		private static float CircleRadiusAdjustmentFactor(int steps)
		{
			return default;
		}

		[Token(Token = "0x6000C57")]
		[Address(RVA = "0x458D95C", Offset = "0x458995C", VA = "0x458D95C")]
		private GatheredMesh RasterizeCapsuleCollider(float radius, float height, Bounds bounds, Matrix4x4 localToWorldMatrix)
		{
			return default;
		}

		[Token(Token = "0x6000C58")]
		[Address(RVA = "0x458E3D4", Offset = "0x458A3D4", VA = "0x458E3D4")]
		private bool ShouldIncludeCollider2D(Collider2D collider)
		{
			return default;
		}

		[Token(Token = "0x6000C59")]
		[Address(RVA = "0x458E520", Offset = "0x458A520", VA = "0x458E520")]
		public void Collect2DColliderMeshes()
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000C5B")]
		[Address(RVA = "0x458EDDC", Offset = "0x458ADDC", VA = "0x458EDDC")]
		[BurstCompile]
		public static void CalculateBounds_0024BurstManaged(ref UnsafeSpan<float3> vertices, ref float4x4 localToWorldMatrix, out Bounds bounds)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED RecastMeshGatherer.CalculateBounds_0024BurstManaged RVA=0x458EDDC Token=0x6000C5B");
}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000C5C")]
		[Address(RVA = "0x458F064", Offset = "0x458B064", VA = "0x458F064")]
		[BurstCompile]
		public static void PatchMissingMeshDataAndBounds_0024BurstManaged(ref UnsafeList<GatheredMesh> gatheredMeshes, ref UnsafeList<UnsafeSpan<Vector3>> vertexBuffers, int meshBufferOffset)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000C5D")]
		[Address(RVA = "0x458F330", Offset = "0x458B330", VA = "0x458F330")]
		[BurstCompile]
		public static void CreateRasterizationMeshes_0024BurstManaged(ref UnsafeList<GatheredMesh> meshes, ref UnsafeList<UnsafeSpan<Vector3>> vertexBuffers, ref UnsafeList<UnsafeSpan<int>> triangleBuffers, ref UnsafeList<UnsafeSpan<int>> tagsBuffers, ref UnsafeSpan<RasterizationMesh> rasterizationMeshesOutput)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000C5E")]
		[Address(RVA = "0x458F664", Offset = "0x458B664", VA = "0x458F664")]
		[BurstCompile]
		private static void ConvertTreesToMeshes_0024BurstManaged(ref UnsafeSpan<TreeInstance> treeInstances, ref float3 terrainPos, ref float3 terrainSize, ref UnsafeSpan<TreeInfo> treeInfos, ref UnsafeList<GatheredMesh> allSubmeshes, ref Bounds graphBounds, ref UnsafeList<GatheredMesh> meshes)
		{
		}
	}
}
