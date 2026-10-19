using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace BrainFailProductions.PolyFew.AsImpL.MathUtil
{
	[Token(Token = "0x2000D14")]
	public static class Triangulation
	{
		[Token(Token = "0x6005159")]
		[Address(RVA = "0x42DBB28", Offset = "0x42D7B28", VA = "0x42DBB28")]
		public static List<Triangle> TriangulateConvexPolygon(List<Vertex> vertices, bool preserveOriginalVertices = true)
		{
			return null;
		}

		[Token(Token = "0x600515A")]
		[Address(RVA = "0x42DC004", Offset = "0x42D8004", VA = "0x42DC004")]
		public static List<Triangle> TriangulateByEarClipping(List<Vertex> origVertices, Vector3 planeNormal, string meshName, bool preserveOriginalVertices = true)
		{
			return null;
		}

		[Token(Token = "0x600515B")]
		[Address(RVA = "0x42DBF34", Offset = "0x42D7F34", VA = "0x42DBF34")]
		public static Triangle ClipTriangle(Vertex vertex, List<Vertex> vertices)
		{
			return null;
		}

		[Token(Token = "0x600515C")]
		[Address(RVA = "0x42DC5F0", Offset = "0x42D85F0", VA = "0x42DC5F0")]
		private static Triangle ClipEar(Vertex earVertex, List<Vertex> earVertices, List<Vertex> vertices, Vector3 planeNormal)
		{
			return null;
		}

		[Token(Token = "0x600515D")]
		[Address(RVA = "0x42DBD74", Offset = "0x42D7D74", VA = "0x42DBD74")]
		private static Vertex FindMaxAreaEarVertex(List<Vertex> earVertices)
		{
			return null;
		}

		[Token(Token = "0x600515E")]
		[Address(RVA = "0x42DC474", Offset = "0x42D8474", VA = "0x42DC474")]
		private static List<Vertex> FindEarVertices(List<Vertex> vertices, Vector3 planeNormal)
		{
			return null;
		}

		[Token(Token = "0x600515F")]
		[Address(RVA = "0x42DC9C4", Offset = "0x42D89C4", VA = "0x42DC9C4")]
		private static bool IsVertexReflex(Vertex v, Vector3 vNormal)
		{
			return default;
		}

		[Token(Token = "0x6005160")]
		[Address(RVA = "0x42DC7BC", Offset = "0x42D87BC", VA = "0x42DC7BC")]
		private static bool IsVertexEar(Vertex v, List<Vertex> vertices, Vector3 planeNormal)
		{
			return default;
		}
	}
}
