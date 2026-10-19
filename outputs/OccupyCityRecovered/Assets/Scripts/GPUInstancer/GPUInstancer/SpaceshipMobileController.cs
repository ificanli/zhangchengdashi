using Il2CppDummyDll;
using UnityEngine;

namespace GPUInstancer
{
	[Token(Token = "0x2000013")]
	public class SpaceshipMobileController : MonoBehaviour
	{
		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0x20")]
		public float engineTorque;

		[Token(Token = "0x40000C3")]
		[FieldOffset(Offset = "0x24")]
		public float enginePower;

		[Token(Token = "0x40000C4")]
		[FieldOffset(Offset = "0x28")]
		public SpaceshipMobileJoystick spaceShipJoystick;

		[Token(Token = "0x40000C5")]
		[FieldOffset(Offset = "0x30")]
		private Rigidbody shipRigidbody;

		[Token(Token = "0x40000C6")]
		[FieldOffset(Offset = "0x38")]
		private float rollInput;

		[Token(Token = "0x40000C7")]
		[FieldOffset(Offset = "0x3C")]
		private float thrustInput;

		[Token(Token = "0x40000C8")]
		[FieldOffset(Offset = "0x40")]
		private float pitchInput;

		[Token(Token = "0x40000C9")]
		[FieldOffset(Offset = "0x44")]
		private float yawInput;

		[Token(Token = "0x40000CA")]
		[FieldOffset(Offset = "0x48")]
		private ParticleSystem.EmissionModule engineThrusterEmission;

		[Token(Token = "0x40000CB")]
		[FieldOffset(Offset = "0x50")]
		private ParticleSystem.EmissionModule engineGlowEmission;

		[Token(Token = "0x40000CC")]
		[FieldOffset(Offset = "0x58")]
		private Light engineGlowLight;

		[Token(Token = "0x40000CD")]
		[FieldOffset(Offset = "0x60")]
		private float originalThrusterEmissionRate;

		[Token(Token = "0x40000CE")]
		[FieldOffset(Offset = "0x64")]
		private float originalGlowEmissionRate;

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x73B2364", Offset = "0x73AE364", VA = "0x73B2364")]
		private void Awake()
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x73B2548", Offset = "0x73AE548", VA = "0x73B2548")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x73B257C", Offset = "0x73AE57C", VA = "0x73B257C")]
		private void GetJoystickInput()
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x73B28E4", Offset = "0x73AE8E4", VA = "0x73B28E4")]
		public void SetRollInput(float rollInput)
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x73B28EC", Offset = "0x73AE8EC", VA = "0x73B28EC")]
		public void SetThrustInput(bool isThrusting)
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x73B25A4", Offset = "0x73AE5A4", VA = "0x73B25A4")]
		private void Move()
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x73B27B8", Offset = "0x73AE7B8", VA = "0x73B27B8")]
		private void AdjustThrusterEffects()
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x73B2914", Offset = "0x73AE914", VA = "0x73B2914")]
		public SpaceshipMobileController()
		{
		}
	}
}
