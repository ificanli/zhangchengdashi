using Il2CppDummyDll;
using Pathfinding.Collections;
using Pathfinding.Jobs;
using Unity.Burst;

namespace Pathfinding.Graphs.Grid.Jobs
{
	[Token(Token = "0x200022A")]
	[BurstCompile]
	public struct JobFilterDiagonalConnections : IJobParallelForBatched
	{
		[Token(Token = "0x4000A46")]
		[FieldOffset(Offset = "0x0")]
		public Slice3D slice;

		[Token(Token = "0x4000A47")]
		[FieldOffset(Offset = "0x24")]
		public NumNeighbours neighbours;

		[Token(Token = "0x4000A48")]
		[FieldOffset(Offset = "0x28")]
		public bool cutCorners;

		[Token(Token = "0x4000A49")]
		[FieldOffset(Offset = "0x30")]
		public UnsafeSpan<ulong> nodeConnections;

		[Token(Token = "0x1700021F")]
		public bool allowBoundsChecks
		{
			[Token(Token = "0x6000E0E")]
			[Address(RVA = "0x447B7E8", Offset = "0x44777E8", VA = "0x447B7E8", Slot = "4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000E0F")]
		[Address(RVA = "0x447B7F0", Offset = "0x44777F0", VA = "0x447B7F0", Slot = "5")]
		public void Execute(int start, int count)
		{
		}
	}
}
