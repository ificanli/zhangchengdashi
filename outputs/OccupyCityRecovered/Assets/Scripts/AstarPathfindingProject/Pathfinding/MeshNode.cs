using Il2CppDummyDll;
using Pathfinding.Serialization;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x20000A0")]
	public abstract class MeshNode : GraphNode
	{
		[Token(Token = "0x4000362")]
		[FieldOffset(Offset = "0x28")]
		public Connection[] connections;

		[Token(Token = "0x600055B")]
		public abstract Int3 GetVertex(int i);

		[Token(Token = "0x600055C")]
		public abstract int GetVertexCount();

		[Token(Token = "0x600055D")]
		public abstract Vector3 ClosestPointOnNodeXZ(Vector3 p);

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x450EDE4", Offset = "0x450ADE4", VA = "0x450EDE4", Slot = "9")]
		public override void ClearConnections(bool alsoReverse = true)
		{
		}

		[Token(Token = "0x600055F")]
		public override void GetConnections<T>(NodeActionWithData<T> action, ref T data, int connectionFilter = 32)
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x450EF00", Offset = "0x450AF00", VA = "0x450EF00", Slot = "10")]
		public override bool ContainsOutgoingConnection(GraphNode node)
		{
			return default;
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x450EF6C", Offset = "0x450AF6C", VA = "0x450EF6C", Slot = "7")]
		public override void AddPartialConnection(GraphNode node, uint cost, bool isOutgoing, bool isIncoming)
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x450EF90", Offset = "0x450AF90", VA = "0x450EF90")]
		public void AddPartialConnection(GraphNode node, uint cost, byte shapeEdgeInfo)
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x450F1D0", Offset = "0x450B1D0", VA = "0x450F1D0", Slot = "8")]
		public override void RemovePartialConnection(GraphNode node)
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x450F3E0", Offset = "0x450B3E0", VA = "0x450F3E0", Slot = "21")]
		public override int GetGizmoHashCode()
		{
			return default;
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x450F494", Offset = "0x450B494", VA = "0x450F494", Slot = "24")]
		public override void SerializeReferences(GraphSerializationContext ctx)
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x450F4BC", Offset = "0x450B4BC", VA = "0x450F4BC", Slot = "25")]
		public override void DeserializeReferences(GraphSerializationContext ctx)
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x450F4EC", Offset = "0x450B4EC", VA = "0x450F4EC")]
		protected MeshNode()
		{
		}
	}
}
