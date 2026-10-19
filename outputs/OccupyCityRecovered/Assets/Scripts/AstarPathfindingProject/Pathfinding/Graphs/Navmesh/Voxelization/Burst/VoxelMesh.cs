using Il2CppDummyDll;
using Pathfinding.Jobs;
using Unity.Collections;

namespace Pathfinding.Graphs.Navmesh.Voxelization.Burst
{
	[Token(Token = "0x20001E5")]
	public struct VoxelMesh : IArenaDisposable
	{
		[Token(Token = "0x40008F2")]
		[FieldOffset(Offset = "0x0")]
		public NativeList<Int3> verts;

		[Token(Token = "0x40008F3")]
		[FieldOffset(Offset = "0x8")]
		public NativeList<int> tris;

		[Token(Token = "0x40008F4")]
		[FieldOffset(Offset = "0x10")]
		public NativeList<int> areas;

		[Token(Token = "0x6000D4B")]
		[Address(RVA = "0x4468474", Offset = "0x4464474", VA = "0x4468474", Slot = "4")]
void IArenaDisposable.DisposeWith(DisposeArena arena)
		{
		}
	}
}
