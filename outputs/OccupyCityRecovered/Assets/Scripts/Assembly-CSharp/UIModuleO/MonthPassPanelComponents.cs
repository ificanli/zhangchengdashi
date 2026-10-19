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
	[Token(Token = "0x2000B52")]
	public class MonthPassPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B53")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__508 : IAsyncStateMachine
		{
			[Token(Token = "0x4005282")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005283")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005284")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MonthPassPanelComponents _003C_003E4__this;

			[Token(Token = "0x4005285")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x600453D")]
			[Address(RVA = "0x41FD11C", Offset = "0x41F911C", VA = "0x41FD11C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600453E")]
			[Address(RVA = "0x41FD394", Offset = "0x41F9394", VA = "0x41FD394", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4005262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ButtonExtend _buttonExtendBG;

		[Token(Token = "0x4005263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RectTransform _rectTransformImgBg;

		[Token(Token = "0x4005264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Image _imageGold;

		[Token(Token = "0x4005265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Image _imageImgCrown;

		[Token(Token = "0x4005266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TextMeshProUGUI _textMeshProUGUITxtGiftPackName;

		[Token(Token = "0x4005267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private BenefitValueItem _benefitValueItemBenefitValueItem;

		[Token(Token = "0x4005268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RectTransform _rectTransformImgWood;

		[Token(Token = "0x4005269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Button _buttonImgWood;

		[Token(Token = "0x400526A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private TextMeshProUGUI _textMeshProUGUITxtWoodNum;

		[Token(Token = "0x400526B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private RectTransform _rectTransformImgCoin;

		[Token(Token = "0x400526C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Button _buttonImgCoin;

		[Token(Token = "0x400526D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private TextMeshProUGUI _textMeshProUGUITxtCoinNum;

		[Token(Token = "0x400526E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private RectTransform _rectTransformImgGem;

		[Token(Token = "0x400526F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Button _buttonImgGem;

		[Token(Token = "0x4005270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private TextMeshProUGUI _textMeshProUGUITxtGemNum;

		[Token(Token = "0x4005271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private TextMeshProUGUI _textMeshProUGUITxtDailyReward;

		[Token(Token = "0x4005272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Image _imageImgDailyRewardDuiHao;

		[Token(Token = "0x4005273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Image _imageImgBannerDuiHao;

		[Token(Token = "0x4005274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private TextMeshProUGUI _textMeshProUGUITxtPrivilege;

		[Token(Token = "0x4005275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private TextMeshProUGUI _textMeshProUGUITxtNoAdDes;

		[Token(Token = "0x4005276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private TextMeshProUGUI _textMeshProUGUITxtMoreReDes;

		[Token(Token = "0x4005277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private RectTransform _rectTransformBtnBuy;

		[Token(Token = "0x4005278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private HWIAPButton _hWIAPButtonBtnBuy;

		[Token(Token = "0x4005279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private ButtonExtend _buttonExtendBtnBuy;

		[Token(Token = "0x400527A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private RectTransform _rectTransformBtnRenewal;

		[Token(Token = "0x400527B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private ButtonExtend _buttonExtendBtnRenewal;

		[Token(Token = "0x400527C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private ButtonExtend _buttonExtendBtnReceive;

		[Token(Token = "0x400527D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private TextMeshProUGUI _textMeshProUGUITxtReceive;

		[Token(Token = "0x400527E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private TextMeshProUGUI _textMeshProUGUITxtHasReceive;

		[Token(Token = "0x400527F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private ButtonExtend _buttonExtendBtnClose;

		[Token(Token = "0x4005280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Image _imageImgTimeLeftBg;

		[Token(Token = "0x4005281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private TextMeshProUGUI _textMeshProUGUITxtTimeLeft;

		[Token(Token = "0x17000B71")]
		public ButtonExtend ButtonExtendBG
		{
			[Token(Token = "0x600450F")]
			[Address(RVA = "0x41FBA3C", Offset = "0x41F7A3C", VA = "0x41FBA3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B72")]
		public RectTransform RectTransformImgBg
		{
			[Token(Token = "0x6004510")]
			[Address(RVA = "0x41FBB04", Offset = "0x41F7B04", VA = "0x41FBB04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B73")]
		public Image ImageGold
		{
			[Token(Token = "0x6004511")]
			[Address(RVA = "0x41FBBCC", Offset = "0x41F7BCC", VA = "0x41FBBCC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B74")]
		public Image ImageImgCrown
		{
			[Token(Token = "0x6004512")]
			[Address(RVA = "0x41FBC94", Offset = "0x41F7C94", VA = "0x41FBC94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B75")]
		public TextMeshProUGUI TextMeshProUGUITxtGiftPackName
		{
			[Token(Token = "0x6004513")]
			[Address(RVA = "0x41FB3F0", Offset = "0x41F73F0", VA = "0x41FB3F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B76")]
		public BenefitValueItem BenefitValueItemBenefitValueItem
		{
			[Token(Token = "0x6004514")]
			[Address(RVA = "0x41FB0D0", Offset = "0x41F70D0", VA = "0x41FB0D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B77")]
		public RectTransform RectTransformImgWood
		{
			[Token(Token = "0x6004515")]
			[Address(RVA = "0x41FBD5C", Offset = "0x41F7D5C", VA = "0x41FBD5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B78")]
		public Button ButtonImgWood
		{
			[Token(Token = "0x6004516")]
			[Address(RVA = "0x41FBE24", Offset = "0x41F7E24", VA = "0x41FBE24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B79")]
		public TextMeshProUGUI TextMeshProUGUITxtWoodNum
		{
			[Token(Token = "0x6004517")]
			[Address(RVA = "0x41FB328", Offset = "0x41F7328", VA = "0x41FB328")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B7A")]
		public RectTransform RectTransformImgCoin
		{
			[Token(Token = "0x6004518")]
			[Address(RVA = "0x41FBEEC", Offset = "0x41F7EEC", VA = "0x41FBEEC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B7B")]
		public Button ButtonImgCoin
		{
			[Token(Token = "0x6004519")]
			[Address(RVA = "0x41FBFB4", Offset = "0x41F7FB4", VA = "0x41FBFB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B7C")]
		public TextMeshProUGUI TextMeshProUGUITxtCoinNum
		{
			[Token(Token = "0x600451A")]
			[Address(RVA = "0x41FB198", Offset = "0x41F7198", VA = "0x41FB198")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B7D")]
		public RectTransform RectTransformImgGem
		{
			[Token(Token = "0x600451B")]
			[Address(RVA = "0x41FC07C", Offset = "0x41F807C", VA = "0x41FC07C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B7E")]
		public Button ButtonImgGem
		{
			[Token(Token = "0x600451C")]
			[Address(RVA = "0x41FC144", Offset = "0x41F8144", VA = "0x41FC144")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B7F")]
		public TextMeshProUGUI TextMeshProUGUITxtGemNum
		{
			[Token(Token = "0x600451D")]
			[Address(RVA = "0x41FB260", Offset = "0x41F7260", VA = "0x41FB260")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B80")]
		public TextMeshProUGUI TextMeshProUGUITxtDailyReward
		{
			[Token(Token = "0x600451E")]
			[Address(RVA = "0x41FB4B8", Offset = "0x41F74B8", VA = "0x41FB4B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B81")]
		public Image ImageImgDailyRewardDuiHao
		{
			[Token(Token = "0x600451F")]
			[Address(RVA = "0x41FC20C", Offset = "0x41F820C", VA = "0x41FC20C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B82")]
		public Image ImageImgBannerDuiHao
		{
			[Token(Token = "0x6004520")]
			[Address(RVA = "0x41FC2D4", Offset = "0x41F82D4", VA = "0x41FC2D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B83")]
		public TextMeshProUGUI TextMeshProUGUITxtPrivilege
		{
			[Token(Token = "0x6004521")]
			[Address(RVA = "0x41FB580", Offset = "0x41F7580", VA = "0x41FB580")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B84")]
		public TextMeshProUGUI TextMeshProUGUITxtNoAdDes
		{
			[Token(Token = "0x6004522")]
			[Address(RVA = "0x41FB648", Offset = "0x41F7648", VA = "0x41FB648")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B85")]
		public TextMeshProUGUI TextMeshProUGUITxtMoreReDes
		{
			[Token(Token = "0x6004523")]
			[Address(RVA = "0x41FB710", Offset = "0x41F7710", VA = "0x41FB710")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B86")]
		public RectTransform RectTransformBtnBuy
		{
			[Token(Token = "0x6004524")]
			[Address(RVA = "0x41FC39C", Offset = "0x41F839C", VA = "0x41FC39C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B87")]
		public HWIAPButton HWIAPButtonBtnBuy
		{
			[Token(Token = "0x6004525")]
			[Address(RVA = "0x41FB968", Offset = "0x41F7968", VA = "0x41FB968")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B88")]
		public ButtonExtend ButtonExtendBtnBuy
		{
			[Token(Token = "0x6004526")]
			[Address(RVA = "0x41FC464", Offset = "0x41F8464", VA = "0x41FC464")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B89")]
		public RectTransform RectTransformBtnRenewal
		{
			[Token(Token = "0x6004527")]
			[Address(RVA = "0x41FC52C", Offset = "0x41F852C", VA = "0x41FC52C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B8A")]
		public ButtonExtend ButtonExtendBtnRenewal
		{
			[Token(Token = "0x6004528")]
			[Address(RVA = "0x41FC5F4", Offset = "0x41F85F4", VA = "0x41FC5F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B8B")]
		public ButtonExtend ButtonExtendBtnReceive
		{
			[Token(Token = "0x6004529")]
			[Address(RVA = "0x41FC6BC", Offset = "0x41F86BC", VA = "0x41FC6BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B8C")]
		public TextMeshProUGUI TextMeshProUGUITxtReceive
		{
			[Token(Token = "0x600452A")]
			[Address(RVA = "0x41FB8A0", Offset = "0x41F78A0", VA = "0x41FB8A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B8D")]
		public TextMeshProUGUI TextMeshProUGUITxtHasReceive
		{
			[Token(Token = "0x600452B")]
			[Address(RVA = "0x41FB7D8", Offset = "0x41F77D8", VA = "0x41FB7D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B8E")]
		public ButtonExtend ButtonExtendBtnClose
		{
			[Token(Token = "0x600452C")]
			[Address(RVA = "0x41FC784", Offset = "0x41F8784", VA = "0x41FC784")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B8F")]
		public Image ImageImgTimeLeftBg
		{
			[Token(Token = "0x600452D")]
			[Address(RVA = "0x41FC84C", Offset = "0x41F884C", VA = "0x41FC84C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B90")]
		public TextMeshProUGUI TextMeshProUGUITxtTimeLeft
		{
			[Token(Token = "0x600452E")]
			[Address(RVA = "0x41FC914", Offset = "0x41F8914", VA = "0x41FC914")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600452F")]
		[Address(RVA = "0x41FC9DC", Offset = "0x41F89DC", VA = "0x41FC9DC")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6004530")]
		[Address(RVA = "0x41FCC48", Offset = "0x41F8C48", VA = "0x41FCC48", Slot = "12")]
		protected virtual void OnButtonExtendBGClicked()
		{
		}

		[Token(Token = "0x6004531")]
		[Address(RVA = "0x41FCCB4", Offset = "0x41F8CB4", VA = "0x41FCCB4", Slot = "13")]
		protected virtual void OnButtonImgWoodClicked()
		{
		}

		[Token(Token = "0x6004532")]
		[Address(RVA = "0x41FCD20", Offset = "0x41F8D20", VA = "0x41FCD20", Slot = "14")]
		protected virtual void OnButtonImgCoinClicked()
		{
		}

		[Token(Token = "0x6004533")]
		[Address(RVA = "0x41FCD8C", Offset = "0x41F8D8C", VA = "0x41FCD8C", Slot = "15")]
		protected virtual void OnButtonImgGemClicked()
		{
		}

		[Token(Token = "0x6004534")]
		[Address(RVA = "0x41FCDF8", Offset = "0x41F8DF8", VA = "0x41FCDF8", Slot = "16")]
		protected virtual void OnButtonExtendBtnBuyClicked()
		{
		}

		[Token(Token = "0x6004535")]
		[Address(RVA = "0x41FCE64", Offset = "0x41F8E64", VA = "0x41FCE64", Slot = "17")]
		protected virtual void OnButtonExtendBtnRenewalClicked()
		{
		}

		[Token(Token = "0x6004536")]
		[Address(RVA = "0x41FCED0", Offset = "0x41F8ED0", VA = "0x41FCED0", Slot = "18")]
		protected virtual void OnButtonExtendBtnReceiveClicked()
		{
		}

		[Token(Token = "0x6004537")]
		[Address(RVA = "0x41FCF3C", Offset = "0x41F8F3C", VA = "0x41FCF3C", Slot = "19")]
		protected virtual void OnButtonExtendBtnCloseClicked()
		{
		}

		[Token(Token = "0x6004538")]
		[Address(RVA = "0x41FCFA8", Offset = "0x41F8FA8", VA = "0x41FCFA8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6004539")]
		[Address(RVA = "0x41FCFC4", Offset = "0x41F8FC4", VA = "0x41FCFC4", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__508))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x600453A")]
		[Address(RVA = "0x41FD058", Offset = "0x41F9058", VA = "0x41FD058", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x600453B")]
		[Address(RVA = "0x41FD10C", Offset = "0x41F910C", VA = "0x41FD10C")]
		public MonthPassPanelComponents()
		{
		}
	}
}
