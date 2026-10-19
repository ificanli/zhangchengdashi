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
	[Token(Token = "0x2000B37")]
	public class BuyGiftPackTwoSurePanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B38")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__776 : IAsyncStateMachine
		{
			[Token(Token = "0x40051D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40051D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40051D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BuyGiftPackTwoSurePanelComponents _003C_003E4__this;

			[Token(Token = "0x40051D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x600446B")]
			[Address(RVA = "0x41EBC30", Offset = "0x41E7C30", VA = "0x41EBC30", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600446C")]
			[Address(RVA = "0x41EBEA8", Offset = "0x41E7EA8", VA = "0x41EBEA8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40051C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Button _buttonBG;

		[Token(Token = "0x40051C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RectTransform _rectTransformRoot;

		[Token(Token = "0x40051C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RectTransform _rectTransformRoleRoot;

		[Token(Token = "0x40051C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private RectTransform _rectTransformConntRoot;

		[Token(Token = "0x40051C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TextMeshProUGUI _textMeshProUGUITxtGiftName;

		[Token(Token = "0x40051C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private ButtonExtend _buttonExtendBtnClose;

		[Token(Token = "0x40051C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RectTransform _rectTransformContent;

		[Token(Token = "0x40051C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private GridLayoutGroup _gridLayoutGroupContent;

		[Token(Token = "0x40051C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private RewardItemUI _rewardItemUIRewardItemUI1;

		[Token(Token = "0x40051C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private ButtonExtend _buttonExtendShowDes;

		[Token(Token = "0x40051CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private RewardItemUI _rewardItemUIRewardItemUI2;

		[Token(Token = "0x40051CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private ButtonExtend _buttonExtendShowDes1;

		[Token(Token = "0x40051CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private RewardItemUI _rewardItemUIRewardItemUI3;

		[Token(Token = "0x40051CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private ButtonExtend _buttonExtendShowDes2;

		[Token(Token = "0x40051CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private ButtonExtend _buttonExtendBtnBuy;

		[Token(Token = "0x40051CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private TextMeshProUGUI _textMeshProUGUITxtPriceNum;

		[Token(Token = "0x40051D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private RectTransform _rectTransformBenefitValueItem;

		[Token(Token = "0x40051D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private BenefitValueItem _benefitValueItemBenefitValueItem;

		[Token(Token = "0x17000B3A")]
		public Button ButtonBG
		{
			[Token(Token = "0x600444D")]
			[Address(RVA = "0x41EB450", Offset = "0x41E7450", VA = "0x41EB450")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B3B")]
		public RectTransform RectTransformRoot
		{
			[Token(Token = "0x600444E")]
			[Address(RVA = "0x41E84F4", Offset = "0x41E44F4", VA = "0x41E84F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B3C")]
		public RectTransform RectTransformRoleRoot
		{
			[Token(Token = "0x600444F")]
			[Address(RVA = "0x41E8C98", Offset = "0x41E4C98", VA = "0x41E8C98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B3D")]
		public RectTransform RectTransformConntRoot
		{
			[Token(Token = "0x6004450")]
			[Address(RVA = "0x41EA95C", Offset = "0x41E695C", VA = "0x41EA95C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B3E")]
		public TextMeshProUGUI TextMeshProUGUITxtGiftName
		{
			[Token(Token = "0x6004451")]
			[Address(RVA = "0x41E9544", Offset = "0x41E5544", VA = "0x41E9544")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B3F")]
		public ButtonExtend ButtonExtendBtnClose
		{
			[Token(Token = "0x6004452")]
			[Address(RVA = "0x41EB518", Offset = "0x41E7518", VA = "0x41EB518")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B40")]
		public RectTransform RectTransformContent
		{
			[Token(Token = "0x6004453")]
			[Address(RVA = "0x41EA61C", Offset = "0x41E661C", VA = "0x41EA61C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B41")]
		public GridLayoutGroup GridLayoutGroupContent
		{
			[Token(Token = "0x6004454")]
			[Address(RVA = "0x41EA894", Offset = "0x41E6894", VA = "0x41EA894")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B42")]
		public RewardItemUI RewardItemUIRewardItemUI1
		{
			[Token(Token = "0x6004455")]
			[Address(RVA = "0x41E8F78", Offset = "0x41E4F78", VA = "0x41E8F78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B43")]
		public ButtonExtend ButtonExtendShowDes
		{
			[Token(Token = "0x6004456")]
			[Address(RVA = "0x41EB5E0", Offset = "0x41E75E0", VA = "0x41EB5E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B44")]
		public RewardItemUI RewardItemUIRewardItemUI2
		{
			[Token(Token = "0x6004457")]
			[Address(RVA = "0x41E9040", Offset = "0x41E5040", VA = "0x41E9040")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B45")]
		public ButtonExtend ButtonExtendShowDes1
		{
			[Token(Token = "0x6004458")]
			[Address(RVA = "0x41EB6A8", Offset = "0x41E76A8", VA = "0x41EB6A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B46")]
		public RewardItemUI RewardItemUIRewardItemUI3
		{
			[Token(Token = "0x6004459")]
			[Address(RVA = "0x41E9108", Offset = "0x41E5108", VA = "0x41E9108")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B47")]
		public ButtonExtend ButtonExtendShowDes2
		{
			[Token(Token = "0x600445A")]
			[Address(RVA = "0x41EB770", Offset = "0x41E7770", VA = "0x41EB770")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B48")]
		public ButtonExtend ButtonExtendBtnBuy
		{
			[Token(Token = "0x600445B")]
			[Address(RVA = "0x41EB838", Offset = "0x41E7838", VA = "0x41EB838")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B49")]
		public TextMeshProUGUI TextMeshProUGUITxtPriceNum
		{
			[Token(Token = "0x600445C")]
			[Address(RVA = "0x41E947C", Offset = "0x41E547C", VA = "0x41E947C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B4A")]
		public RectTransform RectTransformBenefitValueItem
		{
			[Token(Token = "0x600445D")]
			[Address(RVA = "0x41E9B48", Offset = "0x41E5B48", VA = "0x41E9B48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B4B")]
		public BenefitValueItem BenefitValueItemBenefitValueItem
		{
			[Token(Token = "0x600445E")]
			[Address(RVA = "0x41E9A80", Offset = "0x41E5A80", VA = "0x41E9A80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600445F")]
		[Address(RVA = "0x41EB900", Offset = "0x41E7900", VA = "0x41EB900")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6004460")]
		[Address(RVA = "0x41E8D80", Offset = "0x41E4D80", VA = "0x41E8D80", Slot = "12")]
		protected virtual void OnButtonBGClicked()
		{
		}

		[Token(Token = "0x6004461")]
		[Address(RVA = "0x41E8A0C", Offset = "0x41E4A0C", VA = "0x41E8A0C", Slot = "13")]
		protected virtual void OnButtonExtendBtnCloseClicked()
		{
		}

		[Token(Token = "0x6004462")]
		[Address(RVA = "0x41EBAE4", Offset = "0x41E7AE4", VA = "0x41EBAE4", Slot = "14")]
		protected virtual void OnButtonExtendShowDesClicked()
		{
		}

		[Token(Token = "0x6004463")]
		[Address(RVA = "0x41EBB50", Offset = "0x41E7B50", VA = "0x41EBB50", Slot = "15")]
		protected virtual void OnButtonExtendShowDes1Clicked()
		{
		}

		[Token(Token = "0x6004464")]
		[Address(RVA = "0x41EBBBC", Offset = "0x41E7BBC", VA = "0x41EBBBC", Slot = "16")]
		protected virtual void OnButtonExtendShowDes2Clicked()
		{
		}

		[Token(Token = "0x6004465")]
		[Address(RVA = "0x41E8980", Offset = "0x41E4980", VA = "0x41E8980", Slot = "17")]
		protected virtual void OnButtonExtendBtnBuyClicked()
		{
		}

		[Token(Token = "0x6004466")]
		[Address(RVA = "0x41E84D8", Offset = "0x41E44D8", VA = "0x41E84D8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6004467")]
		[Address(RVA = "0x41EAAD4", Offset = "0x41E6AD4", VA = "0x41EAAD4", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__776))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6004468")]
		[Address(RVA = "0x41E8A88", Offset = "0x41E4A88", VA = "0x41E8A88", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6004469")]
		[Address(RVA = "0x41EAAA0", Offset = "0x41E6AA0", VA = "0x41EAAA0")]
		public BuyGiftPackTwoSurePanelComponents()
		{
		}
	}
}
