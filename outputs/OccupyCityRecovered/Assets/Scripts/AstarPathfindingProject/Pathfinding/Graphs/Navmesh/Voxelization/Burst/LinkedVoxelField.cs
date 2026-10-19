using Il2CppDummyDll;
using Pathfinding.Jobs;
using Unity.Collections;

namespace Pathfinding.Graphs.Navmesh.Voxelization.Burst
{
	[Token(Token = "0x20001E1")]
	public struct LinkedVoxelField : IArenaDisposable
	{
		[Token(Token = "0x40008D8")]
		public const uint MaxHeight = 65536u;

		[Token(Token = "0x40008D9")]
		public const int MaxHeightInt = 65536;

		[Token(Token = "0x40008DA")]
		public const uint InvalidSpanValue = uint.MaxValue;

		[Token(Token = "0x40008DB")]
		public const float AvgSpanLayerCountEstimate = 8f;

		[Token(Token = "0x40008DC")]
		[FieldOffset(Offset = "0x0")]
		public int width;

		[Token(Token = "0x40008DD")]
		[FieldOffset(Offset = "0x4")]
		public int depth;

		[Token(Token = "0x40008DE")]
		[FieldOffset(Offset = "0x8")]
		public int height;

		[Token(Token = "0x40008DF")]
		[FieldOffset(Offset = "0xC")]
		public bool flatten;

		[Token(Token = "0x40008E0")]
		[FieldOffset(Offset = "0x10")]
		public NativeList<LinkedVoxelSpan> linkedSpans;

		[Token(Token = "0x40008E1")]
		[FieldOffset(Offset = "0x18")]
		private NativeList<int> removedStack;

		[Token(Token = "0x40008E2")]
		[FieldOffset(Offset = "0x20")]
		private NativeList<CellMinMax> linkedCellMinMax;

		[Token(Token = "0x6000D36")]
		[Address(RVA = "0x45A4328", Offset = "0x45A0328", VA = "0x45A4328")]
		public LinkedVoxelField(int width, int depth, int height)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED LinkedVoxelField..ctor RVA=0x45A4328 Token=0x6000D36");
}

		[Token(Token = "0x6000D37")]
		[Address(RVA = "0x45A4450", Offset = "0x45A0450", VA = "0x45A4450", Slot = "4")]
void IArenaDisposable.DisposeWith(DisposeArena arena)
		{
		}

		[Token(Token = "0x6000D38")]
		[Address(RVA = "0x45A44F8", Offset = "0x45A04F8", VA = "0x45A44F8")]
		public void ResetLinkedVoxelSpans()
		{
		}

		[Token(Token = "0x6000D39")]
		[Address(RVA = "0x45A4668", Offset = "0x45A0668", VA = "0x45A4668")]
		private void PushToSpanRemovedStack(int index)
		{
		}

		[Token(Token = "0x6000D3A")]
		[Address(RVA = "0x45A41A8", Offset = "0x45A01A8", VA = "0x45A41A8")]
		public int GetSpanCount()
		{
			return default;
		}

		[Token(Token = "0x6000D3B")]
		[Address(RVA = "0x45A46C4", Offset = "0x45A06C4", VA = "0x45A46C4")]
		public void ResolveSolid(int index, int objectID, int voxelWalkableClimb)
		{
		}

		[Token(Token = "0x6000D3C")]
		[Address(RVA = "0x45A4E1C", Offset = "0x45A0E1C", VA = "0x45A4E1C")]
		public void SetWalkableBackground()
		{
		}

		[Token(Token = "0x6000D3D")]
		[Address(RVA = "0x45A4ED0", Offset = "0x45A0ED0", VA = "0x45A4ED0")]
		public void AddFlattenedSpan(int index, int area)
		{
		}

		[Token(Token = "0x6000D3E")]
		[Address(RVA = "0x45A4788", Offset = "0x45A0788", VA = "0x45A4788")]
		public void AddLinkedSpan(int index, int bottom, int top, int area, int voxelWalkableClimb, int objectID)
		{
		}
	}
}
