using Il2CppDummyDll;
using Pathfinding.Collections;
using Pathfinding.Jobs;
using Unity.Burst;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;

namespace Pathfinding.Graphs.Grid.Jobs
{
	[Token(Token = "0x2000225")]
	[BurstCompile(FloatMode = FloatMode.Fast, CompileSynchronously = true)]
	public struct JobCalculateGridConnections : IJobParallelForBatched
	{
		[Token(Token = "0x4000A22")]
		[FieldOffset(Offset = "0x0")]
		public float maxStepHeight;

		[Token(Token = "0x4000A23")]
		[FieldOffset(Offset = "0x4")]
		public float4x4 graphToWorld;

		[Token(Token = "0x4000A24")]
		[FieldOffset(Offset = "0x44")]
		public IntBounds bounds;

		[Token(Token = "0x4000A25")]
		[FieldOffset(Offset = "0x5C")]
		public int3 arrayBounds;

		[Token(Token = "0x4000A26")]
		[FieldOffset(Offset = "0x68")]
		public NumNeighbours neighbours;

		[Token(Token = "0x4000A27")]
		[FieldOffset(Offset = "0x6C")]
		public float characterHeight;

		[Token(Token = "0x4000A28")]
		[FieldOffset(Offset = "0x70")]
		public bool use2D;

		[Token(Token = "0x4000A29")]
		[FieldOffset(Offset = "0x71")]
		public bool cutCorners;

		[Token(Token = "0x4000A2A")]
		[FieldOffset(Offset = "0x72")]
		public bool maxStepUsesSlope;

		[Token(Token = "0x4000A2B")]
		[FieldOffset(Offset = "0x73")]
		public bool layeredDataLayout;

		[Token(Token = "0x4000A2C")]
		[FieldOffset(Offset = "0x78")]
		[ReadOnly]
		public UnsafeSpan<bool> nodeWalkable;

		[Token(Token = "0x4000A2D")]
		[FieldOffset(Offset = "0x88")]
		[ReadOnly]
		public UnsafeSpan<float4> nodeNormals;

		[Token(Token = "0x4000A2E")]
		[FieldOffset(Offset = "0x98")]
		[ReadOnly]
		public UnsafeSpan<Vector3> nodePositions;

		[Token(Token = "0x4000A2F")]
		[FieldOffset(Offset = "0xA8")]
		[WriteOnly]
		public UnsafeSpan<ulong> nodeConnections;

		[Token(Token = "0x1700021E")]
		public bool allowBoundsChecks
		{
			[Token(Token = "0x6000DFF")]
			[Address(RVA = "0x447A364", Offset = "0x4476364", VA = "0x447A364", Slot = "4")]
			get
			{ return false; }
		}

		[Token(Token = "0x6000E00")]
		[Address(RVA = "0x447A36C", Offset = "0x447636C", VA = "0x447A36C")]
		public static bool IsValidConnection(float y, float y2, float maxStepHeight)
		{ return math.abs(y-y2)<=maxStepHeight; }

		[Token(Token = "0x6000E01")]
		[Address(RVA = "0x447A37C", Offset = "0x447637C", VA = "0x447A37C")]
		public static bool IsValidConnection(float2 yRange, float2 yRange2, float maxStepHeight, float characterHeight)
		{
 if (!IsValidConnection(yRange.x,yRange2.x,maxStepHeight)) return false;
 float bottom=(!float.IsNaN(yRange2.x) && yRange.x<=yRange2.x) ? yRange2.x : yRange.x;
 float top=(float.IsNaN(yRange2.y) || yRange.y<yRange2.y) ? yRange.y : yRange2.y;
 return top-bottom>=characterHeight;
}

		[Token(Token = "0x6000E02")]
		[Address(RVA = "0x447A404", Offset = "0x4476404", VA = "0x447A404")]
		private static float ConnectionY(UnsafeSpan<float3> nodePositions, UnsafeSpan<float4> nodeNormals, NativeArray<float4> normalToHeightOffset, int nodeIndex, int dir, float4 up, bool reverse)
		{
 var p=nodePositions[nodeIndex]; var n=nodeNormals[nodeIndex]; var o=normalToHeightOffset[dir];
 float baseHeight=up.w*0f+(up.z*p.z+(up.x*p.x+up.y*p.y));
 float offset=n.w*o.w+(n.z*o.z+(n.x*o.x+n.y*o.y));
 if (reverse) offset=-offset;
 return baseHeight+offset;
}

		[Token(Token = "0x6000E03")]
		[Address(RVA = "0x447A5F0", Offset = "0x44765F0", VA = "0x447A5F0")]
		private static float2 ConnectionYRange(UnsafeSpan<float3> nodePositions, UnsafeSpan<float4> nodeNormals, NativeArray<float4> normalToHeightOffset, int nodeIndex, int layerStride, int y, int maxY, int dir, float4 up, bool reverse)
		{
 float bottom=ConnectionY(nodePositions,nodeNormals,normalToHeightOffset,nodeIndex,dir,up,reverse);
 uint above=unchecked((uint)(layerStride+nodeIndex));
 float top=above>=(uint)nodeNormals.Length || math.all(nodeNormals[above]==default(float4))
  ? float.PositiveInfinity : ConnectionY(nodePositions,nodeNormals,normalToHeightOffset,unchecked((int)above),dir,up,reverse);
 return new float2(bottom,top);
}

		[Token(Token = "0x6000E04")]
		[Address(RVA = "0x447A78C", Offset = "0x447678C", VA = "0x447A78C")]
		private static NativeArray<float4> HeightOffsetProjections(float4x4 graphToWorldTranform, bool maxStepUsesSlope)
		{
 var result=new NativeArray<float4>(8,Allocator.Temp,NativeArrayOptions.ClearMemory);
 if (maxStepUsesSlope) for (int i=0;i<result.Length;i++) {
  float x=GridGraph.neighbourXOffsets[i],z=GridGraph.neighbourZOffsets[i];
  result[i]=new float4((graphToWorldTranform.c0.x*x+graphToWorldTranform.c2.x*z)*-0.5f,
   (graphToWorldTranform.c0.y*x+graphToWorldTranform.c2.y*z)*-0.5f,
   (graphToWorldTranform.c0.z*x+graphToWorldTranform.c2.z*z)*-0.5f,-0f);
 }
 return result;
}

		[Token(Token = "0x6000E05")]
		[Address(RVA = "0x447A8F8", Offset = "0x44768F8", VA = "0x447A8F8", Slot = "5")]
		public void Execute(int start, int count)
		{
 if (nodePositions.Length!=nodeNormals.Length) throw new System.Exception("nodePositions and nodeNormals must have the same length");
 if (nodePositions.Length!=nodeWalkable.Length) throw new System.Exception("nodePositions and nodeWalkable must have the same length");
 if (nodePositions.Length!=nodeConnections.Length) throw new System.Exception("nodePositions and nodeConnections must have the same length");
 if (layeredDataLayout) ExecuteLayered(start,count); else ExecuteFlat(start,count);
}

		[Token(Token = "0x6000E06")]
		[Address(RVA = "0x447AF20", Offset = "0x4476F20", VA = "0x447AF20")]
		public void ExecuteFlat(int start, int count)
		{
 if (maxStepHeight<=0f || use2D) maxStepHeight=float.PositiveInfinity;
 var up=graphToWorld.c1;
 var offsets=new NativeArray<int>(8,Allocator.Temp,NativeArrayOptions.UninitializedMemory);
 for (int d=0;d<8;d++) offsets[d]=unchecked(GridGraph.neighbourXOffsets[d]+arrayBounds.x*GridGraph.neighbourZOffsets[d]);
 var positions=nodePositions.Reinterpret<float3>();
 var projections=HeightOffsetProjections(graphToWorld,maxStepUsesSlope);
 int end=unchecked(bounds.min.z+start+count);
 for (int z=unchecked(bounds.min.z+start);z<end;z++) {
  int mask=z==0?0x6e:0xff;
  if (z==unchecked(arrayBounds.z-1)) mask&=0x9b;
  for (int x=bounds.min.x;x<bounds.max.x;x++) {
   int index=unchecked(x+arrayBounds.x*z);
   if (!nodeWalkable[index]) { nodeConnections[index]=0; continue; }
   int connections=x==0?mask&0x37:mask;
   if (x==unchecked(arrayBounds.x-1)) connections&=0xcd;
   for (int d=0;d<8;d++) {
    float y=ConnectionY(positions,nodeNormals,projections,index,d,up,false);
    if ((connections&(1<<d))!=0) {
     int neighbour=unchecked(index+offsets[d]);
     float otherY=ConnectionY(positions,nodeNormals,projections,neighbour,d,up,true);
     if (!nodeWalkable[neighbour] || !IsValidConnection(y,otherY,maxStepHeight)) connections&=~(1<<d);
    }
   }
   nodeConnections[index]=unchecked((ulong)GridNode.FilterDiagonalConnections(connections,neighbours,cutCorners));
  }
 }
}

		[Token(Token = "0x6000E07")]
		[Address(RVA = "0x447AA44", Offset = "0x4476A44", VA = "0x447AA44")]
		public void ExecuteLayered(int start, int count)
		{
 if (maxStepHeight<=0f || use2D) maxStepHeight=float.PositiveInfinity;
 var up=graphToWorld.c1;
 var offsets=new NativeArray<int>(8,Allocator.Temp,NativeArrayOptions.UninitializedMemory);
 for (int d=0;d<8;d++) offsets[d]=unchecked(GridGraph.neighbourXOffsets[d]+arrayBounds.x*GridGraph.neighbourZOffsets[d]);
 var positions=nodePositions.Reinterpret<float3>();
 var projections=HeightOffsetProjections(graphToWorld,maxStepUsesSlope);
 int layerStride=unchecked(arrayBounds.x*arrayBounds.z);
 for (int layer=bounds.min.y;layer<bounds.max.y;layer++)
  for (int z=unchecked(bounds.min.z+start);z<unchecked(bounds.min.z+start+count);z++)
   for (int x=bounds.min.x;x<bounds.max.x;x++) {
    int flatIndex=unchecked(x+arrayBounds.x*z), index=unchecked(flatIndex+layer*layerStride);
    ulong connections=0xffffffffUL;
    if (nodeWalkable[index]) {
     connections=0;
     for (int d=0;d<8;d++) {
      int nx=unchecked(x+GridGraph.neighbourXOffsets[d]), nz=unchecked(z+GridGraph.neighbourZOffsets[d]);
      int found=15;
      if ((nx|nz)>=0 && nx<arrayBounds.x && nz<arrayBounds.z) {
       var range=ConnectionYRange(positions,nodeNormals,projections,index,layerStride,layer,arrayBounds.y,d,up,false);
       int neighbour=unchecked(flatIndex+offsets[d]);
       for (int targetLayer=0;targetLayer<arrayBounds.y;targetLayer++,neighbour=unchecked(neighbour+layerStride)) {
        if (nodeWalkable[neighbour]) {
         var other=ConnectionYRange(positions,nodeNormals,projections,neighbour,layerStride,targetLayer,arrayBounds.y,d,up,true);
         if (IsValidConnection(range,other,maxStepHeight,characterHeight)) { found=targetLayer; break; }
        }
       }
      }
      connections|=unchecked((ulong)(long)found)<<(4*d);
     }
    }
    nodeConnections[index]=connections;
   }
}
	}
}
