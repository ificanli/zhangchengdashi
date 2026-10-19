using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Pathfinding.Collections;
using Pathfinding.Util;
using Unity.Burst;
using Unity.Burst.Intrinsics;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Transforms;

namespace Pathfinding.ECS
{
	[Token(Token = "0x200037C")]
	[UpdateInGroup(typeof(AIMovementSystemGroup))]
	[UpdateBefore(typeof(SchedulePathSearchSystem))]
	[RequireMatchingQueriesForUpdate]
	[BurstCompile]
	public partial struct MovementPlaneFromGraphSystem : ISystem, ISystemCompilerGenerated
	{
		[Token(Token = "0x200037D")]
		private partial struct JobMovementPlaneFromNavmeshNormal : IJobEntity, IJobChunk
		{

			[Token(Token = "0x4000F16")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float dt;

			[Token(Token = "0x4000F17")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public NativeList<Int3> vertices;

			[Token(Token = "0x4000F18")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<GraphNode> que;

			[Token(Token = "0x6001657")]
			[Address(RVA = "0x44D687C", Offset = "0x44D287C", VA = "0x44D687C")]
			public void Execute(ManagedState managedState, in LocalTransform localTransform, ref AgentMovementPlane agentMovementPlane, in AgentCylinderShape shape)
			{
			}

			[Token(Token = "0x6001670")]
			[Address(RVA = "0x44D6F98", Offset = "0x44D2F98", VA = "0x44D6F98", Slot = "4")]
void IJobChunk.Execute(in ArchetypeChunk chunk, int unfilteredChunkIndex, bool useEnabledMask, in v128 chunkEnabledMask)
			{
			}
		}

		[Token(Token = "0x2000381")]
		[BurstCompile]
		private partial struct JobMovementPlaneFromGraph : IJobEntity, IJobChunk
		{

			[Token(Token = "0x4000F21")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public NativeArray<AgentMovementPlane> movementPlanes;

			[Token(Token = "0x600167C")]
			[Address(RVA = "0x44D74A8", Offset = "0x44D34A8", VA = "0x44D74A8")]
			public void Execute(in MovementState movementState, ref AgentMovementPlane movementPlane)
			{
			}

			[Token(Token = "0x6001695")]
			[Address(RVA = "0x44D798C", Offset = "0x44D398C", VA = "0x44D798C", Slot = "4")]
void IJobChunk.Execute(in ArchetypeChunk chunk, int unfilteredChunkIndex, bool useEnabledMask, in v128 chunkEnabledMask)
			{
			}
		}

		[Token(Token = "0x2000385")]
		private struct TypeHandle
		{
			[Token(Token = "0x4000F27")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public JobMovementPlaneFromNavmeshNormal.InternalCompilerQueryAndHandleData __Pathfinding_ECS_MovementPlaneFromGraphSystem_JobMovementPlaneFromNavmeshNormal_WithoutDefaultQuery_JobEntityTypeHandle;

			[Token(Token = "0x4000F28")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			public JobMovementPlaneFromGraph.InternalCompilerQueryAndHandleData __Pathfinding_ECS_MovementPlaneFromGraphSystem_JobMovementPlaneFromGraph_WithoutDefaultQuery_JobEntityTypeHandle;

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x60016A1")]
			[Address(RVA = "0x44D7DC8", Offset = "0x44D3DC8", VA = "0x44D7DC8")]
			public void __AssignHandles(ref SystemState state)
			{
			}
		}

		[Token(Token = "0x2000387")]
		public delegate void SampleSmoothTriangleNormal_000014C0_0024PostfixBurstDelegate(ref float3 position, ref UnsafeSpan<Int3> _triangleVertices, ref AgentMovementPlane agentMovementPlane, float agentRadius, float alpha);

		[Token(Token = "0x2000388")]
		internal static class SampleSmoothTriangleNormal_000014C0_0024BurstDirectCall
		{
			[Token(Token = "0x4000F2B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			[Token(Token = "0x4000F2C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;

			[Token(Token = "0x60016A9")]
			[Address(RVA = "0x44D811C", Offset = "0x44D411C", VA = "0x44D811C")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
			}

			[Token(Token = "0x60016AA")]
			[Address(RVA = "0x44D8238", Offset = "0x44D4238", VA = "0x44D8238")]
			private static IntPtr GetFunctionPointer()
			{
				return default;
			}

			[Token(Token = "0x60016AB")]
			[Address(RVA = "0x44D8294", Offset = "0x44D4294", VA = "0x44D8294")]
			public static void Constructor()
			{
			}

			[Token(Token = "0x60016AC")]
			[Address(RVA = "0x44D833C", Offset = "0x44D433C", VA = "0x44D833C")]
			public static void Initialize()
			{
			}

			[Token(Token = "0x60016AE")]
			[Address(RVA = "0x44D5970", Offset = "0x44D1970", VA = "0x44D5970")]
			public static void Invoke(ref float3 position, ref UnsafeSpan<Int3> _triangleVertices, ref AgentMovementPlane agentMovementPlane, float agentRadius, float alpha)
			{
			}
		}

		[Token(Token = "0x4000F12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public EntityQuery entityQueryGraph;

		[Token(Token = "0x4000F13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public EntityQuery entityQueryNormal;

		[Token(Token = "0x4000F14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GCHandle graphNodeQueue;

		[Token(Token = "0x4000F15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TypeHandle __TypeHandle;

		[Token(Token = "0x6001646")]
		[Address(RVA = "0x44D4BA0", Offset = "0x44D0BA0", VA = "0x44D4BA0", Slot = "4")]
		public void OnCreate(ref SystemState state)
		{
		}

		[Token(Token = "0x6001647")]
		[Address(RVA = "0x44D4E4C", Offset = "0x44D0E4C", VA = "0x44D4E4C", Slot = "5")]
		public void OnDestroy(ref SystemState state)
		{
		}

		[Token(Token = "0x6001648")]
		[Address(RVA = "0x44D4E58", Offset = "0x44D0E58", VA = "0x44D4E58", Slot = "6")]
		public void OnUpdate(ref SystemState systemState)
		{
		}

		[Token(Token = "0x6001649")]
		[Address(RVA = "0x44D51A4", Offset = "0x44D11A4", VA = "0x44D51A4")]
		public static NativeMovementPlane MovementPlaneFromGraph(NavGraph graph)
		{
			return default;
		}

		[Token(Token = "0x600164A")]
		[Address(RVA = "0x44D52B8", Offset = "0x44D12B8", VA = "0x44D52B8")]
		public static void SampleSmoothNavmeshNormal(TriangleMeshNode node, List<GraphNode> scratchList, NativeList<Int3> scratchBuffer, float3 position, float agentRadius, ref AgentMovementPlane agentMovementPlane, float alpha)
		{
		}

		[Token(Token = "0x600164B")]
		[Address(RVA = "0x44D578C", Offset = "0x44D178C", VA = "0x44D578C")]
		private static float Square(float x)
		{
			return default;
		}

		[Token(Token = "0x600164C")]
		[Address(RVA = "0x44D5794", Offset = "0x44D1794", VA = "0x44D5794")]
		private static float SinAngle(float3 a, float3 b, float3 c)
		{
			return default;
		}

		[Token(Token = "0x600164D")]
		[Address(RVA = "0x44D5708", Offset = "0x44D1708", VA = "0x44D5708")]
		[BurstCompile(FloatMode = FloatMode.Fast)]
		private static void SampleSmoothTriangleNormal(ref float3 position, ref UnsafeSpan<Int3> _triangleVertices, ref AgentMovementPlane agentMovementPlane, float agentRadius, float alpha)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600164E")]
		[Address(RVA = "0x44D5A5C", Offset = "0x44D1A5C", VA = "0x44D5A5C")]
		private void __ScheduleViaJobChunkExtension_0(JobMovementPlaneFromNavmeshNormal job, EntityQuery query, JobHandle dependency, ref SystemState state, bool hasUserDefinedQuery)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600164F")]
		[Address(RVA = "0x44D5BB0", Offset = "0x44D1BB0", VA = "0x44D5BB0")]
		private JobHandle __ScheduleViaJobChunkExtension_1(JobMovementPlaneFromGraph job, EntityQuery query, JobHandle dependency, ref SystemState state, bool hasUserDefinedQuery)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6001650")]
		[Address(RVA = "0x44D5CC4", Offset = "0x44D1CC4", VA = "0x44D5CC4")]
		private void __AssignQueries(ref SystemState state)
		{
		}

		[Token(Token = "0x6001651")]
		[Address(RVA = "0x44D5D04", Offset = "0x44D1D04", VA = "0x44D5D04", Slot = "7")]
		public void OnCreateForCompiler(ref SystemState state)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6001656")]
		[Address(RVA = "0x44D5D74", Offset = "0x44D1D74", VA = "0x44D5D74")]
		[BurstCompile(FloatMode = FloatMode.Fast)]
		public static void SampleSmoothTriangleNormal_0024BurstManaged(ref float3 position, ref UnsafeSpan<Int3> _triangleVertices, ref AgentMovementPlane agentMovementPlane, float agentRadius, float alpha)
		{
		}
	}
}
