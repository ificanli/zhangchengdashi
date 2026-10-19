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
	[Token(Token = "0x2000252")]
	public class MainTowerBehaviour : DefenseArchitectureBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000253")]
		[CompilerGenerated]
		private struct _003CAtkLogic_003Ed__18 : IAsyncStateMachine
		{
			[Token(Token = "0x4001ED4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001ED5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001ED6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MainTowerBehaviour _003C_003E4__this;

			[Token(Token = "0x4001ED7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000A31")]
			[Address(RVA = "0x43828BC", Offset = "0x437E8BC", VA = "0x43828BC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000A32")]
			[Address(RVA = "0x4382EFC", Offset = "0x437EEFC", VA = "0x4382EFC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000254")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__10 : IAsyncStateMachine
		{
			[Token(Token = "0x4001ED8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001ED9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001EDA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MainTowerBehaviour _003C_003E4__this;

			[Token(Token = "0x4001EDB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public HexBehaviour hex;

			[Token(Token = "0x4001EDC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public GlobalArchitectureInfo info;

			[Token(Token = "0x4001EDD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool isEnemy;

			[Token(Token = "0x4001EDE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public int cardLevel;

			[Token(Token = "0x4001EDF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public RareLevel rareLevel;

			[Token(Token = "0x4001EE0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public UnityAction callBack;

			[Token(Token = "0x4001EE1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public CardFettersType fettersType;

			[Token(Token = "0x4001EE2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public AtkWayType atkWayType;

			[Token(Token = "0x4001EE3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000A33")]
			[Address(RVA = "0x4382F08", Offset = "0x437EF08", VA = "0x4382F08", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000A34")]
			[Address(RVA = "0x4383B04", Offset = "0x437FB04", VA = "0x4383B04", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4001ECA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		private float _mainTowerFrontAtkTime;

		[Token(Token = "0x4001ECB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private float _mainTowerAtkOffset;

		[Token(Token = "0x4001ECC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		public int mainTowerHp;

		[Token(Token = "0x4001ECD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private int _mainTowerMaxHp;

		[Token(Token = "0x4001ECE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		private float _towerFindTargetFront;

		[Token(Token = "0x4001ECF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private string _mainTowerAtkFormula;

		[Token(Token = "0x4001ED0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private int outPutCoinNum;

		[Token(Token = "0x4001ED1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private Tween tweener;

		[Token(Token = "0x4001ED2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private Animator _animator;

		[Token(Token = "0x4001ED3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private Transform _aimTf;

		[Token(Token = "0x6000A24")]
		[Address(RVA = "0x4381280", Offset = "0x437D280", VA = "0x4381280", Slot = "8")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__10))]
		public override void Init(HexBehaviour hex, GlobalArchitectureInfo info, bool isEnemy, int cardLevel, RareLevel rareLevel, [Optional] UnityAction callBack, CardFettersType fettersType = CardFettersType.Null, AtkWayType atkWayType = AtkWayType.Null)
		{
		}

		[Token(Token = "0x6000A25")]
		[Address(RVA = "0x4381370", Offset = "0x437D370", VA = "0x4381370", Slot = "9")]
		protected override void InitTalent()
		{
		}

		[Token(Token = "0x6000A26")]
		[Address(RVA = "0x438137C", Offset = "0x437D37C", VA = "0x438137C", Slot = "5")]
		public override void MyUpdate()
		{
		}

		[Token(Token = "0x6000A27")]
		[Address(RVA = "0x4381A68", Offset = "0x437DA68", VA = "0x4381A68")]
		protected new void FindTargetSync(float range)
		{
		}

		[Token(Token = "0x6000A28")]
		[Address(RVA = "0x4381B84", Offset = "0x437DB84", VA = "0x4381B84")]
		public new void ShowDamageText(string damage, Color color)
		{
		}

		[Token(Token = "0x6000A29")]
		[Address(RVA = "0x4381E54", Offset = "0x437DE54", VA = "0x4381E54", Slot = "11")]
		protected override void WoundPuiiHpLogic(int num, string id, bool isBuild, EntityBase target)
		{
		}

		[Token(Token = "0x6000A2A")]
		[Address(RVA = "0x43822EC", Offset = "0x437E2EC", VA = "0x43822EC", Slot = "13")]
		protected override void PerformLogic()
		{
		}

		[Token(Token = "0x6000A2B")]
		[Address(RVA = "0x4381AF0", Offset = "0x437DAF0", VA = "0x4381AF0")]
		private void MainTowerAtk()
		{
		}

		[Token(Token = "0x6000A2C")]
		[Address(RVA = "0x43822F0", Offset = "0x437E2F0", VA = "0x43822F0", Slot = "15")]
		[AsyncStateMachine(typeof(_003CAtkLogic_003Ed__18))]
		protected override void AtkLogic()
		{
		}

		[Token(Token = "0x6000A2D")]
		[Address(RVA = "0x438237C", Offset = "0x437E37C", VA = "0x438237C", Slot = "16")]
		protected override void FindTargetAndGetDamage()
		{
		}

		[Token(Token = "0x6000A2E")]
		[Address(RVA = "0x438261C", Offset = "0x437E61C", VA = "0x438261C", Slot = "12")]
		protected override void Dead()
		{
		}

		[Token(Token = "0x6000A2F")]
		[Address(RVA = "0x4382898", Offset = "0x437E898", VA = "0x4382898")]
		public MainTowerBehaviour()
		{
		}
	}
}
