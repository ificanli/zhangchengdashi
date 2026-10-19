using Il2CppDummyDll;
using Unity.Entities;
using Unity.Mathematics;

namespace Pathfinding.ECS
{
	[Token(Token = "0x2000301")]
	public struct MovementStatistics : IComponentData, IQueryTypeParameter
	{
		[Token(Token = "0x4000DD1")]
		[FieldOffset(Offset = "0x0")]
		public float3 estimatedVelocity;

		[Token(Token = "0x4000DD2")]
		[FieldOffset(Offset = "0xC")]
		public float3 lastPosition;
	}
}
