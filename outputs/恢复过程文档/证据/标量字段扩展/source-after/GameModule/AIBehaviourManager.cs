using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;
using ToolModule;

namespace GameModule
{
	[Token(Token = "0x20003FC")]
	public class AIBehaviourManager : ManagerBase<AIBehaviourManager>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000414")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__100 : IAsyncStateMachine
		{
			[Token(Token = "0x40028AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40028AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40028AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public AIBehaviourManager _003C_003E4__this;

			[Token(Token = "0x600135B")]
			[Address(RVA = "0x3DE1A30", Offset = "0x3DDDA30", VA = "0x3DE1A30", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600135C")]
			[Address(RVA = "0x3DE253C", Offset = "0x3DDE53C", VA = "0x3DE253C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000415")]
		[CompilerGenerated]
		private struct _003CPlayerSendEmoji_003Ed__123 : IAsyncStateMachine
		{
			[Token(Token = "0x40028AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40028AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40028B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public AIBehaviourManager _003C_003E4__this;

			[Token(Token = "0x40028B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600135D")]
			[Address(RVA = "0x3DE2548", Offset = "0x3DDE548", VA = "0x3DE2548", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600135E")]
			[Address(RVA = "0x3DE2A78", Offset = "0x3DDEA78", VA = "0x3DE2A78", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000416")]
		[CompilerGenerated]
		private struct _003CSendWords_003Ed__121 : IAsyncStateMachine
		{
			[Token(Token = "0x40028B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40028B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40028B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public AIBehaviourManager _003C_003E4__this;

			[Token(Token = "0x40028B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public object o;

			[Token(Token = "0x40028B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600135F")]
			[Address(RVA = "0x3DE2A84", Offset = "0x3DDEA84", VA = "0x3DE2A84", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001360")]
			[Address(RVA = "0x3DE2F04", Offset = "0x3DDEF04", VA = "0x3DE2F04", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000417")]
		[CompilerGenerated]
		private struct _003CStartGame_003Ed__146 : IAsyncStateMachine
		{
			[Token(Token = "0x40028B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40028B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40028B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public AIBehaviourManager _003C_003E4__this;

			[Token(Token = "0x40028BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001361")]
			[Address(RVA = "0x3DE2F10", Offset = "0x3DDEF10", VA = "0x3DE2F10", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001362")]
			[Address(RVA = "0x3DE37F0", Offset = "0x3DDF7F0", VA = "0x3DE37F0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400283B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool _isOpenHexing;

		[Token(Token = "0x400283C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float _frontTime;

		[Token(Token = "0x400283D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float _openHexTimeOffset;

		[Token(Token = "0x400283E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float _logicTime;

		[Token(Token = "0x400283F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float _lastRealTime;

		[Token(Token = "0x4002840")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int hasCoin;

		[Token(Token = "0x4002841")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int bornHasCoin;

		[Token(Token = "0x4002842")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool _isAddCoining;

		[Token(Token = "0x4002843")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public RankItemData ItemInfo;

		[Token(Token = "0x4002844")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<int> hardIndexs;

		[Token(Token = "0x4002845")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool IsHard;

		[Token(Token = "0x4002846")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public int nowDifficultLevel;

		[Token(Token = "0x4002847")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public List<string> aiBattleCardID;

		[Token(Token = "0x4002848")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AIType aiType;

		[Token(Token = "0x4002849")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool isFirstOpen;

		[Token(Token = "0x400284A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
		private bool canAction;

		[Token(Token = "0x400284B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x66")]
		private bool _isGamePaused;

		[Token(Token = "0x400284C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private List<GlobalHeroCardInfo> _cardInfoList;

		[Token(Token = "0x400284D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private List<GlobalHeroCardInfo> _cardRInfoList;

		[Token(Token = "0x400284E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private List<GlobalHeroCardInfo> _cardSrInfoList;

		[Token(Token = "0x400284F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private List<GlobalHeroCardInfo> _cardSsrInfoList;

		[Token(Token = "0x4002850")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private List<GlobalHeroCardInfo> _cardSssrInfoList;

		[Token(Token = "0x4002851")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private List<GlobalHeroCardInfo> _cardRNoGoldMineInfoList;

		[Token(Token = "0x4002852")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Dictionary<int, DeadUnitInfo> GameDeadUnitInfoDic;

		[Token(Token = "0x4002853")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Dictionary<string, int> cardLevelDic;

		[Token(Token = "0x4002854")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Dictionary<string, int> cardTalentDic;

		[Token(Token = "0x4002855")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public int moraleNum;

		[Token(Token = "0x4002856")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public bool crazySendEmoji;

		[Token(Token = "0x4002857")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB5")]
		public bool forcedLengdaryProp;

		[Token(Token = "0x4002858")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private int _attackLevel;

		[Token(Token = "0x4002859")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int _hpLevel;

		[Token(Token = "0x400285A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int _cdLevel;

		[Token(Token = "0x400285B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int _orcsCount;

		[Token(Token = "0x400285C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int _unDeadCount;

		[Token(Token = "0x400285D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int _terranCount;

		[Token(Token = "0x400285E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int _meleeCount;

		[Token(Token = "0x400285F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int _remoteCount;

		[Token(Token = "0x4002860")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private int _machineCount;

		[Token(Token = "0x4002861")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public int openHexCount;

		[Token(Token = "0x4002862")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool isPriorityOpenSpecialNearrHex;

		[Token(Token = "0x4002863")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private float propTime;

		[Token(Token = "0x4002864")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int propUsedCount;

		[Token(Token = "0x4002865")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float pTime;

		[Token(Token = "0x4002866")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public string propId;

		[Token(Token = "0x4002867")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public int propLevel;

		[Token(Token = "0x4002868")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private List<EnemyPropBattleEntry> _enemyPropDataList;

		[Token(Token = "0x4002869")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private PropAttrSnapshot _currentEnemyPropAttrSnapshot;

		[Token(Token = "0x400286A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public Dictionary<string, List<int>> cardAllUnlockTalent;

		[Token(Token = "0x400286B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public Dictionary<string, List<int>> cardAllHaveTalent;

		[Token(Token = "0x400286C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public string blessId;

		[Token(Token = "0x400286D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public bool enemyNowGameOpenGoldCardEd;

		[Token(Token = "0x400286E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private float sTime;

		[Token(Token = "0x400286F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private float lTime;

		[Token(Token = "0x4002870")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private bool sendEmojiTimeNoLimit;

		[Token(Token = "0x4002871")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private float jTime;

		[Token(Token = "0x4002872")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private float arFrontWoundTime;

		[Token(Token = "0x4002873")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private bool isNoBeAttack;

		[Token(Token = "0x4002874")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		private int openUnchartedHexCount;

		[Token(Token = "0x4002875")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private int barCount;

		[Token(Token = "0x4002876")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		private int goldCount;

		[Token(Token = "0x17000112")]
		public bool IsGamePaused
		{
			[Token(Token = "0x60012AB")]
			[Address(RVA = "0x3DD2220", Offset = "0x3DCE220", VA = "0x3DD2220")]
			get
			{
				return default;
			}
			[Token(Token = "0x60012AC")]
			[Address(RVA = "0x3DD22B0", Offset = "0x3DCE2B0", VA = "0x3DD22B0")]
			private set
			{
				_isGamePaused = value;
			}
		}

		[Token(Token = "0x17000113")]
		public List<GlobalHeroCardInfo> CardInfoList
		{
			[Token(Token = "0x60012AD")]
			[Address(RVA = "0x3DD22BC", Offset = "0x3DCE2BC", VA = "0x3DD22BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000114")]
		public int OrcsCount
		{
			[Token(Token = "0x60012AE")]
			[Address(RVA = "0x3DD22C4", Offset = "0x3DCE2C4", VA = "0x3DD22C4")]
			get
			{
				return _orcsCount;
			}
		}

		[Token(Token = "0x17000115")]
		public int UnDeadCount
		{
			[Token(Token = "0x60012AF")]
			[Address(RVA = "0x3DD22CC", Offset = "0x3DCE2CC", VA = "0x3DD22CC")]
			get
			{
				return _unDeadCount;
			}
		}

		[Token(Token = "0x17000116")]
		public int TerranCount
		{
			[Token(Token = "0x60012B0")]
			[Address(RVA = "0x3DD22D4", Offset = "0x3DCE2D4", VA = "0x3DD22D4")]
			get
			{
				return _terranCount;
			}
		}

		[Token(Token = "0x17000117")]
		public int MeleeCount
		{
			[Token(Token = "0x60012B1")]
			[Address(RVA = "0x3DD22DC", Offset = "0x3DCE2DC", VA = "0x3DD22DC")]
			get
			{
				return _meleeCount;
			}
		}

		[Token(Token = "0x17000118")]
		public int RemoteCount
		{
			[Token(Token = "0x60012B2")]
			[Address(RVA = "0x3DD22E4", Offset = "0x3DCE2E4", VA = "0x3DD22E4")]
			get
			{
				return _remoteCount;
			}
		}

		[Token(Token = "0x17000119")]
		public int MachineCount
		{
			[Token(Token = "0x60012B3")]
			[Address(RVA = "0x3DD22EC", Offset = "0x3DCE2EC", VA = "0x3DD22EC")]
			get
			{
				return _machineCount;
			}
		}

		[Token(Token = "0x1700011A")]
		public int AttackLevel
		{
			[Token(Token = "0x60012B4")]
			[Address(RVA = "0x3DD22F4", Offset = "0x3DCE2F4", VA = "0x3DD22F4")]
			get
			{
				return _attackLevel;
			}
		}

		[Token(Token = "0x1700011B")]
		public int HpLevel
		{
			[Token(Token = "0x60012B5")]
			[Address(RVA = "0x3DD22FC", Offset = "0x3DCE2FC", VA = "0x3DD22FC")]
			get
			{
				return _hpLevel;
			}
		}

		[Token(Token = "0x1700011C")]
		public int CdLevel
		{
			[Token(Token = "0x60012B6")]
			[Address(RVA = "0x3DD2304", Offset = "0x3DCE304", VA = "0x3DD2304")]
			get
			{
				return _cdLevel;
			}
		}

		[Token(Token = "0x1700011D")]
		public int OrcsFetterLevel
		{
			[Token(Token = "0x60012B7")]
			[Address(RVA = "0x3DD230C", Offset = "0x3DCE30C", VA = "0x3DD230C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700011E")]
		public int UndeadFetterLevel
		{
			[Token(Token = "0x60012B8")]
			[Address(RVA = "0x3DD233C", Offset = "0x3DCE33C", VA = "0x3DD233C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700011F")]
		public int TerranFetterLevel
		{
			[Token(Token = "0x60012B9")]
			[Address(RVA = "0x3DD236C", Offset = "0x3DCE36C", VA = "0x3DD236C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000120")]
		public int MachineFetterLevel
		{
			[Token(Token = "0x60012BA")]
			[Address(RVA = "0x3DD239C", Offset = "0x3DCE39C", VA = "0x3DD239C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000121")]
		public int MeleeFetterLevel
		{
			[Token(Token = "0x60012BB")]
			[Address(RVA = "0x3DD23CC", Offset = "0x3DCE3CC", VA = "0x3DD23CC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000122")]
		public int RemoteFetterLevel
		{
			[Token(Token = "0x60012BC")]
			[Address(RVA = "0x3DD23FC", Offset = "0x3DCE3FC", VA = "0x3DD23FC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000123")]
		public bool EqipDefenseArrowTowerCard
		{
			[Token(Token = "0x60012BD")]
			[Address(RVA = "0x3DD242C", Offset = "0x3DCE42C", VA = "0x3DD242C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000124")]
		public bool EqipDefenseCatapultsCard
		{
			[Token(Token = "0x60012BE")]
			[Address(RVA = "0x3DD2538", Offset = "0x3DCE538", VA = "0x3DD2538")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000125")]
		public bool EqipDefenseCard
		{
			[Token(Token = "0x60012BF")]
			[Address(RVA = "0x3DCF580", Offset = "0x3DCB580", VA = "0x3DCF580")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000126")]
		internal bool HasPropChargeAvailable
		{
			[Token(Token = "0x60012C0")]
			[Address(RVA = "0x3DD2644", Offset = "0x3DCE644", VA = "0x3DD2644")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000127")]
		public int PropUsedCount
		{
			[Token(Token = "0x60012C1")]
			[Address(RVA = "0x3DD2878", Offset = "0x3DCE878", VA = "0x3DD2878")]
			get
			{
				return propUsedCount;
			}
		}

		[Token(Token = "0x17000128")]
		public float PropReadyTime
		{
			[Token(Token = "0x60012C2")]
			[Address(RVA = "0x3DD2880", Offset = "0x3DCE880", VA = "0x3DD2880")]
			get
			{
				return propTime;
			}
		}

		[Token(Token = "0x17000129")]
		public float PropElapsedTime
		{
			[Token(Token = "0x60012C3")]
			[Address(RVA = "0x3DD2888", Offset = "0x3DCE888", VA = "0x3DD2888")]
			get
			{
				return pTime;
			}
		}

		[Token(Token = "0x60012C4")]
		[Address(RVA = "0x3DD2890", Offset = "0x3DCE890", VA = "0x3DD2890", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__100))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x60012C5")]
		[Address(RVA = "0x3DD2920", Offset = "0x3DCE920", VA = "0x3DD2920")]
		private void EnemyHornEmitIng(object o)
		{
		}

		[Token(Token = "0x60012C6")]
		[Address(RVA = "0x3DD2924", Offset = "0x3DCE924", VA = "0x3DD2924")]
		private void EnemyHornEmitEnd(object o)
		{
		}

		[Token(Token = "0x60012C7")]
		[Address(RVA = "0x3DD2928", Offset = "0x3DCE928", VA = "0x3DD2928")]
		private void CloseMatchPanel(object o)
		{
		}

		[Token(Token = "0x60012C8")]
		[Address(RVA = "0x3DD297C", Offset = "0x3DCE97C", VA = "0x3DD297C")]
		private void EnemyOpenHexCountAdd(object o)
		{
		}

		[Token(Token = "0x60012C9")]
		[Address(RVA = "0x3DD298C", Offset = "0x3DCE98C", VA = "0x3DD298C")]
		private void HasEnemyArchitectureWound(object o)
		{
		}

		[Token(Token = "0x60012CA")]
		[Address(RVA = "0x3DD2994", Offset = "0x3DCE994", VA = "0x3DD2994")]
		private void EnemyCreatResourcesAr(object o)
		{
		}

		[Token(Token = "0x60012CB")]
		[Address(RVA = "0x3DD29A4", Offset = "0x3DCE9A4", VA = "0x3DD29A4")]
		private void EnemyCreatBarracksAr(object o)
		{
		}

		[Token(Token = "0x60012CC")]
		[Address(RVA = "0x3DD29B4", Offset = "0x3DCE9B4", VA = "0x3DD29B4")]
		private void EnemyBarracksArDestroy(object o)
		{
		}

		[Token(Token = "0x60012CD")]
		[Address(RVA = "0x3DD29C4", Offset = "0x3DCE9C4", VA = "0x3DD29C4")]
		private void EnemyResourcesArDestroy(object o)
		{
		}

		[Token(Token = "0x60012CE")]
		[Address(RVA = "0x3DD29D4", Offset = "0x3DCE9D4", VA = "0x3DD29D4")]
		private void Update()
		{
		}

		[Token(Token = "0x60012CF")]
		[Address(RVA = "0x3DD37DC", Offset = "0x3DCF7DC", VA = "0x3DD37DC")]
		private void JudgmentPropTiming()
		{
		}

		[Token(Token = "0x60012D0")]
		[Address(RVA = "0x3DD3A14", Offset = "0x3DCFA14", VA = "0x3DD3A14")]
		public void SetGamePaused(bool paused)
		{
		}

		[Token(Token = "0x60012D1")]
		[Address(RVA = "0x3DD3A20", Offset = "0x3DCFA20", VA = "0x3DD3A20")]
		private void OnPauseGame(object o)
		{
		}

		[Token(Token = "0x60012D2")]
		[Address(RVA = "0x3DD3A2C", Offset = "0x3DCFA2C", VA = "0x3DD3A2C")]
		private void OnResumeGame(object o)
		{
		}

		[Token(Token = "0x60012D3")]
		[Address(RVA = "0x3DD39AC", Offset = "0x3DCF9AC", VA = "0x3DD39AC")]
		private void ReleaseProp()
		{
		}

		[Token(Token = "0x60012D4")]
		[Address(RVA = "0x3DD3A34", Offset = "0x3DCFA34", VA = "0x3DD3A34")]
		internal void OnArtifactAIReleased()
		{
		}

		[Token(Token = "0x60012D5")]
		[Address(RVA = "0x3DD34C0", Offset = "0x3DCF4C0", VA = "0x3DD34C0")]
		private void SendEmojis()
		{
		}

		[Token(Token = "0x60012D6")]
		[Address(RVA = "0x3DD3BC0", Offset = "0x3DCFBC0", VA = "0x3DD3BC0")]
		[AsyncStateMachine(typeof(_003CSendWords_003Ed__121))]
		private void SendWords(object o)
		{
		}

		[Token(Token = "0x60012D7")]
		[Address(RVA = "0x3DD3C5C", Offset = "0x3DCFC5C", VA = "0x3DD3C5C")]
		private void BuildDestroyToSendEmojis(object o)
		{
		}

		[Token(Token = "0x60012D8")]
		[Address(RVA = "0x3DD3E38", Offset = "0x3DCFE38", VA = "0x3DD3E38")]
		[AsyncStateMachine(typeof(_003CPlayerSendEmoji_003Ed__123))]
		private void PlayerSendEmoji(object o)
		{
		}

		[Token(Token = "0x60012D9")]
		[Address(RVA = "0x3DD2B98", Offset = "0x3DCEB98", VA = "0x3DD2B98")]
		private void EnemyOpenHex(bool isHard)
		{
		}

		[Token(Token = "0x60012DA")]
		[Address(RVA = "0x3DD3FF0", Offset = "0x3DCFFF0", VA = "0x3DD3FF0")]
		private void Development(bool isHard, List<HexBehaviour> resourcesHex, List<HexBehaviour> unchartedHex, List<HexBehaviour> barracksHex, List<HexBehaviour> enemyCanOpenObj)
		{
		}

		[Token(Token = "0x60012DB")]
		[Address(RVA = "0x3DD429C", Offset = "0x3DD029C", VA = "0x3DD429C")]
		private void Gambling(bool isHard, List<HexBehaviour> resourcesHex, List<HexBehaviour> unchartedHex, List<HexBehaviour> barracksHex, List<HexBehaviour> enemyCanOpenObj)
		{
		}

		[Token(Token = "0x60012DC")]
		[Address(RVA = "0x3DD4530", Offset = "0x3DD0530", VA = "0x3DD4530")]
		private void Offense(bool isHard, List<HexBehaviour> resourcesHex, List<HexBehaviour> unchartedHex, List<HexBehaviour> barracksHex, List<HexBehaviour> enemyCanOpenObj)
		{
		}

		[Token(Token = "0x60012DD")]
		[Address(RVA = "0x3DD4A9C", Offset = "0x3DD0A9C", VA = "0x3DD4A9C")]
		private static int GetLegendaryTileV1BasePrice()
		{
			return default;
		}

		[Token(Token = "0x60012DE")]
		[Address(RVA = "0x3DD4AEC", Offset = "0x3DD0AEC", VA = "0x3DD4AEC")]
		private static bool CandidateUnionHasOpenableLegendary(List<HexBehaviour> preferredHexes, List<HexBehaviour> fallbackHexes)
		{
			return default;
		}

		[Token(Token = "0x60012DF")]
		[Address(RVA = "0x3DD4C78", Offset = "0x3DD0C78", VA = "0x3DD4C78")]
		private bool ShouldReserveGoldForOpenableLegendary(int coin, List<HexBehaviour> preferredHexes, List<HexBehaviour> fallbackHexes)
		{
			return default;
		}

		[Token(Token = "0x60012E0")]
		[Address(RVA = "0x3DD4F20", Offset = "0x3DD0F20", VA = "0x3DD4F20")]
		private HexBehaviour ApplyLegendaryTileV1AiPreference(HexBehaviour hbDefault, List<HexBehaviour> preferredHexes, List<HexBehaviour> fallbackHexes, int coin)
		{
			return null;
		}

		[Token(Token = "0x60012E1")]
		[Address(RVA = "0x3DD4888", Offset = "0x3DD0888", VA = "0x3DD4888")]
		private HexBehaviour TryOpenHex(List<HexBehaviour> preferredHexes, List<HexBehaviour> fallbackHexes, int hasCoin, bool unchartedPreferRandom = false, bool unchartedfallbackRandom = false)
		{
			return null;
		}

		[Token(Token = "0x60012E2")]
		[Address(RVA = "0x3DD55F8", Offset = "0x3DD15F8", VA = "0x3DD55F8")]
		private HexBehaviour TryOpenHexCore(List<HexBehaviour> preferredHexes, List<HexBehaviour> fallbackHexes, int hasCoin, bool unchartedPreferRandom, bool unchartedfallbackRandom)
		{
			return null;
		}

		[Token(Token = "0x60012E3")]
		[Address(RVA = "0x3DD3EC4", Offset = "0x3DCFEC4", VA = "0x3DD3EC4")]
		public void ChangeCoin(int coinNum)
		{
		}

		[Token(Token = "0x60012E4")]
		[Address(RVA = "0x3DD5880", Offset = "0x3DD1880", VA = "0x3DD5880")]
		public PropAttrSnapshot GetCurrentEnemyPropAttrSnapshot()
		{
			return null;
		}

		[Token(Token = "0x60012E5")]
		[Address(RVA = "0x3DD5888", Offset = "0x3DD1888", VA = "0x3DD5888")]
		public IReadOnlyList<EnemyPropBattleEntry> GetCurrentEnemyPropDataList()
		{
			return null;
		}

		[Token(Token = "0x60012E6")]
		[Address(RVA = "0x3DD5890", Offset = "0x3DD1890", VA = "0x3DD5890")]
		public BattlePowerSideInput BuildEnemyBattlePowerSideInput()
		{
			return default;
		}

		[Token(Token = "0x60012E7")]
		[Address(RVA = "0x3DD5C48", Offset = "0x3DD1C48", VA = "0x3DD5C48")]
		public bool TryGetEnemyPropEntry(string infoId, out int level, out int startLevel)
		{
			return default;
		}

		[Token(Token = "0x60012E8")]
		[Address(RVA = "0x3DD5D40", Offset = "0x3DD1D40", VA = "0x3DD5D40")]
		private void ApplyEnemyPropBattleData(EnemyBattleDataCofig enemyBattleData, GameType gameType)
		{
		}

		[Token(Token = "0x60012E9")]
		[Address(RVA = "0x3DD5E8C", Offset = "0x3DD1E8C", VA = "0x3DD5E8C")]
		[AsyncStateMachine(typeof(_003CStartGame_003Ed__146))]
		public void StartGame([Optional] EnemyBattleDataCofig enemyDataCofig)
		{
		}

		[Token(Token = "0x60012EA")]
		[Address(RVA = "0x3DD5F18", Offset = "0x3DD1F18", VA = "0x3DD5F18")]
		private void CallRecordEnemyInfo(object o)
		{
		}

		[Token(Token = "0x60012EB")]
		[Address(RVA = "0x3DD6B70", Offset = "0x3DD2B70", VA = "0x3DD6B70")]
		private void EnemyRandomBattleData(object o)
		{
		}

		[Token(Token = "0x60012EC")]
		[Address(RVA = "0x3DD8BC0", Offset = "0x3DD4BC0", VA = "0x3DD8BC0")]
		private void RandomEnemyMoraleNum(object o)
		{
		}

		[Token(Token = "0x60012ED")]
		[Address(RVA = "0x3DD8BC4", Offset = "0x3DD4BC4", VA = "0x3DD8BC4")]
		private int RoundToNearestMultipleOfFive(int number)
		{
			return default;
		}

		[Token(Token = "0x60012EE")]
		[Address(RVA = "0x3DD5FE8", Offset = "0x3DD1FE8", VA = "0x3DD5FE8")]
		public void RecordEnemyOpenHexTimeOffset(int difficultLevel, bool isPVE)
		{
		}

		[Token(Token = "0x60012EF")]
		[Address(RVA = "0x3DD6F50", Offset = "0x3DD2F50", VA = "0x3DD6F50")]
		public EnemyBattleDataCofig GetEnemyBattleDataCofig(int difficultLevel, GameType gameType, [Optional] List<string> customCardId)
		{
			return null;
		}

		[Token(Token = "0x60012F0")]
		[Address(RVA = "0x3DD6148", Offset = "0x3DD2148", VA = "0x3DD6148")]
		public void RefreshRecordEnemyBattleInfo(EnemyBattleDataCofig enemyBattleData, GameType gameType = GameType.PVP)
		{
		}

		[Token(Token = "0x60012F1")]
		[Address(RVA = "0x3DDA8BC", Offset = "0x3DD68BC", VA = "0x3DDA8BC")]
		public int GetMainTowerTalentInfo()
		{
			return default;
		}

		[Token(Token = "0x60012F2")]
		[Address(RVA = "0x3DD8C94", Offset = "0x3DD4C94", VA = "0x3DD8C94")]
		public RankItemData RandomEnemyInfo(int difficultLevel, GameType gameType)
		{
			return null;
		}

		[Token(Token = "0x60012F3")]
		[Address(RVA = "0x3DDAD24", Offset = "0x3DD6D24", VA = "0x3DDAD24")]
		public Dictionary<CardFettersType, int> GetFetterEnableConfig()
		{
			return null;
		}

		[Token(Token = "0x60012F4")]
		[Address(RVA = "0x3DDAE48", Offset = "0x3DD6E48", VA = "0x3DDAE48")]
		public Dictionary<AtkWayType, int> GetAtkWayTypeEnableConfig()
		{
			return null;
		}

		[Token(Token = "0x60012F5")]
		[Address(RVA = "0x3DDAF1C", Offset = "0x3DD6F1C", VA = "0x3DDAF1C")]
		private void AllowOpenHex(object o)
		{
		}

		[Token(Token = "0x60012F6")]
		[Address(RVA = "0x3DDAFB4", Offset = "0x3DD6FB4", VA = "0x3DDAFB4")]
		public void AddDeadUnit(int id, DeadUnitInfo unitInfo)
		{
		}

		[Token(Token = "0x60012F7")]
		[Address(RVA = "0x3DDB058", Offset = "0x3DD7058", VA = "0x3DDB058")]
		public void RemoveDeadUnit(int id)
		{
		}

		[Token(Token = "0x60012F8")]
		[Address(RVA = "0x3DDB0E8", Offset = "0x3DD70E8", VA = "0x3DDB0E8")]
		public void EndGame()
		{
		}

		[Token(Token = "0x60012F9")]
		[Address(RVA = "0x3DDB2F0", Offset = "0x3DD72F0", VA = "0x3DDB2F0")]
		private List<string> RandomAICardAndRecord(string enemyCardConfig, [Optional] List<string> customCardIds)
		{
			return null;
		}

		[Token(Token = "0x60012FA")]
		[Address(RVA = "0x3DDC7AC", Offset = "0x3DD87AC", VA = "0x3DDC7AC")]
		private string FindCardOfRarity(RareLevel rarity, List<string> excludeIds, List<UserHeroCardData> heroCardInfos)
		{
			return null;
		}

		[Token(Token = "0x60012FB")]
		[Address(RVA = "0x3DDCC88", Offset = "0x3DD8C88", VA = "0x3DDCC88")]
		private List<string> Override8Handle(List<string> cardDeck)
		{
			return null;
		}

		[Token(Token = "0x60012FC")]
		[Address(RVA = "0x3DD9188", Offset = "0x3DD5188", VA = "0x3DD9188")]
		private List<string> RanDomAICardFollowFetter(string enemyCardConfig, [Optional] List<string> customCardListId)
		{
			return null;
		}

		[Token(Token = "0x60012FD")]
		[Address(RVA = "0x3DD6248", Offset = "0x3DD2248", VA = "0x3DD6248")]
		private void RecordEquipCardInfo([Optional] List<UserHeroCardData> cardData)
		{
		}

		[Token(Token = "0x60012FE")]
		[Address(RVA = "0x3DDDEF0", Offset = "0x3DD9EF0", VA = "0x3DDDEF0")]
		public List<int> GetBattleCardIDList()
		{
			return null;
		}

		[Token(Token = "0x60012FF")]
		[Address(RVA = "0x3DDE034", Offset = "0x3DDA034", VA = "0x3DDE034")]
		public int GetBattleCardLevel(int id)
		{
			return default;
		}

		[Token(Token = "0x6001300")]
		[Address(RVA = "0x3DDE0E4", Offset = "0x3DDA0E4", VA = "0x3DDE0E4")]
		public (GlobalArchitectureInfo, string) RandomRArchitectureLevelInfo(bool isMirror, HexType hexType, bool isInit)
		{
			return default;
		}

		[Token(Token = "0x6001301")]
		[Address(RVA = "0x3DDE7B4", Offset = "0x3DDA7B4", VA = "0x3DDE7B4")]
		public (GlobalArchitectureInfo, string) RandomSRArchitectureLevelInfo(bool isMirror, HexType hexType, bool isInit)
		{
			return default;
		}

		[Token(Token = "0x6001302")]
		[Address(RVA = "0x3DDE980", Offset = "0x3DDA980", VA = "0x3DDE980")]
		public (GlobalArchitectureInfo, string) RandomSSRArchitectureLevelInfo(bool isMirror, HexType hexType, bool isInit)
		{
			return default;
		}

		[Token(Token = "0x6001303")]
		[Address(RVA = "0x3DDEB4C", Offset = "0x3DDAB4C", VA = "0x3DDEB4C")]
		public (GlobalArchitectureInfo, string) RandomSSSRArchitectureLevelInfo(bool isMirror, HexType hexType, bool isInit)
		{
			return default;
		}

		[Token(Token = "0x6001304")]
		[Address(RVA = "0x3DDE454", Offset = "0x3DDA454", VA = "0x3DDE454")]
		private string GetAICardDeckByHexType(HexType type, RareLevel rare, bool isInit)
		{
			return null;
		}

		[Token(Token = "0x6001305")]
		[Address(RVA = "0x3DDED18", Offset = "0x3DDAD18", VA = "0x3DDED18")]
		private List<GlobalHeroCardInfo> GetOrcMeleeInfo()
		{
			return null;
		}

		[Token(Token = "0x6001306")]
		[Address(RVA = "0x3DDEEC0", Offset = "0x3DDAEC0", VA = "0x3DDEEC0")]
		private List<GlobalHeroCardInfo> GetOrcRemoteInfo()
		{
			return null;
		}

		[Token(Token = "0x6001307")]
		[Address(RVA = "0x3DDF06C", Offset = "0x3DDB06C", VA = "0x3DDF06C")]
		private List<GlobalHeroCardInfo> GetHumanMeleeInfo()
		{
			return null;
		}

		[Token(Token = "0x6001308")]
		[Address(RVA = "0x3DDF218", Offset = "0x3DDB218", VA = "0x3DDF218")]
		private List<GlobalHeroCardInfo> GetHumanRemoteInfo()
		{
			return null;
		}

		[Token(Token = "0x6001309")]
		[Address(RVA = "0x3DDF3C8", Offset = "0x3DDB3C8", VA = "0x3DDF3C8")]
		private List<GlobalHeroCardInfo> GetUnDeadMeleeInfo()
		{
			return null;
		}

		[Token(Token = "0x600130A")]
		[Address(RVA = "0x3DDF574", Offset = "0x3DDB574", VA = "0x3DDF574")]
		private List<GlobalHeroCardInfo> GetUnDeadRemoteInfo()
		{
			return null;
		}

		[Token(Token = "0x600130B")]
		[Address(RVA = "0x3DDF724", Offset = "0x3DDB724", VA = "0x3DDF724")]
		private List<GlobalHeroCardInfo> GetMachineRemoteInfo()
		{
			return null;
		}

		[Token(Token = "0x600130C")]
		[Address(RVA = "0x3DDF918", Offset = "0x3DDB918", VA = "0x3DDF918")]
		private List<GlobalHeroCardInfo> GetMachineDefenseInfo()
		{
			return null;
		}

		[Token(Token = "0x600130D")]
		[Address(RVA = "0x3DDFB0C", Offset = "0x3DDBB0C", VA = "0x3DDFB0C")]
		private List<GlobalHeroCardInfo> GetMachineMeleeInfo()
		{
			return null;
		}

		[Token(Token = "0x600130E")]
		[Address(RVA = "0x3DDD5E4", Offset = "0x3DD95E4", VA = "0x3DDD5E4")]
		private List<string> RandomSingleRaceDeck(CardFettersType raceType)
		{
			return null;
		}

		[Token(Token = "0x600130F")]
		[Address(RVA = "0x3DDFD6C", Offset = "0x3DDBD6C", VA = "0x3DDFD6C")]
		public (GlobalArchitectureInfo, string) RandomRArchitectureLevelInfoAndNoGoldMine()
		{
			return default;
		}

		[Token(Token = "0x6001310")]
		[Address(RVA = "0x3DDFFBC", Offset = "0x3DDBFBC", VA = "0x3DDFFBC")]
		public (GlobalArchitectureInfo, string, string) RandomBarracksArchitectureInfo()
		{
			return default;
		}

		[Token(Token = "0x6001311")]
		[Address(RVA = "0x3DE025C", Offset = "0x3DDC25C", VA = "0x3DE025C")]
		public (GlobalArchitectureInfo, string) RandomSRArchitectureLevelInfoAndNoDef()
		{
			return default;
		}

		[Token(Token = "0x6001312")]
		[Address(RVA = "0x3DE04AC", Offset = "0x3DDC4AC", VA = "0x3DE04AC")]
		public AIBehaviourManager()
		{
		}
	}
}
