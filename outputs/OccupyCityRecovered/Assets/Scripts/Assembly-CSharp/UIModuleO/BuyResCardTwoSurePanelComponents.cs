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
	[Token(Token = "0x2000B3B")]
	public class BuyResCardTwoSurePanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B3C")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__176 : IAsyncStateMachine
		{
			[Token(Token = "0x40051ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40051EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40051EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BuyResCardTwoSurePanelComponents _003C_003E4__this;

			[Token(Token = "0x40051F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x600448C")]
			[Address(RVA = "0x41EEFE4", Offset = "0x41EAFE4", VA = "0x41EEFE4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600448D")]
			[Address(RVA = "0x41EF25C", Offset = "0x41EB25C", VA = "0x41EF25C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40051E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Button _buttonBG;

		[Token(Token = "0x40051E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RectTransform _rectTransformRoot;

		[Token(Token = "0x40051E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TextMeshProUGUI _textMeshProUGUITxtSureBuy;

		[Token(Token = "0x40051E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private RectTransform _rectTransformRewardRoot;

		[Token(Token = "0x40051E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TextMeshProUGUI _textMeshProUGUITxtCardTip;

		[Token(Token = "0x40051E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private ButtonExtend _buttonExtendBtnClose;

		[Token(Token = "0x40051E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private ButtonExtend _buttonExtendBtnBuy;

		[Token(Token = "0x40051E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private TextMeshProUGUI _textMeshProUGUITxtPriceNum;

		[Token(Token = "0x40051EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Image _imageImgCoin;

		[Token(Token = "0x40051EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Image _imageImgResIcon;

		[Token(Token = "0x40051EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private TextMeshProUGUI _textMeshProUGUITxtResNum;

		[Token(Token = "0x17000B4C")]
		public Button ButtonBG
		{
			[Token(Token = "0x6004478")]
			[Address(RVA = "0x41EEC6C", Offset = "0x41EAC6C", VA = "0x41EEC6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B4D")]
		public RectTransform RectTransformRoot
		{
			[Token(Token = "0x6004479")]
			[Address(RVA = "0x41EBF04", Offset = "0x41E7F04", VA = "0x41EBF04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B4E")]
		public TextMeshProUGUI TextMeshProUGUITxtSureBuy
		{
			[Token(Token = "0x600447A")]
			[Address(RVA = "0x41EEAD0", Offset = "0x41EAAD0", VA = "0x41EEAD0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B4F")]
		public RectTransform RectTransformRewardRoot
		{
			[Token(Token = "0x600447B")]
			[Address(RVA = "0x41EE174", Offset = "0x41EA174", VA = "0x41EE174")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B50")]
		public TextMeshProUGUI TextMeshProUGUITxtCardTip
		{
			[Token(Token = "0x600447C")]
			[Address(RVA = "0x41EEA08", Offset = "0x41EAA08", VA = "0x41EEA08")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B51")]
		public ButtonExtend ButtonExtendBtnClose
		{
			[Token(Token = "0x600447D")]
			[Address(RVA = "0x41EED34", Offset = "0x41EAD34", VA = "0x41EED34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B52")]
		public ButtonExtend ButtonExtendBtnBuy
		{
			[Token(Token = "0x600447E")]
			[Address(RVA = "0x41EEDFC", Offset = "0x41EADFC", VA = "0x41EEDFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B53")]
		public TextMeshProUGUI TextMeshProUGUITxtPriceNum
		{
			[Token(Token = "0x600447F")]
			[Address(RVA = "0x41EE7B0", Offset = "0x41EA7B0", VA = "0x41EE7B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B54")]
		public Image ImageImgCoin
		{
			[Token(Token = "0x6004480")]
			[Address(RVA = "0x41EEB98", Offset = "0x41EAB98", VA = "0x41EEB98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B55")]
		public Image ImageImgResIcon
		{
			[Token(Token = "0x6004481")]
			[Address(RVA = "0x41EE878", Offset = "0x41EA878", VA = "0x41EE878")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B56")]
		public TextMeshProUGUI TextMeshProUGUITxtResNum
		{
			[Token(Token = "0x6004482")]
			[Address(RVA = "0x41EE940", Offset = "0x41EA940", VA = "0x41EE940")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004483")]
		[Address(RVA = "0x41EEEC4", Offset = "0x41EAEC4", VA = "0x41EEEC4")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6004484")]
		[Address(RVA = "0x41ECBF4", Offset = "0x41E8BF4", VA = "0x41ECBF4", Slot = "12")]
		protected virtual void OnButtonBGClicked()
		{
		}

		[Token(Token = "0x6004485")]
		[Address(RVA = "0x41EC088", Offset = "0x41E8088", VA = "0x41EC088", Slot = "13")]
		protected virtual void OnButtonExtendBtnCloseClicked()
		{
		}

		[Token(Token = "0x6004486")]
		[Address(RVA = "0x41ECAA4", Offset = "0x41E8AA4", VA = "0x41ECAA4", Slot = "14")]
		protected virtual void OnButtonExtendBtnBuyClicked()
		{
		}

		[Token(Token = "0x6004487")]
		[Address(RVA = "0x41EBEE8", Offset = "0x41E7EE8", VA = "0x41EBEE8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6004488")]
		[Address(RVA = "0x41ECE88", Offset = "0x41E8E88", VA = "0x41ECE88", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__176))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6004489")]
		[Address(RVA = "0x41ECB20", Offset = "0x41E8B20", VA = "0x41ECB20", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x600448A")]
		[Address(RVA = "0x41ECE7C", Offset = "0x41E8E7C", VA = "0x41ECE7C")]
		public BuyResCardTwoSurePanelComponents()
		{
		}
	}
}
