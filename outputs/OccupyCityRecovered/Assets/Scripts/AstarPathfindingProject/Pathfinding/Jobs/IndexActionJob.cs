using Il2CppDummyDll;
using Pathfinding.Graphs.Grid;
using Unity.Burst;
using Unity.Jobs;

namespace Pathfinding.Jobs
{
	[Token(Token = "0x200017B")]
	[BurstCompile]
	public struct IndexActionJob<T> : IJob where T : struct, GridIterationUtilities.ISliceAction
	{
		[Token(Token = "0x400078A")]
		[FieldOffset(Offset = "0x0")]
		public T action;

		[Token(Token = "0x400078B")]
		[FieldOffset(Offset = "0x0")]
		public int length;

		[Token(Token = "0x6000B9F")]
		public void Execute()
		{
		}
	}
}
