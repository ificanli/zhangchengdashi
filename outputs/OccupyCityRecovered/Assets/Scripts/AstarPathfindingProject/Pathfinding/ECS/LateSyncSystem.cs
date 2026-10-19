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
		}

		[Token(Token = "0x600163A")]
		[Address(RVA = "0x44D43B0", Offset = "0x44D03B0", VA = "0x44D43B0", Slot = "5")]
		public void OnDestroy(ref SystemState systemState)
		{
		}

		[Token(Token = "0x600163B")]
		[Address(RVA = "0x44D43B8", Offset = "0x44D03B8", VA = "0x44D43B8", Slot = "6")]
		public void OnUpdate(ref SystemState systemState)
		{
		}

		[Token(Token = "0x600163C")]
		[Address(RVA = "0x44D450C", Offset = "0x44D050C", VA = "0x44D450C")]
		private JobHandle ScheduleRepairPaths(ref SystemState systemState, JobHandle dependency)
		{
			return default;
		}

		[Token(Token = "0x600163D")]
		[Address(RVA = "0x44D4520", Offset = "0x44D0520", VA = "0x44D4520")]
		private JobHandle ScheduleSyncEntitiesToTransforms(ref SystemState systemState, JobHandle dependency)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600163E")]
		[Address(RVA = "0x44D4890", Offset = "0x44D0890", VA = "0x44D4890")]
		private JobHandle __ScheduleViaJobChunkExtension_0(JobClearTemporaryData job, EntityQuery query, JobHandle dependency, ref SystemState state, bool hasUserDefinedQuery)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600163F")]
		[Address(RVA = "0x44D492C", Offset = "0x44D092C", VA = "0x44D492C")]
		private void __AssignQueries(ref SystemState state)
		{
		}

		[Token(Token = "0x6001640")]
		[Address(RVA = "0x44D496C", Offset = "0x44D096C", VA = "0x44D496C", Slot = "7")]
		public void OnCreateForCompiler(ref SystemState state)
		{
		}
	}
}
