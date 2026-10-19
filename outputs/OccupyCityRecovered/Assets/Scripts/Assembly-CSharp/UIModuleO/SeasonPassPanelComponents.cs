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
	[Token(Token = "0x2000AFA")]
	public class SeasonPassPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000AFB")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__591 : IAsyncStateMachine
		{
			[Token(Token = "0x4005083")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005084")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005085")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SeasonPassPanelComponents _003C_003E4__this;

			[Token(Token = "0x4005086")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x600428A")]
			[Address(RVA = "0x41D0134", Offset = "0x41CC134", VA = "0x41D0134", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600428B")]
			[Address(RVA = "0x41D03AC", Offset = "0x41CC3AC", VA = "0x41D03AC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400506A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ButtonExtend _buttonExtendPanelBlackBG;

		[Token(Token = "0x400506B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Image _imageCharacterBG;

		[Token(Token = "0x400506C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Image _imageCharacter;

		[Token(Token = "0x400506D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private TextMeshProUGUI _textMeshProUGUITitle1;

		[Token(Token = "0x400506E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TextMeshProUGUI _textMeshProUGUIRemainingTime;

		[Token(Token = "0x400506F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private ScrollRect _scrollRectScrollView;

		[Token(Token = "0x4005070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private LoopListView2 _loopListView2ScrollView;

		[Token(Token = "0x4005071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private RectTransform _rectTransformReturnTopBtn;

		[Token(Token = "0x4005072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private ButtonExtend _buttonExtendReturnTopBtn;

		[Token(Token = "0x4005073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private RectTransform _rectTransformNextLevelBG;

		[Token(Token = "0x4005074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private TextMeshProUGUI _textMeshProUGUINextLevel;

		[Token(Token = "0x4005075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private RectTransform _rectTransformLevelProgressBG;

		[Token(Token = "0x4005076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private RectTransform _rectTransformLevelProgressBar;

		[Token(Token = "0x4005077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private TextMeshProUGUI _textMeshProUGUILevelProgressText;

		[Token(Token = "0x4005078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Image _imageLevelRightIcon;

		[Token(Token = "0x4005079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private ButtonExtend _buttonExtendSeasonPassIntroduceBtn;

		[Token(Token = "0x400507A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private RectTransform _rectTransformMaxLevelRewardPreviewBtn;

		[Token(Token = "0x400507B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private ButtonExtend _buttonExtendMaxLevelRewardPreviewBtn;

		[Token(Token = "0x400507C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private RectTransform _rectTransformMaxLevelRewardPreviewItem_Line1;

		[Token(Token = "0x400507D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private SeasonPassRewardItem_Line _seasonPassRewardItem_LineMaxLevelRewardPreviewItem_Line1;

		[Token(Token = "0x400507E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RectTransform _rectTransformMaxLevelRewardPreviewItem_Line2;

		[Token(Token = "0x400507F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private SeasonPassRewardItem_Line _seasonPassRewardItem_LineMaxLevelRewardPreviewItem_Line2;

		[Token(Token = "0x4005080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private ButtonExtend _buttonExtendCloseBtn;

		[Token(Token = "0x4005081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private HWIAPButton _hWIAPButtonHWIAPButton;

		[Token(Token = "0x4005082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private ButtonExtend _buttonExtendHWIAPButton;

		[Token(Token = "0x17000A9C")]
		public ButtonExtend ButtonExtendPanelBlackBG
		{
			[Token(Token = "0x6004264")]
			[Address(RVA = "0x41CF7EC", Offset = "0x41CB7EC", VA = "0x41CF7EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A9D")]
		public Image ImageCharacterBG
		{
			[Token(Token = "0x6004265")]
			[Address(RVA = "0x41CDCB0", Offset = "0x41C9CB0", VA = "0x41CDCB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A9E")]
		public Image ImageCharacter
		{
			[Token(Token = "0x6004266")]
			[Address(RVA = "0x41CDD78", Offset = "0x41C9D78", VA = "0x41CDD78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A9F")]
		public TextMeshProUGUI TextMeshProUGUITitle1
		{
			[Token(Token = "0x6004267")]
			[Address(RVA = "0x41CF1A0", Offset = "0x41CB1A0", VA = "0x41CF1A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AA0")]
		public TextMeshProUGUI TextMeshProUGUIRemainingTime
		{
			[Token(Token = "0x6004268")]
			[Address(RVA = "0x41CBC1C", Offset = "0x41C7C1C", VA = "0x41CBC1C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AA1")]
		public ScrollRect ScrollRectScrollView
		{
			[Token(Token = "0x6004269")]
			[Address(RVA = "0x41CF718", Offset = "0x41CB718", VA = "0x41CF718")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AA2")]
		public LoopListView2 LoopListView2ScrollView
		{
			[Token(Token = "0x600426A")]
			[Address(RVA = "0x41CC520", Offset = "0x41C8520", VA = "0x41CC520")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AA3")]
		public RectTransform RectTransformReturnTopBtn
		{
			[Token(Token = "0x600426B")]
			[Address(RVA = "0x41CCAF0", Offset = "0x41C8AF0", VA = "0x41CCAF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AA4")]
		public ButtonExtend ButtonExtendReturnTopBtn
		{
			[Token(Token = "0x600426C")]
			[Address(RVA = "0x41CF8B4", Offset = "0x41CB8B4", VA = "0x41CF8B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AA5")]
		public RectTransform RectTransformNextLevelBG
		{
			[Token(Token = "0x600426D")]
			[Address(RVA = "0x41CF4C0", Offset = "0x41CB4C0", VA = "0x41CF4C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AA6")]
		public TextMeshProUGUI TextMeshProUGUINextLevel
		{
			[Token(Token = "0x600426E")]
			[Address(RVA = "0x41CF650", Offset = "0x41CB650", VA = "0x41CF650")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AA7")]
		public RectTransform RectTransformLevelProgressBG
		{
			[Token(Token = "0x600426F")]
			[Address(RVA = "0x41CF330", Offset = "0x41CB330", VA = "0x41CF330")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AA8")]
		public RectTransform RectTransformLevelProgressBar
		{
			[Token(Token = "0x6004270")]
			[Address(RVA = "0x41CF268", Offset = "0x41CB268", VA = "0x41CF268")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AA9")]
		public TextMeshProUGUI TextMeshProUGUILevelProgressText
		{
			[Token(Token = "0x6004271")]
			[Address(RVA = "0x41CF3F8", Offset = "0x41CB3F8", VA = "0x41CF3F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AAA")]
		public Image ImageLevelRightIcon
		{
			[Token(Token = "0x6004272")]
			[Address(RVA = "0x41CF588", Offset = "0x41CB588", VA = "0x41CF588")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AAB")]
		public ButtonExtend ButtonExtendSeasonPassIntroduceBtn
		{
			[Token(Token = "0x6004273")]
			[Address(RVA = "0x41CF97C", Offset = "0x41CB97C", VA = "0x41CF97C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AAC")]
		public RectTransform RectTransformMaxLevelRewardPreviewBtn
		{
			[Token(Token = "0x6004274")]
			[Address(RVA = "0x41CCA28", Offset = "0x41C8A28", VA = "0x41CCA28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AAD")]
		public ButtonExtend ButtonExtendMaxLevelRewardPreviewBtn
		{
			[Token(Token = "0x6004275")]
			[Address(RVA = "0x41CFA44", Offset = "0x41CBA44", VA = "0x41CFA44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AAE")]
		public RectTransform RectTransformMaxLevelRewardPreviewItem_Line1
		{
			[Token(Token = "0x6004276")]
			[Address(RVA = "0x41CC7D0", Offset = "0x41C87D0", VA = "0x41CC7D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AAF")]
		public SeasonPassRewardItem_Line SeasonPassRewardItem_LineMaxLevelRewardPreviewItem_Line1
		{
			[Token(Token = "0x6004277")]
			[Address(RVA = "0x41CC708", Offset = "0x41C8708", VA = "0x41CC708")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AB0")]
		public RectTransform RectTransformMaxLevelRewardPreviewItem_Line2
		{
			[Token(Token = "0x6004278")]
			[Address(RVA = "0x41CC898", Offset = "0x41C8898", VA = "0x41CC898")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AB1")]
		public SeasonPassRewardItem_Line SeasonPassRewardItem_LineMaxLevelRewardPreviewItem_Line2
		{
			[Token(Token = "0x6004279")]
			[Address(RVA = "0x41CC960", Offset = "0x41C8960", VA = "0x41CC960")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AB2")]
		public ButtonExtend ButtonExtendCloseBtn
		{
			[Token(Token = "0x600427A")]
			[Address(RVA = "0x41CFB0C", Offset = "0x41CBB0C", VA = "0x41CFB0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AB3")]
		public HWIAPButton HWIAPButtonHWIAPButton
		{
			[Token(Token = "0x600427B")]
			[Address(RVA = "0x41CE1F4", Offset = "0x41CA1F4", VA = "0x41CE1F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AB4")]
		public ButtonExtend ButtonExtendHWIAPButton
		{
			[Token(Token = "0x600427C")]
			[Address(RVA = "0x41CFBD4", Offset = "0x41CBBD4", VA = "0x41CFBD4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600427D")]
		[Address(RVA = "0x41CFC9C", Offset = "0x41CBC9C", VA = "0x41CFC9C")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x600427E")]
		[Address(RVA = "0x41CFEEC", Offset = "0x41CBEEC", VA = "0x41CFEEC", Slot = "12")]
		protected virtual void OnButtonExtendPanelBlackBGClicked()
		{
		}

		[Token(Token = "0x600427F")]
		[Address(RVA = "0x41CFF58", Offset = "0x41CBF58", VA = "0x41CFF58", Slot = "13")]
		protected virtual void OnScrollRectScrollViewValueChanged(Vector2 arg)
		{
		}

		[Token(Token = "0x6004280")]
		[Address(RVA = "0x41CCF3C", Offset = "0x41C8F3C", VA = "0x41CCF3C", Slot = "14")]
		protected virtual void OnButtonExtendReturnTopBtnClicked()
		{
		}

		[Token(Token = "0x6004281")]
		[Address(RVA = "0x41CD534", Offset = "0x41C9534", VA = "0x41CD534", Slot = "15")]
		protected virtual void OnButtonExtendSeasonPassIntroduceBtnClicked()
		{
		}

		[Token(Token = "0x6004282")]
		[Address(RVA = "0x41CCE8C", Offset = "0x41C8E8C", VA = "0x41CCE8C", Slot = "16")]
		protected virtual void OnButtonExtendMaxLevelRewardPreviewBtnClicked()
		{
		}

		[Token(Token = "0x6004283")]
		[Address(RVA = "0x41CCDE4", Offset = "0x41C8DE4", VA = "0x41CCDE4", Slot = "17")]
		protected virtual void OnButtonExtendCloseBtnClicked()
		{
		}

		[Token(Token = "0x6004284")]
		[Address(RVA = "0x41D000C", Offset = "0x41CC00C", VA = "0x41D000C", Slot = "18")]
		protected virtual void OnButtonExtendHWIAPButtonClicked()
		{
		}

		[Token(Token = "0x6004285")]
		[Address(RVA = "0x41CBA10", Offset = "0x41C7A10", VA = "0x41CBA10", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6004286")]
		[Address(RVA = "0x41CD638", Offset = "0x41C9638", VA = "0x41CD638", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__591))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6004287")]
		[Address(RVA = "0x41D0078", Offset = "0x41CC078", VA = "0x41D0078", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6004288")]
		[Address(RVA = "0x41CD62C", Offset = "0x41C962C", VA = "0x41CD62C")]
		public SeasonPassPanelComponents()
		{
		}
	}
}
