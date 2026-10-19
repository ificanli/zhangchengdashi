using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000A24")]
	public class MysteryAdventurePanelView : MonoBehaviour
	{
		[Token(Token = "0x4004B2D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _bgImage;

		[Token(Token = "0x4004B2E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI _countdownText;

		[Token(Token = "0x4004B2F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Button _closeButton;

		[Token(Token = "0x4004B30")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Button _rulesButton;

		[Token(Token = "0x4004B31")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _progressSection;

		[Token(Token = "0x4004B32")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _progressPanelBg;

		[Token(Token = "0x4004B33")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _progressFillImage;

		[Token(Token = "0x4004B34")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TextMeshProUGUI _lapCountText;

		[Token(Token = "0x4004B35")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _sideDailyTaskIcon;

		[Token(Token = "0x4004B36")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private TextMeshProUGUI _sideDailyTaskLabel;

		[Token(Token = "0x4004B37")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _sideDailyTaskRedDot;

		[Token(Token = "0x4004B38")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Image _sideDailyGiftIcon;

		[Token(Token = "0x4004B39")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private TextMeshProUGUI _sideDailyGiftLabel;

		[Token(Token = "0x4004B3A")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _sideDailyGiftRedDot;

		[Token(Token = "0x4004B3B")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _sideDiscountShopRoot;

		[Token(Token = "0x4004B3C")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Image _sideDiscountShopIcon;

		[Token(Token = "0x4004B3D")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private TextMeshProUGUI _sideDiscountShopLabel;

		[Token(Token = "0x4004B3E")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private RectTransform _boardArea;

		[Token(Token = "0x4004B3F")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Image _centerLapProgress;

		[Token(Token = "0x4004B40")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Slider _centerLapProgressSlider;

		[Token(Token = "0x4004B41")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private TextMeshProUGUI _centerLapText;

		[Token(Token = "0x4004B42")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private TextMeshProUGUI _centerLevelText;

		[Token(Token = "0x4004B43")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private TextMeshProUGUI _lapProgressText;

		[Token(Token = "0x4004B44")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private MysteryAdventureBoardCellView[] _cells;

		[Token(Token = "0x4004B45")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private RectTransform _playerToken;

		[Token(Token = "0x4004B46")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private Image _playerTokenImage;

		[Token(Token = "0x4004B47")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private Image _footerBg;

		[Token(Token = "0x4004B48")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private TextMeshProUGUI _recoverText;

		[Token(Token = "0x4004B49")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private TextMeshProUGUI _diceInfoText;

		[Token(Token = "0x4004B4A")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private TextMeshProUGUI _diceResultText;

		[Token(Token = "0x4004B4B")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private TextMeshProUGUI _toastText;

		[Token(Token = "0x4004B4C")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private Button _rollButton;

		[Token(Token = "0x4004B4D")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private Image _rollButtonBg;

		[Token(Token = "0x4004B4E")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private Image _rollButtonCircle;

		[Token(Token = "0x4004B4F")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private Image _rollDiceIcon;

		[Token(Token = "0x4004B50")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private MysteryAdventureDiceEffectView _diceEffect;

		[Token(Token = "0x4004B51")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private MysteryAdventurePanelEffectView _panelEffect;

		[Token(Token = "0x4004B52")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		private Toggle _tenRollToggle;

		[Token(Token = "0x4004B53")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		private Toggle _autoRollToggle;

		[Token(Token = "0x4004B54")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		private Toggle _skipAnimToggle;

		[Token(Token = "0x4004B55")]
		[FieldOffset(Offset = "0x160")]
		[SerializeField]
		[Header("累计投骰轨道")]
		private ScrollRect _totalDiceScrollRect;

		[Token(Token = "0x4004B56")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		private RectTransform _totalDiceContent;

		[Token(Token = "0x4004B57")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		private RectTransform _totalDiceItemsContainer;

		[Token(Token = "0x4004B58")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		private Image _totalDiceTrackBg;

		[Token(Token = "0x4004B59")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		private Image _totalDiceTrackFill;

		[Token(Token = "0x4004B5A")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		private TextMeshProUGUI _totalDiceConsumedText;

		[Token(Token = "0x4004B5B")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		private MysteryAdventureTotalDiceMilestoneItem _milestoneItemTemplate;

		[Token(Token = "0x4004B5C")]
		[FieldOffset(Offset = "0x198")]
		[SerializeField]
		[Header("棋子跳跃动画")]
		private MysteryAdventureBoardMoveSettings _boardMoveSettings;

		[Token(Token = "0x170008FF")]
		public Image BgImage
		{
			[Token(Token = "0x6003C52")]
			[Address(RVA = "0x41490D0", Offset = "0x41450D0", VA = "0x41490D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000900")]
		public TextMeshProUGUI CountdownText
		{
			[Token(Token = "0x6003C53")]
			[Address(RVA = "0x41490D8", Offset = "0x41450D8", VA = "0x41490D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000901")]
		public Button CloseButton
		{
			[Token(Token = "0x6003C54")]
			[Address(RVA = "0x41490E0", Offset = "0x41450E0", VA = "0x41490E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000902")]
		public Button RulesButton
		{
			[Token(Token = "0x6003C55")]
			[Address(RVA = "0x41490E8", Offset = "0x41450E8", VA = "0x41490E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000903")]
		public GameObject ProgressSection
		{
			[Token(Token = "0x6003C56")]
			[Address(RVA = "0x41490F0", Offset = "0x41450F0", VA = "0x41490F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000904")]
		public Image ProgressPanelBg
		{
			[Token(Token = "0x6003C57")]
			[Address(RVA = "0x41490F8", Offset = "0x41450F8", VA = "0x41490F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000905")]
		public Image ProgressFillImage
		{
			[Token(Token = "0x6003C58")]
			[Address(RVA = "0x4149100", Offset = "0x4145100", VA = "0x4149100")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000906")]
		public TextMeshProUGUI LapCountText
		{
			[Token(Token = "0x6003C59")]
			[Address(RVA = "0x4149108", Offset = "0x4145108", VA = "0x4149108")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000907")]
		public Image SideDailyTaskIcon
		{
			[Token(Token = "0x6003C5A")]
			[Address(RVA = "0x4149110", Offset = "0x4145110", VA = "0x4149110")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000908")]
		public TextMeshProUGUI SideDailyTaskLabel
		{
			[Token(Token = "0x6003C5B")]
			[Address(RVA = "0x4149118", Offset = "0x4145118", VA = "0x4149118")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000909")]
		public GameObject SideDailyTaskRedDot
		{
			[Token(Token = "0x6003C5C")]
			[Address(RVA = "0x4149120", Offset = "0x4145120", VA = "0x4149120")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700090A")]
		public Image SideDailyGiftIcon
		{
			[Token(Token = "0x6003C5D")]
			[Address(RVA = "0x4149128", Offset = "0x4145128", VA = "0x4149128")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700090B")]
		public TextMeshProUGUI SideDailyGiftLabel
		{
			[Token(Token = "0x6003C5E")]
			[Address(RVA = "0x4149130", Offset = "0x4145130", VA = "0x4149130")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700090C")]
		public GameObject SideDailyGiftRedDot
		{
			[Token(Token = "0x6003C5F")]
			[Address(RVA = "0x4149138", Offset = "0x4145138", VA = "0x4149138")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700090D")]
		public GameObject SideDiscountShopRoot
		{
			[Token(Token = "0x6003C60")]
			[Address(RVA = "0x4149140", Offset = "0x4145140", VA = "0x4149140")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700090E")]
		public Image SideDiscountShopIcon
		{
			[Token(Token = "0x6003C61")]
			[Address(RVA = "0x4149148", Offset = "0x4145148", VA = "0x4149148")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700090F")]
		public TextMeshProUGUI SideDiscountShopLabel
		{
			[Token(Token = "0x6003C62")]
			[Address(RVA = "0x4149150", Offset = "0x4145150", VA = "0x4149150")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000910")]
		public RectTransform BoardArea
		{
			[Token(Token = "0x6003C63")]
			[Address(RVA = "0x4149158", Offset = "0x4145158", VA = "0x4149158")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000911")]
		public Image CenterLapProgress
		{
			[Token(Token = "0x6003C64")]
			[Address(RVA = "0x4149160", Offset = "0x4145160", VA = "0x4149160")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000912")]
		public Slider CenterLapProgressSlider
		{
			[Token(Token = "0x6003C65")]
			[Address(RVA = "0x4149168", Offset = "0x4145168", VA = "0x4149168")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000913")]
		public TextMeshProUGUI CenterLapText
		{
			[Token(Token = "0x6003C66")]
			[Address(RVA = "0x4149170", Offset = "0x4145170", VA = "0x4149170")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000914")]
		public TextMeshProUGUI CenterLevelText
		{
			[Token(Token = "0x6003C67")]
			[Address(RVA = "0x4149178", Offset = "0x4145178", VA = "0x4149178")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000915")]
		public TextMeshProUGUI LapProgressText
		{
			[Token(Token = "0x6003C68")]
			[Address(RVA = "0x4149180", Offset = "0x4145180", VA = "0x4149180")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000916")]
		public MysteryAdventureBoardCellView[] Cells
		{
			[Token(Token = "0x6003C69")]
			[Address(RVA = "0x4149188", Offset = "0x4145188", VA = "0x4149188")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000917")]
		public RectTransform PlayerToken
		{
			[Token(Token = "0x6003C6A")]
			[Address(RVA = "0x4149190", Offset = "0x4145190", VA = "0x4149190")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000918")]
		public Image PlayerTokenImage
		{
			[Token(Token = "0x6003C6B")]
			[Address(RVA = "0x4149198", Offset = "0x4145198", VA = "0x4149198")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000919")]
		public Image FooterBg
		{
			[Token(Token = "0x6003C6C")]
			[Address(RVA = "0x41491A0", Offset = "0x41451A0", VA = "0x41491A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700091A")]
		public TextMeshProUGUI RecoverText
		{
			[Token(Token = "0x6003C6D")]
			[Address(RVA = "0x41491A8", Offset = "0x41451A8", VA = "0x41491A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700091B")]
		public TextMeshProUGUI DiceInfoText
		{
			[Token(Token = "0x6003C6E")]
			[Address(RVA = "0x41491B0", Offset = "0x41451B0", VA = "0x41491B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700091C")]
		public TextMeshProUGUI DiceResultText
		{
			[Token(Token = "0x6003C6F")]
			[Address(RVA = "0x41491B8", Offset = "0x41451B8", VA = "0x41491B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700091D")]
		public TextMeshProUGUI ToastText
		{
			[Token(Token = "0x6003C70")]
			[Address(RVA = "0x41491C0", Offset = "0x41451C0", VA = "0x41491C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700091E")]
		public Button RollButton
		{
			[Token(Token = "0x6003C71")]
			[Address(RVA = "0x41491C8", Offset = "0x41451C8", VA = "0x41491C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700091F")]
		public Image RollButtonBg
		{
			[Token(Token = "0x6003C72")]
			[Address(RVA = "0x41491D0", Offset = "0x41451D0", VA = "0x41491D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000920")]
		public Image RollButtonCircle
		{
			[Token(Token = "0x6003C73")]
			[Address(RVA = "0x41491D8", Offset = "0x41451D8", VA = "0x41491D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000921")]
		public Image RollDiceIcon
		{
			[Token(Token = "0x6003C74")]
			[Address(RVA = "0x41491E0", Offset = "0x41451E0", VA = "0x41491E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000922")]
		public MysteryAdventureDiceEffectView DiceEffect
		{
			[Token(Token = "0x6003C75")]
			[Address(RVA = "0x41491E8", Offset = "0x41451E8", VA = "0x41491E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000923")]
		public MysteryAdventurePanelEffectView PanelEffect
		{
			[Token(Token = "0x6003C76")]
			[Address(RVA = "0x41491F0", Offset = "0x41451F0", VA = "0x41491F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000924")]
		public Toggle TenRollToggle
		{
			[Token(Token = "0x6003C79")]
			[Address(RVA = "0x41492E0", Offset = "0x41452E0", VA = "0x41492E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000925")]
		public Toggle AutoRollToggle
		{
			[Token(Token = "0x6003C7A")]
			[Address(RVA = "0x41492E8", Offset = "0x41452E8", VA = "0x41492E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000926")]
		public Toggle SkipAnimToggle
		{
			[Token(Token = "0x6003C7B")]
			[Address(RVA = "0x41492F0", Offset = "0x41452F0", VA = "0x41492F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000927")]
		public ScrollRect TotalDiceScrollRect
		{
			[Token(Token = "0x6003C81")]
			[Address(RVA = "0x414950C", Offset = "0x414550C", VA = "0x414950C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000928")]
		public RectTransform TotalDiceContent
		{
			[Token(Token = "0x6003C82")]
			[Address(RVA = "0x4149514", Offset = "0x4145514", VA = "0x4149514")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000929")]
		public RectTransform TotalDiceItemsContainer
		{
			[Token(Token = "0x6003C83")]
			[Address(RVA = "0x414951C", Offset = "0x414551C", VA = "0x414951C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700092A")]
		public Image TotalDiceTrackBg
		{
			[Token(Token = "0x6003C84")]
			[Address(RVA = "0x4149524", Offset = "0x4145524", VA = "0x4149524")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700092B")]
		public Image TotalDiceTrackFill
		{
			[Token(Token = "0x6003C85")]
			[Address(RVA = "0x414952C", Offset = "0x414552C", VA = "0x414952C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700092C")]
		public TextMeshProUGUI TotalDiceConsumedText
		{
			[Token(Token = "0x6003C86")]
			[Address(RVA = "0x4149534", Offset = "0x4145534", VA = "0x4149534")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700092D")]
		public MysteryAdventureTotalDiceMilestoneItem MilestoneItemTemplate
		{
			[Token(Token = "0x6003C87")]
			[Address(RVA = "0x414953C", Offset = "0x414553C", VA = "0x414953C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700092E")]
		public MysteryAdventureBoardMoveSettings BoardMoveSettings
		{
			[Token(Token = "0x6003C8F")]
			[Address(RVA = "0x414957C", Offset = "0x414557C", VA = "0x414957C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003C77")]
		[Address(RVA = "0x41491F8", Offset = "0x41451F8", VA = "0x41491F8")]
		internal void RegisterDiceEffect(MysteryAdventureDiceEffectView effect)
		{
		}

		[Token(Token = "0x6003C78")]
		[Address(RVA = "0x414926C", Offset = "0x414526C", VA = "0x414926C")]
		internal void RegisterPanelEffect(MysteryAdventurePanelEffectView effect)
		{
		}

		[Token(Token = "0x6003C7C")]
		[Address(RVA = "0x41492F8", Offset = "0x41452F8", VA = "0x41492F8")]
		internal void BindTenRollToggle(Toggle toggle)
		{
		}

		[Token(Token = "0x6003C7D")]
		[Address(RVA = "0x4149300", Offset = "0x4145300", VA = "0x4149300")]
		internal void BindSideDiscountShopRoot(GameObject root)
		{
		}

		[Token(Token = "0x6003C7E")]
		[Address(RVA = "0x4149308", Offset = "0x4145308", VA = "0x4149308")]
		internal void BindSideDiscountShopIcon(Image icon)
		{
		}

		[Token(Token = "0x6003C7F")]
		[Address(RVA = "0x4149310", Offset = "0x4145310", VA = "0x4149310")]
		internal void BindSideDiscountShopLabel(TextMeshProUGUI label)
		{
		}

		[Token(Token = "0x6003C80")]
		[Address(RVA = "0x4149318", Offset = "0x4145318", VA = "0x4149318")]
		public void EnsureSideDiscountShopBindings()
		{
		}

		[Token(Token = "0x6003C88")]
		[Address(RVA = "0x4149544", Offset = "0x4145544", VA = "0x4149544")]
		internal void BindTotalDiceScrollRect(ScrollRect scrollRect)
		{
		}

		[Token(Token = "0x6003C89")]
		[Address(RVA = "0x414954C", Offset = "0x414554C", VA = "0x414954C")]
		internal void BindTotalDiceContent(RectTransform content)
		{
		}

		[Token(Token = "0x6003C8A")]
		[Address(RVA = "0x4149554", Offset = "0x4145554", VA = "0x4149554")]
		internal void BindTotalDiceItemsContainer(RectTransform container)
		{
		}

		[Token(Token = "0x6003C8B")]
		[Address(RVA = "0x414955C", Offset = "0x414555C", VA = "0x414955C")]
		internal void BindTotalDiceTrackBg(Image trackBg)
		{
		}

		[Token(Token = "0x6003C8C")]
		[Address(RVA = "0x4149564", Offset = "0x4145564", VA = "0x4149564")]
		internal void BindTotalDiceTrackFill(Image trackFill)
		{
		}

		[Token(Token = "0x6003C8D")]
		[Address(RVA = "0x414956C", Offset = "0x414556C", VA = "0x414956C")]
		internal void BindTotalDiceConsumedText(TextMeshProUGUI text)
		{
		}

		[Token(Token = "0x6003C8E")]
		[Address(RVA = "0x4149574", Offset = "0x4145574", VA = "0x4149574")]
		internal void BindMilestoneItemTemplate(MysteryAdventureTotalDiceMilestoneItem template)
		{
		}

		[Token(Token = "0x6003C90")]
		[Address(RVA = "0x414959C", Offset = "0x414559C", VA = "0x414959C")]
		public void EnsureDiceUiBindings()
		{
		}

		[Token(Token = "0x6003C91")]
		[Address(RVA = "0x4149700", Offset = "0x4145700", VA = "0x4149700")]
		public void EnsureSideEntryRedDotBindings()
		{
		}

		[Token(Token = "0x6003C92")]
		[Address(RVA = "0x4149724", Offset = "0x4145724", VA = "0x4149724")]
		private static void BindSideEntryRedDotIfMissing(ref GameObject redDot, Image icon)
		{
		}

		[Token(Token = "0x6003C93")]
		private static void BindIfNull<T>(ref T field, T candidate) where T : class
		{
		}

		[Token(Token = "0x6003C94")]
		[Address(RVA = "0x4149844", Offset = "0x4145844", VA = "0x4149844")]
		public MysteryAdventurePanelView()
		{
		}
	}
}
