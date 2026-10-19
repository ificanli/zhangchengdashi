using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Jobs;

namespace GPUInstancer.CrowdAnimations
{
	[Token(Token = "0x200002A")]
	[BurstCompile]
	internal struct ApplyBoneUpdatesJob : IJobParallelForTransform
	{
		[Token(Token = "0x400014D")]
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public NativeArray<Matrix4x4> bindPoses;

		[Token(Token = "0x400014E")]
		[FieldOffset(Offset = "0x10")]
		[ReadOnly]
		public NativeArray<int> boneUpdateFilter;

		[Token(Token = "0x400014F")]
		[FieldOffset(Offset = "0x20")]
		[ReadOnly]
		public NativeArray<Vector4> animationData;

		[Token(Token = "0x4000150")]
		[FieldOffset(Offset = "0x30")]
		[ReadOnly]
		public NativeArray<Vector4> crowdAnimatorControllerData;

		[Token(Token = "0x4000151")]
		[FieldOffset(Offset = "0x40")]
		[ReadOnly]
		public NativeArray<Matrix4x4> bakedAnimationData;

		[Token(Token = "0x4000152")]
		[FieldOffset(Offset = "0x50")]
		[ReadOnly]
		public float currentTime;

		[Token(Token = "0x4000153")]
		[FieldOffset(Offset = "0x54")]
		[ReadOnly]
		public int frameRate;

		[Token(Token = "0x4000154")]
		[FieldOffset(Offset = "0x58")]
		[ReadOnly]
		public int instanceCount;

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x73CE734", Offset = "0x73CA734", VA = "0x73CE734", Slot = "4")]
		public void Execute(int index, TransformAccess transform)
		{
		}
	}
}
