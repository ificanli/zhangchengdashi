using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace Pathfinding.Jobs
{
	[Token(Token = "0x2000181")]
	[BurstCompile]
	public struct JobRotate3DArray<T> : IJob where T : struct
	{
		[Token(Token = "0x400079A")]
		[FieldOffset(Offset = "0x0")]
		public NativeArray<T> arr;

		[Token(Token = "0x400079B")]
		[FieldOffset(Offset = "0x0")]
		public int3 size;

		[Token(Token = "0x400079C")]
		[FieldOffset(Offset = "0x0")]
		public int dx;

		[Token(Token = "0x400079D")]
		[FieldOffset(Offset = "0x0")]
		public int dz;

		[Token(Token = "0x6000BA6")]
		public void Execute()
		{
		}
	}
}
