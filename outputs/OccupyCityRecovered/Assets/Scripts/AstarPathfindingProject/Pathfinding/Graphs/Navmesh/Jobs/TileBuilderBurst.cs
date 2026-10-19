using Il2CppDummyDll;
using Pathfinding.Graphs.Navmesh.Voxelization.Burst;
using Pathfinding.Jobs;
using Unity.Collections;

namespace Pathfinding.Graphs.Navmesh.Jobs
{
	[Token(Token = "0x20001F6")]
	public struct TileBuilderBurst : IArenaDisposable
	{
		[Token(Token = "0x4000947")]
		[FieldOffset(Offset = "0x0")]
		public LinkedVoxelField linkedVoxelField;

		[Token(Token = "0x4000948")]
		[FieldOffset(Offset = "0x28")]
		public CompactVoxelField compactVoxelField;

		[Token(Token = "0x4000949")]
		[FieldOffset(Offset = "0x50")]
		public NativeList<ushort> distanceField;

		[Token(Token = "0x400094A")]
		[FieldOffset(Offset = "0x58")]
		public NativeQueue<Int3> tmpQueue1;

		[Token(Token = "0x400094B")]
		[FieldOffset(Offset = "0x60")]
		public NativeQueue<Int3> tmpQueue2;

		[Token(Token = "0x400094C")]
		[FieldOffset(Offset = "0x68")]
		public NativeList<VoxelContour> contours;

		[Token(Token = "0x400094D")]
		[FieldOffset(Offset = "0x70")]
		public NativeList<int> contourVertices;

		[Token(Token = "0x400094E")]
		[FieldOffset(Offset = "0x78")]
		public VoxelMesh voxelMesh;

		[Token(Token = "0x6000D78")]
		[Address(RVA = "0x446FECC", Offset = "0x446BECC", VA = "0x446FECC")]
		public TileBuilderBurst(int width, int depth, int voxelWalkableHeight, int maximumVoxelYCoord)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED TileBuilderBurst..ctor RVA=0x446FECC Token=0x6000D78");
}

		[Token(Token = "0x6000D79")]
		[Address(RVA = "0x4470144", Offset = "0x446C144", VA = "0x4470144", Slot = "4")]
void IArenaDisposable.DisposeWith(DisposeArena arena)
		{
		}
	}
}
