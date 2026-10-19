using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GPUInstancer.CrowdAnimations
{
	[Token(Token = "0x200001C")]
	public class GPUIMecanimAnimator : GPUIAnimatorWorkflow
	{
		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x30")]
		public GPUIAnimatorState animatorState;

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x73C9678", Offset = "0x73C5678", VA = "0x73C9678")]
		public GPUIMecanimAnimator()
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x73C9710", Offset = "0x73C5710", VA = "0x73C9710")]
		public void UpdateDataFromMecanimAnimator(GPUICrowdRuntimeData runtimeData, int arrayIndex, Animator animatorRef, List<AnimatorClipInfo> animatorClipInfos)
		{
		}
	}
}
