using System;
using Il2CppDummyDll;

namespace GPUInstancer.CrowdAnimations
{
	[Serializable]
	[Token(Token = "0x2000024")]
	public class GPUIAnimatorState
	{
		[Token(Token = "0x40000E3")]
		[FieldOffset(Offset = "0x10")]
		public string fullPathName;

		[Token(Token = "0x40000E4")]
		[FieldOffset(Offset = "0x18")]
		public int hashCode;

		[Token(Token = "0x40000E5")]
		[FieldOffset(Offset = "0x1C")]
		public float cycleOffset;

		[Token(Token = "0x40000E6")]
		[FieldOffset(Offset = "0x20")]
		public bool isBlend;

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x73CA64C", Offset = "0x73C664C", VA = "0x73CA64C")]
		public GPUIAnimatorState()
		{
		}
	}
}
