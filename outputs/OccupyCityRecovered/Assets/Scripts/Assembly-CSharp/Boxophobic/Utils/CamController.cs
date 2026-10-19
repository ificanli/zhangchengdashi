using Il2CppDummyDll;
using UnityEngine;

namespace Boxophobic.Utils
{
	[Token(Token = "0x2000DFC")]
	public class CamController : MonoBehaviour
	{
		[Token(Token = "0x40061B8")]
		[FieldOffset(Offset = "0x20")]
		public float movementSpeed;

		[Token(Token = "0x40061B9")]
		[FieldOffset(Offset = "0x24")]
		public float accelerationMultiplier;

		[Token(Token = "0x40061BA")]
		[FieldOffset(Offset = "0x28")]
		public float sensitivity;

		[Token(Token = "0x40061BB")]
		[FieldOffset(Offset = "0x2C")]
		private float yaw;

		[Token(Token = "0x40061BC")]
		[FieldOffset(Offset = "0x30")]
		private float pitch;

		[Token(Token = "0x600566B")]
		[Address(RVA = "0x433C7F4", Offset = "0x43387F4", VA = "0x433C7F4")]
		private void Start()
		{
		}

		[Token(Token = "0x600566C")]
		[Address(RVA = "0x433C83C", Offset = "0x433883C", VA = "0x433C83C")]
		private void Update()
		{
		}

		[Token(Token = "0x600566D")]
		[Address(RVA = "0x433C9F8", Offset = "0x43389F8", VA = "0x433C9F8")]
		public CamController()
		{
		}
	}
}
