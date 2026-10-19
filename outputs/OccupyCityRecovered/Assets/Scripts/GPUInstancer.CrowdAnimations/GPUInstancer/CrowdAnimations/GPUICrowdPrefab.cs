using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GPUInstancer.CrowdAnimations
{
	[Token(Token = "0x2000036")]
	public class GPUICrowdPrefab : GPUInstancerPrefab
	{
		[NonSerialized]
		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public GPUICrowdRuntimeData runtimeData;

		[NonSerialized]
		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Animator animatorRef;

		[NonSerialized]
		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public GPUIMecanimAnimator mecanimAnimator;

		[NonSerialized]
		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public GPUICrowdAnimator crowdAnimator;

		[NonSerialized]
		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public bool hasChildPrefabs;

		[NonSerialized]
		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public List<GPUICrowdPrefab> childCrowdPrefabs;

		[NonSerialized]
		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public GPUICrowdPrefab parentCrowdPrefab;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public Transform[] exposedTransforms;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private bool _hasParentPrefab;

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x73D62D0", Offset = "0x73D22D0", VA = "0x73D62D0", Slot = "7")]
		public override void SetupPrefabInstance(GPUInstancerRuntimeData runtimeData, bool forceNew = false)
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x73D5B60", Offset = "0x73D1B60", VA = "0x73D5B60")]
		public Animator GetAnimator()
		{
			return null;
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x73D6B24", Offset = "0x73D2B24", VA = "0x73D6B24", Slot = "5")]
		public override Transform GetInstanceTransform(bool forceNew = false)
		{
			return null;
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x73D6C00", Offset = "0x73D2C00", VA = "0x73D6C00")]
		private bool EnsureCrowdAnimatorWritable()
		{
			return default;
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x73D6C48", Offset = "0x73D2C48", VA = "0x73D6C48")]
		public void StartAnimation(AnimationClip animationClip, float startTime = -1f, float speed = 1f, float transitionTime = 0f)
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x73D6D3C", Offset = "0x73D2D3C", VA = "0x73D6D3C")]
		public void StartAnimation(GPUIAnimationClipData clipData, float startTime = -1f, float speed = 1f, float transitionTime = 0f)
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x73D6E4C", Offset = "0x73D2E4C", VA = "0x73D6E4C")]
		public void StartBlend(Vector4 animationWeights, AnimationClip animationClip1, AnimationClip animationClip2, [Optional] AnimationClip animationClip3, [Optional] AnimationClip animationClip4, [Optional] float[] animationTimes, [Optional] float[] animationSpeeds, float transitionTime = 0f)
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x73D6FA0", Offset = "0x73D2FA0", VA = "0x73D6FA0")]
		public void SetAnimationWeights(Vector4 animationWeights)
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x73D7094", Offset = "0x73D3094", VA = "0x73D7094")]
		public void SetAnimationSpeed(float animationSpeed)
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x73D7160", Offset = "0x73D3160", VA = "0x73D7160")]
		public void SetAnimationSpeeds(float[] animationSpeeds)
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x73D721C", Offset = "0x73D321C", VA = "0x73D721C")]
		public float GetAnimationTime(AnimationClip animationClip)
		{
			return default;
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x73D7244", Offset = "0x73D3244", VA = "0x73D7244")]
		public void SetAnimationTime(AnimationClip animationClip, float time)
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x73D7318", Offset = "0x73D3318", VA = "0x73D7318")]
		public GPUICrowdPrefab()
		{
		}
	}
}
