using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using SDKModule;
using SuperScrollView;
using TMPro;
using UIFramework;
using UIModuleO.UIAnim;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000B6E")]
	public class ShopPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B6F")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__2156 : IAsyncStateMachine
		{
			[Token(Token = "0x400536F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005370")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005371")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ShopPanelComponents _003C_003E4__this;

			[Token(Token = "0x4005372")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60045FE")]
			[Address(RVA = "0x420FE50", Offset = "0x420BE50", VA = "0x420FE50", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60045FF")]
			[Address(RVA = "0x42100C8", Offset = "0x420C0C8", VA = "0x42100C8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4005335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RectTransform _rectTransformSvSales;

		[Token(Token = "0x4005336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ScrollRect _scrollRectSvSales;

		[Token(Token = "0x4005337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RectTransform _rectTransformViewportSales;

		[Token(Token = "0x4005338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private RectTransform _rectTransformContentSales;

		[Token(Token = "0x4005339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private RectTransform _rectTransformSvSalesB;

		[Token(Token = "0x400533A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private ScrollRect _scrollRectSvSalesB;

		[Token(Token = "0x400533B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RectTransform _rectTransformSvPrimary;

		[Token(Token = "0x400533C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private ScrollRect _scrollRectSvPrimary;

		[Token(Token = "0x400533D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Image _imageImgDaliyOffresBg;

		[Token(Token = "0x400533E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private TextMeshProUGUI _textMeshProUGUITxtCutDown;

		[Token(Token = "0x400533F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private TextMeshProUGUI _textMeshProUGUITxtDailyTitle;

		[Token(Token = "0x4005340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private AdButtonExtend _adButtonExtendBtnWatchAdRefresh;

		[Token(Token = "0x4005341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private TextMeshProUGUI _textMeshProUGUITxtWatchAdRefresh;

		[Token(Token = "0x4005342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private RectTransform _rectTransformImgBuyCardRoot;

		[Token(Token = "0x4005343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private TextMeshProUGUI _textMeshProUGUITxtWatchAdRefreshTip;

		[Token(Token = "0x4005344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private TextMeshProUGUI _textMeshProUGUITxtWatchAdRefreshCutDown;

		[Token(Token = "0x4005345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private TextMeshProUGUI _textMeshProUGUITxtCutDowmTip;

		[Token(Token = "0x4005346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Image _imageImgSellBoxBg;

		[Token(Token = "0x4005347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private TextMeshProUGUI _textMeshProUGUITxtBoxTitle;

		[Token(Token = "0x4005348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Image _imageImgCardBg;

		[Token(Token = "0x4005349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private TextMeshProUGUI _textMeshProUGUITxtCardTitle;

		[Token(Token = "0x400534A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private TextMeshProUGUI _textMeshProUGUIImgCardHintText;

		[Token(Token = "0x400534B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private RectTransform _rectTransformImgBuyTopCardRoot;

		[Token(Token = "0x400534C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private RectTransform _rectTransformImgBuyBotCardRoot;

		[Token(Token = "0x400534D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private RectTransform _rectTransformImgSellDiamondBg;

		[Token(Token = "0x400534E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Image _imageImgSellDiamondBg;

		[Token(Token = "0x400534F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Image _imageImgGemsHintBg;

		[Token(Token = "0x4005350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private TextMeshProUGUI _textMeshProUGUITxtDiamondTitle;

		[Token(Token = "0x4005351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private RectTransform _rectTransformImgBuyDiamondRoot;

		[Token(Token = "0x4005352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Image _imageImgBuyDiamondRoot;

		[Token(Token = "0x4005353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Image _imageImgSellGoldBg;

		[Token(Token = "0x4005354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private TextMeshProUGUI _textMeshProUGUITxtGoldTitle;

		[Token(Token = "0x4005355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private RectTransform _rectTransformImgBuyGoldRoot;

		[Token(Token = "0x4005356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private RectTransform _rectTransformImgFreeGoldRoot;

		[Token(Token = "0x4005357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Image _imageImgSellWoodBg;

		[Token(Token = "0x4005358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private TextMeshProUGUI _textMeshProUGUITxtWoodTitle;

		[Token(Token = "0x4005359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private RectTransform _rectTransformImgBuyWoodRoot;

		[Token(Token = "0x400535A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private RectTransform _rectTransformImgFreeWoodRoot;

		[Token(Token = "0x400535B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private Image _imageImgSellAbilityStoneBg;

		[Token(Token = "0x400535C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private RectTransform _rectTransformImgBuyAbilityStoneRoot;

		[Token(Token = "0x400535D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private RectTransform _rectTransformImgFreeAbilityStoneRoot;

		[Token(Token = "0x400535E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private Image _imageImgSellCrystalBg;

		[Token(Token = "0x400535F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private TextMeshProUGUI _textMeshProUGUITxtCrystalTitle;

		[Token(Token = "0x4005360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private RectTransform _rectTransformImgBuyCrystalRoot;

		[Token(Token = "0x4005361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private RectTransform _rectTransformImgFreeCrystalRoot;

		[Token(Token = "0x4005362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private RectTransform _rectTransformSvArena;

		[Token(Token = "0x4005363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private ScrollRect _scrollRectSvArena;

		[Token(Token = "0x4005364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private LoopListView2 _loopListView2SvArena;

		[Token(Token = "0x4005365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private ButtonExtend _buttonExtendBackground;

		[Token(Token = "0x4005366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private ButtonExtend _buttonExtendShowDes;

		[Token(Token = "0x4005367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private ButtonExtend _buttonExtendShowDes1;

		[Token(Token = "0x4005368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private ButtonExtend _buttonExtendShowDes2;

		[Token(Token = "0x4005369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private RectTransform _rectTransformTabGroup;

		[Token(Token = "0x400536A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private TabButtonGroup _tabButtonGroupTabGroup;

		[Token(Token = "0x400536B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private ButtonExtend _buttonExtendBtnSales;

		[Token(Token = "0x400536C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private ButtonExtend _buttonExtendBtnPrimary;

		[Token(Token = "0x400536D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private ButtonExtend _buttonExtendBtnArena;

		[Token(Token = "0x400536E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private RectTransform _rectTransformLock;

		[Token(Token = "0x17000B92")]
		public RectTransform RectTransformSvSales
		{
			[Token(Token = "0x60045B2")]
			[Address(RVA = "0x4203730", Offset = "0x41FF730", VA = "0x4203730")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B93")]
		public ScrollRect ScrollRectSvSales
		{
			[Token(Token = "0x60045B3")]
			[Address(RVA = "0x41FE544", Offset = "0x41FA544", VA = "0x41FE544")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B94")]
		public RectTransform RectTransformViewportSales
		{
			[Token(Token = "0x60045B4")]
			[Address(RVA = "0x420C63C", Offset = "0x420863C", VA = "0x420C63C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B95")]
		public RectTransform RectTransformContentSales
		{
			[Token(Token = "0x60045B5")]
			[Address(RVA = "0x4200228", Offset = "0x41FC228", VA = "0x4200228")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B96")]
		public RectTransform RectTransformSvSalesB
		{
			[Token(Token = "0x60045B6")]
			[Address(RVA = "0x42037F8", Offset = "0x41FF7F8", VA = "0x42037F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B97")]
		public ScrollRect ScrollRectSvSalesB
		{
			[Token(Token = "0x60045B7")]
			[Address(RVA = "0x420EB40", Offset = "0x420AB40", VA = "0x420EB40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B98")]
		public RectTransform RectTransformSvPrimary
		{
			[Token(Token = "0x60045B8")]
			[Address(RVA = "0x4203120", Offset = "0x41FF120", VA = "0x4203120")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B99")]
		public ScrollRect ScrollRectSvPrimary
		{
			[Token(Token = "0x60045B9")]
			[Address(RVA = "0x4203214", Offset = "0x41FF214", VA = "0x4203214")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B9A")]
		public Image ImageImgDaliyOffresBg
		{
			[Token(Token = "0x60045BA")]
			[Address(RVA = "0x4202C70", Offset = "0x41FEC70", VA = "0x4202C70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B9B")]
		public TextMeshProUGUI TextMeshProUGUITxtCutDown
		{
			[Token(Token = "0x60045BB")]
			[Address(RVA = "0x41FD8B8", Offset = "0x41F98B8", VA = "0x41FD8B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B9C")]
		public TextMeshProUGUI TextMeshProUGUITxtDailyTitle
		{
			[Token(Token = "0x60045BC")]
			[Address(RVA = "0x420DD94", Offset = "0x4209D94", VA = "0x420DD94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B9D")]
		public AdButtonExtend AdButtonExtendBtnWatchAdRefresh
		{
			[Token(Token = "0x60045BD")]
			[Address(RVA = "0x41FD980", Offset = "0x41F9980", VA = "0x41FD980")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B9E")]
		public TextMeshProUGUI TextMeshProUGUITxtWatchAdRefresh
		{
			[Token(Token = "0x60045BE")]
			[Address(RVA = "0x420E244", Offset = "0x420A244", VA = "0x420E244")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B9F")]
		public RectTransform RectTransformImgBuyCardRoot
		{
			[Token(Token = "0x60045BF")]
			[Address(RVA = "0x4208B28", Offset = "0x4204B28", VA = "0x4208B28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BA0")]
		public TextMeshProUGUI TextMeshProUGUITxtWatchAdRefreshTip
		{
			[Token(Token = "0x60045C0")]
			[Address(RVA = "0x41FDA48", Offset = "0x41F9A48", VA = "0x41FDA48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BA1")]
		public TextMeshProUGUI TextMeshProUGUITxtWatchAdRefreshCutDown
		{
			[Token(Token = "0x60045C1")]
			[Address(RVA = "0x41FDB10", Offset = "0x41F9B10", VA = "0x41FDB10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BA2")]
		public TextMeshProUGUI TextMeshProUGUITxtCutDowmTip
		{
			[Token(Token = "0x60045C2")]
			[Address(RVA = "0x420E30C", Offset = "0x420A30C", VA = "0x420E30C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BA3")]
		public Image ImageImgSellBoxBg
		{
			[Token(Token = "0x60045C3")]
			[Address(RVA = "0x4201DD8", Offset = "0x41FDDD8", VA = "0x4201DD8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BA4")]
		public TextMeshProUGUI TextMeshProUGUITxtBoxTitle
		{
			[Token(Token = "0x60045C4")]
			[Address(RVA = "0x420DE5C", Offset = "0x4209E5C", VA = "0x420DE5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BA5")]
		public Image ImageImgCardBg
		{
			[Token(Token = "0x60045C5")]
			[Address(RVA = "0x4201D10", Offset = "0x41FDD10", VA = "0x4201D10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BA6")]
		public TextMeshProUGUI TextMeshProUGUITxtCardTitle
		{
			[Token(Token = "0x60045C6")]
			[Address(RVA = "0x42063C4", Offset = "0x42023C4", VA = "0x42063C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BA7")]
		public TextMeshProUGUI TextMeshProUGUIImgCardHintText
		{
			[Token(Token = "0x60045C7")]
			[Address(RVA = "0x420648C", Offset = "0x420248C", VA = "0x420648C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BA8")]
		public RectTransform RectTransformImgBuyTopCardRoot
		{
			[Token(Token = "0x60045C8")]
			[Address(RVA = "0x420661C", Offset = "0x420261C", VA = "0x420661C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BA9")]
		public RectTransform RectTransformImgBuyBotCardRoot
		{
			[Token(Token = "0x60045C9")]
			[Address(RVA = "0x4206554", Offset = "0x4202554", VA = "0x4206554")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BAA")]
		public RectTransform RectTransformImgSellDiamondBg
		{
			[Token(Token = "0x60045CA")]
			[Address(RVA = "0x42050CC", Offset = "0x42010CC", VA = "0x42050CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BAB")]
		public Image ImageImgSellDiamondBg
		{
			[Token(Token = "0x60045CB")]
			[Address(RVA = "0x4202E00", Offset = "0x41FEE00", VA = "0x4202E00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BAC")]
		public Image ImageImgGemsHintBg
		{
			[Token(Token = "0x60045CC")]
			[Address(RVA = "0x4205004", Offset = "0x4201004", VA = "0x4205004")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BAD")]
		public TextMeshProUGUI TextMeshProUGUITxtDiamondTitle
		{
			[Token(Token = "0x60045CD")]
			[Address(RVA = "0x420DFEC", Offset = "0x4209FEC", VA = "0x420DFEC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BAE")]
		public RectTransform RectTransformImgBuyDiamondRoot
		{
			[Token(Token = "0x60045CE")]
			[Address(RVA = "0x42091A0", Offset = "0x42051A0", VA = "0x42091A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BAF")]
		public Image ImageImgBuyDiamondRoot
		{
			[Token(Token = "0x60045CF")]
			[Address(RVA = "0x4205194", Offset = "0x4201194", VA = "0x4205194")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BB0")]
		public Image ImageImgSellGoldBg
		{
			[Token(Token = "0x60045D0")]
			[Address(RVA = "0x4202D38", Offset = "0x41FED38", VA = "0x4202D38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BB1")]
		public TextMeshProUGUI TextMeshProUGUITxtGoldTitle
		{
			[Token(Token = "0x60045D1")]
			[Address(RVA = "0x420DF24", Offset = "0x4209F24", VA = "0x420DF24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BB2")]
		public RectTransform RectTransformImgBuyGoldRoot
		{
			[Token(Token = "0x60045D2")]
			[Address(RVA = "0x4206EB8", Offset = "0x4202EB8", VA = "0x4206EB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BB3")]
		public RectTransform RectTransformImgFreeGoldRoot
		{
			[Token(Token = "0x60045D3")]
			[Address(RVA = "0x4206F80", Offset = "0x4202F80", VA = "0x4206F80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BB4")]
		public Image ImageImgSellWoodBg
		{
			[Token(Token = "0x60045D4")]
			[Address(RVA = "0x4202EC8", Offset = "0x41FEEC8", VA = "0x4202EC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BB5")]
		public TextMeshProUGUI TextMeshProUGUITxtWoodTitle
		{
			[Token(Token = "0x60045D5")]
			[Address(RVA = "0x420E0B4", Offset = "0x420A0B4", VA = "0x420E0B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BB6")]
		public RectTransform RectTransformImgBuyWoodRoot
		{
			[Token(Token = "0x60045D6")]
			[Address(RVA = "0x420A9C0", Offset = "0x42069C0", VA = "0x420A9C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BB7")]
		public RectTransform RectTransformImgFreeWoodRoot
		{
			[Token(Token = "0x60045D7")]
			[Address(RVA = "0x420AA88", Offset = "0x4206A88", VA = "0x420AA88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BB8")]
		public Image ImageImgSellAbilityStoneBg
		{
			[Token(Token = "0x60045D8")]
			[Address(RVA = "0x4202F90", Offset = "0x41FEF90", VA = "0x4202F90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BB9")]
		public RectTransform RectTransformImgBuyAbilityStoneRoot
		{
			[Token(Token = "0x60045D9")]
			[Address(RVA = "0x4205A50", Offset = "0x4201A50", VA = "0x4205A50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BBA")]
		public RectTransform RectTransformImgFreeAbilityStoneRoot
		{
			[Token(Token = "0x60045DA")]
			[Address(RVA = "0x4205B18", Offset = "0x4201B18", VA = "0x4205B18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BBB")]
		public Image ImageImgSellCrystalBg
		{
			[Token(Token = "0x60045DB")]
			[Address(RVA = "0x4203058", Offset = "0x41FF058", VA = "0x4203058")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BBC")]
		public TextMeshProUGUI TextMeshProUGUITxtCrystalTitle
		{
			[Token(Token = "0x60045DC")]
			[Address(RVA = "0x420E17C", Offset = "0x420A17C", VA = "0x420E17C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BBD")]
		public RectTransform RectTransformImgBuyCrystalRoot
		{
			[Token(Token = "0x60045DD")]
			[Address(RVA = "0x4207854", Offset = "0x4203854", VA = "0x4207854")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BBE")]
		public RectTransform RectTransformImgFreeCrystalRoot
		{
			[Token(Token = "0x60045DE")]
			[Address(RVA = "0x420791C", Offset = "0x420391C", VA = "0x420791C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BBF")]
		public RectTransform RectTransformSvArena
		{
			[Token(Token = "0x60045DF")]
			[Address(RVA = "0x42038C0", Offset = "0x41FF8C0", VA = "0x42038C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BC0")]
		public ScrollRect ScrollRectSvArena
		{
			[Token(Token = "0x60045E0")]
			[Address(RVA = "0x420EA78", Offset = "0x420AA78", VA = "0x420EA78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BC1")]
		public LoopListView2 LoopListView2SvArena
		{
			[Token(Token = "0x60045E1")]
			[Address(RVA = "0x4204F3C", Offset = "0x4200F3C", VA = "0x4204F3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BC2")]
		public ButtonExtend ButtonExtendBackground
		{
			[Token(Token = "0x60045E2")]
			[Address(RVA = "0x420EF08", Offset = "0x420AF08", VA = "0x420EF08")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BC3")]
		public ButtonExtend ButtonExtendShowDes
		{
			[Token(Token = "0x60045E3")]
			[Address(RVA = "0x420EFD0", Offset = "0x420AFD0", VA = "0x420EFD0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BC4")]
		public ButtonExtend ButtonExtendShowDes1
		{
			[Token(Token = "0x60045E4")]
			[Address(RVA = "0x420F098", Offset = "0x420B098", VA = "0x420F098")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BC5")]
		public ButtonExtend ButtonExtendShowDes2
		{
			[Token(Token = "0x60045E5")]
			[Address(RVA = "0x420F160", Offset = "0x420B160", VA = "0x420F160")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BC6")]
		public RectTransform RectTransformTabGroup
		{
			[Token(Token = "0x60045E6")]
			[Address(RVA = "0x4203668", Offset = "0x41FF668", VA = "0x4203668")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BC7")]
		public TabButtonGroup TabButtonGroupTabGroup
		{
			[Token(Token = "0x60045E7")]
			[Address(RVA = "0x4204E74", Offset = "0x4200E74", VA = "0x4204E74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BC8")]
		public ButtonExtend ButtonExtendBtnSales
		{
			[Token(Token = "0x60045E8")]
			[Address(RVA = "0x420F228", Offset = "0x420B228", VA = "0x420F228")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BC9")]
		public ButtonExtend ButtonExtendBtnPrimary
		{
			[Token(Token = "0x60045E9")]
			[Address(RVA = "0x420F2F0", Offset = "0x420B2F0", VA = "0x420F2F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BCA")]
		public ButtonExtend ButtonExtendBtnArena
		{
			[Token(Token = "0x60045EA")]
			[Address(RVA = "0x4202498", Offset = "0x41FE498", VA = "0x4202498")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BCB")]
		public RectTransform RectTransformLock
		{
			[Token(Token = "0x60045EB")]
			[Address(RVA = "0x4203988", Offset = "0x41FF988", VA = "0x4203988")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60045EC")]
		[Address(RVA = "0x420F3B8", Offset = "0x420B3B8", VA = "0x420F3B8")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x60045ED")]
		[Address(RVA = "0x420F764", Offset = "0x420B764", VA = "0x420F764", Slot = "12")]
		protected virtual void OnScrollRectSvSalesValueChanged(Vector2 arg)
		{
		}

		[Token(Token = "0x60045EE")]
		[Address(RVA = "0x420F818", Offset = "0x420B818", VA = "0x420F818", Slot = "13")]
		protected virtual void OnScrollRectSvSalesBValueChanged(Vector2 arg)
		{
		}

		[Token(Token = "0x60045EF")]
		[Address(RVA = "0x420F8CC", Offset = "0x420B8CC", VA = "0x420F8CC", Slot = "14")]
		protected virtual void OnScrollRectSvPrimaryValueChanged(Vector2 arg)
		{
		}

		[Token(Token = "0x60045F0")]
		[Address(RVA = "0x420F980", Offset = "0x420B980", VA = "0x420F980", Slot = "15")]
		protected virtual void OnAdButtonExtendBtnWatchAdRefreshClicked()
		{
		}

		[Token(Token = "0x60045F1")]
		[Address(RVA = "0x420F9EC", Offset = "0x420B9EC", VA = "0x420F9EC", Slot = "16")]
		protected virtual void OnScrollRectSvArenaValueChanged(Vector2 arg)
		{
		}

		[Token(Token = "0x60045F2")]
		[Address(RVA = "0x420FAA0", Offset = "0x420BAA0", VA = "0x420FAA0", Slot = "17")]
		protected virtual void OnButtonExtendBackgroundClicked()
		{
		}

		[Token(Token = "0x60045F3")]
		[Address(RVA = "0x420FB0C", Offset = "0x420BB0C", VA = "0x420FB0C", Slot = "18")]
		protected virtual void OnButtonExtendShowDesClicked()
		{
		}

		[Token(Token = "0x60045F4")]
		[Address(RVA = "0x420FB78", Offset = "0x420BB78", VA = "0x420FB78", Slot = "19")]
		protected virtual void OnButtonExtendShowDes1Clicked()
		{
		}

		[Token(Token = "0x60045F5")]
		[Address(RVA = "0x420FBE4", Offset = "0x420BBE4", VA = "0x420FBE4", Slot = "20")]
		protected virtual void OnButtonExtendShowDes2Clicked()
		{
		}

		[Token(Token = "0x60045F6")]
		[Address(RVA = "0x420FC50", Offset = "0x420BC50", VA = "0x420FC50", Slot = "21")]
		protected virtual void OnButtonExtendBtnSalesClicked()
		{
		}

		[Token(Token = "0x60045F7")]
		[Address(RVA = "0x420FCBC", Offset = "0x420BCBC", VA = "0x420FCBC", Slot = "22")]
		protected virtual void OnButtonExtendBtnPrimaryClicked()
		{
		}

		[Token(Token = "0x60045F8")]
		[Address(RVA = "0x420FD28", Offset = "0x420BD28", VA = "0x420FD28", Slot = "23")]
		protected virtual void OnButtonExtendBtnArenaClicked()
		{
		}

		[Token(Token = "0x60045F9")]
		[Address(RVA = "0x4203E6C", Offset = "0x41FFE6C", VA = "0x4203E6C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60045FA")]
		[Address(RVA = "0x4203E8C", Offset = "0x41FFE8C", VA = "0x4203E8C", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__2156))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60045FB")]
		[Address(RVA = "0x420FD94", Offset = "0x420BD94", VA = "0x420FD94", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60045FC")]
		[Address(RVA = "0x4203E44", Offset = "0x41FFE44", VA = "0x4203E44")]
		public ShopPanelComponents()
		{
		}
	}
}
