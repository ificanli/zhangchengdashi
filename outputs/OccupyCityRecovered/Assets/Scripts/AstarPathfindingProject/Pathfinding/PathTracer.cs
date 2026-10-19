using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Pathfinding.Collections;
using Pathfinding.Drawing;
using Pathfinding.Util;
using Unity.Burst;
using Unity.Collections;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x200015A")]
	[BurstCompile]
	public struct PathTracer
	{
		[Token(Token = "0x200015B")]
		public enum PartGraphType : byte
		{
			[Token(Token = "0x400073A")]
			Navmesh = 0,
			[Token(Token = "0x400073B")]
			Grid = 1,
			[Token(Token = "0x400073C")]
			OffMeshLink = 2
		}

		[Token(Token = "0x200015C")]
		public enum RepairQuality
		{
			[Token(Token = "0x400073E")]
			Low = 0,
			[Token(Token = "0x400073F")]
			High = 1
		}

		[Token(Token = "0x200015D")]
		private struct QueueItem
		{
			[Token(Token = "0x4000740")]
			[FieldOffset(Offset = "0x0")]
			public GraphNode node;

			[Token(Token = "0x4000741")]
			[FieldOffset(Offset = "0x8")]
			public int parent;

			[Token(Token = "0x4000742")]
			[FieldOffset(Offset = "0xC")]
			public float distance;
		}

		[Token(Token = "0x200015F")]
		public delegate bool ContainsAndProject_00000A6A_0024PostfixBurstDelegate(ref Int3 a, ref Int3 b, ref Int3 c, ref Vector3 p, float height, ref NativeMovementPlane movementPlane, out Vector3 projected);

		[Token(Token = "0x2000160")]
		internal static class ContainsAndProject_00000A6A_0024BurstDirectCall
		{
			[Token(Token = "0x4000745")]
			[FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			[Token(Token = "0x4000746")]
			[FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;

			[Token(Token = "0x6000B39")]
			[Address(RVA = "0x457B5B8", Offset = "0x45775B8", VA = "0x457B5B8")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
			}

			[Token(Token = "0x6000B3A")]
			[Address(RVA = "0x457B6D4", Offset = "0x45776D4", VA = "0x457B6D4")]
			private static IntPtr GetFunctionPointer()
			{
				return default;
			}

			[Token(Token = "0x6000B3B")]
			[Address(RVA = "0x457B730", Offset = "0x4577730", VA = "0x457B730")]
			public static void Constructor()
			{
			}

			[Token(Token = "0x6000B3C")]
			[Address(RVA = "0x457B7D8", Offset = "0x45777D8", VA = "0x457B7D8")]
			public static void Initialize()
			{
			}

			[Token(Token = "0x6000B3E")]
			[Address(RVA = "0x457B7E0", Offset = "0x45777E0", VA = "0x457B7E0")]
			public static bool Invoke(ref Int3 a, ref Int3 b, ref Int3 c, ref Vector3 p, float height, ref NativeMovementPlane movementPlane, out Vector3 projected)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED PathTracer.ContainsAndProject_00000A6A_0024BurstDirectCall.Invoke RVA=0x457B7E0 Token=0x6000B3E");
}
		}

		[Token(Token = "0x2000161")]
		public delegate float EstimateRemainingPath_00000A7D_0024PostfixBurstDelegate(ref Funnel.FunnelState funnelState, ref Funnel.PathPart part, int maxCorners, ref NativeMovementPlane movementPlane);

		[Token(Token = "0x2000162")]
		internal static class EstimateRemainingPath_00000A7D_0024BurstDirectCall
		{
			[Token(Token = "0x4000747")]
			[FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			[Token(Token = "0x4000748")]
			[FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;

			[Token(Token = "0x6000B43")]
			[Address(RVA = "0x457BB20", Offset = "0x4577B20", VA = "0x457BB20")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
			}

			[Token(Token = "0x6000B44")]
			[Address(RVA = "0x457BC3C", Offset = "0x4577C3C", VA = "0x457BC3C")]
			private static IntPtr GetFunctionPointer()
			{
				return default;
			}

			[Token(Token = "0x6000B45")]
			[Address(RVA = "0x457BC98", Offset = "0x4577C98", VA = "0x457BC98")]
			public static void Constructor()
			{
			}

			[Token(Token = "0x6000B46")]
			[Address(RVA = "0x457BD40", Offset = "0x4577D40", VA = "0x457BD40")]
			public static void Initialize()
			{
			}

			[Token(Token = "0x6000B48")]
			[Address(RVA = "0x457BD48", Offset = "0x4577D48", VA = "0x457BD48")]
			public static float Invoke(ref Funnel.FunnelState funnelState, ref Funnel.PathPart part, int maxCorners, ref NativeMovementPlane movementPlane)
			{
				return default;
			}
		}

		[Token(Token = "0x2000163")]
		public delegate float RemainingDistanceLowerBound_00000A81_0024PostfixBurstDelegate(in UnsafeSpan<float3> nextCorners, in float3 endOfPart, in NativeMovementPlane movementPlane);

		[Token(Token = "0x2000164")]
		internal static class RemainingDistanceLowerBound_00000A81_0024BurstDirectCall
		{
			[Token(Token = "0x4000749")]
			[FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			[Token(Token = "0x400074A")]
			[FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;

			[Token(Token = "0x6000B4D")]
			[Address(RVA = "0x457C01C", Offset = "0x457801C", VA = "0x457C01C")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
			}

			[Token(Token = "0x6000B4E")]
			[Address(RVA = "0x457C138", Offset = "0x4578138", VA = "0x457C138")]
			private static IntPtr GetFunctionPointer()
			{
				return default;
			}

			[Token(Token = "0x6000B4F")]
			[Address(RVA = "0x457C194", Offset = "0x4578194", VA = "0x457C194")]
			public static void Constructor()
			{
			}

			[Token(Token = "0x6000B50")]
			[Address(RVA = "0x457C23C", Offset = "0x457823C", VA = "0x457C23C")]
			public static void Initialize()
			{
			}

			[Token(Token = "0x6000B52")]
			[Address(RVA = "0x457C244", Offset = "0x4578244", VA = "0x457C244")]
			public static float Invoke(in UnsafeSpan<float3> nextCorners, in float3 endOfPart, in NativeMovementPlane movementPlane)
			{
				return default;
			}
		}

		[Token(Token = "0x400071B")]
		[FieldOffset(Offset = "0x0")]
		private Funnel.PathPart[] parts;

		[Token(Token = "0x400071C")]
		[FieldOffset(Offset = "0x8")]
		private CircularBuffer<GraphNode> nodes;

		[Token(Token = "0x400071D")]
		[FieldOffset(Offset = "0x18")]
		private CircularBuffer<int> nodeHashes;

		[Token(Token = "0x400071E")]
		[FieldOffset(Offset = "0x28")]
		private CircularBuffer<byte> portalIsNotInnerCorner;

		[Token(Token = "0x400071F")]
		[FieldOffset(Offset = "0x38")]
		private Funnel.FunnelState funnelState;

		[Token(Token = "0x4000720")]
		[FieldOffset(Offset = "0x90")]
		private Vector3 unclampedEndPoint;

		[Token(Token = "0x4000721")]
		[FieldOffset(Offset = "0x9C")]
		private Vector3 unclampedStartPoint;

		[Token(Token = "0x4000722")]
		[FieldOffset(Offset = "0xA8")]
		private GraphNode startNodeInternal;

		[Token(Token = "0x4000723")]
		[FieldOffset(Offset = "0xB0")]
		private TraversalConstraint traversalConstraint;

		[Token(Token = "0x4000724")]
		[FieldOffset(Offset = "0xC8")]
		private TraversalCosts traversalCosts;

		[Token(Token = "0x4000725")]
		[FieldOffset(Offset = "0xE0")]
		private int firstPartIndex;

		[Token(Token = "0x4000726")]
		[FieldOffset(Offset = "0xE4")]
		private bool startIsUpToDate;

		[Token(Token = "0x4000727")]
		[FieldOffset(Offset = "0xE5")]
		private bool endIsUpToDate;

		[Token(Token = "0x4000728")]
		[FieldOffset(Offset = "0xE6")]
		private bool pathEmptyAndUnrepairableBacking;

		[Token(Token = "0x4000729")]
		[FieldOffset(Offset = "0xE7")]
		private bool firstPartContainsDestroyedNodes;

		[Token(Token = "0x400072A")]
		[FieldOffset(Offset = "0xE8")]
		public PartGraphType partGraphType;

		[Token(Token = "0x400072C")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ProfilerMarker MarkerContains;

		[Token(Token = "0x400072D")]
		[FieldOffset(Offset = "0x8")]
		private static readonly ProfilerMarker MarkerClosest;

		[Token(Token = "0x400072E")]
		[FieldOffset(Offset = "0x10")]
		private static readonly ProfilerMarker MarkerGetNearest;

		[Token(Token = "0x400072F")]
		[FieldOffset(Offset = "0x18")]
		private static readonly ProfilerMarker MarkerSetFunnelState;

		[Token(Token = "0x4000730")]
		[FieldOffset(Offset = "0x20")]
		private static readonly ProfilerMarker MarkerCalculatePortals;

		[Token(Token = "0x4000731")]
		private const int NODES_TO_CHECK_FOR_DESTRUCTION = 5;

		[Token(Token = "0x4000732")]
		[FieldOffset(Offset = "0x28")]
		private static readonly QueueItem[][] TempQueues;

		[Token(Token = "0x4000733")]
		[FieldOffset(Offset = "0x30")]
		private static readonly List<GraphNode>[] TempConnectionLists;

		[Token(Token = "0x4000734")]
		[ThreadStatic]
		private static List<float3> tmpLeftPortals;

		[Token(Token = "0x4000735")]
		[ThreadStatic]
		private static List<float3> tmpRightPortals;

		[Token(Token = "0x4000736")]
		[ThreadStatic]
		private static List<GraphNode> scratchList;

		[Token(Token = "0x4000737")]
		[FieldOffset(Offset = "0x38")]
		private static int[] SplittingCoefficients;

		[Token(Token = "0x4000738")]
		[FieldOffset(Offset = "0x40")]
		private static readonly ProfilerMarker MarkerSimplify;

		[Token(Token = "0x170001DE")]
		private bool pathEmptyAndUnrepairable
		{
			[Token(Token = "0x6000AEA")]
			[Address(RVA = "0x456FBB0", Offset = "0x456BBB0", VA = "0x456FBB0")]
			readonly get
			{
				return default;
			}
			[Token(Token = "0x6000AEB")]
			[Address(RVA = "0x456FBB8", Offset = "0x456BBB8", VA = "0x456FBB8")]
			set
			{
			}
		}

		[Token(Token = "0x170001DF")]
		public ushort version
		{
			[Token(Token = "0x6000AEC")]
			[Address(RVA = "0x456FDFC", Offset = "0x456BDFC", VA = "0x456FDFC")]
			[CompilerGenerated]
			[IgnoredByDeepProfiler]
			readonly get
			{
				return default;
			}
			[Token(Token = "0x6000AED")]
			[Address(RVA = "0x456FE04", Offset = "0x456BE04", VA = "0x456FE04")]
			[CompilerGenerated]
			[IgnoredByDeepProfiler]
			private set
			{
			}
		}

		[Token(Token = "0x170001E0")]
		public readonly bool isCreated
		{
			[Token(Token = "0x6000AEE")]
			[Address(RVA = "0x456FE0C", Offset = "0x456BE0C", VA = "0x456FE0C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170001E1")]
		public GraphNode startNode
		{
			[Token(Token = "0x6000AEF")]
			[Address(RVA = "0x456FE54", Offset = "0x456BE54", VA = "0x456FE54")]
			[IgnoredByDeepProfiler]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000AF0")]
			[Address(RVA = "0x456FE84", Offset = "0x456BE84", VA = "0x456FE84")]
			[IgnoredByDeepProfiler]
			private set
			{
			}
		}

		[Token(Token = "0x170001E2")]
		public readonly bool isStale
		{
			[Token(Token = "0x6000AF1")]
			[Address(RVA = "0x456FE8C", Offset = "0x456BE8C", VA = "0x456FE8C")]
			[IgnoredByDeepProfiler]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170001E3")]
		public readonly int partCount
		{
			[Token(Token = "0x6000AF2")]
			[Address(RVA = "0x456FEBC", Offset = "0x456BEBC", VA = "0x456FEBC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170001E4")]
		public readonly bool hasPath
		{
			[Token(Token = "0x6000AF3")]
			[Address(RVA = "0x456FEDC", Offset = "0x456BEDC", VA = "0x456FEDC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170001E5")]
		public readonly bool hasValidEndPoint
		{
			[Token(Token = "0x6000AF4")]
			[Address(RVA = "0x456FF50", Offset = "0x456BF50", VA = "0x456FF50")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170001E6")]
		public readonly Vector3 startPoint
		{
			[Token(Token = "0x6000AF5")]
			[Address(RVA = "0x456FFC4", Offset = "0x456BFC4", VA = "0x456FFC4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170001E7")]
		public readonly Vector3 endPoint
		{
			[Token(Token = "0x6000AF6")]
			[Address(RVA = "0x4570000", Offset = "0x456C000", VA = "0x4570000")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170001E8")]
		public readonly Vector3 endPointOfFirstPart
		{
			[Token(Token = "0x6000AF7")]
			[Address(RVA = "0x4570038", Offset = "0x456C038", VA = "0x4570038")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170001E9")]
		public int desiredCornersForGoodSimplification
		{
			[Token(Token = "0x6000AF8")]
			[Address(RVA = "0x4570074", Offset = "0x456C074", VA = "0x4570074")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170001EA")]
		public readonly bool isNextPartValidLink
		{
			[Token(Token = "0x6000AF9")]
			[Address(RVA = "0x4570088", Offset = "0x456C088", VA = "0x4570088")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000AFA")]
		[Address(RVA = "0x45702B4", Offset = "0x456C2B4", VA = "0x45702B4")]
		public PathTracer(Allocator allocator)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED PathTracer..ctor RVA=0x45702B4 Token=0x6000AFA");
}

		[Token(Token = "0x6000AFB")]
		[Address(RVA = "0x45705C0", Offset = "0x456C5C0", VA = "0x45705C0")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000AFC")]
		[Address(RVA = "0x457061C", Offset = "0x456C61C", VA = "0x457061C")]
		public void SetEmptyAndUnrepairable()
		{
		}

		[Token(Token = "0x6000AFD")]
		[Address(RVA = "0x4570674", Offset = "0x456C674", VA = "0x4570674")]
		public Vector3 UpdateStart(Vector3 position, RepairQuality quality, NativeMovementPlane movementPlane)
		{
			return default;
		}

		[Token(Token = "0x6000AFE")]
		[Address(RVA = "0x4570D1C", Offset = "0x456CD1C", VA = "0x4570D1C")]
		public Vector3 UpdateEnd(Vector3 position, RepairQuality quality, NativeMovementPlane movementPlane)
		{
			return default;
		}

		[Token(Token = "0x6000AFF")]
		[Address(RVA = "0x4570E10", Offset = "0x456CE10", VA = "0x4570E10")]
		private void AppendNode(bool toStart, GraphNode node)
		{
		}

		[Token(Token = "0x6000B00")]
		[Address(RVA = "0x4571534", Offset = "0x456D534", VA = "0x4571534")]
		private void AppendPath(bool toStart, CircularBuffer<GraphNode> path)
		{
		}

		[Token(Token = "0x6000B01")]
		[Address(RVA = "0x45716D4", Offset = "0x456D6D4", VA = "0x45716D4")]
		[Conditional("UNITY_EDITOR")]
		private void CheckInvariants()
		{
		}

		[Token(Token = "0x6000B02")]
		[Address(RVA = "0x45716D8", Offset = "0x456D6D8", VA = "0x45716D8")]
		private bool SplicePath(int startIndex, int toRemove, List<GraphNode> toInsert)
		{
			return default;
		}

		[Token(Token = "0x6000B03")]
		[Address(RVA = "0x457221C", Offset = "0x456E21C", VA = "0x457221C")]
		private static bool ContainsPoint(GraphNode node, Vector3 point, NativeMovementPlane plane)
		{
			return default;
		}

		[Token(Token = "0x6000B04")]
		[Address(RVA = "0x4572308", Offset = "0x456E308", VA = "0x4572308")]
		[BurstCompile]
		private static bool ContainsAndProject(ref Int3 a, ref Int3 b, ref Int3 c, ref Vector3 p, float height, ref NativeMovementPlane movementPlane, out Vector3 projected)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED PathTracer.ContainsAndProject RVA=0x4572308 Token=0x6000B04");
}

		[Token(Token = "0x6000B05")]
		[Address(RVA = "0x45723B0", Offset = "0x456E3B0", VA = "0x45723B0")]
		private static float3 ProjectOnSurface(float3 a, float3 b, float3 c, float3 p, float3 up)
		{
			return default;
		}

		[Token(Token = "0x6000B06")]
		[Address(RVA = "0x457076C", Offset = "0x456C76C", VA = "0x457076C")]
		private void Repair(Vector3 point, bool isStart, RepairQuality quality, NativeMovementPlane movementPlane, bool allowCache = true)
		{
		}

		[Token(Token = "0x6000B07")]
		[Address(RVA = "0x4573390", Offset = "0x456F390", VA = "0x4573390")]
		private void HeuristicallyPopPortals(bool isStartOfPart, Vector3 point)
		{
		}

		[Token(Token = "0x6000B08")]
		[Address(RVA = "0x45737BC", Offset = "0x456F7BC", VA = "0x45737BC")]
		[Conditional("UNITY_ASSERTIONS")]
		private void AssertValidInPath(int absoluteNodeIndex)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000B09")]
		[Address(RVA = "0x45737C0", Offset = "0x456F7C0", VA = "0x45737C0")]
		[IgnoredByDeepProfiler]
		private readonly bool ValidInPath(int absoluteNodeIndex)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000B0A")]
		[Address(RVA = "0x457391C", Offset = "0x456F91C", VA = "0x457391C")]
		[IgnoredByDeepProfiler]
		private static bool Valid(GraphNode node)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000B0B")]
		[Address(RVA = "0x4573954", Offset = "0x456F954", VA = "0x4573954")]
		[IgnoredByDeepProfiler]
		private static int HashNode(GraphNode node)
		{
			return default;
		}

		[Token(Token = "0x6000B0C")]
		[Address(RVA = "0x4572640", Offset = "0x456E640", VA = "0x4572640")]
		private void RepairFull(Vector3 point, bool isStart, RepairQuality quality, NativeMovementPlane movementPlane)
		{
		}

		[Token(Token = "0x6000B0D")]
		[Address(RVA = "0x4574324", Offset = "0x4570324", VA = "0x4574324")]
		private static float SquaredDistanceToNode(GraphNode node, Vector3 point, ref BBTree.ProjectionParams projectionParams)
		{
			return default;
		}

		[Token(Token = "0x6000B0E")]
		[Address(RVA = "0x45745CC", Offset = "0x45705CC", VA = "0x45745CC")]
		private static bool QueueHasNode(QueueItem[] queue, int count, GraphNode node)
		{
			return default;
		}

		[Token(Token = "0x6000B0F")]
		[Address(RVA = "0x4574630", Offset = "0x4570630", VA = "0x4574630")]
		private void GetTempQueue(out QueueItem[] queue, out List<GraphNode> connections)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED PathTracer.GetTempQueue RVA=0x4574630 Token=0x6000B0F");
}

		[Token(Token = "0x6000B10")]
		[Address(RVA = "0x4573B38", Offset = "0x456FB38", VA = "0x4573B38")]
		private CircularBuffer<GraphNode> LocalSearch(GraphNode currentNode, Vector3 point, int maxNodesToSearch, NativeMovementPlane movementPlane, bool reverse)
		{
			return default;
		}

		[Token(Token = "0x6000B11")]
		[Address(RVA = "0x4574D3C", Offset = "0x4570D3C", VA = "0x4574D3C")]
		public void DrawFunnel(CommandBuilder draw, NativeMovementPlane movementPlane)
		{
		}

		[Token(Token = "0x6000B12")]
		[Address(RVA = "0x45756B8", Offset = "0x45716B8", VA = "0x45756B8")]
		private static Int3 MaybeSetYZero(Int3 p, bool setYToZero)
		{
			return default;
		}

		[Token(Token = "0x6000B13")]
		[Address(RVA = "0x45756D4", Offset = "0x45716D4", VA = "0x45756D4")]
		private static bool IsInnerVertex(CircularBuffer<GraphNode> nodes, Funnel.PathPart part, int portalIndex, bool rightSide, List<GraphNode> alternativeNodes, ref TraversalConstraint traversalConstraint, ref TraversalCosts traversalCosts, out int startIndex, out int endIndex)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED PathTracer.IsInnerVertex RVA=0x45756D4 Token=0x6000B13");
}

		[Token(Token = "0x6000B14")]
		[Address(RVA = "0x45758A8", Offset = "0x45718A8", VA = "0x45758A8")]
		private static bool IsInnerVertexTriangleMesh(CircularBuffer<GraphNode> nodes, Funnel.PathPart part, int portalIndex, bool rightSide, List<GraphNode> alternativeNodes, ref TraversalConstraint traversalConstraint, ref TraversalCosts traversalCosts, out int startIndex, out int endIndex)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED PathTracer.IsInnerVertexTriangleMesh RVA=0x45758A8 Token=0x6000B14");
}

		[Token(Token = "0x6000B15")]
		[Address(RVA = "0x45762A0", Offset = "0x45722A0", VA = "0x45762A0")]
		private bool FirstInnerVertex(NativeArray<int> indices, int numCorners, List<GraphNode> alternativePath, out int alternativeStartIndex, out int alternativeEndIndex)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED PathTracer.FirstInnerVertex RVA=0x45762A0 Token=0x6000B15");
}

		[Token(Token = "0x6000B16")]
		[Address(RVA = "0x45764D8", Offset = "0x45724D8", VA = "0x45764D8")]
		public float EstimateRemainingPath(int maxCorners, ref NativeMovementPlane movementPlane)
		{
			return default;
		}

		[Token(Token = "0x6000B17")]
		[Address(RVA = "0x4576570", Offset = "0x4572570", VA = "0x4576570")]
		[BurstCompile]
		private static float EstimateRemainingPath(ref Funnel.FunnelState funnelState, ref Funnel.PathPart part, int maxCorners, ref NativeMovementPlane movementPlane)
		{
			return default;
		}

		[Token(Token = "0x6000B18")]
		[Address(RVA = "0x45765F0", Offset = "0x45725F0", VA = "0x45765F0")]
		public void GetNextCorners(NativeList<float3> buffer, int maxCorners, ref NativeArray<int> scratchArray, Allocator allocator, bool allowSimplify = true)
		{
		}

		[Token(Token = "0x6000B19")]
		[Address(RVA = "0x4576744", Offset = "0x4572744", VA = "0x4576744")]
		public int GetNextCornerIndices(ref NativeArray<int> buffer, int maxCorners, Allocator allocator, bool allowSimplify, out bool lastCorner)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED PathTracer.GetNextCornerIndices RVA=0x4576744 Token=0x6000B19");
}

		[Token(Token = "0x6000B1A")]
		[Address(RVA = "0x457786C", Offset = "0x457386C", VA = "0x457786C")]
		public void ConvertCornerIndicesToPathProjected(NativeArray<int> cornerIndices, int numCorners, bool lastCorner, NativeList<float3> buffer, float3 up)
		{
		}

		[Token(Token = "0x6000B1B")]
		[Address(RVA = "0x4577AA0", Offset = "0x4573AA0", VA = "0x4577AA0")]
		[BurstCompile]
		public static float RemainingDistanceLowerBound(in UnsafeSpan<float3> nextCorners, in float3 endOfPart, in NativeMovementPlane movementPlane)
		{
			return default;
		}

		[Token(Token = "0x6000B1C")]
		[Address(RVA = "0x4577B10", Offset = "0x4573B10", VA = "0x4577B10")]
		public void PopParts(int count)
		{
		}

		[Token(Token = "0x6000B1D")]
		[Address(RVA = "0x456FC44", Offset = "0x456BC44", VA = "0x456FC44")]
		public void RemoveAllButFirstNode()
		{
		}

		[Token(Token = "0x6000B1E")]
		[Address(RVA = "0x457247C", Offset = "0x456E47C", VA = "0x457247C")]
		private void RemoveAllPartsExceptFirst()
		{
		}

		[Token(Token = "0x6000B1F")]
		[Address(RVA = "0x4570140", Offset = "0x456C140", VA = "0x4570140")]
		public readonly Funnel.PartType GetPartType(int partIndex = 0)
		{
			return default;
		}

		[Token(Token = "0x6000B20")]
		[Address(RVA = "0x457017C", Offset = "0x456C17C", VA = "0x457017C")]
		public readonly bool PartContainsDestroyedNodes(int partIndex = 0)
		{
			return default;
		}

		[Token(Token = "0x6000B21")]
		[Address(RVA = "0x4578398", Offset = "0x4574398", VA = "0x4578398")]
		public OffMeshLinks.OffMeshLinkTracer GetLinkInfo(int partIndex = 0)
		{
			return default;
		}

		[Token(Token = "0x6000B22")]
		[Address(RVA = "0x4571D30", Offset = "0x456DD30", VA = "0x4571D30")]
		private static void GetTemporaryPortalLists(out List<float3> left, out List<float3> right)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED PathTracer.GetTemporaryPortalLists RVA=0x4571D30 Token=0x6000B22");
}

		[Token(Token = "0x6000B23")]
		[Address(RVA = "0x4578070", Offset = "0x4574070", VA = "0x4578070")]
		private void SetFunnelState(Funnel.PathPart part)
		{
		}

		[Token(Token = "0x6000B24")]
		[Address(RVA = "0x4571EDC", Offset = "0x456DEDC", VA = "0x4571EDC")]
		private void CalculateFunnelPortals(int startNodeIndex, int endNodeIndex, List<float3> outLeftPortals, List<float3> outRightPortals)
		{
		}

		[Token(Token = "0x6000B25")]
		[Address(RVA = "0x4578694", Offset = "0x4574694", VA = "0x4578694")]
		public void SetFromSingleNode(GraphNode node, Vector3 position, NativeMovementPlane movementPlane, TraversalConstraint traversalConstraint, TraversalCosts traversalCosts)
		{
		}

		[Token(Token = "0x6000B26")]
		[Address(RVA = "0x4570494", Offset = "0x456C494", VA = "0x4570494")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000B27")]
		[Address(RVA = "0x4578E08", Offset = "0x4574E08", VA = "0x4578E08")]
		private static int2 ResolveNormalizedGridPoint(GridGraph grid, ref CircularBuffer<GraphNode> nodes, UnsafeSpan<int> cornerIndices, Funnel.PathPart part, int index, out int nodeIndex)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED PathTracer.ResolveNormalizedGridPoint RVA=0x4578E08 Token=0x6000B27");
}

		[Token(Token = "0x6000B28")]
		[Address(RVA = "0x4576BE4", Offset = "0x4572BE4", VA = "0x4576BE4")]
		private static bool SimplifyGridInnerVertex(ref CircularBuffer<GraphNode> nodes, UnsafeSpan<int> cornerIndices, Funnel.PathPart part, ref CircularBuffer<byte> portalIsNotInnerCorner, List<GraphNode> alternativePath, out int alternativeStartIndex, out int alternativeEndIndex, ref TraversalConstraint traversalConstraint, ref TraversalCosts traversalCosts, bool lastCorner)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED PathTracer.SimplifyGridInnerVertex RVA=0x4576BE4 Token=0x6000B28");
}

		[Token(Token = "0x6000B29")]
		[Address(RVA = "0x45747E8", Offset = "0x45707E8", VA = "0x45747E8")]
		private static void RemoveGridPathDiagonals(Funnel.PathPart[] parts, int partIndex, ref CircularBuffer<GraphNode> path, ref CircularBuffer<int> pathNodeHashes, ref TraversalConstraint traversalConstraint)
		{
		}

		[Token(Token = "0x6000B2A")]
		[Address(RVA = "0x4573A0C", Offset = "0x456FA0C", VA = "0x4573A0C")]
		private static PartGraphType PartGraphTypeFromNode(GraphNode node)
		{
			return default;
		}

		[Token(Token = "0x6000B2B")]
		[Address(RVA = "0x4579360", Offset = "0x4575360", VA = "0x4579360")]
		public void SetPath(ABPath path, NativeMovementPlane movementPlane)
		{
		}

		[Token(Token = "0x6000B2C")]
		[Address(RVA = "0x4578940", Offset = "0x4574940", VA = "0x4578940")]
		public void SetPath(List<Funnel.PathPart> parts, List<GraphNode> nodes, Vector3 unclampedStartPoint, Vector3 unclampedEndPoint, NativeMovementPlane movementPlane, TraversalConstraint traversalConstraint, TraversalCosts traversalCosts)
		{
		}

		[Token(Token = "0x6000B2D")]
		[Address(RVA = "0x45794E4", Offset = "0x45754E4", VA = "0x45794E4")]
		public PathTracer Clone()
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000B2F")]
		[Address(RVA = "0x4579978", Offset = "0x4575978", VA = "0x4579978")]
		[BurstCompile]
		public static bool ContainsAndProject_0024BurstManaged(ref Int3 a, ref Int3 b, ref Int3 c, ref Vector3 p, float height, ref NativeMovementPlane movementPlane, out Vector3 projected)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED PathTracer.ContainsAndProject_0024BurstManaged RVA=0x4579978 Token=0x6000B2F");
}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000B30")]
		[Address(RVA = "0x4579C38", Offset = "0x4575C38", VA = "0x4579C38")]
		[BurstCompile]
		public static float EstimateRemainingPath_0024BurstManaged(ref Funnel.FunnelState funnelState, ref Funnel.PathPart part, int maxCorners, ref NativeMovementPlane movementPlane)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000B31")]
		[Address(RVA = "0x4579EA4", Offset = "0x4575EA4", VA = "0x4579EA4")]
		[BurstCompile]
		public static float RemainingDistanceLowerBound_0024BurstManaged(in UnsafeSpan<float3> nextCorners, in float3 endOfPart, in NativeMovementPlane movementPlane)
		{
			return default;
		}
	}
}
