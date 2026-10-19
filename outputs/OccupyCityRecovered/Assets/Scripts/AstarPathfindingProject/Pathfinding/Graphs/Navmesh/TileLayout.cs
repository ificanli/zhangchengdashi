using Il2CppDummyDll;
using Pathfinding.Util;
using Unity.Mathematics;
using UnityEngine;

namespace Pathfinding.Graphs.Navmesh
{
	[Token(Token = "0x20001CF")]
	public struct TileLayout
	{
		[Token(Token = "0x400089D")]
		[FieldOffset(Offset = "0x0")]
		public Vector2Int tileCount;

		[Token(Token = "0x400089E")]
		[FieldOffset(Offset = "0x8")]
		public GraphTransform transform;

		[Token(Token = "0x400089F")]
		[FieldOffset(Offset = "0x10")]
		public Vector2Int tileSizeInVoxels;

		[Token(Token = "0x40008A0")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 graphSpaceSize;

		[Token(Token = "0x40008A1")]
		[FieldOffset(Offset = "0x24")]
		public float cellSize;

		[Token(Token = "0x17000202")]
		public float CellHeight
		{
			[Token(Token = "0x6000CE5")]
			[Address(RVA = "0x45950A0", Offset = "0x45910A0", VA = "0x45950A0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000203")]
		public Vector2 TileWorldSize
		{
			[Token(Token = "0x6000CE6")]
			[Address(RVA = "0x4595084", Offset = "0x4591084", VA = "0x4595084")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000204")]
		public float TileWorldSizeX
		{
			[Token(Token = "0x6000CE7")]
			[Address(RVA = "0x45950C8", Offset = "0x45910C8", VA = "0x45950C8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000205")]
		public float TileWorldSizeZ
		{
			[Token(Token = "0x6000CE8")]
			[Address(RVA = "0x45950DC", Offset = "0x45910DC", VA = "0x45950DC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000CE9")]
		[Address(RVA = "0x4593CEC", Offset = "0x458FCEC", VA = "0x4593CEC")]
		public Bounds GetTileBoundsInGraphSpace(int x, int z, int width = 1, int depth = 1)
		{
			return default;
		}

		[Token(Token = "0x6000CEA")]
		[Address(RVA = "0x459F974", Offset = "0x459B974", VA = "0x459F974")]
		public IntRect GetTouchingTiles(Bounds bounds, float margin = 0f)
		{
			return default;
		}

		[Token(Token = "0x6000CEB")]
		[Address(RVA = "0x4595794", Offset = "0x4591794", VA = "0x4595794")]
		public static IntRect GetTouchingTiles(ref float4x4 worldToGraphTransform, float2 tileSize, Bounds bounds, float margin = 0f)
		{
			return default;
		}

		[Token(Token = "0x6000CEC")]
		[Address(RVA = "0x459FC24", Offset = "0x459BC24", VA = "0x459FC24")]
		public IntRect GetTouchingTilesInGraphSpace(Rect rect)
		{
			return default;
		}

		[Token(Token = "0x6000CED")]
		[Address(RVA = "0x459FE54", Offset = "0x459BE54", VA = "0x459FE54")]
		public TileLayout(RecastGraph graph)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED TileLayout..ctor RVA=0x459FE54 Token=0x6000CED");
}

		[Token(Token = "0x6000CEE")]
		[Address(RVA = "0x45A0150", Offset = "0x459C150", VA = "0x45A0150")]
		public TileLayout(NavMeshGraph graph)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED TileLayout..ctor RVA=0x45A0150 Token=0x6000CEE");
}

		[Token(Token = "0x6000CEF")]
		[Address(RVA = "0x459FF04", Offset = "0x459BF04", VA = "0x459FF04")]
		public TileLayout(Bounds bounds, Quaternion rotation, float cellSize, int tileSizeInVoxels, bool useTiles)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED TileLayout..ctor RVA=0x459FF04 Token=0x6000CEF");
}
	}
}
