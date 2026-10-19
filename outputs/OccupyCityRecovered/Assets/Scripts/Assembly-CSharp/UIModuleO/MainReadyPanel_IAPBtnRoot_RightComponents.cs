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
	[Token(Token = "0x2000988")]
	public class MainReadyPanel_IAPBtnRoot_RightComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000989")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__222 : IAsyncStateMachine
		{
			[Token(Token = "0x400476E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400476F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004770")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MainReadyPanel_IAPBtnRoot_RightComponents _003C_003E4__this;

			[Token(Token = "0x4004771")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x600386E")]
			[Address(RVA = "0x40F55EC", Offset = "0x40F15EC", VA = "0x40F55EC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600386F")]
			[Address(RVA = "0x40F5864", Offset = "0x40F1864", VA = "0x40F5864", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400475F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ButtonExtend _buttonExtendSeasonPassEntranceBtn;

		[Token(Token = "0x4004760")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private SeasonPassEntranceBtn _seasonPassEntranceBtnSeasonPassEntranceBtn;

		[Token(Token = "0x4004761")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RectTransform _rectTransformBG;

		[Token(Token = "0x4004762")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Image _imageBG;

		[Token(Token = "0x4004763")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ScrollRect _scrollRectScrollView;

		[Token(Token = "0x4004764")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private RectTransform _rectTransformContent;

		[Token(Token = "0x4004765")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private ContentSizeFitter _contentSizeFitterContent;

		[Token(Token = "0x4004766")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private ButtonExtend _buttonExtendBtnNewPack;

		[Token(Token = "0x4004767")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private GiftBtn _giftBtnBtnNewPack;

		[Token(Token = "0x4004768")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private ButtonExtend _buttonExtendBtnFund;

		[Token(Token = "0x4004769")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private ButtonExtend _buttonExtendBtnMonthPass;

		[Token(Token = "0x400476A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private GiftBtn _giftBtnBtnMonthPass;

		[Token(Token = "0x400476B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private ButtonExtend _buttonExtendBtnCheckInReward;

		[Token(Token = "0x400476C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private ButtonExtend _buttonExtendBtnDailyBless;

		[Token(Token = "0x400476D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private GiftBtn _giftBtnBtnDailyBless;

		[Token(Token = "0x17000869")]
		public ButtonExtend ButtonExtendSeasonPassEntranceBtn
		{
			[Token(Token = "0x6003852")]
			[Address(RVA = "0x40F50F8", Offset = "0x40F10F8", VA = "0x40F50F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700086A")]
		public SeasonPassEntranceBtn SeasonPassEntranceBtnSeasonPassEntranceBtn
		{
			[Token(Token = "0x6003853")]
			[Address(RVA = "0x40F32DC", Offset = "0x40EF2DC", VA = "0x40F32DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700086B")]
		public RectTransform RectTransformBG
		{
			[Token(Token = "0x6003854")]
			[Address(RVA = "0x40F2B7C", Offset = "0x40EEB7C", VA = "0x40F2B7C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700086C")]
		public Image ImageBG
		{
			[Token(Token = "0x6003855")]
			[Address(RVA = "0x40F285C", Offset = "0x40EE85C", VA = "0x40F285C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700086D")]
		public ScrollRect ScrollRectScrollView
		{
			[Token(Token = "0x6003856")]
			[Address(RVA = "0x40F2924", Offset = "0x40EE924", VA = "0x40F2924")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700086E")]
		public RectTransform RectTransformContent
		{
			[Token(Token = "0x6003857")]
			[Address(RVA = "0x40F2AB4", Offset = "0x40EEAB4", VA = "0x40F2AB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700086F")]
		public ContentSizeFitter ContentSizeFitterContent
		{
			[Token(Token = "0x6003858")]
			[Address(RVA = "0x40F29EC", Offset = "0x40EE9EC", VA = "0x40F29EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000870")]
		public ButtonExtend ButtonExtendBtnNewPack
		{
			[Token(Token = "0x6003859")]
			[Address(RVA = "0x40F3F40", Offset = "0x40EFF40", VA = "0x40F3F40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000871")]
		public GiftBtn GiftBtnBtnNewPack
		{
			[Token(Token = "0x600385A")]
			[Address(RVA = "0x40F4008", Offset = "0x40F0008", VA = "0x40F4008")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000872")]
		public ButtonExtend ButtonExtendBtnFund
		{
			[Token(Token = "0x600385B")]
			[Address(RVA = "0x40F2D1C", Offset = "0x40EED1C", VA = "0x40F2D1C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000873")]
		public ButtonExtend ButtonExtendBtnMonthPass
		{
			[Token(Token = "0x600385C")]
			[Address(RVA = "0x40F4660", Offset = "0x40F0660", VA = "0x40F4660")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000874")]
		public GiftBtn GiftBtnBtnMonthPass
		{
			[Token(Token = "0x600385D")]
			[Address(RVA = "0x40F4F5C", Offset = "0x40F0F5C", VA = "0x40F4F5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000875")]
		public ButtonExtend ButtonExtendBtnCheckInReward
		{
			[Token(Token = "0x600385E")]
			[Address(RVA = "0x40F3444", Offset = "0x40EF444", VA = "0x40F3444")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000876")]
		public ButtonExtend ButtonExtendBtnDailyBless
		{
			[Token(Token = "0x600385F")]
			[Address(RVA = "0x40F3080", Offset = "0x40EF080", VA = "0x40F3080")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000877")]
		public GiftBtn GiftBtnBtnDailyBless
		{
			[Token(Token = "0x6003860")]
			[Address(RVA = "0x40F5024", Offset = "0x40F1024", VA = "0x40F5024")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003861")]
		[Address(RVA = "0x40F51C0", Offset = "0x40F11C0", VA = "0x40F51C0")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6003862")]
		[Address(RVA = "0x40F5410", Offset = "0x40F1410", VA = "0x40F5410", Slot = "12")]
		protected virtual void OnButtonExtendSeasonPassEntranceBtnClicked()
		{
		}

		[Token(Token = "0x6003863")]
		[Address(RVA = "0x40F547C", Offset = "0x40F147C", VA = "0x40F547C", Slot = "13")]
		protected virtual void OnScrollRectScrollViewValueChanged(Vector2 arg)
		{
		}

		[Token(Token = "0x6003864")]
		[Address(RVA = "0x40F3908", Offset = "0x40EF908", VA = "0x40F3908", Slot = "14")]
		protected virtual void OnButtonExtendBtnNewPackClicked()
		{
		}

		[Token(Token = "0x6003865")]
		[Address(RVA = "0x40F4858", Offset = "0x40F0858", VA = "0x40F4858", Slot = "15")]
		protected virtual void OnButtonExtendBtnFundClicked()
		{
		}

		[Token(Token = "0x6003866")]
		[Address(RVA = "0x40F39E0", Offset = "0x40EF9E0", VA = "0x40F39E0", Slot = "16")]
		protected virtual void OnButtonExtendBtnMonthPassClicked()
		{
		}

		[Token(Token = "0x6003867")]
		[Address(RVA = "0x40F35E4", Offset = "0x40EF5E4", VA = "0x40F35E4", Slot = "17")]
		protected virtual void OnButtonExtendBtnCheckInRewardClicked()
		{
		}

		[Token(Token = "0x6003868")]
		[Address(RVA = "0x40F477C", Offset = "0x40F077C", VA = "0x40F477C", Slot = "18")]
		protected virtual void OnButtonExtendBtnDailyBlessClicked()
		{
		}

		[Token(Token = "0x6003869")]
		[Address(RVA = "0x40F25FC", Offset = "0x40EE5FC", VA = "0x40F25FC", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600386A")]
		[Address(RVA = "0x40F48E0", Offset = "0x40F08E0", VA = "0x40F48E0", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__222))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x600386B")]
		[Address(RVA = "0x40F5530", Offset = "0x40F1530", VA = "0x40F5530", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x600386C")]
		[Address(RVA = "0x40F48CC", Offset = "0x40F08CC", VA = "0x40F48CC")]
		public MainReadyPanel_IAPBtnRoot_RightComponents()
		{
		}
	}
}
