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
	[Token(Token = "0x2000B76")]
	public class SpecialOfferGiftPackPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B77")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__791 : IAsyncStateMachine
		{
			[Token(Token = "0x4005398")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005399")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400539A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SpecialOfferGiftPackPanelComponents _003C_003E4__this;

			[Token(Token = "0x400539B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x600463B")]
			[Address(RVA = "0x4212B58", Offset = "0x420EB58", VA = "0x4212B58", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600463C")]
			[Address(RVA = "0x4212DD0", Offset = "0x420EDD0", VA = "0x4212DD0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4005390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ButtonExtend _buttonExtendBG;

		[Token(Token = "0x4005391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RectTransform _rectTransformRoot;

		[Token(Token = "0x4005392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TextMeshProUGUI _textMeshProUGUITxtGiftName;

		[Token(Token = "0x4005393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ButtonExtend _buttonExtendBtnClose;

		[Token(Token = "0x4005394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TextMeshProUGUI _textMeshProUGUITxtCutDown;

		[Token(Token = "0x4005395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private HWIAPButton _hWIAPButtonHWIAPButton;

		[Token(Token = "0x4005396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private ButtonExtend _buttonExtendHWIAPButton;

		[Token(Token = "0x4005397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private BenefitValueItem _benefitValueItemBenefitValueItem;

		[Token(Token = "0x17000BD3")]
		public ButtonExtend ButtonExtendBG
		{
			[Token(Token = "0x600462A")]
			[Address(RVA = "0x4212148", Offset = "0x420E148", VA = "0x4212148")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BD4")]
		public RectTransform RectTransformRoot
		{
			[Token(Token = "0x600462B")]
			[Address(RVA = "0x4212210", Offset = "0x420E210", VA = "0x4212210")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BD5")]
		public TextMeshProUGUI TextMeshProUGUITxtGiftName
		{
			[Token(Token = "0x600462C")]
			[Address(RVA = "0x42122D8", Offset = "0x420E2D8", VA = "0x42122D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BD6")]
		public ButtonExtend ButtonExtendBtnClose
		{
			[Token(Token = "0x600462D")]
			[Address(RVA = "0x42123A0", Offset = "0x420E3A0", VA = "0x42123A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BD7")]
		public TextMeshProUGUI TextMeshProUGUITxtCutDown
		{
			[Token(Token = "0x600462E")]
			[Address(RVA = "0x4212468", Offset = "0x420E468", VA = "0x4212468")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BD8")]
		public HWIAPButton HWIAPButtonHWIAPButton
		{
			[Token(Token = "0x600462F")]
			[Address(RVA = "0x4212530", Offset = "0x420E530", VA = "0x4212530")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BD9")]
		public ButtonExtend ButtonExtendHWIAPButton
		{
			[Token(Token = "0x6004630")]
			[Address(RVA = "0x42125F8", Offset = "0x420E5F8", VA = "0x42125F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BDA")]
		public BenefitValueItem BenefitValueItemBenefitValueItem
		{
			[Token(Token = "0x6004631")]
			[Address(RVA = "0x42126C0", Offset = "0x420E6C0", VA = "0x42126C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004632")]
		[Address(RVA = "0x4212788", Offset = "0x420E788", VA = "0x4212788")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6004633")]
		[Address(RVA = "0x42128A0", Offset = "0x420E8A0", VA = "0x42128A0", Slot = "12")]
		protected virtual void OnButtonExtendBGClicked()
		{
		}

		[Token(Token = "0x6004634")]
		[Address(RVA = "0x421290C", Offset = "0x420E90C", VA = "0x421290C", Slot = "13")]
		protected virtual void OnButtonExtendBtnCloseClicked()
		{
		}

		[Token(Token = "0x6004635")]
		[Address(RVA = "0x4212978", Offset = "0x420E978", VA = "0x4212978", Slot = "14")]
		protected virtual void OnButtonExtendHWIAPButtonClicked()
		{
		}

		[Token(Token = "0x6004636")]
		[Address(RVA = "0x42129E4", Offset = "0x420E9E4", VA = "0x42129E4", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6004637")]
		[Address(RVA = "0x4212A00", Offset = "0x420EA00", VA = "0x4212A00", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__791))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6004638")]
		[Address(RVA = "0x4212A94", Offset = "0x420EA94", VA = "0x4212A94", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6004639")]
		[Address(RVA = "0x4212B48", Offset = "0x420EB48", VA = "0x4212B48")]
		public SpecialOfferGiftPackPanelComponents()
		{
		}
	}
}
