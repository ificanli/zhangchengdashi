using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;
using Pathfinding;
using Pathfinding.Graphs.Navmesh;
using Pathfinding.Graphs.Util;
using Pathfinding.Sync;
using Pathfinding.Util;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.Serialization;

[Token(Token = "0x2000004")]
[ExecuteInEditMode]
[AddComponentMenu("Pathfinding/AstarPath")]
[HelpURL("https://arongranberg.com/astar/documentation/stable/astarpath.html")]
[DisallowMultipleComponent]
public class AstarPath : VersionedMonoBehaviour
{
	[Token(Token = "0x2000005")]
	public enum AstarDistribution
	{
		[Token(Token = "0x4000041")]
		WebsiteDownload = 0,
		[Token(Token = "0x4000042")]
		AssetStore = 1,
		[Token(Token = "0x4000043")]
		PackageManager = 2
	}

	[Token(Token = "0x2000006")]
	private class DummyGraphUpdateContext : IGraphUpdateContext
	{
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x444592C", Offset = "0x444192C", VA = "0x444592C", Slot = "4")]
		public void DirtyBounds(Bounds bounds)
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x4445930", Offset = "0x4441930", VA = "0x4445930")]
		public DummyGraphUpdateContext()
		{
		}
	}

	[Token(Token = "0x2000007")]
	private class DestroyGraphPromise : IGraphUpdatePromise
	{
		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IGraphInternals graph;

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x4445938", Offset = "0x4441938", VA = "0x4445938", Slot = "5")]
		public IEnumerator<JobHandle> Prepare()
		{
			return null;
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x4445940", Offset = "0x4441940", VA = "0x4445940", Slot = "6")]
		public void Apply(IGraphUpdateContext context)
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x44459E4", Offset = "0x44419E4", VA = "0x44459E4")]
		public DestroyGraphPromise()
		{
		}
	}

	[Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class _003CScanInternal_003Ed__130 : IEnumerable<Progress>, IEnumerable, IEnumerator<Progress>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private Progress _003C_003E2__current;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int _003C_003El__initialThreadId;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private NavGraph[] graphsToScan;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public NavGraph[] _003C_003E3__graphsToScan;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AstarPath _003C_003E4__this;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool async;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		public bool _003C_003E3__async;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private PathProcessor.GraphUpdateLock _003CgraphUpdateLock_003E5__2;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Stopwatch _003Cwatch_003E5__3;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private List<(IGraphUpdatePromise, IEnumerator<JobHandle>)> _003Cpromises_003E5__4;

		[Token(Token = "0x1700000C")]
Progress System.Collections.Generic.IEnumerator<Pathfinding.Progress>.Current
		{
			[Token(Token = "0x6000062")]
			[Address(RVA = "0x44471E8", Offset = "0x44431E8", VA = "0x44471E8", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CPathfinding_002EProgress_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700000D")]
object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000064")]
			[Address(RVA = "0x4447230", Offset = "0x4443230", VA = "0x4447230", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x444392C", Offset = "0x443F92C", VA = "0x444392C")]
		[DebuggerHidden]
		public _003CScanInternal_003Ed__130(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x4445C74", Offset = "0x4441C74", VA = "0x4445C74", Slot = "7")]
		[DebuggerHidden]
void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x4445C78", Offset = "0x4441C78", VA = "0x4445C78", Slot = "8")]
bool System.Collections.IEnumerator.MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x44471E8", Offset = "0x44431E8", VA = "0x44471E8", Slot = "6")]
		[DebuggerHidden]
		private Progress System_002ECollections_002EGeneric_002EIEnumerator_003CPathfinding_002EProgress_003E_002Eget_Current()
		{
			return default;
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x44471F8", Offset = "0x44431F8", VA = "0x44471F8", Slot = "10")]
		[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x4447230", Offset = "0x4443230", VA = "0x4447230", Slot = "9")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x444728C", Offset = "0x444328C", VA = "0x444728C", Slot = "4")]
		[DebuggerHidden]
IEnumerator<Progress> System.Collections.Generic.IEnumerable<Pathfinding.Progress>.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x4447338", Offset = "0x4443338", VA = "0x4447338", Slot = "5")]
		[DebuggerHidden]
IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class _003CTickAsyncScanUntilCompletion_003Ed__127 : IEnumerable<Progress>, IEnumerable, IEnumerator<Progress>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private Progress _003C_003E2__current;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int _003C_003El__initialThreadId;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IEnumerator<Progress> task;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IEnumerator<Progress> _003C_003E3__task;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AstarPath _003C_003E4__this;

		[Token(Token = "0x1700000E")]
Progress System.Collections.Generic.IEnumerator<Pathfinding.Progress>.Current
		{
			[Token(Token = "0x600006A")]
			[Address(RVA = "0x4447544", Offset = "0x4443544", VA = "0x4447544", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CPathfinding_002EProgress_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700000F")]
object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600006C")]
			[Address(RVA = "0x444758C", Offset = "0x444358C", VA = "0x444758C", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x44438F8", Offset = "0x443F8F8", VA = "0x44438F8")]
		[DebuggerHidden]
		public _003CTickAsyncScanUntilCompletion_003Ed__127(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x444733C", Offset = "0x444333C", VA = "0x444733C", Slot = "7")]
		[DebuggerHidden]
void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x4447340", Offset = "0x4443340", VA = "0x4447340", Slot = "8")]
bool System.Collections.IEnumerator.MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x4447544", Offset = "0x4443544", VA = "0x4447544", Slot = "6")]
		[DebuggerHidden]
		private Progress System_002ECollections_002EGeneric_002EIEnumerator_003CPathfinding_002EProgress_003E_002Eget_Current()
		{
			return default;
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x4447554", Offset = "0x4443554", VA = "0x4447554", Slot = "10")]
		[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x444758C", Offset = "0x444358C", VA = "0x444758C", Slot = "9")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x44475E8", Offset = "0x44435E8", VA = "0x44475E8", Slot = "4")]
		[DebuggerHidden]
IEnumerator<Progress> System.Collections.Generic.IEnumerable<Pathfinding.Progress>.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x444768C", Offset = "0x444368C", VA = "0x444768C", Slot = "5")]
		[DebuggerHidden]
IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class _003CUpdateGraphsInternal_003Ed__105 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float delay;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AstarPath _003C_003E4__this;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GraphUpdateObject ob;

		[Token(Token = "0x17000010")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000072")]
			[Address(RVA = "0x4447740", Offset = "0x4443740", VA = "0x4447740", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000011")]
object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000074")]
			[Address(RVA = "0x4447780", Offset = "0x4443780", VA = "0x4447780", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x4442298", Offset = "0x443E298", VA = "0x4442298")]
		[DebuggerHidden]
		public _003CUpdateGraphsInternal_003Ed__105(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x4447690", Offset = "0x4443690", VA = "0x4447690", Slot = "5")]
		[DebuggerHidden]
void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x4447694", Offset = "0x4443694", VA = "0x4447694", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x4447740", Offset = "0x4443740", VA = "0x4447740", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x4447748", Offset = "0x4443748", VA = "0x4447748", Slot = "8")]
		[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x4447780", Offset = "0x4443780", VA = "0x4447780", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly Version Version = new Version(5,4,4);

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static readonly AstarDistribution Distribution = AstarDistribution.AssetStore;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static readonly string Branch = (waitForPathDepth = 0) == 0 ? "master" : "master";

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[FormerlySerializedAs("astarData")]
	public AstarData data;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static AstarPath active;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool hasScannedGraphAtStartup;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	public bool showNavGraphs;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
	public bool showUnwalkableNodes;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public GraphDebugMode debugMode;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GraphUpdateDebugMode graphUpdateDebugMode;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float debugFloor;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float debugRoof;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public bool manualDebugFloorRoof;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
	public bool showSearchTree;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float unwalkableNodeDebugSize;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public PathLog logPathResults;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float maxNearestNodeDistance;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public bool scanOnStartup;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
	[Obsolete("This setting has been removed. It is now always true", true)]
	public bool fullGetNearestSearch;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x56")]
	[Obsolete("This setting has been removed. It was always a bit of a hack. Use TraversalConstraint.graphMask if you want to choose which graphs are searched.", true)]
	public bool prioritizeGraphs;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[Obsolete("This setting has been removed. It was always a bit of a hack. Use TraversalConstraint.graphMask if you want to choose which graphs are searched.", true)]
	public float prioritizeGraphsLimit;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public AstarColor colorSettings;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	protected string[] tagNames;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Heuristic heuristic;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public float heuristicScale;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public ThreadCount threadCount;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public float maxFrameTime;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public bool batchGraphUpdates;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public float graphUpdateBatchingInterval;

	[NonSerialized]
	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	internal PathHandler debugPathData;

	[NonSerialized]
	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	internal ushort debugPathID;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private string inGameDebugPath;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static Action OnAwakeSettings;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static OnGraphDelegate OnGraphPreScan;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static OnGraphDelegate OnGraphPostScan;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public static OnPathDelegate OnPathPreSearch;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public static OnPathDelegate OnPathPostSearch;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public static OnScanDelegate OnPreScan;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public static OnScanDelegate OnPostScan;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public static OnScanDelegate OnLatePostScan;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public static OnScanDelegate OnGraphsUpdated;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public static Action On65KOverflow;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public static Action OnPathsCalculated;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private readonly GraphUpdateProcessor graphUpdates;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	internal readonly HierarchicalGraph hierarchicalGraph;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public readonly OffMeshLinks offMeshLinks;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public NavmeshUpdates navmeshUpdates;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly WorkItemProcessor workItems;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	internal readonly PathProcessor pathProcessor;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	internal GlobalNodeStorage nodeStorage;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private RWLock graphDataLock;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private bool graphUpdatesWorkItemAdded;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	private float lastGraphUpdate;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private PathProcessor.GraphUpdateLock workItemLock;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	internal readonly PathReturnQueue pathReturnQueue;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public EuclideanEmbedding euclideanEmbedding;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private IEnumerator<Progress> asyncScanTask;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public bool showGraphs;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x121")]
	public bool showGraphsInStandalonePlayer;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x122")]
	private ushort nextFreePathID;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private static int waitForPathDepth;

	[Token(Token = "0x17000001")]
	public NavGraph[] graphs
	{
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x4440C90", Offset = "0x443CC90", VA = "0x4440C90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000002")]
	public float maxNearestNodeDistanceSqr
	{
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x4440CAC", Offset = "0x443CCAC", VA = "0x4440CAC")]
		get
		{ return maxNearestNodeDistance * maxNearestNodeDistance; }
	}

	[Token(Token = "0x17000003")]
	public float effectiveHeuristicScale
	{
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x4440CB8", Offset = "0x443CCB8", VA = "0x4440CB8")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x17000004")]
	public float lastScanTime
	{
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x4440CD0", Offset = "0x443CCD0", VA = "0x4440CD0")]
		[CompilerGenerated]
		get
		{
			return default;
		}
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x4440CD8", Offset = "0x443CCD8", VA = "0x4440CD8")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[field: Token(Token = "0x4000022")]
[field: Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
[field: System.NonSerialized]
[Token(Token = "0x17000005")]
	public bool isScanning
	{
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x4440CE0", Offset = "0x443CCE0", VA = "0x4440CE0")]
		[CompilerGenerated]
		get
		;
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x4440CE8", Offset = "0x443CCE8", VA = "0x4440CE8")]
		[CompilerGenerated]
		private set
		;
	}

	[Token(Token = "0x17000006")]
	public int NumParallelThreads
	{
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x4440CF4", Offset = "0x443CCF4", VA = "0x4440CF4")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x17000007")]
	public bool IsUsingMultithreading
	{
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x4440D10", Offset = "0x443CD10", VA = "0x4440D10")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x17000008")]
	public bool IsAnyGraphUpdateQueued
	{
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x4440D2C", Offset = "0x443CD2C", VA = "0x4440D2C")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x17000009")]
	public bool IsAnyGraphUpdateInProgress
	{
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x4440D48", Offset = "0x443CD48", VA = "0x4440D48")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x1700000A")]
	public bool IsAnyWorkItemInProgress
	{
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x4440D64", Offset = "0x443CD64", VA = "0x4440D64")]
		get
		{ return workItems.workItemsInProgress; }
	}

	[Token(Token = "0x1700000B")]
	internal bool IsInsideWorkItem
	{
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x4440D80", Offset = "0x443CD80", VA = "0x4440D80")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x4440D9C", Offset = "0x443CD9C", VA = "0x4440D9C")]
	private AstarPath()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x44412E4", Offset = "0x443D2E4", VA = "0x44412E4")]
	public string[] GetTagNames()
	{
		return null;
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x44413F4", Offset = "0x443D3F4", VA = "0x44413F4")]
	public static void FindAstarPath()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x44415DC", Offset = "0x443D5DC", VA = "0x44415DC")]
	public static string[] FindTagNames()
	{
		return null;
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x44416EC", Offset = "0x443D6EC", VA = "0x44416EC")]
	internal ushort GetNextPathID()
	{
 if (nextFreePathID == 0) {
  nextFreePathID = 1;
  var overflow = On65KOverflow;
  if (overflow != null) {
   On65KOverflow = null;
   overflow();
  }
 }
 ushort result = nextFreePathID;
 nextFreePathID = unchecked((ushort)(nextFreePathID + 1));
 return result;
}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x44417A4", Offset = "0x443D7A4", VA = "0x44417A4")]
	private void RecalculateDebugLimits()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x44417B4", Offset = "0x443D7B4", VA = "0x44417B4", Slot = "6")]
	public override void DrawGizmos()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x4441ADC", Offset = "0x443DADC", VA = "0x4441ADC")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x4441B90", Offset = "0x443DB90", VA = "0x4441B90")]
	private void LogPathResults(StringBuilder debugStringBuilder, Path path)
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x4441D0C", Offset = "0x443DD0C", VA = "0x4441D0C")]
	private void Update()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x4441E80", Offset = "0x443DE80", VA = "0x4441E80")]
	private void PerformBlockingActions(bool force = false)
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x4441F38", Offset = "0x443DF38", VA = "0x4441F38")]
	public void AddWorkItem(Action callback)
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x4441FD8", Offset = "0x443DFD8", VA = "0x4441FD8")]
	public void AddWorkItem(Action<IWorkItemContext> callback)
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x4441F7C", Offset = "0x443DF7C", VA = "0x4441F7C")]
	public void AddWorkItem(AstarWorkItem item)
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x444203C", Offset = "0x443E03C", VA = "0x444203C")]
	public void QueueGraphUpdates()
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x4441E28", Offset = "0x443DE28", VA = "0x4441E28")]
	private void TryQueueGraphUpdates()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x4442154", Offset = "0x443E154", VA = "0x4442154")]
	public void UpdateGraphs(Bounds bounds, float delay)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x44421FC", Offset = "0x443E1FC", VA = "0x44421FC")]
	public void UpdateGraphs(GraphUpdateObject ob, float delay)
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x444221C", Offset = "0x443E21C", VA = "0x444221C")]
	[IteratorStateMachine(typeof(_003CUpdateGraphsInternal_003Ed__105))]
	private IEnumerator UpdateGraphsInternal(GraphUpdateObject ob, float delay)
	{
		return null;
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x44422C0", Offset = "0x443E2C0", VA = "0x44422C0")]
	public void UpdateGraphs(Bounds bounds)
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x4442348", Offset = "0x443E348", VA = "0x4442348")]
	public void UpdateGraphs(GraphUpdateObject ob)
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x44423D0", Offset = "0x443E3D0", VA = "0x44423D0")]
	public void FlushGraphUpdates()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x444241C", Offset = "0x443E41C", VA = "0x444241C")]
	public void FlushWorkItems()
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x4442604", Offset = "0x443E604", VA = "0x4442604")]
	private void InitializePathProcessor()
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x4441A6C", Offset = "0x443DA6C", VA = "0x4441A6C")]
	private void InitializeColors()
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x44426AC", Offset = "0x443E6AC", VA = "0x44426AC")]
	private void ShutdownPathfindingThreads()
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x44427F8", Offset = "0x443E7F8", VA = "0x44427F8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x4442E2C", Offset = "0x443EE2C", VA = "0x4442E2C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x4443064", Offset = "0x443F064", VA = "0x4443064")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600002D")]
	public JobHandle AllocateNodes<T>(T[] result, int count, Func<T> createNode, uint variantsPerNode) where T : GraphNode
	{ if (!pathProcessor.queue.allReceiversBlocked) throw new Exception("Trying to initialize a node when it is not safe to initialize any nodes. Must be done during a graph update. See http://arongranberg.com/astar/docs/graph-updates.html#direct"); return nodeStorage.AllocateNodesJob(result, count, createNode, variantsPerNode); }

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x4443270", Offset = "0x443F270", VA = "0x4443270")]
	internal void InitializeNode(GraphNode node)
	{ if (!pathProcessor.queue.allReceiversBlocked) throw new Exception("Trying to initialize a node when it is not safe to initialize any nodes. Must be done during a graph update. See http://arongranberg.com/astar/docs/graph-updates.html#direct"); nodeStorage.InitializeNode(node); }

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x444332C", Offset = "0x443F32C", VA = "0x444332C")]
	internal void InitializeNodes(GraphNode[] nodes)
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x444342C", Offset = "0x443F42C", VA = "0x444342C")]
	internal void DestroyNode(GraphNode node)
	{ nodeStorage.DestroyNode(node); }

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x44425B4", Offset = "0x443E5B4", VA = "0x44425B4")]
	public PathProcessor.GraphUpdateLock PausePathfinding()
	{
		return default;
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x444201C", Offset = "0x443E01C", VA = "0x444201C")]
	public PathProcessor.GraphUpdateLock PausePathfindingSoon()
	{
		return default;
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x4442FBC", Offset = "0x443EFBC", VA = "0x4442FBC")]
	private void BlockUntilAsyncScanComplete()
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x4443448", Offset = "0x443F448", VA = "0x4443448")]
	public void Scan(NavGraph graphToScan)
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x4442B00", Offset = "0x443EB00", VA = "0x4442B00")]
	public void Scan([Optional] NavGraph[] graphsToScan)
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x444359C", Offset = "0x443F59C", VA = "0x444359C")]
	public IEnumerable<Progress> ScanAsync(NavGraph graphToScan)
	{
		return null;
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x4443668", Offset = "0x443F668", VA = "0x4443668")]
	public IEnumerable<Progress> ScanAsync([Optional] NavGraph[] graphsToScan)
	{
		return null;
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x444387C", Offset = "0x443F87C", VA = "0x444387C")]
	[IteratorStateMachine(typeof(_003CTickAsyncScanUntilCompletion_003Ed__127))]
	private IEnumerable<Progress> TickAsyncScanUntilCompletion(IEnumerator<Progress> task)
	{
		return null;
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x4443514", Offset = "0x443F514", VA = "0x4443514")]
	[IteratorStateMachine(typeof(_003CScanInternal_003Ed__130))]
	private IEnumerable<Progress> ScanInternal(NavGraph[] graphsToScan, bool async)
	{
		return null;
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x4443960", Offset = "0x443F960", VA = "0x4443960")]
	internal void DirtyBounds(Bounds bounds)
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x44439F0", Offset = "0x443F9F0", VA = "0x44439F0")]
	internal void VisualizeOriginalGraphUpdateBounds(Bounds bounds)
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x4443A3C", Offset = "0x443FA3C", VA = "0x4443A3C")]
	public static void BlockUntilCalculated(Path path)
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x4443F2C", Offset = "0x443FF2C", VA = "0x4443F2C")]
	public static void StartPath(Path path, bool pushToFront = false, bool assumeInPlayMode = false)
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x4444360", Offset = "0x4440360", VA = "0x4444360")]
	public bool IsPointOnNavmesh(Vector3 position)
	{
		return default;
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x4444460", Offset = "0x4440460", VA = "0x4444460")]
	public NNInfo GetNearest(Vector3 position)
	{
		return default;
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x4444530", Offset = "0x4440530", VA = "0x4444530")]
	[Obsolete("NNConstraint is obsolete. Use the overload that takes a NearestNodeConstraint instead")]
	public NNInfo GetNearest(Vector3 position, NNConstraint constraint)
	{
		return default;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Token(Token = "0x6000041")]
	[Address(RVA = "0x4444658", Offset = "0x4440658", VA = "0x4444658")]
	public NNInfo GetNearest(Vector3 position, NearestNodeConstraint constraint)
	{ return GetNearest(position, ref constraint); }

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x4444688", Offset = "0x4440688", VA = "0x4444688")]
	internal NNInfo GetNearest(Vector3 position, ref NearestNodeConstraint constraint)
	{
 var graphs = data.graphs;
 constraint.maxDistanceSqr = constraint.maxDistanceSqrOrDefault(AstarPath.active);
 NNInfo nearest = NNInfo.Empty;
 if (graphs == null || graphs.Length == 0) return nearest;
 if (graphs.Length == 1) {
  var graph = graphs[0];
  if (graph != null && constraint.graphMask.Contains(graph)) nearest = graph.GetNearest(position, ref constraint);
  return nearest;
 }
 unsafe {
  var buffer = stackalloc System.ValueTuple<float, uint>[graphs.Length];
  global::Unity.Collections.LowLevel.Unsafe.UnsafeUtility.MemClear(buffer, graphs.Length * 8L);
  var candidates = new Pathfinding.Collections.UnsafeSpan<System.ValueTuple<float, uint>>(buffer, graphs.Length);
  int count = 0;
  for (uint i = 0; i < graphs.Length; i++) {
   var graph = graphs[i];
   if (graph == null || !constraint.graphMask.Contains(i)) continue;
   float lowerBound = graph.NearestNodeDistanceSqrLowerBound(position, ref constraint);
   if (lowerBound <= constraint.maxDistanceSqr) candidates[count++] = (lowerBound, i);
  }
  candidates = candidates.Slice(0, count);
  Pathfinding.Collections.SpanExtensions.Sort(candidates);
  for (int i = 0; i < candidates.Length; i++) {
   if (candidates[i].Item1 > constraint.maxDistanceSqr) break;
   var candidate = graphs[candidates[i].Item2].GetNearest(position, ref constraint);
   if (candidate.distanceCostSqr < constraint.maxDistanceSqr) {
    constraint.maxDistanceSqr = candidate.distanceCostSqr;
    nearest = candidate;
   }
  }
 }
 return nearest;
}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x4444C0C", Offset = "0x4440C0C", VA = "0x4444C0C")]
	public bool GetNearestBorder(Vector3 position, NearestNodeConstraint constraint, out GraphHitInfo hit)
	{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED AstarPath.GetNearestBorder RVA=0x4444C0C Token=0x6000043");
}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x4444C9C", Offset = "0x4440C9C", VA = "0x4444C9C")]
	public bool GetNearestBorder(Vector3 position, GraphNode sourceNode, out GraphHitInfo hit)
	{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED AstarPath.GetNearestBorder RVA=0x4444C9C Token=0x6000044");
}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x4444F4C", Offset = "0x4440F4C", VA = "0x4444F4C")]
	public bool Linecast(Vector3 start, Vector3 end)
	{
		return default;
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x444518C", Offset = "0x444118C", VA = "0x444518C")]
	public bool Linecast(Vector3 start, Vector3 end, out GraphHitInfo hit)
	{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED AstarPath.Linecast RVA=0x444518C Token=0x6000046");
}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x4445060", Offset = "0x4441060", VA = "0x4445060")]
	private IRaycastableGraph ClosestRaycastableGraph(Vector3 point)
	{
		return null;
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x44452C4", Offset = "0x44412C4", VA = "0x44452C4")]
	public GraphNode GetNearest(Ray ray)
	{
		return null;
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x4445430", Offset = "0x4441430", VA = "0x4445430")]
	public GraphSnapshot Snapshot(Bounds bounds, GraphMask graphMask)
	{
		return default;
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x44455D4", Offset = "0x44415D4", VA = "0x44455D4")]
	public RWLock.ReadLockAsync LockGraphDataForReading()
	{
		return default;
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x4445614", Offset = "0x4441614", VA = "0x4445614")]
	public RWLock.WriteLockAsync LockGraphDataForWriting()
	{
		return default;
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x4445654", Offset = "0x4441654", VA = "0x4445654")]
	public RWLock.LockSync LockGraphDataForWritingSync()
	{
		return default;
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x4444F04", Offset = "0x4440F04", VA = "0x4444F04")]
	public NavmeshEdges.NavmeshBorderData GetNavmeshBorderData(out RWLock.CombinedReadLockAsync readLock)
	{ return hierarchicalGraph.navmeshEdges.GetNavmeshEdgeData(out readLock); }
}
