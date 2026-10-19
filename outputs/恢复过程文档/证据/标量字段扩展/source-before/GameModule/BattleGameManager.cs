using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using ToolModule;
using UnityEngine;
using UnityEngine.Events;

namespace GameModule
{
	[Token(Token = "0x200041B")]
	public class BattleGameManager : ManagerBase<BattleGameManager>
	{
		[Token(Token = "0x200041C")]
		private struct AnimationPauseSnapshot
		{
			[Token(Token = "0x40028FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Dictionary<int, float> animatorInstanceSpeed;

			[Token(Token = "0x40028FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public bool hasGpuiCrowdPrefab;

			[Token(Token = "0x4002900")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float gpuiAnimationSpeed;

			[Token(Token = "0x4002901")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool shouldResumeAniInstancing;
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200041E")]
		[CompilerGenerated]
		private struct _003CBeginStartCountDown_003Ed__82 : IAsyncStateMachine
		{
			[Token(Token = "0x4002911")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002912")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002913")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BattleGameManager _003C_003E4__this;

			[Token(Token = "0x4002914")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60013A8")]
			[Address(RVA = "0x3DE9E4C", Offset = "0x3DE5E4C", VA = "0x3DE9E4C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60013A9")]
			[Address(RVA = "0x3DEA220", Offset = "0x3DE6220", VA = "0x3DEA220", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200041F")]
		[CompilerGenerated]
		private struct _003CCountDownEnd_003Ed__81 : IAsyncStateMachine
		{
			[Token(Token = "0x4002915")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002916")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002917")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BattleGameManager _003C_003E4__this;

			[Token(Token = "0x60013AA")]
			[Address(RVA = "0x3DEA22C", Offset = "0x3DE622C", VA = "0x3DEA22C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60013AB")]
			[Address(RVA = "0x3DEA60C", Offset = "0x3DE660C", VA = "0x3DEA60C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x2000420")]
		[CompilerGenerated]
		private sealed class _003CCountdown_003Ed__67 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4002918")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4002919")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400291A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BattleGameManager _003C_003E4__this;

			[Token(Token = "0x1700012D")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60013AF")]
				[Address(RVA = "0x3DEA8D8", Offset = "0x3DE68D8", VA = "0x3DEA8D8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x1700012E")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60013B1")]
				[Address(RVA = "0x3DEA918", Offset = "0x3DE6918", VA = "0x3DEA918", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60013AC")]
			[Address(RVA = "0x3DE52D8", Offset = "0x3DE12D8", VA = "0x3DE52D8")]
			[DebuggerHidden]
			public _003CCountdown_003Ed__67(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60013AD")]
			[Address(RVA = "0x3DEA618", Offset = "0x3DE6618", VA = "0x3DEA618", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60013AE")]
			[Address(RVA = "0x3DEA61C", Offset = "0x3DE661C", VA = "0x3DEA61C", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60013AF")]
			[Address(RVA = "0x3DEA8D8", Offset = "0x3DE68D8", VA = "0x3DEA8D8", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60013B0")]
			[Address(RVA = "0x3DEA8E0", Offset = "0x3DE68E0", VA = "0x3DEA8E0", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60013B1")]
			[Address(RVA = "0x3DEA918", Offset = "0x3DE6918", VA = "0x3DEA918", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000421")]
		[CompilerGenerated]
		private struct _003CGameEnd_003Ed__52 : IAsyncStateMachine
		{
			[Token(Token = "0x400291B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400291C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400291D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool isVictory;

			[Token(Token = "0x400291E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public BattleGameManager _003C_003E4__this;

			[Token(Token = "0x400291F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool doTxtAni;

			[Token(Token = "0x4002920")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60013B2")]
			[Address(RVA = "0x3DEA920", Offset = "0x3DE6920", VA = "0x3DEA920", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60013B3")]
			[Address(RVA = "0x3DEB054", Offset = "0x3DE7054", VA = "0x3DEB054", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000422")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__43 : IAsyncStateMachine
		{
			[Token(Token = "0x4002921")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002922")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002923")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BattleGameManager _003C_003E4__this;

			[Token(Token = "0x4002924")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60013B4")]
			[Address(RVA = "0x3DEB060", Offset = "0x3DE7060", VA = "0x3DEB060", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60013B5")]
			[Address(RVA = "0x3DEBB38", Offset = "0x3DE7B38", VA = "0x3DEBB38", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000423")]
		[CompilerGenerated]
		private struct _003CSettlementAnimationEnd_003Ed__59 : IAsyncStateMachine
		{
			[Token(Token = "0x4002925")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002926")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002927")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BattleGameManager _003C_003E4__this;

			[Token(Token = "0x4002928")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60013B6")]
			[Address(RVA = "0x3DEBB44", Offset = "0x3DE7B44", VA = "0x3DEBB44", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60013B7")]
			[Address(RVA = "0x3DEC720", Offset = "0x3DE8720", VA = "0x3DEC720", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40028D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly Dictionary<int, AnimationPauseSnapshot> _pausedRoleAnimationSnapshots;

		[Token(Token = "0x40028D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int hasCoin;

		[Token(Token = "0x40028D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int battleInitCoin;

		[Token(Token = "0x40028D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int battleTotalEarned;

		[Token(Token = "0x40028D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int battleTotalCost;

		[Token(Token = "0x40028D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool _isAddCoining;

		[Token(Token = "0x40028D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float _timeLeft;

		[Token(Token = "0x40028D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int countDownTime;

		[Token(Token = "0x40028D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string _timeString;

		[Token(Token = "0x40028D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool isCountDowning;

		[Token(Token = "0x40028DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Coroutine _myCoroutine;

		[Token(Token = "0x40028DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public int openHexCount;

		[Token(Token = "0x40028DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public bool hornIng;

		[Token(Token = "0x40028DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float hornTime;

		[Token(Token = "0x40028DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Dictionary<string, int> roleAllDamageDic;

		[Token(Token = "0x40028DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Dictionary<string, int> towerAllDamageDic;

		[Token(Token = "0x40028E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public bool isVictory;

		[Token(Token = "0x40028E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string GetBoxId;

		[Token(Token = "0x40028E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public int nowWinStreakCount;

		[Token(Token = "0x40028E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public int nowLoseStreakCount;

		[Token(Token = "0x40028E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Dictionary<string, int> cardOpenCount;

		[Token(Token = "0x40028E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public int gameUseCoinNums;

		[Token(Token = "0x40028E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Dictionary<int, DeadUnitInfo> GameDeadUnitInfoDic;

		[Token(Token = "0x40028E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private UnityAction<bool> gameEndCallBack;

		[Token(Token = "0x40028E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private UnityAction<bool> applyRewardCallBack;

		[Token(Token = "0x40028E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public RewardConfig rewardConfig;

		[Token(Token = "0x40028EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public RewardConfig tempConfig;

		[Token(Token = "0x40028EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private BattleContext _battleContext;

		[Token(Token = "0x40028EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public bool playerNowGameOpenGoldCardEd;

		[Token(Token = "0x40028ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD9")]
		public bool canCutDown;

		[Token(Token = "0x40028EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDA")]
		private bool _isGamePaused;

		[Token(Token = "0x40028EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public readonly int[] PropBTestChargeTime;

		[Token(Token = "0x40028F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private string betRewardNum;

		[Token(Token = "0x40028F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public GameType GameType;

		[Token(Token = "0x40028F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public BattleResult battleResult;

		[Token(Token = "0x40028F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private GUIStyle _cachedBoxStyle;

		[Token(Token = "0x40028F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private GUIStyle _cachedToggleStyle;

		[Token(Token = "0x40028F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private GUIStyle _cachedButtonStyle;

		[Token(Token = "0x40028F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private GUIStyle _cachedLabelStyle;

		[Token(Token = "0x40028F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private float _cachedGuiScale;

		[Token(Token = "0x40028F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Font _cachedGuiFont;

		[Token(Token = "0x40028F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private bool _showFpsAdaptPanel;

		[Token(Token = "0x40028FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private float _perfPanelScale;

		[Token(Token = "0x40028FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private float _fpsTimer;

		[Token(Token = "0x40028FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private int _fpsFrameCount;

		[Token(Token = "0x40028FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private int _fpsCurrent;

		[Token(Token = "0x1700012A")]
		public float ElapseTime
		{
			[Token(Token = "0x6001367")]
			[Address(RVA = "0x3DE3A9C", Offset = "0x3DDFA9C", VA = "0x3DE3A9C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700012B")]
		public bool IsGamePaused
		{
			[Token(Token = "0x6001368")]
			[Address(RVA = "0x3DE3AAC", Offset = "0x3DDFAAC", VA = "0x3DE3AAC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001369")]
			[Address(RVA = "0x3DE3B3C", Offset = "0x3DDFB3C", VA = "0x3DE3B3C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700012C")]
		public string BetRewardNum
		{
			[Token(Token = "0x600136A")]
			[Address(RVA = "0x3DE3B48", Offset = "0x3DDFB48", VA = "0x3DE3B48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600136B")]
		[Address(RVA = "0x3DE3B50", Offset = "0x3DDFB50", VA = "0x3DE3B50", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__43))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x600136C")]
		[Address(RVA = "0x3DE3BDC", Offset = "0x3DDFBDC", VA = "0x3DE3BDC")]
		private void BetRecordRewardNum(object o)
		{
		}

		[Token(Token = "0x600136D")]
		[Address(RVA = "0x3DE3C0C", Offset = "0x3DDFC0C", VA = "0x3DE3C0C")]
		public void RecordCardCount(string id)
		{
		}

		[Token(Token = "0x600136E")]
		[Address(RVA = "0x3DE3CEC", Offset = "0x3DDFCEC", VA = "0x3DE3CEC")]
		private void GuidOneEndAddCoin(object o)
		{
		}

		[Token(Token = "0x600136F")]
		[Address(RVA = "0x3DE3F10", Offset = "0x3DDFF10", VA = "0x3DE3F10")]
		public void RecordCoinCount(int num)
		{
		}

		[Token(Token = "0x6001370")]
		[Address(RVA = "0x3DE3F20", Offset = "0x3DDFF20", VA = "0x3DE3F20")]
		private void PlayerHornEmitIng(object o)
		{
		}

		[Token(Token = "0x6001371")]
		[Address(RVA = "0x3DE3F2C", Offset = "0x3DDFF2C", VA = "0x3DE3F2C")]
		private void PlayerHornEmitEnd(object o)
		{
		}

		[Token(Token = "0x6001372")]
		[Address(RVA = "0x3DE3F34", Offset = "0x3DDFF34", VA = "0x3DE3F34")]
		private void GameEndCheck(object o)
		{
		}

		[Token(Token = "0x6001373")]
		[Address(RVA = "0x3DE4088", Offset = "0x3DE0088", VA = "0x3DE4088")]
		private void CloseMatchPanel(object o)
		{
		}

		[Token(Token = "0x6001374")]
		[Address(RVA = "0x3DE3FD8", Offset = "0x3DDFFD8", VA = "0x3DE3FD8")]
		[AsyncStateMachine(typeof(_003CGameEnd_003Ed__52))]
		public void GameEnd(bool isVictory, bool doTxtAni)
		{
		}

		[Token(Token = "0x6001375")]
		[Address(RVA = "0x3DE4094", Offset = "0x3DE0094", VA = "0x3DE4094")]
		public void ShowFoundEnemyPanel(GameType gameType)
		{
		}

		[Token(Token = "0x6001376")]
		[Address(RVA = "0x3DE41CC", Offset = "0x3DE01CC", VA = "0x3DE41CC")]
		public void HideFoundEnemyPanel()
		{
		}

		[Token(Token = "0x6001377")]
		[Address(RVA = "0x3DE4234", Offset = "0x3DE0234", VA = "0x3DE4234")]
		private void ShowInterstitial(object o)
		{
		}

		[Token(Token = "0x6001378")]
		[Address(RVA = "0x3DE4238", Offset = "0x3DE0238", VA = "0x3DE4238")]
		private double GetMinutesSinceInstall()
		{
			return default;
		}

		[Token(Token = "0x6001379")]
		[Address(RVA = "0x3DE44C8", Offset = "0x3DE04C8", VA = "0x3DE44C8")]
		private bool IsPayedPlayer()
		{
			return default;
		}

		[Token(Token = "0x600137A")]
		[Address(RVA = "0x3DE4618", Offset = "0x3DE0618", VA = "0x3DE4618")]
		private bool HadBuyInterstitialIAP()
		{
			return default;
		}

		[Token(Token = "0x600137B")]
		[Address(RVA = "0x3DE4748", Offset = "0x3DE0748", VA = "0x3DE4748")]
		[AsyncStateMachine(typeof(_003CSettlementAnimationEnd_003Ed__59))]
		private void SettlementAnimationEnd(object o)
		{
		}

		[Token(Token = "0x600137C")]
		[Address(RVA = "0x3DE47D4", Offset = "0x3DE07D4", VA = "0x3DE47D4")]
		private void RecordGameResult()
		{
		}

		[Token(Token = "0x600137D")]
		[Address(RVA = "0x3DE4E98", Offset = "0x3DE0E98", VA = "0x3DE4E98")]
		private void GameEndRewardUser(RewardConfig config)
		{
		}

		[Token(Token = "0x600137E")]
		[Address(RVA = "0x3DE4F14", Offset = "0x3DE0F14", VA = "0x3DE4F14")]
		public string GameSuccessGetTrophyNumber()
		{
			return null;
		}

		[Token(Token = "0x600137F")]
		[Address(RVA = "0x3DE50F8", Offset = "0x3DE10F8", VA = "0x3DE50F8")]
		private void PlayerOpenHexCountAdd(object o)
		{
		}

		[Token(Token = "0x6001380")]
		[Address(RVA = "0x3DE5108", Offset = "0x3DE1108", VA = "0x3DE5108")]
		private void Update()
		{
		}

		[Token(Token = "0x6001381")]
		[Address(RVA = "0x3DE3CF4", Offset = "0x3DDFCF4", VA = "0x3DE3CF4")]
		public void ChangeCoin(int coinNum)
		{
		}

		[Token(Token = "0x6001382")]
		[Address(RVA = "0x3DE514C", Offset = "0x3DE114C", VA = "0x3DE514C")]
		private void CoinChangeUpdateGamePanel(object o)
		{
		}

		[Token(Token = "0x6001383")]
		[Address(RVA = "0x3DE5278", Offset = "0x3DE1278", VA = "0x3DE5278")]
		[IteratorStateMachine(typeof(_003CCountdown_003Ed__67))]
		private IEnumerator Countdown()
		{
			return null;
		}

		[Token(Token = "0x6001384")]
		[Address(RVA = "0x3DE5300", Offset = "0x3DE1300", VA = "0x3DE5300")]
		public void SetGamePaused(bool paused)
		{
		}

		[Token(Token = "0x6001385")]
		[Address(RVA = "0x3DE5424", Offset = "0x3DE1424", VA = "0x3DE5424")]
		private void OnPauseGame(object o)
		{
		}

		[Token(Token = "0x6001386")]
		[Address(RVA = "0x3DE5444", Offset = "0x3DE1444", VA = "0x3DE5444")]
		private void OnResumeGame(object o)
		{
		}

		[Token(Token = "0x6001387")]
		[Address(RVA = "0x3DE531C", Offset = "0x3DE131C", VA = "0x3DE531C")]
		private void ApplyAnimationPauseToAllRoles(bool paused)
		{
		}

		[Token(Token = "0x6001388")]
		[Address(RVA = "0x3DE545C", Offset = "0x3DE145C", VA = "0x3DE545C")]
		private void ApplyAnimationPauseToRoleList(List<GameObject> roles, bool paused)
		{
		}

		[Token(Token = "0x6001389")]
		[Address(RVA = "0x3DE5D94", Offset = "0x3DE1D94", VA = "0x3DE5D94")]
		public void TryApplyPauseToNewRole(GameObject roleObj)
		{
		}

		[Token(Token = "0x600138A")]
		[Address(RVA = "0x3DE5540", Offset = "0x3DE1540", VA = "0x3DE5540")]
		private void ApplyAnimationPauseToSingleRole(GameObject roleObj, bool paused)
		{
		}

		[Token(Token = "0x600138B")]
		[Address(RVA = "0x3DE5E20", Offset = "0x3DE1E20", VA = "0x3DE5E20")]
		private string GetTimeCutDownString()
		{
			return null;
		}

		[Token(Token = "0x600138C")]
		[Address(RVA = "0x3DE6088", Offset = "0x3DE2088", VA = "0x3DE6088")]
		public void RecordDamage(string id, int damage)
		{
		}

		[Token(Token = "0x600138D")]
		[Address(RVA = "0x3DE6178", Offset = "0x3DE2178", VA = "0x3DE6178")]
		public void RecordBuildDamage(string id, int damage)
		{
		}

		[Token(Token = "0x600138E")]
		[Address(RVA = "0x3DE6268", Offset = "0x3DE2268", VA = "0x3DE6268")]
		public string GetDamageMaxPath()
		{
			return null;
		}

		[Token(Token = "0x600138F")]
		[Address(RVA = "0x3DE65C8", Offset = "0x3DE25C8", VA = "0x3DE65C8")]
		public void AddDeadUnit(int id, DeadUnitInfo unitInfo)
		{
		}

		[Token(Token = "0x6001390")]
		[Address(RVA = "0x3DE666C", Offset = "0x3DE266C", VA = "0x3DE666C")]
		public void RemoveDeadUnit(int id)
		{
		}

		[Token(Token = "0x6001391")]
		[Address(RVA = "0x3DE66FC", Offset = "0x3DE26FC", VA = "0x3DE66FC")]
		[AsyncStateMachine(typeof(_003CCountDownEnd_003Ed__81))]
		private void CountDownEnd()
		{
		}

		[Token(Token = "0x6001392")]
		[Address(RVA = "0x3DE6788", Offset = "0x3DE2788", VA = "0x3DE6788")]
		[AsyncStateMachine(typeof(_003CBeginStartCountDown_003Ed__82))]
		private void BeginStartCountDown(object o)
		{
		}

		[Token(Token = "0x6001393")]
		[Address(RVA = "0x3DE6814", Offset = "0x3DE2814", VA = "0x3DE6814")]
		public void StartGame(BattleContext battleContext)
		{
		}

		[Token(Token = "0x6001394")]
		[Address(RVA = "0x3DE6DAC", Offset = "0x3DE2DAC", VA = "0x3DE6DAC")]
		public void EndGame()
		{
		}

		[Token(Token = "0x6001395")]
		[Address(RVA = "0x3DE6F80", Offset = "0x3DE2F80", VA = "0x3DE6F80")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6001396")]
		[Address(RVA = "0x3DE99CC", Offset = "0x3DE59CC", VA = "0x3DE99CC")]
		public BattleGameManager()
		{
		}
	}
}
