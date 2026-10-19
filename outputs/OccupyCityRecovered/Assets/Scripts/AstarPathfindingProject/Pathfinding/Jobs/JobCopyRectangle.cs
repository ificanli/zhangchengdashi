using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;

namespace Pathfinding.Jobs
{
	[Token(Token = "0x2000178")]
	[BurstCompile]
	public struct JobCopyRectangle<T> : IJob where T : struct
	{
		[Token(Token = "0x4000782")]
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		[DisableUninitializedReadCheck]
		public NativeArray<T> input;

		[Token(Token = "0x4000783")]
		[FieldOffset(Offset = "0x0")]
		[WriteOnly]
		public NativeArray<T> output;

		[Token(Token = "0x4000784")]
		[FieldOffset(Offset = "0x0")]
		public Slice3D inputSlice;

		[Token(Token = "0x4000785")]
		[FieldOffset(Offset = "0x0")]
		public Slice3D outputSlice;

		[Token(Token = "0x6000B9B")]
		public void Execute()
		{
		}

		[Token(Token = "0x6000B9C")]
		public static void Copy(NativeArray<T> input, NativeArray<T> output, Slice3D inputSlice, Slice3D outputSlice)
		{
		}
	}
}
