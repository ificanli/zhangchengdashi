using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using TMPro;
using UIFramework;
using UIModuleO.UIAnim;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000BAF")]
	public class TrophyProgressItem_ArenaComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000BB0")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__741 : IAsyncStateMachine
		{
			[Token(Token = "0x4005500")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005501")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005502")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public TrophyProgressItem_ArenaComponents _003C_003E4__this;

			[Token(Token = "0x4005503")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60047F9")]
			[Address(RVA = "0x422F2CC", Offset = "0x422B2CC", VA = "0x422F2CC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60047FA")]
			[Address(RVA = "0x422F544", Offset = "0x422B544", VA = "0x422F544", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40054CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RectTransform _rectTransformTrophyProgressItem_Arena;

		[Token(Token = "0x40054D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Image _imageImgArenaIcon;

		[Token(Token = "0x40054D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TextMeshProUGUI _textMeshProUGUIArenaTitle;

		[Token(Token = "0x40054D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private TextMeshProUGUI _textMeshProUGUITrophyRequire;

		[Token(Token = "0x40054D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TextMeshProUGUI _textMeshProUGUIRewardTitle;

		[Token(Token = "0x40054D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private ButtonExtend _buttonExtendBtnClaimCompleteReward;

		[Token(Token = "0x40054D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RectTransform _rectTransformImgCoinRewardBg;

		[Token(Token = "0x40054D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private DOTweenAnimation _dOTweenAnimationImgCoinRewardBg;

		[Token(Token = "0x40054D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private TextMeshProUGUI _textMeshProUGUITxtCoinNum;

		[Token(Token = "0x40054D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Image _imageImgCoinDuiHao;

		[Token(Token = "0x40054D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Image _imageImgCoinLockIcon;

		[Token(Token = "0x40054DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Image _imageRedDot_UICoin;

		[Token(Token = "0x40054DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private RectTransform _rectTransformImgGemRewardBg;

		[Token(Token = "0x40054DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private DOTweenAnimation _dOTweenAnimationImgGemRewardBg;

		[Token(Token = "0x40054DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private TextMeshProUGUI _textMeshProUGUITxtGemNum;

		[Token(Token = "0x40054DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Image _imageImgGemDuiHao;

		[Token(Token = "0x40054DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Image _imageImgGemLockIcon;

		[Token(Token = "0x40054E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Image _imageRedDot_UIGem;

		[Token(Token = "0x40054E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private RectTransform _rectTransformImgBoxRewardBg;

		[Token(Token = "0x40054E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private DOTweenAnimation _dOTweenAnimationImgBoxRewardBg;

		[Token(Token = "0x40054E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Image _imageImgBoxIcon;

		[Token(Token = "0x40054E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private TextMeshProUGUI _textMeshProUGUITxtBoxNum;

		[Token(Token = "0x40054E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Image _imageImgBoxDuiHao;

		[Token(Token = "0x40054E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Image _imageImgBoxLockIcon;

		[Token(Token = "0x40054E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Image _imageRedDot_UIBox;

		[Token(Token = "0x40054E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private RectTransform _rectTransformCard;

		[Token(Token = "0x40054E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private RectTransform _rectTransformRewardRoot;

		[Token(Token = "0x40054EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Image _imageRewardRoot;

		[Token(Token = "0x40054EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private TextMeshProUGUI _textMeshProUGUITxtChooseOne;

		[Token(Token = "0x40054EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private RectTransform _rectTransformBtnRewardOne;

		[Token(Token = "0x40054ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private ButtonExtend _buttonExtendBtnRewardOne;

		[Token(Token = "0x40054EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private DOTweenAnimation _dOTweenAnimationBtnRewardOne;

		[Token(Token = "0x40054EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Image _imageImgSelectReward1LockIcon;

		[Token(Token = "0x40054F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private RectTransform _rectTransformBtnRewardTwo;

		[Token(Token = "0x40054F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private ButtonExtend _buttonExtendBtnRewardTwo;

		[Token(Token = "0x40054F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private DOTweenAnimation _dOTweenAnimationBtnRewardTwo;

		[Token(Token = "0x40054F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Image _imageImgSelectReward2LockIcon;

		[Token(Token = "0x40054F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private RectTransform _rectTransformBtnRewardThere;

		[Token(Token = "0x40054F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private ButtonExtend _buttonExtendBtnRewardThere;

		[Token(Token = "0x40054F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private DOTweenAnimation _dOTweenAnimationBtnRewardThere;

		[Token(Token = "0x40054F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private Image _imageImgSelectReward3LockIcon;

		[Token(Token = "0x40054F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private RectTransform _rectTransformUnlockFunction;

		[Token(Token = "0x40054F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private Image _imageUnlockFunction;

		[Token(Token = "0x40054FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private TextMeshProUGUI _textMeshProUGUIUnlockFunctionText;

		[Token(Token = "0x40054FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private RectTransform _rectTransformProgressBarRoot;

		[Token(Token = "0x40054FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private RectTransform _rectTransformProgressHistory;

		[Token(Token = "0x40054FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private RectTransform _rectTransformProgressOwn;

		[Token(Token = "0x40054FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private RectTransform _rectTransformProgressOwnBubble;

		[Token(Token = "0x40054FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private TextMeshProUGUI _textMeshProUGUIProgressOwnBubbleText;

		[Token(Token = "0x17000C2A")]
		public RectTransform RectTransformTrophyProgressItem_Arena
		{
			[Token(Token = "0x60047BE")]
			[Address(RVA = "0x422CA38", Offset = "0x4228A38", VA = "0x422CA38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C2B")]
		public Image ImageImgArenaIcon
		{
			[Token(Token = "0x60047BF")]
			[Address(RVA = "0x422B54C", Offset = "0x422754C", VA = "0x422B54C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C2C")]
		public TextMeshProUGUI TextMeshProUGUIArenaTitle
		{
			[Token(Token = "0x60047C0")]
			[Address(RVA = "0x422CB24", Offset = "0x4228B24", VA = "0x422CB24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C2D")]
		public TextMeshProUGUI TextMeshProUGUITrophyRequire
		{
			[Token(Token = "0x60047C1")]
			[Address(RVA = "0x422CBEC", Offset = "0x4228BEC", VA = "0x422CBEC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C2E")]
		public TextMeshProUGUI TextMeshProUGUIRewardTitle
		{
			[Token(Token = "0x60047C2")]
			[Address(RVA = "0x422CCB4", Offset = "0x4228CB4", VA = "0x422CCB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C2F")]
		public ButtonExtend ButtonExtendBtnClaimCompleteReward
		{
			[Token(Token = "0x60047C3")]
			[Address(RVA = "0x422CD7C", Offset = "0x4228D7C", VA = "0x422CD7C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C30")]
		public RectTransform RectTransformImgCoinRewardBg
		{
			[Token(Token = "0x60047C4")]
			[Address(RVA = "0x422CE44", Offset = "0x4228E44", VA = "0x422CE44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C31")]
		public DOTweenAnimation DOTweenAnimationImgCoinRewardBg
		{
			[Token(Token = "0x60047C5")]
			[Address(RVA = "0x422CF0C", Offset = "0x4228F0C", VA = "0x422CF0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C32")]
		public TextMeshProUGUI TextMeshProUGUITxtCoinNum
		{
			[Token(Token = "0x60047C6")]
			[Address(RVA = "0x422CFD4", Offset = "0x4228FD4", VA = "0x422CFD4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C33")]
		public Image ImageImgCoinDuiHao
		{
			[Token(Token = "0x60047C7")]
			[Address(RVA = "0x422D09C", Offset = "0x422909C", VA = "0x422D09C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C34")]
		public Image ImageImgCoinLockIcon
		{
			[Token(Token = "0x60047C8")]
			[Address(RVA = "0x422D164", Offset = "0x4229164", VA = "0x422D164")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C35")]
		public Image ImageRedDot_UICoin
		{
			[Token(Token = "0x60047C9")]
			[Address(RVA = "0x422D22C", Offset = "0x422922C", VA = "0x422D22C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C36")]
		public RectTransform RectTransformImgGemRewardBg
		{
			[Token(Token = "0x60047CA")]
			[Address(RVA = "0x422D2F4", Offset = "0x42292F4", VA = "0x422D2F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C37")]
		public DOTweenAnimation DOTweenAnimationImgGemRewardBg
		{
			[Token(Token = "0x60047CB")]
			[Address(RVA = "0x422D3BC", Offset = "0x42293BC", VA = "0x422D3BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C38")]
		public TextMeshProUGUI TextMeshProUGUITxtGemNum
		{
			[Token(Token = "0x60047CC")]
			[Address(RVA = "0x422D484", Offset = "0x4229484", VA = "0x422D484")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C39")]
		public Image ImageImgGemDuiHao
		{
			[Token(Token = "0x60047CD")]
			[Address(RVA = "0x422D54C", Offset = "0x422954C", VA = "0x422D54C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C3A")]
		public Image ImageImgGemLockIcon
		{
			[Token(Token = "0x60047CE")]
			[Address(RVA = "0x422D614", Offset = "0x4229614", VA = "0x422D614")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C3B")]
		public Image ImageRedDot_UIGem
		{
			[Token(Token = "0x60047CF")]
			[Address(RVA = "0x422D6DC", Offset = "0x42296DC", VA = "0x422D6DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C3C")]
		public RectTransform RectTransformImgBoxRewardBg
		{
			[Token(Token = "0x60047D0")]
			[Address(RVA = "0x422D7A4", Offset = "0x42297A4", VA = "0x422D7A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C3D")]
		public DOTweenAnimation DOTweenAnimationImgBoxRewardBg
		{
			[Token(Token = "0x60047D1")]
			[Address(RVA = "0x422D86C", Offset = "0x422986C", VA = "0x422D86C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C3E")]
		public Image ImageImgBoxIcon
		{
			[Token(Token = "0x60047D2")]
			[Address(RVA = "0x422C0D4", Offset = "0x42280D4", VA = "0x422C0D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C3F")]
		public TextMeshProUGUI TextMeshProUGUITxtBoxNum
		{
			[Token(Token = "0x60047D3")]
			[Address(RVA = "0x422D934", Offset = "0x4229934", VA = "0x422D934")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C40")]
		public Image ImageImgBoxDuiHao
		{
			[Token(Token = "0x60047D4")]
			[Address(RVA = "0x422D9FC", Offset = "0x42299FC", VA = "0x422D9FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C41")]
		public Image ImageImgBoxLockIcon
		{
			[Token(Token = "0x60047D5")]
			[Address(RVA = "0x422DAC4", Offset = "0x4229AC4", VA = "0x422DAC4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C42")]
		public Image ImageRedDot_UIBox
		{
			[Token(Token = "0x60047D6")]
			[Address(RVA = "0x422DB8C", Offset = "0x4229B8C", VA = "0x422DB8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C43")]
		public RectTransform RectTransformCard
		{
			[Token(Token = "0x60047D7")]
			[Address(RVA = "0x422DC54", Offset = "0x4229C54", VA = "0x422DC54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C44")]
		public RectTransform RectTransformRewardRoot
		{
			[Token(Token = "0x60047D8")]
			[Address(RVA = "0x422DD1C", Offset = "0x4229D1C", VA = "0x422DD1C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C45")]
		public Image ImageRewardRoot
		{
			[Token(Token = "0x60047D9")]
			[Address(RVA = "0x422DDE4", Offset = "0x4229DE4", VA = "0x422DDE4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C46")]
		public TextMeshProUGUI TextMeshProUGUITxtChooseOne
		{
			[Token(Token = "0x60047DA")]
			[Address(RVA = "0x422DEAC", Offset = "0x4229EAC", VA = "0x422DEAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C47")]
		public RectTransform RectTransformBtnRewardOne
		{
			[Token(Token = "0x60047DB")]
			[Address(RVA = "0x422DF74", Offset = "0x4229F74", VA = "0x422DF74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C48")]
		public ButtonExtend ButtonExtendBtnRewardOne
		{
			[Token(Token = "0x60047DC")]
			[Address(RVA = "0x422E03C", Offset = "0x422A03C", VA = "0x422E03C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C49")]
		public DOTweenAnimation DOTweenAnimationBtnRewardOne
		{
			[Token(Token = "0x60047DD")]
			[Address(RVA = "0x422E104", Offset = "0x422A104", VA = "0x422E104")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C4A")]
		public Image ImageImgSelectReward1LockIcon
		{
			[Token(Token = "0x60047DE")]
			[Address(RVA = "0x422E1CC", Offset = "0x422A1CC", VA = "0x422E1CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C4B")]
		public RectTransform RectTransformBtnRewardTwo
		{
			[Token(Token = "0x60047DF")]
			[Address(RVA = "0x422E294", Offset = "0x422A294", VA = "0x422E294")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C4C")]
		public ButtonExtend ButtonExtendBtnRewardTwo
		{
			[Token(Token = "0x60047E0")]
			[Address(RVA = "0x422E35C", Offset = "0x422A35C", VA = "0x422E35C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C4D")]
		public DOTweenAnimation DOTweenAnimationBtnRewardTwo
		{
			[Token(Token = "0x60047E1")]
			[Address(RVA = "0x422E424", Offset = "0x422A424", VA = "0x422E424")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C4E")]
		public Image ImageImgSelectReward2LockIcon
		{
			[Token(Token = "0x60047E2")]
			[Address(RVA = "0x422E4EC", Offset = "0x422A4EC", VA = "0x422E4EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C4F")]
		public RectTransform RectTransformBtnRewardThere
		{
			[Token(Token = "0x60047E3")]
			[Address(RVA = "0x422E5B4", Offset = "0x422A5B4", VA = "0x422E5B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C50")]
		public ButtonExtend ButtonExtendBtnRewardThere
		{
			[Token(Token = "0x60047E4")]
			[Address(RVA = "0x422E67C", Offset = "0x422A67C", VA = "0x422E67C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C51")]
		public DOTweenAnimation DOTweenAnimationBtnRewardThere
		{
			[Token(Token = "0x60047E5")]
			[Address(RVA = "0x422E744", Offset = "0x422A744", VA = "0x422E744")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C52")]
		public Image ImageImgSelectReward3LockIcon
		{
			[Token(Token = "0x60047E6")]
			[Address(RVA = "0x422E80C", Offset = "0x422A80C", VA = "0x422E80C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C53")]
		public RectTransform RectTransformUnlockFunction
		{
			[Token(Token = "0x60047E7")]
			[Address(RVA = "0x422E8D4", Offset = "0x422A8D4", VA = "0x422E8D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C54")]
		public Image ImageUnlockFunction
		{
			[Token(Token = "0x60047E8")]
			[Address(RVA = "0x422C19C", Offset = "0x422819C", VA = "0x422C19C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C55")]
		public TextMeshProUGUI TextMeshProUGUIUnlockFunctionText
		{
			[Token(Token = "0x60047E9")]
			[Address(RVA = "0x422E99C", Offset = "0x422A99C", VA = "0x422E99C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C56")]
		public RectTransform RectTransformProgressBarRoot
		{
			[Token(Token = "0x60047EA")]
			[Address(RVA = "0x422EA64", Offset = "0x422AA64", VA = "0x422EA64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C57")]
		public RectTransform RectTransformProgressHistory
		{
			[Token(Token = "0x60047EB")]
			[Address(RVA = "0x422EB2C", Offset = "0x422AB2C", VA = "0x422EB2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C58")]
		public RectTransform RectTransformProgressOwn
		{
			[Token(Token = "0x60047EC")]
			[Address(RVA = "0x422EBF4", Offset = "0x422ABF4", VA = "0x422EBF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C59")]
		public RectTransform RectTransformProgressOwnBubble
		{
			[Token(Token = "0x60047ED")]
			[Address(RVA = "0x422ECBC", Offset = "0x422ACBC", VA = "0x422ECBC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C5A")]
		public TextMeshProUGUI TextMeshProUGUIProgressOwnBubbleText
		{
			[Token(Token = "0x60047EE")]
			[Address(RVA = "0x422ED84", Offset = "0x422AD84", VA = "0x422ED84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60047EF")]
		[Address(RVA = "0x422EE4C", Offset = "0x422AE4C", VA = "0x422EE4C")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x60047F0")]
		[Address(RVA = "0x422EFA8", Offset = "0x422AFA8", VA = "0x422EFA8", Slot = "12")]
		protected virtual void OnButtonExtendBtnClaimCompleteRewardClicked()
		{
		}

		[Token(Token = "0x60047F1")]
		[Address(RVA = "0x422F014", Offset = "0x422B014", VA = "0x422F014", Slot = "13")]
		protected virtual void OnButtonExtendBtnRewardOneClicked()
		{
		}

		[Token(Token = "0x60047F2")]
		[Address(RVA = "0x422F080", Offset = "0x422B080", VA = "0x422F080", Slot = "14")]
		protected virtual void OnButtonExtendBtnRewardTwoClicked()
		{
		}

		[Token(Token = "0x60047F3")]
		[Address(RVA = "0x422F0EC", Offset = "0x422B0EC", VA = "0x422F0EC", Slot = "15")]
		protected virtual void OnButtonExtendBtnRewardThereClicked()
		{
		}

		[Token(Token = "0x60047F4")]
		[Address(RVA = "0x422F158", Offset = "0x422B158", VA = "0x422F158", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60047F5")]
		[Address(RVA = "0x422F174", Offset = "0x422B174", VA = "0x422F174", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__741))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60047F6")]
		[Address(RVA = "0x422F208", Offset = "0x422B208", VA = "0x422F208", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60047F7")]
		[Address(RVA = "0x422F2BC", Offset = "0x422B2BC", VA = "0x422F2BC")]
		public TrophyProgressItem_ArenaComponents()
		{
		}
	}
}
