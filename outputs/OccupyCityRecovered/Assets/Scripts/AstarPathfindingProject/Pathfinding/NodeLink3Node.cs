using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x2000088")]
	public class NodeLink3Node : PointNode
	{
		[Token(Token = "0x40002E6")]
		[FieldOffset(Offset = "0x38")]
		public NodeLink3 link;

		[Token(Token = "0x40002E7")]
		[FieldOffset(Offset = "0x40")]
		public Vector3 portalA;

		[Token(Token = "0x40002E8")]
		[FieldOffset(Offset = "0x4C")]
		public Vector3 portalB;

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x4507B34", Offset = "0x4503B34", VA = "0x4507B34")]
		public NodeLink3Node(AstarPath astar)
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x4507B6C", Offset = "0x4503B6C", VA = "0x4507B6C", Slot = "11")]
		public override bool GetPortal(GraphNode other, out Vector3 left, out Vector3 right)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED NodeLink3Node.GetPortal RVA=0x4507B6C Token=0x60004A2");
}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x4507C38", Offset = "0x4503C38", VA = "0x4507C38")]
		public GraphNode GetOther(GraphNode a)
		{
			return null;
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x4507D7C", Offset = "0x4503D7C", VA = "0x4507D7C")]
		private GraphNode GetOtherInternal(GraphNode a)
		{
			return null;
		}
	}
}
