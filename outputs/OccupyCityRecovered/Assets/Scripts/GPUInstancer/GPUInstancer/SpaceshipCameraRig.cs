using Il2CppDummyDll;
using UnityEngine;

namespace GPUInstancer
{
	[Token(Token = "0x2000023")]
	public class SpaceshipCameraRig : MonoBehaviour
	{
		[Token(Token = "0x4000134")]
		[FieldOffset(Offset = "0x20")]
		public Transform m_Target;

		[Token(Token = "0x4000135")]
		[FieldOffset(Offset = "0x28")]
		public float m_MoveSpeed;

		[Token(Token = "0x4000136")]
		[FieldOffset(Offset = "0x2C")]
		public float m_TurnSpeed;

		[Token(Token = "0x4000137")]
		[FieldOffset(Offset = "0x30")]
		public float m_RollSpeed;

		[Token(Token = "0x4000138")]
		[FieldOffset(Offset = "0x34")]
		public bool m_FollowVelocity;

		[Token(Token = "0x4000139")]
		[FieldOffset(Offset = "0x35")]
		public bool m_FollowTilt;

		[Token(Token = "0x400013A")]
		[FieldOffset(Offset = "0x38")]
		public float m_SpinTurnLimit;

		[Token(Token = "0x400013B")]
		[FieldOffset(Offset = "0x3C")]
		public float m_TargetVelocityLowerLimit;

		[Token(Token = "0x400013C")]
		[FieldOffset(Offset = "0x40")]
		public float m_SmoothTurnTime;

		[Token(Token = "0x400013D")]
		[FieldOffset(Offset = "0x44")]
		private Vector3 m_LastTargetPosition;

		[Token(Token = "0x400013E")]
		[FieldOffset(Offset = "0x50")]
		private Rigidbody targetRigidbody;

		[Token(Token = "0x400013F")]
		[FieldOffset(Offset = "0x58")]
		private float m_LastFlatAngle;

		[Token(Token = "0x4000140")]
		[FieldOffset(Offset = "0x5C")]
		private float m_CurrentTurnAmount;

		[Token(Token = "0x4000141")]
		[FieldOffset(Offset = "0x60")]
		private float m_TurnSpeedVelocityChange;

		[Token(Token = "0x4000142")]
		[FieldOffset(Offset = "0x64")]
		private Vector3 m_RollUp;

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x73B6D30", Offset = "0x73B2D30", VA = "0x73B6D30")]
		private void Start()
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x73B6DC4", Offset = "0x73B2DC4", VA = "0x73B6DC4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x73B6DE0", Offset = "0x73B2DE0", VA = "0x73B6DE0")]
		private void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x73B73E4", Offset = "0x73B33E4", VA = "0x73B73E4")]
		public SpaceshipCameraRig()
		{
		}
	}
}
