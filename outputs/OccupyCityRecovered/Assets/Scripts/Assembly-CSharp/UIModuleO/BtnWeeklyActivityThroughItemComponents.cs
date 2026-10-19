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
	[Token(Token = "0x2000786")]
	public class BtnWeeklyActivityThroughItemComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000787")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__183 : IAsyncStateMachine
		{
			[Token(Token = "0x4003A91")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003A92")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003A93")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BtnWeeklyActivityThroughItemComponents _003C_003E4__this;

			[Token(Token = "0x4003A94")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6002960")]
			[Address(RVA = "0x3FC303C", Offset = "0x3FBF03C", VA = "0x3FC303C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002961")]
			[Address(RVA = "0x3FC32B4", Offset = "0x3FBF2B4", VA = "0x3FC32B4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003A87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ButtonExtend _buttonExtendBtnWeeklyActivityThroughItem;

		[Token(Token = "0x4003A88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TextMeshProUGUI _textMeshProUGUITxtMondayCutDown;

		[Token(Token = "0x4003A89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Image _imageImgCardEffBg;

		[Token(Token = "0x4003A8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Image _imageImgCardIcon;

		[Token(Token = "0x4003A8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TextMeshProUGUI _textMeshProUGUITxtCardDes;

		[Token(Token = "0x4003A8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private TextMeshProUGUI _textMeshProUGUITxtSummonDes;

		[Token(Token = "0x4003A8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private TextMeshProUGUI _textMeshProUGUITxtAttackDes;

		[Token(Token = "0x4003A8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private TextMeshProUGUI _textMeshProUGUITxtHPDes;

		[Token(Token = "0x4003A8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private RectTransform _rectTransformRewardRoot;

		[Token(Token = "0x4003A90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private TextMeshProUGUI _textMeshProUGUITxtGiftPackName;

		[Token(Token = "0x170003E5")]
		public ButtonExtend ButtonExtendBtnWeeklyActivityThroughItem
		{
			[Token(Token = "0x600294F")]
			[Address(RVA = "0x3FC2E54", Offset = "0x3FBEE54", VA = "0x3FC2E54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003E6")]
		public TextMeshProUGUI TextMeshProUGUITxtMondayCutDown
		{
			[Token(Token = "0x6002950")]
			[Address(RVA = "0x3FC0FCC", Offset = "0x3FBCFCC", VA = "0x3FC0FCC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003E7")]
		public Image ImageImgCardEffBg
		{
			[Token(Token = "0x6002951")]
			[Address(RVA = "0x3FC1334", Offset = "0x3FBD334", VA = "0x3FC1334")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003E8")]
		public Image ImageImgCardIcon
		{
			[Token(Token = "0x6002952")]
			[Address(RVA = "0x3FC2D80", Offset = "0x3FBED80", VA = "0x3FC2D80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003E9")]
		public TextMeshProUGUI TextMeshProUGUITxtCardDes
		{
			[Token(Token = "0x6002953")]
			[Address(RVA = "0x3FC2998", Offset = "0x3FBE998", VA = "0x3FC2998")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003EA")]
		public TextMeshProUGUI TextMeshProUGUITxtSummonDes
		{
			[Token(Token = "0x6002954")]
			[Address(RVA = "0x3FC2B28", Offset = "0x3FBEB28", VA = "0x3FC2B28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003EB")]
		public TextMeshProUGUI TextMeshProUGUITxtAttackDes
		{
			[Token(Token = "0x6002955")]
			[Address(RVA = "0x3FC2BF0", Offset = "0x3FBEBF0", VA = "0x3FC2BF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003EC")]
		public TextMeshProUGUI TextMeshProUGUITxtHPDes
		{
			[Token(Token = "0x6002956")]
			[Address(RVA = "0x3FC2CB8", Offset = "0x3FBECB8", VA = "0x3FC2CB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003ED")]
		public RectTransform RectTransformRewardRoot
		{
			[Token(Token = "0x6002957")]
			[Address(RVA = "0x3FC0C28", Offset = "0x3FBCC28", VA = "0x3FC0C28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003EE")]
		public TextMeshProUGUI TextMeshProUGUITxtGiftPackName
		{
			[Token(Token = "0x6002958")]
			[Address(RVA = "0x3FC2A60", Offset = "0x3FBEA60", VA = "0x3FC2A60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002959")]
		[Address(RVA = "0x3FC2EF8", Offset = "0x3FBEEF8", VA = "0x3FC2EF8")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x600295A")]
		[Address(RVA = "0x3FC1208", Offset = "0x3FBD208", VA = "0x3FC1208", Slot = "12")]
		protected virtual void OnButtonExtendBtnWeeklyActivityThroughItemClicked()
		{
		}

		[Token(Token = "0x600295B")]
		[Address(RVA = "0x3FC0C0C", Offset = "0x3FBCC0C", VA = "0x3FC0C0C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600295C")]
		[Address(RVA = "0x3FC0DA8", Offset = "0x3FBCDA8", VA = "0x3FC0DA8", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__183))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x600295D")]
		[Address(RVA = "0x3FC2F80", Offset = "0x3FBEF80", VA = "0x3FC2F80", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x600295E")]
		[Address(RVA = "0x3FC1454", Offset = "0x3FBD454", VA = "0x3FC1454")]
		public BtnWeeklyActivityThroughItemComponents()
		{
		}
	}
}
