using Il2CppDummyDll;
using Pathfinding;
using UnityEngine;

namespace GameModule
{
	[Token(Token = "0x20004D9")]
	public class CitizenBehaviour : MonoBehaviour
	{
		[Token(Token = "0x4002C7A")]
		[FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x4002C7B")]
		[FieldOffset(Offset = "0x28")]
		private AIPath aiPath;

		[Token(Token = "0x4002C7C")]
		[FieldOffset(Offset = "0x30")]
		private AIDestinationSetter aiDestination;

		[Token(Token = "0x4002C7D")]
		[FieldOffset(Offset = "0x38")]
		public int state;

		[Token(Token = "0x4002C7E")]
		[FieldOffset(Offset = "0x3C")]
		private float idleTime;

		[Token(Token = "0x4002C7F")]
		[FieldOffset(Offset = "0x40")]
		private Transform target;

		[Token(Token = "0x4002C80")]
		[FieldOffset(Offset = "0x48")]
		private Vector3 tagetPos;

		[Token(Token = "0x4002C81")]
		[FieldOffset(Offset = "0x54")]
		private bool isActive;

		[Token(Token = "0x4002C82")]
		[FieldOffset(Offset = "0x55")]
		private bool isIdleAndJump;

		[Token(Token = "0x600186B")]
		[Address(RVA = "0x3E6E0C0", Offset = "0x3E6A0C0", VA = "0x3E6E0C0")]
		public void Init()
		{
		}

		[Token(Token = "0x600186C")]
		[Address(RVA = "0x3E6E218", Offset = "0x3E6A218", VA = "0x3E6E218")]
		public void SetFixedState()
		{
		}

		[Token(Token = "0x600186D")]
		[Address(RVA = "0x3E79628", Offset = "0x3E75628", VA = "0x3E79628")]
		private void UpdateMainTowerPanelSmallRoleState(object o)
		{
		}

		[Token(Token = "0x600186E")]
		[Address(RVA = "0x3E69D34", Offset = "0x3E65D34", VA = "0x3E69D34")]
		public void OpenActive()
		{
		}

		[Token(Token = "0x600186F")]
		[Address(RVA = "0x3E69D70", Offset = "0x3E65D70", VA = "0x3E69D70")]
		public void OffActive()
		{
		}

		[Token(Token = "0x6001870")]
		[Address(RVA = "0x3E79880", Offset = "0x3E75880", VA = "0x3E79880")]
		private void Update()
		{
		}

		[Token(Token = "0x6001871")]
		[Address(RVA = "0x3E79630", Offset = "0x3E75630", VA = "0x3E79630")]
		private void Randomstate(int sta)
		{
		}

		[Token(Token = "0x6001872")]
		[Address(RVA = "0x3E799CC", Offset = "0x3E759CC", VA = "0x3E799CC")]
		public void JumpCallBack()
		{
		}

		[Token(Token = "0x6001873")]
		[Address(RVA = "0x3E799A4", Offset = "0x3E759A4", VA = "0x3E799A4")]
		private void IdleRandomTime()
		{
		}

		[Token(Token = "0x6001874")]
		[Address(RVA = "0x3E799D4", Offset = "0x3E759D4", VA = "0x3E799D4")]
		public CitizenBehaviour()
		{
		}
	}
}
