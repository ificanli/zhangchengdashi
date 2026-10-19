using Il2CppDummyDll;
using UnityEngine;

namespace EpicToonFX
{
	[Token(Token = "0x2000DEA")]
	public class ETFXRotation : MonoBehaviour
	{
		[Token(Token = "0x2000DEB")]
		public enum spaceEnum
		{
			[Token(Token = "0x4006190")]
			Local = 0,
			[Token(Token = "0x4006191")]
			World = 1
		}

		[Token(Token = "0x400618D")]
		[FieldOffset(Offset = "0x20")]
		[Header("Rotate axises by degrees per second")]
		public Vector3 rotateVector;

		[Token(Token = "0x400618E")]
		[FieldOffset(Offset = "0x2C")]
		public spaceEnum rotateSpace;

		[Token(Token = "0x6005646")]
		[Address(RVA = "0x433BB58", Offset = "0x4337B58", VA = "0x433BB58")]
		private void Start()
		{
		}

		[Token(Token = "0x6005647")]
		[Address(RVA = "0x433BB5C", Offset = "0x4337B5C", VA = "0x433BB5C")]
		private void Update()
		{
		}

		[Token(Token = "0x6005648")]
		[Address(RVA = "0x433BC28", Offset = "0x4337C28", VA = "0x433BC28")]
		public ETFXRotation()
		{
		}
	}
}
