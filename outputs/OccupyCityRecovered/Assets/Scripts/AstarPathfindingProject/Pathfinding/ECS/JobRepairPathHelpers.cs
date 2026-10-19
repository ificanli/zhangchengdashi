using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Pathfinding.Collections;
using Unity.Burst;
using Unity.Mathematics;
using Unity.Transforms;

namespace Pathfinding.ECS
{
	[Token(Token = "0x200034A")]
	[BurstCompile]
	internal static class JobRepairPathHelpers
	{
		[Token(Token = "0x200034B")]
		public struct PathTracerInfo
		{
			[Token(Token = "0x4000E9F")]
			[FieldOffset(Offset = "0x0")]
			public float3 endPointOfFirstPart;

			[Token(Token = "0x4000EA0")]
			[FieldOffset(Offset = "0xC")]
			public int partCount;

			[Token(Token = "0x4000EA1")]
			[FieldOffset(Offset = "0x10")]
			[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
			public bool isStale;

			[Token(Token = "0x4000EA2")]
			[FieldOffset(Offset = "0x11")]
			[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
			public bool hasValidEndPoint;
		}

		[Token(Token = "0x200034C")]
		public delegate void UpdateReachedEndInfo_0000138C_0024PostfixBurstDelegate(ref UnsafeSpan<float3> nextCorners, ref MovementState state, ref AgentMovementPlane movementPlane, ref LocalTransform transform, ref AgentCylinderShape shape, ref DestinationPoint destination, float stopDistance, ref PathTracerInfo pathTracer);

		[Token(Token = "0x200034D")]
		internal static class UpdateReachedEndInfo_0000138C_0024BurstDirectCall
		{
			[Token(Token = "0x4000EA3")]
			[FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			[Token(Token = "0x4000EA4")]
			[FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;

			[Token(Token = "0x6001500")]
			[Address(RVA = "0x44C7F7C", Offset = "0x44C3F7C", VA = "0x44C7F7C")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
			}

			[Token(Token = "0x6001501")]
			[Address(RVA = "0x44C8098", Offset = "0x44C4098", VA = "0x44C8098")]
			private static IntPtr GetFunctionPointer()
			{
				return default;
			}

			[Token(Token = "0x6001502")]
			[Address(RVA = "0x44C80F4", Offset = "0x44C40F4", VA = "0x44C80F4")]
			public static void Constructor()
			{
			}

			[Token(Token = "0x6001503")]
			[Address(RVA = "0x44C819C", Offset = "0x44C419C", VA = "0x44C819C")]
			public static void Initialize()
			{
			}

			[Token(Token = "0x6001505")]
			[Address(RVA = "0x44C76AC", Offset = "0x44C36AC", VA = "0x44C76AC")]
			public static void Invoke(ref UnsafeSpan<float3> nextCorners, ref MovementState state, ref AgentMovementPlane movementPlane, ref LocalTransform transform, ref AgentCylinderShape shape, ref DestinationPoint destination, float stopDistance, ref PathTracerInfo pathTracer)
			{
			}
		}

		[Token(Token = "0x60014F8")]
		[Address(RVA = "0x44C6D78", Offset = "0x44C2D78", VA = "0x44C6D78")]
		[BurstCompile]
		public static void UpdateReachedEndInfo(ref UnsafeSpan<float3> nextCorners, ref MovementState state, ref AgentMovementPlane movementPlane, ref LocalTransform transform, ref AgentCylinderShape shape, ref DestinationPoint destination, float stopDistance, ref PathTracerInfo pathTracer)
		{
		}

		[Token(Token = "0x60014F9")]
		[Address(RVA = "0x44C6E24", Offset = "0x44C2E24", VA = "0x44C6E24")]
		public static void UpdateReachedOrientation(ref MovementState state, ref LocalTransform transform, ref AgentMovementPlane movementPlane, ref DestinationPoint destination)
		{
		}

		[Token(Token = "0x60014FA")]
		[Address(RVA = "0x44C77D4", Offset = "0x44C37D4", VA = "0x44C77D4")]
		private static bool ReachedDesiredOrientation(ref LocalTransform transform, ref AgentMovementPlane movementPlane, ref DestinationPoint destination)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60014FB")]
		[Address(RVA = "0x44C799C", Offset = "0x44C399C", VA = "0x44C799C")]
		[BurstCompile]
		public static void UpdateReachedEndInfo_0024BurstManaged(ref UnsafeSpan<float3> nextCorners, ref MovementState state, ref AgentMovementPlane movementPlane, ref LocalTransform transform, ref AgentCylinderShape shape, ref DestinationPoint destination, float stopDistance, ref PathTracerInfo pathTracer)
		{
		}
	}
}
