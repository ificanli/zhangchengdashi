using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GPUInstancer.CrowdAnimations
{
	[Serializable]
	[Token(Token = "0x2000027")]
	public class GPUICrowdPrototype : GPUInstancerPrefabPrototype
	{
		[Token(Token = "0x4000121")]
		[FieldOffset(Offset = "0xB8")]
		public GPUICrowdAnimationData animationData;

		[Token(Token = "0x4000122")]
		[FieldOffset(Offset = "0xC0")]
		public int frameRate;

		[Token(Token = "0x4000123")]
		[FieldOffset(Offset = "0xC4")]
		public AnimatorCullingMode animatorCullingMode;

		[Token(Token = "0x4000124")]
		[FieldOffset(Offset = "0xC8")]
		public string modelPrefabPath;

		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0xD0")]
		public bool hasNoAnimator;

		[Token(Token = "0x4000126")]
		[FieldOffset(Offset = "0xD8")]
		public List<AnimationClip> clipList;

		[Token(Token = "0x4000127")]
		[FieldOffset(Offset = "0xE0")]
		public bool hasOptionalRenderers;

		[NonSerialized]
		[Token(Token = "0x4000128")]
		[FieldOffset(Offset = "0xE1")]
		public bool isChildPrototype;

		[NonSerialized]
		[Token(Token = "0x4000129")]
		[FieldOffset(Offset = "0xE8")]
		public GPUICrowdPrototype parentPrototype;

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x73CB2D4", Offset = "0x73C72D4", VA = "0x73CB2D4")]
		public bool IsBakeRequired()
		{
			return default;
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x73CB3C4", Offset = "0x73C73C4", VA = "0x73CB3C4")]
		public GPUICrowdPrototype()
		{
		}
	}
}
