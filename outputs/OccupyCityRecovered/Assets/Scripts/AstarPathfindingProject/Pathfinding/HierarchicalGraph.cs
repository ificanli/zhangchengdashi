using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Pathfinding.Collections;
using Pathfinding.Drawing;
using Pathfinding.Sync;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x20000AB")]
	public class HierarchicalGraph
	{
		[Token(Token = "0x20000AC")]
		public struct HierarhicalNodeData
		{
			[Token(Token = "0x400039F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public SlabAllocator<int> connectionAllocator;

			[Token(Token = "0x40003A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[ReadOnly]
			public NativeList<int> connectionAllocations;

			[Token(Token = "0x40003A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[ReadOnly]
			public NativeList<Bounds> bounds;
		}

		[Token(Token = "0x20000AD")]
		private struct JobRecalculateComponents : IJob
		{
			[Token(Token = "0x20000AE")]
			private struct Context
			{
				[Token(Token = "0x40003A8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public List<GraphNode> children;

				[Token(Token = "0x40003A9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public int hierarchicalNodeIndex;

				[Token(Token = "0x40003AA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public List<int> connections;

				[Token(Token = "0x40003AB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public uint graphindex;

				[Token(Token = "0x40003AC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public Queue<GraphNode> queue;
			}

			[Token(Token = "0x40003A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public GCHandle hGraphGC;

			[Token(Token = "0x40003A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public NativeList<int> connectionAllocations;

			[Token(Token = "0x40003A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public NativeList<Bounds> bounds;

			[Token(Token = "0x40003A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public NativeList<int> dirtiedHierarchicalNodes;

			[Token(Token = "0x40003A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public NativeReference<int> numHierarchicalNodes;

			[Token(Token = "0x40003A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private bool warnedAboutTooManyHierarchicalNodes;

			[Token(Token = "0x60005B0")]
			[Address(RVA = "0x45130D8", Offset = "0x450F0D8", VA = "0x45130D8")]
			private void Grow(HierarchicalGraph graph)
			{
			}

			[Token(Token = "0x60005B1")]
			[Address(RVA = "0x45134BC", Offset = "0x450F4BC", VA = "0x45134BC")]
			private int GetHierarchicalNodeIndex(HierarchicalGraph graph)
			{
				return default;
			}

			[Token(Token = "0x60005B2")]
			[Address(RVA = "0x45135A8", Offset = "0x450F5A8", VA = "0x45135A8")]
			private void RemoveHierarchicalNode(HierarchicalGraph hGraph, int hierarchicalNode, bool removeAdjacentSmallNodes)
			{
			}

			[Token(Token = "0x60005B3")]
			[Address(RVA = "0x4513A60", Offset = "0x450FA60", VA = "0x4513A60")]
			[Conditional("CHECK_INVARIANTS")]
			private void CheckConnectionInvariants()
			{
			}

			[Token(Token = "0x60005B4")]
			[Address(RVA = "0x4513D1C", Offset = "0x450FD1C", VA = "0x4513D1C")]
			[Conditional("CHECK_INVARIANTS")]
			private void CheckPreUpdateInvariants()
			{
			}

			[Token(Token = "0x60005B5")]
			[Address(RVA = "0x4513ED0", Offset = "0x450FED0", VA = "0x4513ED0")]
			[Conditional("CHECK_INVARIANTS")]
			private void CheckChildInvariants()
			{
			}

			[Token(Token = "0x60005B6")]
			[Address(RVA = "0x451403C", Offset = "0x451003C", VA = "0x451403C")]
			private void FindHierarchicalNodeChildren(HierarchicalGraph hGraph, int hierarchicalNode, GraphNode startNode)
			{
			}

			[Token(Token = "0x60005B7")]
			[Address(RVA = "0x4514514", Offset = "0x4510514", VA = "0x4514514")]
			private void FloodFill(HierarchicalGraph hGraph)
			{
			}

			[Token(Token = "0x60005B8")]
			[Address(RVA = "0x45147AC", Offset = "0x45107AC", VA = "0x45147AC", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Token(Token = "0x4000386")]
		private const int Tiling = 16;

		[Token(Token = "0x4000387")]
		private const int MaxChildrenPerNode = 256;

		[Token(Token = "0x4000388")]
		private const int MinChildrenPerNode = 128;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private GlobalNodeStorage nodeStorage;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal List<GraphNode>[] children;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal NativeList<int> connectionAllocations;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal SlabAllocator<int> connectionAllocator;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private NativeList<int> dirtiedHierarchicalNodes;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int[] areas;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private byte[] dirty;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int[] versions;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool anyNodesDestroyed;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		internal NativeList<Bounds> bounds;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private NativeReference<int> numHierarchicalNodes;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		internal GCHandle gcHandle;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public NavmeshEdges navmeshEdges;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Queue<GraphNode> temporaryQueue;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private List<int> currentConnections;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Stack<int> temporaryStack;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private HierarchicalBitset dirtyNodes;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private CircularBuffer<int> freeNodeIndices;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int gizmoVersion;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private RWLock rwLock;

		[Token(Token = "0x17000123")]
		public int version
		{
			[Token(Token = "0x600059E")]
			[Address(RVA = "0x4512224", Offset = "0x450E224", VA = "0x4512224")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x600059F")]
			[Address(RVA = "0x451222C", Offset = "0x450E22C", VA = "0x451222C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000124")]
		public int NumConnectedComponents
		{
			[Token(Token = "0x60005A9")]
			[Address(RVA = "0x45128C0", Offset = "0x450E8C0", VA = "0x45128C0")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x60005AA")]
			[Address(RVA = "0x45128C8", Offset = "0x450E8C8", VA = "0x45128C8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x4512234", Offset = "0x450E234", VA = "0x4512234")]
		internal void OnDisable()
		{
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x45123A8", Offset = "0x450E3A8", VA = "0x45123A8")]
		public int GetHierarchicalNodeVersion(int index)
		{
			return default;
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x45123E8", Offset = "0x450E3E8", VA = "0x45123E8")]
		public HierarhicalNodeData GetHierarhicalNodeData(out RWLock.ReadLockAsync readLock)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED HierarchicalGraph.GetHierarhicalNodeData RVA=0x45123E8 Token=0x60005A2");
}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x4512450", Offset = "0x450E450", VA = "0x4512450")]
		internal HierarchicalGraph(GlobalNodeStorage nodeStorage)
		{
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x45125D4", Offset = "0x450E5D4", VA = "0x45125D4")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x450FE68", Offset = "0x450BE68", VA = "0x450FE68")]
		internal void OnCreatedNode(GraphNode node)
		{
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x45100C4", Offset = "0x450C0C4", VA = "0x45100C4")]
		internal void OnDestroyedNode(GraphNode node)
		{ dirty[node.HierarchicalNodeIndex]=1;dirtyNodes.Reset(unchecked((int)node.NodeIndex));node.IsHierarchicalNodeDirty=false;anyNodesDestroyed=true; }

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x450E4B0", Offset = "0x450A4B0", VA = "0x450E4B0")]
		public void AddDirtyNode(GraphNode node)
		{
 if (!node.IsHierarchicalNodeDirty && dirtyNodes.IsCreated && !node.Destroyed) {
  dirtyNodes.Set(unchecked((int)node.NodeIndex));
  dirty[node.HierarchicalNodeIndex] = 1;
  node.IsHierarchicalNodeDirty = true;
 }
}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x450FE6C", Offset = "0x450BE6C", VA = "0x450FE6C")]
		public void ReserveNodeIndices(uint nodeIndexCount)
		{ dirtyNodes.Capacity = System.Math.Max(dirtyNodes.Capacity, unchecked((int)nodeIndexCount)); }

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x450E648", Offset = "0x450A648", VA = "0x450E648")]
		public uint GetConnectedComponent(int hierarchicalNodeIndex)
		{ return unchecked((uint)areas[hierarchicalNodeIndex]); }

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x450D4A8", Offset = "0x45094A8", VA = "0x450D4A8")]
		public void RecalculateIfNecessary()
		{
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x45128D0", Offset = "0x450E8D0", VA = "0x45128D0")]
		public JobHandle JobRecalculateIfNecessary([Optional] JobHandle dependsOn)
		{
			return default;
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x4512A8C", Offset = "0x450EA8C", VA = "0x4512A8C")]
		public void RecalculateAll()
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x4512B98", Offset = "0x450EB98", VA = "0x4512B98")]
		public void OnDrawGizmos(DrawingData gizmos, bool renderInGame)
		{
		}
	}
}
