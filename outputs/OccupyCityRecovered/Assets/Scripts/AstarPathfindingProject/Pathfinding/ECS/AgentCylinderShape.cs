using System;
using Il2CppDummyDll;
using Unity.Entities;

namespace Pathfinding.ECS
{
	[Serializable]
	[Token(Token = "0x20002E3")]
	public struct AgentCylinderShape : IComponentData, IQueryTypeParameter
	{
		[Token(Token = "0x4000D74")]
		[FieldOffset(Offset = "0x0")]
		public float radius;

		[Token(Token = "0x4000D75")]
		[FieldOffset(Offset = "0x4")]
		public float height;
	}
}
