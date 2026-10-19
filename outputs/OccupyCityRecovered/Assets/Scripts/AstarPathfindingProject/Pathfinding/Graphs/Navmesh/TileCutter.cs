using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Pathfinding.Collections;
using Pathfinding.Sync;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using UnityEngine;

namespace Pathfinding.Graphs.Navmesh
{
	[Token(Token = "0x20001C0")]
	public struct TileCutter
	{
		[Token(Token = "0x20001C1")]
		public struct TileCutterOutput : IProgress, IDisposable
		{
			[Token(Token = "0x4000874")]
			[FieldOffset(Offset = "0x0")]
			public TileMeshesUnsafe tileMeshes;

			[Token(Token = "0x17000201")]
			public float Progress
			{
				[Token(Token = "0x6000CAD")]
				[Address(RVA = "0x4598058", Offset = "0x4594058", VA = "0x4598058", Slot = "4")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x6000CAE")]
			[Address(RVA = "0x4598060", Offset = "0x4594060", VA = "0x4598060", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Token(Token = "0x20001C2")]
		[BurstCompile]
		private struct JobCutTiles : IJob
		{
			[Token(Token = "0x4000875")]
			[FieldOffset(Offset = "0x0")]
			public UnsafeSpan<UnsafeList<UnsafeSpan<Int3>>> tileVertices;

			[Token(Token = "0x4000876")]
			[FieldOffset(Offset = "0x10")]
			public UnsafeSpan<UnsafeList<UnsafeSpan<int>>> tileTriangles;

			[Token(Token = "0x4000877")]
			[FieldOffset(Offset = "0x20")]
			public UnsafeSpan<UnsafeList<UnsafeSpan<int>>> tileTags;

			[Token(Token = "0x4000878")]
			[FieldOffset(Offset = "0x30")]
			public TileHandler.CutCollection cutCollection;

			[Token(Token = "0x4000879")]
			[FieldOffset(Offset = "0x98")]
			public TileMeshesUnsafe inputTileMeshes;

			[Token(Token = "0x400087A")]
			[FieldOffset(Offset = "0xC0")]
			public NativeArray<TileMesh.TileMeshUnsafe> outputTileMeshes;

			[Token(Token = "0x6000CAF")]
			[Address(RVA = "0x4598068", Offset = "0x4594068", VA = "0x4598068", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Token(Token = "0x4000871")]
		[FieldOffset(Offset = "0x0")]
		private NavmeshBase graph;

		[Token(Token = "0x4000872")]
		[FieldOffset(Offset = "0x8")]
		private GridLookup<NavmeshClipper> cuts;

		[Token(Token = "0x4000873")]
		[FieldOffset(Offset = "0x10")]
		private TileLayout tileLayout;

		[Token(Token = "0x6000CA7")]
		[Address(RVA = "0x4596030", Offset = "0x4592030", VA = "0x4596030")]
		public TileCutter(NavmeshBase graph, GridLookup<NavmeshClipper> cuts, TileLayout tileLayout)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED TileCutter..ctor RVA=0x4596030 Token=0x6000CA7");
}

		[Token(Token = "0x6000CA8")]
		[Address(RVA = "0x4596048", Offset = "0x4592048", VA = "0x4596048")]
		private static void DisposeTileData(UnsafeSpan<UnsafeList<UnsafeSpan<Int3>>> tileVertices, UnsafeSpan<UnsafeList<UnsafeSpan<int>>> tileTriangles, UnsafeSpan<UnsafeList<UnsafeSpan<int>>> tileTags, Allocator allocator, bool skipFirst)
		{
		}

		[Token(Token = "0x6000CA9")]
		[Address(RVA = "0x45963A0", Offset = "0x45923A0", VA = "0x45963A0")]
		public static void EnsurePreCutDataExists(NavmeshBase graph, NavmeshTile tile)
		{
		}

		[Token(Token = "0x6000CAA")]
		[Address(RVA = "0x4596630", Offset = "0x4592630", VA = "0x4596630")]
		private static bool CheckVersion()
		{
			return default;
		}

		[Token(Token = "0x6000CAB")]
		[Address(RVA = "0x4596638", Offset = "0x4592638", VA = "0x4596638")]
		public Promise<TileCutterOutput> Schedule(List<Vector2Int> tileCoordinates)
		{
			return default;
		}

		[Token(Token = "0x6000CAC")]
		[Address(RVA = "0x4597AFC", Offset = "0x4593AFC", VA = "0x4597AFC")]
		public Promise<TileCutterOutput> Schedule(Promise<TileBuilder.TileBuilderOutput> builderOutput)
		{
			return default;
		}
	}
}
