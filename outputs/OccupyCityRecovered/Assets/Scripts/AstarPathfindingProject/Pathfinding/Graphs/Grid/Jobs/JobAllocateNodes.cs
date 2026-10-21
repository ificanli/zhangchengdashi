using System;
using Il2CppDummyDll;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace Pathfinding.Graphs.Grid.Jobs
{
	[Token(Token = "0x2000224")]
	public struct JobAllocateNodes : IJob
	{
		[Token(Token = "0x4000A1C")]
		[FieldOffset(Offset = "0x0")]
		public AstarPath active;

		[Token(Token = "0x4000A1D")]
		[FieldOffset(Offset = "0x8")]
		[ReadOnly]
		public NativeArray<float4> nodeNormals;

		[Token(Token = "0x4000A1E")]
		[FieldOffset(Offset = "0x18")]
		public IntBounds dataBounds;

		[Token(Token = "0x4000A1F")]
		[FieldOffset(Offset = "0x30")]
		public int3 nodeArrayBounds;

		[Token(Token = "0x4000A20")]
		[FieldOffset(Offset = "0x40")]
		public GridNodeBase[] nodes;

		[Token(Token = "0x4000A21")]
		[FieldOffset(Offset = "0x48")]
		public Func<GridNodeBase> newGridNodeDelegate;

		[Token(Token = "0x6000DFE")]
		[Address(RVA = "0x4479FFC", Offset = "0x4475FFC", VA = "0x4479FFC", Slot = "4")]
		public void Execute()
		{
 var size=dataBounds.size;
 var normals=Pathfinding.Collections.SpanExtensions.AsUnsafeReadOnlySpan(nodeNormals);
 for (int y=1;y<size.y;y++)
  for (int z=0;z<size.z;z++)
   for (int x=0;x<size.x;x++) {
    int index=unchecked(dataBounds.min.x+x+nodeArrayBounds.x*(dataBounds.min.z+z+nodeArrayBounds.z*(y+dataBounds.min.y)));
    bool present=Unity.Mathematics.math.any(normals[unchecked((uint)index)]!=default(float4));
    var node=nodes[index];
    if (present==(node!=null)) continue;
    if (present) { nodes[index]=newGridNodeDelegate();active.InitializeNode(nodes[index]); }
    else { node.ClearCustomConnections(true);node.ResetConnectionsInternal();node.Destroy();nodes[index]=null; }
   }
}
	}
}
