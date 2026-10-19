using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using GameModule;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x200067B")]
	public class WorldCupShootFlow : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200067C")]
		[CompilerGenerated]
		private struct _003CEnsureShootResultPopupAsync_003Ed__34 : IAsyncStateMachine
		{
			[Token(Token = "0x4003485")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003486")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder<bool> _003C_003Et__builder;

			[Token(Token = "0x4003487")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WorldCupShootFlow _003C_003E4__this;

			[Token(Token = "0x4003488")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int lifecycleVersion;

			[Token(Token = "0x4003489")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

			[Token(Token = "0x400348A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__2;

			[Token(Token = "0x600225D")]
			[Address(RVA = "0x3F33840", Offset = "0x3F2F840", VA = "0x3F33840", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600225E")]
			[Address(RVA = "0x3F340F8", Offset = "0x3F300F8", VA = "0x3F340F8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200067D")]
		[CompilerGenerated]
		private struct _003CEnterShootGameplayAsync_003Ed__26 : IAsyncStateMachine
		{
			[Token(Token = "0x400348B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400348C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400348D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public WorldCupShootFlow _003C_003E4__this;

			[Token(Token = "0x400348E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int lifecycleVersion;

			[Token(Token = "0x400348F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600225F")]
			[Address(RVA = "0x3F34150", Offset = "0x3F30150", VA = "0x3F34150", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002260")]
			[Address(RVA = "0x3F347D0", Offset = "0x3F307D0", VA = "0x3F347D0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200067E")]
		[CompilerGenerated]
		private struct _003CExitShootGameplayAsync_003Ed__21 : IAsyncStateMachine
		{
			[Token(Token = "0x4003490")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003491")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003492")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public WorldCupShootFlow _003C_003E4__this;

			[Token(Token = "0x4003493")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002261")]
			[Address(RVA = "0x3F347DC", Offset = "0x3F307DC", VA = "0x3F347DC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002262")]
			[Address(RVA = "0x3F34C10", Offset = "0x3F30C10", VA = "0x3F34C10", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200067F")]
		[CompilerGenerated]
		private struct _003CPlayMainUiEnterAsync_003Ed__28 : IAsyncStateMachine
		{
			[Token(Token = "0x4003494")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003495")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003496")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public WorldCupShootFlow _003C_003E4__this;

			[Token(Token = "0x4003497")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002263")]
			[Address(RVA = "0x3F34C1C", Offset = "0x3F30C1C", VA = "0x3F34C1C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002264")]
			[Address(RVA = "0x3F35340", Offset = "0x3F31340", VA = "0x3F35340", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000680")]
		[CompilerGenerated]
		private struct _003CPlayMainUiExitAsync_003Ed__27 : IAsyncStateMachine
		{
			[Token(Token = "0x4003498")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003499")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400349A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public WorldCupShootFlow _003C_003E4__this;

			[Token(Token = "0x400349B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6002265")]
			[Address(RVA = "0x3F3534C", Offset = "0x3F3134C", VA = "0x3F3534C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002266")]
			[Address(RVA = "0x3F3587C", Offset = "0x3F3187C", VA = "0x3F3587C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000681")]
		[CompilerGenerated]
		private struct _003CPreloadShootStageAsync_003Ed__25 : IAsyncStateMachine
		{
			[Token(Token = "0x400349C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400349D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400349E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public WorldCupShootFlow _003C_003E4__this;

			[Token(Token = "0x400349F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int lifecycleVersion;

			[Token(Token = "0x40034A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private WorldCupShootBridge _003Cbridge_003E5__2;

			[Token(Token = "0x40034A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

			[Token(Token = "0x40034A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask.Awaiter _003C_003Eu__2;

			[Token(Token = "0x6002267")]
			[Address(RVA = "0x3F35888", Offset = "0x3F31888", VA = "0x3F35888", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002268")]
			[Address(RVA = "0x3F35FAC", Offset = "0x3F31FAC", VA = "0x3F35FAC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000682")]
		[CompilerGenerated]
		private struct _003CShootButtonFlowAsync_003Ed__24 : IAsyncStateMachine
		{
			[Token(Token = "0x40034A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40034A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40034A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public WorldCupShootFlow _003C_003E4__this;

			[Token(Token = "0x40034A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int _003CflowVersion_003E5__2;

			[Token(Token = "0x40034A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private int _003Cmultiplier_003E5__3;

			[Token(Token = "0x40034A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x40034A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<FootballShootResult>.Awaiter _003C_003Eu__2;

			[Token(Token = "0x6002269")]
			[Address(RVA = "0x3F35FB8", Offset = "0x3F31FB8", VA = "0x3F35FB8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600226A")]
			[Address(RVA = "0x3F36C7C", Offset = "0x3F32C7C", VA = "0x3F36C7C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000683")]
		[CompilerGenerated]
		private struct _003CShowShootResultPopupAsync_003Ed__30 : IAsyncStateMachine
		{
			[Token(Token = "0x40034AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40034AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40034AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public WorldCupShootFlow _003C_003E4__this;

			[Token(Token = "0x40034AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int lifecycleVersion;

			[Token(Token = "0x40034AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action onClosed;

			[Token(Token = "0x40034AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public WorldCupShootResultPayload payload;

			[Token(Token = "0x40034B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask<bool>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600226B")]
			[Address(RVA = "0x3F36C88", Offset = "0x3F32C88", VA = "0x3F36C88", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600226C")]
			[Address(RVA = "0x3F37120", Offset = "0x3F33120", VA = "0x3F37120", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private WorldCupActivityPanelView _view;

		[Token(Token = "0x4003477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private WorldCupActivityMainUiSlideAnimator _mainUiSlideAnimator;

		[Token(Token = "0x4003478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WorldCupShootBridge _shootBridge;

		[Token(Token = "0x4003479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool _isShooting;

		[Token(Token = "0x400347A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		private bool _shootStagePreloading;

		[Token(Token = "0x400347B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
		private bool _shootGameplayActive;

		[Token(Token = "0x400347C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B")]
		private bool _flowRunning;

		[Token(Token = "0x400347D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool _shootResultPopupLoading;

		[Token(Token = "0x400347E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int _lifecycleVersion;

		[Token(Token = "0x400347F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private WorldCupShootResultPopup _shootResultPopup;

		[Token(Token = "0x4003480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Func<int> _getMultiplier;

		[Token(Token = "0x4003481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Func<bool> _toastActivityEnded;

		[Token(Token = "0x4003482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Func<bool> _tryAutoDowngrade;

		[Token(Token = "0x4003483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Action _refreshMultiplier;

		[Token(Token = "0x4003484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Action _refreshPanel;

		[Token(Token = "0x170001DE")]
		public bool IsMultiplierSelectionLocked
		{
			[Token(Token = "0x6002240")]
			[Address(RVA = "0x3F2D4B8", Offset = "0x3F294B8", VA = "0x3F2D4B8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600223F")]
		[Address(RVA = "0x3F2C194", Offset = "0x3F28194", VA = "0x3F2C194")]
		public void Initialize(WorldCupActivityPanelView view, Func<int> getMultiplier, Func<bool> toastActivityEnded, Func<bool> tryAutoDowngrade, Action refreshMultiplier, Action refreshPanel)
		{
		}

		[Token(Token = "0x6002241")]
		[Address(RVA = "0x3F2DF1C", Offset = "0x3F29F1C", VA = "0x3F2DF1C")]
		public void OnPanelShow()
		{
		}

		[Token(Token = "0x6002242")]
		[Address(RVA = "0x3F2C43C", Offset = "0x3F2843C", VA = "0x3F2C43C")]
		public void OnPanelHide()
		{
		}

		[Token(Token = "0x6002243")]
		[Address(RVA = "0x3F2D3EC", Offset = "0x3F293EC", VA = "0x3F2D3EC")]
		public bool TryHandleBack()
		{
			return default;
		}

		[Token(Token = "0x6002244")]
		[Address(RVA = "0x3F329C4", Offset = "0x3F2E9C4", VA = "0x3F329C4")]
		[AsyncStateMachine(typeof(_003CExitShootGameplayAsync_003Ed__21))]
		private UniTask ExitShootGameplayAsync()
		{
			return default;
		}

		[Token(Token = "0x6002245")]
		[Address(RVA = "0x3F2C934", Offset = "0x3F28934", VA = "0x3F2C934")]
		public void RefreshShootUi()
		{
		}

		[Token(Token = "0x6002246")]
		[Address(RVA = "0x3F2D8A8", Offset = "0x3F298A8", VA = "0x3F2D8A8")]
		public void OnShootButtonClicked()
		{
		}

		[Token(Token = "0x6002247")]
		[Address(RVA = "0x3F32CF8", Offset = "0x3F2ECF8", VA = "0x3F32CF8")]
		[AsyncStateMachine(typeof(_003CShootButtonFlowAsync_003Ed__24))]
		private UniTask ShootButtonFlowAsync()
		{
			return default;
		}

		[Token(Token = "0x6002248")]
		[Address(RVA = "0x3F32924", Offset = "0x3F2E924", VA = "0x3F32924")]
		[AsyncStateMachine(typeof(_003CPreloadShootStageAsync_003Ed__25))]
		private UniTask PreloadShootStageAsync(int lifecycleVersion)
		{
			return default;
		}

		[Token(Token = "0x6002249")]
		[Address(RVA = "0x3F32D88", Offset = "0x3F2ED88", VA = "0x3F32D88")]
		[AsyncStateMachine(typeof(_003CEnterShootGameplayAsync_003Ed__26))]
		private UniTask EnterShootGameplayAsync(int lifecycleVersion)
		{
			return default;
		}

		[Token(Token = "0x600224A")]
		[Address(RVA = "0x3F32E28", Offset = "0x3F2EE28", VA = "0x3F32E28")]
		[AsyncStateMachine(typeof(_003CPlayMainUiExitAsync_003Ed__27))]
		private UniTask PlayMainUiExitAsync()
		{
			return default;
		}

		[Token(Token = "0x600224B")]
		[Address(RVA = "0x3F32EB4", Offset = "0x3F2EEB4", VA = "0x3F32EB4")]
		[AsyncStateMachine(typeof(_003CPlayMainUiEnterAsync_003Ed__28))]
		private UniTask PlayMainUiEnterAsync()
		{
			return default;
		}

		[Token(Token = "0x600224C")]
		[Address(RVA = "0x3F3289C", Offset = "0x3F2E89C", VA = "0x3F3289C")]
		private void ResetMainUiImmediate()
		{
		}

		[Token(Token = "0x600224D")]
		[Address(RVA = "0x3F32F90", Offset = "0x3F2EF90", VA = "0x3F32F90")]
		[AsyncStateMachine(typeof(_003CShowShootResultPopupAsync_003Ed__30))]
		private UniTask ShowShootResultPopupAsync(int lifecycleVersion, WorldCupShootResultPayload payload, Action onClosed)
		{
			return default;
		}

		[Token(Token = "0x600224E")]
		[Address(RVA = "0x3F33044", Offset = "0x3F2F044", VA = "0x3F33044")]
		private bool IsCurrentLifecycle(int lifecycleVersion)
		{
			return default;
		}

		[Token(Token = "0x600224F")]
		[Address(RVA = "0x3F330D0", Offset = "0x3F2F0D0", VA = "0x3F330D0")]
		private bool ToastActivityEnded()
		{
			return default;
		}

		[Token(Token = "0x6002250")]
		[Address(RVA = "0x3F33174", Offset = "0x3F2F174", VA = "0x3F33174")]
		private bool TryGetShootMultiplier(out int multiplier)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED WorldCupShootFlow.TryGetShootMultiplier RVA=0x3F33174 Token=0x6002250");
}

		[Token(Token = "0x6002251")]
		[Address(RVA = "0x3F33290", Offset = "0x3F2F290", VA = "0x3F33290")]
		[AsyncStateMachine(typeof(_003CEnsureShootResultPopupAsync_003Ed__34))]
		private UniTask<bool> EnsureShootResultPopupAsync(int lifecycleVersion)
		{
			return default;
		}

		[Token(Token = "0x6002252")]
		[Address(RVA = "0x3F32A50", Offset = "0x3F2EA50", VA = "0x3F32A50")]
		private void RefreshShootButton()
		{
		}

		[Token(Token = "0x6002253")]
		[Address(RVA = "0x3F32C40", Offset = "0x3F2EC40", VA = "0x3F32C40")]
		private void RefreshBackButton()
		{
		}

		[Token(Token = "0x6002254")]
		[Address(RVA = "0x3F32F40", Offset = "0x3F2EF40", VA = "0x3F32F40")]
		private void SetMainUiVisibleFallback(bool visible)
		{
		}

		[Token(Token = "0x6002255")]
		[Address(RVA = "0x3F327F8", Offset = "0x3F2E7F8", VA = "0x3F327F8")]
		private void SetAnimMaskActive(bool active)
		{
		}

		[Token(Token = "0x6002256")]
		[Address(RVA = "0x3F33768", Offset = "0x3F2F768", VA = "0x3F33768")]
		private static void SetGroupActive(GameObject group, bool active)
		{
		}

		[Token(Token = "0x6002257")]
		[Address(RVA = "0x3F33358", Offset = "0x3F2F358", VA = "0x3F33358")]
		private void ApplyShootButtonSprite(Sprite sprite)
		{
		}

		[Token(Token = "0x6002258")]
		[Address(RVA = "0x3F3348C", Offset = "0x3F2F48C", VA = "0x3F3348C")]
		private void SetShootButtonAffordVisual(bool canAfford)
		{
		}

		[Token(Token = "0x6002259")]
		[Address(RVA = "0x3F337FC", Offset = "0x3F2F7FC", VA = "0x3F337FC")]
		private void RestoreActionButtonVisuals()
		{
		}

		[Token(Token = "0x600225A")]
		[Address(RVA = "0x3F335C8", Offset = "0x3F2F5C8", VA = "0x3F335C8")]
		private static void SetButtonInteractable(Button button, bool interactable)
		{
		}

		[Token(Token = "0x600225B")]
		[Address(RVA = "0x3F33668", Offset = "0x3F2F668", VA = "0x3F33668")]
		private static void ResetButtonVisualState(Button button)
		{
		}

		[Token(Token = "0x600225C")]
		[Address(RVA = "0x3F33838", Offset = "0x3F2F838", VA = "0x3F33838")]
		public WorldCupShootFlow()
		{
		}
	}
}
