using Il2CppDummyDll;

namespace Pathfinding.Graphs.Navmesh.Voxelization.Burst
{
	[Token(Token = "0x20001E0")]
	internal struct CellMinMax
	{
		[Token(Token = "0x40008D5")]
		[FieldOffset(Offset = "0x0")]
		public int objectID;

		[Token(Token = "0x40008D6")]
		[FieldOffset(Offset = "0x4")]
		public int min;

		[Token(Token = "0x40008D7")]
		[FieldOffset(Offset = "0x8")]
		public int max;
	}
}
