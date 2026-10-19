using Il2CppDummyDll;
using Unity.Entities;
using Unity.Transforms;

namespace Pathfinding.ECS
{
	[Token(Token = "0x20002F3")]
	public delegate void BeforeControlDelegate(Entity entity, float dt, ref LocalTransform localTransform, ref AgentCylinderShape shape, ref AgentMovementPlane movementPlane, ref DestinationPoint destination, ref MovementState movementState, ref MovementSettings movementSettings);
}
