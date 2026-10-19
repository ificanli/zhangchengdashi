using System;
using System.Collections;
using Il2CppDummyDll;
using Unity.Entities;
using UnityEngine.Scripting;

namespace Pathfinding.ECS
{
	[Token(Token = "0x20002E9")]
	public class ManagedAgentOffMeshLinkTraversal : IComponentData, IQueryTypeParameter, ICloneable, ICleanupComponentData
	{
		[Token(Token = "0x4000D7B")]
		[FieldOffset(Offset = "0x10")]
		public AgentOffMeshLinkTraversalContext context;

		[Token(Token = "0x4000D7C")]
		[FieldOffset(Offset = "0x18")]
		public IEnumerator coroutine;

		[Token(Token = "0x4000D7D")]
		[FieldOffset(Offset = "0x20")]
		public IOffMeshLinkHandler handler;

		[Token(Token = "0x4000D7E")]
		[FieldOffset(Offset = "0x28")]
		public IOffMeshLinkStateMachine stateMachine;

		[Token(Token = "0x600128D")]
		[Address(RVA = "0x44B1D44", Offset = "0x44ADD44", VA = "0x44B1D44")]
		[Preserve]
		public ManagedAgentOffMeshLinkTraversal()
		{
		}

		[Token(Token = "0x600128E")]
		[Address(RVA = "0x44B1D4C", Offset = "0x44ADD4C", VA = "0x44B1D4C")]
		public ManagedAgentOffMeshLinkTraversal(AgentOffMeshLinkTraversalContext context, IOffMeshLinkHandler handler)
		{
		}

		[Token(Token = "0x600128F")]
		[Address(RVA = "0x44B1D7C", Offset = "0x44ADD7C", VA = "0x44B1D7C", Slot = "4")]
		public object Clone()
		{
			return null;
		}
	}
}
