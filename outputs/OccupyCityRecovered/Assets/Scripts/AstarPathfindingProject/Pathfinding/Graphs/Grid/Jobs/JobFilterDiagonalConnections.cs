using Il2CppDummyDll;
using Pathfinding.Collections;
using Pathfinding.Jobs;
using Unity.Burst;

namespace Pathfinding.Graphs.Grid.Jobs
{
	[Token(Token = "0x200022A")]
	[BurstCompile]
	public struct JobFilterDiagonalConnections : IJobParallelForBatched
	{
		[Token(Token = "0x4000A46")]
		[FieldOffset(Offset = "0x0")]
		public Slice3D slice;

		[Token(Token = "0x4000A47")]
		[FieldOffset(Offset = "0x24")]
		public NumNeighbours neighbours;

		[Token(Token = "0x4000A48")]
		[FieldOffset(Offset = "0x28")]
		public bool cutCorners;

		[Token(Token = "0x4000A49")]
		[FieldOffset(Offset = "0x30")]
		public UnsafeSpan<ulong> nodeConnections;

		[Token(Token = "0x1700021F")]
		public bool allowBoundsChecks
		{
			[Token(Token = "0x6000E0E")]
			[Address(RVA = "0x447B7E8", Offset = "0x44777E8", VA = "0x447B7E8", Slot = "4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000E0F")]
		[Address(RVA = "0x447B7F0", Offset = "0x44777F0", VA = "0x447B7F0", Slot = "5")]
		public void Execute(int start, int count)
		{
 slice.AssertMatchesOuter(nodeConnections);
 var outerSize=slice.outerSize;
 var offsets=new Unity.Collections.NativeArray<int>(8,Unity.Collections.Allocator.Temp,Unity.Collections.NativeArrayOptions.UninitializedMemory);
 for (int d=0;d<8;d++) offsets[d]=unchecked(GridGraph.neighbourXOffsets[d]+outerSize.x*GridGraph.neighbourZOffsets[d]);
 ulong hexMask=0;
 foreach (int d in GridGraph.hexagonNeighbourIndices) hexMask|=15UL<<unchecked(4*d);
 int required=cutCorners ? 1 : 2;
 int layerStride=unchecked(outerSize.x*outerSize.z);
 int endZ=unchecked(slice.slice.min.z+start+count);
 for (int y=slice.slice.min.y;y<slice.slice.max.y;y++)
  for (int z=unchecked(slice.slice.min.z+start);z<endZ;z++)
   for (int x=slice.slice.min.x;x<slice.slice.max.x;x++) {
    int flatIndex=unchecked(x+outerSize.x*z);
    int index=unchecked(flatIndex+y*layerStride);
    if (neighbours==NumNeighbours.Six) {
     nodeConnections[index]=(uint)nodeConnections[index] | (ulong)(uint)~(uint)hexMask;
    } else if (neighbours==NumNeighbours.Four) {
     nodeConnections[index]|=0xffff0000UL;
    } else if (neighbours==NumNeighbours.Eight) {
     ulong connections=nodeConnections[index];
     if (connections==0xffffffffUL) continue;
     for (int d=0;d<4;d++) {
      int diagonal=(int)((connections>>(unchecked(4*d+16)))&15UL);
      if (diagonal==15) continue;
      int next=unchecked((d+1)&3),paths=0;
      int first=(int)((connections>>(4*d))&15UL);
      if (first!=15) {
       int neighbour=unchecked(flatIndex+layerStride*first+offsets[d]);
       if (((nodeConnections[neighbour]>>(4*next))&15UL)==(ulong)diagonal) paths++;
      }
      int second=(int)((connections>>(4*next))&15UL);
      if (second!=15) {
       int neighbour=unchecked(flatIndex+layerStride*second+offsets[next]);
       if (((nodeConnections[neighbour]>>(4*d))&15UL)==(ulong)diagonal) paths++;
      }
      if (paths<required) connections|=15UL<<unchecked(4*d+16);
     }
     nodeConnections[index]=connections;
    }
   }
}
	}
}
