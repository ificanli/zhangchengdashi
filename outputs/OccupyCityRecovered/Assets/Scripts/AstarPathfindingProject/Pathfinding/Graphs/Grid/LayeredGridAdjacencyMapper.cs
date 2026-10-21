using Il2CppDummyDll;
using Unity.Collections;

namespace Pathfinding.Graphs.Grid
{
	[Token(Token = "0x2000205")]
	public struct LayeredGridAdjacencyMapper : GridAdjacencyMapper
	{
		[Token(Token = "0x6000D99")]
		[Address(RVA = "0x447367C", Offset = "0x446F67C", VA = "0x447367C", Slot = "4")]
		public int LayerCount(IntBounds bounds)
		{ return bounds.size.y; }

		[Token(Token = "0x6000D9A")]
		[Address(RVA = "0x4473698", Offset = "0x446F698", VA = "0x4473698", Slot = "5")]
		public int GetNeighbourIndex(int nodeIndexXZ, int nodeIndex, int direction, NativeArray<ulong> nodeConnections, NativeArray<int> neighbourOffsets, int layerStride)
		{ return unchecked(nodeIndexXZ+neighbourOffsets[direction]+(int)((nodeConnections[nodeIndex]>>unchecked(4*direction))&15UL)*layerStride); }

		[Token(Token = "0x6000D9B")]
		[Address(RVA = "0x44736BC", Offset = "0x446F6BC", VA = "0x44736BC", Slot = "6")]
		public bool HasConnection(int nodeIndex, int direction, NativeArray<ulong> nodeConnections)
		{ return ((nodeConnections[nodeIndex]>>unchecked(4*direction))&15UL)!=15UL; }
	}
}
