using Il2CppDummyDll;
using UnityEngine;

namespace Boxophobic.Utils
{
	[Token(Token = "0x2000DFD")]
	[RequireComponent(typeof(CharacterController))]
	public class FPSController : MonoBehaviour
	{
		[Token(Token = "0x40061BD")]
		[FieldOffset(Offset = "0x20")]
		public float walkingSpeed;

		[Token(Token = "0x40061BE")]
		[FieldOffset(Offset = "0x24")]
		public float lookSpeed;

		[Token(Token = "0x40061BF")]
		[FieldOffset(Offset = "0x28")]
		public float lookXLimit;

		[Token(Token = "0x40061C0")]
		[FieldOffset(Offset = "0x30")]
		[Space(10f)]
		public GameObject playerCamera;

		[Token(Token = "0x40061C1")]
		[FieldOffset(Offset = "0x38")]
		private CharacterController characterController;

		[Token(Token = "0x40061C2")]
		[FieldOffset(Offset = "0x40")]
		private float rotationX;

		[Token(Token = "0x600566E")]
		[Address(RVA = "0x433CA14", Offset = "0x4338A14", VA = "0x433CA14")]
		private void Start()
		{
		}

		[Token(Token = "0x600566F")]
		[Address(RVA = "0x433CA78", Offset = "0x4338A78", VA = "0x433CA78")]
		private void Update()
		{
		}

		[Token(Token = "0x6005670")]
		[Address(RVA = "0x433CE2C", Offset = "0x4338E2C", VA = "0x433CE2C")]
		public FPSController()
		{
		}
	}
}
