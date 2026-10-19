using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using SDKModule;
using Spine.Unity;
using TMPro;
using UIFramework;
using UIModuleO.UIAnim;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000A7C")]
	public class BoxItemComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000A7D")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__310 : IAsyncStateMachine
		{
			[Token(Token = "0x4004D8D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004D8E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004D8F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BoxItemComponents _003C_003E4__this;

			[Token(Token = "0x4004D90")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6003F33")]
			[Address(RVA = "0x417A1B0", Offset = "0x41761B0", VA = "0x417A1B0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003F34")]
			[Address(RVA = "0x417A428", Offset = "0x4176428", VA = "0x417A428", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004D77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RectTransform _rectTransformBoxItem;

		[Token(Token = "0x4004D78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Image _imageBoxItem;

		[Token(Token = "0x4004D79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private ButtonExtend _buttonExtendBoxItem;

		[Token(Token = "0x4004D7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Image _imageBgSpine;

		[Token(Token = "0x4004D7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private SkeletonGraphic _skeletonGraphicBgBSpine;

		[Token(Token = "0x4004D7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private SkeletonGraphic _skeletonGraphicBox;

		[Token(Token = "0x4004D7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private TextMeshProUGUI _textMeshProUGUITxtArenaDes;

		[Token(Token = "0x4004D7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private TextMeshProUGUI _textMeshProUGUITxtUnlockTime;

		[Token(Token = "0x4004D7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private RectTransform _rectTransformImgTapToUnLockBG;

		[Token(Token = "0x4004D80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private TextMeshProUGUI _textMeshProUGUITxtTapToUnLock;

		[Token(Token = "0x4004D81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private RectTransform _rectTransformImgTapToUnOpenBG;

		[Token(Token = "0x4004D82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private RectTransform _rectTransformTxtOpenBox;

		[Token(Token = "0x4004D83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private TextMeshProUGUI _textMeshProUGUITxtOpenBox;

		[Token(Token = "0x4004D84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private RectTransform _rectTransformBtnDiamond;

		[Token(Token = "0x4004D85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Image _imageBtnDiamond;

		[Token(Token = "0x4004D86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private TextMeshProUGUI _textMeshProUGUITxtDiamondUnLock;

		[Token(Token = "0x4004D87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private TextMeshProUGUI _textMeshProUGUITxtOpeningOpen;

		[Token(Token = "0x4004D88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private RectTransform _rectTransformBtnAdRoot;

		[Token(Token = "0x4004D89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private AdButtonExtend _adButtonExtendBtnAd;

		[Token(Token = "0x4004D8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private RectTransform _rectTransformTxtAd;

		[Token(Token = "0x4004D8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private TextMeshProUGUI _textMeshProUGUITxtAd;

		[Token(Token = "0x4004D8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Image _imageAdIcon;

		[Token(Token = "0x170009A1")]
		public RectTransform RectTransformBoxItem
		{
			[Token(Token = "0x6003F15")]
			[Address(RVA = "0x41789D0", Offset = "0x41749D0", VA = "0x41789D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009A2")]
		public Image ImageBoxItem
		{
			[Token(Token = "0x6003F16")]
			[Address(RVA = "0x4177DF4", Offset = "0x4173DF4", VA = "0x4177DF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009A3")]
		public ButtonExtend ButtonExtendBoxItem
		{
			[Token(Token = "0x6003F17")]
			[Address(RVA = "0x4179E60", Offset = "0x4175E60", VA = "0x4179E60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009A4")]
		public Image ImageBgSpine
		{
			[Token(Token = "0x6003F18")]
			[Address(RVA = "0x4178CCC", Offset = "0x4174CCC", VA = "0x4178CCC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009A5")]
		public SkeletonGraphic SkeletonGraphicBgBSpine
		{
			[Token(Token = "0x6003F19")]
			[Address(RVA = "0x4175A2C", Offset = "0x4171A2C", VA = "0x4175A2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009A6")]
		public SkeletonGraphic SkeletonGraphicBox
		{
			[Token(Token = "0x6003F1A")]
			[Address(RVA = "0x4175894", Offset = "0x4171894", VA = "0x4175894")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009A7")]
		public TextMeshProUGUI TextMeshProUGUITxtArenaDes
		{
			[Token(Token = "0x6003F1B")]
			[Address(RVA = "0x4176580", Offset = "0x4172580", VA = "0x4176580")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009A8")]
		public TextMeshProUGUI TextMeshProUGUITxtUnlockTime
		{
			[Token(Token = "0x6003F1C")]
			[Address(RVA = "0x41760D0", Offset = "0x41720D0", VA = "0x41760D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009A9")]
		public RectTransform RectTransformImgTapToUnLockBG
		{
			[Token(Token = "0x6003F1D")]
			[Address(RVA = "0x4176198", Offset = "0x4172198", VA = "0x4176198")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009AA")]
		public TextMeshProUGUI TextMeshProUGUITxtTapToUnLock
		{
			[Token(Token = "0x6003F1E")]
			[Address(RVA = "0x4178A74", Offset = "0x4174A74", VA = "0x4178A74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009AB")]
		public RectTransform RectTransformImgTapToUnOpenBG
		{
			[Token(Token = "0x6003F1F")]
			[Address(RVA = "0x4176260", Offset = "0x4172260", VA = "0x4176260")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009AC")]
		public RectTransform RectTransformTxtOpenBox
		{
			[Token(Token = "0x6003F20")]
			[Address(RVA = "0x41763F0", Offset = "0x41723F0", VA = "0x41763F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009AD")]
		public TextMeshProUGUI TextMeshProUGUITxtOpenBox
		{
			[Token(Token = "0x6003F21")]
			[Address(RVA = "0x4178C04", Offset = "0x4174C04", VA = "0x4178C04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009AE")]
		public RectTransform RectTransformBtnDiamond
		{
			[Token(Token = "0x6003F22")]
			[Address(RVA = "0x41764B8", Offset = "0x41724B8", VA = "0x41764B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009AF")]
		public Image ImageBtnDiamond
		{
			[Token(Token = "0x6003F23")]
			[Address(RVA = "0x4179D8C", Offset = "0x4175D8C", VA = "0x4179D8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009B0")]
		public TextMeshProUGUI TextMeshProUGUITxtDiamondUnLock
		{
			[Token(Token = "0x6003F24")]
			[Address(RVA = "0x4176AF8", Offset = "0x4172AF8", VA = "0x4176AF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009B1")]
		public TextMeshProUGUI TextMeshProUGUITxtOpeningOpen
		{
			[Token(Token = "0x6003F25")]
			[Address(RVA = "0x4178B3C", Offset = "0x4174B3C", VA = "0x4178B3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009B2")]
		public RectTransform RectTransformBtnAdRoot
		{
			[Token(Token = "0x6003F26")]
			[Address(RVA = "0x4176328", Offset = "0x4172328", VA = "0x4176328")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009B3")]
		public AdButtonExtend AdButtonExtendBtnAd
		{
			[Token(Token = "0x6003F27")]
			[Address(RVA = "0x417754C", Offset = "0x417354C", VA = "0x417754C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009B4")]
		public RectTransform RectTransformTxtAd
		{
			[Token(Token = "0x6003F28")]
			[Address(RVA = "0x41777A4", Offset = "0x41737A4", VA = "0x41777A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009B5")]
		public TextMeshProUGUI TextMeshProUGUITxtAd
		{
			[Token(Token = "0x6003F29")]
			[Address(RVA = "0x41776DC", Offset = "0x41736DC", VA = "0x41776DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009B6")]
		public Image ImageAdIcon
		{
			[Token(Token = "0x6003F2A")]
			[Address(RVA = "0x4177614", Offset = "0x4173614", VA = "0x4177614")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003F2B")]
		[Address(RVA = "0x4179F04", Offset = "0x4175F04", VA = "0x4179F04")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6003F2C")]
		[Address(RVA = "0x4176798", Offset = "0x4172798", VA = "0x4176798", Slot = "12")]
		protected virtual void OnButtonExtendBoxItemClicked()
		{
		}

		[Token(Token = "0x6003F2D")]
		[Address(RVA = "0x4179FD8", Offset = "0x4175FD8", VA = "0x4179FD8", Slot = "13")]
		protected virtual void OnAdButtonExtendBtnAdClicked()
		{
		}

		[Token(Token = "0x6003F2E")]
		[Address(RVA = "0x417A044", Offset = "0x4176044", VA = "0x417A044", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6003F2F")]
		[Address(RVA = "0x417A060", Offset = "0x4176060", VA = "0x417A060", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__310))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6003F30")]
		[Address(RVA = "0x417A0F4", Offset = "0x41760F4", VA = "0x417A0F4", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6003F31")]
		[Address(RVA = "0x417788C", Offset = "0x417388C", VA = "0x417788C")]
		public BoxItemComponents()
		{
		}
	}
}
