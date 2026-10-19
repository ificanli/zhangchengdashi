using Il2CppDummyDll;
using UnityEngine;

namespace DM
{
	[Token(Token = "0x2000D48")]
	public class AnimatorMatcher : MonoBehaviour
	{
		[Token(Token = "0x4005ED2")]
		[FieldOffset(Offset = "0x20")]
		private Animator anim;

		[Token(Token = "0x4005ED3")]
		[FieldOffset(Offset = "0x28")]
		private ControlManager control;

		[Token(Token = "0x4005ED4")]
		[FieldOffset(Offset = "0x30")]
		private Vector3 dPosition;

		[Token(Token = "0x4005ED5")]
		[FieldOffset(Offset = "0x3C")]
		private Vector3 vPosition;

		[Token(Token = "0x6005242")]
		[Address(RVA = "0x42FEDF0", Offset = "0x42FADF0", VA = "0x42FEDF0")]
		private void Start()
		{
		}

		[Token(Token = "0x6005243")]
		[Address(RVA = "0x42FEE6C", Offset = "0x42FAE6C", VA = "0x42FEE6C")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6005244")]
		[Address(RVA = "0x42FEF2C", Offset = "0x42FAF2C", VA = "0x42FEF2C")]
		public AnimatorMatcher()
		{
		}
	}
}
