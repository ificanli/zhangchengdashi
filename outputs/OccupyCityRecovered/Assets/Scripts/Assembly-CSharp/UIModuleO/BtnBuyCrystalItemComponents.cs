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
	[Token(Token = "0x2000752")]
	public class BtnBuyCrystalItemComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000753")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__268 : IAsyncStateMachine
		{
			[Token(Token = "0x4003988")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003989")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400398A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BtnBuyCrystalItemComponents _003C_003E4__this;

			[Token(Token = "0x400398B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x600281C")]
			[Address(RVA = "0x3FADF50", Offset = "0x3FA9F50", VA = "0x3FADF50", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600281D")]
			[Address(RVA = "0x3FAE1C8", Offset = "0x3FAA1C8", VA = "0x3FAE1C8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400397A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ButtonExtend _buttonExtendBtnBuyCrystalItem;

		[Token(Token = "0x400397B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RectTransform _rectTransformShop_bg_dablue;

		[Token(Token = "0x400397C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RectTransform _rectTransformShop_bg_blue;

		[Token(Token = "0x400397D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private RectTransform _rectTransformShop_bg_green;

		[Token(Token = "0x400397E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private RectTransform _rectTransformImgCrystalIcon;

		[Token(Token = "0x400397F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Image _imageImgCrystalIcon;

		[Token(Token = "0x4003980")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private DOTweenAnimation _dOTweenAnimationImgCrystalIcon;

		[Token(Token = "0x4003981")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private TextMeshProUGUI _textMeshProUGUITxtName;

		[Token(Token = "0x4003982")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private TextMeshProUGUI _textMeshProUGUITxtPriceNum;

		[Token(Token = "0x4003983")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private TextMeshProUGUI _textMeshProUGUITxtCoinNum;

		[Token(Token = "0x4003984")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private TextMeshProUGUI _textMeshProUGUITxtPurchased;

		[Token(Token = "0x4003985")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Image _imageImgBuyEd;

		[Token(Token = "0x4003986")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private TextMeshProUGUI _textMeshProUGUITxtFree;

		[Token(Token = "0x4003987")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private AdButtonExtend _adButtonExtendBtnAd;

		[Token(Token = "0x17000387")]
		public ButtonExtend ButtonExtendBtnBuyCrystalItem
		{
			[Token(Token = "0x6002806")]
			[Address(RVA = "0x3FADC00", Offset = "0x3FA9C00", VA = "0x3FADC00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000388")]
		public RectTransform RectTransformShop_bg_dablue
		{
			[Token(Token = "0x6002807")]
			[Address(RVA = "0x3FADA64", Offset = "0x3FA9A64", VA = "0x3FADA64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000389")]
		public RectTransform RectTransformShop_bg_blue
		{
			[Token(Token = "0x6002808")]
			[Address(RVA = "0x3FAD99C", Offset = "0x3FA999C", VA = "0x3FAD99C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700038A")]
		public RectTransform RectTransformShop_bg_green
		{
			[Token(Token = "0x6002809")]
			[Address(RVA = "0x3FAD8D4", Offset = "0x3FA98D4", VA = "0x3FAD8D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700038B")]
		public RectTransform RectTransformImgCrystalIcon
		{
			[Token(Token = "0x600280A")]
			[Address(RVA = "0x3FAC570", Offset = "0x3FA8570", VA = "0x3FAC570")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700038C")]
		public Image ImageImgCrystalIcon
		{
			[Token(Token = "0x600280B")]
			[Address(RVA = "0x3FADB2C", Offset = "0x3FA9B2C", VA = "0x3FADB2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700038D")]
		public DOTweenAnimation DOTweenAnimationImgCrystalIcon
		{
			[Token(Token = "0x600280C")]
			[Address(RVA = "0x3FAC638", Offset = "0x3FA8638", VA = "0x3FAC638")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700038E")]
		public TextMeshProUGUI TextMeshProUGUITxtName
		{
			[Token(Token = "0x600280D")]
			[Address(RVA = "0x3FAC2A8", Offset = "0x3FA82A8", VA = "0x3FAC2A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700038F")]
		public TextMeshProUGUI TextMeshProUGUITxtPriceNum
		{
			[Token(Token = "0x600280E")]
			[Address(RVA = "0x3FAC370", Offset = "0x3FA8370", VA = "0x3FAC370")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000390")]
		public TextMeshProUGUI TextMeshProUGUITxtCoinNum
		{
			[Token(Token = "0x600280F")]
			[Address(RVA = "0x3FABF88", Offset = "0x3FA7F88", VA = "0x3FABF88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000391")]
		public TextMeshProUGUI TextMeshProUGUITxtPurchased
		{
			[Token(Token = "0x6002810")]
			[Address(RVA = "0x3FAC050", Offset = "0x3FA8050", VA = "0x3FAC050")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000392")]
		public Image ImageImgBuyEd
		{
			[Token(Token = "0x6002811")]
			[Address(RVA = "0x3FAC118", Offset = "0x3FA8118", VA = "0x3FAC118")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000393")]
		public TextMeshProUGUI TextMeshProUGUITxtFree
		{
			[Token(Token = "0x6002812")]
			[Address(RVA = "0x3FAC1E0", Offset = "0x3FA81E0", VA = "0x3FAC1E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000394")]
		public AdButtonExtend AdButtonExtendBtnAd
		{
			[Token(Token = "0x6002813")]
			[Address(RVA = "0x3FACC50", Offset = "0x3FA8C50", VA = "0x3FACC50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002814")]
		[Address(RVA = "0x3FADCA4", Offset = "0x3FA9CA4", VA = "0x3FADCA4")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6002815")]
		[Address(RVA = "0x3FAC910", Offset = "0x3FA8910", VA = "0x3FAC910", Slot = "12")]
		protected virtual void OnButtonExtendBtnBuyCrystalItemClicked()
		{
		}

		[Token(Token = "0x6002816")]
		[Address(RVA = "0x3FADD78", Offset = "0x3FA9D78", VA = "0x3FADD78", Slot = "13")]
		protected virtual void OnAdButtonExtendBtnAdClicked()
		{
		}

		[Token(Token = "0x6002817")]
		[Address(RVA = "0x3FADDE4", Offset = "0x3FA9DE4", VA = "0x3FADDE4", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002818")]
		[Address(RVA = "0x3FADE00", Offset = "0x3FA9E00", VA = "0x3FADE00", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__268))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002819")]
		[Address(RVA = "0x3FADE94", Offset = "0x3FA9E94", VA = "0x3FADE94", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x600281A")]
		[Address(RVA = "0x3FACECC", Offset = "0x3FA8ECC", VA = "0x3FACECC")]
		public BtnBuyCrystalItemComponents()
		{
		}
	}
}
