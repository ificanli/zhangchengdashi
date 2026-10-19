using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Pathfinding.Collections;
using Pathfinding.Sync;
using Pathfinding.Util;
using Unity.Burst;
using Unity.Collections;
using Unity.Mathematics;
using Unity.Profiling;

namespace Pathfinding.RVO
{
	[Token(Token = "0x20002CE")]
	[BurstCompile]
	public static class RVOObstacleCache
	{
		[Token(Token = "0x20002CF")]
		public struct ObstacleSegment
		{
			[Token(Token = "0x4000CE8")]
			[FieldOffset(Offset = "0x0")]
			public float3 vertex1;

			[Token(Token = "0x4000CE9")]
			[FieldOffset(Offset = "0xC")]
			public float3 vertex2;

			[Token(Token = "0x4000CEA")]
			[FieldOffset(Offset = "0x18")]
			public int vertex1LinkId;

			[Token(Token = "0x4000CEB")]
			[FieldOffset(Offset = "0x1C")]
			public int vertex2LinkId;
		}

		[Token(Token = "0x20002D0")]
		internal unsafe delegate void TraceContours_00001070_0024PostfixBurstDelegate(ref UnsafeSpan<ObstacleSegment> obstaclesSpan, ref NativeMovementPlane movementPlane, int obstacleId, UnmanagedObstacle* outputObstacles, ref SlabAllocator<float3> verticesAllocator, ref SlabAllocator<ObstacleVertexGroup> obstaclesAllocator, ref SpinLock spinLock, bool simplifyObstacles);

		[Token(Token = "0x20002D1")]
		internal static class TraceContours_00001070_0024BurstDirectCall
		{
			[Token(Token = "0x4000CEC")]
			[FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			[Token(Token = "0x4000CED")]
			[FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;

			[Token(Token = "0x60011C2")]
			[Address(RVA = "0x44A15F8", Offset = "0x449D5F8", VA = "0x44A15F8")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
			}

			[Token(Token = "0x60011C3")]
			[Address(RVA = "0x44A1714", Offset = "0x449D714", VA = "0x44A1714")]
			private static IntPtr GetFunctionPointer()
			{
				return default;
			}

			[Token(Token = "0x60011C4")]
			[Address(RVA = "0x44A1770", Offset = "0x449D770", VA = "0x44A1770")]
			public static void Constructor()
			{
			}

			[Token(Token = "0x60011C5")]
			[Address(RVA = "0x44A1818", Offset = "0x449D818", VA = "0x44A1818")]
			public static void Initialize()
			{
			}

			[Token(Token = "0x60011C7")]
			[Address(RVA = "0x44A0868", Offset = "0x449C868", VA = "0x44A0868")]
			public unsafe static void Invoke(ref UnsafeSpan<ObstacleSegment> obstaclesSpan, ref NativeMovementPlane movementPlane, int obstacleId, UnmanagedObstacle* outputObstacles, ref SlabAllocator<float3> verticesAllocator, ref SlabAllocator<ObstacleVertexGroup> obstaclesAllocator, ref SpinLock spinLock, bool simplifyObstacles)
			{
			}
		}

		[Token(Token = "0x4000CE7")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ProfilerMarker MarkerAllocate;

		[Token(Token = "0x60011B9")]
		[Address(RVA = "0x449FD84", Offset = "0x449BD84", VA = "0x449FD84")]
		private static ulong HashKey(GraphNode sourceNode, int traversableTags, SimpleMovementPlane movementPlane)
		{
			return default;
		}

		[Token(Token = "0x60011BA")]
		[Address(RVA = "0x449FE40", Offset = "0x449BE40", VA = "0x449FE40")]
		public static void CollectContours(List<GraphNode> nodes, NativeList<ObstacleSegment> obstacles)
		{
		}

		[Token(Token = "0x60011BB")]
		[Address(RVA = "0x44A07BC", Offset = "0x449C7BC", VA = "0x44A07BC")]
		[BurstCompile]
		internal unsafe static void TraceContours(ref UnsafeSpan<ObstacleSegment> obstaclesSpan, ref NativeMovementPlane movementPlane, int obstacleId, UnmanagedObstacle* outputObstacles, ref SlabAllocator<float3> verticesAllocator, ref SlabAllocator<ObstacleVertexGroup> obstaclesAllocator, ref SpinLock spinLock, bool simplifyObstacles)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x60011BD")]
		[Address(RVA = "0x44A0A28", Offset = "0x449CA28", VA = "0x44A0A28")]
		[BurstCompile]
		internal unsafe static void TraceContours_0024BurstManaged(ref UnsafeSpan<ObstacleSegment> obstaclesSpan, ref NativeMovementPlane movementPlane, int obstacleId, UnmanagedObstacle* outputObstacles, ref SlabAllocator<float3> verticesAllocator, ref SlabAllocator<ObstacleVertexGroup> obstaclesAllocator, ref SpinLock spinLock, bool simplifyObstacles)
		{
		}
	}
}
