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
	[Token(Token = "0x200086B")]
	public class ElitePackGiftPackPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200086C")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__788 : IAsyncStateMachine
		{
			[Token(Token = "0x4003FBA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003FBB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003FBC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ElitePackGiftPackPanelComponents _003C_003E4__this;

			[Token(Token = "0x4003FBD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6002F5C")]
			[Address(RVA = "0x402E5B0", Offset = "0x402A5B0", VA = "0x402E5B0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002F5D")]
			[Address(RVA = "0x402E828", Offset = "0x402A828", VA = "0x402E828", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003FB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ButtonExtend _buttonExtendBG;

		[Token(Token = "0x4003FB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RectTransform _rectTransformRoot;

		[Token(Token = "0x4003FB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TextMeshProUGUI _textMeshProUGUITxtGiftName;

		[Token(Token = "0x4003FB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ButtonExtend _buttonExtendBtnClose;

		[Token(Token = "0x4003FB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TextMeshProUGUI _textMeshProUGUITxtCutDown;

		[Token(Token = "0x4003FB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private HWIAPButton _hWIAPButtonHWIAPButton;

		[Token(Token = "0x4003FB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private ButtonExtend _buttonExtendHWIAPButton;

		[Token(Token = "0x4003FB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private BenefitValueItem _benefitValueItemBenefitValueItem;

		[Token(Token = "0x17000591")]
		public ButtonExtend ButtonExtendBG
		{
			[Token(Token = "0x6002F4B")]
			[Address(RVA = "0x402E1CC", Offset = "0x402A1CC", VA = "0x402E1CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000592")]
		public RectTransform RectTransformRoot
		{
			[Token(Token = "0x6002F4C")]
			[Address(RVA = "0x402D9D8", Offset = "0x40299D8", VA = "0x402D9D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000593")]
		public TextMeshProUGUI TextMeshProUGUITxtGiftName
		{
			[Token(Token = "0x6002F4D")]
			[Address(RVA = "0x402E0F8", Offset = "0x402A0F8", VA = "0x402E0F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000594")]
		public ButtonExtend ButtonExtendBtnClose
		{
			[Token(Token = "0x6002F4E")]
			[Address(RVA = "0x402E294", Offset = "0x402A294", VA = "0x402E294")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000595")]
		public TextMeshProUGUI TextMeshProUGUITxtCutDown
		{
			[Token(Token = "0x6002F4F")]
			[Address(RVA = "0x402D254", Offset = "0x4029254", VA = "0x402D254")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000596")]
		public HWIAPButton HWIAPButtonHWIAPButton
		{
			[Token(Token = "0x6002F50")]
			[Address(RVA = "0x402D350", Offset = "0x4029350", VA = "0x402D350")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000597")]
		public ButtonExtend ButtonExtendHWIAPButton
		{
			[Token(Token = "0x6002F51")]
			[Address(RVA = "0x402E35C", Offset = "0x402A35C", VA = "0x402E35C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000598")]
		public BenefitValueItem BenefitValueItemBenefitValueItem
		{
			[Token(Token = "0x6002F52")]
			[Address(RVA = "0x402D670", Offset = "0x4029670", VA = "0x402D670")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002F53")]
		[Address(RVA = "0x402E424", Offset = "0x402A424", VA = "0x402E424")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6002F54")]
		[Address(RVA = "0x402D7E0", Offset = "0x40297E0", VA = "0x402D7E0", Slot = "12")]
		protected virtual void OnButtonExtendBGClicked()
		{
		}

		[Token(Token = "0x6002F55")]
		[Address(RVA = "0x402D86C", Offset = "0x402986C", VA = "0x402D86C", Slot = "13")]
		protected virtual void OnButtonExtendBtnCloseClicked()
		{
		}

		[Token(Token = "0x6002F56")]
		[Address(RVA = "0x402E53C", Offset = "0x402A53C", VA = "0x402E53C", Slot = "14")]
		protected virtual void OnButtonExtendHWIAPButtonClicked()
		{
		}

		[Token(Token = "0x6002F57")]
		[Address(RVA = "0x402D124", Offset = "0x4029124", VA = "0x402D124", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002F58")]
		[Address(RVA = "0x402DAFC", Offset = "0x4029AFC", VA = "0x402DAFC", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__788))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002F59")]
		[Address(RVA = "0x402DBEC", Offset = "0x4029BEC", VA = "0x402DBEC", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6002F5A")]
		[Address(RVA = "0x402DAF0", Offset = "0x4029AF0", VA = "0x402DAF0")]
		public ElitePackGiftPackPanelComponents()
		{
		}
	}
}
