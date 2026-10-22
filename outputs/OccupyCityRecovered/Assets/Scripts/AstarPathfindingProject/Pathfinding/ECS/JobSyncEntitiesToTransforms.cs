using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using Unity.Transforms;
using UnityEngine.Jobs;

namespace Pathfinding.ECS
{
	[Token(Token = "0x2000350")]
	[BurstCompile]
	internal struct JobSyncEntitiesToTransforms : IJobParallelForTransform
	{
		[Token(Token = "0x4000EAD")]
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public NativeArray<Entity> entities;

		[Token(Token = "0x4000EAE")]
		[FieldOffset(Offset = "0x10")]
		[ReadOnly]
		public ComponentLookup<LocalTransform> entityPositions;

		[Token(Token = "0x4000EAF")]
		[FieldOffset(Offset = "0x38")]
		[ReadOnly]
		public ComponentLookup<MovementState> movementState;

		[Token(Token = "0x4000EB0")]
		[FieldOffset(Offset = "0x60")]
		[ReadOnly]
		public ComponentLookup<SyncPositionWithTransform> syncPositionWithTransform;

		[Token(Token = "0x4000EB1")]
		[FieldOffset(Offset = "0x88")]
		[ReadOnly]
		public ComponentLookup<SyncRotationWithTransform> syncRotationWithTransform;

		[Token(Token = "0x4000EB2")]
		[FieldOffset(Offset = "0xB0")]
		[ReadOnly]
		public ComponentLookup<OrientationYAxisForward> orientationYAxisForward;

		[Token(Token = "0x600150F")]
		[Address(RVA = "0x44CB97C", Offset = "0x44C797C", VA = "0x44CB97C", Slot = "4")]
		public void Execute(int index, TransformAccess transform)
		{
            var entity = entities[index];
            if (!entityPositions.HasComponent(entity)) return;
            MovementState state;
            bool hasMovementState = movementState.TryGetComponent(entity, out state);
            ref readonly var localTransform = ref entityPositions.GetRefRO(entity).ValueRO;
            if (syncPositionWithTransform.HasComponent(entity)) {
                transform.position = (UnityEngine.Vector3)((hasMovementState ? state.positionOffset : Unity.Mathematics.float3.zero) + localTransform.Position);
            }
            if (syncRotationWithTransform.HasComponent(entity)) {
                var rotation = localTransform.Rotation;
                if (orientationYAxisForward.HasComponent(entity)) {
                    rotation = Unity.Mathematics.math.mul(rotation, SyncTransformsToEntitiesSystem.ZAxisForwardToYAxisForward);
                }
                transform.rotation = (UnityEngine.Quaternion)rotation;
            }
}
	}
}
