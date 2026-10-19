using Il2CppDummyDll;
using Pathfinding.Jobs;
using Unity.Collections;

namespace Pathfinding.Graphs.Navmesh.Voxelization.Burst
{
	[Token(Token = "0x20001DD")]
	public struct CompactVoxelField : IArenaDisposable
	{
		[Token(Token = "0x40008C6")]
		public const int UnwalkableArea = 0;

		[Token(Token = "0x40008C7")]
		public const uint NotConnected = 63u;

		[Token(Token = "0x40008C8")]
		[FieldOffset(Offset = "0x0")]
		public readonly int voxelWalkableHeight;

		[Token(Token = "0x40008C9")]
		[FieldOffset(Offset = "0x4")]
		public readonly int width;

		[Token(Token = "0x40008CA")]
		[FieldOffset(Offset = "0x8")]
		public readonly int depth;

		[Token(Token = "0x40008CB")]
		[FieldOffset(Offset = "0x10")]
		public NativeList<CompactVoxelSpan> spans;

		[Token(Token = "0x40008CC")]
		[FieldOffset(Offset = "0x18")]
		public NativeList<CompactVoxelCell> cells;

		[Token(Token = "0x40008CD")]
		[FieldOffset(Offset = "0x20")]
		public NativeList<int> areaTypes;

		[Token(Token = "0x40008CE")]
		public const int MaxLayers = 65535;

		[Token(Token = "0x6000D2E")]
		[Address(RVA = "0x45A3B70", Offset = "0x459FB70", VA = "0x45A3B70")]
		public CompactVoxelField(int width, int depth, int voxelWalkableHeight, Allocator allocator)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED CompactVoxelField..ctor RVA=0x45A3B70 Token=0x6000D2E");
}

		[Token(Token = "0x6000D2F")]
		[Address(RVA = "0x45A3C94", Offset = "0x459FC94", VA = "0x45A3C94", Slot = "4")]
void IArenaDisposable.DisposeWith(DisposeArena arena)
		{
		}

		[Token(Token = "0x6000D30")]
		[Address(RVA = "0x45A3D3C", Offset = "0x459FD3C", VA = "0x45A3D3C")]
		public int GetNeighbourIndex(int index, int direction)
		{
			return default;
		}

		[Token(Token = "0x6000D31")]
		[Address(RVA = "0x45A3DF4", Offset = "0x459FDF4", VA = "0x45A3DF4")]
		public void BuildFromLinkedField(LinkedVoxelField field)
		{
		}
	}
}
