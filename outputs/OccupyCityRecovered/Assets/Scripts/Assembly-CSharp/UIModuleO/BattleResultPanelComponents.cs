using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using SDKModule;
using TMPro;
using UIFramework;
using UIModuleO.UIAnim;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000710")]
	public class BattleResultPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000711")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__645 : IAsyncStateMachine
		{
			[Token(Token = "0x4003842")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003843")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003844")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BattleResultPanelComponents _003C_003E4__this;

			[Token(Token = "0x4003845")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6002686")]
			[Address(RVA = "0x3F95E58", Offset = "0x3F91E58", VA = "0x3F95E58", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002687")]
			[Address(RVA = "0x3F960D0", Offset = "0x3F920D0", VA = "0x3F960D0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003814")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RectTransform _rectTransformImgTitle_Success;

		[Token(Token = "0x4003815")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Image _imageImgJinGuang;

		[Token(Token = "0x4003816")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Image _imageImgRoleIcon_Success;

		[Token(Token = "0x4003817")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private RectTransform _rectTransformImgTitle_Lose;

		[Token(Token = "0x4003818")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Image _imageImgRoleIcon_Lose;

		[Token(Token = "0x4003819")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private RectTransform _rectTransformRewardBG;

		[Token(Token = "0x400381A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RectTransform _rectTransformTrophyExpRoot;

		[Token(Token = "0x400381B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private ButtonExtend _buttonExtendBattleResultItem;

		[Token(Token = "0x400381C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private RectTransform _rectTransformRewardsRoot;

		[Token(Token = "0x400381D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private TextMeshProUGUI _textMeshProUGUITxtRewards;

		[Token(Token = "0x400381E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private RectTransform _rectTransformImgRewardLayOutRoot;

		[Token(Token = "0x400381F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private RectTransform _rectTransformImgBoxBg;

		[Token(Token = "0x4003820")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Image _imageImgBoxBg;

		[Token(Token = "0x4003821")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private ButtonExtend _buttonExtendImgBoxBg;

		[Token(Token = "0x4003822")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Image _imageImgBoxIcon;

		[Token(Token = "0x4003823")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private TextMeshProUGUI _textMeshProUGUITxtBoxReward;

		[Token(Token = "0x4003824")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Image _imageImgCrosses;

		[Token(Token = "0x4003825")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private TextMeshProUGUI _textMeshProUGUITxtNoEmpty;

		[Token(Token = "0x4003826")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private RectTransform _rectTransformTxtAFK;

		[Token(Token = "0x4003827")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Transform _transformSparkleAreaYellow;

		[Token(Token = "0x4003828")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RectTransform _rectTransformImgPackBg;

		[Token(Token = "0x4003829")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private RectTransform _rectTransformImgCardItem;

		[Token(Token = "0x400382A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Image _imageImgCardItem;

		[Token(Token = "0x400382B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Button _buttonImgCardItem;

		[Token(Token = "0x400382C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Image _imageImgCardIcon;

		[Token(Token = "0x400382D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Image _imageImgType;

		[Token(Token = "0x400382E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private TextMeshProUGUI _textMeshProUGUITxtNum;

		[Token(Token = "0x400382F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Image _imageImgProgress;

		[Token(Token = "0x4003830")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private TextMeshProUGUI _textMeshProUGUITxtProgress;

		[Token(Token = "0x4003831")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private RectTransform _rectTransformImgCardDuiHao;

		[Token(Token = "0x4003832")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private RectTransform _rectTransformImgCoinIcon;

		[Token(Token = "0x4003833")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private ButtonExtend _buttonExtendImgCoinIcon;

		[Token(Token = "0x4003834")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private TextMeshProUGUI _textMeshProUGUITxtCoinNum;

		[Token(Token = "0x4003835")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private RectTransform _rectTransformImgCoinDuiHao;

		[Token(Token = "0x4003836")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private RectTransform _rectTransformImgWoodIcon;

		[Token(Token = "0x4003837")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private ButtonExtend _buttonExtendImgWoodIcon;

		[Token(Token = "0x4003838")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private RectTransform _rectTransformImgWoodDuiHao;

		[Token(Token = "0x4003839")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private RectTransform _rectTransformTxtVictoryPack;

		[Token(Token = "0x400383A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private TextMeshProUGUI _textMeshProUGUITxtVictoryPack;

		[Token(Token = "0x400383B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private RectTransform _rectTransformBtnAd;

		[Token(Token = "0x400383C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private AdButtonExtend _adButtonExtendBtnAd;

		[Token(Token = "0x400383D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private TextMeshProUGUI _textMeshProUGUITxtAd;

		[Token(Token = "0x400383E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private TextMeshProUGUI _textMeshProUGUITxtWatchADPackCount;

		[Token(Token = "0x400383F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private RectTransform _rectTransformBtnSure;

		[Token(Token = "0x4003840")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private ButtonExtend _buttonExtendBtnSure;

		[Token(Token = "0x4003841")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private TextMeshProUGUI _textMeshProUGUITxtSure;

		[Token(Token = "0x170002ED")]
		public RectTransform RectTransformImgTitle_Success
		{
			[Token(Token = "0x600264B")]
			[Address(RVA = "0x3F94A8C", Offset = "0x3F90A8C", VA = "0x3F94A8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002EE")]
		public Image ImageImgJinGuang
		{
			[Token(Token = "0x600264C")]
			[Address(RVA = "0x3F8F4A4", Offset = "0x3F8B4A4", VA = "0x3F8F4A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002EF")]
		public Image ImageImgRoleIcon_Success
		{
			[Token(Token = "0x600264D")]
			[Address(RVA = "0x3F8F56C", Offset = "0x3F8B56C", VA = "0x3F8F56C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002F0")]
		public RectTransform RectTransformImgTitle_Lose
		{
			[Token(Token = "0x600264E")]
			[Address(RVA = "0x3F94B54", Offset = "0x3F90B54", VA = "0x3F94B54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002F1")]
		public Image ImageImgRoleIcon_Lose
		{
			[Token(Token = "0x600264F")]
			[Address(RVA = "0x3F8F7C4", Offset = "0x3F8B7C4", VA = "0x3F8F7C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002F2")]
		public RectTransform RectTransformRewardBG
		{
			[Token(Token = "0x6002650")]
			[Address(RVA = "0x3F8F954", Offset = "0x3F8B954", VA = "0x3F8F954")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002F3")]
		public RectTransform RectTransformTrophyExpRoot
		{
			[Token(Token = "0x6002651")]
			[Address(RVA = "0x3F94E74", Offset = "0x3F90E74", VA = "0x3F94E74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002F4")]
		public ButtonExtend ButtonExtendBattleResultItem
		{
			[Token(Token = "0x6002652")]
			[Address(RVA = "0x3F95768", Offset = "0x3F91768", VA = "0x3F95768")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002F5")]
		public RectTransform RectTransformRewardsRoot
		{
			[Token(Token = "0x6002653")]
			[Address(RVA = "0x3F950CC", Offset = "0x3F910CC", VA = "0x3F950CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002F6")]
		public TextMeshProUGUI TextMeshProUGUITxtRewards
		{
			[Token(Token = "0x6002654")]
			[Address(RVA = "0x3F94C1C", Offset = "0x3F90C1C", VA = "0x3F94C1C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002F7")]
		public RectTransform RectTransformImgRewardLayOutRoot
		{
			[Token(Token = "0x6002655")]
			[Address(RVA = "0x3F95004", Offset = "0x3F91004", VA = "0x3F95004")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002F8")]
		public RectTransform RectTransformImgBoxBg
		{
			[Token(Token = "0x6002656")]
			[Address(RVA = "0x3F902B8", Offset = "0x3F8C2B8", VA = "0x3F902B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002F9")]
		public Image ImageImgBoxBg
		{
			[Token(Token = "0x6002657")]
			[Address(RVA = "0x3F94F3C", Offset = "0x3F90F3C", VA = "0x3F94F3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002FA")]
		public ButtonExtend ButtonExtendImgBoxBg
		{
			[Token(Token = "0x6002658")]
			[Address(RVA = "0x3F95830", Offset = "0x3F91830", VA = "0x3F95830")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002FB")]
		public Image ImageImgBoxIcon
		{
			[Token(Token = "0x6002659")]
			[Address(RVA = "0x3F92590", Offset = "0x3F8E590", VA = "0x3F92590")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002FC")]
		public TextMeshProUGUI TextMeshProUGUITxtBoxReward
		{
			[Token(Token = "0x600265A")]
			[Address(RVA = "0x3F92338", Offset = "0x3F8E338", VA = "0x3F92338")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002FD")]
		public Image ImageImgCrosses
		{
			[Token(Token = "0x600265B")]
			[Address(RVA = "0x3F924C8", Offset = "0x3F8E4C8", VA = "0x3F924C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002FE")]
		public TextMeshProUGUI TextMeshProUGUITxtNoEmpty
		{
			[Token(Token = "0x600265C")]
			[Address(RVA = "0x3F92400", Offset = "0x3F8E400", VA = "0x3F92400")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002FF")]
		public RectTransform RectTransformTxtAFK
		{
			[Token(Token = "0x600265D")]
			[Address(RVA = "0x3F8F88C", Offset = "0x3F8B88C", VA = "0x3F8F88C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000300")]
		public Transform TransformSparkleAreaYellow
		{
			[Token(Token = "0x600265E")]
			[Address(RVA = "0x3F8F634", Offset = "0x3F8B634", VA = "0x3F8F634")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000301")]
		public RectTransform RectTransformImgPackBg
		{
			[Token(Token = "0x600265F")]
			[Address(RVA = "0x3F91540", Offset = "0x3F8D540", VA = "0x3F91540")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000302")]
		public RectTransform RectTransformImgCardItem
		{
			[Token(Token = "0x6002660")]
			[Address(RVA = "0x3F8FB60", Offset = "0x3F8BB60", VA = "0x3F8FB60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000303")]
		public Image ImageImgCardItem
		{
			[Token(Token = "0x6002661")]
			[Address(RVA = "0x3F91928", Offset = "0x3F8D928", VA = "0x3F91928")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000304")]
		public Button ButtonImgCardItem
		{
			[Token(Token = "0x6002662")]
			[Address(RVA = "0x3F958F8", Offset = "0x3F918F8", VA = "0x3F958F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000305")]
		public Image ImageImgCardIcon
		{
			[Token(Token = "0x6002663")]
			[Address(RVA = "0x3F91860", Offset = "0x3F8D860", VA = "0x3F91860")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000306")]
		public Image ImageImgType
		{
			[Token(Token = "0x6002664")]
			[Address(RVA = "0x3F919F0", Offset = "0x3F8D9F0", VA = "0x3F919F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000307")]
		public TextMeshProUGUI TextMeshProUGUITxtNum
		{
			[Token(Token = "0x6002665")]
			[Address(RVA = "0x3F91798", Offset = "0x3F8D798", VA = "0x3F91798")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000308")]
		public Image ImageImgProgress
		{
			[Token(Token = "0x6002666")]
			[Address(RVA = "0x3F8EC54", Offset = "0x3F8AC54", VA = "0x3F8EC54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000309")]
		public TextMeshProUGUI TextMeshProUGUITxtProgress
		{
			[Token(Token = "0x6002667")]
			[Address(RVA = "0x3F8EB8C", Offset = "0x3F8AB8C", VA = "0x3F8EB8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700030A")]
		public RectTransform RectTransformImgCardDuiHao
		{
			[Token(Token = "0x6002668")]
			[Address(RVA = "0x3F8E7A4", Offset = "0x3F8A7A4", VA = "0x3F8E7A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700030B")]
		public RectTransform RectTransformImgCoinIcon
		{
			[Token(Token = "0x6002669")]
			[Address(RVA = "0x3F8FE04", Offset = "0x3F8BE04", VA = "0x3F8FE04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700030C")]
		public ButtonExtend ButtonExtendImgCoinIcon
		{
			[Token(Token = "0x600266A")]
			[Address(RVA = "0x3F959C0", Offset = "0x3F919C0", VA = "0x3F959C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700030D")]
		public TextMeshProUGUI TextMeshProUGUITxtCoinNum
		{
			[Token(Token = "0x600266B")]
			[Address(RVA = "0x3F8DED4", Offset = "0x3F89ED4", VA = "0x3F8DED4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700030E")]
		public RectTransform RectTransformImgCoinDuiHao
		{
			[Token(Token = "0x600266C")]
			[Address(RVA = "0x3F8E86C", Offset = "0x3F8A86C", VA = "0x3F8E86C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700030F")]
		public RectTransform RectTransformImgWoodIcon
		{
			[Token(Token = "0x600266D")]
			[Address(RVA = "0x3F900A8", Offset = "0x3F8C0A8", VA = "0x3F900A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000310")]
		public ButtonExtend ButtonExtendImgWoodIcon
		{
			[Token(Token = "0x600266E")]
			[Address(RVA = "0x3F95A88", Offset = "0x3F91A88", VA = "0x3F95A88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000311")]
		public RectTransform RectTransformImgWoodDuiHao
		{
			[Token(Token = "0x600266F")]
			[Address(RVA = "0x3F8E934", Offset = "0x3F8A934", VA = "0x3F8E934")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000312")]
		public RectTransform RectTransformTxtVictoryPack
		{
			[Token(Token = "0x6002670")]
			[Address(RVA = "0x3F8EAC4", Offset = "0x3F8AAC4", VA = "0x3F8EAC4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000313")]
		public TextMeshProUGUI TextMeshProUGUITxtVictoryPack
		{
			[Token(Token = "0x6002671")]
			[Address(RVA = "0x3F949C4", Offset = "0x3F909C4", VA = "0x3F949C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000314")]
		public RectTransform RectTransformBtnAd
		{
			[Token(Token = "0x6002672")]
			[Address(RVA = "0x3F8F6FC", Offset = "0x3F8B6FC", VA = "0x3F8F6FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000315")]
		public AdButtonExtend AdButtonExtendBtnAd
		{
			[Token(Token = "0x6002673")]
			[Address(RVA = "0x3F8E9FC", Offset = "0x3F8A9FC", VA = "0x3F8E9FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000316")]
		public TextMeshProUGUI TextMeshProUGUITxtAd
		{
			[Token(Token = "0x6002674")]
			[Address(RVA = "0x3F94DAC", Offset = "0x3F90DAC", VA = "0x3F94DAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000317")]
		public TextMeshProUGUI TextMeshProUGUITxtWatchADPackCount
		{
			[Token(Token = "0x6002675")]
			[Address(RVA = "0x3F8EF24", Offset = "0x3F8AF24", VA = "0x3F8EF24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000318")]
		public RectTransform RectTransformBtnSure
		{
			[Token(Token = "0x6002676")]
			[Address(RVA = "0x3F91608", Offset = "0x3F8D608", VA = "0x3F91608")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000319")]
		public ButtonExtend ButtonExtendBtnSure
		{
			[Token(Token = "0x6002677")]
			[Address(RVA = "0x3F916D0", Offset = "0x3F8D6D0", VA = "0x3F916D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700031A")]
		public TextMeshProUGUI TextMeshProUGUITxtSure
		{
			[Token(Token = "0x6002678")]
			[Address(RVA = "0x3F94CE4", Offset = "0x3F90CE4", VA = "0x3F94CE4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002679")]
		[Address(RVA = "0x3F95B50", Offset = "0x3F91B50", VA = "0x3F95B50")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x600267A")]
		[Address(RVA = "0x3F95D78", Offset = "0x3F91D78", VA = "0x3F95D78", Slot = "12")]
		protected virtual void OnButtonExtendBattleResultItemClicked()
		{
		}

		[Token(Token = "0x600267B")]
		[Address(RVA = "0x3F9024C", Offset = "0x3F8C24C", VA = "0x3F9024C", Slot = "13")]
		protected virtual void OnButtonExtendImgBoxBgClicked()
		{
		}

		[Token(Token = "0x600267C")]
		[Address(RVA = "0x3F8FAF4", Offset = "0x3F8BAF4", VA = "0x3F8FAF4", Slot = "14")]
		protected virtual void OnButtonImgCardItemClicked()
		{
		}

		[Token(Token = "0x600267D")]
		[Address(RVA = "0x3F8FD98", Offset = "0x3F8BD98", VA = "0x3F8FD98", Slot = "15")]
		protected virtual void OnButtonExtendImgCoinIconClicked()
		{
		}

		[Token(Token = "0x600267E")]
		[Address(RVA = "0x3F9003C", Offset = "0x3F8C03C", VA = "0x3F9003C", Slot = "16")]
		protected virtual void OnButtonExtendImgWoodIconClicked()
		{
		}

		[Token(Token = "0x600267F")]
		[Address(RVA = "0x3F95DE4", Offset = "0x3F91DE4", VA = "0x3F95DE4", Slot = "17")]
		protected virtual void OnAdButtonExtendBtnAdClicked()
		{
		}

		[Token(Token = "0x6002680")]
		[Address(RVA = "0x3F8DBC4", Offset = "0x3F89BC4", VA = "0x3F8DBC4", Slot = "18")]
		protected virtual void OnButtonExtendBtnSureClicked()
		{
		}

		[Token(Token = "0x6002681")]
		[Address(RVA = "0x3F9046C", Offset = "0x3F8C46C", VA = "0x3F9046C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002682")]
		[Address(RVA = "0x3F9048C", Offset = "0x3F8C48C", VA = "0x3F9048C", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__645))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002683")]
		[Address(RVA = "0x3F8F3F0", Offset = "0x3F8B3F0", VA = "0x3F8F3F0", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6002684")]
		[Address(RVA = "0x3F90448", Offset = "0x3F8C448", VA = "0x3F90448")]
		public BattleResultPanelComponents()
		{
		}
	}
}
