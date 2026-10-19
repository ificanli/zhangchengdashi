using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Pathfinding.Graphs.Navmesh;
using Pathfinding.Graphs.Navmesh.Jobs;
using Pathfinding.Jobs;
using Pathfinding.Serialization;
using Pathfinding.Sync;
using Pathfinding.Util;
using Unity.Jobs;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x2000102")]
	[JsonOptIn]
	[Preserve]
	public class RecastGraph : NavmeshBase, IUpdatableGraph
	{
		[Token(Token = "0x2000103")]
		public enum RelevantGraphSurfaceMode
		{
			[Token(Token = "0x4000590")]
			DoNotRequire = 0,
			[Token(Token = "0x4000591")]
			OnlyForCompletelyInsideTile = 1,
			[Token(Token = "0x4000592")]
			RequireForAll = 2
		}

		[Token(Token = "0x2000104")]
		public enum DimensionMode
		{
			[Token(Token = "0x4000594")]
			Dimension2D = 0,
			[Token(Token = "0x4000595")]
			Dimension3D = 1
		}

		[Token(Token = "0x2000105")]
		public enum BackgroundTraversability
		{
			[Token(Token = "0x4000597")]
			Walkable = 0,
			[Token(Token = "0x4000598")]
			Unwalkable = 1
		}

		[Serializable]
		[Token(Token = "0x2000106")]
		public struct PerLayerModification
		{
			[Token(Token = "0x4000599")]
			[FieldOffset(Offset = "0x0")]
			public int layer;

			[Token(Token = "0x400059A")]
			[FieldOffset(Offset = "0x4")]
			public RecastNavmeshModifier.Mode mode;

			[Token(Token = "0x400059B")]
			[FieldOffset(Offset = "0x8")]
			public int surfaceID;

			[Token(Token = "0x170001A7")]
			public static PerLayerModification Default
			{
				[Token(Token = "0x6000927")]
				[Address(RVA = "0x454D0C0", Offset = "0x45490C0", VA = "0x454D0C0")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x6000928")]
			[Address(RVA = "0x454D0CC", Offset = "0x45490CC", VA = "0x454D0CC")]
			public static PerLayerModification[] ToLayerLookup(List<PerLayerModification> perLayerModifications, PerLayerModification defaultValue)
			{
				return null;
			}
		}

		[Serializable]
		[Token(Token = "0x2000107")]
		public struct PerTerrainLayerModification
		{
			[Token(Token = "0x400059C")]
			[FieldOffset(Offset = "0x0")]
			public int layer;

			[Token(Token = "0x400059D")]
			[FieldOffset(Offset = "0x4")]
			public RecastNavmeshModifier.Mode mode;

			[Token(Token = "0x400059E")]
			[FieldOffset(Offset = "0x8")]
			public int surfaceID;

			[Token(Token = "0x400059F")]
			[FieldOffset(Offset = "0xC")]
			public float threshold;

			[Token(Token = "0x170001A8")]
			public static PerTerrainLayerModification Default
			{
				[Token(Token = "0x6000929")]
				[Address(RVA = "0x454D378", Offset = "0x4549378", VA = "0x454D378")]
				get
				{
					return default;
				}
			}
		}

		[Serializable]
		[Token(Token = "0x2000108")]
		public class CollectionSettings
		{
			[Token(Token = "0x2000109")]
			public enum FilterMode
			{
				[Token(Token = "0x40005AD")]
				Layers = 0,
				[Token(Token = "0x40005AE")]
				Tags = 1
			}

			[Token(Token = "0x40005A0")]
			[FieldOffset(Offset = "0x10")]
			public FilterMode collectionMode;

			[NonSerialized]
			[Token(Token = "0x40005A1")]
			[FieldOffset(Offset = "0x14")]
			public PhysicsScene? physicsScene;

			[NonSerialized]
			[Token(Token = "0x40005A2")]
			[FieldOffset(Offset = "0x1C")]
			public PhysicsScene2D? physicsScene2D;

			[Token(Token = "0x40005A3")]
			[FieldOffset(Offset = "0x24")]
			public LayerMask layerMask;

			[Token(Token = "0x40005A4")]
			[FieldOffset(Offset = "0x28")]
			public List<string> tagMask;

			[Token(Token = "0x40005A5")]
			[FieldOffset(Offset = "0x30")]
			public bool rasterizeColliders;

			[Token(Token = "0x40005A6")]
			[FieldOffset(Offset = "0x31")]
			public bool rasterizeMeshes;

			[Token(Token = "0x40005A7")]
			[FieldOffset(Offset = "0x32")]
			public bool rasterizeTerrain;

			[Token(Token = "0x40005A8")]
			[FieldOffset(Offset = "0x33")]
			public bool rasterizeTrees;

			[Token(Token = "0x40005A9")]
			[FieldOffset(Offset = "0x34")]
			public int terrainHeightmapDownsamplingFactor;

			[Token(Token = "0x40005AA")]
			[FieldOffset(Offset = "0x38")]
			public float colliderRasterizeDetail;

			[Token(Token = "0x40005AB")]
			[FieldOffset(Offset = "0x40")]
			public Action<RecastMeshGatherer> onCollectMeshes;

			[Token(Token = "0x600092A")]
			[Address(RVA = "0x454D018", Offset = "0x4549018", VA = "0x454D018")]
			public CollectionSettings()
			{
			}
		}

		[Token(Token = "0x200010A")]
		private class RecastGraphUpdatePromise : IGraphUpdatePromise
		{
			[Token(Token = "0x200010C")]
			[CompilerGenerated]
			private sealed class _003CPrepare_003Ed__5 : IEnumerator<JobHandle>, IEnumerator, IDisposable
			{
				[Token(Token = "0x40005B5")]
				[FieldOffset(Offset = "0x10")]
				private int _003C_003E1__state;

				[Token(Token = "0x40005B6")]
				[FieldOffset(Offset = "0x18")]
				private JobHandle _003C_003E2__current;

				[Token(Token = "0x40005B7")]
				[FieldOffset(Offset = "0x28")]
				public RecastGraphUpdatePromise _003C_003E4__this;

				[Token(Token = "0x40005B8")]
				[FieldOffset(Offset = "0x30")]
				private int _003Ci_003E5__2;

				[Token(Token = "0x170001A9")]
JobHandle System.Collections.Generic.IEnumerator<Unity.Jobs.JobHandle>.Current
				{
					[Token(Token = "0x6000935")]
					[Address(RVA = "0x454DE34", Offset = "0x4549E34", VA = "0x454DE34", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EGeneric_002EIEnumerator_003CUnity_002EJobs_002EJobHandle_003E_002Eget_Current();
					}
				}

				[Token(Token = "0x170001AA")]
object System.Collections.IEnumerator.Current
				{
					[Token(Token = "0x6000937")]
					[Address(RVA = "0x454DE78", Offset = "0x4549E78", VA = "0x454DE78", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EIEnumerator_002Eget_Current();
					}
				}

				[Token(Token = "0x6000932")]
				[Address(RVA = "0x454D480", Offset = "0x4549480", VA = "0x454D480")]
				[DebuggerHidden]
				public _003CPrepare_003Ed__5(int _003C_003E1__state)
				{
				}

				[Token(Token = "0x6000933")]
				[Address(RVA = "0x454DD18", Offset = "0x4549D18", VA = "0x454DD18", Slot = "5")]
				[DebuggerHidden]
void System.IDisposable.Dispose()
				{
				}

				[Token(Token = "0x6000934")]
				[Address(RVA = "0x454DD1C", Offset = "0x4549D1C", VA = "0x454DD1C", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
				{
					return default;
				}

				[Token(Token = "0x6000935")]
				[Address(RVA = "0x454DE34", Offset = "0x4549E34", VA = "0x454DE34", Slot = "4")]
				[DebuggerHidden]
				private JobHandle System_002ECollections_002EGeneric_002EIEnumerator_003CUnity_002EJobs_002EJobHandle_003E_002Eget_Current()
				{
					return default;
				}

				[Token(Token = "0x6000936")]
				[Address(RVA = "0x454DE40", Offset = "0x4549E40", VA = "0x454DE40", Slot = "8")]
				[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
				{
				}

				[Token(Token = "0x6000937")]
				[Address(RVA = "0x454DE78", Offset = "0x4549E78", VA = "0x454DE78", Slot = "7")]
				[DebuggerHidden]
				private object System_002ECollections_002EIEnumerator_002Eget_Current()
				{
					return null;
				}
			}

			[Token(Token = "0x40005AF")]
			[FieldOffset(Offset = "0x10")]
			public List<(Promise<TileBuilder.TileBuilderOutput>, Promise<TileCutter.TileCutterOutput>, Promise<JobBuildNodes.BuildNodeTilesOutput>)> promises;

			[Token(Token = "0x40005B0")]
			[FieldOffset(Offset = "0x18")]
			public List<GraphUpdateObject> graphUpdates;

			[Token(Token = "0x40005B1")]
			[FieldOffset(Offset = "0x20")]
			public RecastGraph graph;

			[Token(Token = "0x40005B2")]
			[FieldOffset(Offset = "0x28")]
			private int graphHash;

			[Token(Token = "0x600092B")]
			[Address(RVA = "0x454B22C", Offset = "0x454722C", VA = "0x454B22C")]
			public RecastGraphUpdatePromise(RecastGraph graph, List<GraphUpdateObject> graphUpdates)
			{
			}

			[Token(Token = "0x600092C")]
			[Address(RVA = "0x454D420", Offset = "0x4549420", VA = "0x454D420", Slot = "5")]
			[IteratorStateMachine(typeof(_003CPrepare_003Ed__5))]
			public IEnumerator<JobHandle> Prepare()
			{
				return null;
			}

			[Token(Token = "0x600092D")]
			[Address(RVA = "0x454D388", Offset = "0x4549388", VA = "0x454D388")]
			private static int HashSettings(RecastGraph graph)
			{
				return default;
			}

			[Token(Token = "0x600092E")]
			[Address(RVA = "0x454D4A8", Offset = "0x45494A8", VA = "0x454D4A8", Slot = "6")]
			public void Apply(IGraphUpdateContext ctx)
			{
			}
		}

		[Token(Token = "0x200010D")]
		private class RecastGraphScanPromise : IGraphUpdatePromise
		{
			[Token(Token = "0x200010E")]
			[CompilerGenerated]
			private sealed class _003CPrepare_003Ed__8 : IEnumerator<JobHandle>, IEnumerator, IDisposable
			{
				[Token(Token = "0x40005BF")]
				[FieldOffset(Offset = "0x10")]
				private int _003C_003E1__state;

				[Token(Token = "0x40005C0")]
				[FieldOffset(Offset = "0x18")]
				private JobHandle _003C_003E2__current;

				[Token(Token = "0x40005C1")]
				[FieldOffset(Offset = "0x28")]
				public RecastGraphScanPromise _003C_003E4__this;

				[Token(Token = "0x40005C2")]
				[FieldOffset(Offset = "0x30")]
				private DisposeArena _003Carena_003E5__2;

				[Token(Token = "0x40005C3")]
				[FieldOffset(Offset = "0x38")]
				private Promise<TileBuilder.TileBuilderOutput> _003CtileMeshesPromise_003E5__3;

				[Token(Token = "0x40005C4")]
				[FieldOffset(Offset = "0x50")]
				private Promise<TileCutter.TileCutterOutput> _003CcutPromise_003E5__4;

				[Token(Token = "0x40005C5")]
				[FieldOffset(Offset = "0x88")]
				private Promise<JobBuildNodes.BuildNodeTilesOutput> _003CtilesPromise_003E5__5;

				[Token(Token = "0x170001AC")]
JobHandle System.Collections.Generic.IEnumerator<Unity.Jobs.JobHandle>.Current
				{
					[Token(Token = "0x600093F")]
					[Address(RVA = "0x454E700", Offset = "0x454A700", VA = "0x454E700", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EGeneric_002EIEnumerator_003CUnity_002EJobs_002EJobHandle_003E_002Eget_Current();
					}
				}

				[Token(Token = "0x170001AD")]
object System.Collections.IEnumerator.Current
				{
					[Token(Token = "0x6000941")]
					[Address(RVA = "0x454E744", Offset = "0x454A744", VA = "0x454E744", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EIEnumerator_002Eget_Current();
					}
				}

				[Token(Token = "0x600093C")]
				[Address(RVA = "0x454DFE0", Offset = "0x4549FE0", VA = "0x454DFE0")]
				[DebuggerHidden]
				public _003CPrepare_003Ed__8(int _003C_003E1__state)
				{
				}

				[Token(Token = "0x600093D")]
				[Address(RVA = "0x454E1D0", Offset = "0x454A1D0", VA = "0x454E1D0", Slot = "5")]
				[DebuggerHidden]
void System.IDisposable.Dispose()
				{
				}

				[Token(Token = "0x600093E")]
				[Address(RVA = "0x454E1D4", Offset = "0x454A1D4", VA = "0x454E1D4", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
				{
					return default;
				}

				[Token(Token = "0x600093F")]
				[Address(RVA = "0x454E700", Offset = "0x454A700", VA = "0x454E700", Slot = "4")]
				[DebuggerHidden]
				private JobHandle System_002ECollections_002EGeneric_002EIEnumerator_003CUnity_002EJobs_002EJobHandle_003E_002Eget_Current()
				{
					return default;
				}

				[Token(Token = "0x6000940")]
				[Address(RVA = "0x454E70C", Offset = "0x454A70C", VA = "0x454E70C", Slot = "8")]
				[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
				{
				}

				[Token(Token = "0x6000941")]
				[Address(RVA = "0x454E744", Offset = "0x454A744", VA = "0x454E744", Slot = "7")]
				[DebuggerHidden]
				private object System_002ECollections_002EIEnumerator_002Eget_Current()
				{
					return null;
				}
			}

			[Token(Token = "0x40005B9")]
			[FieldOffset(Offset = "0x10")]
			public RecastGraph graph;

			[Token(Token = "0x40005BA")]
			[FieldOffset(Offset = "0x18")]
			private TileLayout tileLayout;

			[Token(Token = "0x40005BB")]
			[FieldOffset(Offset = "0x40")]
			private bool emptyGraph;

			[Token(Token = "0x40005BC")]
			[FieldOffset(Offset = "0x48")]
			private NavmeshTile[] tiles;

			[Token(Token = "0x40005BD")]
			[FieldOffset(Offset = "0x50")]
			private IProgress progressSource;

			[Token(Token = "0x40005BE")]
			[FieldOffset(Offset = "0x58")]
			private NavmeshUpdates.NavmeshUpdateSettings cutSettings;

			[Token(Token = "0x170001AB")]
			public float Progress
			{
				[Token(Token = "0x6000938")]
				[Address(RVA = "0x454DED4", Offset = "0x4549ED4", VA = "0x454DED4", Slot = "4")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x6000939")]
			[Address(RVA = "0x454DF80", Offset = "0x4549F80", VA = "0x454DF80", Slot = "5")]
			[IteratorStateMachine(typeof(_003CPrepare_003Ed__8))]
			public IEnumerator<JobHandle> Prepare()
			{
				return null;
			}

			[Token(Token = "0x600093A")]
			[Address(RVA = "0x454E008", Offset = "0x454A008", VA = "0x454E008", Slot = "6")]
			public void Apply(IGraphUpdateContext ctx)
			{
			}

			[Token(Token = "0x600093B")]
			[Address(RVA = "0x454BBFC", Offset = "0x4547BFC", VA = "0x454BBFC")]
			public RecastGraphScanPromise()
			{
			}
		}

		[Token(Token = "0x200010F")]
		private class RecastMovePromise : IGraphUpdatePromise
		{
			[Token(Token = "0x2000110")]
			[CompilerGenerated]
			private sealed class _003CPrepare_003Ed__5 : IEnumerator<JobHandle>, IEnumerator, IDisposable
			{
				[Token(Token = "0x40005CA")]
				[FieldOffset(Offset = "0x10")]
				private int _003C_003E1__state;

				[Token(Token = "0x40005CB")]
				[FieldOffset(Offset = "0x18")]
				private JobHandle _003C_003E2__current;

				[Token(Token = "0x40005CC")]
				[FieldOffset(Offset = "0x28")]
				public RecastMovePromise _003C_003E4__this;

				[Token(Token = "0x40005CD")]
				[FieldOffset(Offset = "0x30")]
				private IntRect _003CcreatedTiles_003E5__2;

				[Token(Token = "0x40005CE")]
				[FieldOffset(Offset = "0x40")]
				private DisposeArena _003CdisposeArena_003E5__3;

				[Token(Token = "0x40005CF")]
				[FieldOffset(Offset = "0x48")]
				private Promise<TileBuilder.TileBuilderOutput> _003CpendingPromise_003E5__4;

				[Token(Token = "0x170001AE")]
JobHandle System.Collections.Generic.IEnumerator<Unity.Jobs.JobHandle>.Current
				{
					[Token(Token = "0x6000948")]
					[Address(RVA = "0x454EB38", Offset = "0x454AB38", VA = "0x454EB38", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EGeneric_002EIEnumerator_003CUnity_002EJobs_002EJobHandle_003E_002Eget_Current();
					}
				}

				[Token(Token = "0x170001AF")]
object System.Collections.IEnumerator.Current
				{
					[Token(Token = "0x600094A")]
					[Address(RVA = "0x454EB7C", Offset = "0x454AB7C", VA = "0x454EB7C", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EIEnumerator_002Eget_Current();
					}
				}

				[Token(Token = "0x6000945")]
				[Address(RVA = "0x454E800", Offset = "0x454A800", VA = "0x454E800")]
				[DebuggerHidden]
				public _003CPrepare_003Ed__5(int _003C_003E1__state)
				{
				}

				[Token(Token = "0x6000946")]
				[Address(RVA = "0x454E898", Offset = "0x454A898", VA = "0x454E898", Slot = "5")]
				[DebuggerHidden]
void System.IDisposable.Dispose()
				{
				}

				[Token(Token = "0x6000947")]
				[Address(RVA = "0x454E89C", Offset = "0x454A89C", VA = "0x454E89C", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
				{
					return default;
				}

				[Token(Token = "0x6000948")]
				[Address(RVA = "0x454EB38", Offset = "0x454AB38", VA = "0x454EB38", Slot = "4")]
				[DebuggerHidden]
				private JobHandle System_002ECollections_002EGeneric_002EIEnumerator_003CUnity_002EJobs_002EJobHandle_003E_002Eget_Current()
				{
					return default;
				}

				[Token(Token = "0x6000949")]
				[Address(RVA = "0x454EB44", Offset = "0x454AB44", VA = "0x454EB44", Slot = "8")]
				[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
				{
				}

				[Token(Token = "0x600094A")]
				[Address(RVA = "0x454EB7C", Offset = "0x454AB7C", VA = "0x454EB7C", Slot = "7")]
				[DebuggerHidden]
				private object System_002ECollections_002EIEnumerator_002Eget_Current()
				{
					return null;
				}
			}

			[Token(Token = "0x40005C6")]
			[FieldOffset(Offset = "0x10")]
			private RecastGraph graph;

			[Token(Token = "0x40005C7")]
			[FieldOffset(Offset = "0x18")]
			private TileMeshes tileMeshes;

			[Token(Token = "0x40005C8")]
			[FieldOffset(Offset = "0x38")]
			private Vector2Int delta;

			[Token(Token = "0x40005C9")]
			[FieldOffset(Offset = "0x40")]
			private IntRect newTileRect;

			[Token(Token = "0x6000942")]
			[Address(RVA = "0x454BB14", Offset = "0x4547B14", VA = "0x454BB14")]
			public RecastMovePromise(RecastGraph graph, Vector2Int delta)
			{
			}

			[Token(Token = "0x6000943")]
			[Address(RVA = "0x454E7A0", Offset = "0x454A7A0", VA = "0x454E7A0", Slot = "5")]
			[IteratorStateMachine(typeof(_003CPrepare_003Ed__5))]
			public IEnumerator<JobHandle> Prepare()
			{
				return null;
			}

			[Token(Token = "0x6000944")]
			[Address(RVA = "0x454E828", Offset = "0x454A828", VA = "0x454E828", Slot = "6")]
			public void Apply(IGraphUpdateContext ctx)
			{
			}
		}

		[Token(Token = "0x4000577")]
		[FieldOffset(Offset = "0xB0")]
		[JsonMember]
		public float characterRadius;

		[Token(Token = "0x4000578")]
		[FieldOffset(Offset = "0xB4")]
		[JsonMember]
		public float contourMaxError;

		[Token(Token = "0x4000579")]
		[FieldOffset(Offset = "0xB8")]
		[JsonMember]
		public float cellSize;

		[Token(Token = "0x400057A")]
		[FieldOffset(Offset = "0xBC")]
		[JsonMember]
		public float walkableHeight;

		[Token(Token = "0x400057B")]
		[FieldOffset(Offset = "0xC0")]
		[JsonMember]
		public float walkableClimb;

		[Token(Token = "0x400057C")]
		[FieldOffset(Offset = "0xC4")]
		[JsonMember]
		public float maxSlope;

		[Token(Token = "0x400057D")]
		[FieldOffset(Offset = "0xC8")]
		[JsonMember]
		public float maxEdgeLength;

		[Token(Token = "0x400057E")]
		[FieldOffset(Offset = "0xCC")]
		[JsonMember]
		public float minRegionSize;

		[Token(Token = "0x400057F")]
		[FieldOffset(Offset = "0xD0")]
		[JsonMember]
		public int editorTileSize;

		[Token(Token = "0x4000580")]
		[FieldOffset(Offset = "0xD4")]
		[JsonMember]
		public int tileSizeX;

		[Token(Token = "0x4000581")]
		[FieldOffset(Offset = "0xD8")]
		[JsonMember]
		public int tileSizeZ;

		[Token(Token = "0x4000582")]
		[FieldOffset(Offset = "0xDC")]
		[JsonMember]
		public bool useTiles;

		[Token(Token = "0x4000583")]
		[FieldOffset(Offset = "0xDD")]
		public bool scanEmptyGraph;

		[Token(Token = "0x4000584")]
		[FieldOffset(Offset = "0xE0")]
		[JsonMember]
		public List<PerLayerModification> perLayerModifications;

		[Token(Token = "0x4000585")]
		[FieldOffset(Offset = "0xE8")]
		[JsonMember]
		public List<PerTerrainLayerModification> perTerrainLayerModifications;

		[Token(Token = "0x4000586")]
		[FieldOffset(Offset = "0xF0")]
		[JsonMember]
		public DimensionMode dimensionMode;

		[Token(Token = "0x4000587")]
		[FieldOffset(Offset = "0xF4")]
		[JsonMember]
		public BackgroundTraversability backgroundTraversability;

		[Token(Token = "0x4000588")]
		[FieldOffset(Offset = "0xF8")]
		[JsonMember]
		public RelevantGraphSurfaceMode relevantGraphSurfaceMode;

		[Token(Token = "0x4000589")]
		[FieldOffset(Offset = "0x100")]
		[JsonMember]
		public CollectionSettings collectionSettings;

		[Token(Token = "0x400058A")]
		[FieldOffset(Offset = "0x108")]
		[JsonMember]
		public Vector3 rotation;

		[Token(Token = "0x400058B")]
		[FieldOffset(Offset = "0x114")]
		[JsonMember]
		public Vector3 forcedBoundsCenter;

		[Token(Token = "0x400058C")]
		[FieldOffset(Offset = "0x120")]
		private DisposeArena pendingGraphUpdateArena;

		[Token(Token = "0x400058D")]
		[FieldOffset(Offset = "0x128")]
		private bool hasExtendedInX;

		[Token(Token = "0x400058E")]
		[FieldOffset(Offset = "0x129")]
		private bool hasExtendedInZ;

		[Token(Token = "0x17000196")]
		[Obsolete("Use collectionSettings.rasterizeColliders instead")]
		public bool rasterizeColliders
		{
			[Token(Token = "0x6000900")]
			[Address(RVA = "0x454A7E4", Offset = "0x45467E4", VA = "0x454A7E4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000901")]
			[Address(RVA = "0x454A800", Offset = "0x4546800", VA = "0x454A800")]
			set
			{
			}
		}

		[Token(Token = "0x17000197")]
		[Obsolete("Use collectionSettings.rasterizeMeshes instead")]
		public bool rasterizeMeshes
		{
			[Token(Token = "0x6000902")]
			[Address(RVA = "0x454A820", Offset = "0x4546820", VA = "0x454A820")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000903")]
			[Address(RVA = "0x454A83C", Offset = "0x454683C", VA = "0x454A83C")]
			set
			{
			}
		}

		[Token(Token = "0x17000198")]
		[Obsolete("Use collectionSettings.rasterizeTerrain instead")]
		public bool rasterizeTerrain
		{
			[Token(Token = "0x6000904")]
			[Address(RVA = "0x454A85C", Offset = "0x454685C", VA = "0x454A85C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000905")]
			[Address(RVA = "0x454A878", Offset = "0x4546878", VA = "0x454A878")]
			set
			{
			}
		}

		[Token(Token = "0x17000199")]
		[Obsolete("Use collectionSettings.rasterizeTrees instead")]
		public bool rasterizeTrees
		{
			[Token(Token = "0x6000906")]
			[Address(RVA = "0x454A898", Offset = "0x4546898", VA = "0x454A898")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000907")]
			[Address(RVA = "0x454A8B4", Offset = "0x45468B4", VA = "0x454A8B4")]
			set
			{
			}
		}

		[Token(Token = "0x1700019A")]
		[Obsolete("Use collectionSettings.colliderRasterizeDetail instead")]
		public float colliderRasterizeDetail
		{
			[Token(Token = "0x6000908")]
			[Address(RVA = "0x454A8D4", Offset = "0x45468D4", VA = "0x454A8D4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000909")]
			[Address(RVA = "0x454A8F0", Offset = "0x45468F0", VA = "0x454A8F0")]
			set
			{
			}
		}

		[Token(Token = "0x1700019B")]
		[Obsolete("Use collectionSettings.layerMask instead")]
		public LayerMask mask
		{
			[Token(Token = "0x600090A")]
			[Address(RVA = "0x454A90C", Offset = "0x454690C", VA = "0x454A90C")]
			get
			{
				return default;
			}
			[Token(Token = "0x600090B")]
			[Address(RVA = "0x454A928", Offset = "0x4546928", VA = "0x454A928")]
			set
			{
			}
		}

		[Token(Token = "0x1700019C")]
		[Obsolete("Use collectionSettings.tagMask instead")]
		public List<string> tagMask
		{
			[Token(Token = "0x600090C")]
			[Address(RVA = "0x454A944", Offset = "0x4546944", VA = "0x454A944")]
			get
			{
				return null;
			}
			[Token(Token = "0x600090D")]
			[Address(RVA = "0x454A960", Offset = "0x4546960", VA = "0x454A960")]
			set
			{
			}
		}

		[Token(Token = "0x1700019D")]
		[Obsolete("Use collectionSettings.terrainHeightmapDownsamplingFactor instead")]
		public int terrainSampleSize
		{
			[Token(Token = "0x600090E")]
			[Address(RVA = "0x454A97C", Offset = "0x454697C", VA = "0x454A97C")]
			get
			{
				return default;
			}
			[Token(Token = "0x600090F")]
			[Address(RVA = "0x454A998", Offset = "0x4546998", VA = "0x454A998")]
			set
			{
			}
		}

		[Token(Token = "0x1700019E")]
		public override float NavmeshCuttingCharacterRadius
		{
			[Token(Token = "0x6000910")]
			[Address(RVA = "0x454A9B4", Offset = "0x45469B4", VA = "0x454A9B4", Slot = "52")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700019F")]
		public override bool RecalculateNormals
		{
			[Token(Token = "0x6000911")]
			[Address(RVA = "0x454A9BC", Offset = "0x45469BC", VA = "0x454A9BC", Slot = "56")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170001A0")]
		public override float TileWorldSizeX
		{
			[Token(Token = "0x6000912")]
			[Address(RVA = "0x454A9C4", Offset = "0x45469C4", VA = "0x454A9C4", Slot = "53")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170001A1")]
		public override float TileWorldSizeZ
		{
			[Token(Token = "0x6000913")]
			[Address(RVA = "0x454A9D8", Offset = "0x45469D8", VA = "0x454A9D8", Slot = "54")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170001A2")]
		public override float MaxTileConnectionEdgeDistance
		{
			[Token(Token = "0x6000914")]
			[Address(RVA = "0x454A9EC", Offset = "0x45469EC", VA = "0x454A9EC", Slot = "55")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170001A3")]
		public override Bounds bounds
		{
			[Token(Token = "0x6000915")]
			[Address(RVA = "0x454A9F4", Offset = "0x45469F4", VA = "0x454A9F4", Slot = "16")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170001A4")]
		internal int CharacterRadiusInVoxels
		{
			[Token(Token = "0x600091F")]
			[Address(RVA = "0x454BEB4", Offset = "0x4547EB4", VA = "0x454BEB4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170001A5")]
		internal int TileBorderSizeInVoxels
		{
			[Token(Token = "0x6000920")]
			[Address(RVA = "0x454BF34", Offset = "0x4547F34", VA = "0x454BF34")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170001A6")]
		internal float TileBorderSizeInWorldUnits
		{
			[Token(Token = "0x6000921")]
			[Address(RVA = "0x454BF48", Offset = "0x4547F48", VA = "0x454BF48")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000916")]
		[Address(RVA = "0x454AB60", Offset = "0x4546B60", VA = "0x454AB60", Slot = "21")]
		public override bool IsInsideBounds(Vector3 point)
		{
			return default;
		}

		[Token(Token = "0x6000917")]
		[Address(RVA = "0x454AC70", Offset = "0x4546C70", VA = "0x454AC70")]
		[Obsolete("Use SnapBoundsToScene instead")]
		public void SnapForceBoundsToScene()
		{
		}

		[Token(Token = "0x6000918")]
		[Address(RVA = "0x454AC74", Offset = "0x4546C74", VA = "0x454AC74")]
		public void SnapBoundsToScene()
		{
		}

		[Token(Token = "0x6000919")]
		[Address(RVA = "0x454B1C4", Offset = "0x45471C4", VA = "0x454B1C4", Slot = "58")]
IGraphUpdatePromise IUpdatableGraph.ScheduleGraphUpdates(List<GraphUpdateObject> graphUpdates)
		{
			return null;
		}

		[Token(Token = "0x600091A")]
		[Address(RVA = "0x454BAA4", Offset = "0x4547AA4", VA = "0x454BAA4")]
		public IGraphUpdatePromise TranslateInDirection(int dx, int dz)
		{
			return null;
		}

		[Token(Token = "0x600091B")]
		[Address(RVA = "0x454BB98", Offset = "0x4547B98", VA = "0x454BB98", Slot = "31")]
		protected override IGraphUpdatePromise ScanInternal(bool async)
		{
			return null;
		}

		[Token(Token = "0x600091C")]
		[Address(RVA = "0x454BC04", Offset = "0x4547C04", VA = "0x454BC04", Slot = "57")]
		public override GraphTransform CalculateTransform()
		{
			return null;
		}

		[Token(Token = "0x600091D")]
		[Address(RVA = "0x454BC8C", Offset = "0x4547C8C", VA = "0x454BC8C")]
		public static GraphTransform CalculateTransform(Bounds bounds, Quaternion rotation)
		{
			return null;
		}

		[Token(Token = "0x600091E")]
		[Address(RVA = "0x454BE98", Offset = "0x4547E98", VA = "0x454BE98")]
		protected void SetLayout(TileLayout info)
		{
		}

		[Token(Token = "0x6000922")]
		[Address(RVA = "0x454BF6C", Offset = "0x4547F6C", VA = "0x454BF6C", Slot = "59")]
		public virtual void Resize(IntRect newTileBounds)
		{
		}

		[Token(Token = "0x6000923")]
		[Address(RVA = "0x454C6C4", Offset = "0x45486C4", VA = "0x454C6C4")]
		public void EnsureInitialized()
		{
		}

		[Token(Token = "0x6000924")]
		[Address(RVA = "0x454C7D0", Offset = "0x45487D0", VA = "0x454C7D0")]
		public void ReplaceTiles(TileMeshes tileMeshes, float yOffset = 0f)
		{
		}

		[Token(Token = "0x6000925")]
		[Address(RVA = "0x454CCF4", Offset = "0x4548CF4", VA = "0x454CCF4", Slot = "34")]
		protected override void PostDeserialization(GraphSerializationContext ctx)
		{
		}

		[Token(Token = "0x6000926")]
		[Address(RVA = "0x454CEA4", Offset = "0x4548EA4", VA = "0x454CEA4")]
		public RecastGraph()
		{
		}
	}
}
