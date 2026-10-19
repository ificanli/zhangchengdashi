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
	[Token(Token = "0x2000AE8")]
	public class RewardItemUIComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000AE9")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__201 : IAsyncStateMachine
		{
			[Token(Token = "0x4005001")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005002")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005003")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public RewardItemUIComponents _003C_003E4__this;

			[Token(Token = "0x4005004")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60041F5")]
			[Address(RVA = "0x41C4590", Offset = "0x41C0590", VA = "0x41C4590", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60041F6")]
			[Address(RVA = "0x41C4808", Offset = "0x41C0808", VA = "0x41C4808", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004FED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RectTransform _rectTransformRewardItemUI;

		[Token(Token = "0x4004FEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RectTransform _rectTransformBack;

		[Token(Token = "0x4004FEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Image _imageBack;

		[Token(Token = "0x4004FF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private RectTransform _rectTransformImgMask;

		[Token(Token = "0x4004FF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Image _imageImgMask;

		[Token(Token = "0x4004FF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Mask _maskImgMask;

		[Token(Token = "0x4004FF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RectTransform _rectTransformIcon;

		[Token(Token = "0x4004FF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Image _imageIcon;

		[Token(Token = "0x4004FF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private SkeletonGraphic _skeletonGraphicCardSpine;

		[Token(Token = "0x4004FF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Image _imageImgProcessBG;

		[Token(Token = "0x4004FF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Image _imageImgProcess;

		[Token(Token = "0x4004FF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private TextMeshProUGUI _textMeshProUGUITxtCardCount;

		[Token(Token = "0x4004FF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private TextMeshProUGUI _textMeshProUGUICount;

		[Token(Token = "0x4004FFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Image _imageImgTypeBg;

		[Token(Token = "0x4004FFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private RectTransform _rectTransformImgTypeIcon;

		[Token(Token = "0x4004FFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Image _imageImgTypeIcon;

		[Token(Token = "0x4004FFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private RectTransform _rectTransformName;

		[Token(Token = "0x4004FFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private TextMeshProUGUI _textMeshProUGUIName;

		[Token(Token = "0x4004FFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Image _imageRedDot_UI;

		[Token(Token = "0x4005000")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private ButtonExtend _buttonExtendShowDes;

		[Token(Token = "0x17000A6C")]
		public RectTransform RectTransformRewardItemUI
		{
			[Token(Token = "0x60041DA")]
			[Address(RVA = "0x41BECF8", Offset = "0x41BACF8", VA = "0x41BECF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A6D")]
		public RectTransform RectTransformBack
		{
			[Token(Token = "0x60041DB")]
			[Address(RVA = "0x41BEC30", Offset = "0x41BAC30", VA = "0x41BEC30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A6E")]
		public Image ImageBack
		{
			[Token(Token = "0x60041DC")]
			[Address(RVA = "0x41BFBFC", Offset = "0x41BBBFC", VA = "0x41BFBFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A6F")]
		public RectTransform RectTransformImgMask
		{
			[Token(Token = "0x60041DD")]
			[Address(RVA = "0x41BF080", Offset = "0x41BB080", VA = "0x41BF080")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A70")]
		public Image ImageImgMask
		{
			[Token(Token = "0x60041DE")]
			[Address(RVA = "0x41BFCC4", Offset = "0x41BBCC4", VA = "0x41BFCC4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A71")]
		public Mask MaskImgMask
		{
			[Token(Token = "0x60041DF")]
			[Address(RVA = "0x41BFD8C", Offset = "0x41BBD8C", VA = "0x41BFD8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A72")]
		public RectTransform RectTransformIcon
		{
			[Token(Token = "0x60041E0")]
			[Address(RVA = "0x41BEFB8", Offset = "0x41BAFB8", VA = "0x41BEFB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A73")]
		public Image ImageIcon
		{
			[Token(Token = "0x60041E1")]
			[Address(RVA = "0x41C1F40", Offset = "0x41BDF40", VA = "0x41C1F40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A74")]
		public SkeletonGraphic SkeletonGraphicCardSpine
		{
			[Token(Token = "0x60041E2")]
			[Address(RVA = "0x41C2008", Offset = "0x41BE008", VA = "0x41C2008")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A75")]
		public Image ImageImgProcessBG
		{
			[Token(Token = "0x60041E3")]
			[Address(RVA = "0x41BFE54", Offset = "0x41BBE54", VA = "0x41BFE54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A76")]
		public Image ImageImgProcess
		{
			[Token(Token = "0x60041E4")]
			[Address(RVA = "0x41C0150", Offset = "0x41BC150", VA = "0x41C0150")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A77")]
		public TextMeshProUGUI TextMeshProUGUITxtCardCount
		{
			[Token(Token = "0x60041E5")]
			[Address(RVA = "0x41C0088", Offset = "0x41BC088", VA = "0x41C0088")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A78")]
		public TextMeshProUGUI TextMeshProUGUICount
		{
			[Token(Token = "0x60041E6")]
			[Address(RVA = "0x41BFB34", Offset = "0x41BBB34", VA = "0x41BFB34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A79")]
		public Image ImageImgTypeBg
		{
			[Token(Token = "0x60041E7")]
			[Address(RVA = "0x41C02E0", Offset = "0x41BC2E0", VA = "0x41C02E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A7A")]
		public RectTransform RectTransformImgTypeIcon
		{
			[Token(Token = "0x60041E8")]
			[Address(RVA = "0x41BEEF0", Offset = "0x41BAEF0", VA = "0x41BEEF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A7B")]
		public Image ImageImgTypeIcon
		{
			[Token(Token = "0x60041E9")]
			[Address(RVA = "0x41C0218", Offset = "0x41BC218", VA = "0x41C0218")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A7C")]
		public RectTransform RectTransformName
		{
			[Token(Token = "0x60041EA")]
			[Address(RVA = "0x41BF9E8", Offset = "0x41BB9E8", VA = "0x41BF9E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A7D")]
		public TextMeshProUGUI TextMeshProUGUIName
		{
			[Token(Token = "0x60041EB")]
			[Address(RVA = "0x41C3A90", Offset = "0x41BFA90", VA = "0x41C3A90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A7E")]
		public Image ImageRedDot_UI
		{
			[Token(Token = "0x60041EC")]
			[Address(RVA = "0x41BF3D8", Offset = "0x41BB3D8", VA = "0x41BF3D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A7F")]
		public ButtonExtend ButtonExtendShowDes
		{
			[Token(Token = "0x60041ED")]
			[Address(RVA = "0x41C24E0", Offset = "0x41BE4E0", VA = "0x41C24E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60041EE")]
		[Address(RVA = "0x41C43B8", Offset = "0x41C03B8", VA = "0x41C43B8")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x60041EF")]
		[Address(RVA = "0x41C2D68", Offset = "0x41BED68", VA = "0x41C2D68", Slot = "12")]
		protected virtual void OnButtonExtendShowDesClicked()
		{
		}

		[Token(Token = "0x60041F0")]
		[Address(RVA = "0x41BEAD8", Offset = "0x41BAAD8", VA = "0x41BEAD8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60041F1")]
		[Address(RVA = "0x41C4440", Offset = "0x41C0440", VA = "0x41C4440", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__201))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60041F2")]
		[Address(RVA = "0x41C44D4", Offset = "0x41C04D4", VA = "0x41C44D4", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60041F3")]
		[Address(RVA = "0x41C2DFC", Offset = "0x41BEDFC", VA = "0x41C2DFC")]
		public RewardItemUIComponents()
		{
		}
	}
}
