using Il2CppDummyDll;
using Pathfinding.Serialization;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x20000ED")]
	public class LevelGridNode : GridNodeBase
	{
		[Token(Token = "0x4000521")]
		[FieldOffset(Offset = "0x0")]
		private static LayerGridGraph[] _gridGraphs;

		[Token(Token = "0x4000522")]
		[FieldOffset(Offset = "0x38")]
		public uint gridConnections;

		[Token(Token = "0x4000523")]
		[FieldOffset(Offset = "0x8")]
		protected static LayerGridGraph[] gridGraphs;

		[Token(Token = "0x4000524")]
		private const int MaxNeighbours = 8;

		[Token(Token = "0x4000525")]
		public const int ConnectionMask = 15;

		[Token(Token = "0x4000526")]
		public const int ConnectionStride = 4;

		[Token(Token = "0x4000527")]
		public const int AxisAlignedConnectionsMask = 65535;

		[Token(Token = "0x4000528")]
		public const uint AllConnectionsMask = uint.MaxValue;

		[Token(Token = "0x4000529")]
		public const int NoConnection = 15;

		[Token(Token = "0x400052A")]
		internal const ulong DiagonalConnectionsMask = 4294901760uL;

		[Token(Token = "0x400052B")]
		public const int MaxLayerCount = 15;

		[Token(Token = "0x1700018A")]
		public override bool HasAnyGridConnections
		{
			[Token(Token = "0x600083D")]
			[Address(RVA = "0x453E0AC", Offset = "0x453A0AC", VA = "0x453E0AC", Slot = "30")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700018B")]
		public override bool HasConnectionsToAllEightNeighbours
		{
			[Token(Token = "0x600083E")]
			[Address(RVA = "0x453E0BC", Offset = "0x453A0BC", VA = "0x453E0BC", Slot = "26")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700018C")]
		public override bool HasConnectionsToAllAxisAlignedNeighbours
		{
			[Token(Token = "0x600083F")]
			[Address(RVA = "0x453E12C", Offset = "0x453A12C", VA = "0x453E12C", Slot = "27")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700018D")]
		public int LayerCoordinateInGrid
		{
			[Token(Token = "0x6000840")]
			[Address(RVA = "0x453E140", Offset = "0x453A140", VA = "0x453E140")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000841")]
			[Address(RVA = "0x453E14C", Offset = "0x453A14C", VA = "0x453E14C")]
			set
			{
			}
		}

		[Token(Token = "0x6000837")]
		[Address(RVA = "0x453DC28", Offset = "0x4539C28", VA = "0x453DC28")]
		public LevelGridNode()
		{
		}

		[Token(Token = "0x6000838")]
		[Address(RVA = "0x453DC80", Offset = "0x4539C80", VA = "0x453DC80")]
		public LevelGridNode(AstarPath astar)
		{
		}

		[Token(Token = "0x6000839")]
		[Address(RVA = "0x453DCFC", Offset = "0x4539CFC", VA = "0x453DCFC")]
		public static LayerGridGraph GetGridGraph(uint graphIndex)
		{
			return null;
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0x453DD78", Offset = "0x4539D78", VA = "0x453DD78")]
		public static void SetGridGraph(int graphIndex, LayerGridGraph graph)
		{
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0x453DF44", Offset = "0x4539F44", VA = "0x453DF44")]
		public static void ClearGridGraph(int graphIndex, LayerGridGraph graph)
		{
		}

		[Token(Token = "0x600083C")]
		[Address(RVA = "0x453E030", Offset = "0x453A030", VA = "0x453E030", Slot = "31")]
		public override void ResetConnectionsInternal()
		{
		}

		[Token(Token = "0x6000842")]
		[Address(RVA = "0x453E154", Offset = "0x453A154", VA = "0x453E154")]
		public void SetPosition(Int3 position)
		{
		}

		[Token(Token = "0x6000843")]
		[Address(RVA = "0x453E160", Offset = "0x453A160", VA = "0x453E160", Slot = "21")]
		public override int GetGizmoHashCode()
		{
			return default;
		}

		[Token(Token = "0x6000844")]
		[Address(RVA = "0x453E198", Offset = "0x453A198", VA = "0x453E198", Slot = "28")]
		public override GridNodeBase GetNeighbourAlongDirection(int direction)
		{
			return null;
		}

		[Token(Token = "0x6000845")]
		[Address(RVA = "0x453E294", Offset = "0x453A294", VA = "0x453E294", Slot = "9")]
		public override void ClearConnections(bool alsoReverse)
		{
		}

		[Token(Token = "0x6000846")]
		public override void GetConnections<T>(NodeActionWithData<T> action, ref T data, int connectionFilter)
		{
		}

		[Token(Token = "0x6000847")]
		[Address(RVA = "0x453E4A0", Offset = "0x453A4A0", VA = "0x453E4A0", Slot = "29")]
		public override bool HasConnectionInDirection(int direction)
		{
			return default;
		}

		[Token(Token = "0x6000848")]
		[Address(RVA = "0x453E3FC", Offset = "0x453A3FC", VA = "0x453E3FC")]
		public void SetConnectionValue(int dir, int value)
		{
		}

		[Token(Token = "0x6000849")]
		[Address(RVA = "0x453E4BC", Offset = "0x453A4BC", VA = "0x453E4BC")]
		public void SetAllConnectionInternal(ulong value)
		{
		}

		[Token(Token = "0x600084A")]
		[Address(RVA = "0x453E280", Offset = "0x453A280", VA = "0x453E280")]
		public int GetConnectionValue(int dir)
		{
			return default;
		}

		[Token(Token = "0x600084B")]
		[Address(RVA = "0x453E4C4", Offset = "0x453A4C4", VA = "0x453E4C4", Slot = "7")]
		public override void AddPartialConnection(GraphNode node, uint cost, bool isOutgoing, bool isIncoming)
		{
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0x453E688", Offset = "0x453A688", VA = "0x453E688", Slot = "8")]
		public override void RemovePartialConnection(GraphNode node)
		{
		}

		[Token(Token = "0x600084D")]
		[Address(RVA = "0x453E588", Offset = "0x453A588", VA = "0x453E588")]
		protected void RemoveGridConnection(LevelGridNode node)
		{
		}

		[Token(Token = "0x600084E")]
		[Address(RVA = "0x453E730", Offset = "0x453A730", VA = "0x453E730", Slot = "11")]
		public override bool GetPortal(GraphNode other, out Vector3 left, out Vector3 right)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED LevelGridNode.GetPortal RVA=0x453E730 Token=0x600084E");
}

		[Token(Token = "0x600084F")]
		[Address(RVA = "0x453EC40", Offset = "0x453AC40", VA = "0x453EC40", Slot = "12")]
		public override void Open(ref Path.SearchContext ctx, uint pathNodeIndex, uint gScore)
		{
		}

		[Token(Token = "0x6000850")]
		[Address(RVA = "0x453EFD4", Offset = "0x453AFD4", VA = "0x453EFD4", Slot = "22")]
		public override void SerializeNode(GraphSerializationContext ctx)
		{
		}

		[Token(Token = "0x6000851")]
		[Address(RVA = "0x453F0B0", Offset = "0x453B0B0", VA = "0x453F0B0", Slot = "23")]
		public override void DeserializeNode(GraphSerializationContext ctx)
		{
		}
	}
}
