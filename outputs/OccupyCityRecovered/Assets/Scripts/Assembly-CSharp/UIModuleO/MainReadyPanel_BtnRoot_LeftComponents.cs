using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using UIFramework;
using UIModuleO.UIAnim;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000983")]
	public class MainReadyPanel_BtnRoot_LeftComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000984")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__256 : IAsyncStateMachine
		{
			[Token(Token = "0x4004751")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004752")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004753")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MainReadyPanel_BtnRoot_LeftComponents _003C_003E4__this;

			[Token(Token = "0x4004754")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6003833")]
			[Address(RVA = "0x40F1D3C", Offset = "0x40EDD3C", VA = "0x40F1D3C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003834")]
			[Address(RVA = "0x40F1FB4", Offset = "0x40EDFB4", VA = "0x40F1FB4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004739")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RectTransform _rectTransformBG;

		[Token(Token = "0x400473A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Image _imageBG;

		[Token(Token = "0x400473B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private ScrollRect _scrollRectScrollView;

		[Token(Token = "0x400473C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private RectTransform _rectTransformContent;

		[Token(Token = "0x400473D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ContentSizeFitter _contentSizeFitterContent;

		[Token(Token = "0x400473E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private ButtonExtend _buttonExtendBtnWeeklyClash;

		[Token(Token = "0x400473F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private ButtonExtend _buttonExtendBtnGoldCardWeekly;

		[Token(Token = "0x4004740")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private GiftBtn _giftBtnBtnGoldCardWeekly;

		[Token(Token = "0x4004741")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private ButtonExtend _buttonExtendBtnMysteriousStore;

		[Token(Token = "0x4004742")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private GiftBtn _giftBtnBtnMysteriousStore;

		[Token(Token = "0x4004743")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private ButtonExtend _buttonExtendBtnGiftChain;

		[Token(Token = "0x4004744")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private GiftBtn _giftBtnBtnGiftChain;

		[Token(Token = "0x4004745")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private ButtonExtend _buttonExtendBtnGiftChain2;

		[Token(Token = "0x4004746")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private GiftBtn _giftBtnBtnGiftChain2;

		[Token(Token = "0x4004747")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private ButtonExtend _buttonExtendBtnPushPack;

		[Token(Token = "0x4004748")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private GiftBtn _giftBtnBtnPushPack;

		[Token(Token = "0x4004749")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private ButtonExtend _buttonExtendBtnSpecialOffer;

		[Token(Token = "0x400474A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private GiftBtn _giftBtnBtnSpecialOffer;

		[Token(Token = "0x400474B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private ButtonExtend _buttonExtendBtnElitePack;

		[Token(Token = "0x400474C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private GiftBtn _giftBtnBtnElitePack;

		[Token(Token = "0x400474D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private ButtonExtend _buttonExtendBtnArenaPack;

		[Token(Token = "0x400474E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private GiftBtn _giftBtnBtnArenaPack;

		[Token(Token = "0x400474F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private ButtonExtend _buttonExtendBtnWorldCup;

		[Token(Token = "0x4004750")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private GiftBtn _giftBtnBtnWorldCup;

		[Token(Token = "0x17000851")]
		public RectTransform RectTransformBG
		{
			[Token(Token = "0x600380A")]
			[Address(RVA = "0x40EEBE4", Offset = "0x40EABE4", VA = "0x40EEBE4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000852")]
		public Image ImageBG
		{
			[Token(Token = "0x600380B")]
			[Address(RVA = "0x40EE8C4", Offset = "0x40EA8C4", VA = "0x40EE8C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000853")]
		public ScrollRect ScrollRectScrollView
		{
			[Token(Token = "0x600380C")]
			[Address(RVA = "0x40EE98C", Offset = "0x40EA98C", VA = "0x40EE98C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000854")]
		public RectTransform RectTransformContent
		{
			[Token(Token = "0x600380D")]
			[Address(RVA = "0x40EEB1C", Offset = "0x40EAB1C", VA = "0x40EEB1C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000855")]
		public ContentSizeFitter ContentSizeFitterContent
		{
			[Token(Token = "0x600380E")]
			[Address(RVA = "0x40EEA54", Offset = "0x40EAA54", VA = "0x40EEA54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000856")]
		public ButtonExtend ButtonExtendBtnWeeklyClash
		{
			[Token(Token = "0x600380F")]
			[Address(RVA = "0x40F0A94", Offset = "0x40ECA94", VA = "0x40F0A94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000857")]
		public ButtonExtend ButtonExtendBtnGoldCardWeekly
		{
			[Token(Token = "0x6003810")]
			[Address(RVA = "0x40EC970", Offset = "0x40E8970", VA = "0x40EC970")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000858")]
		public GiftBtn GiftBtnBtnGoldCardWeekly
		{
			[Token(Token = "0x6003811")]
			[Address(RVA = "0x40ECA38", Offset = "0x40E8A38", VA = "0x40ECA38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000859")]
		public ButtonExtend ButtonExtendBtnMysteriousStore
		{
			[Token(Token = "0x6003812")]
			[Address(RVA = "0x40F0B5C", Offset = "0x40ECB5C", VA = "0x40F0B5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700085A")]
		public GiftBtn GiftBtnBtnMysteriousStore
		{
			[Token(Token = "0x6003813")]
			[Address(RVA = "0x40EC718", Offset = "0x40E8718", VA = "0x40EC718")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700085B")]
		public ButtonExtend ButtonExtendBtnGiftChain
		{
			[Token(Token = "0x6003814")]
			[Address(RVA = "0x40EDFC0", Offset = "0x40E9FC0", VA = "0x40EDFC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700085C")]
		public GiftBtn GiftBtnBtnGiftChain
		{
			[Token(Token = "0x6003815")]
			[Address(RVA = "0x40EC330", Offset = "0x40E8330", VA = "0x40EC330")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700085D")]
		public ButtonExtend ButtonExtendBtnGiftChain2
		{
			[Token(Token = "0x6003816")]
			[Address(RVA = "0x40EC7E0", Offset = "0x40E87E0", VA = "0x40EC7E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700085E")]
		public GiftBtn GiftBtnBtnGiftChain2
		{
			[Token(Token = "0x6003817")]
			[Address(RVA = "0x40EC8A8", Offset = "0x40E88A8", VA = "0x40EC8A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700085F")]
		public ButtonExtend ButtonExtendBtnPushPack
		{
			[Token(Token = "0x6003818")]
			[Address(RVA = "0x40ED874", Offset = "0x40E9874", VA = "0x40ED874")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000860")]
		public GiftBtn GiftBtnBtnPushPack
		{
			[Token(Token = "0x6003819")]
			[Address(RVA = "0x40EC268", Offset = "0x40E8268", VA = "0x40EC268")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000861")]
		public ButtonExtend ButtonExtendBtnSpecialOffer
		{
			[Token(Token = "0x600381A")]
			[Address(RVA = "0x40EC3F8", Offset = "0x40E83F8", VA = "0x40EC3F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000862")]
		public GiftBtn GiftBtnBtnSpecialOffer
		{
			[Token(Token = "0x600381B")]
			[Address(RVA = "0x40EC4C0", Offset = "0x40E84C0", VA = "0x40EC4C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000863")]
		public ButtonExtend ButtonExtendBtnElitePack
		{
			[Token(Token = "0x600381C")]
			[Address(RVA = "0x40EC588", Offset = "0x40E8588", VA = "0x40EC588")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000864")]
		public GiftBtn GiftBtnBtnElitePack
		{
			[Token(Token = "0x600381D")]
			[Address(RVA = "0x40EC650", Offset = "0x40E8650", VA = "0x40EC650")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000865")]
		public ButtonExtend ButtonExtendBtnArenaPack
		{
			[Token(Token = "0x600381E")]
			[Address(RVA = "0x40ECB00", Offset = "0x40E8B00", VA = "0x40ECB00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000866")]
		public GiftBtn GiftBtnBtnArenaPack
		{
			[Token(Token = "0x600381F")]
			[Address(RVA = "0x40ECBC8", Offset = "0x40E8BC8", VA = "0x40ECBC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000867")]
		public ButtonExtend ButtonExtendBtnWorldCup
		{
			[Token(Token = "0x6003820")]
			[Address(RVA = "0x40ECD24", Offset = "0x40E8D24", VA = "0x40ECD24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000868")]
		public GiftBtn GiftBtnBtnWorldCup
		{
			[Token(Token = "0x6003821")]
			[Address(RVA = "0x40ECDEC", Offset = "0x40E8DEC", VA = "0x40ECDEC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003822")]
		[Address(RVA = "0x40F0C24", Offset = "0x40ECC24", VA = "0x40F0C24")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6003823")]
		[Address(RVA = "0x40F0FDC", Offset = "0x40ECFDC", VA = "0x40F0FDC", Slot = "12")]
		protected virtual void OnScrollRectScrollViewValueChanged(Vector2 arg)
		{
		}

		[Token(Token = "0x6003824")]
		[Address(RVA = "0x40F1090", Offset = "0x40ED090", VA = "0x40F1090", Slot = "13")]
		protected virtual void OnButtonExtendBtnWeeklyClashClicked()
		{
		}

		[Token(Token = "0x6003825")]
		[Address(RVA = "0x40EF7FC", Offset = "0x40EB7FC", VA = "0x40EF7FC", Slot = "14")]
		protected virtual void OnButtonExtendBtnGoldCardWeeklyClicked()
		{
		}

		[Token(Token = "0x6003826")]
		[Address(RVA = "0x40EF86C", Offset = "0x40EB86C", VA = "0x40EF86C", Slot = "15")]
		protected virtual void OnButtonExtendBtnMysteriousStoreClicked()
		{
		}

		[Token(Token = "0x6003827")]
		[Address(RVA = "0x40EEFC8", Offset = "0x40EAFC8", VA = "0x40EEFC8", Slot = "16")]
		protected virtual void OnButtonExtendBtnGiftChainClicked()
		{
		}

		[Token(Token = "0x6003828")]
		[Address(RVA = "0x40EF250", Offset = "0x40EB250", VA = "0x40EF250", Slot = "17")]
		protected virtual void OnButtonExtendBtnGiftChain2Clicked()
		{
		}

		[Token(Token = "0x6003829")]
		[Address(RVA = "0x40EEE34", Offset = "0x40EAE34", VA = "0x40EEE34", Slot = "18")]
		protected virtual void OnButtonExtendBtnPushPackClicked()
		{
		}

		[Token(Token = "0x600382A")]
		[Address(RVA = "0x40EF0A0", Offset = "0x40EB0A0", VA = "0x40EF0A0", Slot = "19")]
		protected virtual void OnButtonExtendBtnSpecialOfferClicked()
		{
		}

		[Token(Token = "0x600382B")]
		[Address(RVA = "0x40EF178", Offset = "0x40EB178", VA = "0x40EF178", Slot = "20")]
		protected virtual void OnButtonExtendBtnElitePackClicked()
		{
		}

		[Token(Token = "0x600382C")]
		[Address(RVA = "0x40EF554", Offset = "0x40EB554", VA = "0x40EF554", Slot = "21")]
		protected virtual void OnButtonExtendBtnArenaPackClicked()
		{
		}

		[Token(Token = "0x600382D")]
		[Address(RVA = "0x40EF61C", Offset = "0x40EB61C", VA = "0x40EF61C", Slot = "22")]
		protected virtual void OnButtonExtendBtnWorldCupClicked()
		{
		}

		[Token(Token = "0x600382E")]
		[Address(RVA = "0x40EBA74", Offset = "0x40E7A74", VA = "0x40EBA74", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600382F")]
		[Address(RVA = "0x40EF6D4", Offset = "0x40EB6D4", VA = "0x40EF6D4", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__256))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6003830")]
		[Address(RVA = "0x40F10FC", Offset = "0x40ED0FC", VA = "0x40F10FC", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6003831")]
		[Address(RVA = "0x40EF690", Offset = "0x40EB690", VA = "0x40EF690")]
		public MainReadyPanel_BtnRoot_LeftComponents()
		{
		}
	}
}
