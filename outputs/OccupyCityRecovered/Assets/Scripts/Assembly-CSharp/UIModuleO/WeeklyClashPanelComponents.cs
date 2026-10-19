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

namespace UIModuleO
{
	[Token(Token = "0x2000C0B")]
	public class WeeklyClashPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000C0C")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__401 : IAsyncStateMachine
		{
			[Token(Token = "0x400571E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400571F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005720")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public WeeklyClashPanelComponents _003C_003E4__this;

			[Token(Token = "0x4005721")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6004AAE")]
			[Address(RVA = "0x425EDD0", Offset = "0x425ADD0", VA = "0x425EDD0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004AAF")]
			[Address(RVA = "0x425F048", Offset = "0x425B048", VA = "0x425F048", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4005710")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TextMeshProUGUI _textMeshProUGUITitle1;

		[Token(Token = "0x4005711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ButtonExtend _buttonExtendSeasonPassEntranceBtn;

		[Token(Token = "0x4005712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private SeasonPassEntranceBtn _seasonPassEntranceBtnSeasonPassEntranceBtn;

		[Token(Token = "0x4005713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private TextMeshProUGUI _textMeshProUGUIHintText;

		[Token(Token = "0x4005714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private RectTransform _rectTransformPreparationStatus;

		[Token(Token = "0x4005715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private WeeklyClashPanel_PreparationStatus _weeklyClashPanel_PreparationStatusPreparationStatus;

		[Token(Token = "0x4005716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RectTransform _rectTransformSettlementAndBattleStatus;

		[Token(Token = "0x4005717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private WeeklyClashPanel_SettlementAndBattleStatus _weeklyClashPanel_SettlementAndBattleStatusSettlementAndBattleStatus;

		[Token(Token = "0x4005718")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private RectTransform _rectTransformBattleStatus;

		[Token(Token = "0x4005719")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private WeeklyClashPanel_BattleStatus _weeklyClashPanel_BattleStatusBattleStatus;

		[Token(Token = "0x400571A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private RectTransform _rectTransformSettlementStatus;

		[Token(Token = "0x400571B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private WeeklyClashPanel_SettlementStatus _weeklyClashPanel_SettlementStatusSettlementStatus;

		[Token(Token = "0x400571C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private ButtonExtend _buttonExtendCloseBtn;

		[Token(Token = "0x400571D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private ButtonExtend _buttonExtendRewardPreviewBtn;

		[Token(Token = "0x17000D1B")]
		public TextMeshProUGUI TextMeshProUGUITitle1
		{
			[Token(Token = "0x6004A97")]
			[Address(RVA = "0x425D50C", Offset = "0x425950C", VA = "0x425D50C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D1C")]
		public ButtonExtend ButtonExtendSeasonPassEntranceBtn
		{
			[Token(Token = "0x6004A98")]
			[Address(RVA = "0x425E938", Offset = "0x425A938", VA = "0x425E938")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D1D")]
		public SeasonPassEntranceBtn SeasonPassEntranceBtnSeasonPassEntranceBtn
		{
			[Token(Token = "0x6004A99")]
			[Address(RVA = "0x425E864", Offset = "0x425A864", VA = "0x425E864")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D1E")]
		public TextMeshProUGUI TextMeshProUGUIHintText
		{
			[Token(Token = "0x6004A9A")]
			[Address(RVA = "0x425DFA8", Offset = "0x4259FA8", VA = "0x425DFA8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D1F")]
		public RectTransform RectTransformPreparationStatus
		{
			[Token(Token = "0x6004A9B")]
			[Address(RVA = "0x425D5D4", Offset = "0x42595D4", VA = "0x425D5D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D20")]
		public WeeklyClashPanel_PreparationStatus WeeklyClashPanel_PreparationStatusPreparationStatus
		{
			[Token(Token = "0x6004A9C")]
			[Address(RVA = "0x425D69C", Offset = "0x425969C", VA = "0x425D69C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D21")]
		public RectTransform RectTransformSettlementAndBattleStatus
		{
			[Token(Token = "0x6004A9D")]
			[Address(RVA = "0x425D764", Offset = "0x4259764", VA = "0x425D764")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D22")]
		public WeeklyClashPanel_SettlementAndBattleStatus WeeklyClashPanel_SettlementAndBattleStatusSettlementAndBattleStatus
		{
			[Token(Token = "0x6004A9E")]
			[Address(RVA = "0x425D9BC", Offset = "0x42599BC", VA = "0x425D9BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D23")]
		public RectTransform RectTransformBattleStatus
		{
			[Token(Token = "0x6004A9F")]
			[Address(RVA = "0x425D82C", Offset = "0x425982C", VA = "0x425D82C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D24")]
		public WeeklyClashPanel_BattleStatus WeeklyClashPanel_BattleStatusBattleStatus
		{
			[Token(Token = "0x6004AA0")]
			[Address(RVA = "0x425DA84", Offset = "0x4259A84", VA = "0x425DA84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D25")]
		public RectTransform RectTransformSettlementStatus
		{
			[Token(Token = "0x6004AA1")]
			[Address(RVA = "0x425D8F4", Offset = "0x42598F4", VA = "0x425D8F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D26")]
		public WeeklyClashPanel_SettlementStatus WeeklyClashPanel_SettlementStatusSettlementStatus
		{
			[Token(Token = "0x6004AA2")]
			[Address(RVA = "0x425DB4C", Offset = "0x4259B4C", VA = "0x425DB4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D27")]
		public ButtonExtend ButtonExtendCloseBtn
		{
			[Token(Token = "0x6004AA3")]
			[Address(RVA = "0x425EA00", Offset = "0x425AA00", VA = "0x425EA00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D28")]
		public ButtonExtend ButtonExtendRewardPreviewBtn
		{
			[Token(Token = "0x6004AA4")]
			[Address(RVA = "0x425EAC8", Offset = "0x425AAC8", VA = "0x425EAC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004AA5")]
		[Address(RVA = "0x425EB90", Offset = "0x425AB90", VA = "0x425EB90")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6004AA6")]
		[Address(RVA = "0x425ECA8", Offset = "0x425ACA8", VA = "0x425ECA8", Slot = "12")]
		protected virtual void OnButtonExtendSeasonPassEntranceBtnClicked()
		{
		}

		[Token(Token = "0x6004AA7")]
		[Address(RVA = "0x425E090", Offset = "0x425A090", VA = "0x425E090", Slot = "13")]
		protected virtual void OnButtonExtendCloseBtnClicked()
		{
		}

		[Token(Token = "0x6004AA8")]
		[Address(RVA = "0x425E1D4", Offset = "0x425A1D4", VA = "0x425E1D4", Slot = "14")]
		protected virtual void OnButtonExtendRewardPreviewBtnClicked()
		{
		}

		[Token(Token = "0x6004AA9")]
		[Address(RVA = "0x425CECC", Offset = "0x4258ECC", VA = "0x425CECC", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6004AAA")]
		[Address(RVA = "0x425E284", Offset = "0x425A284", VA = "0x425E284", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__401))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6004AAB")]
		[Address(RVA = "0x425ED14", Offset = "0x425AD14", VA = "0x425ED14", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6004AAC")]
		[Address(RVA = "0x425E248", Offset = "0x425A248", VA = "0x425E248")]
		public WeeklyClashPanelComponents()
		{
		}
	}
}
