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
	[Token(Token = "0x2000394")]
	[BurstCompile]
	[UpdateBefore(typeof(TraverseOffMeshLinkSystem))]
	[UpdateBefore(typeof(RepairPathSystem))]
	[UpdateInGroup(typeof(AIMovementSystemGroup))]
	public partial struct SchedulePathSearchSystem : ISystem, ISystemCompilerGenerated
	{
		[Token(Token = "0x2000395")]
		[WithAbsent(new Type[] { typeof(ManagedAgentOffMeshLinkTraversal) })]
		[WithPresent(new Type[] { typeof(AgentShouldRecalculatePath) })]
		private partial struct JobCheckStaleness : IJobEntity, IJobEntityChunkBeginEnd, IJobChunk
		{

			[Token(Token = "0x4000F45")]
			[FieldOffset(Offset = "0x0")]
			public NativeBitArray isPathStale;

			[Token(Token = "0x4000F46")]
			[FieldOffset(Offset = "0x10")]
			private int index;

			[Token(Token = "0x60016E3")]
			[Address(RVA = "0x44DA100", Offset = "0x44D6100", VA = "0x44DA100")]
			public void Execute(ManagedState state)
			{
                int bitIndex = index;
                index = unchecked(index + 1);
                isPathStale.Set(bitIndex, state.pathTracer.isStale);
            }

			[Token(Token = "0x60016E4")]
			[Address(RVA = "0x44DA184", Offset = "0x44D6184", VA = "0x44DA184")]
			public bool OnChunkBegin(in ArchetypeChunk chunk, int unfilteredChunkIndex, bool useEnabledMask, in v128 chunkEnabledMask)
			{
                if (unchecked(index + chunk.Count) > isPathStale.Length)
                {
                    int mask = unchecked(index + chunk.Count - 1);
                    mask |= mask >> 1;
                    mask |= mask >> 2;
                    mask |= mask >> 4;
                    mask |= mask >> 8;
                    mask |= mask >> 16;
                    isPathStale.Resize(unchecked(mask + 1), NativeArrayOptions.ClearMemory);
                }
                return true;
            }

			[Token(Token = "0x60016E5")]
			[Address(RVA = "0x44DA210", Offset = "0x44D6210", VA = "0x44DA210")]
			public void OnChunkEnd(in ArchetypeChunk chunk, int unfilteredChunkIndex, bool useEnabledMask, in v128 chunkEnabledMask, bool chunkWasExecuted)
			{
			}

			[Token(Token = "0x60016FE")]
			[Address(RVA = "0x44DA5E4", Offset = "0x44D65E4", VA = "0x44DA5E4", Slot = "4")]
bool IJobEntityChunkBeginEnd.OnChunkBegin(in ArchetypeChunk chunk, int unfilteredChunkIndex, bool useEnabledMask, in v128 chunkEnabledMask)
			{
                OnChunkBegin(in chunk, unfilteredChunkIndex, useEnabledMask, in chunkEnabledMask);
                return true;
            }

			[Token(Token = "0x60016FF")]
			[Address(RVA = "0x44DA5FC", Offset = "0x44D65FC", VA = "0x44DA5FC", Slot = "5")]
void IJobEntityChunkBeginEnd.OnChunkEnd(in ArchetypeChunk chunk, int unfilteredChunkIndex, bool useEnabledMask, in v128 chunkEnabledMask, bool chunkWasExecuted)
			{
			}

			[Token(Token = "0x6001700")]
			[Address(RVA = "0x44DA600", Offset = "0x44D6600", VA = "0x44DA600", Slot = "6")]
void IJobChunk.Execute(in ArchetypeChunk chunk, int unfilteredChunkIndex, bool useEnabledMask, in v128 chunkEnabledMask)
			{ Execute(in chunk, unfilteredChunkIndex, useEnabledMask, in chunkEnabledMask); }
		}

		[Token(Token = "0x2000399")]
		[BurstCompile]
		[WithAbsent(new Type[] { typeof(ManagedAgentOffMeshLinkTraversal) })]
		[WithPresent(new Type[] { typeof(AgentShouldRecalculatePath) })]
		private partial struct JobShouldRecalculatePaths : IJobEntity, IJobChunk
		{

			[Token(Token = "0x4000F4C")]
			[FieldOffset(Offset = "0x0")]
			public float time;

			[Token(Token = "0x4000F4D")]
			[FieldOffset(Offset = "0x8")]
			public NativeBitArray isPathStale;

			[Token(Token = "0x4000F4E")]
			[FieldOffset(Offset = "0x18")]
			private int index;

			[Token(Token = "0x600170C")]
			[Address(RVA = "0x44DAA88", Offset = "0x44D6A88", VA = "0x44DAA88")]
			public void Execute(ref AutoRepathPolicy autoRepathPolicy, in LocalTransform transform, in AgentCylinderShape shape, in DestinationPoint destination, EnabledRefRW<AgentShouldRecalculatePath> shouldRecalculatePath)
			{
                int bitIndex = index;
                index = unchecked(index + 1);
                bool stale = isPathStale.IsSet(bitIndex);
                bool recalculate = autoRepathPolicy.ShouldRecalculatePath(transform.Position, shape.radius, destination.destination, time, stale);
                shouldRecalculatePath.ValueRW = recalculate;
            }

			[Token(Token = "0x6001725")]
			[Address(RVA = "0x44DB2AC", Offset = "0x44D72AC", VA = "0x44DB2AC", Slot = "4")]
void IJobChunk.Execute(in ArchetypeChunk chunk, int unfilteredChunkIndex, bool useEnabledMask, in v128 chunkEnabledMask)
			{ Execute(in chunk, unfilteredChunkIndex, useEnabledMask, in chunkEnabledMask); }
		}

		[Token(Token = "0x200039D")]
		[WithAll(new Type[] { typeof(AgentShouldRecalculatePath) })]
		[WithAbsent(new Type[] { typeof(ManagedAgentOffMeshLinkTraversal) })]
		public partial struct JobRecalculatePaths : IJobEntity, IJobChunk
		{

			[Token(Token = "0x4000F57")]
			[FieldOffset(Offset = "0x0")]
			public float time;

			[Token(Token = "0x6001731")]
			[Address(RVA = "0x44DB7E0", Offset = "0x44D77E0", VA = "0x44DB7E0")]
			public void Execute(ManagedState state, ManagedSettings settings, ref AutoRepathPolicy autoRepathPolicy, ref LocalTransform transform, ref DestinationPoint destination, ref AgentMovementPlane movementPlane)
			{
                MaybeRecalculatePath(state, settings, ref autoRepathPolicy, ref transform, ref destination, ref movementPlane, time, true);
            }

			[Token(Token = "0x6001732")]
			[Address(RVA = "0x44DB808", Offset = "0x44D7808", VA = "0x44DB808")]
			public static void MaybeRecalculatePath(ManagedState state, ManagedSettings settings, ref AutoRepathPolicy autoRepathPolicy, ref LocalTransform transform, ref DestinationPoint destination, ref AgentMovementPlane movementPlane, float time, bool wantsToRecalculatePath)
			{
                if (!wantsToRecalculatePath) return;
                if (state.pendingPath != null) return;
                ABPath path = ABPath.Construct((UnityEngine.Vector3)transform.Position, (UnityEngine.Vector3)destination.destination, null);
                path.UseSettings(settings.pathfindingSettings);
                path.nearestNodeDistanceMetric = DistanceMetric.ClosestAsSeenFromAboveSoft((UnityEngine.Vector3)movementPlane.value.up);
                ManagedState.SetPath(path, state, in movementPlane, ref destination);
                autoRepathPolicy.OnScheduledPathRecalculation(destination.destination, time);
            }

			[Token(Token = "0x600174B")]
			[Address(RVA = "0x44DC160", Offset = "0x44D8160", VA = "0x44DC160", Slot = "4")]
void IJobChunk.Execute(in ArchetypeChunk chunk, int unfilteredChunkIndex, bool useEnabledMask, in v128 chunkEnabledMask)
			{ Execute(in chunk, unfilteredChunkIndex, useEnabledMask, in chunkEnabledMask); }
		}

		[Token(Token = "0x20003A1")]
		private struct TypeHandle
		{
			[Token(Token = "0x4000F62")]
			[FieldOffset(Offset = "0x0")]
			public JobCheckStaleness.InternalCompilerQueryAndHandleData __Pathfinding_ECS_SchedulePathSearchSystem_JobCheckStaleness_WithDefaultQuery_JobEntityTypeHandle;

			[Token(Token = "0x4000F63")]
			[FieldOffset(Offset = "0x38")]
			public JobShouldRecalculatePaths.InternalCompilerQueryAndHandleData __Pathfinding_ECS_SchedulePathSearchSystem_JobShouldRecalculatePaths_WithDefaultQuery_JobEntityTypeHandle;

			[Token(Token = "0x4000F64")]
			[FieldOffset(Offset = "0x110")]
			public JobRecalculatePaths.InternalCompilerQueryAndHandleData __Pathfinding_ECS_SchedulePathSearchSystem_JobRecalculatePaths_WithDefaultQuery_JobEntityTypeHandle;

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x6001757")]
			[Address(RVA = "0x44DC7B0", Offset = "0x44D87B0", VA = "0x44DC7B0")]
			public void __AssignHandles(ref SystemState state)
			{
                __Pathfinding_ECS_SchedulePathSearchSystem_JobCheckStaleness_WithDefaultQuery_JobEntityTypeHandle.Init(ref state, true);
                __Pathfinding_ECS_SchedulePathSearchSystem_JobShouldRecalculatePaths_WithDefaultQuery_JobEntityTypeHandle.Init(ref state, true);
                __Pathfinding_ECS_SchedulePathSearchSystem_JobRecalculatePaths_WithDefaultQuery_JobEntityTypeHandle.Init(ref state, true);
            }
		}

		[Token(Token = "0x4000F43")]
		[FieldOffset(Offset = "0x0")]
		private TypeHandle __TypeHandle;

		[Token(Token = "0x4000F44")]
		[FieldOffset(Offset = "0x210")]
		private EntityQuery __query_376638600_0;

		[Token(Token = "0x60016DB")]
		[Address(RVA = "0x44D97D8", Offset = "0x44D57D8", VA = "0x44D97D8", Slot = "6")]
		public void OnUpdate(ref SystemState systemState)
		{
            if (AstarPath.active == null || !AIMovementSystemGroup.TimeScaledRateManager.IsFirstSubstep || __query_376638600_0.IsEmptyIgnoreFilter) return;
            NativeBitArray stale = new NativeBitArray(512, Allocator.TempJob, NativeArrayOptions.ClearMemory);
            systemState.CompleteDependency();
            PathProcessor.GraphUpdateLock graphLock = AstarPath.active.PausePathfindingSoon();
            JobCheckStaleness checkStaleness = new JobCheckStaleness { isPathStale = stale };
            __ScheduleViaJobChunkExtension_0(checkStaleness, __TypeHandle.__Pathfinding_ECS_SchedulePathSearchSystem_JobCheckStaleness_WithDefaultQuery_JobEntityTypeHandle.DefaultQuery, systemState.Dependency, ref systemState, false);
            JobShouldRecalculatePaths shouldRecalculate = new JobShouldRecalculatePaths
            {
                time = (float)systemState.WorldUnmanaged.Time.ElapsedTime,
                isPathStale = stale
            };
            __ScheduleViaJobChunkExtension_1(shouldRecalculate, __TypeHandle.__Pathfinding_ECS_SchedulePathSearchSystem_JobShouldRecalculatePaths_WithDefaultQuery_JobEntityTypeHandle.DefaultQuery, systemState.Dependency, ref systemState, false);
            JobRecalculatePaths recalculate = new JobRecalculatePaths { time = (float)systemState.WorldUnmanaged.Time.ElapsedTime };
            __ScheduleViaJobChunkExtension_2(recalculate, __TypeHandle.__Pathfinding_ECS_SchedulePathSearchSystem_JobRecalculatePaths_WithDefaultQuery_JobEntityTypeHandle.DefaultQuery, systemState.Dependency, ref systemState, false);
            graphLock.Release();
            stale.Dispose();
        }

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60016DC")]
		[Address(RVA = "0x44D9BD4", Offset = "0x44D5BD4", VA = "0x44D9BD4")]
		private void __ScheduleViaJobChunkExtension_0(JobCheckStaleness job, EntityQuery query, JobHandle dependency, ref SystemState state, bool hasUserDefinedQuery)
		{
            job.__EntityManager = state.EntityManager;
            __TypeHandle.__Pathfinding_ECS_SchedulePathSearchSystem_JobCheckStaleness_WithDefaultQuery_JobEntityTypeHandle.__TypeHandle.Update(ref state);
            job.__TypeHandle = __TypeHandle.__Pathfinding_ECS_SchedulePathSearchSystem_JobCheckStaleness_WithDefaultQuery_JobEntityTypeHandle.__TypeHandle;
            Unity.Entities.Internal.InternalCompilerInterface.JobChunkInterface.RunByRefWithoutJobs(ref job, query);
        }

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60016DD")]
		[Address(RVA = "0x44D9CB4", Offset = "0x44D5CB4", VA = "0x44D9CB4")]
		private void __ScheduleViaJobChunkExtension_1(JobShouldRecalculatePaths job, EntityQuery query, JobHandle dependency, ref SystemState state, bool hasUserDefinedQuery)
		{
            __TypeHandle.__Pathfinding_ECS_SchedulePathSearchSystem_JobShouldRecalculatePaths_WithDefaultQuery_JobEntityTypeHandle.__TypeHandle.Update(ref state);
            job.__TypeHandle = __TypeHandle.__Pathfinding_ECS_SchedulePathSearchSystem_JobShouldRecalculatePaths_WithDefaultQuery_JobEntityTypeHandle.__TypeHandle;
            Unity.Entities.JobChunkExtensions.RunByRef(ref job, query);
        }

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60016DE")]
		[Address(RVA = "0x44D9E2C", Offset = "0x44D5E2C", VA = "0x44D9E2C")]
		private void __ScheduleViaJobChunkExtension_2(JobRecalculatePaths job, EntityQuery query, JobHandle dependency, ref SystemState state, bool hasUserDefinedQuery)
		{
            job.__EntityManager = state.EntityManager;
            __TypeHandle.__Pathfinding_ECS_SchedulePathSearchSystem_JobRecalculatePaths_WithDefaultQuery_JobEntityTypeHandle.__TypeHandle.Update(ref state);
            job.__TypeHandle = __TypeHandle.__Pathfinding_ECS_SchedulePathSearchSystem_JobRecalculatePaths_WithDefaultQuery_JobEntityTypeHandle.__TypeHandle;
            Unity.Entities.Internal.InternalCompilerInterface.JobChunkInterface.RunByRefWithoutJobs(ref job, query);
        }

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60016DF")]
		[Address(RVA = "0x44D9FD0", Offset = "0x44D5FD0", VA = "0x44D9FD0")]
		private void __AssignQueries(ref SystemState state)
		{
            EntityQueryBuilder builder = new EntityQueryBuilder(Allocator.Temp);
            __query_376638600_0 = builder.WithAll<ManagedState>().Build(ref state);
            builder.Reset();
            builder.Dispose();
        }

		[Token(Token = "0x60016E0")]
		[Address(RVA = "0x44DA088", Offset = "0x44D6088", VA = "0x44DA088", Slot = "7")]
		public void OnCreateForCompiler(ref SystemState state)
		{
            __AssignQueries(ref state);
            __TypeHandle.__AssignHandles(ref state);
        }
	}
}
