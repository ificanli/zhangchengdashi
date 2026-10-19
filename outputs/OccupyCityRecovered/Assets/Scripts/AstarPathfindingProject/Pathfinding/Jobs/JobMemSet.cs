using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;

namespace Pathfinding.Jobs
{
	[Token(Token = "0x2000179")]
	[BurstCompile]
	public struct JobMemSet<T> : IJob where T : struct
	{
		[Token(Token = "0x4000786")]
		[FieldOffset(Offset = "0x0")]
		[WriteOnly]
		public NativeArray<T> data;

		[Token(Token = "0x4000787")]
		[FieldOffset(Offset = "0x0")]
		public T value;

		[Token(Token = "0x6000B9D")]
		public void Execute()
		{
		}
	}
}
