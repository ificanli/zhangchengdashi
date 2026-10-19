using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Pathfinding.Collections;
using Unity.Burst;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x200014B")]
	[BurstCompile]
	public static class Funnel
	{
		[Token(Token = "0x200014C")]
		public struct FunnelPortals
		{
			[Token(Token = "0x40006F2")]
			[FieldOffset(Offset = "0x0")]
			public List<Vector3> left;

			[Token(Token = "0x40006F3")]
			[FieldOffset(Offset = "0x8")]
			public List<Vector3> right;
		}

		[Token(Token = "0x200014D")]
		public enum PartType
		{
			[Token(Token = "0x40006F5")]
			OffMeshLink = 0,
			[Token(Token = "0x40006F6")]
			NodeSequence = 1
		}

		[Token(Token = "0x200014E")]
		public struct PathPart
		{
			[Token(Token = "0x40006F7")]
			[FieldOffset(Offset = "0x0")]
			public int startIndex;

			[Token(Token = "0x40006F8")]
			[FieldOffset(Offset = "0x4")]
			public int endIndex;

			[Token(Token = "0x40006F9")]
			[FieldOffset(Offset = "0x8")]
			public Vector3 startPoint;

			[Token(Token = "0x40006FA")]
			[FieldOffset(Offset = "0x14")]
			public Vector3 endPoint;

			[Token(Token = "0x40006FB")]
			[FieldOffset(Offset = "0x20")]
			public PartType type;
		}

		[Token(Token = "0x200014F")]
		[BurstCompile]
		public struct FunnelState
		{
			[Token(Token = "0x2000150")]
			public delegate void PushStart_00000A34_0024PostfixBurstDelegate(ref NativeCircularBuffer<float3> leftPortals, ref NativeCircularBuffer<float3> rightPortals, ref NativeCircularBuffer<float4> unwrappedPortals, ref float3 newLeftPortal, ref float3 newRightPortal, ref float3 projectionAxis);

			[Token(Token = "0x2000151")]
			internal static class PushStart_00000A34_0024BurstDirectCall
			{
				[Token(Token = "0x4000700")]
				[FieldOffset(Offset = "0x0")]
				private static IntPtr Pointer;

				[Token(Token = "0x4000701")]
				[FieldOffset(Offset = "0x8")]
				private static IntPtr DeferredCompilation;

				[Token(Token = "0x6000AC0")]
				[Address(RVA = "0x456C194", Offset = "0x4568194", VA = "0x456C194")]
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr P_0)
				{
				}

				[Token(Token = "0x6000AC1")]
				[Address(RVA = "0x456C2B0", Offset = "0x45682B0", VA = "0x456C2B0")]
				private static IntPtr GetFunctionPointer()
				{
					return default;
				}

				[Token(Token = "0x6000AC2")]
				[Address(RVA = "0x456C30C", Offset = "0x456830C", VA = "0x456C30C")]
				public static void Constructor()
				{
				}

				[Token(Token = "0x6000AC3")]
				[Address(RVA = "0x456C3B4", Offset = "0x45683B4", VA = "0x456C3B4")]
				public static void Initialize()
				{
				}

				[Token(Token = "0x6000AC5")]
				[Address(RVA = "0x456A718", Offset = "0x4566718", VA = "0x456A718")]
				public static void Invoke(ref NativeCircularBuffer<float3> leftPortals, ref NativeCircularBuffer<float3> rightPortals, ref NativeCircularBuffer<float4> unwrappedPortals, ref float3 newLeftPortal, ref float3 newRightPortal, ref float3 projectionAxis)
				{
				}
			}

			[Token(Token = "0x2000152")]
			public delegate void ConvertCornerIndicesToPathProjected_00000A3E_0024PostfixBurstDelegate(ref FunnelState funnelState, ref UnsafeSpan<int> indices, bool splitAtEveryPortal, in float3 startPoint, in float3 endPoint, bool lastCorner, in float3 projectionAxis, ref UnsafeSpan<float3> result, in float3 up);

			[Token(Token = "0x2000153")]
			internal static class ConvertCornerIndicesToPathProjected_00000A3E_0024BurstDirectCall
			{
				[Token(Token = "0x4000702")]
				[FieldOffset(Offset = "0x0")]
				private static IntPtr Pointer;

				[Token(Token = "0x4000703")]
				[FieldOffset(Offset = "0x8")]
				private static IntPtr DeferredCompilation;

				[Token(Token = "0x6000ACA")]
				[Address(RVA = "0x456C650", Offset = "0x4568650", VA = "0x456C650")]
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr P_0)
				{
				}

				[Token(Token = "0x6000ACB")]
				[Address(RVA = "0x456C76C", Offset = "0x456876C", VA = "0x456C76C")]
				private static IntPtr GetFunctionPointer()
				{
					return default;
				}

				[Token(Token = "0x6000ACC")]
				[Address(RVA = "0x456C7C8", Offset = "0x45687C8", VA = "0x456C7C8")]
				public static void Constructor()
				{
				}

				[Token(Token = "0x6000ACD")]
				[Address(RVA = "0x456C870", Offset = "0x4568870", VA = "0x456C870")]
				public static void Initialize()
				{
				}

				[Token(Token = "0x6000ACF")]
				[Address(RVA = "0x456B63C", Offset = "0x456763C", VA = "0x456B63C")]
				public static void Invoke(ref FunnelState funnelState, ref UnsafeSpan<int> indices, bool splitAtEveryPortal, in float3 startPoint, in float3 endPoint, bool lastCorner, in float3 projectionAxis, ref UnsafeSpan<float3> result, in float3 up)
				{
				}
			}

			[Token(Token = "0x40006FC")]
			[FieldOffset(Offset = "0x0")]
			public NativeCircularBuffer<float3> leftFunnel;

			[Token(Token = "0x40006FD")]
			[FieldOffset(Offset = "0x18")]
			public NativeCircularBuffer<float3> rightFunnel;

			[Token(Token = "0x40006FE")]
			[FieldOffset(Offset = "0x30")]
			public NativeCircularBuffer<float4> unwrappedPortals;

			[Token(Token = "0x40006FF")]
			[FieldOffset(Offset = "0x48")]
			public float3 projectionAxis;

			[Token(Token = "0x6000AA3")]
			[Address(RVA = "0x4569BFC", Offset = "0x4565BFC", VA = "0x4569BFC")]
			public FunnelState(int initialCapacity, Allocator allocator)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED Funnel.FunnelState..ctor RVA=0x4569BFC Token=0x6000AA3");
}

			[Token(Token = "0x6000AA4")]
			[Address(RVA = "0x4568DE4", Offset = "0x4564DE4", VA = "0x4568DE4")]
			public FunnelState(FunnelPortals portals, Allocator allocator)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED Funnel.FunnelState..ctor RVA=0x4568DE4 Token=0x6000AA4");
}

			[Token(Token = "0x6000AA5")]
			[Address(RVA = "0x4569EE0", Offset = "0x4565EE0", VA = "0x4569EE0")]
			public FunnelState Clone()
			{
				return default;
			}

			[Token(Token = "0x6000AA6")]
			[Address(RVA = "0x4569FD8", Offset = "0x4565FD8", VA = "0x4569FD8")]
			public void Clear()
			{
			}

			[Token(Token = "0x6000AA7")]
			[Address(RVA = "0x4568F30", Offset = "0x4564F30", VA = "0x4568F30")]
			public void PopStart()
			{
			}

			[Token(Token = "0x6000AA8")]
			[Address(RVA = "0x4568FC8", Offset = "0x4564FC8", VA = "0x4568FC8")]
			public void PopEnd()
			{
			}

			[Token(Token = "0x6000AA9")]
			[Address(RVA = "0x456A084", Offset = "0x4566084", VA = "0x456A084")]
			public void Pop(bool fromStart)
			{
			}

			[Token(Token = "0x6000AAA")]
			[Address(RVA = "0x456A090", Offset = "0x4566090", VA = "0x456A090")]
			public void PushStart(float3 newLeftPortal, float3 newRightPortal)
			{
			}

			[Token(Token = "0x6000AAB")]
			[Address(RVA = "0x456A160", Offset = "0x4566160", VA = "0x456A160")]
			private static bool DifferentSidesOfLine(float3 start, float3 end, float3 a, float3 b)
			{
				return default;
			}

			[Token(Token = "0x6000AAC")]
			[Address(RVA = "0x456A300", Offset = "0x4566300", VA = "0x456A300")]
			public bool IsReasonableToPopStart(float3 startPoint, float3 endPoint)
			{
				return default;
			}

			[Token(Token = "0x6000AAD")]
			[Address(RVA = "0x456A508", Offset = "0x4566508", VA = "0x456A508")]
			public bool IsReasonableToPopEnd(float3 startPoint, float3 endPoint)
			{
				return default;
			}

			[Token(Token = "0x6000AAE")]
			[Address(RVA = "0x456A0CC", Offset = "0x45660CC", VA = "0x456A0CC")]
			[BurstCompile]
			private static void PushStart(ref NativeCircularBuffer<float3> leftPortals, ref NativeCircularBuffer<float3> rightPortals, ref NativeCircularBuffer<float4> unwrappedPortals, ref float3 newLeftPortal, ref float3 newRightPortal, ref float3 projectionAxis)
			{
			}

			[Token(Token = "0x6000AAF")]
			[Address(RVA = "0x456A81C", Offset = "0x456681C", VA = "0x456A81C")]
			public void Splice(int startIndex, int toRemove, List<float3> newLeftPortal, List<float3> newRightPortal)
			{
			}

			[Token(Token = "0x6000AB0")]
			[Address(RVA = "0x4569D44", Offset = "0x4565D44", VA = "0x4569D44")]
			public void PushEnd(Vector3 newLeftPortal, Vector3 newRightPortal)
			{
			}

			[Token(Token = "0x6000AB1")]
			[Address(RVA = "0x456A8D4", Offset = "0x45668D4", VA = "0x456A8D4")]
			public void Push(bool toStart, Vector3 newLeftPortal, Vector3 newRightPortal)
			{
			}

			[Token(Token = "0x6000AB2")]
			[Address(RVA = "0x456919C", Offset = "0x456519C", VA = "0x456919C")]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000AB3")]
			[Address(RVA = "0x456A974", Offset = "0x4566974", VA = "0x456A974")]
			public int CalculateNextCornerIndices(int maxCorners, NativeArray<int> result, float3 startPoint, float3 endPoint, out bool lastCorner)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED Funnel.FunnelState.CalculateNextCornerIndices RVA=0x456A974 Token=0x6000AB3");
}

			[Token(Token = "0x6000AB4")]
			[Address(RVA = "0x4569054", Offset = "0x4565054", VA = "0x4569054")]
			public void CalculateNextCorners(int maxCorners, bool splitAtEveryPortal, float3 startPoint, float3 endPoint, NativeList<float3> result)
			{
			}

			[Token(Token = "0x6000AB5")]
			[Address(RVA = "0x456AAB4", Offset = "0x4566AB4", VA = "0x456AAB4")]
			public void ConvertCornerIndicesToPath(NativeArray<int> indices, int numCorners, bool splitAtEveryPortal, float3 startPoint, float3 endPoint, bool lastCorner, NativeList<float3> result)
			{
			}

			[Token(Token = "0x6000AB6")]
			[Address(RVA = "0x456B124", Offset = "0x4567124", VA = "0x456B124")]
			public void ConvertCornerIndicesToPathProjected(UnsafeSpan<int> indices, bool splitAtEveryPortal, float3 startPoint, float3 endPoint, bool lastCorner, NativeList<float3> result, float3 up)
			{
			}

			[Token(Token = "0x6000AB7")]
			[Address(RVA = "0x456B368", Offset = "0x4567368", VA = "0x456B368")]
			public float4x3 UnwrappedPortalsToWorldMatrix(float3 up)
			{
				return default;
			}

			[Token(Token = "0x6000AB8")]
			[Address(RVA = "0x456B2B4", Offset = "0x45672B4", VA = "0x456B2B4")]
			[BurstCompile]
			public static void ConvertCornerIndicesToPathProjected(ref FunnelState funnelState, ref UnsafeSpan<int> indices, bool splitAtEveryPortal, in float3 startPoint, in float3 endPoint, bool lastCorner, in float3 projectionAxis, ref UnsafeSpan<float3> result, in float3 up)
			{
			}

			[Token(Token = "0x6000AB9")]
			[Address(RVA = "0x456AF8C", Offset = "0x4566F8C", VA = "0x456AF8C")]
			private static void CalculatePortalIntersections(int startIndex, int endIndex, NativeCircularBuffer<float3> leftPortals, NativeCircularBuffer<float3> rightPortals, NativeCircularBuffer<float4> unwrappedPortals, float2 from, float2 to, NativeList<float3> result)
			{
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x6000ABA")]
			[Address(RVA = "0x456B76C", Offset = "0x456776C", VA = "0x456B76C")]
			[BurstCompile]
			public static void PushStart_0024BurstManaged(ref NativeCircularBuffer<float3> leftPortals, ref NativeCircularBuffer<float3> rightPortals, ref NativeCircularBuffer<float4> unwrappedPortals, ref float3 newLeftPortal, ref float3 newRightPortal, ref float3 projectionAxis)
			{
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x6000ABB")]
			[Address(RVA = "0x456BB98", Offset = "0x4567B98", VA = "0x456BB98")]
			[BurstCompile]
			public static void ConvertCornerIndicesToPathProjected_0024BurstManaged(ref FunnelState funnelState, ref UnsafeSpan<int> indices, bool splitAtEveryPortal, in float3 startPoint, in float3 endPoint, bool lastCorner, in float3 projectionAxis, ref UnsafeSpan<float3> result, in float3 up)
			{
			}
		}

		[Token(Token = "0x2000154")]
		public delegate int Calculate_00000A26_0024PostfixBurstDelegate(ref NativeCircularBuffer<float4> unwrappedPortals, ref NativeCircularBuffer<float3> leftPortals, ref NativeCircularBuffer<float3> rightPortals, ref float3 startPoint, ref float3 endPoint, ref UnsafeSpan<int> funnelPath, int maxCorners, ref float3 projectionAxis, out bool lastCorner);

		[Token(Token = "0x2000155")]
		internal static class Calculate_00000A26_0024BurstDirectCall
		{
			[Token(Token = "0x4000704")]
			[FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			[Token(Token = "0x4000705")]
			[FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;

			[Token(Token = "0x6000AD4")]
			[Address(RVA = "0x456CB20", Offset = "0x4568B20", VA = "0x456CB20")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
			}

			[Token(Token = "0x6000AD5")]
			[Address(RVA = "0x456CC3C", Offset = "0x4568C3C", VA = "0x456CC3C")]
			private static IntPtr GetFunctionPointer()
			{
				return default;
			}

			[Token(Token = "0x6000AD6")]
			[Address(RVA = "0x456CC98", Offset = "0x4568C98", VA = "0x456CC98")]
			public static void Constructor()
			{
			}

			[Token(Token = "0x6000AD7")]
			[Address(RVA = "0x456CD40", Offset = "0x4568D40", VA = "0x456CD40")]
			public static void Initialize()
			{
			}

			[Token(Token = "0x6000AD9")]
			[Address(RVA = "0x45692CC", Offset = "0x45652CC", VA = "0x45692CC")]
			public static int Invoke(ref NativeCircularBuffer<float4> unwrappedPortals, ref NativeCircularBuffer<float3> leftPortals, ref NativeCircularBuffer<float3> rightPortals, ref float3 startPoint, ref float3 endPoint, ref UnsafeSpan<int> funnelPath, int maxCorners, ref float3 projectionAxis, out bool lastCorner)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED Funnel.Calculate_00000A26_0024BurstDirectCall.Invoke RVA=0x45692CC Token=0x6000AD9");
}
		}

		[Token(Token = "0x40006F0")]
		public const int RightSideBit = 1073741824;

		[Token(Token = "0x40006F1")]
		public const int FunnelPortalIndexMask = 1073741823;

		[Token(Token = "0x6000A96")]
		[Address(RVA = "0x45669A4", Offset = "0x45629A4", VA = "0x45669A4")]
		public static List<PathPart> SplitIntoParts(Path path)
		{
			return null;
		}

		[Token(Token = "0x6000A97")]
		[Address(RVA = "0x45670C0", Offset = "0x45630C0", VA = "0x45670C0")]
		public static void Simplify(List<PathPart> parts, ref List<GraphNode> nodes, ref TraversalCosts traversalCosts, ref TraversalConstraint traversalConstraint)
		{
		}

		[Token(Token = "0x6000A98")]
		[Address(RVA = "0x45673D8", Offset = "0x45633D8", VA = "0x45673D8")]
		public static void Simplify(PathPart part, IRaycastableGraph graph, List<GraphNode> nodes, List<GraphNode> result, ref TraversalCosts traversalCosts, ref TraversalConstraint traversalConstraint)
		{
		}

		[Token(Token = "0x6000A99")]
		[Address(RVA = "0x4568094", Offset = "0x4564094", VA = "0x4568094")]
		private static void RemoveBacktracking(List<GraphNode> nodes, int listStartIndex, int aroundIndex)
		{
		}

		[Token(Token = "0x6000A9A")]
		[Address(RVA = "0x456818C", Offset = "0x456418C", VA = "0x456818C")]
		public static FunnelPortals ConstructFunnelPortals(List<GraphNode> nodes, PathPart part)
		{
			return default;
		}

		[Token(Token = "0x6000A9B")]
		[Address(RVA = "0x45687E8", Offset = "0x45647E8", VA = "0x45687E8")]
		private static float2 Unwrap(float3 leftPortal, float3 rightPortal, float2 leftUnwrappedPortal, float2 rightUnwrappedPortal, float3 point, float sideMultiplier, float3 projectionAxis)
		{
			return default;
		}

		[Token(Token = "0x6000A9C")]
		[Address(RVA = "0x4568ACC", Offset = "0x4564ACC", VA = "0x4568ACC")]
		private static bool RightOrColinear(Vector2 a, Vector2 b)
		{
			return default;
		}

		[Token(Token = "0x6000A9D")]
		[Address(RVA = "0x4568AE4", Offset = "0x4564AE4", VA = "0x4568AE4")]
		private static bool LeftOrColinear(Vector2 a, Vector2 b)
		{
			return default;
		}

		[Token(Token = "0x6000A9E")]
		[Address(RVA = "0x4568AFC", Offset = "0x4564AFC", VA = "0x4568AFC")]
		public static List<Vector3> Calculate(FunnelPortals funnel, bool splitAtEveryPortal)
		{
			return null;
		}

		[Token(Token = "0x6000A9F")]
		[Address(RVA = "0x4569218", Offset = "0x4565218", VA = "0x4569218")]
		[BurstCompile]
		private static int Calculate(ref NativeCircularBuffer<float4> unwrappedPortals, ref NativeCircularBuffer<float3> leftPortals, ref NativeCircularBuffer<float3> rightPortals, ref float3 startPoint, ref float3 endPoint, ref UnsafeSpan<int> funnelPath, int maxCorners, ref float3 projectionAxis, out bool lastCorner)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED Funnel.Calculate RVA=0x4569218 Token=0x6000A9F");
}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000AA2")]
		[Address(RVA = "0x45693FC", Offset = "0x45653FC", VA = "0x45693FC")]
		[BurstCompile]
		public static int Calculate_0024BurstManaged(ref NativeCircularBuffer<float4> unwrappedPortals, ref NativeCircularBuffer<float3> leftPortals, ref NativeCircularBuffer<float3> rightPortals, ref float3 startPoint, ref float3 endPoint, ref UnsafeSpan<int> funnelPath, int maxCorners, ref float3 projectionAxis, out bool lastCorner)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED Funnel.Calculate_0024BurstManaged RVA=0x45693FC Token=0x6000AA2");
}
	}
}
