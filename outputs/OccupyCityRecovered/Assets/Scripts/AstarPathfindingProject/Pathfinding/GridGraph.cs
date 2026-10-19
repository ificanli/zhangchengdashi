using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Pathfinding.Drawing;
using Pathfinding.Graphs.Grid;
using Pathfinding.Graphs.Grid.Rules;
using Pathfinding.Jobs;
using Pathfinding.Serialization;
using Pathfinding.Util;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x20000C7")]
	[JsonOptIn]
	[Preserve]
	public class GridGraph : NavGraph, IUpdatableGraph, ITransformedGraph, IRaycastableGraph
	{
		[Token(Token = "0x20000C8")]
		public class TextureData
		{
			[Token(Token = "0x20000C9")]
			public enum ChannelUse
			{
				[Token(Token = "0x4000466")]
				None = 0,
				[Token(Token = "0x4000467")]
				Penalty = 1,
				[Token(Token = "0x4000468")]
				Position = 2,
				[Token(Token = "0x4000469")]
				WalkablePenalty = 3
			}

			[Token(Token = "0x4000460")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool enabled;

			[Token(Token = "0x4000461")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Texture2D source;

			[Token(Token = "0x4000462")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float[] factors;

			[Token(Token = "0x4000463")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ChannelUse[] channels;

			[Token(Token = "0x4000464")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Color32[] data;

			[Token(Token = "0x60006EC")]
			[Address(RVA = "0x45281DC", Offset = "0x45241DC", VA = "0x45281DC")]
			public void Initialize()
			{
			}

			[Token(Token = "0x60006ED")]
			[Address(RVA = "0x4528360", Offset = "0x4524360", VA = "0x4528360")]
			public void Apply(GridNode node, int x, int z)
			{
			}

			[Token(Token = "0x60006EE")]
			[Address(RVA = "0x452850C", Offset = "0x452450C", VA = "0x452850C")]
			private void ApplyChannel(GridNode node, int x, int z, int value, ChannelUse channelUse, float factor)
			{
			}

			[Token(Token = "0x60006EF")]
			[Address(RVA = "0x4528710", Offset = "0x4524710", VA = "0x4528710")]
			public TextureData()
			{
			}
		}

		[Token(Token = "0x20000CA")]
		public enum RecalculationMode
		{
			[Token(Token = "0x400046B")]
			RecalculateFromScratch = 0,
			[Token(Token = "0x400046C")]
			RecalculateMinimal = 1,
			[Token(Token = "0x400046D")]
			NoRecalculation = 2
		}

		[Token(Token = "0x20000CB")]
		private class GridGraphMovePromise : IGraphUpdatePromise
		{
			[Token(Token = "0x20000CC")]
			[CompilerGenerated]
			private sealed class _003CPrepare_003Ed__8 : IEnumerator<JobHandle>, IEnumerator, IDisposable
			{
				[Token(Token = "0x4000474")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private int _003C_003E1__state;

				[Token(Token = "0x4000475")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private JobHandle _003C_003E2__current;

				[Token(Token = "0x4000476")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				public GridGraphMovePromise _003C_003E4__this;

				[Token(Token = "0x4000477")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				private int _003Ci_003E5__2;

				[Token(Token = "0x4000478")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				private IEnumerator<JobHandle> _003Cit_003E5__3;

				[Token(Token = "0x1700015A")]
JobHandle System.Collections.Generic.IEnumerator<Unity.Jobs.JobHandle>.Current
				{
					[Token(Token = "0x60006F7")]
					[Address(RVA = "0x45296A8", Offset = "0x45256A8", VA = "0x45296A8", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EGeneric_002EIEnumerator_003CUnity_002EJobs_002EJobHandle_003E_002Eget_Current();
					}
				}

				[Token(Token = "0x1700015B")]
object System.Collections.IEnumerator.Current
				{
					[Token(Token = "0x60006F9")]
					[Address(RVA = "0x45296EC", Offset = "0x45256EC", VA = "0x45296EC", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EIEnumerator_002Eget_Current();
					}
				}

				[Token(Token = "0x60006F4")]
				[Address(RVA = "0x4528EB8", Offset = "0x4524EB8", VA = "0x4528EB8")]
				[DebuggerHidden]
				public _003CPrepare_003Ed__8(int _003C_003E1__state)
				{
				}

				[Token(Token = "0x60006F5")]
				[Address(RVA = "0x452943C", Offset = "0x452543C", VA = "0x452943C", Slot = "5")]
				[DebuggerHidden]
void System.IDisposable.Dispose()
				{
				}

				[Token(Token = "0x60006F6")]
				[Address(RVA = "0x4529440", Offset = "0x4525440", VA = "0x4529440", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
				{
					return default;
				}

				[Token(Token = "0x60006F7")]
				[Address(RVA = "0x45296A8", Offset = "0x45256A8", VA = "0x45296A8", Slot = "4")]
				[DebuggerHidden]
				private JobHandle System_002ECollections_002EGeneric_002EIEnumerator_003CUnity_002EJobs_002EJobHandle_003E_002Eget_Current()
				{
					return default;
				}

				[Token(Token = "0x60006F8")]
				[Address(RVA = "0x45296B4", Offset = "0x45256B4", VA = "0x45296B4", Slot = "8")]
				[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
				{
				}

				[Token(Token = "0x60006F9")]
				[Address(RVA = "0x45296EC", Offset = "0x45256EC", VA = "0x45296EC", Slot = "7")]
				[DebuggerHidden]
				private object System_002ECollections_002EIEnumerator_002Eget_Current()
				{
					return null;
				}
			}

			[Token(Token = "0x400046E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GridGraph graph;

			[Token(Token = "0x400046F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int dx;

			[Token(Token = "0x4000470")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int dz;

			[Token(Token = "0x4000471")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private IGraphUpdatePromise[] promises;

			[Token(Token = "0x4000472")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private IntRect[] rects;

			[Token(Token = "0x4000473")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int3 startingSize;

			[Token(Token = "0x60006F0")]
			[Address(RVA = "0x4528794", Offset = "0x4524794", VA = "0x4528794")]
			private static void DecomposeInsetsToRectangles(int width, int height, int insetLeft, int insetRight, int insetBottom, int insetTop, IntRect[] output)
			{
			}

			[Token(Token = "0x60006F1")]
			[Address(RVA = "0x45288CC", Offset = "0x45248CC", VA = "0x45288CC")]
			public GridGraphMovePromise(GridGraph graph, int dx, int dz)
			{
			}

			[Token(Token = "0x60006F2")]
			[Address(RVA = "0x4528E58", Offset = "0x4524E58", VA = "0x4528E58", Slot = "5")]
			[IteratorStateMachine(typeof(_003CPrepare_003Ed__8))]
			public IEnumerator<JobHandle> Prepare()
			{
				return null;
			}

			[Token(Token = "0x60006F3")]
			[Address(RVA = "0x4528EE0", Offset = "0x4524EE0", VA = "0x4528EE0", Slot = "6")]
			public void Apply(IGraphUpdateContext ctx)
			{
			}
		}

		[Token(Token = "0x20000CD")]
		private class GridGraphUpdatePromise : IGraphUpdatePromise
		{
			[Token(Token = "0x20000CE")]
			public class NodesHolder
			{
				[Token(Token = "0x400048A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public GridNodeBase[] nodes;

				[Token(Token = "0x6000700")]
				[Address(RVA = "0x4528C5C", Offset = "0x4524C5C", VA = "0x4528C5C")]
				public NodesHolder()
				{
				}
			}

			[Token(Token = "0x20000CF")]
			[CompilerGenerated]
			private sealed class _003CPrepare_003Ed__22 : IEnumerator<JobHandle>, IEnumerator, IDisposable
			{
				[Token(Token = "0x400048B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private int _003C_003E1__state;

				[Token(Token = "0x400048C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private JobHandle _003C_003E2__current;

				[Token(Token = "0x400048D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				public GridGraphUpdatePromise _003C_003E4__this;

				[Token(Token = "0x400048E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				private GraphCollision _003Ccollision_003E5__2;

				[Token(Token = "0x400048F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				private GridGraphRules _003Crules_003E5__3;

				[Token(Token = "0x4000490")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
				private int _003CminLayers_003E5__4;

				[Token(Token = "0x4000491")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
				private bool _003ClayeredDataLayout_003E5__5;

				[Token(Token = "0x4000492")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
				private float _003CcharacterHeight_003E5__6;

				[Token(Token = "0x4000493")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
				private NativeArray<int> _003ClayerCount_003E5__7;

				[Token(Token = "0x4000494")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
				private IEnumerator<JobHandle> _003Cwait_003E5__8;

				[Token(Token = "0x1700015D")]
JobHandle System.Collections.Generic.IEnumerator<Unity.Jobs.JobHandle>.Current
				{
					[Token(Token = "0x6000704")]
					[Address(RVA = "0x452B724", Offset = "0x4527724", VA = "0x452B724", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EGeneric_002EIEnumerator_003CUnity_002EJobs_002EJobHandle_003E_002Eget_Current();
					}
				}

				[Token(Token = "0x1700015E")]
object System.Collections.IEnumerator.Current
				{
					[Token(Token = "0x6000706")]
					[Address(RVA = "0x452B768", Offset = "0x4527768", VA = "0x452B768", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EIEnumerator_002Eget_Current();
					}
				}

				[Token(Token = "0x6000701")]
				[Address(RVA = "0x4529950", Offset = "0x4525950", VA = "0x4529950")]
				[DebuggerHidden]
				public _003CPrepare_003Ed__22(int _003C_003E1__state)
				{
				}

				[Token(Token = "0x6000702")]
				[Address(RVA = "0x4529D9C", Offset = "0x4525D9C", VA = "0x4529D9C", Slot = "5")]
				[DebuggerHidden]
void System.IDisposable.Dispose()
				{
				}

				[Token(Token = "0x6000703")]
				[Address(RVA = "0x4529DA0", Offset = "0x4525DA0", VA = "0x4529DA0", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
				{
					return default;
				}

				[Token(Token = "0x6000704")]
				[Address(RVA = "0x452B724", Offset = "0x4527724", VA = "0x452B724", Slot = "4")]
				[DebuggerHidden]
				private JobHandle System_002ECollections_002EGeneric_002EIEnumerator_003CUnity_002EJobs_002EJobHandle_003E_002Eget_Current()
				{
					return default;
				}

				[Token(Token = "0x6000705")]
				[Address(RVA = "0x452B730", Offset = "0x4527730", VA = "0x452B730", Slot = "8")]
				[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
				{
				}

				[Token(Token = "0x6000706")]
				[Address(RVA = "0x452B768", Offset = "0x4527768", VA = "0x452B768", Slot = "7")]
				[DebuggerHidden]
				private object System_002ECollections_002EIEnumerator_002Eget_Current()
				{
					return null;
				}
			}

			[Token(Token = "0x4000479")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GridGraph graph;

			[Token(Token = "0x400047A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public NodesHolder nodes;

			[Token(Token = "0x400047B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public JobDependencyTracker dependencyTracker;

			[Token(Token = "0x400047C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int3 nodeArrayBounds;

			[Token(Token = "0x400047D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public IntRect rect;

			[Token(Token = "0x400047E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public JobHandle nodesDependsOn;

			[Token(Token = "0x400047F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Allocator allocationMethod;

			[Token(Token = "0x4000480")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public RecalculationMode recalculationMode;

			[Token(Token = "0x4000481")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public GraphUpdateObject graphUpdateObject;

			[Token(Token = "0x4000482")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private IntBounds writeMaskBounds;

			[Token(Token = "0x4000483")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			internal GridGraphRules.Context context;

			[Token(Token = "0x4000484")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private bool emptyUpdate;

			[Token(Token = "0x4000485")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			private IntBounds readBounds;

			[Token(Token = "0x4000486")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private IntBounds fullRecalculationBounds;

			[Token(Token = "0x4000487")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			public bool ownsJobDependencyTracker;

			[Token(Token = "0x4000488")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBD")]
			private bool isFinalUpdate;

			[Token(Token = "0x4000489")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private GraphTransform transform;

			[Token(Token = "0x1700015C")]
			public int CostEstimate
			{
				[Token(Token = "0x60006FA")]
				[Address(RVA = "0x4529748", Offset = "0x4525748", VA = "0x4529748")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x60006FB")]
			[Address(RVA = "0x4528C64", Offset = "0x4524C64", VA = "0x4528C64")]
			public GridGraphUpdatePromise(GridGraph graph, GraphTransform transform, NodesHolder nodes, int3 nodeArrayBounds, IntRect rect, JobDependencyTracker dependencyTracker, JobHandle nodesDependsOn, Allocator allocationMethod, RecalculationMode recalculationMode, GraphUpdateObject graphUpdateObject, bool ownsJobDependencyTracker, bool isFinalUpdate)
			{
			}

			[Token(Token = "0x60006FC")]
			[Address(RVA = "0x4529754", Offset = "0x4525754", VA = "0x4529754")]
			public static void CalculateRectangles(GridGraph graph, IntRect rect, out IntRect originalRect, out IntRect fullRecalculationRect, out IntRect writeMaskRect, out IntRect readRect)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED GridGraph.GridGraphUpdatePromise.CalculateRectangles RVA=0x4529754 Token=0x60006FC");
}

			[Token(Token = "0x60006FD")]
			[Address(RVA = "0x45298F0", Offset = "0x45258F0", VA = "0x45298F0", Slot = "5")]
			[IteratorStateMachine(typeof(_003CPrepare_003Ed__22))]
			public IEnumerator<JobHandle> Prepare()
			{
				return null;
			}

			[Token(Token = "0x60006FE")]
			[Address(RVA = "0x4529978", Offset = "0x4525978", VA = "0x4529978", Slot = "6")]
			public void Apply(IGraphUpdateContext ctx)
			{
			}

			[Token(Token = "0x60006FF")]
			[Address(RVA = "0x4529D3C", Offset = "0x4525D3C", VA = "0x4529D3C")]
			public void Dispose()
			{
			}
		}

		[Token(Token = "0x20000D0")]
		private class CombinedGridGraphUpdatePromise : IGraphUpdatePromise
		{
			[Token(Token = "0x20000D1")]
			[CompilerGenerated]
			private sealed class _003CPrepare_003Ed__2 : IEnumerator<JobHandle>, IEnumerator, IDisposable
			{
				[Token(Token = "0x4000496")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private int _003C_003E1__state;

				[Token(Token = "0x4000497")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private JobHandle _003C_003E2__current;

				[Token(Token = "0x4000498")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				public CombinedGridGraphUpdatePromise _003C_003E4__this;

				[Token(Token = "0x4000499")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				private int _003Ci_003E5__2;

				[Token(Token = "0x400049A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				private IEnumerator<JobHandle> _003Cit_003E5__3;

				[Token(Token = "0x1700015F")]
JobHandle System.Collections.Generic.IEnumerator<Unity.Jobs.JobHandle>.Current
				{
					[Token(Token = "0x600070D")]
					[Address(RVA = "0x452BEA0", Offset = "0x4527EA0", VA = "0x452BEA0", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EGeneric_002EIEnumerator_003CUnity_002EJobs_002EJobHandle_003E_002Eget_Current();
					}
				}

				[Token(Token = "0x17000160")]
object System.Collections.IEnumerator.Current
				{
					[Token(Token = "0x600070F")]
					[Address(RVA = "0x452BEE4", Offset = "0x4527EE4", VA = "0x452BEE4", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EIEnumerator_002Eget_Current();
					}
				}

				[Token(Token = "0x600070A")]
				[Address(RVA = "0x452BAE8", Offset = "0x4527AE8", VA = "0x452BAE8")]
				[DebuggerHidden]
				public _003CPrepare_003Ed__2(int _003C_003E1__state)
				{
				}

				[Token(Token = "0x600070B")]
				[Address(RVA = "0x452BC68", Offset = "0x4527C68", VA = "0x452BC68", Slot = "5")]
				[DebuggerHidden]
void System.IDisposable.Dispose()
				{
				}

				[Token(Token = "0x600070C")]
				[Address(RVA = "0x452BC6C", Offset = "0x4527C6C", VA = "0x452BC6C", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
				{
					return default;
				}

				[Token(Token = "0x600070D")]
				[Address(RVA = "0x452BEA0", Offset = "0x4527EA0", VA = "0x452BEA0", Slot = "4")]
				[DebuggerHidden]
				private JobHandle System_002ECollections_002EGeneric_002EIEnumerator_003CUnity_002EJobs_002EJobHandle_003E_002Eget_Current()
				{
					return default;
				}

				[Token(Token = "0x600070E")]
				[Address(RVA = "0x452BEAC", Offset = "0x4527EAC", VA = "0x452BEAC", Slot = "8")]
				[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
				{
				}

				[Token(Token = "0x600070F")]
				[Address(RVA = "0x452BEE4", Offset = "0x4527EE4", VA = "0x452BEE4", Slot = "7")]
				[DebuggerHidden]
				private object System_002ECollections_002EIEnumerator_002Eget_Current()
				{
					return null;
				}
			}

			[Token(Token = "0x4000495")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private List<IGraphUpdatePromise> promises;

			[Token(Token = "0x6000707")]
			[Address(RVA = "0x452B7C4", Offset = "0x45277C4", VA = "0x452B7C4")]
			public CombinedGridGraphUpdatePromise(GridGraph graph, List<GraphUpdateObject> graphUpdates)
			{
			}

			[Token(Token = "0x6000708")]
			[Address(RVA = "0x452BA88", Offset = "0x4527A88", VA = "0x452BA88", Slot = "5")]
			[IteratorStateMachine(typeof(_003CPrepare_003Ed__2))]
			public IEnumerator<JobHandle> Prepare()
			{
				return null;
			}

			[Token(Token = "0x6000709")]
			[Address(RVA = "0x452BB10", Offset = "0x4527B10", VA = "0x452BB10", Slot = "6")]
			public void Apply(IGraphUpdateContext ctx)
			{
			}
		}

		[Token(Token = "0x20000D2")]
		private class GridGraphSnapshot : IGraphSnapshot, IDisposable
		{
			[Token(Token = "0x400049B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal GridGraphNodeData nodes;

			[Token(Token = "0x400049C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			internal GridGraph graph;

			[Token(Token = "0x6000710")]
			[Address(RVA = "0x452BF40", Offset = "0x4527F40", VA = "0x452BF40", Slot = "5")]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000711")]
			[Address(RVA = "0x452BF4C", Offset = "0x4527F4C", VA = "0x452BF4C", Slot = "4")]
			public void Restore(IGraphUpdateContext ctx)
			{
			}

			[Token(Token = "0x6000712")]
			[Address(RVA = "0x452C244", Offset = "0x4528244", VA = "0x452C244")]
			public GridGraphSnapshot()
			{
			}
		}

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[JsonMember]
		public InspectorGridMode inspectorGridMode;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[JsonMember]
		public InspectorGridHexagonNodeSize inspectorHexagonSizeMode;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int width;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public int depth;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[JsonMember]
		public float aspectRatio;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[JsonMember]
		public float isometricAngle;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly float StandardIsometricAngle;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static readonly float StandardDimetricAngle;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[JsonMember]
		public bool uniformEdgeCosts;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[JsonMember]
		public Vector3 rotation;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[JsonMember]
		public Vector3 center;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[JsonMember]
		public Vector2 unclampedSize;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[JsonMember]
		public float nodeSize;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[JsonMember]
		public GraphCollision collision;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[JsonMember]
		public float maxStepHeight;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		[JsonMember]
		public bool maxStepUsesSlope;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[JsonMember]
		public float maxSlope;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		[JsonMember]
		public int erodeIterations;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[JsonMember]
		public bool erosionUseTags;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[JsonMember]
		public int erosionFirstTag;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[JsonMember]
		public int erosionTagsPrecedenceMask;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[JsonMember]
		public NumNeighbours neighbours;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[JsonMember]
		public bool cutCorners;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[Obsolete("Use the RuleElevationPenalty class instead")]
		[JsonMember]
		public float penaltyPositionOffset;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[JsonMember]
		[Obsolete("Use the RuleElevationPenalty class instead")]
		public bool penaltyPosition;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[JsonMember]
		[Obsolete("Use the RuleElevationPenalty class instead")]
		public float penaltyPositionFactor;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[JsonMember]
		[Obsolete("Use the RuleAnglePenalty class instead")]
		public bool penaltyAngle;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[Obsolete("Use the RuleAnglePenalty class instead")]
		[JsonMember]
		public float penaltyAngleFactor;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[Obsolete("Use the RuleAnglePenalty class instead")]
		[JsonMember]
		public float penaltyAnglePower;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[JsonMember]
		public GridGraphRules rules;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[JsonMember]
		public bool showMeshOutline;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE1")]
		[JsonMember]
		public bool showNodeConnections;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE2")]
		[JsonMember]
		public bool showMeshSurface;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[JsonMember]
		[Obsolete("Use the RuleTexture class instead")]
		public TextureData textureData;

		[NonSerialized]
		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public readonly int[] neighbourOffsets;

		[NonSerialized]
		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public readonly float[] neighbourCosts;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly int[] neighbourXOffsets;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly int[] neighbourZOffsets;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal static readonly int[] hexagonNeighbourIndices;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal static readonly int[] axisAlignedNeighbourIndices;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal static readonly int[] allNeighbourIndices;

		[Token(Token = "0x400045A")]
		internal const int HexagonConnectionMask = 175;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public GridNodeBase[] nodes;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		protected GridGraphNodeData nodeData;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		protected Func<GridNodeBase> newGridNodeDelegate;

		[Token(Token = "0x400045F")]
		public const int FixedPrecisionScale = 1024;

		[Token(Token = "0x1700014E")]
		public virtual int LayerCount
		{
			[Token(Token = "0x6000691")]
			[Address(RVA = "0x451CE98", Offset = "0x4518E98", VA = "0x451CE98", Slot = "48")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000692")]
			[Address(RVA = "0x451CEA0", Offset = "0x4518EA0", VA = "0x451CEA0", Slot = "49")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700014F")]
		public virtual int MaxLayers
		{
			[Token(Token = "0x6000693")]
			[Address(RVA = "0x451CEF8", Offset = "0x4518EF8", VA = "0x451CEF8", Slot = "50")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000150")]
		[Obsolete("This field has been renamed to maxStepHeight")]
		public float maxClimb
		{
			[Token(Token = "0x6000697")]
			[Address(RVA = "0x451CF88", Offset = "0x4518F88", VA = "0x451CF88")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000698")]
			[Address(RVA = "0x451CF90", Offset = "0x4518F90", VA = "0x451CF90")]
			set
			{
			}
		}

		[Token(Token = "0x17000151")]
		protected bool useRaycastNormal
		{
			[Token(Token = "0x6000699")]
			[Address(RVA = "0x451CF98", Offset = "0x4518F98", VA = "0x451CF98")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000152")]
		public Vector2 size
		{
			[Token(Token = "0x600069A")]
			[Address(RVA = "0x451D010", Offset = "0x4519010", VA = "0x451D010")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x600069B")]
			[Address(RVA = "0x451D018", Offset = "0x4519018", VA = "0x451D018")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x17000153")]
		internal unsafe ref GridGraphNodeData nodeDataRef
		{
			[Token(Token = "0x600069D")]
			[Address(RVA = "0x451D0B4", Offset = "0x45190B4", VA = "0x451D0B4")]
			get
			{
				return ref *(GridGraphNodeData*)null;
			}
		}

		[Token(Token = "0x17000154")]
		public GraphTransform transform
		{
			[Token(Token = "0x600069E")]
			[Address(RVA = "0x451D0BC", Offset = "0x45190BC", VA = "0x451D0BC", Slot = "37")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600069F")]
			[Address(RVA = "0x451D0C4", Offset = "0x45190C4", VA = "0x451D0C4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000155")]
		public bool is2D
		{
			[Token(Token = "0x60006A0")]
			[Address(RVA = "0x451D0CC", Offset = "0x45190CC", VA = "0x451D0CC")]
			get
			{
				return default;
			}
			[Token(Token = "0x60006A1")]
			[Address(RVA = "0x451D1E0", Offset = "0x45191E0", VA = "0x451D1E0")]
			set
			{
			}
		}

		[Token(Token = "0x17000156")]
		public override bool isScanned
		{
			[Token(Token = "0x60006A2")]
			[Address(RVA = "0x451D258", Offset = "0x4519258", VA = "0x451D258", Slot = "13")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000157")]
		public override Bounds bounds
		{
			[Token(Token = "0x60006A7")]
			[Address(RVA = "0x451D8BC", Offset = "0x45198BC", VA = "0x451D8BC", Slot = "16")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000158")]
		public int Width
		{
			[Token(Token = "0x60006AB")]
			[Address(RVA = "0x451DABC", Offset = "0x4519ABC", VA = "0x451DABC")]
			get
			{
				return default;
			}
			[Token(Token = "0x60006AC")]
			[Address(RVA = "0x451DAC4", Offset = "0x4519AC4", VA = "0x451DAC4")]
			set
			{
			}
		}

		[Token(Token = "0x17000159")]
		public int Depth
		{
			[Token(Token = "0x60006AD")]
			[Address(RVA = "0x451DACC", Offset = "0x4519ACC", VA = "0x451DACC")]
			get
			{
				return default;
			}
			[Token(Token = "0x60006AE")]
			[Address(RVA = "0x451DAD4", Offset = "0x4519AD4", VA = "0x451DAD4")]
			set
			{
			}
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0x451CD10", Offset = "0x4518D10", VA = "0x451CD10", Slot = "27")]
		protected override void DisposeUnmanagedData()
		{
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0x451CDA4", Offset = "0x4518DA4", VA = "0x451CDA4", Slot = "28")]
		protected override void DestroyAllNodes()
		{
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0x451CF00", Offset = "0x4518F00", VA = "0x451CF00", Slot = "17")]
		public override int CountNodes()
		{
			return default;
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0x451CF18", Offset = "0x4518F18", VA = "0x451CF18", Slot = "18")]
		public override void GetNodes(Action<GraphNode> action)
		{
		}

		[Token(Token = "0x6000696")]
		public override void GetNodes<T>(GraphNode.NodeActionWithData<T> action, ref T data)
		{
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0x451D020", Offset = "0x4519020", VA = "0x451D020")]
		public static int[] GetNeighbourDirections(NumNeighbours neighbours)
		{
			return null;
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x451D268", Offset = "0x4519268", VA = "0x451D268", Slot = "51")]
		protected virtual GridNodeBase[] AllocateNodesJob(int size, out JobHandle dependency)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED GridGraph.AllocateNodesJob RVA=0x451D268 Token=0x60006A3");
}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x451D30C", Offset = "0x451930C", VA = "0x451D30C", Slot = "22")]
		public override void RelocateNodes(Matrix4x4 deltaMatrix)
		{
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x451D358", Offset = "0x4519358", VA = "0x451D358")]
		public void RelocateNodes(Vector3 center, Quaternion rotation, float nodeSize, float aspectRatio = 1f, float isometricAngle = 0f)
		{
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x451D80C", Offset = "0x451980C", VA = "0x451D80C", Slot = "21")]
		public override bool IsInsideBounds(Vector3 point)
		{
			return default;
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x451D940", Offset = "0x4519940", VA = "0x451D940")]
		public Int3 GraphPointToWorld(int x, int z, float height)
		{
			return default;
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x451D984", Offset = "0x4519984", VA = "0x451D984")]
		public static float ConvertHexagonSizeToNodeSize(InspectorGridHexagonNodeSize mode, float value)
		{
			return default;
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x451DA20", Offset = "0x4519A20", VA = "0x451DA20")]
		public static float ConvertNodeSizeToHexagonSize(InspectorGridHexagonNodeSize mode, float value)
		{
			return default;
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x451DADC", Offset = "0x4519ADC", VA = "0x451DADC")]
		public float GetConnectionCost(int dir)
		{
			return default;
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x451DB0C", Offset = "0x4519B0C", VA = "0x451DB0C")]
		public void SetGridShape(InspectorGridMode shape)
		{
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x451DC08", Offset = "0x4519C08", VA = "0x451DC08")]
		public void AlignToTilemap(GridLayout grid)
		{
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x451D6EC", Offset = "0x45196EC", VA = "0x451D6EC")]
		public void SetDimensions(int width, int depth, float nodeSize)
		{
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x451ED8C", Offset = "0x451AD8C", VA = "0x451ED8C")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x451F15C", Offset = "0x451B15C", VA = "0x451F15C")]
		public GraphTransform CalculateTransform()
		{
			return null;
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x451EDB8", Offset = "0x451ADB8", VA = "0x451EDB8")]
		private void CalculateDimensions(out int width, out int depth, out float nodeSize)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED GridGraph.CalculateDimensions RVA=0x451EDB8 Token=0x60006B5");
}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x451F8F4", Offset = "0x451B8F4", VA = "0x451F8F4", Slot = "23")]
		public override float NearestNodeDistanceSqrLowerBound(Vector3 position, ref NearestNodeConstraint constraint)
		{
			return default;
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x451F9D0", Offset = "0x451B9D0", VA = "0x451F9D0", Slot = "52")]
		protected virtual GridNodeBase GetNearestFromGraphSpace(Vector3 positionGraphSpace)
		{
			return null;
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x451FA64", Offset = "0x451BA64", VA = "0x451FA64", Slot = "24")]
		public override NNInfo GetNearest(Vector3 position, ref NearestNodeConstraint constraint)
		{
			return default;
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x4520530", Offset = "0x451C530", VA = "0x4520530", Slot = "25")]
		public override NNInfo RandomPointOnSurface(NearestNodeConstraint constraint, bool highQuality = true)
		{
			return default;
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x45206C8", Offset = "0x451C6C8", VA = "0x45206C8", Slot = "53")]
		public virtual void SetUpOffsetsAndCosts()
		{
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x4520968", Offset = "0x451C968", VA = "0x4520968")]
		public IGraphUpdatePromise TranslateInDirection(int dx, int dz)
		{
			return null;
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x45209DC", Offset = "0x451C9DC", VA = "0x45209DC", Slot = "31")]
		protected override IGraphUpdatePromise ScanInternal(bool async)
		{
			return null;
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x4520C6C", Offset = "0x451CC6C", VA = "0x4520C6C")]
		public void SetWalkability(bool[] walkability, IntRect rect)
		{
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x4521598", Offset = "0x451D598", VA = "0x4521598")]
		public void RecalculateAllConnections()
		{
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x4521018", Offset = "0x451D018", VA = "0x4521018")]
		public void RecalculateConnectionsInRegion(IntRect recalculateRect)
		{
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x4521738", Offset = "0x451D738", VA = "0x4521738")]
		public void CalculateConnectionsForCellAndNeighbours(int x, int z)
		{
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x4521784", Offset = "0x451D784", VA = "0x4521784", Slot = "54")]
		[Obsolete("This method is very slow since 4.3.80. Use RecalculateConnectionsInRegion or RecalculateAllConnections instead to batch connection recalculations.")]
		public virtual void CalculateConnections(GridNodeBase node)
		{
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x45217C4", Offset = "0x451D7C4", VA = "0x45217C4", Slot = "55")]
		[Obsolete("This method is very slow since 4.3.80. Use RecalculateConnectionsInRegion instead to batch connection recalculations.")]
		public virtual void CalculateConnections(int x, int z)
		{
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x4521800", Offset = "0x451D800", VA = "0x4521800", Slot = "35")]
		public override void OnDrawGizmos(DrawingData gizmos, bool drawNodes, RedrawScope redrawScope, bool renderInGame)
		{
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x45221D8", Offset = "0x451E1D8", VA = "0x45221D8")]
		private void CreateNavmeshSurfaceVisualization(GridNodeBase[] nodes, int nodeCount, GraphGizmoHelper helper)
		{
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x45215E0", Offset = "0x451D5E0", VA = "0x45215E0")]
		public Bounds GetBoundsFromRect(IntRect rect)
		{
			return default;
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x4522CB8", Offset = "0x451ECB8", VA = "0x4522CB8")]
		public IntRect GetRectFromBounds(Bounds bounds)
		{
			return default;
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x4522EF0", Offset = "0x451EEF0", VA = "0x4522EF0")]
		public List<GraphNode> GetNodesInRegion(Bounds bounds)
		{
			return null;
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x4522F34", Offset = "0x451EF34", VA = "0x4522F34")]
		public List<GraphNode> GetNodesInRegion(GraphUpdateShape shape)
		{
			return null;
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x4522FA4", Offset = "0x451EFA4", VA = "0x4522FA4", Slot = "56")]
		protected virtual List<GraphNode> GetNodesInRegion(Bounds bounds, GraphUpdateShape shape)
		{
			return null;
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x45232B8", Offset = "0x451F2B8", VA = "0x45232B8")]
		public List<GraphNode> GetNodesInRegion(IntRect rect)
		{
			return null;
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x4523548", Offset = "0x451F548", VA = "0x4523548", Slot = "57")]
		public virtual int GetNodesInRegion(IntRect rect, GridNodeBase[] buffer)
		{
			return default;
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x45236E8", Offset = "0x451F6E8", VA = "0x45236E8", Slot = "58")]
		public virtual GridNodeBase GetNode(int x, int z)
		{
			return null;
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x4523744", Offset = "0x451F744", VA = "0x4523744", Slot = "36")]
IGraphUpdatePromise IUpdatableGraph.ScheduleGraphUpdates(List<GraphUpdateObject> graphUpdates)
		{
			return null;
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x4523864", Offset = "0x451F864", VA = "0x4523864", Slot = "29")]
		public override IGraphSnapshot Snapshot(Bounds bounds)
		{
			return null;
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x4523B1C", Offset = "0x451FB1C", VA = "0x4523B1C", Slot = "38")]
		public bool Linecast(Vector3 from, Vector3 to)
		{
			return default;
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x4523C30", Offset = "0x451FC30", VA = "0x4523C30", Slot = "39")]
		[Obsolete("The hint parameter is deprecated")]
		public bool Linecast(Vector3 from, Vector3 to, GraphNode hint)
		{
			return default;
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x4523C60", Offset = "0x451FC60", VA = "0x4523C60", Slot = "40")]
		[Obsolete("The hint parameter is deprecated")]
		public bool Linecast(Vector3 from, Vector3 to, GraphNode hint, out GraphHitInfo hit)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED GridGraph.Linecast RVA=0x4523C60 Token=0x60006D1");
}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x4523D54", Offset = "0x451FD54", VA = "0x4523D54")]
		protected static long CrossMagnitude(int2 a, int2 b)
		{
			return default;
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x4523D74", Offset = "0x451FD74", VA = "0x4523D74")]
		protected bool ClipLineSegmentToBounds(Vector3 a, Vector3 b, out Vector3 outA, out Vector3 outB)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED GridGraph.ClipLineSegmentToBounds RVA=0x4523D74 Token=0x60006D3");
}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x4523D44", Offset = "0x451FD44", VA = "0x4523D44", Slot = "41")]
		[Obsolete("The hint parameter is deprecated")]
		public bool Linecast(Vector3 from, Vector3 to, GraphNode hint, out GraphHitInfo hit, ref TraversalConstraint traversalConstraint, List<GraphNode> trace)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED GridGraph.Linecast RVA=0x4523D44 Token=0x60006D4");
}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x4523B4C", Offset = "0x451FB4C", VA = "0x4523B4C", Slot = "43")]
		public bool Linecast(Vector3 from, Vector3 to, out GraphHitInfo hit)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED GridGraph.Linecast RVA=0x4523B4C Token=0x60006D5");
}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x4524618", Offset = "0x4520618", VA = "0x4524618", Slot = "45")]
		public bool Linecast(Vector3 from, Vector3 to, out GraphHitInfo hit, [Optional] List<GraphNode> trace)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED GridGraph.Linecast RVA=0x4524618 Token=0x60006D6");
}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x45241F0", Offset = "0x45201F0", VA = "0x45241F0", Slot = "44")]
		public bool Linecast(Vector3 from, Vector3 to, out GraphHitInfo hit, ref TraversalConstraint traversalConstraint, [Optional] List<GraphNode> trace)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED GridGraph.Linecast RVA=0x45241F0 Token=0x60006D7");
}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x452494C", Offset = "0x452094C", VA = "0x452494C")]
		[Obsolete("Use Linecast instead")]
		public bool SnappedLinecast(Vector3 from, Vector3 to, GraphNode hint, out GraphHitInfo hit)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED GridGraph.SnappedLinecast RVA=0x452494C Token=0x60006D8");
}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x4524A3C", Offset = "0x4520A3C", VA = "0x4524A3C")]
		public bool Linecast(GridNodeBase fromNode, GridNodeBase toNode)
		{
			return default;
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x4524AEC", Offset = "0x4520AEC", VA = "0x4524AEC")]
		public bool Linecast(GridNodeBase fromNode, GridNodeBase toNode, ref TraversalConstraint traversalConstraint)
		{
			return default;
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x4524700", Offset = "0x4520700", VA = "0x4524700")]
		public bool Linecast(Vector3 from, Vector3 to, out GridHitInfo hit, ref TraversalConstraint traversalConstraint, [Optional] List<GraphNode> trace)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED GridGraph.Linecast RVA=0x4524700 Token=0x60006DB");
}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x4525C2C", Offset = "0x4521C2C", VA = "0x4525C2C")]
		public bool Linecast(GridNodeBase fromNode, Vector2 normalizedFromPoint, GridNodeBase toNode, Vector2 normalizedToPoint, out GridHitInfo hit, [Optional] List<GraphNode> trace, bool continuePastEnd = false)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED GridGraph.Linecast RVA=0x4525C2C Token=0x60006DC");
}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x4525958", Offset = "0x4521958", VA = "0x4525958")]
		public bool Linecast(GridNodeBase fromNode, Vector2 normalizedFromPoint, GridNodeBase toNode, Vector2 normalizedToPoint, out GridHitInfo hit, ref TraversalConstraint traversalConstraint, [Optional] List<GraphNode> trace, bool continuePastEnd = false)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED GridGraph.Linecast RVA=0x4525958 Token=0x60006DD");
}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x4524B28", Offset = "0x4520B28", VA = "0x4524B28")]
		public bool Linecast(GridNodeBase fromNode, int2 fixedNormalizedFromPoint, GridNodeBase toNode, int2 fixedNormalizedToPoint, out GridHitInfo hit, ref TraversalConstraint traversalConstraint, [Optional] List<GraphNode> trace, bool continuePastEnd = false)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED GridGraph.Linecast RVA=0x4524B28 Token=0x60006DE");
}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x4525D14", Offset = "0x4521D14", VA = "0x4525D14")]
		[Obsolete("Use the overload that takes a TraversalConstraint instead. See the migration guide for version 5.4 for more information.")]
		public bool Linecast(Vector3 from, Vector3 to, out GridHitInfo hit, List<GraphNode> trace, Func<GraphNode, bool> filter)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED GridGraph.Linecast RVA=0x4525D14 Token=0x60006DF");
}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x4525E1C", Offset = "0x4521E1C", VA = "0x4525E1C")]
		[Obsolete("Use the overload that takes a TraversalConstraint instead. See the migration guide for version 5.4 for more information.")]
		public bool Linecast(GridNodeBase fromNode, GridNodeBase toNode, Func<GraphNode, bool> filter)
		{
			return default;
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x4525EE4", Offset = "0x4521EE4", VA = "0x4525EE4", Slot = "46")]
		[Obsolete("Use the overload that takes a TraversalConstraint instead. See the migration guide for version 5.4 for more information.")]
		public bool Linecast(Vector3 from, Vector3 to, out GraphHitInfo hit, List<GraphNode> trace, Func<GraphNode, bool> filter)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED GridGraph.Linecast RVA=0x4525EE4 Token=0x60006E1");
}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x4525FEC", Offset = "0x4521FEC", VA = "0x4525FEC", Slot = "47")]
		[Obsolete("Use the overload that takes a TraversalConstraint instead. See the migration guide for version 5.4 for more information.")]
		public bool Linecast(Vector3 from, Vector3 to, GraphNode hint, out GraphHitInfo hit, List<GraphNode> trace, Func<GraphNode, bool> filter)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED GridGraph.Linecast RVA=0x4525FEC Token=0x60006E2");
}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x45260F4", Offset = "0x45220F4", VA = "0x45260F4", Slot = "32")]
		protected override void SerializeExtraInfo(GraphSerializationContext ctx)
		{
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x4526390", Offset = "0x4522390", VA = "0x4526390", Slot = "33")]
		protected override void DeserializeExtraInfo(GraphSerializationContext ctx)
		{
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x452655C", Offset = "0x452255C", VA = "0x452655C")]
		protected void DeserializeNativeData(GraphSerializationContext ctx, bool normalsSerialized)
		{
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x45261B4", Offset = "0x45221B4", VA = "0x45261B4")]
		protected void SerializeNodeSurfaceNormals(GraphSerializationContext ctx)
		{
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x4526788", Offset = "0x4522788", VA = "0x4526788")]
		protected void DeserializeNodeSurfaceNormals(GraphSerializationContext ctx, GridNodeBase[] nodes, bool ignoreForCompatibility)
		{
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x4526908", Offset = "0x4522908", VA = "0x4526908")]
		private void HandleBackwardsCompatibility(GraphSerializationContext ctx)
		{
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x4526FF0", Offset = "0x4522FF0", VA = "0x4526FF0", Slot = "34")]
		protected override void PostDeserialization(GraphSerializationContext ctx)
		{
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x45271E8", Offset = "0x45231E8", VA = "0x45271E8")]
		public GridGraph()
		{
		}
	}
}
