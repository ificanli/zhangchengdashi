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
	[Token(Token = "0x2000351")]
	[WithAll(new Type[] { typeof(SimulateMovement) })]
	[BurstCompile]
	public partial struct JobUpdateMovementStatistics : IJobEntity, IJobChunk
	{

		[Token(Token = "0x4000EB3")]
		[FieldOffset(Offset = "0x0")]
		public float dt;

		[Token(Token = "0x6001510")]
		[Address(RVA = "0x44CBC64", Offset = "0x44C7C64", VA = "0x44CBC64")]
		private static void UpdateStatistics(in LocalTransform transform, ref MovementStatistics movementStatistics, float dt)
		{
            if (!(dt <= 1e-6f)) {
                movementStatistics.estimatedVelocity = (transform.Position - movementStatistics.lastPosition) / dt;
            }
            movementStatistics.lastPosition = transform.Position;
        }

		[Token(Token = "0x6001511")]
		[Address(RVA = "0x44CBCB4", Offset = "0x44C7CB4", VA = "0x44CBCB4")]
		public void Execute(in LocalTransform transform, ref MovementStatistics movementStatistics)
		{
            UpdateStatistics(in transform, ref movementStatistics, dt);
        }

		[Token(Token = "0x600152A")]
		[Address(RVA = "0x44CC134", Offset = "0x44C8134", VA = "0x44CC134", Slot = "4")]
void IJobChunk.Execute(in ArchetypeChunk chunk, int unfilteredChunkIndex, bool useEnabledMask, in v128 chunkEnabledMask)
		{ Execute(in chunk, unfilteredChunkIndex, useEnabledMask, in chunkEnabledMask); }
	}
}
