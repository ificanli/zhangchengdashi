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
	[Token(Token = "0x200085B")]
	public class DailyBlessPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200085C")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__154 : IAsyncStateMachine
		{
			[Token(Token = "0x4003F79")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003F7A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003F7B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public DailyBlessPanelComponents _003C_003E4__this;

			[Token(Token = "0x4003F7C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6002F08")]
			[Address(RVA = "0x402A1A8", Offset = "0x40261A8", VA = "0x402A1A8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002F09")]
			[Address(RVA = "0x402A420", Offset = "0x4026420", VA = "0x402A420", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003F6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Image _imageBg;

		[Token(Token = "0x4003F6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ButtonExtend _buttonExtendBg;

		[Token(Token = "0x4003F6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RectTransform _rectTransformAllRoot;

		[Token(Token = "0x4003F70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private TextMeshProUGUI _textMeshProUGUITxtTitle;

		[Token(Token = "0x4003F71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TextMeshProUGUI _textMeshProUGUITxtTip;

		[Token(Token = "0x4003F72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private RectTransform _rectTransformRoot;

		[Token(Token = "0x4003F73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private AdButtonExtend _adButtonExtendHWVideoButton;

		[Token(Token = "0x4003F74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private TextMeshProUGUI _textMeshProUGUIText;

		[Token(Token = "0x4003F75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private TextMeshProUGUI _textMeshProUGUITxtNotNeed;

		[Token(Token = "0x4003F76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private RectTransform _rectTransformImgAnimationIcon;

		[Token(Token = "0x4003F77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Image _imageImgAnimationIcon;

		[Token(Token = "0x4003F78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private RectTransform _rectTransformRectTargetPos;

		[Token(Token = "0x17000579")]
		public Image ImageBg
		{
			[Token(Token = "0x6002EF4")]
			[Address(RVA = "0x4028DF4", Offset = "0x4024DF4", VA = "0x4028DF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700057A")]
		public ButtonExtend ButtonExtendBg
		{
			[Token(Token = "0x6002EF5")]
			[Address(RVA = "0x4029F98", Offset = "0x4025F98", VA = "0x4029F98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700057B")]
		public RectTransform RectTransformAllRoot
		{
			[Token(Token = "0x6002EF6")]
			[Address(RVA = "0x4028D2C", Offset = "0x4024D2C", VA = "0x4028D2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700057C")]
		public TextMeshProUGUI TextMeshProUGUITxtTitle
		{
			[Token(Token = "0x6002EF7")]
			[Address(RVA = "0x4029538", Offset = "0x4025538", VA = "0x4029538")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700057D")]
		public TextMeshProUGUI TextMeshProUGUITxtTip
		{
			[Token(Token = "0x6002EF8")]
			[Address(RVA = "0x4029600", Offset = "0x4025600", VA = "0x4029600")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700057E")]
		public RectTransform RectTransformRoot
		{
			[Token(Token = "0x6002EF9")]
			[Address(RVA = "0x4029EC4", Offset = "0x4025EC4", VA = "0x4029EC4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700057F")]
		public AdButtonExtend AdButtonExtendHWVideoButton
		{
			[Token(Token = "0x6002EFA")]
			[Address(RVA = "0x4027FE0", Offset = "0x4023FE0", VA = "0x4027FE0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000580")]
		public TextMeshProUGUI TextMeshProUGUIText
		{
			[Token(Token = "0x6002EFB")]
			[Address(RVA = "0x40296C8", Offset = "0x40256C8", VA = "0x40296C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000581")]
		public TextMeshProUGUI TextMeshProUGUITxtNotNeed
		{
			[Token(Token = "0x6002EFC")]
			[Address(RVA = "0x4029790", Offset = "0x4025790", VA = "0x4029790")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000582")]
		public RectTransform RectTransformImgAnimationIcon
		{
			[Token(Token = "0x6002EFD")]
			[Address(RVA = "0x4027A78", Offset = "0x4023A78", VA = "0x4027A78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000583")]
		public Image ImageImgAnimationIcon
		{
			[Token(Token = "0x6002EFE")]
			[Address(RVA = "0x40279B0", Offset = "0x40239B0", VA = "0x40279B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000584")]
		public RectTransform RectTransformRectTargetPos
		{
			[Token(Token = "0x6002EFF")]
			[Address(RVA = "0x4028C64", Offset = "0x4024C64", VA = "0x4028C64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002F00")]
		[Address(RVA = "0x402A060", Offset = "0x4026060", VA = "0x402A060")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6002F01")]
		[Address(RVA = "0x4027670", Offset = "0x4023670", VA = "0x4027670", Slot = "12")]
		protected virtual void OnButtonExtendBgClicked()
		{
		}

		[Token(Token = "0x6002F02")]
		[Address(RVA = "0x402A134", Offset = "0x4026134", VA = "0x402A134", Slot = "13")]
		protected virtual void OnAdButtonExtendHWVideoButtonClicked()
		{
		}

		[Token(Token = "0x6002F03")]
		[Address(RVA = "0x40278A8", Offset = "0x40238A8", VA = "0x40278A8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002F04")]
		[Address(RVA = "0x40278C8", Offset = "0x40238C8", VA = "0x40278C8", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__154))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002F05")]
		[Address(RVA = "0x4027738", Offset = "0x4023738", VA = "0x4027738", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6002F06")]
		[Address(RVA = "0x4027884", Offset = "0x4023884", VA = "0x4027884")]
		public DailyBlessPanelComponents()
		{
		}
	}
}
