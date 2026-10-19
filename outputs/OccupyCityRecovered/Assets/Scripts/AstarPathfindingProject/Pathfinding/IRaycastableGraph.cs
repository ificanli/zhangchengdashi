using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x2000033")]
	public interface IRaycastableGraph
	{
		[Token(Token = "0x6000265")]
		bool Linecast(Vector3 start, Vector3 end);

		[Token(Token = "0x6000266")]
		[Obsolete]
		bool Linecast(Vector3 start, Vector3 end, GraphNode startNodeHint);

		[Token(Token = "0x6000267")]
		[Obsolete]
		bool Linecast(Vector3 start, Vector3 end, GraphNode startNodeHint, out GraphHitInfo hit);

		[Token(Token = "0x6000268")]
		bool Linecast(Vector3 start, Vector3 end, GraphNode startNodeHint, out GraphHitInfo hit, ref TraversalConstraint traversalConstraint, List<GraphNode> trace);

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x445DCF8", Offset = "0x4459CF8", VA = "0x445DCF8", Slot = "4")]
		bool Linecast(Vector3 start, Vector3 end, GraphNode startNodeHint, out GraphHitInfo hit, List<GraphNode> trace)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED IRaycastableGraph.Linecast RVA=0x445DCF8 Token=0x6000269");
}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x445DE58", Offset = "0x4459E58", VA = "0x445DE58", Slot = "5")]
		bool Linecast(Vector3 start, Vector3 end, out GraphHitInfo hit)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED IRaycastableGraph.Linecast RVA=0x445DE58 Token=0x600026A");
}

		[Token(Token = "0x600026B")]
		bool Linecast(Vector3 start, Vector3 end, out GraphHitInfo hit, ref TraversalConstraint traversalConstraint, [Optional] List<GraphNode> trace);

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x445DFA4", Offset = "0x4459FA4", VA = "0x445DFA4", Slot = "7")]
		bool Linecast(Vector3 start, Vector3 end, out GraphHitInfo hit, List<GraphNode> trace)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED IRaycastableGraph.Linecast RVA=0x445DFA4 Token=0x600026C");
}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x445E0F4", Offset = "0x445A0F4", VA = "0x445E0F4", Slot = "8")]
		[Obsolete("Use the overload that takes a TraversalConstraint instead of a filter function")]
		bool Linecast(Vector3 start, Vector3 end, out GraphHitInfo hit, List<GraphNode> trace, Func<GraphNode, bool> filter)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED IRaycastableGraph.Linecast RVA=0x445E0F4 Token=0x600026D");
}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x445E260", Offset = "0x445A260", VA = "0x445E260", Slot = "9")]
		[Obsolete("Use the overload that takes a TraversalConstraint instead of a filter function")]
		bool Linecast(Vector3 start, Vector3 end, GraphNode startNodeHint, out GraphHitInfo hit, List<GraphNode> trace, Func<GraphNode, bool> filter)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED IRaycastableGraph.Linecast RVA=0x445E260 Token=0x600026E");
}
	}
}
