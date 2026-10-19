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
	[Token(Token = "0x2000897")]
	public class FundPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000898")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__758 : IAsyncStateMachine
		{
			[Token(Token = "0x400412D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400412E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400412F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public FundPanelComponents _003C_003E4__this;

			[Token(Token = "0x4004130")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60030AD")]
			[Address(RVA = "0x405189C", Offset = "0x404D89C", VA = "0x405189C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60030AE")]
			[Address(RVA = "0x4051B14", Offset = "0x404DB14", VA = "0x4051B14", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ButtonExtend _buttonExtendPanelBlackBG;

		[Token(Token = "0x4004116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Image _imageBG;

		[Token(Token = "0x4004117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TextMeshProUGUI _textMeshProUGUITitle;

		[Token(Token = "0x4004118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private TextMeshProUGUI _textMeshProUGUIFundIntroduction;

		[Token(Token = "0x4004119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TextMeshProUGUI _textMeshProUGUICurrentActivity;

		[Token(Token = "0x400411A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Image _imageRewardsBG_Item2;

		[Token(Token = "0x400411B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Image _imageRewardsBG_Item3;

		[Token(Token = "0x400411C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private ScrollRect _scrollRectScrollView;

		[Token(Token = "0x400411D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private LoopListView2 _loopListView2ScrollView;

		[Token(Token = "0x400411E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private RectTransform _rectTransformTotalItems2;

		[Token(Token = "0x400411F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private RectTransform _rectTransformTotalItems2_Title2;

		[Token(Token = "0x4004120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private ButtonExtend _buttonExtendHWIAPButton;

		[Token(Token = "0x4004121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private ButtonExtend _buttonExtendHWIAPButton1;

		[Token(Token = "0x4004122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private RectTransform _rectTransformTotalItems3;

		[Token(Token = "0x4004123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private RectTransform _rectTransformTotalItems3_Title2;

		[Token(Token = "0x4004124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private RectTransform _rectTransformTotalItems3_Title3;

		[Token(Token = "0x4004125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private ButtonExtend _buttonExtendHWIAPButton2;

		[Token(Token = "0x4004126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private ButtonExtend _buttonExtendHWIAPButton3;

		[Token(Token = "0x4004127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private ButtonExtend _buttonExtendHWIAPButton4;

		[Token(Token = "0x4004128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private RectTransform _rectTransformSwitchFundBtns;

		[Token(Token = "0x4004129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private ButtonExtend _buttonExtendSwitchFundBtn;

		[Token(Token = "0x400412A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private SwitchFundBtn _switchFundBtnSwitchFundBtn;

		[Token(Token = "0x400412B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private ButtonExtend _buttonExtendCloseBtn;

		[Token(Token = "0x400412C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private TextMeshProUGUI _textMeshProUGUITotalGemsNumber;

		[Token(Token = "0x170005EC")]
		public ButtonExtend ButtonExtendPanelBlackBG
		{
			[Token(Token = "0x6003086")]
			[Address(RVA = "0x4050AC4", Offset = "0x404CAC4", VA = "0x4050AC4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005ED")]
		public Image ImageBG
		{
			[Token(Token = "0x6003087")]
			[Address(RVA = "0x40505D0", Offset = "0x404C5D0", VA = "0x40505D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005EE")]
		public TextMeshProUGUI TextMeshProUGUITitle
		{
			[Token(Token = "0x6003088")]
			[Address(RVA = "0x404EED8", Offset = "0x404AED8", VA = "0x404EED8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005EF")]
		public TextMeshProUGUI TextMeshProUGUIFundIntroduction
		{
			[Token(Token = "0x6003089")]
			[Address(RVA = "0x404EFA0", Offset = "0x404AFA0", VA = "0x404EFA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005F0")]
		public TextMeshProUGUI TextMeshProUGUICurrentActivity
		{
			[Token(Token = "0x600308A")]
			[Address(RVA = "0x404F1F8", Offset = "0x404B1F8", VA = "0x404F1F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005F1")]
		public Image ImageRewardsBG_Item2
		{
			[Token(Token = "0x600308B")]
			[Address(RVA = "0x404EAF0", Offset = "0x404AAF0", VA = "0x404EAF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005F2")]
		public Image ImageRewardsBG_Item3
		{
			[Token(Token = "0x600308C")]
			[Address(RVA = "0x404EBB8", Offset = "0x404ABB8", VA = "0x404EBB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005F3")]
		public ScrollRect ScrollRectScrollView
		{
			[Token(Token = "0x600308D")]
			[Address(RVA = "0x4050B8C", Offset = "0x404CB8C", VA = "0x4050B8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005F4")]
		public LoopListView2 LoopListView2ScrollView
		{
			[Token(Token = "0x600308E")]
			[Address(RVA = "0x404F068", Offset = "0x404B068", VA = "0x404F068")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005F5")]
		public RectTransform RectTransformTotalItems2
		{
			[Token(Token = "0x600308F")]
			[Address(RVA = "0x404D310", Offset = "0x4049310", VA = "0x404D310")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005F6")]
		public RectTransform RectTransformTotalItems2_Title2
		{
			[Token(Token = "0x6003090")]
			[Address(RVA = "0x404EC80", Offset = "0x404AC80", VA = "0x404EC80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005F7")]
		public ButtonExtend ButtonExtendHWIAPButton
		{
			[Token(Token = "0x6003091")]
			[Address(RVA = "0x4050C54", Offset = "0x404CC54", VA = "0x4050C54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005F8")]
		public ButtonExtend ButtonExtendHWIAPButton1
		{
			[Token(Token = "0x6003092")]
			[Address(RVA = "0x4050D1C", Offset = "0x404CD1C", VA = "0x4050D1C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005F9")]
		public RectTransform RectTransformTotalItems3
		{
			[Token(Token = "0x6003093")]
			[Address(RVA = "0x404D3D8", Offset = "0x40493D8", VA = "0x404D3D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005FA")]
		public RectTransform RectTransformTotalItems3_Title2
		{
			[Token(Token = "0x6003094")]
			[Address(RVA = "0x404ED48", Offset = "0x404AD48", VA = "0x404ED48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005FB")]
		public RectTransform RectTransformTotalItems3_Title3
		{
			[Token(Token = "0x6003095")]
			[Address(RVA = "0x404EE10", Offset = "0x404AE10", VA = "0x404EE10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005FC")]
		public ButtonExtend ButtonExtendHWIAPButton2
		{
			[Token(Token = "0x6003096")]
			[Address(RVA = "0x4050DE4", Offset = "0x404CDE4", VA = "0x4050DE4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005FD")]
		public ButtonExtend ButtonExtendHWIAPButton3
		{
			[Token(Token = "0x6003097")]
			[Address(RVA = "0x4050EAC", Offset = "0x404CEAC", VA = "0x4050EAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005FE")]
		public ButtonExtend ButtonExtendHWIAPButton4
		{
			[Token(Token = "0x6003098")]
			[Address(RVA = "0x4050F74", Offset = "0x404CF74", VA = "0x4050F74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005FF")]
		public RectTransform RectTransformSwitchFundBtns
		{
			[Token(Token = "0x6003099")]
			[Address(RVA = "0x404FA50", Offset = "0x404BA50", VA = "0x404FA50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000600")]
		public ButtonExtend ButtonExtendSwitchFundBtn
		{
			[Token(Token = "0x600309A")]
			[Address(RVA = "0x405103C", Offset = "0x404D03C", VA = "0x405103C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000601")]
		public SwitchFundBtn SwitchFundBtnSwitchFundBtn
		{
			[Token(Token = "0x600309B")]
			[Address(RVA = "0x404F988", Offset = "0x404B988", VA = "0x404F988")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000602")]
		public ButtonExtend ButtonExtendCloseBtn
		{
			[Token(Token = "0x600309C")]
			[Address(RVA = "0x4051104", Offset = "0x404D104", VA = "0x4051104")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000603")]
		public TextMeshProUGUI TextMeshProUGUITotalGemsNumber
		{
			[Token(Token = "0x600309D")]
			[Address(RVA = "0x404F130", Offset = "0x404B130", VA = "0x404F130")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600309E")]
		[Address(RVA = "0x40511CC", Offset = "0x404D1CC", VA = "0x40511CC")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x600309F")]
		[Address(RVA = "0x404FFA8", Offset = "0x404BFA8", VA = "0x404FFA8", Slot = "12")]
		protected virtual void OnButtonExtendPanelBlackBGClicked()
		{
		}

		[Token(Token = "0x60030A0")]
		[Address(RVA = "0x40514A4", Offset = "0x404D4A4", VA = "0x40514A4", Slot = "13")]
		protected virtual void OnScrollRectScrollViewValueChanged(Vector2 arg)
		{
		}

		[Token(Token = "0x60030A1")]
		[Address(RVA = "0x4051558", Offset = "0x404D558", VA = "0x4051558", Slot = "14")]
		protected virtual void OnButtonExtendHWIAPButtonClicked()
		{
		}

		[Token(Token = "0x60030A2")]
		[Address(RVA = "0x40515C4", Offset = "0x404D5C4", VA = "0x40515C4", Slot = "15")]
		protected virtual void OnButtonExtendHWIAPButton1Clicked()
		{
		}

		[Token(Token = "0x60030A3")]
		[Address(RVA = "0x4051630", Offset = "0x404D630", VA = "0x4051630", Slot = "16")]
		protected virtual void OnButtonExtendHWIAPButton2Clicked()
		{
		}

		[Token(Token = "0x60030A4")]
		[Address(RVA = "0x405169C", Offset = "0x404D69C", VA = "0x405169C", Slot = "17")]
		protected virtual void OnButtonExtendHWIAPButton3Clicked()
		{
		}

		[Token(Token = "0x60030A5")]
		[Address(RVA = "0x4051708", Offset = "0x404D708", VA = "0x4051708", Slot = "18")]
		protected virtual void OnButtonExtendHWIAPButton4Clicked()
		{
		}

		[Token(Token = "0x60030A6")]
		[Address(RVA = "0x4051774", Offset = "0x404D774", VA = "0x4051774", Slot = "19")]
		protected virtual void OnButtonExtendSwitchFundBtnClicked()
		{
		}

		[Token(Token = "0x60030A7")]
		[Address(RVA = "0x4050034", Offset = "0x404C034", VA = "0x4050034", Slot = "20")]
		protected virtual void OnButtonExtendCloseBtnClicked()
		{
		}

		[Token(Token = "0x60030A8")]
		[Address(RVA = "0x404D2F4", Offset = "0x40492F4", VA = "0x404D2F4", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60030A9")]
		[Address(RVA = "0x40501E0", Offset = "0x404C1E0", VA = "0x40501E0", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__758))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60030AA")]
		[Address(RVA = "0x40517E0", Offset = "0x404D7E0", VA = "0x40517E0", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60030AB")]
		[Address(RVA = "0x40501D4", Offset = "0x404C1D4", VA = "0x40501D4")]
		public FundPanelComponents()
		{
		}
	}
}
