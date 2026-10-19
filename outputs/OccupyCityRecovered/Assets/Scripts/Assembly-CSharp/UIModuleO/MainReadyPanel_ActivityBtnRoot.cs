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
	[Token(Token = "0x200096A")]
	public class MainReadyPanel_ActivityBtnRoot : MainReadyPanel_ActivityBtnRootComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200096D")]
		[CompilerGenerated]
		private struct _003CAwake_003Ed__16 : IAsyncStateMachine
		{
			[Token(Token = "0x40046CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40046D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40046D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MainReadyPanel_ActivityBtnRoot _003C_003E4__this;

			[Token(Token = "0x40046D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600378D")]
			[Address(RVA = "0x40E574C", Offset = "0x40E174C", VA = "0x40E574C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600378E")]
			[Address(RVA = "0x40E5DF0", Offset = "0x40E1DF0", VA = "0x40E5DF0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200096E")]
		[CompilerGenerated]
		private struct _003CLoadIndicatorSprites_003Ed__17 : IAsyncStateMachine
		{
			[Token(Token = "0x40046D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40046D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40046D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MainReadyPanel_ActivityBtnRoot _003C_003E4__this;

			[Token(Token = "0x40046D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600378F")]
			[Address(RVA = "0x40E5DFC", Offset = "0x40E1DFC", VA = "0x40E5DFC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003790")]
			[Address(RVA = "0x40E63BC", Offset = "0x40E23BC", VA = "0x40E63BC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200096F")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__18 : IAsyncStateMachine
		{
			[Token(Token = "0x40046D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40046D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40046D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MainReadyPanel_ActivityBtnRoot _003C_003E4__this;

			[Token(Token = "0x40046DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x40046DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6003791")]
			[Address(RVA = "0x40E63C8", Offset = "0x40E23C8", VA = "0x40E63C8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003792")]
			[Address(RVA = "0x40E67D8", Offset = "0x40E27D8", VA = "0x40E67D8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40046BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private List<GameObject> _activeButtons;

		[Token(Token = "0x40046BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private List<Image> _indicatorImages;

		[Token(Token = "0x40046BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int _currentIndex;

		[Token(Token = "0x40046BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float _carouselTimer;

		[Token(Token = "0x40046BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float _carouselInterval;

		[Token(Token = "0x40046C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool _isCarouselActive;

		[Token(Token = "0x40046C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x95")]
		private bool _isAnimating;

		[Token(Token = "0x40046C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float _buttonWidth;

		[Token(Token = "0x40046C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		[SerializeField]
		private float _buttonSpacing;

		[Token(Token = "0x40046C4")]
		private const float CenterOffsetX = -10f;

		[Token(Token = "0x40046C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Dictionary<RectTransform, Tween> _buttonTweens;

		[Token(Token = "0x40046C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Sprite _activeIndicatorSprite;

		[Token(Token = "0x40046C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Sprite _inactiveIndicatorSprite;

		[Token(Token = "0x40046C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[Header("指示器设置")]
		[SerializeField]
		private float _indicatorSize;

		[Token(Token = "0x40046C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[SerializeField]
		private float _indicatorSpacing;

		[Token(Token = "0x40046CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[Header("轮播动画设置")]
		[SerializeField]
		private float _slideDuration;

		[Token(Token = "0x6003770")]
		[Address(RVA = "0x40E2E10", Offset = "0x40DEE10", VA = "0x40E2E10", Slot = "4")]
		[AsyncStateMachine(typeof(_003CAwake_003Ed__16))]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6003771")]
		[Address(RVA = "0x40E2E9C", Offset = "0x40DEE9C", VA = "0x40E2E9C")]
		[AsyncStateMachine(typeof(_003CLoadIndicatorSprites_003Ed__17))]
		private UniTask LoadIndicatorSprites()
		{
			return default;
		}

		[Token(Token = "0x6003772")]
		[Address(RVA = "0x40E2F2C", Offset = "0x40DEF2C", VA = "0x40E2F2C", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__18))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6003773")]
		[Address(RVA = "0x40E2FC8", Offset = "0x40DEFC8", VA = "0x40E2FC8")]
		private void Update()
		{
		}

		[Token(Token = "0x6003774")]
		[Address(RVA = "0x40E3334", Offset = "0x40DF334", VA = "0x40E3334")]
		public void RefreshActiveButtons()
		{
		}

		[Token(Token = "0x6003775")]
		[Address(RVA = "0x40E3AA0", Offset = "0x40DFAA0", VA = "0x40E3AA0")]
		private void UpdateCarouselState()
		{
		}

		[Token(Token = "0x6003776")]
		[Address(RVA = "0x40E3F78", Offset = "0x40DFF78", VA = "0x40E3F78")]
		private void CreateIndicators(int count)
		{
		}

		[Token(Token = "0x6003777")]
		[Address(RVA = "0x40E4850", Offset = "0x40E0850", VA = "0x40E4850")]
		private void UpdateIndicators()
		{
		}

		[Token(Token = "0x6003778")]
		[Address(RVA = "0x40E3E48", Offset = "0x40DFE48", VA = "0x40E3E48")]
		private void ArrangeButtonsForSingle()
		{
		}

		[Token(Token = "0x6003779")]
		[Address(RVA = "0x40E4620", Offset = "0x40E0620", VA = "0x40E4620")]
		private void ArrangeButtonsForCarousel()
		{
		}

		[Token(Token = "0x600377A")]
		[Address(RVA = "0x40E32BC", Offset = "0x40DF2BC", VA = "0x40E32BC")]
		private void SwitchToNextButton()
		{
		}

		[Token(Token = "0x600377B")]
		[Address(RVA = "0x40E49B8", Offset = "0x40E09B8", VA = "0x40E49B8")]
		private void SlideToButton(int targetIndex)
		{
		}

		[Token(Token = "0x600377C")]
		[Address(RVA = "0x40E3510", Offset = "0x40DF510", VA = "0x40E3510")]
		private void KillAllButtonTweens()
		{
		}

		[Token(Token = "0x600377D")]
		[Address(RVA = "0x40E4D6C", Offset = "0x40E0D6C", VA = "0x40E4D6C")]
		public void ManualSwitchNext()
		{
		}

		[Token(Token = "0x600377E")]
		[Address(RVA = "0x40E4DC8", Offset = "0x40E0DC8", VA = "0x40E4DC8")]
		private void ResetView()
		{
		}

		[Token(Token = "0x600377F")]
		[Address(RVA = "0x40E4DCC", Offset = "0x40E0DCC", VA = "0x40E4DCC")]
		public void SwitchToButton(int index)
		{
		}

		[Token(Token = "0x6003780")]
		[Address(RVA = "0x40E4E3C", Offset = "0x40E0E3C", VA = "0x40E4E3C")]
		public void SetCarouselPaused(bool paused)
		{
		}

		[Token(Token = "0x6003781")]
		[Address(RVA = "0x40E4EA4", Offset = "0x40E0EA4", VA = "0x40E4EA4", Slot = "12")]
		protected override void OnButtonExtendImgBgClicked()
		{
		}

		[Token(Token = "0x6003782")]
		[Address(RVA = "0x40E5270", Offset = "0x40E1270", VA = "0x40E5270")]
		private void UpdateWeeklyClashActive(object o)
		{
		}

		[Token(Token = "0x6003783")]
		[Address(RVA = "0x40E501C", Offset = "0x40E101C", VA = "0x40E501C")]
		public List<string> GetAllCarouselButtonNames()
		{
			return null;
		}

		[Token(Token = "0x6003784")]
		[Address(RVA = "0x40E53F8", Offset = "0x40E13F8", VA = "0x40E53F8")]
		public MainReadyPanel_ActivityBtnRoot()
		{
		}
	}
}
