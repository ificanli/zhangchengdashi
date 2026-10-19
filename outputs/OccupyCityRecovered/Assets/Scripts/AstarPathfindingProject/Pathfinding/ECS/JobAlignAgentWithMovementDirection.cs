using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Burst.Intrinsics;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Transforms;

namespace Pathfinding.ECS
{
	[Token(Token = "0x2000312")]
	[BurstCompile]
	[WithAll(new Type[] { typeof(SimulateMovement) })]
	public partial struct JobAlignAgentWithMovementDirection : IJobEntity, IJobChunk
	{

		[Token(Token = "0x4000DE7")]
		[FieldOffset(Offset = "0x0")]
		public float dt;

		[Token(Token = "0x6001304")]
		[Address(RVA = "0x44B5E40", Offset = "0x44B1E40", VA = "0x44B5E40")]
		public void Execute(ref LocalTransform transform, in MovementSettings movementSettings, in MovementState movementState, in AgentCylinderShape shape, in AgentMovementPlane movementPlane, in MovementControl movementControl, ref ResolvedMovement resolvedMovement)
		{
		}

		[Token(Token = "0x600131D")]
		[Address(RVA = "0x44B697C", Offset = "0x44B297C", VA = "0x44B697C", Slot = "4")]
void IJobChunk.Execute(in ArchetypeChunk chunk, int unfilteredChunkIndex, bool useEnabledMask, in v128 chunkEnabledMask)
		{
		}
	}
}
