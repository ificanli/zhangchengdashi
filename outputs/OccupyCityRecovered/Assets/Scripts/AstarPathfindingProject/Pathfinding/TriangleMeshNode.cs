using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Pathfinding.Collections;
using Pathfinding.Serialization;
using Pathfinding.Util;
using Unity.Burst;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x20000F0")]
	[BurstCompile]
	public sealed class TriangleMeshNode : MeshNode
	{
		[Token(Token = "0x20000F1")]
		public delegate void InterpolateEdge_00000834_0024PostfixBurstDelegate(ref Int3 p1, ref Int3 p2, uint fractionAlongEdge, out Int3 pos);

		[Token(Token = "0x20000F2")]
		internal static class InterpolateEdge_00000834_0024BurstDirectCall
		{
			[Token(Token = "0x4000537")]
			[FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			[Token(Token = "0x4000538")]
			[FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;

			[Token(Token = "0x6000898")]
			[Address(RVA = "0x4544200", Offset = "0x4540200", VA = "0x4544200")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
			}

			[Token(Token = "0x6000899")]
			[Address(RVA = "0x454431C", Offset = "0x454031C", VA = "0x454431C")]
			private static IntPtr GetFunctionPointer()
			{
				return default;
			}

			[Token(Token = "0x600089A")]
			[Address(RVA = "0x4544378", Offset = "0x4540378", VA = "0x4544378")]
			public static void Constructor()
			{
			}

			[Token(Token = "0x600089B")]
			[Address(RVA = "0x4544420", Offset = "0x4540420", VA = "0x4544420")]
			public static void Initialize()
			{
			}

			[Token(Token = "0x600089D")]
			[Address(RVA = "0x4541B50", Offset = "0x453DB50", VA = "0x4541B50")]
			public static void Invoke(ref Int3 p1, ref Int3 p2, uint fractionAlongEdge, out Int3 pos)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED TriangleMeshNode.InterpolateEdge_00000834_0024BurstDirectCall.Invoke RVA=0x4541B50 Token=0x600089D");
}
		}

		[Token(Token = "0x20000F3")]
		public delegate void OpenSingleEdgeBurst_00000839_0024PostfixBurstDelegate(ref Int3 s1, ref Int3 s2, ref Int3 pos, ushort pathID, uint pathNodeIndex, uint candidatePathNodeIndex, uint candidateNodeIndex, uint candidateG, float traversalCostFactor, ref UnsafeSpan<PathNode> pathNodes, ref BinaryHeap heap, ref HeuristicObjective heuristicObjective);

		[Token(Token = "0x20000F4")]
		internal static class OpenSingleEdgeBurst_00000839_0024BurstDirectCall
		{
			[Token(Token = "0x4000539")]
			[FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			[Token(Token = "0x400053A")]
			[FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;

			[Token(Token = "0x60008A2")]
			[Address(RVA = "0x4544724", Offset = "0x4540724", VA = "0x4544724")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
			}

			[Token(Token = "0x60008A3")]
			[Address(RVA = "0x4544840", Offset = "0x4540840", VA = "0x4544840")]
			private static IntPtr GetFunctionPointer()
			{
				return default;
			}

			[Token(Token = "0x60008A4")]
			[Address(RVA = "0x454489C", Offset = "0x454089C", VA = "0x454489C")]
			public static void Constructor()
			{
			}

			[Token(Token = "0x60008A5")]
			[Address(RVA = "0x4544944", Offset = "0x4540944", VA = "0x4544944")]
			public static void Initialize()
			{
			}

			[Token(Token = "0x60008A7")]
			[Address(RVA = "0x4542950", Offset = "0x453E950", VA = "0x4542950")]
			public static void Invoke(ref Int3 s1, ref Int3 s2, ref Int3 pos, ushort pathID, uint pathNodeIndex, uint candidatePathNodeIndex, uint candidateNodeIndex, uint candidateG, float traversalCostFactor, ref UnsafeSpan<PathNode> pathNodes, ref BinaryHeap heap, ref HeuristicObjective heuristicObjective)
			{
			}
		}

		[Token(Token = "0x20000F5")]
		public delegate void CalculateBestEdgePosition_0000083A_0024PostfixBurstDelegate(ref Int3 s1, ref Int3 s2, ref Int3 pos, out int3 closestPointAlongEdge, out uint quantizedFractionAlongEdge, out float cost);

		[Token(Token = "0x20000F6")]
		internal static class CalculateBestEdgePosition_0000083A_0024BurstDirectCall
		{
			[Token(Token = "0x400053B")]
			[FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			[Token(Token = "0x400053C")]
			[FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;

			[Token(Token = "0x60008AC")]
			[Address(RVA = "0x4544B5C", Offset = "0x4540B5C", VA = "0x4544B5C")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
			}

			[Token(Token = "0x60008AD")]
			[Address(RVA = "0x4544C78", Offset = "0x4540C78", VA = "0x4544C78")]
			private static IntPtr GetFunctionPointer()
			{
				return default;
			}

			[Token(Token = "0x60008AE")]
			[Address(RVA = "0x4544CD4", Offset = "0x4540CD4", VA = "0x4544CD4")]
			public static void Constructor()
			{
			}

			[Token(Token = "0x60008AF")]
			[Address(RVA = "0x4544D7C", Offset = "0x4540D7C", VA = "0x4544D7C")]
			public static void Initialize()
			{
			}

			[Token(Token = "0x60008B1")]
			[Address(RVA = "0x4542C08", Offset = "0x453EC08", VA = "0x4542C08")]
			public static void Invoke(ref Int3 s1, ref Int3 s2, ref Int3 pos, out int3 closestPointAlongEdge, out uint quantizedFractionAlongEdge, out float cost)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED TriangleMeshNode.CalculateBestEdgePosition_0000083A_0024BurstDirectCall.Invoke RVA=0x4542C08 Token=0x60008B1");
}
		}

		[Token(Token = "0x400052E")]
		public const bool InaccuratePathSearch = false;

		[Token(Token = "0x400052F")]
		[FieldOffset(Offset = "0x30")]
		public int v0;

		[Token(Token = "0x4000530")]
		[FieldOffset(Offset = "0x34")]
		public int v1;

		[Token(Token = "0x4000531")]
		[FieldOffset(Offset = "0x38")]
		public int v2;

		[Token(Token = "0x4000532")]
		[FieldOffset(Offset = "0x0")]
		private static INavmeshHolder[] _navmeshHolders;

		[Token(Token = "0x4000533")]
		[FieldOffset(Offset = "0x8")]
		private static readonly object lockObject;

		[Token(Token = "0x4000534")]
		[FieldOffset(Offset = "0x10")]
		public static readonly ProfilerMarker MarkerDecode;

		[Token(Token = "0x4000535")]
		[FieldOffset(Offset = "0x18")]
		public static readonly ProfilerMarker MarkerGetVertices;

		[Token(Token = "0x4000536")]
		[FieldOffset(Offset = "0x20")]
		public static readonly ProfilerMarker MarkerClosest;

		[Token(Token = "0x1700018E")]
		internal override int PathNodeVariants
		{
			[Token(Token = "0x600086C")]
			[Address(RVA = "0x4540124", Offset = "0x453C124", VA = "0x4540124", Slot = "4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700018F")]
		public int TileIndex
		{
			[Token(Token = "0x600086E")]
			[Address(RVA = "0x45401A8", Offset = "0x453C1A8", VA = "0x45401A8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600086A")]
		[Address(RVA = "0x45400BC", Offset = "0x453C0BC", VA = "0x45400BC")]
		public TriangleMeshNode()
		{
		}

		[Token(Token = "0x600086B")]
		[Address(RVA = "0x45400EC", Offset = "0x453C0EC", VA = "0x45400EC")]
		public TriangleMeshNode(AstarPath astar)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600086D")]
		[Address(RVA = "0x454012C", Offset = "0x453C12C", VA = "0x454012C")]
		public static INavmeshHolder GetNavmeshHolder(uint graphIndex)
		{
			return null;
		}

		[Token(Token = "0x600086F")]
		[Address(RVA = "0x45401B4", Offset = "0x453C1B4", VA = "0x45401B4")]
		public static void SetNavmeshHolder(int graphIndex, INavmeshHolder graph)
		{
		}

		[Token(Token = "0x6000870")]
		[Address(RVA = "0x45403C8", Offset = "0x453C3C8", VA = "0x45403C8")]
		public static void ClearNavmeshHolder(int graphIndex, INavmeshHolder graph)
		{
		}

		[Token(Token = "0x6000871")]
		[Address(RVA = "0x4540594", Offset = "0x453C594", VA = "0x4540594")]
		public void UpdatePositionFromVertices()
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000872")]
		[Address(RVA = "0x4540858", Offset = "0x453C858", VA = "0x4540858")]
		[IgnoredByDeepProfiler]
		public int GetVertexIndex(int i)
		{
			return default;
		}

		[Token(Token = "0x6000873")]
		[Address(RVA = "0x4540880", Offset = "0x453C880", VA = "0x4540880")]
		public int GetVertexArrayIndex(int i)
		{
			return default;
		}

		[Token(Token = "0x6000874")]
		[Address(RVA = "0x454062C", Offset = "0x453C62C", VA = "0x454062C")]
		public void GetVertices(out Int3 v0, out Int3 v1, out Int3 v2)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED TriangleMeshNode.GetVertices RVA=0x454062C Token=0x6000874");
}

		[Token(Token = "0x6000875")]
		[Address(RVA = "0x45409D8", Offset = "0x453C9D8", VA = "0x45409D8")]
		public void GetVerticesInGraphSpace(out Int3 v0, out Int3 v1, out Int3 v2)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED TriangleMeshNode.GetVerticesInGraphSpace RVA=0x45409D8 Token=0x6000875");
}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000876")]
		[Address(RVA = "0x4540C04", Offset = "0x453CC04", VA = "0x4540C04", Slot = "26")]
		[IgnoredByDeepProfiler]
		public override Int3 GetVertex(int i)
		{
			return default;
		}

		[Token(Token = "0x6000877")]
		[Address(RVA = "0x453B03C", Offset = "0x453703C", VA = "0x453B03C")]
		public Int3 GetVertexInGraphSpace(int i)
		{
			return default;
		}

		[Token(Token = "0x6000878")]
		[Address(RVA = "0x4540D64", Offset = "0x453CD64", VA = "0x4540D64", Slot = "27")]
		public override int GetVertexCount()
		{
			return default;
		}

		[Token(Token = "0x6000879")]
		[Address(RVA = "0x4540D6C", Offset = "0x453CD6C", VA = "0x4540D6C")]
		public Vector3 ProjectOnSurface(Vector3 point)
		{
			return default;
		}

		[Token(Token = "0x600087A")]
		[Address(RVA = "0x4540F74", Offset = "0x453CF74", VA = "0x4540F74", Slot = "17")]
		public override Vector3 ClosestPointOnNode(Vector3 p)
		{
			return default;
		}

		[Token(Token = "0x600087B")]
		[Address(RVA = "0x4541110", Offset = "0x453D110", VA = "0x4541110")]
		internal Int3 ClosestPointOnNodeXZInGraphSpace(Vector3 p)
		{
			return default;
		}

		[Token(Token = "0x600087C")]
		[Address(RVA = "0x4541500", Offset = "0x453D500", VA = "0x4541500", Slot = "28")]
		public override Vector3 ClosestPointOnNodeXZ(Vector3 p)
		{
			return default;
		}

		[Token(Token = "0x600087D")]
		[Address(RVA = "0x454163C", Offset = "0x453D63C", VA = "0x454163C", Slot = "19")]
		public override bool ContainsPoint(Vector3 p)
		{
			return default;
		}

		[Token(Token = "0x600087E")]
		[Address(RVA = "0x45417BC", Offset = "0x453D7BC", VA = "0x45417BC")]
		public bool ContainsPoint(Vector3 p, NativeMovementPlane movementPlane)
		{
			return default;
		}

		[Token(Token = "0x600087F")]
		[Address(RVA = "0x45418F4", Offset = "0x453D8F4", VA = "0x45418F4", Slot = "20")]
		public override bool ContainsPointInGraphSpace(Int3 p)
		{
			return default;
		}

		[Token(Token = "0x6000880")]
		[Address(RVA = "0x45419C4", Offset = "0x453D9C4", VA = "0x45419C4", Slot = "14")]
		public override Int3 DecodeVariantPosition(uint pathNodeIndex, uint fractionAlongEdge)
		{
			return default;
		}

		[Token(Token = "0x6000881")]
		[Address(RVA = "0x4541AD4", Offset = "0x453DAD4", VA = "0x4541AD4")]
		[BurstCompile(FloatMode = FloatMode.Fast)]
		private static void InterpolateEdge(ref Int3 p1, ref Int3 p2, uint fractionAlongEdge, out Int3 pos)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED TriangleMeshNode.InterpolateEdge RVA=0x4541AD4 Token=0x6000881");
}

		[Token(Token = "0x6000882")]
		[Address(RVA = "0x4541D10", Offset = "0x453DD10", VA = "0x4541D10", Slot = "13")]
		public override void OpenAtPoint(ref Path.SearchContext ctx, uint pathNodeIndex, Int3 point, uint gScore)
		{
		}

		[Token(Token = "0x6000883")]
		[Address(RVA = "0x4542568", Offset = "0x453E568", VA = "0x4542568", Slot = "12")]
		public override void Open(ref Path.SearchContext ctx, uint pathNodeIndex, uint gScore)
		{
		}

		[Token(Token = "0x6000884")]
		[Address(RVA = "0x4541D20", Offset = "0x453DD20", VA = "0x4541D20")]
		private void OpenAtPoint(ref Path.SearchContext ctx, uint pathNodeIndex, Int3 pos, int edge, uint gScore)
		{
		}

		[Token(Token = "0x6000885")]
		[Address(RVA = "0x45426C0", Offset = "0x453E6C0", VA = "0x45426C0")]
		private void OpenSingleEdge(ref Path.SearchContext ctx, uint pathNodeIndex, TriangleMeshNode other, int sharedEdgeOnOtherNode, Int3 pos, uint gScore, float traversalCostFactor)
		{
		}

		[Token(Token = "0x6000886")]
		[Address(RVA = "0x4542848", Offset = "0x453E848", VA = "0x4542848")]
		[BurstCompile]
		private static void OpenSingleEdgeBurst(ref Int3 s1, ref Int3 s2, ref Int3 pos, ushort pathID, uint pathNodeIndex, uint candidatePathNodeIndex, uint candidateNodeIndex, uint candidateG, float traversalCostFactor, ref UnsafeSpan<PathNode> pathNodes, ref BinaryHeap heap, ref HeuristicObjective heuristicObjective)
		{
		}

		[Token(Token = "0x6000887")]
		[Address(RVA = "0x4542B74", Offset = "0x453EB74", VA = "0x4542B74")]
		[BurstCompile]
		private static void CalculateBestEdgePosition(ref Int3 s1, ref Int3 s2, ref Int3 pos, out int3 closestPointAlongEdge, out uint quantizedFractionAlongEdge, out float cost)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED TriangleMeshNode.CalculateBestEdgePosition RVA=0x4542B74 Token=0x6000887");
}

		[Token(Token = "0x6000888")]
		[Address(RVA = "0x4542D30", Offset = "0x453ED30", VA = "0x4542D30")]
		public int SharedEdge(GraphNode other)
		{
			return default;
		}

		[Token(Token = "0x6000889")]
		[Address(RVA = "0x4542DDC", Offset = "0x453EDDC", VA = "0x4542DDC", Slot = "11")]
		public override bool GetPortal(GraphNode toNode, out Vector3 left, out Vector3 right)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED TriangleMeshNode.GetPortal RVA=0x4542DDC Token=0x6000889");
}

		[Token(Token = "0x600088A")]
		[Address(RVA = "0x45430D0", Offset = "0x453F0D0", VA = "0x45430D0")]
		public bool GetPortalInGraphSpace(TriangleMeshNode toNode, out Int3 a, out Int3 b, out int aIndex, out int bIndex)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED TriangleMeshNode.GetPortalInGraphSpace RVA=0x45430D0 Token=0x600088A");
}

		[Token(Token = "0x600088B")]
		[Address(RVA = "0x4542DFC", Offset = "0x453EDFC", VA = "0x4542DFC")]
		public bool GetPortal(GraphNode toNode, out Vector3 left, out Vector3 right, out int aIndex, out int bIndex)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED TriangleMeshNode.GetPortal RVA=0x4542DFC Token=0x600088B");
}

		[Token(Token = "0x600088C")]
		[Address(RVA = "0x45435E4", Offset = "0x453F5E4", VA = "0x45435E4", Slot = "15")]
		public override float SurfaceArea()
		{
			return default;
		}

		[Token(Token = "0x600088D")]
		[Address(RVA = "0x454386C", Offset = "0x453F86C", VA = "0x454386C", Slot = "16")]
		public override Vector3 RandomPointOnSurface()
		{
			return default;
		}

		[Token(Token = "0x600088E")]
		[Address(RVA = "0x45439D8", Offset = "0x453F9D8", VA = "0x45439D8", Slot = "22")]
		public override void SerializeNode(GraphSerializationContext ctx)
		{
		}

		[Token(Token = "0x600088F")]
		[Address(RVA = "0x4543A54", Offset = "0x453FA54", VA = "0x4543A54", Slot = "23")]
		public override void DeserializeNode(GraphSerializationContext ctx)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000891")]
		[Address(RVA = "0x4543C28", Offset = "0x453FC28", VA = "0x4543C28")]
		[BurstCompile(FloatMode = FloatMode.Fast)]
		public static void InterpolateEdge_0024BurstManaged(ref Int3 p1, ref Int3 p2, uint fractionAlongEdge, out Int3 pos)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED TriangleMeshNode.InterpolateEdge_0024BurstManaged RVA=0x4543C28 Token=0x6000891");
}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000892")]
		[Address(RVA = "0x4543D24", Offset = "0x453FD24", VA = "0x4543D24")]
		[BurstCompile]
		public static void OpenSingleEdgeBurst_0024BurstManaged(ref Int3 s1, ref Int3 s2, ref Int3 pos, ushort pathID, uint pathNodeIndex, uint candidatePathNodeIndex, uint candidateNodeIndex, uint candidateG, float traversalCostFactor, ref UnsafeSpan<PathNode> pathNodes, ref BinaryHeap heap, ref HeuristicObjective heuristicObjective)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000893")]
		[Address(RVA = "0x4543E6C", Offset = "0x453FE6C", VA = "0x4543E6C")]
		[BurstCompile]
		public static void CalculateBestEdgePosition_0024BurstManaged(ref Int3 s1, ref Int3 s2, ref Int3 pos, out int3 closestPointAlongEdge, out uint quantizedFractionAlongEdge, out float cost)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED TriangleMeshNode.CalculateBestEdgePosition_0024BurstManaged RVA=0x4543E6C Token=0x6000893");
}
	}
}
