using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Jobs;

namespace GPUInstancer
{
	[Token(Token = "0x2000043")]
	[BurstCompile]
	public struct AutoUpdateTransformsJob : IJobParallelForTransform
	{
		[Token(Token = "0x4000312")]
		[FieldOffset(Offset = "0x0")]
		[WriteOnly]
		public NativeArray<Matrix4x4> instanceDataNativeArray;

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x73DE400", Offset = "0x73DA400", VA = "0x73DE400", Slot = "4")]
		public void Execute(int index, TransformAccess transform)
		{
		}
	}
}
