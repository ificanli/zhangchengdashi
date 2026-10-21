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
			public float[] factors = new float[3];

			[Token(Token = "0x4000463")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ChannelUse[] channels = new ChannelUse[3];

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
			{}
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
				{}
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
					{ return _003C_003E2__current; }
				}

				[Token(Token = "0x1700015E")]
object System.Collections.IEnumerator.Current
				{
					[Token(Token = "0x6000706")]
					[Address(RVA = "0x452B768", Offset = "0x4527768", VA = "0x452B768", Slot = "7")]
					[DebuggerHidden]
					get
					{ return _003C_003E2__current; }
				}

				[Token(Token = "0x6000701")]
				[Address(RVA = "0x4529950", Offset = "0x4525950", VA = "0x4529950")]
				[DebuggerHidden]
				public _003CPrepare_003Ed__22(int _003C_003E1__state)
				{ this._003C_003E1__state=_003C_003E1__state; }

				[Token(Token = "0x6000702")]
				[Address(RVA = "0x4529D9C", Offset = "0x4525D9C", VA = "0x4529D9C", Slot = "5")]
				[DebuggerHidden]
void System.IDisposable.Dispose()
				{}

				[Token(Token = "0x6000703")]
				[Address(RVA = "0x4529DA0", Offset = "0x4525DA0", VA = "0x4529DA0", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
				{
 var p=_003C_003E4__this;
 switch (_003C_003E1__state) {
  case 0: _003C_003E1__state=-1;break;
  case 1: _003C_003E1__state=-1;goto HeightReady;
  case 2: _003C_003E1__state=-1;goto WaitBeforeCollision;
  case 3: _003C_003E1__state=-1;p.context.tracker.timeSlice=TimeSlice.MillisFromNow(2f);goto WaitCollision;
  case 4: _003C_003E1__state=-1;goto WaitBeforeConnections;
  case 5: _003C_003E1__state=-1;goto WaitAfterConnections;
  case 6: _003C_003E1__state=-1;goto WaitAfterErosion;
  case 7: _003C_003E1__state=-1;goto WaitAfterErodedConnections;
  case 8: _003C_003E1__state=-1;goto WaitPostProcess;
  case 9: _003C_003E1__state=-1;goto WaitFinalWrites;
  case 10: _003C_003E1__state=-1;p.dependencyTracker.ClearMemory();return false;
  default:return false;
 }
 if (p.emptyUpdate) return false;
 _003Ccollision_003E5__2=p.graph.collision;
 _003Crules_003E5__3=p.graph.rules;
 if (p.recalculationMode!=RecalculationMode.RecalculateFromScratch) {
  _003CminLayers_003E5__4=p.graph.nodeData.bounds.max.y;
  p.readBounds.max.y=p.fullRecalculationBounds.max.y=p.writeMaskBounds.max.y=_003CminLayers_003E5__4;
  if (p.recalculationMode==RecalculationMode.RecalculateMinimal && p.readBounds==p.fullRecalculationBounds) p.recalculationMode=RecalculationMode.RecalculateFromScratch;
 } else _003CminLayers_003E5__4=1;
 _003ClayeredDataLayout_003E5__5=p.graph is LayerGridGraph;
 _003CcharacterHeight_003E5__6=p.graph is LayerGridGraph layered ? layered.characterHeight : float.PositiveInfinity;
 p.context=new GridGraphRules.Context { graph=p.graph,data=new GridGraphScanData { dependencyTracker=p.dependencyTracker,up=p.transform.TransformVector(Vector3.up).normalized,transform=p.transform } };
 if (unchecked((uint)p.recalculationMode)>1u) {
  p.context.data.nodes=new GridGraphNodeData { allocationMethod=p.allocationMethod,numNodes=p.readBounds.volume,bounds=p.readBounds,layeredDataLayout=_003ClayeredDataLayout_003E5__5 };
  p.context.data.nodes.AllocateBuffers(p.dependencyTracker);
  p.context.data.nodes.CopyFrom(p.graph.nodeData,true,p.dependencyTracker);
  goto DefaultsReady;
 }
 if (_003Ccollision_003E5__2.heightCheck && !_003Ccollision_003E5__2.use2D) {
  _003ClayerCount_003E5__7=p.dependencyTracker.NewNativeArray<int>(1,p.allocationMethod,NativeArrayOptions.UninitializedMemory);
  float nodeWidth=p.graph.nodeSize;
  if (p.graph.neighbours==NumNeighbours.Six) nodeWidth=ConvertNodeSizeToHexagonSize(InspectorGridHexagonNodeSize.Width,nodeWidth);
  _003C_003E2__current=p.context.data.HeightCheck(_003Ccollision_003E5__2,nodeWidth,p.graph.MaxLayers,p.fullRecalculationBounds,_003ClayerCount_003E5__7,_003CcharacterHeight_003E5__6,p.allocationMethod);
  _003C_003E1__state=1;return true;
 }
 p.context.data.nodes=new GridGraphNodeData { allocationMethod=p.allocationMethod,numNodes=p.fullRecalculationBounds.volume,bounds=p.fullRecalculationBounds,layeredDataLayout=_003ClayeredDataLayout_003E5__5 };
 p.context.data.nodes.AllocateBuffers(p.dependencyTracker);
 p.context.data.SetDefaultNodePositions(p.transform);
 p.context.data.nodes.walkable.MemSet(true).Schedule(p.dependencyTracker);
 p.context.data.nodes.normals.MemSet(new float4(p.context.data.up,0f)).Schedule(p.dependencyTracker);
 goto DefaultsReady;
HeightReady:
 {
  int layers=System.Math.Max(_003CminLayers_003E5__4,_003ClayerCount_003E5__7[0]);
  p.writeMaskBounds.max.y=p.fullRecalculationBounds.max.y=p.readBounds.max.y=layers;
  p.context.data.heightHitsBounds.max.y=_003ClayerCount_003E5__7[0];
  p.context.data.nodes=new GridGraphNodeData { allocationMethod=p.allocationMethod,numNodes=p.fullRecalculationBounds.volume,bounds=p.fullRecalculationBounds,layeredDataLayout=_003ClayeredDataLayout_003E5__5 };
  p.context.data.nodes.AllocateBuffers(p.dependencyTracker);
  p.context.data.SetDefaultNodePositions(p.transform);
  p.context.data.CopyHits(p.context.data.heightHitsBounds);
  p.context.data.CalculateWalkabilityFromHeightData(p.graph.useRaycastNormal,_003Ccollision_003E5__2.unwalkableWhenNoGround,p.graph.maxSlope,_003CcharacterHeight_003E5__6);
  _003ClayerCount_003E5__7=default(NativeArray<int>);
 }
DefaultsReady:
 p.context.data.SetDefaultPenalties(p.graph.initialPenalty);
 JobHandle.ScheduleBatchedJobs();
 _003Crules_003E5__3.RebuildIfNecessary();
 _003Cwait_003E5__8=_003Crules_003E5__3.ExecuteRule(GridGraphRule.Pass.BeforeCollision,p.context);
WaitBeforeCollision:
 if (_003Cwait_003E5__8.MoveNext()) { _003C_003E2__current=_003Cwait_003E5__8.Current;_003C_003E1__state=2;return true; }
 _003Cwait_003E5__8=null;
 if (!_003Ccollision_003E5__2.collisionCheck) goto CollisionFinished;
 p.context.tracker.timeSlice=TimeSlice.MillisFromNow(1f);
 _003Cwait_003E5__8=p.context.data.CollisionCheck(_003Ccollision_003E5__2,p.fullRecalculationBounds);
WaitCollision:
  if (_003Cwait_003E5__8!=null && _003Cwait_003E5__8.MoveNext()) { _003C_003E2__current=_003Cwait_003E5__8.Current;_003C_003E1__state=3;return true; }
  _003Cwait_003E5__8=null;
CollisionFinished:
 _003Cwait_003E5__8=_003Crules_003E5__3.ExecuteRule(GridGraphRule.Pass.BeforeConnections,p.context);
WaitBeforeConnections:
 if (_003Cwait_003E5__8.MoveNext()) { _003C_003E2__current=_003Cwait_003E5__8.Current;_003C_003E1__state=4;return true; }
 _003Cwait_003E5__8=null;
 if (p.recalculationMode==RecalculationMode.RecalculateMinimal) {
  var data=new GridGraphNodeData { allocationMethod=p.allocationMethod,numNodes=p.readBounds.volume,bounds=p.readBounds,layeredDataLayout=_003ClayeredDataLayout_003E5__5 };
  data.AllocateBuffers(p.dependencyTracker);
  data.normals.MemSet(float4.zero).Schedule(p.dependencyTracker);
  data.walkable.MemSet(false).Schedule(p.dependencyTracker);
  data.walkableWithErosion.MemSet(false).Schedule(p.dependencyTracker);
  data.CopyFrom(p.graph.nodeData,true,p.dependencyTracker);
  data.CopyFrom(p.context.data.nodes,p.graphUpdateObject==null||p.graphUpdateObject.resetPenaltyOnPhysics,p.dependencyTracker);
  p.context.data.nodes=data;
 }
 if (p.graphUpdateObject!=null) {
  if (p.graphUpdateObject.GetType()!=typeof(GraphUpdateObject)) {
   for (int y=p.writeMaskBounds.min.y;y<p.writeMaskBounds.max.y;y++)
    for (int z=p.writeMaskBounds.min.z;z<p.writeMaskBounds.max.z;z++)
     for (int x=p.writeMaskBounds.min.x;x<p.writeMaskBounds.max.x;x++) p.graphUpdateObject.WillUpdateNode(p.nodes.nodes[unchecked(x+p.nodeArrayBounds.x*(z+y*p.nodeArrayBounds.z))]);
  }
  if (p.rect.IsValid()) {
   var area=new IntBounds(p.rect.xmin,0,p.rect.ymin,unchecked(p.rect.xmax+1),p.context.data.nodes.layers,unchecked(p.rect.ymax+1));
   area=area.Offset(-p.context.data.nodes.bounds.min);
   var indices=p.dependencyTracker.NewNativeArray<int>(area.volume,p.context.data.nodes.allocationMethod,NativeArrayOptions.ClearMemory);
   var dimensions=p.context.data.nodes.bounds.size;int cursor=0;
   for (int y=area.min.y;y<area.max.y;y++) for (int z=area.min.z;z<area.max.z;z++) for (int x=area.min.x;x<area.max.x;x++) indices[cursor++]=unchecked(x+dimensions.x*(z+y*dimensions.z));
   p.graphUpdateObject.ApplyJob(new GraphUpdateObject.GraphUpdateData { nodePositions=p.context.data.nodes.positions,nodePenalties=p.context.data.nodes.penalties,nodeWalkable=p.context.data.nodes.walkable,nodeTags=p.context.data.nodes.tags,nodeNormals=p.context.data.nodes.normals,nodeIndices=indices },p.dependencyTracker);
  }
 }
 p.context.data.Connections(p.graph.maxStepHeight,p.graph.maxStepUsesSlope,p.context.data.nodes.bounds,p.graph.neighbours,p.graph.cutCorners,_003Ccollision_003E5__2.use2D,false,_003CcharacterHeight_003E5__6);
 _003Cwait_003E5__8=_003Crules_003E5__3.ExecuteRule(GridGraphRule.Pass.AfterConnections,p.context);
WaitAfterConnections:
 if (_003Cwait_003E5__8.MoveNext()) { _003C_003E2__current=_003Cwait_003E5__8.Current;_003C_003E1__state=5;return true; }
 _003Cwait_003E5__8=null;
 if (p.graph.erodeIterations<1) { p.context.data.nodes.walkable.CopyToJob(p.context.data.nodes.walkableWithErosion).Schedule(p.dependencyTracker);goto ErosionFinished; }
  p.context.data.Erosion(p.graph.neighbours,p.graph.erodeIterations,p.writeMaskBounds,p.graph.erosionUseTags,p.graph.erosionFirstTag,p.graph.erosionTagsPrecedenceMask);
  _003Cwait_003E5__8=_003Crules_003E5__3.ExecuteRule(GridGraphRule.Pass.AfterErosion,p.context);
WaitAfterErosion:
  if (_003Cwait_003E5__8.MoveNext()) { _003C_003E2__current=_003Cwait_003E5__8.Current;_003C_003E1__state=6;return true; }
  _003Cwait_003E5__8=null;
  p.context.data.Connections(p.graph.maxStepHeight,p.graph.maxStepUsesSlope,p.context.data.nodes.bounds,p.graph.neighbours,p.graph.cutCorners,_003Ccollision_003E5__2.use2D,true,_003CcharacterHeight_003E5__6);
  _003Cwait_003E5__8=_003Crules_003E5__3.ExecuteRule(GridGraphRule.Pass.AfterConnections,p.context);
WaitAfterErodedConnections:
  if (_003Cwait_003E5__8.MoveNext()) { _003C_003E2__current=_003Cwait_003E5__8.Current;_003C_003E1__state=7;return true; }
  _003Cwait_003E5__8=null;
ErosionFinished:
 _003Cwait_003E5__8=_003Crules_003E5__3.ExecuteRule(GridGraphRule.Pass.PostProcess,p.context);
WaitPostProcess:
 if (_003Cwait_003E5__8.MoveNext()) { _003C_003E2__current=_003Cwait_003E5__8.Current;_003C_003E1__state=8;return true; }
 _003Cwait_003E5__8=null;
 p.graph.nodeData.TrackBuffers(p.dependencyTracker);
 if (p.recalculationMode!=RecalculationMode.RecalculateFromScratch) {
  p.graph.nodeData.ResizeLayerCount(p.context.data.nodes.layers,p.dependencyTracker);
  p.graph.nodeData.CopyFrom(p.context.data.nodes,p.writeMaskBounds,true,p.dependencyTracker);
 } else p.graph.nodeData=p.context.data.nodes;
 p.graph.nodeData.PersistBuffers(p.dependencyTracker);
 _003C_003E2__current=p.nodesDependsOn;_003C_003E1__state=9;return true;
WaitFinalWrites:
 _003C_003E2__current=p.dependencyTracker.AllWritesDependency;_003C_003E1__state=10;return true;
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
				{ throw new System.NotSupportedException(); }

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
				{ return fullRecalculationBounds.volume; }
			}

			[Token(Token = "0x60006FB")]
			[Address(RVA = "0x4528C64", Offset = "0x4524C64", VA = "0x4528C64")]
			public GridGraphUpdatePromise(GridGraph graph, GraphTransform transform, NodesHolder nodes, int3 nodeArrayBounds, IntRect rect, JobDependencyTracker dependencyTracker, JobHandle nodesDependsOn, Allocator allocationMethod, RecalculationMode recalculationMode, GraphUpdateObject graphUpdateObject, bool ownsJobDependencyTracker, bool isFinalUpdate)
			{
 this.graph=graph; this.nodes=nodes; this.nodeArrayBounds=nodeArrayBounds; this.transform=transform;
 this.dependencyTracker=dependencyTracker; this.nodesDependsOn=nodesDependsOn;
 this.allocationMethod=allocationMethod; this.recalculationMode=recalculationMode; this.graphUpdateObject=graphUpdateObject;
 this.ownsJobDependencyTracker=ownsJobDependencyTracker; this.isFinalUpdate=isFinalUpdate;
 IntRect full, mask, read;
 CalculateRectangles(graph, rect, out this.rect, out full, out mask, out read);
 if (recalculationMode == RecalculationMode.RecalculateFromScratch) full=read;
 if (!full.IsValid()) emptyUpdate=true;
 readBounds=new IntBounds(read.xmin,0,read.ymin,unchecked(read.xmax+1),nodeArrayBounds.y,unchecked(read.ymax+1));
 fullRecalculationBounds=new IntBounds(full.xmin,0,full.ymin,unchecked(full.xmax+1),nodeArrayBounds.y,unchecked(full.ymax+1));
 writeMaskBounds=new IntBounds(mask.xmin,0,mask.ymin,unchecked(mask.xmax+1),nodeArrayBounds.y,unchecked(mask.ymax+1));
 if (ownsJobDependencyTracker) dependencyTracker.SetLinearDependencies(fullRecalculationBounds.volume < 500);
}

			[Token(Token = "0x60006FC")]
			[Address(RVA = "0x4529754", Offset = "0x4525754", VA = "0x4529754")]
			public static void CalculateRectangles(GridGraph graph, IntRect rect, out IntRect originalRect, out IntRect fullRecalculationRect, out IntRect writeMaskRect, out IntRect readRect)
			{
 fullRecalculationRect = rect;
 if (graph.collision.collisionCheck && graph.collision.type != ColliderType.Ray) {
  float value = graph.collision.diameter * 0.5f + 0.5f;
  int radius = float.IsNaN(value) ? 0 : float.IsPositiveInfinity(value) ? int.MinValue : value >= int.MaxValue ? int.MaxValue : value <= int.MinValue ? int.MinValue : (int)Math.Floor(value);
  fullRecalculationRect = fullRecalculationRect.Expand(radius);
 }
 writeMaskRect = fullRecalculationRect.Expand(unchecked(graph.erodeIterations + 1));
 readRect = writeMaskRect.Expand(unchecked(graph.erodeIterations + 1));
 var bounds = new IntRect(0,0,unchecked(graph.width-1),unchecked(graph.depth-1));
 readRect = IntRect.Intersection(readRect, bounds);
 fullRecalculationRect = IntRect.Intersection(fullRecalculationRect, bounds);
 writeMaskRect = IntRect.Intersection(writeMaskRect, bounds);
 originalRect = IntRect.Intersection(rect, bounds);
}

			[Token(Token = "0x60006FD")]
			[Address(RVA = "0x45298F0", Offset = "0x45258F0", VA = "0x45298F0", Slot = "5")]
			[IteratorStateMachine(typeof(_003CPrepare_003Ed__22))]
			public IEnumerator<JobHandle> Prepare()
			{ return new _003CPrepare_003Ed__22(0) { _003C_003E4__this=this }; }

			[Token(Token = "0x60006FE")]
			[Address(RVA = "0x4529978", Offset = "0x4525978", VA = "0x4529978", Slot = "6")]
			public void Apply(IGraphUpdateContext ctx)
			{
 graph.AssertSafeToUpdateGraph();
 if (emptyUpdate) {
  Dispose();
  if (isFinalUpdate) graph.rules.ExecuteRuleMainThread(GridGraphRule.Pass.AfterApplied,context??new GridGraphRules.Context { graph=graph });
  return;
 }
 var originalHolderNodes=nodes.nodes; var originalGraphNodes=graph.nodes;
 if (context.data.nodes.layers>=2) {
  nodeArrayBounds.y=context.data.nodes.layers;
  Pathfinding.Util.Memory.Realloc(ref nodes.nodes,unchecked(nodeArrayBounds.x*nodeArrayBounds.y*nodeArrayBounds.z));
  new Pathfinding.Graphs.Grid.Jobs.JobAllocateNodes { active=graph.active,nodeNormals=context.data.nodes.normals,dataBounds=context.data.nodes.bounds,nodeArrayBounds=nodeArrayBounds,nodes=nodes.nodes,newGridNodeDelegate=graph.newGridNodeDelegate }.Execute();
 }
 graph.nodeData.AssignToNodes(nodes.nodes,nodeArrayBounds,writeMaskBounds,graph.graphIndex,default(JobHandle),dependencyTracker).Complete();
 if (nodes.nodes!=graph.nodes) {
  if (originalHolderNodes!=originalGraphNodes) graph.DestroyAllNodes();
  graph.nodes=nodes.nodes;graph.LayerCount=context.data.nodes.layers;
 }
 ctx.DirtyBounds(graph.GetBoundsFromRect(new IntRect(writeMaskBounds.min.x,writeMaskBounds.min.z,unchecked(writeMaskBounds.max.x-1),unchecked(writeMaskBounds.max.z-1))));
 Dispose();
 if (isFinalUpdate) graph.rules.ExecuteRuleMainThread(GridGraphRule.Pass.AfterApplied,context);
}

			[Token(Token = "0x60006FF")]
			[Address(RVA = "0x4529D3C", Offset = "0x4525D3C", VA = "0x4529D3C")]
			public void Dispose()
			{
 if (ownsJobDependencyTracker) {
  Pathfinding.Pooling.ObjectPool<JobDependencyTracker>.Release(ref dependencyTracker);
  if (context!=null) context.data.dependencyTracker=null;
 }
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
		public float aspectRatio = 1f;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[JsonMember]
		public float isometricAngle;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly float StandardIsometricAngle = 54.7356109619140625f;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static readonly float StandardDimetricAngle = 60.000003814697265625f;

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
		public Vector2 unclampedSize = new Vector2(10f, 10f);

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[JsonMember]
		public float nodeSize = 1f;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[JsonMember]
		public GraphCollision collision = new GraphCollision();

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[JsonMember]
		public float maxStepHeight = 0.4f;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		[JsonMember]
		public bool maxStepUsesSlope = true;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[JsonMember]
		public float maxSlope = 90f;

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
		public int erosionFirstTag = 1;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[JsonMember]
		public int erosionTagsPrecedenceMask = -1;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[JsonMember]
		public NumNeighbours neighbours = NumNeighbours.Eight;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[JsonMember]
		public bool cutCorners = true;

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
		public float penaltyPositionFactor = 1f;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[JsonMember]
		[Obsolete("Use the RuleAnglePenalty class instead")]
		public bool penaltyAngle;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[Obsolete("Use the RuleAnglePenalty class instead")]
		[JsonMember]
		public float penaltyAngleFactor = 100f;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[Obsolete("Use the RuleAnglePenalty class instead")]
		[JsonMember]
		public float penaltyAnglePower = 1f;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[JsonMember]
		public GridGraphRules rules = new GridGraphRules();

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[JsonMember]
		public bool showMeshOutline = true;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE1")]
		[JsonMember]
		public bool showNodeConnections;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE2")]
		[JsonMember]
		public bool showMeshSurface = true;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[JsonMember]
		[Obsolete("Use the RuleTexture class instead")]
		public TextureData textureData = new TextureData();

		[NonSerialized]
		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public readonly int[] neighbourOffsets = new int[8];

		[NonSerialized]
		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public readonly float[] neighbourCosts = new float[8];

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly int[] neighbourXOffsets = new int[] { 0,1,0,-1,1,1,-1,-1 };

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly int[] neighbourZOffsets = new int[] { -1,0,1,0,-1,1,1,-1 };

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal static readonly int[] hexagonNeighbourIndices = new int[] { 0,1,5,2,3,7 };

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal static readonly int[] axisAlignedNeighbourIndices = new int[] { 0,1,2,3 };

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal static readonly int[] allNeighbourIndices = new int[] { 0,1,2,3,4,5,6,7 };

		[Token(Token = "0x400045A")]
		internal const int HexagonConnectionMask = 175;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public GridNodeBase[] nodes;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		protected GridGraphNodeData nodeData;

		[Token(Token = "0x17000154")]
		public GraphTransform transform
		{
			[Token(Token = "0x600069E")]
			[Address(RVA = "0x451D0BC", Offset = "0x45190BC", VA = "0x451D0BC", Slot = "37")]
			[CompilerGenerated]
			get
			;
			[Token(Token = "0x600069F")]
			[Address(RVA = "0x451D0C4", Offset = "0x45190C4", VA = "0x451D0C4")]
			[CompilerGenerated]
			private set
			;
		} = new GraphTransform(Matrix4x4.identity);

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		protected Func<GridNodeBase> newGridNodeDelegate = () => new GridNode();

		[Token(Token = "0x400045F")]
		public const int FixedPrecisionScale = 1024;

		[Token(Token = "0x1700014E")]
		public virtual int LayerCount
		{
			[Token(Token = "0x6000691")]
			[Address(RVA = "0x451CE98", Offset = "0x4518E98", VA = "0x451CE98", Slot = "48")]
			get
			{ return 1; }
			[Token(Token = "0x6000692")]
			[Address(RVA = "0x451CEA0", Offset = "0x4518EA0", VA = "0x451CEA0", Slot = "49")]
			protected set
			{ if (value!=1) throw new System.NotSupportedException("Grid graphs cannot have multiple layers"); }
		}

		[Token(Token = "0x1700014F")]
		public virtual int MaxLayers
		{
			[Token(Token = "0x6000693")]
			[Address(RVA = "0x451CEF8", Offset = "0x4518EF8", VA = "0x451CEF8", Slot = "50")]
			get
			{ return 1; }
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
			{ return math.abs(90f-maxSlope)>float.Epsilon; }
		}

		[Token(Token = "0x17000152")]
		public Vector2 size
		{
			[Token(Token = "0x600069A")]
			[Address(RVA = "0x451D010", Offset = "0x4519010", VA = "0x451D010")]
			[CompilerGenerated]
			get
			;
			[Token(Token = "0x600069B")]
			[Address(RVA = "0x451D018", Offset = "0x4519018", VA = "0x451D018")]
			[CompilerGenerated]
			protected set
			;
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
 GetNodes(node=>{ var gridNode=node as GridNodeBase; gridNode.ClearCustomConnections(true); node.ClearConnections(false); node.Destroy(); });
 nodes=null;
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
		{ if (nodes!=null) for (int i=0;i<nodes.Length;i++) if (nodes[i]!=null) action(nodes[i]); }

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
		{ var result = new GridNodeBase[size]; dependency = active.AllocateNodes(result, size, newGridNodeDelegate, 1); return result; }

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
 if (mode == InspectorGridHexagonNodeSize.Width) return value * 0.8164966106414795f;
 if (mode == InspectorGridHexagonNodeSize.Diameter) return value * 0.9428090453147888f;
 return value;
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
 int width,depth; float size;
 CalculateDimensions(out width,out depth,out size);
 Matrix4x4 layout;
 if (neighbours==NumNeighbours.Six) {
  float horizontal=size*aspectRatio;
  layout=new Matrix4x4(new Vector4(horizontal*0.8164966106414795f,0f,0f,0f),new Vector4(0f,1f,0f,0f),new Vector4((horizontal*-0.5f)*0.8164966106414795f,0f,size*0.7071067690849304f,0f),new Vector4(0f,0f,0f,1f));
  var centered=Matrix4x4.TRS(center,Quaternion.Euler(rotation),Vector3.one)*layout;
  var origin=centered.MultiplyPoint3x4(new Vector3((float)width*-0.5f,-0.0f,(float)depth*-0.5f));
  return new GraphTransform(Matrix4x4.TRS(origin,Quaternion.Euler(rotation),Vector3.one)*layout);
 }
 float cosine=Mathf.Cos(isometricAngle*0.01745329238474369f);
 layout=Matrix4x4.Scale(new Vector3(size*aspectRatio,1f,size));
 float angle=Mathf.Atan2(size,size*aspectRatio)*57.295780181884766f;
 var isometric=Matrix4x4.Rotate(Quaternion.Euler(0f,-angle,0f))*Matrix4x4.Scale(new Vector3(cosine,1f,1f))*Matrix4x4.Rotate(Quaternion.Euler(0f,angle,0f));
 layout=isometric*layout;
 var positioned=Matrix4x4.TRS(center,Quaternion.Euler(rotation),Vector3.one)*layout;
 var corner=positioned.MultiplyPoint3x4(new Vector3((float)width*-0.5f,-0.0f,(float)depth*-0.5f));
 return new GraphTransform(Matrix4x4.TRS(corner,Quaternion.Euler(rotation),Vector3.one)*layout);
}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x451EDB8", Offset = "0x451ADB8", VA = "0x451EDB8")]
		private void CalculateDimensions(out int width, out int depth, out float nodeSize)
		{
 float x = unclampedSize.x < 0 ? -unclampedSize.x : unclampedSize.x;
 float y = unclampedSize.y < 0 ? -unclampedSize.y : unclampedSize.y;
 nodeSize = this.nodeSize > x * (1f / 1024f) ? this.nodeSize : x * (1f / 1024f);
 nodeSize = this.nodeSize > y * (1f / 1024f) ? this.nodeSize : y * (1f / 1024f);
 size = new Vector2(x >= nodeSize ? x : nodeSize, y >= nodeSize ? y : nodeSize);
 width = Mathf.FloorToInt(size.x / nodeSize);
 depth = Mathf.FloorToInt(size.y / nodeSize);
 if (Mathf.Approximately(Mathf.CeilToInt(size.x / nodeSize), size.x / nodeSize)) width = Mathf.CeilToInt(size.x / nodeSize);
 if (Mathf.Approximately(Mathf.CeilToInt(size.y / nodeSize), size.y / nodeSize)) depth = Mathf.CeilToInt(size.y / nodeSize);
}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x451F8F4", Offset = "0x451B8F4", VA = "0x451F8F4", Slot = "23")]
		public override float NearestNodeDistanceSqrLowerBound(Vector3 position, ref NearestNodeConstraint constraint)
		{
 if (nodes == null) return float.PositiveInfinity;
 int capturedWidth = width;
 int capturedDepth = depth;
 int layers = LayerCount;
 if (nodes.Length != unchecked(capturedWidth * capturedDepth * layers)) return float.PositiveInfinity;
 Vector3 graphPosition = transform.InverseTransform(position);
 float clampedX = graphPosition.x > width ? width : graphPosition.x;
 if (graphPosition.x < 0f) clampedX = 0f;
 float clampedZ = graphPosition.z > depth ? depth : graphPosition.z;
 if (graphPosition.z < 0f) clampedZ = 0f;
 float dx = graphPosition.x - clampedX;
 float dz = graphPosition.z - clampedZ;
 return dx * dx + dz * dz;
}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x451F9D0", Offset = "0x451B9D0", VA = "0x451F9D0", Slot = "52")]
		protected virtual GridNodeBase GetNearestFromGraphSpace(Vector3 positionGraphSpace)
		{
 if (nodes == null || nodes.Length != unchecked(width * depth)) return null;
 float px = positionGraphSpace.x, pz = positionGraphSpace.z;
 int x = float.IsNaN(px) ? 0 : float.IsPositiveInfinity(px) ? int.MinValue : px >= int.MaxValue ? int.MaxValue : px <= int.MinValue ? int.MinValue : (int)px;
 int z = float.IsNaN(pz) ? 0 : float.IsPositiveInfinity(pz) ? int.MinValue : pz >= int.MaxValue ? int.MaxValue : pz <= int.MinValue ? int.MinValue : (int)pz;
 x = x < 0 ? 0 : x > unchecked(width - 1) ? unchecked(width - 1) : x;
 z = z < 0 ? 0 : z > unchecked(depth - 1) ? unchecked(depth - 1) : z;
 return nodes[unchecked(z * width + x)];
}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x451FA64", Offset = "0x451BA64", VA = "0x451FA64", Slot = "24")]
		public override NNInfo GetNearest(Vector3 position, ref NearestNodeConstraint constraint)
		{
 if (nodes == null || nodes.Length != unchecked(width * depth * LayerCount)) return NNInfo.Empty;
 Vector3 graphPosition = transform.InverseTransform(position);
 float px = graphPosition.x, pz = graphPosition.z;
 int x = float.IsNaN(px) ? 0 : float.IsPositiveInfinity(px) ? int.MinValue : px >= int.MaxValue ? int.MaxValue : px <= int.MinValue ? int.MinValue : (int)px;
 int z = float.IsNaN(pz) ? 0 : float.IsPositiveInfinity(pz) ? int.MinValue : pz >= int.MaxValue ? int.MaxValue : pz <= int.MinValue ? int.MinValue : (int)pz;
 x = x < 0 ? 0 : x > unchecked(width - 1) ? unchecked(width - 1) : x;
 z = z < 0 ? 0 : z > unchecked(depth - 1) ? unchecked(depth - 1) : z;
 bool projected = constraint.distanceMetric.isProjectedDistance;
 float maximum = constraint.maxDistanceSqrOrDefault(active);
 int layers = LayerCount, planeSize = unchecked(width * depth);
 Int3 up = default;
 long queryDot = 0;
 float projectionScale = 0;
 if (projected) {
  up = (Int3)transform.WorldUpAtGraphPosition(graphPosition);
  queryDot = Int3.DotLong((Int3)position,up);
  projectionScale = (constraint.distanceMetric.distanceScaleAlongProjectionDirection * 0.001f) * 0.001f;
 }
 bool allSuitable = constraint.allNodesAreSuitable;
 GridNodeBase best = null;
 float bestCost = maximum;
 float cx = px < (float)x + 1f ? px : (float)x + 1f;
 cx = cx > (float)x ? cx : (float)x;
 float cz = pz < (float)z + 1f ? pz : (float)z + 1f;
 cz = cz > (float)z ? cz : (float)z;
 float dx = cx - px, dz = cz - pz;
 float cellDistance = dx * dx + dz * dz;
 int index = unchecked(z * width + x);
 for (int layer = 0; layer < layers; layer++, index = unchecked(index + planeSize)) {
  GridNodeBase node = nodes[index];
  if (node == null || (!allSuitable && !constraint.Suitable(node))) continue;
  float cost;
  if (projected) {
   float lateral = (float)System.Math.Sqrt(cellDistance * (nodeSize * nodeSize));
   float vertical = System.Math.Abs(projectionScale * (float)unchecked(Int3.DotLong(node.position,up) - queryDot));
   float distance = lateral + vertical;
   cost = distance * distance;
  } else {
   float nx = node.position.x * 0.001f - position.x;
   float ny = node.position.y * 0.001f - position.y;
   float nz = node.position.z * 0.001f - position.z;
   cost = nz * nz + (nx * nx + ny * ny);
  }
  if (cost <= bestCost) { bestCost = cost; best = node; }
 }
 float bx = px - (float)x, bz = pz - (float)z;
 bx = bx < 1f - bx ? bx : 1f - bx;
 bz = bz < 1f - bz ? bz : 1f - bz;
 float border = (bx < bz ? bx : bz) * nodeSize;
 float initialBound = border + nodeSize * 0f;
 if (!(bestCost - 0.00001f <= initialBound * initialBound)) {
  for (int radius = 1; ; radius = unchecked(radius + 1)) {
   int tx = unchecked(x + radius), tz = z, stepX = -1, stepZ = 1;
   bool anyInside = false;
   for (int side = 0; side < 4; side++) {
    for (int point = 0; point < radius; point++) {
     if ((tx | tz) >= 0 && tx < width && tz < depth) {
      anyInside = true;
      cx = px < (float)tx + 1f ? px : (float)tx + 1f;
      cx = cx > (float)tx ? cx : (float)tx;
      cz = pz < (float)tz + 1f ? pz : (float)tz + 1f;
      cz = cz > (float)tz ? cz : (float)tz;
      dx = cx - px; dz = cz - pz;
      cellDistance = dz * dz + dx * dx;
      index = unchecked(tz * width + tx);
      for (int layer = 0; layer < layers; layer++, index = unchecked(index + planeSize)) {
       GridNodeBase node = nodes[index];
       if (node == null || (!allSuitable && !constraint.Suitable(node))) continue;
       float cost;
       if (projected) {
        float lateral = (float)System.Math.Sqrt(cellDistance * (nodeSize * nodeSize));
        float vertical = System.Math.Abs(projectionScale * (float)unchecked(Int3.DotLong(node.position,up) - queryDot));
        float distance = lateral + vertical;
        cost = distance * distance;
       } else {
        float nx = node.position.x * 0.001f - position.x;
        float ny = node.position.y * 0.001f - position.y;
        float nz = node.position.z * 0.001f - position.z;
        cost = nz * nz + (nx * nx + ny * ny);
       }
       if (cost <= bestCost) { bestCost = cost; best = node; }
      }
     }
     tx = unchecked(tx + stepX); tz = unchecked(tz + stepZ);
    }
    int oldStepZ = stepZ; stepZ = stepX; stepX = unchecked(-oldStepZ);
   }
   if (!anyInside) break;
   int expansion = unchecked(radius - 1);
   float bound = border + nodeSize * (float)(expansion < 0 ? 0 : expansion);
   if (bestCost - 0.00001f <= bound * bound) break;
  }
 }
 if (best == null) return NNInfo.Empty;
 if (projected) {
  int diffX = unchecked(x - best.XCoordinateInGrid), diffZ = unchecked(z - best.ZCoordinateInGrid);
  while ((diffX | diffZ) != 0) {
   int xDirection = diffX > 0 ? 1 : diffX < 0 ? 3 : -1;
   int zDirection = diffZ > 0 ? 2 : diffZ < 0 ? 0 : -1;
   uint absX = unchecked((uint)(diffX < 0 ? -diffX : diffX));
   uint absZ = unchecked((uint)(diffZ < 0 ? -diffZ : diffZ));
   int primary = absX >= absZ ? xDirection : zDirection;
   int secondary = absX >= absZ ? zDirection : xDirection;
   GridNodeBase next = best.GetNeighbourAlongDirection(primary);
   if (next == null || (!allSuitable && !constraint.Suitable(next))) {
    if (secondary == -1) break;
    next = best.GetNeighbourAlongDirection(secondary);
    if (next == null || (!allSuitable && !constraint.Suitable(next))) break;
   }
   best = next;
   diffX = unchecked(x - best.XCoordinateInGrid); diffZ = unchecked(z - best.ZCoordinateInGrid);
  }
 }
 int nodeX = best.XCoordinateInGrid, nodeZ = best.ZCoordinateInGrid;
 float finalX = px > (float)nodeX + 1f ? (float)nodeX + 1f : px;
 finalX = px < (float)nodeX ? (float)nodeX : finalX;
 float finalZ = pz > (float)nodeZ + 1f ? (float)nodeZ + 1f : pz;
 finalZ = pz < (float)nodeZ ? (float)nodeZ : finalZ;
 Vector3 nodeGraphPosition = transform.InverseTransform((Vector3)best.position);
 Vector3 finalPosition = transform.Transform(new Vector3 { x = finalX, y = nodeGraphPosition.y, z = finalZ });
 if (!projected) {
  float nx = finalPosition.x - position.x, ny = finalPosition.y - position.y, nz = finalPosition.z - position.z;
  bestCost = nz * nz + (nx * nx + ny * ny);
 }
 return bestCost <= maximum ? new NNInfo(best,finalPosition,bestCost) : NNInfo.Empty;
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
 neighbourOffsets[0] = unchecked(-width);
 neighbourOffsets[1] = 1;
 neighbourOffsets[2] = width;
 neighbourOffsets[3] = -1;
 neighbourOffsets[4] = unchecked(1-width);
 neighbourOffsets[5] = unchecked(width+1);
 neighbourOffsets[6] = unchecked(width-1);
 neighbourOffsets[7] = unchecked(-width-1);
 float edge = nodeSize;
 if (neighbours == NumNeighbours.Six) edge = ConvertNodeSizeToHexagonSize(InspectorGridHexagonNodeSize.Width,edge);
 float value = edge * 1000f;
 double whole = Math.Truncate(value);
 double fraction = (double)value - whole;
 float cost;
 if (value >= 0f) cost = fraction == 0.5 ? (((long)whole & 1) == 0 ? (float)whole : (float)whole + 1f) : (float)Math.Floor(value + 0.5f);
 else cost = fraction == -0.5 ? (((long)whole & 1) == 0 ? (float)whole : (float)whole - 1f) : (float)Math.Ceiling(value - 0.5f);
 float diagonal = cost;
 if (!uniformEdgeCosts) {
  value = (edge * 1.4142135381698608f) * 1000f;
  whole = Math.Truncate(value);
  fraction = (double)value - whole;
  if (value >= 0f) diagonal = fraction == 0.5 ? (((long)whole & 1) == 0 ? (float)whole : (float)whole + 1f) : (float)Math.Floor(value + 0.5f);
  else diagonal = fraction == -0.5 ? (((long)whole & 1) == 0 ? (float)whole : (float)whole - 1f) : (float)Math.Ceiling(value - 0.5f);
 }
 neighbourCosts[0] = cost;
 neighbourCosts[1] = cost;
 neighbourCosts[2] = cost;
 neighbourCosts[3] = cost;
 neighbourCosts[4] = diagonal;
 neighbourCosts[5] = diagonal;
 neighbourCosts[6] = diagonal;
 neighbourCosts[7] = diagonal;
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
 if (!(nodeSize > 0f)) return null;
 CalculateDimensions(out width, out depth, out nodeSize);
 transform = CalculateTransform();
 if (width > 1024 || depth > 1024) { UnityEngine.Debug.LogError("One of the grid's sides is longer than 1024 nodes"); return null; }
 SetUpOffsetsAndCosts();
 GridNode.SetGridGraph(unchecked((int)graphIndex), this);
 if (collision == null) collision = new GraphCollision();
 collision.Initialize(transform, nodeSize);
 var tracker = Pathfinding.Pooling.ObjectPool<JobDependencyTracker>.Claim();
 JobHandle dependency;
 var allocatedNodes = AllocateNodesJob(unchecked(width * depth), out dependency);
 return new GridGraphUpdatePromise(this, transform, new GridGraphUpdatePromise.NodesHolder { nodes=allocatedNodes }, new int3(width,1,depth), new IntRect(0,0,unchecked(width-1),unchecked(depth-1)), tracker, dependency, Allocator.Persistent, RecalculationMode.RecalculateFromScratch, null, true, true);
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
 rect=IntRect.Intersection(rect,new IntRect(0,0,unchecked(width-1),unchecked(depth-1)));
 if (!rect.IsValid()) return default(Bounds);
 var center=new Vector3(unchecked(rect.xmin+rect.xmax)*0.5f,collision.fromHeight*0.5f,unchecked(rect.ymin+rect.ymax)*0.5f);
 var size=new Vector3(unchecked(rect.Width+1),collision.fromHeight,unchecked(rect.Height+1));
 return transform.Transform(new Bounds(center,size));
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
		{}
	}
}
