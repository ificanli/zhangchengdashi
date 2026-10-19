using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using SuperScrollView;
using UIFramework;
using UIModuleO.UIAnim;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x20006C3")]
	public class ArenaProgressPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20006C4")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__127 : IAsyncStateMachine
		{
			[Token(Token = "0x4003627")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003628")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003629")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ArenaProgressPanelComponents _003C_003E4__this;

			[Token(Token = "0x400362A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x600241B")]
			[Address(RVA = "0x3F54D54", Offset = "0x3F50D54", VA = "0x3F54D54", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600241C")]
			[Address(RVA = "0x3F54FCC", Offset = "0x3F50FCC", VA = "0x3F54FCC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ScrollRect _scrollRectScrollView;

		[Token(Token = "0x4003624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private LoopListView2 _loopListView2ScrollView;

		[Token(Token = "0x4003625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RectTransform _rectTransformContent;

		[Token(Token = "0x4003626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ButtonExtend _buttonExtendBtnBack;

		[Token(Token = "0x17000255")]
		public ScrollRect ScrollRectScrollView
		{
			[Token(Token = "0x600240F")]
			[Address(RVA = "0x3F536A4", Offset = "0x3F4F6A4", VA = "0x3F536A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000256")]
		public LoopListView2 LoopListView2ScrollView
		{
			[Token(Token = "0x6002410")]
			[Address(RVA = "0x3F53058", Offset = "0x3F4F058", VA = "0x3F53058")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000257")]
		public RectTransform RectTransformContent
		{
			[Token(Token = "0x6002411")]
			[Address(RVA = "0x3F53BD0", Offset = "0x3F4FBD0", VA = "0x3F53BD0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000258")]
		public ButtonExtend ButtonExtendBtnBack
		{
			[Token(Token = "0x6002412")]
			[Address(RVA = "0x3F54ADC", Offset = "0x3F50ADC", VA = "0x3F54ADC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002413")]
		[Address(RVA = "0x3F54BA4", Offset = "0x3F50BA4", VA = "0x3F54BA4")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6002414")]
		[Address(RVA = "0x3F54C98", Offset = "0x3F50C98", VA = "0x3F54C98", Slot = "12")]
		protected virtual void OnScrollRectScrollViewValueChanged(Vector2 arg)
		{
		}

		[Token(Token = "0x6002415")]
		[Address(RVA = "0x3F53EE0", Offset = "0x3F4FEE0", VA = "0x3F53EE0", Slot = "13")]
		protected virtual void OnButtonExtendBtnBackClicked()
		{
		}

		[Token(Token = "0x6002416")]
		[Address(RVA = "0x3F5303C", Offset = "0x3F4F03C", VA = "0x3F5303C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002417")]
		[Address(RVA = "0x3F53E48", Offset = "0x3F4FE48", VA = "0x3F53E48", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__127))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002418")]
		[Address(RVA = "0x3F53CF4", Offset = "0x3F4FCF4", VA = "0x3F53CF4", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6002419")]
		[Address(RVA = "0x3F53E3C", Offset = "0x3F4FE3C", VA = "0x3F53E3C")]
		public ArenaProgressPanelComponents()
		{
		}
	}
}
