using System;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;

namespace andywiecko.BurstTriangulator.LowLevel.Unsafe
{
	[Token(Token = "0x200001B")]
	[BurstCompile]
	internal struct TriangulationJob<T, T2, TBig, TTransform, TUtils> : IJob where T : unmanaged, IComparable<T> where T2 : unmanaged where TBig : unmanaged, IComparable<TBig> where TTransform : unmanaged, ITransform<TTransform, T, T2> where TUtils : unmanaged, IUtils<T, T2, TBig>
	{
		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x0")]
		private NativeArray<T2> inputPositions;

		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x0")]
		[NativeDisableContainerSafetyRestriction]
		private NativeArray<int> constraints;

		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x0")]
		[NativeDisableContainerSafetyRestriction]
		private NativeArray<ConstraintType> constraintTypes;

		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x0")]
		[NativeDisableContainerSafetyRestriction]
		private NativeArray<T2> holeSeeds;

		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x0")]
		private NativeList<T2> outputPositions;

		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x0")]
		private NativeList<int> triangles;

		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x0")]
		private NativeList<int> halfedges;

		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x0")]
		private NativeList<HalfedgeState> constrainedHalfedges;

		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x0")]
		private NativeReference<Status> status;

		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x0")]
		private readonly Args args;

		[Token(Token = "0x600007D")]
		public TriangulationJob(InputData<T2> input, OutputData<T2> output, Args args)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED TriangulationJob..ctor RVA= Token=0x600007D");
}

		[Token(Token = "0x600007E")]
		public TriangulationJob(Triangulator<T2> @this)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED TriangulationJob..ctor RVA= Token=0x600007E");
}

		[Token(Token = "0x600007F")]
		public void Execute()
		{
		}
	}
}
