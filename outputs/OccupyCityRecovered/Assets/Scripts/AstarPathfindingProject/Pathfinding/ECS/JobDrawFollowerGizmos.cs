using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Pathfinding.Drawing;
using Unity.Burst.Intrinsics;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

namespace Pathfinding.ECS
{
	[Token(Token = "0x2000325")]
	public struct JobDrawFollowerGizmos : IJobChunk
	{
		[Token(Token = "0x4000E16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CommandBuilder draw;

		[Token(Token = "0x4000E17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GCHandle entityManagerHandle;

		[Token(Token = "0x4000E18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[ReadOnly]
		public ComponentTypeHandle<LocalTransform> LocalTransformTypeHandleRO;

		[Token(Token = "0x4000E19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[ReadOnly]
		public ComponentTypeHandle<AgentCylinderShape> AgentCylinderShapeHandleRO;

		[Token(Token = "0x4000E1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[ReadOnly]
		public ComponentTypeHandle<MovementSettings> MovementSettingsHandleRO;

		[Token(Token = "0x4000E1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[ReadOnly]
		public ComponentTypeHandle<AgentMovementPlane> AgentMovementPlaneHandleRO;

		[Token(Token = "0x4000E1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[NativeDisableContainerSafetyRestriction]
		public ComponentTypeHandle<ManagedState> ManagedStateHandleRW;

		[Token(Token = "0x4000E1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[ReadOnly]
		public ComponentTypeHandle<MovementState> MovementStateHandleRO;

		[Token(Token = "0x4000E1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[ReadOnly]
		public ComponentTypeHandle<ResolvedMovement> ResolvedMovementHandleRO;

		[Token(Token = "0x4000E1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[NativeDisableContainerSafetyRestriction]
		public NativeList<float3> scratchBuffer1;

		[Token(Token = "0x4000E20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[NativeDisableContainerSafetyRestriction]
		public NativeArray<int> scratchBuffer2;

		[Token(Token = "0x4000E21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Color VisualRotationColor;

		[Token(Token = "0x4000E22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly Color UnsmoothedRotation;

		[Token(Token = "0x4000E23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly Color InternalRotation;

		[Token(Token = "0x4000E24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static readonly Color TargetInternalRotation;

		[Token(Token = "0x4000E25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static readonly Color TargetInternalRotationHint;

		[Token(Token = "0x4000E26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static readonly Color Path;

		[Token(Token = "0x60013AB")]
		[Address(RVA = "0x44BB244", Offset = "0x44B7244", VA = "0x44BB244")]
		public void Execute(in ArchetypeChunk chunk, int unfilteredChunkIndex, bool useEnabledMask, in v128 chunkEnabledMask)
		{
		}

		[Token(Token = "0x60013AC")]
		[Address(RVA = "0x44BB61C", Offset = "0x44B761C", VA = "0x44BB61C")]
		public void Execute(ref LocalTransform transform, ref AgentMovementPlane movementPlane, ref AgentCylinderShape shape, ManagedState managedState, ref MovementSettings settings, ref MovementState movementState, ref ResolvedMovement resolvedMovement)
		{
		}

		[Token(Token = "0x60013AE")]
		[Address(RVA = "0x44BBD78", Offset = "0x44B7D78", VA = "0x44BBD78", Slot = "4")]
void IJobChunk.Execute(in ArchetypeChunk chunk, int unfilteredChunkIndex, bool useEnabledMask, in v128 chunkEnabledMask)
		{
		}
	}
}
