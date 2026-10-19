using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Pathfinding.Clipper2Lib
{
	[Token(Token = "0x2000021")]
	internal static class ClipperEngine
	{
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x460C310", Offset = "0x4608310", VA = "0x460C310")]
		internal static void AddLocMin(Vertex vert, PathType polytype, bool isOpen, List<LocalMinima> minimaList)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60000CC")]
		internal static void EnsureCapacity<T>(this List<T> list, int minCapacity) where T : notnull
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x460C3F0", Offset = "0x46083F0", VA = "0x460C3F0")]
		internal static void AddPathsToVertexList(List<List<Point64>> paths, PathType polytype, bool isOpen, List<LocalMinima> minimaList, List<Vertex> vertexList, VertexPool vertexPool)
		{
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x460CB3C", Offset = "0x4608B3C", VA = "0x460CB3C")]
		internal static void AddPathToVertexList(SpanCompat<Point64> path, PathType polytype, bool isOpen, List<LocalMinima> minimaList, List<Vertex> vertexList, VertexPool vertexPool)
		{
		}
	}
}
