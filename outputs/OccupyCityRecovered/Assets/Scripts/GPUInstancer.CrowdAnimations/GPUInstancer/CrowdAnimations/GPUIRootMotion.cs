using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GPUInstancer.CrowdAnimations
{
	[Serializable]
	[Token(Token = "0x2000023")]
	public struct GPUIRootMotion
	{
		[Token(Token = "0x40000E0")]
		[FieldOffset(Offset = "0x0")]
		public int hasMotion;

		[Token(Token = "0x40000E1")]
		[FieldOffset(Offset = "0x4")]
		public int isPositionOnly;

		[Token(Token = "0x40000E2")]
		[FieldOffset(Offset = "0x8")]
		public Matrix4x4 motionMatrix;

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x73C9658", Offset = "0x73C5658", VA = "0x73C9658")]
		public bool HasMotion()
		{
			return default;
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x73C9668", Offset = "0x73C5668", VA = "0x73C9668")]
		public bool IsPositionOnly()
		{
			return default;
		}
	}
}
