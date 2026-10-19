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
	[Token(Token = "0x2000736")]
	public class BtnAllFetterGiftPackItemComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000737")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__351 : IAsyncStateMachine
		{
			[Token(Token = "0x40038E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40038E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40038E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BtnAllFetterGiftPackItemComponents _003C_003E4__this;

			[Token(Token = "0x40038E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x600276C")]
			[Address(RVA = "0x3FA1974", Offset = "0x3F9D974", VA = "0x3FA1974", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600276D")]
			[Address(RVA = "0x3FA1BEC", Offset = "0x3F9DBEC", VA = "0x3FA1BEC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40038CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ButtonExtend _buttonExtendBtnAllFetterGiftPackItem;

		[Token(Token = "0x40038CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TextMeshProUGUI _textMeshProUGUITxtGiftPackName;

		[Token(Token = "0x40038CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TextMeshProUGUI _textMeshProUGUITxtPrice;

		[Token(Token = "0x40038D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private RewardItemUI _rewardItemUIRewardItemUI1;

		[Token(Token = "0x40038D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private RewardItemUI _rewardItemUIRewardItemUI2;

		[Token(Token = "0x40038D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private RewardItemUI _rewardItemUIRewardItemUI3;

		[Token(Token = "0x40038D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RewardItemUI _rewardItemUIRewardItemUI4;

		[Token(Token = "0x40038D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private RewardItemUI _rewardItemUIRewardItemUI5;

		[Token(Token = "0x40038D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private RewardItemUI _rewardItemUIRewardItemUI6;

		[Token(Token = "0x40038D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private RewardItemUI _rewardItemUIRewardItemUI7;

		[Token(Token = "0x40038D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private RewardItemUI _rewardItemUIRewardItemUI8;

		[Token(Token = "0x40038D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private RewardItemUI _rewardItemUIRewardItemUI9;

		[Token(Token = "0x40038D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private RewardItemUI _rewardItemUIRewardItemUI10;

		[Token(Token = "0x40038DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private RewardItemUI _rewardItemUIRewardItemUI11;

		[Token(Token = "0x40038DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private RewardItemUI _rewardItemUIRewardItemUI12;

		[Token(Token = "0x40038DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private RewardItemUI _rewardItemUIRewardItemUI13;

		[Token(Token = "0x40038DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private RewardItemUI _rewardItemUIRewardItemUI14;

		[Token(Token = "0x40038DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private RewardItemUI _rewardItemUIRewardItemUI15;

		[Token(Token = "0x40038DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private RewardItemUI _rewardItemUIRewardItemUI16;

		[Token(Token = "0x40038E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private BenefitValueItem _benefitValueItemBenefitValueItem;

		[Token(Token = "0x40038E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private TextMeshProUGUI _textMeshProUGUITxtBuyPackCount;

		[Token(Token = "0x40038E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private TextMeshProUGUI _textMeshProUGUITxtAvailable;

		[Token(Token = "0x40038E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Image _imageImgBuyLimitDuiHao;

		[Token(Token = "0x40038E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private TextMeshProUGUI _textMeshProUGUITxtToMonDayCutDown;

		[Token(Token = "0x17000343")]
		public ButtonExtend ButtonExtendBtnAllFetterGiftPackItem
		{
			[Token(Token = "0x600274D")]
			[Address(RVA = "0x3FA1770", Offset = "0x3F9D770", VA = "0x3FA1770")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000344")]
		public TextMeshProUGUI TextMeshProUGUITxtGiftPackName
		{
			[Token(Token = "0x600274E")]
			[Address(RVA = "0x3FA14B0", Offset = "0x3F9D4B0", VA = "0x3FA14B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000345")]
		public TextMeshProUGUI TextMeshProUGUITxtPrice
		{
			[Token(Token = "0x600274F")]
			[Address(RVA = "0x3FA0838", Offset = "0x3F9C838", VA = "0x3FA0838")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000346")]
		public RewardItemUI RewardItemUIRewardItemUI1
		{
			[Token(Token = "0x6002750")]
			[Address(RVA = "0x3F9F190", Offset = "0x3F9B190", VA = "0x3F9F190")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000347")]
		public RewardItemUI RewardItemUIRewardItemUI2
		{
			[Token(Token = "0x6002751")]
			[Address(RVA = "0x3F9F258", Offset = "0x3F9B258", VA = "0x3F9F258")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000348")]
		public RewardItemUI RewardItemUIRewardItemUI3
		{
			[Token(Token = "0x6002752")]
			[Address(RVA = "0x3F9F320", Offset = "0x3F9B320", VA = "0x3F9F320")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000349")]
		public RewardItemUI RewardItemUIRewardItemUI4
		{
			[Token(Token = "0x6002753")]
			[Address(RVA = "0x3F9F3E8", Offset = "0x3F9B3E8", VA = "0x3F9F3E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700034A")]
		public RewardItemUI RewardItemUIRewardItemUI5
		{
			[Token(Token = "0x6002754")]
			[Address(RVA = "0x3F9F4B0", Offset = "0x3F9B4B0", VA = "0x3F9F4B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700034B")]
		public RewardItemUI RewardItemUIRewardItemUI6
		{
			[Token(Token = "0x6002755")]
			[Address(RVA = "0x3F9F578", Offset = "0x3F9B578", VA = "0x3F9F578")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700034C")]
		public RewardItemUI RewardItemUIRewardItemUI7
		{
			[Token(Token = "0x6002756")]
			[Address(RVA = "0x3F9F640", Offset = "0x3F9B640", VA = "0x3F9F640")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700034D")]
		public RewardItemUI RewardItemUIRewardItemUI8
		{
			[Token(Token = "0x6002757")]
			[Address(RVA = "0x3F9F708", Offset = "0x3F9B708", VA = "0x3F9F708")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700034E")]
		public RewardItemUI RewardItemUIRewardItemUI9
		{
			[Token(Token = "0x6002758")]
			[Address(RVA = "0x3F9F7D0", Offset = "0x3F9B7D0", VA = "0x3F9F7D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700034F")]
		public RewardItemUI RewardItemUIRewardItemUI10
		{
			[Token(Token = "0x6002759")]
			[Address(RVA = "0x3F9F898", Offset = "0x3F9B898", VA = "0x3F9F898")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000350")]
		public RewardItemUI RewardItemUIRewardItemUI11
		{
			[Token(Token = "0x600275A")]
			[Address(RVA = "0x3F9F960", Offset = "0x3F9B960", VA = "0x3F9F960")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000351")]
		public RewardItemUI RewardItemUIRewardItemUI12
		{
			[Token(Token = "0x600275B")]
			[Address(RVA = "0x3F9FA28", Offset = "0x3F9BA28", VA = "0x3F9FA28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000352")]
		public RewardItemUI RewardItemUIRewardItemUI13
		{
			[Token(Token = "0x600275C")]
			[Address(RVA = "0x3F9FAF0", Offset = "0x3F9BAF0", VA = "0x3F9FAF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000353")]
		public RewardItemUI RewardItemUIRewardItemUI14
		{
			[Token(Token = "0x600275D")]
			[Address(RVA = "0x3F9FBB8", Offset = "0x3F9BBB8", VA = "0x3F9FBB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000354")]
		public RewardItemUI RewardItemUIRewardItemUI15
		{
			[Token(Token = "0x600275E")]
			[Address(RVA = "0x3F9FC80", Offset = "0x3F9BC80", VA = "0x3F9FC80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000355")]
		public RewardItemUI RewardItemUIRewardItemUI16
		{
			[Token(Token = "0x600275F")]
			[Address(RVA = "0x3F9FD48", Offset = "0x3F9BD48", VA = "0x3F9FD48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000356")]
		public BenefitValueItem BenefitValueItemBenefitValueItem
		{
			[Token(Token = "0x6002760")]
			[Address(RVA = "0x3FA1320", Offset = "0x3F9D320", VA = "0x3FA1320")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000357")]
		public TextMeshProUGUI TextMeshProUGUITxtBuyPackCount
		{
			[Token(Token = "0x6002761")]
			[Address(RVA = "0x3FA06A8", Offset = "0x3F9C6A8", VA = "0x3FA06A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000358")]
		public TextMeshProUGUI TextMeshProUGUITxtAvailable
		{
			[Token(Token = "0x6002762")]
			[Address(RVA = "0x3FA13E8", Offset = "0x3F9D3E8", VA = "0x3FA13E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000359")]
		public Image ImageImgBuyLimitDuiHao
		{
			[Token(Token = "0x6002763")]
			[Address(RVA = "0x3FA0770", Offset = "0x3F9C770", VA = "0x3FA0770")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700035A")]
		public TextMeshProUGUI TextMeshProUGUITxtToMonDayCutDown
		{
			[Token(Token = "0x6002764")]
			[Address(RVA = "0x3FA01A0", Offset = "0x3F9C1A0", VA = "0x3FA01A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002765")]
		[Address(RVA = "0x3FA1814", Offset = "0x3F9D814", VA = "0x3FA1814")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6002766")]
		[Address(RVA = "0x3FA0B40", Offset = "0x3F9CB40", VA = "0x3FA0B40", Slot = "12")]
		protected virtual void OnButtonExtendBtnAllFetterGiftPackItemClicked()
		{
		}

		[Token(Token = "0x6002767")]
		[Address(RVA = "0x3FA189C", Offset = "0x3F9D89C", VA = "0x3FA189C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002768")]
		[Address(RVA = "0x3FA0BC0", Offset = "0x3F9CBC0", VA = "0x3FA0BC0", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__351))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002769")]
		[Address(RVA = "0x3FA18B8", Offset = "0x3F9D8B8", VA = "0x3FA18B8", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x600276A")]
		[Address(RVA = "0x3FA0BB4", Offset = "0x3F9CBB4", VA = "0x3FA0BB4")]
		public BtnAllFetterGiftPackItemComponents()
		{
		}
	}
}
