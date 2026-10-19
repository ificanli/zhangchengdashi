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
	[Token(Token = "0x2000BB7")]
	public class TrophyProgressItem_DefaultComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000BB8")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__513 : IAsyncStateMachine
		{
			[Token(Token = "0x400553C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400553D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400553E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public TrophyProgressItem_DefaultComponents _003C_003E4__this;

			[Token(Token = "0x400553F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x600483C")]
			[Address(RVA = "0x4233FE8", Offset = "0x422FFE8", VA = "0x4233FE8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600483D")]
			[Address(RVA = "0x4234260", Offset = "0x4230260", VA = "0x4234260", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4005522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RectTransform _rectTransformProgressBarRoot;

		[Token(Token = "0x4005523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RectTransform _rectTransformProgressHistory;

		[Token(Token = "0x4005524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RectTransform _rectTransformProgressOwn;

		[Token(Token = "0x4005525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private RectTransform _rectTransformProgressOwnBubble;

		[Token(Token = "0x4005526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TextMeshProUGUI _textMeshProUGUIProgressOwnBubbleText;

		[Token(Token = "0x4005527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private TextMeshProUGUI _textMeshProUGUITrophyRequire;

		[Token(Token = "0x4005528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private ButtonExtend _buttonExtendBtnClaimCompleteReward;

		[Token(Token = "0x4005529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private RectTransform _rectTransformImgCoinRewardBg;

		[Token(Token = "0x400552A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private DOTweenAnimation _dOTweenAnimationImgCoinRewardBg;

		[Token(Token = "0x400552B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private TextMeshProUGUI _textMeshProUGUITxtCoinNum;

		[Token(Token = "0x400552C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Image _imageImgCoinDuiHao;

		[Token(Token = "0x400552D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Image _imageImgCoinLockIcon;

		[Token(Token = "0x400552E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Image _imageRedDot_UICoin;

		[Token(Token = "0x400552F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private RectTransform _rectTransformImgGemRewardBg;

		[Token(Token = "0x4005530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private DOTweenAnimation _dOTweenAnimationImgGemRewardBg;

		[Token(Token = "0x4005531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private TextMeshProUGUI _textMeshProUGUITxtGemNum;

		[Token(Token = "0x4005532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Image _imageImgGemDuiHao;

		[Token(Token = "0x4005533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Image _imageImgGemLockIcon;

		[Token(Token = "0x4005534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Image _imageRedDot_UIGem;

		[Token(Token = "0x4005535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private RectTransform _rectTransformImgBoxRewardBg;

		[Token(Token = "0x4005536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private DOTweenAnimation _dOTweenAnimationImgBoxRewardBg;

		[Token(Token = "0x4005537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Image _imageImgBoxIcon;

		[Token(Token = "0x4005538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private TextMeshProUGUI _textMeshProUGUITxtBoxNum;

		[Token(Token = "0x4005539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Image _imageImgBoxDuiHao;

		[Token(Token = "0x400553A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Image _imageImgBoxLockIcon;

		[Token(Token = "0x400553B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Image _imageRedDot_UIBox;

		[Token(Token = "0x17000C5B")]
		public RectTransform RectTransformProgressBarRoot
		{
			[Token(Token = "0x600481B")]
			[Address(RVA = "0x4230C00", Offset = "0x422CC00", VA = "0x4230C00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C5C")]
		public RectTransform RectTransformProgressHistory
		{
			[Token(Token = "0x600481C")]
			[Address(RVA = "0x42315BC", Offset = "0x422D5BC", VA = "0x42315BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C5D")]
		public RectTransform RectTransformProgressOwn
		{
			[Token(Token = "0x600481D")]
			[Address(RVA = "0x42314F4", Offset = "0x422D4F4", VA = "0x42314F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C5E")]
		public RectTransform RectTransformProgressOwnBubble
		{
			[Token(Token = "0x600481E")]
			[Address(RVA = "0x4231684", Offset = "0x422D684", VA = "0x4231684")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C5F")]
		public TextMeshProUGUI TextMeshProUGUIProgressOwnBubbleText
		{
			[Token(Token = "0x600481F")]
			[Address(RVA = "0x423174C", Offset = "0x422D74C", VA = "0x423174C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C60")]
		public TextMeshProUGUI TextMeshProUGUITrophyRequire
		{
			[Token(Token = "0x6004820")]
			[Address(RVA = "0x4230494", Offset = "0x422C494", VA = "0x4230494")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C61")]
		public ButtonExtend ButtonExtendBtnClaimCompleteReward
		{
			[Token(Token = "0x6004821")]
			[Address(RVA = "0x4230A0C", Offset = "0x422CA0C", VA = "0x4230A0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C62")]
		public RectTransform RectTransformImgCoinRewardBg
		{
			[Token(Token = "0x6004822")]
			[Address(RVA = "0x423055C", Offset = "0x422C55C", VA = "0x423055C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C63")]
		public DOTweenAnimation DOTweenAnimationImgCoinRewardBg
		{
			[Token(Token = "0x6004823")]
			[Address(RVA = "0x4231814", Offset = "0x422D814", VA = "0x4231814")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C64")]
		public TextMeshProUGUI TextMeshProUGUITxtCoinNum
		{
			[Token(Token = "0x6004824")]
			[Address(RVA = "0x42307B4", Offset = "0x422C7B4", VA = "0x42307B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C65")]
		public Image ImageImgCoinDuiHao
		{
			[Token(Token = "0x6004825")]
			[Address(RVA = "0x4231CC4", Offset = "0x422DCC4", VA = "0x4231CC4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C66")]
		public Image ImageImgCoinLockIcon
		{
			[Token(Token = "0x6004826")]
			[Address(RVA = "0x4231A6C", Offset = "0x422DA6C", VA = "0x4231A6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C67")]
		public Image ImageRedDot_UICoin
		{
			[Token(Token = "0x6004827")]
			[Address(RVA = "0x4231F1C", Offset = "0x422DF1C", VA = "0x4231F1C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C68")]
		public RectTransform RectTransformImgGemRewardBg
		{
			[Token(Token = "0x6004828")]
			[Address(RVA = "0x4230624", Offset = "0x422C624", VA = "0x4230624")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C69")]
		public DOTweenAnimation DOTweenAnimationImgGemRewardBg
		{
			[Token(Token = "0x6004829")]
			[Address(RVA = "0x42318DC", Offset = "0x422D8DC", VA = "0x42318DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C6A")]
		public TextMeshProUGUI TextMeshProUGUITxtGemNum
		{
			[Token(Token = "0x600482A")]
			[Address(RVA = "0x423087C", Offset = "0x422C87C", VA = "0x423087C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C6B")]
		public Image ImageImgGemDuiHao
		{
			[Token(Token = "0x600482B")]
			[Address(RVA = "0x4231D8C", Offset = "0x422DD8C", VA = "0x4231D8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C6C")]
		public Image ImageImgGemLockIcon
		{
			[Token(Token = "0x600482C")]
			[Address(RVA = "0x4231B34", Offset = "0x422DB34", VA = "0x4231B34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C6D")]
		public Image ImageRedDot_UIGem
		{
			[Token(Token = "0x600482D")]
			[Address(RVA = "0x4231FE4", Offset = "0x422DFE4", VA = "0x4231FE4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C6E")]
		public RectTransform RectTransformImgBoxRewardBg
		{
			[Token(Token = "0x600482E")]
			[Address(RVA = "0x42306EC", Offset = "0x422C6EC", VA = "0x42306EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C6F")]
		public DOTweenAnimation DOTweenAnimationImgBoxRewardBg
		{
			[Token(Token = "0x600482F")]
			[Address(RVA = "0x42319A4", Offset = "0x422D9A4", VA = "0x42319A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C70")]
		public Image ImageImgBoxIcon
		{
			[Token(Token = "0x6004830")]
			[Address(RVA = "0x4233ABC", Offset = "0x422FABC", VA = "0x4233ABC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C71")]
		public TextMeshProUGUI TextMeshProUGUITxtBoxNum
		{
			[Token(Token = "0x6004831")]
			[Address(RVA = "0x4230944", Offset = "0x422C944", VA = "0x4230944")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C72")]
		public Image ImageImgBoxDuiHao
		{
			[Token(Token = "0x6004832")]
			[Address(RVA = "0x4231E54", Offset = "0x422DE54", VA = "0x4231E54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C73")]
		public Image ImageImgBoxLockIcon
		{
			[Token(Token = "0x6004833")]
			[Address(RVA = "0x4231BFC", Offset = "0x422DBFC", VA = "0x4231BFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C74")]
		public Image ImageRedDot_UIBox
		{
			[Token(Token = "0x6004834")]
			[Address(RVA = "0x42320AC", Offset = "0x422E0AC", VA = "0x42320AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004835")]
		[Address(RVA = "0x4233DF4", Offset = "0x422FDF4", VA = "0x4233DF4")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6004836")]
		[Address(RVA = "0x4232404", Offset = "0x422E404", VA = "0x4232404", Slot = "12")]
		protected virtual void OnButtonExtendBtnClaimCompleteRewardClicked()
		{
		}

		[Token(Token = "0x6004837")]
		[Address(RVA = "0x4233E7C", Offset = "0x422FE7C", VA = "0x4233E7C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6004838")]
		[Address(RVA = "0x4233E98", Offset = "0x422FE98", VA = "0x4233E98", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__513))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6004839")]
		[Address(RVA = "0x4233F2C", Offset = "0x422FF2C", VA = "0x4233F2C", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x600483A")]
		[Address(RVA = "0x4232508", Offset = "0x422E508", VA = "0x4232508")]
		public TrophyProgressItem_DefaultComponents()
		{
		}
	}
}
