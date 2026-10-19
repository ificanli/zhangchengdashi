using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Jobs;

namespace GPUInstancer.CrowdAnimations
{
	[Token(Token = "0x2000029")]
	[BurstCompile]
	internal struct ApplyBufferDataToTransformsJob : IJobParallelForTransform
	{
		[Token(Token = "0x4000149")]
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public NativeArray<Matrix4x4> boneTransformArray;

		[Token(Token = "0x400014A")]
		[FieldOffset(Offset = "0x10")]
		[ReadOnly]
		public NativeArray<Matrix4x4> bindPoses;

		[Token(Token = "0x400014B")]
		[FieldOffset(Offset = "0x20")]
		[ReadOnly]
		public NativeArray<int> boneUpdateFilter;

		[Token(Token = "0x400014C")]
		[FieldOffset(Offset = "0x30")]
		[ReadOnly]
		public int instanceCount;

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x73CE5F8", Offset = "0x73CA5F8", VA = "0x73CE5F8", Slot = "4")]
		public void Execute(int index, TransformAccess transform)
		{
		}
	}
}
