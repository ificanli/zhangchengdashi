using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UIFramework;
using UnityEngine;

namespace UIModuleO
{
	[Token(Token = "0x2000701")]
	public class BattlePowerChangePanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000702")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__62 : IAsyncStateMachine
		{
			[Token(Token = "0x40037C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40037C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40037C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BattlePowerChangePanelComponents _003C_003E4__this;

			[Token(Token = "0x40037C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6002608")]
			[Address(RVA = "0x3F8BFCC", Offset = "0x3F87FCC", VA = "0x3F8BFCC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002609")]
			[Address(RVA = "0x3F8C244", Offset = "0x3F88244", VA = "0x3F8C244", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40037BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Animator _animatorBattlePowerChangePanel;

		[Token(Token = "0x40037BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TextMeshProUGUI _textMeshProUGUIPower;

		[Token(Token = "0x40037BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RectTransform _rectTransformAdd;

		[Token(Token = "0x40037BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private TextMeshProUGUI _textMeshProUGUIAdd;

		[Token(Token = "0x40037C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private RectTransform _rectTransformSub;

		[Token(Token = "0x40037C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private TextMeshProUGUI _textMeshProUGUISub;

		[Token(Token = "0x170002DE")]
		public Animator AnimatorBattlePowerChangePanel
		{
			[Token(Token = "0x60025FC")]
			[Address(RVA = "0x3F8B274", Offset = "0x3F87274", VA = "0x3F8B274")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002DF")]
		public TextMeshProUGUI TextMeshProUGUIPower
		{
			[Token(Token = "0x60025FD")]
			[Address(RVA = "0x3F8AFEC", Offset = "0x3F86FEC", VA = "0x3F8AFEC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002E0")]
		public RectTransform RectTransformAdd
		{
			[Token(Token = "0x60025FE")]
			[Address(RVA = "0x3F8A5B8", Offset = "0x3F865B8", VA = "0x3F8A5B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002E1")]
		public TextMeshProUGUI TextMeshProUGUIAdd
		{
			[Token(Token = "0x60025FF")]
			[Address(RVA = "0x3F8B0E4", Offset = "0x3F870E4", VA = "0x3F8B0E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002E2")]
		public RectTransform RectTransformSub
		{
			[Token(Token = "0x6002600")]
			[Address(RVA = "0x3F8A680", Offset = "0x3F86680", VA = "0x3F8A680")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002E3")]
		public TextMeshProUGUI TextMeshProUGUISub
		{
			[Token(Token = "0x6002601")]
			[Address(RVA = "0x3F8B1AC", Offset = "0x3F871AC", VA = "0x3F8B1AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002602")]
		[Address(RVA = "0x3F8BE78", Offset = "0x3F87E78", VA = "0x3F8BE78")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6002603")]
		[Address(RVA = "0x3F8A5B0", Offset = "0x3F865B0", VA = "0x3F8A5B0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002604")]
		[Address(RVA = "0x3F8BE7C", Offset = "0x3F87E7C", VA = "0x3F8BE7C", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__62))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002605")]
		[Address(RVA = "0x3F8BF10", Offset = "0x3F87F10", VA = "0x3F8BF10", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6002606")]
		[Address(RVA = "0x3F8B464", Offset = "0x3F87464", VA = "0x3F8B464")]
		public BattlePowerChangePanelComponents()
		{
		}
	}
}
