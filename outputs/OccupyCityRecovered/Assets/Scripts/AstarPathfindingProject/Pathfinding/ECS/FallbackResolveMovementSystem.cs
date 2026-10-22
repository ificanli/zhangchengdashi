using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Pathfinding.ECS.RVO;
using Unity.Burst;
using Unity.Burst.Intrinsics;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;

namespace Pathfinding.ECS
{
	[Token(Token = "0x200036C")]
	[RequireMatchingQueriesForUpdate]
	[BurstCompile]
	[UpdateAfter(typeof(FollowerControlSystem))]
	[UpdateAfter(typeof(RVOSystem))]
	[UpdateInGroup(typeof(AIMovementSystemGroup))]
	public partial struct FallbackResolveMovementSystem : ISystem, ISystemCompilerGenerated
	{
		[Token(Token = "0x200036D")]
		[WithAll(new Type[] { typeof(SimulateMovement) })]
		[WithOptions(EntityQueryOptions.FilterWriteGroup)]
		[BurstCompile]
		public partial struct CopyJob : IJobEntity, IJobChunk
		{

			[Token(Token = "0x60015D9")]
			[Address(RVA = "0x44D1C90", Offset = "0x44CDC90", VA = "0x44D1C90")]
			public void Execute(in MovementControl control, ref ResolvedMovement resolved)
			{
            resolved.targetPoint = control.targetPoint;
                resolved.speed = control.speed;
                resolved.turningRadiusMultiplier = 1f;
        }

			[Token(Token = "0x60015F2")]
			[Address(RVA = "0x44D210C", Offset = "0x44CE10C", VA = "0x44D210C", Slot = "4")]
void IJobChunk.Execute(in ArchetypeChunk chunk, int unfilteredChunkIndex, bool useEnabledMask, in v128 chunkEnabledMask)
			{
            Execute(in chunk, unfilteredChunkIndex, useEnabledMask, in chunkEnabledMask);
        }
		}

		[Token(Token = "0x2000371")]
		[WithAll(new Type[] { typeof(SimulateMovement) })]
		[BurstCompile]
		public partial struct CopyRotationJob : IJobEntity, IJobChunk
		{

			[Token(Token = "0x60015FE")]
			[Address(RVA = "0x44D258C", Offset = "0x44CE58C", VA = "0x44D258C")]
			public void Execute(in MovementControl control, ref ResolvedMovement resolved)
			{
            resolved.targetRotation = control.targetRotation;
                resolved.targetRotationHint = control.targetRotationHint;
                resolved.targetRotationOffset = control.targetRotationOffset;
                resolved.rotationSpeed = control.rotationSpeed;
        }

			[Token(Token = "0x6001617")]
			[Address(RVA = "0x44D29F0", Offset = "0x44CE9F0", VA = "0x44D29F0", Slot = "4")]
void IJobChunk.Execute(in ArchetypeChunk chunk, int unfilteredChunkIndex, bool useEnabledMask, in v128 chunkEnabledMask)
			{
            Execute(in chunk, unfilteredChunkIndex, useEnabledMask, in chunkEnabledMask);
        }
		}

		[Token(Token = "0x2000375")]
		private struct TypeHandle
		{
			[Token(Token = "0x4000EFB")]
			[FieldOffset(Offset = "0x0")]
			public CopyJob.InternalCompilerQueryAndHandleData __Pathfinding_ECS_FallbackResolveMovementSystem_CopyJob_WithDefaultQuery_JobEntityTypeHandle;

			[Token(Token = "0x4000EFC")]
			[FieldOffset(Offset = "0x60")]
			public CopyRotationJob.InternalCompilerQueryAndHandleData __Pathfinding_ECS_FallbackResolveMovementSystem_CopyRotationJob_WithDefaultQuery_JobEntityTypeHandle;

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x6001623")]
			[Address(RVA = "0x44D2E5C", Offset = "0x44CEE5C", VA = "0x44D2E5C")]
			public void __AssignHandles(ref SystemState state)
			{
            __Pathfinding_ECS_FallbackResolveMovementSystem_CopyJob_WithDefaultQuery_JobEntityTypeHandle.Init(ref state, true);
                __Pathfinding_ECS_FallbackResolveMovementSystem_CopyRotationJob_WithDefaultQuery_JobEntityTypeHandle.Init(ref state, true);
        }
		}

		[Token(Token = "0x4000EF0")]
		[FieldOffset(Offset = "0x0")]
		private TypeHandle __TypeHandle;

		[Token(Token = "0x60015D2")]
		[Address(RVA = "0x44D184C", Offset = "0x44CD84C", VA = "0x44D184C", Slot = "6")]
		public void OnUpdate(ref SystemState systemState)
		{
            systemState.Dependency = __ScheduleViaJobChunkExtension_0(new CopyJob(), __TypeHandle.__Pathfinding_ECS_FallbackResolveMovementSystem_CopyJob_WithDefaultQuery_JobEntityTypeHandle.DefaultQuery,
                systemState.Dependency, ref systemState, false);
            systemState.Dependency = __ScheduleViaJobChunkExtension_1(new CopyRotationJob(), __TypeHandle.__Pathfinding_ECS_FallbackResolveMovementSystem_CopyRotationJob_WithDefaultQuery_JobEntityTypeHandle.DefaultQuery,
                systemState.Dependency, ref systemState, false);
        }

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60015D3")]
		[Address(RVA = "0x44D19BC", Offset = "0x44CD9BC", VA = "0x44D19BC")]
		private JobHandle __ScheduleViaJobChunkExtension_0(CopyJob job, EntityQuery query, JobHandle dependency, ref SystemState state, bool hasUserDefinedQuery)
		{
            __TypeHandle.__Pathfinding_ECS_FallbackResolveMovementSystem_CopyJob_WithDefaultQuery_JobEntityTypeHandle.__TypeHandle.Update(ref state);
            return __TypeHandle.__Pathfinding_ECS_FallbackResolveMovementSystem_CopyJob_WithDefaultQuery_JobEntityTypeHandle.ScheduleParallel(ref job, query, dependency);
        }

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60015D4")]
		[Address(RVA = "0x44D1ACC", Offset = "0x44CDACC", VA = "0x44D1ACC")]
		private JobHandle __ScheduleViaJobChunkExtension_1(CopyRotationJob job, EntityQuery query, JobHandle dependency, ref SystemState state, bool hasUserDefinedQuery)
		{
            __TypeHandle.__Pathfinding_ECS_FallbackResolveMovementSystem_CopyRotationJob_WithDefaultQuery_JobEntityTypeHandle.__TypeHandle.Update(ref state);
            return __TypeHandle.__Pathfinding_ECS_FallbackResolveMovementSystem_CopyRotationJob_WithDefaultQuery_JobEntityTypeHandle.ScheduleParallel(ref job, query, dependency);
        }

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60015D5")]
		[Address(RVA = "0x44D1BE0", Offset = "0x44CDBE0", VA = "0x44D1BE0")]
		private void __AssignQueries(ref SystemState state)
		{
            var builder = new EntityQueryBuilder(Allocator.Temp);
            builder.Dispose();
        }

		[Token(Token = "0x60015D6")]
		[Address(RVA = "0x44D1C20", Offset = "0x44CDC20", VA = "0x44D1C20", Slot = "7")]
		public void OnCreateForCompiler(ref SystemState state)
		{
            __AssignQueries(ref state);
            __TypeHandle.__Pathfinding_ECS_FallbackResolveMovementSystem_CopyJob_WithDefaultQuery_JobEntityTypeHandle.Init(ref state, true);
            __TypeHandle.__Pathfinding_ECS_FallbackResolveMovementSystem_CopyRotationJob_WithDefaultQuery_JobEntityTypeHandle.Init(ref state, true);
        }
	}
}
