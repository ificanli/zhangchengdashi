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
	[Token(Token = "0x2000C32")]
	public class WeeklyClashSettlementPopupPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000C33")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__638 : IAsyncStateMachine
		{
			[Token(Token = "0x40057DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40057DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40057DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public WeeklyClashSettlementPopupPanelComponents _003C_003E4__this;

			[Token(Token = "0x40057DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6004B9C")]
			[Address(RVA = "0x426C0C4", Offset = "0x42680C4", VA = "0x426C0C4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004B9D")]
			[Address(RVA = "0x426C33C", Offset = "0x426833C", VA = "0x426C33C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40057C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Image _imageSeasonIconLight;

		[Token(Token = "0x40057C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Image _imageWeekIconLight;

		[Token(Token = "0x40057C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Image _imageSeasonIcon;

		[Token(Token = "0x40057C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private RectTransform _rectTransformTitle;

		[Token(Token = "0x40057C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TextMeshProUGUI _textMeshProUGUITitle3;

		[Token(Token = "0x40057C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Image _imageBGCenter_Week;

		[Token(Token = "0x40057C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Image _imageBGCenter_Season;

		[Token(Token = "0x40057C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Image _imageScoreIconShadow;

		[Token(Token = "0x40057C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Image _imageScoreIcon;

		[Token(Token = "0x40057CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private TextMeshProUGUI _textMeshProUGUIRankShadow;

		[Token(Token = "0x40057CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private TextMeshProUGUI _textMeshProUGUIRank;

		[Token(Token = "0x40057CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private TextMeshProUGUI _textMeshProUGUITitle2Shadow;

		[Token(Token = "0x40057CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private TextMeshProUGUI _textMeshProUGUITitle2;

		[Token(Token = "0x40057CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private RectTransform _rectTransformWeekTitle;

		[Token(Token = "0x40057CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Image _imageIcon;

		[Token(Token = "0x40057D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private TextMeshProUGUI _textMeshProUGUIWeek_ScoreNumber;

		[Token(Token = "0x40057D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private RectTransform _rectTransformSeasonTitle;

		[Token(Token = "0x40057D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private TextMeshProUGUI _textMeshProUGUISeason_ScoreNumber;

		[Token(Token = "0x40057D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Image _imageRewardBG;

		[Token(Token = "0x40057D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private RectTransform _rectTransformRewardTitle;

		[Token(Token = "0x40057D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private ScrollRect _scrollRectRewardItemUIScrollView;

		[Token(Token = "0x40057D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private RewardItemUIScrollView _rewardItemUIScrollViewRewardItemUIScrollView;

		[Token(Token = "0x40057D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private ButtonExtend _buttonExtendShowDes;

		[Token(Token = "0x40057D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Image _imageClaimBtnBG;

		[Token(Token = "0x40057D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private ButtonExtend _buttonExtendClaimBtn;

		[Token(Token = "0x17000D53")]
		public Image ImageSeasonIconLight
		{
			[Token(Token = "0x6004B7A")]
			[Address(RVA = "0x4269B18", Offset = "0x4265B18", VA = "0x4269B18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D54")]
		public Image ImageWeekIconLight
		{
			[Token(Token = "0x6004B7B")]
			[Address(RVA = "0x4269BE0", Offset = "0x4265BE0", VA = "0x4269BE0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D55")]
		public Image ImageSeasonIcon
		{
			[Token(Token = "0x6004B7C")]
			[Address(RVA = "0x426A608", Offset = "0x4266608", VA = "0x426A608")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D56")]
		public RectTransform RectTransformTitle
		{
			[Token(Token = "0x6004B7D")]
			[Address(RVA = "0x4269D70", Offset = "0x4265D70", VA = "0x4269D70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D57")]
		public TextMeshProUGUI TextMeshProUGUITitle3
		{
			[Token(Token = "0x6004B7E")]
			[Address(RVA = "0x426A158", Offset = "0x4266158", VA = "0x426A158")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D58")]
		public Image ImageBGCenter_Week
		{
			[Token(Token = "0x6004B7F")]
			[Address(RVA = "0x4269E38", Offset = "0x4265E38", VA = "0x4269E38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D59")]
		public Image ImageBGCenter_Season
		{
			[Token(Token = "0x6004B80")]
			[Address(RVA = "0x4269F00", Offset = "0x4265F00", VA = "0x4269F00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D5A")]
		public Image ImageScoreIconShadow
		{
			[Token(Token = "0x6004B81")]
			[Address(RVA = "0x426A798", Offset = "0x4266798", VA = "0x426A798")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D5B")]
		public Image ImageScoreIcon
		{
			[Token(Token = "0x6004B82")]
			[Address(RVA = "0x426A6D0", Offset = "0x42666D0", VA = "0x426A6D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D5C")]
		public TextMeshProUGUI TextMeshProUGUIRankShadow
		{
			[Token(Token = "0x6004B83")]
			[Address(RVA = "0x426A2E8", Offset = "0x42662E8", VA = "0x426A2E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D5D")]
		public TextMeshProUGUI TextMeshProUGUIRank
		{
			[Token(Token = "0x6004B84")]
			[Address(RVA = "0x426A220", Offset = "0x4266220", VA = "0x426A220")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D5E")]
		public TextMeshProUGUI TextMeshProUGUITitle2Shadow
		{
			[Token(Token = "0x6004B85")]
			[Address(RVA = "0x426A090", Offset = "0x4266090", VA = "0x426A090")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D5F")]
		public TextMeshProUGUI TextMeshProUGUITitle2
		{
			[Token(Token = "0x6004B86")]
			[Address(RVA = "0x4269FC8", Offset = "0x4265FC8", VA = "0x4269FC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D60")]
		public RectTransform RectTransformWeekTitle
		{
			[Token(Token = "0x6004B87")]
			[Address(RVA = "0x426A3B0", Offset = "0x42663B0", VA = "0x426A3B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D61")]
		public Image ImageIcon
		{
			[Token(Token = "0x6004B88")]
			[Address(RVA = "0x4269CA8", Offset = "0x4265CA8", VA = "0x4269CA8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D62")]
		public TextMeshProUGUI TextMeshProUGUIWeek_ScoreNumber
		{
			[Token(Token = "0x6004B89")]
			[Address(RVA = "0x426BB14", Offset = "0x4267B14", VA = "0x426BB14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D63")]
		public RectTransform RectTransformSeasonTitle
		{
			[Token(Token = "0x6004B8A")]
			[Address(RVA = "0x426A478", Offset = "0x4266478", VA = "0x426A478")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D64")]
		public TextMeshProUGUI TextMeshProUGUISeason_ScoreNumber
		{
			[Token(Token = "0x6004B8B")]
			[Address(RVA = "0x426BBDC", Offset = "0x4267BDC", VA = "0x426BBDC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D65")]
		public Image ImageRewardBG
		{
			[Token(Token = "0x6004B8C")]
			[Address(RVA = "0x426A9F0", Offset = "0x42669F0", VA = "0x426A9F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D66")]
		public RectTransform RectTransformRewardTitle
		{
			[Token(Token = "0x6004B8D")]
			[Address(RVA = "0x426A860", Offset = "0x4266860", VA = "0x426A860")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D67")]
		public ScrollRect ScrollRectRewardItemUIScrollView
		{
			[Token(Token = "0x6004B8E")]
			[Address(RVA = "0x426BCB0", Offset = "0x4267CB0", VA = "0x426BCB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D68")]
		public RewardItemUIScrollView RewardItemUIScrollViewRewardItemUIScrollView
		{
			[Token(Token = "0x6004B8F")]
			[Address(RVA = "0x426A928", Offset = "0x4266928", VA = "0x426A928")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D69")]
		public ButtonExtend ButtonExtendShowDes
		{
			[Token(Token = "0x6004B90")]
			[Address(RVA = "0x426BD78", Offset = "0x4267D78", VA = "0x426BD78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D6A")]
		public Image ImageClaimBtnBG
		{
			[Token(Token = "0x6004B91")]
			[Address(RVA = "0x426AAB8", Offset = "0x4266AB8", VA = "0x426AAB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D6B")]
		public ButtonExtend ButtonExtendClaimBtn
		{
			[Token(Token = "0x6004B92")]
			[Address(RVA = "0x426A540", Offset = "0x4266540", VA = "0x426A540")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004B93")]
		[Address(RVA = "0x426BE40", Offset = "0x4267E40", VA = "0x426BE40")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6004B94")]
		[Address(RVA = "0x426BF80", Offset = "0x4267F80", VA = "0x426BF80", Slot = "12")]
		protected virtual void OnScrollRectRewardItemUIScrollViewValueChanged(Vector2 arg)
		{
		}

		[Token(Token = "0x6004B95")]
		[Address(RVA = "0x426C034", Offset = "0x4268034", VA = "0x426C034", Slot = "13")]
		protected virtual void OnButtonExtendShowDesClicked()
		{
		}

		[Token(Token = "0x6004B96")]
		[Address(RVA = "0x426AC00", Offset = "0x4266C00", VA = "0x426AC00", Slot = "14")]
		protected virtual void OnButtonExtendClaimBtnClicked()
		{
		}

		[Token(Token = "0x6004B97")]
		[Address(RVA = "0x426C0A0", Offset = "0x42680A0", VA = "0x426C0A0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6004B98")]
		[Address(RVA = "0x426AE64", Offset = "0x4266E64", VA = "0x426AE64", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__638))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6004B99")]
		[Address(RVA = "0x426AD9C", Offset = "0x4266D9C", VA = "0x426AD9C", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6004B9A")]
		[Address(RVA = "0x426AE58", Offset = "0x4266E58", VA = "0x426AE58")]
		public WeeklyClashSettlementPopupPanelComponents()
		{
		}
	}
}
