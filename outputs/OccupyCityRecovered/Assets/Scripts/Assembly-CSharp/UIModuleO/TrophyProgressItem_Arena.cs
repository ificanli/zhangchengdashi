using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DG.Tweening;
using DataModule;
using Il2CppDummyDll;
using UIModuleO.UIAnim;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000BA7")]
	public class TrophyProgressItem_Arena : TrophyProgressItem_ArenaComponents
	{
		[Token(Token = "0x2000BA9")]
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass11_0
		{
			[Token(Token = "0x40054B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GlobalTrophyProgressInfo config;

			[Token(Token = "0x60047AE")]
			[Address(RVA = "0x42293D0", Offset = "0x42253D0", VA = "0x42293D0")]
			public _003C_003Ec__DisplayClass11_0()
			{
			}

			[Token(Token = "0x60047AF")]
			[Address(RVA = "0x42293D8", Offset = "0x42253D8", VA = "0x42293D8")]
			internal bool _003CLoadArenaResourcesAsync_003Eb__0(GlobalBoxInfo x)
			{
				return default;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000BAA")]
		[CompilerGenerated]
		private struct _003CClaimNormalReward_003Ed__35 : IAsyncStateMachine
		{
			[Token(Token = "0x40054B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40054B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40054B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public TrophyProgressItem_Arena _003C_003E4__this;

			[Token(Token = "0x40054B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private GlobalTrophyProgressInfo _003Cconfig_003E5__2;

			[Token(Token = "0x40054B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60047B0")]
			[Address(RVA = "0x4229410", Offset = "0x4225410", VA = "0x4229410", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60047B1")]
			[Address(RVA = "0x422A40C", Offset = "0x422640C", VA = "0x422A40C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000BAB")]
		[CompilerGenerated]
		private struct _003CLoadArenaIcon_003Ed__10 : IAsyncStateMachine
		{
			[Token(Token = "0x40054BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40054BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40054BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GlobalTrophyProgressInfo config;

			[Token(Token = "0x40054BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TrophyProgressItem_Arena _003C_003E4__this;

			[Token(Token = "0x40054BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private string _003CcurrentConfigId_003E5__2;

			[Token(Token = "0x40054BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60047B2")]
			[Address(RVA = "0x422AF70", Offset = "0x4226F70", VA = "0x422AF70", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60047B3")]
			[Address(RVA = "0x422B614", Offset = "0x4227614", VA = "0x422B614", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000BAC")]
		[CompilerGenerated]
		private struct _003CLoadArenaResourcesAsync_003Ed__11 : IAsyncStateMachine
		{
			[Token(Token = "0x40054C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40054C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40054C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public TrophyProgressItem_Arena _003C_003E4__this;

			[Token(Token = "0x40054C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private _003C_003Ec__DisplayClass11_0 _003C_003E8__1;

			[Token(Token = "0x40054C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private string _003CcurrentConfigId_003E5__2;

			[Token(Token = "0x40054C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x40054C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Image _003C_003E7__wrap2;

			[Token(Token = "0x40054C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__2;

			[Token(Token = "0x60047B4")]
			[Address(RVA = "0x422B620", Offset = "0x4227620", VA = "0x422B620", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60047B5")]
			[Address(RVA = "0x422C264", Offset = "0x4228264", VA = "0x422C264", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000BAD")]
		[CompilerGenerated]
		private struct _003CLoadCardRewardResourcesAsync_003Ed__12 : IAsyncStateMachine
		{
			[Token(Token = "0x40054C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40054C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40054CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public TrophyProgressItem_Arena _003C_003E4__this;

			[Token(Token = "0x60047B6")]
			[Address(RVA = "0x422C270", Offset = "0x4228270", VA = "0x422C270", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60047B7")]
			[Address(RVA = "0x422C8E4", Offset = "0x42288E4", VA = "0x422C8E4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x2000BAE")]
		[CompilerGenerated]
		private sealed class _003CNotifyHeightChangedAfterLayout_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40054CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40054CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40054CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TrophyProgressItem_Arena _003C_003E4__this;

			[Token(Token = "0x40054CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private string _003CconfigId_003E5__2;

			[Token(Token = "0x17000C28")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60047BB")]
				[Address(RVA = "0x422CADC", Offset = "0x4228ADC", VA = "0x422CADC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000C29")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60047BD")]
				[Address(RVA = "0x422CB1C", Offset = "0x4228B1C", VA = "0x422CB1C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60047B8")]
			[Address(RVA = "0x422C8F0", Offset = "0x42288F0", VA = "0x422C8F0")]
			[DebuggerHidden]
			public _003CNotifyHeightChangedAfterLayout_003Ed__28(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60047B9")]
			[Address(RVA = "0x422C918", Offset = "0x4228918", VA = "0x422C918", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60047BA")]
			[Address(RVA = "0x422C91C", Offset = "0x422891C", VA = "0x422C91C", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60047BB")]
			[Address(RVA = "0x422CADC", Offset = "0x4228ADC", VA = "0x422CADC", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60047BC")]
			[Address(RVA = "0x422CAE4", Offset = "0x4228AE4", VA = "0x422CAE4", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60047BD")]
			[Address(RVA = "0x422CB1C", Offset = "0x4228B1C", VA = "0x422CB1C", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x40054AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private TrophyProgressRewardData _rewardData;

		[Token(Token = "0x40054AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private int _index;

		[Token(Token = "0x40054AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
		private float _lastHeight;

		[Token(Token = "0x40054AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private List<RewardItemUI> _allRewardItemUI;

		[Token(Token = "0x40054AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private string _currentConfigId;

		[Token(Token = "0x40054B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private Coroutine _heightNotifyCoroutine;

		[Token(Token = "0x600478B")]
		[Address(RVA = "0x42262C8", Offset = "0x42222C8", VA = "0x42262C8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600478C")]
		[Address(RVA = "0x42263A0", Offset = "0x42223A0", VA = "0x42263A0")]
		public void Show(TrophyProgressRewardData rewardData, int index)
		{
		}

		[Token(Token = "0x600478D")]
		[Address(RVA = "0x4226950", Offset = "0x4222950", VA = "0x4226950")]
		private bool IsDataValid(string configId)
		{
			return default;
		}

		[Token(Token = "0x600478E")]
		[Address(RVA = "0x4226404", Offset = "0x4222404", VA = "0x4226404")]
		private void UpdateUI()
		{
		}

		[Token(Token = "0x600478F")]
		[Address(RVA = "0x4227C9C", Offset = "0x4223C9C", VA = "0x4227C9C")]
		[AsyncStateMachine(typeof(_003CLoadArenaIcon_003Ed__10))]
		private UniTask LoadArenaIcon(GlobalTrophyProgressInfo config)
		{
			return default;
		}

		[Token(Token = "0x6004790")]
		[Address(RVA = "0x4227C1C", Offset = "0x4223C1C", VA = "0x4227C1C")]
		[AsyncStateMachine(typeof(_003CLoadArenaResourcesAsync_003Ed__11))]
		private UniTaskVoid LoadArenaResourcesAsync()
		{
			return default;
		}

		[Token(Token = "0x6004791")]
		[Address(RVA = "0x4227D44", Offset = "0x4223D44", VA = "0x4227D44")]
		[AsyncStateMachine(typeof(_003CLoadCardRewardResourcesAsync_003Ed__12))]
		private UniTask LoadCardRewardResourcesAsync()
		{
			return default;
		}

		[Token(Token = "0x6004792")]
		[Address(RVA = "0x42269AC", Offset = "0x42229AC", VA = "0x42269AC")]
		private void UpdateCardRewardSync(GlobalTrophyProgressInfo config, bool isUnlocked, bool isClaimed)
		{
		}

		[Token(Token = "0x6004793")]
		[Address(RVA = "0x422784C", Offset = "0x422384C", VA = "0x422784C")]
		private void UpdateCardAndUnlockRootVisible(string hasUnlockFunction)
		{
		}

		[Token(Token = "0x6004794")]
		[Address(RVA = "0x42280AC", Offset = "0x42240AC", VA = "0x42280AC")]
		private string GetClaimedCardConfig(string[] cardEntries, string claimedCardId)
		{
			return null;
		}

		[Token(Token = "0x6004795")]
		[Address(RVA = "0x4227F2C", Offset = "0x4223F2C", VA = "0x4227F2C")]
		private ButtonExtend GetCardButtonByIndex(int index)
		{
			return null;
		}

		[Token(Token = "0x6004796")]
		[Address(RVA = "0x4227F60", Offset = "0x4223F60", VA = "0x4227F60")]
		private Image GetCardLockIconByIndex(int index)
		{
			return null;
		}

		[Token(Token = "0x6004797")]
		[Address(RVA = "0x4228150", Offset = "0x4224150", VA = "0x4228150")]
		private DOTweenAnimation GetCardButtonAnimationByIndex(int index)
		{
			return null;
		}

		[Token(Token = "0x6004798")]
		[Address(RVA = "0x4228184", Offset = "0x4224184", VA = "0x4228184")]
		private RectTransform GetCardButtonRectByIndex(int index)
		{
			return null;
		}

		[Token(Token = "0x6004799")]
		[Address(RVA = "0x4227DD4", Offset = "0x4223DD4", VA = "0x4227DD4")]
		private void StopCardButtonAnimations()
		{
		}

		[Token(Token = "0x600479A")]
		[Address(RVA = "0x4227F94", Offset = "0x4223F94", VA = "0x4227F94")]
		private void PlayCardButtonAnimation(int index)
		{
		}

		[Token(Token = "0x600479B")]
		[Address(RVA = "0x42270C0", Offset = "0x42230C0", VA = "0x42270C0")]
		private void UpdateNormalReward(GlobalTrophyProgressInfo config, bool isUnlocked, bool isClaimed)
		{
		}

		[Token(Token = "0x600479C")]
		[Address(RVA = "0x4227A44", Offset = "0x4223A44", VA = "0x4227A44")]
		private void UpdateLockState(bool isUnlocked)
		{
		}

		[Token(Token = "0x600479D")]
		[Address(RVA = "0x4227B14", Offset = "0x4223B14", VA = "0x4227B14")]
		private void UpdateProgressBar(int prevTrophyRequire, int targetTrophy, BigInteger currentTrophy)
		{
		}

		[Token(Token = "0x600479E")]
		[Address(RVA = "0x4228794", Offset = "0x4224794", VA = "0x4228794")]
		private void UpdateProgressBar(int prevTrophyRequire, int targetTrophy, BigInteger currentTrophy, BigInteger historyTrophy)
		{
		}

		[Token(Token = "0x600479F")]
		[Address(RVA = "0x42281B8", Offset = "0x42241B8", VA = "0x42281B8")]
		private void StopAllAnimations()
		{
		}

		[Token(Token = "0x60047A0")]
		[Address(RVA = "0x42284E0", Offset = "0x42244E0", VA = "0x42284E0")]
		private void PlayClaimableAnimations(bool hasGold, bool hasDiamond, bool hasBox)
		{
		}

		[Token(Token = "0x60047A1")]
		[Address(RVA = "0x4227BB4", Offset = "0x4223BB4", VA = "0x4227BB4")]
		[IteratorStateMachine(typeof(_003CNotifyHeightChangedAfterLayout_003Ed__28))]
		private IEnumerator NotifyHeightChangedAfterLayout()
		{
			return null;
		}

		[Token(Token = "0x60047A2")]
		[Address(RVA = "0x4228D5C", Offset = "0x4224D5C", VA = "0x4228D5C")]
		private void NotifyHeightChanged()
		{
		}

		[Token(Token = "0x60047A3")]
		[Address(RVA = "0x4228E44", Offset = "0x4224E44", VA = "0x4228E44", Slot = "13")]
		protected override void OnButtonExtendBtnRewardOneClicked()
		{
		}

		[Token(Token = "0x60047A4")]
		[Address(RVA = "0x422917C", Offset = "0x422517C", VA = "0x422917C", Slot = "14")]
		protected override void OnButtonExtendBtnRewardTwoClicked()
		{
		}

		[Token(Token = "0x60047A5")]
		[Address(RVA = "0x422919C", Offset = "0x422519C", VA = "0x422919C", Slot = "15")]
		protected override void OnButtonExtendBtnRewardThereClicked()
		{
		}

		[Token(Token = "0x60047A6")]
		[Address(RVA = "0x4228E64", Offset = "0x4224E64", VA = "0x4228E64")]
		private void SelectCardReward(int index)
		{
		}

		[Token(Token = "0x60047A7")]
		[Address(RVA = "0x42291BC", Offset = "0x42251BC", VA = "0x42291BC", Slot = "12")]
		protected override void OnButtonExtendBtnClaimCompleteRewardClicked()
		{
		}

		[Token(Token = "0x60047A8")]
		[Address(RVA = "0x42291D8", Offset = "0x42251D8", VA = "0x42291D8")]
		[AsyncStateMachine(typeof(_003CClaimNormalReward_003Ed__35))]
		private void ClaimNormalReward()
		{
		}

		[Token(Token = "0x60047A9")]
		[Address(RVA = "0x4229268", Offset = "0x4225268", VA = "0x4229268")]
		public TrophyProgressItem_Arena()
		{
		}
	}
}
