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
	[Token(Token = "0x2000C20")]
	public class WeeklyClashPanel_SettlementStatusComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000C21")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__503 : IAsyncStateMachine
		{
			[Token(Token = "0x4005778")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005779")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400577A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public WeeklyClashPanel_SettlementStatusComponents _003C_003E4__this;

			[Token(Token = "0x400577B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6004B1E")]
			[Address(RVA = "0x4264A14", Offset = "0x4260A14", VA = "0x4264A14", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004B1F")]
			[Address(RVA = "0x4264C8C", Offset = "0x4260C8C", VA = "0x4264C8C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400576C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private WeeklyClashRoleRankingItem _weeklyClashRoleRankingItemRoleRankingItem;

		[Token(Token = "0x400576D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private WeeklyClashRoleRankingItem _weeklyClashRoleRankingItemRoleRankingItem2;

		[Token(Token = "0x400576E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private WeeklyClashRoleRankingItem _weeklyClashRoleRankingItemRoleRankingItem3;

		[Token(Token = "0x400576F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private WeeklyClashSwitchPanelRect _weeklyClashSwitchPanelRectWeeklyClassSwitchPanelRect;

		[Token(Token = "0x4005770")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TextMeshProUGUI _textMeshProUGUIRankName;

		[Token(Token = "0x4005771")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private TextMeshProUGUI _textMeshProUGUIRankingText;

		[Token(Token = "0x4005772")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private ScrollRect _scrollRectRewardItemUIScrollView;

		[Token(Token = "0x4005773")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private RewardItemUIScrollView _rewardItemUIScrollViewRewardItemUIScrollView;

		[Token(Token = "0x4005774")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private ButtonExtend _buttonExtendHintBtn;

		[Token(Token = "0x4005775")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private ButtonExtend _buttonExtendClaimBtn;

		[Token(Token = "0x4005776")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private RectTransform _rectTransformHadClaimText;

		[Token(Token = "0x4005777")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private TextMeshProUGUI _textMeshProUGUIHadClaimText;

		[Token(Token = "0x17000D36")]
		public WeeklyClashRoleRankingItem WeeklyClashRoleRankingItemRoleRankingItem
		{
			[Token(Token = "0x6004B09")]
			[Address(RVA = "0x4262ABC", Offset = "0x425EABC", VA = "0x4262ABC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D37")]
		public WeeklyClashRoleRankingItem WeeklyClashRoleRankingItemRoleRankingItem2
		{
			[Token(Token = "0x6004B0A")]
			[Address(RVA = "0x4262B84", Offset = "0x425EB84", VA = "0x4262B84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D38")]
		public WeeklyClashRoleRankingItem WeeklyClashRoleRankingItemRoleRankingItem3
		{
			[Token(Token = "0x6004B0B")]
			[Address(RVA = "0x4262C4C", Offset = "0x425EC4C", VA = "0x4262C4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D39")]
		public WeeklyClashSwitchPanelRect WeeklyClashSwitchPanelRectWeeklyClassSwitchPanelRect
		{
			[Token(Token = "0x6004B0C")]
			[Address(RVA = "0x42644E4", Offset = "0x42604E4", VA = "0x42644E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D3A")]
		public TextMeshProUGUI TextMeshProUGUIRankName
		{
			[Token(Token = "0x6004B0D")]
			[Address(RVA = "0x4264028", Offset = "0x4260028", VA = "0x4264028")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D3B")]
		public TextMeshProUGUI TextMeshProUGUIRankingText
		{
			[Token(Token = "0x6004B0E")]
			[Address(RVA = "0x4263038", Offset = "0x425F038", VA = "0x4263038")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D3C")]
		public ScrollRect ScrollRectRewardItemUIScrollView
		{
			[Token(Token = "0x6004B0F")]
			[Address(RVA = "0x42645B8", Offset = "0x42605B8", VA = "0x42645B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D3D")]
		public RewardItemUIScrollView RewardItemUIScrollViewRewardItemUIScrollView
		{
			[Token(Token = "0x6004B10")]
			[Address(RVA = "0x4262F70", Offset = "0x425EF70", VA = "0x4262F70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D3E")]
		public ButtonExtend ButtonExtendHintBtn
		{
			[Token(Token = "0x6004B11")]
			[Address(RVA = "0x4264680", Offset = "0x4260680", VA = "0x4264680")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D3F")]
		public ButtonExtend ButtonExtendClaimBtn
		{
			[Token(Token = "0x6004B12")]
			[Address(RVA = "0x42636E0", Offset = "0x425F6E0", VA = "0x42636E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D40")]
		public RectTransform RectTransformHadClaimText
		{
			[Token(Token = "0x6004B13")]
			[Address(RVA = "0x42637A8", Offset = "0x425F7A8", VA = "0x42637A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D41")]
		public TextMeshProUGUI TextMeshProUGUIHadClaimText
		{
			[Token(Token = "0x6004B14")]
			[Address(RVA = "0x4263618", Offset = "0x425F618", VA = "0x4263618")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004B15")]
		[Address(RVA = "0x4264748", Offset = "0x4260748", VA = "0x4264748")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6004B16")]
		[Address(RVA = "0x4264888", Offset = "0x4260888", VA = "0x4264888", Slot = "12")]
		protected virtual void OnScrollRectRewardItemUIScrollViewValueChanged(Vector2 arg)
		{
		}

		[Token(Token = "0x6004B17")]
		[Address(RVA = "0x4263BA4", Offset = "0x425FBA4", VA = "0x4263BA4", Slot = "13")]
		protected virtual void OnButtonExtendHintBtnClicked()
		{
		}

		[Token(Token = "0x6004B18")]
		[Address(RVA = "0x4263C88", Offset = "0x425FC88", VA = "0x4263C88", Slot = "14")]
		protected virtual void OnButtonExtendClaimBtnClicked()
		{
		}

		[Token(Token = "0x6004B19")]
		[Address(RVA = "0x426493C", Offset = "0x426093C", VA = "0x426493C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6004B1A")]
		[Address(RVA = "0x42640F4", Offset = "0x42600F4", VA = "0x42640F4", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__503))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6004B1B")]
		[Address(RVA = "0x4264958", Offset = "0x4260958", VA = "0x4264958", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6004B1C")]
		[Address(RVA = "0x4263D78", Offset = "0x425FD78", VA = "0x4263D78")]
		public WeeklyClashPanel_SettlementStatusComponents()
		{
		}
	}
}
