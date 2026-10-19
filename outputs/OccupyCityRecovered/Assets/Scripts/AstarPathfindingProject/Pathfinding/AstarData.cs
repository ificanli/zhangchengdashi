using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Pathfinding.Serialization;
using Unity.Profiling;
using UnityEngine;

namespace Pathfinding
{
	[Serializable]
	[Token(Token = "0x2000048")]
	public class AstarData
	{
		[Token(Token = "0x200004D")]
		[CompilerGenerated]
		private sealed class _003CFindGraphsOfType_003Ed__80 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001ED")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40001EE")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40001EF")]
			[FieldOffset(Offset = "0x20")]
			private int _003C_003El__initialThreadId;

			[Token(Token = "0x40001F0")]
			[FieldOffset(Offset = "0x28")]
			public AstarData _003C_003E4__this;

			[Token(Token = "0x40001F1")]
			[FieldOffset(Offset = "0x30")]
			private Type type;

			[Token(Token = "0x40001F2")]
			[FieldOffset(Offset = "0x38")]
			public Type _003C_003E3__type;

			[Token(Token = "0x40001F3")]
			[FieldOffset(Offset = "0x40")]
			private int _003Ci_003E5__2;

			[Token(Token = "0x170000CC")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60002EE")]
				[Address(RVA = "0x4463178", Offset = "0x445F178", VA = "0x4463178", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170000CD")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002F0")]
				[Address(RVA = "0x44631B8", Offset = "0x445F1B8", VA = "0x44631B8", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60002EB")]
			[Address(RVA = "0x4462AC8", Offset = "0x445EAC8", VA = "0x4462AC8")]
			[DebuggerHidden]
			public _003CFindGraphsOfType_003Ed__80(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60002EC")]
			[Address(RVA = "0x4463094", Offset = "0x445F094", VA = "0x4463094", Slot = "7")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60002ED")]
			[Address(RVA = "0x4463098", Offset = "0x445F098", VA = "0x4463098", Slot = "8")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60002EE")]
			[Address(RVA = "0x4463178", Offset = "0x445F178", VA = "0x4463178", Slot = "6")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60002EF")]
			[Address(RVA = "0x4463180", Offset = "0x445F180", VA = "0x4463180", Slot = "10")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60002F0")]
			[Address(RVA = "0x44631B8", Offset = "0x445F1B8", VA = "0x44631B8", Slot = "9")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60002F1")]
			[Address(RVA = "0x44631C0", Offset = "0x445F1C0", VA = "0x44631C0", Slot = "4")]
			[DebuggerHidden]
IEnumerator<object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60002F2")]
			[Address(RVA = "0x4463264", Offset = "0x445F264", VA = "0x4463264", Slot = "5")]
			[DebuggerHidden]
IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x200004E")]
		[CompilerGenerated]
		private sealed class _003CGetUpdateableGraphs_003Ed__81 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001F4")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40001F5")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40001F6")]
			[FieldOffset(Offset = "0x20")]
			private int _003C_003El__initialThreadId;

			[Token(Token = "0x40001F7")]
			[FieldOffset(Offset = "0x28")]
			public AstarData _003C_003E4__this;

			[Token(Token = "0x40001F8")]
			[FieldOffset(Offset = "0x30")]
			private int _003Ci_003E5__2;

			[Token(Token = "0x170000CE")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60002F6")]
				[Address(RVA = "0x4463364", Offset = "0x445F364", VA = "0x4463364", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170000CF")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002F8")]
				[Address(RVA = "0x44633A4", Offset = "0x445F3A4", VA = "0x44633A4", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60002F3")]
			[Address(RVA = "0x4462B6C", Offset = "0x445EB6C", VA = "0x4462B6C")]
			[DebuggerHidden]
			public _003CGetUpdateableGraphs_003Ed__81(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60002F4")]
			[Address(RVA = "0x4463268", Offset = "0x445F268", VA = "0x4463268", Slot = "7")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60002F5")]
			[Address(RVA = "0x446326C", Offset = "0x445F26C", VA = "0x446326C", Slot = "8")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60002F6")]
			[Address(RVA = "0x4463364", Offset = "0x445F364", VA = "0x4463364", Slot = "6")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60002F7")]
			[Address(RVA = "0x446336C", Offset = "0x445F36C", VA = "0x446336C", Slot = "10")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60002F8")]
			[Address(RVA = "0x44633A4", Offset = "0x445F3A4", VA = "0x44633A4", Slot = "9")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60002F9")]
			[Address(RVA = "0x44633AC", Offset = "0x445F3AC", VA = "0x44633AC", Slot = "4")]
			[DebuggerHidden]
IEnumerator<object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60002FA")]
			[Address(RVA = "0x4463448", Offset = "0x445F448", VA = "0x4463448", Slot = "5")]
			[DebuggerHidden]
IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x40001D6")]
		[FieldOffset(Offset = "0x10")]
		private AstarPath active;

		[NonSerialized]
		[Token(Token = "0x40001DE")]
		[FieldOffset(Offset = "0x48")]
		public NavGraph[] graphs;

		[Token(Token = "0x40001DF")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private string dataString;

		[Token(Token = "0x40001E0")]
		[FieldOffset(Offset = "0x58")]
		public TextAsset file_cachedStartup;

		[Token(Token = "0x40001E1")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		public bool cacheStartup;

		[Token(Token = "0x40001E2")]
		[FieldOffset(Offset = "0x68")]
		private List<bool> graphStructureLocked;

		[Token(Token = "0x40001E3")]
		[FieldOffset(Offset = "0x8")]
		private static readonly ProfilerMarker MarkerLoadFromCache;

		[Token(Token = "0x40001E4")]
		[FieldOffset(Offset = "0x10")]
		private static readonly ProfilerMarker MarkerDeserializeGraphs;

		[Token(Token = "0x40001E5")]
		[FieldOffset(Offset = "0x18")]
		private static readonly ProfilerMarker MarkerSerializeGraphs;

		[Token(Token = "0x40001E6")]
		[FieldOffset(Offset = "0x20")]
		private static readonly ProfilerMarker MarkerFindGraphTypes;

		[Token(Token = "0x170000C3")]
		[Obsolete("Use navmeshGraph instead")]
		public NavMeshGraph navmesh
		{
			[Token(Token = "0x60002A7")]
			[Address(RVA = "0x445FA74", Offset = "0x445BA74", VA = "0x445FA74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C4")]
		public NavMeshGraph navmeshGraph
		{
			[Token(Token = "0x60002A8")]
			[Address(RVA = "0x445FA7C", Offset = "0x445BA7C", VA = "0x445FA7C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002A9")]
			[Address(RVA = "0x445FA84", Offset = "0x445BA84", VA = "0x445FA84")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000C5")]
		public GridGraph gridGraph
		{
			[Token(Token = "0x60002AA")]
			[Address(RVA = "0x445FA8C", Offset = "0x445BA8C", VA = "0x445FA8C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002AB")]
			[Address(RVA = "0x445FA94", Offset = "0x445BA94", VA = "0x445FA94")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000C6")]
		public LayerGridGraph layerGridGraph
		{
			[Token(Token = "0x60002AC")]
			[Address(RVA = "0x445FA9C", Offset = "0x445BA9C", VA = "0x445FA9C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002AD")]
			[Address(RVA = "0x445FAA4", Offset = "0x445BAA4", VA = "0x445FAA4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000C7")]
		public PointGraph pointGraph
		{
			[Token(Token = "0x60002AE")]
			[Address(RVA = "0x445FAAC", Offset = "0x445BAAC", VA = "0x445FAAC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002AF")]
			[Address(RVA = "0x445FAB4", Offset = "0x445BAB4", VA = "0x445FAB4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000C8")]
		public RecastGraph recastGraph
		{
			[Token(Token = "0x60002B0")]
			[Address(RVA = "0x445FABC", Offset = "0x445BABC", VA = "0x445FABC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002B1")]
			[Address(RVA = "0x445FAC4", Offset = "0x445BAC4", VA = "0x445FAC4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000C9")]
		public LinkGraph linkGraph
		{
			[Token(Token = "0x60002B2")]
			[Address(RVA = "0x445FACC", Offset = "0x445BACC", VA = "0x445FACC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002B3")]
			[Address(RVA = "0x445FAD4", Offset = "0x445BAD4", VA = "0x445FAD4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000CA")]
		public static Type[] graphTypes
		{
			[Token(Token = "0x60002B4")]
			[Address(RVA = "0x445FADC", Offset = "0x445BADC", VA = "0x445FADC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002B5")]
			[Address(RVA = "0x445FB34", Offset = "0x445BB34", VA = "0x445FB34")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000CB")]
		private byte[] data
		{
			[Token(Token = "0x60002B6")]
			[Address(RVA = "0x445FB90", Offset = "0x445BB90", VA = "0x445FB90")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002B7")]
			[Address(RVA = "0x445FC04", Offset = "0x445BC04", VA = "0x445FC04")]
			set
			{
			}
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x445FC7C", Offset = "0x445BC7C", VA = "0x445FC7C")]
		internal AstarData(AstarPath active)
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x445FD30", Offset = "0x445BD30", VA = "0x445FD30")]
		public byte[] GetData()
		{
			return null;
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x445FD34", Offset = "0x445BD34", VA = "0x445FD34")]
		public void SetData(byte[] data)
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x445FD38", Offset = "0x445BD38", VA = "0x445FD38")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x44601F8", Offset = "0x445C1F8", VA = "0x44601F8")]
		internal void LockGraphStructure(bool allowAddingGraphs = false)
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x44602A0", Offset = "0x445C2A0", VA = "0x44602A0")]
		internal void UnlockGraphStructure()
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x446033C", Offset = "0x445C33C", VA = "0x446033C")]
		private PathProcessor.GraphUpdateLock AssertSafe(bool onlyAddingGraph = false)
		{
			return default;
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x4460490", Offset = "0x445C490", VA = "0x4460490")]
		public void GetNodes(Action<GraphNode> callback)
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x4460500", Offset = "0x445C500", VA = "0x4460500")]
		public void UpdateShortcuts()
		{
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x445FF3C", Offset = "0x445BF3C", VA = "0x445FF3C")]
		public void LoadFromCache()
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x4460998", Offset = "0x445C998", VA = "0x4460998")]
		public byte[] SerializeGraphs()
		{
			return null;
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x44609D0", Offset = "0x445C9D0", VA = "0x44609D0")]
		public byte[] SerializeGraphs(SerializeSettings settings)
		{
			return null;
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x44609EC", Offset = "0x445C9EC", VA = "0x44609EC")]
		public byte[] SerializeGraphs(SerializeSettings settings, out uint checksum)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED AstarData.SerializeGraphs RVA=0x44609EC Token=0x60002C4");
}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x4460CCC", Offset = "0x445CCCC", VA = "0x4460CCC")]
		public byte[] SerializeGraph(SerializeSettings settings, NavGraph graph)
		{
			return null;
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x4460CE4", Offset = "0x445CCE4", VA = "0x4460CE4")]
		public byte[] SerializeGraph(SerializeSettings settings, NavGraph graph, out uint checksum)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED AstarData.SerializeGraph RVA=0x4460CE4 Token=0x60002C6");
}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x44609F8", Offset = "0x445C9F8", VA = "0x44609F8")]
		public byte[] SerializeGraphs(SerializeSettings settings, NavGraph[] graphs, out uint checksum)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED AstarData.SerializeGraphs RVA=0x44609F8 Token=0x60002C7");
}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x44601D0", Offset = "0x445C1D0", VA = "0x44601D0")]
		public void DeserializeGraphs()
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x4460DDC", Offset = "0x445CDDC", VA = "0x4460DDC")]
		public void ClearGraphs()
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x4460E80", Offset = "0x445CE80", VA = "0x4460E80")]
		private void ClearGraphsInternal()
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x44610FC", Offset = "0x445D0FC", VA = "0x44610FC")]
		public void DisposeUnmanagedData()
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x4461278", Offset = "0x445D278", VA = "0x4461278")]
		internal void DestroyAllNodes()
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x44613F4", Offset = "0x445D3F4", VA = "0x44613F4")]
		public void OnDestroy()
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x44608D0", Offset = "0x445C8D0", VA = "0x44608D0")]
		public NavGraph[] DeserializeGraphs(byte[] bytes)
		{
			return null;
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x44613F8", Offset = "0x445D3F8", VA = "0x44613F8")]
		public NavGraph[] DeserializeGraphsAdditive(byte[] bytes)
		{
			return null;
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x4461400", Offset = "0x445D400", VA = "0x4461400")]
		private NavGraph[] DeserializeGraphsAdditive(byte[] bytes, bool warnIfDuplicateGuids)
		{
			return null;
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x4461784", Offset = "0x445D784", VA = "0x4461784")]
		private NavGraph[] DeserializeGraphsPartAdditive(AstarSerializer sr, bool warnIfDuplicateGuids)
		{
			return null;
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x445FE1C", Offset = "0x445BE1C", VA = "0x445FE1C")]
		public void FindGraphTypes()
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x4461F1C", Offset = "0x445DF1C", VA = "0x4461F1C")]
		internal NavGraph CreateGraph(Type type)
		{
			return null;
		}

		[Token(Token = "0x60002D4")]
		public T AddGraph<T>() where T : NavGraph
		{
			return null;
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x4461FA8", Offset = "0x445DFA8", VA = "0x4461FA8")]
		public NavGraph AddGraph(Type type)
		{
			return null;
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x44622C8", Offset = "0x445E2C8", VA = "0x44622C8")]
		private void AddGraph(NavGraph graph)
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x446250C", Offset = "0x445E50C", VA = "0x446250C")]
		public bool RemoveGraph(NavGraph graph)
		{
			return default;
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x4462854", Offset = "0x445E854", VA = "0x4462854")]
		public NavGraph DuplicateGraph(NavGraph graph)
		{
			return null;
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x4457F00", Offset = "0x4453F00", VA = "0x4457F00")]
		public static NavGraph GetGraph(GraphNode node)
		{
			return null;
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x445F524", Offset = "0x445B524", VA = "0x445F524")]
		public NavGraph FindGraph(Func<NavGraph, bool> predicate)
		{
			return null;
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x4460818", Offset = "0x445C818", VA = "0x4460818")]
		public NavGraph FindGraphOfType(Type type)
		{
			return null;
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x4462988", Offset = "0x445E988", VA = "0x4462988")]
		public NavGraph FindGraphWhichInheritsFrom(Type type)
		{
			return null;
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x4462A48", Offset = "0x445EA48", VA = "0x4462A48")]
		[IteratorStateMachine(typeof(_003CFindGraphsOfType_003Ed__80))]
		public IEnumerable FindGraphsOfType(Type type)
		{
			return null;
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x4462AFC", Offset = "0x445EAFC", VA = "0x4462AFC")]
		[IteratorStateMachine(typeof(_003CGetUpdateableGraphs_003Ed__81))]
		public IEnumerable GetUpdateableGraphs()
		{
			return null;
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x4462BA0", Offset = "0x445EBA0", VA = "0x4462BA0")]
		public int GetGraphIndex(NavGraph graph)
		{
			return default;
		}
	}
}
