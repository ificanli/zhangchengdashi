using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace AnimationInstancing
{
	[Token(Token = "0x2000F56")]
	public class AnimationInfo
	{
		[Token(Token = "0x40069E2")]
		[FieldOffset(Offset = "0x10")]
		public string animationName;

		[Token(Token = "0x40069E3")]
		[FieldOffset(Offset = "0x18")]
		public int animationNameHash;

		[Token(Token = "0x40069E4")]
		[FieldOffset(Offset = "0x1C")]
		public int totalFrame;

		[Token(Token = "0x40069E5")]
		[FieldOffset(Offset = "0x20")]
		public int fps;

		[Token(Token = "0x40069E6")]
		[FieldOffset(Offset = "0x24")]
		public int animationIndex;

		[Token(Token = "0x40069E7")]
		[FieldOffset(Offset = "0x28")]
		public int textureIndex;

		[Token(Token = "0x40069E8")]
		[FieldOffset(Offset = "0x2C")]
		public bool rootMotion;

		[Token(Token = "0x40069E9")]
		[FieldOffset(Offset = "0x30")]
		public WrapMode wrapMode;

		[Token(Token = "0x40069EA")]
		[FieldOffset(Offset = "0x38")]
		public Vector3[] velocity;

		[Token(Token = "0x40069EB")]
		[FieldOffset(Offset = "0x40")]
		public Vector3[] angularVelocity;

		[Token(Token = "0x40069EC")]
		[FieldOffset(Offset = "0x48")]
		public List<AnimationEvent> eventList;

		[Token(Token = "0x6005BCF")]
		[Address(RVA = "0x43A0DDC", Offset = "0x439CDDC", VA = "0x43A0DDC")]
		public AnimationInfo()
		{
		}
	}
}
