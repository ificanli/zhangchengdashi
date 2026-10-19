using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using SDKModule;
using TMPro;
using UIFramework;
using UIModuleO.UIAnim;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000B28")]
	public class BtnBuyWoodItemComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B29")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__235 : IAsyncStateMachine
		{
			[Token(Token = "0x4005171")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005172")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005173")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BtnBuyWoodItemComponents _003C_003E4__this;

			[Token(Token = "0x4005174")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60043DC")]
			[Address(RVA = "0x41E36C4", Offset = "0x41DF6C4", VA = "0x41E36C4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60043DD")]
			[Address(RVA = "0x41E393C", Offset = "0x41DF93C", VA = "0x41E393C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4005163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ButtonExtend _buttonExtendBtnBuyWoodItem;

		[Token(Token = "0x4005164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RectTransform _rectTransformShop_bg_dablue;

		[Token(Token = "0x4005165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RectTransform _rectTransformShop_bg_blue;

		[Token(Token = "0x4005166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private RectTransform _rectTransformShop_bg_green;

		[Token(Token = "0x4005167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private RectTransform _rectTransformImgWoodIcon;

		[Token(Token = "0x4005168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Image _imageImgWoodIcon;

		[Token(Token = "0x4005169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private DOTweenAnimation _dOTweenAnimationImgWoodIcon;

		[Token(Token = "0x400516A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private TextMeshProUGUI _textMeshProUGUITxtName;

		[Token(Token = "0x400516B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private TextMeshProUGUI _textMeshProUGUITxtPriceNum;

		[Token(Token = "0x400516C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private TextMeshProUGUI _textMeshProUGUITxtWoodNum;

		[Token(Token = "0x400516D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private TextMeshProUGUI _textMeshProUGUITxtPurchased;

		[Token(Token = "0x400516E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Image _imageImgBuyEd;

		[Token(Token = "0x400516F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private TextMeshProUGUI _textMeshProUGUITxtFree;

		[Token(Token = "0x4005170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private AdButtonExtend _adButtonExtendBtnAd;

		[Token(Token = "0x17000B0F")]
		public ButtonExtend ButtonExtendBtnBuyWoodItem
		{
			[Token(Token = "0x60043C6")]
			[Address(RVA = "0x41E2D88", Offset = "0x41DED88", VA = "0x41E2D88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B10")]
		public RectTransform RectTransformShop_bg_dablue
		{
			[Token(Token = "0x60043C7")]
			[Address(RVA = "0x41E2E2C", Offset = "0x41DEE2C", VA = "0x41E2E2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B11")]
		public RectTransform RectTransformShop_bg_blue
		{
			[Token(Token = "0x60043C8")]
			[Address(RVA = "0x41E2EF4", Offset = "0x41DEEF4", VA = "0x41E2EF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B12")]
		public RectTransform RectTransformShop_bg_green
		{
			[Token(Token = "0x60043C9")]
			[Address(RVA = "0x41E2FBC", Offset = "0x41DEFBC", VA = "0x41E2FBC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B13")]
		public RectTransform RectTransformImgWoodIcon
		{
			[Token(Token = "0x60043CA")]
			[Address(RVA = "0x41E3084", Offset = "0x41DF084", VA = "0x41E3084")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B14")]
		public Image ImageImgWoodIcon
		{
			[Token(Token = "0x60043CB")]
			[Address(RVA = "0x41E314C", Offset = "0x41DF14C", VA = "0x41E314C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B15")]
		public DOTweenAnimation DOTweenAnimationImgWoodIcon
		{
			[Token(Token = "0x60043CC")]
			[Address(RVA = "0x41E3214", Offset = "0x41DF214", VA = "0x41E3214")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B16")]
		public TextMeshProUGUI TextMeshProUGUITxtName
		{
			[Token(Token = "0x60043CD")]
			[Address(RVA = "0x41E2BEC", Offset = "0x41DEBEC", VA = "0x41E2BEC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B17")]
		public TextMeshProUGUI TextMeshProUGUITxtPriceNum
		{
			[Token(Token = "0x60043CE")]
			[Address(RVA = "0x41E2CB4", Offset = "0x41DECB4", VA = "0x41E2CB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B18")]
		public TextMeshProUGUI TextMeshProUGUITxtWoodNum
		{
			[Token(Token = "0x60043CF")]
			[Address(RVA = "0x41E28CC", Offset = "0x41DE8CC", VA = "0x41E28CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B19")]
		public TextMeshProUGUI TextMeshProUGUITxtPurchased
		{
			[Token(Token = "0x60043D0")]
			[Address(RVA = "0x41E2994", Offset = "0x41DE994", VA = "0x41E2994")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B1A")]
		public Image ImageImgBuyEd
		{
			[Token(Token = "0x60043D1")]
			[Address(RVA = "0x41E2A5C", Offset = "0x41DEA5C", VA = "0x41E2A5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B1B")]
		public TextMeshProUGUI TextMeshProUGUITxtFree
		{
			[Token(Token = "0x60043D2")]
			[Address(RVA = "0x41E2B24", Offset = "0x41DEB24", VA = "0x41E2B24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B1C")]
		public AdButtonExtend AdButtonExtendBtnAd
		{
			[Token(Token = "0x60043D3")]
			[Address(RVA = "0x41E32DC", Offset = "0x41DF2DC", VA = "0x41E32DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60043D4")]
		[Address(RVA = "0x41E33A4", Offset = "0x41DF3A4", VA = "0x41E33A4")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x60043D5")]
		[Address(RVA = "0x41E3478", Offset = "0x41DF478", VA = "0x41E3478", Slot = "12")]
		protected virtual void OnButtonExtendBtnBuyWoodItemClicked()
		{
		}

		[Token(Token = "0x60043D6")]
		[Address(RVA = "0x41E34E4", Offset = "0x41DF4E4", VA = "0x41E34E4", Slot = "13")]
		protected virtual void OnAdButtonExtendBtnAdClicked()
		{
		}

		[Token(Token = "0x60043D7")]
		[Address(RVA = "0x41E3550", Offset = "0x41DF550", VA = "0x41E3550", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60043D8")]
		[Address(RVA = "0x41E356C", Offset = "0x41DF56C", VA = "0x41E356C", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__235))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60043D9")]
		[Address(RVA = "0x41E3600", Offset = "0x41DF600", VA = "0x41E3600", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60043DA")]
		[Address(RVA = "0x41E36B4", Offset = "0x41DF6B4", VA = "0x41E36B4")]
		public BtnBuyWoodItemComponents()
		{
		}
	}
}
