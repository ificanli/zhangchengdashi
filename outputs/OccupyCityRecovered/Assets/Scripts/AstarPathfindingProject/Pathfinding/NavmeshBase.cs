using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Pathfinding.Collections;
using Pathfinding.Drawing;
using Pathfinding.Graphs.Navmesh;
using Pathfinding.Serialization;
using Pathfinding.Util;
using Unity.Burst;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x20000E1")]
	[BurstCompile]
	public abstract class NavmeshBase : NavGraph, INavmeshHolder, ITransformedGraph, IRaycastableGraph
	{
		[Token(Token = "0x40004D0")]
		public const int VertexIndexMask = 4095;

		[Token(Token = "0x40004D1")]
		public const int TileIndexMask = 524287;

		[Token(Token = "0x40004D2")]
		public const int TileIndexOffset = 12;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[JsonMember]
		public Vector3 forcedBoundsSize;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[JsonMember]
		public bool showMeshOutline;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
		[JsonMember]
		public bool showNodeConnections;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5E")]
		[JsonMember]
		public bool showMeshSurface;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public int tileXCount;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int tileZCount;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		protected NavmeshTile[] tiles;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[JsonMember]
		[Obsolete("Set the appropriate fields on the NearestNodeConstraint instead")]
		public bool nearestSearchOnlyXZ;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		[JsonMember]
		public bool enableNavmeshCutting;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public NavmeshUpdates.NavmeshUpdateSettings navmeshUpdateData;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int batchTileUpdate;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private bool batchPendingNavmeshCutting;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private List<int> batchUpdatedTiles;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private List<MeshNode> batchNodesToDestroy;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public GraphTransform transform;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Action<NavmeshTile[]> OnRecalculatedTiles;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Dictionary<int, int> nodeRecyclingHashBuffer;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly byte[] LinecastShapeEdgeLookup;

		[Token(Token = "0x1700016D")]
		public abstract float NavmeshCuttingCharacterRadius
		{
			[Token(Token = "0x6000786")]
			get;
		}

		[Token(Token = "0x1700016E")]
		public abstract float TileWorldSizeX
		{
			[Token(Token = "0x6000787")]
			get;
		}

		[Token(Token = "0x1700016F")]
		public abstract float TileWorldSizeZ
		{
			[Token(Token = "0x6000788")]
			get;
		}

		[Token(Token = "0x17000170")]
		public abstract float MaxTileConnectionEdgeDistance
		{
			[Token(Token = "0x6000789")]
			get;
		}

		[Token(Token = "0x17000171")]
GraphTransform ITransformedGraph.transform
		{
			[Token(Token = "0x600078A")]
			[Address(RVA = "0x452F8D0", Offset = "0x452B8D0", VA = "0x452F8D0", Slot = "41")]
			get
			{
				return Pathfinding_002EITransformedGraph_002Eget_transform();
			}
		}

		[Token(Token = "0x17000172")]
		public abstract bool RecalculateNormals
		{
			[Token(Token = "0x600078B")]
			get;
		}

		[Token(Token = "0x17000173")]
		public override bool isScanned
		{
			[Token(Token = "0x600078C")]
			[Address(RVA = "0x452F8D8", Offset = "0x452B8D8", VA = "0x452F8D8", Slot = "13")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0x452F8D0", Offset = "0x452B8D0", VA = "0x452F8D0", Slot = "41")]
		private GraphTransform Pathfinding_002EITransformedGraph_002Eget_transform()
		{
			return null;
		}

		[Token(Token = "0x600078D")]
		public abstract GraphTransform CalculateTransform();

		[Token(Token = "0x600078E")]
		[Address(RVA = "0x452F8E8", Offset = "0x452B8E8", VA = "0x452F8E8")]
		public NavmeshTile GetTile(int x, int z)
		{
			return null;
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0x452F920", Offset = "0x452B920", VA = "0x452F920", Slot = "37")]
		public Int3 GetVertex(int index)
		{
			return default;
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0x452F964", Offset = "0x452B964", VA = "0x452F964", Slot = "38")]
		public Int3 GetVertexInGraphSpace(int index)
		{
			return default;
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0x452F9A8", Offset = "0x452B9A8", VA = "0x452F9A8")]
		public static int GetTileIndex(int index)
		{
			return default;
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0x452F9B0", Offset = "0x452B9B0", VA = "0x452F9B0", Slot = "39")]
		public int GetVertexArrayIndex(int index)
		{
			return default;
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0x452F9B8", Offset = "0x452B9B8", VA = "0x452F9B8", Slot = "40")]
		public void GetTileCoordinates(int tileIndex, out int x, out int z)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED NavmeshBase.GetTileCoordinates RVA=0x452F9B8 Token=0x6000793");
}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0x452F9D4", Offset = "0x452B9D4", VA = "0x452F9D4")]
		public NavmeshTile[] GetTiles()
		{
			return null;
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0x452F9DC", Offset = "0x452B9DC", VA = "0x452F9DC")]
		public Bounds GetTileBounds(IntRect rect)
		{
			return default;
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0x452FA5C", Offset = "0x452BA5C", VA = "0x452FA5C")]
		public Bounds GetTileBounds(int x, int z, int width = 1, int depth = 1)
		{
			return default;
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0x452FBC4", Offset = "0x452BBC4", VA = "0x452FBC4")]
		public Bounds GetTileBoundsInGraphSpace(IntRect rect)
		{
			return default;
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0x452FAC4", Offset = "0x452BAC4", VA = "0x452FAC4")]
		public Bounds GetTileBoundsInGraphSpace(int x, int z, int width = 1, int depth = 1)
		{
			return default;
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0x452FC44", Offset = "0x452BC44", VA = "0x452FC44")]
		public Vector2Int GetTileCoordinates(Vector3 position)
		{
			return default;
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0x452FCD8", Offset = "0x452BCD8", VA = "0x452FCD8", Slot = "26")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0x452FD60", Offset = "0x452BD60", VA = "0x452FD60", Slot = "27")]
		protected override void DisposeUnmanagedData()
		{
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0x452FD7C", Offset = "0x452BD7C", VA = "0x452FD7C", Slot = "28")]
		protected override void DestroyAllNodes()
		{
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0x452FF54", Offset = "0x452BF54", VA = "0x452FF54", Slot = "22")]
		public override void RelocateNodes(Matrix4x4 deltaMatrix)
		{
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0x452FFA0", Offset = "0x452BFA0", VA = "0x452FFA0")]
		public void RelocateNodes(GraphTransform newTransform)
		{
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0x4530124", Offset = "0x452C124", VA = "0x4530124")]
		protected NavmeshTile NewEmptyTile(int x, int z)
		{
			return null;
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x45301E0", Offset = "0x452C1E0", VA = "0x45301E0", Slot = "18")]
		public override void GetNodes(Action<GraphNode> action)
		{
		}

		[Token(Token = "0x60007A1")]
		public override void GetNodes<T>(GraphNode.NodeActionWithData<T> action, ref T data)
		{
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x45302B0", Offset = "0x452C2B0", VA = "0x45302B0")]
		public IntRect GetTouchingTiles(Bounds bounds, float margin = 0f)
		{
			return default;
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x453055C", Offset = "0x452C55C", VA = "0x453055C")]
		public IntRect GetTouchingTilesInGraphSpace(Rect rect)
		{
			return default;
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x453076C", Offset = "0x452C76C", VA = "0x453076C")]
		protected void ConnectTileWithNeighbours(NavmeshTile tile, bool onlyUnflagged = false)
		{
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x453158C", Offset = "0x452D58C", VA = "0x453158C", Slot = "23")]
		public override float NearestNodeDistanceSqrLowerBound(Vector3 position, ref NearestNodeConstraint constraint)
		{
			return default;
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x45316F0", Offset = "0x452D6F0", VA = "0x45316F0", Slot = "24")]
		public override NNInfo GetNearest(Vector3 position, ref NearestNodeConstraint constraint)
		{
			return default;
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x4531BA4", Offset = "0x452DBA4", VA = "0x4531BA4", Slot = "25")]
		public override NNInfo RandomPointOnSurface(NearestNodeConstraint constraint, bool highQuality = true)
		{
			return default;
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x4531D90", Offset = "0x452DD90", VA = "0x4531D90")]
		[Obsolete("Use the overload that takes a NearestNodeConstraint instead. See the migration guide for version 5.4 for more details.")]
		public GraphNode PointOnNavmesh(Vector3 position, NNConstraint constraint)
		{
			return null;
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x4531E10", Offset = "0x452DE10", VA = "0x4531E10")]
		public GraphNode PointOnNavmesh(Vector3 position, NearestNodeConstraint constraint)
		{
			return null;
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x4531EDC", Offset = "0x452DEDC", VA = "0x4531EDC")]
		protected void FillWithEmptyTiles()
		{
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x4531FE0", Offset = "0x452DFE0", VA = "0x4531FE0")]
		protected static void CreateNodeConnections(TriangleMeshNode[] nodes, bool keepExistingConnections)
		{
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x4530958", Offset = "0x452C958", VA = "0x4530958")]
		internal static void ConnectTiles(NavmeshTile tile1, NavmeshTile tile2, float tileWorldSizeX, float tileWorldSizeZ, float maxTileConnectionEdgeDistance)
		{
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x45325AC", Offset = "0x452E5AC", VA = "0x45325AC")]
		public void StartBatchTileUpdate(bool exclusive = false)
		{
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x453262C", Offset = "0x452E62C", VA = "0x453262C")]
		private static void DestroyNodes(List<MeshNode> nodes)
		{
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x45327D4", Offset = "0x452E7D4", VA = "0x45327D4")]
		private void TryConnect(int tileIdx1, int tileIdx2)
		{
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x4532918", Offset = "0x452E918", VA = "0x4532918")]
		public void EndBatchTileUpdate()
		{
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x4532D30", Offset = "0x452ED30", VA = "0x4532D30")]
		public void ClearTiles(IntRect tileRect)
		{
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x4532E20", Offset = "0x452EE20", VA = "0x4532E20")]
		protected void ClearTile(int x, int z, NavmeshTile replacement)
		{
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x4532FDC", Offset = "0x452EFDC", VA = "0x4532FDC")]
		private void PrepareNodeRecycling(int x, int z, UnsafeSpan<Int3> verts, UnsafeSpan<int> tris, TriangleMeshNode[] recycledNodeBuffer)
		{
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x45336F0", Offset = "0x452F6F0", VA = "0x45336F0")]
		public void ReplaceTile(int x, int z, Int3[] verts, int[] tris, [Optional] uint[] tags, bool tryPreserveExistingTagsAndPenalties = true)
		{
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x45338D8", Offset = "0x452F8D8", VA = "0x45338D8")]
		public void ReplaceTile(int x, int z, UnsafeSpan<Int3> verts, UnsafeSpan<int> tris, UnsafeSpan<uint> tags, bool tryPreserveExistingTagsAndPenalties = true)
		{
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x4533C3C", Offset = "0x452FC3C", VA = "0x4533C3C")]
		internal void ReplaceTilePostCut(int x, int z, UnsafeSpan<Int3> verts, UnsafeSpan<int> tris, UnsafeSpan<uint> tags, bool tryPreserveExistingTagsAndPenalties = true, bool preservePreCutData = false)
		{
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x4534910", Offset = "0x4530910", VA = "0x4534910")]
		internal static void CreateNodes(NavmeshTile tile, UnsafeSpan<int> tris, int tileIndex, uint graphIndex, UnsafeSpan<uint> tags, bool initializeNodes, AstarPath astar, uint initialPenalty, bool tryPreserveExistingTagsAndPenalties)
		{
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x4534D00", Offset = "0x4530D00", VA = "0x4534D00")]
		public NavmeshBase()
		{
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x4534EA8", Offset = "0x4530EA8", VA = "0x4534EA8", Slot = "42")]
		public bool Linecast(Vector3 start, Vector3 end)
		{
			return default;
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x4534FCC", Offset = "0x4530FCC", VA = "0x4534FCC", Slot = "44")]
		public bool Linecast(Vector3 start, Vector3 end, GraphNode hint, out GraphHitInfo hit)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED NavmeshBase.Linecast RVA=0x4534FCC Token=0x60007BA");
}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x4534EB0", Offset = "0x4530EB0", VA = "0x4534EB0", Slot = "43")]
		public bool Linecast(Vector3 start, Vector3 end, GraphNode hint)
		{
			return default;
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x4535D98", Offset = "0x4531D98", VA = "0x4535D98", Slot = "46")]
		public bool Linecast(Vector3 start, Vector3 end, GraphNode hint, out GraphHitInfo hit, List<GraphNode> trace)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED NavmeshBase.Linecast RVA=0x4535D98 Token=0x60007BC");
}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x4535EB4", Offset = "0x4531EB4", VA = "0x4535EB4", Slot = "48")]
		public bool Linecast(Vector3 start, Vector3 end, out GraphHitInfo hit, ref TraversalConstraint traversalConstraint, List<GraphNode> trace)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED NavmeshBase.Linecast RVA=0x4535EB4 Token=0x60007BD");
}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x4535F7C", Offset = "0x4531F7C", VA = "0x4535F7C", Slot = "45")]
		public bool Linecast(Vector3 start, Vector3 end, GraphNode hint, out GraphHitInfo hit, ref TraversalConstraint traversalConstraint, List<GraphNode> trace)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED NavmeshBase.Linecast RVA=0x4535F7C Token=0x60007BE");
}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x4536048", Offset = "0x4532048", VA = "0x4536048")]
		public static bool Linecast(NavmeshBase graph, Vector3 start, Vector3 end, GraphNode hint, out GraphHitInfo hit)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED NavmeshBase.Linecast RVA=0x4536048 Token=0x60007BF");
}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x4536158", Offset = "0x4532158", VA = "0x4536158")]
		static NavmeshBase()
		{
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x45350DC", Offset = "0x45310DC", VA = "0x45350DC")]
		public static bool Linecast(NavmeshBase graph, Vector3 origin, Vector3 end, GraphNode hint, out GraphHitInfo hit, ref TraversalConstraint traversalConstraint, List<GraphNode> trace)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED NavmeshBase.Linecast RVA=0x45350DC Token=0x60007C1");
}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x4536504", Offset = "0x4532504", VA = "0x4536504", Slot = "50")]
		[Obsolete("Use the overload that takes a TraversalConstraint instead. See the migration guide for version 5.4 for more information.")]
		public bool Linecast(Vector3 start, Vector3 end, out GraphHitInfo hit, List<GraphNode> trace, Func<GraphNode, bool> filter)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED NavmeshBase.Linecast RVA=0x4536504 Token=0x60007C2");
}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x4536630", Offset = "0x4532630", VA = "0x4536630", Slot = "51")]
		[Obsolete("Use the overload that takes a TraversalConstraint instead. See the migration guide for version 5.4 for more information.")]
		public bool Linecast(Vector3 start, Vector3 end, GraphNode hint, out GraphHitInfo hit, List<GraphNode> trace, Func<GraphNode, bool> filter)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED NavmeshBase.Linecast RVA=0x4536630 Token=0x60007C3");
}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x4536760", Offset = "0x4532760", VA = "0x4536760")]
		[Obsolete("Use the overload that takes a TraversalConstraint instead. See the migration guide for version 5.4 for more information.")]
		public static bool Linecast(NavmeshBase graph, Vector3 origin, Vector3 end, GraphNode hint, out GraphHitInfo hit, List<GraphNode> trace, [Optional] Func<GraphNode, bool> filter)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED NavmeshBase.Linecast RVA=0x4536760 Token=0x60007C4");
}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x4536364", Offset = "0x4532364", VA = "0x4536364")]
		private static bool FindNodeAroundVertex(TriangleMeshNode node, TriangleMeshNode targetNode, Int3 vertexInGraphSpace, bool oppositeDirection)
		{
			return default;
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x4536890", Offset = "0x4532890", VA = "0x4536890", Slot = "35")]
		public override void OnDrawGizmos(DrawingData gizmos, bool drawNodes, RedrawScope redrawScope, bool renderInGame)
		{
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x4537094", Offset = "0x4533094", VA = "0x4537094")]
		private void CreateNavmeshSurfaceVisualization(NavmeshTile[] tiles, int startTile, int endTile, GraphGizmoHelper helper)
		{
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x45374CC", Offset = "0x45334CC", VA = "0x45374CC")]
		private static void CreateNavmeshOutlineVisualization(NavmeshTile[] tiles, int startTile, int endTile, GraphGizmoHelper helper)
		{
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x45378B4", Offset = "0x45338B4", VA = "0x45378B4", Slot = "32")]
		protected override void SerializeExtraInfo(GraphSerializationContext ctx)
		{
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x4537EB8", Offset = "0x4533EB8", VA = "0x4537EB8", Slot = "33")]
		protected override void DeserializeExtraInfo(GraphSerializationContext ctx)
		{
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x453865C", Offset = "0x453465C", VA = "0x453865C", Slot = "34")]
		protected override void PostDeserialization(GraphSerializationContext ctx)
		{
		}
	}
}
