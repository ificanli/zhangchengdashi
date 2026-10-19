using System;
using Il2CppDummyDll;
using Pathfinding.Graphs.Navmesh;
using Pathfinding.Jobs;
using Pathfinding.Serialization;
using Pathfinding.Sync;
using Unity.Jobs;
using UnityEngine;

namespace Pathfinding
{
	[Token(Token = "0x200007F")]
	[AddComponentMenu("Pathfinding/Navmesh Prefab")]
	[HelpURL("https://arongranberg.com/astar/documentation/stable/navmeshprefab.html")]
	public class NavmeshPrefab : VersionedMonoBehaviour
	{
		[Token(Token = "0x2000080")]
		public class SerializedOutput : IProgress, IDisposable
		{
			[Token(Token = "0x40002CF")]
			[FieldOffset(Offset = "0x10")]
			public Promise<TileBuilder.TileBuilderOutput> promise;

			[Token(Token = "0x40002D0")]
			[FieldOffset(Offset = "0x28")]
			public byte[] data;

			[Token(Token = "0x40002D1")]
			[FieldOffset(Offset = "0x30")]
			public DisposeArena arena;

			[Token(Token = "0x170000EB")]
			public float Progress
			{
				[Token(Token = "0x600047C")]
				[Address(RVA = "0x4505484", Offset = "0x4501484", VA = "0x4505484", Slot = "4")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x600047D")]
			[Address(RVA = "0x450533C", Offset = "0x450133C", VA = "0x450533C", Slot = "5")]
			public void Dispose()
			{
			}

			[Token(Token = "0x600047E")]
			[Address(RVA = "0x4505398", Offset = "0x4501398", VA = "0x4505398")]
			public SerializedOutput()
			{
			}
		}

		[Token(Token = "0x2000081")]
		private struct SerializeJob : IJob
		{
			[Token(Token = "0x40002D2")]
			[FieldOffset(Offset = "0x0")]
			public Promise<TileBuilder.TileBuilderOutput> tileMeshesPromise;

			[Token(Token = "0x40002D3")]
			[FieldOffset(Offset = "0x18")]
			public SerializedOutput output;

			[Token(Token = "0x600047F")]
			[Address(RVA = "0x45054CC", Offset = "0x45014CC", VA = "0x45054CC", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Token(Token = "0x40002CA")]
		[FieldOffset(Offset = "0x28")]
		public TextAsset serializedNavmesh;

		[Token(Token = "0x40002CB")]
		[FieldOffset(Offset = "0x30")]
		public bool applyOnStart;

		[Token(Token = "0x40002CC")]
		[FieldOffset(Offset = "0x31")]
		public bool removeTilesWhenDisabled;

		[Token(Token = "0x40002CD")]
		[FieldOffset(Offset = "0x34")]
		public Bounds bounds;

		[Token(Token = "0x40002CE")]
		[FieldOffset(Offset = "0x4C")]
		private bool startHasRun;

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x45037CC", Offset = "0x44FF7CC", VA = "0x45037CC", Slot = "13")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x4503968", Offset = "0x44FF968", VA = "0x4503968")]
		[ContextMenu("Snap to closest tile alignment")]
		public void SnapToClosestTileAlignment()
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x4503D6C", Offset = "0x44FFD6C", VA = "0x4503D6C")]
		[ContextMenu("Apply here")]
		public void Apply()
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x4503A70", Offset = "0x44FFA70", VA = "0x4503A70")]
		public void SnapToClosestTileAlignment(RecastGraph graph)
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x4504718", Offset = "0x4500718", VA = "0x4504718")]
		public void SnapSizeToClosestTileMultiple(RecastGraph graph)
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x4504994", Offset = "0x4500994", VA = "0x4504994")]
		private void Start()
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x4504ADC", Offset = "0x4500ADC", VA = "0x4504ADC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x4504C24", Offset = "0x4500C24", VA = "0x4504C24")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x4504764", Offset = "0x4500764", VA = "0x4504764")]
		public static Bounds SnapSizeToClosestTileMultiple(RecastGraph graph, Bounds bounds)
		{
			return default;
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x4503FE8", Offset = "0x44FFFE8", VA = "0x4503FE8")]
		public static void SnapToGraph(TileLayout tileLayout, Vector3 position, Quaternion rotation, Bounds bounds, out IntRect tileRect, out int snappedRotation, out float yOffset)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED NavmeshPrefab.SnapToGraph RVA=0x4503FE8 Token=0x6000475");
}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x4503E74", Offset = "0x44FFE74", VA = "0x4503E74")]
		public void Apply(RecastGraph graph)
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x4504DF8", Offset = "0x4500DF8", VA = "0x4504DF8")]
		public byte[] Scan()
		{
			return null;
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x4504F3C", Offset = "0x4500F3C", VA = "0x4504F3C")]
		public byte[] Scan(RecastGraph graph)
		{
			return null;
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x4504FD8", Offset = "0x4500FD8", VA = "0x4504FD8")]
		public Promise<SerializedOutput> ScanAsync(RecastGraph graph)
		{
			return default;
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x45053A0", Offset = "0x45013A0", VA = "0x45053A0", Slot = "14")]
		protected override void OnUpgradeSerializedData(ref Migrations migrations, bool unityThread)
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x450540C", Offset = "0x450140C", VA = "0x450540C")]
		public NavmeshPrefab()
		{
		}
	}
}
