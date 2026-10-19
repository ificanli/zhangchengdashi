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
	[Token(Token = "0x20007C7")]
	public class UpgradeCardPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20007C8")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__570 : IAsyncStateMachine
		{
			[Token(Token = "0x4003C38")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003C39")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003C3A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UpgradeCardPanelComponents _003C_003E4__this;

			[Token(Token = "0x4003C3B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6002B2B")]
			[Address(RVA = "0x3FE90C8", Offset = "0x3FE50C8", VA = "0x3FE90C8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002B2C")]
			[Address(RVA = "0x3FE9340", Offset = "0x3FE5340", VA = "0x3FE9340", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003C02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Button _buttonBG;

		[Token(Token = "0x4003C03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RectTransform _rectTransformMid;

		[Token(Token = "0x4003C04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RectTransform _rectTransformLightSkeletonGraphicRoot;

		[Token(Token = "0x4003C05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private RectTransform _rectTransformImgCardIcon;

		[Token(Token = "0x4003C06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Image _imageImgCardIcon;

		[Token(Token = "0x4003C07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Button _buttonBtnRole;

		[Token(Token = "0x4003C08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Image _imageImgRoleIcon;

		[Token(Token = "0x4003C09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private RectTransform _rectTransformBtnTower;

		[Token(Token = "0x4003C0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Button _buttonBtnTower;

		[Token(Token = "0x4003C0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Image _imageImgTowerIcon;

		[Token(Token = "0x4003C0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private RectTransform _rectTransformImgTalentRedDot;

		[Token(Token = "0x4003C0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private TextMeshProUGUI _textMeshProUGUITxtName;

		[Token(Token = "0x4003C0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private TextMeshProUGUI _textMeshProUGUITxtCardRare;

		[Token(Token = "0x4003C0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private RectTransform _rectTransformBtnAtkWayType;

		[Token(Token = "0x4003C10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Image _imageBtnAtkWayType;

		[Token(Token = "0x4003C11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private ButtonExtend _buttonExtendBtnAtkWayType;

		[Token(Token = "0x4003C12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Image _imageImgAtkWayTypeIcon;

		[Token(Token = "0x4003C13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private TextMeshProUGUI _textMeshProUGUITxtAtkWayType;

		[Token(Token = "0x4003C14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private RectTransform _rectTransformBtnFetter;

		[Token(Token = "0x4003C15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Image _imageBtnFetter;

		[Token(Token = "0x4003C16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private ButtonExtend _buttonExtendBtnFetter;

		[Token(Token = "0x4003C17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Image _imageImgFetterIcon;

		[Token(Token = "0x4003C18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private TextMeshProUGUI _textMeshProUGUITxtFetter;

		[Token(Token = "0x4003C19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Image _imageImgCpBg;

		[Token(Token = "0x4003C1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private TextMeshProUGUI _textMeshProUGUITxtCardCPNum;

		[Token(Token = "0x4003C1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private TextMeshProUGUI _textMeshProUGUITxtLevel;

		[Token(Token = "0x4003C1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Image _imageImgProcessBG;

		[Token(Token = "0x4003C1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Image _imageImgProcess;

		[Token(Token = "0x4003C1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private TextMeshProUGUI _textMeshProUGUITxtCardCount;

		[Token(Token = "0x4003C1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private RectTransform _rectTransformGeneralCard;

		[Token(Token = "0x4003C20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private TextMeshProUGUI _textMeshProUGUIGeneralCardNumber;

		[Token(Token = "0x4003C21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Image _imageGeneralCardIcon;

		[Token(Token = "0x4003C22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private ButtonExtend _buttonExtendGeneralCardBtn;

		[Token(Token = "0x4003C23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private RectTransform _rectTransformImgPropetryBG;

		[Token(Token = "0x4003C24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Image _imageImgPropetryBG;

		[Token(Token = "0x4003C25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private ButtonExtend _buttonExtendBtnClose;

		[Token(Token = "0x4003C26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private RectTransform _rectTransformImgOldAbilitiesBg;

		[Token(Token = "0x4003C27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private Image _imageImgOldAbilitiesBg;

		[Token(Token = "0x4003C28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private TextMeshProUGUI _textMeshProUGUITxtAbilities;

		[Token(Token = "0x4003C29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private RectTransform _rectTransformImgTalentBg;

		[Token(Token = "0x4003C2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private RectTransform _rectTransformBtnUpgrade;

		[Token(Token = "0x4003C2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private Image _imageBtnUpgrade;

		[Token(Token = "0x4003C2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private ButtonExtend _buttonExtendBtnUpgrade;

		[Token(Token = "0x4003C2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private TextMeshProUGUI _textMeshProUGUITxtUpgrade;

		[Token(Token = "0x4003C2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private TextMeshProUGUI _textMeshProUGUITxtCoinNum;

		[Token(Token = "0x4003C2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private RectTransform _rectTransformImgUpgradeCardGreenArrow;

		[Token(Token = "0x4003C30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private Image _imageBtnEquip;

		[Token(Token = "0x4003C31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private ButtonExtend _buttonExtendBtnEquip;

		[Token(Token = "0x4003C32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private TextMeshProUGUI _textMeshProUGUITxtEquip;

		[Token(Token = "0x4003C33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private RectTransform _rectTransformIntroBack;

		[Token(Token = "0x4003C34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private RectTransform _rectTransformIntroText;

		[Token(Token = "0x4003C35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private TextMeshProUGUI _textMeshProUGUIIntroText;

		[Token(Token = "0x4003C36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private Image _imageImgLockedBg;

		[Token(Token = "0x4003C37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private ButtonExtend _buttonExtendBtnGoGet;

		[Token(Token = "0x1700044C")]
		public Button ButtonBG
		{
			[Token(Token = "0x6002AE5")]
			[Address(RVA = "0x3FE5DF8", Offset = "0x3FE1DF8", VA = "0x3FE5DF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700044D")]
		public RectTransform RectTransformMid
		{
			[Token(Token = "0x6002AE6")]
			[Address(RVA = "0x3FE5EC0", Offset = "0x3FE1EC0", VA = "0x3FE5EC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700044E")]
		public RectTransform RectTransformLightSkeletonGraphicRoot
		{
			[Token(Token = "0x6002AE7")]
			[Address(RVA = "0x3FE5F88", Offset = "0x3FE1F88", VA = "0x3FE5F88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700044F")]
		public RectTransform RectTransformImgCardIcon
		{
			[Token(Token = "0x6002AE8")]
			[Address(RVA = "0x3FE6050", Offset = "0x3FE2050", VA = "0x3FE6050")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000450")]
		public Image ImageImgCardIcon
		{
			[Token(Token = "0x6002AE9")]
			[Address(RVA = "0x3FE6118", Offset = "0x3FE2118", VA = "0x3FE6118")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000451")]
		public Button ButtonBtnRole
		{
			[Token(Token = "0x6002AEA")]
			[Address(RVA = "0x3FE61E0", Offset = "0x3FE21E0", VA = "0x3FE61E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000452")]
		public Image ImageImgRoleIcon
		{
			[Token(Token = "0x6002AEB")]
			[Address(RVA = "0x3FE62A8", Offset = "0x3FE22A8", VA = "0x3FE62A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000453")]
		public RectTransform RectTransformBtnTower
		{
			[Token(Token = "0x6002AEC")]
			[Address(RVA = "0x3FE6370", Offset = "0x3FE2370", VA = "0x3FE6370")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000454")]
		public Button ButtonBtnTower
		{
			[Token(Token = "0x6002AED")]
			[Address(RVA = "0x3FE6438", Offset = "0x3FE2438", VA = "0x3FE6438")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000455")]
		public Image ImageImgTowerIcon
		{
			[Token(Token = "0x6002AEE")]
			[Address(RVA = "0x3FE6500", Offset = "0x3FE2500", VA = "0x3FE6500")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000456")]
		public RectTransform RectTransformImgTalentRedDot
		{
			[Token(Token = "0x6002AEF")]
			[Address(RVA = "0x3FE65C8", Offset = "0x3FE25C8", VA = "0x3FE65C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000457")]
		public TextMeshProUGUI TextMeshProUGUITxtName
		{
			[Token(Token = "0x6002AF0")]
			[Address(RVA = "0x3FE6690", Offset = "0x3FE2690", VA = "0x3FE6690")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000458")]
		public TextMeshProUGUI TextMeshProUGUITxtCardRare
		{
			[Token(Token = "0x6002AF1")]
			[Address(RVA = "0x3FE6758", Offset = "0x3FE2758", VA = "0x3FE6758")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000459")]
		public RectTransform RectTransformBtnAtkWayType
		{
			[Token(Token = "0x6002AF2")]
			[Address(RVA = "0x3FE6820", Offset = "0x3FE2820", VA = "0x3FE6820")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700045A")]
		public Image ImageBtnAtkWayType
		{
			[Token(Token = "0x6002AF3")]
			[Address(RVA = "0x3FE68E8", Offset = "0x3FE28E8", VA = "0x3FE68E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700045B")]
		public ButtonExtend ButtonExtendBtnAtkWayType
		{
			[Token(Token = "0x6002AF4")]
			[Address(RVA = "0x3FE69B0", Offset = "0x3FE29B0", VA = "0x3FE69B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700045C")]
		public Image ImageImgAtkWayTypeIcon
		{
			[Token(Token = "0x6002AF5")]
			[Address(RVA = "0x3FE6A78", Offset = "0x3FE2A78", VA = "0x3FE6A78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700045D")]
		public TextMeshProUGUI TextMeshProUGUITxtAtkWayType
		{
			[Token(Token = "0x6002AF6")]
			[Address(RVA = "0x3FE6B40", Offset = "0x3FE2B40", VA = "0x3FE6B40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700045E")]
		public RectTransform RectTransformBtnFetter
		{
			[Token(Token = "0x6002AF7")]
			[Address(RVA = "0x3FE6C08", Offset = "0x3FE2C08", VA = "0x3FE6C08")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700045F")]
		public Image ImageBtnFetter
		{
			[Token(Token = "0x6002AF8")]
			[Address(RVA = "0x3FE6CD0", Offset = "0x3FE2CD0", VA = "0x3FE6CD0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000460")]
		public ButtonExtend ButtonExtendBtnFetter
		{
			[Token(Token = "0x6002AF9")]
			[Address(RVA = "0x3FE6D98", Offset = "0x3FE2D98", VA = "0x3FE6D98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000461")]
		public Image ImageImgFetterIcon
		{
			[Token(Token = "0x6002AFA")]
			[Address(RVA = "0x3FE6E60", Offset = "0x3FE2E60", VA = "0x3FE6E60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000462")]
		public TextMeshProUGUI TextMeshProUGUITxtFetter
		{
			[Token(Token = "0x6002AFB")]
			[Address(RVA = "0x3FE6F28", Offset = "0x3FE2F28", VA = "0x3FE6F28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000463")]
		public Image ImageImgCpBg
		{
			[Token(Token = "0x6002AFC")]
			[Address(RVA = "0x3FE6FF0", Offset = "0x3FE2FF0", VA = "0x3FE6FF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000464")]
		public TextMeshProUGUI TextMeshProUGUITxtCardCPNum
		{
			[Token(Token = "0x6002AFD")]
			[Address(RVA = "0x3FE70B8", Offset = "0x3FE30B8", VA = "0x3FE70B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000465")]
		public TextMeshProUGUI TextMeshProUGUITxtLevel
		{
			[Token(Token = "0x6002AFE")]
			[Address(RVA = "0x3FE7180", Offset = "0x3FE3180", VA = "0x3FE7180")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000466")]
		public Image ImageImgProcessBG
		{
			[Token(Token = "0x6002AFF")]
			[Address(RVA = "0x3FE7248", Offset = "0x3FE3248", VA = "0x3FE7248")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000467")]
		public Image ImageImgProcess
		{
			[Token(Token = "0x6002B00")]
			[Address(RVA = "0x3FE7310", Offset = "0x3FE3310", VA = "0x3FE7310")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000468")]
		public TextMeshProUGUI TextMeshProUGUITxtCardCount
		{
			[Token(Token = "0x6002B01")]
			[Address(RVA = "0x3FE73D8", Offset = "0x3FE33D8", VA = "0x3FE73D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000469")]
		public RectTransform RectTransformGeneralCard
		{
			[Token(Token = "0x6002B02")]
			[Address(RVA = "0x3FE74A0", Offset = "0x3FE34A0", VA = "0x3FE74A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700046A")]
		public TextMeshProUGUI TextMeshProUGUIGeneralCardNumber
		{
			[Token(Token = "0x6002B03")]
			[Address(RVA = "0x3FE7568", Offset = "0x3FE3568", VA = "0x3FE7568")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700046B")]
		public Image ImageGeneralCardIcon
		{
			[Token(Token = "0x6002B04")]
			[Address(RVA = "0x3FE7630", Offset = "0x3FE3630", VA = "0x3FE7630")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700046C")]
		public ButtonExtend ButtonExtendGeneralCardBtn
		{
			[Token(Token = "0x6002B05")]
			[Address(RVA = "0x3FE76F8", Offset = "0x3FE36F8", VA = "0x3FE76F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700046D")]
		public RectTransform RectTransformImgPropetryBG
		{
			[Token(Token = "0x6002B06")]
			[Address(RVA = "0x3FE77C0", Offset = "0x3FE37C0", VA = "0x3FE77C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700046E")]
		public Image ImageImgPropetryBG
		{
			[Token(Token = "0x6002B07")]
			[Address(RVA = "0x3FE7888", Offset = "0x3FE3888", VA = "0x3FE7888")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700046F")]
		public ButtonExtend ButtonExtendBtnClose
		{
			[Token(Token = "0x6002B08")]
			[Address(RVA = "0x3FE7950", Offset = "0x3FE3950", VA = "0x3FE7950")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000470")]
		public RectTransform RectTransformImgOldAbilitiesBg
		{
			[Token(Token = "0x6002B09")]
			[Address(RVA = "0x3FE7A18", Offset = "0x3FE3A18", VA = "0x3FE7A18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000471")]
		public Image ImageImgOldAbilitiesBg
		{
			[Token(Token = "0x6002B0A")]
			[Address(RVA = "0x3FE7AE0", Offset = "0x3FE3AE0", VA = "0x3FE7AE0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000472")]
		public TextMeshProUGUI TextMeshProUGUITxtAbilities
		{
			[Token(Token = "0x6002B0B")]
			[Address(RVA = "0x3FE7BA8", Offset = "0x3FE3BA8", VA = "0x3FE7BA8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000473")]
		public RectTransform RectTransformImgTalentBg
		{
			[Token(Token = "0x6002B0C")]
			[Address(RVA = "0x3FE7C70", Offset = "0x3FE3C70", VA = "0x3FE7C70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000474")]
		public RectTransform RectTransformBtnUpgrade
		{
			[Token(Token = "0x6002B0D")]
			[Address(RVA = "0x3FE7D38", Offset = "0x3FE3D38", VA = "0x3FE7D38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000475")]
		public Image ImageBtnUpgrade
		{
			[Token(Token = "0x6002B0E")]
			[Address(RVA = "0x3FE7E00", Offset = "0x3FE3E00", VA = "0x3FE7E00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000476")]
		public ButtonExtend ButtonExtendBtnUpgrade
		{
			[Token(Token = "0x6002B0F")]
			[Address(RVA = "0x3FE7EC8", Offset = "0x3FE3EC8", VA = "0x3FE7EC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000477")]
		public TextMeshProUGUI TextMeshProUGUITxtUpgrade
		{
			[Token(Token = "0x6002B10")]
			[Address(RVA = "0x3FE7F90", Offset = "0x3FE3F90", VA = "0x3FE7F90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000478")]
		public TextMeshProUGUI TextMeshProUGUITxtCoinNum
		{
			[Token(Token = "0x6002B11")]
			[Address(RVA = "0x3FE8058", Offset = "0x3FE4058", VA = "0x3FE8058")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000479")]
		public RectTransform RectTransformImgUpgradeCardGreenArrow
		{
			[Token(Token = "0x6002B12")]
			[Address(RVA = "0x3FE8120", Offset = "0x3FE4120", VA = "0x3FE8120")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700047A")]
		public Image ImageBtnEquip
		{
			[Token(Token = "0x6002B13")]
			[Address(RVA = "0x3FE81E8", Offset = "0x3FE41E8", VA = "0x3FE81E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700047B")]
		public ButtonExtend ButtonExtendBtnEquip
		{
			[Token(Token = "0x6002B14")]
			[Address(RVA = "0x3FE82B0", Offset = "0x3FE42B0", VA = "0x3FE82B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700047C")]
		public TextMeshProUGUI TextMeshProUGUITxtEquip
		{
			[Token(Token = "0x6002B15")]
			[Address(RVA = "0x3FE8378", Offset = "0x3FE4378", VA = "0x3FE8378")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700047D")]
		public RectTransform RectTransformIntroBack
		{
			[Token(Token = "0x6002B16")]
			[Address(RVA = "0x3FE8440", Offset = "0x3FE4440", VA = "0x3FE8440")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700047E")]
		public RectTransform RectTransformIntroText
		{
			[Token(Token = "0x6002B17")]
			[Address(RVA = "0x3FE8508", Offset = "0x3FE4508", VA = "0x3FE8508")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700047F")]
		public TextMeshProUGUI TextMeshProUGUIIntroText
		{
			[Token(Token = "0x6002B18")]
			[Address(RVA = "0x3FE85D0", Offset = "0x3FE45D0", VA = "0x3FE85D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000480")]
		public Image ImageImgLockedBg
		{
			[Token(Token = "0x6002B19")]
			[Address(RVA = "0x3FE8698", Offset = "0x3FE4698", VA = "0x3FE8698")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000481")]
		public ButtonExtend ButtonExtendBtnGoGet
		{
			[Token(Token = "0x6002B1A")]
			[Address(RVA = "0x3FE8760", Offset = "0x3FE4760", VA = "0x3FE8760")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002B1B")]
		[Address(RVA = "0x3FE8828", Offset = "0x3FE4828", VA = "0x3FE8828")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6002B1C")]
		[Address(RVA = "0x3FE8B1C", Offset = "0x3FE4B1C", VA = "0x3FE8B1C", Slot = "12")]
		protected virtual void OnButtonBGClicked()
		{
		}

		[Token(Token = "0x6002B1D")]
		[Address(RVA = "0x3FE8B88", Offset = "0x3FE4B88", VA = "0x3FE8B88", Slot = "13")]
		protected virtual void OnButtonBtnRoleClicked()
		{
		}

		[Token(Token = "0x6002B1E")]
		[Address(RVA = "0x3FE8BF4", Offset = "0x3FE4BF4", VA = "0x3FE8BF4", Slot = "14")]
		protected virtual void OnButtonBtnTowerClicked()
		{
		}

		[Token(Token = "0x6002B1F")]
		[Address(RVA = "0x3FE8C60", Offset = "0x3FE4C60", VA = "0x3FE8C60", Slot = "15")]
		protected virtual void OnButtonExtendBtnAtkWayTypeClicked()
		{
		}

		[Token(Token = "0x6002B20")]
		[Address(RVA = "0x3FE8CCC", Offset = "0x3FE4CCC", VA = "0x3FE8CCC", Slot = "16")]
		protected virtual void OnButtonExtendBtnFetterClicked()
		{
		}

		[Token(Token = "0x6002B21")]
		[Address(RVA = "0x3FE8D38", Offset = "0x3FE4D38", VA = "0x3FE8D38", Slot = "17")]
		protected virtual void OnButtonExtendGeneralCardBtnClicked()
		{
		}

		[Token(Token = "0x6002B22")]
		[Address(RVA = "0x3FE8DA4", Offset = "0x3FE4DA4", VA = "0x3FE8DA4", Slot = "18")]
		protected virtual void OnButtonExtendBtnCloseClicked()
		{
		}

		[Token(Token = "0x6002B23")]
		[Address(RVA = "0x3FE8E10", Offset = "0x3FE4E10", VA = "0x3FE8E10", Slot = "19")]
		protected virtual void OnButtonExtendBtnUpgradeClicked()
		{
		}

		[Token(Token = "0x6002B24")]
		[Address(RVA = "0x3FE8E7C", Offset = "0x3FE4E7C", VA = "0x3FE8E7C", Slot = "20")]
		protected virtual void OnButtonExtendBtnEquipClicked()
		{
		}

		[Token(Token = "0x6002B25")]
		[Address(RVA = "0x3FE8EE8", Offset = "0x3FE4EE8", VA = "0x3FE8EE8", Slot = "21")]
		protected virtual void OnButtonExtendBtnGoGetClicked()
		{
		}

		[Token(Token = "0x6002B26")]
		[Address(RVA = "0x3FE8F54", Offset = "0x3FE4F54", VA = "0x3FE8F54", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002B27")]
		[Address(RVA = "0x3FE8F70", Offset = "0x3FE4F70", VA = "0x3FE8F70", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__570))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002B28")]
		[Address(RVA = "0x3FE9004", Offset = "0x3FE5004", VA = "0x3FE9004", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6002B29")]
		[Address(RVA = "0x3FE90B8", Offset = "0x3FE50B8", VA = "0x3FE90B8")]
		public UpgradeCardPanelComponents()
		{
		}
	}
}
