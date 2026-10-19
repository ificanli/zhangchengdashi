using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace GameModule
{
	[Token(Token = "0x200024A")]
	public class BarracksArchitectureBehaviour : ArchitectureBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200024B")]
		[CompilerGenerated]
		private struct _003CCreatRole_003Ed__34 : IAsyncStateMachine
		{
			[Token(Token = "0x4001E8D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001E8E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001E8F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BarracksArchitectureBehaviour _003C_003E4__this;

			[Token(Token = "0x4001E90")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int _003CactualCreatCount_003E5__2;

			[Token(Token = "0x4001E91")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private List<Vector3> _003Cpositions_003E5__3;

			[Token(Token = "0x4001E92")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private List<GameObject> _003Ceffects_003E5__4;

			[Token(Token = "0x4001E93")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x4001E94")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private UniTask<List<Vector3>>.Awaiter _003C_003Eu__2;

			[Token(Token = "0x4001E95")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__3;

			[Token(Token = "0x4001E96")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__4;

			[Token(Token = "0x60009FE")]
			[Address(RVA = "0x4299C04", Offset = "0x4295C04", VA = "0x4299C04", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60009FF")]
			[Address(RVA = "0x429CB34", Offset = "0x4298B34", VA = "0x429CB34", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200024C")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__28 : IAsyncStateMachine
		{
			[Token(Token = "0x4001E97")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001E98")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001E99")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BarracksArchitectureBehaviour _003C_003E4__this;

			[Token(Token = "0x4001E9A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public HexBehaviour hex;

			[Token(Token = "0x4001E9B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public GlobalArchitectureInfo info;

			[Token(Token = "0x4001E9C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool isEnemy;

			[Token(Token = "0x4001E9D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public int cardLevel;

			[Token(Token = "0x4001E9E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public RareLevel rareLevel;

			[Token(Token = "0x4001E9F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public UnityAction callBack;

			[Token(Token = "0x4001EA0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public CardFettersType fettersType;

			[Token(Token = "0x4001EA1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public AtkWayType atkWayType;

			[Token(Token = "0x4001EA2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000A00")]
			[Address(RVA = "0x437AEFC", Offset = "0x4376EFC", VA = "0x437AEFC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000A01")]
			[Address(RVA = "0x437B688", Offset = "0x4377688", VA = "0x437B688", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200024D")]
		[CompilerGenerated]
		private struct _003CRefreshCreatRoleConfigAsync_003Ed__29 : IAsyncStateMachine
		{
			[Token(Token = "0x4001EA3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001EA4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001EA5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BarracksArchitectureBehaviour _003C_003E4__this;

			[Token(Token = "0x4001EA6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private string _003CloadRoleID_003E5__2;

			[Token(Token = "0x4001EA7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000A02")]
			[Address(RVA = "0x437B694", Offset = "0x4377694", VA = "0x437B694", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000A03")]
			[Address(RVA = "0x437BD58", Offset = "0x4377D58", VA = "0x437BD58", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200024E")]
		[CompilerGenerated]
		private struct _003CRefreshCreatRoleConfigForCheat_003Ed__30 : IAsyncStateMachine
		{
			[Token(Token = "0x4001EA8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001EA9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001EAA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BarracksArchitectureBehaviour _003C_003E4__this;

			[Token(Token = "0x4001EAB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6000A04")]
			[Address(RVA = "0x437BD64", Offset = "0x4377D64", VA = "0x437BD64", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6000A05")]
			[Address(RVA = "0x437C18C", Offset = "0x437818C", VA = "0x437C18C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4001E72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private string _creatRoleID;

		[Token(Token = "0x4001E73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private GlobalRoleInfo _roleInfo;

		[Token(Token = "0x4001E74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private GameObject _rolePrefabRes;

		[Token(Token = "0x4001E75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private string _originRoleID;

		[Token(Token = "0x4001E76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private string _originCardID;

		[Token(Token = "0x4001E77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private int _originCardLevel;

		[Token(Token = "0x4001E78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private RareLevel _originRareLevel;

		[Token(Token = "0x4001E79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private CardFettersType _originFettersType;

		[Token(Token = "0x4001E7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private AtkWayType _originAtkWayType;

		[Token(Token = "0x4001E7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private string _spawnCardID;

		[Token(Token = "0x4001E7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private int _spawnCardLevel;

		[Token(Token = "0x4001E7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private RareLevel _spawnRareLevel;

		[Token(Token = "0x4001E7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private CardFettersType _spawnFettersType;

		[Token(Token = "0x4001E7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private AtkWayType _spawnAtkWayType;

		[Token(Token = "0x4001E80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private string _legendaryBarracksRegisterRoleID;

		[Token(Token = "0x4001E81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private bool loadResEnd;

		[Token(Token = "0x4001E82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private GlobalHeroCardInfo cardInfo;

		[Token(Token = "0x4001E83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private int creatRoleCount;

		[Token(Token = "0x4001E84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		private bool stopCreatRole;

		[Token(Token = "0x4001E85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private List<GameObject> creatRoleList;

		[Token(Token = "0x4001E86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private int maxUnitCount;

		[Token(Token = "0x4001E87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		private int _creatRoleCount;

		[Token(Token = "0x4001E88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private bool _isWaitingForSlot;

		[Token(Token = "0x4001E89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x159")]
		private bool _hasReservedSlot;

		[Token(Token = "0x4001E8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		private int _reservedSlotCount;

		[Token(Token = "0x4001E8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private bool _isWaitingForMyLegendaryUnitDead;

		[Token(Token = "0x4001E8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool _hasRecordedThirdGameSkeletonGiant;

		[Token(Token = "0x60009EC")]
		[Address(RVA = "0x4298ED4", Offset = "0x4294ED4", VA = "0x4298ED4", Slot = "7")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60009ED")]
		[Address(RVA = "0x4298FA4", Offset = "0x4294FA4", VA = "0x4298FA4", Slot = "8")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__28))]
		public override void Init(HexBehaviour hex, GlobalArchitectureInfo info, bool isEnemy, int cardLevel, RareLevel rareLevel, [Optional] UnityAction callBack, CardFettersType fettersType = CardFettersType.Null, AtkWayType atkWayType = AtkWayType.Null)
		{
		}

		[Token(Token = "0x60009EE")]
		[Address(RVA = "0x4299090", Offset = "0x4295090", VA = "0x4299090")]
		[AsyncStateMachine(typeof(_003CRefreshCreatRoleConfigAsync_003Ed__29))]
		private UniTask RefreshCreatRoleConfigAsync()
		{
			return default;
		}

		[Token(Token = "0x60009EF")]
		[Address(RVA = "0x4299128", Offset = "0x4295128", VA = "0x4299128")]
		[AsyncStateMachine(typeof(_003CRefreshCreatRoleConfigForCheat_003Ed__30))]
		public void RefreshCreatRoleConfigForCheat()
		{
		}

		[Token(Token = "0x60009F0")]
		[Address(RVA = "0x42991B4", Offset = "0x42951B4", VA = "0x42991B4")]
		private bool ShouldUseLegendarySpawnLimit()
		{
			return default;
		}

		[Token(Token = "0x60009F1")]
		[Address(RVA = "0x42991C4", Offset = "0x42951C4", VA = "0x42991C4")]
		private void RefreshLegendaryBarracksRegister()
		{
		}

		[Token(Token = "0x60009F2")]
		[Address(RVA = "0x4299314", Offset = "0x4295314", VA = "0x4299314", Slot = "13")]
		protected override void PerformLogic()
		{
		}

		[Token(Token = "0x60009F3")]
		[Address(RVA = "0x4299358", Offset = "0x4295358", VA = "0x4299358")]
		[AsyncStateMachine(typeof(_003CCreatRole_003Ed__34))]
		private void CreatRole()
		{
		}

		[Token(Token = "0x60009F4")]
		[Address(RVA = "0x42993E8", Offset = "0x42953E8", VA = "0x42993E8", Slot = "10")]
		protected override bool ShouldPerformLogic()
		{
			return default;
		}

		[Token(Token = "0x60009F5")]
		[Address(RVA = "0x4299580", Offset = "0x4295580", VA = "0x4299580")]
		public int GetRareLevelValue()
		{
			return default;
		}

		[Token(Token = "0x60009F6")]
		[Address(RVA = "0x429959C", Offset = "0x429559C", VA = "0x429959C")]
		public string GetCreatRoleID()
		{
			return null;
		}

		[Token(Token = "0x60009F7")]
		[Address(RVA = "0x42995E4", Offset = "0x42955E4", VA = "0x42995E4")]
		public bool IsLegendaryBarracks()
		{
			return default;
		}

		[Token(Token = "0x60009F8")]
		[Address(RVA = "0x42995F4", Offset = "0x42955F4", VA = "0x42995F4")]
		public void OnCanSpawnRole()
		{
		}

		[Token(Token = "0x60009F9")]
		[Address(RVA = "0x42996F4", Offset = "0x42956F4", VA = "0x42996F4")]
		private void ReleaseReservedSlotIfNeeded()
		{
		}

		[Token(Token = "0x60009FA")]
		[Address(RVA = "0x42997B4", Offset = "0x42957B4", VA = "0x42997B4", Slot = "14")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60009FB")]
		[Address(RVA = "0x42999F4", Offset = "0x42959F4", VA = "0x42999F4")]
		private void HasRoleDead(object o)
		{
		}

		[Token(Token = "0x60009FC")]
		[Address(RVA = "0x4299B74", Offset = "0x4295B74", VA = "0x4299B74")]
		public BarracksArchitectureBehaviour()
		{
		}
	}
}
