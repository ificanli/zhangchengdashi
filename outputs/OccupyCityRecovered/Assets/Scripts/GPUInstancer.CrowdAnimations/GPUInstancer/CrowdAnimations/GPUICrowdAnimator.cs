using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GPUInstancer.CrowdAnimations
{
	[Token(Token = "0x200001A")]
	public class GPUICrowdAnimator : GPUIAnimatorWorkflow
	{
		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector4 currentClipStartTimes;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public GPUIAnimationClipData[] newAnimationClipData;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector4 newClipStartTimes;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float[] currentClipSpeeds;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public GPUICrowdTransition transition;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public int transitionIndex;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Vector4 DEFAULT_WEIGHT;

		[Token(Token = "0x17000005")]
		public bool isInTransition
		{
			[Token(Token = "0x600006D")]
			[Address(RVA = "0x73C18AC", Offset = "0x73BD8AC", VA = "0x73C18AC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x73BE148", Offset = "0x73BA148", VA = "0x73BE148")]
		public GPUICrowdAnimator()
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x73C6EB4", Offset = "0x73C2EB4", VA = "0x73C6EB4")]
		public void ResetAnimator()
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x73C6FB8", Offset = "0x73C2FB8", VA = "0x73C6FB8")]
		public void StartAnimation(GPUICrowdRuntimeData runtimeData, int arrayIndex, AnimationClip animationClip, float startTime = -1f, float speed = 1f, float transitionTime = 0f)
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x73C7118", Offset = "0x73C3118", VA = "0x73C7118")]
		private static bool ValidateArrayIndexForCrowdAnimator(GPUICrowdRuntimeData runtimeData, int arrayIndex)
		{
			return default;
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x73BD994", Offset = "0x73B9994", VA = "0x73BD994")]
		public void StartAnimation(GPUICrowdRuntimeData runtimeData, int arrayIndex, GPUIAnimationClipData clipData, float startTime = -1f, float speed = 1f, float transitionTime = 0f)
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x73C77DC", Offset = "0x73C37DC", VA = "0x73C77DC")]
		public void StartBlend(GPUICrowdRuntimeData runtimeData, int arrayIndex, Vector4 animationWeights, AnimationClip animationClip1, AnimationClip animationClip2, [Optional] AnimationClip animationClip3, [Optional] AnimationClip animationClip4, [Optional] float[] animationTimes, [Optional] float[] animationSpeeds, float transitionTime = 0f)
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x73C79C8", Offset = "0x73C39C8", VA = "0x73C79C8")]
		public void StartBlend(GPUICrowdRuntimeData runtimeData, int arrayIndex, Vector4 animationWeights, GPUIAnimationClipData clipData1, GPUIAnimationClipData clipData2, GPUIAnimationClipData clipData3, GPUIAnimationClipData clipData4, [Optional] float[] animationTimes, [Optional] float[] animationSpeeds, float transitionTime = 0f)
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x73C2E9C", Offset = "0x73BEE9C", VA = "0x73C2E9C")]
		public void SetAnimationSpeed(GPUICrowdRuntimeData runtimeData, int arrayIndex, float animationSpeed)
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x73C8434", Offset = "0x73C4434", VA = "0x73C8434")]
		public void SetAnimationSpeeds(GPUICrowdRuntimeData runtimeData, int arrayIndex, float[] animationSpeeds)
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x73C871C", Offset = "0x73C471C", VA = "0x73C871C")]
		public void SetAnimationWeights(GPUICrowdRuntimeData runtimeData, int arrayIndex, Vector4 animationWeights)
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x73C7190", Offset = "0x73C3190", VA = "0x73C7190")]
		public void RemoveFromTransitioningAnimatorsSwapBack(GPUICrowdRuntimeData runtimeData)
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x73C87F0", Offset = "0x73C47F0", VA = "0x73C87F0")]
		public bool ApplyTransition(GPUICrowdRuntimeData runtimeData, float currentTime)
		{
			return default;
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x73C7338", Offset = "0x73C3338", VA = "0x73C7338")]
		public void CompleteTransition(GPUICrowdRuntimeData runtimeData)
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x73C8918", Offset = "0x73C4918", VA = "0x73C8918")]
		public void ApplyAnimationEvents(GPUICrowdRuntimeData runtimeData, GPUICrowdPrefab crowdInstance, float currentTime, float deltaTime)
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x73C8CC4", Offset = "0x73C4CC4", VA = "0x73C8CC4")]
		public float GetClipTime(GPUICrowdRuntimeData runtimeData, AnimationClip animationClip)
		{
			return default;
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x73C83B8", Offset = "0x73C43B8", VA = "0x73C83B8")]
		public float GetClipTime(GPUIAnimationClipData clipData)
		{
			return default;
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x73C8E20", Offset = "0x73C4E20", VA = "0x73C8E20")]
		public float GetClipTotalTime(int clipIndex, float currentTime)
		{
			return default;
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x73C8C68", Offset = "0x73C4C68", VA = "0x73C8C68")]
		public float GetClipFrame(int clipIndex, float currentTime, float clipLength, int clipFrameCount, bool isLoopDisabled)
		{
			return default;
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x73C8EE4", Offset = "0x73C4EE4", VA = "0x73C8EE4")]
		public static float GetClipFrame(float clipTotalTime, float clipLength, int clipFrameCount, bool isLoopDisabled)
		{
			return default;
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x73C8F24", Offset = "0x73C4F24", VA = "0x73C8F24")]
		public void SetClipTime(GPUICrowdRuntimeData runtimeData, int arrayIndex, AnimationClip animationClip, float time)
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x73C2A10", Offset = "0x73BEA10", VA = "0x73C2A10")]
		public void SetClipTime(GPUICrowdRuntimeData runtimeData, int arrayIndex, GPUIAnimationClipData clipData, float time)
		{
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x73C906C", Offset = "0x73C506C", VA = "0x73C906C")]
		public void UpdateIndex(GPUICrowdRuntimeData runtimeData, int arrayIndex)
		{
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x73C78D4", Offset = "0x73C38D4", VA = "0x73C78D4")]
		public GPUIAnimationClipData GetClipData(GPUICrowdRuntimeData runtimeData, AnimationClip animationClip)
		{
			return default;
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x73C73C0", Offset = "0x73C33C0", VA = "0x73C73C0")]
		private void BlendAnimations(GPUICrowdRuntimeData runtimeData, int arrayIndex, bool hasTransition = false)
		{
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x73C7360", Offset = "0x73C3360", VA = "0x73C7360")]
		private float GetSpeedRelativeStartTime(float currentTime, float previousStartTime, float previousSpeed, float clipLength, float newSpeed)
		{
			return default;
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x73C72C8", Offset = "0x73C32C8", VA = "0x73C72C8")]
		private int GetCurrentClipIndex(GPUIAnimationClipData clipData)
		{
			return default;
		}
	}
}
