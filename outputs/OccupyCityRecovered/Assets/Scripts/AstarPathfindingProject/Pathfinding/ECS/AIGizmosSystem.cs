using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Pathfinding.Drawing;
using Unity.Entities;
using Unity.Jobs;

namespace Pathfinding.ECS
{
	[Token(Token = "0x2000355")]
	[UpdateInGroup(typeof(AIMovementSystemGroup))]
	public partial struct AIGizmosSystem : ISystem, ISystemCompilerGenerated
	{
		[Token(Token = "0x2000356")]
		private class DrawerCallback : IDrawGizmos
		{
			[Token(Token = "0x4000EBF")]
			[FieldOffset(Offset = "0x10")]
			private World world;

			[Token(Token = "0x1700031D")]
			public bool Exists
			{
				[Token(Token = "0x6001541")]
				[Address(RVA = "0x44CCFC8", Offset = "0x44C8FC8", VA = "0x44CCFC8", Slot = "5")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x600153F")]
			[Address(RVA = "0x44CC824", Offset = "0x44C8824", VA = "0x44CC824")]
			public DrawerCallback(World world)
			{
			}

			[Token(Token = "0x6001540")]
			[Address(RVA = "0x44CCE80", Offset = "0x44C8E80", VA = "0x44CCE80", Slot = "4")]
			public void DrawGizmos()
			{
			}
		}

		[Token(Token = "0x2000357")]
		private struct TypeHandle
		{
			[Token(Token = "0x4000EC0")]
			[FieldOffset(Offset = "0x0")]
			public JobDrawFollowerGizmosBase.InternalCompilerQueryAndHandleData __Pathfinding_ECS_JobDrawFollowerGizmosBase_WithDefaultQuery_JobEntityTypeHandle;

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x6001542")]
			[Address(RVA = "0x44CD060", Offset = "0x44C9060", VA = "0x44CD060")]
			public void __AssignHandles(ref SystemState state)
			{
			}
		}

		[Token(Token = "0x4000EB9")]
		[FieldOffset(Offset = "0x0")]
		private static bool manuallyTriggered;

		[Token(Token = "0x4000EBA")]
		[FieldOffset(Offset = "0x0")]
		private JobRepairPath.Scheduler jobRepairPathScheduler;

		[Token(Token = "0x4000EBB")]
		[FieldOffset(Offset = "0x178")]
		private ComponentTypeHandle<MovementState> MovementStateTypeHandleRO;

		[Token(Token = "0x4000EBC")]
		[FieldOffset(Offset = "0x1A0")]
		private ComponentTypeHandle<ResolvedMovement> ResolvedMovementHandleRO;

		[Token(Token = "0x4000EBD")]
		[FieldOffset(Offset = "0x1C8")]
		private TypeHandle __TypeHandle;

		[Token(Token = "0x4000EBE")]
		[FieldOffset(Offset = "0x250")]
		private EntityQuery __query_2063717491_0;

		[Token(Token = "0x6001536")]
		[Address(RVA = "0x44CC658", Offset = "0x44C8658", VA = "0x44CC658", Slot = "4")]
		public void OnCreate(ref SystemState state)
		{
		}

		[Token(Token = "0x6001537")]
		[Address(RVA = "0x44CC84C", Offset = "0x44C884C", VA = "0x44CC84C", Slot = "6")]
		public void OnUpdate(ref SystemState systemState)
		{
		}

		[Token(Token = "0x6001538")]
		[Address(RVA = "0x44CC8C0", Offset = "0x44C88C0", VA = "0x44CC8C0")]
		private void DrawGizmos(ref SystemState systemState)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6001539")]
		[Address(RVA = "0x44CCCA0", Offset = "0x44C8CA0", VA = "0x44CCCA0")]
		private JobHandle __ScheduleViaJobChunkExtension_0(JobDrawFollowerGizmosBase job, EntityQuery query, JobHandle dependency, ref SystemState state, bool hasUserDefinedQuery)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600153A")]
		[Address(RVA = "0x44CCD3C", Offset = "0x44C8D3C", VA = "0x44CCD3C")]
		private void __AssignQueries(ref SystemState state)
		{
		}

		[Token(Token = "0x600153B")]
		[Address(RVA = "0x44CCE4C", Offset = "0x44C8E4C", VA = "0x44CCE4C", Slot = "7")]
		public void OnCreateForCompiler(ref SystemState state)
		{
		}
	}
}
