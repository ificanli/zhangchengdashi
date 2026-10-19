using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Pathfinding.RVO;
using Unity.Burst;
using Unity.Burst.Intrinsics;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Transforms;

namespace Pathfinding.ECS.RVO
{
	[Token(Token = "0x20003B3")]
	[BurstCompile]
	[UpdateAfter(typeof(FollowerControlSystem))]
	[UpdateInGroup(typeof(AIMovementSystemGroup))]
	public partial struct RVOSystem : ISystem, ISystemCompilerGenerated
	{
		[Token(Token = "0x20003B4")]
		[BurstCompile]
		public partial struct JobCopyFromEntitiesToRVOSimulator : IJobEntity, IJobChunk
		{

			[Token(Token = "0x4000FAC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[NativeDisableParallelForRestriction]
			public SimulatorBurst.AgentData agentData;

			[Token(Token = "0x4000FAD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
			[ReadOnly]
			public SimulatorBurst.AgentOutputData agentOutputData;

			[Token(Token = "0x4000FAE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
			public MovementPlane movementPlaneMode;

			[Token(Token = "0x4000FAF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
			[ReadOnly]
			public ComponentLookup<AgentOffMeshLinkTraversal> agentOffMeshLinkTraversalLookup;

			[Token(Token = "0x4000FB0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
			public float dt;

			[Token(Token = "0x60017AA")]
			[Address(RVA = "0x44E3CAC", Offset = "0x44DFCAC", VA = "0x44E3CAC")]
			public void Execute(Entity entity, in LocalTransform transform, in AgentCylinderShape shape, in AgentMovementPlane movementPlane, in AgentIndex agentIndex, in RVOAgent controller, in MovementControl target)
			{
			}

			[Token(Token = "0x60017C3")]
			[Address(RVA = "0x44E49D8", Offset = "0x44E09D8", VA = "0x44E49D8", Slot = "4")]
void IJobChunk.Execute(in ArchetypeChunk chunk, int unfilteredChunkIndex, bool useEnabledMask, in v128 chunkEnabledMask)
			{
			}
		}

		[Token(Token = "0x20003B8")]
		[BurstCompile]
		public partial struct JobCopyFromRVOSimulatorToEntities : IJobEntity, IJobChunk
		{

			[Token(Token = "0x4000FBB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public NativeArray<AgentIndex> agentDataVersions;

			[Token(Token = "0x4000FBC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[ReadOnly]
			public RVOQuadtreeBurst quadtree;

			[Token(Token = "0x4000FBD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[ReadOnly]
			public SimulatorBurst.AgentOutputData agentOutputData;

			[Token(Token = "0x4000FBE")]
			private const float MaximumCirclePackingDensity = 0.9069f;

			[Token(Token = "0x60017CF")]
			[Address(RVA = "0x44E508C", Offset = "0x44E108C", VA = "0x44E508C")]
			public void Execute(in LocalTransform transform, in AgentCylinderShape shape, in AgentIndex agentIndex, in RVOAgent controller, in MovementControl control, ref ResolvedMovement resolved)
			{
			}

			[Token(Token = "0x60017E8")]
			[Address(RVA = "0x44E5978", Offset = "0x44E1978", VA = "0x44E5978", Slot = "4")]
void IJobChunk.Execute(in ArchetypeChunk chunk, int unfilteredChunkIndex, bool useEnabledMask, in v128 chunkEnabledMask)
			{
			}
		}

		[Token(Token = "0x20003BC")]
		private struct TypeHandle
		{
			[Token(Token = "0x4000FC8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public JobCopyFromEntitiesToRVOSimulator.InternalCompilerQueryAndHandleData __Pathfinding_ECS_RVO_RVOSystem_JobCopyFromEntitiesToRVOSimulator_WithDefaultQuery_JobEntityTypeHandle;

			[Token(Token = "0x4000FC9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			public JobCopyFromRVOSimulatorToEntities.InternalCompilerQueryAndHandleData __Pathfinding_ECS_RVO_RVOSystem_JobCopyFromRVOSimulatorToEntities_WithDefaultQuery_JobEntityTypeHandle;

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x60017F4")]
			[Address(RVA = "0x44E600C", Offset = "0x44E200C", VA = "0x44E600C")]
			public void __AssignHandles(ref SystemState state)
			{
			}
		}

		[Token(Token = "0x4000FA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private GCHandle lastSimulator;

		[Token(Token = "0x4000FA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private ComponentLookup<AgentOffMeshLinkTraversal> agentOffMeshLinkTraversalLookup;

		[Token(Token = "0x4000FA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TypeHandle __TypeHandle;

		[Token(Token = "0x4000FA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		private EntityQuery __query_614662194_0;

		[Token(Token = "0x4000FA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		private EntityQuery __query_614662194_1;

		[Token(Token = "0x4000FAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		private EntityQuery __query_614662194_2;

		[Token(Token = "0x4000FAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		private EntityQuery __query_614662194_3;

		[Token(Token = "0x600179B")]
		[Address(RVA = "0x44DF6B0", Offset = "0x44DB6B0", VA = "0x44DF6B0", Slot = "4")]
		public void OnCreate(ref SystemState state)
		{
		}

		[Token(Token = "0x600179C")]
		[Address(RVA = "0x44DF74C", Offset = "0x44DB74C", VA = "0x44DF74C", Slot = "5")]
		public void OnDestroy(ref SystemState state)
		{
		}

		[Token(Token = "0x600179D")]
		[Address(RVA = "0x44DF754", Offset = "0x44DB754", VA = "0x44DF754", Slot = "6")]
		public void OnUpdate(ref SystemState systemState)
		{
		}

		[Token(Token = "0x600179E")]
		[Address(RVA = "0x44DF8FC", Offset = "0x44DB8FC", VA = "0x44DF8FC")]
		private void RemoveAllAgentsFromSimulation(ref SystemState systemState)
		{
		}

		[Token(Token = "0x600179F")]
		[Address(RVA = "0x44DFA00", Offset = "0x44DBA00", VA = "0x44DFA00")]
		private void AddAndRemoveAgentsFromSimulation(ref SystemState systemState, SimulatorBurst simulator)
		{
		}

		[Token(Token = "0x60017A0")]
		[Address(RVA = "0x44DFCEC", Offset = "0x44DBCEC", VA = "0x44DFCEC")]
		private void CopyFromEntitiesToRVOSimulator(ref SystemState systemState, SimulatorBurst simulator, float dt)
		{
		}

		[Token(Token = "0x60017A1")]
		[Address(RVA = "0x44DFF38", Offset = "0x44DBF38", VA = "0x44DFF38")]
		private void CopyFromRVOSimulatorToEntities(ref SystemState systemState, SimulatorBurst simulator)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60017A2")]
		[Address(RVA = "0x44E00E8", Offset = "0x44DC0E8", VA = "0x44E00E8")]
		private JobHandle __ScheduleViaJobChunkExtension_0(JobCopyFromEntitiesToRVOSimulator job, EntityQuery query, JobHandle dependency, ref SystemState state, bool hasUserDefinedQuery)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60017A3")]
		[Address(RVA = "0x44E0184", Offset = "0x44DC184", VA = "0x44E0184")]
		private JobHandle __ScheduleViaJobChunkExtension_1(JobCopyFromRVOSimulatorToEntities job, EntityQuery query, JobHandle dependency, ref SystemState state, bool hasUserDefinedQuery)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60017A4")]
		[Address(RVA = "0x44E0220", Offset = "0x44DC220", VA = "0x44E0220")]
		private void __AssignQueries(ref SystemState state)
		{
		}

		[Token(Token = "0x60017A5")]
		[Address(RVA = "0x44E0438", Offset = "0x44DC438", VA = "0x44E0438", Slot = "7")]
		public void OnCreateForCompiler(ref SystemState state)
		{
		}
	}
}
