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
	[Token(Token = "0x20006B3")]
	public class ArenaPackItemComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20006B4")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__651 : IAsyncStateMachine
		{
			[Token(Token = "0x400359B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400359C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400359D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ArenaPackItemComponents _003C_003E4__this;

			[Token(Token = "0x400359E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x600238E")]
			[Address(RVA = "0x3F47F58", Offset = "0x3F43F58", VA = "0x3F47F58", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600238F")]
			[Address(RVA = "0x3F481D0", Offset = "0x3F441D0", VA = "0x3F481D0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400358F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Image _imageBackground;

		[Token(Token = "0x4003590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ButtonExtend _buttonExtendBackground;

		[Token(Token = "0x4003591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Image _imageCardIcon;

		[Token(Token = "0x4003592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private TextMeshProUGUI _textMeshProUGUICardName;

		[Token(Token = "0x4003593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private BenefitValueItem _benefitValueItemBenefitValueItem;

		[Token(Token = "0x4003594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private RewardItemUI _rewardItemUIRewardItemUI1;

		[Token(Token = "0x4003595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RewardItemUI _rewardItemUIRewardItemUI2;

		[Token(Token = "0x4003596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private RewardItemUI _rewardItemUIRewardItemUI3;

		[Token(Token = "0x4003597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Image _imageArenaIcon;

		[Token(Token = "0x4003598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private TextMeshProUGUI _textMeshProUGUIArenaText;

		[Token(Token = "0x4003599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private TextMeshProUGUI _textMeshProUGUIPriceValue;

		[Token(Token = "0x400359A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private TextMeshProUGUI _textMeshProUGUITimerText;

		[Token(Token = "0x1700020C")]
		public Image ImageBackground
		{
			[Token(Token = "0x600237B")]
			[Address(RVA = "0x3F474C0", Offset = "0x3F434C0", VA = "0x3F474C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700020D")]
		public ButtonExtend ButtonExtendBackground
		{
			[Token(Token = "0x600237C")]
			[Address(RVA = "0x3F47C9C", Offset = "0x3F43C9C", VA = "0x3F47C9C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700020E")]
		public Image ImageCardIcon
		{
			[Token(Token = "0x600237D")]
			[Address(RVA = "0x3F47588", Offset = "0x3F43588", VA = "0x3F47588")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700020F")]
		public TextMeshProUGUI TextMeshProUGUICardName
		{
			[Token(Token = "0x600237E")]
			[Address(RVA = "0x3F47BC8", Offset = "0x3F43BC8", VA = "0x3F47BC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000210")]
		public BenefitValueItem BenefitValueItemBenefitValueItem
		{
			[Token(Token = "0x600237F")]
			[Address(RVA = "0x3F478A8", Offset = "0x3F438A8", VA = "0x3F478A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000211")]
		public RewardItemUI RewardItemUIRewardItemUI1
		{
			[Token(Token = "0x6002380")]
			[Address(RVA = "0x3F47970", Offset = "0x3F43970", VA = "0x3F47970")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000212")]
		public RewardItemUI RewardItemUIRewardItemUI2
		{
			[Token(Token = "0x6002381")]
			[Address(RVA = "0x3F47A38", Offset = "0x3F43A38", VA = "0x3F47A38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000213")]
		public RewardItemUI RewardItemUIRewardItemUI3
		{
			[Token(Token = "0x6002382")]
			[Address(RVA = "0x3F47B00", Offset = "0x3F43B00", VA = "0x3F47B00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000214")]
		public Image ImageArenaIcon
		{
			[Token(Token = "0x6002383")]
			[Address(RVA = "0x3F47650", Offset = "0x3F43650", VA = "0x3F47650")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000215")]
		public TextMeshProUGUI TextMeshProUGUIArenaText
		{
			[Token(Token = "0x6002384")]
			[Address(RVA = "0x3F477E0", Offset = "0x3F437E0", VA = "0x3F477E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000216")]
		public TextMeshProUGUI TextMeshProUGUIPriceValue
		{
			[Token(Token = "0x6002385")]
			[Address(RVA = "0x3F47718", Offset = "0x3F43718", VA = "0x3F47718")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000217")]
		public TextMeshProUGUI TextMeshProUGUITimerText
		{
			[Token(Token = "0x6002386")]
			[Address(RVA = "0x3F46188", Offset = "0x3F42188", VA = "0x3F46188")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002387")]
		[Address(RVA = "0x3F47D64", Offset = "0x3F43D64", VA = "0x3F47D64")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6002388")]
		[Address(RVA = "0x3F463D0", Offset = "0x3F423D0", VA = "0x3F463D0", Slot = "12")]
		protected virtual void OnButtonExtendBackgroundClicked()
		{
		}

		[Token(Token = "0x6002389")]
		[Address(RVA = "0x3F47DEC", Offset = "0x3F43DEC", VA = "0x3F47DEC", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600238A")]
		[Address(RVA = "0x3F47E08", Offset = "0x3F43E08", VA = "0x3F47E08", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__651))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x600238B")]
		[Address(RVA = "0x3F47E9C", Offset = "0x3F43E9C", VA = "0x3F47E9C", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x600238C")]
		[Address(RVA = "0x3F4644C", Offset = "0x3F4244C", VA = "0x3F4644C")]
		public ArenaPackItemComponents()
		{
		}
	}
}
