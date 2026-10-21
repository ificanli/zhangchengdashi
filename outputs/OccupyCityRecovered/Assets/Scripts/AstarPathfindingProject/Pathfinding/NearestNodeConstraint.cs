using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Pathfinding
{
	[Token(Token = "0x20000B2")]
	public struct NearestNodeConstraint
	{
		[Token(Token = "0x20000B3")]
		public enum WalkabilityConstraint : byte
		{
			[Token(Token = "0x40003B7")]
			Walkable = 0,
			[Token(Token = "0x40003B8")]
			Unwalkable = 1,
			[Token(Token = "0x40003B9")]
			DontCare = 2
		}

		[Token(Token = "0x40003AF")]
		[FieldOffset(Offset = "0x0")]
		public DistanceMetric distanceMetric;

		[Token(Token = "0x40003B0")]
		[FieldOffset(Offset = "0x10")]
		public int area;

		[Token(Token = "0x40003B1")]
		[FieldOffset(Offset = "0x14")]
		public float maxDistanceSqr;

		[Token(Token = "0x40003B2")]
		[FieldOffset(Offset = "0x18")]
		internal TraversalConstraint traversal;

		[Token(Token = "0x40003B3")]
		[FieldOffset(Offset = "0x30")]
		public WalkabilityConstraint walkable;

		[Token(Token = "0x40003B4")]
		[FieldOffset(Offset = "0x0")]
		public static readonly NearestNodeConstraint Walkable = new NearestNodeConstraint { distanceMetric = DistanceMetric.Euclidean, area = -1, maxDistanceSqr = -1, traversal = TraversalConstraint.None, walkable = WalkabilityConstraint.Walkable };

		[Token(Token = "0x40003B5")]
		[FieldOffset(Offset = "0x38")]
		public static readonly NearestNodeConstraint None = new NearestNodeConstraint { distanceMetric = DistanceMetric.Euclidean, area = -1, maxDistanceSqr = -1, traversal = TraversalConstraint.None, walkable = WalkabilityConstraint.DontCare };

		[Token(Token = "0x17000126")]
		public int tags
		{
			[Token(Token = "0x60005C7")]
			[Address(RVA = "0x45156FC", Offset = "0x45116FC", VA = "0x45156FC")]
			get
			{ return traversal.tags; }
			[Token(Token = "0x60005C8")]
			[Address(RVA = "0x4515704", Offset = "0x4511704", VA = "0x4515704")]
			set
			{ traversal.tags = value; }
		}

		[Token(Token = "0x17000127")]
		public GraphMask graphMask
		{
			[Token(Token = "0x60005C9")]
			[Address(RVA = "0x451570C", Offset = "0x451170C", VA = "0x451570C")]
			get
			{ return traversal.graphMask; }
			[Token(Token = "0x60005CA")]
			[Address(RVA = "0x45096A0", Offset = "0x45056A0", VA = "0x45096A0")]
			set
			{ traversal.graphMask = value; }
		}

		[Token(Token = "0x17000128")]
		public Func<GraphNode, bool> filter
		{
			[Token(Token = "0x60005CB")]
			[Address(RVA = "0x4515714", Offset = "0x4511714", VA = "0x4515714")]
			get
			{ return traversal.filter; }
			[Token(Token = "0x60005CC")]
			[Address(RVA = "0x45157B0", Offset = "0x45117B0", VA = "0x45157B0")]
			set
			{ traversal.filter = value; }
		}

		[Token(Token = "0x17000129")]
		public ITraversalProvider traversalProvider
		{
			[Token(Token = "0x60005CD")]
			[Address(RVA = "0x4515838", Offset = "0x4511838", VA = "0x4515838")]
			get
			{ return traversal.traversalProvider; }
			[Token(Token = "0x60005CE")]
			[Address(RVA = "0x45158D4", Offset = "0x45118D4", VA = "0x45158D4")]
			set
			{ traversal.traversalProvider = value; }
		}

		[Token(Token = "0x1700012A")]
		public bool allNodesAreSuitable
		{
			[Token(Token = "0x60005CF")]
			[Address(RVA = "0x4515940", Offset = "0x4511940", VA = "0x4515940")]
			get
			{ return area < 0 && traversal.tags == -1 && traversal.graphMask.containsAllGraphs && walkable == WalkabilityConstraint.DontCare && traversal.filterType == TraversalConstraint.FilterType.None; }
		}

		[Token(Token = "0x1700012B")]
		public float? maxDistance
		{
			[Token(Token = "0x60005D0")]
			[Address(RVA = "0x45159EC", Offset = "0x45119EC", VA = "0x45159EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005D1")]
			[Address(RVA = "0x4515A5C", Offset = "0x4511A5C", VA = "0x4515A5C")]
			set
			{
			}
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x4515AEC", Offset = "0x4511AEC", VA = "0x4515AEC")]
		internal float maxDistanceSqrOrDefault(AstarPath astar)
		{ return maxDistanceSqr < 0 ? astar.maxNearestNodeDistanceSqr : maxDistanceSqr; }

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x4515B1C", Offset = "0x4511B1C", VA = "0x4515B1C")]
		public bool Suitable(GraphNode node)
		{
 if (area >= 0 && node.Area != (uint)area) return false;
 if (node.Walkable ? walkable == WalkabilityConstraint.Unwalkable : walkable == WalkabilityConstraint.Walkable) return false;
 if (((traversal.tags >> (int)node.Tag) & 1) == 0) return false;
 if (traversal.filterType == TraversalConstraint.FilterType.TraversalProvider) return ((ITraversalProvider)traversal.filterObj).CanTraverse(ref traversal,node);
 if (traversal.filterType == TraversalConstraint.FilterType.Func) return ((System.Func<GraphNode,bool>)traversal.filterObj)(node);
 return true;
}
	}
}
