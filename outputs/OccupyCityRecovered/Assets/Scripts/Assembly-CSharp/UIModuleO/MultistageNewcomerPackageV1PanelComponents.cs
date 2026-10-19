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
	[Token(Token = "0x20009A6")]
	public class MultistageNewcomerPackageV1PanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20009A7")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__429 : IAsyncStateMachine
		{
			[Token(Token = "0x4004831")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004832")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004833")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MultistageNewcomerPackageV1PanelComponents _003C_003E4__this;

			[Token(Token = "0x4004834")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6003968")]
			[Address(RVA = "0x4103BF8", Offset = "0x40FFBF8", VA = "0x4103BF8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003969")]
			[Address(RVA = "0x4103E70", Offset = "0x40FFE70", VA = "0x4103E70", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004814")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Button _buttonBackground;

		[Token(Token = "0x4004815")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Image _imageContent;

		[Token(Token = "0x4004816")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TextMeshProUGUI _textMeshProUGUITitle;

		[Token(Token = "0x4004817")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private RectTransform _rectTransformCountTimer;

		[Token(Token = "0x4004818")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TextMeshProUGUI _textMeshProUGUICountTimer;

		[Token(Token = "0x4004819")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private ButtonExtend _buttonExtendClose;

		[Token(Token = "0x400481A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RectTransform _rectTransformCardItem;

		[Token(Token = "0x400481B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private RectTransform _rectTransformCardLight;

		[Token(Token = "0x400481C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private TextMeshProUGUI _textMeshProUGUICardNumber;

		[Token(Token = "0x400481D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private RectTransform _rectTransformCardIsGet;

		[Token(Token = "0x400481E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private TextMeshProUGUI _textMeshProUGUICardIHint;

		[Token(Token = "0x400481F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private RectTransform _rectTransformDayAwardRoot;

		[Token(Token = "0x4004820")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private dayAwardItem _dayAwardItemMultistageNewcomerPackagePanel_DayAwardItem1;

		[Token(Token = "0x4004821")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private BenefitValueItem _benefitValueItemBenefitValueItem;

		[Token(Token = "0x4004822")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private RectTransform _rectTransformClaimBtn;

		[Token(Token = "0x4004823")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private ButtonExtend _buttonExtendClaimBtn;

		[Token(Token = "0x4004824")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private RectTransform _rectTransformClaimBtnLight;

		[Token(Token = "0x4004825")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private TextMeshProUGUI _textMeshProUGUIClaimText;

		[Token(Token = "0x4004826")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private RectTransform _rectTransformRedDot_UI;

		[Token(Token = "0x4004827")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private RectTransform _rectTransformClaimBtnMask;

		[Token(Token = "0x4004828")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private HWIAPButton _hWIAPButtonHWIAPButton;

		[Token(Token = "0x4004829")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private ButtonExtend _buttonExtendHWIAPButton;

		[Token(Token = "0x400482A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private ToggleGroup _toggleGroupToggleList;

		[Token(Token = "0x400482B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Toggle _toggleMultistageNewcomerPackagePanel_ToggleLevel1;

		[Token(Token = "0x400482C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private MultistageNewcomerPackagePanel_ToggleLevel _multistageNewcomerPackagePanel_ToggleLevelMultistageNewcomerPackagePanel_ToggleLevel1;

		[Token(Token = "0x400482D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Toggle _toggleMultistageNewcomerPackagePanel_ToggleLevel2;

		[Token(Token = "0x400482E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private MultistageNewcomerPackagePanel_ToggleLevel _multistageNewcomerPackagePanel_ToggleLevelMultistageNewcomerPackagePanel_ToggleLevel2;

		[Token(Token = "0x400482F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Toggle _toggleMultistageNewcomerPackagePanel_ToggleLevel3;

		[Token(Token = "0x4004830")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private MultistageNewcomerPackagePanel_ToggleLevel _multistageNewcomerPackagePanel_ToggleLevelMultistageNewcomerPackagePanel_ToggleLevel3;

		[Token(Token = "0x170008A7")]
		public Button ButtonBackground
		{
			[Token(Token = "0x600393E")]
			[Address(RVA = "0x41036DC", Offset = "0x40FF6DC", VA = "0x41036DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008A8")]
		public Image ImageContent
		{
			[Token(Token = "0x600393F")]
			[Address(RVA = "0x41000C8", Offset = "0x40FC0C8", VA = "0x41000C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008A9")]
		public TextMeshProUGUI TextMeshProUGUITitle
		{
			[Token(Token = "0x6003940")]
			[Address(RVA = "0x4101C80", Offset = "0x40FDC80", VA = "0x4101C80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008AA")]
		public RectTransform RectTransformCountTimer
		{
			[Token(Token = "0x6003941")]
			[Address(RVA = "0x4102724", Offset = "0x40FE724", VA = "0x4102724")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008AB")]
		public TextMeshProUGUI TextMeshProUGUICountTimer
		{
			[Token(Token = "0x6003942")]
			[Address(RVA = "0x41027F4", Offset = "0x40FE7F4", VA = "0x41027F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008AC")]
		public ButtonExtend ButtonExtendClose
		{
			[Token(Token = "0x6003943")]
			[Address(RVA = "0x41037A4", Offset = "0x40FF7A4", VA = "0x41037A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008AD")]
		public RectTransform RectTransformCardItem
		{
			[Token(Token = "0x6003944")]
			[Address(RVA = "0x4100190", Offset = "0x40FC190", VA = "0x4100190")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008AE")]
		public RectTransform RectTransformCardLight
		{
			[Token(Token = "0x6003945")]
			[Address(RVA = "0x4100258", Offset = "0x40FC258", VA = "0x4100258")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008AF")]
		public TextMeshProUGUI TextMeshProUGUICardNumber
		{
			[Token(Token = "0x6003946")]
			[Address(RVA = "0x4101A28", Offset = "0x40FDA28", VA = "0x4101A28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008B0")]
		public RectTransform RectTransformCardIsGet
		{
			[Token(Token = "0x6003947")]
			[Address(RVA = "0x4101BB8", Offset = "0x40FDBB8", VA = "0x4101BB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008B1")]
		public TextMeshProUGUI TextMeshProUGUICardIHint
		{
			[Token(Token = "0x6003948")]
			[Address(RVA = "0x4101AF0", Offset = "0x40FDAF0", VA = "0x4101AF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008B2")]
		public RectTransform RectTransformDayAwardRoot
		{
			[Token(Token = "0x6003949")]
			[Address(RVA = "0x41028BC", Offset = "0x40FE8BC", VA = "0x41028BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008B3")]
		public dayAwardItem DayAwardItemMultistageNewcomerPackagePanel_DayAwardItem1
		{
			[Token(Token = "0x600394A")]
			[Address(RVA = "0x4102084", Offset = "0x40FE084", VA = "0x4102084")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008B4")]
		public BenefitValueItem BenefitValueItemBenefitValueItem
		{
			[Token(Token = "0x600394B")]
			[Address(RVA = "0x4101D48", Offset = "0x40FDD48", VA = "0x4101D48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008B5")]
		public RectTransform RectTransformClaimBtn
		{
			[Token(Token = "0x600394C")]
			[Address(RVA = "0x41024CC", Offset = "0x40FE4CC", VA = "0x41024CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008B6")]
		public ButtonExtend ButtonExtendClaimBtn
		{
			[Token(Token = "0x600394D")]
			[Address(RVA = "0x41021AC", Offset = "0x40FE1AC", VA = "0x41021AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008B7")]
		public RectTransform RectTransformClaimBtnLight
		{
			[Token(Token = "0x600394E")]
			[Address(RVA = "0x4102404", Offset = "0x40FE404", VA = "0x4102404")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008B8")]
		public TextMeshProUGUI TextMeshProUGUIClaimText
		{
			[Token(Token = "0x600394F")]
			[Address(RVA = "0x4102594", Offset = "0x40FE594", VA = "0x4102594")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008B9")]
		public RectTransform RectTransformRedDot_UI
		{
			[Token(Token = "0x6003950")]
			[Address(RVA = "0x4102274", Offset = "0x40FE274", VA = "0x4102274")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008BA")]
		public RectTransform RectTransformClaimBtnMask
		{
			[Token(Token = "0x6003951")]
			[Address(RVA = "0x410233C", Offset = "0x40FE33C", VA = "0x410233C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008BB")]
		public HWIAPButton HWIAPButtonHWIAPButton
		{
			[Token(Token = "0x6003952")]
			[Address(RVA = "0x410265C", Offset = "0x40FE65C", VA = "0x410265C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008BC")]
		public ButtonExtend ButtonExtendHWIAPButton
		{
			[Token(Token = "0x6003953")]
			[Address(RVA = "0x410386C", Offset = "0x40FF86C", VA = "0x410386C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008BD")]
		public ToggleGroup ToggleGroupToggleList
		{
			[Token(Token = "0x6003954")]
			[Address(RVA = "0x4100C4C", Offset = "0x40FCC4C", VA = "0x4100C4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008BE")]
		public Toggle ToggleMultistageNewcomerPackagePanel_ToggleLevel1
		{
			[Token(Token = "0x6003955")]
			[Address(RVA = "0x4100D14", Offset = "0x40FCD14", VA = "0x4100D14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008BF")]
		public MultistageNewcomerPackagePanel_ToggleLevel MultistageNewcomerPackagePanel_ToggleLevelMultistageNewcomerPackagePanel_ToggleLevel1
		{
			[Token(Token = "0x6003956")]
			[Address(RVA = "0x4100320", Offset = "0x40FC320", VA = "0x4100320")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008C0")]
		public Toggle ToggleMultistageNewcomerPackagePanel_ToggleLevel2
		{
			[Token(Token = "0x6003957")]
			[Address(RVA = "0x4100DDC", Offset = "0x40FCDDC", VA = "0x4100DDC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008C1")]
		public MultistageNewcomerPackagePanel_ToggleLevel MultistageNewcomerPackagePanel_ToggleLevelMultistageNewcomerPackagePanel_ToggleLevel2
		{
			[Token(Token = "0x6003958")]
			[Address(RVA = "0x41003E8", Offset = "0x40FC3E8", VA = "0x41003E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008C2")]
		public Toggle ToggleMultistageNewcomerPackagePanel_ToggleLevel3
		{
			[Token(Token = "0x6003959")]
			[Address(RVA = "0x4100EA4", Offset = "0x40FCEA4", VA = "0x4100EA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008C3")]
		public MultistageNewcomerPackagePanel_ToggleLevel MultistageNewcomerPackagePanel_ToggleLevelMultistageNewcomerPackagePanel_ToggleLevel3
		{
			[Token(Token = "0x600395A")]
			[Address(RVA = "0x41004B0", Offset = "0x40FC4B0", VA = "0x41004B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600395B")]
		[Address(RVA = "0x4103934", Offset = "0x40FF934", VA = "0x4103934")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x600395C")]
		[Address(RVA = "0x4102DD0", Offset = "0x40FEDD0", VA = "0x4102DD0", Slot = "12")]
		protected virtual void OnButtonBackgroundClicked()
		{
		}

		[Token(Token = "0x600395D")]
		[Address(RVA = "0x4102D44", Offset = "0x40FED44", VA = "0x4102D44", Slot = "13")]
		protected virtual void OnButtonExtendCloseClicked()
		{
		}

		[Token(Token = "0x600395E")]
		[Address(RVA = "0x41029E0", Offset = "0x40FE9E0", VA = "0x41029E0", Slot = "14")]
		protected virtual void OnButtonExtendClaimBtnClicked()
		{
		}

		[Token(Token = "0x600395F")]
		[Address(RVA = "0x4103B84", Offset = "0x40FFB84", VA = "0x4103B84", Slot = "15")]
		protected virtual void OnButtonExtendHWIAPButtonClicked()
		{
		}

		[Token(Token = "0x6003960")]
		[Address(RVA = "0x4102A90", Offset = "0x40FEA90", VA = "0x4102A90", Slot = "16")]
		protected virtual void OnToggleLevel1ValueChanged(bool arg)
		{
		}

		[Token(Token = "0x6003961")]
		[Address(RVA = "0x4102B84", Offset = "0x40FEB84", VA = "0x4102B84", Slot = "17")]
		protected virtual void OnToggleLevel2ValueChanged(bool arg)
		{
		}

		[Token(Token = "0x6003962")]
		[Address(RVA = "0x4102C78", Offset = "0x40FEC78", VA = "0x4102C78", Slot = "18")]
		protected virtual void OnToggleLevel3ValueChanged(bool arg)
		{
		}

		[Token(Token = "0x6003963")]
		[Address(RVA = "0x41000AC", Offset = "0x40FC0AC", VA = "0x41000AC", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6003964")]
		[Address(RVA = "0x4103228", Offset = "0x40FF228", VA = "0x4103228", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__429))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6003965")]
		[Address(RVA = "0x4102EAC", Offset = "0x40FEEAC", VA = "0x4102EAC", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6003966")]
		[Address(RVA = "0x4103180", Offset = "0x40FF180", VA = "0x4103180")]
		public MultistageNewcomerPackageV1PanelComponents()
		{
		}
	}
}
