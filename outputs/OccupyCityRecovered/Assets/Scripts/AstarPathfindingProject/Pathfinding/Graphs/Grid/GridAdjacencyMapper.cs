using Il2CppDummyDll;
using Unity.Collections;

namespace Pathfinding.Graphs.Grid
{
	[Token(Token = "0x2000203")]
	public interface GridAdjacencyMapper
	{
		[Token(Token = "0x6000D93")]
		int LayerCount(IntBounds bounds);

		[Token(Token = "0x6000D94")]
		int GetNeighbourIndex(int nodeIndexXZ, int nodeIndex, int direction, NativeArray<ulong> nodeConnections, NativeArray<int> neighbourOffsets, int layerStride);

		[Token(Token = "0x6000D95")]
		bool HasConnection(int nodeIndex, int direction, NativeArray<ulong> nodeConnections);
	}
}
