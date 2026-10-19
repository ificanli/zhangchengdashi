using Il2CppDummyDll;
using Pathfinding.Graphs.Grid;
using Unity.Burst;
using Unity.Jobs;

namespace Pathfinding.Jobs
{
	[Token(Token = "0x200017C")]
	[BurstCompile]
	public struct SliceActionJob<T> : IJob where T : struct, GridIterationUtilities.ISliceAction
	{
		[Token(Token = "0x400078C")]
		[FieldOffset(Offset = "0x0")]
		public T action;

		[Token(Token = "0x400078D")]
		[FieldOffset(Offset = "0x0")]
		public Slice3D slice;

		[Token(Token = "0x6000BA0")]
		public void Execute()
		{
		}
	}
}
