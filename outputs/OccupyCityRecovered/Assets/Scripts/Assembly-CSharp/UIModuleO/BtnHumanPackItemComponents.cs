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
	[Token(Token = "0x2000775")]
	public class BtnHumanPackItemComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000776")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__222 : IAsyncStateMachine
		{
			[Token(Token = "0x4003A49")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003A4A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003A4B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BtnHumanPackItemComponents _003C_003E4__this;

			[Token(Token = "0x4003A4C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60028FB")]
			[Address(RVA = "0x3FBCEE4", Offset = "0x3FB8EE4", VA = "0x3FBCEE4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60028FC")]
			[Address(RVA = "0x3FBD15C", Offset = "0x3FB915C", VA = "0x3FBD15C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003A3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ButtonExtend _buttonExtendBtnHumanPackItem;

		[Token(Token = "0x4003A3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Image _imageBackground;

		[Token(Token = "0x4003A3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Image _imageLight;

		[Token(Token = "0x4003A3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Image _imageImgFetterIcon;

		[Token(Token = "0x4003A3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Image _imageImgBoxIcon;

		[Token(Token = "0x4003A3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private RectTransform _rectTransformRewardRoot;

		[Token(Token = "0x4003A40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private TextMeshProUGUI _textMeshProUGUITxtPrice;

		[Token(Token = "0x4003A41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private TextMeshProUGUI _textMeshProUGUITxtGiftPackName;

		[Token(Token = "0x4003A42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private BenefitValueItem _benefitValueItemBenefitValueItem;

		[Token(Token = "0x4003A43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private RectTransform _rectTransformBuyGiftLimitRoot;

		[Token(Token = "0x4003A44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private TextMeshProUGUI _textMeshProUGUITxtBuyPackCount;

		[Token(Token = "0x4003A45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private TextMeshProUGUI _textMeshProUGUITxtAvailable;

		[Token(Token = "0x4003A46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Image _imageImgBuyLimitDuiHao;

		[Token(Token = "0x4003A47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Image _imageImgToMonDayCutDownBg;

		[Token(Token = "0x4003A48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private TextMeshProUGUI _textMeshProUGUITxtToMonDayCutDown;

		[Token(Token = "0x170003C6")]
		public ButtonExtend ButtonExtendBtnHumanPackItem
		{
			[Token(Token = "0x60028E5")]
			[Address(RVA = "0x3FBCC4C", Offset = "0x3FB8C4C", VA = "0x3FBCC4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003C7")]
		public Image ImageBackground
		{
			[Token(Token = "0x60028E6")]
			[Address(RVA = "0x3FBC858", Offset = "0x3FB8858", VA = "0x3FBC858")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003C8")]
		public Image ImageLight
		{
			[Token(Token = "0x60028E7")]
			[Address(RVA = "0x3FB9948", Offset = "0x3FB5948", VA = "0x3FB9948")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003C9")]
		public Image ImageImgFetterIcon
		{
			[Token(Token = "0x60028E8")]
			[Address(RVA = "0x3FBC920", Offset = "0x3FB8920", VA = "0x3FBC920")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003CA")]
		public Image ImageImgBoxIcon
		{
			[Token(Token = "0x60028E9")]
			[Address(RVA = "0x3FBA6B0", Offset = "0x3FB66B0", VA = "0x3FBA6B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003CB")]
		public RectTransform RectTransformRewardRoot
		{
			[Token(Token = "0x60028EA")]
			[Address(RVA = "0x3FBA5E8", Offset = "0x3FB65E8", VA = "0x3FBA5E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003CC")]
		public TextMeshProUGUI TextMeshProUGUITxtPrice
		{
			[Token(Token = "0x60028EB")]
			[Address(RVA = "0x3FB9404", Offset = "0x3FB5404", VA = "0x3FB9404")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003CD")]
		public TextMeshProUGUI TextMeshProUGUITxtGiftPackName
		{
			[Token(Token = "0x60028EC")]
			[Address(RVA = "0x3FBC9E8", Offset = "0x3FB89E8", VA = "0x3FBC9E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003CE")]
		public BenefitValueItem BenefitValueItemBenefitValueItem
		{
			[Token(Token = "0x60028ED")]
			[Address(RVA = "0x3FBC6C8", Offset = "0x3FB86C8", VA = "0x3FBC6C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003CF")]
		public RectTransform RectTransformBuyGiftLimitRoot
		{
			[Token(Token = "0x60028EE")]
			[Address(RVA = "0x3FBCB78", Offset = "0x3FB8B78", VA = "0x3FBCB78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003D0")]
		public TextMeshProUGUI TextMeshProUGUITxtBuyPackCount
		{
			[Token(Token = "0x60028EF")]
			[Address(RVA = "0x3FB9274", Offset = "0x3FB5274", VA = "0x3FB9274")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003D1")]
		public TextMeshProUGUI TextMeshProUGUITxtAvailable
		{
			[Token(Token = "0x60028F0")]
			[Address(RVA = "0x3FBC790", Offset = "0x3FB8790", VA = "0x3FBC790")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003D2")]
		public Image ImageImgBuyLimitDuiHao
		{
			[Token(Token = "0x60028F1")]
			[Address(RVA = "0x3FB933C", Offset = "0x3FB533C", VA = "0x3FB933C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003D3")]
		public Image ImageImgToMonDayCutDownBg
		{
			[Token(Token = "0x60028F2")]
			[Address(RVA = "0x3FBCAB0", Offset = "0x3FB8AB0", VA = "0x3FBCAB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003D4")]
		public TextMeshProUGUI TextMeshProUGUITxtToMonDayCutDown
		{
			[Token(Token = "0x60028F3")]
			[Address(RVA = "0x3FB8D3C", Offset = "0x3FB4D3C", VA = "0x3FB8D3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60028F4")]
		[Address(RVA = "0x3FBCCF0", Offset = "0x3FB8CF0", VA = "0x3FBCCF0")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x60028F5")]
		[Address(RVA = "0x3FB9818", Offset = "0x3FB5818", VA = "0x3FB9818", Slot = "12")]
		protected virtual void OnButtonExtendBtnHumanPackItemClicked()
		{
		}

		[Token(Token = "0x60028F6")]
		[Address(RVA = "0x3FBCD78", Offset = "0x3FB8D78", VA = "0x3FBCD78", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60028F7")]
		[Address(RVA = "0x3FBCD94", Offset = "0x3FB8D94", VA = "0x3FBCD94", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__222))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60028F8")]
		[Address(RVA = "0x3FBCE28", Offset = "0x3FB8E28", VA = "0x3FBCE28", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60028F9")]
		[Address(RVA = "0x3FB9AE4", Offset = "0x3FB5AE4", VA = "0x3FB9AE4")]
		public BtnHumanPackItemComponents()
		{
		}
	}
}
