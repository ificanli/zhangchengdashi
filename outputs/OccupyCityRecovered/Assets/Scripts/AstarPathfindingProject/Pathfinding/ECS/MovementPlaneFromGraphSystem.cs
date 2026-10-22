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
            var node = managedState.pathTracer.startNode as TriangleMeshNode;
            if (node == null) return;
            float radius = shape.radius >= 0.01f ? shape.radius : 0.01f;
            SampleSmoothNavmeshNormal(node, que, vertices, localTransform.Position, radius, ref agentMovementPlane, dt * 20f);
        }

			[Token(Token = "0x6001670")]
			[Address(RVA = "0x44D6F98", Offset = "0x44D2F98", VA = "0x44D6F98", Slot = "4")]
void IJobChunk.Execute(in ArchetypeChunk chunk, int unfilteredChunkIndex, bool useEnabledMask, in v128 chunkEnabledMask)
			{ Execute(in chunk, unfilteredChunkIndex, useEnabledMask, in chunkEnabledMask); }
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
            uint index = movementState.graphIndex;
            if (index < (uint)movementPlanes.Length) movementPlane = movementPlanes[(int)index];
        }

			[Token(Token = "0x6001695")]
			[Address(RVA = "0x44D798C", Offset = "0x44D398C", VA = "0x44D798C", Slot = "4")]
void IJobChunk.Execute(in ArchetypeChunk chunk, int unfilteredChunkIndex, bool useEnabledMask, in v128 chunkEnabledMask)
			{ Execute(in chunk, unfilteredChunkIndex, useEnabledMask, in chunkEnabledMask); }
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
            __Pathfinding_ECS_MovementPlaneFromGraphSystem_JobMovementPlaneFromNavmeshNormal_WithoutDefaultQuery_JobEntityTypeHandle.Init(ref state, false);
            __Pathfinding_ECS_MovementPlaneFromGraphSystem_JobMovementPlaneFromGraph_WithoutDefaultQuery_JobEntityTypeHandle.Init(ref state, false);
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
            entityQueryGraph = state.GetEntityQuery(new ComponentType[] {
                ComponentType.ReadOnly<MovementState>(),
                ComponentType.ReadWrite<AgentMovementPlane>(),
                ComponentType.ReadOnly<AgentMovementPlaneSource>()
            });
            entityQueryGraph.SetSharedComponentFilter(new AgentMovementPlaneSource { value = MovementPlaneSource.Graph });
            entityQueryNormal = state.GetEntityQuery(new ComponentType[] {
                ComponentType.ReadWrite<ManagedState>(),
                ComponentType.ReadOnly<LocalTransform>(),
                ComponentType.ReadWrite<AgentMovementPlane>(),
                ComponentType.ReadOnly<AgentCylinderShape>(),
                ComponentType.ReadOnly<AgentMovementPlaneSource>()
            });
            entityQueryNormal.AddSharedComponentFilter(new AgentMovementPlaneSource { value = MovementPlaneSource.NavmeshNormal });
            graphNodeQueue = GCHandle.Alloc(new List<GraphNode>(32));
        }

		[Token(Token = "0x6001647")]
		[Address(RVA = "0x44D4E4C", Offset = "0x44D0E4C", VA = "0x44D4E4C", Slot = "5")]
		public void OnDestroy(ref SystemState state)
		{
            graphNodeQueue.Free();
        }

		[Token(Token = "0x6001648")]
		[Address(RVA = "0x44D4E58", Offset = "0x44D0E58", VA = "0x44D4E58", Slot = "6")]
		public void OnUpdate(ref SystemState systemState)
		{
            if (ReferenceEquals(AstarPath.active, null)) return;
            var graphs = AstarPath.active.data.graphs;
            if (graphs == null) return;
            var planes = Unity.Collections.CollectionHelper.CreateNativeArray<AgentMovementPlane>(graphs.Length, systemState.WorldUpdateAllocator, NativeArrayOptions.UninitializedMemory);
            for (int i = 0; i < graphs.Length; i++) planes[i] = new AgentMovementPlane { value = MovementPlaneFromGraph(graphs[i]) };
            if (!entityQueryNormal.IsEmpty) {
                systemState.CompleteDependency();
                var vertices = new NativeList<Int3>(16, Allocator.Temp);
                var job = new JobMovementPlaneFromNavmeshNormal {
                    dt = AIMovementSystemGroup.TimeScaledRateManager.CheapStepDeltaTime,
                    vertices = vertices,
                    que = (List<GraphNode>)graphNodeQueue.Target
                };
                __ScheduleViaJobChunkExtension_0(job, entityQueryNormal, systemState.Dependency, ref systemState, true);
            }
            systemState.Dependency = __ScheduleViaJobChunkExtension_1(new JobMovementPlaneFromGraph { movementPlanes = planes }, entityQueryGraph, systemState.Dependency, ref systemState, true);
        }

		[Token(Token = "0x6001649")]
		[Address(RVA = "0x44D51A4", Offset = "0x44D11A4", VA = "0x44D51A4")]
		public static NativeMovementPlane MovementPlaneFromGraph(NavGraph graph)
		{
            quaternion rotation;
            if (graph is NavmeshBase navmesh) rotation = navmesh.transform.rotation;
            else if (graph is GridGraph grid) rotation = grid.transform.rotation;
            else rotation = quaternion.identity;
            return new NativeMovementPlane(rotation);
        }

		[Token(Token = "0x600164A")]
		[Address(RVA = "0x44D52B8", Offset = "0x44D12B8", VA = "0x44D52B8")]
		public static void SampleSmoothNavmeshNormal(TriangleMeshNode node, List<GraphNode> scratchList, NativeList<Int3> scratchBuffer, float3 position, float agentRadius, ref AgentMovementPlane agentMovementPlane, float alpha)
		{
            scratchBuffer.Clear();
            scratchList.Clear();
            node.TemporaryFlag1 = true;
            scratchList.Add(node);
            int v0 = node.v0, v1 = node.v1, v2 = node.v2;
            for (int i = 0; i < scratchList.Count; i++) {
                var triangle = scratchList[i] as TriangleMeshNode;
                if (triangle == null) continue;
                if (triangle.v0 != v0 && triangle.v0 != v1 && triangle.v0 != v2 &&
                    triangle.v1 != v0 && triangle.v1 != v1 && triangle.v1 != v2 &&
                    triangle.v2 != v0 && triangle.v2 != v1 && triangle.v2 != v2) continue;
                Int3 a, b, c;
                triangle.GetVertices(out a, out b, out c);
                scratchBuffer.Add(a);
                scratchBuffer.Add(b);
                scratchBuffer.Add(c);
                triangle.GetConnections((GraphNode con, ref List<GraphNode> que) => {
                    if (!con.TemporaryFlag1) {
                        con.TemporaryFlag1 = true;
                        que.Add(con);
                    }
                }, ref scratchList, 32);
            }
            for (int i = 0; i < scratchList.Count; i++) scratchList[i].TemporaryFlag1 = false;
            var triangleVertices = scratchBuffer.AsUnsafeSpan();
            SampleSmoothTriangleNormal(ref position, ref triangleVertices, ref agentMovementPlane, agentRadius, alpha);
        }

		[Token(Token = "0x600164B")]
		[Address(RVA = "0x44D578C", Offset = "0x44D178C", VA = "0x44D578C")]
		private static float Square(float x)
		{
            return x * x;
        }

		[Token(Token = "0x600164C")]
		[Address(RVA = "0x44D5794", Offset = "0x44D1794", VA = "0x44D5794")]
		private static float SinAngle(float3 a, float3 b, float3 c)
		{
            float3 ab = math.normalizesafe(a - b);
            float3 cb = math.normalizesafe(c - b);
            float cosine = (ab.x * cb.x + ab.y * cb.y) + ab.z * cb.z;
            return math.sqrt(1f - cosine * cosine);
        }

		[Token(Token = "0x600164D")]
		[Address(RVA = "0x44D5708", Offset = "0x44D1708", VA = "0x44D5708")]
		[BurstCompile(FloatMode = FloatMode.Fast)]
		private static void SampleSmoothTriangleNormal(ref float3 position, ref UnsafeSpan<Int3> _triangleVertices, ref AgentMovementPlane agentMovementPlane, float agentRadius, float alpha)
		{
            SampleSmoothTriangleNormal_0024BurstManaged(ref position, ref _triangleVertices, ref agentMovementPlane, agentRadius, alpha);
        }

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600164E")]
		[Address(RVA = "0x44D5A5C", Offset = "0x44D1A5C", VA = "0x44D5A5C")]
		private void __ScheduleViaJobChunkExtension_0(JobMovementPlaneFromNavmeshNormal job, EntityQuery query, JobHandle dependency, ref SystemState state, bool hasUserDefinedQuery)
		{
            __TypeHandle.__Pathfinding_ECS_MovementPlaneFromGraphSystem_JobMovementPlaneFromNavmeshNormal_WithoutDefaultQuery_JobEntityTypeHandle.AssignEntityManager(ref job, state.EntityManager);
            __TypeHandle.__Pathfinding_ECS_MovementPlaneFromGraphSystem_JobMovementPlaneFromNavmeshNormal_WithoutDefaultQuery_JobEntityTypeHandle.__TypeHandle.Update(ref state);
            __TypeHandle.__Pathfinding_ECS_MovementPlaneFromGraphSystem_JobMovementPlaneFromNavmeshNormal_WithoutDefaultQuery_JobEntityTypeHandle.Run(ref job, query);
        }

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600164F")]
		[Address(RVA = "0x44D5BB0", Offset = "0x44D1BB0", VA = "0x44D5BB0")]
		private JobHandle __ScheduleViaJobChunkExtension_1(JobMovementPlaneFromGraph job, EntityQuery query, JobHandle dependency, ref SystemState state, bool hasUserDefinedQuery)
		{
            __TypeHandle.__Pathfinding_ECS_MovementPlaneFromGraphSystem_JobMovementPlaneFromGraph_WithoutDefaultQuery_JobEntityTypeHandle.__TypeHandle.Update(ref state);
            return __TypeHandle.__Pathfinding_ECS_MovementPlaneFromGraphSystem_JobMovementPlaneFromGraph_WithoutDefaultQuery_JobEntityTypeHandle.ScheduleParallel(ref job, query, dependency);
        }

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6001650")]
		[Address(RVA = "0x44D5CC4", Offset = "0x44D1CC4", VA = "0x44D5CC4")]
		private void __AssignQueries(ref SystemState state)
		{
            var builder = new EntityQueryBuilder(Allocator.Temp);
            builder.Dispose();
        }

		[Token(Token = "0x6001651")]
		[Address(RVA = "0x44D5D04", Offset = "0x44D1D04", VA = "0x44D5D04", Slot = "7")]
		public void OnCreateForCompiler(ref SystemState state)
		{
            __AssignQueries(ref state);
            __TypeHandle.__AssignHandles(ref state);
        }

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6001656")]
		[Address(RVA = "0x44D5D74", Offset = "0x44D1D74", VA = "0x44D5D74")]
		[BurstCompile(FloatMode = FloatMode.Fast)]
		public static void SampleSmoothTriangleNormal_0024BurstManaged(ref float3 position, ref UnsafeSpan<Int3> _triangleVertices, ref AgentMovementPlane agentMovementPlane, float agentRadius, float alpha)
		{
            if (_triangleVertices.Length < 3) throw new ArgumentException("triangleVertices.Length < 3");
            float3 weights = float3.zero;
            float3x3 normals = new float3x3(float3.zero, float3.zero, float3.zero);
            float3 up = agentMovementPlane.value.up;
            float radiusSquared = Square(agentRadius * 1.5f);
            for (int i = 0; i < _triangleVertices.Length; i += 3) {
                Int3 ia = _triangleVertices[i], ib = _triangleVertices[i + 1], ic = _triangleVertices[i + 2];
                float3 a = new float3(ia.x, ia.y, ia.z) * 0.001f;
                float3 b = new float3(ib.x, ib.y, ib.z) * 0.001f;
                float3 c = new float3(ic.x, ic.y, ic.z) * 0.001f;
                float3 normal = math.normalizesafe(math.cross(b - a, c - a));
                float slopeDot = math.dot(up, normal);
                float weight = 1f;
                if (slopeDot < 0.86f) {
                    float3 closest;
                    Polygon.ClosestPointOnTriangleByRef(in a, in b, in c, in position, out closest);
                    float falloff = 1f - math.lengthsq(closest - position) / radiusSquared;
                    float clampedDot = slopeDot >= 0f ? slopeDot : 0f;
                    float clampedFalloff = falloff >= 0.1f ? falloff : 0.1f;
                    weight = ((0.86f - clampedDot) / 0.86f) * (clampedFalloff - 1f) + 1f;
                }
                for (int j = 0; j < 3; j++) {
                    Int3 vertex = _triangleVertices[j];
                    if (ia.x == vertex.x && ia.y == vertex.y && ia.z == vertex.z) {
                        float w = weight * SinAngle(c, a, b);
                        weights[j] += w;
                        normals[j] += normal * w;
                    }
                }
                for (int j = 0; j < 3; j++) {
                    Int3 vertex = _triangleVertices[j];
                    if (ib.x == vertex.x && ib.y == vertex.y && ib.z == vertex.z) {
                        float w = weight * SinAngle(a, b, c);
                        weights[j] += w;
                        normals[j] += normal * w;
                    }
                }
                for (int j = 0; j < 3; j++) {
                    Int3 vertex = _triangleVertices[j];
                    if (ic.x == vertex.x && ic.y == vertex.y && ic.z == vertex.z) {
                        float w = weight * SinAngle(b, c, a);
                        weights[j] += w;
                        normals[j] += normal * w;
                    }
                }
            }
            for (int j = 0; j < 3; j++) if (weights[j] > 0f) normals[j] /= weights[j];
            Int3 firstA = _triangleVertices[0], firstB = _triangleVertices[1], firstC = _triangleVertices[2];
            float3 barycentric = Polygon.ClosestPointOnTriangleBarycentric(
                new float3(firstA.x, firstA.y, firstA.z) * 0.001f,
                new float3(firstB.x, firstB.y, firstB.z) * 0.001f,
                new float3(firstC.x, firstC.y, firstC.z) * 0.001f, position);
            float3 smoothUp = math.normalizesafe((normals.c0 * barycentric.x + normals.c1 * barycentric.y) + normals.c2 * barycentric.z);
            float interpolation = alpha <= 1f ? alpha : 1f;
            if (!(interpolation >= 0f)) interpolation = 0f;
            agentMovementPlane.value = agentMovementPlane.value.MatchUpDirection(up + interpolation * (smoothUp - up));
        }
	}
}
