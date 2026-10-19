using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Pathfinding.Collections;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x200008A")]
	public class OffMeshLinks
	{
		[Token(Token = "0x200008B")]
		public struct Anchor
		{
			[Token(Token = "0x40002F9")]
			[FieldOffset(Offset = "0x0")]
			public Vector3 center;

			[Token(Token = "0x40002FA")]
			[FieldOffset(Offset = "0xC")]
			public Quaternion rotation;

			[Token(Token = "0x40002FB")]
			[FieldOffset(Offset = "0x1C")]
			public float width;

			[Token(Token = "0x170000F7")]
			public readonly Vector3 point1
			{
				[Token(Token = "0x60004C2")]
				[Address(RVA = "0x450AEB4", Offset = "0x4506EB4", VA = "0x450AEB4")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170000F8")]
			public readonly Vector3 point2
			{
				[Token(Token = "0x60004C3")]
				[Address(RVA = "0x450AF04", Offset = "0x4506F04", VA = "0x450AF04")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x60004C4")]
			[Address(RVA = "0x450C33C", Offset = "0x450833C", VA = "0x450C33C")]
			public static bool operator ==(Anchor a, Anchor b)
			{
				return default;
			}

			[Token(Token = "0x60004C5")]
			[Address(RVA = "0x450C3D0", Offset = "0x45083D0", VA = "0x450C3D0")]
			public static bool operator !=(Anchor a, Anchor b)
			{
				return default;
			}

			[Token(Token = "0x60004C6")]
			[Address(RVA = "0x450C464", Offset = "0x4508464", VA = "0x450C464", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default;
			}

			[Token(Token = "0x60004C7")]
			[Address(RVA = "0x450C4F4", Offset = "0x45084F4", VA = "0x450C4F4", Slot = "2")]
			public override int GetHashCode()
			{
				return default;
			}
		}

		[Token(Token = "0x200008C")]
		public enum Directionality
		{
			[Token(Token = "0x40002FD")]
			OneWay = 0,
			[Token(Token = "0x40002FE")]
			TwoWay = 1
		}

		[Token(Token = "0x200008D")]
		[Flags]
		public enum OffMeshLinkStatus
		{
			[Token(Token = "0x4000300")]
			Inactive = 1,
			[Token(Token = "0x4000301")]
			Pending = 2,
			[Token(Token = "0x4000302")]
			Active = 4,
			[Token(Token = "0x4000303")]
			FailedToConnectStart = 9,
			[Token(Token = "0x4000304")]
			FailedToConnectEnd = 0x11,
			[Token(Token = "0x4000305")]
			PendingRemoval = 0x20
		}

		[Token(Token = "0x200008E")]
		public readonly struct OffMeshLinkTracer
		{
			[Token(Token = "0x4000306")]
			[FieldOffset(Offset = "0x0")]
			public readonly OffMeshLinkConcrete link;

			[Token(Token = "0x4000307")]
			[FieldOffset(Offset = "0x8")]
			public readonly Vector3 relativeStart;

			[Token(Token = "0x4000308")]
			[FieldOffset(Offset = "0x14")]
			public readonly Vector3 relativeEnd;

			[Token(Token = "0x4000309")]
			[FieldOffset(Offset = "0x20")]
			public readonly bool isReverse;

			[Token(Token = "0x170000F9")]
			public Component component
			{
				[Token(Token = "0x60004CA")]
				[Address(RVA = "0x450C5D4", Offset = "0x45085D4", VA = "0x450C5D4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000FA")]
			public GameObject gameObject
			{
				[Token(Token = "0x60004CB")]
				[Address(RVA = "0x450C614", Offset = "0x4508614", VA = "0x450C614")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004C8")]
			[Address(RVA = "0x450B344", Offset = "0x4507344", VA = "0x450B344")]
			public OffMeshLinkTracer(OffMeshLinkConcrete link, bool reversed)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED OffMeshLinks.OffMeshLinkTracer..ctor RVA=0x450B344 Token=0x60004C8");
}

			[Token(Token = "0x60004C9")]
			[Address(RVA = "0x450C5B8", Offset = "0x45085B8", VA = "0x450C5B8")]
			public OffMeshLinkTracer(OffMeshLinkConcrete link, Vector3 relativeStart, Vector3 relativeEnd, bool isReverse)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED OffMeshLinks.OffMeshLinkTracer..ctor RVA=0x450C5B8 Token=0x60004C9");
}
		}

		[Token(Token = "0x200008F")]
		public class OffMeshLinkSource
		{
			[Token(Token = "0x400030A")]
			[FieldOffset(Offset = "0x10")]
			public Anchor start;

			[Token(Token = "0x400030B")]
			[FieldOffset(Offset = "0x30")]
			public Anchor end;

			[Token(Token = "0x400030C")]
			[FieldOffset(Offset = "0x50")]
			public Directionality directionality;

			[Token(Token = "0x400030D")]
			[FieldOffset(Offset = "0x54")]
			public PathfindingTag tag;

			[Token(Token = "0x400030E")]
			[FieldOffset(Offset = "0x58")]
			public float costFactor;

			[Token(Token = "0x400030F")]
			[FieldOffset(Offset = "0x5C")]
			public float maxSnappingDistance;

			[Token(Token = "0x4000310")]
			[FieldOffset(Offset = "0x60")]
			public GraphMask graphMask;

			[Token(Token = "0x4000311")]
			[FieldOffset(Offset = "0x68")]
			public IOffMeshLinkHandler handler;

			[Token(Token = "0x4000312")]
			[FieldOffset(Offset = "0x70")]
			public Component component;

			[Token(Token = "0x4000313")]
			[FieldOffset(Offset = "0x78")]
			internal AABBTree<OffMeshLinkCombined>.Key treeKey;

			[Token(Token = "0x170000FB")]
			public GameObject gameObject
			{
				[Token(Token = "0x60004CC")]
				[Address(RVA = "0x450C6C4", Offset = "0x45086C4", VA = "0x450C6C4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000FC")]
			public OffMeshLinkStatus status
			{
				[Token(Token = "0x60004CD")]
				[Address(RVA = "0x450C74C", Offset = "0x450874C", VA = "0x450C74C")]
				[CompilerGenerated]
				get
				{
					return default;
				}
				[Token(Token = "0x60004CE")]
				[Address(RVA = "0x450C754", Offset = "0x4508754", VA = "0x450C754")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Token(Token = "0x170000FD")]
			public Bounds bounds
			{
				[Token(Token = "0x60004CF")]
				[Address(RVA = "0x450BAF8", Offset = "0x4507AF8", VA = "0x450BAF8")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x60004D0")]
			[Address(RVA = "0x450C75C", Offset = "0x450875C", VA = "0x450C75C")]
			public OffMeshLinkSource()
			{
			}
		}

		[Token(Token = "0x2000090")]
		internal class OffMeshLinkCombined
		{
			[Token(Token = "0x4000315")]
			[FieldOffset(Offset = "0x10")]
			public OffMeshLinkSource source;

			[Token(Token = "0x4000316")]
			[FieldOffset(Offset = "0x18")]
			public OffMeshLinkConcrete concrete;

			[Token(Token = "0x60004D1")]
			[Address(RVA = "0x450BAF0", Offset = "0x4507AF0", VA = "0x450BAF0")]
			public OffMeshLinkCombined()
			{
			}
		}

		[Token(Token = "0x2000091")]
		public class OffMeshLinkConcrete
		{
			[Token(Token = "0x4000317")]
			[FieldOffset(Offset = "0x10")]
			public Anchor start;

			[Token(Token = "0x4000318")]
			[FieldOffset(Offset = "0x30")]
			public Anchor end;

			[Token(Token = "0x4000319")]
			[FieldOffset(Offset = "0x50")]
			public GraphNode[] startNodes;

			[Token(Token = "0x400031A")]
			[FieldOffset(Offset = "0x58")]
			public GraphNode[] endNodes;

			[Token(Token = "0x400031B")]
			[FieldOffset(Offset = "0x60")]
			public LinkNode startLinkNode;

			[Token(Token = "0x400031C")]
			[FieldOffset(Offset = "0x68")]
			public LinkNode endLinkNode;

			[Token(Token = "0x400031D")]
			[FieldOffset(Offset = "0x70")]
			public Directionality directionality;

			[Token(Token = "0x400031E")]
			[FieldOffset(Offset = "0x74")]
			public PathfindingTag tag;

			[Token(Token = "0x400031F")]
			[FieldOffset(Offset = "0x78")]
			public float costFactor;

			[Token(Token = "0x4000320")]
			[FieldOffset(Offset = "0x7C")]
			internal bool staleConnections;

			[Token(Token = "0x4000321")]
			[FieldOffset(Offset = "0x80")]
			internal OffMeshLinkSource source;

			[Token(Token = "0x170000FE")]
			public IOffMeshLinkHandler handler
			{
				[Token(Token = "0x60004D2")]
				[Address(RVA = "0x450C76C", Offset = "0x450876C", VA = "0x450C76C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000FF")]
			public Component component
			{
				[Token(Token = "0x60004D3")]
				[Address(RVA = "0x450C5F8", Offset = "0x45085F8", VA = "0x450C5F8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000100")]
			public GameObject gameObject
			{
				[Token(Token = "0x60004D4")]
				[Address(RVA = "0x450C62C", Offset = "0x450862C", VA = "0x450C62C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004D5")]
			[Address(RVA = "0x450BD28", Offset = "0x4507D28", VA = "0x450BD28")]
			public bool Equivalent(OffMeshLinkConcrete other)
			{
				return default;
			}

			[Token(Token = "0x60004D6")]
			[Address(RVA = "0x450BC60", Offset = "0x4507C60", VA = "0x450BC60")]
			public void Disconnect()
			{
			}

			[Token(Token = "0x60004D7")]
			[Address(RVA = "0x450BEA8", Offset = "0x4507EA8", VA = "0x450BEA8")]
			public void Connect(LinkGraph linkGraph, OffMeshLinkSource source)
			{
			}

			[Token(Token = "0x60004D8")]
			[Address(RVA = "0x450C798", Offset = "0x4508798", VA = "0x450C798")]
			public OffMeshLinkTracer GetTracer(LinkNode firstNode)
			{
				return default;
			}

			[Token(Token = "0x60004D9")]
			[Address(RVA = "0x450BD20", Offset = "0x4507D20", VA = "0x450BD20")]
			public OffMeshLinkConcrete()
			{
			}
		}

		[Token(Token = "0x40002F5")]
		[FieldOffset(Offset = "0x10")]
		private AABBTree<OffMeshLinkCombined> tree;

		[Token(Token = "0x40002F6")]
		[FieldOffset(Offset = "0x18")]
		private List<OffMeshLinkSource> pendingAdd;

		[Token(Token = "0x40002F7")]
		[FieldOffset(Offset = "0x20")]
		private bool updateScheduled;

		[Token(Token = "0x40002F8")]
		[FieldOffset(Offset = "0x28")]
		private AstarPath astar;

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x4509EF4", Offset = "0x4505EF4", VA = "0x4509EF4")]
		public OffMeshLinks(AstarPath astar)
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x4509FC4", Offset = "0x4505FC4", VA = "0x4509FC4")]
		public List<NavGraph> ConnectedGraphs(OffMeshLinkSource link)
		{
			return null;
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x450A270", Offset = "0x4506270", VA = "0x450A270")]
		public void Add(OffMeshLinkSource link)
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x450A4CC", Offset = "0x45064CC", VA = "0x450A4CC")]
		internal void OnDisable()
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x450A758", Offset = "0x4506758", VA = "0x450A758")]
		public void Remove(OffMeshLinkSource link)
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x450A868", Offset = "0x4506868", VA = "0x450A868")]
		private bool ClampSegment(Anchor anchor, GraphMask graphMask, float maxSnappingDistance, out Anchor result, List<GraphNode> nodes)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED OffMeshLinks.ClampSegment RVA=0x450A868 Token=0x60004BB");
}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x450AF54", Offset = "0x4506F54", VA = "0x450AF54")]
		public void DirtyBounds(Bounds bounds)
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x450AFD8", Offset = "0x4506FD8", VA = "0x450AFD8")]
		public void Dirty(OffMeshLinkSource link)
		{
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x450AFF0", Offset = "0x4506FF0", VA = "0x450AFF0")]
		internal void DirtyNoSchedule(OffMeshLinkSource link)
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x450A3A8", Offset = "0x45063A8", VA = "0x450A3A8")]
		private void ScheduleUpdate()
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x450B04C", Offset = "0x450704C", VA = "0x450B04C")]
		public OffMeshLinkTracer GetNearest(Vector3 point, float maxDistance)
		{
			return default;
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x450B3C0", Offset = "0x45073C0", VA = "0x450B3C0")]
		internal void Refresh()
		{
		}
	}
}
