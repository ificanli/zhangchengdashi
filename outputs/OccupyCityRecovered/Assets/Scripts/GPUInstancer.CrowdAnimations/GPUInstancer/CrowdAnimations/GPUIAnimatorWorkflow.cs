using Il2CppDummyDll;
using UnityEngine;

namespace GPUInstancer.CrowdAnimations
{
	[Token(Token = "0x2000019")]
	public abstract class GPUIAnimatorWorkflow
	{
		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x10")]
		public GPUIAnimationClipData[] currentAnimationClipData;

		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x18")]
		public Vector4 currentAnimationClipDataWeights;

		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x28")]
		public int activeClipCount;

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x73C6EAC", Offset = "0x73C2EAC", VA = "0x73C6EAC")]
		protected GPUIAnimatorWorkflow()
		{
		}
	}
}
