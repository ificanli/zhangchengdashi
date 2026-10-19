using System;
using Il2CppDummyDll;
using Pathfinding.Collections;
using Pathfinding.Util;
using Unity.Profiling;

namespace Pathfinding.Graphs.Navmesh
{
	[Token(Token = "0x20001A8")]
	public class NavmeshTile : INavmeshHolder, ITransformedGraph
	{
		[Token(Token = "0x4000802")]
		[FieldOffset(Offset = "0x10")]
		public UnsafeSpan<Int3> vertsInGraphSpace;

		[Token(Token = "0x4000803")]
		[FieldOffset(Offset = "0x20")]
		public UnsafeSpan<Int3> verts;

		[Token(Token = "0x4000804")]
		[FieldOffset(Offset = "0x30")]
		public UnsafeSpan<int> tris;

		[Token(Token = "0x4000805")]
		[FieldOffset(Offset = "0x40")]
		public bool isCut;

		[Token(Token = "0x4000806")]
		[FieldOffset(Offset = "0x48")]
		public UnsafeSpan<Int3> preCutVertsInTileSpace;

		[Token(Token = "0x4000807")]
		[FieldOffset(Offset = "0x58")]
		public UnsafeSpan<int> preCutTris;

		[Token(Token = "0x4000808")]
		[FieldOffset(Offset = "0x68")]
		public UnsafeSpan<uint> preCutTags;

		[Token(Token = "0x4000809")]
		[FieldOffset(Offset = "0x78")]
		public int x;

		[Token(Token = "0x400080A")]
		[FieldOffset(Offset = "0x7C")]
		public int z;

		[Token(Token = "0x400080B")]
		[FieldOffset(Offset = "0x80")]
		public int w;

		[Token(Token = "0x400080C")]
		[FieldOffset(Offset = "0x84")]
		public int d;

		[Token(Token = "0x400080D")]
		[FieldOffset(Offset = "0x88")]
		public TriangleMeshNode[] nodes;

		[Token(Token = "0x400080E")]
		[FieldOffset(Offset = "0x90")]
		public BBTree bbTree;

		[Token(Token = "0x400080F")]
		[FieldOffset(Offset = "0xC0")]
		public bool flag;

		[Token(Token = "0x4000810")]
		[FieldOffset(Offset = "0xC8")]
		public NavmeshBase graph;

		[Token(Token = "0x170001FD")]
		public GraphTransform transform
		{
			[Token(Token = "0x6000C30")]
			[Address(RVA = "0x45882B0", Offset = "0x45842B0", VA = "0x45882B0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000C2C")]
		[Address(RVA = "0x4588144", Offset = "0x4584144", VA = "0x4588144", Slot = "8")]
		public void GetTileCoordinates(int tileIndex, out int x, out int z)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED NavmeshTile.GetTileCoordinates RVA=0x4588144 Token=0x6000C2C");
}

		[Token(Token = "0x6000C2D")]
		[Address(RVA = "0x4588158", Offset = "0x4584158", VA = "0x4588158", Slot = "7")]
		public int GetVertexArrayIndex(int index)
		{
			return default;
		}

		[Token(Token = "0x6000C2E")]
		[Address(RVA = "0x4588160", Offset = "0x4584160", VA = "0x4588160", Slot = "5")]
		public Int3 GetVertex(int index)
		{
			return default;
		}

		[Token(Token = "0x6000C2F")]
		[Address(RVA = "0x4588208", Offset = "0x4584208", VA = "0x4588208", Slot = "6")]
		[IgnoredByDeepProfiler]
		public Int3 GetVertexInGraphSpace(int index)
		{
			return default;
		}

		[Token(Token = "0x6000C31")]
		[Address(RVA = "0x45882CC", Offset = "0x45842CC", VA = "0x45882CC", Slot = "4")]
		public void GetNodes(Action<GraphNode> action)
		{
		}

		[Token(Token = "0x6000C32")]
		[Address(RVA = "0x4588338", Offset = "0x4584338", VA = "0x4588338")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000C33")]
		[Address(RVA = "0x4588430", Offset = "0x4584430", VA = "0x4588430")]
		public NavmeshTile()
		{
		}
	}
}
