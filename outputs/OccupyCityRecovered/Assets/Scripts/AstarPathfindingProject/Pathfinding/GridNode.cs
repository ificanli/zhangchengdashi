using Il2CppDummyDll;
using Pathfinding.Serialization;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x20000EB")]
	public class GridNode : GridNodeBase
	{
		[Token(Token = "0x4000510")]
		[FieldOffset(Offset = "0x0")]
		private static GridGraph[] _gridGraphs = new GridGraph[0];

		[Token(Token = "0x4000511")]
		private const int GridFlagsConnectionOffset = 0;

		[Token(Token = "0x4000512")]
		private const int GridFlagsConnectionBit0 = 1;

		[Token(Token = "0x4000513")]
		private const int GridFlagsConnectionMask = 255;

		[Token(Token = "0x4000514")]
		private const int GridFlagsAxisAlignedConnectionMask = 15;

		[Token(Token = "0x4000515")]
		private const int GridFlagsEdgeNodeOffset = 10;

		[Token(Token = "0x4000516")]
		private const int GridFlagsEdgeNodeMask = 1024;

		[Token(Token = "0x1700017C")]
		internal ushort InternalGridFlags
		{
			[Token(Token = "0x60007F8")]
			[Address(RVA = "0x453B57C", Offset = "0x453757C", VA = "0x453B57C")]
			get
			{
				return default;
			}
			[Token(Token = "0x60007F9")]
			[Address(RVA = "0x453B584", Offset = "0x4537584", VA = "0x453B584")]
			set
			{
			}
		}

		[Token(Token = "0x1700017D")]
		public override bool HasConnectionsToAllEightNeighbours
		{
			[Token(Token = "0x60007FA")]
			[Address(RVA = "0x453B58C", Offset = "0x453758C", VA = "0x453B58C", Slot = "26")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700017E")]
		public override bool HasConnectionsToAllAxisAlignedNeighbours
		{
			[Token(Token = "0x60007FB")]
			[Address(RVA = "0x453B5A0", Offset = "0x45375A0", VA = "0x453B5A0", Slot = "27")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700017F")]
		public override bool HasAnyGridConnections
		{
			[Token(Token = "0x6000801")]
			[Address(RVA = "0x453B7B0", Offset = "0x45377B0", VA = "0x453B7B0", Slot = "30")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000180")]
		public bool EdgeNode
		{
			[Token(Token = "0x6000803")]
			[Address(RVA = "0x453B840", Offset = "0x4537840", VA = "0x453B840")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000804")]
			[Address(RVA = "0x453B84C", Offset = "0x453784C", VA = "0x453B84C")]
			set
			{
			}
		}

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x453B19C", Offset = "0x453719C", VA = "0x453B19C")]
		public GridNode()
		{}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x453B1FC", Offset = "0x45371FC", VA = "0x453B1FC")]
		public GridNode(AstarPath astar)
		{ astar.InitializeNode(this); }

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x453B278", Offset = "0x4537278", VA = "0x453B278")]
		public static GridGraph GetGridGraph(uint graphIndex)
		{ return _gridGraphs[graphIndex]; }

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0x453B2F4", Offset = "0x45372F4", VA = "0x453B2F4")]
		public static void SetGridGraph(int graphIndex, GridGraph graph)
		{
 if (_gridGraphs.Length <= graphIndex) {
  var graphs = new GridGraph[unchecked(graphIndex + 1)];
  for (int i = 0; i < _gridGraphs.Length; i++) graphs[i] = _gridGraphs[i];
  _gridGraphs = graphs;
 }
 _gridGraphs[graphIndex] = graph;
}

		[Token(Token = "0x60007F7")]
		[Address(RVA = "0x453B490", Offset = "0x4537490", VA = "0x453B490")]
		public static void ClearGridGraph(int graphIndex, GridGraph graph)
		{
		}

		[Token(Token = "0x60007FC")]
		[Address(RVA = "0x453B5B4", Offset = "0x45375B4", VA = "0x453B5B4", Slot = "29")]
		public override bool HasConnectionInDirection(int dir)
		{ return ((gridFlags >> dir) & 1) != 0; }

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0x453B5C4", Offset = "0x45375C4", VA = "0x453B5C4")]
		public void SetConnection(int dir, bool value)
		{
		}

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0x453B664", Offset = "0x4537664", VA = "0x453B664")]
		public void SetConnectionInternal(int dir, bool value)
		{
		}

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0x453B724", Offset = "0x4537724", VA = "0x453B724")]
		public void SetAllConnectionInternal(int connections)
		{ gridFlags=unchecked((ushort)((gridFlags&0xff00)|connections)); AstarPath.active.hierarchicalGraph.AddDirtyNode(this); }

		[Token(Token = "0x6000800")]
		[Address(RVA = "0x453B71C", Offset = "0x453771C", VA = "0x453B71C")]
		public int GetAllConnectionInternal()
		{ return gridFlags&255; }

		[Token(Token = "0x6000802")]
		[Address(RVA = "0x453B7C0", Offset = "0x45377C0", VA = "0x453B7C0", Slot = "31")]
		public override void ResetConnectionsInternal()
		{ gridFlags=unchecked((ushort)(gridFlags&0xff00));AstarPath.active.hierarchicalGraph.AddDirtyNode(this); }

		[Token(Token = "0x6000805")]
		[Address(RVA = "0x453B87C", Offset = "0x453787C", VA = "0x453B87C", Slot = "28")]
		public override GridNodeBase GetNeighbourAlongDirection(int direction)
		{ if (!HasConnectionInDirection(direction)) return null; GridGraph graph=GetGridGraph(GraphIndex); return graph.nodes[unchecked(NodeInGridIndex + graph.neighbourOffsets[direction])]; }

		[Token(Token = "0x6000806")]
		[Address(RVA = "0x453B950", Offset = "0x4537950", VA = "0x453B950", Slot = "9")]
		public override void ClearConnections(bool alsoReverse)
		{
 if (alsoReverse) for (int i=0;i<8;i++) {
  var node=GetNeighbourAlongDirection(i) as GridNode;
  if (node!=null) node.SetConnectionInternal(i<4?(i+2)&3:((i-2)&3)+4,false);
 }
 ResetConnectionsInternal();ClearCustomConnections(false);
}

		[Token(Token = "0x6000807")]
		public override void GetConnections<T>(NodeActionWithData<T> action, ref T data, int connectionFilter)
		{
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0x453BAC4", Offset = "0x4537AC4", VA = "0x453BAC4", Slot = "11")]
		public override bool GetPortal(GraphNode other, out Vector3 left, out Vector3 right)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED GridNode.GetPortal RVA=0x453BAC4 Token=0x6000808");
}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0x453C0FC", Offset = "0x45380FC", VA = "0x453C0FC")]
		public static int FilterDiagonalConnections(int conns, NumNeighbours neighbours, bool cutCorners)
		{
 if (neighbours==NumNeighbours.Six) return conns&0xaf;
 if (neighbours==NumNeighbours.Four) return conns&0xf;
 int cardinal=conns&0xf;
 int rotated=unchecked((cardinal<<3)|(int)(((uint)conns>>1)&7));
 int allowed=cutCorners?rotated|cardinal:rotated&cardinal;
 return unchecked((conns&(allowed<<4))|cardinal);
}

		[Token(Token = "0x600080A")]
		[Address(RVA = "0x453C144", Offset = "0x4538144", VA = "0x453C144", Slot = "12")]
		public override void Open(ref Path.SearchContext ctx, uint pathNodeIndex, uint gScore)
		{
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0x453C82C", Offset = "0x453882C", VA = "0x453C82C", Slot = "22")]
		public override void SerializeNode(GraphSerializationContext ctx)
		{
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0x453C884", Offset = "0x4538884", VA = "0x453C884", Slot = "23")]
		public override void DeserializeNode(GraphSerializationContext ctx)
		{
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0x453C8E0", Offset = "0x45388E0", VA = "0x453C8E0", Slot = "7")]
		public override void AddPartialConnection(GraphNode node, uint cost, bool isOutgoing, bool isIncoming)
		{
		}

		[Token(Token = "0x600080E")]
		[Address(RVA = "0x453CCDC", Offset = "0x4538CDC", VA = "0x453CCDC", Slot = "8")]
		public override void RemovePartialConnection(GraphNode node)
		{
		}

		[Token(Token = "0x600080F")]
		[Address(RVA = "0x453C9A4", Offset = "0x45389A4", VA = "0x453C9A4")]
		protected void RemoveGridConnection(GridNode node)
		{
		}
	}
}
