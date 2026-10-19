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
	[Token(Token = "0x20008FD")]
	public class GiftChainPanel2Components : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20008FE")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__421 : IAsyncStateMachine
		{
			[Token(Token = "0x40043D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40043D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40043D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GiftChainPanel2Components _003C_003E4__this;

			[Token(Token = "0x40043D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60033D8")]
			[Address(RVA = "0x40A07BC", Offset = "0x409C7BC", VA = "0x40A07BC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60033D9")]
			[Address(RVA = "0x40A0A34", Offset = "0x409CA34", VA = "0x40A0A34", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40043CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ButtonExtend _buttonExtendBtnCloseAllScreen;

		[Token(Token = "0x40043CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BenefitValueItem _benefitValueItemBenefitValueItem;

		[Token(Token = "0x40043CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TextMeshProUGUI _textMeshProUGUITxtTitle;

		[Token(Token = "0x40043CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private TextMeshProUGUI _textMeshProUGUITxtDes;

		[Token(Token = "0x40043CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TextMeshProUGUI _textMeshProUGUITxtCutDown;

		[Token(Token = "0x40043CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private ScrollRect _scrollRectScrollView;

		[Token(Token = "0x40043D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private LoopListView2 _loopListView2ScrollView;

		[Token(Token = "0x40043D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private ButtonExtend _buttonExtendBuy;

		[Token(Token = "0x40043D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private ButtonExtend _buttonExtendHWIAPButton;

		[Token(Token = "0x40043D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private ButtonExtend _buttonExtendBtnClose;

		[Token(Token = "0x170006FB")]
		public ButtonExtend ButtonExtendBtnCloseAllScreen
		{
			[Token(Token = "0x60033C3")]
			[Address(RVA = "0x40A008C", Offset = "0x409C08C", VA = "0x40A008C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006FC")]
		public BenefitValueItem BenefitValueItemBenefitValueItem
		{
			[Token(Token = "0x60033C4")]
			[Address(RVA = "0x409CF34", Offset = "0x4098F34", VA = "0x409CF34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006FD")]
		public TextMeshProUGUI TextMeshProUGUITxtTitle
		{
			[Token(Token = "0x60033C5")]
			[Address(RVA = "0x409CDA4", Offset = "0x4098DA4", VA = "0x409CDA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006FE")]
		public TextMeshProUGUI TextMeshProUGUITxtDes
		{
			[Token(Token = "0x60033C6")]
			[Address(RVA = "0x409CE6C", Offset = "0x4098E6C", VA = "0x409CE6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006FF")]
		public TextMeshProUGUI TextMeshProUGUITxtCutDown
		{
			[Token(Token = "0x60033C7")]
			[Address(RVA = "0x409D144", Offset = "0x4099144", VA = "0x409D144")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000700")]
		public ScrollRect ScrollRectScrollView
		{
			[Token(Token = "0x60033C8")]
			[Address(RVA = "0x409DFB4", Offset = "0x4099FB4", VA = "0x409DFB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000701")]
		public LoopListView2 LoopListView2ScrollView
		{
			[Token(Token = "0x60033C9")]
			[Address(RVA = "0x409CFFC", Offset = "0x4098FFC", VA = "0x409CFFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000702")]
		public ButtonExtend ButtonExtendBuy
		{
			[Token(Token = "0x60033CA")]
			[Address(RVA = "0x40A0154", Offset = "0x409C154", VA = "0x40A0154")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000703")]
		public ButtonExtend ButtonExtendHWIAPButton
		{
			[Token(Token = "0x60033CB")]
			[Address(RVA = "0x40A021C", Offset = "0x409C21C", VA = "0x40A021C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000704")]
		public ButtonExtend ButtonExtendBtnClose
		{
			[Token(Token = "0x60033CC")]
			[Address(RVA = "0x40A02E4", Offset = "0x409C2E4", VA = "0x40A02E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60033CD")]
		[Address(RVA = "0x40A03AC", Offset = "0x409C3AC", VA = "0x40A03AC")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x60033CE")]
		[Address(RVA = "0x409E1D0", Offset = "0x409A1D0", VA = "0x409E1D0", Slot = "12")]
		protected virtual void OnButtonExtendBtnCloseAllScreenClicked()
		{
		}

		[Token(Token = "0x60033CF")]
		[Address(RVA = "0x40A0574", Offset = "0x409C574", VA = "0x40A0574", Slot = "13")]
		protected virtual void OnScrollRectScrollViewValueChanged(Vector2 arg)
		{
		}

		[Token(Token = "0x60033D0")]
		[Address(RVA = "0x40A0628", Offset = "0x409C628", VA = "0x40A0628", Slot = "14")]
		protected virtual void OnButtonExtendBuyClicked()
		{
		}

		[Token(Token = "0x60033D1")]
		[Address(RVA = "0x40A0694", Offset = "0x409C694", VA = "0x40A0694", Slot = "15")]
		protected virtual void OnButtonExtendHWIAPButtonClicked()
		{
		}

		[Token(Token = "0x60033D2")]
		[Address(RVA = "0x409E144", Offset = "0x409A144", VA = "0x409E144", Slot = "16")]
		protected virtual void OnButtonExtendBtnCloseClicked()
		{
		}

		[Token(Token = "0x60033D3")]
		[Address(RVA = "0x409C88C", Offset = "0x409888C", VA = "0x409C88C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60033D4")]
		[Address(RVA = "0x409E298", Offset = "0x409A298", VA = "0x409E298", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__421))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60033D5")]
		[Address(RVA = "0x40A0700", Offset = "0x409C700", VA = "0x40A0700", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60033D6")]
		[Address(RVA = "0x409E28C", Offset = "0x409A28C", VA = "0x409E28C")]
		public GiftChainPanel2Components()
		{
		}
	}
}
