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
	[Token(Token = "0x2000338")]
	[WithOptions(EntityQueryOptions.IgnoreComponentEnabledState)]
	public partial struct JobManagedOffMeshLinkTransition : IJobEntity, IJobChunk
	{

		[Token(Token = "0x4000E5C")]
		[FieldOffset(Offset = "0x0")]
		public EntityCommandBuffer commandBuffer;

		[Token(Token = "0x4000E5D")]
		[FieldOffset(Offset = "0x20")]
		public float deltaTime;

		[Token(Token = "0x6001454")]
		[Address(RVA = "0x44C1214", Offset = "0x44BD214", VA = "0x44C1214")]
		public void Execute(Entity entity, ManagedState state, ref LocalTransform transform, ref AgentMovementPlane movementPlane, ref MovementControl movementControl, ref MovementSettings movementSettings, ref AgentOffMeshLinkTraversal linkInfo, ManagedAgentOffMeshLinkTraversal managedLinkInfo, EnabledRefRW<AgentOffMeshLinkMovementDisabled> movementDisabled, EnabledRefRW<AgentOffMeshLinkLocalAvoidanceDisabled> localAvoidanceDisabled)
		{
		}

		[Token(Token = "0x6001455")]
		[Address(RVA = "0x44C139C", Offset = "0x44BD39C", VA = "0x44C139C")]
		public static bool MoveNext(Entity entity, ManagedState state, ref LocalTransform transform, ref AgentMovementPlane movementPlane, ref MovementControl movementControl, ref MovementSettings movementSettings, ref AgentOffMeshLinkTraversal linkInfo, ManagedAgentOffMeshLinkTraversal managedLinkInfo, EnabledRefRW<AgentOffMeshLinkMovementDisabled> movementDisabled, EnabledRefRW<AgentOffMeshLinkLocalAvoidanceDisabled> localAvoidanceDisabled, float deltaTime)
		{
			return default;
		}

		[Token(Token = "0x600146E")]
		[Address(RVA = "0x44C26F0", Offset = "0x44BE6F0", VA = "0x44C26F0", Slot = "4")]
void IJobChunk.Execute(in ArchetypeChunk chunk, int unfilteredChunkIndex, bool useEnabledMask, in v128 chunkEnabledMask)
		{
		}
	}
}
