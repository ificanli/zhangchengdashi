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
	[Token(Token = "0x20008F3")]
	public class GiftChainPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20008F4")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__328 : IAsyncStateMachine
		{
			[Token(Token = "0x40043AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40043AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40043AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GiftChainPanelComponents _003C_003E4__this;

			[Token(Token = "0x40043AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x600339E")]
			[Address(RVA = "0x409C44C", Offset = "0x409844C", VA = "0x409C44C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600339F")]
			[Address(RVA = "0x409C6C4", Offset = "0x40986C4", VA = "0x409C6C4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400439F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ButtonExtend _buttonExtendBtnCloseAllScreen;

		[Token(Token = "0x40043A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RectTransform _rectTransformCenter;

		[Token(Token = "0x40043A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BenefitValueItem _benefitValueItemBenefitValueItem;

		[Token(Token = "0x40043A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private TextMeshProUGUI _textMeshProUGUITxtTitle;

		[Token(Token = "0x40043A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TextMeshProUGUI _textMeshProUGUITxtDes;

		[Token(Token = "0x40043A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private TextMeshProUGUI _textMeshProUGUITxtCutDown;

		[Token(Token = "0x40043A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private ScrollRect _scrollRectScrollView;

		[Token(Token = "0x40043A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private LoopListView2 _loopListView2ScrollView;

		[Token(Token = "0x40043A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private ButtonExtend _buttonExtendBuy;

		[Token(Token = "0x40043A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private ButtonExtend _buttonExtendHWIAPButton;

		[Token(Token = "0x40043A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private ButtonExtend _buttonExtendBtnClose;

		[Token(Token = "0x170006F0")]
		public ButtonExtend ButtonExtendBtnCloseAllScreen
		{
			[Token(Token = "0x6003388")]
			[Address(RVA = "0x409BDB4", Offset = "0x4097DB4", VA = "0x409BDB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006F1")]
		public RectTransform RectTransformCenter
		{
			[Token(Token = "0x6003389")]
			[Address(RVA = "0x409957C", Offset = "0x409557C", VA = "0x409957C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006F2")]
		public BenefitValueItem BenefitValueItemBenefitValueItem
		{
			[Token(Token = "0x600338A")]
			[Address(RVA = "0x409BCE0", Offset = "0x4097CE0", VA = "0x409BCE0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006F3")]
		public TextMeshProUGUI TextMeshProUGUITxtTitle
		{
			[Token(Token = "0x600338B")]
			[Address(RVA = "0x409BB50", Offset = "0x4097B50", VA = "0x409BB50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006F4")]
		public TextMeshProUGUI TextMeshProUGUITxtDes
		{
			[Token(Token = "0x600338C")]
			[Address(RVA = "0x409BC18", Offset = "0x4097C18", VA = "0x409BC18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006F5")]
		public TextMeshProUGUI TextMeshProUGUITxtCutDown
		{
			[Token(Token = "0x600338D")]
			[Address(RVA = "0x4098488", Offset = "0x4094488", VA = "0x4098488")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006F6")]
		public ScrollRect ScrollRectScrollView
		{
			[Token(Token = "0x600338E")]
			[Address(RVA = "0x409916C", Offset = "0x409516C", VA = "0x409916C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006F7")]
		public LoopListView2 LoopListView2ScrollView
		{
			[Token(Token = "0x600338F")]
			[Address(RVA = "0x40997E8", Offset = "0x40957E8", VA = "0x40997E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006F8")]
		public ButtonExtend ButtonExtendBuy
		{
			[Token(Token = "0x6003390")]
			[Address(RVA = "0x409BE7C", Offset = "0x4097E7C", VA = "0x409BE7C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006F9")]
		public ButtonExtend ButtonExtendHWIAPButton
		{
			[Token(Token = "0x6003391")]
			[Address(RVA = "0x409BF44", Offset = "0x4097F44", VA = "0x409BF44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006FA")]
		public ButtonExtend ButtonExtendBtnClose
		{
			[Token(Token = "0x6003392")]
			[Address(RVA = "0x409C00C", Offset = "0x409800C", VA = "0x409C00C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003393")]
		[Address(RVA = "0x409C0D4", Offset = "0x40980D4", VA = "0x409C0D4")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6003394")]
		[Address(RVA = "0x40996F0", Offset = "0x40956F0", VA = "0x40996F0", Slot = "12")]
		protected virtual void OnButtonExtendBtnCloseAllScreenClicked()
		{
		}

		[Token(Token = "0x6003395")]
		[Address(RVA = "0x409C29C", Offset = "0x409829C", VA = "0x409C29C", Slot = "13")]
		protected virtual void OnScrollRectScrollViewValueChanged(Vector2 arg)
		{
		}

		[Token(Token = "0x6003396")]
		[Address(RVA = "0x409C350", Offset = "0x4098350", VA = "0x409C350", Slot = "14")]
		protected virtual void OnButtonExtendBuyClicked()
		{
		}

		[Token(Token = "0x6003397")]
		[Address(RVA = "0x409C3BC", Offset = "0x40983BC", VA = "0x409C3BC", Slot = "15")]
		protected virtual void OnButtonExtendHWIAPButtonClicked()
		{
		}

		[Token(Token = "0x6003398")]
		[Address(RVA = "0x4099664", Offset = "0x4095664", VA = "0x4099664", Slot = "16")]
		protected virtual void OnButtonExtendBtnCloseClicked()
		{
		}

		[Token(Token = "0x6003399")]
		[Address(RVA = "0x409C428", Offset = "0x4098428", VA = "0x409C428", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600339A")]
		[Address(RVA = "0x40998B4", Offset = "0x40958B4", VA = "0x40998B4", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__328))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x600339B")]
		[Address(RVA = "0x40999A4", Offset = "0x40959A4", VA = "0x40999A4", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x600339C")]
		[Address(RVA = "0x40997AC", Offset = "0x40957AC", VA = "0x40997AC")]
		public GiftChainPanelComponents()
		{
		}
	}
}
