using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x2000097")]
	internal class WorkItemProcessor : IWorkItemContext, IGraphUpdateContext
	{
		[Token(Token = "0x2000098")]
		private struct BoundsVisualization
		{
			[Token(Token = "0x2000099")]
			public enum BoundsVisualizationType
			{
				[Token(Token = "0x400033C")]
				OriginalBounds = 0,
				[Token(Token = "0x400033D")]
				AffectedBounds = 1
			}

			[Token(Token = "0x4000337")]
			[FieldOffset(Offset = "0x0")]
			public Bounds bounds;

			[Token(Token = "0x4000338")]
			[FieldOffset(Offset = "0x18")]
			public float createdTime;

			[Token(Token = "0x4000339")]
			[FieldOffset(Offset = "0x1C")]
			public int createdFrame;

			[Token(Token = "0x400033A")]
			[FieldOffset(Offset = "0x20")]
			public BoundsVisualizationType type;

			[Token(Token = "0x6000508")]
			[Address(RVA = "0x450D1A8", Offset = "0x45091A8", VA = "0x450D1A8")]
			public BoundsVisualization(Bounds bounds, BoundsVisualizationType type)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED WorkItemProcessor.BoundsVisualization..ctor RVA=0x450D1A8 Token=0x6000508");
}
		}

		[Token(Token = "0x200009A")]
		private class IndexedQueue<T>
		{
			[Token(Token = "0x400033E")]
			[FieldOffset(Offset = "0x0")]
			private T[] buffer;

			[Token(Token = "0x400033F")]
			[FieldOffset(Offset = "0x0")]
			private int start;

			[Token(Token = "0x17000106")]
			public T this[int index]
			{
				[Token(Token = "0x6000509")]
				get
				{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED WorkItemProcessor.IndexedQueue.indexer.get RVA= Token=0x6000509");
}
				[Token(Token = "0x600050A")]
				set
				{
				}
			}

			[Token(Token = "0x17000107")]
			public int Count
			{
				[Token(Token = "0x600050B")]
				[CompilerGenerated]
				get
				{
					return default;
				}
				[Token(Token = "0x600050C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x600050D")]
			public void Enqueue(T item)
			{
			}

			[Token(Token = "0x600050E")]
			public T Dequeue()
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED WorkItemProcessor.IndexedQueue.Dequeue RVA= Token=0x600050E");
}

			[Token(Token = "0x600050F")]
			public IndexedQueue()
			{
			}
		}

		[Token(Token = "0x400032F")]
		[FieldOffset(Offset = "0x10")]
		[CompilerGenerated]
		private Action m_OnGraphsUpdated;

		[Token(Token = "0x4000331")]
		[FieldOffset(Offset = "0x20")]
		private readonly AstarPath astar;

		[Token(Token = "0x4000332")]
		[FieldOffset(Offset = "0x28")]
		private readonly IndexedQueue<AstarWorkItem> workItems;

		[Token(Token = "0x4000333")]
		[FieldOffset(Offset = "0x30")]
		private readonly List<BoundsVisualization> boundsVisualizations;

		[Token(Token = "0x4000334")]
		[FieldOffset(Offset = "0x38")]
		private bool anyGraphsDirty;

		[Token(Token = "0x4000335")]
		[FieldOffset(Offset = "0x39")]
		private bool preUpdateEventSent;

		[Token(Token = "0x17000103")]
		public bool workItemsInProgressRightNow
		{
			[Token(Token = "0x60004F6")]
			[Address(RVA = "0x450D008", Offset = "0x4509008", VA = "0x450D008")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x60004F7")]
			[Address(RVA = "0x450D010", Offset = "0x4509010", VA = "0x450D010")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000104")]
		public bool anyQueued
		{
			[Token(Token = "0x60004F8")]
			[Address(RVA = "0x450D01C", Offset = "0x450901C", VA = "0x450D01C")]
			get
			{
				return default;
			}
		}

		[field: Token(Token = "0x4000336")]
[field: Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
[Token(Token = "0x17000105")]
		public bool workItemsInProgress
		{
			[Token(Token = "0x60004F9")]
			[Address(RVA = "0x450D06C", Offset = "0x450906C", VA = "0x450D06C")]
			[CompilerGenerated]
			get
			;
			[Token(Token = "0x60004FA")]
			[Address(RVA = "0x450D074", Offset = "0x4509074", VA = "0x450D074")]
			[CompilerGenerated]
			private set
			;
		}

		[Token(Token = "0x14000001")]
		public event Action OnGraphsUpdated
		{
			[Token(Token = "0x60004F4")]
			[Address(RVA = "0x450CED0", Offset = "0x4508ED0", VA = "0x450CED0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60004F5")]
			[Address(RVA = "0x450CF6C", Offset = "0x4508F6C", VA = "0x450CF6C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x450D080", Offset = "0x4509080", VA = "0x450D080", Slot = "8")]
		public void VisualizeOriginalGraphUpdateBounds(Bounds bounds)
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x450D1E4", Offset = "0x45091E4", VA = "0x450D1E4", Slot = "4")]
void IWorkItemContext.QueueFloodFill()
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x450D1E8", Offset = "0x45091E8", VA = "0x450D1E8", Slot = "6")]
void IWorkItemContext.PreUpdate()
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x450D270", Offset = "0x4509270", VA = "0x450D270", Slot = "7")]
void IWorkItemContext.SetGraphDirty(NavGraph graph)
		{
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x450D2E0", Offset = "0x45092E0", VA = "0x450D2E0", Slot = "9")]
void IGraphUpdateContext.DirtyBounds(Bounds bounds)
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x450D32C", Offset = "0x450932C", VA = "0x450D32C")]
		internal void DirtyBounds(Bounds bounds)
		{
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x450D464", Offset = "0x4509464", VA = "0x450D464", Slot = "5")]
		public void EnsureValidFloodFill()
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x450D4D8", Offset = "0x45094D8", VA = "0x450D4D8")]
		public WorkItemProcessor(AstarPath astar)
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x450D5B0", Offset = "0x45095B0", VA = "0x450D5B0")]
		public void AddWorkItem(AstarWorkItem item)
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x450D624", Offset = "0x4509624", VA = "0x450D624")]
		private bool ProcessWorkItems(bool force, bool sendEvents)
		{
			return default;
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x450DB50", Offset = "0x4509B50", VA = "0x450DB50")]
		public bool ProcessWorkItemsForScan(bool force)
		{
			return default;
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x450DB5C", Offset = "0x4509B5C", VA = "0x450DB5C")]
		public bool ProcessWorkItemsForUpdate(bool force)
		{
			return default;
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x450DB68", Offset = "0x4509B68", VA = "0x450DB68")]
		public void DrawGizmos()
		{
		}
	}
}
