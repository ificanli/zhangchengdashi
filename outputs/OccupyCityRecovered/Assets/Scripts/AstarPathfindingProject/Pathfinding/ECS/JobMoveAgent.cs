using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Burst.Intrinsics;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Transforms;

namespace Pathfinding.ECS
{
	[Token(Token = "0x2000340")]
	[WithNone(new Type[] { typeof(AgentOffMeshLinkMovementDisabled) })]
	[WithAll(new Type[]
	{
		typeof(SimulateMovement),
		typeof(SimulateMovementFinalize)
	})]
	[BurstCompile]
	public partial struct JobMoveAgent : IJobEntity, IJobChunk
	{

		[Token(Token = "0x4000E71")]
		[FieldOffset(Offset = "0x0")]
		public float dt;

		[Token(Token = "0x600149F")]
		[Address(RVA = "0x44C38D4", Offset = "0x44BF8D4", VA = "0x44C38D4")]
		public static quaternion ResolveRotation(quaternion rotation, ref MovementState state, in ResolvedMovement resolvedMovement, in MovementSettings movementSettings, in AgentMovementPlane movementPlane, float dt)
		{
            float currentAngle = movementPlane.value.ToPlane(rotation);
            float oldOffset = state.rotationOffset;
            float effectiveAngle = (currentAngle - oldOffset) - state.rotationOffset2;
            float delta = AstarMath.DeltaAngle(effectiveAngle, resolvedMovement.targetRotation);
            float upper = resolvedMovement.rotationSpeed * dt;
            float lower = (-resolvedMovement.rotationSpeed) * dt;
            if (float.IsNaN(delta) || upper < delta) delta = upper;
            if (float.IsNaN(delta) || delta < lower) delta = lower;
            float nextAngle = effectiveAngle + delta;

            float maxOffsetSpeed = movementSettings.follower.maxRotationSpeed * 0.01745329238474369f;
            float halfOffsetSpeed = maxOffsetSpeed * 0.5f;
            float upperOffsetStep = halfOffsetSpeed * dt;
            float lowerOffsetStep = (-halfOffsetSpeed) * dt;
            float offsetDelta = AstarMath.DeltaAngle(state.rotationOffset, resolvedMovement.targetRotationOffset);
            if (float.IsNaN(offsetDelta) || upperOffsetStep < offsetDelta) offsetDelta = upperOffsetStep;
            if (float.IsNaN(offsetDelta) || offsetDelta < lowerOffsetStep) offsetDelta = lowerOffsetStep;
            state.rotationOffset = state.rotationOffset + offsetDelta;
            state.rotationOffset = AstarMath.DeltaAngle(0f, state.rotationOffset);

            float smoothing = movementSettings.rotationSmoothing;
            if (smoothing > 0f) {
                float compensation = (effectiveAngle + oldOffset) - (state.rotationOffset + nextAngle);
                state.rotationOffset2 = state.rotationOffset2 + compensation;
                state.rotationOffset2 = AstarMath.DeltaAngle(0f, state.rotationOffset2);
                float hintDelta = AstarMath.DeltaAngle(currentAngle, resolvedMovement.targetRotationHint);
                float offsetMagnitude = math.abs(state.rotationOffset2);
                if (offsetMagnitude > 0f) {
                    float angularDecay = (math.abs(hintDelta) / smoothing) * dt;
                    float fixedDecay = (-0.1f / smoothing) * dt;
                    float factor = (1f - angularDecay) + fixedDecay / offsetMagnitude;
                    if (!(factor >= 0f)) factor = 0f;
                    state.rotationOffset2 = state.rotationOffset2 * factor;
                }
            } else if (state.rotationOffset2 != 0f) {
                float fade = -state.rotationOffset2;
                if (float.IsNaN(fade) || upperOffsetStep < fade) fade = upperOffsetStep;
                if (float.IsNaN(fade) || fade < lowerOffsetStep) fade = lowerOffsetStep;
                state.rotationOffset2 = state.rotationOffset2 + fade;
            }
            return movementPlane.value.ToWorldRotation((nextAngle + state.rotationOffset) + state.rotationOffset2);
        }

		[Token(Token = "0x60014A0")]
		[Address(RVA = "0x44C3B78", Offset = "0x44BFB78", VA = "0x44C3B78")]
		public static float3 MoveWithoutGravity(float3 position, in ResolvedMovement resolvedMovement, in AgentMovementPlane movementPlane, float dt)
		{
            float2 delta = movementPlane.value.ToPlane(resolvedMovement.targetPoint - position);
            float distance = math.sqrt(delta.x * delta.x + delta.y * delta.y);
            float fraction = (resolvedMovement.speed * dt) / distance;
            if (!(fraction <= 1f)) fraction = 1f;
            if (fraction < 0f) fraction = 0f;
            if (distance > 0.0001f) delta *= fraction;
            return movementPlane.value.ToWorld(delta, 0f);
        }

		[Token(Token = "0x60014A1")]
		[Address(RVA = "0x44C3C80", Offset = "0x44BFC80", VA = "0x44C3C80")]
		public static void ResolvePositionSmoothing(float3 movementDelta, ref MovementState state, in MovementSettings movementSettings, float dt)
		{
            float smoothing = movementSettings.positionSmoothing;
            if (smoothing > 0f) {
                state.positionOffset -= movementDelta;
                float3 offset = state.positionOffset;
                float distance = math.sqrt(offset.z * offset.z + (offset.x * offset.x + offset.y * offset.y));
                if (distance > 0f) {
                    float proportionalDecay = (1f / smoothing) * dt;
                    float fixedDecay = (0.1f / smoothing) * dt;
                    float factor = (1f - proportionalDecay) - fixedDecay / distance;
                    if (!(factor >= 0f)) factor = 0f;
                    state.positionOffset *= factor;
                }
            } else {
                state.positionOffset = float3.zero;
            }
        }

		[Token(Token = "0x60014A2")]
		[Address(RVA = "0x44C3DEC", Offset = "0x44BFDEC", VA = "0x44C3DEC")]
		public void Execute(ref LocalTransform transform, in AgentCylinderShape shape, in AgentMovementPlane movementPlane, ref MovementState state, in MovementSettings movementSettings, in ResolvedMovement resolvedMovement, ref MovementStatistics movementStatistics)
		{
            MoveAgent(ref transform, in shape, in movementPlane, ref state,
                in movementSettings, in resolvedMovement, ref movementStatistics, dt);
        }

		[Token(Token = "0x60014A3")]
		[Address(RVA = "0x44C3E08", Offset = "0x44BFE08", VA = "0x44C3E08")]
		public static void MoveAgent(ref LocalTransform transform, in AgentCylinderShape shape, in AgentMovementPlane movementPlane, ref MovementState state, in MovementSettings movementSettings, in ResolvedMovement resolvedMovement, ref MovementStatistics movementStatistics, float dt)
		{
            float3 movementDelta = MoveWithoutGravity(transform.Position, in resolvedMovement, in movementPlane, dt);
            transform.Position += movementDelta;
            if (math.abs(transform.Position.z) < 0.00001f) transform.Position.z = 0f;
            ResolvePositionSmoothing(movementDelta, ref state, in movementSettings, dt);
            transform.Rotation = ResolveRotation(transform.Rotation, ref state,
                in resolvedMovement, in movementSettings, in movementPlane, dt);
        }

		[Token(Token = "0x60014BC")]
		[Address(RVA = "0x44C4740", Offset = "0x44C0740", VA = "0x44C4740", Slot = "4")]
void IJobChunk.Execute(in ArchetypeChunk chunk, int unfilteredChunkIndex, bool useEnabledMask, in v128 chunkEnabledMask)
		{
            Execute(in chunk, unfilteredChunkIndex, useEnabledMask, in chunkEnabledMask);
        }
	}
}
