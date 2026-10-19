using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Pathfinding.ECS.RVO;
using Unity.Burst;
using Unity.Entities;
using Unity.Jobs;
using Unity.Profiling;

namespace Pathfinding.ECS
{
	[Token(Token = "0x200035A")]
	[BurstCompile]
	[RequireMatchingQueriesForUpdate]
	[UpdateInGroup(typeof(AIMovementSystemGroup))]
	[UpdateAfter(typeof(FallbackResolveMovementSystem))]
	[UpdateAfter(typeof(RVOSystem))]
	[UpdateAfter(typeof(FollowerControlSystem))]
	public partial struct AIMoveSystem : ISystem, ISystemCompilerGenerated
	{
		[Token(Token = "0x200035B")]
		private struct TypeHandle
		{
			[Token(Token = "0x4000ED4")]
			[FieldOffset(Offset = "0x0")]
			public JobAlignAgentWithMovementDirection.InternalCompilerQueryAndHandleData __Pathfinding_ECS_JobAlignAgentWithMovementDirection_WithDefaultQuery_JobEntityTypeHandle;

			[Token(Token = "0x4000ED5")]
			[FieldOffset(Offset = "0x128")]
			public JobMoveAgent.InternalCompilerQueryAndHandleData __Pathfinding_ECS_JobMoveAgent_WithDefaultQuery_JobEntityTypeHandle;

			[Token(Token = "0x4000ED6")]
			[FieldOffset(Offset = "0x250")]
			public JobPrepareAgentRaycasts.InternalCompilerQueryAndHandleData __Pathfinding_ECS_JobPrepareAgentRaycasts_WithoutDefaultQuery_JobEntityTypeHandle;

			[Token(Token = "0x4000ED7")]
			[FieldOffset(Offset = "0x3A8")]
			public JobApplyGravity.InternalCompilerQueryAndHandleData __Pathfinding_ECS_JobApplyGravity_WithoutDefaultQuery_JobEntityTypeHandle;

			[Token(Token = "0x4000ED8")]
			[FieldOffset(Offset = "0x460")]
			public JobManagedMovementOverrideBeforeMovement.InternalCompilerQueryAndHandleData __Pathfinding_ECS_JobManagedMovementOverrideBeforeMovement_WithoutDefaultQuery_JobEntityTypeHandle;

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x6001563")]
			[Address(RVA = "0x44CF0E0", Offset = "0x44CB0E0", VA = "0x44CF0E0")]
			public void __AssignHandles(ref SystemState state)
			{
			}
		}

		[Token(Token = "0x4000ED0")]
		[FieldOffset(Offset = "0x0")]
		private EntityQuery entityQueryWithGravity;

		[Token(Token = "0x4000ED1")]
		[FieldOffset(Offset = "0x10")]
		private EntityQuery entityQueryMovementOverride;

		[Token(Token = "0x4000ED2")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ProfilerMarker MarkerMovementOverride;

		[Token(Token = "0x4000ED3")]
		[FieldOffset(Offset = "0x20")]
		private TypeHandle __TypeHandle;

		[Token(Token = "0x6001554")]
		[Address(RVA = "0x44CDFA8", Offset = "0x44C9FA8", VA = "0x44CDFA8", Slot = "4")]
		public void OnCreate(ref SystemState state)
		{
		}

		[Token(Token = "0x6001555")]
		[Address(RVA = "0x44CE50C", Offset = "0x44CA50C", VA = "0x44CE50C", Slot = "6")]
		public void OnUpdate(ref SystemState systemState)
		{
		}

		[Token(Token = "0x6001556")]
		[Address(RVA = "0x44CE898", Offset = "0x44CA898", VA = "0x44CE898")]
		private void ScheduleApplyGravity(ref SystemState systemState, float dt)
		{
		}

		[Token(Token = "0x6001557")]
		[Address(RVA = "0x44CE74C", Offset = "0x44CA74C", VA = "0x44CE74C")]
		private void RunMovementOverrideBeforeMovement(ref SystemState systemState, float dt)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6001558")]
		[Address(RVA = "0x44CEB94", Offset = "0x44CAB94", VA = "0x44CEB94")]
		private JobHandle __ScheduleViaJobChunkExtension_0(JobAlignAgentWithMovementDirection job, EntityQuery query, JobHandle dependency, ref SystemState state, bool hasUserDefinedQuery)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6001559")]
		[Address(RVA = "0x44CEC30", Offset = "0x44CAC30", VA = "0x44CEC30")]
		private JobHandle __ScheduleViaJobChunkExtension_1(JobMoveAgent job, EntityQuery query, JobHandle dependency, ref SystemState state, bool hasUserDefinedQuery)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600155A")]
		[Address(RVA = "0x44CECCC", Offset = "0x44CACCC", VA = "0x44CECCC")]
		private JobHandle __ScheduleViaJobChunkExtension_2(JobPrepareAgentRaycasts job, EntityQuery query, JobHandle dependency, ref SystemState state, bool hasUserDefinedQuery)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600155B")]
		[Address(RVA = "0x44CEDBC", Offset = "0x44CADBC", VA = "0x44CEDBC")]
		private JobHandle __ScheduleViaJobChunkExtension_3(JobApplyGravity job, EntityQuery query, JobHandle dependency, ref SystemState state, bool hasUserDefinedQuery)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600155C")]
		[Address(RVA = "0x44CEEAC", Offset = "0x44CAEAC", VA = "0x44CEEAC")]
		private void __ScheduleViaJobChunkExtension_4(JobManagedMovementOverrideBeforeMovement job, EntityQuery query, JobHandle dependency, ref SystemState state, bool hasUserDefinedQuery)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600155D")]
		[Address(RVA = "0x44CEF38", Offset = "0x44CAF38", VA = "0x44CEF38")]
		private void __AssignQueries(ref SystemState state)
		{
		}

		[Token(Token = "0x600155E")]
		[Address(RVA = "0x44CEF78", Offset = "0x44CAF78", VA = "0x44CEF78", Slot = "7")]
		public void OnCreateForCompiler(ref SystemState state)
		{
		}
	}
}
