using System;
using Il2CppDummyDll;

namespace GPUInstancer.CrowdAnimations
{
	[Serializable]
	[Token(Token = "0x2000020")]
	public struct GPUIAnimationClipData
	{
		[Token(Token = "0x40000CB")]
		[FieldOffset(Offset = "0x0")]
		public int clipIndex;

		[Token(Token = "0x40000CC")]
		[FieldOffset(Offset = "0x4")]
		public int clipStartFrame;

		[Token(Token = "0x40000CD")]
		[FieldOffset(Offset = "0x8")]
		public int clipFrameCount;

		[Token(Token = "0x40000CE")]
		[FieldOffset(Offset = "0xC")]
		public int hasRootMotion;

		[Token(Token = "0x40000CF")]
		[FieldOffset(Offset = "0x10")]
		public float length;

		[Token(Token = "0x40000D0")]
		[FieldOffset(Offset = "0x14")]
		public int isLoopDisabled;

		[Token(Token = "0x40000D1")]
		[FieldOffset(Offset = "0x18")]
		public int isClipLooping;

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x73C9648", Offset = "0x73C5648", VA = "0x73C9648")]
		public bool HasRootMotion()
		{
			return default;
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x73C4FAC", Offset = "0x73C0FAC", VA = "0x73C4FAC")]
		public bool IsLoopDisabled()
		{
			return default;
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x73C9F5C", Offset = "0x73C5F5C", VA = "0x73C9F5C")]
		public bool IsClipLooping()
		{
			return default;
		}
	}
}
