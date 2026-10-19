using System;
using Il2CppDummyDll;
using Unity.Entities;
using UnityEngine;
using UnityEngine.Scripting;

namespace Pathfinding.ECS
{
	[Token(Token = "0x2000302")]
	public struct PhysicsSceneRef : ISharedComponentData, IQueryTypeParameter, IEquatable<PhysicsSceneRef>
	{
		[Token(Token = "0x4000DD3")]
		[FieldOffset(Offset = "0x0")]
		public PhysicsScene physicsScene;

		[Token(Token = "0x60012F1")]
		[Address(RVA = "0x44B5BB8", Offset = "0x44B1BB8", VA = "0x44B5BB8", Slot = "4")]
		public bool Equals(PhysicsSceneRef other)
		{
			return default;
		}

		[Token(Token = "0x60012F2")]
		[Address(RVA = "0x44B5BC8", Offset = "0x44B1BC8", VA = "0x44B5BC8", Slot = "2")]
		public override int GetHashCode()
		{
			return default;
		}
	}
}
