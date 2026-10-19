using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UIFramework;
using UIModuleO.UIAnim;

namespace UIModuleO
{
	[Token(Token = "0x2000B2D")]
	public class BtnMonthlyCardItemComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B2E")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__294 : IAsyncStateMachine
		{
			[Token(Token = "0x4005189")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400518A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400518B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BtnMonthlyCardItemComponents _003C_003E4__this;

			[Token(Token = "0x400518C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6004401")]
			[Address(RVA = "0x41E50F8", Offset = "0x41E10F8", VA = "0x41E50F8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004402")]
			[Address(RVA = "0x41E5370", Offset = "0x41E1370", VA = "0x41E5370", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400517F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ButtonExtend _buttonExtendBtnMonthlyCardItem;

		[Token(Token = "0x4005180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TextMeshProUGUI _textMeshProUGUITxtGiftPackName;

		[Token(Token = "0x4005181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TextMeshProUGUI _textMeshProUGUITxtPrice;

		[Token(Token = "0x4005182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private TextMeshProUGUI _textMeshProUGUITxtAdFree;

		[Token(Token = "0x4005183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TextMeshProUGUI _textMeshProUGUITxtMoreReward;

		[Token(Token = "0x4005184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private TextMeshProUGUI _textMeshProUGUITxtWoodNum;

		[Token(Token = "0x4005185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private TextMeshProUGUI _textMeshProUGUITxtCoinNum;

		[Token(Token = "0x4005186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private TextMeshProUGUI _textMeshProUGUITxtGemNum;

		[Token(Token = "0x4005187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private TextMeshProUGUI _textMeshProUGUITxtDailyReward;

		[Token(Token = "0x4005188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private BenefitValueItem _benefitValueItemBenefitValueItem;

		[Token(Token = "0x17000B1F")]
		public ButtonExtend ButtonExtendBtnMonthlyCardItem
		{
			[Token(Token = "0x60043F0")]
			[Address(RVA = "0x41E4E60", Offset = "0x41E0E60", VA = "0x41E4E60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B20")]
		public TextMeshProUGUI TextMeshProUGUITxtGiftPackName
		{
			[Token(Token = "0x60043F1")]
			[Address(RVA = "0x41E4964", Offset = "0x41E0964", VA = "0x41E4964")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B21")]
		public TextMeshProUGUI TextMeshProUGUITxtPrice
		{
			[Token(Token = "0x60043F2")]
			[Address(RVA = "0x41E3CC4", Offset = "0x41DFCC4", VA = "0x41E3CC4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B22")]
		public TextMeshProUGUI TextMeshProUGUITxtAdFree
		{
			[Token(Token = "0x60043F3")]
			[Address(RVA = "0x41E4A2C", Offset = "0x41E0A2C", VA = "0x41E4A2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B23")]
		public TextMeshProUGUI TextMeshProUGUITxtMoreReward
		{
			[Token(Token = "0x60043F4")]
			[Address(RVA = "0x41E4AF4", Offset = "0x41E0AF4", VA = "0x41E4AF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B24")]
		public TextMeshProUGUI TextMeshProUGUITxtWoodNum
		{
			[Token(Token = "0x60043F5")]
			[Address(RVA = "0x41E489C", Offset = "0x41E089C", VA = "0x41E489C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B25")]
		public TextMeshProUGUI TextMeshProUGUITxtCoinNum
		{
			[Token(Token = "0x60043F6")]
			[Address(RVA = "0x41E470C", Offset = "0x41E070C", VA = "0x41E470C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B26")]
		public TextMeshProUGUI TextMeshProUGUITxtGemNum
		{
			[Token(Token = "0x60043F7")]
			[Address(RVA = "0x41E47D4", Offset = "0x41E07D4", VA = "0x41E47D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B27")]
		public TextMeshProUGUI TextMeshProUGUITxtDailyReward
		{
			[Token(Token = "0x60043F8")]
			[Address(RVA = "0x41E4BBC", Offset = "0x41E0BBC", VA = "0x41E4BBC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B28")]
		public BenefitValueItem BenefitValueItemBenefitValueItem
		{
			[Token(Token = "0x60043F9")]
			[Address(RVA = "0x41E4C84", Offset = "0x41E0C84", VA = "0x41E4C84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60043FA")]
		[Address(RVA = "0x41E4F04", Offset = "0x41E0F04", VA = "0x41E4F04")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x60043FB")]
		[Address(RVA = "0x41E3DF8", Offset = "0x41DFDF8", VA = "0x41E3DF8", Slot = "12")]
		protected virtual void OnButtonExtendBtnMonthlyCardItemClicked()
		{
		}

		[Token(Token = "0x60043FC")]
		[Address(RVA = "0x41E4F8C", Offset = "0x41E0F8C", VA = "0x41E4F8C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60043FD")]
		[Address(RVA = "0x41E4FA8", Offset = "0x41E0FA8", VA = "0x41E4FA8", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__294))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60043FE")]
		[Address(RVA = "0x41E503C", Offset = "0x41E103C", VA = "0x41E503C", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60043FF")]
		[Address(RVA = "0x41E3F44", Offset = "0x41DFF44", VA = "0x41E3F44")]
		public BtnMonthlyCardItemComponents()
		{
		}
	}
}
