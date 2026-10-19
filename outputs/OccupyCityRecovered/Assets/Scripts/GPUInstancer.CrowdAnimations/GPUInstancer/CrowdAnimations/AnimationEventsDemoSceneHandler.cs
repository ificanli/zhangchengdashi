using Il2CppDummyDll;
using UnityEngine;

namespace GPUInstancer.CrowdAnimations
{
	[Token(Token = "0x200000A")]
	public class AnimationEventsDemoSceneHandler : MonoBehaviour
	{
		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x20")]
		public GPUICrowdManager gpuiCrowdManager;

		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x28")]
		public Transform spitPrefab;

		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x30")]
		private readonly Vector3 spitVector;

		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x3C")]
		private readonly Vector3 spitPosAdd;

		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x48")]
		private Transform[] _spits;

		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x50")]
		private Transform _spitsParent;

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x73BEE78", Offset = "0x73BAE78", VA = "0x73BEE78")]
		public void Spit(GPUICrowdPrefab crowdInstance, float floatParam, int intParam, string stringParam)
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x73BF254", Offset = "0x73BB254", VA = "0x73BF254")]
		public AnimationEventsDemoSceneHandler()
		{
		}
	}
}
