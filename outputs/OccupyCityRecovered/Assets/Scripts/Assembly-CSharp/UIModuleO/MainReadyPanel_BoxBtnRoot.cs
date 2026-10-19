using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000972")]
	public class MainReadyPanel_BoxBtnRoot : MainReadyPanel_BoxBtnRootComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000976")]
		[CompilerGenerated]
		private struct _003CAwake_003Ed__16 : IAsyncStateMachine
		{
			[Token(Token = "0x40046FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40046FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004700")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MainReadyPanel_BoxBtnRoot _003C_003E4__this;

			[Token(Token = "0x4004701")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60037C4")]
			[Address(RVA = "0x40E985C", Offset = "0x40E585C", VA = "0x40E985C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60037C5")]
			[Address(RVA = "0x40E9CDC", Offset = "0x40E5CDC", VA = "0x40E9CDC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000977")]
		[CompilerGenerated]
		private struct _003CCreatBoxIcon_003Ed__19 : IAsyncStateMachine
		{
			[Token(Token = "0x4004702")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004703")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004704")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MainReadyPanel_BoxBtnRoot _003C_003E4__this;

			[Token(Token = "0x4004705")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60037C6")]
			[Address(RVA = "0x40E9CE8", Offset = "0x40E5CE8", VA = "0x40E9CE8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60037C7")]
			[Address(RVA = "0x40EA69C", Offset = "0x40E669C", VA = "0x40EA69C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000978")]
		[CompilerGenerated]
		private struct _003CLoadIndicatorSprites_003Ed__17 : IAsyncStateMachine
		{
			[Token(Token = "0x4004706")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004707")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004708")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MainReadyPanel_BoxBtnRoot _003C_003E4__this;

			[Token(Token = "0x4004709")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60037C8")]
			[Address(RVA = "0x40EA6A8", Offset = "0x40E66A8", VA = "0x40EA6A8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60037C9")]
			[Address(RVA = "0x40EAC68", Offset = "0x40E6C68", VA = "0x40EAC68", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000979")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__18 : IAsyncStateMachine
		{
			[Token(Token = "0x400470A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400470B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400470C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MainReadyPanel_BoxBtnRoot _003C_003E4__this;

			[Token(Token = "0x400470D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60037CA")]
			[Address(RVA = "0x40EAC74", Offset = "0x40E6C74", VA = "0x40EAC74", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60037CB")]
			[Address(RVA = "0x40EAE64", Offset = "0x40E6E64", VA = "0x40EAE64", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40046E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private List<GameObject> _activeButtons;

		[Token(Token = "0x40046E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private List<Image> _indicatorImages;

		[Token(Token = "0x40046E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int _currentIndex;

		[Token(Token = "0x40046EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float _carouselTimer;

		[Token(Token = "0x40046EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float _carouselInterval;

		[Token(Token = "0x40046EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool _isCarouselActive;

		[Token(Token = "0x40046ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x95")]
		private bool _isAnimating;

		[Token(Token = "0x40046EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float _buttonWidth;

		[Token(Token = "0x40046EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		[SerializeField]
		private float _buttonSpacing;

		[Token(Token = "0x40046F0")]
		private const float CenterOffsetX = -2f;

		[Token(Token = "0x40046F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Dictionary<RectTransform, Tween> _buttonTweens;

		[Token(Token = "0x40046F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Sprite _activeIndicatorSprite;

		[Token(Token = "0x40046F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Sprite _inactiveIndicatorSprite;

		[Token(Token = "0x40046F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[Header("指示器设置")]
		[SerializeField]
		private float _indicatorSize;

		[Token(Token = "0x40046F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[SerializeField]
		private float _indicatorSpacing;

		[Token(Token = "0x40046F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Header("轮播动画设置")]
		private float _slideDuration;

		[Token(Token = "0x60037A3")]
		[Address(RVA = "0x40E6C74", Offset = "0x40E2C74", VA = "0x40E6C74", Slot = "4")]
		[AsyncStateMachine(typeof(_003CAwake_003Ed__16))]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60037A4")]
		[Address(RVA = "0x40E6D00", Offset = "0x40E2D00", VA = "0x40E6D00")]
		[AsyncStateMachine(typeof(_003CLoadIndicatorSprites_003Ed__17))]
		private UniTask LoadIndicatorSprites()
		{
			return default;
		}

		[Token(Token = "0x60037A5")]
		[Address(RVA = "0x40E6D90", Offset = "0x40E2D90", VA = "0x40E6D90", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__18))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60037A6")]
		[Address(RVA = "0x40E6E24", Offset = "0x40E2E24", VA = "0x40E6E24")]
		[AsyncStateMachine(typeof(_003CCreatBoxIcon_003Ed__19))]
		public void CreatBoxIcon(object o)
		{
		}

		[Token(Token = "0x60037A7")]
		[Address(RVA = "0x40E6EB4", Offset = "0x40E2EB4", VA = "0x40E6EB4")]
		private void Update()
		{
		}

		[Token(Token = "0x60037A8")]
		[Address(RVA = "0x40E6FCC", Offset = "0x40E2FCC", VA = "0x40E6FCC")]
		public void RefreshActiveButtons()
		{
		}

		[Token(Token = "0x60037A9")]
		[Address(RVA = "0x40E753C", Offset = "0x40E353C", VA = "0x40E753C")]
		public void RemoveBoxIcon(GameObject buttonObj)
		{
		}

		[Token(Token = "0x60037AA")]
		[Address(RVA = "0x40E7764", Offset = "0x40E3764", VA = "0x40E7764")]
		public void ClearAllBoxIcons()
		{
		}

		[Token(Token = "0x60037AB")]
		[Address(RVA = "0x40E70D0", Offset = "0x40E30D0", VA = "0x40E70D0")]
		private void UpdateCarouselState()
		{
		}

		[Token(Token = "0x60037AC")]
		[Address(RVA = "0x40E838C", Offset = "0x40E438C", VA = "0x40E838C")]
		private void CreateIndicators(int count)
		{
		}

		[Token(Token = "0x60037AD")]
		[Address(RVA = "0x40E8C58", Offset = "0x40E4C58", VA = "0x40E8C58")]
		private void UpdateIndicators()
		{
		}

		[Token(Token = "0x60037AE")]
		[Address(RVA = "0x40E825C", Offset = "0x40E425C", VA = "0x40E825C")]
		private void ArrangeButtonsForSingle()
		{
		}

		[Token(Token = "0x60037AF")]
		[Address(RVA = "0x40E8A28", Offset = "0x40E4A28", VA = "0x40E8A28")]
		private void ArrangeButtonsForCarousel()
		{
		}

		[Token(Token = "0x60037B0")]
		[Address(RVA = "0x40E6F54", Offset = "0x40E2F54", VA = "0x40E6F54")]
		private void SwitchToNextButton()
		{
		}

		[Token(Token = "0x60037B1")]
		[Address(RVA = "0x40E8DC0", Offset = "0x40E4DC0", VA = "0x40E8DC0")]
		private void SlideToButton(int targetIndex)
		{
		}

		[Token(Token = "0x60037B2")]
		[Address(RVA = "0x40E79AC", Offset = "0x40E39AC", VA = "0x40E79AC")]
		private void KillAllButtonTweens()
		{
		}

		[Token(Token = "0x60037B3")]
		[Address(RVA = "0x40E9174", Offset = "0x40E5174", VA = "0x40E9174")]
		public void ManualSwitchNext()
		{
		}

		[Token(Token = "0x60037B4")]
		[Address(RVA = "0x40E91D0", Offset = "0x40E51D0", VA = "0x40E91D0")]
		private void ResetView()
		{
		}

		[Token(Token = "0x60037B5")]
		[Address(RVA = "0x40E91D4", Offset = "0x40E51D4", VA = "0x40E91D4")]
		public void SwitchToButton(int index)
		{
		}

		[Token(Token = "0x60037B6")]
		[Address(RVA = "0x40E9244", Offset = "0x40E5244", VA = "0x40E9244")]
		public void SetCarouselPaused(bool paused)
		{
		}

		[Token(Token = "0x60037B7")]
		[Address(RVA = "0x40E92AC", Offset = "0x40E52AC", VA = "0x40E92AC", Slot = "12")]
		protected override void OnButtonExtendImgBgClicked()
		{
		}

		[Token(Token = "0x60037B8")]
		[Address(RVA = "0x40E93F0", Offset = "0x40E53F0", VA = "0x40E93F0")]
		public MainReadyPanel_BoxBtnRoot()
		{
		}
	}
}
