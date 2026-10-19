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
	[Token(Token = "0x2000778")]
	public class BtnMonthlyCardItemBComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000779")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__180 : IAsyncStateMachine
		{
			[Token(Token = "0x4003A57")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003A58")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003A59")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BtnMonthlyCardItemBComponents _003C_003E4__this;

			[Token(Token = "0x4003A5A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6002913")]
			[Address(RVA = "0x3FBE0C4", Offset = "0x3FBA0C4", VA = "0x3FBE0C4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002914")]
			[Address(RVA = "0x3FBE33C", Offset = "0x3FBA33C", VA = "0x3FBE33C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003A4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ButtonExtend _buttonExtendBtnMonthlyCardItemB;

		[Token(Token = "0x4003A50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TextMeshProUGUI _textMeshProUGUITxtGiftPackName;

		[Token(Token = "0x4003A51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TextMeshProUGUI _textMeshProUGUITxtPrice;

		[Token(Token = "0x4003A52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private TextMeshProUGUI _textMeshProUGUITxtDailyReward;

		[Token(Token = "0x4003A53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private BenefitValueItem _benefitValueItemBenefitValueItem;

		[Token(Token = "0x4003A54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private RewardItemUI _rewardItemUIRewardItemUI1;

		[Token(Token = "0x4003A55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RewardItemUI _rewardItemUIRewardItemUI2;

		[Token(Token = "0x4003A56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private RewardItemUI _rewardItemUIRewardItemUI3;

		[Token(Token = "0x170003D5")]
		public ButtonExtend ButtonExtendBtnMonthlyCardItemB
		{
			[Token(Token = "0x6002904")]
			[Address(RVA = "0x3FBDE2C", Offset = "0x3FB9E2C", VA = "0x3FBDE2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003D6")]
		public TextMeshProUGUI TextMeshProUGUITxtGiftPackName
		{
			[Token(Token = "0x6002905")]
			[Address(RVA = "0x3FBD40C", Offset = "0x3FB940C", VA = "0x3FBD40C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003D7")]
		public TextMeshProUGUI TextMeshProUGUITxtPrice
		{
			[Token(Token = "0x6002906")]
			[Address(RVA = "0x3FBD59C", Offset = "0x3FB959C", VA = "0x3FBD59C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003D8")]
		public TextMeshProUGUI TextMeshProUGUITxtDailyReward
		{
			[Token(Token = "0x6002907")]
			[Address(RVA = "0x3FBD4D4", Offset = "0x3FB94D4", VA = "0x3FBD4D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003D9")]
		public BenefitValueItem BenefitValueItemBenefitValueItem
		{
			[Token(Token = "0x6002908")]
			[Address(RVA = "0x3FBD664", Offset = "0x3FB9664", VA = "0x3FBD664")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003DA")]
		public RewardItemUI RewardItemUIRewardItemUI1
		{
			[Token(Token = "0x6002909")]
			[Address(RVA = "0x3FBD980", Offset = "0x3FB9980", VA = "0x3FBD980")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003DB")]
		public RewardItemUI RewardItemUIRewardItemUI2
		{
			[Token(Token = "0x600290A")]
			[Address(RVA = "0x3FBDB8C", Offset = "0x3FB9B8C", VA = "0x3FBDB8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003DC")]
		public RewardItemUI RewardItemUIRewardItemUI3
		{
			[Token(Token = "0x600290B")]
			[Address(RVA = "0x3FBDC54", Offset = "0x3FB9C54", VA = "0x3FBDC54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600290C")]
		[Address(RVA = "0x3FBDED0", Offset = "0x3FB9ED0", VA = "0x3FBDED0")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x600290D")]
		[Address(RVA = "0x3FBDD88", Offset = "0x3FB9D88", VA = "0x3FBDD88", Slot = "12")]
		protected virtual void OnButtonExtendBtnMonthlyCardItemBClicked()
		{
		}

		[Token(Token = "0x600290E")]
		[Address(RVA = "0x3FBDF58", Offset = "0x3FB9F58", VA = "0x3FBDF58", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600290F")]
		[Address(RVA = "0x3FBDF74", Offset = "0x3FB9F74", VA = "0x3FBDF74", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__180))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002910")]
		[Address(RVA = "0x3FBE008", Offset = "0x3FBA008", VA = "0x3FBE008", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6002911")]
		[Address(RVA = "0x3FBDDFC", Offset = "0x3FB9DFC", VA = "0x3FBDDFC")]
		public BtnMonthlyCardItemBComponents()
		{
		}
	}
}
