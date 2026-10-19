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
	[Token(Token = "0x2000C29")]
	public class WeeklyClashRewardPreviewPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000C2A")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__620 : IAsyncStateMachine
		{
			[Token(Token = "0x40057A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40057A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40057AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public WeeklyClashRewardPreviewPanelComponents _003C_003E4__this;

			[Token(Token = "0x40057AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6004B5C")]
			[Address(RVA = "0x4268070", Offset = "0x4264070", VA = "0x4268070", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004B5D")]
			[Address(RVA = "0x42682E8", Offset = "0x42642E8", VA = "0x42682E8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400579E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ButtonExtend _buttonExtendBG;

		[Token(Token = "0x400579F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RectTransform _rectTransformPage;

		[Token(Token = "0x40057A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private ButtonExtend _buttonExtendCloseBtn;

		[Token(Token = "0x40057A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ScrollRect _scrollRectRewardItemScrollView;

		[Token(Token = "0x40057A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private LoopListView2 _loopListView2RewardItemScrollView;

		[Token(Token = "0x40057A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private TextMeshProUGUI _textMeshProUGUINameText;

		[Token(Token = "0x40057A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private AvatarItem _avatarItemAvatarItem;

		[Token(Token = "0x40057A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private ScrollRect _scrollRectRewardItemUIScrollView;

		[Token(Token = "0x40057A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Toggle _toggleWeeklyToggle;

		[Token(Token = "0x40057A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Toggle _toggleSeasonToggle;

		[Token(Token = "0x17000D46")]
		public ButtonExtend ButtonExtendBG
		{
			[Token(Token = "0x6004B46")]
			[Address(RVA = "0x4267990", Offset = "0x4263990", VA = "0x4267990")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D47")]
		public RectTransform RectTransformPage
		{
			[Token(Token = "0x6004B47")]
			[Address(RVA = "0x4266A48", Offset = "0x4262A48", VA = "0x4266A48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D48")]
		public ButtonExtend ButtonExtendCloseBtn
		{
			[Token(Token = "0x6004B48")]
			[Address(RVA = "0x4267A58", Offset = "0x4263A58", VA = "0x4267A58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D49")]
		public ScrollRect ScrollRectRewardItemScrollView
		{
			[Token(Token = "0x6004B49")]
			[Address(RVA = "0x4266D6C", Offset = "0x4262D6C", VA = "0x4266D6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D4A")]
		public LoopListView2 LoopListView2RewardItemScrollView
		{
			[Token(Token = "0x6004B4A")]
			[Address(RVA = "0x426667C", Offset = "0x426267C", VA = "0x426667C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D4B")]
		public TextMeshProUGUI TextMeshProUGUINameText
		{
			[Token(Token = "0x6004B4B")]
			[Address(RVA = "0x426658C", Offset = "0x426258C", VA = "0x426658C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D4C")]
		public AvatarItem AvatarItemAvatarItem
		{
			[Token(Token = "0x6004B4C")]
			[Address(RVA = "0x42664C4", Offset = "0x42624C4", VA = "0x42664C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D4D")]
		public ScrollRect ScrollRectRewardItemUIScrollView
		{
			[Token(Token = "0x6004B4D")]
			[Address(RVA = "0x4267B20", Offset = "0x4263B20", VA = "0x4267B20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D4E")]
		public Toggle ToggleWeeklyToggle
		{
			[Token(Token = "0x6004B4E")]
			[Address(RVA = "0x42678BC", Offset = "0x42638BC", VA = "0x42678BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D4F")]
		public Toggle ToggleSeasonToggle
		{
			[Token(Token = "0x6004B4F")]
			[Address(RVA = "0x4267BE8", Offset = "0x4263BE8", VA = "0x4267BE8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004B50")]
		[Address(RVA = "0x4267CB0", Offset = "0x4263CB0", VA = "0x4267CB0")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6004B51")]
		[Address(RVA = "0x4266B30", Offset = "0x4262B30", VA = "0x4266B30", Slot = "12")]
		protected virtual void OnButtonExtendBGClicked()
		{
		}

		[Token(Token = "0x6004B52")]
		[Address(RVA = "0x4266BBC", Offset = "0x4262BBC", VA = "0x4266BBC", Slot = "13")]
		protected virtual void OnButtonExtendCloseBtnClicked()
		{
		}

		[Token(Token = "0x6004B53")]
		[Address(RVA = "0x4267EE4", Offset = "0x4263EE4", VA = "0x4267EE4", Slot = "14")]
		protected virtual void OnScrollRectRewardItemScrollViewValueChanged(Vector2 arg)
		{
		}

		[Token(Token = "0x6004B54")]
		[Address(RVA = "0x4267F98", Offset = "0x4263F98", VA = "0x4267F98", Slot = "15")]
		protected virtual void OnScrollRectRewardItemUIScrollViewValueChanged(Vector2 arg)
		{
		}

		[Token(Token = "0x6004B55")]
		[Address(RVA = "0x4266834", Offset = "0x4262834", VA = "0x4266834", Slot = "16")]
		protected virtual void OnToggleWeeklyToggleValueChanged(bool arg)
		{
		}

		[Token(Token = "0x6004B56")]
		[Address(RVA = "0x4266768", Offset = "0x4262768", VA = "0x4266768", Slot = "17")]
		protected virtual void OnToggleSeasonToggleValueChanged(bool arg)
		{
		}

		[Token(Token = "0x6004B57")]
		[Address(RVA = "0x426804C", Offset = "0x426404C", VA = "0x426804C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6004B58")]
		[Address(RVA = "0x4266E38", Offset = "0x4262E38", VA = "0x4266E38", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__620))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6004B59")]
		[Address(RVA = "0x4266F40", Offset = "0x4262F40", VA = "0x4266F40", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6004B5A")]
		[Address(RVA = "0x4266CE0", Offset = "0x4262CE0", VA = "0x4266CE0")]
		public WeeklyClashRewardPreviewPanelComponents()
		{
		}
	}
}
