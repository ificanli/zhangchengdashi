using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Pathfinding.Drawing;
using Unity.Burst;
using Unity.Entities;
using Unity.Jobs;
using Unity.Profiling;

namespace Pathfinding.ECS
{
	[Token(Token = "0x2000376")]
	[BurstCompile]
	[UpdateInGroup(typeof(AIMovementSystemGroup))]
	public partial struct FollowerControlSystem : ISystem, ISystemCompilerGenerated
	{
		[Token(Token = "0x2000377")]
		private struct TypeHandle
		{
			[Token(Token = "0x4000F04")]
			[FieldOffset(Offset = "0x0")]
			public JobManagedMovementOverrideBeforeControl.InternalCompilerQueryAndHandleData __Pathfinding_ECS_JobManagedMovementOverrideBeforeControl_WithoutDefaultQuery_JobEntityTypeHandle;

			[Token(Token = "0x4000F05")]
			[FieldOffset(Offset = "0x130")]
			public JobControl.InternalCompilerQueryAndHandleData __Pathfinding_ECS_JobControl_WithDefaultQuery_JobEntityTypeHandle;

			[Token(Token = "0x4000F06")]
			[FieldOffset(Offset = "0x280")]
			public JobManagedMovementOverrideAfterControl.InternalCompilerQueryAndHandleData __Pathfinding_ECS_JobManagedMovementOverrideAfterControl_WithoutDefaultQuery_JobEntityTypeHandle;

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x6001632")]
			[Address(RVA = "0x44D3F88", Offset = "0x44CFF88", VA = "0x44D3F88")]
			public void __AssignHandles(ref SystemState state)
			{
            __Pathfinding_ECS_JobManagedMovementOverrideBeforeControl_WithoutDefaultQuery_JobEntityTypeHandle.Init(ref state, false);
                __Pathfinding_ECS_JobControl_WithDefaultQuery_JobEntityTypeHandle.Init(ref state, true);
                __Pathfinding_ECS_JobManagedMovementOverrideAfterControl_WithoutDefaultQuery_JobEntityTypeHandle.Init(ref state, false);
        }
		}

		[Token(Token = "0x4000EFD")]
		[FieldOffset(Offset = "0x0")]
		private EntityQuery entityQueryControlManaged;

		[Token(Token = "0x4000EFE")]
		[FieldOffset(Offset = "0x10")]
		private EntityQuery entityQueryControlManaged2;

		[Token(Token = "0x4000EFF")]
		[FieldOffset(Offset = "0x20")]
		private RedrawScope redrawScope;

		[Token(Token = "0x4000F00")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ProfilerMarker MarkerMovementOverrideBeforeControl = new ProfilerMarker("MovementOverrideBeforeControl");

		[Token(Token = "0x4000F01")]
		[FieldOffset(Offset = "0x8")]
		private static readonly ProfilerMarker MarkerMovementOverrideAfterControl = new ProfilerMarker("MovementOverrideAfterControl");

		[Token(Token = "0x4000F02")]
		[FieldOffset(Offset = "0x30")]
		private TypeHandle __TypeHandle;

		[Token(Token = "0x4000F03")]
		[FieldOffset(Offset = "0x408")]
		private EntityQuery __query_248260819_0;

		[Token(Token = "0x6001624")]
		[Address(RVA = "0x44D300C", Offset = "0x44CF00C", VA = "0x44D300C", Slot = "4")]
		public void OnCreate(ref SystemState state)
		{
            redrawScope = DrawingManager.GetRedrawScope(null);
            entityQueryControlManaged = state.GetEntityQuery(new ComponentType[] {
                ComponentType.ReadWrite<ManagedMovementOverrideBeforeControl>(),
                ComponentType.ReadWrite<Unity.Transforms.LocalTransform>(),
                ComponentType.ReadWrite<AgentCylinderShape>(),
                ComponentType.ReadWrite<AgentMovementPlane>(),
                ComponentType.ReadWrite<DestinationPoint>(),
                ComponentType.ReadWrite<MovementState>(),
                ComponentType.ReadWrite<MovementStatistics>(),
                ComponentType.ReadWrite<ManagedState>(),
                ComponentType.ReadWrite<MovementSettings>(),
                ComponentType.ReadWrite<ResolvedMovement>(),
                ComponentType.ReadWrite<MovementControl>(),
                ComponentType.Exclude<AgentOffMeshLinkTraversal>(),
                ComponentType.ReadOnly<SimulateMovement>(),
                ComponentType.ReadOnly<SimulateMovementControl>()
            });
            entityQueryControlManaged2 = state.GetEntityQuery(new ComponentType[] {
                ComponentType.ReadWrite<ManagedMovementOverrideAfterControl>(),
                ComponentType.ReadWrite<Unity.Transforms.LocalTransform>(),
                ComponentType.ReadWrite<AgentCylinderShape>(),
                ComponentType.ReadWrite<AgentMovementPlane>(),
                ComponentType.ReadWrite<DestinationPoint>(),
                ComponentType.ReadWrite<MovementState>(),
                ComponentType.ReadWrite<MovementStatistics>(),
                ComponentType.ReadWrite<ManagedState>(),
                ComponentType.ReadWrite<MovementSettings>(),
                ComponentType.ReadWrite<ResolvedMovement>(),
                ComponentType.ReadWrite<MovementControl>(),
                ComponentType.Exclude<AgentOffMeshLinkTraversal>(),
                ComponentType.ReadOnly<SimulateMovement>(),
                ComponentType.ReadOnly<SimulateMovementControl>()
            });
        }

		[Token(Token = "0x6001625")]
		[Address(RVA = "0x44D3524", Offset = "0x44CF524", VA = "0x44D3524", Slot = "5")]
		public void OnDestroy(ref SystemState state)
		{
            redrawScope.Dispose();
        }

		[Token(Token = "0x6001626")]
		[Address(RVA = "0x44D357C", Offset = "0x44CF57C", VA = "0x44D357C", Slot = "6")]
		public void OnUpdate(ref SystemState systemState)
		{
            if (AstarPath.active == null || __query_248260819_0.IsEmptyIgnoreFilter) return;
            ProcessControlLoop(ref systemState, AIMovementSystemGroup.TimeScaledRateManager.CheapStepDeltaTime);
        }

		[Token(Token = "0x6001627")]
		[Address(RVA = "0x44D3684", Offset = "0x44CF684", VA = "0x44D3684")]
		private void ProcessControlLoop(ref SystemState systemState, float dt)
		{
            if (!entityQueryControlManaged.IsEmpty)
            {
                systemState.Dependency.Complete();
                __ScheduleViaJobChunkExtension_0(new JobManagedMovementOverrideBeforeControl { dt = dt },
                    entityQueryControlManaged, systemState.Dependency, ref systemState, true);
            }
            redrawScope.Rewind();
            CommandBuilder builder = DrawingManager.GetBuilder(redrawScope, false);
            NavmeshEdges.NavmeshBorderData borderData = AstarPath.active.GetNavmeshBorderData(out Pathfinding.Sync.RWLock.CombinedReadLockAsync readLock);
            var job = new JobControl { dt = dt, draw = builder, navmeshEdgeData = borderData };
            systemState.Dependency = __ScheduleViaJobChunkExtension_1(job,
                __TypeHandle.__Pathfinding_ECS_JobControl_WithDefaultQuery_JobEntityTypeHandle.DefaultQuery,
                JobHandle.CombineDependencies(systemState.Dependency, readLock.dependency), ref systemState, false);
            readLock.UnlockAfter(systemState.Dependency);
            builder.DisposeAfter(systemState.Dependency, AllowedDelay.EndOfFrame);
            if (!entityQueryControlManaged2.IsEmpty)
            {
                systemState.Dependency.Complete();
                __ScheduleViaJobChunkExtension_2(new JobManagedMovementOverrideAfterControl { dt = dt },
                    entityQueryControlManaged2, systemState.Dependency, ref systemState, true);
            }
        }

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6001628")]
		[Address(RVA = "0x44D3BC4", Offset = "0x44CFBC4", VA = "0x44D3BC4")]
		private void __ScheduleViaJobChunkExtension_0(JobManagedMovementOverrideBeforeControl job, EntityQuery query, JobHandle dependency, ref SystemState state, bool hasUserDefinedQuery)
		{
            __TypeHandle.__Pathfinding_ECS_JobManagedMovementOverrideBeforeControl_WithoutDefaultQuery_JobEntityTypeHandle.AssignEntityManager(ref job, state.EntityManager);
            __TypeHandle.__Pathfinding_ECS_JobManagedMovementOverrideBeforeControl_WithoutDefaultQuery_JobEntityTypeHandle.__TypeHandle.Update(ref state);
            __TypeHandle.__Pathfinding_ECS_JobManagedMovementOverrideBeforeControl_WithoutDefaultQuery_JobEntityTypeHandle.Run(ref job, query);
        }

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6001629")]
		[Address(RVA = "0x44D3C50", Offset = "0x44CFC50", VA = "0x44D3C50")]
		private JobHandle __ScheduleViaJobChunkExtension_1(JobControl job, EntityQuery query, JobHandle dependency, ref SystemState state, bool hasUserDefinedQuery)
		{
            __TypeHandle.__Pathfinding_ECS_JobControl_WithDefaultQuery_JobEntityTypeHandle.__TypeHandle.Update(ref state);
            return __TypeHandle.__Pathfinding_ECS_JobControl_WithDefaultQuery_JobEntityTypeHandle.ScheduleParallel(ref job, query, dependency);
        }

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600162A")]
		[Address(RVA = "0x44D3CEC", Offset = "0x44CFCEC", VA = "0x44D3CEC")]
		private void __ScheduleViaJobChunkExtension_2(JobManagedMovementOverrideAfterControl job, EntityQuery query, JobHandle dependency, ref SystemState state, bool hasUserDefinedQuery)
		{
            __TypeHandle.__Pathfinding_ECS_JobManagedMovementOverrideAfterControl_WithoutDefaultQuery_JobEntityTypeHandle.AssignEntityManager(ref job, state.EntityManager);
            __TypeHandle.__Pathfinding_ECS_JobManagedMovementOverrideAfterControl_WithoutDefaultQuery_JobEntityTypeHandle.__TypeHandle.Update(ref state);
            __TypeHandle.__Pathfinding_ECS_JobManagedMovementOverrideAfterControl_WithoutDefaultQuery_JobEntityTypeHandle.Run(ref job, query);
        }

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600162B")]
		[Address(RVA = "0x44D3D78", Offset = "0x44CFD78", VA = "0x44D3D78")]
		private void __AssignQueries(ref SystemState state)
		{
            var builder = new Unity.Entities.EntityQueryBuilder(Unity.Collections.Allocator.Temp);
            __query_248260819_0 = builder.WithAll<MovementState>().Build(ref state);
            builder.Reset();
            builder.Dispose();
        }

		[Token(Token = "0x600162C")]
		[Address(RVA = "0x44D3E30", Offset = "0x44CFE30", VA = "0x44D3E30", Slot = "7")]
		public void OnCreateForCompiler(ref SystemState state)
		{
            __AssignQueries(ref state);
            __TypeHandle.__Pathfinding_ECS_JobManagedMovementOverrideBeforeControl_WithoutDefaultQuery_JobEntityTypeHandle.Init(ref state, false);
            __TypeHandle.__Pathfinding_ECS_JobControl_WithDefaultQuery_JobEntityTypeHandle.Init(ref state, true);
            __TypeHandle.__Pathfinding_ECS_JobManagedMovementOverrideAfterControl_WithoutDefaultQuery_JobEntityTypeHandle.Init(ref state, false);
        }
	}
}
