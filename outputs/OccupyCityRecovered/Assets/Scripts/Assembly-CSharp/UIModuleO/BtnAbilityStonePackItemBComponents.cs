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
	[Token(Token = "0x200072E")]
	public class BtnAbilityStonePackItemBComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200072F")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__198 : IAsyncStateMachine
		{
			[Token(Token = "0x40038B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40038B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40038B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BtnAbilityStonePackItemBComponents _003C_003E4__this;

			[Token(Token = "0x40038B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6002728")]
			[Address(RVA = "0x3F9DF30", Offset = "0x3F99F30", VA = "0x3F9DF30", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002729")]
			[Address(RVA = "0x3F9E1A8", Offset = "0x3F9A1A8", VA = "0x3F9E1A8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40038A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ButtonExtend _buttonExtendBtnAbilityStonePackItemB;

		[Token(Token = "0x40038AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TextMeshProUGUI _textMeshProUGUITxtPrice;

		[Token(Token = "0x40038AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TextMeshProUGUI _textMeshProUGUICount1;

		[Token(Token = "0x40038AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private RewardItemUI _rewardItemUIRewardItemUI2;

		[Token(Token = "0x40038AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private RewardItemUI _rewardItemUIRewardItemUI3;

		[Token(Token = "0x40038AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private TextMeshProUGUI _textMeshProUGUITxtToMonDayCutDown;

		[Token(Token = "0x40038AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private BenefitValueItem _benefitValueItemBenefitValueItem;

		[Token(Token = "0x17000335")]
		public ButtonExtend ButtonExtendBtnAbilityStonePackItemB
		{
			[Token(Token = "0x600271A")]
			[Address(RVA = "0x3F9DCB4", Offset = "0x3F99CB4", VA = "0x3F9DCB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000336")]
		public TextMeshProUGUI TextMeshProUGUITxtPrice
		{
			[Token(Token = "0x600271B")]
			[Address(RVA = "0x3F9D8C0", Offset = "0x3F998C0", VA = "0x3F9D8C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000337")]
		public TextMeshProUGUI TextMeshProUGUICount1
		{
			[Token(Token = "0x600271C")]
			[Address(RVA = "0x3F9DA50", Offset = "0x3F99A50", VA = "0x3F9DA50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000338")]
		public RewardItemUI RewardItemUIRewardItemUI2
		{
			[Token(Token = "0x600271D")]
			[Address(RVA = "0x3F9DB18", Offset = "0x3F99B18", VA = "0x3F9DB18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000339")]
		public RewardItemUI RewardItemUIRewardItemUI3
		{
			[Token(Token = "0x600271E")]
			[Address(RVA = "0x3F9DBE0", Offset = "0x3F99BE0", VA = "0x3F9DBE0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700033A")]
		public TextMeshProUGUI TextMeshProUGUITxtToMonDayCutDown
		{
			[Token(Token = "0x600271F")]
			[Address(RVA = "0x3F9CFB8", Offset = "0x3F98FB8", VA = "0x3F9CFB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700033B")]
		public BenefitValueItem BenefitValueItemBenefitValueItem
		{
			[Token(Token = "0x6002720")]
			[Address(RVA = "0x3F9D988", Offset = "0x3F99988", VA = "0x3F9D988")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002721")]
		[Address(RVA = "0x3F9DD58", Offset = "0x3F99D58", VA = "0x3F9DD58")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6002722")]
		[Address(RVA = "0x3F9D114", Offset = "0x3F99114", VA = "0x3F9D114", Slot = "12")]
		protected virtual void OnButtonExtendBtnAbilityStonePackItemBClicked()
		{
		}

		[Token(Token = "0x6002723")]
		[Address(RVA = "0x3F9CE94", Offset = "0x3F98E94", VA = "0x3F9CE94", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002724")]
		[Address(RVA = "0x3F9DDE0", Offset = "0x3F99DE0", VA = "0x3F9DDE0", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__198))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002725")]
		[Address(RVA = "0x3F9DE74", Offset = "0x3F99E74", VA = "0x3F9DE74", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6002726")]
		[Address(RVA = "0x3F9D188", Offset = "0x3F99188", VA = "0x3F9D188")]
		public BtnAbilityStonePackItemBComponents()
		{
		}
	}
}
