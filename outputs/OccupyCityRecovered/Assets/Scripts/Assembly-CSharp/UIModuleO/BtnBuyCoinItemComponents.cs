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
	[Token(Token = "0x2000B1C")]
	public class BtnBuyCoinItemComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B1D")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__235 : IAsyncStateMachine
		{
			[Token(Token = "0x4005138")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005139")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400513A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BtnBuyCoinItemComponents _003C_003E4__this;

			[Token(Token = "0x400513B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6004397")]
			[Address(RVA = "0x41DF354", Offset = "0x41DB354", VA = "0x41DF354", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004398")]
			[Address(RVA = "0x41DF5CC", Offset = "0x41DB5CC", VA = "0x41DF5CC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400512A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ButtonExtend _buttonExtendBtnBuyCoinItem;

		[Token(Token = "0x400512B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RectTransform _rectTransformShop_bg_dablue;

		[Token(Token = "0x400512C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RectTransform _rectTransformShop_bg_blue;

		[Token(Token = "0x400512D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private RectTransform _rectTransformShop_bg_green;

		[Token(Token = "0x400512E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private RectTransform _rectTransformImgCoinIcon;

		[Token(Token = "0x400512F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Image _imageImgCoinIcon;

		[Token(Token = "0x4005130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private DOTweenAnimation _dOTweenAnimationImgCoinIcon;

		[Token(Token = "0x4005131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private TextMeshProUGUI _textMeshProUGUITxtName;

		[Token(Token = "0x4005132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private TextMeshProUGUI _textMeshProUGUITxtPriceNum;

		[Token(Token = "0x4005133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private TextMeshProUGUI _textMeshProUGUITxtCoinNum;

		[Token(Token = "0x4005134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private TextMeshProUGUI _textMeshProUGUITxtPurchased;

		[Token(Token = "0x4005135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Image _imageImgBuyEd;

		[Token(Token = "0x4005136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private TextMeshProUGUI _textMeshProUGUITxtFree;

		[Token(Token = "0x4005137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private AdButtonExtend _adButtonExtendBtnAd;

		[Token(Token = "0x17000AFA")]
		public ButtonExtend ButtonExtendBtnBuyCoinItem
		{
			[Token(Token = "0x6004381")]
			[Address(RVA = "0x41DF004", Offset = "0x41DB004", VA = "0x41DF004")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AFB")]
		public RectTransform RectTransformShop_bg_dablue
		{
			[Token(Token = "0x6004382")]
			[Address(RVA = "0x41DE428", Offset = "0x41DA428", VA = "0x41DE428")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AFC")]
		public RectTransform RectTransformShop_bg_blue
		{
			[Token(Token = "0x6004383")]
			[Address(RVA = "0x41DE360", Offset = "0x41DA360", VA = "0x41DE360")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AFD")]
		public RectTransform RectTransformShop_bg_green
		{
			[Token(Token = "0x6004384")]
			[Address(RVA = "0x41DE298", Offset = "0x41DA298", VA = "0x41DE298")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AFE")]
		public RectTransform RectTransformImgCoinIcon
		{
			[Token(Token = "0x6004385")]
			[Address(RVA = "0x41DD6D4", Offset = "0x41D96D4", VA = "0x41DD6D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AFF")]
		public Image ImageImgCoinIcon
		{
			[Token(Token = "0x6004386")]
			[Address(RVA = "0x41DE748", Offset = "0x41DA748", VA = "0x41DE748")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B00")]
		public DOTweenAnimation DOTweenAnimationImgCoinIcon
		{
			[Token(Token = "0x6004387")]
			[Address(RVA = "0x41DD60C", Offset = "0x41D960C", VA = "0x41DD60C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B01")]
		public TextMeshProUGUI TextMeshProUGUITxtName
		{
			[Token(Token = "0x6004388")]
			[Address(RVA = "0x41DE680", Offset = "0x41DA680", VA = "0x41DE680")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B02")]
		public TextMeshProUGUI TextMeshProUGUITxtPriceNum
		{
			[Token(Token = "0x6004389")]
			[Address(RVA = "0x41DE5B8", Offset = "0x41DA5B8", VA = "0x41DE5B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B03")]
		public TextMeshProUGUI TextMeshProUGUITxtCoinNum
		{
			[Token(Token = "0x600438A")]
			[Address(RVA = "0x41DE4F0", Offset = "0x41DA4F0", VA = "0x41DE4F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B04")]
		public TextMeshProUGUI TextMeshProUGUITxtPurchased
		{
			[Token(Token = "0x600438B")]
			[Address(RVA = "0x41DEDA0", Offset = "0x41DADA0", VA = "0x41DEDA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B05")]
		public Image ImageImgBuyEd
		{
			[Token(Token = "0x600438C")]
			[Address(RVA = "0x41DEE68", Offset = "0x41DAE68", VA = "0x41DEE68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B06")]
		public TextMeshProUGUI TextMeshProUGUITxtFree
		{
			[Token(Token = "0x600438D")]
			[Address(RVA = "0x41DEF30", Offset = "0x41DAF30", VA = "0x41DEF30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B07")]
		public AdButtonExtend AdButtonExtendBtnAd
		{
			[Token(Token = "0x600438E")]
			[Address(RVA = "0x41DD0F8", Offset = "0x41D90F8", VA = "0x41DD0F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600438F")]
		[Address(RVA = "0x41DF0A8", Offset = "0x41DB0A8", VA = "0x41DF0A8")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6004390")]
		[Address(RVA = "0x41DCCDC", Offset = "0x41D8CDC", VA = "0x41DCCDC", Slot = "12")]
		protected virtual void OnButtonExtendBtnBuyCoinItemClicked()
		{
		}

		[Token(Token = "0x6004391")]
		[Address(RVA = "0x41DF17C", Offset = "0x41DB17C", VA = "0x41DF17C", Slot = "13")]
		protected virtual void OnAdButtonExtendBtnAdClicked()
		{
		}

		[Token(Token = "0x6004392")]
		[Address(RVA = "0x41DF1E8", Offset = "0x41DB1E8", VA = "0x41DF1E8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6004393")]
		[Address(RVA = "0x41DF204", Offset = "0x41DB204", VA = "0x41DF204", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__235))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6004394")]
		[Address(RVA = "0x41DF298", Offset = "0x41DB298", VA = "0x41DF298", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6004395")]
		[Address(RVA = "0x41DD2A0", Offset = "0x41D92A0", VA = "0x41DD2A0")]
		public BtnBuyCoinItemComponents()
		{
		}
	}
}
