using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using TMPro;
using UIFramework;
using UIModuleO.UIAnim;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x20008E4")]
	public class GiftChainItem2Components : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20008E5")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__211 : IAsyncStateMachine
		{
			[Token(Token = "0x4004358")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004359")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400435A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GiftChainItem2Components _003C_003E4__this;

			[Token(Token = "0x400435B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x600333F")]
			[Address(RVA = "0x4095D44", Offset = "0x4091D44", VA = "0x4095D44", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003340")]
			[Address(RVA = "0x4095FBC", Offset = "0x4091FBC", VA = "0x4095FBC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TextMeshProUGUI _textMeshProUGUIName;

		[Token(Token = "0x4004345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private CanvasGroup _canvasGroupFirstMask;

		[Token(Token = "0x4004346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TextMeshProUGUI _textMeshProUGUIFirstName;

		[Token(Token = "0x4004347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private RectTransform _rectTransformRewardItemUI;

		[Token(Token = "0x4004348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private RewardItemUI _rewardItemUIRewardItemUI;

		[Token(Token = "0x4004349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private RectTransform _rectTransformImgUnKnow;

		[Token(Token = "0x400434A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RectTransform _rectTransformLockBg;

		[Token(Token = "0x400434B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Image _imageLockBg;

		[Token(Token = "0x400434C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private RectTransform _rectTransformLock;

		[Token(Token = "0x400434D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private RectTransform _rectTransformBuy;

		[Token(Token = "0x400434E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private ButtonExtend _buttonExtendBuy;

		[Token(Token = "0x400434F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private DOTweenAnimation _dOTweenAnimationBuy;

		[Token(Token = "0x4004350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private TextMeshProUGUI _textMeshProUGUICost;

		[Token(Token = "0x4004351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private RectTransform _rectTransformHWIAPButton;

		[Token(Token = "0x4004352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private HWIAPButton _hWIAPButtonHWIAPButton;

		[Token(Token = "0x4004353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private ButtonExtend _buttonExtendHWIAPButton;

		[Token(Token = "0x4004354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private DOTweenAnimation _dOTweenAnimationHWIAPButton;

		[Token(Token = "0x4004355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private RectTransform _rectTransformHasBuy;

		[Token(Token = "0x4004356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Image _imageHasBuy;

		[Token(Token = "0x4004357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private RectTransform _rectTransformRedDot_UI;

		[Token(Token = "0x170006CD")]
		public TextMeshProUGUI TextMeshProUGUIName
		{
			[Token(Token = "0x6003323")]
			[Address(RVA = "0x4093CB0", Offset = "0x408FCB0", VA = "0x4093CB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006CE")]
		public CanvasGroup CanvasGroupFirstMask
		{
			[Token(Token = "0x6003324")]
			[Address(RVA = "0x40950A4", Offset = "0x40910A4", VA = "0x40950A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006CF")]
		public TextMeshProUGUI TextMeshProUGUIFirstName
		{
			[Token(Token = "0x6003325")]
			[Address(RVA = "0x4093BE8", Offset = "0x408FBE8", VA = "0x4093BE8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006D0")]
		public RectTransform RectTransformRewardItemUI
		{
			[Token(Token = "0x6003326")]
			[Address(RVA = "0x4094F14", Offset = "0x4090F14", VA = "0x4094F14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006D1")]
		public RewardItemUI RewardItemUIRewardItemUI
		{
			[Token(Token = "0x6003327")]
			[Address(RVA = "0x4093B20", Offset = "0x408FB20", VA = "0x4093B20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006D2")]
		public RectTransform RectTransformImgUnKnow
		{
			[Token(Token = "0x6003328")]
			[Address(RVA = "0x4094FDC", Offset = "0x4090FDC", VA = "0x4094FDC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006D3")]
		public RectTransform RectTransformLockBg
		{
			[Token(Token = "0x6003329")]
			[Address(RVA = "0x4094BF4", Offset = "0x4090BF4", VA = "0x4094BF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006D4")]
		public Image ImageLockBg
		{
			[Token(Token = "0x600332A")]
			[Address(RVA = "0x40959B8", Offset = "0x40919B8", VA = "0x40959B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006D5")]
		public RectTransform RectTransformLock
		{
			[Token(Token = "0x600332B")]
			[Address(RVA = "0x4094B2C", Offset = "0x4090B2C", VA = "0x4094B2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006D6")]
		public RectTransform RectTransformBuy
		{
			[Token(Token = "0x600332C")]
			[Address(RVA = "0x4094D84", Offset = "0x4090D84", VA = "0x4094D84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006D7")]
		public ButtonExtend ButtonExtendBuy
		{
			[Token(Token = "0x600332D")]
			[Address(RVA = "0x4093E40", Offset = "0x408FE40", VA = "0x4093E40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006D8")]
		public DOTweenAnimation DOTweenAnimationBuy
		{
			[Token(Token = "0x600332E")]
			[Address(RVA = "0x4095234", Offset = "0x4091234", VA = "0x4095234")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006D9")]
		public TextMeshProUGUI TextMeshProUGUICost
		{
			[Token(Token = "0x600332F")]
			[Address(RVA = "0x4093F08", Offset = "0x408FF08", VA = "0x4093F08")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006DA")]
		public RectTransform RectTransformHWIAPButton
		{
			[Token(Token = "0x6003330")]
			[Address(RVA = "0x4094E4C", Offset = "0x4090E4C", VA = "0x4094E4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006DB")]
		public HWIAPButton HWIAPButtonHWIAPButton
		{
			[Token(Token = "0x6003331")]
			[Address(RVA = "0x4093D78", Offset = "0x408FD78", VA = "0x4093D78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006DC")]
		public ButtonExtend ButtonExtendHWIAPButton
		{
			[Token(Token = "0x6003332")]
			[Address(RVA = "0x4095A80", Offset = "0x4091A80", VA = "0x4095A80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006DD")]
		public DOTweenAnimation DOTweenAnimationHWIAPButton
		{
			[Token(Token = "0x6003333")]
			[Address(RVA = "0x409516C", Offset = "0x409116C", VA = "0x409516C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006DE")]
		public RectTransform RectTransformHasBuy
		{
			[Token(Token = "0x6003334")]
			[Address(RVA = "0x4094CBC", Offset = "0x4090CBC", VA = "0x4094CBC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006DF")]
		public Image ImageHasBuy
		{
			[Token(Token = "0x6003335")]
			[Address(RVA = "0x40952FC", Offset = "0x40912FC", VA = "0x40952FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006E0")]
		public RectTransform RectTransformRedDot_UI
		{
			[Token(Token = "0x6003336")]
			[Address(RVA = "0x4094A64", Offset = "0x4090A64", VA = "0x4094A64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003337")]
		[Address(RVA = "0x4095B48", Offset = "0x4091B48", VA = "0x4095B48")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6003338")]
		[Address(RVA = "0x409547C", Offset = "0x409147C", VA = "0x409547C", Slot = "12")]
		protected virtual void OnButtonExtendBuyClicked()
		{
		}

		[Token(Token = "0x6003339")]
		[Address(RVA = "0x4095C1C", Offset = "0x4091C1C", VA = "0x4095C1C", Slot = "13")]
		protected virtual void OnButtonExtendHWIAPButtonClicked()
		{
		}

		[Token(Token = "0x600333A")]
		[Address(RVA = "0x4093620", Offset = "0x408F620", VA = "0x4093620", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600333B")]
		[Address(RVA = "0x4095544", Offset = "0x4091544", VA = "0x4095544", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__211))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x600333C")]
		[Address(RVA = "0x4095C88", Offset = "0x4091C88", VA = "0x4095C88", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x600333D")]
		[Address(RVA = "0x4095538", Offset = "0x4091538", VA = "0x4095538")]
		public GiftChainItem2Components()
		{
		}
	}
}
