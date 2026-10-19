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
	[Token(Token = "0x20008E9")]
	public class GiftChainItemComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20008EA")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__169 : IAsyncStateMachine
		{
			[Token(Token = "0x400437D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400437E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400437F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GiftChainItemComponents _003C_003E4__this;

			[Token(Token = "0x4004380")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6003362")]
			[Address(RVA = "0x4097FD8", Offset = "0x4093FD8", VA = "0x4097FD8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003363")]
			[Address(RVA = "0x4098250", Offset = "0x4094250", VA = "0x4098250", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400436E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TextMeshProUGUI _textMeshProUGUIName;

		[Token(Token = "0x400436F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private CanvasGroup _canvasGroupFirstMask;

		[Token(Token = "0x4004370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TextMeshProUGUI _textMeshProUGUIFirstName;

		[Token(Token = "0x4004371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private RectTransform _rectTransformH;

		[Token(Token = "0x4004372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private RectTransform _rectTransformItem;

		[Token(Token = "0x4004373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private RectTransform _rectTransformLockBg;

		[Token(Token = "0x4004374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Image _imageLockBg;

		[Token(Token = "0x4004375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private RectTransform _rectTransformLock;

		[Token(Token = "0x4004376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private RectTransform _rectTransformBuy;

		[Token(Token = "0x4004377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private ButtonExtend _buttonExtendBuy;

		[Token(Token = "0x4004378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private TextMeshProUGUI _textMeshProUGUICost;

		[Token(Token = "0x4004379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private RectTransform _rectTransformHWIAPButton;

		[Token(Token = "0x400437A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private HWIAPButton _hWIAPButtonHWIAPButton;

		[Token(Token = "0x400437B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private ButtonExtend _buttonExtendHWIAPButton;

		[Token(Token = "0x400437C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private RectTransform _rectTransformHasBuy;

		[Token(Token = "0x170006E1")]
		public TextMeshProUGUI TextMeshProUGUIName
		{
			[Token(Token = "0x600334B")]
			[Address(RVA = "0x4097774", Offset = "0x4093774", VA = "0x4097774")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006E2")]
		public CanvasGroup CanvasGroupFirstMask
		{
			[Token(Token = "0x600334C")]
			[Address(RVA = "0x40968D0", Offset = "0x40928D0", VA = "0x40968D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006E3")]
		public TextMeshProUGUI TextMeshProUGUIFirstName
		{
			[Token(Token = "0x600334D")]
			[Address(RVA = "0x409783C", Offset = "0x409383C", VA = "0x409783C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006E4")]
		public RectTransform RectTransformH
		{
			[Token(Token = "0x600334E")]
			[Address(RVA = "0x4097B5C", Offset = "0x4093B5C", VA = "0x4097B5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006E5")]
		public RectTransform RectTransformItem
		{
			[Token(Token = "0x600334F")]
			[Address(RVA = "0x40976AC", Offset = "0x40936AC", VA = "0x40976AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006E6")]
		public RectTransform RectTransformLockBg
		{
			[Token(Token = "0x6003350")]
			[Address(RVA = "0x40965B0", Offset = "0x40925B0", VA = "0x40965B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006E7")]
		public Image ImageLockBg
		{
			[Token(Token = "0x6003351")]
			[Address(RVA = "0x4097C30", Offset = "0x4093C30", VA = "0x4097C30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006E8")]
		public RectTransform RectTransformLock
		{
			[Token(Token = "0x6003352")]
			[Address(RVA = "0x40964E8", Offset = "0x40924E8", VA = "0x40964E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006E9")]
		public RectTransform RectTransformBuy
		{
			[Token(Token = "0x6003353")]
			[Address(RVA = "0x4096740", Offset = "0x4092740", VA = "0x4096740")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006EA")]
		public ButtonExtend ButtonExtendBuy
		{
			[Token(Token = "0x6003354")]
			[Address(RVA = "0x40979CC", Offset = "0x40939CC", VA = "0x40979CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006EB")]
		public TextMeshProUGUI TextMeshProUGUICost
		{
			[Token(Token = "0x6003355")]
			[Address(RVA = "0x4097A94", Offset = "0x4093A94", VA = "0x4097A94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006EC")]
		public RectTransform RectTransformHWIAPButton
		{
			[Token(Token = "0x6003356")]
			[Address(RVA = "0x4096808", Offset = "0x4092808", VA = "0x4096808")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006ED")]
		public HWIAPButton HWIAPButtonHWIAPButton
		{
			[Token(Token = "0x6003357")]
			[Address(RVA = "0x4097904", Offset = "0x4093904", VA = "0x4097904")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006EE")]
		public ButtonExtend ButtonExtendHWIAPButton
		{
			[Token(Token = "0x6003358")]
			[Address(RVA = "0x4097CF8", Offset = "0x4093CF8", VA = "0x4097CF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006EF")]
		public RectTransform RectTransformHasBuy
		{
			[Token(Token = "0x6003359")]
			[Address(RVA = "0x4096678", Offset = "0x4092678", VA = "0x4096678")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600335A")]
		[Address(RVA = "0x4097DC0", Offset = "0x4093DC0", VA = "0x4097DC0")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x600335B")]
		[Address(RVA = "0x4096AD8", Offset = "0x4092AD8", VA = "0x4096AD8", Slot = "12")]
		protected virtual void OnButtonExtendBuyClicked()
		{
		}

		[Token(Token = "0x600335C")]
		[Address(RVA = "0x4097E94", Offset = "0x4093E94", VA = "0x4097E94", Slot = "13")]
		protected virtual void OnButtonExtendHWIAPButtonClicked()
		{
		}

		[Token(Token = "0x600335D")]
		[Address(RVA = "0x4097F00", Offset = "0x4093F00", VA = "0x4097F00", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600335E")]
		[Address(RVA = "0x4096BE8", Offset = "0x4092BE8", VA = "0x4096BE8", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__169))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x600335F")]
		[Address(RVA = "0x4097F1C", Offset = "0x4093F1C", VA = "0x4097F1C", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6003360")]
		[Address(RVA = "0x4096BDC", Offset = "0x4092BDC", VA = "0x4096BDC")]
		public GiftChainItemComponents()
		{
		}
	}
}
