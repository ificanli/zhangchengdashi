using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Transforms;

namespace Pathfinding.ECS
{
	[Token(Token = "0x200037A")]
	[UpdateInGroup(typeof(AIMovementSystemGroup))]
	[RequireMatchingQueriesForUpdate]
	[UpdateAfter(typeof(AIMoveSystem))]
	[UpdateAfter(typeof(MovementStatisticsSystem))]
	public partial struct LateSyncSystem : ISystem, ISystemCompilerGenerated
	{
		[Token(Token = "0x200037B")]
		private struct TypeHandle
		{
			[Token(Token = "0x4000F0C")]
			[FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public ComponentLookup<SyncPositionWithTransform> __Pathfinding_ECS_SyncPositionWithTransform_RO_ComponentLookup;

			[Token(Token = "0x4000F0D")]
			[FieldOffset(Offset = "0x28")]
			[ReadOnly]
			public ComponentLookup<SyncRotationWithTransform> __Pathfinding_ECS_SyncRotationWithTransform_RO_ComponentLookup;

			[Token(Token = "0x4000F0E")]
			[FieldOffset(Offset = "0x50")]
			[ReadOnly]
			public ComponentLookup<OrientationYAxisForward> __Pathfinding_ECS_OrientationYAxisForward_RO_ComponentLookup;

			[Token(Token = "0x4000F0F")]
			[FieldOffset(Offset = "0x78")]
			[ReadOnly]
			public ComponentLookup<LocalTransform> __Unity_Transforms_LocalTransform_RO_ComponentLookup;

			[Token(Token = "0x4000F10")]
			[FieldOffset(Offset = "0xA0")]
			[ReadOnly]
			public ComponentLookup<MovementState> __Pathfinding_ECS_MovementState_RO_ComponentLookup;

			[Token(Token = "0x4000F11")]
			[FieldOffset(Offset = "0xC8")]
			public JobClearTemporaryData.InternalCompilerQueryAndHandleData __Pathfinding_ECS_JobClearTemporaryData_WithDefaultQuery_JobEntityTypeHandle;

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x6001645")]
			[Address(RVA = "0x44D49CC", Offset = "0x44D09CC", VA = "0x44D49CC")]
			public void __AssignHandles(ref SystemState state)
			{
            __Pathfinding_ECS_SyncPositionWithTransform_RO_ComponentLookup = state.GetComponentLookup<SyncPositionWithTransform>(true);
__Pathfinding_ECS_SyncRotationWithTransform_RO_ComponentLookup = state.GetComponentLookup<SyncRotationWithTransform>(true);
__Pathfinding_ECS_OrientationYAxisForward_RO_ComponentLookup = state.GetComponentLookup<OrientationYAxisForward>(true);
__Unity_Transforms_LocalTransform_RO_ComponentLookup = state.GetComponentLookup<LocalTransform>(true);
__Pathfinding_ECS_MovementState_RO_ComponentLookup = state.GetComponentLookup<MovementState>(true);
__Pathfinding_ECS_JobClearTemporaryData_WithDefaultQuery_JobEntityTypeHandle.Init(ref state, true);
        }
		}

		[Token(Token = "0x4000F09")]
		[FieldOffset(Offset = "0x0")]
		private JobRepairPath.Scheduler jobRepairPathScheduler;

		[Token(Token = "0x4000F0A")]
		[FieldOffset(Offset = "0x178")]
		private EntityQuery entityQueryPrepareMovement;

		[Token(Token = "0x4000F0B")]
		[FieldOffset(Offset = "0x188")]
		private TypeHandle __TypeHandle;

		[Token(Token = "0x6001639")]
		[Address(RVA = "0x44D42EC", Offset = "0x44D02EC", VA = "0x44D42EC", Slot = "4")]
		public void OnCreate(ref SystemState systemState)
		{
            jobRepairPathScheduler = new JobRepairPath.Scheduler(ref systemState);
            var builder = jobRepairPathScheduler.GetEntityQuery(Allocator.Temp).WithAll<SimulateMovement, SimulateMovementRepair>();
            entityQueryPrepareMovement = builder.Build(ref systemState);
        }

		[Token(Token = "0x600163A")]
		[Address(RVA = "0x44D43B0", Offset = "0x44D03B0", VA = "0x44D43B0", Slot = "5")]
		public void OnDestroy(ref SystemState systemState)
		{
            jobRepairPathScheduler.Dispose();
        }

		[Token(Token = "0x600163B")]
		[Address(RVA = "0x44D43B8", Offset = "0x44D03B8", VA = "0x44D43B8", Slot = "6")]
		public void OnUpdate(ref SystemState systemState)
		{
            systemState.Dependency = jobRepairPathScheduler.ScheduleParallel(ref systemState, entityQueryPrepareMovement, systemState.Dependency);
            systemState.Dependency = ScheduleSyncEntitiesToTransforms(ref systemState, systemState.Dependency);
            systemState.Dependency = __ScheduleViaJobChunkExtension_0(new JobClearTemporaryData(), __TypeHandle.__Pathfinding_ECS_JobClearTemporaryData_WithDefaultQuery_JobEntityTypeHandle.DefaultQuery, systemState.Dependency, ref systemState, false);
        }

		[Token(Token = "0x600163C")]
		[Address(RVA = "0x44D450C", Offset = "0x44D050C", VA = "0x44D450C")]
		private JobHandle ScheduleRepairPaths(ref SystemState systemState, JobHandle dependency)
		{
            return jobRepairPathScheduler.ScheduleParallel(ref systemState, entityQueryPrepareMovement, dependency);
        }

		[Token(Token = "0x600163D")]
		[Address(RVA = "0x44D4520", Offset = "0x44D0520", VA = "0x44D4520")]
		private JobHandle ScheduleSyncEntitiesToTransforms(ref SystemState systemState, JobHandle dependency)
		{
            UnityEngine.Jobs.TransformAccessArray transforms;
            FollowerEntity[] components;
            int count = Pathfinding.Util.BatchedEvents.GetComponents<FollowerEntity>(Pathfinding.Util.BatchedEvents.Event.None, out transforms, out components);
            if (count < 1) return dependency;
            var entities = Unity.Collections.CollectionHelper.CreateNativeArray<Entity>(count, systemState.WorldUpdateAllocator, NativeArrayOptions.ClearMemory);
            for (int i = 0; i < count; i++) entities[i] = components[i].entity;
            __TypeHandle.__Pathfinding_ECS_SyncPositionWithTransform_RO_ComponentLookup.Update(ref systemState);
            __TypeHandle.__Pathfinding_ECS_SyncRotationWithTransform_RO_ComponentLookup.Update(ref systemState);
            __TypeHandle.__Pathfinding_ECS_OrientationYAxisForward_RO_ComponentLookup.Update(ref systemState);
            __TypeHandle.__Unity_Transforms_LocalTransform_RO_ComponentLookup.Update(ref systemState);
            __TypeHandle.__Pathfinding_ECS_MovementState_RO_ComponentLookup.Update(ref systemState);
            var job = new JobSyncEntitiesToTransforms {
                entities = entities,
                entityPositions = __TypeHandle.__Unity_Transforms_LocalTransform_RO_ComponentLookup,
                movementState = __TypeHandle.__Pathfinding_ECS_MovementState_RO_ComponentLookup,
                syncPositionWithTransform = __TypeHandle.__Pathfinding_ECS_SyncPositionWithTransform_RO_ComponentLookup,
                syncRotationWithTransform = __TypeHandle.__Pathfinding_ECS_SyncRotationWithTransform_RO_ComponentLookup,
                orientationYAxisForward = __TypeHandle.__Pathfinding_ECS_OrientationYAxisForward_RO_ComponentLookup
            };
            return UnityEngine.Jobs.IJobParallelForTransformExtensions.Schedule(job, transforms, dependency);
        }

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600163E")]
		[Address(RVA = "0x44D4890", Offset = "0x44D0890", VA = "0x44D4890")]
		private JobHandle __ScheduleViaJobChunkExtension_0(JobClearTemporaryData job, EntityQuery query, JobHandle dependency, ref SystemState state, bool hasUserDefinedQuery)
		{
            __TypeHandle.__Pathfinding_ECS_JobClearTemporaryData_WithDefaultQuery_JobEntityTypeHandle.__TypeHandle.Update(ref state);
            return __TypeHandle.__Pathfinding_ECS_JobClearTemporaryData_WithDefaultQuery_JobEntityTypeHandle.ScheduleParallel(ref job, query, dependency);
        }

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600163F")]
		[Address(RVA = "0x44D492C", Offset = "0x44D092C", VA = "0x44D492C")]
		private void __AssignQueries(ref SystemState state)
		{
            var builder = new EntityQueryBuilder(Allocator.Temp);
            builder.Dispose();
        }

		[Token(Token = "0x6001640")]
		[Address(RVA = "0x44D496C", Offset = "0x44D096C", VA = "0x44D496C", Slot = "7")]
		public void OnCreateForCompiler(ref SystemState state)
		{
            __AssignQueries(ref state);
            __TypeHandle.__AssignHandles(ref state);
        }
	}
}
