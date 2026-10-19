using System.Collections.Generic;
using Il2CppDummyDll;

namespace Pathfinding.Clipper2Lib
{
	[Token(Token = "0x2000022")]
	public class ReuseableDataContainer64
	{
		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x10")]
		internal readonly List<LocalMinima> _minimaList;

		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x18")]
		internal readonly List<Vertex> _vertexList;

		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x20")]
		internal readonly VertexPool _vertexPool;

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x460CF24", Offset = "0x4608F24", VA = "0x460CF24")]
		public ReuseableDataContainer64()
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x460CFEC", Offset = "0x4608FEC", VA = "0x460CFEC")]
		public void Clear()
		{
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x460D1AC", Offset = "0x46091AC", VA = "0x460D1AC")]
		public void AddPaths(List<List<Point64>> paths, PathType pt, bool isOpen)
		{
		}
	}
}
