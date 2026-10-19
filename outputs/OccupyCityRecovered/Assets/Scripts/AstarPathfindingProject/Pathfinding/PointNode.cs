using System;
using Il2CppDummyDll;
using Pathfinding.Serialization;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x20000EE")]
	public class PointNode : GraphNode
	{
		[Token(Token = "0x400052C")]
		[FieldOffset(Offset = "0x28")]
		public Connection[] connections;

		[Token(Token = "0x400052D")]
		[FieldOffset(Offset = "0x30")]
		public GameObject gameObject;

		[Token(Token = "0x6000853")]
		[Address(RVA = "0x453F38C", Offset = "0x453B38C", VA = "0x453F38C")]
		[Obsolete("Set node.position instead")]
		public void SetPosition(Int3 value)
		{
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0x453F398", Offset = "0x453B398", VA = "0x453F398")]
		public PointNode()
		{
		}

		[Token(Token = "0x6000855")]
		[Address(RVA = "0x453F3A0", Offset = "0x453B3A0", VA = "0x453F3A0")]
		public PointNode(AstarPath astar)
		{
		}

		[Token(Token = "0x6000856")]
		[Address(RVA = "0x453F3D8", Offset = "0x453B3D8", VA = "0x453F3D8", Slot = "17")]
		public override Vector3 ClosestPointOnNode(Vector3 p)
		{
			return default;
		}

		[Token(Token = "0x6000857")]
		[Address(RVA = "0x453F404", Offset = "0x453B404", VA = "0x453F404", Slot = "19")]
		public override bool ContainsPoint(Vector3 point)
		{
			return default;
		}

		[Token(Token = "0x6000858")]
		[Address(RVA = "0x453F40C", Offset = "0x453B40C", VA = "0x453F40C", Slot = "20")]
		public override bool ContainsPointInGraphSpace(Int3 point)
		{
			return default;
		}

		[Token(Token = "0x6000859")]
		public override void GetConnections<T>(NodeActionWithData<T> action, ref T data, int connectionFilter)
		{
		}

		[Token(Token = "0x600085A")]
		[Address(RVA = "0x453F414", Offset = "0x453B414", VA = "0x453F414", Slot = "9")]
		public override void ClearConnections(bool alsoReverse)
		{
		}

		[Token(Token = "0x600085B")]
		[Address(RVA = "0x453F4E4", Offset = "0x453B4E4", VA = "0x453F4E4", Slot = "10")]
		public override bool ContainsOutgoingConnection(GraphNode node)
		{
			return default;
		}

		[Token(Token = "0x600085C")]
		[Address(RVA = "0x453F56C", Offset = "0x453B56C", VA = "0x453F56C", Slot = "7")]
		public override void AddPartialConnection(GraphNode node, uint cost, bool isOutgoing, bool isIncoming)
		{
		}

		[Token(Token = "0x600085D")]
		[Address(RVA = "0x453F8B8", Offset = "0x453B8B8", VA = "0x453F8B8", Slot = "8")]
		public override void RemovePartialConnection(GraphNode node)
		{
		}

		[Token(Token = "0x600085E")]
		[Address(RVA = "0x453FA48", Offset = "0x453BA48", VA = "0x453FA48", Slot = "12")]
		public override void Open(ref Path.SearchContext ctx, uint pathNodeIndex, uint gScore)
		{
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0x453FD50", Offset = "0x453BD50", VA = "0x453FD50", Slot = "13")]
		public override void OpenAtPoint(ref Path.SearchContext ctx, uint pathNodeIndex, Int3 pos, uint gScore)
		{
		}

		[Token(Token = "0x6000860")]
		[Address(RVA = "0x453FEF8", Offset = "0x453BEF8", VA = "0x453FEF8", Slot = "21")]
		public override int GetGizmoHashCode()
		{
			return default;
		}

		[Token(Token = "0x6000861")]
		[Address(RVA = "0x453FF7C", Offset = "0x453BF7C", VA = "0x453FF7C", Slot = "22")]
		public override void SerializeNode(GraphSerializationContext ctx)
		{
		}

		[Token(Token = "0x6000862")]
		[Address(RVA = "0x453FFB8", Offset = "0x453BFB8", VA = "0x453FFB8", Slot = "23")]
		public override void DeserializeNode(GraphSerializationContext ctx)
		{
		}

		[Token(Token = "0x6000863")]
		[Address(RVA = "0x453FFF8", Offset = "0x453BFF8", VA = "0x453FFF8", Slot = "24")]
		public override void SerializeReferences(GraphSerializationContext ctx)
		{
		}

		[Token(Token = "0x6000864")]
		[Address(RVA = "0x4540020", Offset = "0x453C020", VA = "0x4540020", Slot = "25")]
		public override void DeserializeReferences(GraphSerializationContext ctx)
		{
		}
	}
}
