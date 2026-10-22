using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine.Jobs;

namespace Pathfinding.ECS
{
	[Token(Token = "0x20003A8")]
	[UpdateInGroup(typeof(SimulationSystemGroup))]
	[UpdateBefore(typeof(AIMovementSystemGroup))]
	[UpdateBefore(typeof(TransformSystemGroup))]
	public partial struct SyncTransformsToEntitiesSystem : ISystem, ISystemCompilerGenerated
	{
		[Token(Token = "0x20003A9")]
		[BurstCompile]
		private struct SyncTransformsToEntitiesJob : IJobParallelForTransform
		{
			[Token(Token = "0x4000F75")]
			[FieldOffset(Offset = "0x0")]
			[DeallocateOnJobCompletion]
			[ReadOnly]
			public NativeArray<Entity> entities;

			[Token(Token = "0x4000F76")]
			[FieldOffset(Offset = "0x10")]
			[NativeDisableParallelForRestriction]
			public ComponentLookup<LocalTransform> entityPositions;

			[Token(Token = "0x4000F77")]
			[FieldOffset(Offset = "0x38")]
			[ReadOnly]
			public ComponentLookup<SyncPositionWithTransform> syncPositionWithTransform;

			[Token(Token = "0x4000F78")]
			[FieldOffset(Offset = "0x60")]
			[ReadOnly]
			public ComponentLookup<SyncRotationWithTransform> syncRotationWithTransform;

			[Token(Token = "0x4000F79")]
			[FieldOffset(Offset = "0x88")]
			[ReadOnly]
			public ComponentLookup<OrientationYAxisForward> orientationYAxisForward;

			[Token(Token = "0x4000F7A")]
			[FieldOffset(Offset = "0xB0")]
			[ReadOnly]
			public ComponentLookup<MovementState> movementState;

			[Token(Token = "0x6001771")]
			[Address(RVA = "0x44DDBD4", Offset = "0x44D9BD4", VA = "0x44DDBD4", Slot = "4")]
			public void Execute(int index, TransformAccess transform)
			{
            var entity = entities[index];
            if (!entityPositions.HasComponent(entity)) return;
            ref var localTransform = ref entityPositions.GetRefRW(entity).ValueRW;
            MovementState state;
            bool hasMovementState = movementState.TryGetComponent(entity, out state);
            if (syncPositionWithTransform.HasComponent(entity)) {
                localTransform.Position = (float3)transform.position - (hasMovementState ? state.positionOffset : float3.zero);
            }
            if (syncRotationWithTransform.HasComponent(entity)) {
                quaternion rotation = transform.rotation;
                if (orientationYAxisForward.HasComponent(entity)) rotation = math.mul(rotation, YAxisForwardToZAxisForward);
                localTransform.Rotation = rotation;
            }
            localTransform.Scale = transform.localScale.y;
        }
		}

		[Token(Token = "0x20003AA")]
		private struct TypeHandle
		{
			[Token(Token = "0x4000F7B")]
			[FieldOffset(Offset = "0x0")]
			public ComponentLookup<LocalTransform> __Unity_Transforms_LocalTransform_RW_ComponentLookup;

			[Token(Token = "0x4000F7C")]
			[FieldOffset(Offset = "0x28")]
			[ReadOnly]
			public ComponentLookup<SyncPositionWithTransform> __Pathfinding_ECS_SyncPositionWithTransform_RO_ComponentLookup;

			[Token(Token = "0x4000F7D")]
			[FieldOffset(Offset = "0x50")]
			[ReadOnly]
			public ComponentLookup<SyncRotationWithTransform> __Pathfinding_ECS_SyncRotationWithTransform_RO_ComponentLookup;

			[Token(Token = "0x4000F7E")]
			[FieldOffset(Offset = "0x78")]
			[ReadOnly]
			public ComponentLookup<OrientationYAxisForward> __Pathfinding_ECS_OrientationYAxisForward_RO_ComponentLookup;

			[Token(Token = "0x4000F7F")]
			[FieldOffset(Offset = "0xA0")]
			[ReadOnly]
			public ComponentLookup<MovementState> __Pathfinding_ECS_MovementState_RO_ComponentLookup;

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x6001772")]
			[Address(RVA = "0x44DDEC0", Offset = "0x44D9EC0", VA = "0x44DDEC0")]
			public void __AssignHandles(ref SystemState state)
			{
            __Unity_Transforms_LocalTransform_RW_ComponentLookup = state.GetComponentLookup<LocalTransform>(false);
__Pathfinding_ECS_SyncPositionWithTransform_RO_ComponentLookup = state.GetComponentLookup<SyncPositionWithTransform>(true);
__Pathfinding_ECS_SyncRotationWithTransform_RO_ComponentLookup = state.GetComponentLookup<SyncRotationWithTransform>(true);
__Pathfinding_ECS_OrientationYAxisForward_RO_ComponentLookup = state.GetComponentLookup<OrientationYAxisForward>(true);
__Pathfinding_ECS_MovementState_RO_ComponentLookup = state.GetComponentLookup<MovementState>(true);
        }
		}

		[Token(Token = "0x4000F72")]
		[FieldOffset(Offset = "0x0")]
		public static readonly quaternion ZAxisForwardToYAxisForward = new quaternion(0.7071067690849304f, 0.0f, 0.0f, 0.7071067690849304f);

		[Token(Token = "0x4000F73")]
		[FieldOffset(Offset = "0x10")]
		public static readonly quaternion YAxisForwardToZAxisForward = new quaternion(-0.7071067690849304f, 0.0f, 0.0f, 0.7071067690849304f);

		[Token(Token = "0x4000F74")]
		[FieldOffset(Offset = "0x0")]
		private TypeHandle __TypeHandle;

		[Token(Token = "0x600176B")]
		[Address(RVA = "0x44DD4D0", Offset = "0x44D94D0", VA = "0x44DD4D0", Slot = "6")]
		public void OnUpdate(ref SystemState systemState)
		{
            TransformAccessArray transforms;
            FollowerEntity[] components;
            int count = Pathfinding.Util.BatchedEvents.GetComponents<FollowerEntity>(Pathfinding.Util.BatchedEvents.Event.None, out transforms, out components);
            if (count < 1) return;
            var entities = new NativeArray<Entity>(count, Allocator.TempJob, NativeArrayOptions.ClearMemory);
            for (int i = 0; i < count; i++) entities[i] = components[i].entity;
            __TypeHandle.__Unity_Transforms_LocalTransform_RW_ComponentLookup.Update(ref systemState);
            __TypeHandle.__Pathfinding_ECS_SyncPositionWithTransform_RO_ComponentLookup.Update(ref systemState);
            __TypeHandle.__Pathfinding_ECS_SyncRotationWithTransform_RO_ComponentLookup.Update(ref systemState);
            __TypeHandle.__Pathfinding_ECS_OrientationYAxisForward_RO_ComponentLookup.Update(ref systemState);
            __TypeHandle.__Pathfinding_ECS_MovementState_RO_ComponentLookup.Update(ref systemState);
            var job = new SyncTransformsToEntitiesJob {
                entities = entities,
                entityPositions = __TypeHandle.__Unity_Transforms_LocalTransform_RW_ComponentLookup,
                syncPositionWithTransform = __TypeHandle.__Pathfinding_ECS_SyncPositionWithTransform_RO_ComponentLookup,
                syncRotationWithTransform = __TypeHandle.__Pathfinding_ECS_SyncRotationWithTransform_RO_ComponentLookup,
                orientationYAxisForward = __TypeHandle.__Pathfinding_ECS_OrientationYAxisForward_RO_ComponentLookup,
                movementState = __TypeHandle.__Pathfinding_ECS_MovementState_RO_ComponentLookup
            };
            systemState.Dependency = job.Schedule(transforms, systemState.Dependency);
        }

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600176C")]
		[Address(RVA = "0x44DD82C", Offset = "0x44D982C", VA = "0x44DD82C")]
		private void __AssignQueries(ref SystemState state)
		{
            var builder = new EntityQueryBuilder(Allocator.Temp);
            builder.Dispose();
        }

		[Token(Token = "0x600176D")]
		[Address(RVA = "0x44DD86C", Offset = "0x44D986C", VA = "0x44DD86C", Slot = "7")]
		public void OnCreateForCompiler(ref SystemState state)
		{
            __AssignQueries(ref state);
            __TypeHandle.__AssignHandles(ref state);
        }
	}
}
