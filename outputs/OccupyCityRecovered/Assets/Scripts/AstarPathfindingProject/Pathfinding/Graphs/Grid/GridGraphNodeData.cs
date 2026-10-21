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
 var node = outerIdx < nodes.Length ? nodes[outerIdx] : null;
 if (node != null) {
  nodePositions[innerIdx] = (Vector3)node.position;
  nodeWalkable[innerIdx] = node.Walkable;
 } else {
  nodePositions[innerIdx] = Vector3.zero;
  nodeWalkable[innerIdx] = false;
 }
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
			{ return bounds.size.y; }
		}

		[Token(Token = "0x6000D9D")]
		[Address(RVA = "0x44736F4", Offset = "0x446F6F4", VA = "0x44736F4")]
		public void AllocateBuffers(JobDependencyTracker dependencyTracker)
		{
 if (dependencyTracker != null) {
  positions = dependencyTracker.NewNativeArray<Vector3>(numNodes, allocationMethod, NativeArrayOptions.UninitializedMemory);
  normals = dependencyTracker.NewNativeArray<float4>(numNodes, allocationMethod, NativeArrayOptions.UninitializedMemory);
  connections = dependencyTracker.NewNativeArray<ulong>(numNodes, allocationMethod, NativeArrayOptions.UninitializedMemory);
  penalties = dependencyTracker.NewNativeArray<uint>(numNodes, allocationMethod, NativeArrayOptions.UninitializedMemory);
  walkable = dependencyTracker.NewNativeArray<bool>(numNodes, allocationMethod, NativeArrayOptions.UninitializedMemory);
  walkableWithErosion = dependencyTracker.NewNativeArray<bool>(numNodes, allocationMethod, NativeArrayOptions.UninitializedMemory);
  tags = dependencyTracker.NewNativeArray<int>(numNodes, allocationMethod, NativeArrayOptions.ClearMemory);
 } else {
  positions = new NativeArray<Vector3>(numNodes, allocationMethod, NativeArrayOptions.UninitializedMemory);
  normals = new NativeArray<float4>(numNodes, allocationMethod, NativeArrayOptions.UninitializedMemory);
  connections = new NativeArray<ulong>(numNodes, allocationMethod, NativeArrayOptions.UninitializedMemory);
  penalties = new NativeArray<uint>(numNodes, allocationMethod, NativeArrayOptions.UninitializedMemory);
  walkable = new NativeArray<bool>(numNodes, allocationMethod, NativeArrayOptions.UninitializedMemory);
  walkableWithErosion = new NativeArray<bool>(numNodes, allocationMethod, NativeArrayOptions.UninitializedMemory);
  tags = new NativeArray<int>(numNodes, allocationMethod, NativeArrayOptions.ClearMemory);
 }
}

		[Token(Token = "0x6000D9E")]
		[Address(RVA = "0x44739B8", Offset = "0x446F9B8", VA = "0x44739B8")]
		public void TrackBuffers(JobDependencyTracker dependencyTracker)
		{
 if (positions.IsCreated) dependencyTracker.Track(positions, true);
 if (normals.IsCreated) dependencyTracker.Track(normals, true);
 if (connections.IsCreated) dependencyTracker.Track(connections, true);
 if (penalties.IsCreated) dependencyTracker.Track(penalties, true);
 if (walkable.IsCreated) dependencyTracker.Track(walkable, true);
 if (walkableWithErosion.IsCreated) dependencyTracker.Track(walkableWithErosion, true);
 if (tags.IsCreated) dependencyTracker.Track(tags, true);
}

		[Token(Token = "0x6000D9F")]
		[Address(RVA = "0x4473B94", Offset = "0x446FB94", VA = "0x4473B94")]
		public void PersistBuffers(JobDependencyTracker dependencyTracker)
		{
 dependencyTracker.Persist(positions);
 dependencyTracker.Persist(normals);
 dependencyTracker.Persist(connections);
 dependencyTracker.Persist(penalties);
 dependencyTracker.Persist(walkable);
 dependencyTracker.Persist(walkableWithErosion);
 dependencyTracker.Persist(tags);
}

		[Token(Token = "0x6000DA0")]
		[Address(RVA = "0x4473CC0", Offset = "0x446FCC0", VA = "0x4473CC0")]
		public void Dispose()
		{
 numNodes = 0;
 bounds = default;
 if (positions.IsCreated) positions.Dispose();
 if (normals.IsCreated) normals.Dispose();
 if (connections.IsCreated) connections.Dispose();
 if (penalties.IsCreated) penalties.Dispose();
 if (walkable.IsCreated) walkable.Dispose();
 if (walkableWithErosion.IsCreated) walkableWithErosion.Dispose();
 if (tags.IsCreated) tags.Dispose();
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
 if (layers < layerCount) {
  var previous = this;
  bounds.max.y = layerCount;
  numNodes = bounds.volume;
  AllocateBuffers(dependencyTracker);
  normals.MemSet(float4.zero).Schedule(dependencyTracker);
  walkable.MemSet(false).Schedule(dependencyTracker);
  walkableWithErosion.MemSet(false).Schedule(dependencyTracker);
  new Pathfinding.Graphs.Grid.Jobs.JobCopyBuffers { input = previous, output = this, bounds = previous.bounds, copyPenaltyAndTags = true }.Schedule(dependencyTracker);
 }
 if (layers > layerCount) throw new System.ArgumentException("Cannot reduce the number of layers");
}

		[Token(Token = "0x6000DA3")]
		[Address(RVA = "0x4474514", Offset = "0x4470514", VA = "0x4474514")]
		public void ReadFromNodesForConnectionCalculations(GridNodeBase[] nodes, Slice3D slice, JobHandle nodesDependsOn, NativeArray<float4> graphNodeNormals, JobDependencyTracker dependencyTracker)
		{
 bounds = slice.slice;
 numNodes = bounds.volume;
 positions = new NativeArray<Vector3>(numNodes, allocationMethod, NativeArrayOptions.UninitializedMemory);
 normals = new NativeArray<float4>(numNodes, allocationMethod, NativeArrayOptions.UninitializedMemory);
 connections = new NativeArray<ulong>(numNodes, allocationMethod, NativeArrayOptions.UninitializedMemory);
 walkableWithErosion = new NativeArray<bool>(numNodes, allocationMethod, NativeArrayOptions.UninitializedMemory);
 var reader = new LightReader { nodes = nodes, nodePositions = positions.AsUnsafeSpan(), nodeWalkable = walkableWithErosion.AsUnsafeSpan() };
 GridIterationUtilities.ForEachCellIn3DSlice(slice, ref reader);
 ReadNodeNormals(slice, graphNodeNormals, dependencyTracker);
}

		[Token(Token = "0x6000DA4")]
		[Address(RVA = "0x4474848", Offset = "0x4470848", VA = "0x4474848")]
		private void ReadNodeNormals(Slice3D slice, NativeArray<float4> graphNodeNormals, JobDependencyTracker dependencyTracker)
		{
 if (dependencyTracker != null) {
  normals.MemSet(float4.zero).Schedule(dependencyTracker);
  new JobCopyRectangle<float4> { input = graphNodeNormals, output = normals, inputSlice = slice, outputSlice = new Slice3D(bounds, slice.slice) }.Schedule(dependencyTracker);
 } else {
  normals.AsUnsafeSpan().FillZeros();
  JobCopyRectangle<float4>.Copy(graphNodeNormals, normals, slice, new Slice3D(bounds, slice.slice));
 }
}

		[Token(Token = "0x6000DA5")]
		[Address(RVA = "0x4474B94", Offset = "0x4470B94", VA = "0x4474B94")]
		public static GridGraphNodeData ReadFromNodes(GridNodeBase[] nodes, Slice3D slice, JobHandle nodesDependsOn, NativeArray<float4> graphNodeNormals, Allocator allocator, bool layeredDataLayout, JobDependencyTracker dependencyTracker)
		{
 var data = new GridGraphNodeData { allocationMethod = allocator, numNodes = slice.slice.volume, bounds = slice.slice, layeredDataLayout = layeredDataLayout };
 data.AllocateBuffers(dependencyTracker);
 var handle = System.Runtime.InteropServices.GCHandle.Alloc(nodes);
 var job = new Pathfinding.Graphs.Grid.Jobs.JobReadNodeData { nodesHandle = handle, slice = slice, nodePositions = data.positions, nodePenalties = data.penalties, nodeTags = data.tags, nodeConnections = data.connections, nodeWalkableWithErosion = data.walkableWithErosion, nodeWalkable = data.walkable };
 var dependency = job.ScheduleBatch(data.numNodes, System.Math.Max(2000, data.numNodes / 16), dependencyTracker, nodesDependsOn);
 dependencyTracker.DeferFree(handle, dependency);
 if (graphNodeNormals.IsCreated) data.ReadNodeNormals(slice, graphNodeNormals, dependencyTracker);
 return data;
}

		[Token(Token = "0x6000DA6")]
		[Address(RVA = "0x4474E40", Offset = "0x4470E40", VA = "0x4474E40")]
		public GridGraphNodeData ReadFromNodesAndCopy(GridNodeBase[] nodes, Slice3D slice, JobHandle nodesDependsOn, NativeArray<float4> graphNodeNormals, bool copyPenaltyAndTags, JobDependencyTracker dependencyTracker)
		{
 var result = ReadFromNodes(nodes, slice, nodesDependsOn, graphNodeNormals, allocationMethod, layeredDataLayout, dependencyTracker);
 result.CopyFrom(this, copyPenaltyAndTags, dependencyTracker);
 return result;
}

		[Token(Token = "0x6000DA7")]
		[Address(RVA = "0x4474F28", Offset = "0x4470F28", VA = "0x4474F28")]
		public void CopyFrom(GridGraphNodeData other, bool copyPenaltyAndTags, JobDependencyTracker dependencyTracker)
		{ CopyFrom(other, IntBounds.Intersection(bounds, other.bounds), copyPenaltyAndTags, dependencyTracker); }

		[Token(Token = "0x6000DA8")]
		[Address(RVA = "0x4474FD8", Offset = "0x4470FD8", VA = "0x4474FD8")]
		public void CopyFrom(GridGraphNodeData other, IntBounds bounds, bool copyPenaltyAndTags, JobDependencyTracker dependencyTracker)
		{
 var job = new Pathfinding.Graphs.Grid.Jobs.JobCopyBuffers { input = other, output = this, bounds = bounds, copyPenaltyAndTags = copyPenaltyAndTags };
 if (dependencyTracker != null) job.Schedule(dependencyTracker);
 else Unity.Jobs.IJobExtensions.RunByRef(ref job);
}

		[Token(Token = "0x6000DA9")]
		[Address(RVA = "0x44750E8", Offset = "0x44710E8", VA = "0x44750E8")]
		public JobHandle AssignToNodes(GridNodeBase[] nodes, int3 nodeArrayBounds, IntBounds writeMask, uint graphIndex, JobHandle nodesDependsOn, JobDependencyTracker dependencyTracker)
		{
 var handle=System.Runtime.InteropServices.GCHandle.Alloc(nodes);
 var job=new Pathfinding.Graphs.Grid.Jobs.JobWriteNodeData { nodesHandle=handle,graphIndex=graphIndex,nodeArrayBounds=nodeArrayBounds,dataBounds=bounds,writeMask=writeMask,nodePositions=positions,nodePenalties=penalties,nodeTags=tags,nodeConnections=connections,nodeWalkableWithErosion=walkableWithErosion,nodeWalkable=walkable };
 var dependency=job.ScheduleBatch(writeMask.volume,System.Math.Max(1000,writeMask.volume/16),dependencyTracker,nodesDependsOn);
 dependencyTracker.DeferFree(handle,dependency);
 return dependency;
}
	}
}
