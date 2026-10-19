using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using SuperScrollView;
using TMPro;
using UIFramework;
using UIModuleO.UIAnim;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x20006F7")]
	public class BannerPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20006F8")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__366 : IAsyncStateMachine
		{
			[Token(Token = "0x4003782")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003783")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003784")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BannerPanelComponents _003C_003E4__this;

			[Token(Token = "0x4003785")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60025C1")]
			[Address(RVA = "0x3F8A204", Offset = "0x3F86204", VA = "0x3F8A204", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60025C2")]
			[Address(RVA = "0x3F8A47C", Offset = "0x3F8647C", VA = "0x3F8A47C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003774")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Button _buttonBackground;

		[Token(Token = "0x4003775")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RectTransform _rectTransformContents;

		[Token(Token = "0x4003776")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private ButtonExtend _buttonExtendClose;

		[Token(Token = "0x4003777")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private TextMeshProUGUI _textMeshProUGUITitle;

		[Token(Token = "0x4003778")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Image _imagePlayerInfo;

		[Token(Token = "0x4003779")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private AvatarItem _avatarItemPlayerAvatarItem;

		[Token(Token = "0x400377A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Image _imageImgBotDanIcon;

		[Token(Token = "0x400377B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private TextMeshProUGUI _textMeshProUGUITxtBotDanName;

		[Token(Token = "0x400377C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private TextMeshProUGUI _textMeshProUGUITxtBotTrophyNum;

		[Token(Token = "0x400377D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Image _imageImgPlayerPropIcon;

		[Token(Token = "0x400377E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private TextMeshProUGUI _textMeshProUGUITxtPlayerPropName;

		[Token(Token = "0x400377F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private ScrollRect _scrollRectScrollView;

		[Token(Token = "0x4003780")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private LoopGridView _loopGridViewScrollView;

		[Token(Token = "0x4003781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private ButtonExtend _buttonExtendSelectBannerItem;

		[Token(Token = "0x170002C6")]
		public Button ButtonBackground
		{
			[Token(Token = "0x60025A9")]
			[Address(RVA = "0x3F89C38", Offset = "0x3F85C38", VA = "0x3F89C38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002C7")]
		public RectTransform RectTransformContents
		{
			[Token(Token = "0x60025AA")]
			[Address(RVA = "0x3F88370", Offset = "0x3F84370", VA = "0x3F88370")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002C8")]
		public ButtonExtend ButtonExtendClose
		{
			[Token(Token = "0x60025AB")]
			[Address(RVA = "0x3F89D00", Offset = "0x3F85D00", VA = "0x3F89D00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002C9")]
		public TextMeshProUGUI TextMeshProUGUITitle
		{
			[Token(Token = "0x60025AC")]
			[Address(RVA = "0x3F89B64", Offset = "0x3F85B64", VA = "0x3F89B64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002CA")]
		public Image ImagePlayerInfo
		{
			[Token(Token = "0x60025AD")]
			[Address(RVA = "0x3F88640", Offset = "0x3F84640", VA = "0x3F88640")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002CB")]
		public AvatarItem AvatarItemPlayerAvatarItem
		{
			[Token(Token = "0x60025AE")]
			[Address(RVA = "0x3F896B4", Offset = "0x3F856B4", VA = "0x3F896B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002CC")]
		public Image ImageImgBotDanIcon
		{
			[Token(Token = "0x60025AF")]
			[Address(RVA = "0x3F8977C", Offset = "0x3F8577C", VA = "0x3F8977C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002CD")]
		public TextMeshProUGUI TextMeshProUGUITxtBotDanName
		{
			[Token(Token = "0x60025B0")]
			[Address(RVA = "0x3F89844", Offset = "0x3F85844", VA = "0x3F89844")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002CE")]
		public TextMeshProUGUI TextMeshProUGUITxtBotTrophyNum
		{
			[Token(Token = "0x60025B1")]
			[Address(RVA = "0x3F8990C", Offset = "0x3F8590C", VA = "0x3F8990C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002CF")]
		public Image ImageImgPlayerPropIcon
		{
			[Token(Token = "0x60025B2")]
			[Address(RVA = "0x3F89A9C", Offset = "0x3F85A9C", VA = "0x3F89A9C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002D0")]
		public TextMeshProUGUI TextMeshProUGUITxtPlayerPropName
		{
			[Token(Token = "0x60025B3")]
			[Address(RVA = "0x3F899D4", Offset = "0x3F859D4", VA = "0x3F899D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002D1")]
		public ScrollRect ScrollRectScrollView
		{
			[Token(Token = "0x60025B4")]
			[Address(RVA = "0x3F89DC8", Offset = "0x3F85DC8", VA = "0x3F89DC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002D2")]
		public LoopGridView LoopGridViewScrollView
		{
			[Token(Token = "0x60025B5")]
			[Address(RVA = "0x3F88438", Offset = "0x3F84438", VA = "0x3F88438")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002D3")]
		public ButtonExtend ButtonExtendSelectBannerItem
		{
			[Token(Token = "0x60025B6")]
			[Address(RVA = "0x3F89E90", Offset = "0x3F85E90", VA = "0x3F89E90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60025B7")]
		[Address(RVA = "0x3F89F58", Offset = "0x3F85F58", VA = "0x3F89F58")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x60025B8")]
		[Address(RVA = "0x3F88728", Offset = "0x3F84728", VA = "0x3F88728", Slot = "12")]
		protected virtual void OnButtonBackgroundClicked()
		{
		}

		[Token(Token = "0x60025B9")]
		[Address(RVA = "0x3F887B4", Offset = "0x3F847B4", VA = "0x3F887B4", Slot = "13")]
		protected virtual void OnButtonExtendCloseClicked()
		{
		}

		[Token(Token = "0x60025BA")]
		[Address(RVA = "0x3F8A0DC", Offset = "0x3F860DC", VA = "0x3F8A0DC", Slot = "14")]
		protected virtual void OnScrollRectScrollViewValueChanged(Vector2 arg)
		{
		}

		[Token(Token = "0x60025BB")]
		[Address(RVA = "0x3F8A190", Offset = "0x3F86190", VA = "0x3F8A190", Slot = "15")]
		protected virtual void OnButtonExtendSelectBannerItemClicked()
		{
		}

		[Token(Token = "0x60025BC")]
		[Address(RVA = "0x3F88354", Offset = "0x3F84354", VA = "0x3F88354", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60025BD")]
		[Address(RVA = "0x3F88A64", Offset = "0x3F84A64", VA = "0x3F88A64", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__366))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60025BE")]
		[Address(RVA = "0x3F8899C", Offset = "0x3F8499C", VA = "0x3F8899C", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60025BF")]
		[Address(RVA = "0x3F88A58", Offset = "0x3F84A58", VA = "0x3F88A58")]
		public BannerPanelComponents()
		{
		}
	}
}
