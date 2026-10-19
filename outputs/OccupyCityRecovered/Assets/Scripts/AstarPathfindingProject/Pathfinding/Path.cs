using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using Il2CppDummyDll;
using Pathfinding.Collections;
using Unity.Burst;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x20000B4")]
	[BurstCompile]
	public abstract class Path : IPathInternals
	{
		[Token(Token = "0x20000B5")]
		[BurstCompile]
		public struct SearchContext
		{
			[Token(Token = "0x20000B6")]
			public struct OpenCandidateParams
			{
				[Token(Token = "0x40003D6")]
				[FieldOffset(Offset = "0x0")]
				public UnsafeSpan<PathNode> pathNodes;

				[Token(Token = "0x40003D7")]
				[FieldOffset(Offset = "0x10")]
				public uint parentPathNode;

				[Token(Token = "0x40003D8")]
				[FieldOffset(Offset = "0x14")]
				public uint targetPathNode;

				[Token(Token = "0x40003D9")]
				[FieldOffset(Offset = "0x18")]
				public uint targetNodeIndex;

				[Token(Token = "0x40003DA")]
				[FieldOffset(Offset = "0x1C")]
				public uint targetG;

				[Token(Token = "0x40003DB")]
				[FieldOffset(Offset = "0x20")]
				public uint fractionAlongEdge;

				[Token(Token = "0x40003DC")]
				[FieldOffset(Offset = "0x24")]
				public int3 targetNodePosition;

				[Token(Token = "0x40003DD")]
				[FieldOffset(Offset = "0x30")]
				public ushort pathID;
			}

			[Token(Token = "0x20000B7")]
			public delegate void OpenCandidateConnectionBurst_000005D7_0024PostfixBurstDelegate(ref OpenCandidateParams pars, ref BinaryHeap heap, ref HeuristicObjective heuristicObjective);

			[Token(Token = "0x20000B8")]
			internal static class OpenCandidateConnectionBurst_000005D7_0024BurstDirectCall
			{
				[Token(Token = "0x40003DE")]
				[FieldOffset(Offset = "0x0")]
				private static IntPtr Pointer;

				[Token(Token = "0x40003DF")]
				[FieldOffset(Offset = "0x8")]
				private static IntPtr DeferredCompilation;

				[Token(Token = "0x6000623")]
				[Address(RVA = "0x45190D4", Offset = "0x45150D4", VA = "0x45190D4")]
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr P_0)
				{
				}

				[Token(Token = "0x6000624")]
				[Address(RVA = "0x45191F0", Offset = "0x45151F0", VA = "0x45191F0")]
				private static IntPtr GetFunctionPointer()
				{
					return default;
				}

				[Token(Token = "0x6000625")]
				[Address(RVA = "0x451924C", Offset = "0x451524C", VA = "0x451924C")]
				public static void Constructor()
				{
				}

				[Token(Token = "0x6000626")]
				[Address(RVA = "0x45192F4", Offset = "0x45152F4", VA = "0x45192F4")]
				public static void Initialize()
				{
				}

				[Token(Token = "0x6000628")]
				[Address(RVA = "0x4518788", Offset = "0x4514788", VA = "0x4518788")]
				public static void Invoke(ref OpenCandidateParams pars, ref BinaryHeap heap, ref HeuristicObjective heuristicObjective)
				{
				}
			}

			[Token(Token = "0x40003D0")]
			[FieldOffset(Offset = "0x0")]
			public Path path;

			[Token(Token = "0x40003D1")]
			[FieldOffset(Offset = "0x8")]
			public PathHandler pathHandler;

			[Token(Token = "0x40003D2")]
			[FieldOffset(Offset = "0x10")]
			public HeuristicObjective heuristicObjective;

			[Token(Token = "0x40003D3")]
			[FieldOffset(Offset = "0x48")]
			public TraversalConstraint traversalConstraint;

			[Token(Token = "0x40003D4")]
			[FieldOffset(Offset = "0x60")]
			public TraversalCosts traversalCosts;

			[Token(Token = "0x40003D5")]
			[FieldOffset(Offset = "0x78")]
			public ushort pathID;

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x6000615")]
			[Address(RVA = "0x45180F8", Offset = "0x45140F8", VA = "0x45180F8")]
			public bool ShouldConsiderPathNode(uint pathNodeIndex)
			{
				return default;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x6000616")]
			[Address(RVA = "0x45181D0", Offset = "0x45141D0", VA = "0x45181D0")]
			public void SkipOverNode(ref SearchContext ctx, uint pathNodeIndex, uint parentNodeIndex, uint fractionAlongEdge, uint hScore, uint gScore)
			{
			}

			[Token(Token = "0x6000617")]
			[Address(RVA = "0x4518350", Offset = "0x4514350", VA = "0x4518350")]
			public void OpenCandidateConnectionsToEndNode(Int3 position, uint parentPathNode, uint parentNodeIndex, uint parentG, float traversalCostFactor)
			{
			}

			[Token(Token = "0x6000618")]
			[Address(RVA = "0x4518608", Offset = "0x4514608", VA = "0x4518608")]
			public void OpenCandidateConnection(uint parentPathNode, uint targetPathNode, uint targetG, uint fractionAlongEdge, Int3 targetNodePosition)
			{
			}

			[Token(Token = "0x6000619")]
			[Address(RVA = "0x451871C", Offset = "0x451471C", VA = "0x451871C")]
			[BurstCompile]
			public static void OpenCandidateConnectionBurst(ref OpenCandidateParams pars, ref BinaryHeap heap, ref HeuristicObjective heuristicObjective)
			{
			}

			[Token(Token = "0x600061A")]
			[Address(RVA = "0x4518850", Offset = "0x4514850", VA = "0x4518850")]
			public readonly int3 FirstTemporaryEndNode()
			{
				return default;
			}

			[Token(Token = "0x600061B")]
			[Address(RVA = "0x4518900", Offset = "0x4514900", VA = "0x4518900")]
			public readonly void TemporaryEndNodesBoundingBox(out int3 mn, out int3 mx)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED Path.SearchContext.TemporaryEndNodesBoundingBox RVA=0x4518900 Token=0x600061B");
}

			[Token(Token = "0x600061C")]
			[Address(RVA = "0x4518A04", Offset = "0x4514A04", VA = "0x4518A04")]
			public void MarkNodesAdjacentToTemporaryEndNodes()
			{
			}

			[Token(Token = "0x600061D")]
			[Address(RVA = "0x4518BAC", Offset = "0x4514BAC", VA = "0x4518BAC")]
			public void AddStartNodesToHeap()
			{
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x600061E")]
			[Address(RVA = "0x4518C3C", Offset = "0x4514C3C", VA = "0x4518C3C")]
			[BurstCompile]
			public static void OpenCandidateConnectionBurst_0024BurstManaged(ref OpenCandidateParams pars, ref BinaryHeap heap, ref HeuristicObjective heuristicObjective)
			{
			}
		}

		[Token(Token = "0x20000B9")]
		[CompilerGenerated]
		private sealed class _003CWaitForPath_003Ed__55 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003E0")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40003E1")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40003E2")]
			[FieldOffset(Offset = "0x20")]
			public Path _003C_003E4__this;

			[Token(Token = "0x17000139")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600062C")]
				[Address(RVA = "0x45193B0", Offset = "0x45153B0", VA = "0x45193B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x1700013A")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600062E")]
				[Address(RVA = "0x45193F0", Offset = "0x45153F0", VA = "0x45193F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000629")]
			[Address(RVA = "0x45163A0", Offset = "0x45123A0", VA = "0x45163A0")]
			[DebuggerHidden]
			public _003CWaitForPath_003Ed__55(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600062A")]
			[Address(RVA = "0x45192FC", Offset = "0x45152FC", VA = "0x45192FC", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600062B")]
			[Address(RVA = "0x4519300", Offset = "0x4515300", VA = "0x4519300", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600062C")]
			[Address(RVA = "0x45193B0", Offset = "0x45153B0", VA = "0x45193B0", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600062D")]
			[Address(RVA = "0x45193B8", Offset = "0x45153B8", VA = "0x45193B8", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600062E")]
			[Address(RVA = "0x45193F0", Offset = "0x45153F0", VA = "0x45193F0", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x40003BA")]
		[FieldOffset(Offset = "0x10")]
		public OnPathDelegate callback;

		[Token(Token = "0x40003BB")]
		[FieldOffset(Offset = "0x18")]
		public OnPathDelegate immediateCallback;

		[Token(Token = "0x40003BD")]
		[FieldOffset(Offset = "0x24")]
		protected PathCompleteState completeState;

		[Token(Token = "0x40003BF")]
		[FieldOffset(Offset = "0x30")]
		public List<GraphNode> path;

		[Token(Token = "0x40003C0")]
		[FieldOffset(Offset = "0x38")]
		public List<Vector3> vectorPath;

		[Token(Token = "0x40003C3")]
		[FieldOffset(Offset = "0x48")]
		private bool Pathfinding_002EIPathInternals_002EPooled__BackingField;

		[Token(Token = "0x40003C4")]
		[FieldOffset(Offset = "0x49")]
		protected bool hasBeenReset;

		[Token(Token = "0x40003C5")]
		[FieldOffset(Offset = "0x50")]
		public TraversalCosts traversalCosts;

		[Token(Token = "0x40003C6")]
		[FieldOffset(Offset = "0x68")]
		public TraversalConstraint traversalConstraint;

		[Token(Token = "0x40003C7")]
		[FieldOffset(Offset = "0x80")]
		public DistanceMetric nearestNodeDistanceMetric;

		[Token(Token = "0x40003C8")]
		[FieldOffset(Offset = "0x90")]
		public Heuristic heuristic;

		[Token(Token = "0x40003C9")]
		[FieldOffset(Offset = "0x94")]
		public float heuristicScale;

		[Token(Token = "0x40003CB")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ProfilerMarker MarkerOpenCandidateConnectionsToEnd;

		[Token(Token = "0x40003CC")]
		[FieldOffset(Offset = "0x8")]
		public static readonly ProfilerMarker MarkerTrace;

		[Token(Token = "0x40003CD")]
		[FieldOffset(Offset = "0xA0")]
		private object[] claimed;

		[Token(Token = "0x40003CE")]
		[FieldOffset(Offset = "0xA8")]
		private int claimCount;

		[Token(Token = "0x40003CF")]
		[FieldOffset(Offset = "0xAC")]
		private bool releasedNotSilent;

		[Token(Token = "0x1700012C")]
		public PathState PipelineState
		{
			[Token(Token = "0x60005D5")]
			[Address(RVA = "0x4515E04", Offset = "0x4511E04", VA = "0x4515E04")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x60005D6")]
			[Address(RVA = "0x4515E0C", Offset = "0x4511E0C", VA = "0x4515E0C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700012D")]
		[Obsolete("Use path.traversalConstraint.traversalProvider and path.traversalCosts.traversalProvider instead")]
		public ITraversalProvider traversalProvider
		{
			[Token(Token = "0x60005D7")]
			[Address(RVA = "0x4515E14", Offset = "0x4511E14", VA = "0x4515E14")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005D8")]
			[Address(RVA = "0x4515E68", Offset = "0x4511E68", VA = "0x4515E68")]
			set
			{
			}
		}

		[Token(Token = "0x1700012E")]
		public PathCompleteState CompleteState
		{
			[Token(Token = "0x60005D9")]
			[Address(RVA = "0x4515ED8", Offset = "0x4511ED8", VA = "0x4515ED8")]
			get
			{
				return default;
			}
			[Token(Token = "0x60005DA")]
			[Address(RVA = "0x4515EE0", Offset = "0x4511EE0", VA = "0x4515EE0")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700012F")]
		public bool error
		{
			[Token(Token = "0x60005DB")]
			[Address(RVA = "0x4515FA8", Offset = "0x4511FA8", VA = "0x4515FA8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000130")]
		public string errorLog
		{
			[Token(Token = "0x60005DC")]
			[Address(RVA = "0x4515FB8", Offset = "0x4511FB8", VA = "0x4515FB8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60005DD")]
			[Address(RVA = "0x4515FC0", Offset = "0x4511FC0", VA = "0x4515FC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000131")]
		public float duration
		{
			[Token(Token = "0x60005DE")]
			[Address(RVA = "0x4515FC8", Offset = "0x4511FC8", VA = "0x4515FC8")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x60005DF")]
			[Address(RVA = "0x4515FD0", Offset = "0x4511FD0", VA = "0x4515FD0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Token(Token = "0x17000132")]
		public int searchedNodes
		{
			[Token(Token = "0x60005E0")]
			[Address(RVA = "0x4515FD8", Offset = "0x4511FD8", VA = "0x4515FD8")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x60005E1")]
			[Address(RVA = "0x4515FE0", Offset = "0x4511FE0", VA = "0x4515FE0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x17000133")]
bool IPathInternals.Pooled
		{
			[Token(Token = "0x60005E2")]
			[Address(RVA = "0x4515FE8", Offset = "0x4511FE8", VA = "0x4515FE8", Slot = "4")]
			get
			{
				return Pathfinding_002EIPathInternals_002Eget_Pooled();
			}
			[Token(Token = "0x60005E3")]
			[Address(RVA = "0x4515FF0", Offset = "0x4511FF0", VA = "0x4515FF0", Slot = "5")]
			set
			{
				Pathfinding_002EIPathInternals_002Eset_Pooled(value);
			}
		}

		[Token(Token = "0x17000134")]
		[Obsolete("Use the traversalConstraint field instead. Check the migration guide for version 5.4 for more information.")]
		public NNConstraintPathProxy nnConstraint
		{
			[Token(Token = "0x60005E4")]
			[Address(RVA = "0x4515FFC", Offset = "0x4511FFC", VA = "0x4515FFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000135")]
		public ushort pathID
		{
			[Token(Token = "0x60005E5")]
			[Address(RVA = "0x4516058", Offset = "0x4512058", VA = "0x4516058")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x60005E6")]
			[Address(RVA = "0x4516060", Offset = "0x4512060", VA = "0x4516060")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000136")]
		[Obsolete("Use traversalConstraint.tags instead")]
		public int enabledTags
		{
			[Token(Token = "0x60005E7")]
			[Address(RVA = "0x4516068", Offset = "0x4512068", VA = "0x4516068")]
			get
			{
				return default;
			}
			[Token(Token = "0x60005E8")]
			[Address(RVA = "0x4516070", Offset = "0x4512070", VA = "0x4516070")]
			set
			{
			}
		}

		[Token(Token = "0x17000137")]
		[Obsolete("Use traversalCosts.tagEntryCosts instead")]
		public uint[] tagPenalties
		{
			[Token(Token = "0x60005E9")]
			[Address(RVA = "0x4516078", Offset = "0x4512078", VA = "0x4516078")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005EA")]
			[Address(RVA = "0x4516080", Offset = "0x4512080", VA = "0x4516080")]
			set
			{
			}
		}

		[Token(Token = "0x17000138")]
		public NearestNodeConstraint nearestNodeConstraint
		{
			[Token(Token = "0x60005EB")]
			[Address(RVA = "0x4516088", Offset = "0x4512088", VA = "0x4516088")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x4515FE8", Offset = "0x4511FE8", VA = "0x4515FE8", Slot = "4")]
		private bool Pathfinding_002EIPathInternals_002Eget_Pooled()
		{
			return default;
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x4515FF0", Offset = "0x4511FF0", VA = "0x4515FF0", Slot = "5")]
		private void Pathfinding_002EIPathInternals_002Eset_Pooled(bool value)
		{
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x4516198", Offset = "0x4512198", VA = "0x4516198")]
		public void UseSettings(PathRequestSettings settings)
		{
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x45161F4", Offset = "0x45121F4", VA = "0x45161F4")]
		public float GetTotalLength()
		{
			return default;
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x4516340", Offset = "0x4512340", VA = "0x4516340")]
		[IteratorStateMachine(typeof(_003CWaitForPath_003Ed__55))]
		public IEnumerator WaitForPath()
		{
			return null;
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x45163C8", Offset = "0x45123C8", VA = "0x45163C8")]
		public void BlockUntilCalculated()
		{
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x4516420", Offset = "0x4512420", VA = "0x4516420")]
		[Obsolete("Use traversalCosts instead")]
		public uint GetTagPenalty(int tag)
		{
			return default;
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x4516454", Offset = "0x4512454", VA = "0x4516454")]
		[Obsolete("Use traversalConstraint.CanTraverse instead")]
		public bool CanTraverse(GraphNode node)
		{
			return default;
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x45164BC", Offset = "0x45124BC", VA = "0x45164BC")]
		[Obsolete("Use traversalConstraint.CanTraverse instead")]
		public bool CanTraverse(GraphNode from, GraphNode to)
		{
			return default;
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x451652C", Offset = "0x451252C", VA = "0x451652C")]
		[Obsolete("Use traversalCosts instead", true)]
		public uint GetTraversalCost(GraphNode node)
		{
			return default;
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x4516534", Offset = "0x4512534", VA = "0x4516534")]
		public bool IsDone()
		{
			return default;
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x4516544", Offset = "0x4512544", VA = "0x4516544", Slot = "6")]
void IPathInternals.AdvanceState(PathState s)
		{
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x4516650", Offset = "0x4512650", VA = "0x4516650")]
		public void FailWithError(string msg)
		{
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x45166EC", Offset = "0x45126EC", VA = "0x45166EC")]
		public void Error()
		{
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x45166F4", Offset = "0x45126F4", VA = "0x45166F4")]
		private void ErrorCheck()
		{
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x451680C", Offset = "0x451280C", VA = "0x451680C")]
		private void CheckTraversalProviderCompatibility()
		{
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x4516810", Offset = "0x4512810", VA = "0x4516810", Slot = "15")]
		protected virtual void OnEnterPool()
		{
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x451692C", Offset = "0x451292C", VA = "0x451692C", Slot = "16")]
		protected virtual void Reset()
		{
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x4516B50", Offset = "0x4512B50", VA = "0x4516B50")]
		public void Claim(object o)
		{
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x4516D20", Offset = "0x4512D20", VA = "0x4516D20")]
		public void Release(object o, bool silent = false)
		{
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x4516F64", Offset = "0x4512F64", VA = "0x4516F64", Slot = "17")]
		protected virtual void Trace(ref SearchContext ctx, uint fromPathNodeIndex)
		{
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x4516F6C", Offset = "0x4512F6C", VA = "0x4516F6C")]
		protected void Trace(ref SearchContext ctx, uint fromPathNodeIndex, bool reverse)
		{
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x45174F0", Offset = "0x45134F0", VA = "0x45174F0")]
		protected void DebugStringPrefix(PathLog logMode, StringBuilder text)
		{
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0x45176C0", Offset = "0x45136C0", VA = "0x45176C0")]
		protected void DebugStringSuffix(PathLog logMode, StringBuilder text)
		{
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0x451785C", Offset = "0x451385C", VA = "0x451785C", Slot = "18")]
		protected virtual void DebugString(StringBuilder builder, PathLog logMode)
		{
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x45178BC", Offset = "0x45138BC", VA = "0x45178BC", Slot = "19")]
		protected virtual void ReturnPath()
		{
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x45178DC", Offset = "0x45138DC", VA = "0x45178DC")]
		protected void PrepareBase(PathHandler pathHandler)
		{
		}

		[Token(Token = "0x6000605")]
		protected abstract void Prepare(ref SearchContext ctx);

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x4517A98", Offset = "0x4513A98", VA = "0x4517A98", Slot = "21")]
		protected virtual void Cleanup(ref SearchContext ctx)
		{
		}

		[Token(Token = "0x6000607")]
		protected abstract void OnHeapExhausted(ref SearchContext ctx);

		[Token(Token = "0x6000608")]
		protected abstract void OnFoundEndNode(ref SearchContext ctx, uint pathNode, uint hScore, uint gScore);

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x4517CB0", Offset = "0x4513CB0", VA = "0x4517CB0", Slot = "24")]
		public virtual void OnVisitNode(ref SearchContext ctx, uint pathNode, uint hScore, uint gScore)
		{
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x4517CB4", Offset = "0x4513CB4", VA = "0x4517CB4", Slot = "25")]
		protected virtual void CalculateStep(ref SearchContext ctx, long targetTick)
		{
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0x4517F34", Offset = "0x4513F34", VA = "0x4517F34", Slot = "7")]
void IPathInternals.OnEnterPool()
		{
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0x4517F44", Offset = "0x4513F44", VA = "0x4517F44", Slot = "8")]
void IPathInternals.Reset()
		{
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0x4517F54", Offset = "0x4513F54", VA = "0x4517F54", Slot = "9")]
void IPathInternals.ReturnPath()
		{
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0x4517F64", Offset = "0x4513F64", VA = "0x4517F64", Slot = "10")]
void IPathInternals.PrepareBase(PathHandler handler)
		{
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0x4517F68", Offset = "0x4513F68", VA = "0x4517F68", Slot = "11")]
void IPathInternals.Prepare(ref SearchContext ctx)
		{
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0x4517F78", Offset = "0x4513F78", VA = "0x4517F78", Slot = "12")]
void IPathInternals.Cleanup(ref SearchContext ctx)
		{
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0x4517F88", Offset = "0x4513F88", VA = "0x4517F88", Slot = "13")]
void IPathInternals.CalculateStep(ref SearchContext ctx, long targetTick)
		{
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x4517F98", Offset = "0x4513F98", VA = "0x4517F98", Slot = "14")]
void IPathInternals.DebugString(StringBuilder builder, PathLog logMode)
		{
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x4517FA8", Offset = "0x4513FA8", VA = "0x4517FA8")]
		protected Path()
		{
		}
	}
}
