using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Pathfinding.Serialization;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x20000EC")]
	public abstract class GridNodeBase : GraphNode
	{
		[Token(Token = "0x4000517")]
		private const int GridFlagsWalkableErosionOffset = 8;

		[Token(Token = "0x4000518")]
		private const int GridFlagsWalkableErosionMask = 256;

		[Token(Token = "0x4000519")]
		private const int GridFlagsWalkableTmpOffset = 9;

		[Token(Token = "0x400051A")]
		private const int GridFlagsWalkableTmpMask = 512;

		[Token(Token = "0x400051B")]
		public const int NodeInGridIndexLayerOffset = 24;

		[Token(Token = "0x400051C")]
		protected const int NodeInGridIndexMask = 16777215;

		[Token(Token = "0x400051D")]
		[FieldOffset(Offset = "0x28")]
		protected int nodeInGridIndex;

		[Token(Token = "0x400051E")]
		[FieldOffset(Offset = "0x2C")]
		protected ushort gridFlags;

		[Token(Token = "0x400051F")]
		[FieldOffset(Offset = "0x30")]
		public Connection[] connections;

		[Token(Token = "0x4000520")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly int[] offsetToDirection = new int[] { 7,0,4,3,-1,1,6,2,5 };

		[Token(Token = "0x17000181")]
		public int NodeInGridIndex
		{
			[Token(Token = "0x6000811")]
			[Address(RVA = "0x453B710", Offset = "0x4537710", VA = "0x453B710")]
			get
			{ return nodeInGridIndex&0x00ffffff; }
			[Token(Token = "0x6000812")]
			[Address(RVA = "0x453CF7C", Offset = "0x4538F7C", VA = "0x453CF7C")]
			set
			{ nodeInGridIndex=unchecked(value|(nodeInGridIndex&(int)0xff000000u)); }
		}

		[Token(Token = "0x17000182")]
		public int XCoordinateInGrid
		{
			[Token(Token = "0x6000813")]
			[Address(RVA = "0x453CF8C", Offset = "0x4538F8C", VA = "0x453CF8C")]
			get
			{ int index=NodeInGridIndex; int graphWidth=GridNode.GetGridGraph(GraphIndex).width; return graphWidth == 0 ? index : index % graphWidth; }
		}

		[Token(Token = "0x17000183")]
		public int ZCoordinateInGrid
		{
			[Token(Token = "0x6000814")]
			[Address(RVA = "0x453D004", Offset = "0x4539004", VA = "0x453D004")]
			get
			{ int index=NodeInGridIndex; int graphWidth=GridNode.GetGridGraph(GraphIndex).width; return graphWidth == 0 ? 0 : index / graphWidth; }
		}

		[Token(Token = "0x17000184")]
		public Vector2Int CoordinatesInGrid
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x6000815")]
			[Address(RVA = "0x453D078", Offset = "0x4539078", VA = "0x453D078")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000185")]
		public bool WalkableErosion
		{
			[Token(Token = "0x6000816")]
			[Address(RVA = "0x453D0F4", Offset = "0x45390F4", VA = "0x453D0F4")]
			get
			{ return (gridFlags&256)!=0; }
			[Token(Token = "0x6000817")]
			[Address(RVA = "0x453D100", Offset = "0x4539100", VA = "0x453D100")]
			set
			{ gridFlags=unchecked((ushort)((gridFlags&0xfeff)|(value?256:0))); }
		}

		[Token(Token = "0x17000186")]
		public bool TmpWalkable
		{
			[Token(Token = "0x6000818")]
			[Address(RVA = "0x453D130", Offset = "0x4539130", VA = "0x453D130")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000819")]
			[Address(RVA = "0x453D13C", Offset = "0x453913C", VA = "0x453D13C")]
			set
			{
			}
		}

		[Token(Token = "0x17000187")]
		public abstract bool HasConnectionsToAllEightNeighbours
		{
			[Token(Token = "0x600081A")]
			get;
		}

		[Token(Token = "0x17000188")]
		public abstract bool HasConnectionsToAllAxisAlignedNeighbours
		{
			[Token(Token = "0x600081B")]
			get;
		}

		[Token(Token = "0x17000189")]
		public abstract bool HasAnyGridConnections
		{
			[Token(Token = "0x6000829")]
			get;
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0x453BA7C", Offset = "0x4537A7C", VA = "0x453BA7C")]
		public static int OppositeConnectionDirection(int dir)
		{
			return default;
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0x453C058", Offset = "0x4538058", VA = "0x453C058")]
		public static int OffsetToConnectionDirection(int dx, int dz)
		{
			return default;
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0x453D16C", Offset = "0x453916C", VA = "0x453D16C")]
		public Vector3 ProjectOnSurface(Vector3 point)
		{
			return default;
		}

		[Token(Token = "0x600081F")]
		[Address(RVA = "0x453D260", Offset = "0x4539260", VA = "0x453D260", Slot = "17")]
		public override Vector3 ClosestPointOnNode(Vector3 p)
		{
			return default;
		}

		[Token(Token = "0x6000820")]
		[Address(RVA = "0x453D370", Offset = "0x4539370", VA = "0x453D370", Slot = "19")]
		public override bool ContainsPoint(Vector3 point)
		{
			return default;
		}

		[Token(Token = "0x6000821")]
		[Address(RVA = "0x453D448", Offset = "0x4539448", VA = "0x453D448", Slot = "20")]
		public override bool ContainsPointInGraphSpace(Int3 point)
		{
			return default;
		}

		[Token(Token = "0x6000822")]
		[Address(RVA = "0x453D4B8", Offset = "0x45394B8", VA = "0x453D4B8", Slot = "15")]
		public override float SurfaceArea()
		{
			return default;
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0x453D524", Offset = "0x4539524", VA = "0x453D524", Slot = "16")]
		public override Vector3 RandomPointOnSurface()
		{
			return default;
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0x453D638", Offset = "0x4539638", VA = "0x453D638")]
		public Vector2 NormalizePoint(Vector3 worldPoint)
		{
			return default;
		}

		[Token(Token = "0x6000825")]
		[Address(RVA = "0x453D700", Offset = "0x4539700", VA = "0x453D700")]
		public Vector3 UnNormalizePoint(Vector2 normalizedPointOnSurface)
		{
			return default;
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0x453D7D4", Offset = "0x45397D4", VA = "0x453D7D4", Slot = "21")]
		public override int GetGizmoHashCode()
		{
			return default;
		}

		[Token(Token = "0x6000827")]
		public abstract GridNodeBase GetNeighbourAlongDirection(int direction);

		[Token(Token = "0x6000828")]
		[Address(RVA = "0x453D864", Offset = "0x4539864", VA = "0x453D864", Slot = "29")]
		public virtual bool HasConnectionInDirection(int direction)
		{
			return default;
		}

		[Token(Token = "0x600082A")]
		[Address(RVA = "0x453D888", Offset = "0x4539888", VA = "0x453D888", Slot = "10")]
		public override bool ContainsOutgoingConnection(GraphNode node)
		{
			return default;
		}

		[Token(Token = "0x600082B")]
		public abstract void ResetConnectionsInternal();

		[Token(Token = "0x600082C")]
		[Address(RVA = "0x453D940", Offset = "0x4539940", VA = "0x453D940", Slot = "13")]
		public override void OpenAtPoint(ref Path.SearchContext ctx, uint pathNodeIndex, Int3 pos, uint gScore)
		{
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0x453C64C", Offset = "0x453864C", VA = "0x453C64C", Slot = "12")]
		public override void Open(ref Path.SearchContext ctx, uint pathNodeIndex, uint gScore)
		{
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0x453D9B8", Offset = "0x45399B8", VA = "0x453D9B8")]
		public void ClearCustomConnections(bool alsoReverse)
		{
 if (connections!=null) {
  for (int i=0;i<connections.Length;i++) connections[i].node.RemovePartialConnection(this);
  connections=null;AstarPath.active.hierarchicalGraph.AddDirtyNode(this);
 }
}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0x453BABC", Offset = "0x4537ABC", VA = "0x453BABC", Slot = "9")]
		public override void ClearConnections(bool alsoReverse)
		{
		}

		[Token(Token = "0x6000830")]
		public override void GetConnections<T>(NodeActionWithData<T> action, ref T data, int connectionFilter)
		{
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0x453CAA4", Offset = "0x4538AA4", VA = "0x453CAA4", Slot = "7")]
		public override void AddPartialConnection(GraphNode node, uint cost, bool isOutgoing, bool isIncoming)
		{
		}

		[Token(Token = "0x6000832")]
		[Address(RVA = "0x453CD84", Offset = "0x4538D84", VA = "0x453CD84", Slot = "8")]
		public override void RemovePartialConnection(GraphNode node)
		{
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0x453DA98", Offset = "0x4539A98", VA = "0x453DA98", Slot = "24")]
		public override void SerializeReferences(GraphSerializationContext ctx)
		{
		}

		[Token(Token = "0x6000834")]
		[Address(RVA = "0x453DAC0", Offset = "0x4539AC0", VA = "0x453DAC0", Slot = "25")]
		public override void DeserializeReferences(GraphSerializationContext ctx)
		{
		}

		[Token(Token = "0x6000835")]
		[Address(RVA = "0x453B1F4", Offset = "0x45371F4", VA = "0x453B1F4")]
		protected GridNodeBase()
		{}
	}
}
