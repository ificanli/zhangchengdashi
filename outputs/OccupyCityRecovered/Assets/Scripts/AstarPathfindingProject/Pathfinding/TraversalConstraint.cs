using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Pathfinding
{
	[Token(Token = "0x20000C4")]
	public struct TraversalConstraint
	{
		[Token(Token = "0x20000C5")]
		internal enum FilterType
		{
			[Token(Token = "0x400042A")]
			None = 0,
			[Token(Token = "0x400042B")]
			TraversalProvider = 1,
			[Token(Token = "0x400042C")]
			Func = 2
		}

		[Token(Token = "0x4000424")]
		[FieldOffset(Offset = "0x0")]
		internal object filterObj;

		[Token(Token = "0x4000425")]
		[FieldOffset(Offset = "0x8")]
		public int tags;

		[Token(Token = "0x4000426")]
		[FieldOffset(Offset = "0xC")]
		public GraphMask graphMask;

		[Token(Token = "0x4000427")]
		[FieldOffset(Offset = "0x10")]
		internal FilterType filterType;

		[Token(Token = "0x4000428")]
		[FieldOffset(Offset = "0x0")]
		public static readonly TraversalConstraint None = new TraversalConstraint { tags = -1, graphMask = GraphMask.everything };

		[Token(Token = "0x17000148")]
		public ITraversalProvider traversalProvider
		{
			[Token(Token = "0x6000678")]
			[Address(RVA = "0x451588C", Offset = "0x451188C", VA = "0x451588C")]
			get
			{ return filterObj as ITraversalProvider; }
			[Token(Token = "0x6000679")]
			[Address(RVA = "0x450CCB8", Offset = "0x4508CB8", VA = "0x450CCB8")]
			set
			{ filterObj = value; filterType = value != null ? FilterType.TraversalProvider : FilterType.None; }
		}

		[Token(Token = "0x17000149")]
		public Func<GraphNode, bool> filter
		{
			[Token(Token = "0x600067A")]
			[Address(RVA = "0x4515768", Offset = "0x4511768", VA = "0x4515768")]
			get
			{ return filterObj as System.Func<GraphNode, bool>; }
			[Token(Token = "0x600067B")]
			[Address(RVA = "0x4515820", Offset = "0x4511820", VA = "0x4515820")]
			set
			{ filterObj = value; filterType = value != null ? FilterType.Func : FilterType.None; }
		}

		[Token(Token = "0x1700014A")]
		public bool filterDiagonalGridConnections
		{
			[Token(Token = "0x600067C")]
			[Address(RVA = "0x451C3B8", Offset = "0x45183B8", VA = "0x451C3B8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0x451C494", Offset = "0x4518494", VA = "0x451C494")]
		public TraversalConstraint(Func<GraphNode, bool> filter)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED TraversalConstraint..ctor RVA=0x451C494 Token=0x600067D");
}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0x451C51C", Offset = "0x451851C", VA = "0x451C51C")]
		public TraversalConstraint(ITraversalProvider traversalProvider)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED TraversalConstraint..ctor RVA=0x451C51C Token=0x600067E");
}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600067F")]
		[Address(RVA = "0x451C5A0", Offset = "0x45185A0", VA = "0x451C5A0")]
		public bool CanTraverse(GraphNode node)
		{
 if (!node.Walkable || ((tags >> (int)node.Tag) & 1) == 0) return false;
 switch (filterType) {
  case FilterType.Func: return global::Unity.Collections.LowLevel.Unsafe.UnsafeUtility.As<object, Func<GraphNode, bool>>(ref filterObj).Invoke(node);
  case FilterType.TraversalProvider: return global::Unity.Collections.LowLevel.Unsafe.UnsafeUtility.As<object, ITraversalProvider>(ref filterObj).CanTraverse(ref this, node);
  default: return true;
 }
}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000680")]
		[Address(RVA = "0x451C730", Offset = "0x4518730", VA = "0x451C730")]
		public bool CanTraverse(GraphNode from, GraphNode to)
		{
 if (!to.Walkable || ((tags >> (int)to.Tag) & 1) == 0) return false;
 switch (filterType) {
  case FilterType.Func: return global::Unity.Collections.LowLevel.Unsafe.UnsafeUtility.As<object, Func<GraphNode, bool>>(ref filterObj).Invoke(to);
  case FilterType.TraversalProvider: return global::Unity.Collections.LowLevel.Unsafe.UnsafeUtility.As<object, ITraversalProvider>(ref filterObj).CanTraverse(ref this, from, to);
  default: return true;
 }
}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000681")]
		[Address(RVA = "0x451C8C8", Offset = "0x45188C8", VA = "0x451C8C8")]
		public bool CanTraverseSkipUserFilter(GraphNode node)
		{ return node.Walkable && ((tags >> (int)node.Tag) & 1) != 0; }

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000682")]
		[Address(RVA = "0x451C8FC", Offset = "0x45188FC", VA = "0x451C8FC")]
		public NearestNodeConstraint ToNearestNodeConstraint()
		{
 var traversalConstraint = this;
 return new NearestNodeConstraint { distanceMetric = DistanceMetric.Euclidean, area = -1, maxDistanceSqr = -1, traversal = traversalConstraint, walkable = NearestNodeConstraint.WalkabilityConstraint.Walkable };
}
	}
}
