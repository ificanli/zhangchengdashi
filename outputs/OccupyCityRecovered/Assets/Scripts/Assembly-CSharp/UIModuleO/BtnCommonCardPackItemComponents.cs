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
	[Token(Token = "0x2000763")]
	public class BtnCommonCardPackItemComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000764")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__243 : IAsyncStateMachine
		{
			[Token(Token = "0x40039DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40039DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40039E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BtnCommonCardPackItemComponents _003C_003E4__this;

			[Token(Token = "0x40039E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x600287E")]
			[Address(RVA = "0x3FB39EC", Offset = "0x3FAF9EC", VA = "0x3FB39EC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600287F")]
			[Address(RVA = "0x3FB3C64", Offset = "0x3FAFC64", VA = "0x3FB3C64", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40039CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ButtonExtend _buttonExtendBtnCommonCardPackItem;

		[Token(Token = "0x40039D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TextMeshProUGUI _textMeshProUGUITxtPrice;

		[Token(Token = "0x40039D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RewardItemUI _rewardItemUIRewardItemUI1;

		[Token(Token = "0x40039D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private RewardItemUI _rewardItemUIRewardItemUI2;

		[Token(Token = "0x40039D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private RewardItemUI _rewardItemUIRewardItemUI3;

		[Token(Token = "0x40039D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private BenefitValueItem _benefitValueItemBenefitValueItem;

		[Token(Token = "0x40039D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private TextMeshProUGUI _textMeshProUGUITxtBuyPackCount;

		[Token(Token = "0x40039D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private TextMeshProUGUI _textMeshProUGUITxtAvailable;

		[Token(Token = "0x40039D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Image _imageImgBuyLimitDuiHao;

		[Token(Token = "0x40039D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Image _imageImgCardEffBg;

		[Token(Token = "0x40039D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Image _imageImgCardIcon1;

		[Token(Token = "0x40039DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Image _imageImgCardIcon2;

		[Token(Token = "0x40039DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Image _imageImgCardIcon3;

		[Token(Token = "0x40039DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private TextMeshProUGUI _textMeshProUGUITxtGiftPackName;

		[Token(Token = "0x40039DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private TextMeshProUGUI _textMeshProUGUITxtToMonDayCutDown;

		[Token(Token = "0x170003A0")]
		public ButtonExtend ButtonExtendBtnCommonCardPackItem
		{
			[Token(Token = "0x6002868")]
			[Address(RVA = "0x3FB37E8", Offset = "0x3FAF7E8", VA = "0x3FB37E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003A1")]
		public TextMeshProUGUI TextMeshProUGUITxtPrice
		{
			[Token(Token = "0x6002869")]
			[Address(RVA = "0x3FB1630", Offset = "0x3FAD630", VA = "0x3FB1630")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003A2")]
		public RewardItemUI RewardItemUIRewardItemUI1
		{
			[Token(Token = "0x600286A")]
			[Address(RVA = "0x3FB364C", Offset = "0x3FAF64C", VA = "0x3FB364C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003A3")]
		public RewardItemUI RewardItemUIRewardItemUI2
		{
			[Token(Token = "0x600286B")]
			[Address(RVA = "0x3FB3714", Offset = "0x3FAF714", VA = "0x3FB3714")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003A4")]
		public RewardItemUI RewardItemUIRewardItemUI3
		{
			[Token(Token = "0x600286C")]
			[Address(RVA = "0x3FB3584", Offset = "0x3FAF584", VA = "0x3FB3584")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003A5")]
		public BenefitValueItem BenefitValueItemBenefitValueItem
		{
			[Token(Token = "0x600286D")]
			[Address(RVA = "0x3FB25FC", Offset = "0x3FAE5FC", VA = "0x3FB25FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003A6")]
		public TextMeshProUGUI TextMeshProUGUITxtBuyPackCount
		{
			[Token(Token = "0x600286E")]
			[Address(RVA = "0x3FB14A0", Offset = "0x3FAD4A0", VA = "0x3FB14A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003A7")]
		public TextMeshProUGUI TextMeshProUGUITxtAvailable
		{
			[Token(Token = "0x600286F")]
			[Address(RVA = "0x3FB26C4", Offset = "0x3FAE6C4", VA = "0x3FB26C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003A8")]
		public Image ImageImgBuyLimitDuiHao
		{
			[Token(Token = "0x6002870")]
			[Address(RVA = "0x3FB1568", Offset = "0x3FAD568", VA = "0x3FB1568")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003A9")]
		public Image ImageImgCardEffBg
		{
			[Token(Token = "0x6002871")]
			[Address(RVA = "0x3FB1D70", Offset = "0x3FADD70", VA = "0x3FB1D70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003AA")]
		public Image ImageImgCardIcon1
		{
			[Token(Token = "0x6002872")]
			[Address(RVA = "0x3FB332C", Offset = "0x3FAF32C", VA = "0x3FB332C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003AB")]
		public Image ImageImgCardIcon2
		{
			[Token(Token = "0x6002873")]
			[Address(RVA = "0x3FB33F4", Offset = "0x3FAF3F4", VA = "0x3FB33F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003AC")]
		public Image ImageImgCardIcon3
		{
			[Token(Token = "0x6002874")]
			[Address(RVA = "0x3FB34BC", Offset = "0x3FAF4BC", VA = "0x3FB34BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003AD")]
		public TextMeshProUGUI TextMeshProUGUITxtGiftPackName
		{
			[Token(Token = "0x6002875")]
			[Address(RVA = "0x3FB278C", Offset = "0x3FAE78C", VA = "0x3FB278C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003AE")]
		public TextMeshProUGUI TextMeshProUGUITxtToMonDayCutDown
		{
			[Token(Token = "0x6002876")]
			[Address(RVA = "0x3FB0F98", Offset = "0x3FACF98", VA = "0x3FB0F98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002877")]
		[Address(RVA = "0x3FB388C", Offset = "0x3FAF88C", VA = "0x3FB388C")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6002878")]
		[Address(RVA = "0x3FB1C44", Offset = "0x3FADC44", VA = "0x3FB1C44", Slot = "12")]
		protected virtual void OnButtonExtendBtnCommonCardPackItemClicked()
		{
		}

		[Token(Token = "0x6002879")]
		[Address(RVA = "0x3FB3914", Offset = "0x3FAF914", VA = "0x3FB3914", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600287A")]
		[Address(RVA = "0x3FB1E9C", Offset = "0x3FADE9C", VA = "0x3FB1E9C", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__243))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x600287B")]
		[Address(RVA = "0x3FB3930", Offset = "0x3FAF930", VA = "0x3FB3930", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x600287C")]
		[Address(RVA = "0x3FB1E90", Offset = "0x3FADE90", VA = "0x3FB1E90")]
		public BtnCommonCardPackItemComponents()
		{
		}
	}
}
