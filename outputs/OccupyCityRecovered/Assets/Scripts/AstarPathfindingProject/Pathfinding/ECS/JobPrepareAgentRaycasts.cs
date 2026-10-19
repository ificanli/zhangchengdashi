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
	[Token(Token = "0x2000344")]
	[BurstCompile]
	public partial struct JobPrepareAgentRaycasts : IJobEntity, IJobChunk
	{

		[Token(Token = "0x4000E7C")]
		[FieldOffset(Offset = "0x0")]
		public NativeArray<RaycastCommand> raycastCommands;

		[Token(Token = "0x4000E7D")]
		[FieldOffset(Offset = "0x10")]
		public QueryParameters raycastQueryParameters;

		[Token(Token = "0x4000E7E")]
		[FieldOffset(Offset = "0x20")]
		public float dt;

		[Token(Token = "0x4000E7F")]
		[FieldOffset(Offset = "0x24")]
		public float gravity;

		[Token(Token = "0x60014C8")]
		[Address(RVA = "0x44C4EE8", Offset = "0x44C0EE8", VA = "0x44C4EE8")]
		private void ApplyGravity(ref GravityState gravityState)
		{
		}

		[Token(Token = "0x60014C9")]
		[Address(RVA = "0x44C4F00", Offset = "0x44C0F00", VA = "0x44C4F00")]
		private RaycastCommand CalculateRaycastCommands(ref LocalTransform transform, in AgentCylinderShape shape, in AgentMovementPlane movementPlane, in MovementSettings movementSettings, ref GravityState gravityState, PhysicsScene physicsScene)
		{
			return default;
		}

		[Token(Token = "0x60014CA")]
		[Address(RVA = "0x44C50C0", Offset = "0x44C10C0", VA = "0x44C50C0")]
		public void Execute(ref LocalTransform transform, in AgentCylinderShape shape, in AgentMovementPlane movementPlane, ref MovementState state, in MovementSettings movementSettings, ref ResolvedMovement resolvedMovement, ref MovementStatistics movementStatistics, ref GravityState gravityState, in PhysicsSceneRef physicsWorldIndex, [EntityIndexInQuery] int entityIndexInQuery)
		{
		}

		[Token(Token = "0x60014E3")]
		[Address(RVA = "0x44C5AB8", Offset = "0x44C1AB8", VA = "0x44C5AB8", Slot = "4")]
void IJobChunk.Execute(in ArchetypeChunk chunk, int unfilteredChunkIndex, bool useEnabledMask, in v128 chunkEnabledMask)
		{
		}
	}
}
