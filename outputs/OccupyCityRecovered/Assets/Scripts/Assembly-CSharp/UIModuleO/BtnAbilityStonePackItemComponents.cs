using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UIFramework;
using UIModuleO.UIAnim;
using UnityEngine;

namespace UIModuleO
{
	[Token(Token = "0x2000730")]
	public class BtnAbilityStonePackItemComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000731")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__204 : IAsyncStateMachine
		{
			[Token(Token = "0x40038BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40038BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40038BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BtnAbilityStonePackItemComponents _003C_003E4__this;

			[Token(Token = "0x40038BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6002738")]
			[Address(RVA = "0x3F9E588", Offset = "0x3F9A588", VA = "0x3F9E588", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002739")]
			[Address(RVA = "0x3F9E800", Offset = "0x3F9A800", VA = "0x3F9E800", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40038B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ButtonExtend _buttonExtendBtnAbilityStonePackItem;

		[Token(Token = "0x40038B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TextMeshProUGUI _textMeshProUGUITxtPrice;

		[Token(Token = "0x40038B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BenefitValueItem _benefitValueItemBenefitValueItem;

		[Token(Token = "0x40038B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private TextMeshProUGUI _textMeshProUGUITxtToMonDayCutDown;

		[Token(Token = "0x40038B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private RectTransform _rectTransformRewardRoot;

		[Token(Token = "0x40038B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private TextMeshProUGUI _textMeshProUGUICount1;

		[Token(Token = "0x40038BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private TextMeshProUGUI _textMeshProUGUICount2;

		[Token(Token = "0x1700033C")]
		public ButtonExtend ButtonExtendBtnAbilityStonePackItem
		{
			[Token(Token = "0x600272A")]
			[Address(RVA = "0x3F9E1B4", Offset = "0x3F9A1B4", VA = "0x3F9E1B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700033D")]
		public TextMeshProUGUI TextMeshProUGUITxtPrice
		{
			[Token(Token = "0x600272B")]
			[Address(RVA = "0x3F9CA18", Offset = "0x3F98A18", VA = "0x3F9CA18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700033E")]
		public BenefitValueItem BenefitValueItemBenefitValueItem
		{
			[Token(Token = "0x600272C")]
			[Address(RVA = "0x3F9CAE0", Offset = "0x3F98AE0", VA = "0x3F9CAE0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700033F")]
		public TextMeshProUGUI TextMeshProUGUITxtToMonDayCutDown
		{
			[Token(Token = "0x600272D")]
			[Address(RVA = "0x3F9E258", Offset = "0x3F9A258", VA = "0x3F9E258")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000340")]
		public RectTransform RectTransformRewardRoot
		{
			[Token(Token = "0x600272E")]
			[Address(RVA = "0x3F9CBA8", Offset = "0x3F98BA8", VA = "0x3F9CBA8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000341")]
		public TextMeshProUGUI TextMeshProUGUICount1
		{
			[Token(Token = "0x600272F")]
			[Address(RVA = "0x3F9CC70", Offset = "0x3F98C70", VA = "0x3F9CC70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000342")]
		public TextMeshProUGUI TextMeshProUGUICount2
		{
			[Token(Token = "0x6002730")]
			[Address(RVA = "0x3F9CD38", Offset = "0x3F98D38", VA = "0x3F9CD38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002731")]
		[Address(RVA = "0x3F9E320", Offset = "0x3F9A320", VA = "0x3F9E320")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6002732")]
		[Address(RVA = "0x3F9E3A8", Offset = "0x3F9A3A8", VA = "0x3F9E3A8", Slot = "12")]
		protected virtual void OnButtonExtendBtnAbilityStonePackItemClicked()
		{
		}

		[Token(Token = "0x6002733")]
		[Address(RVA = "0x3F9E414", Offset = "0x3F9A414", VA = "0x3F9E414", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002734")]
		[Address(RVA = "0x3F9E430", Offset = "0x3F9A430", VA = "0x3F9E430", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__204))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002735")]
		[Address(RVA = "0x3F9E4C4", Offset = "0x3F9A4C4", VA = "0x3F9E4C4", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6002736")]
		[Address(RVA = "0x3F9E578", Offset = "0x3F9A578", VA = "0x3F9E578")]
		public BtnAbilityStonePackItemComponents()
		{
		}
	}
}
