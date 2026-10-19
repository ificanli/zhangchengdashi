using Il2CppDummyDll;
using UnityEngine;

namespace GPUInstancer
{
	[Token(Token = "0x2000021")]
	public class GrassMowerController : MonoBehaviour
	{
		[Token(Token = "0x400012D")]
		[FieldOffset(Offset = "0x20")]
		public float engineTorque;

		[Token(Token = "0x400012E")]
		[FieldOffset(Offset = "0x24")]
		public float enginePower;

		[Token(Token = "0x400012F")]
		[FieldOffset(Offset = "0x28")]
		private Rigidbody grassMowerRigidbody;

		[Token(Token = "0x4000130")]
		[FieldOffset(Offset = "0x30")]
		private float thrustInput;

		[Token(Token = "0x4000131")]
		[FieldOffset(Offset = "0x34")]
		private float yawInput;

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x73B688C", Offset = "0x73B288C", VA = "0x73B688C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x73B68DC", Offset = "0x73B28DC", VA = "0x73B68DC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x73B68F4", Offset = "0x73B28F4", VA = "0x73B68F4")]
		private void GetInputs()
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x73B6970", Offset = "0x73B2970", VA = "0x73B6970")]
		private void Move()
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x73B6A98", Offset = "0x73B2A98", VA = "0x73B6A98")]
		public GrassMowerController()
		{
		}
	}
}
