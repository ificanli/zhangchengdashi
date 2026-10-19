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
	[Token(Token = "0x2000745")]
	public class BtnArtifactPackItemComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000746")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__375 : IAsyncStateMachine
		{
			[Token(Token = "0x4003940")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003941")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003942")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BtnArtifactPackItemComponents _003C_003E4__this;

			[Token(Token = "0x4003943")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60027CA")]
			[Address(RVA = "0x3FA8C74", Offset = "0x3FA4C74", VA = "0x3FA8C74", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60027CB")]
			[Address(RVA = "0x3FA8EEC", Offset = "0x3FA4EEC", VA = "0x3FA8EEC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003930")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ButtonExtend _buttonExtendBtnArtifactPackItem;

		[Token(Token = "0x4003931")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Image _imageImgCutDownBg;

		[Token(Token = "0x4003932")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Image _imageImgArtifact;

		[Token(Token = "0x4003933")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private TextMeshProUGUI _textMeshProUGUITxtArtifactNum;

		[Token(Token = "0x4003934")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TextMeshProUGUI _textMeshProUGUITxtGiftPackName;

		[Token(Token = "0x4003935")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private TextMeshProUGUI _textMeshProUGUITxtPrice;

		[Token(Token = "0x4003936")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RectTransform _rectTransformRewardRoot;

		[Token(Token = "0x4003937")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private RectTransform _rectTransformImgResRoot;

		[Token(Token = "0x4003938")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Image _imageImgResRoot;

		[Token(Token = "0x4003939")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private BenefitValueItem _benefitValueItemBenefitValueItem;

		[Token(Token = "0x400393A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private RectTransform _rectTransformBuyGiftLimitRoot;

		[Token(Token = "0x400393B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private TextMeshProUGUI _textMeshProUGUITxtBuyPackCount;

		[Token(Token = "0x400393C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private TextMeshProUGUI _textMeshProUGUITxtAvailable;

		[Token(Token = "0x400393D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Image _imageImgBuyLimitDuiHao;

		[Token(Token = "0x400393E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Image _imageImgToMonDayCutDownBg;

		[Token(Token = "0x400393F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private TextMeshProUGUI _textMeshProUGUITxtToMonDayCutDown;

		[Token(Token = "0x17000369")]
		public ButtonExtend ButtonExtendBtnArtifactPackItem
		{
			[Token(Token = "0x60027B3")]
			[Address(RVA = "0x3FA89DC", Offset = "0x3FA49DC", VA = "0x3FA89DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700036A")]
		public Image ImageImgCutDownBg
		{
			[Token(Token = "0x60027B4")]
			[Address(RVA = "0x3FA52A0", Offset = "0x3FA12A0", VA = "0x3FA52A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700036B")]
		public Image ImageImgArtifact
		{
			[Token(Token = "0x60027B5")]
			[Address(RVA = "0x3FA54F8", Offset = "0x3FA14F8", VA = "0x3FA54F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700036C")]
		public TextMeshProUGUI TextMeshProUGUITxtArtifactNum
		{
			[Token(Token = "0x60027B6")]
			[Address(RVA = "0x3FA55C0", Offset = "0x3FA15C0", VA = "0x3FA55C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700036D")]
		public TextMeshProUGUI TextMeshProUGUITxtGiftPackName
		{
			[Token(Token = "0x60027B7")]
			[Address(RVA = "0x3FA5368", Offset = "0x3FA1368", VA = "0x3FA5368")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700036E")]
		public TextMeshProUGUI TextMeshProUGUITxtPrice
		{
			[Token(Token = "0x60027B8")]
			[Address(RVA = "0x3FA2844", Offset = "0x3F9E844", VA = "0x3FA2844")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700036F")]
		public RectTransform RectTransformRewardRoot
		{
			[Token(Token = "0x60027B9")]
			[Address(RVA = "0x3FA5688", Offset = "0x3FA1688", VA = "0x3FA5688")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000370")]
		public RectTransform RectTransformImgResRoot
		{
			[Token(Token = "0x60027BA")]
			[Address(RVA = "0x3FA5750", Offset = "0x3FA1750", VA = "0x3FA5750")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000371")]
		public Image ImageImgResRoot
		{
			[Token(Token = "0x60027BB")]
			[Address(RVA = "0x3FA5430", Offset = "0x3FA1430", VA = "0x3FA5430")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000372")]
		public BenefitValueItem BenefitValueItemBenefitValueItem
		{
			[Token(Token = "0x60027BC")]
			[Address(RVA = "0x3FA1E68", Offset = "0x3F9DE68", VA = "0x3FA1E68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000373")]
		public RectTransform RectTransformBuyGiftLimitRoot
		{
			[Token(Token = "0x60027BD")]
			[Address(RVA = "0x3FA32C4", Offset = "0x3F9F2C4", VA = "0x3FA32C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000374")]
		public TextMeshProUGUI TextMeshProUGUITxtBuyPackCount
		{
			[Token(Token = "0x60027BE")]
			[Address(RVA = "0x3FA26B4", Offset = "0x3F9E6B4", VA = "0x3FA26B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000375")]
		public TextMeshProUGUI TextMeshProUGUITxtAvailable
		{
			[Token(Token = "0x60027BF")]
			[Address(RVA = "0x3FA338C", Offset = "0x3F9F38C", VA = "0x3FA338C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000376")]
		public Image ImageImgBuyLimitDuiHao
		{
			[Token(Token = "0x60027C0")]
			[Address(RVA = "0x3FA277C", Offset = "0x3F9E77C", VA = "0x3FA277C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000377")]
		public Image ImageImgToMonDayCutDownBg
		{
			[Token(Token = "0x60027C1")]
			[Address(RVA = "0x3FA31FC", Offset = "0x3F9F1FC", VA = "0x3FA31FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000378")]
		public TextMeshProUGUI TextMeshProUGUITxtToMonDayCutDown
		{
			[Token(Token = "0x60027C2")]
			[Address(RVA = "0x3FA23FC", Offset = "0x3F9E3FC", VA = "0x3FA23FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60027C3")]
		[Address(RVA = "0x3FA8A80", Offset = "0x3FA4A80", VA = "0x3FA8A80")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x60027C4")]
		[Address(RVA = "0x3FA2BA8", Offset = "0x3F9EBA8", VA = "0x3FA2BA8", Slot = "12")]
		protected virtual void OnButtonExtendBtnArtifactPackItemClicked()
		{
		}

		[Token(Token = "0x60027C5")]
		[Address(RVA = "0x3FA8B08", Offset = "0x3FA4B08", VA = "0x3FA8B08", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60027C6")]
		[Address(RVA = "0x3FA8B24", Offset = "0x3FA4B24", VA = "0x3FA8B24", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__375))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60027C7")]
		[Address(RVA = "0x3FA8BB8", Offset = "0x3FA4BB8", VA = "0x3FA8BB8", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60027C8")]
		[Address(RVA = "0x3FA2CB0", Offset = "0x3F9ECB0", VA = "0x3FA2CB0")]
		public BtnArtifactPackItemComponents()
		{
		}
	}
}
