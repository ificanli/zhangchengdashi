using Il2CppDummyDll;
using UnityEngine;

namespace GPUInstancer
{
	[Token(Token = "0x200001D")]
	[RequireComponent(typeof(CharacterController))]
	public class FPController : MonoBehaviour
	{
		[Token(Token = "0x400010E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		public float m_WalkSpeed;

		[Token(Token = "0x400010F")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		public float m_RunSpeed;

		[Token(Token = "0x4000110")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		public float m_JumpSpeed;

		[Token(Token = "0x4000111")]
		[FieldOffset(Offset = "0x2C")]
		private bool m_IsWalking;

		[Token(Token = "0x4000112")]
		[FieldOffset(Offset = "0x30")]
		private MouseLook m_MouseLook;

		[Token(Token = "0x4000113")]
		[FieldOffset(Offset = "0x38")]
		private Camera m_Camera;

		[Token(Token = "0x4000114")]
		[FieldOffset(Offset = "0x40")]
		private bool m_Jump;

		[Token(Token = "0x4000115")]
		[FieldOffset(Offset = "0x44")]
		private float m_YRotation;

		[Token(Token = "0x4000116")]
		[FieldOffset(Offset = "0x48")]
		private Vector2 m_Input;

		[Token(Token = "0x4000117")]
		[FieldOffset(Offset = "0x50")]
		private Vector3 m_MoveDir;

		[Token(Token = "0x4000118")]
		[FieldOffset(Offset = "0x60")]
		private CharacterController m_CharacterController;

		[Token(Token = "0x4000119")]
		[FieldOffset(Offset = "0x68")]
		private CollisionFlags m_CollisionFlags;

		[Token(Token = "0x400011A")]
		[FieldOffset(Offset = "0x6C")]
		private bool m_PreviouslyGrounded;

		[Token(Token = "0x400011B")]
		[FieldOffset(Offset = "0x6D")]
		private bool m_Jumping;

		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0x70")]
		private float m_StickToGroundForce;

		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0x74")]
		private float m_GravityMultiplier;

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x73B5810", Offset = "0x73B1810", VA = "0x73B5810")]
		private void Start()
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x73B5988", Offset = "0x73B1988", VA = "0x73B5988")]
		private void Update()
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x73B5AB4", Offset = "0x73B1AB4", VA = "0x73B5AB4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x73B5ECC", Offset = "0x73B1ECC", VA = "0x73B5ECC")]
		private void GetInput(out float speed)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED FPController.GetInput RVA=0x73B5ECC Token=0x60000A7");
}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x73B5A64", Offset = "0x73B1A64", VA = "0x73B5A64")]
		private void RotateView()
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x73B63AC", Offset = "0x73B23AC", VA = "0x73B63AC")]
		private void OnControllerColliderHit(ControllerColliderHit hit)
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x73B64D0", Offset = "0x73B24D0", VA = "0x73B64D0")]
		public FPController()
		{
		}
	}
}
