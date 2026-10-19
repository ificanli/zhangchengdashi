using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x2000077")]
	public static class GraphUtilities
	{
		[Token(Token = "0x600044D")]
		[Address(RVA = "0x44FEA3C", Offset = "0x44FAA3C", VA = "0x44FEA3C")]
		public static List<Vector3> GetContours(NavGraph graph)
		{
			return null;
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x44FEC48", Offset = "0x44FAC48", VA = "0x44FEC48")]
		public static void GetContours(NavmeshBase navmesh, Action<List<Int3>, bool> results)
		{
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x44FEE8C", Offset = "0x44FAE8C", VA = "0x44FEE8C")]
		public static void GetContours(GridGraph grid, Action<Vector3[]> callback, float yMergeThreshold, [Optional] GridNodeBase[] nodes, [Optional] Func<GraphNode, GraphNode, bool> connectionFilter)
		{
		}
	}
}
