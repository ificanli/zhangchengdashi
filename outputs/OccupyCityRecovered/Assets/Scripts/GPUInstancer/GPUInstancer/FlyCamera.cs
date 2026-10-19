using Il2CppDummyDll;
using UnityEngine;

namespace GPUInstancer
{
	[Token(Token = "0x200005A")]
	public class FlyCamera : MonoBehaviour
	{
		[Token(Token = "0x400037E")]
		[FieldOffset(Offset = "0x20")]
		public float mainSpeed;

		[Token(Token = "0x400037F")]
		[FieldOffset(Offset = "0x24")]
		public float shiftSpeed;

		[Token(Token = "0x4000380")]
		[FieldOffset(Offset = "0x28")]
		public float rotationSpeed;

		[Token(Token = "0x4000381")]
		[FieldOffset(Offset = "0x2C")]
		private Vector3 _inputVector;

		[Token(Token = "0x4000382")]
		[FieldOffset(Offset = "0x38")]
		private Vector3 _rotationEuler;

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x73F0CC0", Offset = "0x73ECCC0", VA = "0x73F0CC0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x73F0D60", Offset = "0x73ECD60", VA = "0x73F0D60")]
		private void Update()
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x73F0E54", Offset = "0x73ECE54", VA = "0x73F0E54")]
		private void CalculateInputVector()
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x73F0F84", Offset = "0x73ECF84", VA = "0x73F0F84")]
		public FlyCamera()
		{
		}
	}
}
