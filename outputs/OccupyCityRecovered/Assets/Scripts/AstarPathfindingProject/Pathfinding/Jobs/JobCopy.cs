using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;

namespace Pathfinding.Jobs
{
	[Token(Token = "0x200017A")]
	[BurstCompile]
	public struct JobCopy<T> : IJob where T : struct
	{
		[Token(Token = "0x4000788")]
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public NativeArray<T> from;

		[Token(Token = "0x4000789")]
		[FieldOffset(Offset = "0x0")]
		[WriteOnly]
		public NativeArray<T> to;

		[Token(Token = "0x6000B9E")]
		public void Execute()
		{
		}
	}
}
