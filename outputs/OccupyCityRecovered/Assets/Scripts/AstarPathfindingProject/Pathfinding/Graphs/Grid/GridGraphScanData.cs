using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Pathfinding.Jobs;
using Pathfinding.Util;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

namespace Pathfinding.Graphs.Grid
{
	[Token(Token = "0x2000208")]
	public struct GridGraphScanData
	{
		[Token(Token = "0x40009C0")]
		[FieldOffset(Offset = "0x0")]
		public JobDependencyTracker dependencyTracker;

		[Token(Token = "0x40009C1")]
		[FieldOffset(Offset = "0x8")]
		public Vector3 up;

		[Token(Token = "0x40009C2")]
		[FieldOffset(Offset = "0x18")]
		public GraphTransform transform;

		[Token(Token = "0x40009C3")]
		[FieldOffset(Offset = "0x20")]
		public GridGraphNodeData nodes;

		[Token(Token = "0x40009C4")]
		[FieldOffset(Offset = "0xB8")]
		public NativeArray<RaycastHit> heightHits;

		[Token(Token = "0x40009C5")]
		[FieldOffset(Offset = "0xC8")]
		public IntBounds heightHitsBounds;

		[Token(Token = "0x17000210")]
		[Obsolete("Use nodes.bounds or heightHitsBounds depending on if you are using the heightHits array or not")]
		public IntBounds bounds
		{
			[Token(Token = "0x6000DAB")]
			[Address(RVA = "0x44754FC", Offset = "0x44714FC", VA = "0x44754FC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000211")]
		[Obsolete("Use nodes.layeredDataLayout instead")]
		public bool layeredDataLayout
		{
			[Token(Token = "0x6000DAC")]
			[Address(RVA = "0x4475510", Offset = "0x4471510", VA = "0x4475510")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000212")]
		[Obsolete("Use nodes.positions instead")]
		public NativeArray<Vector3> nodePositions
		{
			[Token(Token = "0x6000DAD")]
			[Address(RVA = "0x4475518", Offset = "0x4471518", VA = "0x4475518")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000213")]
		[Obsolete("Use nodes.connections instead")]
		public NativeArray<ulong> nodeConnections
		{
			[Token(Token = "0x6000DAE")]
			[Address(RVA = "0x4475524", Offset = "0x4471524", VA = "0x4475524")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000214")]
		[Obsolete("Use nodes.penalties instead")]
		public NativeArray<uint> nodePenalties
		{
			[Token(Token = "0x6000DAF")]
			[Address(RVA = "0x4475530", Offset = "0x4471530", VA = "0x4475530")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000215")]
		[Obsolete("Use nodes.tags instead")]
		public NativeArray<int> nodeTags
		{
			[Token(Token = "0x6000DB0")]
			[Address(RVA = "0x447553C", Offset = "0x447153C", VA = "0x447553C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000216")]
		[Obsolete("Use nodes.normals instead")]
		public NativeArray<float4> nodeNormals
		{
			[Token(Token = "0x6000DB1")]
			[Address(RVA = "0x4475548", Offset = "0x4471548", VA = "0x4475548")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000217")]
		[Obsolete("Use nodes.walkable instead")]
		public NativeArray<bool> nodeWalkable
		{
			[Token(Token = "0x6000DB2")]
			[Address(RVA = "0x4475554", Offset = "0x4471554", VA = "0x4475554")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000218")]
		[Obsolete("Use nodes.walkableWithErosion instead")]
		public NativeArray<bool> nodeWalkableWithErosion
		{
			[Token(Token = "0x6000DB3")]
			[Address(RVA = "0x4475560", Offset = "0x4471560", VA = "0x4475560")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000DB4")]
		[Address(RVA = "0x447556C", Offset = "0x447156C", VA = "0x447556C")]
		public void SetDefaultPenalties(uint initialPenalty)
		{ nodes.penalties.MemSet(initialPenalty).Schedule(dependencyTracker); }

		[Token(Token = "0x6000DB5")]
		[Address(RVA = "0x4475610", Offset = "0x4471610", VA = "0x4475610")]
		public void SetDefaultNodePositions(GraphTransform transform)
		{
 new Pathfinding.Graphs.Grid.Jobs.JobNodeGridLayout { graphToWorld=transform.matrix, bounds=nodes.bounds, nodePositions=nodes.positions }.Schedule(dependencyTracker);
}

		[Token(Token = "0x6000DB6")]
		[Address(RVA = "0x44756BC", Offset = "0x44716BC", VA = "0x44756BC")]
		public JobHandle HeightCheck(GraphCollision collision, float nodeWidth, int maxHits, IntBounds recalculationBounds, NativeArray<int> outLayerCount, float characterHeight, Allocator allocator)
		{
 var size=recalculationBounds.size;
 int count=unchecked(size.x*size.z);
 heightHits=dependencyTracker.NewNativeArray<RaycastHit>(unchecked(count*maxHits),allocator,NativeArrayOptions.ClearMemory);
 heightHitsBounds=recalculationBounds;
 Vector3 offset=up*collision.fromHeight;
 Vector3 direction=-up*(collision.fromHeight+0.01f);
 if (collision.thickRaycast) {
  if (maxHits>1) throw new NotImplementedException("Thick raycasts are not supported for layered grid graphs");
  var commands=dependencyTracker.NewNativeArray<SpherecastCommand>(count,allocator,NativeArrayOptions.ClearMemory);
  new Pathfinding.Graphs.Grid.Jobs.JobPrepareGridRaycastThick { graphToWorld=transform.matrix,bounds=recalculationBounds,raycastOffset=offset,raycastDirection=direction,raycastMask=collision.heightMask,physicsScene=Physics.defaultPhysicsScene,radius=(collision.thickRaycastDiameter*nodeWidth)*0.5f,raycastCommands=commands }.Schedule(dependencyTracker);
  dependencyTracker.ScheduleBatch(commands,heightHits,2048);
  new JobClampHitToRay { commands=commands,hits=heightHits }.Schedule(dependencyTracker);
  outLayerCount[0]=1;
  return default(JobHandle);
 } else {
  var commands=dependencyTracker.NewNativeArray<RaycastCommand>(count,allocator,NativeArrayOptions.ClearMemory);
  var dependency=new Pathfinding.Graphs.Grid.Jobs.JobPrepareGridRaycast { graphToWorld=transform.matrix,bounds=recalculationBounds,raycastOffset=offset,raycastDirection=direction,raycastMask=collision.heightMask,physicsScene=Physics.defaultPhysicsScene,raycastCommands=commands }.Schedule(dependencyTracker);
  if (maxHits>1) {
   dependency=new JobRaycastAll(commands,heightHits,Physics.defaultPhysicsScene,maxHits,allocator,dependencyTracker,characterHeight*0.5f).Schedule(dependency);
   return new JobMaxHitCount { hits=heightHits,maxHits=maxHits,layerStride=count,maxHitCount=outLayerCount }.Schedule(dependency);
  }
  dependencyTracker.ScheduleBatch(commands,heightHits,2048);
  outLayerCount[0]=1;
  return default(JobHandle);
 }
}

		[Token(Token = "0x6000DB7")]
		[Address(RVA = "0x4475BF0", Offset = "0x4471BF0", VA = "0x4475BF0")]
		public void CopyHits(IntBounds recalculationBounds)
		{
 nodes.normals.MemSet(float4.zero).Schedule(dependencyTracker);
 new JobCopyHits { hits=heightHits,points=nodes.positions,normals=nodes.normals,slice=new Slice3D(nodes.bounds,recalculationBounds) }.Schedule(dependencyTracker);
}

		[Token(Token = "0x6000DB8")]
		[Address(RVA = "0x4475D64", Offset = "0x4471D64", VA = "0x4475D64")]
		public void CalculateWalkabilityFromHeightData(bool useRaycastNormal, bool unwalkableWhenNoGround, float maxSlope, float characterHeight)
		{
 var size=nodes.bounds.size;
 new Pathfinding.Graphs.Grid.Jobs.JobNodeWalkability { useRaycastNormal=useRaycastNormal, maxSlope=maxSlope, up=up, unwalkableWhenNoGround=unwalkableWhenNoGround, characterHeight=characterHeight, layerStride=unchecked(size.x*size.z), nodePositions=nodes.positions.Reinterpret<float3>(), nodeNormals=nodes.normals, nodeWalkable=nodes.walkable }.Schedule(dependencyTracker);
}

		[Token(Token = "0x6000DB9")]
		[Address(RVA = "0x4475E9C", Offset = "0x4471E9C", VA = "0x4475E9C")]
		public IEnumerator<JobHandle> CollisionCheck(GraphCollision collision, IntBounds calculationBounds)
		{
 if (collision.type==ColliderType.Ray && !collision.use2D) {
  var collisionResult=dependencyTracker.NewNativeArray<bool>(nodes.numNodes,nodes.allocationMethod,NativeArrayOptions.UninitializedMemory);
  collision.JobCollisionRay(nodes.positions,collisionResult,up,nodes.allocationMethod,dependencyTracker);
  nodes.walkable.BitwiseAndWith(collisionResult).WithLength(nodes.numNodes).Schedule(dependencyTracker);
  return null;
 }
 return new Pathfinding.Graphs.Grid.Jobs.JobCheckCollisions { nodePositions=nodes.positions,collisionResult=nodes.walkable,collision=collision }.ExecuteMainThreadJob(dependencyTracker);
}

		[Token(Token = "0x6000DBA")]
		[Address(RVA = "0x4475FF4", Offset = "0x4471FF4", VA = "0x4475FF4")]
		public void Connections(float maxStepHeight, bool maxStepUsesSlope, IntBounds calculationBounds, NumNeighbours neighbours, bool cutCorners, bool use2D, bool useErodedWalkability, float characterHeight)
		{
 var job=new Pathfinding.Graphs.Grid.Jobs.JobCalculateGridConnections {
  maxStepHeight=maxStepHeight,
  graphToWorld=transform.matrix,
  bounds=calculationBounds.Offset(-nodes.bounds.min),
  arrayBounds=nodes.bounds.size,
  neighbours=neighbours,
  characterHeight=characterHeight,
  use2D=use2D,
  cutCorners=cutCorners,
  maxStepUsesSlope=maxStepUsesSlope,
  layeredDataLayout=nodes.layeredDataLayout,
  nodeWalkable=Pathfinding.Collections.SpanExtensions.AsUnsafeReadOnlySpan(useErodedWalkability?nodes.walkableWithErosion:nodes.walkable),
  nodePositions=Pathfinding.Collections.SpanExtensions.AsUnsafeReadOnlySpan(nodes.positions),
  nodeNormals=Pathfinding.Collections.SpanExtensions.AsUnsafeReadOnlySpan(nodes.normals),
  nodeConnections=Pathfinding.Collections.SpanExtensions.AsUnsafeSpan(nodes.connections)
 };
 if (dependencyTracker!=null) Pathfinding.Jobs.IJobExtensions.ScheduleBatch(job,calculationBounds.size.z,20,dependencyTracker);
 else Pathfinding.Jobs.JobParallelForBatchedExtensions.RunBatch(job,calculationBounds.size.z);
 if (nodes.layeredDataLayout) {
  var filter=new Pathfinding.Graphs.Grid.Jobs.JobFilterDiagonalConnections {
   slice=new Pathfinding.Jobs.Slice3D(nodes.bounds,calculationBounds),
   neighbours=neighbours,
   cutCorners=cutCorners,
   nodeConnections=Pathfinding.Collections.SpanExtensions.AsUnsafeSpan(nodes.connections)
  };
  if (dependencyTracker!=null) Pathfinding.Jobs.IJobExtensions.ScheduleBatch(filter,calculationBounds.size.z,20,dependencyTracker);
  else Pathfinding.Jobs.JobParallelForBatchedExtensions.RunBatch(filter,calculationBounds.size.z);
 }
}

		[Token(Token = "0x6000DBB")]
		[Address(RVA = "0x44766CC", Offset = "0x44726CC", VA = "0x44766CC")]
		public void Erosion(NumNeighbours neighbours, int erodeIterations, IntBounds erosionWriteMask, bool erosionUsesTags, int erosionStartTag, int erosionTagsPrecedenceMask)
		{
 if (nodes.layeredDataLayout) {
  var job=new Pathfinding.Graphs.Grid.Jobs.JobErosion<LayeredGridAdjacencyMapper> {
   bounds=nodes.bounds,writeMask=erosionWriteMask,neighbours=neighbours,erosion=erodeIterations,
   erosionUsesTags=erosionUsesTags,erosionStartTag=erosionStartTag,erosionTagsPrecedenceMask=erosionTagsPrecedenceMask,
   nodeConnections=nodes.connections,nodeWalkable=nodes.walkable,outNodeWalkable=nodes.walkableWithErosion,nodeTags=nodes.tags
  };
  Pathfinding.Jobs.IJobExtensions.Schedule(job,dependencyTracker);
 } else {
  var job=new Pathfinding.Graphs.Grid.Jobs.JobErosion<FlatGridAdjacencyMapper> {
   bounds=nodes.bounds,writeMask=erosionWriteMask,neighbours=neighbours,erosion=erodeIterations,
   erosionUsesTags=erosionUsesTags,erosionStartTag=erosionStartTag,erosionTagsPrecedenceMask=erosionTagsPrecedenceMask,
   nodeConnections=nodes.connections,nodeWalkable=nodes.walkable,outNodeWalkable=nodes.walkableWithErosion,nodeTags=nodes.tags
  };
  Pathfinding.Jobs.IJobExtensions.Schedule(job,dependencyTracker);
 }
}

		[Token(Token = "0x6000DBC")]
		[Address(RVA = "0x4476848", Offset = "0x4472848", VA = "0x4476848")]
		public void AssignNodeConnections(GridNodeBase[] nodes, int3 nodeArrayBounds, IntBounds writeBounds)
		{
 var dataBounds=this.nodes.bounds; var dataSize=dataBounds.size; var size=writeBounds.size;
 var connections=Pathfinding.Collections.SpanExtensions.AsUnsafeReadOnlySpan(this.nodes.connections);
 int localX=unchecked(writeBounds.min.x-dataBounds.min.x);
 int localY=unchecked(writeBounds.min.y-dataBounds.min.y);
 int localZ=unchecked(writeBounds.min.z-dataBounds.min.z);
 for (int y=0;y<size.y;y++)
  for (int z=0;z<size.z;z++) {
   int dataIndex=unchecked(localX+unchecked(localY+y)*unchecked(dataSize.x*dataSize.z)+unchecked(localZ+z)*dataSize.x);
   int nodeIndex=unchecked(writeBounds.min.x+nodeArrayBounds.x*unchecked(writeBounds.min.z+z+nodeArrayBounds.z*unchecked(writeBounds.min.y+y)));
   for (int x=0;x<size.x;x++) {
    var node=nodes[nodeIndex+x];
    ref ulong value=ref connections[unchecked((uint)(dataIndex+x))];
    if (node==null) continue;
    if (node is LevelGridNode layered) layered.SetAllConnectionInternal(value);
    else (node as GridNode).SetAllConnectionInternal(unchecked((int)value));
   }
  }
}
	}
}
