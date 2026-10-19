using Il2CppDummyDll;
using UnityEngine;

namespace GPUInstancer
{
	[Token(Token = "0x2000024")]
	public class SpaceshipController : MonoBehaviour
	{
		[Token(Token = "0x4000143")]
		[FieldOffset(Offset = "0x20")]
		public float engineTorque;

		[Token(Token = "0x4000144")]
		[FieldOffset(Offset = "0x24")]
		public float enginePower;

		[Token(Token = "0x4000145")]
		[FieldOffset(Offset = "0x28")]
		private Rigidbody shipRigidbody;

		[Token(Token = "0x4000146")]
		[FieldOffset(Offset = "0x30")]
		private float rollInput;

		[Token(Token = "0x4000147")]
		[FieldOffset(Offset = "0x34")]
		private float thrustInput;

		[Token(Token = "0x4000148")]
		[FieldOffset(Offset = "0x38")]
		private float pitchInput;

		[Token(Token = "0x4000149")]
		[FieldOffset(Offset = "0x3C")]
		private float yawInput;

		[Token(Token = "0x400014A")]
		[FieldOffset(Offset = "0x40")]
		private ParticleSystem.EmissionModule engineThrusterEmission;

		[Token(Token = "0x400014B")]
		[FieldOffset(Offset = "0x48")]
		private ParticleSystem.EmissionModule engineGlowEmission;

		[Token(Token = "0x400014C")]
		[FieldOffset(Offset = "0x50")]
		private Light engineGlowLight;

		[Token(Token = "0x400014D")]
		[FieldOffset(Offset = "0x58")]
		private float originalThrusterEmissionRate;

		[Token(Token = "0x400014E")]
		[FieldOffset(Offset = "0x5C")]
		private float originalGlowEmissionRate;

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x73B7470", Offset = "0x73B3470", VA = "0x73B7470")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x73B7654", Offset = "0x73B3654", VA = "0x73B7654")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x73B7674", Offset = "0x73B3674", VA = "0x73B7674")]
		private void GetInputs()
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x73B7748", Offset = "0x73B3748", VA = "0x73B7748")]
		private void Move()
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x73B795C", Offset = "0x73B395C", VA = "0x73B795C")]
		private void AdjustThrusterEffects()
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x73B7A88", Offset = "0x73B3A88", VA = "0x73B7A88")]
		public SpaceshipController()
		{
		}
	}
}
