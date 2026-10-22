using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Pathfinding.Drawing;
using Unity.Burst;
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
	[Token(Token = "0x200031E")]
	[BurstCompile]
	[WithNone(new Type[] { typeof(AgentOffMeshLinkTraversal) })]
	[WithAll(new Type[]
	{
		typeof(SimulateMovement),
		typeof(SimulateMovementControl)
	})]
	public partial struct JobControl : IJobEntity, IJobEntityChunkBeginEnd, IJobChunk
	{

		[Token(Token = "0x4000E03")]
		[FieldOffset(Offset = "0x0")]
		public float dt;

		[Token(Token = "0x4000E04")]
		[FieldOffset(Offset = "0x8")]
		public CommandBuilder draw;

		[Token(Token = "0x4000E05")]
		[FieldOffset(Offset = "0x20")]
		[ReadOnly]
		[NativeDisableContainerSafetyRestriction]
		public NavmeshEdges.NavmeshBorderData navmeshEdgeData;

		[Token(Token = "0x4000E06")]
		[FieldOffset(Offset = "0x50")]
		[NativeDisableContainerSafetyRestriction]
		public NativeList<float2> edgesScratch;

		[Token(Token = "0x4000E07")]
		[FieldOffset(Offset = "0x58")]
		[NativeDisableContainerSafetyRestriction]
		public NativeList<int> indicesScratch;

		[Token(Token = "0x4000E08")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ProfilerMarker MarkerConvertObstacles = new ProfilerMarker("ConvertObstacles");

		[Token(Token = "0x6001374")]
		[Address(RVA = "0x44B89BC", Offset = "0x44B49BC", VA = "0x44B89BC")]
		public static float3 ClampToNavmesh(float3 position, float3 closestOnNavmesh, in AgentCylinderShape shape, in AgentMovementPlane movementPlane)
		{
            float3 up = movementPlane.value.up;
            float3 delta = position - closestOnNavmesh;
            float projection = delta.z * up.z + (delta.x * up.x + delta.y * up.y);
            float minimum = shape.height * -0.4f;
            float clamped = projection > minimum || float.IsNaN(minimum) ? projection : minimum;
            return new float3(closestOnNavmesh.x + up.x * clamped,
                closestOnNavmesh.y + up.y * clamped, closestOnNavmesh.z + up.z * clamped);
        }

		[Token(Token = "0x6001375")]
		[Address(RVA = "0x44B8A68", Offset = "0x44B4A68", VA = "0x44B8A68")]
		public bool OnChunkBegin(in ArchetypeChunk chunk, int unfilteredChunkIndex, bool useEnabledMask, in v128 chunkEnabledMask)
		{
            if (!edgesScratch.IsCreated) edgesScratch = new NativeList<float2>(64, Allocator.Temp);
            if (!indicesScratch.IsCreated) indicesScratch = new NativeList<int>(64, Allocator.Temp);
            return true;
        }

		[Token(Token = "0x6001376")]
		[Address(RVA = "0x44B8B40", Offset = "0x44B4B40", VA = "0x44B8B40")]
		public void OnChunkEnd(in ArchetypeChunk chunk, int unfilteredChunkIndex, bool useEnabledMask, in v128 chunkEnabledMask, bool chunkWasExecuted)
		{
		}

		[Token(Token = "0x6001377")]
		[Address(RVA = "0x44B8B44", Offset = "0x44B4B44", VA = "0x44B8B44")]
		public void Execute(ref LocalTransform transform, ref MovementState state, in DestinationPoint destination, in AgentCylinderShape shape, in AgentMovementPlane movementPlane, in MovementSettings settings, in ResolvedMovement resolvedMovement, ref MovementControl controlOutput)
		{
            float3 position = ClampToNavmesh(transform.Position, state.closestOnNavmesh, in shape, in movementPlane);
            edgesScratch.Clear();
            Pathfinding.PID.PIDMovement followerSettings = settings.follower;
            followerSettings.ScaleByAgentScale(math.abs(transform.Scale));
            followerSettings.desiredWallDistance *= resolvedMovement.turningRadiusMultiplier;
            if (state.hierarchicalNodeIndex != -1)
            {
                UnityEngine.Bounds bounds = Pathfinding.PID.PIDMovement.InterestingEdgeBounds(ref followerSettings,
                    state.closestOnNavmesh, state.nextCorner, shape.height, movementPlane.value);
                navmeshEdgeData.GetEdgesInRange(state.hierarchicalNodeIndex, bounds, edgesScratch, indicesScratch, movementPlane.value);
            }
            float clearance = state.traversingLastPart ? math.max(settings.stopDistance - 0.005f, 0f) : 0f;
            float remainingDistance = math.max(state.remainingDistanceToEndOfPart - clearance, 0f);
            float rotation = movementPlane.value.ToPlane(transform.Rotation);
            float rotationOffset = state.rotationOffset;
            float rotationOffset2 = state.rotationOffset2;
            transform.Position = position;
            if (dt <= 0.000001f)
            {
                controlOutput.hierarchicalNodeIndex = -1;
                return;
            }
            if (float.IsInfinity(remainingDistance))
            {
                controlOutput = new MovementControl {
                    targetPoint = position, endOfPath = position, speed = 0f,
                    maxSpeed = settings.follower.speed, hierarchicalNodeIndex = state.hierarchicalNodeIndex,
                    targetRotation = resolvedMovement.targetRotation, targetRotationHint = resolvedMovement.targetRotation,
                    targetRotationOffset = state.rotationOffset, rotationSpeed = settings.follower.maxRotationSpeed,
                    overrideLocalAvoidance = false
                };
                return;
            }
            float currentRotation = (rotation - rotationOffset) - rotationOffset2;
            if (!settings.isStopped && state.hasValidEndPoint)
            {
                var controlParams = new Pathfinding.PID.PIDMovement.ControlParams {
                    p = (UnityEngine.Vector3)position,
                    speed = controlOutput.speed,
                    rotation = currentRotation,
                    maxDesiredWallDistance = state.followerState.maxDesiredWallDistance,
                    endOfPath = state.endOfPath,
                    facingDirectionAtEndOfPath = destination.facingDirection,
                    edges = edgesScratch.AsArray(),
                    nextCorner = state.nextCorner,
                    agentRadius = shape.radius,
                    remainingDistance = remainingDistance,
                    closestOnNavmesh = state.closestOnNavmesh,
                    debugFlags = Pathfinding.PID.PIDMovement.DebugFlags.Nothing,
                    movementPlane = movementPlane.value
                };
                Pathfinding.PID.AnglePIDControlOutput2D output = Pathfinding.PID.PIDMovement.Control(ref followerSettings,
                    dt, ref controlParams, ref draw, out state.followerState.maxDesiredWallDistance);
                float3 worldDelta = movementPlane.value.ToWorld(output.positionDelta, 0f);
                float distance = math.length(worldDelta);
                float3 direction = math.normalizesafe(worldDelta);
                controlOutput = new MovementControl {
                    targetPoint = position + remainingDistance * direction,
                    endOfPath = state.endOfPath,
                    speed = distance / dt,
                    maxSpeed = followerSettings.speed * 1.1f,
                    hierarchicalNodeIndex = state.hierarchicalNodeIndex,
                    targetRotation = currentRotation + output.rotationDelta,
                    targetRotationHint = currentRotation + AstarMath.DeltaAngle(currentRotation, output.targetRotation),
                    targetRotationOffset = state.rotationOffset,
                    rotationSpeed = math.abs(output.rotationDelta / dt),
                    overrideLocalAvoidance = false
                };
            }
            else
            {
                float3 direction = math.normalizesafe(resolvedMovement.targetPoint - position);
                Pathfinding.PID.PIDMovement speedSettings = settings.follower;
                float speed = speedSettings.Accelerate(resolvedMovement.speed, settings.follower.slowdownTime, -dt);
                controlOutput = new MovementControl {
                    targetPoint = position + direction * 10f,
                    endOfPath = state.endOfPath,
                    speed = speed,
                    maxSpeed = settings.follower.speed,
                    hierarchicalNodeIndex = state.hierarchicalNodeIndex,
                    targetRotation = currentRotation,
                    targetRotationHint = currentRotation,
                    targetRotationOffset = state.rotationOffset,
                    rotationSpeed = settings.follower.maxRotationSpeed,
                    overrideLocalAvoidance = false
                };
            }
        }

		[Token(Token = "0x6001391")]
		[Address(RVA = "0x44BA1B0", Offset = "0x44B61B0", VA = "0x44BA1B0", Slot = "4")]
bool IJobEntityChunkBeginEnd.OnChunkBegin(in ArchetypeChunk chunk, int unfilteredChunkIndex, bool useEnabledMask, in v128 chunkEnabledMask)
		{
            OnChunkBegin(in chunk, unfilteredChunkIndex, false, in chunkEnabledMask);
            return true;
        }

		[Token(Token = "0x6001392")]
		[Address(RVA = "0x44BA210", Offset = "0x44B6210", VA = "0x44BA210", Slot = "5")]
void IJobEntityChunkBeginEnd.OnChunkEnd(in ArchetypeChunk chunk, int unfilteredChunkIndex, bool useEnabledMask, in v128 chunkEnabledMask, bool chunkWasExecuted)
		{
		}

		[Token(Token = "0x6001393")]
		[Address(RVA = "0x44BA264", Offset = "0x44B6264", VA = "0x44BA264", Slot = "6")]
void IJobChunk.Execute(in ArchetypeChunk chunk, int unfilteredChunkIndex, bool useEnabledMask, in v128 chunkEnabledMask)
		{
            Execute(in chunk, unfilteredChunkIndex, useEnabledMask, in chunkEnabledMask);
        }
	}
}
