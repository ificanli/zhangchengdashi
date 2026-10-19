using System.Collections.Generic;
using Il2CppDummyDll;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x2000157")]
	public static class GridStringPulling
	{
		[Token(Token = "0x2000158")]
		private struct TriangleBounds
		{
			[Token(Token = "0x400070F")]
			[FieldOffset(Offset = "0x0")]
			private int2 d1;

			[Token(Token = "0x4000710")]
			[FieldOffset(Offset = "0x8")]
			private int2 d2;

			[Token(Token = "0x4000711")]
			[FieldOffset(Offset = "0x10")]
			private int2 d3;

			[Token(Token = "0x4000712")]
			[FieldOffset(Offset = "0x18")]
			private long t1;

			[Token(Token = "0x4000713")]
			[FieldOffset(Offset = "0x20")]
			private long t2;

			[Token(Token = "0x4000714")]
			[FieldOffset(Offset = "0x28")]
			private long t3;

			[Token(Token = "0x6000AE8")]
			[Address(RVA = "0x456F754", Offset = "0x456B754", VA = "0x456F754")]
			public TriangleBounds(int2 p1, int2 p2, int2 p3)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED GridStringPulling.TriangleBounds..ctor RVA=0x456F754 Token=0x6000AE8");
}

			[Token(Token = "0x6000AE9")]
			[Address(RVA = "0x456F880", Offset = "0x456B880", VA = "0x456F880")]
			public bool Contains(int2 p)
			{
				return default;
			}
		}

		[Token(Token = "0x2000159")]
		private enum PredicateFailMode
		{
			[Token(Token = "0x4000716")]
			Undefined = 0,
			[Token(Token = "0x4000717")]
			Turn = 1,
			[Token(Token = "0x4000718")]
			LinecastObstacle = 2,
			[Token(Token = "0x4000719")]
			LinecastCost = 3,
			[Token(Token = "0x400071A")]
			ReachedEnd = 4
		}

		[Token(Token = "0x4000706")]
		[FieldOffset(Offset = "0x0")]
		private static int2[] directionToCorners;

		[Token(Token = "0x4000707")]
		private const int FixedPrecisionScale = 1024;

		[Token(Token = "0x4000708")]
		[FieldOffset(Offset = "0x8")]
		private static ProfilerMarker marker1;

		[Token(Token = "0x4000709")]
		[FieldOffset(Offset = "0x10")]
		private static ProfilerMarker marker2;

		[Token(Token = "0x400070A")]
		[FieldOffset(Offset = "0x18")]
		private static ProfilerMarker marker3;

		[Token(Token = "0x400070B")]
		[FieldOffset(Offset = "0x20")]
		private static ProfilerMarker marker4;

		[Token(Token = "0x400070C")]
		[FieldOffset(Offset = "0x28")]
		private static ProfilerMarker marker5;

		[Token(Token = "0x400070D")]
		[FieldOffset(Offset = "0x30")]
		private static ProfilerMarker marker6;

		[Token(Token = "0x400070E")]
		[FieldOffset(Offset = "0x38")]
		private static ProfilerMarker marker7;

		[Token(Token = "0x6000ADC")]
		[Address(RVA = "0x456D268", Offset = "0x4569268", VA = "0x456D268")]
		private static long Cross(int2 lhs, int2 rhs)
		{
			return default;
		}

		[Token(Token = "0x6000ADD")]
		[Address(RVA = "0x456D288", Offset = "0x4569288", VA = "0x456D288")]
		private static long Dot(int2 a, int2 b)
		{
			return default;
		}

		[Token(Token = "0x6000ADE")]
		[Address(RVA = "0x456D29C", Offset = "0x456929C", VA = "0x456D29C")]
		private static bool RightOrColinear(int2 a, int2 b, int2 p)
		{
			return default;
		}

		[Token(Token = "0x6000ADF")]
		[Address(RVA = "0x456D2D4", Offset = "0x45692D4", VA = "0x456D2D4")]
		private static int2 Perpendicular(int2 v)
		{
			return default;
		}

		[Token(Token = "0x6000AE0")]
		[Address(RVA = "0x456D2E8", Offset = "0x45692E8", VA = "0x456D2E8")]
		private static int2 ToFixedPrecision(Vector2 p)
		{
			return default;
		}

		[Token(Token = "0x6000AE1")]
		[Address(RVA = "0x456D344", Offset = "0x4569344", VA = "0x456D344")]
		private static Vector2 FromFixedPrecision(int2 p)
		{
			return default;
		}

		[Token(Token = "0x6000AE2")]
		[Address(RVA = "0x456D368", Offset = "0x4569368", VA = "0x456D368")]
		private static Side Side2D(int2 a, int2 b, int2 p)
		{
			return default;
		}

		[Token(Token = "0x6000AE3")]
		[Address(RVA = "0x456D410", Offset = "0x4569410", VA = "0x456D410")]
		public static float IntersectionLength(int2 nodeCenter, int2 segmentStart, int2 segmentEnd)
		{
			return default;
		}

		[Token(Token = "0x6000AE4")]
		[Address(RVA = "0x456D644", Offset = "0x4569644", VA = "0x456D644")]
		internal static void TestIntersectionLength()
		{
		}

		[Token(Token = "0x6000AE5")]
		[Address(RVA = "0x456D648", Offset = "0x4569648", VA = "0x456D648")]
		private static uint LinecastCost(List<GraphNode> trace, int2 segmentStart, int2 segmentEnd, GridGraph gg, ref TraversalCosts traversalCosts)
		{
			return default;
		}

		[Token(Token = "0x6000AE6")]
		[Address(RVA = "0x456D848", Offset = "0x4569848", VA = "0x456D848")]
		public static List<Vector3> Calculate(List<GraphNode> pathNodes, int nodeStartIndex, int nodeEndIndex, Vector3 startPoint, Vector3 endPoint, ref TraversalCosts traversalCosts, ref TraversalConstraint traversalConstraint, int maxCorners = int.MaxValue)
		{
			return null;
		}
	}
}
