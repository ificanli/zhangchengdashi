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
	[Token(Token = "0x20006AE")]
	public class ArenaGiftPackPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20006AF")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__674 : IAsyncStateMachine
		{
			[Token(Token = "0x400357D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400357E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400357F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ArenaGiftPackPanelComponents _003C_003E4__this;

			[Token(Token = "0x4003580")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6002370")]
			[Address(RVA = "0x3F45D48", Offset = "0x3F41D48", VA = "0x3F45D48", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002371")]
			[Address(RVA = "0x3F45FC0", Offset = "0x3F41FC0", VA = "0x3F45FC0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Button _buttonBackground;

		[Token(Token = "0x4003572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RectTransform _rectTransformContents;

		[Token(Token = "0x4003573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TextMeshProUGUI _textMeshProUGUITitle;

		[Token(Token = "0x4003574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ButtonExtend _buttonExtendClose;

		[Token(Token = "0x4003575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private BenefitValueItem _benefitValueItemBenefitValueItem;

		[Token(Token = "0x4003576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Image _imageBusinessCard;

		[Token(Token = "0x4003577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RewardItemUI _rewardItemUIRewardItemUI1;

		[Token(Token = "0x4003578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private RewardItemUI _rewardItemUIRewardItemUI2;

		[Token(Token = "0x4003579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private RewardItemUI _rewardItemUIRewardItemUI3;

		[Token(Token = "0x400357A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private TextMeshProUGUI _textMeshProUGUITimerText;

		[Token(Token = "0x400357B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private HWIAPButton _hWIAPButtonHWIAPButton;

		[Token(Token = "0x400357C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private ButtonExtend _buttonExtendHWIAPButton;

		[Token(Token = "0x17000200")]
		public Button ButtonBackground
		{
			[Token(Token = "0x600235B")]
			[Address(RVA = "0x3F45964", Offset = "0x3F41964", VA = "0x3F45964")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000201")]
		public RectTransform RectTransformContents
		{
			[Token(Token = "0x600235C")]
			[Address(RVA = "0x3F44008", Offset = "0x3F40008", VA = "0x3F44008")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000202")]
		public TextMeshProUGUI TextMeshProUGUITitle
		{
			[Token(Token = "0x600235D")]
			[Address(RVA = "0x3F457C8", Offset = "0x3F417C8", VA = "0x3F457C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000203")]
		public ButtonExtend ButtonExtendClose
		{
			[Token(Token = "0x600235E")]
			[Address(RVA = "0x3F45A2C", Offset = "0x3F41A2C", VA = "0x3F45A2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000204")]
		public BenefitValueItem BenefitValueItemBenefitValueItem
		{
			[Token(Token = "0x600235F")]
			[Address(RVA = "0x3F45700", Offset = "0x3F41700", VA = "0x3F45700")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000205")]
		public Image ImageBusinessCard
		{
			[Token(Token = "0x6002360")]
			[Address(RVA = "0x3F453E0", Offset = "0x3F413E0", VA = "0x3F453E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000206")]
		public RewardItemUI RewardItemUIRewardItemUI1
		{
			[Token(Token = "0x6002361")]
			[Address(RVA = "0x3F454A8", Offset = "0x3F414A8", VA = "0x3F454A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000207")]
		public RewardItemUI RewardItemUIRewardItemUI2
		{
			[Token(Token = "0x6002362")]
			[Address(RVA = "0x3F45570", Offset = "0x3F41570", VA = "0x3F45570")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000208")]
		public RewardItemUI RewardItemUIRewardItemUI3
		{
			[Token(Token = "0x6002363")]
			[Address(RVA = "0x3F45638", Offset = "0x3F41638", VA = "0x3F45638")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000209")]
		public TextMeshProUGUI TextMeshProUGUITimerText
		{
			[Token(Token = "0x6002364")]
			[Address(RVA = "0x3F4429C", Offset = "0x3F4029C", VA = "0x3F4429C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700020A")]
		public HWIAPButton HWIAPButtonHWIAPButton
		{
			[Token(Token = "0x6002365")]
			[Address(RVA = "0x3F45890", Offset = "0x3F41890", VA = "0x3F45890")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700020B")]
		public ButtonExtend ButtonExtendHWIAPButton
		{
			[Token(Token = "0x6002366")]
			[Address(RVA = "0x3F45AF4", Offset = "0x3F41AF4", VA = "0x3F45AF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002367")]
		[Address(RVA = "0x3F45BBC", Offset = "0x3F41BBC", VA = "0x3F45BBC")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6002368")]
		[Address(RVA = "0x3F4453C", Offset = "0x3F4053C", VA = "0x3F4453C", Slot = "12")]
		protected virtual void OnButtonBackgroundClicked()
		{
		}

		[Token(Token = "0x6002369")]
		[Address(RVA = "0x3F445C8", Offset = "0x3F405C8", VA = "0x3F445C8", Slot = "13")]
		protected virtual void OnButtonExtendCloseClicked()
		{
		}

		[Token(Token = "0x600236A")]
		[Address(RVA = "0x3F45CD4", Offset = "0x3F41CD4", VA = "0x3F45CD4", Slot = "14")]
		protected virtual void OnButtonExtendHWIAPButtonClicked()
		{
		}

		[Token(Token = "0x600236B")]
		[Address(RVA = "0x3F43FEC", Offset = "0x3F3FFEC", VA = "0x3F43FEC", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600236C")]
		[Address(RVA = "0x3F44698", Offset = "0x3F40698", VA = "0x3F44698", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__674))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x600236D")]
		[Address(RVA = "0x3F44468", Offset = "0x3F40468", VA = "0x3F44468", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x600236E")]
		[Address(RVA = "0x3F4468C", Offset = "0x3F4068C", VA = "0x3F4468C")]
		public ArenaGiftPackPanelComponents()
		{
		}
	}
}
