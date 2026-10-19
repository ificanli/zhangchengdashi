using Il2CppDummyDll;
using Pathfinding.Collections;
using Unity.Collections;

namespace Pathfinding.Graphs.Navmesh
{
	[Token(Token = "0x20001D0")]
	public struct TileMesh
	{
		[Token(Token = "0x20001D1")]
		public struct TileMeshUnsafe
		{
			[Token(Token = "0x40008A5")]
			[FieldOffset(Offset = "0x0")]
			public UnsafeSpan<int> triangles;

			[Token(Token = "0x40008A6")]
			[FieldOffset(Offset = "0x10")]
			public UnsafeSpan<Int3> verticesInTileSpace;

			[Token(Token = "0x40008A7")]
			[FieldOffset(Offset = "0x20")]
			public UnsafeSpan<uint> tags;

			[Token(Token = "0x6000CF0")]
			[Address(RVA = "0x45A022C", Offset = "0x459C22C", VA = "0x45A022C")]
			public void Dispose(Allocator allocator)
			{
			}

			[Token(Token = "0x6000CF1")]
			[Address(RVA = "0x45A02D4", Offset = "0x459C2D4", VA = "0x45A02D4")]
			public TileMesh ToManaged()
			{
				return default;
			}
		}

		[Token(Token = "0x40008A2")]
		[FieldOffset(Offset = "0x0")]
		public int[] triangles;

		[Token(Token = "0x40008A3")]
		[FieldOffset(Offset = "0x8")]
		public Int3[] verticesInTileSpace;

		[Token(Token = "0x40008A4")]
		[FieldOffset(Offset = "0x10")]
		public uint[] tags;
	}
}
