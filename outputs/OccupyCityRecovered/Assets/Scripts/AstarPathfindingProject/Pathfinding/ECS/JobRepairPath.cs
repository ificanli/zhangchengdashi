using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Unity.Burst.Intrinsics;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Profiling;
using Unity.Transforms;

namespace Pathfinding.ECS
{
	[Token(Token = "0x2000348")]
	public struct JobRepairPath : IJobChunk
	{
		[Token(Token = "0x2000349")]
		public struct Scheduler
		{
			[Token(Token = "0x4000E94")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public ComponentTypeHandle<LocalTransform> LocalTransformTypeHandleRO;

			[Token(Token = "0x4000E95")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ComponentTypeHandle<MovementState> MovementStateTypeHandleRW;

			[Token(Token = "0x4000E96")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[ReadOnly]
			public ComponentTypeHandle<AgentCylinderShape> AgentCylinderShapeTypeHandleRO;

			[Token(Token = "0x4000E97")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[NativeDisableContainerSafetyRestriction]
			public ComponentTypeHandle<ManagedState> ManagedStateTypeHandleRW;

			[Token(Token = "0x4000E98")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[ReadOnly]
			public ComponentTypeHandle<MovementSettings> MovementSettingsTypeHandleRO;

			[Token(Token = "0x4000E99")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			public ComponentTypeHandle<AutoRepathPolicy> AutoRepathPolicyRW;

			[Token(Token = "0x4000E9A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			[ReadOnly]
			public ComponentTypeHandle<DestinationPoint> DestinationPointTypeHandleRO;

			[Token(Token = "0x4000E9B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			[ReadOnly]
			public ComponentTypeHandle<AgentMovementPlane> AgentMovementPlaneTypeHandleRO;

			[Token(Token = "0x4000E9C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
			public ComponentTypeHandle<ReadyToTraverseOffMeshLink> ReadyToTraverseOffMeshLinkTypeHandleRW;

			[Token(Token = "0x4000E9D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
			public GCHandle entityManagerHandle;

			[Token(Token = "0x4000E9E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
			public bool onlyApplyPendingPaths;

			[Token(Token = "0x60014F3")]
			[Address(RVA = "0x44C7004", Offset = "0x44C3004", VA = "0x44C7004")]
			public EntityQueryBuilder GetEntityQuery(Allocator allocator)
			{
				return default;
			}

			[Token(Token = "0x60014F4")]
			[Address(RVA = "0x44C7130", Offset = "0x44C3130", VA = "0x44C7130")]
			public Scheduler(ref SystemState systemState)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED JobRepairPath.Scheduler..ctor RVA=0x44C7130 Token=0x60014F4");
}

			[Token(Token = "0x60014F5")]
			[Address(RVA = "0x44C7430", Offset = "0x44C3430", VA = "0x44C7430")]
			public void Dispose()
			{
			}

			[Token(Token = "0x60014F6")]
			[Address(RVA = "0x44C743C", Offset = "0x44C343C", VA = "0x44C743C")]
			public void Update(ref SystemState systemState)
			{
			}

			[Token(Token = "0x60014F7")]
			[Address(RVA = "0x44C75CC", Offset = "0x44C35CC", VA = "0x44C75CC")]
			public JobHandle ScheduleParallel(ref SystemState systemState, EntityQuery query, JobHandle dependency)
			{
				return default;
			}
		}

		[Token(Token = "0x4000E8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Scheduler scheduler;

		[Token(Token = "0x4000E8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		[NativeDisableContainerSafetyRestriction]
		public NativeArray<int> indicesScratch;

		[Token(Token = "0x4000E8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		[NativeDisableContainerSafetyRestriction]
		public NativeList<float3> nextCornersScratch;

		[Token(Token = "0x4000E90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public bool onlyApplyPendingPaths;

		[Token(Token = "0x4000E91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly ProfilerMarker MarkerRepair;

		[Token(Token = "0x4000E92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly ProfilerMarker MarkerGetNextCorners;

		[Token(Token = "0x4000E93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly ProfilerMarker MarkerUpdateReachedEndInfo;

		[Token(Token = "0x60014EF")]
		[Address(RVA = "0x44C6388", Offset = "0x44C2388", VA = "0x44C6388")]
		public void Execute(in ArchetypeChunk chunk, int unfilteredChunkIndex, bool useEnabledMask, in v128 chunkEnabledMask)
		{
		}

		[Token(Token = "0x60014F0")]
		[Address(RVA = "0x44C686C", Offset = "0x44C286C", VA = "0x44C686C")]
		public static void Execute(ref LocalTransform transform, ref MovementState state, ref AgentCylinderShape shape, ref AgentMovementPlane movementPlane, ref AutoRepathPolicy autoRepathPolicy, ref DestinationPoint destination, EnabledRefRW<ReadyToTraverseOffMeshLink> readyToTraverseOffMeshLink, ManagedState managedState, in MovementSettings settings, NativeList<float3> nextCornersScratch, ref NativeArray<int> indicesScratch, Allocator allocator, bool onlyApplyPendingPaths)
		{
		}

		[Token(Token = "0x60014F2")]
		[Address(RVA = "0x44C6F9C", Offset = "0x44C2F9C", VA = "0x44C6F9C", Slot = "4")]
void IJobChunk.Execute(in ArchetypeChunk chunk, int unfilteredChunkIndex, bool useEnabledMask, in v128 chunkEnabledMask)
		{
		}
	}
}
