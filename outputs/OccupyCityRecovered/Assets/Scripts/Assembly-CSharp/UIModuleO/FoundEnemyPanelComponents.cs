using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using Spine.Unity;
using TMPro;
using UIFramework;
using UIModuleO.UIAnim;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000892")]
	public class FoundEnemyPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000893")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__1005 : IAsyncStateMachine
		{
			[Token(Token = "0x40040F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40040F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40040F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public FoundEnemyPanelComponents _003C_003E4__this;

			[Token(Token = "0x40040F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6003076")]
			[Address(RVA = "0x404CFBC", Offset = "0x4048FBC", VA = "0x404CFBC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003077")]
			[Address(RVA = "0x404D234", Offset = "0x4049234", VA = "0x404D234", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40040B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RectTransform _rectTransformPage2;

		[Token(Token = "0x40040B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Image _imageCloudBG;

		[Token(Token = "0x40040B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RectTransform _rectTransformLeftClouds_Layer1;

		[Token(Token = "0x40040B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private RectTransform _rectTransformRightClouds_Layer1;

		[Token(Token = "0x40040B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private RectTransform _rectTransformRightClouds_Layer2;

		[Token(Token = "0x40040B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private RectTransform _rectTransformLeftClouds_Layer2;

		[Token(Token = "0x40040B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RectTransform _rectTransformRightClouds_Layer3;

		[Token(Token = "0x40040BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private RectTransform _rectTransformLeftClouds_Layer3;

		[Token(Token = "0x40040BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private ButtonExtend _buttonExtendRawImage;

		[Token(Token = "0x40040BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private RectTransform _rectTransformPage1;

		[Token(Token = "0x40040BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private RectTransform _rectTransformOtherParnet;

		[Token(Token = "0x40040BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private TextMeshProUGUI _textMeshProUGUITxtDes;

		[Token(Token = "0x40040BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private RectTransform _rectTransformImgCircle;

		[Token(Token = "0x40040C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private ScrollRect _scrollRectTipScrollView;

		[Token(Token = "0x40040C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private RectTransform _rectTransformContent;

		[Token(Token = "0x40040C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private TextMeshProUGUI _textMeshProUGUITxtTipTitle;

		[Token(Token = "0x40040C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private ButtonExtend _buttonExtendBtnTipLeft;

		[Token(Token = "0x40040C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private ButtonExtend _buttonExtendBtnTipRight;

		[Token(Token = "0x40040C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private RectTransform _rectTransformBannerParent;

		[Token(Token = "0x40040C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private RectTransform _rectTransformImgBotBG;

		[Token(Token = "0x40040C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Image _imagePlayerBanner;

		[Token(Token = "0x40040C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private AvatarItem _avatarItemPlayerAvatarItem;

		[Token(Token = "0x40040C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private TextMeshProUGUI _textMeshProUGUITxtBotName;

		[Token(Token = "0x40040CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private TextMeshProUGUI _textMeshProUGUITxtPlayerCoinNum;

		[Token(Token = "0x40040CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private RectTransform _rectTransformTxtPlayerCP;

		[Token(Token = "0x40040CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private TextMeshProUGUI _textMeshProUGUITxtPlayerCP;

		[Token(Token = "0x40040CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private TextMeshProUGUI _textMeshProUGUITxtPlayerCPNum;

		[Token(Token = "0x40040CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Image _imageImgBotDanIcon;

		[Token(Token = "0x40040CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private TextMeshProUGUI _textMeshProUGUITxtBotDanName;

		[Token(Token = "0x40040D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private RectTransform _rectTransformImgBotTrophyIcon;

		[Token(Token = "0x40040D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private TextMeshProUGUI _textMeshProUGUITxtBotTrophyNum;

		[Token(Token = "0x40040D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private TextMeshProUGUI _textMeshProUGUITxtPlayerMorale;

		[Token(Token = "0x40040D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private RectTransform _rectTransformFetterItemBotRoot;

		[Token(Token = "0x40040D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Image _imageImgPlayerPropIcon;

		[Token(Token = "0x40040D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private TextMeshProUGUI _textMeshProUGUITxtPlayerPropName;

		[Token(Token = "0x40040D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Image _imageImgPlayerBlessBg;

		[Token(Token = "0x40040D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Image _imageImgPlayerBlessIcon;

		[Token(Token = "0x40040D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private RectTransform _rectTransformImgTopBG;

		[Token(Token = "0x40040D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private RectTransform _rectTransformImgTopRedEffBg_1;

		[Token(Token = "0x40040DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private RectTransform _rectTransformImgTopRedEffBg_2;

		[Token(Token = "0x40040DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private RectTransform _rectTransformImgTopRedEffBg_3;

		[Token(Token = "0x40040DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private RectTransform _rectTransformImgTopInfoBg;

		[Token(Token = "0x40040DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private Image _imageEnemyBanner;

		[Token(Token = "0x40040DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private Image _imageImgTopIcon;

		[Token(Token = "0x40040DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private AvatarItem _avatarItemEnemyAvatarItem;

		[Token(Token = "0x40040E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private Image _imageImgTopPropIcon;

		[Token(Token = "0x40040E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private TextMeshProUGUI _textMeshProUGUITxtTopPropName;

		[Token(Token = "0x40040E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private TextMeshProUGUI _textMeshProUGUITxtTopName;

		[Token(Token = "0x40040E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private TextMeshProUGUI _textMeshProUGUITxtEnemyCoinNum;

		[Token(Token = "0x40040E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private RectTransform _rectTransformTxtEnemyCPNum;

		[Token(Token = "0x40040E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private TextMeshProUGUI _textMeshProUGUITxtEnemyCPNum;

		[Token(Token = "0x40040E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private TextMeshProUGUI _textMeshProUGUITxtEnemyCP;

		[Token(Token = "0x40040E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private RectTransform _rectTransformFetterEnemyItemBotRoot;

		[Token(Token = "0x40040E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private Image _imageImgTopDanIcon;

		[Token(Token = "0x40040E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private TextMeshProUGUI _textMeshProUGUITxtTopDanName;

		[Token(Token = "0x40040EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private RectTransform _rectTransformImgTopTrophyIcon;

		[Token(Token = "0x40040EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private TextMeshProUGUI _textMeshProUGUITxtTopTrophyNum;

		[Token(Token = "0x40040EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private TextMeshProUGUI _textMeshProUGUITxtEnemyMorale;

		[Token(Token = "0x40040ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private Image _imageImgEnemyBlessBg;

		[Token(Token = "0x40040EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private Image _imageImgEnemyBlessIcon;

		[Token(Token = "0x40040EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private RectTransform _rectTransformVsSkeletonGraphic;

		[Token(Token = "0x40040F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private SkeletonGraphic _skeletonGraphicVsSkeletonGraphic;

		[Token(Token = "0x40040F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private RectTransform _rectTransformTxtCutDown;

		[Token(Token = "0x40040F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		private TextMeshProUGUI _textMeshProUGUITxtCutDown;

		[Token(Token = "0x40040F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private RectTransform _rectTransformImgLoupeIcon;

		[Token(Token = "0x170005AB")]
		public RectTransform RectTransformPage2
		{
			[Token(Token = "0x600302B")]
			[Address(RVA = "0x4049804", Offset = "0x4045804", VA = "0x4049804")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005AC")]
		public Image ImageCloudBG
		{
			[Token(Token = "0x600302C")]
			[Address(RVA = "0x40498CC", Offset = "0x40458CC", VA = "0x40498CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005AD")]
		public RectTransform RectTransformLeftClouds_Layer1
		{
			[Token(Token = "0x600302D")]
			[Address(RVA = "0x4049994", Offset = "0x4045994", VA = "0x4049994")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005AE")]
		public RectTransform RectTransformRightClouds_Layer1
		{
			[Token(Token = "0x600302E")]
			[Address(RVA = "0x4049A5C", Offset = "0x4045A5C", VA = "0x4049A5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005AF")]
		public RectTransform RectTransformRightClouds_Layer2
		{
			[Token(Token = "0x600302F")]
			[Address(RVA = "0x4049B24", Offset = "0x4045B24", VA = "0x4049B24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005B0")]
		public RectTransform RectTransformLeftClouds_Layer2
		{
			[Token(Token = "0x6003030")]
			[Address(RVA = "0x4049BEC", Offset = "0x4045BEC", VA = "0x4049BEC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005B1")]
		public RectTransform RectTransformRightClouds_Layer3
		{
			[Token(Token = "0x6003031")]
			[Address(RVA = "0x4049CB4", Offset = "0x4045CB4", VA = "0x4049CB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005B2")]
		public RectTransform RectTransformLeftClouds_Layer3
		{
			[Token(Token = "0x6003032")]
			[Address(RVA = "0x4049D7C", Offset = "0x4045D7C", VA = "0x4049D7C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005B3")]
		public ButtonExtend ButtonExtendRawImage
		{
			[Token(Token = "0x6003033")]
			[Address(RVA = "0x4049E44", Offset = "0x4045E44", VA = "0x4049E44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005B4")]
		public RectTransform RectTransformPage1
		{
			[Token(Token = "0x6003034")]
			[Address(RVA = "0x4049F0C", Offset = "0x4045F0C", VA = "0x4049F0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005B5")]
		public RectTransform RectTransformOtherParnet
		{
			[Token(Token = "0x6003035")]
			[Address(RVA = "0x4049FD4", Offset = "0x4045FD4", VA = "0x4049FD4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005B6")]
		public TextMeshProUGUI TextMeshProUGUITxtDes
		{
			[Token(Token = "0x6003036")]
			[Address(RVA = "0x404A09C", Offset = "0x404609C", VA = "0x404A09C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005B7")]
		public RectTransform RectTransformImgCircle
		{
			[Token(Token = "0x6003037")]
			[Address(RVA = "0x404A164", Offset = "0x4046164", VA = "0x404A164")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005B8")]
		public ScrollRect ScrollRectTipScrollView
		{
			[Token(Token = "0x6003038")]
			[Address(RVA = "0x404A22C", Offset = "0x404622C", VA = "0x404A22C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005B9")]
		public RectTransform RectTransformContent
		{
			[Token(Token = "0x6003039")]
			[Address(RVA = "0x404A2F4", Offset = "0x40462F4", VA = "0x404A2F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005BA")]
		public TextMeshProUGUI TextMeshProUGUITxtTipTitle
		{
			[Token(Token = "0x600303A")]
			[Address(RVA = "0x404A3BC", Offset = "0x40463BC", VA = "0x404A3BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005BB")]
		public ButtonExtend ButtonExtendBtnTipLeft
		{
			[Token(Token = "0x600303B")]
			[Address(RVA = "0x404A484", Offset = "0x4046484", VA = "0x404A484")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005BC")]
		public ButtonExtend ButtonExtendBtnTipRight
		{
			[Token(Token = "0x600303C")]
			[Address(RVA = "0x404A54C", Offset = "0x404654C", VA = "0x404A54C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005BD")]
		public RectTransform RectTransformBannerParent
		{
			[Token(Token = "0x600303D")]
			[Address(RVA = "0x404A614", Offset = "0x4046614", VA = "0x404A614")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005BE")]
		public RectTransform RectTransformImgBotBG
		{
			[Token(Token = "0x600303E")]
			[Address(RVA = "0x404A6DC", Offset = "0x40466DC", VA = "0x404A6DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005BF")]
		public Image ImagePlayerBanner
		{
			[Token(Token = "0x600303F")]
			[Address(RVA = "0x404A7A4", Offset = "0x40467A4", VA = "0x404A7A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005C0")]
		public AvatarItem AvatarItemPlayerAvatarItem
		{
			[Token(Token = "0x6003040")]
			[Address(RVA = "0x404A86C", Offset = "0x404686C", VA = "0x404A86C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005C1")]
		public TextMeshProUGUI TextMeshProUGUITxtBotName
		{
			[Token(Token = "0x6003041")]
			[Address(RVA = "0x404A934", Offset = "0x4046934", VA = "0x404A934")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005C2")]
		public TextMeshProUGUI TextMeshProUGUITxtPlayerCoinNum
		{
			[Token(Token = "0x6003042")]
			[Address(RVA = "0x404A9FC", Offset = "0x40469FC", VA = "0x404A9FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005C3")]
		public RectTransform RectTransformTxtPlayerCP
		{
			[Token(Token = "0x6003043")]
			[Address(RVA = "0x404AAC4", Offset = "0x4046AC4", VA = "0x404AAC4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005C4")]
		public TextMeshProUGUI TextMeshProUGUITxtPlayerCP
		{
			[Token(Token = "0x6003044")]
			[Address(RVA = "0x404AB8C", Offset = "0x4046B8C", VA = "0x404AB8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005C5")]
		public TextMeshProUGUI TextMeshProUGUITxtPlayerCPNum
		{
			[Token(Token = "0x6003045")]
			[Address(RVA = "0x404AC54", Offset = "0x4046C54", VA = "0x404AC54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005C6")]
		public Image ImageImgBotDanIcon
		{
			[Token(Token = "0x6003046")]
			[Address(RVA = "0x404AD1C", Offset = "0x4046D1C", VA = "0x404AD1C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005C7")]
		public TextMeshProUGUI TextMeshProUGUITxtBotDanName
		{
			[Token(Token = "0x6003047")]
			[Address(RVA = "0x404ADE4", Offset = "0x4046DE4", VA = "0x404ADE4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005C8")]
		public RectTransform RectTransformImgBotTrophyIcon
		{
			[Token(Token = "0x6003048")]
			[Address(RVA = "0x404AEAC", Offset = "0x4046EAC", VA = "0x404AEAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005C9")]
		public TextMeshProUGUI TextMeshProUGUITxtBotTrophyNum
		{
			[Token(Token = "0x6003049")]
			[Address(RVA = "0x404AF74", Offset = "0x4046F74", VA = "0x404AF74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005CA")]
		public TextMeshProUGUI TextMeshProUGUITxtPlayerMorale
		{
			[Token(Token = "0x600304A")]
			[Address(RVA = "0x404B03C", Offset = "0x404703C", VA = "0x404B03C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005CB")]
		public RectTransform RectTransformFetterItemBotRoot
		{
			[Token(Token = "0x600304B")]
			[Address(RVA = "0x404B104", Offset = "0x4047104", VA = "0x404B104")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005CC")]
		public Image ImageImgPlayerPropIcon
		{
			[Token(Token = "0x600304C")]
			[Address(RVA = "0x404B1CC", Offset = "0x40471CC", VA = "0x404B1CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005CD")]
		public TextMeshProUGUI TextMeshProUGUITxtPlayerPropName
		{
			[Token(Token = "0x600304D")]
			[Address(RVA = "0x404B294", Offset = "0x4047294", VA = "0x404B294")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005CE")]
		public Image ImageImgPlayerBlessBg
		{
			[Token(Token = "0x600304E")]
			[Address(RVA = "0x404B35C", Offset = "0x404735C", VA = "0x404B35C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005CF")]
		public Image ImageImgPlayerBlessIcon
		{
			[Token(Token = "0x600304F")]
			[Address(RVA = "0x404B424", Offset = "0x4047424", VA = "0x404B424")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005D0")]
		public RectTransform RectTransformImgTopBG
		{
			[Token(Token = "0x6003050")]
			[Address(RVA = "0x404B4EC", Offset = "0x40474EC", VA = "0x404B4EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005D1")]
		public RectTransform RectTransformImgTopRedEffBg_1
		{
			[Token(Token = "0x6003051")]
			[Address(RVA = "0x404B5B4", Offset = "0x40475B4", VA = "0x404B5B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005D2")]
		public RectTransform RectTransformImgTopRedEffBg_2
		{
			[Token(Token = "0x6003052")]
			[Address(RVA = "0x404B67C", Offset = "0x404767C", VA = "0x404B67C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005D3")]
		public RectTransform RectTransformImgTopRedEffBg_3
		{
			[Token(Token = "0x6003053")]
			[Address(RVA = "0x404B744", Offset = "0x4047744", VA = "0x404B744")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005D4")]
		public RectTransform RectTransformImgTopInfoBg
		{
			[Token(Token = "0x6003054")]
			[Address(RVA = "0x404B80C", Offset = "0x404780C", VA = "0x404B80C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005D5")]
		public Image ImageEnemyBanner
		{
			[Token(Token = "0x6003055")]
			[Address(RVA = "0x404B8D4", Offset = "0x40478D4", VA = "0x404B8D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005D6")]
		public Image ImageImgTopIcon
		{
			[Token(Token = "0x6003056")]
			[Address(RVA = "0x404B99C", Offset = "0x404799C", VA = "0x404B99C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005D7")]
		public AvatarItem AvatarItemEnemyAvatarItem
		{
			[Token(Token = "0x6003057")]
			[Address(RVA = "0x404BA64", Offset = "0x4047A64", VA = "0x404BA64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005D8")]
		public Image ImageImgTopPropIcon
		{
			[Token(Token = "0x6003058")]
			[Address(RVA = "0x404BB2C", Offset = "0x4047B2C", VA = "0x404BB2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005D9")]
		public TextMeshProUGUI TextMeshProUGUITxtTopPropName
		{
			[Token(Token = "0x6003059")]
			[Address(RVA = "0x404BBF4", Offset = "0x4047BF4", VA = "0x404BBF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005DA")]
		public TextMeshProUGUI TextMeshProUGUITxtTopName
		{
			[Token(Token = "0x600305A")]
			[Address(RVA = "0x404BCBC", Offset = "0x4047CBC", VA = "0x404BCBC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005DB")]
		public TextMeshProUGUI TextMeshProUGUITxtEnemyCoinNum
		{
			[Token(Token = "0x600305B")]
			[Address(RVA = "0x404BD84", Offset = "0x4047D84", VA = "0x404BD84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005DC")]
		public RectTransform RectTransformTxtEnemyCPNum
		{
			[Token(Token = "0x600305C")]
			[Address(RVA = "0x404BE4C", Offset = "0x4047E4C", VA = "0x404BE4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005DD")]
		public TextMeshProUGUI TextMeshProUGUITxtEnemyCPNum
		{
			[Token(Token = "0x600305D")]
			[Address(RVA = "0x404BF14", Offset = "0x4047F14", VA = "0x404BF14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005DE")]
		public TextMeshProUGUI TextMeshProUGUITxtEnemyCP
		{
			[Token(Token = "0x600305E")]
			[Address(RVA = "0x404BFDC", Offset = "0x4047FDC", VA = "0x404BFDC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005DF")]
		public RectTransform RectTransformFetterEnemyItemBotRoot
		{
			[Token(Token = "0x600305F")]
			[Address(RVA = "0x404C0A4", Offset = "0x40480A4", VA = "0x404C0A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005E0")]
		public Image ImageImgTopDanIcon
		{
			[Token(Token = "0x6003060")]
			[Address(RVA = "0x404C16C", Offset = "0x404816C", VA = "0x404C16C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005E1")]
		public TextMeshProUGUI TextMeshProUGUITxtTopDanName
		{
			[Token(Token = "0x6003061")]
			[Address(RVA = "0x404C234", Offset = "0x4048234", VA = "0x404C234")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005E2")]
		public RectTransform RectTransformImgTopTrophyIcon
		{
			[Token(Token = "0x6003062")]
			[Address(RVA = "0x404C2FC", Offset = "0x40482FC", VA = "0x404C2FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005E3")]
		public TextMeshProUGUI TextMeshProUGUITxtTopTrophyNum
		{
			[Token(Token = "0x6003063")]
			[Address(RVA = "0x404C3C4", Offset = "0x40483C4", VA = "0x404C3C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005E4")]
		public TextMeshProUGUI TextMeshProUGUITxtEnemyMorale
		{
			[Token(Token = "0x6003064")]
			[Address(RVA = "0x404C48C", Offset = "0x404848C", VA = "0x404C48C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005E5")]
		public Image ImageImgEnemyBlessBg
		{
			[Token(Token = "0x6003065")]
			[Address(RVA = "0x404C554", Offset = "0x4048554", VA = "0x404C554")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005E6")]
		public Image ImageImgEnemyBlessIcon
		{
			[Token(Token = "0x6003066")]
			[Address(RVA = "0x404C61C", Offset = "0x404861C", VA = "0x404C61C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005E7")]
		public RectTransform RectTransformVsSkeletonGraphic
		{
			[Token(Token = "0x6003067")]
			[Address(RVA = "0x404C6E4", Offset = "0x40486E4", VA = "0x404C6E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005E8")]
		public SkeletonGraphic SkeletonGraphicVsSkeletonGraphic
		{
			[Token(Token = "0x6003068")]
			[Address(RVA = "0x404C7AC", Offset = "0x40487AC", VA = "0x404C7AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005E9")]
		public RectTransform RectTransformTxtCutDown
		{
			[Token(Token = "0x6003069")]
			[Address(RVA = "0x404C874", Offset = "0x4048874", VA = "0x404C874")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005EA")]
		public TextMeshProUGUI TextMeshProUGUITxtCutDown
		{
			[Token(Token = "0x600306A")]
			[Address(RVA = "0x404C93C", Offset = "0x404893C", VA = "0x404C93C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005EB")]
		public RectTransform RectTransformImgLoupeIcon
		{
			[Token(Token = "0x600306B")]
			[Address(RVA = "0x404CA04", Offset = "0x4048A04", VA = "0x404CA04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600306C")]
		[Address(RVA = "0x404CACC", Offset = "0x4048ACC", VA = "0x404CACC")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x600306D")]
		[Address(RVA = "0x404CC50", Offset = "0x4048C50", VA = "0x404CC50", Slot = "12")]
		protected virtual void OnButtonExtendRawImageClicked()
		{
		}

		[Token(Token = "0x600306E")]
		[Address(RVA = "0x404CCBC", Offset = "0x4048CBC", VA = "0x404CCBC", Slot = "13")]
		protected virtual void OnScrollRectTipScrollViewValueChanged(Vector2 arg)
		{
		}

		[Token(Token = "0x600306F")]
		[Address(RVA = "0x404CD70", Offset = "0x4048D70", VA = "0x404CD70", Slot = "14")]
		protected virtual void OnButtonExtendBtnTipLeftClicked()
		{
		}

		[Token(Token = "0x6003070")]
		[Address(RVA = "0x404CDDC", Offset = "0x4048DDC", VA = "0x404CDDC", Slot = "15")]
		protected virtual void OnButtonExtendBtnTipRightClicked()
		{
		}

		[Token(Token = "0x6003071")]
		[Address(RVA = "0x404CE48", Offset = "0x4048E48", VA = "0x404CE48", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6003072")]
		[Address(RVA = "0x404CE64", Offset = "0x4048E64", VA = "0x404CE64", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__1005))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6003073")]
		[Address(RVA = "0x404CEF8", Offset = "0x4048EF8", VA = "0x404CEF8", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6003074")]
		[Address(RVA = "0x404CFAC", Offset = "0x4048FAC", VA = "0x404CFAC")]
		public FoundEnemyPanelComponents()
		{
		}
	}
}
