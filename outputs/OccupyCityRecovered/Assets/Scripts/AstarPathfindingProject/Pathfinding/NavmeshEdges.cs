using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Pathfinding.Collections;
using Pathfinding.Drawing;
using Pathfinding.RVO;
using Pathfinding.Sync;
using Pathfinding.Util;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x200007B")]
	[BurstCompile]
	public class NavmeshEdges
	{
		[Token(Token = "0x200007C")]
		[BurstCompile]
		private struct JobResizeObstacles : IJob
		{
			[Token(Token = "0x40002BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public NativeList<UnmanagedObstacle> obstacles;

			[Token(Token = "0x40002BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public NativeReference<int> numHierarchicalNodes;

			[Token(Token = "0x6000460")]
			[Address(RVA = "0x4500F0C", Offset = "0x44FCF0C", VA = "0x4500F0C", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Token(Token = "0x200007D")]
		private struct JobCalculateObstacles : IJobParallelForBatch
		{
			[Token(Token = "0x40002BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public GCHandle hGraphGC;

			[Token(Token = "0x40002BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public SlabAllocator<float3> obstacleVertices;

			[Token(Token = "0x40002BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SlabAllocator<ObstacleVertexGroup> obstacleVertexGroups;

			[Token(Token = "0x40002C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[NativeDisableParallelForRestriction]
			public NativeArray<UnmanagedObstacle> obstacles;

			[Token(Token = "0x40002C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[NativeDisableParallelForRestriction]
			public NativeArray<Bounds> bounds;

			[Token(Token = "0x40002C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[ReadOnly]
			public NativeList<int> dirtyHierarchicalNodes;

			[Token(Token = "0x40002C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[NativeDisableParallelForRestriction]
			public NativeReference<SpinLock> allocationLock;

			[Token(Token = "0x40002C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static readonly ProfilerMarker MarkerBBox;

			[Token(Token = "0x40002C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static readonly ProfilerMarker MarkerObstacles;

			[Token(Token = "0x40002C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static readonly ProfilerMarker MarkerCollect;

			[Token(Token = "0x40002C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static readonly ProfilerMarker MarkerTrace;

			[Token(Token = "0x6000461")]
			[Address(RVA = "0x4501074", Offset = "0x44FD074", VA = "0x4501074", Slot = "4")]
			public void Execute(int startIndex, int count)
			{
			}

			[Token(Token = "0x6000462")]
			[Address(RVA = "0x4501298", Offset = "0x44FD298", VA = "0x4501298")]
			private void CalculateBoundingBox(HierarchicalGraph hGraph, int hierarchicalNode)
			{
			}

			[Token(Token = "0x6000463")]
			[Address(RVA = "0x4501BA0", Offset = "0x44FDBA0", VA = "0x4501BA0")]
			private void CalculateObstacles(HierarchicalGraph hGraph, int hierarchicalNode, SlabAllocator<ObstacleVertexGroup> obstacleVertexGroups, SlabAllocator<float3> obstacleVertices, NativeArray<UnmanagedObstacle> obstacles, NativeList<RVOObstacleCache.ObstacleSegment> edgesScratch)
			{
			}
		}

		[Token(Token = "0x200007E")]
		public struct NavmeshBorderData
		{
			[Token(Token = "0x40002C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public HierarchicalGraph.HierarhicalNodeData hierarhicalNodeData;

			[Token(Token = "0x40002C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SimulatorBurst.ObstacleData obstacleData;

			[Token(Token = "0x6000465")]
			[Address(RVA = "0x4502124", Offset = "0x44FE124", VA = "0x4502124")]
			public static NavmeshBorderData CreateEmpty(Allocator allocator)
			{
				return default;
			}

			[Token(Token = "0x6000466")]
			[Address(RVA = "0x450222C", Offset = "0x44FE22C", VA = "0x450222C")]
			public void DisposeEmpty(JobHandle dependsOn)
			{
			}

			[Token(Token = "0x6000467")]
			[Address(RVA = "0x4502348", Offset = "0x44FE348", VA = "0x4502348")]
			private static void GetHierarchicalNodesInRangeRec(int hierarchicalNode, Bounds bounds, SlabAllocator<int> connectionAllocator, [NoAlias] NativeList<int> connectionAllocations, NativeList<Bounds> nodeBounds, [NoAlias] NativeList<int> indices)
			{
			}

			[Token(Token = "0x6000468")]
			[Address(RVA = "0x450258C", Offset = "0x44FE58C", VA = "0x450258C")]
			private static void ConvertObstaclesToEdges(ref SimulatorBurst.ObstacleData obstacleData, NativeList<int> obstacleIndices, Bounds localBounds, NativeList<float2> edgeBuffer, NativeMovementPlane movementPlane)
			{
			}

			[Token(Token = "0x6000469")]
			[Address(RVA = "0x4502DA0", Offset = "0x44FEDA0", VA = "0x4502DA0")]
			public GraphHitInfo GetClosestEdge(int hierarchicalNode, float3 position, NativeList<int> scratchBuffer)
			{
				return default;
			}

			[Token(Token = "0x600046A")]
			[Address(RVA = "0x45035E8", Offset = "0x44FF5E8", VA = "0x45035E8")]
			public void GetObstaclesInRange(int hierarchicalNode, Bounds bounds, NativeList<int> obstacleIndexBuffer)
			{
			}

			[Token(Token = "0x600046B")]
			[Address(RVA = "0x4503718", Offset = "0x44FF718", VA = "0x4503718")]
			public void GetEdgesInRange(int hierarchicalNode, Bounds localBounds, NativeList<float2> edgeBuffer, NativeList<int> scratchBuffer, NativeMovementPlane movementPlane)
			{
			}
		}

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SimulatorBurst.ObstacleData obstacleData;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private NativeReference<SpinLock> allocationLock;

		[Token(Token = "0x40002B7")]
		private const int JobRecalculateObstaclesBatchCount = 32;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private RWLock rwLock;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public HierarchicalGraph hierarchicalGraph;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int gizmoVersion;

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x4500320", Offset = "0x44FC320", VA = "0x4500320")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x45003C4", Offset = "0x44FC3C4", VA = "0x45003C4")]
		private void Init()
		{
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x4500470", Offset = "0x44FC470", VA = "0x4500470")]
		public JobHandle RecalculateObstacles(NativeList<int> dirtyHierarchicalNodes, NativeReference<int> numHierarchicalNodes, JobHandle dependency)
		{
			return default;
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x4500640", Offset = "0x44FC640", VA = "0x4500640")]
		public void OnDrawGizmos(DrawingData gizmos, bool renderInGame)
		{
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x4500DB0", Offset = "0x44FCDB0", VA = "0x4500DB0")]
		public NavmeshBorderData GetNavmeshEdgeData(out RWLock.CombinedReadLockAsync readLock)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED NavmeshEdges.GetNavmeshEdgeData RVA=0x4500DB0 Token=0x600045E");
}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x4500EAC", Offset = "0x44FCEAC", VA = "0x4500EAC")]
		public NavmeshEdges()
		{
		}
	}
}
