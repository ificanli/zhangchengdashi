using Il2CppDummyDll;
using UnityEngine;

namespace AnimationInstancing
{
	[Token(Token = "0x2000F57")]
	public class ExtraBoneInfo
	{
		[Token(Token = "0x40069ED")]
		[FieldOffset(Offset = "0x10")]
		public string[] extraBone;

		[Token(Token = "0x40069EE")]
		[FieldOffset(Offset = "0x18")]
		public Matrix4x4[] extraBindPose;

		[Token(Token = "0x6005BD0")]
		[Address(RVA = "0x43A0DE4", Offset = "0x439CDE4", VA = "0x43A0DE4")]
		public ExtraBoneInfo()
		{
		}
	}
}
