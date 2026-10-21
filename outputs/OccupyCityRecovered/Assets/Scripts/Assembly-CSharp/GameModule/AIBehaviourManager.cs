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
			try
			{
			    var self = _003C_003E4__this;
			    self.hasCoin = 50;
			    self.bornHasCoin = 50;
			    EventModule.EventManager.Instance.StartListening("EnemyRandomBattleCardData", self.EnemyRandomBattleData);
			    EventModule.EventManager.Instance.StartListening("GameSteerEndShowCardProbabilityPanel", self.AllowOpenHex);
			    EventModule.EventManager.Instance.StartListening("EnemyBeginOpenHex", self.EnemyOpenHexCountAdd);
			    EventModule.EventManager.Instance.StartListening("HasEnemyArchitectureWound", self.HasEnemyArchitectureWound);
			    EventModule.EventManager.Instance.StartListening("EnemyCreatResourcesAr", self.EnemyCreatResourcesAr);
			    EventModule.EventManager.Instance.StartListening("EnemyCreatBarracksAr", self.EnemyCreatBarracksAr);
			    EventModule.EventManager.Instance.StartListening("EnemyBarracksArDestroy", self.EnemyBarracksArDestroy);
			    EventModule.EventManager.Instance.StartListening("EnemyResourcesArDestroy", self.EnemyResourcesArDestroy);
			    EventModule.EventManager.Instance.StartListening("EnemyBarracksArDestroy", self.BuildDestroyToSendEmojis);
			    EventModule.EventManager.Instance.StartListening("EnemyResourcesArDestroy", self.BuildDestroyToSendEmojis);
			    EventModule.EventManager.Instance.StartListening("CountDownIsTen", self.SendWords);
			    EventModule.EventManager.Instance.StartListening("PlayerOpenGoldCard", self.SendWords);
			    EventModule.EventManager.Instance.StartListening("PlayerSendEmoji", self.PlayerSendEmoji);
			    EventModule.EventManager.Instance.StartListening("EnemyHornEmitIng", self.EnemyHornEmitIng);
			    EventModule.EventManager.Instance.StartListening("EnemyHornEmitEnd", self.EnemyHornEmitEnd);
			    EventModule.EventManager.Instance.StartListening("CallRecordEnemyInfo", self.CallRecordEnemyInfo);
			    EventModule.EventManager.Instance.StartListening("RandomEnemyMoraleNum", self.RandomEnemyMoraleNum);
			    EventModule.EventManager.Instance.StartListening("CloseMatchPanel", self.CloseMatchPanel);
			    EventModule.EventManager.Instance.StartListening("PauseGame", self.OnPauseGame);
			    EventModule.EventManager.Instance.StartListening("ResumeGame", self.OnResumeGame);
			}
			catch (System.Exception ex)
			{
			    _003C_003E1__state = -2;
			    _003C_003Et__builder.SetException(ex);
			    return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult();
		}

			[Token(Token = "0x600135C")]
			[Address(RVA = "0x3DE253C", Offset = "0x3DDE53C", VA = "0x3DE253C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			_003C_003Et__builder.SetStateMachine(stateMachine);
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
			try
			{
			    var self = _003C_003E4__this;
			    UniTask.Awaiter awaiter;
			    if (_003C_003E1__state == 0)
			    {
			        awaiter = _003C_003Eu__1;
			        _003C_003Eu__1 = default;
			        _003C_003E1__state = -1;
			        goto Resume;
			    }
			    self.forcedLengdaryProp = false;
			    if (SDKModule.ABTestManager.Instance.GamePlayImprove01IsBTest)
			    {
			        int value = UnityEngine.Random.Range(0, 10);
			        self.aiType = value <= 1 ? AIType.Gambling : value <= 5 ? AIType.Development : AIType.Offense;
			    }
			    else
			        self.aiType = (AIType)UnityEngine.Random.Range(0, 3);
			    UnityEngine.Debug.Log(self.aiType);
			    self.pTime = 0f;
			    self.goldCount = 0;
			    self.isFirstOpen = true;
			    self.jTime = 0f;
			    self.arFrontWoundTime = 0f;
			    self.isNoBeAttack = true;
			    self.openUnchartedHexCount = 0;
			    self.barCount = 0;
			    self.sTime = 0f;
			    self.lTime = 0f;
			    self.sendEmojiTimeNoLimit = true;
			    if (TrainingGroundManager.IsInGuidedGame)
			    {
			        int coin = TrainingGroundManager.Instance.GetEnemyInitialCoin();
			        self.hasCoin = coin;
			        self.bornHasCoin = coin;
			    }
			    else
			        self.hasCoin = self.bornHasCoin;
			    self._isGamePaused = false;
			    if (ArenaManager.Instance.GetUnLockArenaCount() >= 2)
			        self.crazySendEmoji = UnityEngine.Random.Range(0, 100) < 5;
			    self.sendEmojiTimeNoLimit = false;
			    if (DataManager.Instance.GlobalInfo == null)
			        throw new System.NullReferenceException();
			    int begin = BattleGameManager.Instance.PropBTestChargeTime[0];
			    self.propTime = UnityEngine.Random.Range(unchecked(begin + 10), BattleGameManager.Instance.PropBTestChargeTime[1]);
			    self._logicTime = 0f;
			    self._lastRealTime = UnityEngine.Time.time;
			    self._frontTime = DbtSaveDataManager_PlayerGuideData.I.Data.isFirstThroghGame ? float.MaxValue : self._logicTime - (self._openHexTimeOffset + -3f);
			    self.isPriorityOpenSpecialNearrHex = false;
			    string arena = StringTool.IsNullOrEmpty(CoreGameManager.NowPlayEdArenaID, true) ? "1001" : CoreGameManager.NowPlayEdArenaID;
			    if (arena != "1001" && arena != "1002" && arena != "1003")
			    {
			        self.isPriorityOpenSpecialNearrHex = UnityEngine.Random.Range(0, 101) < 50;
			        UnityEngine.Debug.Log("这把想不想抢夺资源格子" + self.isPriorityOpenSpecialNearrHex.ToString());
			    }
			    awaiter = UniTask.WaitForSeconds(1, false, (PlayerLoopTiming)8, default, false).GetAwaiter();
			    if (!awaiter.IsCompleted)
			    {
			        _003C_003E1__state = 0;
			        _003C_003Eu__1 = awaiter;
			        _003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
			        return;
			    }
			Resume:
			    awaiter.GetResult();
			    self._isOpenHexing = true;
			    if (!QuickTutor.TutorialManager.Instance.IsStepComplete("1008"))
			    {
			        self._isOpenHexing = false;
			        self.moraleNum = 0;
			    }
			}
			catch (System.Exception ex)
			{
			    _003C_003E1__state = -2;
			    _003C_003Et__builder.SetException(ex);
			    return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult();
		}

			[Token(Token = "0x6001362")]
			[Address(RVA = "0x3DE37F0", Offset = "0x3DDF7F0", VA = "0x3DE37F0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			_003C_003Et__builder.SetStateMachine(stateMachine);
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
		public List<string> aiBattleCardID = new List<string>();

		[Token(Token = "0x4002848")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AIType aiType;

		[Token(Token = "0x4002849")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool isFirstOpen = true;

		[Token(Token = "0x400284A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
		private bool canAction;

		[Token(Token = "0x400284B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x66")]
		private bool _isGamePaused;

		[Token(Token = "0x400284C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private List<GlobalHeroCardInfo> _cardInfoList = new List<GlobalHeroCardInfo>();

		[Token(Token = "0x400284D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private List<GlobalHeroCardInfo> _cardRInfoList = new List<GlobalHeroCardInfo>();

		[Token(Token = "0x400284E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private List<GlobalHeroCardInfo> _cardSrInfoList = new List<GlobalHeroCardInfo>();

		[Token(Token = "0x400284F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private List<GlobalHeroCardInfo> _cardSsrInfoList = new List<GlobalHeroCardInfo>();

		[Token(Token = "0x4002850")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private List<GlobalHeroCardInfo> _cardSssrInfoList = new List<GlobalHeroCardInfo>();

		[Token(Token = "0x4002851")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private List<GlobalHeroCardInfo> _cardRNoGoldMineInfoList = new List<GlobalHeroCardInfo>();

		[Token(Token = "0x4002852")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Dictionary<int, DeadUnitInfo> GameDeadUnitInfoDic = new Dictionary<int, DeadUnitInfo>();

		[Token(Token = "0x4002853")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Dictionary<string, int> cardLevelDic = new Dictionary<string, int>();

		[Token(Token = "0x4002854")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Dictionary<string, int> cardTalentDic = new Dictionary<string, int>();

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
		private List<EnemyPropBattleEntry> _enemyPropDataList = new List<EnemyPropBattleEntry>();

		[Token(Token = "0x4002869")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private PropAttrSnapshot _currentEnemyPropAttrSnapshot = PropAttrSnapshot.Empty;

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
		private bool sendEmojiTimeNoLimit = true;

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
			return _isGamePaused || QuickTutor.TutorialManager.Instance.tutorialing;
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
			return _cardInfoList;
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
			int count = _orcsCount;
			return count > 5 ? 3 : count > 3 ? 2 : count > 1 ? 1 : 0;
		}
		}

		[Token(Token = "0x1700011E")]
		public int UndeadFetterLevel
		{
			[Token(Token = "0x60012B8")]
			[Address(RVA = "0x3DD233C", Offset = "0x3DCE33C", VA = "0x3DD233C")]
			get
			{
			int count = _unDeadCount;
			return count > 5 ? 3 : count > 3 ? 2 : count > 1 ? 1 : 0;
		}
		}

		[Token(Token = "0x1700011F")]
		public int TerranFetterLevel
		{
			[Token(Token = "0x60012B9")]
			[Address(RVA = "0x3DD236C", Offset = "0x3DCE36C", VA = "0x3DD236C")]
			get
			{
			int count = _terranCount;
			return count > 5 ? 3 : count > 3 ? 2 : count > 1 ? 1 : 0;
		}
		}

		[Token(Token = "0x17000120")]
		public int MachineFetterLevel
		{
			[Token(Token = "0x60012BA")]
			[Address(RVA = "0x3DD239C", Offset = "0x3DCE39C", VA = "0x3DD239C")]
			get
			{
			int count = _machineCount;
			return count > 5 ? 3 : count > 3 ? 2 : count > 1 ? 1 : 0;
		}
		}

		[Token(Token = "0x17000121")]
		public int MeleeFetterLevel
		{
			[Token(Token = "0x60012BB")]
			[Address(RVA = "0x3DD23CC", Offset = "0x3DCE3CC", VA = "0x3DD23CC")]
			get
			{
			int count = _meleeCount;
			return count > 6 ? 3 : count > 4 ? 2 : count > 2 ? 1 : 0;
		}
		}

		[Token(Token = "0x17000122")]
		public int RemoteFetterLevel
		{
			[Token(Token = "0x60012BC")]
			[Address(RVA = "0x3DD23FC", Offset = "0x3DCE3FC", VA = "0x3DD23FC")]
			get
			{
			int count = _remoteCount;
			return count > 6 ? 3 : count > 4 ? 2 : count > 2 ? 1 : 0;
		}
		}

		[Token(Token = "0x17000123")]
		public bool EqipDefenseArrowTowerCard
		{
			[Token(Token = "0x60012BD")]
			[Address(RVA = "0x3DD242C", Offset = "0x3DCE42C", VA = "0x3DD242C")]
			get
			{
			return _cardInfoList != null && System.Linq.Enumerable.Any(_cardInfoList, x => x.id == "1014");
		}
		}

		[Token(Token = "0x17000124")]
		public bool EqipDefenseCatapultsCard
		{
			[Token(Token = "0x60012BE")]
			[Address(RVA = "0x3DD2538", Offset = "0x3DCE538", VA = "0x3DD2538")]
			get
			{
			return _cardInfoList != null && System.Linq.Enumerable.Any(_cardInfoList, x => x.id == "1015");
		}
		}

		[Token(Token = "0x17000125")]
		public bool EqipDefenseCard
		{
			[Token(Token = "0x60012BF")]
			[Address(RVA = "0x3DCF580", Offset = "0x3DCB580", VA = "0x3DCF580")]
			get
			{
			return _cardInfoList != null && (EqipDefenseCatapultsCard || EqipDefenseArrowTowerCard);
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
			_003CInit_003Ed__100 stateMachine = default;
			stateMachine._003C_003Et__builder = AsyncUniTaskMethodBuilder.Create();
			stateMachine._003C_003E4__this = this;
			stateMachine._003C_003E1__state = -1;
			stateMachine._003C_003Et__builder.Start(ref stateMachine);
			return stateMachine._003C_003Et__builder.Task;
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
			canAction = true;
			bool guided = TrainingGroundManager.IsInGuidedGame;
			float value = _logicTime;
			if (!guided)
			    value = (value - _openHexTimeOffset) + UnityEngine.Random.Range(0.8f, 1.5f);
			_frontTime = value;
		}

		[Token(Token = "0x60012C8")]
		[Address(RVA = "0x3DD297C", Offset = "0x3DCE97C", VA = "0x3DD297C")]
		private void EnemyOpenHexCountAdd(object o)
		{
			openHexCount = unchecked(openHexCount + 1);
		}

		[Token(Token = "0x60012C9")]
		[Address(RVA = "0x3DD298C", Offset = "0x3DCE98C", VA = "0x3DD298C")]
		private void HasEnemyArchitectureWound(object o)
		{
			isNoBeAttack = false;
		}

		[Token(Token = "0x60012CA")]
		[Address(RVA = "0x3DD2994", Offset = "0x3DCE994", VA = "0x3DD2994")]
		private void EnemyCreatResourcesAr(object o)
		{
			goldCount = unchecked(goldCount + 1);
		}

		[Token(Token = "0x60012CB")]
		[Address(RVA = "0x3DD29A4", Offset = "0x3DCE9A4", VA = "0x3DD29A4")]
		private void EnemyCreatBarracksAr(object o)
		{
			barCount = unchecked(barCount + 1);
		}

		[Token(Token = "0x60012CC")]
		[Address(RVA = "0x3DD29B4", Offset = "0x3DCE9B4", VA = "0x3DD29B4")]
		private void EnemyBarracksArDestroy(object o)
		{
			barCount = unchecked(barCount - 1);
		}

		[Token(Token = "0x60012CD")]
		[Address(RVA = "0x3DD29C4", Offset = "0x3DCE9C4", VA = "0x3DD29C4")]
		private void EnemyResourcesArDestroy(object o)
		{
			goldCount = unchecked(goldCount - 1);
		}

		[Token(Token = "0x60012CE")]
		[Address(RVA = "0x3DD29D4", Offset = "0x3DCE9D4", VA = "0x3DD29D4")]
		private void Update()
		{
			float now = UnityEngine.Time.time;
			float previous = _lastRealTime;
			_lastRealTime = now;
			if (previous <= 0f)
			    previous = now;
			if (CoreGameManager.Gaming && !IsGamePaused)
			{
			    float elapsed = now - previous;
			    _logicTime = elapsed + _logicTime;
			}
			if (!CoreGameManager.Gaming || !_isOpenHexing || !canAction || IsGamePaused)
			    return;
			if (_logicTime - _frontTime >= _openHexTimeOffset)
			{
			    EnemyOpenHex(IsHard);
			    _frontTime = _logicTime;
			}
			if (!isNoBeAttack)
			    arFrontWoundTime += UnityEngine.Time.deltaTime;
			if (arFrontWoundTime > 1f)
			{
			    arFrontWoundTime = 0f;
			    isNoBeAttack = true;
			}
			SendEmojis();
			jTime += UnityEngine.Time.deltaTime;
			JudgmentPropTiming();
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
			_isGamePaused = paused;
		}

		[Token(Token = "0x60012D1")]
		[Address(RVA = "0x3DD3A20", Offset = "0x3DCFA20", VA = "0x3DD3A20")]
		private void OnPauseGame(object o)
		{
			_isGamePaused = true;
		}

		[Token(Token = "0x60012D2")]
		[Address(RVA = "0x3DD3A2C", Offset = "0x3DCFA2C", VA = "0x3DD3A2C")]
		private void OnResumeGame(object o)
		{
			_isGamePaused = false;
		}

		[Token(Token = "0x60012D3")]
		[Address(RVA = "0x3DD39AC", Offset = "0x3DCF9AC", VA = "0x3DD39AC")]
		private void ReleaseProp()
		{
			PropManager.Instance.EnemyTriggerProp(propId, default(UnityEngine.Vector3?));
			OnArtifactAIReleased();
		}

		[Token(Token = "0x60012D4")]
		[Address(RVA = "0x3DD3A34", Offset = "0x3DCFA34", VA = "0x3DD3A34")]
		internal void OnArtifactAIReleased()
		{
			propUsedCount = unchecked(propUsedCount + 1);
			if (SDKModule.ABTestManager.Instance.NewArtifactsPlayIsBTest)
			    return;
			float nextTime = -1f;
			if (SDKModule.ABTestManager.Instance.MaxArtifactUsageIsOn)
			{
			    if (propUsedCount == 2)
			    {
			        var times = BattleGameManager.Instance.PropBTestChargeTime;
			        nextTime = times[times.Length - 1];
			    }
			    else if (propUsedCount < 2)
			    {
			        int minimum = BattleGameManager.Instance.PropBTestChargeTime[propUsedCount];
			        int maximum = BattleGameManager.Instance.PropBTestChargeTime[unchecked(propUsedCount + 1)];
			        nextTime = UnityEngine.Random.Range(minimum, maximum);
			    }
			}
			propTime = nextTime;
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
			var all = BattleGameSceneManager.Instance.allEnemyStayOpenHexObjBehaviours;
			if (all.Count == 0) return;
			var enemyCanOpenObj = new List<HexBehaviour>();
			var resourcesHex = new List<HexBehaviour>();
			var unchartedHex = new List<HexBehaviour>();
			var barracksHex = new List<HexBehaviour>();
			for (int i = 0; i < all.Count; i++)
			    if (all[i].canOpen && !all[i].isBridge) enemyCanOpenObj.Add(all[i]);
			for (int i = 0; i < enemyCanOpenObj.Count; i++)
			{
			    if (enemyCanOpenObj[i].hexUIType == HexType.resources || enemyCanOpenObj[i].hexUIType == HexType.defense)
			        resourcesHex.Add(enemyCanOpenObj[i]);
			    else if (enemyCanOpenObj[i].hexUIType == HexType.UnCharted)
			        unchartedHex.Add(enemyCanOpenObj[i]);
			    else if (enemyCanOpenObj[i].hexUIType == HexType.barracks || enemyCanOpenObj[i].hexUIType == HexType.soldierpile)
			        barracksHex.Add(enemyCanOpenObj[i]);
			}
			if (enemyCanOpenObj.Count == 0) return;
			if (TrainingGroundManager.IsInGuidedGame && TrainingGroundManager.Instance.TryGetNextEnemyFlipPos(out UnityEngine.Vector3 target))
			{
			    HexBehaviour fixedHex = null;
			    foreach (HexBehaviour item in enemyCanOpenObj)
			    {
			        UnityEngine.Vector3 position = item.transform.position;
			        if (UnityEngine.Mathf.Abs(position.x - target.x) < 0.01f && UnityEngine.Mathf.Abs(position.z - target.z) < 0.01f)
			        { fixedHex = item; break; }
			    }
			    if (fixedHex != null && fixedHex.price <= hasCoin)
			    {
			        ChangeCoin(unchecked(-fixedHex.price));
			        fixedHex.OpenHex(true, isHard);
			        if (TrainingGroundManager.Instance.TryGetNextEnemyFlipInterval(out float interval)) _openHexTimeOffset = interval;
			        if (isFirstOpen) isFirstOpen = false;
			        return;
			    }
			}
			List<HexBehaviour> preferredHexes = new List<HexBehaviour>();
			if (aiType == AIType.Development) preferredHexes = resourcesHex;
			else if (aiType == AIType.Gambling) preferredHexes = unchartedHex;
			else if (aiType == AIType.Offense) preferredHexes = barracksHex;
			if (!isFirstOpen)
			{
			    if (aiType == AIType.Development) Development(isHard, resourcesHex, unchartedHex, barracksHex, enemyCanOpenObj);
			    else if (aiType == AIType.Gambling) Gambling(isHard, resourcesHex, unchartedHex, barracksHex, enemyCanOpenObj);
			    else if (aiType == AIType.Offense) Offense(isHard, resourcesHex, unchartedHex, barracksHex, enemyCanOpenObj);
			    return;
			}
			HexBehaviour selected = null;
			if (preferredHexes.Count != 0)
			{
			    selected = preferredHexes[UnityEngine.Random.Range(0, preferredHexes.Count)];
			    while (selected.price > hasCoin)
			    {
			        preferredHexes.Remove(selected);
			        // Original retains the last removed object when Count becomes zero.
			        if (preferredHexes.Count == 0) break;
			        selected = preferredHexes[UnityEngine.Random.Range(0, preferredHexes.Count)];
			    }
			}
			if (selected == null)
			{
			    var fallback = new List<HexBehaviour>(enemyCanOpenObj);
			    if (fallback.Count != 0)
			    {
			        selected = fallback[UnityEngine.Random.Range(0, fallback.Count)];
			        while (true)
			        {
			            // Original performs a CLR-null check before price, not Unity null.
			            if (object.ReferenceEquals(selected, null)) throw new System.NullReferenceException();
			            if (selected.price <= hasCoin) break;
			            fallback.Remove(selected);
			            if (fallback.Count == 0) break;
			            selected = fallback[UnityEngine.Random.Range(0, fallback.Count)];
			            if (fallback.Count < 2) break;
			        }
			    }
			}
			if (selected != null)
			{
			    ChangeCoin(unchecked(-selected.price));
			    selected.OpenHex(true, isHard);
			    if (TrainingGroundManager.IsInGuidedGame && TrainingGroundManager.Instance.TryGetNextEnemyFlipInterval(out float interval))
			        _openHexTimeOffset = interval;
			}
			isFirstOpen = false;
		}

		[Token(Token = "0x60012DA")]
		[Address(RVA = "0x3DD3FF0", Offset = "0x3DCFFF0", VA = "0x3DD3FF0")]
		private void Development(bool isHard, List<HexBehaviour> resourcesHex, List<HexBehaviour> unchartedHex, List<HexBehaviour> barracksHex, List<HexBehaviour> enemyCanOpenObj)
		{
			HexBehaviour selected;
			if (jTime >= 30f)
			{
			    selected = TryOpenHex(enemyCanOpenObj, new List<HexBehaviour>(), hasCoin, true, false);
			}
			else if (isNoBeAttack)
			{
			    List<HexBehaviour> preferredHexes = resourcesHex;
			    if (resourcesHex.Count <= 0)
			        preferredHexes = UnityEngine.Random.Range(0, 101) >= 10 ? barracksHex : unchartedHex;
			    enemyCanOpenObj.RemoveAll(item => preferredHexes.Contains(item));
			    selected = TryOpenHex(preferredHexes, enemyCanOpenObj, hasCoin, false, true);
			}
			else
			{
			    List<HexBehaviour> preferredHexes = barracksHex;
			    if (barracksHex.Count <= 0)
			        preferredHexes = unchartedHex.Count <= 0 ? resourcesHex : unchartedHex;
			    enemyCanOpenObj.RemoveAll(item => preferredHexes.Contains(item));
			    selected = TryOpenHex(preferredHexes, enemyCanOpenObj, hasCoin, false, true);
			}
			if (selected != null)
			{
			    ChangeCoin(unchecked(-selected.price));
			    selected.OpenHex(true, isHard);
			}
		}

		[Token(Token = "0x60012DB")]
		[Address(RVA = "0x3DD429C", Offset = "0x3DD029C", VA = "0x3DD429C")]
		private void Gambling(bool isHard, List<HexBehaviour> resourcesHex, List<HexBehaviour> unchartedHex, List<HexBehaviour> barracksHex, List<HexBehaviour> enemyCanOpenObj)
		{
			List<HexBehaviour> preferredHexes = new List<HexBehaviour>();
			int roll = UnityEngine.Random.Range(0, 101);
			int threshold = openUnchartedHexCount <= 2 ? 50 : 20;
			if (roll < threshold && unchartedHex.Count > 0)
			    preferredHexes = unchartedHex;
			else
			{
			    preferredHexes = UnityEngine.Random.Range(0, 101) >= 50 ? barracksHex : resourcesHex;
			    if (preferredHexes.Count <= 0)
			    {
			        if (resourcesHex.Count != 0 || barracksHex.Count != 0)
			            preferredHexes = resourcesHex.Count <= 0 ? barracksHex : resourcesHex;
			        else preferredHexes = unchartedHex;
			    }
			}
			enemyCanOpenObj.RemoveAll(item => preferredHexes.Contains(item));
			HexBehaviour selected = TryOpenHex(preferredHexes, enemyCanOpenObj, hasCoin, false, false);
			if (selected != null)
			{
			    int price = selected.price;
			    int count = openUnchartedHexCount;
			    if (price == 25)
			    {
			        count = unchecked(count + 1);
			        if (count == 4) count = 1;
			        openUnchartedHexCount = count;
			    }
			    else if (count == 4) openUnchartedHexCount = 1;
			    ChangeCoin(unchecked(-price));
			    selected.OpenHex(true, isHard);
			}
		}

		[Token(Token = "0x60012DC")]
		[Address(RVA = "0x3DD4530", Offset = "0x3DD0530", VA = "0x3DD4530")]
		private void Offense(bool isHard, List<HexBehaviour> resourcesHex, List<HexBehaviour> unchartedHex, List<HexBehaviour> barracksHex, List<HexBehaviour> enemyCanOpenObj)
		{
			List<HexBehaviour> preferredHexes = new List<HexBehaviour>();
			if (goldCount == 0 && resourcesHex.Count >= 1)
			    preferredHexes = resourcesHex;
			else if (barCount == 0 && barracksHex.Count >= 1)
			    preferredHexes = barracksHex;
			else if (barCount <= goldCount)
			{
			    if (UnityEngine.Random.Range(0, 101) <= 9 && unchartedHex.Count >= 1)
			        preferredHexes = unchartedHex;
			    else
			    {
			        preferredHexes = barracksHex;
			        if (barracksHex.Count <= 0)
			            preferredHexes = resourcesHex.Count > 0 ? resourcesHex : unchartedHex;
			    }
			}
			else
			{
			    double ratio = (double)barCount / (double)goldCount;
			    double percentage = ratio * 100.0 / (ratio + 1.0);
			    // Original FCVTZS: NaN=>0, saturating signed conversion; +infinity is explicitly overridden.
			    int converted = double.IsPositiveInfinity(percentage) ? int.MinValue :
			        double.IsNaN(percentage) ? 0 : percentage >= int.MaxValue ? int.MaxValue :
			        percentage <= int.MinValue ? int.MinValue : (int)percentage;
			    int threshold = converted >= 80 ? 80 : converted;
			    preferredHexes = UnityEngine.Random.Range(0, 101) < threshold ? resourcesHex :
			        UnityEngine.Random.Range(0, 101) < 10 ? unchartedHex : barracksHex;
			    if (preferredHexes.Count <= 0)
			    {
			        if (resourcesHex == null || barracksHex == null) throw new System.NullReferenceException();
			        int barracksCount = barracksHex.Count;
			        if (resourcesHex.Count > 0)
			        {
			            preferredHexes = barracksHex;
			            if (barracksCount <= 0)
			                preferredHexes = unchartedHex.Count > 0 ? unchartedHex : resourcesHex;
			        }
			        else preferredHexes = barracksCount > 0 ? barracksHex : unchartedHex;
			    }
			}
			enemyCanOpenObj.RemoveAll(item => preferredHexes.Contains(item));
			HexBehaviour selected = TryOpenHex(preferredHexes, enemyCanOpenObj, hasCoin, false, true);
			if (selected != null)
			{
			    ChangeCoin(unchecked(-selected.price));
			    selected.OpenHex(true, isHard);
			}
		}

		[Token(Token = "0x60012DD")]
		[Address(RVA = "0x3DD4A9C", Offset = "0x3DD0A9C", VA = "0x3DD4A9C")]
		private static int GetLegendaryTileV1BasePrice()
		{
			return BattleGameSceneManager.GetLegendaryTileV1Price();
		}

		[Token(Token = "0x60012DE")]
		[Address(RVA = "0x3DD4AEC", Offset = "0x3DD0AEC", VA = "0x3DD4AEC")]
		private static bool CandidateUnionHasOpenableLegendary(List<HexBehaviour> preferredHexes, List<HexBehaviour> fallbackHexes)
		{
			if (preferredHexes != null)
			{
			    for (int i = 0; i < preferredHexes.Count; i++)
			    {
			        HexBehaviour hex = preferredHexes[i];
			        if (hex != null && hex.LegendaryTileGuaranteed && hex.canOpen && !hex.isBridge)
			            return true;
			    }
			}
			if (fallbackHexes != null)
			{
			    for (int i = 0; i < fallbackHexes.Count; i++)
			    {
			        HexBehaviour hex = fallbackHexes[i];
			        if (hex != null && hex.LegendaryTileGuaranteed && hex.canOpen && !hex.isBridge)
			            return true;
			    }
			}
			return false;
		}

		[Token(Token = "0x60012DF")]
		[Address(RVA = "0x3DD4C78", Offset = "0x3DD0C78", VA = "0x3DD4C78")]
		private bool ShouldReserveGoldForOpenableLegendary(int coin, List<HexBehaviour> preferredHexes, List<HexBehaviour> fallbackHexes)
		{
			int minLegendaryPriceNotYetAffordable = int.MaxValue;
			if (!BattleGameSceneManager.IsLegendaryTileV1EnabledThisBattle() || nowDifficultLevel < 2 || isFirstOpen ||
			    !CandidateUnionHasOpenableLegendary(preferredHexes, fallbackHexes))
			    return false;
			var scene = BattleGameSceneManager.Instance;
			if (scene == null)
			    return false;
			// Original reads both list references before reading either Count.
			var enemyOpened = scene.allEnemyHasOpenHexObj;
			if (enemyOpened == null) throw new System.NullReferenceException();
			var playerOpened = scene.allPlayerHasOpenHexObj;
			if (playerOpened == null) throw new System.NullReferenceException();
			int playerCount = playerOpened.Count;
			int enemyCount = enemyOpened.Count;
			if (playerCount != 0)
			{
			    if (playerCount >= 1 && (float)playerCount * 1.3f < (float)enemyCount)
			        return false;
			}
			else if (enemyCount >= 1)
			    return false;
			ConsiderList(preferredHexes);
			ConsiderList(fallbackHexes);
			return minLegendaryPriceNotYetAffordable != int.MaxValue;
			
			void ConsiderList(List<HexBehaviour> list)
			{
			    if (list == null) return;
			    for (int i = 0; i < list.Count; i++)
			    {
			        HexBehaviour item = list[i];
			        if (item == null) continue;
			        if (item.LegendaryTileGuaranteed && item.canOpen && !item.isBridge)
			        {
			            int price = item.price;
			            if (price > coin && price < minLegendaryPriceNotYetAffordable)
			                minLegendaryPriceNotYetAffordable = price;
			        }
			    }
			}
		}

		[Token(Token = "0x60012E0")]
		[Address(RVA = "0x3DD4F20", Offset = "0x3DD0F20", VA = "0x3DD4F20")]
		private HexBehaviour ApplyLegendaryTileV1AiPreference(HexBehaviour hbDefault, List<HexBehaviour> preferredHexes, List<HexBehaviour> fallbackHexes, int coin)
		{
			if (!BattleGameSceneManager.IsLegendaryTileV1EnabledThisBattle() || nowDifficultLevel < 2)
			    return hbDefault;
			if (!CandidateUnionHasOpenableLegendary(preferredHexes, fallbackHexes) || GetLegendaryTileV1BasePrice() > coin)
			    return hbDefault;
			var affordableLegendary = new List<HexBehaviour>();
			var unionOpenable = new List<HexBehaviour>();
			var pathAnchorsNonLegend = new List<HexBehaviour>();
			AddUnion(preferredHexes);
			AddUnion(fallbackHexes);
			for (int i = 0; i < unionOpenable.Count; i++)
			{
			    HexBehaviour item = unionOpenable[i];
			    if (item.LegendaryTileGuaranteed)
			    {
			        if (item.price <= coin) affordableLegendary.Add(item);
			    }
			    else pathAnchorsNonLegend.Add(item);
			}
			if (affordableLegendary.Count == 0) return hbDefault;
			var scene = BattleGameSceneManager.Instance;
			var enemyOpened = scene.allEnemyHasOpenHexObj;
			if (enemyOpened == null) throw new System.NullReferenceException();
			var playerOpened = scene.allPlayerHasOpenHexObj;
			if (playerOpened == null) throw new System.NullReferenceException();
			int playerCount = playerOpened.Count;
			int enemyCount = enemyOpened.Count;
			int maxDistance = 2;
			bool allowWithoutAnchor = false;
			if (playerCount != 0)
			{
			    if (playerCount >= 1)
			    {
			        if ((float)playerCount * 1.3f < (float)enemyCount) return hbDefault;
			        if ((float)playerCount * 0.7f > (float)enemyCount)
			        {
			            maxDistance = 4;
			            allowWithoutAnchor = true;
			        }
			    }
			}
			else if (enemyCount >= 1) return hbDefault;
			HexBehaviour best = null;
			int bestDistance = int.MaxValue;
			for (int i = 0; i < affordableLegendary.Count; i++)
			{
			    HexBehaviour item = affordableLegendary[i];
			    int distance = MinPathDistToLegend(item);
			    bool allowed = pathAnchorsNonLegend.Count != 0 ? distance <= maxDistance : allowWithoutAnchor;
			    if (allowed)
			    {
			        // ASM evaluates Unity equality even when distance already wins.
			        bool bestIsNull = best == null;
			        if (distance < bestDistance || bestIsNull || (distance == bestDistance && UnityEngine.Random.Range(0, 2) == 0))
			        {
			            bestDistance = distance;
			            best = item;
			        }
			    }
			}
			return best != null ? best : hbDefault;
			
			void AddUnion(List<HexBehaviour> list)
			{
			    if (list == null) return;
			    for (int i = 0; i < list.Count; i++)
			    {
			        HexBehaviour item = list[i];
			        if (item == null || !item.canOpen) continue;
			        bool found = false;
			        for (int j = 0; j < unionOpenable.Count; j++)
			        {
			            if (unionOpenable[j] == item) { found = true; break; }
			        }
			        if (!found) unionOpenable.Add(item);
			    }
			}
			int MinPathDistToLegend(HexBehaviour legendary)
			{
			    int minDistance = int.MaxValue;
			    for (int i = 0; i < pathAnchorsNonLegend.Count; i++)
			    {
			        HexBehaviour anchor = pathAnchorsNonLegend[i];
			        int distance = HexManager.HexDistance(anchor.HexCoord, legendary.HexCoord);
			        if (distance < minDistance) minDistance = distance;
			    }
			    return minDistance;
			}
		}

		[Token(Token = "0x60012E1")]
		[Address(RVA = "0x3DD4888", Offset = "0x3DD0888", VA = "0x3DD4888")]
		private HexBehaviour TryOpenHex(List<HexBehaviour> preferredHexes, List<HexBehaviour> fallbackHexes, int hasCoin, bool unchartedPreferRandom = false, bool unchartedfallbackRandom = false)
		{
			var specialNearHex = BattleGameSceneManager.Instance.GetSpecialNearHex();
			if (specialNearHex != null && isPriorityOpenSpecialNearrHex && specialNearHex.Count >= 1)
			{
			    for (int i = 0; i < specialNearHex.Count; i++)
			    {
			        if (specialNearHex[i].price <= hasCoin)
			        {
			            // Preserve original diagnostic and return the same indexed item.
			            UnityEngine.Debug.Log("去抢夺源格子,朝着它翻了");
			            return specialNearHex[i];
			        }
			    }
			}
			if (ShouldReserveGoldForOpenableLegendary(hasCoin, preferredHexes, fallbackHexes))
			    return null;
			var preferredCopy = new List<HexBehaviour>(preferredHexes);
			var fallbackCopy = new List<HexBehaviour>(fallbackHexes);
			HexBehaviour selected = TryOpenHexCore(preferredCopy, fallbackCopy, hasCoin, unchartedPreferRandom, unchartedfallbackRandom);
			return ApplyLegendaryTileV1AiPreference(selected, preferredHexes, fallbackHexes, hasCoin);
		}

		[Token(Token = "0x60012E2")]
		[Address(RVA = "0x3DD55F8", Offset = "0x3DD15F8", VA = "0x3DD55F8")]
		private HexBehaviour TryOpenHexCore(List<HexBehaviour> preferredHexes, List<HexBehaviour> fallbackHexes, int hasCoin, bool unchartedPreferRandom, bool unchartedfallbackRandom)
		{
			HexBehaviour hex = null;
			    if (preferredHexes.Count > 0)
			    {
			        hex = preferredHexes[UnityEngine.Random.Range(0, preferredHexes.Count)];
			        while (hex != null &&
			            (hex.price > hasCoin ||
			             (hasCoin > 25 && hex.price == 25 && unchartedPreferRandom &&
			              UnityEngine.Random.Range(0, 101) > 10)))
			        {
			            preferredHexes.Remove(hex);
			            if (preferredHexes.Count == 0)
			            {
			                hex = null;
			                break;
			            }
			            hex = preferredHexes.Count > 0
			                ? preferredHexes[UnityEngine.Random.Range(0, preferredHexes.Count)]
			                : null;
			        }
			    }
			
			    if (hex == null && fallbackHexes.Count > 0)
			    {
			        hex = fallbackHexes[UnityEngine.Random.Range(0, fallbackHexes.Count)];
			        int retries = UnityEngine.Random.Range(0, fallbackHexes.Count);
			        if (retries <= 1)
			            retries = 1;
			        retries--;
			
			        while (hex != null &&
			            (hex.price > hasCoin ||
			             (hex.price == 25 && hasCoin > 25 && unchartedfallbackRandom &&
			              UnityEngine.Random.Range(0, 101) > 10)))
			        {
			            fallbackHexes.Remove(hex);
			            if (retries == 0 || fallbackHexes.Count == 0)
			            {
			                hex = null;
			                break;
			            }
			            hex = fallbackHexes.Count > 0
			                ? fallbackHexes[UnityEngine.Random.Range(0, fallbackHexes.Count)]
			                : null;
			            retries--;
			        }
			    }
			    return hex;
		}

		[Token(Token = "0x60012E3")]
		[Address(RVA = "0x3DD3EC4", Offset = "0x3DCFEC4", VA = "0x3DD3EC4")]
		public void ChangeCoin(int coinNum)
		{
			if (coinNum < 0)
			    EventModule.EventManager.Instance.TriggerEvent("EnemyGameCostCoin", unchecked(-coinNum));
			int updatedCoin = unchecked(hasCoin + coinNum);
			hasCoin = updatedCoin < 0 ? 0 : (updatedCoin > 10000000 ? 10000000 : updatedCoin);
			SubGameBuffManager.Instance.OnCoinChanged(true, hasCoin);
		}

		[Token(Token = "0x60012E4")]
		[Address(RVA = "0x3DD5880", Offset = "0x3DD1880", VA = "0x3DD5880")]
		public PropAttrSnapshot GetCurrentEnemyPropAttrSnapshot()
		{
			return _currentEnemyPropAttrSnapshot;
		}

		[Token(Token = "0x60012E5")]
		[Address(RVA = "0x3DD5888", Offset = "0x3DD1888", VA = "0x3DD5888")]
		public IReadOnlyList<EnemyPropBattleEntry> GetCurrentEnemyPropDataList()
		{
			return _enemyPropDataList;
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
			level = 1;
			startLevel = 0;
			if (string.IsNullOrEmpty(infoId) || _enemyPropDataList == null)
			    return false;
			for (int i = 0; i < _enemyPropDataList.Count; i++)
			{
			    EnemyPropBattleEntry entry = _enemyPropDataList[i];
			    if (entry != null && entry.infoId == infoId)
			    {
			        level = entry.level;
			        startLevel = entry.startLevel;
			        return true;
			    }
			}
			return false;
		}

		[Token(Token = "0x60012E8")]
		[Address(RVA = "0x3DD5D40", Offset = "0x3DD1D40", VA = "0x3DD5D40")]
		private void ApplyEnemyPropBattleData(EnemyBattleDataCofig enemyBattleData, GameType gameType)
		{
			if (enemyBattleData != null)
			{
			    int arenaLevel = EnemyPropBattleGenerator.ResolveArenaLevel();
			    if (enemyBattleData.enemyPropDataList == null || enemyBattleData.enemyPropDataList.Count == 0)
			        enemyBattleData.enemyPropDataList = EnemyPropBattleGenerator.BuildEnemyPropDataList(arenaLevel, gameType, default);
			    if (!string.IsNullOrEmpty(enemyBattleData.enemyPropId))
			        EnemyPropBattleGenerator.EnsureEquipInList(enemyBattleData.enemyPropDataList, enemyBattleData.enemyPropId, arenaLevel);
			    _enemyPropDataList = new List<EnemyPropBattleEntry>(enemyBattleData.enemyPropDataList);
			    if (enemyBattleData.enemyPropAttrSnapshot != null && !object.ReferenceEquals(enemyBattleData.enemyPropAttrSnapshot, PropAttrSnapshot.Empty))
			    {
			        _currentEnemyPropAttrSnapshot = enemyBattleData.enemyPropAttrSnapshot;
			        return;
			    }
			    _currentEnemyPropAttrSnapshot = EnemyPropBattleGenerator.BuildPropAttrSnapshot(_enemyPropDataList);
			    enemyBattleData.enemyPropAttrSnapshot = _currentEnemyPropAttrSnapshot;
			}
		}

		[Token(Token = "0x60012E9")]
		[Address(RVA = "0x3DD5E8C", Offset = "0x3DD1E8C", VA = "0x3DD5E8C")]
		[AsyncStateMachine(typeof(_003CStartGame_003Ed__146))]
		public void StartGame([Optional] EnemyBattleDataCofig enemyDataCofig)
		{
			_003CStartGame_003Ed__146 stateMachine = default;
			stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
			stateMachine._003C_003E4__this = this;
			stateMachine._003C_003E1__state = -1;
			stateMachine._003C_003Et__builder.Start(ref stateMachine);
		}

		[Token(Token = "0x60012EA")]
		[Address(RVA = "0x3DD5F18", Offset = "0x3DD1F18", VA = "0x3DD5F18")]
		private void CallRecordEnemyInfo(object o)
		{
			if (o is BattleContext context && context.enemyDataCofig != null)
			{
			    var data = context.enemyDataCofig;
			    RecordEnemyOpenHexTimeOffset(data.difficultLevel, context.GameType == GameType.PVE);
			    RefreshRecordEnemyBattleInfo(data, context.GameType);
			    RecordEquipCardInfo(data.GetCardList());
			}
		}

		[Token(Token = "0x60012EB")]
		[Address(RVA = "0x3DD6B70", Offset = "0x3DD2B70", VA = "0x3DD6B70")]
		private void EnemyRandomBattleData(object o)
		{
			EnemyBattleDataCofig data;
			if (TrainingGroundManager.IsInGuidedGame)
			{
			    var cards = TrainingGroundManager.Instance.GetFixedEnemyCardDeck();
			    nowDifficultLevel = TrainingGroundManager.Instance.GetFixedEnemyDifficultLevel();
			    RecordEnemyOpenHexTimeOffset(nowDifficultLevel, false);
			    data = GetEnemyBattleDataCofig(nowDifficultLevel, (GameType)0, cards);
			}
			else
			{
			    string current = CoreGameManager.NowPlayEdArenaID;
			    string balance = ArenaManager.Instance.GetEnemyContentBalanceArenaId();
			    bool fought = current != "1003" || ArenaManager.Instance.HasFoughtInArena("1003");
			    var balances = DataManager.Instance.GlobalInfo.arenaEnemyBalanceInfoDic;
			    if (fought)
			    {
			        int weight = StringTool.ToInt(balances[balance].weight);
			        int roll = UnityEngine.Random.Range(0, 10);
			        IsHard = roll >= weight;
			        if (DbtSaveDataManager_PlayerGuideData.I.Data.isFirstThroghGame) IsHard = false;
			        else if (roll >= weight) balance = unchecked(2 * StringTool.ToInt(balance)).ToString();
			    }
			    else IsHard = false;
			    nowDifficultLevel = StringTool.ToInt(balances[balance].difficultLevel);
			    if (UserLableManager.Instance.UserLableIsOpen()) nowDifficultLevel = UserLableManager.Instance.EnmeyDifficultyLevelHandle(nowDifficultLevel);
			    RecordEnemyOpenHexTimeOffset(nowDifficultLevel, false);
			    data = GetEnemyBattleDataCofig(nowDifficultLevel, (GameType)0, CheatControl.Instance.BattleCustomCards);
			}
			data.difficultLevel = nowDifficultLevel;
			RefreshRecordEnemyBattleInfo(data, (GameType)0);
			RecordEquipCardInfo();
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
			if (number == 0) return 0;
			return unchecked((int)System.Math.Round((double)number / 5.0, 0, System.MidpointRounding.AwayFromZero) * 5);
		}

		[Token(Token = "0x60012EE")]
		[Address(RVA = "0x3DD5FE8", Offset = "0x3DD1FE8", VA = "0x3DD5FE8")]
		public void RecordEnemyOpenHexTimeOffset(int difficultLevel, bool isPVE)
		{
			_openHexTimeOffset = StringTool.ToInt(DataManager.Instance.GlobalInfo.enemyDifficultLevelInfoDic[difficultLevel].moveInterval);
			if (!isPVE && UserLableManager.Instance.UserLableIsOpen())
			    _openHexTimeOffset = UserLableManager.Instance.EnmeyOpenHexOffsetHandle((int)_openHexTimeOffset);
			if (TrainingGroundManager.IsInGuidedGame && TrainingGroundManager.Instance.TryGetNextEnemyFlipInterval(out float interval))
			    _openHexTimeOffset = interval;
		}

		[Token(Token = "0x60012EF")]
		[Address(RVA = "0x3DD6F50", Offset = "0x3DD2F50", VA = "0x3DD6F50")]
		public EnemyBattleDataCofig GetEnemyBattleDataCofig(int difficultLevel, GameType gameType, [Optional] List<string> customCardId)
		{
			var result = new EnemyBattleDataCofig();
			var config = DataManager.Instance.GlobalInfo.enemyDifficultLevelInfoDic[difficultLevel];
			string artifactConfig = config.enemyArtifactCofig;
			var weights = artifactConfig.Split(',');
			float roll = UnityEngine.Random.Range(0f, 100f);
			int rare = 0;
			if (roll >= StringTool.ToFloat(weights[0]))
			{
			    if (roll < StringTool.ToFloat(weights[0]) + StringTool.ToFloat(weights[1])) rare = 1;
			    else if (roll < (StringTool.ToFloat(weights[0]) + StringTool.ToFloat(weights[1])) + StringTool.ToFloat(weights[2])) rare = 2;
			    else if (roll < ((StringTool.ToFloat(weights[0]) + StringTool.ToFloat(weights[1])) + StringTool.ToFloat(weights[2])) + StringTool.ToFloat(weights[3])) rare = 3;
			}
			if (SDKModule.ABTestManager.Instance.ArtifactsSystemIsBTest)
			{
			    if (ArenaManager.Instance.GetUnLockArenaCount() >= 3)
			    {
			        uint value = unchecked((uint)DbtSaveDataManager_PlayerCoreData.I.Data.PlayerGameCount * 0xCCCCCCCDu + 0x19999998u);
			        uint rotated = (value >> 2) | (value << 30);
			        if (rotated <= 0x0CCCCCCCu && (uint)gameType <= 3u && gameType != (GameType)1)
			        {
			            forcedLengdaryProp = true;
			            rare = 3;
			            propTime = UnityEngine.Random.Range(40, 60);
			        }
			    }
			}
			else rare = 0;
			int arenaLevel = EnemyPropBattleGenerator.ResolveArenaLevel();
			var context = new EnemyPropBuildContext { equipRareTarget = rare, requireLegendaryPool = forcedLengdaryProp || rare == 3 };
			result.enemyPropDataList = EnemyPropBattleGenerator.BuildEnemyPropDataList(arenaLevel, gameType, context);
			string equipped = EnemyPropBattleGenerator.PickEquippedPropId(result.enemyPropDataList, rare);
			if (!SDKModule.ABTestManager.Instance.ArtifactsSystemIsBTest || !ArenaProgressManager.Instance.ArtifactsIsUnLock()) equipped = "3001";
			if (!string.IsNullOrEmpty(CheatControl.Instance.BattleCustomPropId)) equipped = CheatControl.Instance.BattleCustomPropId;
			result.enemyPropId = equipped;
			EnemyPropBattleGenerator.EnsureEquipInList(result.enemyPropDataList, equipped, arenaLevel);
			result.enemyPropAttrSnapshot = EnemyPropBattleGenerator.BuildPropAttrSnapshot(result.enemyPropDataList);
			EnemyPropBattleGenerator.LogGenerateSummary(arenaLevel, difficultLevel, gameType, artifactConfig, rare, result.enemyPropDataList, equipped, result.enemyPropAttrSnapshot);
			if (SDKModule.ABTestManager.Instance.NewMainCity2)
			{
			    var levels = config.newMainCityLevel.Split(',');
			    result.attackLevel = UnityEngine.Random.Range(StringTool.ToInt(levels[0]), StringTool.ToInt(levels[1]));
			    result.hpLevel = UnityEngine.Random.Range(StringTool.ToInt(levels[0]), StringTool.ToInt(levels[1]));
			    var coins = config.newMainCityCoinRange.Split(',');
			    result.cdLevel = UnityEngine.Random.Range(StringTool.ToInt(coins[0]), StringTool.ToInt(coins[1]));
			}
			else
			{
			    var levels = config.mainCityLevel.Split(',');
			    result.attackLevel = UnityEngine.Random.Range(StringTool.ToInt(levels[0]), StringTool.ToInt(levels[1]));
			    result.hpLevel = UnityEngine.Random.Range(StringTool.ToInt(levels[0]), StringTool.ToInt(levels[1]));
			    result.cdLevel = UnityEngine.Random.Range(StringTool.ToInt(levels[0]), StringTool.ToInt(levels[1]));
			}
			UnityEngine.Debug.Log(string.Format("是否A组：{0}, 敌人等级：{1}  attackLevel = {2}, hpLevel = {3},cdLevel = {4}", new object[] { SDKModule.ABTestManager.Instance.NewMainCity2, difficultLevel, result.attackLevel, result.hpLevel, result.cdLevel }));
			result.info = RandomEnemyInfo(difficultLevel, gameType);
			result.battleCardIDList = RanDomAICardFollowFetter(config.enemyCardConfig, customCardId);
			var cardLevels = config.cardLevel.Split(',');
			if (result.cardLevelDic == null) result.cardLevelDic = new Dictionary<string, int>();
			for (int i = 0; i < result.battleCardIDList.Count; i++)
			{
			    var target = result.cardLevelDic;
			    string id = result.battleCardIDList[i];
			    int level = UnityEngine.Random.Range(StringTool.ToInt(cardLevels[0]), StringTool.ToInt(cardLevels[1]));
			    target.TryAdd(id, level);
			}
			if (DailyBlessManager.Instance.IsBTest() && QuickTutor.TutorialManager.Instance.IsStepComplete("1008") && QuickTutor.TutorialManager.Instance.IsStepComplete("1015") && (uint)gameType <= 3u && gameType != (GameType)1 && UnityEngine.Random.Range(0, 100) <= 49)
			    result.blessId = DailyBlessManager.Instance.GetRandomBlessId();
			if (CardTalent_2Manager.Instance.NewAbility2IsBTest())
			{
			    var baseInfos = DataManager.Instance.GlobalInfo.globalCardTalent2BaseInfoDic;
			    var prices = DataManager.Instance.GlobalInfo.upgradeTalentPriceDic;
			    if (result.cardTalentUnLockDic2 == null) result.cardTalentUnLockDic2 = new Dictionary<string, List<int>>();
			    for (int i = 0; i < result.battleCardIDList.Count; i++)
			    {
			        if (result.battleCardIDList[i] == "1001") continue;
			        var talents = new List<int>();
			        var info = baseInfos[result.battleCardIDList[i]];
			        var initial = info.cardHaveTalent.Split(';');
			        for (int j = 0; j < initial.Length; j++) talents.Add(StringTool.ToInt(initial[j]));
			        var epic = info.cardEpicTalent.Split(';');
			        for (int j = 0; j < epic.Length; j++)
			        {
			            var price = prices[unchecked(j + 1).ToString()];
			            if (result.cardLevelDic[result.battleCardIDList[i]] >= StringTool.ToInt(price.unlockLevel))
			            {
			                var talentWeights = config.enemyTalent2LevelWeight.Split(',');
			                int value = UnityEngine.Random.Range(0, 10);
			                if (value < StringTool.ToInt(talentWeights[0])) talents.Add(StringTool.ToInt(epic[j]));
			                else if (value < unchecked(StringTool.ToInt(talentWeights[0]) + StringTool.ToInt(talentWeights[1]))) talents.Add(unchecked(StringTool.ToInt(epic[j]) + 1));
			                else if (value < unchecked(unchecked(StringTool.ToInt(talentWeights[0]) + StringTool.ToInt(talentWeights[1])) + StringTool.ToInt(talentWeights[2]))) talents.Add(unchecked(StringTool.ToInt(epic[j]) + 2));
			            }
			        }
			        var gold = info.cardGoldTalent.Split(';');
			        for (int j = 0; j < gold.Length; j++)
			        {
			            var price = prices["3"];
			            if (HeroCardManager.Instance.GetCardIsSSSR(result.battleCardIDList[i]) || result.cardLevelDic[result.battleCardIDList[i]] >= StringTool.ToInt(price.unlockLevel))
			            {
			                var talentWeights = config.enemyTalent2LevelWeight.Split(',');
			                int value = UnityEngine.Random.Range(0, 10);
			                if (value < StringTool.ToInt(talentWeights[0])) talents.Add(StringTool.ToInt(gold[j]));
			                else if (value < unchecked(StringTool.ToInt(talentWeights[0]) + StringTool.ToInt(talentWeights[1]))) talents.Add(unchecked(StringTool.ToInt(gold[j]) + 1));
			                else if (value < unchecked(unchecked(StringTool.ToInt(talentWeights[0]) + StringTool.ToInt(talentWeights[1])) + StringTool.ToInt(talentWeights[2]))) talents.Add(unchecked(StringTool.ToInt(gold[j]) + 2));
			            }
			        }
			        result.cardTalentUnLockDic2.Add(result.battleCardIDList[i], talents);
			    }
			    return result;
			}
			var talentConfig = config.enemyCardTalentCofig.Split(';');
			var r = talentConfig[0].Split(',');
			var sr = talentConfig[1].Split(',');
			var ssr = talentConfig[2].Split(',');
			var sssr = talentConfig[3].Split(',');
			if (result.cardTalentDic == null) result.cardTalentDic = new Dictionary<string, int>();
			for (int i = 0; i < result.battleCardIDList.Count; i++)
			{
			    string id = result.battleCardIDList[i];
			    if (HeroCardManager.Instance.GetCardInfo(id).GetRareLevel() == (RareLevel)0) result.cardTalentDic.Add(id, UnityEngine.Mathf.Max(0, UnityEngine.Mathf.Min(35, UnityEngine.Random.Range(StringTool.ToInt(r[0]), StringTool.ToInt(r[1])))));
			    else if (HeroCardManager.Instance.GetCardInfo(id).GetRareLevel() == (RareLevel)1) result.cardTalentDic.Add(id, UnityEngine.Mathf.Max(0, UnityEngine.Mathf.Min(35, UnityEngine.Random.Range(StringTool.ToInt(sr[0]), StringTool.ToInt(sr[1])))));
			    else if (HeroCardManager.Instance.GetCardInfo(id).GetRareLevel() == (RareLevel)2) result.cardTalentDic.Add(id, UnityEngine.Mathf.Max(0, UnityEngine.Mathf.Min(35, UnityEngine.Random.Range(StringTool.ToInt(ssr[0]), StringTool.ToInt(ssr[1])))));
			    else if (HeroCardManager.Instance.GetCardInfo(id).GetRareLevel() == (RareLevel)3) result.cardTalentDic.Add(id, UnityEngine.Mathf.Max(0, UnityEngine.Mathf.Min(36, UnityEngine.Random.Range(StringTool.ToInt(sssr[0]), StringTool.ToInt(sssr[1])))));
			    int value = result.cardTalentDic[result.battleCardIDList[i]];
			    if (value >= result.cardLevelDic[result.battleCardIDList[i]]) result.cardTalentDic[result.battleCardIDList[i]] = unchecked(result.cardLevelDic[result.battleCardIDList[i]] - 1);
			}
			if (result.cardTalentUnLockDic == null) result.cardTalentUnLockDic = new Dictionary<string, List<int>>();
			foreach (var entry in result.cardTalentDic)
			    if (entry.Key != "1001") result.cardTalentUnLockDic.TryAdd(entry.Key, CardTalentManager.Instance.GetCardAllUnLockCardTalentNode(entry.Key, entry.Value));
			return result;
		}

		[Token(Token = "0x60012F0")]
		[Address(RVA = "0x3DD6148", Offset = "0x3DD2148", VA = "0x3DD6148")]
		public void RefreshRecordEnemyBattleInfo(EnemyBattleDataCofig enemyBattleData, GameType gameType = GameType.PVP)
		{
			_attackLevel = enemyBattleData.attackLevel;
			_hpLevel = enemyBattleData.hpLevel;
			_cdLevel = enemyBattleData.cdLevel;
			ItemInfo = enemyBattleData.info;
			ApplyEnemyPropBattleData(enemyBattleData, gameType);
			propId = enemyBattleData.enemyPropId;
			aiBattleCardID = System.Linq.Enumerable.ToList(enemyBattleData.battleCardIDList);
			cardLevelDic = new Dictionary<string, int>(enemyBattleData.cardLevelDic);
			cardTalentDic = enemyBattleData.cardTalentDic;
			cardAllUnlockTalent = enemyBattleData.cardTalentUnLockDic;
			cardAllHaveTalent = enemyBattleData.cardTalentUnLockDic2;
			blessId = enemyBattleData.blessId;
		}

		[Token(Token = "0x60012F1")]
		[Address(RVA = "0x3DDA8BC", Offset = "0x3DD68BC", VA = "0x3DDA8BC")]
		public int GetMainTowerTalentInfo()
		{
			if (SDKModule.ABTestManager.Instance.NewMainCity2)
			{
			    float total = unchecked(_hpLevel + _attackLevel + _cdLevel);
			    int extra = UnityEngine.Mathf.FloorToInt(total / 10f);
			    float level = unchecked(_attackLevel + extra + _hpLevel);
			    return UnityEngine.Mathf.CeilToInt(level / 50f);
			}
			var levels = new List<int> { _attackLevel, _hpLevel, _cdLevel };
			var source = DataManager.Instance.GlobalInfo.danInfos;
			var thresholds = new List<int>();
			for (int i = 0; i < 4; i++)
			    thresholds.Add(StringTool.ToInt(source[i].talentLimitLevel));
			thresholds.Reverse();
			for (int i = 0; i < thresholds.Count; i++)
			    for (int j = 0; j < levels.Count; j++)
			        if (levels[j] > thresholds[i]) return i;
			return -1;
		}

		[Token(Token = "0x60012F2")]
		[Address(RVA = "0x3DD8C94", Offset = "0x3DD4C94", VA = "0x3DD8C94")]
		public RankItemData RandomEnemyInfo(int difficultLevel, GameType gameType)
		{
			if (DbtSaveDataManager_PlayerRankData.I.Data.rankInfo.Count < 1) return null;
			var difficult = DataManager.Instance.GlobalInfo.enemyDifficultLevelInfoDic[difficultLevel];
			int arena = StringTool.ToInt(CoreGameManager.NowPlayEdArenaID);
			if (IsHard) arena = unchecked(2 * arena);
			var balance = DataManager.Instance.GlobalInfo.arenaEnemyBalanceInfoDic[arena.ToString()];
			var ranks = DbtSaveDataManager_PlayerRankData.I.Data.rankInfo;
			int trophies = 0;
			if (gameType == (GameType)1 || gameType == (GameType)2)
			{
			    var range = difficult.trophyCount.Split(',');
			    trophies = UnityEngine.Random.Range(StringTool.ToInt(range[0]), StringTool.ToInt(range[1]));
			}
			else if (gameType == (GameType)0 || gameType == (GameType)3)
			{
			    var range = balance.trophyCount.Split(',');
			    trophies = UnityEngine.Random.Range(StringTool.ToInt(range[0]), StringTool.ToInt(range[1]));
			    if (SDKModule.ABTestManager.Instance.NewArenaProcessIsBTest)
			    {
			        int dan = DbtSaveDataManager_PlayerArenaData.I.Data.DanNum;
			        int maxDan = ArenaManager.Instance.MaxDanNumber;
			        int minimum = StringTool.ToInt(DataManager.Instance.GlobalInfo.danInfos[unchecked(dan - 1)].trophyRequire);
			        if (dan == maxDan) trophies = unchecked(UnityEngine.Random.Range(100, 800) + minimum);
			        else trophies = UnityEngine.Random.Range(minimum, StringTool.ToInt(DataManager.Instance.GlobalInfo.danInfos[dan].trophyRequire));
			    }
			}
			_ = ranks[UnityEngine.Random.Range(0, ranks.Count)];
			RankItemData selected;
			do { selected = ranks[UnityEngine.Random.Range(0, ranks.Count)]; } while (selected.isPlayer);
			return new RankItemData { isPlayer = false, trophyNum = trophies, iconPath = selected.iconPath, name = selected.name };
		}

		[Token(Token = "0x60012F3")]
		[Address(RVA = "0x3DDAD24", Offset = "0x3DD6D24", VA = "0x3DDAD24")]
		public Dictionary<CardFettersType, int> GetFetterEnableConfig()
		{
            Dictionary<CardFettersType, int> result = new Dictionary<CardFettersType, int>();
            int count = _orcsCount;
            if (count >= 2) result.Add(CardFettersType.Orcs, count);
            count = _unDeadCount;
            if (count >= 2) result.Add(CardFettersType.Undead, count);
            count = _terranCount;
            if (count >= 2) result.Add(CardFettersType.Terran, count);
            count = _machineCount;
            if (count >= 2) result.Add(CardFettersType.Machine, count);
            return result;
        }

		[Token(Token = "0x60012F4")]
		[Address(RVA = "0x3DDAE48", Offset = "0x3DD6E48", VA = "0x3DDAE48")]
		public Dictionary<AtkWayType, int> GetAtkWayTypeEnableConfig()
		{
            Dictionary<AtkWayType, int> result = new Dictionary<AtkWayType, int>();
            int count = _meleeCount;
            if (count >= 3) result.Add(AtkWayType.Melee, count);
            count = _remoteCount;
            if (count >= 3) result.Add(AtkWayType.Remote, count);
            return result;
        }

		[Token(Token = "0x60012F5")]
		[Address(RVA = "0x3DDAF1C", Offset = "0x3DD6F1C", VA = "0x3DDAF1C")]
		private void AllowOpenHex(object o)
		{
			if (CoreGameManager.Gaming)
			    _isOpenHexing = true;
		}

		[Token(Token = "0x60012F6")]
		[Address(RVA = "0x3DDAFB4", Offset = "0x3DD6FB4", VA = "0x3DDAFB4")]
		public void AddDeadUnit(int id, DeadUnitInfo unitInfo)
		{
			if (!GameDeadUnitInfoDic.ContainsKey(id))
			    GameDeadUnitInfoDic.Add(id, unitInfo);
		}

		[Token(Token = "0x60012F7")]
		[Address(RVA = "0x3DDB058", Offset = "0x3DD7058", VA = "0x3DDB058")]
		public void RemoveDeadUnit(int id)
		{
			if (GameDeadUnitInfoDic.ContainsKey(id))
			    GameDeadUnitInfoDic.Remove(id);
		}

		[Token(Token = "0x60012F8")]
		[Address(RVA = "0x3DDB0E8", Offset = "0x3DD70E8", VA = "0x3DDB0E8")]
		public void EndGame()
		{
			enemyNowGameOpenGoldCardEd = false;
			_isOpenHexing = false;
			openHexCount = 0;
			aiBattleCardID.Clear();
			_cardInfoList.Clear();
			_cardRInfoList.Clear();
			_cardRNoGoldMineInfoList.Clear();
			_cardSrInfoList.Clear();
			_cardSsrInfoList.Clear();
			_cardSssrInfoList.Clear();
			cardLevelDic.Clear();
			GameDeadUnitInfoDic.Clear();
			moraleNum = 0;
			crazySendEmoji = false;
			forcedLengdaryProp = false;
			propUsedCount = 0;
			canAction = false;
			propId = string.Empty;
			blessId = string.Empty;
		}

		[Token(Token = "0x60012F9")]
		[Address(RVA = "0x3DDB2F0", Offset = "0x3DD72F0", VA = "0x3DDB2F0")]
		private List<string> RandomAICardAndRecord(string enemyCardConfig, [Optional] List<string> customCardIds)
		{
			var result = new List<string>();
			result.Clear();
			int unlocked = ArenaManager.Instance.GetUnLockArenaCount();
			string arena = StringTool.IsNullOrEmpty(CoreGameManager.NowPlayEdArenaID, true) ? "1001" : CoreGameManager.NowPlayEdArenaID;
			bool reduce = GameConfigModule.GameConfigManager.GameGlobalConfig.enableReduceArena12EnemyDifficulty && SDKModule.ABTestManager.Instance.GamePlayImprove01IsBTest && arena == "1001";
			var config = enemyCardConfig.Split(',');
			int r = 0, sr = 0, ssr = 0, sssr = 0;
			if (unlocked <= 3) { r = StringTool.ToInt(config[0]); sr = StringTool.ToInt(config[1]); ssr = StringTool.ToInt(config[2]); sssr = StringTool.ToInt(config[3]); }
			if (DbtSaveDataManager_PlayerGuideData.I.Data.isFirstThroghGame)
			    return new List<string> { "1001", "1002", "1003", "1004", "1005", "1011", "1013", "1014" };
			var existing = new Dictionary<RareLevel, int>();
			var cards = DbtSaveDataManager_PlayerCardData.I.Data.userHeroCardDataList;
			if (customCardIds != null && customCardIds.Count >= 1)
			{
			    int count = UnityEngine.Mathf.Min(customCardIds.Count, 8);
			    for (int i = 0; i < count; i++)
			    {
			        string id = customCardIds[i];
			        if (result.Contains(id)) continue;
			        result.Add(id);
			        RareLevel rare = HeroCardManager.Instance.GetCardRare(id);
			        if (!existing.ContainsKey(rare)) existing[rare] = 0;
			        existing[rare] = unchecked(existing[rare] + 1);
			    }
			}
			if (!result.Contains("1001"))
			{
			    result.Add("1001");
			    existing[(RareLevel)0] = existing.ContainsKey((RareLevel)0) ? unchecked(existing[(RareLevel)0] + 1) : 1;
			}
			var counts = new Dictionary<RareLevel, int>();
			counts.Add((RareLevel)0, existing.ContainsKey((RareLevel)0) ? existing[(RareLevel)0] : 0);
			counts.Add((RareLevel)1, existing.ContainsKey((RareLevel)1) ? existing[(RareLevel)1] : 0);
			counts.Add((RareLevel)2, existing.ContainsKey((RareLevel)2) ? existing[(RareLevel)2] : 0);
			counts.Add((RareLevel)3, existing.ContainsKey((RareLevel)3) ? existing[(RareLevel)3] : 0);
			var rarities = new List<RareLevel> { (RareLevel)0, (RareLevel)1, (RareLevel)2, (RareLevel)3 };
			foreach (var rare in rarities)
			{
			    if (counts[rare] > (rare == (RareLevel)0 ? 1 : 0)) continue;
			    string id = FindCardOfRarity(rare, result, cards);
			    if (string.IsNullOrEmpty(id)) continue;
			    result.Add(id);
			    counts[rare] = unchecked(counts[rare] + 1);
			}
			while (result.Count < 8)
			{
			    int rejected = -1;
			    bool added = false;
			    do
			    {
			        string id = cards[UnityEngine.Random.Range(0, cards.Count)].id;
			        if (!result.Contains(id) && (!reduce || StringTool.ToInt(DataManager.Instance.GlobalInfo.heroCardDic[id].cardFetters) != 1))
			        {
			            RareLevel rare = DbtSaveDataManager_PlayerCardData.I.Data.userHeroCardDataDic[id].GetRareLevel();
			            bool allowed = false;
			            switch ((int)rare)
			            {
			                case 0: allowed = r < 1 || counts[rare] < r; break;
			                case 1: allowed = sr < 1 || counts[rare] < sr; break;
			                case 2: allowed = ssr < 1 || counts[rare] < ssr; break;
			                case 3: allowed = sssr < 1 || counts[rare] < sssr; break;
			            }
			            if (allowed)
			            {
			                counts[rare] = unchecked(counts[rare] + 1);
			                result.Add(id); added = true; break;
			            }
			        }
			        rejected++;
			    } while (rejected < 1999);
			    if (added) continue;
			    var remaining = System.Linq.Enumerable.ToList(System.Linq.Enumerable.Where(cards, card => !result.Contains(card.id)));
			    if (reduce) remaining = System.Linq.Enumerable.ToList(System.Linq.Enumerable.Where(remaining, card => StringTool.ToInt(DataManager.Instance.GlobalInfo.heroCardDic[card.id].cardFetters) != 1));
			    if (remaining.Count < 1) break;
			    string fallback = remaining[UnityEngine.Random.Range(0, remaining.Count)].id;
			    result.Add(fallback);
			}
			if (result.Count >= 9) result = Override8Handle(result);
			return result;
		}

		[Token(Token = "0x60012FA")]
		[Address(RVA = "0x3DDC7AC", Offset = "0x3DD87AC", VA = "0x3DDC7AC")]
		private string FindCardOfRarity(RareLevel rarity, List<string> excludeIds, List<UserHeroCardData> heroCardInfos)
		{
			string arena = StringTool.IsNullOrEmpty(CoreGameManager.NowPlayEdArenaID, true) ? "1001" : CoreGameManager.NowPlayEdArenaID;
			bool reduce = GameConfigModule.GameConfigManager.GameGlobalConfig.enableReduceArena12EnemyDifficulty && SDKModule.ABTestManager.Instance.GamePlayImprove01IsBTest && arena == "1001";
			var candidates = System.Linq.Enumerable.ToList(System.Linq.Enumerable.Where(heroCardInfos, x => HeroCardManager.Instance.GetCardRare(x.id) == rarity && !excludeIds.Contains(x.id)));
			if (reduce) candidates = System.Linq.Enumerable.ToList(System.Linq.Enumerable.Where(candidates, x => StringTool.ToInt(DataManager.Instance.GlobalInfo.heroCardDic[x.id].cardFetters) != 1));
			if (candidates.Count >= 1) return candidates[UnityEngine.Random.Range(0, candidates.Count)].id;
			foreach (var card in heroCardInfos) if (!excludeIds.Contains(card.id)) return card.id;
			return "";
		}

		[Token(Token = "0x60012FB")]
		[Address(RVA = "0x3DDCC88", Offset = "0x3DD8C88", VA = "0x3DDCC88")]
		private List<string> Override8Handle(List<string> cardDeck)
		{
			if (!cardDeck.Contains("1001")) cardDeck.Add("1001");
			var rarities = new List<RareLevel> { (RareLevel)1, (RareLevel)2, (RareLevel)3 };
			var missing = new List<RareLevel>();
			foreach (var rare in rarities)
			    if (!System.Linq.Enumerable.Any(cardDeck, id => HeroCardManager.Instance.GetCardRare(id) == rare)) missing.Add(rare);
			while (cardDeck.Count > 8)
			{
			    string remove = null;
			    foreach (var id in cardDeck)
			    {
			        if (id == "1001") continue;
			        RareLevel rare = HeroCardManager.Instance.GetCardRare(id);
			        if (!missing.Contains(rare) && System.Linq.Enumerable.Count(cardDeck, item => HeroCardManager.Instance.GetCardRare(item) == rare) >= 2)
			        { remove = id; break; }
			    }
			    if (remove == null) remove = System.Linq.Enumerable.FirstOrDefault(cardDeck, id => id != "1001" && !missing.Contains(HeroCardManager.Instance.GetCardRare(id)));
			    if (remove == null) remove = System.Linq.Enumerable.FirstOrDefault(cardDeck, id => id != "1001");
			    if (remove != null) { cardDeck.Remove(remove); continue; }
			    if (cardDeck.Count >= 9) return System.Linq.Enumerable.ToList(System.Linq.Enumerable.Take(cardDeck, 8));
			    break;
			}
			return cardDeck;
		}

		[Token(Token = "0x60012FC")]
		[Address(RVA = "0x3DD9188", Offset = "0x3DD5188", VA = "0x3DD9188")]
		private List<string> RanDomAICardFollowFetter(string enemyCardConfig, [Optional] List<string> customCardListId)
		{
			var result = new List<string>();
			result.Clear();
			result.Add("1001");
			var configs = DataManager.Instance.GlobalInfo.arenaEnemyCardsInfoList;
			string currentArena = StringTool.IsNullOrEmpty(CoreGameManager.NowPlayEdArenaID, true) ? "1001" : CoreGameManager.NowPlayEdArenaID;
			int balanceArena = StringTool.ToInt(ArenaManager.Instance.GetEnemyContentBalanceArenaId());
			bool reduce = GameConfigModule.GameConfigManager.GameGlobalConfig.enableReduceArena12EnemyDifficulty && SDKModule.ABTestManager.Instance.GamePlayImprove01IsBTest && currentArena == "1001";
			var candidates = new List<ArenaEnemyCardsInfo>();
			var availableLevels = new List<int>();
			for (int i = 0; i < configs.Count; i++)
			    if (!availableLevels.Contains(StringTool.ToInt(configs[i].minArnenaLevel))) availableLevels.Add(StringTool.ToInt(configs[i].minArnenaLevel));
			int arenaLevel = unchecked(balanceArena - 1000);
			availableLevels.Sort(); availableLevels.Reverse();
			int selectedLevel = -1;
			for (int i = 0; i < availableLevels.Count; i++)
			    if (arenaLevel >= availableLevels[i]) { selectedLevel = availableLevels[i]; break; }
			for (int i = configs.Count - 1; i >= 0; i--)
			    if (selectedLevel == StringTool.ToInt(configs[i].minArnenaLevel)) candidates.Add(configs[i]);
			if (selectedLevel == -1 || (customCardListId != null && customCardListId.Count >= 1)) return RandomAICardAndRecord(enemyCardConfig, customCardListId);
			ArenaEnemyCardsInfo selected = null;
			bool improved = SDKModule.ABTestManager.Instance.GamePlayImprove01IsBTest;
			if (arenaLevel >= 5 && improved)
			{
			    if (UnityEngine.Random.Range(0, 100) <= 49)
			    {
			        var all = new List<ArenaEnemyCardsInfo>();
			        for (int i = configs.Count - 1; i >= 0; i--) all.Add(configs[i]);
			        var fullFetter = System.Linq.Enumerable.ToList(System.Linq.Enumerable.Where(all, x => StringTool.ToInt(x.fetterFull) == 1));
			        if (fullFetter.Count >= 1) selected = fullFetter[UnityEngine.Random.Range(0, fullFetter.Count)];
			    }
			    else
			    {
			        var races = new List<CardFettersType> { (CardFettersType)0, (CardFettersType)2 };
			        if (!reduce) races.Add((CardFettersType)1);
			        races.Add((CardFettersType)3);
			        if (races.Count >= 1)
			        {
			            CardFettersType? race = races[UnityEngine.Random.Range(0, races.Count)];
			            if (race.HasValue)
			            {
			                var single = RandomSingleRaceDeck(race.Value);
			                if (single != null && single.Count == 8) return single;
			            }
			        }
			    }
			}
			if (selected == null) selected = candidates[UnityEngine.Random.Range(0, candidates.Count)];
			int orcMelee = StringTool.ToInt(selected.orcMeleeCount);
			int orcRemote = StringTool.ToInt(selected.orcRangeCount);
			int humanMelee = StringTool.ToInt(selected.humanMeleeCount);
			int humanRemote = StringTool.ToInt(selected.humanRangeCount);
			int undeadMelee = StringTool.ToInt(selected.undeadMeleeCount);
			int undeadRemote = StringTool.ToInt(selected.undeadRangeCount);
			int machineRemote = StringTool.ToInt(selected.machineRangeCount);
			int machineDefense = StringTool.ToInt(selected.machineDefenseCount);
			int machineMelee = StringTool.ToInt(selected.machineMeleeCount);
			var pool = new List<GlobalHeroCardInfo>();
			void AddCards(int count, System.Func<List<GlobalHeroCardInfo>> getter) { if (count >= 1) pool.AddRange(getter()); }
			AddCards(orcMelee, GetOrcMeleeInfo);
			AddCards(orcRemote, GetOrcRemoteInfo);
			AddCards(humanMelee, GetHumanMeleeInfo);
			AddCards(humanRemote, GetHumanRemoteInfo);
			AddCards(undeadMelee, GetUnDeadMeleeInfo);
			AddCards(undeadRemote, GetUnDeadRemoteInfo);
			AddCards(machineRemote, GetMachineRemoteInfo);
			AddCards(machineDefense, GetMachineDefenseInfo);
			AddCards(machineMelee, GetMachineMeleeInfo);
			if (reduce) pool.RemoveAll(x => StringTool.ToInt(x.cardFetters) == 1);
			GlobalHeroCardInfo guaranteedR = null, guaranteedSR = null, guaranteedSSR = null, guaranteedSSSR = null;
			int rare = 0;
			string id = "";
			bool success = false;
			void CheckAndDecrement(ref int counter, System.Func<bool> condition)
			{
			    if (!condition()) return;
			    int previous = counter;
			    counter = unchecked(counter - 1);
			    if (counter < 0) { counter = previous; result.Remove(id); success = false; }
			}
			do
			{
			    success = false; id = "";
			    int index = UnityEngine.Random.Range(0, pool.Count);
			    if ((int)DbtSaveDataManager_PlayerCardData.I.Data.userHeroCardDataDic[pool[index].id].GetRareLevel() == rare)
			    {
			        success = true;
			        id = pool[index].id;
			        result.Add(id);
			        switch (rare) { case 0: guaranteedR = pool[index]; break; case 1: guaranteedSR = pool[index]; break; case 2: guaranteedSSR = pool[index]; break; case 3: guaranteedSSSR = pool[index]; break; }
			        int race = StringTool.ToInt(pool[index].cardFetters);
			        int attack = StringTool.ToInt(pool[index].atkType);
			        CheckAndDecrement(ref orcMelee, () => race == 0 && attack == 0);
			        CheckAndDecrement(ref orcRemote, () => race == 0 && attack == 1);
			        CheckAndDecrement(ref humanMelee, () => race == 2 && attack == 0);
			        CheckAndDecrement(ref humanRemote, () => race == 2 && attack == 1);
			        CheckAndDecrement(ref undeadMelee, () => race == 1 && attack == 0);
			        CheckAndDecrement(ref undeadRemote, () => race == 1 && attack == 1);
			        CheckAndDecrement(ref machineRemote, () => race == 3 && attack == 1 && pool[index].type == "barracks");
			        CheckAndDecrement(ref machineDefense, () => race == 3 && attack == 1 && pool[index].type == "defense");
			        CheckAndDecrement(ref machineMelee, () => race == 3 && attack == 0 && pool[index].type == "barracks");
			    }
			} while (!success || ++rare != 4);
			void ProcessCardInfo(System.Func<List<GlobalHeroCardInfo>> getter, int count)
			{
			    var available = System.Linq.Enumerable.ToList(System.Linq.Enumerable.Where(getter(), card => card.id != guaranteedR.id && card.id != guaranteedSR.id && card.id != guaranteedSSR.id && card.id != guaranteedSSSR.id));
			    int remaining = unchecked(count - 1);
			    if (remaining < 0) return;
			    do
			    {
			        int index = UnityEngine.Random.Range(0, available.Count);
			        var card = available[index];
			        available.RemoveAt(index);
			        result.Add(card.id);
			    } while (--remaining >= 0);
			}
			ProcessCardInfo(GetOrcMeleeInfo, orcMelee);
			ProcessCardInfo(GetOrcRemoteInfo, orcRemote);
			ProcessCardInfo(GetHumanMeleeInfo, humanMelee);
			ProcessCardInfo(GetHumanRemoteInfo, humanRemote);
			ProcessCardInfo(GetUnDeadMeleeInfo, undeadMelee);
			ProcessCardInfo(GetUnDeadRemoteInfo, undeadRemote);
			ProcessCardInfo(GetMachineRemoteInfo, machineRemote);
			ProcessCardInfo(GetMachineDefenseInfo, machineDefense);
			ProcessCardInfo(GetMachineMeleeInfo, machineMelee);
			return result;
		}

		[Token(Token = "0x60012FD")]
		[Address(RVA = "0x3DD6248", Offset = "0x3DD2248", VA = "0x3DD6248")]
		private void RecordEquipCardInfo([Optional] List<UserHeroCardData> cardData)
		{
			_orcsCount = 0;
			_unDeadCount = 0;
			_terranCount = 0;
			_meleeCount = 0;
			_remoteCount = 0;
			_machineCount = 0;
			_cardRInfoList.Clear();
			_cardSrInfoList.Clear();
			_cardSsrInfoList.Clear();
			_cardSssrInfoList.Clear();
			_cardRNoGoldMineInfoList.Clear();
			_cardInfoList.Clear();
			if (cardData != null)
			{
			    aiBattleCardID.Clear();
			    for (int i = 0; i < cardData.Count; i++)
			        aiBattleCardID.Add(cardData[i].id);
			    cardLevelDic.Clear();
			}
			int index = 0;
			for (; index < aiBattleCardID.Count; index++)
			    _cardInfoList.Add(DataManager.Instance.GlobalInfo.heroCardInfos.Find(x => x.id == aiBattleCardID[index]));
			for (int i = 0; i < _cardInfoList.Count; i++)
			{
			    if (_cardInfoList[i].rareLevel == "R")
			    {
			        _cardRInfoList.Add(_cardInfoList[i]);
			        if (_cardInfoList[i].id != "1001")
			            _cardRNoGoldMineInfoList.Add(_cardInfoList[i]);
			    }
			    else if (_cardInfoList[i].rareLevel == "SR")
			        _cardSrInfoList.Add(_cardInfoList[i]);
			    else if (_cardInfoList[i].rareLevel == "SSR")
			        _cardSsrInfoList.Add(_cardInfoList[i]);
			    else if (_cardInfoList[i].rareLevel == "SSSR")
			        _cardSssrInfoList.Add(_cardInfoList[i]);
			    if (_cardInfoList[i].cardFetters == "0") _orcsCount = unchecked(_orcsCount + 1);
			    else if (_cardInfoList[i].cardFetters == "1") _unDeadCount = unchecked(_unDeadCount + 1);
			    else if (_cardInfoList[i].cardFetters == "2") _terranCount = unchecked(_terranCount + 1);
			    else if (_cardInfoList[i].cardFetters == "3") _machineCount = unchecked(_machineCount + 1);
			    if (_cardInfoList[i].atkType == "0") _meleeCount = unchecked(_meleeCount + 1);
			    else if (_cardInfoList[i].atkType == "1") _remoteCount = unchecked(_remoteCount + 1);
			    if (cardData != null)
			        cardLevelDic.TryAdd(_cardInfoList[i].id, cardData[i].level);
			}
			EventModule.EventManager.Instance.TriggerEvent("EnemyRandomCardTalentCofig", null);
		}

		[Token(Token = "0x60012FE")]
		[Address(RVA = "0x3DDDEF0", Offset = "0x3DD9EF0", VA = "0x3DDDEF0")]
		public List<int> GetBattleCardIDList()
		{
			var result = new List<int>();
			for (int i = 0; i < _cardInfoList.Count; i++)
			    result.Add(StringTool.ToInt(_cardInfoList[i].id));
			return result;
		}

		[Token(Token = "0x60012FF")]
		[Address(RVA = "0x3DDE034", Offset = "0x3DDA034", VA = "0x3DDE034")]
		public int GetBattleCardLevel(int id)
		{
			return cardLevelDic.ContainsKey(id.ToString()) ? cardLevelDic[id.ToString()] : 0;
		}

		[Token(Token = "0x6001300")]
		[Address(RVA = "0x3DDE0E4", Offset = "0x3DDA0E4", VA = "0x3DDE0E4")]
		public (GlobalArchitectureInfo, string) RandomRArchitectureLevelInfo(bool isMirror, HexType hexType, bool isInit)
		{
			bool noGoldMine = SDKModule.ABTestManager.Instance.MinesCountIsBTest && BattleGameSceneManager.Instance.sceneGoldMineCanCreatCount < 1 ? true : !isInit;
			bool balance = SDKModule.ABTestManager.Instance.MinesCountIsBTest && SDKModule.ABTestManager.Instance.BalanceAdjustment01IsBTest && !isMirror;
			if (isInit && balance && EqipDefenseCard && !EquipCardInfoManager.Instance.EqipDefenseCard)
			    noGoldMine |= BattleGameSceneManager.Instance.sceneGoldMineCanCreatCount <= BattleGameSceneManager.Instance.sceneGoldMineMirrorSideCount;
			string architectureID;
			if ((hexType != HexType.resources && isMirror) || noGoldMine)
			    architectureID = _cardRNoGoldMineInfoList[UnityEngine.Random.Range(0, _cardRNoGoldMineInfoList.Count)].architecturdID;
			else
			    architectureID = _cardRInfoList[UnityEngine.Random.Range(0, _cardRInfoList.Count)].architecturdID;
			if (isMirror)
			{
			    string selected = GetAICardDeckByHexType(hexType, RareLevel.R, false);
			    if (!StringTool.IsNullOrEmpty(selected, true)) architectureID = selected;
			}
			var info = DataManager.Instance.GlobalInfo.architectureInfos.Find(x => x.id == architectureID);
			return (info, info.cardID);
		}

		[Token(Token = "0x6001301")]
		[Address(RVA = "0x3DDE7B4", Offset = "0x3DDA7B4", VA = "0x3DDE7B4")]
		public (GlobalArchitectureInfo, string) RandomSRArchitectureLevelInfo(bool isMirror, HexType hexType, bool isInit)
		{
			string architectureID = _cardSrInfoList[UnityEngine.Random.Range(0, _cardSrInfoList.Count)].architecturdID;
			if (isMirror)
			{
			    string selected = GetAICardDeckByHexType(hexType, RareLevel.SR, false);
			    if (!StringTool.IsNullOrEmpty(selected, true)) architectureID = selected;
			}
			var info = DataManager.Instance.GlobalInfo.architectureInfos.Find(x => x.id == architectureID);
			return (info, info.cardID);
		}

		[Token(Token = "0x6001302")]
		[Address(RVA = "0x3DDE980", Offset = "0x3DDA980", VA = "0x3DDE980")]
		public (GlobalArchitectureInfo, string) RandomSSRArchitectureLevelInfo(bool isMirror, HexType hexType, bool isInit)
		{
			string architectureID = _cardSsrInfoList[UnityEngine.Random.Range(0, _cardSsrInfoList.Count)].architecturdID;
			if (isMirror)
			{
			    string selected = GetAICardDeckByHexType(hexType, RareLevel.SSR, false);
			    if (!StringTool.IsNullOrEmpty(selected, true)) architectureID = selected;
			}
			var info = DataManager.Instance.GlobalInfo.architectureInfos.Find(x => x.id == architectureID);
			return (info, info.cardID);
		}

		[Token(Token = "0x6001303")]
		[Address(RVA = "0x3DDEB4C", Offset = "0x3DDAB4C", VA = "0x3DDEB4C")]
		public (GlobalArchitectureInfo, string) RandomSSSRArchitectureLevelInfo(bool isMirror, HexType hexType, bool isInit)
		{
			string architectureID = _cardSssrInfoList[UnityEngine.Random.Range(0, _cardSssrInfoList.Count)].architecturdID;
			if (isMirror)
			{
			    string selected = GetAICardDeckByHexType(hexType, RareLevel.SSSR, false);
			    if (!StringTool.IsNullOrEmpty(selected, true)) architectureID = selected;
			}
			var info = DataManager.Instance.GlobalInfo.architectureInfos.Find(x => x.id == architectureID);
			return (info, info.cardID);
		}

		[Token(Token = "0x6001304")]
		[Address(RVA = "0x3DDE454", Offset = "0x3DDA454", VA = "0x3DDE454")]
		private string GetAICardDeckByHexType(HexType type, RareLevel rare, bool isInit)
		{
			var cards = new List<string>();
			HexType requested = type == HexType.soldierpile ? HexType.barracks : type;
			for (int i = 0; i < _cardInfoList.Count; i++)
			{
			    if (System.Enum.Parse<HexType>(_cardInfoList[i].type) == requested && System.Enum.Parse<RareLevel>(_cardInfoList[i].rareLevel) == rare)
			        cards.Add(_cardInfoList[i].architecturdID);
			}
			if (cards.Count == 0)
			{
			    for (int i = 0; i < _cardInfoList.Count; i++)
			        if (System.Enum.Parse<HexType>(_cardInfoList[i].type) == requested)
			            cards.Add(_cardInfoList[i].architecturdID);
			    if (cards.Count == 0)
			        return null;
			}
			return cards[UnityEngine.Random.Range(0, cards.Count)];
		}

		[Token(Token = "0x6001305")]
		[Address(RVA = "0x3DDED18", Offset = "0x3DDAD18", VA = "0x3DDED18")]
		private List<GlobalHeroCardInfo> GetOrcMeleeInfo()
		{
			var cards = DataManager.Instance.GlobalInfo.heroCardInfos;
			var result = new List<GlobalHeroCardInfo>();
			for (int i = 0; i < cards.Count; i++)
			    if (StringTool.ToInt(cards[i].cardFetters) == 0 && StringTool.ToInt(cards[i].atkType) == 0) result.Add(cards[i]);
			return result;
		}

		[Token(Token = "0x6001306")]
		[Address(RVA = "0x3DDEEC0", Offset = "0x3DDAEC0", VA = "0x3DDEEC0")]
		private List<GlobalHeroCardInfo> GetOrcRemoteInfo()
		{
			var cards = DataManager.Instance.GlobalInfo.heroCardInfos;
			var result = new List<GlobalHeroCardInfo>();
			for (int i = 0; i < cards.Count; i++)
			    if (StringTool.ToInt(cards[i].cardFetters) == 0 && StringTool.ToInt(cards[i].atkType) == 1) result.Add(cards[i]);
			return result;
		}

		[Token(Token = "0x6001307")]
		[Address(RVA = "0x3DDF06C", Offset = "0x3DDB06C", VA = "0x3DDF06C")]
		private List<GlobalHeroCardInfo> GetHumanMeleeInfo()
		{
			var cards = DataManager.Instance.GlobalInfo.heroCardInfos;
			var result = new List<GlobalHeroCardInfo>();
			for (int i = 0; i < cards.Count; i++)
			    if (StringTool.ToInt(cards[i].cardFetters) == 2 && StringTool.ToInt(cards[i].atkType) == 0) result.Add(cards[i]);
			return result;
		}

		[Token(Token = "0x6001308")]
		[Address(RVA = "0x3DDF218", Offset = "0x3DDB218", VA = "0x3DDF218")]
		private List<GlobalHeroCardInfo> GetHumanRemoteInfo()
		{
			var cards = DataManager.Instance.GlobalInfo.heroCardInfos;
			var result = new List<GlobalHeroCardInfo>();
			for (int i = 0; i < cards.Count; i++)
			    if (StringTool.ToInt(cards[i].cardFetters) == 2 && StringTool.ToInt(cards[i].atkType) == 1) result.Add(cards[i]);
			return result;
		}

		[Token(Token = "0x6001309")]
		[Address(RVA = "0x3DDF3C8", Offset = "0x3DDB3C8", VA = "0x3DDF3C8")]
		private List<GlobalHeroCardInfo> GetUnDeadMeleeInfo()
		{
			var cards = DataManager.Instance.GlobalInfo.heroCardInfos;
			var result = new List<GlobalHeroCardInfo>();
			for (int i = 0; i < cards.Count; i++)
			    if (StringTool.ToInt(cards[i].cardFetters) == 1 && StringTool.ToInt(cards[i].atkType) == 0) result.Add(cards[i]);
			return result;
		}

		[Token(Token = "0x600130A")]
		[Address(RVA = "0x3DDF574", Offset = "0x3DDB574", VA = "0x3DDF574")]
		private List<GlobalHeroCardInfo> GetUnDeadRemoteInfo()
		{
			var cards = DataManager.Instance.GlobalInfo.heroCardInfos;
			var result = new List<GlobalHeroCardInfo>();
			for (int i = 0; i < cards.Count; i++)
			    if (StringTool.ToInt(cards[i].cardFetters) == 1 && StringTool.ToInt(cards[i].atkType) == 1) result.Add(cards[i]);
			return result;
		}

		[Token(Token = "0x600130B")]
		[Address(RVA = "0x3DDF724", Offset = "0x3DDB724", VA = "0x3DDF724")]
		private List<GlobalHeroCardInfo> GetMachineRemoteInfo()
		{
			var cards = DataManager.Instance.GlobalInfo.heroCardInfos;
			var result = new List<GlobalHeroCardInfo>();
			for (int i = 0; i < cards.Count; i++)
			    if (StringTool.ToInt(cards[i].cardFetters) == 3 && StringTool.ToInt(cards[i].atkType) == 1 && cards[i].type == "barracks") result.Add(cards[i]);
			return result;
		}

		[Token(Token = "0x600130C")]
		[Address(RVA = "0x3DDF918", Offset = "0x3DDB918", VA = "0x3DDF918")]
		private List<GlobalHeroCardInfo> GetMachineDefenseInfo()
		{
			var cards = DataManager.Instance.GlobalInfo.heroCardInfos;
			var result = new List<GlobalHeroCardInfo>();
			for (int i = 0; i < cards.Count; i++)
			    if (StringTool.ToInt(cards[i].cardFetters) == 3 && StringTool.ToInt(cards[i].atkType) == 1 && cards[i].type == "defense") result.Add(cards[i]);
			return result;
		}

		[Token(Token = "0x600130D")]
		[Address(RVA = "0x3DDFB0C", Offset = "0x3DDBB0C", VA = "0x3DDFB0C")]
		private List<GlobalHeroCardInfo> GetMachineMeleeInfo()
		{
			var cards = DataManager.Instance.GlobalInfo.heroCardInfos;
			var result = new List<GlobalHeroCardInfo>();
			for (int i = 0; i < cards.Count; i++)
			    if (StringTool.ToInt(cards[i].cardFetters) == 3 && StringTool.ToInt(cards[i].atkType) == 0 && cards[i].type == "barracks") result.Add(cards[i]);
			return result;
		}

		[Token(Token = "0x600130E")]
		[Address(RVA = "0x3DDD5E4", Offset = "0x3DD95E4", VA = "0x3DDD5E4")]
		private List<string> RandomSingleRaceDeck(CardFettersType raceType)
		{
			var all = System.Linq.Enumerable.ToList(System.Linq.Enumerable.Where(DataManager.Instance.GlobalInfo.heroCardInfos, x => StringTool.ToInt(x.cardFetters) == (int)raceType && x.id != "1001"));
			if (all.Count < 4) return null;
			var r = System.Linq.Enumerable.ToList(System.Linq.Enumerable.Where(all, x => x.rareLevel == "R"));
			var sr = System.Linq.Enumerable.ToList(System.Linq.Enumerable.Where(all, x => x.rareLevel == "SR"));
			var ssr = System.Linq.Enumerable.ToList(System.Linq.Enumerable.Where(all, x => x.rareLevel == "SSR"));
			var sssr = System.Linq.Enumerable.ToList(System.Linq.Enumerable.Where(all, x => x.rareLevel == "SSSR"));
			if (r.Count == 0 || sr.Count == 0 || ssr.Count == 0 || sssr.Count == 0) return null;
			var result = new List<string> { "1001" };
			var used = new HashSet<string>();
			GlobalHeroCardInfo first = r[UnityEngine.Random.Range(0, r.Count)];
			used.Add(first.id);
			result.Add(first.id);
			var secondPool = System.Linq.Enumerable.ToList(System.Linq.Enumerable.Where(sr, x => !used.Contains(x.id)));
			var second = secondPool[UnityEngine.Random.Range(0, secondPool.Count)];
			if (second == null) return null;
			used.Add(second.id); result.Add(second.id);
			var thirdPool = System.Linq.Enumerable.ToList(System.Linq.Enumerable.Where(ssr, x => !used.Contains(x.id)));
			var third = thirdPool[UnityEngine.Random.Range(0, thirdPool.Count)];
			if (third == null) return null;
			used.Add(third.id); result.Add(third.id);
			var fourthPool = System.Linq.Enumerable.ToList(System.Linq.Enumerable.Where(sssr, x => !used.Contains(x.id)));
			var fourth = fourthPool[UnityEngine.Random.Range(0, fourthPool.Count)];
			if (fourth == null) return null;
			used.Add(fourth.id); result.Add(fourth.id);
			var remaining = System.Linq.Enumerable.ToList(System.Linq.Enumerable.Where(all, x => !used.Contains(x.id)));
			while (result.Count <= 7 && remaining.Count >= 1)
			{
			    var card = remaining[UnityEngine.Random.Range(0, remaining.Count)];
			    remaining.Remove(card);
			    if (used.Add(card.id)) result.Add(card.id);
			}
			return result.Count == 8 ? result : null;
		}

		[Token(Token = "0x600130F")]
		[Address(RVA = "0x3DDFD6C", Offset = "0x3DDBD6C", VA = "0x3DDFD6C")]
		public (GlobalArchitectureInfo, string) RandomRArchitectureLevelInfoAndNoGoldMine()
		{
			var cards = System.Linq.Enumerable.ToList(_cardRInfoList);
			for (int i = 0; i < cards.Count; i++)
			    if (cards[i].id == "1001") { cards.RemoveAt(i); break; }
			int selected = UnityEngine.Random.Range(0, cards.Count);
			string architectureID = cards[selected].architecturdID;
			var info = DataManager.Instance.GlobalInfo.architectureInfos.Find(x => x.id == architectureID);
			return (info, cards[selected].id);
		}

		[Token(Token = "0x6001310")]
		[Address(RVA = "0x3DDFFBC", Offset = "0x3DDBFBC", VA = "0x3DDFFBC")]
		public (GlobalArchitectureInfo, string, string) RandomBarracksArchitectureInfo()
		{
			var cards = System.Linq.Enumerable.ToList(_cardInfoList);
			for (int i = cards.Count - 1; i >= 0; i--)
			    if (cards[i].type != "barracks") cards.RemoveAt(i);
			int selected = UnityEngine.Random.Range(0, cards.Count);
			string architectureID = cards[selected].architecturdID;
			var info = DataManager.Instance.GlobalInfo.architectureInfos.Find(x => x.id == architectureID);
			string id = cards[selected].id;
			string rare = DataManager.Instance.GlobalInfo.heroCardDic[cards[selected].id].rareLevel;
			return (info, id, rare);
		}

		[Token(Token = "0x6001311")]
		[Address(RVA = "0x3DE025C", Offset = "0x3DDC25C", VA = "0x3DE025C")]
		public (GlobalArchitectureInfo, string) RandomSRArchitectureLevelInfoAndNoDef()
		{
			var cards = System.Linq.Enumerable.ToList(_cardSrInfoList);
			for (int i = 0; i < cards.Count; i++)
			    if (cards[i].id == "1014") { cards.RemoveAt(i); break; }
			int selected = UnityEngine.Random.Range(0, cards.Count);
			string architectureID = cards[selected].architecturdID;
			var info = DataManager.Instance.GlobalInfo.architectureInfos.Find(x => x.id == architectureID);
			return (info, cards[selected].id);
		}

		[Token(Token = "0x6001312")]
		[Address(RVA = "0x3DE04AC", Offset = "0x3DDC4AC", VA = "0x3DE04AC")]
		public AIBehaviourManager()
		{

		}
	}
}
