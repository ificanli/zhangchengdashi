using Il2CppDummyDll;
using Pathfinding.Collections;
using Pathfinding.Graphs.Navmesh.Jobs;

namespace Pathfinding.Graphs.Navmesh
{
	[Token(Token = "0x20001A9")]
	public struct RecastBuilder
	{
		[Token(Token = "0x6000C34")]
		[Address(RVA = "0x4588438", Offset = "0x4584438", VA = "0x4588438")]
		public static TileBuilder BuildTileMeshes(RecastGraph graph, TileLayout tileLayout, IntRect tileRect)
		{
			return default;
		}

		[Token(Token = "0x6000C35")]
		[Address(RVA = "0x4588490", Offset = "0x4584490", VA = "0x4588490")]
		public static JobBuildNodes BuildNodeTiles(RecastGraph graph, TileLayout tileLayout)
		{
			return default;
		}

		[Token(Token = "0x6000C36")]
		[Address(RVA = "0x45884E4", Offset = "0x45844E4", VA = "0x45884E4")]
		public static TileCutter CutTiles(NavmeshBase graph, GridLookup<NavmeshClipper> cuts, TileLayout tileLayout)
		{
			return default;
		}
	}
}
