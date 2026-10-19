using System.Collections.Generic;
using Il2CppDummyDll;

namespace Pathfinding
{
	[Token(Token = "0x20000F7")]
	public class PointKDTree
	{
		[Token(Token = "0x20000F8")]
		private struct Node
		{
			[Token(Token = "0x4000544")]
			[FieldOffset(Offset = "0x0")]
			public GraphNode[] data;

			[Token(Token = "0x4000545")]
			[FieldOffset(Offset = "0x8")]
			public int split;

			[Token(Token = "0x4000546")]
			[FieldOffset(Offset = "0xC")]
			public ushort count;

			[Token(Token = "0x4000547")]
			[FieldOffset(Offset = "0xE")]
			public byte splitAxis;
		}

		[Token(Token = "0x20000F9")]
		private class CompareX : IComparer<GraphNode>
		{
			[Token(Token = "0x60008C6")]
			[Address(RVA = "0x45467D4", Offset = "0x45427D4", VA = "0x45467D4", Slot = "4")]
			public int Compare(GraphNode lhs, GraphNode rhs)
			{
				return default;
			}

			[Token(Token = "0x60008C7")]
			[Address(RVA = "0x45467BC", Offset = "0x45427BC", VA = "0x45467BC")]
			public CompareX()
			{
			}
		}

		[Token(Token = "0x20000FA")]
		private class CompareY : IComparer<GraphNode>
		{
			[Token(Token = "0x60008C8")]
			[Address(RVA = "0x45467FC", Offset = "0x45427FC", VA = "0x45467FC", Slot = "4")]
			public int Compare(GraphNode lhs, GraphNode rhs)
			{
				return default;
			}

			[Token(Token = "0x60008C9")]
			[Address(RVA = "0x45467C4", Offset = "0x45427C4", VA = "0x45467C4")]
			public CompareY()
			{
			}
		}

		[Token(Token = "0x20000FB")]
		private class CompareZ : IComparer<GraphNode>
		{
			[Token(Token = "0x60008CA")]
			[Address(RVA = "0x4546824", Offset = "0x4542824", VA = "0x4546824", Slot = "4")]
			public int Compare(GraphNode lhs, GraphNode rhs)
			{
				return default;
			}

			[Token(Token = "0x60008CB")]
			[Address(RVA = "0x45467CC", Offset = "0x45427CC", VA = "0x45467CC")]
			public CompareZ()
			{
			}
		}

		[Token(Token = "0x400053D")]
		public const int LeafSize = 10;

		[Token(Token = "0x400053E")]
		public const int LeafArraySize = 21;

		[Token(Token = "0x400053F")]
		[FieldOffset(Offset = "0x10")]
		private Node[] tree;

		[Token(Token = "0x4000540")]
		[FieldOffset(Offset = "0x18")]
		private int numNodes;

		[Token(Token = "0x4000541")]
		[FieldOffset(Offset = "0x20")]
		private readonly List<GraphNode> largeList;

		[Token(Token = "0x4000542")]
		[FieldOffset(Offset = "0x28")]
		private readonly Stack<GraphNode[]> arrayCache;

		[Token(Token = "0x4000543")]
		[FieldOffset(Offset = "0x0")]
		private static readonly IComparer<GraphNode>[] comparers;

		[Token(Token = "0x60008B2")]
		[Address(RVA = "0x4544D84", Offset = "0x4540D84", VA = "0x4544D84")]
		public PointKDTree()
		{
		}

		[Token(Token = "0x60008B3")]
		[Address(RVA = "0x4544F28", Offset = "0x4540F28", VA = "0x4544F28")]
		public void Add(GraphNode node)
		{
		}

		[Token(Token = "0x60008B4")]
		[Address(RVA = "0x4545118", Offset = "0x4541118", VA = "0x4545118")]
		public void Remove(GraphNode node)
		{
		}

		[Token(Token = "0x60008B5")]
		[Address(RVA = "0x4545388", Offset = "0x4541388", VA = "0x4545388")]
		public void Rebuild(GraphNode[] nodes, int start, int end)
		{
		}

		[Token(Token = "0x60008B6")]
		[Address(RVA = "0x4544E98", Offset = "0x4540E98", VA = "0x4544E98")]
		private GraphNode[] GetOrCreateList()
		{
			return null;
		}

		[Token(Token = "0x60008B7")]
		[Address(RVA = "0x4545974", Offset = "0x4541974", VA = "0x4545974")]
		private int Size(int index)
		{
			return default;
		}

		[Token(Token = "0x60008B8")]
		[Address(RVA = "0x45459F0", Offset = "0x45419F0", VA = "0x45459F0")]
		private void CollectAndClear(int index, List<GraphNode> buffer)
		{
		}

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0x4545B50", Offset = "0x4541B50", VA = "0x4545B50")]
		private static int MaxAllowedSize(int numNodes, int depth)
		{
			return default;
		}

		[Token(Token = "0x60008BA")]
		[Address(RVA = "0x4545BD8", Offset = "0x4541BD8", VA = "0x4545BD8")]
		private void Rebalance(int index)
		{
		}

		[Token(Token = "0x60008BB")]
		[Address(RVA = "0x4545C60", Offset = "0x4541C60", VA = "0x4545C60")]
		private void EnsureSize(int index)
		{
		}

		[Token(Token = "0x60008BC")]
		[Address(RVA = "0x4545528", Offset = "0x4541528", VA = "0x4545528")]
		private void Build(int index, List<GraphNode> nodes, int start, int end)
		{
		}

		[Token(Token = "0x60008BD")]
		[Address(RVA = "0x4544F40", Offset = "0x4540F40", VA = "0x4544F40")]
		private void Add(GraphNode point, int index, int depth = 0)
		{
		}

		[Token(Token = "0x60008BE")]
		[Address(RVA = "0x454517C", Offset = "0x454117C", VA = "0x454517C")]
		private bool Remove(GraphNode point, int index, int depth = 0)
		{
			return default;
		}

		[Token(Token = "0x60008BF")]
		[Address(RVA = "0x4545D28", Offset = "0x4541D28", VA = "0x4545D28")]
		public GraphNode GetNearest(Int3 point, ref NearestNodeConstraint constraint, ref float distanceSqr)
		{
			return null;
		}

		[Token(Token = "0x60008C0")]
		[Address(RVA = "0x4545DC8", Offset = "0x4541DC8", VA = "0x4545DC8")]
		private void GetNearestInternal(int index, Int3 point, ref NearestNodeConstraint constraint, ref GraphNode best, ref long bestSqrDist)
		{
		}

		[Token(Token = "0x60008C1")]
		[Address(RVA = "0x4545FD8", Offset = "0x4541FD8", VA = "0x4545FD8")]
		public GraphNode GetNearestConnection(Int3 point, ref NearestNodeConstraint constraint, long maximumSqrConnectionLength)
		{
			return null;
		}

		[Token(Token = "0x60008C2")]
		[Address(RVA = "0x454602C", Offset = "0x454202C", VA = "0x454602C")]
		private void GetNearestConnectionInternal(int index, Int3 point, ref NearestNodeConstraint constraint, ref GraphNode best, ref long bestSqrDist, long distanceThresholdOffset)
		{
		}

		[Token(Token = "0x60008C3")]
		[Address(RVA = "0x4546420", Offset = "0x4542420", VA = "0x4546420")]
		public void GetInRange(Int3 point, long sqrRadius, List<GraphNode> buffer)
		{
		}

		[Token(Token = "0x60008C4")]
		[Address(RVA = "0x454643C", Offset = "0x454243C", VA = "0x454643C")]
		private void GetInRangeInternal(int index, Int3 point, long sqrRadius, List<GraphNode> buffer)
		{
		}
	}
}
