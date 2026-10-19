using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using DataModule;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace GameModule
{
	[Token(Token = "0x200024F")]
	public class DefenseArchitectureBehaviour : ArchitectureBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000251")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__9 : IAsyncStateMachine
		{
			[Token(Token = "0x4001EBE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001EBF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001EC0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public DefenseArchitectureBehaviour _003C_003E4__this;

			[Token(Token = "0x4001EC1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public HexBehaviour hex;

			[Token(Token = "0x4001EC2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public GlobalArchitectureInfo info;

			[Token(Token = "0x4001EC3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool isEnemy;

			[Token(Token = "0x4001EC4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public int cardLevel;

			[Token(Token = "0x4001EC5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public RareLevel rareLevel;

			[Token(Token = "0x4001EC6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public UnityAction callBack;

			[Token(Token = "0x4001EC7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public CardFettersType fettersType;

			[Token(Token = "0x4001EC8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public AtkWayType atkWayType;

			[Token(Token = "0x4001EC9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000A22")]
			[Address(RVA = "0x438079C", Offset = "0x437C79C", VA = "0x438079C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000A23")]
			[Address(RVA = "0x4381274", Offset = "0x437D274", VA = "0x4381274", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4001EAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		protected int Damage;

		[Token(Token = "0x4001EAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		protected GameObject BulletRes;

		[Token(Token = "0x4001EAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		protected RoleBehaviour RoleBehaviour;

		[Token(Token = "0x4001EAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Transform gangGan;

		[Token(Token = "0x4001EB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Transform shitou;

		[Token(Token = "0x4001EB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private SkinnedMeshRenderer _skinnedMeshRenderer;

		[Token(Token = "0x4001EB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		protected bool isMainTower;

		[Token(Token = "0x4001EB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private EntityBase TargetBehaviour;

		[Token(Token = "0x4001EB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private EntityBase AttackObj;

		[Token(Token = "0x4001EB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private float SkillNumber;

		[Token(Token = "0x4001EB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private float catapultExploseRange;

		[Token(Token = "0x4001EB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private CardFettersType fetterType;

		[Token(Token = "0x4001EB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private bool _shouldReduceCD;

		[Token(Token = "0x4001EB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Sequence _sequence;

		[Token(Token = "0x4001EBA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Sequence _sequence2;

		[Token(Token = "0x4001EBB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Vector3 catapultsPos;

		[Token(Token = "0x6000A06")]
		[Address(RVA = "0x437C198", Offset = "0x4378198", VA = "0x437C198", Slot = "8")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__9))]
		public override void Init(HexBehaviour hex, GlobalArchitectureInfo info, bool isEnemy, int cardLevel, RareLevel rareLevel, [Optional] UnityAction callBack, CardFettersType fettersType = CardFettersType.Null, AtkWayType atkWayType = AtkWayType.Null)
		{
		}

		[Token(Token = "0x6000A07")]
		[Address(RVA = "0x437C288", Offset = "0x4378288", VA = "0x437C288", Slot = "9")]
		protected override void InitTalent()
		{
		}

		[Token(Token = "0x6000A08")]
		[Address(RVA = "0x437C904", Offset = "0x4378904", VA = "0x437C904")]
		protected int OnAttackTalentTrigger(int atkNum)
		{
			return default;
		}

		[Token(Token = "0x6000A09")]
		[Address(RVA = "0x437CB94", Offset = "0x4378B94", VA = "0x437CB94")]
		protected (int, float) OnHurtTalentTrigger(int damage)
		{
			return default;
		}

		[Token(Token = "0x6000A0A")]
		[Address(RVA = "0x437CB30", Offset = "0x4378B30", VA = "0x437CB30")]
		private List<RoleBehaviour> GetNearOneMTeamMate()
		{
			return null;
		}

		[Token(Token = "0x6000A0B")]
		[Address(RVA = "0x437CDA4", Offset = "0x4378DA4", VA = "0x437CDA4", Slot = "4")]
		public override void Wound(int damage, string id, [Optional][DefaultParameterValue(false)] bool isBuild, [Optional] EntityBase target, [Optional][DefaultParameterValue(false)] bool isLandRole, [Optional][DefaultParameterValue((AtkWayType)0)] AtkWayType atkWayType, [Optional][DefaultParameterValue((CardFettersType)4)] CardFettersType fetterType, [Optional] Object linkAttackObj)
		{
		}

		[Token(Token = "0x6000A0C")]
		[Address(RVA = "0x437CF7C", Offset = "0x4378F7C", VA = "0x437CF7C")]
		public void ShowDamageText(string damage, Color color)
		{
		}

		[Token(Token = "0x6000A0D")]
		[Address(RVA = "0x437DDBC", Offset = "0x4379DBC", VA = "0x437DDBC", Slot = "5")]
		public override void MyUpdate()
		{
		}

		[Token(Token = "0x6000A0E")]
		[Address(RVA = "0x437E060", Offset = "0x437A060", VA = "0x437E060", Slot = "13")]
		protected override void PerformLogic()
		{
		}

		[Token(Token = "0x6000A0F")]
		[Address(RVA = "0x437E1F0", Offset = "0x437A1F0", VA = "0x437E1F0", Slot = "15")]
		protected virtual void AtkLogic()
		{
		}

		[Token(Token = "0x6000A10")]
		[Address(RVA = "0x437EF28", Offset = "0x437AF28", VA = "0x437EF28")]
		protected void FireBulletLogic(bool isTouShiChe, bool isTowerAr, [Optional] Vector3 rolePosition)
		{
		}

		[Token(Token = "0x6000A11")]
		[Address(RVA = "0x437F71C", Offset = "0x437B71C", VA = "0x437F71C")]
		private void Vampire()
		{
		}

		[Token(Token = "0x6000A12")]
		[Address(RVA = "0x438002C", Offset = "0x437C02C", VA = "0x438002C", Slot = "16")]
		protected virtual void FindTargetAndGetDamage()
		{
		}

		[Token(Token = "0x6000A13")]
		[Address(RVA = "0x43801CC", Offset = "0x437C1CC", VA = "0x43801CC")]
		protected void FindTargetSync(float range)
		{
		}

		[Token(Token = "0x6000A14")]
		[Address(RVA = "0x4380254", Offset = "0x437C254", VA = "0x4380254", Slot = "14")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000A15")]
		[Address(RVA = "0x4380318", Offset = "0x437C318", VA = "0x4380318")]
		public DefenseArchitectureBehaviour()
		{
		}
	}
}
