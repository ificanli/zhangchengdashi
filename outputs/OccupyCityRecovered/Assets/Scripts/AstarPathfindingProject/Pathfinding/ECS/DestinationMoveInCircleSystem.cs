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
	[Token(Token = "0x2000364")]
	[RequireMatchingQueriesForUpdate]
	[UpdateBefore(typeof(SchedulePathSearchSystem))]
	[BurstCompile]
	[UpdateInGroup(typeof(AIMovementSystemGroup))]
	public partial struct DestinationMoveInCircleSystem : ISystem, ISystemCompilerGenerated
	{
		[Token(Token = "0x2000365")]
		[BurstCompile]
		private partial struct UpdateDestinationJob : IJobEntity, IJobChunk
		{

			[Token(Token = "0x4000EE5")]
			[FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public ComponentLookup<LocalToWorld> TransformLookup;

			[Token(Token = "0x60015A2")]
			[Address(RVA = "0x44D0864", Offset = "0x44CC864", VA = "0x44D0864")]
			public void Execute(ref DestinationPoint destPoint, in LocalTransform localTransform, in MoveInCircle.DestinationMoveInCircle destCircle)
			{
			}

			[Token(Token = "0x60015BB")]
			[Address(RVA = "0x44D0F34", Offset = "0x44CCF34", VA = "0x44D0F34", Slot = "4")]
void IJobChunk.Execute(in ArchetypeChunk chunk, int unfilteredChunkIndex, bool useEnabledMask, in v128 chunkEnabledMask)
			{
			}
		}

		[Token(Token = "0x2000369")]
		private struct TypeHandle
		{
			[Token(Token = "0x4000EEC")]
			[FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public ComponentLookup<LocalToWorld> __Unity_Transforms_LocalToWorld_RO_ComponentLookup;

			[Token(Token = "0x4000EED")]
			[FieldOffset(Offset = "0x28")]
			public UpdateDestinationJob.InternalCompilerQueryAndHandleData __Pathfinding_ECS_DestinationMoveInCircleSystem_UpdateDestinationJob_WithDefaultQuery_JobEntityTypeHandle;

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x60015C7")]
			[Address(RVA = "0x44D1440", Offset = "0x44CD440", VA = "0x44D1440")]
			public void __AssignHandles(ref SystemState state)
			{
			}
		}

		[Token(Token = "0x4000EE4")]
		[FieldOffset(Offset = "0x0")]
		private TypeHandle __TypeHandle;

		[Token(Token = "0x600159B")]
		[Address(RVA = "0x44D0404", Offset = "0x44CC404", VA = "0x44D0404", Slot = "6")]
		[BurstCompile]
		public void OnUpdate(ref SystemState state)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600159C")]
		[Address(RVA = "0x44D0570", Offset = "0x44CC570", VA = "0x44D0570")]
		private JobHandle __ScheduleViaJobChunkExtension_0(UpdateDestinationJob job, EntityQuery query, JobHandle dependency, ref SystemState state, bool hasUserDefinedQuery)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600159D")]
		[Address(RVA = "0x44D06B0", Offset = "0x44CC6B0", VA = "0x44D06B0")]
		private void __AssignQueries(ref SystemState state)
		{
		}

		[Token(Token = "0x600159E")]
		[Address(RVA = "0x44D06F0", Offset = "0x44CC6F0", VA = "0x44D06F0", Slot = "7")]
		public void OnCreateForCompiler(ref SystemState state)
		{
		}
	}
}
