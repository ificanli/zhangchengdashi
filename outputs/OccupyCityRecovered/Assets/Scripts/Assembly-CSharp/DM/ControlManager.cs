using Il2CppDummyDll;
using UnityEngine;

namespace DM
{
	[Token(Token = "0x2000D4A")]
	public class ControlManager : MonoBehaviour
	{
		[Token(Token = "0x4005EE6")]
		[FieldOffset(Offset = "0x20")]
		[Header("Initialize")]
		public GameObject activeModel;

		[Token(Token = "0x4005EE7")]
		[FieldOffset(Offset = "0x28")]
		public string[] randomAttacks;

		[Token(Token = "0x4005EE8")]
		[FieldOffset(Offset = "0x30")]
		[Header("Inputs")]
		public float vertical;

		[Token(Token = "0x4005EE9")]
		[FieldOffset(Offset = "0x34")]
		public float horizontal;

		[Token(Token = "0x4005EEA")]
		[FieldOffset(Offset = "0x38")]
		public float moveAmount;

		[Token(Token = "0x4005EEB")]
		[FieldOffset(Offset = "0x3C")]
		public Vector3 moveDir;

		[Token(Token = "0x4005EEC")]
		[FieldOffset(Offset = "0x48")]
		[Header("Stats")]
		public float moveSpeed;

		[Token(Token = "0x4005EED")]
		[FieldOffset(Offset = "0x4C")]
		public float sprintSpeed;

		[Token(Token = "0x4005EEE")]
		[FieldOffset(Offset = "0x50")]
		public float rotateSpeed;

		[Token(Token = "0x4005EEF")]
		[FieldOffset(Offset = "0x54")]
		public float jumpForce;

		[Token(Token = "0x4005EF0")]
		[FieldOffset(Offset = "0x58")]
		[Header("States")]
		public bool onGround;

		[Token(Token = "0x4005EF1")]
		[FieldOffset(Offset = "0x59")]
		public bool sprint;

		[Token(Token = "0x4005EF2")]
		[FieldOffset(Offset = "0x5A")]
		[HideInInspector]
		public bool jump;

		[Token(Token = "0x4005EF3")]
		[FieldOffset(Offset = "0x5B")]
		[HideInInspector]
		public bool normalAttack;

		[Token(Token = "0x4005EF4")]
		[FieldOffset(Offset = "0x5C")]
		[HideInInspector]
		public bool comboAttack;

		[Token(Token = "0x4005EF5")]
		[FieldOffset(Offset = "0x5D")]
		public bool canMove;

		[Token(Token = "0x4005EF6")]
		[FieldOffset(Offset = "0x5E")]
		[HideInInspector]
		public bool roll;

		[Token(Token = "0x4005EF7")]
		[FieldOffset(Offset = "0x60")]
		private float fixedDelta;

		[Token(Token = "0x4005EF8")]
		[FieldOffset(Offset = "0x64")]
		private float delta;

		[Token(Token = "0x4005EF9")]
		[FieldOffset(Offset = "0x68")]
		private Animator anim;

		[Token(Token = "0x4005EFA")]
		[FieldOffset(Offset = "0x70")]
		[HideInInspector]
		public Rigidbody rigid;

		[Token(Token = "0x4005EFB")]
		[FieldOffset(Offset = "0x78")]
		private CameraManager camManager;

		[Token(Token = "0x600524B")]
		[Address(RVA = "0x42FF34C", Offset = "0x42FB34C", VA = "0x42FF34C")]
		private void Start()
		{
		}

		[Token(Token = "0x600524C")]
		[Address(RVA = "0x42FF3E8", Offset = "0x42FB3E8", VA = "0x42FF3E8")]
		private void SetupAnimator()
		{
		}

		[Token(Token = "0x600524D")]
		[Address(RVA = "0x42FF54C", Offset = "0x42FB54C", VA = "0x42FF54C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600524E")]
		[Address(RVA = "0x42FF724", Offset = "0x42FB724", VA = "0x42FF724")]
		private void Update()
		{
		}

		[Token(Token = "0x600524F")]
		[Address(RVA = "0x42FF73C", Offset = "0x42FB73C", VA = "0x42FF73C")]
		private void GetInput()
		{
		}

		[Token(Token = "0x6005250")]
		[Address(RVA = "0x42FF890", Offset = "0x42FB890", VA = "0x42FF890")]
		private void UpdateStates()
		{
		}

		[Token(Token = "0x6005251")]
		[Address(RVA = "0x42FF580", Offset = "0x42FB580", VA = "0x42FF580")]
		private void FixedTick(float d)
		{
		}

		[Token(Token = "0x6005252")]
		[Address(RVA = "0x42FFC00", Offset = "0x42FBC00", VA = "0x42FFC00")]
		private void HandleMovementAnimations()
		{
		}

		[Token(Token = "0x6005253")]
		[Address(RVA = "0x42FFCB4", Offset = "0x42FBCB4", VA = "0x42FFCB4")]
		private void OnTriggerStay(Collider collision)
		{
		}

		[Token(Token = "0x6005254")]
		[Address(RVA = "0x42FFD64", Offset = "0x42FBD64", VA = "0x42FFD64")]
		private void OnTriggerExit(Collider collision)
		{
		}

		[Token(Token = "0x6005255")]
		[Address(RVA = "0x42FFE10", Offset = "0x42FBE10", VA = "0x42FFE10")]
		public ControlManager()
		{
		}
	}
}
