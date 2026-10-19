using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Pathfinding.Graphs.Navmesh;
using Pathfinding.Graphs.Navmesh.Jobs;
using Pathfinding.Serialization;
using Pathfinding.Sync;
using Pathfinding.Util;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x20000E6")]
	[Preserve]
	[JsonOptIn]
	public class NavMeshGraph : NavmeshBase, IUpdatableGraph
	{
		[Token(Token = "0x20000E7")]
		private class NavMeshGraphUpdatePromise : IGraphUpdatePromise
		{
			[Token(Token = "0x40004F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public NavMeshGraph graph;

			[Token(Token = "0x40004F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public List<GraphUpdateObject> graphUpdates;

			[Token(Token = "0x60007E6")]
			[Address(RVA = "0x4539BC8", Offset = "0x4535BC8", VA = "0x4539BC8", Slot = "6")]
			public void Apply(IGraphUpdateContext ctx)
			{
			}

			[Token(Token = "0x60007E7")]
			[Address(RVA = "0x4539628", Offset = "0x4535628", VA = "0x4539628")]
			public NavMeshGraphUpdatePromise()
			{
			}
		}

		[Token(Token = "0x20000E8")]
		private class NavMeshGraphScanPromise : IGraphUpdatePromise
		{
			[Token(Token = "0x20000E9")]
			[CompilerGenerated]
			private sealed class _003CPrepare_003Ed__7 : IEnumerator<JobHandle>, IEnumerator, IDisposable
			{
				[Token(Token = "0x40004FF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private int _003C_003E1__state;

				[Token(Token = "0x4000500")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private JobHandle _003C_003E2__current;

				[Token(Token = "0x4000501")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				public NavMeshGraphScanPromise _003C_003E4__this;

				[Token(Token = "0x4000502")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				private NativeArray<Vector3> _003Cvertices_003E5__2;

				[Token(Token = "0x4000503")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
				private NativeArray<int> _003Cindices_003E5__3;

				[Token(Token = "0x4000504")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
				private Promise<TileBuilder.TileBuilderOutput> _003Cpromise_003E5__4;

				[Token(Token = "0x4000505")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
				private GCHandle _003CtilesGCHandle_003E5__5;

				[Token(Token = "0x4000506")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
				private Promise<TileCutter.TileCutterOutput> _003CcutPromise_003E5__6;

				[Token(Token = "0x4000507")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
				private NativeArray<JobCalculateTriangleConnections.TileNodeConnectionsUnsafe> _003CtileNodeConnections_003E5__7;

				[Token(Token = "0x1700017A")]
JobHandle System.Collections.Generic.IEnumerator<Unity.Jobs.JobHandle>.Current
				{
					[Token(Token = "0x60007EE")]
					[Address(RVA = "0x453AA6C", Offset = "0x4536A6C", VA = "0x453AA6C", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EGeneric_002EIEnumerator_003CUnity_002EJobs_002EJobHandle_003E_002Eget_Current();
					}
				}

				[Token(Token = "0x1700017B")]
object System.Collections.IEnumerator.Current
				{
					[Token(Token = "0x60007F0")]
					[Address(RVA = "0x453AAB0", Offset = "0x4536AB0", VA = "0x453AAB0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return System_002ECollections_002EIEnumerator_002Eget_Current();
					}
				}

				[Token(Token = "0x60007EB")]
				[Address(RVA = "0x4539D7C", Offset = "0x4535D7C", VA = "0x4539D7C")]
				[DebuggerHidden]
				public _003CPrepare_003Ed__7(int _003C_003E1__state)
				{
				}

				[Token(Token = "0x60007EC")]
				[Address(RVA = "0x453A0C0", Offset = "0x45360C0", VA = "0x453A0C0", Slot = "5")]
				[DebuggerHidden]
void System.IDisposable.Dispose()
				{
				}

				[Token(Token = "0x60007ED")]
				[Address(RVA = "0x453A0C4", Offset = "0x45360C4", VA = "0x453A0C4", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
				{
					return default;
				}

				[Token(Token = "0x60007EE")]
				[Address(RVA = "0x453AA6C", Offset = "0x4536A6C", VA = "0x453AA6C", Slot = "4")]
				[DebuggerHidden]
				private JobHandle System_002ECollections_002EGeneric_002EIEnumerator_003CUnity_002EJobs_002EJobHandle_003E_002Eget_Current()
				{
					return default;
				}

				[Token(Token = "0x60007EF")]
				[Address(RVA = "0x453AA78", Offset = "0x4536A78", VA = "0x453AA78", Slot = "8")]
				[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
				{
				}

				[Token(Token = "0x60007F0")]
				[Address(RVA = "0x453AAB0", Offset = "0x4536AB0", VA = "0x453AAB0", Slot = "7")]
				[DebuggerHidden]
				private object System_002ECollections_002EIEnumerator_002Eget_Current()
				{
					return null;
				}
			}

			[Token(Token = "0x40004F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public NavMeshGraph graph;

			[Token(Token = "0x40004F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private bool emptyGraph;

			[Token(Token = "0x40004FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private GraphTransform transform;

			[Token(Token = "0x40004FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private NavmeshTile[] tiles;

			[Token(Token = "0x40004FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 forcedBoundsSize;

			[Token(Token = "0x40004FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private IntRect tileRect;

			[Token(Token = "0x40004FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private NavmeshUpdates.NavmeshUpdateSettings cutSettings;

			[Token(Token = "0x60007E8")]
			[Address(RVA = "0x4539D1C", Offset = "0x4535D1C", VA = "0x4539D1C", Slot = "5")]
			[IteratorStateMachine(typeof(_003CPrepare_003Ed__7))]
			public IEnumerator<JobHandle> Prepare()
			{
				return null;
			}

			[Token(Token = "0x60007E9")]
			[Address(RVA = "0x4539DA4", Offset = "0x4535DA4", VA = "0x4539DA4", Slot = "6")]
			public void Apply(IGraphUpdateContext ctx)
			{
			}

			[Token(Token = "0x60007EA")]
			[Address(RVA = "0x4539ABC", Offset = "0x4535ABC", VA = "0x4539ABC")]
			public NavMeshGraphScanPromise()
			{
			}
		}

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[JsonMember]
		public Mesh sourceMesh;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[JsonMember]
		public Vector3 offset;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[JsonMember]
		public Vector3 rotation;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[JsonMember]
		public float scale;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		[JsonMember]
		public bool recalculateNormals;

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[JsonMember]
		private Vector3 cachedSourceMeshBoundsMin;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[JsonMember]
		public float navmeshCuttingCharacterRadius;

		[Token(Token = "0x17000174")]
		public override float NavmeshCuttingCharacterRadius
		{
			[Token(Token = "0x60007D9")]
			[Address(RVA = "0x4538F5C", Offset = "0x4534F5C", VA = "0x4538F5C", Slot = "52")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000175")]
		public override bool RecalculateNormals
		{
			[Token(Token = "0x60007DA")]
			[Address(RVA = "0x4538F64", Offset = "0x4534F64", VA = "0x4538F64", Slot = "56")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000176")]
		public override float TileWorldSizeX
		{
			[Token(Token = "0x60007DB")]
			[Address(RVA = "0x4538F6C", Offset = "0x4534F6C", VA = "0x4538F6C", Slot = "53")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000177")]
		public override float TileWorldSizeZ
		{
			[Token(Token = "0x60007DC")]
			[Address(RVA = "0x4538F74", Offset = "0x4534F74", VA = "0x4538F74", Slot = "54")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000178")]
		public override float MaxTileConnectionEdgeDistance
		{
			[Token(Token = "0x60007DD")]
			[Address(RVA = "0x4538F7C", Offset = "0x4534F7C", VA = "0x4538F7C", Slot = "55")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000179")]
		public override Bounds bounds
		{
			[Token(Token = "0x60007DF")]
			[Address(RVA = "0x45390E0", Offset = "0x45350E0", VA = "0x45390E0", Slot = "16")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0x4538F84", Offset = "0x4534F84", VA = "0x4538F84", Slot = "21")]
		public override bool IsInsideBounds(Vector3 point)
		{
			return default;
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x45392A8", Offset = "0x45352A8", VA = "0x45392A8", Slot = "57")]
		public override GraphTransform CalculateTransform()
		{
			return null;
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x45395B8", Offset = "0x45355B8", VA = "0x45395B8", Slot = "58")]
IGraphUpdatePromise IUpdatableGraph.ScheduleGraphUpdates(List<GraphUpdateObject> graphUpdates)
		{
			return null;
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x4539630", Offset = "0x4535630", VA = "0x4539630")]
		public static void UpdateArea(GraphUpdateObject o, INavmeshHolder graph)
		{
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x4539A58", Offset = "0x4535A58", VA = "0x4539A58", Slot = "31")]
		protected override IGraphUpdatePromise ScanInternal(bool async)
		{
			return null;
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x4539AC4", Offset = "0x4535AC4", VA = "0x4539AC4", Slot = "34")]
		protected override void PostDeserialization(GraphSerializationContext ctx)
		{
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x4539B5C", Offset = "0x4535B5C", VA = "0x4539B5C")]
		public NavMeshGraph()
		{
		}
	}
}
