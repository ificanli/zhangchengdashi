using System;
using Il2CppDummyDll;

namespace Pathfinding
{
	[Token(Token = "0x20000EF")]
	public interface INavmeshHolder : ITransformedGraph
	{
		[Token(Token = "0x6000865")]
		void GetNodes(Action<GraphNode> del);

		[Token(Token = "0x6000866")]
		Int3 GetVertex(int i);

		[Token(Token = "0x6000867")]
		Int3 GetVertexInGraphSpace(int i);

		[Token(Token = "0x6000868")]
		int GetVertexArrayIndex(int index);

		[Token(Token = "0x6000869")]
		void GetTileCoordinates(int tileIndex, out int x, out int z);
	}
}
