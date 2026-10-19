using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Pathfinding.Collections;
using Pathfinding.Jobs;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

namespace Pathfinding.Graphs.Grid
{
	[Token(Token = "0x2000206")]
	public struct GridGraphNodeData
	{
		[Token(Token = "0x2000207")]
		private struct LightReader : GridIterationUtilities.ISliceAction
		{
			[Token(Token = "0x40009BD")]
			[FieldOffset(Offset = "0x0")]
			public GridNodeBase[] nodes;

			[Token(Token = "0x40009BE")]
			[FieldOffset(Offset = "0x8")]
			public UnsafeSpan<Vector3> nodePositions;

			[Token(Token = "0x40009BF")]
			[FieldOffset(Offset = "0x18")]
			public UnsafeSpan<bool> nodeWalkable;

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x6000DAA")]
			[Address(RVA = "0x44752A4", Offset = "0x44712A4", VA = "0x44752A4", Slot = "4")]
			public void Execute(uint outerIdx, uint innerIdx)
			{
			}
		}

		[Token(Token = "0x40009B2")]
		[FieldOffset(Offset = "0x0")]
		public Allocator allocationMethod;

		[Token(Token = "0x40009B3")]
		[FieldOffset(Offset = "0x4")]
		public int numNodes;

		[Token(Token = "0x40009B4")]
		[FieldOffset(Offset = "0x8")]
		public IntBounds bounds;

		[Token(Token = "0x40009B5")]
		[FieldOffset(Offset = "0x20")]
		public NativeArray<Vector3> positions;

		[Token(Token = "0x40009B6")]
		[FieldOffset(Offset = "0x30")]
		public NativeArray<ulong> connections;

		[Token(Token = "0x40009B7")]
		[FieldOffset(Offset = "0x40")]
		public NativeArray<uint> penalties;

		[Token(Token = "0x40009B8")]
		[FieldOffset(Offset = "0x50")]
		public NativeArray<int> tags;

		[Token(Token = "0x40009B9")]
		[FieldOffset(Offset = "0x60")]
		public NativeArray<float4> normals;

		[Token(Token = "0x40009BA")]
		[FieldOffset(Offset = "0x70")]
		public NativeArray<bool> walkable;

		[Token(Token = "0x40009BB")]
		[FieldOffset(Offset = "0x80")]
		public NativeArray<bool> walkableWithErosion;

		[Token(Token = "0x40009BC")]
		[FieldOffset(Offset = "0x90")]
		public bool layeredDataLayout;

		[Token(Token = "0x1700020F")]
		public int layers
		{
			[Token(Token = "0x6000D9C")]
			[Address(RVA = "0x44736D8", Offset = "0x446F6D8", VA = "0x44736D8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000D9D")]
		[Address(RVA = "0x44736F4", Offset = "0x446F6F4", VA = "0x44736F4")]
		public void AllocateBuffers(JobDependencyTracker dependencyTracker)
		{
		}

		[Token(Token = "0x6000D9E")]
		[Address(RVA = "0x44739B8", Offset = "0x446F9B8", VA = "0x44739B8")]
		public void TrackBuffers(JobDependencyTracker dependencyTracker)
		{
		}

		[Token(Token = "0x6000D9F")]
		[Address(RVA = "0x4473B94", Offset = "0x446FB94", VA = "0x4473B94")]
		public void PersistBuffers(JobDependencyTracker dependencyTracker)
		{
		}

		[Token(Token = "0x6000DA0")]
		[Address(RVA = "0x4473CC0", Offset = "0x446FCC0", VA = "0x4473CC0")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000DA1")]
		[Address(RVA = "0x4473E50", Offset = "0x446FE50", VA = "0x4473E50")]
		public JobHandle Rotate2D(int dx, int dz, JobHandle dependency)
		{
			return default;
		}

		[Token(Token = "0x6000DA2")]
		[Address(RVA = "0x4474264", Offset = "0x4470264", VA = "0x4474264")]
		public void ResizeLayerCount(int layerCount, JobDependencyTracker dependencyTracker)
		{
		}

		[Token(Token = "0x6000DA3")]
		[Address(RVA = "0x4474514", Offset = "0x4470514", VA = "0x4474514")]
		public void ReadFromNodesForConnectionCalculations(GridNodeBase[] nodes, Slice3D slice, JobHandle nodesDependsOn, NativeArray<float4> graphNodeNormals, JobDependencyTracker dependencyTracker)
		{
		}

		[Token(Token = "0x6000DA4")]
		[Address(RVA = "0x4474848", Offset = "0x4470848", VA = "0x4474848")]
		private void ReadNodeNormals(Slice3D slice, NativeArray<float4> graphNodeNormals, JobDependencyTracker dependencyTracker)
		{
		}

		[Token(Token = "0x6000DA5")]
		[Address(RVA = "0x4474B94", Offset = "0x4470B94", VA = "0x4474B94")]
		public static GridGraphNodeData ReadFromNodes(GridNodeBase[] nodes, Slice3D slice, JobHandle nodesDependsOn, NativeArray<float4> graphNodeNormals, Allocator allocator, bool layeredDataLayout, JobDependencyTracker dependencyTracker)
		{
			return default;
		}

		[Token(Token = "0x6000DA6")]
		[Address(RVA = "0x4474E40", Offset = "0x4470E40", VA = "0x4474E40")]
		public GridGraphNodeData ReadFromNodesAndCopy(GridNodeBase[] nodes, Slice3D slice, JobHandle nodesDependsOn, NativeArray<float4> graphNodeNormals, bool copyPenaltyAndTags, JobDependencyTracker dependencyTracker)
		{
			return default;
		}

		[Token(Token = "0x6000DA7")]
		[Address(RVA = "0x4474F28", Offset = "0x4470F28", VA = "0x4474F28")]
		public void CopyFrom(GridGraphNodeData other, bool copyPenaltyAndTags, JobDependencyTracker dependencyTracker)
		{
		}

		[Token(Token = "0x6000DA8")]
		[Address(RVA = "0x4474FD8", Offset = "0x4470FD8", VA = "0x4474FD8")]
		public void CopyFrom(GridGraphNodeData other, IntBounds bounds, bool copyPenaltyAndTags, JobDependencyTracker dependencyTracker)
		{
		}

		[Token(Token = "0x6000DA9")]
		[Address(RVA = "0x44750E8", Offset = "0x44710E8", VA = "0x44750E8")]
		public JobHandle AssignToNodes(GridNodeBase[] nodes, int3 nodeArrayBounds, IntBounds writeMask, uint graphIndex, JobHandle nodesDependsOn, JobDependencyTracker dependencyTracker)
		{
			return default;
		}
	}
}
