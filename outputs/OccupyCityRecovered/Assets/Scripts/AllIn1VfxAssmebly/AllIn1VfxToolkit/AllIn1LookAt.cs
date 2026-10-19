using Il2CppDummyDll;
using UnityEngine;

namespace AllIn1VfxToolkit
{
	[Token(Token = "0x200000A")]
	public class AllIn1LookAt : MonoBehaviour
	{
		[Token(Token = "0x200000B")]
		private enum FaceDirection
		{
			[Token(Token = "0x4000022")]
			Forward = 0,
			[Token(Token = "0x4000023")]
			Up = 1,
			[Token(Token = "0x4000024")]
			Right = 2
		}

		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool updateEveryFrame;

		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x21")]
		[Space]
		[Header("Choose Target")]
		[SerializeField]
		private bool targetIsMainCamera;

		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform target;

		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x30")]
		[Space]
		[Header("Look At Direction")]
		[SerializeField]
		private FaceDirection faceDirection;

		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private bool negateDirection;

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x3CEC02C", Offset = "0x3CE802C", VA = "0x3CEC02C")]
		private void Start()
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x3CEC3F0", Offset = "0x3CE83F0", VA = "0x3CEC3F0")]
		private void Update()
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x3CEC1E8", Offset = "0x3CE81E8", VA = "0x3CEC1E8")]
		private void LookAtCompute()
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x3CEC400", Offset = "0x3CE8400", VA = "0x3CEC400")]
		public AllIn1LookAt()
		{
		}
	}
}
