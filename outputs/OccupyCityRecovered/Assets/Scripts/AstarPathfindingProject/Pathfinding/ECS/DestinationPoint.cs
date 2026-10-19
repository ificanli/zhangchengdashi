using Il2CppDummyDll;
using Unity.Entities;
using Unity.Mathematics;

namespace Pathfinding.ECS
{
	[Token(Token = "0x20002F1")]
	public struct DestinationPoint : IComponentData, IQueryTypeParameter
	{
		[Token(Token = "0x4000D97")]
		[FieldOffset(Offset = "0x0")]
		public float3 destination;

		[Token(Token = "0x4000D98")]
		[FieldOffset(Offset = "0xC")]
		public float3 facingDirection;
	}
}
