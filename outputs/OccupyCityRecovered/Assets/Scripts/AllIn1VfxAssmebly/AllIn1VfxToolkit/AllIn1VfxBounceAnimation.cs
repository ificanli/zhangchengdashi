using Il2CppDummyDll;
using UnityEngine;

namespace AllIn1VfxToolkit
{
	[Token(Token = "0x2000010")]
	public class AllIn1VfxBounceAnimation : MonoBehaviour
	{
		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector3 targetOffset;

		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float speed;

		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x30")]
		private Vector3 startPosition;

		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x3C")]
		private Vector3 animationMovementVector;

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x3CEC468", Offset = "0x3CE8468", VA = "0x3CEC468")]
		private void Start()
		{
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x3CEC498", Offset = "0x3CE8498", VA = "0x3CEC498")]
		private void Update()
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x3CEC520", Offset = "0x3CE8520", VA = "0x3CEC520")]
		public AllIn1VfxBounceAnimation()
		{
		}
	}
}
