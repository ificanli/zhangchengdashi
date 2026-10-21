using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Pathfinding.Serialization;
using Unity.Profiling;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x200009C")]
	public abstract class GraphNode
	{
		[Token(Token = "0x200009D")]
		public delegate void NodeActionWithData<T>(GraphNode node, ref T data);

		[Token(Token = "0x4000348")]
		[FieldOffset(Offset = "0x10")]
		private int nodeIndex;

		[Token(Token = "0x4000349")]
		[FieldOffset(Offset = "0x14")]
		protected uint flags;

		[Token(Token = "0x400034A")]
		[FieldOffset(Offset = "0x18")]
		private uint penalty;

		[Token(Token = "0x400034B")]
		private const uint NodeIndexMask = 268435455u;

		[Token(Token = "0x400034C")]
		public const uint DestroyedNodeIndex = 268435454u;

		[Token(Token = "0x400034D")]
		public const int InvalidNodeIndex = 0;

		[Token(Token = "0x400034E")]
		private const int TemporaryFlag1Mask = 268435456;

		[Token(Token = "0x400034F")]
		private const int TemporaryFlag2Mask = 536870912;

		[Token(Token = "0x4000350")]
		[FieldOffset(Offset = "0x1C")]
		public Int3 position;

		[Token(Token = "0x4000351")]
		private const int FlagsWalkableOffset = 0;

		[Token(Token = "0x4000352")]
		private const uint FlagsWalkableMask = 1u;

		[Token(Token = "0x4000353")]
		private const int FlagsHierarchicalIndexOffset = 1;

		[Token(Token = "0x4000354")]
		private const uint HierarchicalIndexMask = 262142u;

		[Token(Token = "0x4000355")]
		private const int HierarchicalDirtyOffset = 18;

		[Token(Token = "0x4000356")]
		private const uint HierarchicalDirtyMask = 262144u;

		[Token(Token = "0x4000357")]
		private const int FlagsGraphOffset = 24;

		[Token(Token = "0x4000358")]
		private const uint FlagsGraphMask = 4278190080u;

		[Token(Token = "0x4000359")]
		public const uint MaxHierarchicalNodeIndex = 131071u;

		[Token(Token = "0x400035A")]
		public const uint MaxGraphIndex = 254u;

		[Token(Token = "0x400035B")]
		public const uint InvalidGraphIndex = 255u;

		[Token(Token = "0x400035C")]
		private const int FlagsTagOffset = 19;

		[Token(Token = "0x400035D")]
		public const int MaxTagIndex = 31;

		[Token(Token = "0x400035E")]
		private const uint FlagsTagMask = 16252928u;

		[Token(Token = "0x1700010E")]
		public NavGraph Graph
		{
			[Token(Token = "0x600051C")]
			[Address(RVA = "0x450A218", Offset = "0x4506218", VA = "0x450A218")]
			get
			{ return AstarData.GetGraph(this); }
		}

		[Token(Token = "0x1700010F")]
		public bool Destroyed
		{
			[Token(Token = "0x600051E")]
			[Address(RVA = "0x4509334", Offset = "0x4505334", VA = "0x4509334")]
			[IgnoredByDeepProfiler]
			get
			{ return (unchecked((uint)nodeIndex) & NodeIndexMask) == DestroyedNodeIndex; }
		}

		[Token(Token = "0x17000110")]
		public uint NodeIndex
		{
			[Token(Token = "0x600051F")]
			[Address(RVA = "0x450C85C", Offset = "0x450885C", VA = "0x450C85C")]
			[IgnoredByDeepProfiler]
			get
			{ return (uint)nodeIndex & NodeIndexMask; }
			[Token(Token = "0x6000520")]
			[Address(RVA = "0x450E2BC", Offset = "0x450A2BC", VA = "0x450E2BC")]
			[IgnoredByDeepProfiler]
			internal set
			{ nodeIndex = unchecked((nodeIndex & (int)0xF0000000u) | (int)value); }
		}

		[Token(Token = "0x17000111")]
		internal virtual int PathNodeVariants
		{
			[Token(Token = "0x6000521")]
			[Address(RVA = "0x450E2D0", Offset = "0x450A2D0", VA = "0x450E2D0", Slot = "4")]
			get
			{ return 1; }
		}

		[Token(Token = "0x17000112")]
		internal bool TemporaryFlag1
		{
			[Token(Token = "0x6000522")]
			[Address(RVA = "0x450E2D8", Offset = "0x450A2D8", VA = "0x450E2D8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000523")]
			[Address(RVA = "0x450E2E4", Offset = "0x450A2E4", VA = "0x450E2E4")]
			set
			{
			}
		}

		[Token(Token = "0x17000113")]
		internal bool TemporaryFlag2
		{
			[Token(Token = "0x6000524")]
			[Address(RVA = "0x450E314", Offset = "0x450A314", VA = "0x450E314")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000525")]
			[Address(RVA = "0x450E320", Offset = "0x450A320", VA = "0x450E320")]
			set
			{
			}
		}

		[Token(Token = "0x17000114")]
		public uint Flags
		{
			[Token(Token = "0x6000526")]
			[Address(RVA = "0x450E350", Offset = "0x450A350", VA = "0x450E350")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000527")]
			[Address(RVA = "0x450E358", Offset = "0x450A358", VA = "0x450E358")]
			set
			{
			}
		}

		[Token(Token = "0x17000115")]
		public uint Penalty
		{
			[Token(Token = "0x6000528")]
			[Address(RVA = "0x450E360", Offset = "0x450A360", VA = "0x450E360")]
			get
			{ return penalty; }
			[Token(Token = "0x6000529")]
			[Address(RVA = "0x450E368", Offset = "0x450A368", VA = "0x450E368")]
			set
			{ if (value>0x00ffffffu) UnityEngine.Debug.LogWarning("Very high penalty applied. Are you sure negative values haven't underflowed?\nPenalty values this high could with long paths cause overflows and in some cases infinite loops because of that.\nPenalty value applied: "+value.ToString()); penalty=value; }
		}

		[Token(Token = "0x17000116")]
		public bool Walkable
		{
			[Token(Token = "0x600052A")]
			[Address(RVA = "0x450E420", Offset = "0x450A420", VA = "0x450E420")]
			[IgnoredByDeepProfiler]
			get
			{ return (flags & 1) != 0; }
			[Token(Token = "0x600052B")]
			[Address(RVA = "0x450E42C", Offset = "0x450A42C", VA = "0x450E42C")]
			[IgnoredByDeepProfiler]
			set
			{ flags=(flags&0xfffffffeu)|(value?1u:0u); AstarPath.active.hierarchicalGraph.AddDirtyNode(this); }
		}

		[Token(Token = "0x17000117")]
		internal int HierarchicalNodeIndex
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x600052C")]
			[Address(RVA = "0x450E578", Offset = "0x450A578", VA = "0x450E578")]
			[IgnoredByDeepProfiler]
			get
			{ return (int)((flags >> 1) & 0x1FFFF); }
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x600052D")]
			[Address(RVA = "0x450E584", Offset = "0x450A584", VA = "0x450E584")]
			[IgnoredByDeepProfiler]
			set
			{
			}
		}

		[Token(Token = "0x17000118")]
		internal bool IsHierarchicalNodeDirty
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x600052E")]
			[Address(RVA = "0x450E598", Offset = "0x450A598", VA = "0x450E598")]
			[IgnoredByDeepProfiler]
			get
			{ return (flags & 0x40000u) != 0; }
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x600052F")]
			[Address(RVA = "0x450E5A4", Offset = "0x450A5A4", VA = "0x450E5A4")]
			[IgnoredByDeepProfiler]
			set
			{ flags = (flags & 0xFFFBFFFFu) | (value ? 0x40000u : 0u); }
		}

		[Token(Token = "0x17000119")]
		public uint Area
		{
			[Token(Token = "0x6000530")]
			[Address(RVA = "0x450E5D4", Offset = "0x450A5D4", VA = "0x450E5D4")]
			get
			{ return AstarPath.active.hierarchicalGraph.GetConnectedComponent(HierarchicalNodeIndex); }
		}

		[Token(Token = "0x1700011A")]
		public uint GraphIndex
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x6000531")]
			[Address(RVA = "0x450E678", Offset = "0x450A678", VA = "0x450E678")]
			[IgnoredByDeepProfiler]
			get
			{ return flags >> 24; }
			[Token(Token = "0x6000532")]
			[Address(RVA = "0x450E680", Offset = "0x450A680", VA = "0x450E680")]
			set
			{ flags=unchecked((flags&0x00ffffffu)|(value<<24)); }
		}

		[Token(Token = "0x1700011B")]
		public uint Tag
		{
			[Token(Token = "0x6000533")]
			[Address(RVA = "0x450E688", Offset = "0x450A688", VA = "0x450E688")]
			get
			{ return (flags >> 19) & 31u; }
			[Token(Token = "0x6000534")]
			[Address(RVA = "0x450C788", Offset = "0x4508788", VA = "0x450C788")]
			set
			{ flags=(flags&0xff07ffffu)|((value&31u)<<19); }
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x450E1BC", Offset = "0x450A1BC", VA = "0x450E1BC")]
		public void Destroy()
		{
 if (Destroyed) return;
 ClearConnections(true);
 if (AstarPath.active!=null) AstarPath.active.DestroyNode(this);
 nodeIndex=unchecked((nodeIndex&(int)0xf0000000u)|(int)DestroyedNodeIndex);
}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x450E694", Offset = "0x450A694", VA = "0x450E694")]
		public void SetConnectivityDirty()
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x450E704", Offset = "0x450A704", VA = "0x450E704", Slot = "5")]
		public virtual void GetConnections(Action<GraphNode> action, int connectionFilter = 32)
		{
		}

		[Token(Token = "0x6000537")]
		public abstract void GetConnections<T>(NodeActionWithData<T> action, ref T data, int connectionFilter = 32);

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x45096A8", Offset = "0x45056A8", VA = "0x45096A8")]
		public static void Connect(GraphNode lhs, GraphNode rhs, uint cost, OffMeshLinks.Directionality directionality = OffMeshLinks.Directionality.TwoWay)
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x450E834", Offset = "0x450A834", VA = "0x450E834")]
		public static void Disconnect(GraphNode lhs, GraphNode rhs)
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x450E878", Offset = "0x450A878", VA = "0x450E878")]
		[Obsolete("Use the static Connect method instead, or AddPartialConnection if you really need to")]
		public void AddConnection(GraphNode node, uint cost)
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x450E88C", Offset = "0x450A88C", VA = "0x450E88C")]
		[Obsolete("Use the static Disconnect method instead, or RemovePartialConnection if you really need to")]
		public void RemoveConnection(GraphNode node)
		{
		}

		[Token(Token = "0x600053C")]
		public abstract void AddPartialConnection(GraphNode node, uint cost, bool isOutgoing, bool isIncoming);

		[Token(Token = "0x600053D")]
		public abstract void RemovePartialConnection(GraphNode node);

		[Token(Token = "0x600053E")]
		public abstract void ClearConnections(bool alsoReverse = true);

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x450E898", Offset = "0x450A898", VA = "0x450E898")]
		[Obsolete("Use ContainsOutgoingConnection instead")]
		public bool ContainsConnection(GraphNode node)
		{
			return default;
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x450E8A4", Offset = "0x450A8A4", VA = "0x450E8A4", Slot = "10")]
		public virtual bool ContainsOutgoingConnection(GraphNode node)
		{
			return default;
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x450E9AC", Offset = "0x450A9AC", VA = "0x450E9AC")]
		[Obsolete("Use GetPortal(GraphNode, out Vector3, out Vector3) instead")]
		public bool GetPortal(GraphNode other, List<Vector3> left, List<Vector3> right, bool backwards)
		{
			return default;
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x450EB24", Offset = "0x450AB24", VA = "0x450EB24", Slot = "11")]
		public virtual bool GetPortal(GraphNode other, out Vector3 left, out Vector3 right)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED GraphNode.GetPortal RVA=0x450EB24 Token=0x6000542");
}

		[Token(Token = "0x6000543")]
		public abstract void Open(ref Path.SearchContext ctx, uint pathNodeIndex, uint gScore);

		[Token(Token = "0x6000544")]
		public abstract void OpenAtPoint(ref Path.SearchContext ctx, uint pathNodeIndex, Int3 position, uint gScore);

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x450EB9C", Offset = "0x450AB9C", VA = "0x450EB9C", Slot = "14")]
		public virtual Int3 DecodeVariantPosition(uint pathNodeIndex, uint fractionAlongEdge)
		{
			return default;
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x450EBAC", Offset = "0x450ABAC", VA = "0x450EBAC", Slot = "15")]
		public virtual float SurfaceArea()
		{
			return default;
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x450EBB4", Offset = "0x450ABB4", VA = "0x450EBB4", Slot = "16")]
		public virtual Vector3 RandomPointOnSurface()
		{
			return default;
		}

		[Token(Token = "0x6000548")]
		public abstract Vector3 ClosestPointOnNode(Vector3 p);

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x450EBE0", Offset = "0x450ABE0", VA = "0x450EBE0", Slot = "18")]
		public virtual bool ContainsPoint(Int3 point)
		{
			return default;
		}

		[Token(Token = "0x600054A")]
		public abstract bool ContainsPoint(Vector3 point);

		[Token(Token = "0x600054B")]
		public abstract bool ContainsPointInGraphSpace(Int3 point);

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x450EC14", Offset = "0x450AC14", VA = "0x450EC14", Slot = "21")]
		public virtual int GetGizmoHashCode()
		{
			return default;
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x450EC50", Offset = "0x450AC50", VA = "0x450EC50", Slot = "22")]
		public virtual void SerializeNode(GraphSerializationContext ctx)
		{
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x450ECAC", Offset = "0x450ACAC", VA = "0x450ECAC", Slot = "23")]
		public virtual void DeserializeNode(GraphSerializationContext ctx)
		{
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0x450ED30", Offset = "0x450AD30", VA = "0x450ED30", Slot = "24")]
		public virtual void SerializeReferences(GraphSerializationContext ctx)
		{
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0x450ED34", Offset = "0x450AD34", VA = "0x450ED34", Slot = "25")]
		public virtual void DeserializeReferences(GraphSerializationContext ctx)
		{
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x450ED38", Offset = "0x450AD38", VA = "0x450ED38")]
		protected GraphNode()
		{}
	}
}
