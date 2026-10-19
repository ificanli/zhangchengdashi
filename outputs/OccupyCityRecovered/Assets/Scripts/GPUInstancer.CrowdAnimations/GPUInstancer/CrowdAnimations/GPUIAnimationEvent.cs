using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace GPUInstancer.CrowdAnimations
{
	[Serializable]
	[Token(Token = "0x200002C")]
	public class GPUIAnimationEvent : UnityEvent<GPUICrowdPrefab, float, int, string>
	{
		[Token(Token = "0x400015C")]
		[FieldOffset(Offset = "0x30")]
		public GPUICrowdPrototype prototype;

		[Token(Token = "0x400015D")]
		[FieldOffset(Offset = "0x38")]
		public AnimationClip animationClip;

		[Token(Token = "0x400015E")]
		[FieldOffset(Offset = "0x40")]
		public int eventFrame;

		[Token(Token = "0x400015F")]
		[FieldOffset(Offset = "0x44")]
		public float floatParam;

		[Token(Token = "0x4000160")]
		[FieldOffset(Offset = "0x48")]
		public int intParam;

		[Token(Token = "0x4000161")]
		[FieldOffset(Offset = "0x50")]
		public string stringParam;

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x73CEF64", Offset = "0x73CAF64", VA = "0x73CEF64")]
		public GPUIAnimationEvent()
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x73C5E9C", Offset = "0x73C1E9C", VA = "0x73C5E9C")]
		public GPUIAnimationEvent(GPUICrowdPrototype prototype, AnimationClip animationClip)
		{
		}
	}
}
