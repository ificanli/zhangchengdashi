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
	[Token(Token = "0x200035C")]
	[BurstCompile]
	[RequireMatchingQueriesForUpdate]
	[UpdateBefore(typeof(SchedulePathSearchSystem))]
	[UpdateInGroup(typeof(AIMovementSystemGroup))]
	public partial struct DestinationEntitySystem : ISystem, ISystemCompilerGenerated
	{
		[Token(Token = "0x200035D")]
		[BurstCompile]
		private partial struct UpdateDestinationJob : IJobEntity, IJobChunk
		{

			[Token(Token = "0x4000EDA")]
			[FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public ComponentLookup<LocalToWorld> TransformLookup;

			[Token(Token = "0x600156B")]
			[Address(RVA = "0x44CF5E4", Offset = "0x44CB5E4", VA = "0x44CF5E4")]
			public void Execute(ref DestinationPoint destPoint, in DestinationEntity destEntity)
			{
			}

			[Token(Token = "0x6001584")]
			[Address(RVA = "0x44CFB5C", Offset = "0x44CBB5C", VA = "0x44CFB5C", Slot = "4")]
void IJobChunk.Execute(in ArchetypeChunk chunk, int unfilteredChunkIndex, bool useEnabledMask, in v128 chunkEnabledMask)
			{
			}
		}

		[Token(Token = "0x2000361")]
		private struct TypeHandle
		{
			[Token(Token = "0x4000EE0")]
			[FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public ComponentLookup<LocalToWorld> __Unity_Transforms_LocalToWorld_RO_ComponentLookup;

			[Token(Token = "0x4000EE1")]
			[FieldOffset(Offset = "0x28")]
			public UpdateDestinationJob.InternalCompilerQueryAndHandleData __Pathfinding_ECS_DestinationEntitySystem_UpdateDestinationJob_WithDefaultQuery_JobEntityTypeHandle;

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x6001590")]
			[Address(RVA = "0x44CFF98", Offset = "0x44CBF98", VA = "0x44CFF98")]
			public void __AssignHandles(ref SystemState state)
			{
			}
		}

		[Token(Token = "0x4000ED9")]
		[FieldOffset(Offset = "0x0")]
		private TypeHandle __TypeHandle;

		[Token(Token = "0x6001564")]
		[Address(RVA = "0x44CF1BC", Offset = "0x44CB1BC", VA = "0x44CF1BC", Slot = "6")]
		[BurstCompile]
		public void OnUpdate(ref SystemState state)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6001565")]
		[Address(RVA = "0x44CF31C", Offset = "0x44CB31C", VA = "0x44CF31C")]
		private JobHandle __ScheduleViaJobChunkExtension_0(UpdateDestinationJob job, EntityQuery query, JobHandle dependency, ref SystemState state, bool hasUserDefinedQuery)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6001566")]
		[Address(RVA = "0x44CF430", Offset = "0x44CB430", VA = "0x44CF430")]
		private void __AssignQueries(ref SystemState state)
		{
		}

		[Token(Token = "0x6001567")]
		[Address(RVA = "0x44CF470", Offset = "0x44CB470", VA = "0x44CF470", Slot = "7")]
		public void OnCreateForCompiler(ref SystemState state)
		{
		}
	}
}
