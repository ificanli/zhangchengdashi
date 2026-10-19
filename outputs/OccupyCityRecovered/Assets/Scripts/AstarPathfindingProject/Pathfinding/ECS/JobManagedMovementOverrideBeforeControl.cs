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
	[Token(Token = "0x200032C")]
	public partial struct JobManagedMovementOverrideBeforeControl : IJobEntity, IJobChunk
	{

		[Token(Token = "0x4000E32")]
		[FieldOffset(Offset = "0x0")]
		public float dt;

		[Token(Token = "0x60013E5")]
		[Address(RVA = "0x44BDA58", Offset = "0x44B9A58", VA = "0x44BDA58")]
		public void Execute(ManagedMovementOverrideBeforeControl managedOverride, Entity entity, ref LocalTransform localTransform, ref AgentCylinderShape shape, ref AgentMovementPlane movementPlane, ref DestinationPoint destination, ref MovementState movementState, ref MovementSettings movementSettings)
		{
		}

		[Token(Token = "0x60013FE")]
		[Address(RVA = "0x44BE3D8", Offset = "0x44BA3D8", VA = "0x44BE3D8", Slot = "4")]
void IJobChunk.Execute(in ArchetypeChunk chunk, int unfilteredChunkIndex, bool useEnabledMask, in v128 chunkEnabledMask)
		{
		}
	}
}
