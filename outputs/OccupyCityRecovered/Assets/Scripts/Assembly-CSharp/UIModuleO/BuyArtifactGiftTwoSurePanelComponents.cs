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
	[Token(Token = "0x2000B32")]
	public class BuyArtifactGiftTwoSurePanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B33")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__986 : IAsyncStateMachine
		{
			[Token(Token = "0x40051B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40051B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40051B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BuyArtifactGiftTwoSurePanelComponents _003C_003E4__this;

			[Token(Token = "0x40051B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6004431")]
			[Address(RVA = "0x41E8160", Offset = "0x41E4160", VA = "0x41E8160", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004432")]
			[Address(RVA = "0x41E83D8", Offset = "0x41E43D8", VA = "0x41E83D8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40051A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Button _buttonBG;

		[Token(Token = "0x40051A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RectTransform _rectTransformImgBg;

		[Token(Token = "0x40051A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Image _imageImgArtifact;

		[Token(Token = "0x40051A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private RectTransform _rectTransformImgDailyRewardBg;

		[Token(Token = "0x40051A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ImgIAPArtifactCardItem _imgIAPArtifactCardItemCardItem;

		[Token(Token = "0x40051A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private RewardItemUI _rewardItemUIRewardItemUI1;

		[Token(Token = "0x40051A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private ButtonExtend _buttonExtendShowDes;

		[Token(Token = "0x40051A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private RewardItemUI _rewardItemUIRewardItemUI2;

		[Token(Token = "0x40051A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private ButtonExtend _buttonExtendShowDes1;

		[Token(Token = "0x40051A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private RewardItemUI _rewardItemUIRewardItemUI3;

		[Token(Token = "0x40051AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private ButtonExtend _buttonExtendShowDes2;

		[Token(Token = "0x40051AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private TextMeshProUGUI _textMeshProUGUITxtEffDes;

		[Token(Token = "0x40051AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private TextMeshProUGUI _textMeshProUGUITxtArtifactNum;

		[Token(Token = "0x40051AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private ButtonExtend _buttonExtendBtnClose;

		[Token(Token = "0x40051AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private ButtonExtend _buttonExtendBtnBuy;

		[Token(Token = "0x40051AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private TextMeshProUGUI _textMeshProUGUITxtBuy;

		[Token(Token = "0x40051B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private BenefitValueItem _benefitValueItemBenefitValueItem;

		[Token(Token = "0x17000B29")]
		public Button ButtonBG
		{
			[Token(Token = "0x6004414")]
			[Address(RVA = "0x41E7980", Offset = "0x41E3980", VA = "0x41E7980")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B2A")]
		public RectTransform RectTransformImgBg
		{
			[Token(Token = "0x6004415")]
			[Address(RVA = "0x41E55F4", Offset = "0x41E15F4", VA = "0x41E55F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B2B")]
		public Image ImageImgArtifact
		{
			[Token(Token = "0x6004416")]
			[Address(RVA = "0x41E56BC", Offset = "0x41E16BC", VA = "0x41E56BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B2C")]
		public RectTransform RectTransformImgDailyRewardBg
		{
			[Token(Token = "0x6004417")]
			[Address(RVA = "0x41E78AC", Offset = "0x41E38AC", VA = "0x41E78AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B2D")]
		public ImgIAPArtifactCardItem ImgIAPArtifactCardItemCardItem
		{
			[Token(Token = "0x6004418")]
			[Address(RVA = "0x41E7654", Offset = "0x41E3654", VA = "0x41E7654")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B2E")]
		public RewardItemUI RewardItemUIRewardItemUI1
		{
			[Token(Token = "0x6004419")]
			[Address(RVA = "0x41E73FC", Offset = "0x41E33FC", VA = "0x41E73FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B2F")]
		public ButtonExtend ButtonExtendShowDes
		{
			[Token(Token = "0x600441A")]
			[Address(RVA = "0x41E7A48", Offset = "0x41E3A48", VA = "0x41E7A48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B30")]
		public RewardItemUI RewardItemUIRewardItemUI2
		{
			[Token(Token = "0x600441B")]
			[Address(RVA = "0x41E74C4", Offset = "0x41E34C4", VA = "0x41E74C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B31")]
		public ButtonExtend ButtonExtendShowDes1
		{
			[Token(Token = "0x600441C")]
			[Address(RVA = "0x41E7B10", Offset = "0x41E3B10", VA = "0x41E7B10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B32")]
		public RewardItemUI RewardItemUIRewardItemUI3
		{
			[Token(Token = "0x600441D")]
			[Address(RVA = "0x41E758C", Offset = "0x41E358C", VA = "0x41E758C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B33")]
		public ButtonExtend ButtonExtendShowDes2
		{
			[Token(Token = "0x600441E")]
			[Address(RVA = "0x41E7BD8", Offset = "0x41E3BD8", VA = "0x41E7BD8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B34")]
		public TextMeshProUGUI TextMeshProUGUITxtEffDes
		{
			[Token(Token = "0x600441F")]
			[Address(RVA = "0x41E77E4", Offset = "0x41E37E4", VA = "0x41E77E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B35")]
		public TextMeshProUGUI TextMeshProUGUITxtArtifactNum
		{
			[Token(Token = "0x6004420")]
			[Address(RVA = "0x41E771C", Offset = "0x41E371C", VA = "0x41E771C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B36")]
		public ButtonExtend ButtonExtendBtnClose
		{
			[Token(Token = "0x6004421")]
			[Address(RVA = "0x41E7CA0", Offset = "0x41E3CA0", VA = "0x41E7CA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B37")]
		public ButtonExtend ButtonExtendBtnBuy
		{
			[Token(Token = "0x6004422")]
			[Address(RVA = "0x41E7D68", Offset = "0x41E3D68", VA = "0x41E7D68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B38")]
		public TextMeshProUGUI TextMeshProUGUITxtBuy
		{
			[Token(Token = "0x6004423")]
			[Address(RVA = "0x41E726C", Offset = "0x41E326C", VA = "0x41E726C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B39")]
		public BenefitValueItem BenefitValueItemBenefitValueItem
		{
			[Token(Token = "0x6004424")]
			[Address(RVA = "0x41E7334", Offset = "0x41E3334", VA = "0x41E7334")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004425")]
		[Address(RVA = "0x41E7E30", Offset = "0x41E3E30", VA = "0x41E7E30")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6004426")]
		[Address(RVA = "0x41E5DF8", Offset = "0x41E1DF8", VA = "0x41E5DF8", Slot = "12")]
		protected virtual void OnButtonBGClicked()
		{
		}

		[Token(Token = "0x6004427")]
		[Address(RVA = "0x41E8014", Offset = "0x41E4014", VA = "0x41E8014", Slot = "13")]
		protected virtual void OnButtonExtendShowDesClicked()
		{
		}

		[Token(Token = "0x6004428")]
		[Address(RVA = "0x41E8080", Offset = "0x41E4080", VA = "0x41E8080", Slot = "14")]
		protected virtual void OnButtonExtendShowDes1Clicked()
		{
		}

		[Token(Token = "0x6004429")]
		[Address(RVA = "0x41E80EC", Offset = "0x41E40EC", VA = "0x41E80EC", Slot = "15")]
		protected virtual void OnButtonExtendShowDes2Clicked()
		{
		}

		[Token(Token = "0x600442A")]
		[Address(RVA = "0x41E5C2C", Offset = "0x41E1C2C", VA = "0x41E5C2C", Slot = "16")]
		protected virtual void OnButtonExtendBtnCloseClicked()
		{
		}

		[Token(Token = "0x600442B")]
		[Address(RVA = "0x41E5BA0", Offset = "0x41E1BA0", VA = "0x41E5BA0", Slot = "17")]
		protected virtual void OnButtonExtendBtnBuyClicked()
		{
		}

		[Token(Token = "0x600442C")]
		[Address(RVA = "0x41E55D8", Offset = "0x41E15D8", VA = "0x41E55D8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600442D")]
		[Address(RVA = "0x41E5EEC", Offset = "0x41E1EEC", VA = "0x41E5EEC", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__986))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x600442E")]
		[Address(RVA = "0x41E5D24", Offset = "0x41E1D24", VA = "0x41E5D24", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x600442F")]
		[Address(RVA = "0x41E5EE0", Offset = "0x41E1EE0", VA = "0x41E5EE0")]
		public BuyArtifactGiftTwoSurePanelComponents()
		{
		}
	}
}
