using System;
using Il2CppDummyDll;
using Pathfinding.Jobs;
using Pathfinding.Sync;
using UnityEngine;

namespace Pathfinding.Graphs.Navmesh.Jobs
{
	[Token(Token = "0x20001F2")]
	public struct JobBuildNodes
	{
		[Token(Token = "0x20001F3")]
		public class BuildNodeTilesOutput : IProgress, IDisposable
		{
			[Token(Token = "0x400093D")]
			[FieldOffset(Offset = "0x10")]
			public TileBuilder.TileBuilderOutput progressSource;

			[Token(Token = "0x400093E")]
			[FieldOffset(Offset = "0x18")]
			public NavmeshTile[] tiles;

			[Token(Token = "0x1700020E")]
			public float Progress
			{
				[Token(Token = "0x6000D72")]
				[Address(RVA = "0x446F714", Offset = "0x446B714", VA = "0x446F714", Slot = "4")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x6000D73")]
			[Address(RVA = "0x446F730", Offset = "0x446B730", VA = "0x446F730", Slot = "5")]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000D74")]
			[Address(RVA = "0x446F70C", Offset = "0x446B70C", VA = "0x446F70C")]
			public BuildNodeTilesOutput()
			{
			}
		}

		[Token(Token = "0x4000937")]
		[FieldOffset(Offset = "0x0")]
		private uint graphIndex;

		[Token(Token = "0x4000938")]
		[FieldOffset(Offset = "0x4")]
		public uint initialPenalty;

		[Token(Token = "0x4000939")]
		[FieldOffset(Offset = "0x8")]
		public bool recalculateNormals;

		[Token(Token = "0x400093A")]
		[FieldOffset(Offset = "0xC")]
		public float maxTileConnectionEdgeDistance;

		[Token(Token = "0x400093B")]
		[FieldOffset(Offset = "0x10")]
		private Matrix4x4 graphToWorldSpace;

		[Token(Token = "0x400093C")]
		[FieldOffset(Offset = "0x50")]
		private TileLayout tileLayout;

		[Token(Token = "0x6000D70")]
		[Address(RVA = "0x446F134", Offset = "0x446B134", VA = "0x446F134")]
		internal JobBuildNodes(RecastGraph graph, TileLayout tileLayout)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED JobBuildNodes..ctor RVA=0x446F134 Token=0x6000D70");
}

		[Token(Token = "0x6000D71")]
		[Address(RVA = "0x446F1D0", Offset = "0x446B1D0", VA = "0x446F1D0")]
		public Promise<BuildNodeTilesOutput> Schedule(DisposeArena arena, Promise<TileBuilder.TileBuilderOutput> preCutDependency, Promise<TileCutter.TileCutterOutput> postCutDependency)
		{
			return default;
		}
	}
}
