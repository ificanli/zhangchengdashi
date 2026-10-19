using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Jobs;

namespace GPUInstancer.CrowdAnimations
{
	[Token(Token = "0x200001B")]
	[BurstCompile]
	internal struct ApplyCrowdAnimatorRootMotionJob : IJobParallelForTransform
	{
		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public float currentTime;

		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x4")]
		[ReadOnly]
		public float lerpAmount;

		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x8")]
		[ReadOnly]
		public NativeArray<Vector4> animationData;

		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x18")]
		[ReadOnly]
		public NativeArray<Vector4> crowdAnimatorControllerData;

		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0x28")]
		[ReadOnly]
		public NativeArray<GPUIAnimationClipData> clipDatas;

		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0x38")]
		[ReadOnly]
		public NativeArray<GPUIRootMotion> rootMotions;

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x73C915C", Offset = "0x73C515C", VA = "0x73C915C", Slot = "4")]
		public void Execute(int index, TransformAccess transformAccess)
		{
		}
	}
}
