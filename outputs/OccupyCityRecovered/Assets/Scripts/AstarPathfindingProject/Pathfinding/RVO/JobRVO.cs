using System.Collections.Generic;
using Il2CppDummyDll;
using Pathfinding.Collections;
using Pathfinding.Drawing;
using Pathfinding.Jobs;
using Unity.Burst;
using Unity.Collections;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine;

namespace Pathfinding.RVO
{
	[Token(Token = "0x20002B6")]
	[BurstCompile(CompileSynchronously = true, FloatMode = FloatMode.Default)]
	public struct JobRVO<MovementPlaneWrapper> : IJobParallelForBatched where MovementPlaneWrapper : struct, IMovementPlaneWrapper
	{
		[Token(Token = "0x20002B7")]
		private struct SortByKey : IComparer<int>
		{
			[Token(Token = "0x4000C66")]
			[FieldOffset(Offset = "0x0")]
			public UnsafeSpan<float> keys;

			[Token(Token = "0x6001122")]
			public int Compare(int x, int y)
			{
				return default;
			}
		}

		[Token(Token = "0x20002B8")]
		private struct ORCALine
		{
			[Token(Token = "0x4000C67")]
			[FieldOffset(Offset = "0x0")]
			public float2 point;

			[Token(Token = "0x4000C68")]
			[FieldOffset(Offset = "0x0")]
			public float2 direction;

			[Token(Token = "0x6001123")]
			public void DrawAsHalfPlane(CommandBuilder draw, float halfPlaneLength, float halfPlaneWidth, Color color)
			{
			}

			[Token(Token = "0x6001124")]
			public ORCALine(float2 position, float2 relativePosition, float2 velocity, float2 otherVelocity, float combinedRadius, float timeStep, float invTimeHorizon)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED JobRVO.ORCALine..ctor RVA= Token=0x6001124");
}
		}

		[Token(Token = "0x20002B9")]
		private struct LinearProgram2Output
		{
			[Token(Token = "0x4000C69")]
			[FieldOffset(Offset = "0x0")]
			public float2 velocity;

			[Token(Token = "0x4000C6A")]
			[FieldOffset(Offset = "0x0")]
			public int firstFailedLineIndex;
		}

		[Token(Token = "0x4000C5B")]
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public SimulatorBurst.AgentData agentData;

		[Token(Token = "0x4000C5C")]
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public SimulatorBurst.TemporaryAgentData temporaryAgentData;

		[Token(Token = "0x4000C5D")]
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public NavmeshEdges.NavmeshBorderData navmeshEdgeData;

		[Token(Token = "0x4000C5E")]
		[FieldOffset(Offset = "0x0")]
		[WriteOnly]
		public SimulatorBurst.AgentOutputData output;

		[Token(Token = "0x4000C5F")]
		[FieldOffset(Offset = "0x0")]
		public float deltaTime;

		[Token(Token = "0x4000C60")]
		[FieldOffset(Offset = "0x0")]
		public float symmetryBreakingBias;

		[Token(Token = "0x4000C61")]
		[FieldOffset(Offset = "0x0")]
		public float priorityMultiplier;

		[Token(Token = "0x4000C62")]
		[FieldOffset(Offset = "0x0")]
		public bool useNavmeshAsObstacle;

		[Token(Token = "0x4000C63")]
		private const int MaxObstacleCount = 50;

		[Token(Token = "0x4000C64")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ProfilerMarker MarkerConvertObstacles1;

		[Token(Token = "0x4000C65")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ProfilerMarker MarkerConvertObstacles2;

		[Token(Token = "0x1700027C")]
		public bool allowBoundsChecks
		{
			[Token(Token = "0x6001109")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600110A")]
		public void Execute(int startIndex, int batchSize)
		{
		}

		[Token(Token = "0x600110B")]
		private static void InsertionSort<T, U>(UnsafeSpan<T> data, U comparer) where T : unmanaged where U : IComparer<T>
		{
		}

		[Token(Token = "0x600110C")]
		private void GenerateObstacleVOs(int agentIndex, NativeList<int> adjacentObstacleIdsScratch, NativeArray<int2> adjacentObstacleVerticesScratch, NativeArray<float> segmentDistancesScratch, NativeArray<int> sortedVerticesScratch, NativeArray<ORCALine> orcaLines, NativeArray<int> orcaLineToAgent, [NoAlias] ref int numLines, [NoAlias] in MovementPlaneWrapper movementPlane, float2 optimalVelocity)
		{
		}

		[Token(Token = "0x600110D")]
		public void ExecuteORCA(int startIndex, int batchSize)
		{
		}

		[Token(Token = "0x600110E")]
		private float CalculateForwardClearance(NativeSlice<int> neighbours, MovementPlaneWrapper movementPlane, float3 position, float radius, float2 targetDir)
		{
			return default;
		}

		[Token(Token = "0x600110F")]
		private static bool leftOrColinear(float2 vector1, float2 vector2)
		{
			return default;
		}

		[Token(Token = "0x6001110")]
		private static bool left(float2 vector1, float2 vector2)
		{
			return default;
		}

		[Token(Token = "0x6001111")]
		private static bool rightOrColinear(float2 vector1, float2 vector2)
		{
			return default;
		}

		[Token(Token = "0x6001112")]
		private static bool right(float2 vector1, float2 vector2)
		{
			return default;
		}

		[Token(Token = "0x6001113")]
		private static float det(float2 vector1, float2 vector2)
		{
			return default;
		}

		[Token(Token = "0x6001114")]
		private static float2 rot90(float2 v)
		{
			return default;
		}

		[Token(Token = "0x6001115")]
		private static float DistanceInsideVOs(UnsafeSpan<ORCALine> lines, float2 velocity)
		{
			return default;
		}

		[Token(Token = "0x6001116")]
		private static bool BiasDesiredVelocity(UnsafeSpan<ORCALine> lines, ref float2 desiredVelocity, ref float2 targetPointInVelocitySpace, float maxBiasRadians)
		{
			return default;
		}

		[Token(Token = "0x6001117")]
		private static bool ClipLine(ORCALine line, ORCALine clipper, ref float tLeft, ref float tRight)
		{
			return default;
		}

		[Token(Token = "0x6001118")]
		private static bool ClipBoundary(NativeArray<ORCALine> lines, int lineIndex, float radius, out float tLeft, out float tRight)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED JobRVO.ClipBoundary RVA= Token=0x6001118");
}

		[Token(Token = "0x6001119")]
		private static bool LinearProgram1D(NativeArray<ORCALine> lines, int lineIndex, float radius, float2 optimalVelocity, bool directionOpt, ref float2 result)
		{
			return default;
		}

		[Token(Token = "0x600111A")]
		private static LinearProgram2Output LinearProgram2D(NativeArray<ORCALine> lines, int numLines, float radius, float2 optimalVelocity, bool directionOpt)
		{
			return default;
		}

		[Token(Token = "0x600111B")]
		private static float ClosestPointOnSegment(float2 a, float2 dir, float2 p, float t0, float t1)
		{
			return default;
		}

		[Token(Token = "0x600111C")]
		private static float2 ClosestSegmentSegmentPointNonIntersecting(ORCALine a, ORCALine b, float ta1, float ta2, float tb1, float tb2)
		{
			return default;
		}

		[Token(Token = "0x600111D")]
		private static LinearProgram2Output LinearProgram2DCollapsedSegment(NativeArray<ORCALine> lines, int numLines, int startLine, float radius, float2 currentResult, float2 optimalVelocityStart, float2 optimalVelocityDir, float optimalTLeft, float optimalTRight)
		{
			return default;
		}

		[Token(Token = "0x600111E")]
		private static LinearProgram2Output LinearProgram2DSegment(NativeArray<ORCALine> lines, int numLines, float radius, float2 optimalVelocityStart, float2 optimalVelocityDir, float optimalTLeft, float optimalTRight, float optimalT)
		{
			return default;
		}

		[Token(Token = "0x600111F")]
		private static void LinearProgram3D(NativeArray<ORCALine> lines, int numLines, int numFixedLines, int beginLine, float radius, ref float2 result, NativeArray<ORCALine> scratchBuffer)
		{
		}

		[Token(Token = "0x6001120")]
		private static void DrawVO(CommandBuilder draw, float2 circleCenter, float radius, float2 origin, Color color)
		{
		}
	}
}
