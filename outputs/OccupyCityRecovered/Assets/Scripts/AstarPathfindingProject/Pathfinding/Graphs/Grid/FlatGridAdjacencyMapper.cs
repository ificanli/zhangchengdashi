using Il2CppDummyDll;
using Unity.Collections;

namespace Pathfinding.Graphs.Grid
{
	[Token(Token = "0x2000204")]
	public struct FlatGridAdjacencyMapper : GridAdjacencyMapper
	{
		[Token(Token = "0x6000D96")]
		[Address(RVA = "0x4473658", Offset = "0x446F658", VA = "0x4473658", Slot = "4")]
		public int LayerCount(IntBounds bounds)
		{ return 1; }

		[Token(Token = "0x6000D97")]
		[Address(RVA = "0x4473660", Offset = "0x446F660", VA = "0x4473660", Slot = "5")]
		public int GetNeighbourIndex(int nodeIndexXZ, int nodeIndex, int direction, NativeArray<ulong> nodeConnections, NativeArray<int> neighbourOffsets, int layerStride)
		{ return unchecked(nodeIndex+neighbourOffsets[direction]); }

		[Token(Token = "0x6000D98")]
		[Address(RVA = "0x447366C", Offset = "0x446F66C", VA = "0x447366C", Slot = "6")]
		public bool HasConnection(int nodeIndex, int direction, NativeArray<ulong> nodeConnections)
		{ return ((nodeConnections[nodeIndex]>>direction)&1UL)!=0; }
	}
}
