using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Entities;
using Unity.Jobs;

namespace Pathfinding.ECS
{
	[Token(Token = "0x2000389")]
	[UpdateAfter(typeof(AIMoveSystem))]
	[RequireMatchingQueriesForUpdate]
	[UpdateInGroup(typeof(AIMovementSystemGroup))]
	public partial struct MovementStatisticsSystem : ISystem, ISystemCompilerGenerated
	{
		[Token(Token = "0x200038A")]
		private struct TypeHandle
		{
			[Token(Token = "0x4000F2E")]
			[FieldOffset(Offset = "0x0")]
			public JobUpdateMovementStatistics.InternalCompilerQueryAndHandleData __Pathfinding_ECS_JobUpdateMovementStatistics_WithDefaultQuery_JobEntityTypeHandle;

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x60016B5")]
			[Address(RVA = "0x44D8564", Offset = "0x44D4564", VA = "0x44D8564")]
			public void __AssignHandles(ref SystemState state)
			{
			}
		}

		[Token(Token = "0x4000F2D")]
		[FieldOffset(Offset = "0x0")]
		private TypeHandle __TypeHandle;

		[Token(Token = "0x60016AF")]
		[Address(RVA = "0x44D834C", Offset = "0x44D434C", VA = "0x44D834C", Slot = "6")]
		public void OnUpdate(ref SystemState state)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60016B0")]
		[Address(RVA = "0x44D8430", Offset = "0x44D4430", VA = "0x44D8430")]
		private JobHandle __ScheduleViaJobChunkExtension_0(JobUpdateMovementStatistics job, EntityQuery query, JobHandle dependency, ref SystemState state, bool hasUserDefinedQuery)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60016B1")]
		[Address(RVA = "0x44D84C4", Offset = "0x44D44C4", VA = "0x44D84C4")]
		private void __AssignQueries(ref SystemState state)
		{
		}

		[Token(Token = "0x60016B2")]
		[Address(RVA = "0x44D8504", Offset = "0x44D4504", VA = "0x44D8504", Slot = "7")]
		public void OnCreateForCompiler(ref SystemState state)
		{
		}
	}
}
