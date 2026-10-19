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
	[Token(Token = "0x200099A")]
	public class MultistageNewcomerPackagePanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200099B")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__467 : IAsyncStateMachine
		{
			[Token(Token = "0x40047EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40047EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40047F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MultistageNewcomerPackagePanelComponents _003C_003E4__this;

			[Token(Token = "0x40047F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x600390A")]
			[Address(RVA = "0x40FEF64", Offset = "0x40FAF64", VA = "0x40FEF64", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600390B")]
			[Address(RVA = "0x40FF1DC", Offset = "0x40FB1DC", VA = "0x40FF1DC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40047D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Button _buttonBackground;

		[Token(Token = "0x40047D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Image _imageContent;

		[Token(Token = "0x40047D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private ButtonExtend _buttonExtendClose;

		[Token(Token = "0x40047D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Image _imageAmount;

		[Token(Token = "0x40047D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private RectTransform _rectTransformCardItem;

		[Token(Token = "0x40047DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private ButtonExtend _buttonExtendImgBg;

		[Token(Token = "0x40047DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private BenefitValueItem _benefitValueItemBenefitValueItem;

		[Token(Token = "0x40047DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private TextMeshProUGUI _textMeshProUGUITitle;

		[Token(Token = "0x40047DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private dayAwardItem _dayAwardItemMultistageNewcomerPackagePanel_DayAwardItem1;

		[Token(Token = "0x40047DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private dayAwardItem _dayAwardItemMultistageNewcomerPackagePanel_DayAwardItem2;

		[Token(Token = "0x40047DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private dayAwardItem _dayAwardItemMultistageNewcomerPackagePanel_DayAwardItem3;

		[Token(Token = "0x40047E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private RectTransform _rectTransformClaimBtn;

		[Token(Token = "0x40047E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private ButtonExtend _buttonExtendClaimBtn;

		[Token(Token = "0x40047E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private TextMeshProUGUI _textMeshProUGUIClaimText;

		[Token(Token = "0x40047E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private ToggleGroup _toggleGroupToggleList;

		[Token(Token = "0x40047E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Toggle _toggleMultistageNewcomerPackagePanel_ToggleLevel1;

		[Token(Token = "0x40047E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private MultistageNewcomerPackagePanel_ToggleLevel _multistageNewcomerPackagePanel_ToggleLevelMultistageNewcomerPackagePanel_ToggleLevel1;

		[Token(Token = "0x40047E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Toggle _toggleMultistageNewcomerPackagePanel_ToggleLevel2;

		[Token(Token = "0x40047E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private MultistageNewcomerPackagePanel_ToggleLevel _multistageNewcomerPackagePanel_ToggleLevelMultistageNewcomerPackagePanel_ToggleLevel2;

		[Token(Token = "0x40047E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Toggle _toggleMultistageNewcomerPackagePanel_ToggleLevel3;

		[Token(Token = "0x40047E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private MultistageNewcomerPackagePanel_ToggleLevel _multistageNewcomerPackagePanel_ToggleLevelMultistageNewcomerPackagePanel_ToggleLevel3;

		[Token(Token = "0x40047EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Toggle _toggleMultistageNewcomerPackagePanel_ToggleLevel4;

		[Token(Token = "0x40047EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private MultistageNewcomerPackagePanel_ToggleLevel _multistageNewcomerPackagePanel_ToggleLevelMultistageNewcomerPackagePanel_ToggleLevel4;

		[Token(Token = "0x40047EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private HWIAPButton _hWIAPButtonHWIAPButton;

		[Token(Token = "0x40047ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private ButtonExtend _buttonExtendHWIAPButton;

		[Token(Token = "0x1700088C")]
		public Button ButtonBackground
		{
			[Token(Token = "0x60038E2")]
			[Address(RVA = "0x40FE7BC", Offset = "0x40FA7BC", VA = "0x40FE7BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700088D")]
		public Image ImageContent
		{
			[Token(Token = "0x60038E3")]
			[Address(RVA = "0x40FB9D8", Offset = "0x40F79D8", VA = "0x40FB9D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700088E")]
		public ButtonExtend ButtonExtendClose
		{
			[Token(Token = "0x60038E4")]
			[Address(RVA = "0x40FE884", Offset = "0x40FA884", VA = "0x40FE884")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700088F")]
		public Image ImageAmount
		{
			[Token(Token = "0x60038E5")]
			[Address(RVA = "0x40FDDDC", Offset = "0x40F9DDC", VA = "0x40FDDDC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000890")]
		public RectTransform RectTransformCardItem
		{
			[Token(Token = "0x60038E6")]
			[Address(RVA = "0x40FCDF8", Offset = "0x40F8DF8", VA = "0x40FCDF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000891")]
		public ButtonExtend ButtonExtendImgBg
		{
			[Token(Token = "0x60038E7")]
			[Address(RVA = "0x40FE94C", Offset = "0x40FA94C", VA = "0x40FE94C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000892")]
		public BenefitValueItem BenefitValueItemBenefitValueItem
		{
			[Token(Token = "0x60038E8")]
			[Address(RVA = "0x40FDD14", Offset = "0x40F9D14", VA = "0x40FDD14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000893")]
		public TextMeshProUGUI TextMeshProUGUITitle
		{
			[Token(Token = "0x60038E9")]
			[Address(RVA = "0x40FE0FC", Offset = "0x40FA0FC", VA = "0x40FE0FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000894")]
		public dayAwardItem DayAwardItemMultistageNewcomerPackagePanel_DayAwardItem1
		{
			[Token(Token = "0x60038EA")]
			[Address(RVA = "0x40FDEA4", Offset = "0x40F9EA4", VA = "0x40FDEA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000895")]
		public dayAwardItem DayAwardItemMultistageNewcomerPackagePanel_DayAwardItem2
		{
			[Token(Token = "0x60038EB")]
			[Address(RVA = "0x40FDF6C", Offset = "0x40F9F6C", VA = "0x40FDF6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000896")]
		public dayAwardItem DayAwardItemMultistageNewcomerPackagePanel_DayAwardItem3
		{
			[Token(Token = "0x60038EC")]
			[Address(RVA = "0x40FE034", Offset = "0x40FA034", VA = "0x40FE034")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000897")]
		public RectTransform RectTransformClaimBtn
		{
			[Token(Token = "0x60038ED")]
			[Address(RVA = "0x40FE1C4", Offset = "0x40FA1C4", VA = "0x40FE1C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000898")]
		public ButtonExtend ButtonExtendClaimBtn
		{
			[Token(Token = "0x60038EE")]
			[Address(RVA = "0x40FEA14", Offset = "0x40FAA14", VA = "0x40FEA14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000899")]
		public TextMeshProUGUI TextMeshProUGUIClaimText
		{
			[Token(Token = "0x60038EF")]
			[Address(RVA = "0x40FE28C", Offset = "0x40FA28C", VA = "0x40FE28C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700089A")]
		public ToggleGroup ToggleGroupToggleList
		{
			[Token(Token = "0x60038F0")]
			[Address(RVA = "0x40FC0D8", Offset = "0x40F80D8", VA = "0x40FC0D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700089B")]
		public Toggle ToggleMultistageNewcomerPackagePanel_ToggleLevel1
		{
			[Token(Token = "0x60038F1")]
			[Address(RVA = "0x40FC1A0", Offset = "0x40F81A0", VA = "0x40FC1A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700089C")]
		public MultistageNewcomerPackagePanel_ToggleLevel MultistageNewcomerPackagePanel_ToggleLevelMultistageNewcomerPackagePanel_ToggleLevel1
		{
			[Token(Token = "0x60038F2")]
			[Address(RVA = "0x40FBAA0", Offset = "0x40F7AA0", VA = "0x40FBAA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700089D")]
		public Toggle ToggleMultistageNewcomerPackagePanel_ToggleLevel2
		{
			[Token(Token = "0x60038F3")]
			[Address(RVA = "0x40FC268", Offset = "0x40F8268", VA = "0x40FC268")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700089E")]
		public MultistageNewcomerPackagePanel_ToggleLevel MultistageNewcomerPackagePanel_ToggleLevelMultistageNewcomerPackagePanel_ToggleLevel2
		{
			[Token(Token = "0x60038F4")]
			[Address(RVA = "0x40FBCD4", Offset = "0x40F7CD4", VA = "0x40FBCD4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700089F")]
		public Toggle ToggleMultistageNewcomerPackagePanel_ToggleLevel3
		{
			[Token(Token = "0x60038F5")]
			[Address(RVA = "0x40FC330", Offset = "0x40F8330", VA = "0x40FC330")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008A0")]
		public MultistageNewcomerPackagePanel_ToggleLevel MultistageNewcomerPackagePanel_ToggleLevelMultistageNewcomerPackagePanel_ToggleLevel3
		{
			[Token(Token = "0x60038F6")]
			[Address(RVA = "0x40FBD9C", Offset = "0x40F7D9C", VA = "0x40FBD9C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008A1")]
		public Toggle ToggleMultistageNewcomerPackagePanel_ToggleLevel4
		{
			[Token(Token = "0x60038F7")]
			[Address(RVA = "0x40FC3F8", Offset = "0x40F83F8", VA = "0x40FC3F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008A2")]
		public MultistageNewcomerPackagePanel_ToggleLevel MultistageNewcomerPackagePanel_ToggleLevelMultistageNewcomerPackagePanel_ToggleLevel4
		{
			[Token(Token = "0x60038F8")]
			[Address(RVA = "0x40FBE64", Offset = "0x40F7E64", VA = "0x40FBE64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008A3")]
		public HWIAPButton HWIAPButtonHWIAPButton
		{
			[Token(Token = "0x60038F9")]
			[Address(RVA = "0x40FE354", Offset = "0x40FA354", VA = "0x40FE354")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008A4")]
		public ButtonExtend ButtonExtendHWIAPButton
		{
			[Token(Token = "0x60038FA")]
			[Address(RVA = "0x40FEADC", Offset = "0x40FAADC", VA = "0x40FEADC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60038FB")]
		[Address(RVA = "0x40FEBA4", Offset = "0x40FABA4", VA = "0x40FEBA4")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x60038FC")]
		[Address(RVA = "0x40FCBC4", Offset = "0x40F8BC4", VA = "0x40FCBC4", Slot = "12")]
		protected virtual void OnButtonBackgroundClicked()
		{
		}

		[Token(Token = "0x60038FD")]
		[Address(RVA = "0x40FCB38", Offset = "0x40F8B38", VA = "0x40FCB38", Slot = "13")]
		protected virtual void OnButtonExtendCloseClicked()
		{
		}

		[Token(Token = "0x60038FE")]
		[Address(RVA = "0x40FEE84", Offset = "0x40FAE84", VA = "0x40FEE84", Slot = "14")]
		protected virtual void OnButtonExtendImgBgClicked()
		{
		}

		[Token(Token = "0x60038FF")]
		[Address(RVA = "0x40FC60C", Offset = "0x40F860C", VA = "0x40FC60C", Slot = "15")]
		protected virtual void OnButtonExtendClaimBtnClicked()
		{
		}

		[Token(Token = "0x6003900")]
		[Address(RVA = "0x40FC6C0", Offset = "0x40F86C0", VA = "0x40FC6C0", Slot = "16")]
		protected virtual void OnToggleLevel1ValueChanged(bool arg)
		{
		}

		[Token(Token = "0x6003901")]
		[Address(RVA = "0x40FC87C", Offset = "0x40F887C", VA = "0x40FC87C", Slot = "17")]
		protected virtual void OnToggleLevel2ValueChanged(bool arg)
		{
		}

		[Token(Token = "0x6003902")]
		[Address(RVA = "0x40FC974", Offset = "0x40F8974", VA = "0x40FC974", Slot = "18")]
		protected virtual void OnToggleLevel3ValueChanged(bool arg)
		{
		}

		[Token(Token = "0x6003903")]
		[Address(RVA = "0x40FCA6C", Offset = "0x40F8A6C", VA = "0x40FCA6C", Slot = "19")]
		protected virtual void OnToggleLevel4ValueChanged(bool arg)
		{
		}

		[Token(Token = "0x6003904")]
		[Address(RVA = "0x40FEEF0", Offset = "0x40FAEF0", VA = "0x40FEEF0", Slot = "20")]
		protected virtual void OnButtonExtendHWIAPButtonClicked()
		{
		}

		[Token(Token = "0x6003905")]
		[Address(RVA = "0x40FB9BC", Offset = "0x40F79BC", VA = "0x40FB9BC", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6003906")]
		[Address(RVA = "0x40FCFE0", Offset = "0x40F8FE0", VA = "0x40FCFE0", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__467))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6003907")]
		[Address(RVA = "0x40FCC40", Offset = "0x40F8C40", VA = "0x40FCC40", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6003908")]
		[Address(RVA = "0x40FCF3C", Offset = "0x40F8F3C", VA = "0x40FCF3C")]
		public MultistageNewcomerPackagePanelComponents()
		{
		}
	}
}
