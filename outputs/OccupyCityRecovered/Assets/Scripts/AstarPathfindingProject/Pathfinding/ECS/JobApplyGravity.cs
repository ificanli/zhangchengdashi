using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Burst.Intrinsics;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Transforms;
using UnityEngine;

namespace Pathfinding.ECS
{
	[Token(Token = "0x2000316")]
	[BurstCompile]
	public partial struct JobApplyGravity : IJobEntity, IJobChunk
	{

		[Token(Token = "0x4000DF2")]
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public NativeArray<RaycastHit> raycastHits;

		[Token(Token = "0x4000DF3")]
		[FieldOffset(Offset = "0x10")]
		[ReadOnly]
		public NativeArray<RaycastCommand> raycastCommands;

		[Token(Token = "0x4000DF4")]
		[FieldOffset(Offset = "0x20")]
		public float dt;

		[Token(Token = "0x6001329")]
		[Address(RVA = "0x44B70D4", Offset = "0x44B30D4", VA = "0x44B70D4")]
		private void ResolveGravity(RaycastHit hit, bool grounded, ref LocalTransform transform, in AgentMovementPlane movementPlane, ref GravityState gravityState)
		{
		}

		[Token(Token = "0x600132A")]
		[Address(RVA = "0x44B7280", Offset = "0x44B3280", VA = "0x44B7280")]
		public void Execute(ref LocalTransform transform, in MovementSettings movementSettings, ref AgentMovementPlane movementPlane, ref GravityState gravityState, in AgentMovementPlaneSource movementPlaneSource, [EntityIndexInQuery] int entityIndexInQuery)
		{
		}

		[Token(Token = "0x6001343")]
		[Address(RVA = "0x44B7A14", Offset = "0x44B3A14", VA = "0x44B7A14", Slot = "4")]
void IJobChunk.Execute(in ArchetypeChunk chunk, int unfilteredChunkIndex, bool useEnabledMask, in v128 chunkEnabledMask)
		{
		}
	}
}
