using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using LocalizationModule;
using TMPro;
using UIFramework;
using UIModuleO.UIAnim;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000B0F")]
	public class SettingsPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B10")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__863 : IAsyncStateMachine
		{
			[Token(Token = "0x40050F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40050F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40050F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SettingsPanelComponents _003C_003E4__this;

			[Token(Token = "0x40050F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6004342")]
			[Address(RVA = "0x41D9284", Offset = "0x41D5284", VA = "0x41D9284", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004343")]
			[Address(RVA = "0x41D94FC", Offset = "0x41D54FC", VA = "0x41D94FC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40050D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Button _buttonBlack;

		[Token(Token = "0x40050D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RectTransform _rectTransformPopUp;

		[Token(Token = "0x40050D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TextMeshProUGUI _textMeshProUGUITxtTitle;

		[Token(Token = "0x40050D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Button _buttonUsid;

		[Token(Token = "0x40050D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private RectTransform _rectTransformGrid;

		[Token(Token = "0x40050D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private ButtonExtend _buttonExtendSoundSwitchBtn;

		[Token(Token = "0x40050D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private ButtonExtend _buttonExtendBgmSwitchBtn;

		[Token(Token = "0x40050D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private ButtonExtend _buttonExtendVibratorBtn;

		[Token(Token = "0x40050D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private ButtonExtend _buttonExtendCdkBtn;

		[Token(Token = "0x40050D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private ButtonExtend _buttonExtendAnnouncementBtn;

		[Token(Token = "0x40050DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Button _buttonScanCodeBtn;

		[Token(Token = "0x40050DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private ScrollRect _scrollRectTemplate;

		[Token(Token = "0x40050DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Toggle _toggleItem;

		[Token(Token = "0x40050DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Scrollbar _scrollbarScrollbar;

		[Token(Token = "0x40050DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private ButtonExtend _buttonExtendPolicyBtn;

		[Token(Token = "0x40050DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private ButtonExtend _buttonExtendUserProtocolBtn;

		[Token(Token = "0x40050E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private ButtonExtend _buttonExtendFeedbackBtn;

		[Token(Token = "0x40050E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private ButtonExtend _buttonExtendKefu;

		[Token(Token = "0x40050E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private ButtonExtend _buttonExtendRestoreBtn;

		[Token(Token = "0x40050E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private ButtonExtend _buttonExtendConnectAccount;

		[Token(Token = "0x40050E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private ButtonExtend _buttonExtendDisconnectAccount;

		[Token(Token = "0x40050E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private ButtonExtend _buttonExtendProxyLoginBtn;

		[Token(Token = "0x40050E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private ButtonExtend _buttonExtendMoreSettingsBtn;

		[Token(Token = "0x40050E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private LanguageDropdownExtend _languageDropdownExtendLanguage;

		[Token(Token = "0x40050E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private ScrollRect _scrollRectTemplate1;

		[Token(Token = "0x40050E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Toggle _toggleItem1;

		[Token(Token = "0x40050EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private ButtonExtend _buttonExtendCloseBtn;

		[Token(Token = "0x40050EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private RectTransform _rectTransformCdkPanel;

		[Token(Token = "0x40050EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Button _buttonCdkPanelMask;

		[Token(Token = "0x40050ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private TMP_InputField _tMP_InputFieldCdkInputField;

		[Token(Token = "0x40050EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private ButtonExtend _buttonExtendConfirmBtn;

		[Token(Token = "0x40050EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private ButtonExtend _buttonExtendCloseCdkPanelBtn;

		[Token(Token = "0x17000ACE")]
		public Button ButtonBlack
		{
			[Token(Token = "0x6004301")]
			[Address(RVA = "0x41D7300", Offset = "0x41D3300", VA = "0x41D7300")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000ACF")]
		public RectTransform RectTransformPopUp
		{
			[Token(Token = "0x6004302")]
			[Address(RVA = "0x41D4BB8", Offset = "0x41D0BB8", VA = "0x41D4BB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AD0")]
		public TextMeshProUGUI TextMeshProUGUITxtTitle
		{
			[Token(Token = "0x6004303")]
			[Address(RVA = "0x41D5210", Offset = "0x41D1210", VA = "0x41D5210")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AD1")]
		public Button ButtonUsid
		{
			[Token(Token = "0x6004304")]
			[Address(RVA = "0x41D73C8", Offset = "0x41D33C8", VA = "0x41D73C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AD2")]
		public RectTransform RectTransformGrid
		{
			[Token(Token = "0x6004305")]
			[Address(RVA = "0x41D4F2C", Offset = "0x41D0F2C", VA = "0x41D4F2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AD3")]
		public ButtonExtend ButtonExtendSoundSwitchBtn
		{
			[Token(Token = "0x6004306")]
			[Address(RVA = "0x41D7490", Offset = "0x41D3490", VA = "0x41D7490")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AD4")]
		public ButtonExtend ButtonExtendBgmSwitchBtn
		{
			[Token(Token = "0x6004307")]
			[Address(RVA = "0x41D7558", Offset = "0x41D3558", VA = "0x41D7558")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AD5")]
		public ButtonExtend ButtonExtendVibratorBtn
		{
			[Token(Token = "0x6004308")]
			[Address(RVA = "0x41D7620", Offset = "0x41D3620", VA = "0x41D7620")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AD6")]
		public ButtonExtend ButtonExtendCdkBtn
		{
			[Token(Token = "0x6004309")]
			[Address(RVA = "0x41D4AF0", Offset = "0x41D0AF0", VA = "0x41D4AF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AD7")]
		public ButtonExtend ButtonExtendAnnouncementBtn
		{
			[Token(Token = "0x600430A")]
			[Address(RVA = "0x41D76E8", Offset = "0x41D36E8", VA = "0x41D76E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AD8")]
		public Button ButtonScanCodeBtn
		{
			[Token(Token = "0x600430B")]
			[Address(RVA = "0x41D77B0", Offset = "0x41D37B0", VA = "0x41D77B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AD9")]
		public ScrollRect ScrollRectTemplate
		{
			[Token(Token = "0x600430C")]
			[Address(RVA = "0x41D7878", Offset = "0x41D3878", VA = "0x41D7878")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000ADA")]
		public Toggle ToggleItem
		{
			[Token(Token = "0x600430D")]
			[Address(RVA = "0x41D7940", Offset = "0x41D3940", VA = "0x41D7940")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000ADB")]
		public Scrollbar ScrollbarScrollbar
		{
			[Token(Token = "0x600430E")]
			[Address(RVA = "0x41D7A08", Offset = "0x41D3A08", VA = "0x41D7A08")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000ADC")]
		public ButtonExtend ButtonExtendPolicyBtn
		{
			[Token(Token = "0x600430F")]
			[Address(RVA = "0x41D4C80", Offset = "0x41D0C80", VA = "0x41D4C80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000ADD")]
		public ButtonExtend ButtonExtendUserProtocolBtn
		{
			[Token(Token = "0x6004310")]
			[Address(RVA = "0x41D4D48", Offset = "0x41D0D48", VA = "0x41D4D48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000ADE")]
		public ButtonExtend ButtonExtendFeedbackBtn
		{
			[Token(Token = "0x6004311")]
			[Address(RVA = "0x41D4E10", Offset = "0x41D0E10", VA = "0x41D4E10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000ADF")]
		public ButtonExtend ButtonExtendKefu
		{
			[Token(Token = "0x6004312")]
			[Address(RVA = "0x41D7AD0", Offset = "0x41D3AD0", VA = "0x41D7AD0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AE0")]
		public ButtonExtend ButtonExtendRestoreBtn
		{
			[Token(Token = "0x6004313")]
			[Address(RVA = "0x41D4960", Offset = "0x41D0960", VA = "0x41D4960")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AE1")]
		public ButtonExtend ButtonExtendConnectAccount
		{
			[Token(Token = "0x6004314")]
			[Address(RVA = "0x41D5AF8", Offset = "0x41D1AF8", VA = "0x41D5AF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AE2")]
		public ButtonExtend ButtonExtendDisconnectAccount
		{
			[Token(Token = "0x6004315")]
			[Address(RVA = "0x41D5A30", Offset = "0x41D1A30", VA = "0x41D5A30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AE3")]
		public ButtonExtend ButtonExtendProxyLoginBtn
		{
			[Token(Token = "0x6004316")]
			[Address(RVA = "0x41D7B98", Offset = "0x41D3B98", VA = "0x41D7B98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AE4")]
		public ButtonExtend ButtonExtendMoreSettingsBtn
		{
			[Token(Token = "0x6004317")]
			[Address(RVA = "0x41D7C60", Offset = "0x41D3C60", VA = "0x41D7C60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AE5")]
		public LanguageDropdownExtend LanguageDropdownExtendLanguage
		{
			[Token(Token = "0x6004318")]
			[Address(RVA = "0x41D4A28", Offset = "0x41D0A28", VA = "0x41D4A28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AE6")]
		public ScrollRect ScrollRectTemplate1
		{
			[Token(Token = "0x6004319")]
			[Address(RVA = "0x41D7D28", Offset = "0x41D3D28", VA = "0x41D7D28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AE7")]
		public Toggle ToggleItem1
		{
			[Token(Token = "0x600431A")]
			[Address(RVA = "0x41D7DF0", Offset = "0x41D3DF0", VA = "0x41D7DF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AE8")]
		public ButtonExtend ButtonExtendCloseBtn
		{
			[Token(Token = "0x600431B")]
			[Address(RVA = "0x41D7EB8", Offset = "0x41D3EB8", VA = "0x41D7EB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AE9")]
		public RectTransform RectTransformCdkPanel
		{
			[Token(Token = "0x600431C")]
			[Address(RVA = "0x41D6294", Offset = "0x41D2294", VA = "0x41D6294")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AEA")]
		public Button ButtonCdkPanelMask
		{
			[Token(Token = "0x600431D")]
			[Address(RVA = "0x41D7F80", Offset = "0x41D3F80", VA = "0x41D7F80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AEB")]
		public TMP_InputField TMP_InputFieldCdkInputField
		{
			[Token(Token = "0x600431E")]
			[Address(RVA = "0x41D61CC", Offset = "0x41D21CC", VA = "0x41D61CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AEC")]
		public ButtonExtend ButtonExtendConfirmBtn
		{
			[Token(Token = "0x600431F")]
			[Address(RVA = "0x41D8048", Offset = "0x41D4048", VA = "0x41D8048")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AED")]
		public ButtonExtend ButtonExtendCloseCdkPanelBtn
		{
			[Token(Token = "0x6004320")]
			[Address(RVA = "0x41D8110", Offset = "0x41D4110", VA = "0x41D8110")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004321")]
		[Address(RVA = "0x41D81D8", Offset = "0x41D41D8", VA = "0x41D81D8")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6004322")]
		[Address(RVA = "0x41D551C", Offset = "0x41D151C", VA = "0x41D551C", Slot = "12")]
		protected virtual void OnButtonBlackClicked()
		{
		}

		[Token(Token = "0x6004323")]
		[Address(RVA = "0x41D8A00", Offset = "0x41D4A00", VA = "0x41D8A00", Slot = "13")]
		protected virtual void OnButtonUsidClicked()
		{
		}

		[Token(Token = "0x6004324")]
		[Address(RVA = "0x41D8A6C", Offset = "0x41D4A6C", VA = "0x41D8A6C", Slot = "14")]
		protected virtual void OnButtonExtendSoundSwitchBtnClicked()
		{
		}

		[Token(Token = "0x6004325")]
		[Address(RVA = "0x41D8AD8", Offset = "0x41D4AD8", VA = "0x41D8AD8", Slot = "15")]
		protected virtual void OnButtonExtendBgmSwitchBtnClicked()
		{
		}

		[Token(Token = "0x6004326")]
		[Address(RVA = "0x41D8B44", Offset = "0x41D4B44", VA = "0x41D8B44", Slot = "16")]
		protected virtual void OnButtonExtendVibratorBtnClicked()
		{
		}

		[Token(Token = "0x6004327")]
		[Address(RVA = "0x41D5BD8", Offset = "0x41D1BD8", VA = "0x41D5BD8", Slot = "17")]
		protected virtual void OnButtonExtendCdkBtnClicked()
		{
		}

		[Token(Token = "0x6004328")]
		[Address(RVA = "0x41D697C", Offset = "0x41D297C", VA = "0x41D697C", Slot = "18")]
		protected virtual void OnButtonExtendAnnouncementBtnClicked()
		{
		}

		[Token(Token = "0x6004329")]
		[Address(RVA = "0x41D8BB0", Offset = "0x41D4BB0", VA = "0x41D8BB0", Slot = "19")]
		protected virtual void OnButtonScanCodeBtnClicked()
		{
		}

		[Token(Token = "0x600432A")]
		[Address(RVA = "0x41D8C1C", Offset = "0x41D4C1C", VA = "0x41D8C1C", Slot = "20")]
		protected virtual void OnScrollRectTemplateValueChanged(Vector2 arg)
		{
		}

		[Token(Token = "0x600432B")]
		[Address(RVA = "0x41D8CD0", Offset = "0x41D4CD0", VA = "0x41D8CD0", Slot = "21")]
		protected virtual void OnToggleItemValueChanged(bool arg)
		{
		}

		[Token(Token = "0x600432C")]
		[Address(RVA = "0x41D8D7C", Offset = "0x41D4D7C", VA = "0x41D8D7C", Slot = "22")]
		protected virtual void OnScrollbarScrollbarValueChanged(float arg)
		{
		}

		[Token(Token = "0x600432D")]
		[Address(RVA = "0x41D8E24", Offset = "0x41D4E24", VA = "0x41D8E24", Slot = "23")]
		protected virtual void OnButtonExtendPolicyBtnClicked()
		{
		}

		[Token(Token = "0x600432E")]
		[Address(RVA = "0x41D8E90", Offset = "0x41D4E90", VA = "0x41D8E90", Slot = "24")]
		protected virtual void OnButtonExtendUserProtocolBtnClicked()
		{
		}

		[Token(Token = "0x600432F")]
		[Address(RVA = "0x41D8EFC", Offset = "0x41D4EFC", VA = "0x41D8EFC", Slot = "25")]
		protected virtual void OnButtonExtendFeedbackBtnClicked()
		{
		}

		[Token(Token = "0x6004330")]
		[Address(RVA = "0x41D8F68", Offset = "0x41D4F68", VA = "0x41D8F68", Slot = "26")]
		protected virtual void OnButtonExtendKefuClicked()
		{
		}

		[Token(Token = "0x6004331")]
		[Address(RVA = "0x41D5490", Offset = "0x41D1490", VA = "0x41D5490", Slot = "27")]
		protected virtual void OnButtonExtendRestoreBtnClicked()
		{
		}

		[Token(Token = "0x6004332")]
		[Address(RVA = "0x41D58A4", Offset = "0x41D18A4", VA = "0x41D58A4", Slot = "28")]
		protected virtual void OnButtonExtendConnectAccountClicked()
		{
		}

		[Token(Token = "0x6004333")]
		[Address(RVA = "0x41D59C4", Offset = "0x41D19C4", VA = "0x41D59C4", Slot = "29")]
		protected virtual void OnButtonExtendDisconnectAccountClicked()
		{
		}

		[Token(Token = "0x6004334")]
		[Address(RVA = "0x41D8FD4", Offset = "0x41D4FD4", VA = "0x41D8FD4", Slot = "30")]
		protected virtual void OnButtonExtendProxyLoginBtnClicked()
		{
		}

		[Token(Token = "0x6004335")]
		[Address(RVA = "0x41D9040", Offset = "0x41D5040", VA = "0x41D9040", Slot = "31")]
		protected virtual void OnButtonExtendMoreSettingsBtnClicked()
		{
		}

		[Token(Token = "0x6004336")]
		[Address(RVA = "0x41D90AC", Offset = "0x41D50AC", VA = "0x41D90AC", Slot = "32")]
		protected virtual void OnScrollRectTemplate1ValueChanged(Vector2 arg)
		{
		}

		[Token(Token = "0x6004337")]
		[Address(RVA = "0x41D9160", Offset = "0x41D5160", VA = "0x41D9160", Slot = "33")]
		protected virtual void OnToggleItem1ValueChanged(bool arg)
		{
		}

		[Token(Token = "0x6004338")]
		[Address(RVA = "0x41D538C", Offset = "0x41D138C", VA = "0x41D538C", Slot = "34")]
		protected virtual void OnButtonExtendCloseBtnClicked()
		{
		}

		[Token(Token = "0x6004339")]
		[Address(RVA = "0x41D5F0C", Offset = "0x41D1F0C", VA = "0x41D5F0C", Slot = "35")]
		protected virtual void OnButtonCdkPanelMaskClicked()
		{
		}

		[Token(Token = "0x600433A")]
		[Address(RVA = "0x41D920C", Offset = "0x41D520C", VA = "0x41D920C", Slot = "36")]
		protected virtual void OnInputFieldCdkInputFieldValueChanged(string arg)
		{
		}

		[Token(Token = "0x600433B")]
		[Address(RVA = "0x41D6160", Offset = "0x41D2160", VA = "0x41D6160", Slot = "37")]
		protected virtual void OnButtonExtendConfirmBtnClicked()
		{
		}

		[Token(Token = "0x600433C")]
		[Address(RVA = "0x41D5D40", Offset = "0x41D1D40", VA = "0x41D5D40", Slot = "38")]
		protected virtual void OnButtonExtendCloseCdkPanelBtnClicked()
		{
		}

		[Token(Token = "0x600433D")]
		[Address(RVA = "0x41D4944", Offset = "0x41D0944", VA = "0x41D4944", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600433E")]
		[Address(RVA = "0x41D69FC", Offset = "0x41D29FC", VA = "0x41D69FC", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__863))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x600433F")]
		[Address(RVA = "0x41D5670", Offset = "0x41D1670", VA = "0x41D5670", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6004340")]
		[Address(RVA = "0x41D69F0", Offset = "0x41D29F0", VA = "0x41D69F0")]
		public SettingsPanelComponents()
		{
		}
	}
}
