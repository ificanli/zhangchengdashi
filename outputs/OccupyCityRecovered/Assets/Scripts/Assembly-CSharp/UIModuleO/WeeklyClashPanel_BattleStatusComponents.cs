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
	[Token(Token = "0x2000C10")]
	public class WeeklyClashPanel_BattleStatusComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000C11")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__192 : IAsyncStateMachine
		{
			[Token(Token = "0x400573A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400573B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400573C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public WeeklyClashPanel_BattleStatusComponents _003C_003E4__this;

			[Token(Token = "0x400573D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6004ACF")]
			[Address(RVA = "0x42607BC", Offset = "0x425C7BC", VA = "0x42607BC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004AD0")]
			[Address(RVA = "0x4260A34", Offset = "0x425CA34", VA = "0x4260A34", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4005731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ScrollRect _scrollRectLeaderboardScrollView;

		[Token(Token = "0x4005732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private LoopListView2 _loopListView2LeaderboardScrollView;

		[Token(Token = "0x4005733")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private WeeklyClashSwitchPanelRect _weeklyClashSwitchPanelRectWeeklyClassSwitchPanelRect;

		[Token(Token = "0x4005734")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ButtonExtend _buttonExtendPVPBtn;

		[Token(Token = "0x4005735")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TextMeshProUGUI _textMeshProUGUIRemainingBattleText;

		[Token(Token = "0x4005736")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private ButtonExtend _buttonExtendBtnShowCardDeck;

		[Token(Token = "0x4005737")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private BtnShowCardDeck _btnShowCardDeckBtnShowCardDeck;

		[Token(Token = "0x4005738")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private ButtonExtend _buttonExtendBtnShowProp;

		[Token(Token = "0x4005739")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private BtnShowProp _btnShowPropBtnShowProp;

		[Token(Token = "0x17000D29")]
		public ScrollRect ScrollRectLeaderboardScrollView
		{
			[Token(Token = "0x6004ABC")]
			[Address(RVA = "0x426017C", Offset = "0x425C17C", VA = "0x426017C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D2A")]
		public LoopListView2 LoopListView2LeaderboardScrollView
		{
			[Token(Token = "0x6004ABD")]
			[Address(RVA = "0x425F19C", Offset = "0x425B19C", VA = "0x425F19C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D2B")]
		public WeeklyClashSwitchPanelRect WeeklyClashSwitchPanelRectWeeklyClassSwitchPanelRect
		{
			[Token(Token = "0x6004ABE")]
			[Address(RVA = "0x425FE78", Offset = "0x425BE78", VA = "0x425FE78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D2C")]
		public ButtonExtend ButtonExtendPVPBtn
		{
			[Token(Token = "0x6004ABF")]
			[Address(RVA = "0x425F4EC", Offset = "0x425B4EC", VA = "0x425F4EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D2D")]
		public TextMeshProUGUI TextMeshProUGUIRemainingBattleText
		{
			[Token(Token = "0x6004AC0")]
			[Address(RVA = "0x425F424", Offset = "0x425B424", VA = "0x425F424")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D2E")]
		public ButtonExtend ButtonExtendBtnShowCardDeck
		{
			[Token(Token = "0x6004AC1")]
			[Address(RVA = "0x4260244", Offset = "0x425C244", VA = "0x4260244")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D2F")]
		public BtnShowCardDeck BtnShowCardDeckBtnShowCardDeck
		{
			[Token(Token = "0x6004AC2")]
			[Address(RVA = "0x425FCE8", Offset = "0x425BCE8", VA = "0x425FCE8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D30")]
		public ButtonExtend ButtonExtendBtnShowProp
		{
			[Token(Token = "0x6004AC3")]
			[Address(RVA = "0x426030C", Offset = "0x425C30C", VA = "0x426030C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D31")]
		public BtnShowProp BtnShowPropBtnShowProp
		{
			[Token(Token = "0x6004AC4")]
			[Address(RVA = "0x425FDB0", Offset = "0x425BDB0", VA = "0x425FDB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004AC5")]
		[Address(RVA = "0x42603D4", Offset = "0x425C3D4", VA = "0x42603D4")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6004AC6")]
		[Address(RVA = "0x4260558", Offset = "0x425C558", VA = "0x4260558", Slot = "12")]
		protected virtual void OnScrollRectLeaderboardScrollViewValueChanged(Vector2 arg)
		{
		}

		[Token(Token = "0x6004AC7")]
		[Address(RVA = "0x425F66C", Offset = "0x425B66C", VA = "0x425F66C", Slot = "13")]
		protected virtual void OnButtonExtendPVPBtnClicked()
		{
		}

		[Token(Token = "0x6004AC8")]
		[Address(RVA = "0x426060C", Offset = "0x425C60C", VA = "0x426060C", Slot = "14")]
		protected virtual void OnButtonExtendBtnShowCardDeckClicked()
		{
		}

		[Token(Token = "0x6004AC9")]
		[Address(RVA = "0x4260678", Offset = "0x425C678", VA = "0x4260678", Slot = "15")]
		protected virtual void OnButtonExtendBtnShowPropClicked()
		{
		}

		[Token(Token = "0x6004ACA")]
		[Address(RVA = "0x42606E4", Offset = "0x425C6E4", VA = "0x42606E4", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6004ACB")]
		[Address(RVA = "0x425F850", Offset = "0x425B850", VA = "0x425F850", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__192))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6004ACC")]
		[Address(RVA = "0x4260700", Offset = "0x425C700", VA = "0x4260700", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6004ACD")]
		[Address(RVA = "0x425F750", Offset = "0x425B750", VA = "0x425F750")]
		public WeeklyClashPanel_BattleStatusComponents()
		{
		}
	}
}
