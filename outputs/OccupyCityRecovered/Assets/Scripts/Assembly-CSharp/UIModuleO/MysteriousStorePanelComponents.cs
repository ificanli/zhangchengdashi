using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using SuperScrollView;
using TMPro;
using UIFramework;
using UIModuleO.UIAnim;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x20009B2")]
	public class MysteriousStorePanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20009B3")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__127 : IAsyncStateMachine
		{
			[Token(Token = "0x4004864")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004865")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004866")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MysteriousStorePanelComponents _003C_003E4__this;

			[Token(Token = "0x4004867")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60039B1")]
			[Address(RVA = "0x41076FC", Offset = "0x41036FC", VA = "0x41076FC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60039B2")]
			[Address(RVA = "0x4107974", Offset = "0x4103974", VA = "0x4107974", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400485F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TextMeshProUGUI _textMeshProUGUITitle;

		[Token(Token = "0x4004860")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TextMeshProUGUI _textMeshProUGUITimerText;

		[Token(Token = "0x4004861")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private ScrollRect _scrollRectScrollView;

		[Token(Token = "0x4004862")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private LoopGridView _loopGridViewScrollView;

		[Token(Token = "0x4004863")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ButtonExtend _buttonExtendClose;

		[Token(Token = "0x170008D1")]
		public TextMeshProUGUI TextMeshProUGUITitle
		{
			[Token(Token = "0x60039A4")]
			[Address(RVA = "0x4106D54", Offset = "0x4102D54", VA = "0x4106D54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008D2")]
		public TextMeshProUGUI TextMeshProUGUITimerText
		{
			[Token(Token = "0x60039A5")]
			[Address(RVA = "0x4106A48", Offset = "0x4102A48", VA = "0x4106A48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008D3")]
		public ScrollRect ScrollRectScrollView
		{
			[Token(Token = "0x60039A6")]
			[Address(RVA = "0x4107308", Offset = "0x4103308", VA = "0x4107308")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008D4")]
		public LoopGridView LoopGridViewScrollView
		{
			[Token(Token = "0x60039A7")]
			[Address(RVA = "0x41068C4", Offset = "0x41028C4", VA = "0x41068C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008D5")]
		public ButtonExtend ButtonExtendClose
		{
			[Token(Token = "0x60039A8")]
			[Address(RVA = "0x41073D0", Offset = "0x41033D0", VA = "0x41073D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60039A9")]
		[Address(RVA = "0x4107498", Offset = "0x4103498", VA = "0x4107498")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x60039AA")]
		[Address(RVA = "0x410758C", Offset = "0x410358C", VA = "0x410758C", Slot = "12")]
		protected virtual void OnScrollRectScrollViewValueChanged(Vector2 arg)
		{
		}

		[Token(Token = "0x60039AB")]
		[Address(RVA = "0x4106E3C", Offset = "0x4102E3C", VA = "0x4106E3C", Slot = "13")]
		protected virtual void OnButtonExtendCloseClicked()
		{
		}

		[Token(Token = "0x60039AC")]
		[Address(RVA = "0x41068A8", Offset = "0x41028A8", VA = "0x41068A8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60039AD")]
		[Address(RVA = "0x4106FB4", Offset = "0x4102FB4", VA = "0x4106FB4", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__127))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60039AE")]
		[Address(RVA = "0x4107640", Offset = "0x4103640", VA = "0x4107640", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60039AF")]
		[Address(RVA = "0x4106FA8", Offset = "0x4102FA8", VA = "0x4106FA8")]
		public MysteriousStorePanelComponents()
		{
		}
	}
}
