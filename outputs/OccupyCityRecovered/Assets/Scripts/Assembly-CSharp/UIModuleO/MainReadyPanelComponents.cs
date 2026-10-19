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
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000968")]
	public class MainReadyPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000969")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__2171 : IAsyncStateMachine
		{
			[Token(Token = "0x40046B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40046B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40046B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MainReadyPanelComponents _003C_003E4__this;

			[Token(Token = "0x40046BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x600376E")]
			[Address(RVA = "0x40E2B8C", Offset = "0x40DEB8C", VA = "0x40E2B8C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600376F")]
			[Address(RVA = "0x40E2E04", Offset = "0x40DEE04", VA = "0x40E2E04", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400466B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RectTransform _rectTransformMainReadyPanel;

		[Token(Token = "0x400466C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Image _imageCurrentBG;

		[Token(Token = "0x400466D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Image _imageNextBG;

		[Token(Token = "0x400466E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ButtonExtend _buttonExtendSettingsBtn;

		[Token(Token = "0x400466F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ButtonExtend _buttonExtendAllIAPsBtn;

		[Token(Token = "0x4004670")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private ButtonExtend _buttonExtendOpenUpgradeRewardsPreview;

		[Token(Token = "0x4004671")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RectTransform _rectTransformImgExpProgress;

		[Token(Token = "0x4004672")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private TextMeshProUGUI _textMeshProUGUITxtExpProgress;

		[Token(Token = "0x4004673")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private RectTransform _rectTransformImgRewardBubble;

		[Token(Token = "0x4004674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Image _imageImgRewardTipIcon;

		[Token(Token = "0x4004675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private TextMeshProUGUI _textMeshProUGUITxtRewardTipNum;

		[Token(Token = "0x4004676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private TextMeshProUGUI _textMeshProUGUITxtLevel;

		[Token(Token = "0x4004677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private RectTransform _rectTransformImgEndReward;

		[Token(Token = "0x4004678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Image _imageImgEndReward;

		[Token(Token = "0x4004679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private RectTransform _rectTransformTxtNew;

		[Token(Token = "0x400467A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private TextMeshProUGUI _textMeshProUGUITxtNew;

		[Token(Token = "0x400467B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private RectTransform _rectTransformImgProgressBubble;

		[Token(Token = "0x400467C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private TextMeshProUGUI _textMeshProUGUITxtProgress;

		[Token(Token = "0x400467D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Image _imageImgLevelRewardIcon;

		[Token(Token = "0x400467E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private RectTransform _rectTransformArenaScrollView;

		[Token(Token = "0x400467F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private ScrollRect _scrollRectArenaScrollView;

		[Token(Token = "0x4004680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private RectTransform _rectTransformArenaContent;

		[Token(Token = "0x4004681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private RectTransform _rectTransformImgMoraleBubble;

		[Token(Token = "0x4004682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private RectTransform _rectTransformTxtMoraleDes;

		[Token(Token = "0x4004683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private TextMeshProUGUI _textMeshProUGUITxtMoraleDes;

		[Token(Token = "0x4004684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private RectTransform _rectTransformMainReadyPanel_BtnRoot_Left;

		[Token(Token = "0x4004685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private MainReadyPanel_IAPBtnRoot_Right _mainReadyPanel_IAPBtnRoot_RightMainReadyPanel_IAPBtnRoot_Right;

		[Token(Token = "0x4004686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private ButtonExtend _buttonExtendSeasonPassEntranceBtn;

		[Token(Token = "0x4004687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private ScrollRect _scrollRectScrollView;

		[Token(Token = "0x4004688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private ButtonExtend _buttonExtendBtnNewPack;

		[Token(Token = "0x4004689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private ButtonExtend _buttonExtendBtnFund;

		[Token(Token = "0x400468A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private ButtonExtend _buttonExtendBtnMonthPass;

		[Token(Token = "0x400468B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private ButtonExtend _buttonExtendBtnCheckInReward;

		[Token(Token = "0x400468C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private ButtonExtend _buttonExtendBtnDailyBless;

		[Token(Token = "0x400468D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private RectTransform _rectTransformMainReadyPlayerBanner;

		[Token(Token = "0x400468E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private AutoSafeAreaAligner _autoSafeAreaAlignerMainReadyPlayerBanner;

		[Token(Token = "0x400468F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Image _imageImgProgressIcon;

		[Token(Token = "0x4004690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private TextMeshProUGUI _textMeshProUGUITxtProgressDes;

		[Token(Token = "0x4004691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private TextMeshProUGUI _textMeshProUGUITxtTrophyProgress;

		[Token(Token = "0x4004692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private Image _imagePlayerBanner;

		[Token(Token = "0x4004693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private RectTransform _rectTransformImgBlessBg;

		[Token(Token = "0x4004694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private ButtonExtend _buttonExtendImgBlessBg;

		[Token(Token = "0x4004695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private Image _imageImgBlessIcon;

		[Token(Token = "0x4004696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private RectTransform _rectTransformImgBlessDesBg;

		[Token(Token = "0x4004697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private TextMeshProUGUI _textMeshProUGUITxtBlessDes;

		[Token(Token = "0x4004698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private Image _imageImgPlayerIcon;

		[Token(Token = "0x4004699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private TextMeshProUGUI _textMeshProUGUITxtPlayerPower;

		[Token(Token = "0x400469A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private TextMeshProUGUI _textMeshProUGUITxtPlayerName;

		[Token(Token = "0x400469B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private ButtonExtend _buttonExtendBtnClick;

		[Token(Token = "0x400469C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private MainReadyPanel_ActivityBtnRoot _mainReadyPanel_ActivityBtnRootMainReadyPanel_ActivityBtnRoot;

		[Token(Token = "0x400469D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private RectTransform _rectTransformSubGameChaosTrailEntrance;

		[Token(Token = "0x400469E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private ButtonExtend _buttonExtendSubGameChaosTrailEntrance;

		[Token(Token = "0x400469F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private Animation _animationDonghua;

		[Token(Token = "0x40046A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private RectTransform _rectTransformMainReadyPanel_BoxBtnRoot;

		[Token(Token = "0x40046A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private MainReadyPanel_BoxBtnRoot _mainReadyPanel_BoxBtnRootMainReadyPanel_BoxBtnRoot;

		[Token(Token = "0x40046A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private RectTransform _rectTransformChestSlotsView;

		[Token(Token = "0x40046A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private ChestSlotsView _chestSlotsViewChestSlotsView;

		[Token(Token = "0x40046A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private ButtonExtend _buttonExtendBtnClose;

		[Token(Token = "0x40046A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private ButtonExtend _buttonExtendImgBoxBg1;

		[Token(Token = "0x40046A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private ButtonExtend _buttonExtendImgBoxBg2;

		[Token(Token = "0x40046A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private ButtonExtend _buttonExtendImgBoxBg3;

		[Token(Token = "0x40046A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private ButtonExtend _buttonExtendBtnBuyBoxSlot3;

		[Token(Token = "0x40046A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private ButtonExtend _buttonExtendImgBoxBg4;

		[Token(Token = "0x40046AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		private ButtonExtend _buttonExtendBtnBuyBoxSlot4;

		[Token(Token = "0x40046AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private Button _buttonBlack;

		[Token(Token = "0x40046AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		private ButtonExtend _buttonExtendCloseBtn;

		[Token(Token = "0x40046AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		private ButtonExtend _buttonExtendButton_get;

		[Token(Token = "0x40046AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		private ButtonExtend _buttonExtendButton_get1;

		[Token(Token = "0x40046AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private Toggle _toggleSidetoggle;

		[Token(Token = "0x40046B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		private Toggle _toggleDeskToggle;

		[Token(Token = "0x40046B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		private Button _buttonBlack1;

		[Token(Token = "0x40046B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		private ButtonExtend _buttonExtendCloseBtn1;

		[Token(Token = "0x40046B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		private ButtonExtend _buttonExtendButton_get2;

		[Token(Token = "0x40046B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		private Button _buttonBlack2;

		[Token(Token = "0x40046B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		private ButtonExtend _buttonExtendCloseBtn2;

		[Token(Token = "0x40046B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		private ButtonExtend _buttonExtendButton_GoClub;

		[Token(Token = "0x170007F7")]
		public RectTransform RectTransformMainReadyPanel
		{
			[Token(Token = "0x60036FB")]
			[Address(RVA = "0x40D9DB8", Offset = "0x40D5DB8", VA = "0x40D9DB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007F8")]
		public Image ImageCurrentBG
		{
			[Token(Token = "0x60036FC")]
			[Address(RVA = "0x40DEB6C", Offset = "0x40DAB6C", VA = "0x40DEB6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007F9")]
		public Image ImageNextBG
		{
			[Token(Token = "0x60036FD")]
			[Address(RVA = "0x40DEC34", Offset = "0x40DAC34", VA = "0x40DEC34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007FA")]
		public ButtonExtend ButtonExtendSettingsBtn
		{
			[Token(Token = "0x60036FE")]
			[Address(RVA = "0x40DECFC", Offset = "0x40DACFC", VA = "0x40DECFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007FB")]
		public ButtonExtend ButtonExtendAllIAPsBtn
		{
			[Token(Token = "0x60036FF")]
			[Address(RVA = "0x40DEDC4", Offset = "0x40DADC4", VA = "0x40DEDC4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007FC")]
		public ButtonExtend ButtonExtendOpenUpgradeRewardsPreview
		{
			[Token(Token = "0x6003700")]
			[Address(RVA = "0x40DEE8C", Offset = "0x40DAE8C", VA = "0x40DEE8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007FD")]
		public RectTransform RectTransformImgExpProgress
		{
			[Token(Token = "0x6003701")]
			[Address(RVA = "0x40DC178", Offset = "0x40D8178", VA = "0x40DC178")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007FE")]
		public TextMeshProUGUI TextMeshProUGUITxtExpProgress
		{
			[Token(Token = "0x6003702")]
			[Address(RVA = "0x40DC240", Offset = "0x40D8240", VA = "0x40DC240")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007FF")]
		public RectTransform RectTransformImgRewardBubble
		{
			[Token(Token = "0x6003703")]
			[Address(RVA = "0x40DC0B0", Offset = "0x40D80B0", VA = "0x40DC0B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000800")]
		public Image ImageImgRewardTipIcon
		{
			[Token(Token = "0x6003704")]
			[Address(RVA = "0x40DE4C0", Offset = "0x40DA4C0", VA = "0x40DE4C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000801")]
		public TextMeshProUGUI TextMeshProUGUITxtRewardTipNum
		{
			[Token(Token = "0x6003705")]
			[Address(RVA = "0x40DE3F8", Offset = "0x40DA3F8", VA = "0x40DE3F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000802")]
		public TextMeshProUGUI TextMeshProUGUITxtLevel
		{
			[Token(Token = "0x6003706")]
			[Address(RVA = "0x40DBF20", Offset = "0x40D7F20", VA = "0x40DBF20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000803")]
		public RectTransform RectTransformImgEndReward
		{
			[Token(Token = "0x6003707")]
			[Address(RVA = "0x40DE330", Offset = "0x40DA330", VA = "0x40DE330")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000804")]
		public Image ImageImgEndReward
		{
			[Token(Token = "0x6003708")]
			[Address(RVA = "0x40DEF54", Offset = "0x40DAF54", VA = "0x40DEF54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000805")]
		public RectTransform RectTransformTxtNew
		{
			[Token(Token = "0x6003709")]
			[Address(RVA = "0x40DF01C", Offset = "0x40DB01C", VA = "0x40DF01C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000806")]
		public TextMeshProUGUI TextMeshProUGUITxtNew
		{
			[Token(Token = "0x600370A")]
			[Address(RVA = "0x40DBE58", Offset = "0x40D7E58", VA = "0x40DBE58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000807")]
		public RectTransform RectTransformImgProgressBubble
		{
			[Token(Token = "0x600370B")]
			[Address(RVA = "0x40DBFE8", Offset = "0x40D7FE8", VA = "0x40DBFE8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000808")]
		public TextMeshProUGUI TextMeshProUGUITxtProgress
		{
			[Token(Token = "0x600370C")]
			[Address(RVA = "0x40DF0E4", Offset = "0x40DB0E4", VA = "0x40DF0E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000809")]
		public Image ImageImgLevelRewardIcon
		{
			[Token(Token = "0x600370D")]
			[Address(RVA = "0x40DD6C8", Offset = "0x40D96C8", VA = "0x40DD6C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700080A")]
		public RectTransform RectTransformArenaScrollView
		{
			[Token(Token = "0x600370E")]
			[Address(RVA = "0x40DF1AC", Offset = "0x40DB1AC", VA = "0x40DF1AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700080B")]
		public ScrollRect ScrollRectArenaScrollView
		{
			[Token(Token = "0x600370F")]
			[Address(RVA = "0x40DF274", Offset = "0x40DB274", VA = "0x40DF274")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700080C")]
		public RectTransform RectTransformArenaContent
		{
			[Token(Token = "0x6003710")]
			[Address(RVA = "0x40DF33C", Offset = "0x40DB33C", VA = "0x40DF33C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700080D")]
		public RectTransform RectTransformImgMoraleBubble
		{
			[Token(Token = "0x6003711")]
			[Address(RVA = "0x40D8044", Offset = "0x40D4044", VA = "0x40D8044")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700080E")]
		public RectTransform RectTransformTxtMoraleDes
		{
			[Token(Token = "0x6003712")]
			[Address(RVA = "0x40D81D4", Offset = "0x40D41D4", VA = "0x40D81D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700080F")]
		public TextMeshProUGUI TextMeshProUGUITxtMoraleDes
		{
			[Token(Token = "0x6003713")]
			[Address(RVA = "0x40D810C", Offset = "0x40D410C", VA = "0x40D810C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000810")]
		public RectTransform RectTransformMainReadyPanel_BtnRoot_Left
		{
			[Token(Token = "0x6003714")]
			[Address(RVA = "0x40DB5C0", Offset = "0x40D75C0", VA = "0x40DB5C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000811")]
		public MainReadyPanel_IAPBtnRoot_Right MainReadyPanel_IAPBtnRoot_RightMainReadyPanel_IAPBtnRoot_Right
		{
			[Token(Token = "0x6003715")]
			[Address(RVA = "0x40DB688", Offset = "0x40D7688", VA = "0x40DB688")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000812")]
		public ButtonExtend ButtonExtendSeasonPassEntranceBtn
		{
			[Token(Token = "0x6003716")]
			[Address(RVA = "0x40DF404", Offset = "0x40DB404", VA = "0x40DF404")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000813")]
		public ScrollRect ScrollRectScrollView
		{
			[Token(Token = "0x6003717")]
			[Address(RVA = "0x40DF4CC", Offset = "0x40DB4CC", VA = "0x40DF4CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000814")]
		public ButtonExtend ButtonExtendBtnNewPack
		{
			[Token(Token = "0x6003718")]
			[Address(RVA = "0x40DF594", Offset = "0x40DB594", VA = "0x40DF594")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000815")]
		public ButtonExtend ButtonExtendBtnFund
		{
			[Token(Token = "0x6003719")]
			[Address(RVA = "0x40DF65C", Offset = "0x40DB65C", VA = "0x40DF65C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000816")]
		public ButtonExtend ButtonExtendBtnMonthPass
		{
			[Token(Token = "0x600371A")]
			[Address(RVA = "0x40DF724", Offset = "0x40DB724", VA = "0x40DF724")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000817")]
		public ButtonExtend ButtonExtendBtnCheckInReward
		{
			[Token(Token = "0x600371B")]
			[Address(RVA = "0x40DF7EC", Offset = "0x40DB7EC", VA = "0x40DF7EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000818")]
		public ButtonExtend ButtonExtendBtnDailyBless
		{
			[Token(Token = "0x600371C")]
			[Address(RVA = "0x40DF8B4", Offset = "0x40DB8B4", VA = "0x40DF8B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000819")]
		public RectTransform RectTransformMainReadyPlayerBanner
		{
			[Token(Token = "0x600371D")]
			[Address(RVA = "0x40DF97C", Offset = "0x40DB97C", VA = "0x40DF97C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700081A")]
		public AutoSafeAreaAligner AutoSafeAreaAlignerMainReadyPlayerBanner
		{
			[Token(Token = "0x600371E")]
			[Address(RVA = "0x40DFA44", Offset = "0x40DBA44", VA = "0x40DFA44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700081B")]
		public Image ImageImgProgressIcon
		{
			[Token(Token = "0x600371F")]
			[Address(RVA = "0x40DBC00", Offset = "0x40D7C00", VA = "0x40DBC00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700081C")]
		public TextMeshProUGUI TextMeshProUGUITxtProgressDes
		{
			[Token(Token = "0x6003720")]
			[Address(RVA = "0x40DBCC8", Offset = "0x40D7CC8", VA = "0x40DBCC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700081D")]
		public TextMeshProUGUI TextMeshProUGUITxtTrophyProgress
		{
			[Token(Token = "0x6003721")]
			[Address(RVA = "0x40DBD90", Offset = "0x40D7D90", VA = "0x40DBD90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700081E")]
		public Image ImagePlayerBanner
		{
			[Token(Token = "0x6003722")]
			[Address(RVA = "0x40DFB0C", Offset = "0x40DBB0C", VA = "0x40DFB0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700081F")]
		public RectTransform RectTransformImgBlessBg
		{
			[Token(Token = "0x6003723")]
			[Address(RVA = "0x40DC868", Offset = "0x40D8868", VA = "0x40DC868")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000820")]
		public ButtonExtend ButtonExtendImgBlessBg
		{
			[Token(Token = "0x6003724")]
			[Address(RVA = "0x40DFBD4", Offset = "0x40DBBD4", VA = "0x40DFBD4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000821")]
		public Image ImageImgBlessIcon
		{
			[Token(Token = "0x6003725")]
			[Address(RVA = "0x40DC930", Offset = "0x40D8930", VA = "0x40DC930")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000822")]
		public RectTransform RectTransformImgBlessDesBg
		{
			[Token(Token = "0x6003726")]
			[Address(RVA = "0x40DFC9C", Offset = "0x40DBC9C", VA = "0x40DFC9C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000823")]
		public TextMeshProUGUI TextMeshProUGUITxtBlessDes
		{
			[Token(Token = "0x6003727")]
			[Address(RVA = "0x40DFD64", Offset = "0x40DBD64", VA = "0x40DFD64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000824")]
		public Image ImageImgPlayerIcon
		{
			[Token(Token = "0x6003728")]
			[Address(RVA = "0x40DFE2C", Offset = "0x40DBE2C", VA = "0x40DFE2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000825")]
		public TextMeshProUGUI TextMeshProUGUITxtPlayerPower
		{
			[Token(Token = "0x6003729")]
			[Address(RVA = "0x40DFEF4", Offset = "0x40DBEF4", VA = "0x40DFEF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000826")]
		public TextMeshProUGUI TextMeshProUGUITxtPlayerName
		{
			[Token(Token = "0x600372A")]
			[Address(RVA = "0x40DBB38", Offset = "0x40D7B38", VA = "0x40DBB38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000827")]
		public ButtonExtend ButtonExtendBtnClick
		{
			[Token(Token = "0x600372B")]
			[Address(RVA = "0x40DFFBC", Offset = "0x40DBFBC", VA = "0x40DFFBC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000828")]
		public MainReadyPanel_ActivityBtnRoot MainReadyPanel_ActivityBtnRootMainReadyPanel_ActivityBtnRoot
		{
			[Token(Token = "0x600372C")]
			[Address(RVA = "0x40DB750", Offset = "0x40D7750", VA = "0x40DB750")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000829")]
		public RectTransform RectTransformSubGameChaosTrailEntrance
		{
			[Token(Token = "0x600372D")]
			[Address(RVA = "0x40E0084", Offset = "0x40DC084", VA = "0x40E0084")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700082A")]
		public ButtonExtend ButtonExtendSubGameChaosTrailEntrance
		{
			[Token(Token = "0x600372E")]
			[Address(RVA = "0x40E014C", Offset = "0x40DC14C", VA = "0x40E014C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700082B")]
		public Animation AnimationDonghua
		{
			[Token(Token = "0x600372F")]
			[Address(RVA = "0x40E0214", Offset = "0x40DC214", VA = "0x40E0214")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700082C")]
		public RectTransform RectTransformMainReadyPanel_BoxBtnRoot
		{
			[Token(Token = "0x6003730")]
			[Address(RVA = "0x40DB818", Offset = "0x40D7818", VA = "0x40DB818")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700082D")]
		public MainReadyPanel_BoxBtnRoot MainReadyPanel_BoxBtnRootMainReadyPanel_BoxBtnRoot
		{
			[Token(Token = "0x6003731")]
			[Address(RVA = "0x40DBA70", Offset = "0x40D7A70", VA = "0x40DBA70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700082E")]
		public RectTransform RectTransformChestSlotsView
		{
			[Token(Token = "0x6003732")]
			[Address(RVA = "0x40DB9A8", Offset = "0x40D79A8", VA = "0x40DB9A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700082F")]
		public ChestSlotsView ChestSlotsViewChestSlotsView
		{
			[Token(Token = "0x6003733")]
			[Address(RVA = "0x40DB8E0", Offset = "0x40D78E0", VA = "0x40DB8E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000830")]
		public ButtonExtend ButtonExtendBtnClose
		{
			[Token(Token = "0x6003734")]
			[Address(RVA = "0x40E02DC", Offset = "0x40DC2DC", VA = "0x40E02DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000831")]
		public ButtonExtend ButtonExtendImgBoxBg1
		{
			[Token(Token = "0x6003735")]
			[Address(RVA = "0x40E03A4", Offset = "0x40DC3A4", VA = "0x40E03A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000832")]
		public ButtonExtend ButtonExtendImgBoxBg2
		{
			[Token(Token = "0x6003736")]
			[Address(RVA = "0x40E046C", Offset = "0x40DC46C", VA = "0x40E046C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000833")]
		public ButtonExtend ButtonExtendImgBoxBg3
		{
			[Token(Token = "0x6003737")]
			[Address(RVA = "0x40E0534", Offset = "0x40DC534", VA = "0x40E0534")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000834")]
		public ButtonExtend ButtonExtendBtnBuyBoxSlot3
		{
			[Token(Token = "0x6003738")]
			[Address(RVA = "0x40E05FC", Offset = "0x40DC5FC", VA = "0x40E05FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000835")]
		public ButtonExtend ButtonExtendImgBoxBg4
		{
			[Token(Token = "0x6003739")]
			[Address(RVA = "0x40E06C4", Offset = "0x40DC6C4", VA = "0x40E06C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000836")]
		public ButtonExtend ButtonExtendBtnBuyBoxSlot4
		{
			[Token(Token = "0x600373A")]
			[Address(RVA = "0x40E078C", Offset = "0x40DC78C", VA = "0x40E078C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000837")]
		public Button ButtonBlack
		{
			[Token(Token = "0x600373B")]
			[Address(RVA = "0x40E0854", Offset = "0x40DC854", VA = "0x40E0854")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000838")]
		public ButtonExtend ButtonExtendCloseBtn
		{
			[Token(Token = "0x600373C")]
			[Address(RVA = "0x40E091C", Offset = "0x40DC91C", VA = "0x40E091C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000839")]
		public ButtonExtend ButtonExtendButton_get
		{
			[Token(Token = "0x600373D")]
			[Address(RVA = "0x40E09E4", Offset = "0x40DC9E4", VA = "0x40E09E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700083A")]
		public ButtonExtend ButtonExtendButton_get1
		{
			[Token(Token = "0x600373E")]
			[Address(RVA = "0x40E0AAC", Offset = "0x40DCAAC", VA = "0x40E0AAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700083B")]
		public Toggle ToggleSidetoggle
		{
			[Token(Token = "0x600373F")]
			[Address(RVA = "0x40E0B74", Offset = "0x40DCB74", VA = "0x40E0B74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700083C")]
		public Toggle ToggleDeskToggle
		{
			[Token(Token = "0x6003740")]
			[Address(RVA = "0x40E0C3C", Offset = "0x40DCC3C", VA = "0x40E0C3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700083D")]
		public Button ButtonBlack1
		{
			[Token(Token = "0x6003741")]
			[Address(RVA = "0x40E0D04", Offset = "0x40DCD04", VA = "0x40E0D04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700083E")]
		public ButtonExtend ButtonExtendCloseBtn1
		{
			[Token(Token = "0x6003742")]
			[Address(RVA = "0x40E0DCC", Offset = "0x40DCDCC", VA = "0x40E0DCC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700083F")]
		public ButtonExtend ButtonExtendButton_get2
		{
			[Token(Token = "0x6003743")]
			[Address(RVA = "0x40E0E94", Offset = "0x40DCE94", VA = "0x40E0E94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000840")]
		public Button ButtonBlack2
		{
			[Token(Token = "0x6003744")]
			[Address(RVA = "0x40E0F5C", Offset = "0x40DCF5C", VA = "0x40E0F5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000841")]
		public ButtonExtend ButtonExtendCloseBtn2
		{
			[Token(Token = "0x6003745")]
			[Address(RVA = "0x40E1024", Offset = "0x40DD024", VA = "0x40E1024")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000842")]
		public ButtonExtend ButtonExtendButton_GoClub
		{
			[Token(Token = "0x6003746")]
			[Address(RVA = "0x40E10EC", Offset = "0x40DD0EC", VA = "0x40E10EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003747")]
		[Address(RVA = "0x40E11B4", Offset = "0x40DD1B4", VA = "0x40E11B4")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6003748")]
		[Address(RVA = "0x40E1B1C", Offset = "0x40DDB1C", VA = "0x40E1B1C", Slot = "12")]
		protected virtual void OnButtonExtendSettingsBtnClicked()
		{
		}

		[Token(Token = "0x6003749")]
		[Address(RVA = "0x40E1B88", Offset = "0x40DDB88", VA = "0x40E1B88", Slot = "13")]
		protected virtual void OnButtonExtendAllIAPsBtnClicked()
		{
		}

		[Token(Token = "0x600374A")]
		[Address(RVA = "0x40E1BF4", Offset = "0x40DDBF4", VA = "0x40E1BF4", Slot = "14")]
		protected virtual void OnButtonExtendOpenUpgradeRewardsPreviewClicked()
		{
		}

		[Token(Token = "0x600374B")]
		[Address(RVA = "0x40E1C60", Offset = "0x40DDC60", VA = "0x40E1C60", Slot = "15")]
		protected virtual void OnScrollRectArenaScrollViewValueChanged(Vector2 arg)
		{
		}

		[Token(Token = "0x600374C")]
		[Address(RVA = "0x40E1D14", Offset = "0x40DDD14", VA = "0x40E1D14", Slot = "16")]
		protected virtual void OnButtonExtendSeasonPassEntranceBtnClicked()
		{
		}

		[Token(Token = "0x600374D")]
		[Address(RVA = "0x40E1D80", Offset = "0x40DDD80", VA = "0x40E1D80", Slot = "17")]
		protected virtual void OnScrollRectScrollViewValueChanged(Vector2 arg)
		{
		}

		[Token(Token = "0x600374E")]
		[Address(RVA = "0x40E1E34", Offset = "0x40DDE34", VA = "0x40E1E34", Slot = "18")]
		protected virtual void OnButtonExtendBtnNewPackClicked()
		{
		}

		[Token(Token = "0x600374F")]
		[Address(RVA = "0x40E1EA0", Offset = "0x40DDEA0", VA = "0x40E1EA0", Slot = "19")]
		protected virtual void OnButtonExtendBtnFundClicked()
		{
		}

		[Token(Token = "0x6003750")]
		[Address(RVA = "0x40E1F0C", Offset = "0x40DDF0C", VA = "0x40E1F0C", Slot = "20")]
		protected virtual void OnButtonExtendBtnMonthPassClicked()
		{
		}

		[Token(Token = "0x6003751")]
		[Address(RVA = "0x40E1F78", Offset = "0x40DDF78", VA = "0x40E1F78", Slot = "21")]
		protected virtual void OnButtonExtendBtnCheckInRewardClicked()
		{
		}

		[Token(Token = "0x6003752")]
		[Address(RVA = "0x40E1FE4", Offset = "0x40DDFE4", VA = "0x40E1FE4", Slot = "22")]
		protected virtual void OnButtonExtendBtnDailyBlessClicked()
		{
		}

		[Token(Token = "0x6003753")]
		[Address(RVA = "0x40E2050", Offset = "0x40DE050", VA = "0x40E2050", Slot = "23")]
		protected virtual void OnButtonExtendImgBlessBgClicked()
		{
		}

		[Token(Token = "0x6003754")]
		[Address(RVA = "0x40E20BC", Offset = "0x40DE0BC", VA = "0x40E20BC", Slot = "24")]
		protected virtual void OnButtonExtendBtnClickClicked()
		{
		}

		[Token(Token = "0x6003755")]
		[Address(RVA = "0x40E2128", Offset = "0x40DE128", VA = "0x40E2128", Slot = "25")]
		protected virtual void OnButtonExtendSubGameChaosTrailEntranceClicked()
		{
		}

		[Token(Token = "0x6003756")]
		[Address(RVA = "0x40E2194", Offset = "0x40DE194", VA = "0x40E2194", Slot = "26")]
		protected virtual void OnButtonExtendBtnCloseClicked()
		{
		}

		[Token(Token = "0x6003757")]
		[Address(RVA = "0x40E2200", Offset = "0x40DE200", VA = "0x40E2200", Slot = "27")]
		protected virtual void OnButtonExtendImgBoxBg1Clicked()
		{
		}

		[Token(Token = "0x6003758")]
		[Address(RVA = "0x40E226C", Offset = "0x40DE26C", VA = "0x40E226C", Slot = "28")]
		protected virtual void OnButtonExtendImgBoxBg2Clicked()
		{
		}

		[Token(Token = "0x6003759")]
		[Address(RVA = "0x40E22D8", Offset = "0x40DE2D8", VA = "0x40E22D8", Slot = "29")]
		protected virtual void OnButtonExtendImgBoxBg3Clicked()
		{
		}

		[Token(Token = "0x600375A")]
		[Address(RVA = "0x40E2344", Offset = "0x40DE344", VA = "0x40E2344", Slot = "30")]
		protected virtual void OnButtonExtendBtnBuyBoxSlot3Clicked()
		{
		}

		[Token(Token = "0x600375B")]
		[Address(RVA = "0x40E23B0", Offset = "0x40DE3B0", VA = "0x40E23B0", Slot = "31")]
		protected virtual void OnButtonExtendImgBoxBg4Clicked()
		{
		}

		[Token(Token = "0x600375C")]
		[Address(RVA = "0x40E241C", Offset = "0x40DE41C", VA = "0x40E241C", Slot = "32")]
		protected virtual void OnButtonExtendBtnBuyBoxSlot4Clicked()
		{
		}

		[Token(Token = "0x600375D")]
		[Address(RVA = "0x40E2488", Offset = "0x40DE488", VA = "0x40E2488", Slot = "33")]
		protected virtual void OnButtonBlackClicked()
		{
		}

		[Token(Token = "0x600375E")]
		[Address(RVA = "0x40E24F4", Offset = "0x40DE4F4", VA = "0x40E24F4", Slot = "34")]
		protected virtual void OnButtonExtendCloseBtnClicked()
		{
		}

		[Token(Token = "0x600375F")]
		[Address(RVA = "0x40E2560", Offset = "0x40DE560", VA = "0x40E2560", Slot = "35")]
		protected virtual void OnGetClicked()
		{
		}

		[Token(Token = "0x6003760")]
		[Address(RVA = "0x40E25CC", Offset = "0x40DE5CC", VA = "0x40E25CC", Slot = "36")]
		protected virtual void OnGet1Clicked()
		{
		}

		[Token(Token = "0x6003761")]
		[Address(RVA = "0x40E2638", Offset = "0x40DE638", VA = "0x40E2638", Slot = "37")]
		protected virtual void OnToggleSidetoggleValueChanged(bool arg)
		{
		}

		[Token(Token = "0x6003762")]
		[Address(RVA = "0x40E26E4", Offset = "0x40DE6E4", VA = "0x40E26E4", Slot = "38")]
		protected virtual void OnToggleDeskToggleValueChanged(bool arg)
		{
		}

		[Token(Token = "0x6003763")]
		[Address(RVA = "0x40E2790", Offset = "0x40DE790", VA = "0x40E2790", Slot = "39")]
		protected virtual void OnButtonBlack1Clicked()
		{
		}

		[Token(Token = "0x6003764")]
		[Address(RVA = "0x40E27FC", Offset = "0x40DE7FC", VA = "0x40E27FC", Slot = "40")]
		protected virtual void OnButtonExtendCloseBtn1Clicked()
		{
		}

		[Token(Token = "0x6003765")]
		[Address(RVA = "0x40E2868", Offset = "0x40DE868", VA = "0x40E2868", Slot = "41")]
		protected virtual void OnGet2Clicked()
		{
		}

		[Token(Token = "0x6003766")]
		[Address(RVA = "0x40E28D4", Offset = "0x40DE8D4", VA = "0x40E28D4", Slot = "42")]
		protected virtual void OnButtonBlack2Clicked()
		{
		}

		[Token(Token = "0x6003767")]
		[Address(RVA = "0x40E2940", Offset = "0x40DE940", VA = "0x40E2940", Slot = "43")]
		protected virtual void OnButtonExtendCloseBtn2Clicked()
		{
		}

		[Token(Token = "0x6003768")]
		[Address(RVA = "0x40E29AC", Offset = "0x40DE9AC", VA = "0x40E29AC", Slot = "44")]
		protected virtual void OnGoClubClicked()
		{
		}

		[Token(Token = "0x6003769")]
		[Address(RVA = "0x40E2A18", Offset = "0x40DEA18", VA = "0x40E2A18", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600376A")]
		[Address(RVA = "0x40E2A34", Offset = "0x40DEA34", VA = "0x40E2A34", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__2171))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x600376B")]
		[Address(RVA = "0x40E2AC8", Offset = "0x40DEAC8", VA = "0x40E2AC8", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x600376C")]
		[Address(RVA = "0x40E2B7C", Offset = "0x40DEB7C", VA = "0x40E2B7C")]
		public MainReadyPanelComponents()
		{
		}
	}
}
