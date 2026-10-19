using Il2CppDummyDll;
using UnityEngine;

namespace GPUInstancer.CrowdAnimations
{
	[Token(Token = "0x200002B")]
	public class GPUICrowdTransition
	{
		[Token(Token = "0x4000155")]
		[FieldOffset(Offset = "0x10")]
		public int arrayIndex;

		[Token(Token = "0x4000156")]
		[FieldOffset(Offset = "0x14")]
		public float startTime;

		[Token(Token = "0x4000157")]
		[FieldOffset(Offset = "0x18")]
		public float totalTime;

		[Token(Token = "0x4000158")]
		[FieldOffset(Offset = "0x1C")]
		public int transitioningClipCount;

		[Token(Token = "0x4000159")]
		[FieldOffset(Offset = "0x20")]
		public Vector4 startWeights;

		[Token(Token = "0x400015A")]
		[FieldOffset(Offset = "0x30")]
		public Vector4 endWeights;

		[Token(Token = "0x400015B")]
		[FieldOffset(Offset = "0x40")]
		public int endActiveClipCount;

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x73C739C", Offset = "0x73C339C", VA = "0x73C739C")]
		public void SetData(int arrayIndex, float startTime, float totalTime, int transitioningClipCount, Vector4 startWeights, Vector4 endWeights, int endActiveClipCount)
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x73C7394", Offset = "0x73C3394", VA = "0x73C7394")]
		public GPUICrowdTransition()
		{
		}
	}
}
