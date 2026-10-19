using System;
using Il2CppDummyDll;
using Unity.Entities;

namespace Pathfinding.ECS
{
	[Serializable]
	[Token(Token = "0x20002E5")]
	public struct AgentMovementPlaneSource : ISharedComponentData, IQueryTypeParameter
	{
		[Token(Token = "0x4000D77")]
		[FieldOffset(Offset = "0x0")]
		public MovementPlaneSource value;
	}
}
