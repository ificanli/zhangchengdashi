using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Entities;

namespace Pathfinding.ECS
{
	[Token(Token = "0x2000392")]
	[UpdateBefore(typeof(FollowerControlSystem))]
	[UpdateInGroup(typeof(AIMovementSystemGroup))]
	[BurstCompile]
	public partial struct RepairPathSystem : ISystem, ISystemCompilerGenerated
	{
		[Token(Token = "0x2000393")]
		private struct TypeHandle
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x60016DA")]
			[Address(RVA = "0x44D97CC", Offset = "0x44D57CC", VA = "0x44D97CC")]
			public void __AssignHandles(ref SystemState state)
			{
			}
		}

		[Token(Token = "0x4000F3F")]
		[FieldOffset(Offset = "0x0")]
		private EntityQuery entityQueryPrepare;

		[Token(Token = "0x4000F40")]
		[FieldOffset(Offset = "0x10")]
		private JobRepairPath.Scheduler jobRepairPathScheduler;

		[Token(Token = "0x4000F41")]
		[FieldOffset(Offset = "0x188")]
		private TypeHandle __TypeHandle;

		[Token(Token = "0x4000F42")]
		[FieldOffset(Offset = "0x190")]
		private EntityQuery __query_943785559_0;

		[Token(Token = "0x60016CF")]
		[Address(RVA = "0x44D9438", Offset = "0x44D5438", VA = "0x44D9438", Slot = "4")]
		public void OnCreate(ref SystemState state)
		{
		}

		[Token(Token = "0x60016D0")]
		[Address(RVA = "0x44D9500", Offset = "0x44D5500", VA = "0x44D9500", Slot = "5")]
		public void OnDestroy(ref SystemState state)
		{
		}

		[Token(Token = "0x60016D1")]
		[Address(RVA = "0x44D950C", Offset = "0x44D550C", VA = "0x44D950C", Slot = "6")]
		public void OnUpdate(ref SystemState systemState)
		{
		}

		[Token(Token = "0x60016D2")]
		[Address(RVA = "0x44D9618", Offset = "0x44D5618", VA = "0x44D9618")]
		[Obsolete("Use TraverseOffMeshLinkSystem.NextLinkToTraverse instead")]
		public static OffMeshLinks.OffMeshLinkTracer NextLinkToTraverse(ManagedState state)
		{
			return default;
		}

		[Token(Token = "0x60016D3")]
		[Address(RVA = "0x44D96D8", Offset = "0x44D56D8", VA = "0x44D96D8")]
		[Obsolete("Use TraverseOffMeshLinkSystem.ResolveOffMeshLinkHandler instead")]
		public static IOffMeshLinkHandler ResolveOffMeshLinkHandler(ManagedSettings settings, AgentOffMeshLinkTraversalContext ctx)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60016D4")]
		[Address(RVA = "0x44D9710", Offset = "0x44D5710", VA = "0x44D9710")]
		private void __AssignQueries(ref SystemState state)
		{
		}

		[Token(Token = "0x60016D5")]
		[Address(RVA = "0x44D97C4", Offset = "0x44D57C4", VA = "0x44D97C4", Slot = "7")]
		public void OnCreateForCompiler(ref SystemState state)
		{
		}
	}
}
