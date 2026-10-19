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
	[Token(Token = "0x20008E0")]
	public class GiftBtnComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20008E1")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__147 : IAsyncStateMachine
		{
			[Token(Token = "0x4004337")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004338")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004339")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GiftBtnComponents _003C_003E4__this;

			[Token(Token = "0x400433A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6003317")]
			[Address(RVA = "0x40932C0", Offset = "0x408F2C0", VA = "0x40932C0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003318")]
			[Address(RVA = "0x4093538", Offset = "0x408F538", VA = "0x4093538", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400432C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ButtonExtend _buttonExtendGiftBtn;

		[Token(Token = "0x400432D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RectTransform _rectTransformIconBG;

		[Token(Token = "0x400432E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Image _imageIconBG;

		[Token(Token = "0x400432F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private RectTransform _rectTransformIcon;

		[Token(Token = "0x4004330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Image _imageIcon;

		[Token(Token = "0x4004331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private SkeletonGraphic _skeletonGraphicSpineEff;

		[Token(Token = "0x4004332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RectTransform _rectTransformNameBg;

		[Token(Token = "0x4004333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private TextMeshProUGUI _textMeshProUGUIName;

		[Token(Token = "0x4004334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private RectTransform _rectTransformCutDowmBG;

		[Token(Token = "0x4004335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private TextMeshProUGUI _textMeshProUGUICutDowmText;

		[Token(Token = "0x4004336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private RectTransform _rectTransformRedDot_UI;

		[Token(Token = "0x170006C2")]
		public ButtonExtend ButtonExtendGiftBtn
		{
			[Token(Token = "0x6003305")]
			[Address(RVA = "0x4092E14", Offset = "0x408EE14", VA = "0x4092E14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006C3")]
		public RectTransform RectTransformIconBG
		{
			[Token(Token = "0x6003306")]
			[Address(RVA = "0x4092EB8", Offset = "0x408EEB8", VA = "0x4092EB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006C4")]
		public Image ImageIconBG
		{
			[Token(Token = "0x6003307")]
			[Address(RVA = "0x4092388", Offset = "0x408E388", VA = "0x4092388")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006C5")]
		public RectTransform RectTransformIcon
		{
			[Token(Token = "0x6003308")]
			[Address(RVA = "0x4092F80", Offset = "0x408EF80", VA = "0x4092F80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006C6")]
		public Image ImageIcon
		{
			[Token(Token = "0x6003309")]
			[Address(RVA = "0x4092940", Offset = "0x408E940", VA = "0x4092940")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006C7")]
		public SkeletonGraphic SkeletonGraphicSpineEff
		{
			[Token(Token = "0x600330A")]
			[Address(RVA = "0x4092D40", Offset = "0x408ED40", VA = "0x4092D40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006C8")]
		public RectTransform RectTransformNameBg
		{
			[Token(Token = "0x600330B")]
			[Address(RVA = "0x40921FC", Offset = "0x408E1FC", VA = "0x40921FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006C9")]
		public TextMeshProUGUI TextMeshProUGUIName
		{
			[Token(Token = "0x600330C")]
			[Address(RVA = "0x4092134", Offset = "0x408E134", VA = "0x4092134")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006CA")]
		public RectTransform RectTransformCutDowmBG
		{
			[Token(Token = "0x600330D")]
			[Address(RVA = "0x4091EEC", Offset = "0x408DEEC", VA = "0x4091EEC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006CB")]
		public TextMeshProUGUI TextMeshProUGUICutDowmText
		{
			[Token(Token = "0x600330E")]
			[Address(RVA = "0x409256C", Offset = "0x408E56C", VA = "0x409256C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006CC")]
		public RectTransform RectTransformRedDot_UI
		{
			[Token(Token = "0x600330F")]
			[Address(RVA = "0x4093048", Offset = "0x408F048", VA = "0x4093048")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003310")]
		[Address(RVA = "0x4093110", Offset = "0x408F110", VA = "0x4093110")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6003311")]
		[Address(RVA = "0x4093198", Offset = "0x408F198", VA = "0x4093198", Slot = "12")]
		protected virtual void OnButtonExtendGiftBtnClicked()
		{
		}

		[Token(Token = "0x6003312")]
		[Address(RVA = "0x4091FD8", Offset = "0x408DFD8", VA = "0x4091FD8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6003313")]
		[Address(RVA = "0x4092020", Offset = "0x408E020", VA = "0x4092020", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__147))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6003314")]
		[Address(RVA = "0x4093204", Offset = "0x408F204", VA = "0x4093204", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6003315")]
		[Address(RVA = "0x409263C", Offset = "0x408E63C", VA = "0x409263C")]
		public GiftBtnComponents()
		{
		}
	}
}
