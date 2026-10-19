using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using ToolModule.UI;
using UIFramework;
using UIModuleO.UIAnim;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x200094B")]
	public class ArenaUIBGItemComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200094C")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__836 : IAsyncStateMachine
		{
			[Token(Token = "0x40045D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40045D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40045D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ArenaUIBGItemComponents _003C_003E4__this;

			[Token(Token = "0x40045D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6003673")]
			[Address(RVA = "0x40CB014", Offset = "0x40C7014", VA = "0x40CB014", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003674")]
			[Address(RVA = "0x40CB28C", Offset = "0x40C728C", VA = "0x40CB28C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400459E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Image _imageArenaUIBGItem;

		[Token(Token = "0x400459F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ButtonExtend _buttonExtendBtnButtonArena;

		[Token(Token = "0x40045A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RectTransform _rectTransformImgIconRoot;

		[Token(Token = "0x40045A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Image _imageImgFrontIcon;

		[Token(Token = "0x40045A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Image _imageImgTitleBg;

		[Token(Token = "0x40045A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private RectTransform _rectTransformTopProgressBG;

		[Token(Token = "0x40045A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Image _imageCompleteProgress;

		[Token(Token = "0x40045A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private TextMeshProUGUI _textMeshProUGUITxtProgress;

		[Token(Token = "0x40045A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private TextMeshProUGUI _textMeshProUGUITxtLoss;

		[Token(Token = "0x40045A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private TextMeshProUGUI _textMeshProUGUITxtLossCount;

		[Token(Token = "0x40045A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private RectTransform _rectTransformImgBlackMaskLeft;

		[Token(Token = "0x40045A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private TextMeshProUGUI _textMeshProUGUITxtWin;

		[Token(Token = "0x40045AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private TextMeshProUGUI _textMeshProUGUITxtWinCount;

		[Token(Token = "0x40045AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private RectTransform _rectTransformImgBlackMaskRight;

		[Token(Token = "0x40045AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private TextMeshProUGUI _textMeshProUGUITxtTitle;

		[Token(Token = "0x40045AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private RectTransform _rectTransformBotRewardBG;

		[Token(Token = "0x40045AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Button _buttonBotRewardBG;

		[Token(Token = "0x40045AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private TextMeshProUGUI _textMeshProUGUITxtRewardDes;

		[Token(Token = "0x40045B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private TextMeshProUGUI _textMeshProUGUITxtCompleteRewardDes;

		[Token(Token = "0x40045B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private RectTransform _rectTransformRewardCoinBG;

		[Token(Token = "0x40045B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private TextMeshProUGUI _textMeshProUGUITxtCoinRewardCount;

		[Token(Token = "0x40045B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private RectTransform _rectTransformImgCoinDouble;

		[Token(Token = "0x40045B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private RectTransform _rectTransformRewardDiamondBG;

		[Token(Token = "0x40045B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private TextMeshProUGUI _textMeshProUGUITxtDiamondRewardCount;

		[Token(Token = "0x40045B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private RectTransform _rectTransformImgDiamondDouble;

		[Token(Token = "0x40045B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private RectTransform _rectTransformRewardBoxBG;

		[Token(Token = "0x40045B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Image _imageRewardBoxBG;

		[Token(Token = "0x40045B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private RectTransform _rectTransformImgBoxDouble;

		[Token(Token = "0x40045BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Image _imageImgUnchart;

		[Token(Token = "0x40045BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Image _imageImgExclamationMark;

		[Token(Token = "0x40045BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private RectTransform _rectTransformBlackFrontBG;

		[Token(Token = "0x40045BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Image _imageBlackFrontBG;

		[Token(Token = "0x40045BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private RectTransform _rectTransformImgLockIcon;

		[Token(Token = "0x40045BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Image _imageImgLockIcon;

		[Token(Token = "0x40045C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private RectTransform _rectTransformStartBtn;

		[Token(Token = "0x40045C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private ButtonExtend _buttonExtendStartBtn;

		[Token(Token = "0x40045C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private RectTransform _rectTransformSatrtText;

		[Token(Token = "0x40045C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private TextMeshProUGUI _textMeshProUGUISatrtText;

		[Token(Token = "0x40045C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private TextMeshProUGUI _textMeshProUGUITxtCoinFee;

		[Token(Token = "0x40045C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private Image _imageImgStartBtnLeft;

		[Token(Token = "0x40045C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private Image _imageImgStartBtnRight;

		[Token(Token = "0x40045C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private Image _imageImgAvailableBG;

		[Token(Token = "0x40045C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private GridLayoutMiddleCenter _gridLayoutMiddleCenterLimits;

		[Token(Token = "0x40045C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private TextMeshProUGUI _textMeshProUGUITxtSeasonScoreLimit;

		[Token(Token = "0x40045CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private RectTransform _rectTransformTxtChestLimit;

		[Token(Token = "0x40045CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private TextMeshProUGUI _textMeshProUGUITxtChestLimit;

		[Token(Token = "0x40045CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private TextMeshProUGUI _textMeshProUGUITxtCoinLimit;

		[Token(Token = "0x40045CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private Image _imageImgTrainBG;

		[Token(Token = "0x40045CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private Image _imageImgTrainProcess;

		[Token(Token = "0x40045CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private TextMeshProUGUI _textMeshProUGUITxtTrainProcess;

		[Token(Token = "0x40045D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private Image _imageImgUnLockTipBG;

		[Token(Token = "0x40045D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private TextMeshProUGUI _textMeshProUGUITxtTipWinMore;

		[Token(Token = "0x40045D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private TextMeshProUGUI _textMeshProUGUITxtTipToUnlock;

		[Token(Token = "0x170007C1")]
		public Image ImageArenaUIBGItem
		{
			[Token(Token = "0x6003635")]
			[Address(RVA = "0x40CA454", Offset = "0x40C6454", VA = "0x40CA454")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007C2")]
		public ButtonExtend ButtonExtendBtnButtonArena
		{
			[Token(Token = "0x6003636")]
			[Address(RVA = "0x40C57FC", Offset = "0x40C17FC", VA = "0x40C57FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007C3")]
		public RectTransform RectTransformImgIconRoot
		{
			[Token(Token = "0x6003637")]
			[Address(RVA = "0x40C2EC8", Offset = "0x40BEEC8", VA = "0x40C2EC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007C4")]
		public Image ImageImgFrontIcon
		{
			[Token(Token = "0x6003638")]
			[Address(RVA = "0x40CA4F8", Offset = "0x40C64F8", VA = "0x40CA4F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007C5")]
		public Image ImageImgTitleBg
		{
			[Token(Token = "0x6003639")]
			[Address(RVA = "0x40CA134", Offset = "0x40C6134", VA = "0x40CA134")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007C6")]
		public RectTransform RectTransformTopProgressBG
		{
			[Token(Token = "0x600363A")]
			[Address(RVA = "0x40C738C", Offset = "0x40C338C", VA = "0x40C738C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007C7")]
		public Image ImageCompleteProgress
		{
			[Token(Token = "0x600363B")]
			[Address(RVA = "0x40C3F6C", Offset = "0x40BFF6C", VA = "0x40C3F6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007C8")]
		public TextMeshProUGUI TextMeshProUGUITxtProgress
		{
			[Token(Token = "0x600363C")]
			[Address(RVA = "0x40C3EA4", Offset = "0x40BFEA4", VA = "0x40C3EA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007C9")]
		public TextMeshProUGUI TextMeshProUGUITxtLoss
		{
			[Token(Token = "0x600363D")]
			[Address(RVA = "0x40CAB38", Offset = "0x40C6B38", VA = "0x40CAB38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007CA")]
		public TextMeshProUGUI TextMeshProUGUITxtLossCount
		{
			[Token(Token = "0x600363E")]
			[Address(RVA = "0x40CA818", Offset = "0x40C6818", VA = "0x40CA818")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007CB")]
		public RectTransform RectTransformImgBlackMaskLeft
		{
			[Token(Token = "0x600363F")]
			[Address(RVA = "0x40C4DBC", Offset = "0x40C0DBC", VA = "0x40C4DBC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007CC")]
		public TextMeshProUGUI TextMeshProUGUITxtWin
		{
			[Token(Token = "0x6003640")]
			[Address(RVA = "0x40CAA70", Offset = "0x40C6A70", VA = "0x40CAA70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007CD")]
		public TextMeshProUGUI TextMeshProUGUITxtWinCount
		{
			[Token(Token = "0x6003641")]
			[Address(RVA = "0x40CA750", Offset = "0x40C6750", VA = "0x40CA750")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007CE")]
		public RectTransform RectTransformImgBlackMaskRight
		{
			[Token(Token = "0x6003642")]
			[Address(RVA = "0x40C4E84", Offset = "0x40C0E84", VA = "0x40C4E84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007CF")]
		public TextMeshProUGUI TextMeshProUGUITxtTitle
		{
			[Token(Token = "0x6003643")]
			[Address(RVA = "0x40CA688", Offset = "0x40C6688", VA = "0x40CA688")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007D0")]
		public RectTransform RectTransformBotRewardBG
		{
			[Token(Token = "0x6003644")]
			[Address(RVA = "0x40C4B70", Offset = "0x40C0B70", VA = "0x40C4B70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007D1")]
		public Button ButtonBotRewardBG
		{
			[Token(Token = "0x6003645")]
			[Address(RVA = "0x40CAC0C", Offset = "0x40C6C0C", VA = "0x40CAC0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007D2")]
		public TextMeshProUGUI TextMeshProUGUITxtRewardDes
		{
			[Token(Token = "0x6003646")]
			[Address(RVA = "0x40C7DC0", Offset = "0x40C3DC0", VA = "0x40C7DC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007D3")]
		public TextMeshProUGUI TextMeshProUGUITxtCompleteRewardDes
		{
			[Token(Token = "0x6003647")]
			[Address(RVA = "0x40C7F50", Offset = "0x40C3F50", VA = "0x40C7F50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007D4")]
		public RectTransform RectTransformRewardCoinBG
		{
			[Token(Token = "0x6003648")]
			[Address(RVA = "0x40C41E4", Offset = "0x40C01E4", VA = "0x40C41E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007D5")]
		public TextMeshProUGUI TextMeshProUGUITxtCoinRewardCount
		{
			[Token(Token = "0x6003649")]
			[Address(RVA = "0x40C2BE0", Offset = "0x40BEBE0", VA = "0x40C2BE0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007D6")]
		public RectTransform RectTransformImgCoinDouble
		{
			[Token(Token = "0x600364A")]
			[Address(RVA = "0x40C5038", Offset = "0x40C1038", VA = "0x40C5038")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007D7")]
		public RectTransform RectTransformRewardDiamondBG
		{
			[Token(Token = "0x600364B")]
			[Address(RVA = "0x40C4390", Offset = "0x40C0390", VA = "0x40C4390")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007D8")]
		public TextMeshProUGUI TextMeshProUGUITxtDiamondRewardCount
		{
			[Token(Token = "0x600364C")]
			[Address(RVA = "0x40C7E88", Offset = "0x40C3E88", VA = "0x40C7E88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007D9")]
		public RectTransform RectTransformImgDiamondDouble
		{
			[Token(Token = "0x600364D")]
			[Address(RVA = "0x40C51EC", Offset = "0x40C11EC", VA = "0x40C51EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007DA")]
		public RectTransform RectTransformRewardBoxBG
		{
			[Token(Token = "0x600364E")]
			[Address(RVA = "0x40C453C", Offset = "0x40C053C", VA = "0x40C453C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007DB")]
		public Image ImageRewardBoxBG
		{
			[Token(Token = "0x600364F")]
			[Address(RVA = "0x40C8018", Offset = "0x40C4018", VA = "0x40C8018")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007DC")]
		public RectTransform RectTransformImgBoxDouble
		{
			[Token(Token = "0x6003650")]
			[Address(RVA = "0x40C53A0", Offset = "0x40C13A0", VA = "0x40C53A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007DD")]
		public Image ImageImgUnchart
		{
			[Token(Token = "0x6003651")]
			[Address(RVA = "0x40C80E0", Offset = "0x40C40E0", VA = "0x40C80E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007DE")]
		public Image ImageImgExclamationMark
		{
			[Token(Token = "0x6003652")]
			[Address(RVA = "0x40CA5C0", Offset = "0x40C65C0", VA = "0x40CA5C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007DF")]
		public RectTransform RectTransformBlackFrontBG
		{
			[Token(Token = "0x6003653")]
			[Address(RVA = "0x40C634C", Offset = "0x40C234C", VA = "0x40C634C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007E0")]
		public Image ImageBlackFrontBG
		{
			[Token(Token = "0x6003654")]
			[Address(RVA = "0x40C706C", Offset = "0x40C306C", VA = "0x40C706C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007E1")]
		public RectTransform RectTransformImgLockIcon
		{
			[Token(Token = "0x6003655")]
			[Address(RVA = "0x40C61A8", Offset = "0x40C21A8", VA = "0x40C61A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007E2")]
		public Image ImageImgLockIcon
		{
			[Token(Token = "0x6003656")]
			[Address(RVA = "0x40C7134", Offset = "0x40C3134", VA = "0x40C7134")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007E3")]
		public RectTransform RectTransformStartBtn
		{
			[Token(Token = "0x6003657")]
			[Address(RVA = "0x40C71FC", Offset = "0x40C31FC", VA = "0x40C71FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007E4")]
		public ButtonExtend ButtonExtendStartBtn
		{
			[Token(Token = "0x6003658")]
			[Address(RVA = "0x40C22BC", Offset = "0x40BE2BC", VA = "0x40C22BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007E5")]
		public RectTransform RectTransformSatrtText
		{
			[Token(Token = "0x6003659")]
			[Address(RVA = "0x40C3AAC", Offset = "0x40BFAAC", VA = "0x40C3AAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007E6")]
		public TextMeshProUGUI TextMeshProUGUISatrtText
		{
			[Token(Token = "0x600365A")]
			[Address(RVA = "0x40C3C3C", Offset = "0x40BFC3C", VA = "0x40C3C3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007E7")]
		public TextMeshProUGUI TextMeshProUGUITxtCoinFee
		{
			[Token(Token = "0x600365B")]
			[Address(RVA = "0x40C3B74", Offset = "0x40BFB74", VA = "0x40C3B74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007E8")]
		public Image ImageImgStartBtnLeft
		{
			[Token(Token = "0x600365C")]
			[Address(RVA = "0x40C23A0", Offset = "0x40BE3A0", VA = "0x40C23A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007E9")]
		public Image ImageImgStartBtnRight
		{
			[Token(Token = "0x600365D")]
			[Address(RVA = "0x40C2484", Offset = "0x40BE484", VA = "0x40C2484")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007EA")]
		public Image ImageImgAvailableBG
		{
			[Token(Token = "0x600365E")]
			[Address(RVA = "0x40C36C4", Offset = "0x40BF6C4", VA = "0x40C36C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007EB")]
		public GridLayoutMiddleCenter GridLayoutMiddleCenterLimits
		{
			[Token(Token = "0x600365F")]
			[Address(RVA = "0x40C39E4", Offset = "0x40BF9E4", VA = "0x40C39E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007EC")]
		public TextMeshProUGUI TextMeshProUGUITxtSeasonScoreLimit
		{
			[Token(Token = "0x6003660")]
			[Address(RVA = "0x40C3854", Offset = "0x40BF854", VA = "0x40C3854")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007ED")]
		public RectTransform RectTransformTxtChestLimit
		{
			[Token(Token = "0x6003661")]
			[Address(RVA = "0x40C3D04", Offset = "0x40BFD04", VA = "0x40C3D04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007EE")]
		public TextMeshProUGUI TextMeshProUGUITxtChestLimit
		{
			[Token(Token = "0x6003662")]
			[Address(RVA = "0x40C391C", Offset = "0x40BF91C", VA = "0x40C391C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007EF")]
		public TextMeshProUGUI TextMeshProUGUITxtCoinLimit
		{
			[Token(Token = "0x6003663")]
			[Address(RVA = "0x40C378C", Offset = "0x40BF78C", VA = "0x40C378C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007F0")]
		public Image ImageImgTrainBG
		{
			[Token(Token = "0x6003664")]
			[Address(RVA = "0x40CA1FC", Offset = "0x40C61FC", VA = "0x40CA1FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007F1")]
		public Image ImageImgTrainProcess
		{
			[Token(Token = "0x6003665")]
			[Address(RVA = "0x40CA2C4", Offset = "0x40C62C4", VA = "0x40CA2C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007F2")]
		public TextMeshProUGUI TextMeshProUGUITxtTrainProcess
		{
			[Token(Token = "0x6003666")]
			[Address(RVA = "0x40CA38C", Offset = "0x40C638C", VA = "0x40CA38C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007F3")]
		public Image ImageImgUnLockTipBG
		{
			[Token(Token = "0x6003667")]
			[Address(RVA = "0x40C72C4", Offset = "0x40C32C4", VA = "0x40C72C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007F4")]
		public TextMeshProUGUI TextMeshProUGUITxtTipWinMore
		{
			[Token(Token = "0x6003668")]
			[Address(RVA = "0x40CA8E0", Offset = "0x40C68E0", VA = "0x40CA8E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007F5")]
		public TextMeshProUGUI TextMeshProUGUITxtTipToUnlock
		{
			[Token(Token = "0x6003669")]
			[Address(RVA = "0x40CA9A8", Offset = "0x40C69A8", VA = "0x40CA9A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600366A")]
		[Address(RVA = "0x40CACD4", Offset = "0x40C6CD4", VA = "0x40CACD4")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x600366B")]
		[Address(RVA = "0x40CADEC", Offset = "0x40C6DEC", VA = "0x40CADEC", Slot = "12")]
		protected virtual void OnButtonExtendBtnButtonArenaClicked()
		{
		}

		[Token(Token = "0x600366C")]
		[Address(RVA = "0x40C5A5C", Offset = "0x40C1A5C", VA = "0x40C5A5C", Slot = "13")]
		protected virtual void OnButtonBotRewardBGClicked()
		{
		}

		[Token(Token = "0x600366D")]
		[Address(RVA = "0x40CAE58", Offset = "0x40C6E58", VA = "0x40CAE58", Slot = "14")]
		protected virtual void OnButtonExtendStartBtnClicked()
		{
		}

		[Token(Token = "0x600366E")]
		[Address(RVA = "0x40C2A14", Offset = "0x40BEA14", VA = "0x40C2A14", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600366F")]
		[Address(RVA = "0x40CAEC4", Offset = "0x40C6EC4", VA = "0x40CAEC4", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__836))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6003670")]
		[Address(RVA = "0x40CAF58", Offset = "0x40C6F58", VA = "0x40CAF58", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6003671")]
		[Address(RVA = "0x40C68F0", Offset = "0x40C28F0", VA = "0x40C68F0")]
		public ArenaUIBGItemComponents()
		{
		}
	}
}
