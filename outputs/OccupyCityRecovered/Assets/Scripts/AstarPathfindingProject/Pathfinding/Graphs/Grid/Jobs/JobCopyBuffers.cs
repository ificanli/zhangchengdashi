using Il2CppDummyDll;
using Pathfinding.Jobs;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;

namespace Pathfinding.Graphs.Grid.Jobs
{
	[Token(Token = "0x2000228")]
	[BurstCompile]
	public struct JobCopyBuffers : IJob
	{
		[Token(Token = "0x4000A36")]
		[FieldOffset(Offset = "0x0")]
		[DisableUninitializedReadCheck]
		[ReadOnly]
		public GridGraphNodeData input;

		[Token(Token = "0x4000A37")]
		[FieldOffset(Offset = "0x98")]
		[WriteOnly]
		public GridGraphNodeData output;

		[Token(Token = "0x4000A38")]
		[FieldOffset(Offset = "0x130")]
		public IntBounds bounds;

		[Token(Token = "0x4000A39")]
		[FieldOffset(Offset = "0x148")]
		public bool copyPenaltyAndTags;

		[Token(Token = "0x6000E0B")]
		[Address(RVA = "0x447B520", Offset = "0x4477520", VA = "0x447B520", Slot = "4")]
		public void Execute()
		{
		}
	}
}
