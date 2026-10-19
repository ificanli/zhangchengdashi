using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Pathfinding.Drawing;
using Pathfinding.Util;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Mathematics;
using Unity.Profiling;

namespace Pathfinding.Collections
{
	[Token(Token = "0x200027A")]
	[BurstCompile]
	public struct BBTree : IDisposable
	{
		[Token(Token = "0x200027B")]
		[BurstCompile]
		public readonly struct ProjectionParams
		{
			[Token(Token = "0x200027C")]
			public delegate float SquaredRectPointDistanceOnPlane_00000EC7_0024PostfixBurstDelegate(in ProjectionParams projection, ref IntRect rect, ref float3 p);

			[Token(Token = "0x200027D")]
			internal static class SquaredRectPointDistanceOnPlane_00000EC7_0024BurstDirectCall
			{
				[Token(Token = "0x4000B8F")]
				[FieldOffset(Offset = "0x0")]
				private static IntPtr Pointer;

				[Token(Token = "0x4000B90")]
				[FieldOffset(Offset = "0x8")]
				private static IntPtr DeferredCompilation;

				[Token(Token = "0x6000FEE")]
				[Address(RVA = "0x448EF3C", Offset = "0x448AF3C", VA = "0x448EF3C")]
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr P_0)
				{
				}

				[Token(Token = "0x6000FEF")]
				[Address(RVA = "0x448F058", Offset = "0x448B058", VA = "0x448F058")]
				private static IntPtr GetFunctionPointer()
				{
					return default;
				}

				[Token(Token = "0x6000FF0")]
				[Address(RVA = "0x448F0B4", Offset = "0x448B0B4", VA = "0x448F0B4")]
				public static void Constructor()
				{
				}

				[Token(Token = "0x6000FF1")]
				[Address(RVA = "0x448F15C", Offset = "0x448B15C", VA = "0x448F15C")]
				public static void Initialize()
				{
				}

				[Token(Token = "0x6000FF3")]
				[Address(RVA = "0x448E5A4", Offset = "0x448A5A4", VA = "0x448E5A4")]
				public static float Invoke(in ProjectionParams projection, ref IntRect rect, ref float3 p)
				{
					return default;
				}
			}

			[Token(Token = "0x4000B89")]
			[FieldOffset(Offset = "0x0")]
			public readonly float2x3 planeProjection;

			[Token(Token = "0x4000B8A")]
			[FieldOffset(Offset = "0x18")]
			public readonly float2 projectedUpNormalized;

			[Token(Token = "0x4000B8B")]
			[FieldOffset(Offset = "0x20")]
			public readonly float3 projectionAxis;

			[Token(Token = "0x4000B8C")]
			[FieldOffset(Offset = "0x2C")]
			public readonly float distanceScaleAlongProjectionAxis;

			[Token(Token = "0x4000B8D")]
			[FieldOffset(Offset = "0x30")]
			public readonly DistanceMetric distanceMetricType;

			[Token(Token = "0x4000B8E")]
			[FieldOffset(Offset = "0x31")]
			private readonly byte alignedWithXZPlaneBacking;

			[Token(Token = "0x1700025B")]
			public bool alignedWithXZPlane
			{
				[Token(Token = "0x6000FE5")]
				[Address(RVA = "0x448E528", Offset = "0x448A528", VA = "0x448E528")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x6000FE6")]
			[Address(RVA = "0x448D874", Offset = "0x4489874", VA = "0x448D874")]
			public float SquaredRectPointDistanceOnPlane(IntRect rect, float3 p)
			{
				return default;
			}

			[Token(Token = "0x6000FE7")]
			[Address(RVA = "0x448E538", Offset = "0x448A538", VA = "0x448E538")]
			[IgnoredByDeepProfiler]
			[BurstCompile(FloatMode = FloatMode.Fast)]
			private static float SquaredRectPointDistanceOnPlane(in ProjectionParams projection, ref IntRect rect, ref float3 p)
			{
				return default;
			}

			[Token(Token = "0x6000FE8")]
			[Address(RVA = "0x448E66C", Offset = "0x448A66C", VA = "0x448E66C")]
			public ProjectionParams(ref Pathfinding.DistanceMetric distanceMetric, GraphTransform graphTransform)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED BBTree.ProjectionParams..ctor RVA=0x448E66C Token=0x6000FE8");
}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x6000FE9")]
			[Address(RVA = "0x448EBA8", Offset = "0x448ABA8", VA = "0x448EBA8")]
			[IgnoredByDeepProfiler]
			[BurstCompile(FloatMode = FloatMode.Fast)]
			public static float SquaredRectPointDistanceOnPlane_0024BurstManaged(in ProjectionParams projection, ref IntRect rect, ref float3 p)
			{
				return default;
			}
		}

		[Token(Token = "0x200027E")]
		private struct CloseNode
		{
			[Token(Token = "0x4000B91")]
			[FieldOffset(Offset = "0x0")]
			public int node;

			[Token(Token = "0x4000B92")]
			[FieldOffset(Offset = "0x4")]
			public float distanceSq;

			[Token(Token = "0x4000B93")]
			[FieldOffset(Offset = "0x8")]
			public float tieBreakingDistance;

			[Token(Token = "0x4000B94")]
			[FieldOffset(Offset = "0xC")]
			public float3 closestPointOnNode;
		}

		[Token(Token = "0x200027F")]
		public enum DistanceMetric : byte
		{
			[Token(Token = "0x4000B96")]
			Euclidean = 0,
			[Token(Token = "0x4000B97")]
			ScaledManhattan = 1
		}

		[Token(Token = "0x2000280")]
		[BurstCompile]
		private struct NearbyNodesIterator : IEnumerator<CloseNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x2000281")]
			public struct BoxWithDist
			{
				[Token(Token = "0x4000BA4")]
				[FieldOffset(Offset = "0x0")]
				public int index;

				[Token(Token = "0x4000BA5")]
				[FieldOffset(Offset = "0x4")]
				public float distSqr;
			}

			[Token(Token = "0x2000282")]
			public delegate bool MoveNext_00000ECE_0024PostfixBurstDelegate(ref NearbyNodesIterator it);

			[Token(Token = "0x2000283")]
			internal static class MoveNext_00000ECE_0024BurstDirectCall
			{
				[Token(Token = "0x4000BA6")]
				[FieldOffset(Offset = "0x0")]
				private static IntPtr Pointer;

				[Token(Token = "0x4000BA7")]
				[FieldOffset(Offset = "0x8")]
				private static IntPtr DeferredCompilation;

				[Token(Token = "0x6000FFF")]
				[Address(RVA = "0x448FBF8", Offset = "0x448BBF8", VA = "0x448FBF8")]
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr P_0)
				{
				}

				[Token(Token = "0x6001000")]
				[Address(RVA = "0x448FD14", Offset = "0x448BD14", VA = "0x448FD14")]
				private static IntPtr GetFunctionPointer()
				{
					return default;
				}

				[Token(Token = "0x6001001")]
				[Address(RVA = "0x448FD70", Offset = "0x448BD70", VA = "0x448FD70")]
				public static void Constructor()
				{
				}

				[Token(Token = "0x6001002")]
				[Address(RVA = "0x448E524", Offset = "0x448A524", VA = "0x448E524")]
				public static void Initialize()
				{
				}

				[Token(Token = "0x6001004")]
				[Address(RVA = "0x448F240", Offset = "0x448B240", VA = "0x448F240")]
				public static bool Invoke(ref NearbyNodesIterator it)
				{
					return default;
				}
			}

			[Token(Token = "0x4000B98")]
			[FieldOffset(Offset = "0x0")]
			public UnsafeSpan<BoxWithDist> stack;

			[Token(Token = "0x4000B99")]
			[FieldOffset(Offset = "0x10")]
			public int stackSize;

			[Token(Token = "0x4000B9A")]
			[FieldOffset(Offset = "0x18")]
			public UnsafeSpan<BBTreeBox> tree;

			[Token(Token = "0x4000B9B")]
			[FieldOffset(Offset = "0x28")]
			public UnsafeSpan<int> nodes;

			[Token(Token = "0x4000B9C")]
			[FieldOffset(Offset = "0x38")]
			public UnsafeSpan<int> triangles;

			[Token(Token = "0x4000B9D")]
			[FieldOffset(Offset = "0x48")]
			public UnsafeSpan<Int3> vertices;

			[Token(Token = "0x4000B9E")]
			[FieldOffset(Offset = "0x58")]
			public int indexInLeaf;

			[Token(Token = "0x4000B9F")]
			[FieldOffset(Offset = "0x5C")]
			public float3 point;

			[Token(Token = "0x4000BA0")]
			[FieldOffset(Offset = "0x68")]
			public ProjectionParams projection;

			[Token(Token = "0x4000BA1")]
			[FieldOffset(Offset = "0x9C")]
			public float distanceThresholdSqr;

			[Token(Token = "0x4000BA2")]
			[FieldOffset(Offset = "0xA0")]
			public float tieBreakingDistanceThreshold;

			[Token(Token = "0x4000BA3")]
			[FieldOffset(Offset = "0xA4")]
			internal CloseNode current;

			[Token(Token = "0x1700025C")]
			public CloseNode Current
			{
				[Token(Token = "0x6000FF4")]
				[Address(RVA = "0x448F164", Offset = "0x448B164", VA = "0x448F164", Slot = "4")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x1700025D")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000FF8")]
				[Address(RVA = "0x448F208", Offset = "0x448B208", VA = "0x448F208", Slot = "7")]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000FF5")]
			[Address(RVA = "0x448DD78", Offset = "0x4489D78", VA = "0x448DD78", Slot = "6")]
			public bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000FF6")]
			[Address(RVA = "0x448F1CC", Offset = "0x448B1CC", VA = "0x448F1CC", Slot = "5")]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000FF7")]
			[Address(RVA = "0x448F1D0", Offset = "0x448B1D0", VA = "0x448F1D0", Slot = "8")]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000FF8")]
			[Address(RVA = "0x448F208", Offset = "0x448B208", VA = "0x448F208", Slot = "7")]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000FF9")]
			[Address(RVA = "0x448F178", Offset = "0x448B178", VA = "0x448F178")]
			[BurstCompile(FloatMode = FloatMode.Default)]
private static bool MoveNext(ref NearbyNodesIterator it)
			{
				return default;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x6000FFA")]
			[Address(RVA = "0x448F2E4", Offset = "0x448B2E4", VA = "0x448F2E4")]
			[BurstCompile(FloatMode = FloatMode.Default)]
			public static bool MoveNext_0024BurstManaged(ref NearbyNodesIterator it)
			{
				return default;
			}
		}

		[Token(Token = "0x2000284")]
		private struct BBTreeBox
		{
			[Token(Token = "0x4000BA8")]
			[FieldOffset(Offset = "0x0")]
			public IntRect rect;

			[Token(Token = "0x4000BA9")]
			[FieldOffset(Offset = "0x10")]
			public int nodeOffset;

			[Token(Token = "0x4000BAA")]
			[FieldOffset(Offset = "0x14")]
			public int left;

			[Token(Token = "0x4000BAB")]
			[FieldOffset(Offset = "0x18")]
			public int right;

			[Token(Token = "0x1700025E")]
			public bool IsLeaf
			{
				[Token(Token = "0x6001005")]
				[Address(RVA = "0x448E008", Offset = "0x448A008", VA = "0x448E008")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x6001006")]
			[Address(RVA = "0x448D7B8", Offset = "0x44897B8", VA = "0x448D7B8")]
			public BBTreeBox(IntRect rect)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED BBTree.BBTreeBox..ctor RVA=0x448D7B8 Token=0x6001006");
}
		}

		[Token(Token = "0x2000285")]
		public delegate void Build_00000EBC_0024PostfixBurstDelegate(ref UnsafeSpan<int> triangles, ref UnsafeSpan<Int3> vertices, out BBTree bbTree);

		[Token(Token = "0x2000286")]
		internal static class Build_00000EBC_0024BurstDirectCall
		{
			[Token(Token = "0x4000BAC")]
			[FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			[Token(Token = "0x4000BAD")]
			[FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;

			[Token(Token = "0x600100B")]
			[Address(RVA = "0x448FFD0", Offset = "0x448BFD0", VA = "0x448FFD0")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
			}

			[Token(Token = "0x600100C")]
			[Address(RVA = "0x44900EC", Offset = "0x448C0EC", VA = "0x44900EC")]
			private static IntPtr GetFunctionPointer()
			{
				return default;
			}

			[Token(Token = "0x600100D")]
			[Address(RVA = "0x4490148", Offset = "0x448C148", VA = "0x4490148")]
			public static void Constructor()
			{
			}

			[Token(Token = "0x600100E")]
			[Address(RVA = "0x44901F0", Offset = "0x448C1F0", VA = "0x44901F0")]
			public static void Initialize()
			{
			}

			[Token(Token = "0x6001010")]
			[Address(RVA = "0x448CF80", Offset = "0x4488F80", VA = "0x448CF80")]
			public static void Invoke(ref UnsafeSpan<int> triangles, ref UnsafeSpan<Int3> vertices, out BBTree bbTree)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED BBTree.Build_00000EBC_0024BurstDirectCall.Invoke RVA=0x448CF80 Token=0x6001010");
}
		}

		[Token(Token = "0x4000B85")]
		[FieldOffset(Offset = "0x0")]
		private UnsafeList<BBTreeBox> tree;

		[Token(Token = "0x4000B86")]
		[FieldOffset(Offset = "0x18")]
		private UnsafeList<int> nodePermutation;

		[Token(Token = "0x4000B87")]
		private const int MaximumLeafSize = 4;

		[Token(Token = "0x4000B88")]
		private const int MAX_TREE_HEIGHT = 26;

		[Token(Token = "0x1700025A")]
		public IntRect Size
		{
			[Token(Token = "0x6000FD7")]
			[Address(RVA = "0x448CD80", Offset = "0x4488D80", VA = "0x448CD80")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000FD8")]
		[Address(RVA = "0x448CDE0", Offset = "0x4488DE0", VA = "0x448CDE0", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000FD9")]
		[Address(RVA = "0x448CE50", Offset = "0x4488E50", VA = "0x448CE50")]
		public BBTree(UnsafeSpan<int> triangles, UnsafeSpan<Int3> vertices)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED BBTree..ctor RVA=0x448CE50 Token=0x6000FD9");
}

		[Token(Token = "0x6000FDA")]
		[Address(RVA = "0x448CF14", Offset = "0x4488F14", VA = "0x448CF14")]
		[BurstCompile]
		private static void Build(ref UnsafeSpan<int> triangles, ref UnsafeSpan<Int3> vertices, out BBTree bbTree)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED BBTree.Build RVA=0x448CF14 Token=0x6000FDA");
}

		[Token(Token = "0x6000FDB")]
		[Address(RVA = "0x448D048", Offset = "0x4489048", VA = "0x448D048")]
		private static int SplitByX(NativeArray<IntRect> nodesBounds, NativeArray<int> permutation, int from, int to, int divider)
		{
			return default;
		}

		[Token(Token = "0x6000FDC")]
		[Address(RVA = "0x448D09C", Offset = "0x448909C", VA = "0x448D09C")]
		private static int SplitByZ(NativeArray<IntRect> nodesBounds, NativeArray<int> permutation, int from, int to, int divider)
		{
			return default;
		}

		[Token(Token = "0x6000FDD")]
		[Address(RVA = "0x448D0F0", Offset = "0x44890F0", VA = "0x448D0F0")]
		private static int BuildSubtree(NativeArray<int> permutation, NativeArray<IntRect> nodeBounds, ref UnsafeList<int> nodes, ref UnsafeList<BBTreeBox> tree, int from, int to, bool odd, int depth)
		{
			return default;
		}

		[Token(Token = "0x6000FDE")]
		[Address(RVA = "0x448D6B8", Offset = "0x44896B8", VA = "0x448D6B8")]
		private static IntRect NodeBounds(NativeArray<int> permutation, NativeArray<IntRect> nodeBounds, int from, int to)
		{
			return default;
		}

		[Token(Token = "0x6000FDF")]
		[Address(RVA = "0x448D7D0", Offset = "0x44897D0", VA = "0x448D7D0")]
		public float DistanceSqrLowerBound(float3 p, in ProjectionParams projection)
		{
			return default;
		}

		[Token(Token = "0x6000FE0")]
		[Address(RVA = "0x448D8A0", Offset = "0x44898A0", VA = "0x448D8A0")]
		public void QueryClosest(float3 p, ref NearestNodeConstraint constraint, in ProjectionParams projection, ref float distanceSqr, ref NNInfo previous, GraphNode[] nodes, UnsafeSpan<int> triangles, UnsafeSpan<Int3> vertices)
		{
		}

		[Token(Token = "0x6000FE1")]
		[Address(RVA = "0x448DD7C", Offset = "0x4489D7C", VA = "0x448DD7C")]
		public void DrawGizmos(CommandBuilder draw)
		{
		}

		[Token(Token = "0x6000FE2")]
		[Address(RVA = "0x448DDF4", Offset = "0x4489DF4", VA = "0x448DDF4")]
		private void DrawGizmos(ref CommandBuilder draw, int boxi, int depth)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000FE3")]
		[Address(RVA = "0x448E018", Offset = "0x448A018", VA = "0x448E018")]
		[BurstCompile]
		public static void Build_0024BurstManaged(ref UnsafeSpan<int> triangles, ref UnsafeSpan<Int3> vertices, out BBTree bbTree)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED BBTree.Build_0024BurstManaged RVA=0x448E018 Token=0x6000FE3");
}

		[Token(Token = "0x6000FE4")]
		[Address(RVA = "0x448E4D0", Offset = "0x448A4D0", VA = "0x448E4D0")]
		public static void Initialize_0024NearbyNodesIterator_MoveNext_00000ECE_0024BurstDirectCall()
		{
		}
	}
}
