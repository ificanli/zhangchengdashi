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
	[Token(Token = "0x2000743")]
	public class BtnArtifactPackItemBComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000744")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__234 : IAsyncStateMachine
		{
			[Token(Token = "0x400392C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400392D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400392E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BtnArtifactPackItemBComponents _003C_003E4__this;

			[Token(Token = "0x400392F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60027B1")]
			[Address(RVA = "0x3FA8758", Offset = "0x3FA4758", VA = "0x3FA8758", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60027B2")]
			[Address(RVA = "0x3FA89D0", Offset = "0x3FA49D0", VA = "0x3FA89D0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400391E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ButtonExtend _buttonExtendBtnArtifactPackItemB;

		[Token(Token = "0x400391F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TextMeshProUGUI _textMeshProUGUITxtGiftPackName;

		[Token(Token = "0x4003920")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TextMeshProUGUI _textMeshProUGUITxtPrice;

		[Token(Token = "0x4003921")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private RewardItemUI _rewardItemUIRewardItemUI1;

		[Token(Token = "0x4003922")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private RewardItemUI _rewardItemUIRewardItemUI2;

		[Token(Token = "0x4003923")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private RewardItemUI _rewardItemUIRewardItemUI3;

		[Token(Token = "0x4003924")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private BenefitValueItem _benefitValueItemBenefitValueItem;

		[Token(Token = "0x4003925")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private RectTransform _rectTransformBuyGiftLimitRoot;

		[Token(Token = "0x4003926")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private TextMeshProUGUI _textMeshProUGUITxtBuyPackCount;

		[Token(Token = "0x4003927")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private TextMeshProUGUI _textMeshProUGUITxtAvailable;

		[Token(Token = "0x4003928")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Image _imageImgBuyLimitDuiHao;

		[Token(Token = "0x4003929")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Image _imageImgToMonDayCutDownBg;

		[Token(Token = "0x400392A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private TextMeshProUGUI _textMeshProUGUITxtToMonDayCutDown;

		[Token(Token = "0x400392B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Image _imageImgGoldArtifactIcon;

		[Token(Token = "0x1700035B")]
		public ButtonExtend ButtonExtendBtnArtifactPackItemB
		{
			[Token(Token = "0x600279C")]
			[Address(RVA = "0x3FA8554", Offset = "0x3FA4554", VA = "0x3FA8554")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700035C")]
		public TextMeshProUGUI TextMeshProUGUITxtGiftPackName
		{
			[Token(Token = "0x600279D")]
			[Address(RVA = "0x3FA8160", Offset = "0x3FA4160", VA = "0x3FA8160")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700035D")]
		public TextMeshProUGUI TextMeshProUGUITxtPrice
		{
			[Token(Token = "0x600279E")]
			[Address(RVA = "0x3FA61A0", Offset = "0x3FA21A0", VA = "0x3FA61A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700035E")]
		public RewardItemUI RewardItemUIRewardItemUI1
		{
			[Token(Token = "0x600279F")]
			[Address(RVA = "0x3FA8228", Offset = "0x3FA4228", VA = "0x3FA8228")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700035F")]
		public RewardItemUI RewardItemUIRewardItemUI2
		{
			[Token(Token = "0x60027A0")]
			[Address(RVA = "0x3FA82F0", Offset = "0x3FA42F0", VA = "0x3FA82F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000360")]
		public RewardItemUI RewardItemUIRewardItemUI3
		{
			[Token(Token = "0x60027A1")]
			[Address(RVA = "0x3FA83B8", Offset = "0x3FA43B8", VA = "0x3FA83B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000361")]
		public BenefitValueItem BenefitValueItemBenefitValueItem
		{
			[Token(Token = "0x60027A2")]
			[Address(RVA = "0x3FA72E4", Offset = "0x3FA32E4", VA = "0x3FA72E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000362")]
		public RectTransform RectTransformBuyGiftLimitRoot
		{
			[Token(Token = "0x60027A3")]
			[Address(RVA = "0x3FA7474", Offset = "0x3FA3474", VA = "0x3FA7474")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000363")]
		public TextMeshProUGUI TextMeshProUGUITxtBuyPackCount
		{
			[Token(Token = "0x60027A4")]
			[Address(RVA = "0x3FA6010", Offset = "0x3FA2010", VA = "0x3FA6010")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000364")]
		public TextMeshProUGUI TextMeshProUGUITxtAvailable
		{
			[Token(Token = "0x60027A5")]
			[Address(RVA = "0x3FA753C", Offset = "0x3FA353C", VA = "0x3FA753C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000365")]
		public Image ImageImgBuyLimitDuiHao
		{
			[Token(Token = "0x60027A6")]
			[Address(RVA = "0x3FA60D8", Offset = "0x3FA20D8", VA = "0x3FA60D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000366")]
		public Image ImageImgToMonDayCutDownBg
		{
			[Token(Token = "0x60027A7")]
			[Address(RVA = "0x3FA73AC", Offset = "0x3FA33AC", VA = "0x3FA73AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000367")]
		public TextMeshProUGUI TextMeshProUGUITxtToMonDayCutDown
		{
			[Token(Token = "0x60027A8")]
			[Address(RVA = "0x3FA5A2C", Offset = "0x3FA1A2C", VA = "0x3FA5A2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000368")]
		public Image ImageImgGoldArtifactIcon
		{
			[Token(Token = "0x60027A9")]
			[Address(RVA = "0x3FA8480", Offset = "0x3FA4480", VA = "0x3FA8480")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60027AA")]
		[Address(RVA = "0x3FA85F8", Offset = "0x3FA45F8", VA = "0x3FA85F8")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x60027AB")]
		[Address(RVA = "0x3FA6B60", Offset = "0x3FA2B60", VA = "0x3FA6B60", Slot = "12")]
		protected virtual void OnButtonExtendBtnArtifactPackItemBClicked()
		{
		}

		[Token(Token = "0x60027AC")]
		[Address(RVA = "0x3FA8680", Offset = "0x3FA4680", VA = "0x3FA8680", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60027AD")]
		[Address(RVA = "0x3FA6C08", Offset = "0x3FA2C08", VA = "0x3FA6C08", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__234))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60027AE")]
		[Address(RVA = "0x3FA869C", Offset = "0x3FA469C", VA = "0x3FA869C", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60027AF")]
		[Address(RVA = "0x3FA6BD4", Offset = "0x3FA2BD4", VA = "0x3FA6BD4")]
		public BtnArtifactPackItemBComponents()
		{
		}
	}
}
