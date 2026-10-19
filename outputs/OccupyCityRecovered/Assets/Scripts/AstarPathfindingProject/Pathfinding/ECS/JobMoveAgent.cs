using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Burst.Intrinsics;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Transforms;

namespace Pathfinding.ECS
{
	[Token(Token = "0x2000340")]
	[WithNone(new Type[] { typeof(AgentOffMeshLinkMovementDisabled) })]
	[WithAll(new Type[]
	{
		typeof(SimulateMovement),
		typeof(SimulateMovementFinalize)
	})]
	[BurstCompile]
	public partial struct JobMoveAgent : IJobEntity, IJobChunk
	{

		[Token(Token = "0x4000E71")]
		[FieldOffset(Offset = "0x0")]
		public float dt;

		[Token(Token = "0x600149F")]
		[Address(RVA = "0x44C38D4", Offset = "0x44BF8D4", VA = "0x44C38D4")]
		public static quaternion ResolveRotation(quaternion rotation, ref MovementState state, in ResolvedMovement resolvedMovement, in MovementSettings movementSettings, in AgentMovementPlane movementPlane, float dt)
		{
			return default;
		}

		[Token(Token = "0x60014A0")]
		[Address(RVA = "0x44C3B78", Offset = "0x44BFB78", VA = "0x44C3B78")]
		public static float3 MoveWithoutGravity(float3 position, in ResolvedMovement resolvedMovement, in AgentMovementPlane movementPlane, float dt)
		{
			return default;
		}

		[Token(Token = "0x60014A1")]
		[Address(RVA = "0x44C3C80", Offset = "0x44BFC80", VA = "0x44C3C80")]
		public static void ResolvePositionSmoothing(float3 movementDelta, ref MovementState state, in MovementSettings movementSettings, float dt)
		{
		}

		[Token(Token = "0x60014A2")]
		[Address(RVA = "0x44C3DEC", Offset = "0x44BFDEC", VA = "0x44C3DEC")]
		public void Execute(ref LocalTransform transform, in AgentCylinderShape shape, in AgentMovementPlane movementPlane, ref MovementState state, in MovementSettings movementSettings, in ResolvedMovement resolvedMovement, ref MovementStatistics movementStatistics)
		{
		}

		[Token(Token = "0x60014A3")]
		[Address(RVA = "0x44C3E08", Offset = "0x44BFE08", VA = "0x44C3E08")]
		public static void MoveAgent(ref LocalTransform transform, in AgentCylinderShape shape, in AgentMovementPlane movementPlane, ref MovementState state, in MovementSettings movementSettings, in ResolvedMovement resolvedMovement, ref MovementStatistics movementStatistics, float dt)
		{
		}

		[Token(Token = "0x60014BC")]
		[Address(RVA = "0x44C4740", Offset = "0x44C0740", VA = "0x44C4740", Slot = "4")]
void IJobChunk.Execute(in ArchetypeChunk chunk, int unfilteredChunkIndex, bool useEnabledMask, in v128 chunkEnabledMask)
		{
		}
	}
}
