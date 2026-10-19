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
	[Token(Token = "0x2000330")]
	public partial struct JobManagedMovementOverrideAfterControl : IJobEntity, IJobChunk
	{

		[Token(Token = "0x4000E3F")]
		[FieldOffset(Offset = "0x0")]
		public float dt;

		[Token(Token = "0x600140A")]
		[Address(RVA = "0x44BEBA8", Offset = "0x44BABA8", VA = "0x44BEBA8")]
		public void Execute(ManagedMovementOverrideAfterControl managedOverride, Entity entity, ref LocalTransform localTransform, ref AgentCylinderShape shape, ref AgentMovementPlane movementPlane, ref DestinationPoint destination, ref MovementState movementState, ref MovementSettings movementSettings, ref MovementControl movementControl)
		{
		}

		[Token(Token = "0x6001423")]
		[Address(RVA = "0x44BF5CC", Offset = "0x44BB5CC", VA = "0x44BF5CC", Slot = "4")]
void IJobChunk.Execute(in ArchetypeChunk chunk, int unfilteredChunkIndex, bool useEnabledMask, in v128 chunkEnabledMask)
		{
		}
	}
}
