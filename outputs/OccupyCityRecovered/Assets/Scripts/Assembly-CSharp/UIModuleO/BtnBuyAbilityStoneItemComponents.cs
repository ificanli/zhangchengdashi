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
	[Token(Token = "0x200074D")]
	public class BtnBuyAbilityStoneItemComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200074E")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__232 : IAsyncStateMachine
		{
			[Token(Token = "0x4003969")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400396A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400396B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BtnBuyAbilityStoneItemComponents _003C_003E4__this;

			[Token(Token = "0x400396C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60027F7")]
			[Address(RVA = "0x3FAB930", Offset = "0x3FA7930", VA = "0x3FAB930", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60027F8")]
			[Address(RVA = "0x3FABBA8", Offset = "0x3FA7BA8", VA = "0x3FABBA8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400395B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ButtonExtend _buttonExtendBtnBuyAbilityStoneItem;

		[Token(Token = "0x400395C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RectTransform _rectTransformShop_bg_dablue;

		[Token(Token = "0x400395D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RectTransform _rectTransformShop_bg_blue;

		[Token(Token = "0x400395E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private RectTransform _rectTransformShop_bg_green;

		[Token(Token = "0x400395F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private RectTransform _rectTransformImgAbilityStoneIcon;

		[Token(Token = "0x4003960")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Image _imageImgAbilityStoneIcon;

		[Token(Token = "0x4003961")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private DOTweenAnimation _dOTweenAnimationImgAbilityStoneIcon;

		[Token(Token = "0x4003962")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private TextMeshProUGUI _textMeshProUGUITxtName;

		[Token(Token = "0x4003963")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private TextMeshProUGUI _textMeshProUGUITxtPriceNum;

		[Token(Token = "0x4003964")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private TextMeshProUGUI _textMeshProUGUITxtCoinNum;

		[Token(Token = "0x4003965")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private TextMeshProUGUI _textMeshProUGUITxtPurchased;

		[Token(Token = "0x4003966")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Image _imageImgBuyEd;

		[Token(Token = "0x4003967")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private TextMeshProUGUI _textMeshProUGUITxtFree;

		[Token(Token = "0x4003968")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private AdButtonExtend _adButtonExtendBtnAd;

		[Token(Token = "0x17000379")]
		public ButtonExtend ButtonExtendBtnBuyAbilityStoneItem
		{
			[Token(Token = "0x60027E1")]
			[Address(RVA = "0x3FAB674", Offset = "0x3FA7674", VA = "0x3FAB674")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700037A")]
		public RectTransform RectTransformShop_bg_dablue
		{
			[Token(Token = "0x60027E2")]
			[Address(RVA = "0x3FAA948", Offset = "0x3FA6948", VA = "0x3FAA948")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700037B")]
		public RectTransform RectTransformShop_bg_blue
		{
			[Token(Token = "0x60027E3")]
			[Address(RVA = "0x3FAA880", Offset = "0x3FA6880", VA = "0x3FAA880")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700037C")]
		public RectTransform RectTransformShop_bg_green
		{
			[Token(Token = "0x60027E4")]
			[Address(RVA = "0x3FAA7B8", Offset = "0x3FA67B8", VA = "0x3FAA7B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700037D")]
		public RectTransform RectTransformImgAbilityStoneIcon
		{
			[Token(Token = "0x60027E5")]
			[Address(RVA = "0x3FA9CF8", Offset = "0x3FA5CF8", VA = "0x3FA9CF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700037E")]
		public Image ImageImgAbilityStoneIcon
		{
			[Token(Token = "0x60027E6")]
			[Address(RVA = "0x3FAAC68", Offset = "0x3FA6C68", VA = "0x3FAAC68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700037F")]
		public DOTweenAnimation DOTweenAnimationImgAbilityStoneIcon
		{
			[Token(Token = "0x60027E7")]
			[Address(RVA = "0x3FA9DC0", Offset = "0x3FA5DC0", VA = "0x3FA9DC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000380")]
		public TextMeshProUGUI TextMeshProUGUITxtName
		{
			[Token(Token = "0x60027E8")]
			[Address(RVA = "0x3FAABA0", Offset = "0x3FA6BA0", VA = "0x3FAABA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000381")]
		public TextMeshProUGUI TextMeshProUGUITxtPriceNum
		{
			[Token(Token = "0x60027E9")]
			[Address(RVA = "0x3FAAAD8", Offset = "0x3FA6AD8", VA = "0x3FAAAD8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000382")]
		public TextMeshProUGUI TextMeshProUGUITxtCoinNum
		{
			[Token(Token = "0x60027EA")]
			[Address(RVA = "0x3FAAA10", Offset = "0x3FA6A10", VA = "0x3FAAA10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000383")]
		public TextMeshProUGUI TextMeshProUGUITxtPurchased
		{
			[Token(Token = "0x60027EB")]
			[Address(RVA = "0x3FAB410", Offset = "0x3FA7410", VA = "0x3FAB410")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000384")]
		public Image ImageImgBuyEd
		{
			[Token(Token = "0x60027EC")]
			[Address(RVA = "0x3FAB4D8", Offset = "0x3FA74D8", VA = "0x3FAB4D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000385")]
		public TextMeshProUGUI TextMeshProUGUITxtFree
		{
			[Token(Token = "0x60027ED")]
			[Address(RVA = "0x3FAB5A0", Offset = "0x3FA75A0", VA = "0x3FAB5A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000386")]
		public AdButtonExtend AdButtonExtendBtnAd
		{
			[Token(Token = "0x60027EE")]
			[Address(RVA = "0x3FA9698", Offset = "0x3FA5698", VA = "0x3FA9698")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60027EF")]
		[Address(RVA = "0x3FAB718", Offset = "0x3FA7718", VA = "0x3FAB718")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x60027F0")]
		[Address(RVA = "0x3FA935C", Offset = "0x3FA535C", VA = "0x3FA935C", Slot = "12")]
		protected virtual void OnButtonExtendBtnBuyAbilityStoneItemClicked()
		{
		}

		[Token(Token = "0x60027F1")]
		[Address(RVA = "0x3FAB7EC", Offset = "0x3FA77EC", VA = "0x3FAB7EC", Slot = "13")]
		protected virtual void OnAdButtonExtendBtnAdClicked()
		{
		}

		[Token(Token = "0x60027F2")]
		[Address(RVA = "0x3FAB858", Offset = "0x3FA7858", VA = "0x3FAB858", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60027F3")]
		[Address(RVA = "0x3FA9920", Offset = "0x3FA5920", VA = "0x3FA9920", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__232))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60027F4")]
		[Address(RVA = "0x3FAB874", Offset = "0x3FA7874", VA = "0x3FAB874", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60027F5")]
		[Address(RVA = "0x3FA9914", Offset = "0x3FA5914", VA = "0x3FA9914")]
		public BtnBuyAbilityStoneItemComponents()
		{
		}
	}
}
