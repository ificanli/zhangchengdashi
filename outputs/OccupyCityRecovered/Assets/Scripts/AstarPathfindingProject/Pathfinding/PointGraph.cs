using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Pathfinding.Serialization;
using Pathfinding.Util;
using Unity.Jobs;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x20000FC")]
	[Preserve]
	[JsonOptIn]
	public class PointGraph : NavGraph, IUpdatableGraph
	{
		[Token(Token = "0x20000FD")]
		public enum NodeDistanceMode
		{
			[Token(Token = "0x4000559")]
			Node = 0,
			[Token(Token = "0x400055A")]
			Connection = 1
		}

		[Token(Token = "0x20000FE")]
		private class PointGraphScanPromise : IGraphUpdatePromise
		{
			[Token(Token = "0x20000FF")]
			[CompilerGenerated]
			private sealed class _003CPrepare_003Ed__3 : IEnumerator<JobHandle>, IEnumerator, IDisposable
			{
				[Token(Token = "0x400055E")]
				[FieldOffset(Offset = "0x10")]
				private int _003C_003E1__state;

				[Token(Token = "0x400055F")]
				[FieldOffset(Offset = "0x18")]
				private JobHandle _003C_003E2__current;

				[Token(Token = "0x4000560")]
				[FieldOffset(Offset = "0x28")]
				public PointGraphScanPromise _003C_003E4__this;

				[Token(Token = "0x4000561")]
				[FieldOffset(Offset = "0x30")]
				private IEnumerator<float> _003C_003E7__wrap1;

				[Token(Token = "0x17000192")]
JobHandle System.Collections.Generic.IEnumerator<Unity.Jobs.JobHandle>.Current
				{
					[Token(Token = "0x60008F3")]
					[Address(RVA = "0x4549788", Offset = "0x4545788", VA = "0x4549788", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EGeneric_002EIEnumerator_003CUnity_002EJobs_002EJobHandle_003E_002Eget_Current();
					}
				}

				[Token(Token = "0x17000193")]
object System.Collections.IEnumerator.Current
				{
					[Token(Token = "0x60008F5")]
					[Address(RVA = "0x45497CC", Offset = "0x45457CC", VA = "0x45497CC", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EIEnumerator_002Eget_Current();
					}
				}

				[Token(Token = "0x60008EF")]
				[Address(RVA = "0x4548D04", Offset = "0x4544D04", VA = "0x4548D04")]
				[DebuggerHidden]
				public _003CPrepare_003Ed__3(int _003C_003E1__state)
				{
				}

				[Token(Token = "0x60008F0")]
				[Address(RVA = "0x4548DA0", Offset = "0x4544DA0", VA = "0x4548DA0", Slot = "5")]
				[DebuggerHidden]
void System.IDisposable.Dispose()
				{
				}

				[Token(Token = "0x60008F1")]
				[Address(RVA = "0x4548DBC", Offset = "0x4544DBC", VA = "0x4548DBC", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
				{
					return default;
				}

				[Token(Token = "0x60008F2")]
				[Address(RVA = "0x45496D8", Offset = "0x45456D8", VA = "0x45496D8")]
				private void _003C_003Em__Finally1()
				{
				}

				[Token(Token = "0x60008F3")]
				[Address(RVA = "0x4549788", Offset = "0x4545788", VA = "0x4549788", Slot = "4")]
				[DebuggerHidden]
				private JobHandle System_002ECollections_002EGeneric_002EIEnumerator_003CUnity_002EJobs_002EJobHandle_003E_002Eget_Current()
				{
					return default;
				}

				[Token(Token = "0x60008F4")]
				[Address(RVA = "0x4549794", Offset = "0x4545794", VA = "0x4549794", Slot = "8")]
				[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
				{
				}

				[Token(Token = "0x60008F5")]
				[Address(RVA = "0x45497CC", Offset = "0x45457CC", VA = "0x45497CC", Slot = "7")]
				[DebuggerHidden]
				private object System_002ECollections_002EIEnumerator_002Eget_Current()
				{
					return null;
				}
			}

			[Token(Token = "0x400055B")]
			[FieldOffset(Offset = "0x10")]
			public PointGraph graph;

			[Token(Token = "0x400055C")]
			[FieldOffset(Offset = "0x18")]
			private PointKDTree lookupTree;

			[Token(Token = "0x400055D")]
			[FieldOffset(Offset = "0x20")]
			private PointNode[] nodes;

			[Token(Token = "0x60008EC")]
			[Address(RVA = "0x4548CA4", Offset = "0x4544CA4", VA = "0x4548CA4", Slot = "5")]
			[IteratorStateMachine(typeof(_003CPrepare_003Ed__3))]
			public IEnumerator<JobHandle> Prepare()
			{
				return null;
			}

			[Token(Token = "0x60008ED")]
			[Address(RVA = "0x4548D2C", Offset = "0x4544D2C", VA = "0x4548D2C", Slot = "6")]
			public void Apply(IGraphUpdateContext ctx)
			{
			}

			[Token(Token = "0x60008EE")]
			[Address(RVA = "0x4547E20", Offset = "0x4543E20", VA = "0x4547E20")]
			public PointGraphScanPromise()
			{
			}
		}

		[Token(Token = "0x2000100")]
		private class PointGraphUpdatePromise : IGraphUpdatePromise
		{
			[Token(Token = "0x4000562")]
			[FieldOffset(Offset = "0x10")]
			public PointGraph graph;

			[Token(Token = "0x4000563")]
			[FieldOffset(Offset = "0x18")]
			public List<GraphUpdateObject> graphUpdates;

			[Token(Token = "0x60008F6")]
			[Address(RVA = "0x4549828", Offset = "0x4545828", VA = "0x4549828", Slot = "6")]
			public void Apply(IGraphUpdateContext ctx)
			{
			}

			[Token(Token = "0x60008F7")]
			[Address(RVA = "0x4548958", Offset = "0x4544958", VA = "0x4548958")]
			public PointGraphUpdatePromise()
			{
			}
		}

		[Token(Token = "0x2000101")]
		[CompilerGenerated]
		private sealed class _003CConnectNodesAsync_003Ed__44 : IEnumerable<float>, IEnumerable, IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000564")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000565")]
			[FieldOffset(Offset = "0x14")]
			private float _003C_003E2__current;

			[Token(Token = "0x4000566")]
			[FieldOffset(Offset = "0x18")]
			private int _003C_003El__initialThreadId;

			[Token(Token = "0x4000567")]
			[FieldOffset(Offset = "0x1C")]
			private float maxDistance;

			[Token(Token = "0x4000568")]
			[FieldOffset(Offset = "0x20")]
			public float _003C_003E3__maxDistance;

			[Token(Token = "0x4000569")]
			[FieldOffset(Offset = "0x24")]
			private Vector3 limits;

			[Token(Token = "0x400056A")]
			[FieldOffset(Offset = "0x30")]
			public Vector3 _003C_003E3__limits;

			[Token(Token = "0x400056B")]
			[FieldOffset(Offset = "0x3C")]
			private int nodeCount;

			[Token(Token = "0x400056C")]
			[FieldOffset(Offset = "0x40")]
			public int _003C_003E3__nodeCount;

			[Token(Token = "0x400056D")]
			[FieldOffset(Offset = "0x48")]
			private PointNode[] nodes;

			[Token(Token = "0x400056E")]
			[FieldOffset(Offset = "0x50")]
			public PointNode[] _003C_003E3__nodes;

			[Token(Token = "0x400056F")]
			[FieldOffset(Offset = "0x58")]
			private PointKDTree lookupTree;

			[Token(Token = "0x4000570")]
			[FieldOffset(Offset = "0x60")]
			public PointKDTree _003C_003E3__lookupTree;

			[Token(Token = "0x4000571")]
			[FieldOffset(Offset = "0x68")]
			private PointGraph graph;

			[Token(Token = "0x4000572")]
			[FieldOffset(Offset = "0x70")]
			public PointGraph _003C_003E3__graph;

			[Token(Token = "0x4000573")]
			[FieldOffset(Offset = "0x78")]
			private List<Connection> _003Cconnections_003E5__2;

			[Token(Token = "0x4000574")]
			[FieldOffset(Offset = "0x80")]
			private List<GraphNode> _003CcandidateConnections_003E5__3;

			[Token(Token = "0x4000575")]
			[FieldOffset(Offset = "0x88")]
			private long _003CmaxSquaredRange_003E5__4;

			[Token(Token = "0x4000576")]
			[FieldOffset(Offset = "0x90")]
			private int _003Ci_003E5__5;

			[Token(Token = "0x17000194")]
float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x60008FB")]
				[Address(RVA = "0x454A678", Offset = "0x4546678", VA = "0x454A678", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002ESingle_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000195")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008FD")]
				[Address(RVA = "0x454A6B8", Offset = "0x45466B8", VA = "0x454A6B8", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60008F8")]
			[Address(RVA = "0x4548054", Offset = "0x4544054", VA = "0x4548054")]
			[DebuggerHidden]
			public _003CConnectNodesAsync_003Ed__44(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60008F9")]
			[Address(RVA = "0x4549FC0", Offset = "0x4545FC0", VA = "0x4549FC0", Slot = "7")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008FA")]
			[Address(RVA = "0x4549FC4", Offset = "0x4545FC4", VA = "0x4549FC4", Slot = "8")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60008FB")]
			[Address(RVA = "0x454A678", Offset = "0x4546678", VA = "0x454A678", Slot = "6")]
			[DebuggerHidden]
			private float System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002ESingle_003E_002Eget_Current()
			{
				return default;
			}

			[Token(Token = "0x60008FC")]
			[Address(RVA = "0x454A680", Offset = "0x4546680", VA = "0x454A680", Slot = "10")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60008FD")]
			[Address(RVA = "0x454A6B8", Offset = "0x45466B8", VA = "0x454A6B8", Slot = "9")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60008FE")]
			[Address(RVA = "0x454A714", Offset = "0x4546714", VA = "0x454A714", Slot = "4")]
			[DebuggerHidden]
IEnumerator<float> System.Collections.Generic.IEnumerable<System.Single>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60008FF")]
			[Address(RVA = "0x454A7E0", Offset = "0x45467E0", VA = "0x454A7E0", Slot = "5")]
			[DebuggerHidden]
IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x4000548")]
		[FieldOffset(Offset = "0x50")]
		[JsonMember]
		public Transform root;

		[Token(Token = "0x4000549")]
		[FieldOffset(Offset = "0x58")]
		[JsonMember]
		public string searchTag;

		[Token(Token = "0x400054A")]
		[FieldOffset(Offset = "0x60")]
		[JsonMember]
		public float maxDistance;

		[Token(Token = "0x400054B")]
		[FieldOffset(Offset = "0x64")]
		[JsonMember]
		public Vector3 limits;

		[Token(Token = "0x400054C")]
		[FieldOffset(Offset = "0x70")]
		[JsonMember]
		public bool raycast;

		[Token(Token = "0x400054D")]
		[FieldOffset(Offset = "0x71")]
		[JsonMember]
		public bool use2DPhysics;

		[Token(Token = "0x400054E")]
		[FieldOffset(Offset = "0x72")]
		[JsonMember]
		public bool thickRaycast;

		[Token(Token = "0x400054F")]
		[FieldOffset(Offset = "0x74")]
		[JsonMember]
		public float thickRaycastRadius;

		[Token(Token = "0x4000550")]
		[FieldOffset(Offset = "0x78")]
		[JsonMember]
		public bool recursive;

		[Token(Token = "0x4000551")]
		[FieldOffset(Offset = "0x7C")]
		[JsonMember]
		public LayerMask mask;

		[Token(Token = "0x4000552")]
		[FieldOffset(Offset = "0x80")]
		[JsonMember]
		public bool optimizeForSparseGraph;

		[Token(Token = "0x4000553")]
		[FieldOffset(Offset = "0x88")]
		private PointKDTree lookupTree;

		[Token(Token = "0x4000554")]
		[FieldOffset(Offset = "0x90")]
		private long maximumConnectionLength;

		[Token(Token = "0x4000555")]
		[FieldOffset(Offset = "0x98")]
		public PointNode[] nodes;

		[Token(Token = "0x4000556")]
		[FieldOffset(Offset = "0xA0")]
		[JsonMember]
		public NodeDistanceMode nearestNodeDistanceMode;

		[Token(Token = "0x17000190")]
		public int nodeCount
		{
			[Token(Token = "0x60008CC")]
			[Address(RVA = "0x454684C", Offset = "0x454284C", VA = "0x454684C")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x60008CD")]
			[Address(RVA = "0x4546854", Offset = "0x4542854", VA = "0x4546854")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x17000191")]
		public override bool isScanned
		{
			[Token(Token = "0x60008CE")]
			[Address(RVA = "0x454685C", Offset = "0x454285C", VA = "0x454685C", Slot = "13")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60008CF")]
		[Address(RVA = "0x454686C", Offset = "0x454286C", VA = "0x454686C", Slot = "17")]
		public override int CountNodes()
		{
			return default;
		}

		[Token(Token = "0x60008D0")]
		[Address(RVA = "0x4546874", Offset = "0x4542874", VA = "0x4546874", Slot = "18")]
		public override void GetNodes(Action<GraphNode> action)
		{
		}

		[Token(Token = "0x60008D1")]
		public override void GetNodes<T>(GraphNode.NodeActionWithData<T> action, ref T data)
		{
		}

		[Token(Token = "0x60008D2")]
		[Address(RVA = "0x45468F8", Offset = "0x45428F8", VA = "0x45468F8", Slot = "24")]
		public override NNInfo GetNearest(Vector3 position, ref NearestNodeConstraint constraint)
		{
			return default;
		}

		[Token(Token = "0x60008D3")]
		[Address(RVA = "0x4546CE4", Offset = "0x4542CE4", VA = "0x4546CE4")]
		private NNInfo FindClosestConnectionPoint(PointNode node, Vector3 position, float maxDistanceSqr)
		{
			return default;
		}

		[Token(Token = "0x60008D4")]
		[Address(RVA = "0x4546E74", Offset = "0x4542E74", VA = "0x4546E74", Slot = "25")]
		public override NNInfo RandomPointOnSurface(NearestNodeConstraint constraint, bool highQuality = true)
		{
			return default;
		}

		[Token(Token = "0x60008D5")]
		[Address(RVA = "0x454700C", Offset = "0x454300C", VA = "0x454700C")]
		public PointNode AddNode(Int3 position)
		{
			return null;
		}

		[Token(Token = "0x60008D6")]
		public T AddNode<T>(T node, Int3 position) where T : PointNode
		{
			return null;
		}

		[Token(Token = "0x60008D7")]
		[Address(RVA = "0x45470A4", Offset = "0x45430A4", VA = "0x45470A4")]
		public void RemoveNode(PointNode node)
		{
		}

		[Token(Token = "0x60008D8")]
		[Address(RVA = "0x45472C0", Offset = "0x45432C0", VA = "0x45472C0")]
		public void Clear()
		{
		}

		[Token(Token = "0x60008D9")]
		[Address(RVA = "0x45473D0", Offset = "0x45433D0", VA = "0x45473D0")]
		protected static int CountChildren(Transform tr)
		{
			return default;
		}

		[Token(Token = "0x60008DA")]
		[Address(RVA = "0x45476A0", Offset = "0x45436A0", VA = "0x45476A0")]
		protected static void AddChildren(PointNode[] nodes, ref int c, Transform tr)
		{
		}

		[Token(Token = "0x60008DB")]
		[Address(RVA = "0x4547388", Offset = "0x4543388", VA = "0x4547388")]
		public void RebuildNodeLookup()
		{
		}

		[Token(Token = "0x60008DC")]
		[Address(RVA = "0x4547A78", Offset = "0x4543A78", VA = "0x4547A78")]
		private static PointKDTree BuildNodeLookup(PointNode[] nodes, int nodeCount, bool optimizeForSparseGraph)
		{
			return null;
		}

		[Token(Token = "0x60008DD")]
		[Address(RVA = "0x4547B04", Offset = "0x4543B04", VA = "0x4547B04")]
		public void RebuildConnectionDistanceLookup()
		{
		}

		[Token(Token = "0x60008DE")]
		[Address(RVA = "0x4547B38", Offset = "0x4543B38", VA = "0x4547B38")]
		private static long LongestConnectionLength(PointNode[] nodes, int nodeCount)
		{
			return default;
		}

		[Token(Token = "0x60008DF")]
		[Address(RVA = "0x453F844", Offset = "0x453B844", VA = "0x453F844")]
		public void RegisterConnectionLength(long sqrLength)
		{
		}

		[Token(Token = "0x60008E0")]
		[Address(RVA = "0x4547CA0", Offset = "0x4543CA0", VA = "0x4547CA0", Slot = "37")]
		protected virtual PointNode[] CreateNodes(int count)
		{
			return null;
		}

		[Token(Token = "0x60008E1")]
		[Address(RVA = "0x4547D9C", Offset = "0x4543D9C", VA = "0x4547D9C", Slot = "28")]
		protected override void DestroyAllNodes()
		{
		}

		[Token(Token = "0x60008E2")]
		[Address(RVA = "0x4547DBC", Offset = "0x4543DBC", VA = "0x4547DBC", Slot = "30")]
		protected override IGraphUpdatePromise ScanInternal()
		{
			return null;
		}

		[Token(Token = "0x60008E3")]
		[Address(RVA = "0x4547E28", Offset = "0x4543E28", VA = "0x4547E28")]
		public void ConnectNodes()
		{
		}

		[Token(Token = "0x60008E4")]
		[Address(RVA = "0x4547F90", Offset = "0x4543F90", VA = "0x4547F90")]
		[IteratorStateMachine(typeof(_003CConnectNodesAsync_003Ed__44))]
		private static IEnumerable<float> ConnectNodesAsync(PointNode[] nodes, int nodeCount, PointKDTree lookupTree, float maxDistance, Vector3 limits, PointGraph graph)
		{
			return null;
		}

		[Token(Token = "0x60008E5")]
		[Address(RVA = "0x4548088", Offset = "0x4544088", VA = "0x4548088", Slot = "38")]
		public virtual bool IsValidConnection(GraphNode a, GraphNode b, out float dist)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED PointGraph.IsValidConnection RVA=0x4548088 Token=0x60008E5");
}

		[Token(Token = "0x60008E6")]
		[Address(RVA = "0x45488D0", Offset = "0x45448D0", VA = "0x45488D0", Slot = "36")]
IGraphUpdatePromise IUpdatableGraph.ScheduleGraphUpdates(List<GraphUpdateObject> graphUpdates)
		{
			return null;
		}

		[Token(Token = "0x60008E7")]
		[Address(RVA = "0x4548960", Offset = "0x4544960", VA = "0x4548960", Slot = "34")]
		protected override void PostDeserialization(GraphSerializationContext ctx)
		{
		}

		[Token(Token = "0x60008E8")]
		[Address(RVA = "0x4548964", Offset = "0x4544964", VA = "0x4548964", Slot = "22")]
		public override void RelocateNodes(Matrix4x4 deltaMatrix)
		{
		}

		[Token(Token = "0x60008E9")]
		[Address(RVA = "0x45489A0", Offset = "0x45449A0", VA = "0x45489A0", Slot = "32")]
		protected override void SerializeExtraInfo(GraphSerializationContext ctx)
		{
		}

		[Token(Token = "0x60008EA")]
		[Address(RVA = "0x4548AB4", Offset = "0x4544AB4", VA = "0x4548AB4", Slot = "33")]
		protected override void DeserializeExtraInfo(GraphSerializationContext ctx)
		{
		}

		[Token(Token = "0x60008EB")]
		[Address(RVA = "0x4548C34", Offset = "0x4544C34", VA = "0x4548C34")]
		public PointGraph()
		{
		}
	}
}
