using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;

namespace Pathfinding.Graphs.Grid.Jobs
{
	[Token(Token = "0x2000229")]
	[BurstCompile]
	public struct JobErosion<AdjacencyMapper> : IJob where AdjacencyMapper : GridAdjacencyMapper, new()
	{
		[Token(Token = "0x4000A3A")]
		[FieldOffset(Offset = "0x0")]
		public IntBounds bounds;

		[Token(Token = "0x4000A3B")]
		[FieldOffset(Offset = "0x0")]
		public IntBounds writeMask;

		[Token(Token = "0x4000A3C")]
		[FieldOffset(Offset = "0x0")]
		public NumNeighbours neighbours;

		[Token(Token = "0x4000A3D")]
		[FieldOffset(Offset = "0x0")]
		public int erosion;

		[Token(Token = "0x4000A3E")]
		[FieldOffset(Offset = "0x0")]
		public bool erosionUsesTags;

		[Token(Token = "0x4000A3F")]
		[FieldOffset(Offset = "0x0")]
		public int erosionStartTag;

		[Token(Token = "0x4000A40")]
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public NativeArray<ulong> nodeConnections;

		[Token(Token = "0x4000A41")]
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public NativeArray<bool> nodeWalkable;

		[Token(Token = "0x4000A42")]
		[FieldOffset(Offset = "0x0")]
		[WriteOnly]
		public NativeArray<bool> outNodeWalkable;

		[Token(Token = "0x4000A43")]
		[FieldOffset(Offset = "0x0")]
		public NativeArray<int> nodeTags;

		[Token(Token = "0x4000A44")]
		[FieldOffset(Offset = "0x0")]
		public int erosionTagsPrecedenceMask;

		[Token(Token = "0x4000A45")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int[] hexagonNeighbourIndices=new int[]{1,2,5,0,3,7};

		[Token(Token = "0x6000E0C")]
		public void Execute()
		{
 var slice=new Pathfinding.Jobs.Slice3D(bounds,bounds);
 slice.AssertMatchesOuter(nodeConnections);
 slice.AssertMatchesOuter(nodeWalkable);
 slice.AssertMatchesOuter(outNodeWalkable);
 slice.AssertMatchesOuter(nodeTags);
 var size=slice.slice.size;
 var outer=slice.outerStrides;
 var inner=slice.innerStrides;
 var offsets=new NativeArray<int>(8,Allocator.Temp,NativeArrayOptions.UninitializedMemory);
 for (int d=0;d<8;d++) offsets[d]=unchecked(GridGraph.neighbourXOffsets[d]*inner.Item1+GridGraph.neighbourZOffsets[d]*inner.Item3);
 var distances=new NativeArray<int>(slice.length,Allocator.Temp,NativeArrayOptions.ClearMemory);
 var mapper=new AdjacencyMapper();
 int layers=mapper.LayerCount(slice.slice);
 int outerStart=slice.outerStartIndex;
 for (int z=1;z<unchecked(size.z-1);z++)
  for (int x=1;x<unchecked(size.x-1);x++)
   for (int y=0;y<layers;y++) {
    int nodeIndexXZ=unchecked(x*inner.Item1+z*inner.Item3);
    int index=unchecked(nodeIndexXZ+y*inner.Item2);
    int outerIndex=unchecked(outerStart+x*outer.Item1+z*outer.Item3+y*outer.Item2);
    int distance=int.MaxValue;
    if (neighbours==NumNeighbours.Six) {
     for (int directionIndex=3;directionIndex<6;directionIndex++) {
      int direction=hexagonNeighbourIndices[directionIndex];
      if (mapper.HasConnection(outerIndex,direction,nodeConnections)) {
       int neighbour=mapper.GetNeighbourIndex(nodeIndexXZ,index,direction,nodeConnections,offsets,inner.Item2);
       distance=Unity.Mathematics.math.min(distance,distances[neighbour]);
      } else distance=-1;
     }
    } else {
     int north=mapper.HasConnection(outerIndex,0,nodeConnections)?distances[mapper.GetNeighbourIndex(nodeIndexXZ,index,0,nodeConnections,offsets,inner.Item2)]:-1;
     int west=mapper.HasConnection(outerIndex,3,nodeConnections)?distances[mapper.GetNeighbourIndex(nodeIndexXZ,index,3,nodeConnections,offsets,inner.Item2)]:-1;
     distance=Unity.Mathematics.math.min(north,west);
    }
    distances[index]=unchecked(distance+1);
   }
 for (int z=unchecked(size.z-2);z>=1;z--)
  for (int x=unchecked(size.x-2);x>=1;x--)
   for (int y=0;y<layers;y++) {
    int nodeIndexXZ=unchecked(x*inner.Item1+z*inner.Item3);
    int index=unchecked(nodeIndexXZ+y*inner.Item2);
    int outerIndex=unchecked(outerStart+x*outer.Item1+z*outer.Item3+y*outer.Item2);
    int distance=int.MaxValue;
    if (neighbours==NumNeighbours.Six) {
     for (int directionIndex=3;directionIndex<6;directionIndex++) {
      int direction=hexagonNeighbourIndices[directionIndex];
      if (mapper.HasConnection(outerIndex,direction,nodeConnections)) {
       int neighbour=mapper.GetNeighbourIndex(nodeIndexXZ,index,direction,nodeConnections,offsets,inner.Item2);
       distance=Unity.Mathematics.math.min(distance,distances[neighbour]);
      } else distance=-1;
     }
    } else {
     int south=mapper.HasConnection(outerIndex,2,nodeConnections)?distances[mapper.GetNeighbourIndex(nodeIndexXZ,index,2,nodeConnections,offsets,inner.Item2)]:-1;
     int east=mapper.HasConnection(outerIndex,1,nodeConnections)?distances[mapper.GetNeighbourIndex(nodeIndexXZ,index,1,nodeConnections,offsets,inner.Item2)]:-1;
     distance=Unity.Mathematics.math.min(south,east);
    }
    distances[index]=Unity.Mathematics.math.min(distances[outerIndex],unchecked(distance+1));
   }
 var mask=writeMask.Offset(-bounds.min);
 int tagEnd=unchecked(erosionStartTag+erosion);
 for (int tag=erosionStartTag;tag<tagEnd;tag++) erosionTagsPrecedenceMask=erosionTagsPrecedenceMask | (1 << tag);
 for (int y=mask.min.y;y<mask.max.y;y++)
  for (int z=mask.min.z;z<mask.max.z;z++)
   for (int x=mask.min.x;x<mask.max.x;x++) {
    int index=unchecked(x*inner.Item1+y*inner.Item2+z*inner.Item3);
    int outerIndex=unchecked(outerStart+x*outer.Item1+y*outer.Item2+z*outer.Item3);
    int distance=distances[index];
    if (erosionUsesTags) {
     int oldTag=nodeTags[outerIndex];
     outNodeWalkable[outerIndex]=nodeWalkable[outerIndex];
     if (distance>=erosion) {
      if (oldTag>=erosionStartTag&&oldTag<tagEnd) nodeTags[outerIndex]=0;
     } else if (((erosionTagsPrecedenceMask>>oldTag)&1)!=0) {
      nodeTags[outerIndex]=nodeWalkable[outerIndex]?Unity.Mathematics.math.min(unchecked(erosionStartTag+distance),31):0;
     }
    } else outNodeWalkable[outerIndex]=nodeWalkable[outerIndex] & (distance>=erosion);
   }
}
	}
}
