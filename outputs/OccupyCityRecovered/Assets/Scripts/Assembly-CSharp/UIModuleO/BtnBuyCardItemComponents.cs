using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using SDKModule;
using TMPro;
using UIFramework;
using UIModuleO.UIAnim;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000B15")]
	public class BtnBuyCardItemComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B16")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__214 : IAsyncStateMachine
		{
			[Token(Token = "0x4005113")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005114")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005115")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BtnBuyCardItemComponents _003C_003E4__this;

			[Token(Token = "0x4005116")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x600436D")]
			[Address(RVA = "0x41DC664", Offset = "0x41D8664", VA = "0x41DC664", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600436E")]
			[Address(RVA = "0x41DC8DC", Offset = "0x41D88DC", VA = "0x41DC8DC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4005107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RectTransform _rectTransformBtnBuyCardItem;

		[Token(Token = "0x4005108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ButtonExtend _buttonExtendBtnBuyCardItem;

		[Token(Token = "0x4005109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RectTransform _rectTransformShop_bg_blue;

		[Token(Token = "0x400510A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private RectTransform _rectTransformShop_bg_green;

		[Token(Token = "0x400510B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TextMeshProUGUI _textMeshProUGUITxtProductName;

		[Token(Token = "0x400510C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private TextMeshProUGUI _textMeshProUGUITxtFree;

		[Token(Token = "0x400510D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private TextMeshProUGUI _textMeshProUGUITxtPrice;

		[Token(Token = "0x400510E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Image _imageImgManyDiamond;

		[Token(Token = "0x400510F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private TextMeshProUGUI _textMeshProUGUITxtGetDiamondNum;

		[Token(Token = "0x4005110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private TextMeshProUGUI _textMeshProUGUITxtPurchased;

		[Token(Token = "0x4005111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Image _imageImgBuyEd;

		[Token(Token = "0x4005112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private AdButtonExtend _adButtonExtendBtnAd;

		[Token(Token = "0x17000AEE")]
		public RectTransform RectTransformBtnBuyCardItem
		{
			[Token(Token = "0x6004359")]
			[Address(RVA = "0x41DBCD4", Offset = "0x41D7CD4", VA = "0x41DBCD4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AEF")]
		public ButtonExtend ButtonExtendBtnBuyCardItem
		{
			[Token(Token = "0x600435A")]
			[Address(RVA = "0x41DC314", Offset = "0x41D8314", VA = "0x41DC314")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AF0")]
		public RectTransform RectTransformShop_bg_blue
		{
			[Token(Token = "0x600435B")]
			[Address(RVA = "0x41DAAC4", Offset = "0x41D6AC4", VA = "0x41DAAC4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AF1")]
		public RectTransform RectTransformShop_bg_green
		{
			[Token(Token = "0x600435C")]
			[Address(RVA = "0x41DAB8C", Offset = "0x41D6B8C", VA = "0x41DAB8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AF2")]
		public TextMeshProUGUI TextMeshProUGUITxtProductName
		{
			[Token(Token = "0x600435D")]
			[Address(RVA = "0x41DADE4", Offset = "0x41D6DE4", VA = "0x41DADE4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AF3")]
		public TextMeshProUGUI TextMeshProUGUITxtFree
		{
			[Token(Token = "0x600435E")]
			[Address(RVA = "0x41DAC54", Offset = "0x41D6C54", VA = "0x41DAC54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AF4")]
		public TextMeshProUGUI TextMeshProUGUITxtPrice
		{
			[Token(Token = "0x600435F")]
			[Address(RVA = "0x41DBE40", Offset = "0x41D7E40", VA = "0x41DBE40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AF5")]
		public Image ImageImgManyDiamond
		{
			[Token(Token = "0x6004360")]
			[Address(RVA = "0x41DBD78", Offset = "0x41D7D78", VA = "0x41DBD78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AF6")]
		public TextMeshProUGUI TextMeshProUGUITxtGetDiamondNum
		{
			[Token(Token = "0x6004361")]
			[Address(RVA = "0x41DBC0C", Offset = "0x41D7C0C", VA = "0x41DBC0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AF7")]
		public TextMeshProUGUI TextMeshProUGUITxtPurchased
		{
			[Token(Token = "0x6004362")]
			[Address(RVA = "0x41DAD1C", Offset = "0x41D6D1C", VA = "0x41DAD1C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AF8")]
		public Image ImageImgBuyEd
		{
			[Token(Token = "0x6004363")]
			[Address(RVA = "0x41DBF08", Offset = "0x41D7F08", VA = "0x41DBF08")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AF9")]
		public AdButtonExtend AdButtonExtendBtnAd
		{
			[Token(Token = "0x6004364")]
			[Address(RVA = "0x41D9C30", Offset = "0x41D5C30", VA = "0x41D9C30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004365")]
		[Address(RVA = "0x41DC3B8", Offset = "0x41D83B8", VA = "0x41DC3B8")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6004366")]
		[Address(RVA = "0x41D9928", Offset = "0x41D5928", VA = "0x41D9928", Slot = "12")]
		protected virtual void OnButtonExtendBtnBuyCardItemClicked()
		{
		}

		[Token(Token = "0x6004367")]
		[Address(RVA = "0x41DC48C", Offset = "0x41D848C", VA = "0x41DC48C", Slot = "13")]
		protected virtual void OnAdButtonExtendBtnAdClicked()
		{
		}

		[Token(Token = "0x6004368")]
		[Address(RVA = "0x41DC4F8", Offset = "0x41D84F8", VA = "0x41DC4F8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6004369")]
		[Address(RVA = "0x41DC514", Offset = "0x41D8514", VA = "0x41DC514", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__214))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x600436A")]
		[Address(RVA = "0x41DC5A8", Offset = "0x41D85A8", VA = "0x41DC5A8", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x600436B")]
		[Address(RVA = "0x41DA28C", Offset = "0x41D628C", VA = "0x41DA28C")]
		public BtnBuyCardItemComponents()
		{
		}
	}
}
