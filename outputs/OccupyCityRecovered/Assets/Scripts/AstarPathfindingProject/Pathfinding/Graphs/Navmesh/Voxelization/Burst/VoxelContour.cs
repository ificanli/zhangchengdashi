using Il2CppDummyDll;

namespace Pathfinding.Graphs.Navmesh.Voxelization.Burst
{
	[Token(Token = "0x20001E3")]
	public struct VoxelContour
	{
		[Token(Token = "0x40008E7")]
		[FieldOffset(Offset = "0x0")]
		public int nverts;

		[Token(Token = "0x40008E8")]
		[FieldOffset(Offset = "0x4")]
		public int vertexStartIndex;

		[Token(Token = "0x40008E9")]
		[FieldOffset(Offset = "0x8")]
		public int reg;

		[Token(Token = "0x40008EA")]
		[FieldOffset(Offset = "0xC")]
		public int area;
	}
}
