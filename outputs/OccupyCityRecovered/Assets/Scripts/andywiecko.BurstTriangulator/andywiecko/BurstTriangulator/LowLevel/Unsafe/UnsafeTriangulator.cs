using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Unity.Collections;
using Unity.Mathematics;
using Unity.Profiling;

namespace andywiecko.BurstTriangulator.LowLevel.Unsafe
{
	[Token(Token = "0x2000018")]
	public readonly struct UnsafeTriangulator
	{
	}
	[Token(Token = "0x2000019")]
	public readonly struct UnsafeTriangulator<T2> where T2 : unmanaged
	{
	}
	[Token(Token = "0x200001C")]
	internal readonly struct UnsafeTriangulator<T, T2, TBig, TTransform, TUtils> where T : unmanaged, IComparable<T> where T2 : unmanaged where TBig : unmanaged, IComparable<TBig> where TTransform : unmanaged, ITransform<TTransform, T, T2> where TUtils : unmanaged, IUtils<T, T2, TBig>
	{
		[Token(Token = "0x200001D")]
		private readonly struct Markers
		{
			[Token(Token = "0x4000067")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly ProfilerMarker PreProcessInputStep;

			[Token(Token = "0x4000068")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly ProfilerMarker PostProcessInputStep;

			[Token(Token = "0x4000069")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly ProfilerMarker ValidateInputStep;

			[Token(Token = "0x400006A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly ProfilerMarker DelaunayTriangulationStep;

			[Token(Token = "0x400006B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly ProfilerMarker ConstrainEdgesStep;

			[Token(Token = "0x400006C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly ProfilerMarker PlantingSeedStep;

			[Token(Token = "0x400006D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly ProfilerMarker RefineMeshStep;
		}

		[Token(Token = "0x200001E")]
		private struct ValidateInputStep
		{
			[Token(Token = "0x400006E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private NativeArray<T2>.ReadOnly positions;

			[Token(Token = "0x400006F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private NativeReference<Status> status;

			[Token(Token = "0x4000070")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly Args args;

			[Token(Token = "0x4000071")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private NativeArray<int>.ReadOnly constraints;

			[Token(Token = "0x4000072")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private NativeArray<ConstraintType>.ReadOnly constraintTypes;

			[Token(Token = "0x4000073")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private NativeArray<T2>.ReadOnly holes;

			[Token(Token = "0x6000092")]
			public ValidateInputStep(InputData<T2> input, OutputData<T2> output, Args args)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED UnsafeTriangulator.ValidateInputStep..ctor RVA= Token=0x6000092");
}

			[Token(Token = "0x6000093")]
			public void Execute()
			{
			}

			[Token(Token = "0x6000094")]
			private void ValidateArgs()
			{
			}

			[Token(Token = "0x6000095")]
			private void ValidatePositions()
			{
			}

			[Token(Token = "0x6000096")]
			private void ValidateConstraints()
			{
			}

			[Token(Token = "0x6000097")]
			private void ValidateHoles()
			{
			}
		}

		[Token(Token = "0x200001F")]
		private struct DelaunayTriangulationStep
		{
			[Token(Token = "0x2000020")]
			private struct DistComparer : IComparer<int>
			{
				[Token(Token = "0x4000082")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private NativeArray<TBig> dist;

				[Token(Token = "0x600009D")]
				public DistComparer(NativeArray<TBig> dist)
				{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED UnsafeTriangulator.DelaunayTriangulationStep.DistComparer..ctor RVA= Token=0x600009D");
}

				[Token(Token = "0x600009E")]
				public int Compare(int x, int y)
				{
					return default;
				}
			}

			[Token(Token = "0x4000074")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private NativeReference<Status> status;

			[Token(Token = "0x4000075")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private NativeArray<T2>.ReadOnly positions;

			[Token(Token = "0x4000076")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private NativeList<int> triangles;

			[Token(Token = "0x4000077")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private NativeList<int> halfedges;

			[Token(Token = "0x4000078")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private NativeList<HalfedgeState> constrainedHalfedges;

			[Token(Token = "0x4000079")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private NativeArray<int> hullNext;

			[Token(Token = "0x400007A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private NativeArray<int> hullPrev;

			[Token(Token = "0x400007B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private NativeArray<int> hullTri;

			[Token(Token = "0x400007C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private NativeArray<int> hullHash;

			[Token(Token = "0x400007D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private NativeArray<int> EDGE_STACK;

			[Token(Token = "0x400007E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly int hashSize;

			[Token(Token = "0x400007F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly bool verbose;

			[Token(Token = "0x4000080")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int hullStart;

			[Token(Token = "0x4000081")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int trianglesLen;

			[Token(Token = "0x6000098")]
			public DelaunayTriangulationStep(OutputData<T2> output, Args args)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED UnsafeTriangulator.DelaunayTriangulationStep..ctor RVA= Token=0x6000098");
}

			[Token(Token = "0x6000099")]
			public void Execute(Allocator allocator)
			{
			}

			[Token(Token = "0x600009A")]
			private int Legalize(int a)
			{
				return default;
			}

			[Token(Token = "0x600009B")]
			private int AddTriangle(int i0, int i1, int i2, int a, int b, int c)
			{
				return default;
			}

			[Token(Token = "0x600009C")]
			private void Link(int a, int b)
			{
			}
		}

		[Token(Token = "0x2000021")]
		private struct ConstrainEdgesStep
		{
			[Token(Token = "0x4000083")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private NativeReference<Status> status;

			[Token(Token = "0x4000084")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private NativeArray<T2>.ReadOnly positions;

			[Token(Token = "0x4000085")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private NativeArray<int> triangles;

			[Token(Token = "0x4000086")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private NativeArray<int>.ReadOnly inputConstraintEdges;

			[Token(Token = "0x4000087")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private NativeArray<ConstraintType>.ReadOnly inputConstraintEdgeTypes;

			[Token(Token = "0x4000088")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private NativeList<int> halfedges;

			[Token(Token = "0x4000089")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private NativeList<HalfedgeState> constrainedHalfedges;

			[Token(Token = "0x400008A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly Args args;

			[Token(Token = "0x400008B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private NativeList<int> intersections;

			[Token(Token = "0x400008C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private NativeList<int> unresolvedIntersections;

			[Token(Token = "0x400008D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private NativeArray<int> pointToHalfedge;

			[Token(Token = "0x600009F")]
			public ConstrainEdgesStep(InputData<T2> input, OutputData<T2> output, Args args)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED UnsafeTriangulator.ConstrainEdgesStep..ctor RVA= Token=0x600009F");
}

			[Token(Token = "0x60000A0")]
			public void Execute(Allocator allocator)
			{
			}

			[Token(Token = "0x60000A1")]
			private void TryResolveIntersections(int2 c, HalfedgeState constrainValue, ref int iter)
			{
			}

			[Token(Token = "0x60000A2")]
			private void ReplaceHalfedge(int h0, int h1)
			{
			}

			[Token(Token = "0x60000A3")]
			private bool EdgeEdgeIntersection(int2 e1, int2 e2)
			{
				return default;
			}

			[Token(Token = "0x60000A4")]
			private void MarkHalfedgeConstrained(int halfedge, HalfedgeState constrainValue)
			{
			}

			[Token(Token = "0x60000A5")]
			private void TryApplyConstraint(int2 edge, HalfedgeState constrainValue)
			{
			}

			[Token(Token = "0x60000A6")]
			private bool IsMaxItersExceeded(int iter, int maxIters)
			{
				return default;
			}
		}

		[Token(Token = "0x2000022")]
		private struct PlantingSeedStep
		{
			[Token(Token = "0x400008E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private NativeReference<Status> status;

			[Token(Token = "0x400008F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private NativeList<int> triangles;

			[Token(Token = "0x4000090")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[ReadOnly]
			private NativeList<T2> positions;

			[Token(Token = "0x4000091")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private NativeList<HalfedgeState> constrainedHalfedges;

			[Token(Token = "0x4000092")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private NativeList<int> halfedges;

			[Token(Token = "0x4000093")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private NativeArray<bool> shouldRemoveTriangle;

			[Token(Token = "0x4000094")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private NativeQueue<int> trianglesQueue;

			[Token(Token = "0x4000095")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private NativeArray<T2> holes;

			[Token(Token = "0x4000096")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private bool anyRemovedTriangles;

			[Token(Token = "0x4000097")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly Args args;

			[Token(Token = "0x60000A7")]
			public PlantingSeedStep(InputData<T2> input, OutputData<T2> output, Args args)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED UnsafeTriangulator.PlantingSeedStep..ctor RVA= Token=0x60000A7");
}

			[Token(Token = "0x60000A8")]
			public PlantingSeedStep(OutputData<T2> output, Args args, NativeArray<T2> localHoles)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED UnsafeTriangulator.PlantingSeedStep..ctor RVA= Token=0x60000A8");
}

			[Token(Token = "0x60000A9")]
			public void Execute(Allocator allocator, bool constraintsIsCreated)
			{
			}

			[Token(Token = "0x60000AA")]
			private void PlantBoundarySeeds()
			{
			}

			[Token(Token = "0x60000AB")]
			private void PlantHoleSeeds(NativeArray<T2> holeSeeds)
			{
			}

			[Token(Token = "0x60000AC")]
			private void RemoveVisitedTriangles(Allocator allocator)
			{
			}

			[Token(Token = "0x60000AD")]
			private void PlantSeed(int tId)
			{
			}

			[Token(Token = "0x60000AE")]
			private int FindTriangle(T2 p)
			{
				return default;
			}

			[Token(Token = "0x60000AF")]
			private void PlantAuto(Allocator allocator)
			{
			}
		}

		[Token(Token = "0x2000024")]
		private struct RefineMeshStep
		{
			[Token(Token = "0x2000025")]
			private readonly struct Circle
			{
				[Token(Token = "0x40000A8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public readonly T2 Center;

				[Token(Token = "0x40000A9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public readonly T RadiusSq;

				[Token(Token = "0x60000C5")]
				public Circle((T2 center, T radiusSq) circle)
				{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED UnsafeTriangulator.RefineMeshStep.Circle..ctor RVA= Token=0x60000C5");
}
			}

			[Token(Token = "0x4000099")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private NativeReference<Status> status;

			[Token(Token = "0x400009A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private NativeList<int> triangles;

			[Token(Token = "0x400009B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private NativeList<T2> outputPositions;

			[Token(Token = "0x400009C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private NativeList<int> halfedges;

			[Token(Token = "0x400009D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private NativeList<HalfedgeState> constrainedHalfedges;

			[Token(Token = "0x400009E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private NativeList<Circle> circles;

			[Token(Token = "0x400009F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private NativeQueue<int> trianglesQueue;

			[Token(Token = "0x40000A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private NativeList<int> badTriangles;

			[Token(Token = "0x40000A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private NativeList<int> pathPoints;

			[Token(Token = "0x40000A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private NativeList<int> pathHalfedges;

			[Token(Token = "0x40000A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private NativeList<bool> visitedTriangles;

			[Token(Token = "0x40000A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly T maximumArea2;

			[Token(Token = "0x40000A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly T angleThreshold;

			[Token(Token = "0x40000A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly int initialPointsCount;

			[Token(Token = "0x40000A7")]
			private const float ConcentricShellReferenceRadius = 0.001f;

			[Token(Token = "0x60000B1")]
			public RefineMeshStep(OutputData<T2> output, Args args, TTransform lt)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED UnsafeTriangulator.RefineMeshStep..ctor RVA= Token=0x60000B1");
}

			[Token(Token = "0x60000B2")]
			public RefineMeshStep(OutputData<T2> output, T area2Threshold, T angleThreshold)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED UnsafeTriangulator.RefineMeshStep..ctor RVA= Token=0x60000B2");
}

			[Token(Token = "0x60000B3")]
			public void Execute(Allocator allocator, bool refineMesh, bool constrainBoundary)
			{
			}

			[Token(Token = "0x60000B4")]
			private void SplitEncroachedEdges(NativeList<int> heQueue, NativeList<int> tQueue)
			{
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x60000B5")]
			private bool IsEncroached(int he0)
			{
				return default;
			}

			[Token(Token = "0x60000B6")]
			private void SplitEdge(int he, NativeList<int> heQueue, NativeList<int> tQueue)
			{
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x60000B7")]
			private bool IsBadTriangle(int tId)
			{
				return default;
			}

			[Token(Token = "0x60000B8")]
			private void SplitTriangle(int tId, NativeList<int> heQueue, NativeList<int> tQueue, Allocator allocator)
			{
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x60000B9")]
			private bool AngleIsTooSmall(int tId, T minimumAngle)
			{
				return default;
			}

			[Token(Token = "0x60000BA")]
			private int UnsafeInsertPointCommon(T2 p, int initTriangle)
			{
				return default;
			}

			[Token(Token = "0x60000BB")]
			private void UnsafeInsertPointBulk(T2 p, int initTriangle, [Optional] NativeList<int> heQueue, [Optional] NativeList<int> tQueue)
			{
			}

			[Token(Token = "0x60000BC")]
			private void UnsafeInsertPointBoundary(T2 p, int initHe, [Optional] NativeList<int> heQueue, [Optional] NativeList<int> tQueue)
			{
			}

			[Token(Token = "0x60000BD")]
			private void RecalculateBadTriangles(T2 p)
			{
			}

			[Token(Token = "0x60000BE")]
			private void VisitEdge(T2 p, int t0)
			{
			}

			[Token(Token = "0x60000BF")]
			private void BuildAmphitheaterPolygon(int initHe)
			{
			}

			[Token(Token = "0x60000C0")]
			private void BuildStarPolygon()
			{
			}

			[Token(Token = "0x60000C1")]
			private void ProcessBadTriangles(NativeList<int> heQueue, NativeList<int> tQueue)
			{
			}

			[Token(Token = "0x60000C2")]
			private void RemoveHalfedge(int he, int offset)
			{
			}

			[Token(Token = "0x60000C3")]
			private void BuildNewTrianglesForStar(int pId, NativeList<int> heQueue, NativeList<int> tQueue)
			{
			}

			[Token(Token = "0x60000C4")]
			private void BuildNewTrianglesForAmphitheater(int pId, NativeList<int> heQueue, NativeList<int> tQueue)
			{
			}
		}

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly TUtils utils;

		[Token(Token = "0x6000080")]
		public void Triangulate(InputData<T2> input, OutputData<T2> output, Args args, Allocator allocator)
		{
		}

		[Token(Token = "0x6000081")]
		public void PlantHoleSeeds(InputData<T2> input, OutputData<T2> output, Args args, Allocator allocator)
		{
		}

		[Token(Token = "0x6000082")]
		public void RefineMesh(OutputData<T2> output, Allocator allocator, T area2Threshold, T angleThreshold, bool constrainBoundary = false)
		{
		}

		[Token(Token = "0x6000083")]
		private void PreProcessInputStep(InputData<T2> input, OutputData<T2> output, Args args, out NativeArray<T2> localHoles, out TTransform lt, Allocator allocator)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED UnsafeTriangulator.PreProcessInputStep RVA= Token=0x6000083");
}

		[Token(Token = "0x6000084")]
		private void PostProcessInputStep(OutputData<T2> output, Args args, TTransform lt)
		{
		}

		[Token(Token = "0x6000085")]
		internal static bool AngleIsTooSmall(T2 pA, T2 pB, T2 pC, T minimumAngle)
		{
			return default;
		}

		[Token(Token = "0x6000086")]
		internal static T Area2(T2 a, T2 b, T2 c)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED UnsafeTriangulator.Area2 RVA= Token=0x6000086");
}

		[Token(Token = "0x6000087")]
		private static T Cross(T2 a, T2 b)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED UnsafeTriangulator.Cross RVA= Token=0x6000087");
}

		[Token(Token = "0x6000088")]
		private static TBig CircumRadiusSq(T2 a, T2 b, T2 c)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED UnsafeTriangulator.CircumRadiusSq RVA= Token=0x6000088");
}

		[Token(Token = "0x6000089")]
		private static (T2, T) CalculateCircumCircle(int i, int j, int k, NativeArray<T2> positions)
		{
			return default;
		}

		[Token(Token = "0x600008A")]
		private static bool ccw(T2 a, T2 b, T2 c)
		{
			return default;
		}

		[Token(Token = "0x600008B")]
		internal static bool EdgeEdgeIntersection(T2 a0, T2 a1, T2 b0, T2 b1)
		{
			return default;
		}

		[Token(Token = "0x600008C")]
		private static int NextHalfedge(int he)
		{
			return default;
		}

		[Token(Token = "0x600008D")]
		internal static bool IsConvexQuadrilateral(T2 a, T2 b, T2 c, T2 d)
		{
			return default;
		}

		[Token(Token = "0x600008E")]
		private static TBig Orient2dFast(T2 a, T2 b, T2 c)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED UnsafeTriangulator.Orient2dFast RVA= Token=0x600008E");
}

		[Token(Token = "0x600008F")]
		internal static bool PointLineSegmentIntersection(T2 a, T2 b0, T2 b1)
		{
			return default;
		}
	}
}
