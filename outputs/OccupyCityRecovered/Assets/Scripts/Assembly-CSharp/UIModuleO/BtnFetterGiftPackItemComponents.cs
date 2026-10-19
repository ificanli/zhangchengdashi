using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UIFramework;
using UIModuleO.UIAnim;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x200076F")]
	public class BtnFetterGiftPackItemComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000770")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__195 : IAsyncStateMachine
		{
			[Token(Token = "0x4003A1C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003A1D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003A1E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BtnFetterGiftPackItemComponents _003C_003E4__this;

			[Token(Token = "0x4003A1F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60028D0")]
			[Address(RVA = "0x3FB8908", Offset = "0x3FB4908", VA = "0x3FB8908", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60028D1")]
			[Address(RVA = "0x3FB8B80", Offset = "0x3FB4B80", VA = "0x3FB8B80", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003A10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ButtonExtend _buttonExtendBtnFetterGiftPackItem;

		[Token(Token = "0x4003A11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TextMeshProUGUI _textMeshProUGUITxtGiftPackName;

		[Token(Token = "0x4003A12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BenefitValueItem _benefitValueItemBenefitValueItem;

		[Token(Token = "0x4003A13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Image _imageImgToMonDayCutDownBg;

		[Token(Token = "0x4003A14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TextMeshProUGUI _textMeshProUGUITxtToMonDayCutDown;

		[Token(Token = "0x4003A15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private RewardItemUI _rewardItemUIRewardItemUI1;

		[Token(Token = "0x4003A16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RewardItemUI _rewardItemUIRewardItemUI2;

		[Token(Token = "0x4003A17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private RewardItemUI _rewardItemUIRewardItemUI3;

		[Token(Token = "0x4003A18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private TextMeshProUGUI _textMeshProUGUITxtBuyPackCount;

		[Token(Token = "0x4003A19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private TextMeshProUGUI _textMeshProUGUITxtAvailable;

		[Token(Token = "0x4003A1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private TextMeshProUGUI _textMeshProUGUITxtPrice;

		[Token(Token = "0x4003A1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Image _imageImgBuyLimitDuiHao;

		[Token(Token = "0x170003BA")]
		public ButtonExtend ButtonExtendBtnFetterGiftPackItem
		{
			[Token(Token = "0x60028BD")]
			[Address(RVA = "0x3FB8704", Offset = "0x3FB4704", VA = "0x3FB8704")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003BB")]
		public TextMeshProUGUI TextMeshProUGUITxtGiftPackName
		{
			[Token(Token = "0x60028BE")]
			[Address(RVA = "0x3FB7B38", Offset = "0x3FB3B38", VA = "0x3FB7B38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003BC")]
		public BenefitValueItem BenefitValueItemBenefitValueItem
		{
			[Token(Token = "0x60028BF")]
			[Address(RVA = "0x3FB79A8", Offset = "0x3FB39A8", VA = "0x3FB79A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003BD")]
		public Image ImageImgToMonDayCutDownBg
		{
			[Token(Token = "0x60028C0")]
			[Address(RVA = "0x3FB7C00", Offset = "0x3FB3C00", VA = "0x3FB7C00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003BE")]
		public TextMeshProUGUI TextMeshProUGUITxtToMonDayCutDown
		{
			[Token(Token = "0x60028C1")]
			[Address(RVA = "0x3FB6120", Offset = "0x3FB2120", VA = "0x3FB6120")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003BF")]
		public RewardItemUI RewardItemUIRewardItemUI1
		{
			[Token(Token = "0x60028C2")]
			[Address(RVA = "0x3FB84A0", Offset = "0x3FB44A0", VA = "0x3FB84A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003C0")]
		public RewardItemUI RewardItemUIRewardItemUI2
		{
			[Token(Token = "0x60028C3")]
			[Address(RVA = "0x3FB8568", Offset = "0x3FB4568", VA = "0x3FB8568")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003C1")]
		public RewardItemUI RewardItemUIRewardItemUI3
		{
			[Token(Token = "0x60028C4")]
			[Address(RVA = "0x3FB8630", Offset = "0x3FB4630", VA = "0x3FB8630")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003C2")]
		public TextMeshProUGUI TextMeshProUGUITxtBuyPackCount
		{
			[Token(Token = "0x60028C5")]
			[Address(RVA = "0x3FB6670", Offset = "0x3FB2670", VA = "0x3FB6670")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003C3")]
		public TextMeshProUGUI TextMeshProUGUITxtAvailable
		{
			[Token(Token = "0x60028C6")]
			[Address(RVA = "0x3FB7A70", Offset = "0x3FB3A70", VA = "0x3FB7A70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003C4")]
		public TextMeshProUGUI TextMeshProUGUITxtPrice
		{
			[Token(Token = "0x60028C7")]
			[Address(RVA = "0x3FB6800", Offset = "0x3FB2800", VA = "0x3FB6800")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003C5")]
		public Image ImageImgBuyLimitDuiHao
		{
			[Token(Token = "0x60028C8")]
			[Address(RVA = "0x3FB6738", Offset = "0x3FB2738", VA = "0x3FB6738")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60028C9")]
		[Address(RVA = "0x3FB87A8", Offset = "0x3FB47A8", VA = "0x3FB87A8")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x60028CA")]
		[Address(RVA = "0x3FB6EC4", Offset = "0x3FB2EC4", VA = "0x3FB6EC4", Slot = "12")]
		protected virtual void OnButtonExtendBtnFetterGiftPackItemClicked()
		{
		}

		[Token(Token = "0x60028CB")]
		[Address(RVA = "0x3FB8830", Offset = "0x3FB4830", VA = "0x3FB8830", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60028CC")]
		[Address(RVA = "0x3FB6F44", Offset = "0x3FB2F44", VA = "0x3FB6F44", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__195))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60028CD")]
		[Address(RVA = "0x3FB884C", Offset = "0x3FB484C", VA = "0x3FB884C", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60028CE")]
		[Address(RVA = "0x3FB6F38", Offset = "0x3FB2F38", VA = "0x3FB6F38")]
		public BtnFetterGiftPackItemComponents()
		{
		}
	}
}
