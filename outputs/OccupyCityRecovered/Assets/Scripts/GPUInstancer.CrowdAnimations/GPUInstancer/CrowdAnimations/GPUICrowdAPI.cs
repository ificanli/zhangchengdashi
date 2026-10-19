using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace GPUInstancer.CrowdAnimations
{
	[Token(Token = "0x2000018")]
	public static class GPUICrowdAPI
	{
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x73C1884", Offset = "0x73BD884", VA = "0x73C1884")]
		public static void StartAnimation(GPUICrowdPrefab crowdInstance, AnimationClip animationClip, float startTime = -1f, float speed = 1f, float transitionTime = 0f)
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x73C58D0", Offset = "0x73C18D0", VA = "0x73C58D0")]
		public static void StartAnimation(GPUICrowdPrefab crowdInstance, GPUIAnimationClipData clipData, float startTime = -1f, float speed = 1f, float transitionTime = 0f)
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x73C1898", Offset = "0x73BD898", VA = "0x73C1898")]
		public static void StartBlend(GPUICrowdPrefab crowdInstance, Vector4 animationWeights, AnimationClip animationClip1, AnimationClip animationClip2, [Optional] AnimationClip animationClip3, [Optional] AnimationClip animationClip4, [Optional] float[] animationTimes, [Optional] float[] animationSpeeds, float transitionTime = 0f)
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x73C18BC", Offset = "0x73BD8BC", VA = "0x73C18BC")]
		public static void SetAnimationWeights(GPUICrowdPrefab crowdInstance, Vector4 animationWeights)
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x73C06F4", Offset = "0x73BC6F4", VA = "0x73C06F4")]
		public static void SetAnimationSpeed(GPUICrowdPrefab crowdInstance, float animationSpeed)
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x73C5918", Offset = "0x73C1918", VA = "0x73C5918")]
		public static void SetAnimationSpeeds(GPUICrowdPrefab crowdInstance, float[] animationSpeeds)
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x73C592C", Offset = "0x73C192C", VA = "0x73C592C")]
		public static float GetAnimationTime(GPUICrowdPrefab crowdInstance, AnimationClip animationClip)
		{
			return default;
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x73C5940", Offset = "0x73C1940", VA = "0x73C5940")]
		public static void SetAnimationTime(GPUICrowdPrefab crowdInstance, AnimationClip animationClip, float time)
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x73C028C", Offset = "0x73BC28C", VA = "0x73C028C")]
		public static void SetAnimationSpeedsForPrototype(GPUICrowdManager crowdManager, GPUICrowdPrototype crowdPrototype, float animationSpeed)
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x73C5954", Offset = "0x73C1954", VA = "0x73C5954")]
		public static void SetAnimationSpeedsForPrototype(GPUICrowdManager crowdManager, GPUICrowdPrototype crowdPrototype, float[] animationSpeeds)
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x73C5B8C", Offset = "0x73C1B8C", VA = "0x73C5B8C")]
		public static void AddAnimationEvent(GPUICrowdManager crowdManager, GPUICrowdPrototype crowdPrototype, AnimationClip animationClip, int eventFrame, UnityAction<GPUICrowdPrefab, float, int, string> eventAction, [Optional][DefaultParameterValue(0f)] float floatParam, [Optional][DefaultParameterValue(0)] int intParam, [Optional] string stringParam)
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x73C5EFC", Offset = "0x73C1EFC", VA = "0x73C5EFC")]
		public static void AddAnimationEvent(GPUICrowdManager crowdManager, GPUIAnimationEvent animationEvent)
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x73C61A0", Offset = "0x73C21A0", VA = "0x73C61A0")]
		public static void ClearAnimationEvents(GPUICrowdManager crowdManager, GPUICrowdPrototype crowdPrototype)
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x73C626C", Offset = "0x73C226C", VA = "0x73C626C")]
		public static GPUICrowdPrototype DefineGameObjectAsCrowdPrototypeAtRuntime(GPUICrowdManager crowdManager, GameObject prototypeGameObject, GPUICrowdAnimationData animationData)
		{
			return null;
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x73C6288", Offset = "0x73C2288", VA = "0x73C6288")]
		public static void ChangeMaterial(GPUICrowdManager crowdManager, GPUInstancerPrototype prototype, Material material, int lodLevel = 0, int rendererIndex = 0, int subMeshIndex = 0)
		{
		}
	}
}
