using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Burst.Intrinsics;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Transforms;

namespace Pathfinding.ECS
{
	[Token(Token = "0x2000334")]
	public partial struct JobManagedMovementOverrideBeforeMovement : IJobEntity, IJobChunk
	{

		[Token(Token = "0x4000E4D")]
		[FieldOffset(Offset = "0x0")]
		public float dt;

		[Token(Token = "0x600142F")]
		[Address(RVA = "0x44BFE28", Offset = "0x44BBE28", VA = "0x44BFE28")]
		public void Execute(ManagedMovementOverrideBeforeMovement managedOverride, Entity entity, ref LocalTransform localTransform, ref AgentCylinderShape shape, ref AgentMovementPlane movementPlane, ref DestinationPoint destination, ref MovementState movementState, ref MovementSettings movementSettings, ref MovementControl movementControl, ref ResolvedMovement resolvedMovement)
		{
		}

		[Token(Token = "0x6001448")]
		[Address(RVA = "0x44C0928", Offset = "0x44BC928", VA = "0x44C0928", Slot = "4")]
void IJobChunk.Execute(in ArchetypeChunk chunk, int unfilteredChunkIndex, bool useEnabledMask, in v128 chunkEnabledMask)
		{
		}
	}
}
