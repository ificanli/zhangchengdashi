using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using Spine.Unity;
using TMPro;
using UIFramework;
using UIModuleO.UIAnim;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x20007D9")]
	public class ChestSlotsViewComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20007DA")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__582 : IAsyncStateMachine
		{
			[Token(Token = "0x4003C9E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003C9F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003CA0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ChestSlotsViewComponents _003C_003E4__this;

			[Token(Token = "0x4003CA1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6002BBF")]
			[Address(RVA = "0x3FF11E4", Offset = "0x3FED1E4", VA = "0x3FF11E4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002BC0")]
			[Address(RVA = "0x3FF145C", Offset = "0x3FED45C", VA = "0x3FF145C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003C7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ButtonExtend _buttonExtendBtnClose;

		[Token(Token = "0x4003C7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RectTransform _rectTransformImgBoxBg1;

		[Token(Token = "0x4003C7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Image _imageImgBoxBg1;

		[Token(Token = "0x4003C7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ButtonExtend _buttonExtendImgBoxBg1;

		[Token(Token = "0x4003C7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Image _imageImgSpine1;

		[Token(Token = "0x4003C7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private SkeletonGraphic _skeletonGraphicSpine1B;

		[Token(Token = "0x4003C80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RectTransform _rectTransformTxtEmpty;

		[Token(Token = "0x4003C81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private TextMeshProUGUI _textMeshProUGUITxtEmpty;

		[Token(Token = "0x4003C82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private RectTransform _rectTransformImgBoxBg2;

		[Token(Token = "0x4003C83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Image _imageImgBoxBg2;

		[Token(Token = "0x4003C84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private ButtonExtend _buttonExtendImgBoxBg2;

		[Token(Token = "0x4003C85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Image _imageImgSpine2;

		[Token(Token = "0x4003C86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private SkeletonGraphic _skeletonGraphicSpine2B;

		[Token(Token = "0x4003C87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private RectTransform _rectTransformTxtEmpty1;

		[Token(Token = "0x4003C88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private TextMeshProUGUI _textMeshProUGUITxtEmpty1;

		[Token(Token = "0x4003C89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Image _imageImgLock2;

		[Token(Token = "0x4003C8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private RectTransform _rectTransformImgBoxBg3;

		[Token(Token = "0x4003C8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Image _imageImgBoxBg3;

		[Token(Token = "0x4003C8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private ButtonExtend _buttonExtendImgBoxBg3;

		[Token(Token = "0x4003C8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Image _imageImgSpine3;

		[Token(Token = "0x4003C8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private SkeletonGraphic _skeletonGraphicSpine3B;

		[Token(Token = "0x4003C8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private RectTransform _rectTransformTxtEmpty2;

		[Token(Token = "0x4003C90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private TextMeshProUGUI _textMeshProUGUITxtEmpty2;

		[Token(Token = "0x4003C91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Image _imageImgLock3;

		[Token(Token = "0x4003C92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Image _imageBtnBuyBoxSlot3;

		[Token(Token = "0x4003C93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private ButtonExtend _buttonExtendBtnBuyBoxSlot3;

		[Token(Token = "0x4003C94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private RectTransform _rectTransformImgBoxBg4;

		[Token(Token = "0x4003C95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Image _imageImgBoxBg4;

		[Token(Token = "0x4003C96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private ButtonExtend _buttonExtendImgBoxBg4;

		[Token(Token = "0x4003C97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Image _imageImgSpine4;

		[Token(Token = "0x4003C98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private SkeletonGraphic _skeletonGraphicSpine4B;

		[Token(Token = "0x4003C99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private RectTransform _rectTransformTxtEmpty3;

		[Token(Token = "0x4003C9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private TextMeshProUGUI _textMeshProUGUITxtEmpty3;

		[Token(Token = "0x4003C9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Image _imageImgLock31;

		[Token(Token = "0x4003C9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Image _imageBtnBuyBoxSlot4;

		[Token(Token = "0x4003C9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private ButtonExtend _buttonExtendBtnBuyBoxSlot4;

		[Token(Token = "0x17000492")]
		public ButtonExtend ButtonExtendBtnClose
		{
			[Token(Token = "0x6002B8E")]
			[Address(RVA = "0x3FF0B8C", Offset = "0x3FECB8C", VA = "0x3FF0B8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000493")]
		public RectTransform RectTransformImgBoxBg1
		{
			[Token(Token = "0x6002B8F")]
			[Address(RVA = "0x3FF0860", Offset = "0x3FEC860", VA = "0x3FF0860")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000494")]
		public Image ImageImgBoxBg1
		{
			[Token(Token = "0x6002B90")]
			[Address(RVA = "0x3FEE7F0", Offset = "0x3FEA7F0", VA = "0x3FEE7F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000495")]
		public ButtonExtend ButtonExtendImgBoxBg1
		{
			[Token(Token = "0x6002B91")]
			[Address(RVA = "0x3FEE8B8", Offset = "0x3FEA8B8", VA = "0x3FEE8B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000496")]
		public Image ImageImgSpine1
		{
			[Token(Token = "0x6002B92")]
			[Address(RVA = "0x3FEDC14", Offset = "0x3FE9C14", VA = "0x3FEDC14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000497")]
		public SkeletonGraphic SkeletonGraphicSpine1B
		{
			[Token(Token = "0x6002B93")]
			[Address(RVA = "0x3FEE3E4", Offset = "0x3FEA3E4", VA = "0x3FEE3E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000498")]
		public RectTransform RectTransformTxtEmpty
		{
			[Token(Token = "0x6002B94")]
			[Address(RVA = "0x3FEDB4C", Offset = "0x3FE9B4C", VA = "0x3FEDB4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000499")]
		public TextMeshProUGUI TextMeshProUGUITxtEmpty
		{
			[Token(Token = "0x6002B95")]
			[Address(RVA = "0x3FEDA84", Offset = "0x3FE9A84", VA = "0x3FEDA84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700049A")]
		public RectTransform RectTransformImgBoxBg2
		{
			[Token(Token = "0x6002B96")]
			[Address(RVA = "0x3FF0928", Offset = "0x3FEC928", VA = "0x3FF0928")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700049B")]
		public Image ImageImgBoxBg2
		{
			[Token(Token = "0x6002B97")]
			[Address(RVA = "0x3FEE980", Offset = "0x3FEA980", VA = "0x3FEE980")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700049C")]
		public ButtonExtend ButtonExtendImgBoxBg2
		{
			[Token(Token = "0x6002B98")]
			[Address(RVA = "0x3FEEA48", Offset = "0x3FEAA48", VA = "0x3FEEA48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700049D")]
		public Image ImageImgSpine2
		{
			[Token(Token = "0x6002B99")]
			[Address(RVA = "0x3FEDE6C", Offset = "0x3FE9E6C", VA = "0x3FEDE6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700049E")]
		public SkeletonGraphic SkeletonGraphicSpine2B
		{
			[Token(Token = "0x6002B9A")]
			[Address(RVA = "0x3FEE598", Offset = "0x3FEA598", VA = "0x3FEE598")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700049F")]
		public RectTransform RectTransformTxtEmpty1
		{
			[Token(Token = "0x6002B9B")]
			[Address(RVA = "0x3FEDDA4", Offset = "0x3FE9DA4", VA = "0x3FEDDA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004A0")]
		public TextMeshProUGUI TextMeshProUGUITxtEmpty1
		{
			[Token(Token = "0x6002B9C")]
			[Address(RVA = "0x3FEDCDC", Offset = "0x3FE9CDC", VA = "0x3FEDCDC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004A1")]
		public Image ImageImgLock2
		{
			[Token(Token = "0x6002B9D")]
			[Address(RVA = "0x3FEFAC8", Offset = "0x3FEBAC8", VA = "0x3FEFAC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004A2")]
		public RectTransform RectTransformImgBoxBg3
		{
			[Token(Token = "0x6002B9E")]
			[Address(RVA = "0x3FF09F0", Offset = "0x3FEC9F0", VA = "0x3FF09F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004A3")]
		public Image ImageImgBoxBg3
		{
			[Token(Token = "0x6002B9F")]
			[Address(RVA = "0x3FEEB10", Offset = "0x3FEAB10", VA = "0x3FEEB10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004A4")]
		public ButtonExtend ButtonExtendImgBoxBg3
		{
			[Token(Token = "0x6002BA0")]
			[Address(RVA = "0x3FEEBD8", Offset = "0x3FEABD8", VA = "0x3FEEBD8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004A5")]
		public Image ImageImgSpine3
		{
			[Token(Token = "0x6002BA1")]
			[Address(RVA = "0x3FEE0C4", Offset = "0x3FEA0C4", VA = "0x3FEE0C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004A6")]
		public SkeletonGraphic SkeletonGraphicSpine3B
		{
			[Token(Token = "0x6002BA2")]
			[Address(RVA = "0x3FEE660", Offset = "0x3FEA660", VA = "0x3FEE660")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004A7")]
		public RectTransform RectTransformTxtEmpty2
		{
			[Token(Token = "0x6002BA3")]
			[Address(RVA = "0x3FEDFFC", Offset = "0x3FE9FFC", VA = "0x3FEDFFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004A8")]
		public TextMeshProUGUI TextMeshProUGUITxtEmpty2
		{
			[Token(Token = "0x6002BA4")]
			[Address(RVA = "0x3FEDF34", Offset = "0x3FE9F34", VA = "0x3FEDF34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004A9")]
		public Image ImageImgLock3
		{
			[Token(Token = "0x6002BA5")]
			[Address(RVA = "0x3FEFB90", Offset = "0x3FEBB90", VA = "0x3FEFB90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004AA")]
		public Image ImageBtnBuyBoxSlot3
		{
			[Token(Token = "0x6002BA6")]
			[Address(RVA = "0x3FEFD20", Offset = "0x3FEBD20", VA = "0x3FEFD20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004AB")]
		public ButtonExtend ButtonExtendBtnBuyBoxSlot3
		{
			[Token(Token = "0x6002BA7")]
			[Address(RVA = "0x3FF0C54", Offset = "0x3FECC54", VA = "0x3FF0C54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004AC")]
		public RectTransform RectTransformImgBoxBg4
		{
			[Token(Token = "0x6002BA8")]
			[Address(RVA = "0x3FF0AB8", Offset = "0x3FECAB8", VA = "0x3FF0AB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004AD")]
		public Image ImageImgBoxBg4
		{
			[Token(Token = "0x6002BA9")]
			[Address(RVA = "0x3FEECA0", Offset = "0x3FEACA0", VA = "0x3FEECA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004AE")]
		public ButtonExtend ButtonExtendImgBoxBg4
		{
			[Token(Token = "0x6002BAA")]
			[Address(RVA = "0x3FEED68", Offset = "0x3FEAD68", VA = "0x3FEED68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004AF")]
		public Image ImageImgSpine4
		{
			[Token(Token = "0x6002BAB")]
			[Address(RVA = "0x3FEE31C", Offset = "0x3FEA31C", VA = "0x3FEE31C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004B0")]
		public SkeletonGraphic SkeletonGraphicSpine4B
		{
			[Token(Token = "0x6002BAC")]
			[Address(RVA = "0x3FEE728", Offset = "0x3FEA728", VA = "0x3FEE728")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004B1")]
		public RectTransform RectTransformTxtEmpty3
		{
			[Token(Token = "0x6002BAD")]
			[Address(RVA = "0x3FEE254", Offset = "0x3FEA254", VA = "0x3FEE254")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004B2")]
		public TextMeshProUGUI TextMeshProUGUITxtEmpty3
		{
			[Token(Token = "0x6002BAE")]
			[Address(RVA = "0x3FEE18C", Offset = "0x3FEA18C", VA = "0x3FEE18C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004B3")]
		public Image ImageImgLock31
		{
			[Token(Token = "0x6002BAF")]
			[Address(RVA = "0x3FEFC58", Offset = "0x3FEBC58", VA = "0x3FEFC58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004B4")]
		public Image ImageBtnBuyBoxSlot4
		{
			[Token(Token = "0x6002BB0")]
			[Address(RVA = "0x3FEFDE8", Offset = "0x3FEBDE8", VA = "0x3FEFDE8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004B5")]
		public ButtonExtend ButtonExtendBtnBuyBoxSlot4
		{
			[Token(Token = "0x6002BB1")]
			[Address(RVA = "0x3FF0D1C", Offset = "0x3FECD1C", VA = "0x3FF0D1C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002BB2")]
		[Address(RVA = "0x3FF0DE4", Offset = "0x3FECDE4", VA = "0x3FF0DE4")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6002BB3")]
		[Address(RVA = "0x3FF100C", Offset = "0x3FED00C", VA = "0x3FF100C", Slot = "12")]
		protected virtual void OnButtonExtendBtnCloseClicked()
		{
		}

		[Token(Token = "0x6002BB4")]
		[Address(RVA = "0x3FEEF8C", Offset = "0x3FEAF8C", VA = "0x3FEEF8C", Slot = "13")]
		protected virtual void OnButtonExtendImgBoxBg1Clicked()
		{
		}

		[Token(Token = "0x6002BB5")]
		[Address(RVA = "0x3FEF294", Offset = "0x3FEB294", VA = "0x3FEF294", Slot = "14")]
		protected virtual void OnButtonExtendImgBoxBg2Clicked()
		{
		}

		[Token(Token = "0x6002BB6")]
		[Address(RVA = "0x3FEF4DC", Offset = "0x3FEB4DC", VA = "0x3FEF4DC", Slot = "15")]
		protected virtual void OnButtonExtendImgBoxBg3Clicked()
		{
		}

		[Token(Token = "0x6002BB7")]
		[Address(RVA = "0x3FEF8C0", Offset = "0x3FEB8C0", VA = "0x3FEF8C0", Slot = "16")]
		protected virtual void OnButtonExtendBtnBuyBoxSlot3Clicked()
		{
		}

		[Token(Token = "0x6002BB8")]
		[Address(RVA = "0x3FEF724", Offset = "0x3FEB724", VA = "0x3FEF724", Slot = "17")]
		protected virtual void OnButtonExtendImgBoxBg4Clicked()
		{
		}

		[Token(Token = "0x6002BB9")]
		[Address(RVA = "0x3FEFA5C", Offset = "0x3FEBA5C", VA = "0x3FEFA5C", Slot = "18")]
		protected virtual void OnButtonExtendBtnBuyBoxSlot4Clicked()
		{
		}

		[Token(Token = "0x6002BBA")]
		[Address(RVA = "0x3FF1078", Offset = "0x3FED078", VA = "0x3FF1078", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002BBB")]
		[Address(RVA = "0x3FF1094", Offset = "0x3FED094", VA = "0x3FF1094", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__582))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002BBC")]
		[Address(RVA = "0x3FF1128", Offset = "0x3FED128", VA = "0x3FF1128", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6002BBD")]
		[Address(RVA = "0x3FEFF30", Offset = "0x3FEBF30", VA = "0x3FEFF30")]
		public ChestSlotsViewComponents()
		{
		}
	}
}
