using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Pathfinding.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

namespace Pathfinding.Graphs.Navmesh
{
	[Serializable]
	[Token(Token = "0x20001D4")]
	public class NavmeshUpdates
	{
		[Token(Token = "0x20001D5")]
		public class NavmeshUpdateSettings : IDisposable
		{
			[Token(Token = "0x40008B2")]
			[FieldOffset(Offset = "0x10")]
			internal readonly NavmeshBase graph;

			[Token(Token = "0x40008B3")]
			[FieldOffset(Offset = "0x18")]
			public GridLookup<NavmeshClipper> clipperLookup;

			[Token(Token = "0x40008B4")]
			[FieldOffset(Offset = "0x20")]
			public TileLayout tileLayout;

			[Token(Token = "0x40008B5")]
			[FieldOffset(Offset = "0x48")]
			private UnsafeBitArray dirtyTiles;

			[Token(Token = "0x40008B6")]
			[FieldOffset(Offset = "0x60")]
			private List<Vector2Int> dirtyTileCoordinates;

			[Token(Token = "0x17000206")]
			public bool attachedToGraph
			{
				[Token(Token = "0x6000D06")]
				[Address(RVA = "0x45A25A8", Offset = "0x459E5A8", VA = "0x45A25A8")]
				[CompilerGenerated]
				get
				{
					return default;
				}
				[Token(Token = "0x6000D07")]
				[Address(RVA = "0x45A25B0", Offset = "0x459E5B0", VA = "0x45A25B0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000207")]
			public bool enabled
			{
				[Token(Token = "0x6000D08")]
				[Address(RVA = "0x45A21E4", Offset = "0x459E1E4", VA = "0x45A21E4")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000208")]
			public bool anyTilesDirty
			{
				[Token(Token = "0x6000D09")]
				[Address(RVA = "0x45A1CC0", Offset = "0x459DCC0", VA = "0x45A1CC0")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x6000D0A")]
			[Address(RVA = "0x45A25BC", Offset = "0x459E5BC", VA = "0x45A25BC")]
			private void AssertEnabled()
			{
			}

			[Token(Token = "0x6000D0B")]
			[Address(RVA = "0x45A2618", Offset = "0x459E618", VA = "0x45A2618")]
			public NavmeshUpdateSettings(NavmeshBase graph)
			{
			}

			[Token(Token = "0x6000D0C")]
			[Address(RVA = "0x45A26A8", Offset = "0x459E6A8", VA = "0x45A26A8")]
			public NavmeshUpdateSettings(NavmeshBase graph, TileLayout tileLayout)
			{
			}

			[Token(Token = "0x6000D0D")]
			[Address(RVA = "0x45A2874", Offset = "0x459E874", VA = "0x45A2874")]
			public void UpdateLayoutFromGraph()
			{
			}

			[Token(Token = "0x6000D0E")]
			[Address(RVA = "0x45A2884", Offset = "0x459E884", VA = "0x45A2884")]
			private void ForceUpdateLayoutFromGraph()
			{
			}

			[Token(Token = "0x6000D0F")]
			[Address(RVA = "0x45A2770", Offset = "0x459E770", VA = "0x45A2770")]
			private void SetLayout(TileLayout tileLayout)
			{
			}

			[Token(Token = "0x6000D10")]
			[Address(RVA = "0x45A22E0", Offset = "0x459E2E0", VA = "0x45A22E0")]
			internal void MarkTilesDirty(IntRect rect)
			{
			}

			[Token(Token = "0x6000D11")]
			[Address(RVA = "0x45A2A5C", Offset = "0x459EA5C", VA = "0x45A2A5C")]
			public void ReloadAllTiles()
			{
			}

			[Token(Token = "0x6000D12")]
			[Address(RVA = "0x45A2AB0", Offset = "0x459EAB0", VA = "0x45A2AB0")]
			public void AttachToGraph()
			{
			}

			[Token(Token = "0x6000D13")]
			[Address(RVA = "0x45A21F4", Offset = "0x459E1F4", VA = "0x45A21F4")]
			public void Enable()
			{
			}

			[Token(Token = "0x6000D14")]
			[Address(RVA = "0x45A225C", Offset = "0x459E25C", VA = "0x45A225C")]
			public void Disable()
			{
			}

			[Token(Token = "0x6000D15")]
			[Address(RVA = "0x45A2994", Offset = "0x459E994", VA = "0x45A2994", Slot = "4")]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000D16")]
			[Address(RVA = "0x45A13DC", Offset = "0x459D3DC", VA = "0x45A13DC")]
			public void DiscardPending()
			{
			}

			[Token(Token = "0x6000D17")]
			[Address(RVA = "0x45A2AF8", Offset = "0x459EAF8", VA = "0x45A2AF8")]
			public void OnResized(IntRect newTileBounds, TileLayout tileLayout)
			{
			}

			[Token(Token = "0x6000D18")]
			[Address(RVA = "0x45A12F4", Offset = "0x459D2F4", VA = "0x45A12F4")]
			public void Dirty(NavmeshClipper obj)
			{
			}

			[Token(Token = "0x6000D19")]
			[Address(RVA = "0x45A1638", Offset = "0x459D638", VA = "0x45A1638")]
			public void AddClipper(NavmeshClipper obj)
			{
			}

			[Token(Token = "0x6000D1A")]
			[Address(RVA = "0x45A1800", Offset = "0x459D800", VA = "0x45A1800")]
			public void RemoveClipper(NavmeshClipper obj)
			{
			}

			[Token(Token = "0x6000D1B")]
			[Address(RVA = "0x45A2464", Offset = "0x459E464", VA = "0x45A2464")]
			public void ScheduleDirtyTilesReload()
			{
			}

			[Token(Token = "0x6000D1C")]
			[Address(RVA = "0x45A2E7C", Offset = "0x459EE7C", VA = "0x45A2E7C")]
			public void ReloadDirtyTilesImmediately()
			{
			}
		}

		[Token(Token = "0x40008AE")]
		[FieldOffset(Offset = "0x10")]
		public float updateInterval;

		[Token(Token = "0x40008AF")]
		[FieldOffset(Offset = "0x18")]
		internal AstarPath astar;

		[Token(Token = "0x40008B0")]
		[FieldOffset(Offset = "0x20")]
		private List<NavmeshUpdateSettings> listeners;

		[Token(Token = "0x40008B1")]
		[FieldOffset(Offset = "0x28")]
		private float lastUpdateTime;

		[Token(Token = "0x6000CF8")]
		[Address(RVA = "0x45A1034", Offset = "0x459D034", VA = "0x45A1034")]
		private static Rect ExpandedXZBounds(Bounds bounds)
		{
			return default;
		}

		[Token(Token = "0x6000CF9")]
		[Address(RVA = "0x45A1094", Offset = "0x459D094", VA = "0x45A1094")]
		internal void OnEnable()
		{
		}

		[Token(Token = "0x6000CFA")]
		[Address(RVA = "0x45A117C", Offset = "0x459D17C", VA = "0x45A117C")]
		internal void OnDisable()
		{
		}

		[Token(Token = "0x6000CFB")]
		[Address(RVA = "0x45A125C", Offset = "0x459D25C", VA = "0x45A125C")]
		public void ForceUpdateAround(NavmeshClipper clipper)
		{
		}

		[Token(Token = "0x6000CFC")]
		[Address(RVA = "0x45A1354", Offset = "0x459D354", VA = "0x45A1354")]
		public void DiscardPending()
		{
		}

		[Token(Token = "0x6000CFD")]
		[Address(RVA = "0x45A15A0", Offset = "0x459D5A0", VA = "0x45A15A0")]
		private void HandleOnEnableCallback(NavmeshClipper obj)
		{
		}

		[Token(Token = "0x6000CFE")]
		[Address(RVA = "0x45A1760", Offset = "0x459D760", VA = "0x45A1760")]
		private void HandleOnDisableCallback(NavmeshClipper obj)
		{
		}

		[Token(Token = "0x6000CFF")]
		[Address(RVA = "0x45A18A4", Offset = "0x459D8A4", VA = "0x45A18A4")]
		private void AddListener(NavmeshUpdateSettings listener)
		{
		}

		[Token(Token = "0x6000D00")]
		[Address(RVA = "0x45A1A48", Offset = "0x459DA48", VA = "0x45A1A48")]
		private void RemoveListener(NavmeshUpdateSettings listener)
		{
		}

		[Token(Token = "0x6000D01")]
		[Address(RVA = "0x45A1AA0", Offset = "0x459DAA0", VA = "0x45A1AA0")]
		internal void Update()
		{
		}

		[Token(Token = "0x6000D02")]
		[Address(RVA = "0x45A21CC", Offset = "0x459E1CC", VA = "0x45A21CC")]
		public void ForceUpdate()
		{
		}

		[Token(Token = "0x6000D03")]
		[Address(RVA = "0x45A1BA4", Offset = "0x459DBA4", VA = "0x45A1BA4")]
		private void RefreshEnabledState()
		{
		}

		[Token(Token = "0x6000D04")]
		[Address(RVA = "0x45A1D10", Offset = "0x459DD10", VA = "0x45A1D10")]
		private void ScheduleTileUpdates()
		{
		}

		[Token(Token = "0x6000D05")]
		[Address(RVA = "0x45A2524", Offset = "0x459E524", VA = "0x45A2524")]
		public NavmeshUpdates()
		{
		}
	}
}
