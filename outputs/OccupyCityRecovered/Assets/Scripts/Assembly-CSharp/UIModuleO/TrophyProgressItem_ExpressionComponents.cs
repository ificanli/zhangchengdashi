using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using Spine.Unity;
using TMPro;
using UIFramework;
using UIModuleO.UIAnim;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000BC1")]
	public class TrophyProgressItem_ExpressionComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000BC2")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__625 : IAsyncStateMachine
		{
			[Token(Token = "0x4005595")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005596")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005597")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public TrophyProgressItem_ExpressionComponents _003C_003E4__this;

			[Token(Token = "0x4005598")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6004893")]
			[Address(RVA = "0x423B208", Offset = "0x4237208", VA = "0x423B208", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004894")]
			[Address(RVA = "0x423B480", Offset = "0x4237480", VA = "0x423B480", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400556C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RectTransform _rectTransformProgressBarRoot;

		[Token(Token = "0x400556D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RectTransform _rectTransformProgressHistory;

		[Token(Token = "0x400556E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RectTransform _rectTransformProgressOwn;

		[Token(Token = "0x400556F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private RectTransform _rectTransformProgressOwnBubble;

		[Token(Token = "0x4005570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TextMeshProUGUI _textMeshProUGUIProgressOwnBubbleText;

		[Token(Token = "0x4005571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private TextMeshProUGUI _textMeshProUGUITrophyRequire;

		[Token(Token = "0x4005572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RectTransform _rectTransformExpression;

		[Token(Token = "0x4005573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Image _imageBackground;

		[Token(Token = "0x4005574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private ButtonExtend _buttonExtendBackground;

		[Token(Token = "0x4005575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private RectTransform _rectTransformSpineIcon_1;

		[Token(Token = "0x4005576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private RectTransform _rectTransformSpineIconBg_1;

		[Token(Token = "0x4005577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Image _imageSpineIconBg_1;

		[Token(Token = "0x4005578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private SkeletonGraphic _skeletonGraphicSpine_1;

		[Token(Token = "0x4005579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Image _imageTick_1;

		[Token(Token = "0x400557A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Image _imageRed_1;

		[Token(Token = "0x400557B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private RectTransform _rectTransformSpineIcon_2;

		[Token(Token = "0x400557C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private RectTransform _rectTransformSpineIconBg_2;

		[Token(Token = "0x400557D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Image _imageSpineIconBg_2;

		[Token(Token = "0x400557E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private SkeletonGraphic _skeletonGraphicSpine_2;

		[Token(Token = "0x400557F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Image _imageTick_2;

		[Token(Token = "0x4005580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Image _imageRed_2;

		[Token(Token = "0x4005581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private ButtonExtend _buttonExtendBtnClaimCompleteReward;

		[Token(Token = "0x4005582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private RectTransform _rectTransformImgCoinRewardBg;

		[Token(Token = "0x4005583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private DOTweenAnimation _dOTweenAnimationImgCoinRewardBg;

		[Token(Token = "0x4005584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private TextMeshProUGUI _textMeshProUGUITxtCoinNum;

		[Token(Token = "0x4005585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Image _imageImgCoinDuiHao;

		[Token(Token = "0x4005586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Image _imageImgCoinLockIcon;

		[Token(Token = "0x4005587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Image _imageRedDot_UICoin;

		[Token(Token = "0x4005588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private RectTransform _rectTransformImgGemRewardBg;

		[Token(Token = "0x4005589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private DOTweenAnimation _dOTweenAnimationImgGemRewardBg;

		[Token(Token = "0x400558A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private TextMeshProUGUI _textMeshProUGUITxtGemNum;

		[Token(Token = "0x400558B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Image _imageImgGemDuiHao;

		[Token(Token = "0x400558C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Image _imageImgGemLockIcon;

		[Token(Token = "0x400558D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Image _imageRedDot_UIGem;

		[Token(Token = "0x400558E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private RectTransform _rectTransformImgBoxRewardBg;

		[Token(Token = "0x400558F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private DOTweenAnimation _dOTweenAnimationImgBoxRewardBg;

		[Token(Token = "0x4005590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Image _imageImgBoxIcon;

		[Token(Token = "0x4005591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private TextMeshProUGUI _textMeshProUGUITxtBoxNum;

		[Token(Token = "0x4005592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private Image _imageImgBoxDuiHao;

		[Token(Token = "0x4005593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private Image _imageImgBoxLockIcon;

		[Token(Token = "0x4005594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private Image _imageRedDot_UIBox;

		[Token(Token = "0x17000C75")]
		public RectTransform RectTransformProgressBarRoot
		{
			[Token(Token = "0x6004862")]
			[Address(RVA = "0x423ABD4", Offset = "0x4236BD4", VA = "0x423ABD4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C76")]
		public RectTransform RectTransformProgressHistory
		{
			[Token(Token = "0x6004863")]
			[Address(RVA = "0x423AD64", Offset = "0x4236D64", VA = "0x423AD64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C77")]
		public RectTransform RectTransformProgressOwn
		{
			[Token(Token = "0x6004864")]
			[Address(RVA = "0x423AC9C", Offset = "0x4236C9C", VA = "0x423AC9C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C78")]
		public RectTransform RectTransformProgressOwnBubble
		{
			[Token(Token = "0x6004865")]
			[Address(RVA = "0x423AE2C", Offset = "0x4236E2C", VA = "0x423AE2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C79")]
		public TextMeshProUGUI TextMeshProUGUIProgressOwnBubbleText
		{
			[Token(Token = "0x6004866")]
			[Address(RVA = "0x423AEF4", Offset = "0x4236EF4", VA = "0x423AEF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C7A")]
		public TextMeshProUGUI TextMeshProUGUITrophyRequire
		{
			[Token(Token = "0x6004867")]
			[Address(RVA = "0x4234514", Offset = "0x4230514", VA = "0x4234514")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C7B")]
		public RectTransform RectTransformExpression
		{
			[Token(Token = "0x6004868")]
			[Address(RVA = "0x42351F8", Offset = "0x42311F8", VA = "0x42351F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C7C")]
		public Image ImageBackground
		{
			[Token(Token = "0x6004869")]
			[Address(RVA = "0x4235F2C", Offset = "0x4231F2C", VA = "0x4235F2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C7D")]
		public ButtonExtend ButtonExtendBackground
		{
			[Token(Token = "0x600486A")]
			[Address(RVA = "0x4235E64", Offset = "0x4231E64", VA = "0x4235E64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C7E")]
		public RectTransform RectTransformSpineIcon_1
		{
			[Token(Token = "0x600486B")]
			[Address(RVA = "0x42352C0", Offset = "0x42312C0", VA = "0x42352C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C7F")]
		public RectTransform RectTransformSpineIconBg_1
		{
			[Token(Token = "0x600486C")]
			[Address(RVA = "0x4237650", Offset = "0x4233650", VA = "0x4237650")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C80")]
		public Image ImageSpineIconBg_1
		{
			[Token(Token = "0x600486D")]
			[Address(RVA = "0x4235624", Offset = "0x4231624", VA = "0x4235624")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C81")]
		public SkeletonGraphic SkeletonGraphicSpine_1
		{
			[Token(Token = "0x600486E")]
			[Address(RVA = "0x4235388", Offset = "0x4231388", VA = "0x4235388")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C82")]
		public Image ImageTick_1
		{
			[Token(Token = "0x600486F")]
			[Address(RVA = "0x4235494", Offset = "0x4231494", VA = "0x4235494")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C83")]
		public Image ImageRed_1
		{
			[Token(Token = "0x6004870")]
			[Address(RVA = "0x423555C", Offset = "0x423155C", VA = "0x423555C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C84")]
		public RectTransform RectTransformSpineIcon_2
		{
			[Token(Token = "0x6004871")]
			[Address(RVA = "0x42356EC", Offset = "0x42316EC", VA = "0x42356EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C85")]
		public RectTransform RectTransformSpineIconBg_2
		{
			[Token(Token = "0x6004872")]
			[Address(RVA = "0x4237718", Offset = "0x4233718", VA = "0x4237718")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C86")]
		public Image ImageSpineIconBg_2
		{
			[Token(Token = "0x6004873")]
			[Address(RVA = "0x4235A0C", Offset = "0x4231A0C", VA = "0x4235A0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C87")]
		public SkeletonGraphic SkeletonGraphicSpine_2
		{
			[Token(Token = "0x6004874")]
			[Address(RVA = "0x42357B4", Offset = "0x42317B4", VA = "0x42357B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C88")]
		public Image ImageTick_2
		{
			[Token(Token = "0x6004875")]
			[Address(RVA = "0x423587C", Offset = "0x423187C", VA = "0x423587C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C89")]
		public Image ImageRed_2
		{
			[Token(Token = "0x6004876")]
			[Address(RVA = "0x4235944", Offset = "0x4231944", VA = "0x4235944")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C8A")]
		public ButtonExtend ButtonExtendBtnClaimCompleteReward
		{
			[Token(Token = "0x6004877")]
			[Address(RVA = "0x4236FE8", Offset = "0x4232FE8", VA = "0x4236FE8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C8B")]
		public RectTransform RectTransformImgCoinRewardBg
		{
			[Token(Token = "0x6004878")]
			[Address(RVA = "0x4236144", Offset = "0x4232144", VA = "0x4236144")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C8C")]
		public DOTweenAnimation DOTweenAnimationImgCoinRewardBg
		{
			[Token(Token = "0x6004879")]
			[Address(RVA = "0x42373F8", Offset = "0x42333F8", VA = "0x42373F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C8D")]
		public TextMeshProUGUI TextMeshProUGUITxtCoinNum
		{
			[Token(Token = "0x600487A")]
			[Address(RVA = "0x423639C", Offset = "0x423239C", VA = "0x423639C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C8E")]
		public Image ImageImgCoinDuiHao
		{
			[Token(Token = "0x600487B")]
			[Address(RVA = "0x4236B38", Offset = "0x4232B38", VA = "0x4236B38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C8F")]
		public Image ImageImgCoinLockIcon
		{
			[Token(Token = "0x600487C")]
			[Address(RVA = "0x42368E0", Offset = "0x42328E0", VA = "0x42368E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C90")]
		public Image ImageRedDot_UICoin
		{
			[Token(Token = "0x600487D")]
			[Address(RVA = "0x4236D90", Offset = "0x4232D90", VA = "0x4236D90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C91")]
		public RectTransform RectTransformImgGemRewardBg
		{
			[Token(Token = "0x600487E")]
			[Address(RVA = "0x423620C", Offset = "0x423220C", VA = "0x423620C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C92")]
		public DOTweenAnimation DOTweenAnimationImgGemRewardBg
		{
			[Token(Token = "0x600487F")]
			[Address(RVA = "0x42374C0", Offset = "0x42334C0", VA = "0x42374C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C93")]
		public TextMeshProUGUI TextMeshProUGUITxtGemNum
		{
			[Token(Token = "0x6004880")]
			[Address(RVA = "0x4236464", Offset = "0x4232464", VA = "0x4236464")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C94")]
		public Image ImageImgGemDuiHao
		{
			[Token(Token = "0x6004881")]
			[Address(RVA = "0x4236C00", Offset = "0x4232C00", VA = "0x4236C00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C95")]
		public Image ImageImgGemLockIcon
		{
			[Token(Token = "0x6004882")]
			[Address(RVA = "0x42369A8", Offset = "0x42329A8", VA = "0x42369A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C96")]
		public Image ImageRedDot_UIGem
		{
			[Token(Token = "0x6004883")]
			[Address(RVA = "0x4236E58", Offset = "0x4232E58", VA = "0x4236E58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C97")]
		public RectTransform RectTransformImgBoxRewardBg
		{
			[Token(Token = "0x6004884")]
			[Address(RVA = "0x42362D4", Offset = "0x42322D4", VA = "0x42362D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C98")]
		public DOTweenAnimation DOTweenAnimationImgBoxRewardBg
		{
			[Token(Token = "0x6004885")]
			[Address(RVA = "0x4237588", Offset = "0x4233588", VA = "0x4237588")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C99")]
		public Image ImageImgBoxIcon
		{
			[Token(Token = "0x6004886")]
			[Address(RVA = "0x4239880", Offset = "0x4235880", VA = "0x4239880")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C9A")]
		public TextMeshProUGUI TextMeshProUGUITxtBoxNum
		{
			[Token(Token = "0x6004887")]
			[Address(RVA = "0x423652C", Offset = "0x423252C", VA = "0x423652C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C9B")]
		public Image ImageImgBoxDuiHao
		{
			[Token(Token = "0x6004888")]
			[Address(RVA = "0x4236CC8", Offset = "0x4232CC8", VA = "0x4236CC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C9C")]
		public Image ImageImgBoxLockIcon
		{
			[Token(Token = "0x6004889")]
			[Address(RVA = "0x4236A70", Offset = "0x4232A70", VA = "0x4236A70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C9D")]
		public Image ImageRedDot_UIBox
		{
			[Token(Token = "0x600488A")]
			[Address(RVA = "0x4236F20", Offset = "0x4232F20", VA = "0x4236F20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600488B")]
		[Address(RVA = "0x423AFC8", Offset = "0x4236FC8", VA = "0x423AFC8")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x600488C")]
		[Address(RVA = "0x42377F8", Offset = "0x42337F8", VA = "0x42377F8", Slot = "12")]
		protected virtual void OnButtonExtendBackgroundClicked()
		{
		}

		[Token(Token = "0x600488D")]
		[Address(RVA = "0x4237A8C", Offset = "0x4233A8C", VA = "0x4237A8C", Slot = "13")]
		protected virtual void OnButtonExtendBtnClaimCompleteRewardClicked()
		{
		}

		[Token(Token = "0x600488E")]
		[Address(RVA = "0x423B09C", Offset = "0x423709C", VA = "0x423B09C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600488F")]
		[Address(RVA = "0x423B0B8", Offset = "0x42370B8", VA = "0x423B0B8", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__625))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6004890")]
		[Address(RVA = "0x423B14C", Offset = "0x423714C", VA = "0x423B14C", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6004891")]
		[Address(RVA = "0x4237B90", Offset = "0x4233B90", VA = "0x4237B90")]
		public TrophyProgressItem_ExpressionComponents()
		{
		}
	}
}
