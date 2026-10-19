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
	[Token(Token = "0x2000911")]
	public class HeadShotDetailPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000912")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__627 : IAsyncStateMachine
		{
			[Token(Token = "0x400444D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400444E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400444F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HeadShotDetailPanelComponents _003C_003E4__this;

			[Token(Token = "0x4004450")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x600346E")]
			[Address(RVA = "0x40A9B68", Offset = "0x40A5B68", VA = "0x40A9B68", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600346F")]
			[Address(RVA = "0x40A9DE0", Offset = "0x40A5DE0", VA = "0x40A9DE0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400442F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ButtonExtend _buttonExtendBG;

		[Token(Token = "0x4004430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Image _imageImgBg;

		[Token(Token = "0x4004431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TextMeshProUGUI _textMeshProUGUITxtProfile;

		[Token(Token = "0x4004432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ButtonExtend _buttonExtendBtnClose;

		[Token(Token = "0x4004433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private AvatarItem _avatarItemAvatarItem;

		[Token(Token = "0x4004434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private ButtonExtend _buttonExtendAvatarItem;

		[Token(Token = "0x4004435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Image _imageImgDanIcon;

		[Token(Token = "0x4004436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private TextMeshProUGUI _textMeshProUGUITxtTrophyNum;

		[Token(Token = "0x4004437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Image _imageImgProgress;

		[Token(Token = "0x4004438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private TextMeshProUGUI _textMeshProUGUIRank;

		[Token(Token = "0x4004439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Image _imageBanner;

		[Token(Token = "0x400443A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private ButtonExtend _buttonExtendChangeBanner;

		[Token(Token = "0x400443B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private TextMeshProUGUI _textMeshProUGUIBasicTitle;

		[Token(Token = "0x400443C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private TextMeshProUGUI _textMeshProUGUIVictoriestText;

		[Token(Token = "0x400443D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private TextMeshProUGUI _textMeshProUGUIVictoriesCount;

		[Token(Token = "0x400443E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private TextMeshProUGUI _textMeshProUGUIFailuresText;

		[Token(Token = "0x400443F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private TextMeshProUGUI _textMeshProUGUIFailuresCount;

		[Token(Token = "0x4004440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private TextMeshProUGUI _textMeshProUGUITotalSessionsText;

		[Token(Token = "0x4004441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private TextMeshProUGUI _textMeshProUGUITotalSessionsCount;

		[Token(Token = "0x4004442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private TextMeshProUGUI _textMeshProUGUIWinRateText;

		[Token(Token = "0x4004443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private TextMeshProUGUI _textMeshProUGUITxtWinRateCount;

		[Token(Token = "0x4004444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private TextMeshProUGUI _textMeshProUGUITheHighestTrophyText;

		[Token(Token = "0x4004445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private TextMeshProUGUI _textMeshProUGUITheHighestTrophyCount;

		[Token(Token = "0x4004446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private TextMeshProUGUI _textMeshProUGUICollectedCardsText;

		[Token(Token = "0x4004447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private TextMeshProUGUI _textMeshProUGUICollectedCardsCount;

		[Token(Token = "0x4004448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private RectTransform _rectTransformHeadTips;

		[Token(Token = "0x4004449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Button _buttonHeadTipsBg;

		[Token(Token = "0x400444A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private ScrollRect _scrollRectScrollViewHeadShot;

		[Token(Token = "0x400444B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private RectTransform _rectTransformContentHeadShot;

		[Token(Token = "0x400444C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private ButtonExtend _buttonExtendImgHeadShotItem;

		[Token(Token = "0x17000724")]
		public ButtonExtend ButtonExtendBG
		{
			[Token(Token = "0x6003443")]
			[Address(RVA = "0x40A8018", Offset = "0x40A4018", VA = "0x40A8018")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000725")]
		public Image ImageImgBg
		{
			[Token(Token = "0x6003444")]
			[Address(RVA = "0x40A80E0", Offset = "0x40A40E0", VA = "0x40A80E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000726")]
		public TextMeshProUGUI TextMeshProUGUITxtProfile
		{
			[Token(Token = "0x6003445")]
			[Address(RVA = "0x40A7F44", Offset = "0x40A3F44", VA = "0x40A7F44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000727")]
		public ButtonExtend ButtonExtendBtnClose
		{
			[Token(Token = "0x6003446")]
			[Address(RVA = "0x40A81A8", Offset = "0x40A41A8", VA = "0x40A81A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000728")]
		public AvatarItem AvatarItemAvatarItem
		{
			[Token(Token = "0x6003447")]
			[Address(RVA = "0x40A7470", Offset = "0x40A3470", VA = "0x40A7470")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000729")]
		public ButtonExtend ButtonExtendAvatarItem
		{
			[Token(Token = "0x6003448")]
			[Address(RVA = "0x40A8270", Offset = "0x40A4270", VA = "0x40A8270")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700072A")]
		public Image ImageImgDanIcon
		{
			[Token(Token = "0x6003449")]
			[Address(RVA = "0x40A7DB4", Offset = "0x40A3DB4", VA = "0x40A7DB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700072B")]
		public TextMeshProUGUI TextMeshProUGUITxtTrophyNum
		{
			[Token(Token = "0x600344A")]
			[Address(RVA = "0x40A8338", Offset = "0x40A4338", VA = "0x40A8338")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700072C")]
		public Image ImageImgProgress
		{
			[Token(Token = "0x600344B")]
			[Address(RVA = "0x40A7E7C", Offset = "0x40A3E7C", VA = "0x40A7E7C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700072D")]
		public TextMeshProUGUI TextMeshProUGUIRank
		{
			[Token(Token = "0x600344C")]
			[Address(RVA = "0x40A8400", Offset = "0x40A4400", VA = "0x40A8400")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700072E")]
		public Image ImageBanner
		{
			[Token(Token = "0x600344D")]
			[Address(RVA = "0x40A84C8", Offset = "0x40A44C8", VA = "0x40A84C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700072F")]
		public ButtonExtend ButtonExtendChangeBanner
		{
			[Token(Token = "0x600344E")]
			[Address(RVA = "0x40A8590", Offset = "0x40A4590", VA = "0x40A8590")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000730")]
		public TextMeshProUGUI TextMeshProUGUIBasicTitle
		{
			[Token(Token = "0x600344F")]
			[Address(RVA = "0x40A8658", Offset = "0x40A4658", VA = "0x40A8658")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000731")]
		public TextMeshProUGUI TextMeshProUGUIVictoriestText
		{
			[Token(Token = "0x6003450")]
			[Address(RVA = "0x40A8720", Offset = "0x40A4720", VA = "0x40A8720")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000732")]
		public TextMeshProUGUI TextMeshProUGUIVictoriesCount
		{
			[Token(Token = "0x6003451")]
			[Address(RVA = "0x40A87E8", Offset = "0x40A47E8", VA = "0x40A87E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000733")]
		public TextMeshProUGUI TextMeshProUGUIFailuresText
		{
			[Token(Token = "0x6003452")]
			[Address(RVA = "0x40A88B0", Offset = "0x40A48B0", VA = "0x40A88B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000734")]
		public TextMeshProUGUI TextMeshProUGUIFailuresCount
		{
			[Token(Token = "0x6003453")]
			[Address(RVA = "0x40A8978", Offset = "0x40A4978", VA = "0x40A8978")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000735")]
		public TextMeshProUGUI TextMeshProUGUITotalSessionsText
		{
			[Token(Token = "0x6003454")]
			[Address(RVA = "0x40A8A40", Offset = "0x40A4A40", VA = "0x40A8A40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000736")]
		public TextMeshProUGUI TextMeshProUGUITotalSessionsCount
		{
			[Token(Token = "0x6003455")]
			[Address(RVA = "0x40A8B08", Offset = "0x40A4B08", VA = "0x40A8B08")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000737")]
		public TextMeshProUGUI TextMeshProUGUIWinRateText
		{
			[Token(Token = "0x6003456")]
			[Address(RVA = "0x40A8BD0", Offset = "0x40A4BD0", VA = "0x40A8BD0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000738")]
		public TextMeshProUGUI TextMeshProUGUITxtWinRateCount
		{
			[Token(Token = "0x6003457")]
			[Address(RVA = "0x40A8C98", Offset = "0x40A4C98", VA = "0x40A8C98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000739")]
		public TextMeshProUGUI TextMeshProUGUITheHighestTrophyText
		{
			[Token(Token = "0x6003458")]
			[Address(RVA = "0x40A8D60", Offset = "0x40A4D60", VA = "0x40A8D60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700073A")]
		public TextMeshProUGUI TextMeshProUGUITheHighestTrophyCount
		{
			[Token(Token = "0x6003459")]
			[Address(RVA = "0x40A8E28", Offset = "0x40A4E28", VA = "0x40A8E28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700073B")]
		public TextMeshProUGUI TextMeshProUGUICollectedCardsText
		{
			[Token(Token = "0x600345A")]
			[Address(RVA = "0x40A8EF0", Offset = "0x40A4EF0", VA = "0x40A8EF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700073C")]
		public TextMeshProUGUI TextMeshProUGUICollectedCardsCount
		{
			[Token(Token = "0x600345B")]
			[Address(RVA = "0x40A8FB8", Offset = "0x40A4FB8", VA = "0x40A8FB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700073D")]
		public RectTransform RectTransformHeadTips
		{
			[Token(Token = "0x600345C")]
			[Address(RVA = "0x40A9080", Offset = "0x40A5080", VA = "0x40A9080")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700073E")]
		public Button ButtonHeadTipsBg
		{
			[Token(Token = "0x600345D")]
			[Address(RVA = "0x40A9148", Offset = "0x40A5148", VA = "0x40A9148")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700073F")]
		public ScrollRect ScrollRectScrollViewHeadShot
		{
			[Token(Token = "0x600345E")]
			[Address(RVA = "0x40A9210", Offset = "0x40A5210", VA = "0x40A9210")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000740")]
		public RectTransform RectTransformContentHeadShot
		{
			[Token(Token = "0x600345F")]
			[Address(RVA = "0x40A92D8", Offset = "0x40A52D8", VA = "0x40A92D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000741")]
		public ButtonExtend ButtonExtendImgHeadShotItem
		{
			[Token(Token = "0x6003460")]
			[Address(RVA = "0x40A93A0", Offset = "0x40A53A0", VA = "0x40A93A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003461")]
		[Address(RVA = "0x40A9468", Offset = "0x40A5468", VA = "0x40A9468")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6003462")]
		[Address(RVA = "0x40A96B8", Offset = "0x40A56B8", VA = "0x40A96B8", Slot = "12")]
		protected virtual void OnButtonExtendBGClicked()
		{
		}

		[Token(Token = "0x6003463")]
		[Address(RVA = "0x40A9724", Offset = "0x40A5724", VA = "0x40A9724", Slot = "13")]
		protected virtual void OnButtonExtendBtnCloseClicked()
		{
		}

		[Token(Token = "0x6003464")]
		[Address(RVA = "0x40A9790", Offset = "0x40A5790", VA = "0x40A9790", Slot = "14")]
		protected virtual void OnButtonExtendAvatarItemClicked()
		{
		}

		[Token(Token = "0x6003465")]
		[Address(RVA = "0x40A97FC", Offset = "0x40A57FC", VA = "0x40A97FC", Slot = "15")]
		protected virtual void OnButtonExtendChangeBannerClicked()
		{
		}

		[Token(Token = "0x6003466")]
		[Address(RVA = "0x40A9868", Offset = "0x40A5868", VA = "0x40A9868", Slot = "16")]
		protected virtual void OnButtonHeadTipsBgClicked()
		{
		}

		[Token(Token = "0x6003467")]
		[Address(RVA = "0x40A98D4", Offset = "0x40A58D4", VA = "0x40A98D4", Slot = "17")]
		protected virtual void OnScrollRectScrollViewHeadShotValueChanged(Vector2 arg)
		{
		}

		[Token(Token = "0x6003468")]
		[Address(RVA = "0x40A9988", Offset = "0x40A5988", VA = "0x40A9988", Slot = "18")]
		protected virtual void OnButtonExtendImgHeadShotItemClicked()
		{
		}

		[Token(Token = "0x6003469")]
		[Address(RVA = "0x40A99F4", Offset = "0x40A59F4", VA = "0x40A99F4", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600346A")]
		[Address(RVA = "0x40A9A10", Offset = "0x40A5A10", VA = "0x40A9A10", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__627))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x600346B")]
		[Address(RVA = "0x40A9AA4", Offset = "0x40A5AA4", VA = "0x40A9AA4", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x600346C")]
		[Address(RVA = "0x40A9B58", Offset = "0x40A5B58", VA = "0x40A9B58")]
		public HeadShotDetailPanelComponents()
		{
		}
	}
}
