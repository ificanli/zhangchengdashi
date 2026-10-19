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
	[Token(Token = "0x2000768")]
	public class BtnCrystalPackItemComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000769")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__346 : IAsyncStateMachine
		{
			[Token(Token = "0x40039FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40039FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40039FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BtnCrystalPackItemComponents _003C_003E4__this;

			[Token(Token = "0x40039FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60028A6")]
			[Address(RVA = "0x3FB5C04", Offset = "0x3FB1C04", VA = "0x3FB5C04", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60028A7")]
			[Address(RVA = "0x3FB5E7C", Offset = "0x3FB1E7C", VA = "0x3FB5E7C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40039F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ButtonExtend _buttonExtendBtnCrystalPackItem;

		[Token(Token = "0x40039F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TextMeshProUGUI _textMeshProUGUITxtGiftPackName;

		[Token(Token = "0x40039F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RectTransform _rectTransformBenefitValueItem;

		[Token(Token = "0x40039F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BenefitValueItem _benefitValueItemBenefitValueItem;

		[Token(Token = "0x40039F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private RectTransform _rectTransformImgToMonDayCutDownBg;

		[Token(Token = "0x40039F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private TextMeshProUGUI _textMeshProUGUITxtToMonDayCutDown;

		[Token(Token = "0x40039F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RectTransform _rectTransformRewardRoot;

		[Token(Token = "0x40039F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private RewardItemUI _rewardItemUIRewardItemUI;

		[Token(Token = "0x40039F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private ButtonExtend _buttonExtendShowDes;

		[Token(Token = "0x40039F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private TextMeshProUGUI _textMeshProUGUITxtBuyPackCount;

		[Token(Token = "0x40039FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private TextMeshProUGUI _textMeshProUGUITxtPrice;

		[Token(Token = "0x170003AF")]
		public ButtonExtend ButtonExtendBtnCrystalPackItem
		{
			[Token(Token = "0x6002893")]
			[Address(RVA = "0x3FB52C8", Offset = "0x3FB12C8", VA = "0x3FB52C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003B0")]
		public TextMeshProUGUI TextMeshProUGUITxtGiftPackName
		{
			[Token(Token = "0x6002894")]
			[Address(RVA = "0x3FB5064", Offset = "0x3FB1064", VA = "0x3FB5064")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003B1")]
		public RectTransform RectTransformBenefitValueItem
		{
			[Token(Token = "0x6002895")]
			[Address(RVA = "0x3FB536C", Offset = "0x3FB136C", VA = "0x3FB536C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003B2")]
		public BenefitValueItem BenefitValueItemBenefitValueItem
		{
			[Token(Token = "0x6002896")]
			[Address(RVA = "0x3FB5434", Offset = "0x3FB1434", VA = "0x3FB5434")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003B3")]
		public RectTransform RectTransformImgToMonDayCutDownBg
		{
			[Token(Token = "0x6002897")]
			[Address(RVA = "0x3FB54FC", Offset = "0x3FB14FC", VA = "0x3FB54FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003B4")]
		public TextMeshProUGUI TextMeshProUGUITxtToMonDayCutDown
		{
			[Token(Token = "0x6002898")]
			[Address(RVA = "0x3FB55C4", Offset = "0x3FB15C4", VA = "0x3FB55C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003B5")]
		public RectTransform RectTransformRewardRoot
		{
			[Token(Token = "0x6002899")]
			[Address(RVA = "0x3FB568C", Offset = "0x3FB168C", VA = "0x3FB568C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003B6")]
		public RewardItemUI RewardItemUIRewardItemUI
		{
			[Token(Token = "0x600289A")]
			[Address(RVA = "0x3FB5754", Offset = "0x3FB1754", VA = "0x3FB5754")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003B7")]
		public ButtonExtend ButtonExtendShowDes
		{
			[Token(Token = "0x600289B")]
			[Address(RVA = "0x3FB581C", Offset = "0x3FB181C", VA = "0x3FB581C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003B8")]
		public TextMeshProUGUI TextMeshProUGUITxtBuyPackCount
		{
			[Token(Token = "0x600289C")]
			[Address(RVA = "0x3FB51F4", Offset = "0x3FB11F4", VA = "0x3FB51F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003B9")]
		public TextMeshProUGUI TextMeshProUGUITxtPrice
		{
			[Token(Token = "0x600289D")]
			[Address(RVA = "0x3FB512C", Offset = "0x3FB112C", VA = "0x3FB512C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600289E")]
		[Address(RVA = "0x3FB58E4", Offset = "0x3FB18E4", VA = "0x3FB58E4")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x600289F")]
		[Address(RVA = "0x3FB59B8", Offset = "0x3FB19B8", VA = "0x3FB59B8", Slot = "12")]
		protected virtual void OnButtonExtendBtnCrystalPackItemClicked()
		{
		}

		[Token(Token = "0x60028A0")]
		[Address(RVA = "0x3FB5A24", Offset = "0x3FB1A24", VA = "0x3FB5A24", Slot = "13")]
		protected virtual void OnButtonExtendShowDesClicked()
		{
		}

		[Token(Token = "0x60028A1")]
		[Address(RVA = "0x3FB5A90", Offset = "0x3FB1A90", VA = "0x3FB5A90", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60028A2")]
		[Address(RVA = "0x3FB5AAC", Offset = "0x3FB1AAC", VA = "0x3FB5AAC", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__346))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60028A3")]
		[Address(RVA = "0x3FB5B40", Offset = "0x3FB1B40", VA = "0x3FB5B40", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60028A4")]
		[Address(RVA = "0x3FB5BF4", Offset = "0x3FB1BF4", VA = "0x3FB5BF4")]
		public BtnCrystalPackItemComponents()
		{
		}
	}
}
