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
	[Token(Token = "0x20006D5")]
	public class ArtifactEntryRefreshPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20006D6")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__348 : IAsyncStateMachine
		{
			[Token(Token = "0x40036BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40036BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40036BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ArtifactEntryRefreshPanelComponents _003C_003E4__this;

			[Token(Token = "0x40036BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60024C2")]
			[Address(RVA = "0x3F60BF0", Offset = "0x3F5CBF0", VA = "0x3F60BF0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60024C3")]
			[Address(RVA = "0x3F60E68", Offset = "0x3F5CE68", VA = "0x3F60E68", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40036AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Button _buttonBackground;

		[Token(Token = "0x40036AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Image _imageImgBg;

		[Token(Token = "0x40036AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private ButtonExtend _buttonExtendBtnClose;

		[Token(Token = "0x40036AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Image _imagePossessIcon;

		[Token(Token = "0x40036AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TextMeshProUGUI _textMeshProUGUIPossessIconDes;

		[Token(Token = "0x40036AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private ButtonExtend _buttonExtendKeep;

		[Token(Token = "0x40036B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Image _imageKeepPitchon;

		[Token(Token = "0x40036B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private ButtonExtend _buttonExtendBotEntry;

		[Token(Token = "0x40036B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Image _imageImgBotUnchartBg;

		[Token(Token = "0x40036B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Image _imageBotEntryPitchon;

		[Token(Token = "0x40036B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private RectTransform _rectTransformImgBotEntryIcon;

		[Token(Token = "0x40036B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Image _imageImgBotEntryIcon;

		[Token(Token = "0x40036B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private RectTransform _rectTransformTxtBotEntryDes;

		[Token(Token = "0x40036B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private TextMeshProUGUI _textMeshProUGUITxtBotEntryDes;

		[Token(Token = "0x40036B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private SkeletonGraphic _skeletonGraphicSkeletonGraphic;

		[Token(Token = "0x40036B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private ButtonExtend _buttonExtendBtnForging;

		[Token(Token = "0x40036BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private ButtonExtend _buttonExtendBtnReplace;

		[Token(Token = "0x40036BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private ButtonExtend _buttonExtendIntroduce;

		[Token(Token = "0x1700027A")]
		public Button ButtonBackground
		{
			[Token(Token = "0x60024A3")]
			[Address(RVA = "0x3F60510", Offset = "0x3F5C510", VA = "0x3F60510")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700027B")]
		public Image ImageImgBg
		{
			[Token(Token = "0x60024A4")]
			[Address(RVA = "0x3F5B328", Offset = "0x3F57328", VA = "0x3F5B328")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700027C")]
		public ButtonExtend ButtonExtendBtnClose
		{
			[Token(Token = "0x60024A5")]
			[Address(RVA = "0x3F605D8", Offset = "0x3F5C5D8", VA = "0x3F605D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700027D")]
		public Image ImagePossessIcon
		{
			[Token(Token = "0x60024A6")]
			[Address(RVA = "0x3F60374", Offset = "0x3F5C374", VA = "0x3F60374")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700027E")]
		public TextMeshProUGUI TextMeshProUGUIPossessIconDes
		{
			[Token(Token = "0x60024A7")]
			[Address(RVA = "0x3F602AC", Offset = "0x3F5C2AC", VA = "0x3F602AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700027F")]
		public ButtonExtend ButtonExtendKeep
		{
			[Token(Token = "0x60024A8")]
			[Address(RVA = "0x3F606A0", Offset = "0x3F5C6A0", VA = "0x3F606A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000280")]
		public Image ImageKeepPitchon
		{
			[Token(Token = "0x60024A9")]
			[Address(RVA = "0x3F5C1C0", Offset = "0x3F581C0", VA = "0x3F5C1C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000281")]
		public ButtonExtend ButtonExtendBotEntry
		{
			[Token(Token = "0x60024AA")]
			[Address(RVA = "0x3F60768", Offset = "0x3F5C768", VA = "0x3F60768")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000282")]
		public Image ImageImgBotUnchartBg
		{
			[Token(Token = "0x60024AB")]
			[Address(RVA = "0x3F5EAF8", Offset = "0x3F5AAF8", VA = "0x3F5EAF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000283")]
		public Image ImageBotEntryPitchon
		{
			[Token(Token = "0x60024AC")]
			[Address(RVA = "0x3F5C288", Offset = "0x3F58288", VA = "0x3F5C288")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000284")]
		public RectTransform RectTransformImgBotEntryIcon
		{
			[Token(Token = "0x60024AD")]
			[Address(RVA = "0x3F5C3A4", Offset = "0x3F583A4", VA = "0x3F5C3A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000285")]
		public Image ImageImgBotEntryIcon
		{
			[Token(Token = "0x60024AE")]
			[Address(RVA = "0x3F5C534", Offset = "0x3F58534", VA = "0x3F5C534")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000286")]
		public RectTransform RectTransformTxtBotEntryDes
		{
			[Token(Token = "0x60024AF")]
			[Address(RVA = "0x3F5C46C", Offset = "0x3F5846C", VA = "0x3F5C46C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000287")]
		public TextMeshProUGUI TextMeshProUGUITxtBotEntryDes
		{
			[Token(Token = "0x60024B0")]
			[Address(RVA = "0x3F5C5FC", Offset = "0x3F585FC", VA = "0x3F5C5FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000288")]
		public SkeletonGraphic SkeletonGraphicSkeletonGraphic
		{
			[Token(Token = "0x60024B1")]
			[Address(RVA = "0x3F5C85C", Offset = "0x3F5885C", VA = "0x3F5C85C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000289")]
		public ButtonExtend ButtonExtendBtnForging
		{
			[Token(Token = "0x60024B2")]
			[Address(RVA = "0x3F60830", Offset = "0x3F5C830", VA = "0x3F60830")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700028A")]
		public ButtonExtend ButtonExtendBtnReplace
		{
			[Token(Token = "0x60024B3")]
			[Address(RVA = "0x3F6043C", Offset = "0x3F5C43C", VA = "0x3F6043C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700028B")]
		public ButtonExtend ButtonExtendIntroduce
		{
			[Token(Token = "0x60024B4")]
			[Address(RVA = "0x3F608F8", Offset = "0x3F5C8F8", VA = "0x3F608F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60024B5")]
		[Address(RVA = "0x3F609C0", Offset = "0x3F5C9C0", VA = "0x3F609C0")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x60024B6")]
		[Address(RVA = "0x3F5CF4C", Offset = "0x3F58F4C", VA = "0x3F5CF4C", Slot = "12")]
		protected virtual void OnButtonBackgroundClicked()
		{
		}

		[Token(Token = "0x60024B7")]
		[Address(RVA = "0x3F5CEC0", Offset = "0x3F58EC0", VA = "0x3F5CEC0", Slot = "13")]
		protected virtual void OnButtonExtendBtnCloseClicked()
		{
		}

		[Token(Token = "0x60024B8")]
		[Address(RVA = "0x3F5BEF4", Offset = "0x3F57EF4", VA = "0x3F5BEF4", Slot = "14")]
		protected virtual void OnButtonExtendKeepClicked()
		{
		}

		[Token(Token = "0x60024B9")]
		[Address(RVA = "0x3F5C014", Offset = "0x3F58014", VA = "0x3F5C014", Slot = "15")]
		protected virtual void OnButtonExtendBotEntryClicked()
		{
		}

		[Token(Token = "0x60024BA")]
		[Address(RVA = "0x3F5BB74", Offset = "0x3F57B74", VA = "0x3F5BB74", Slot = "16")]
		protected virtual void OnButtonExtendBtnForgingClicked()
		{
		}

		[Token(Token = "0x60024BB")]
		[Address(RVA = "0x3F5BE3C", Offset = "0x3F57E3C", VA = "0x3F5BE3C", Slot = "17")]
		protected virtual void OnButtonExtendBtnReplaceClicked()
		{
		}

		[Token(Token = "0x60024BC")]
		[Address(RVA = "0x3F5D064", Offset = "0x3F59064", VA = "0x3F5D064", Slot = "18")]
		protected virtual void OnButtonExtendIntroduceClicked()
		{
		}

		[Token(Token = "0x60024BD")]
		[Address(RVA = "0x3F5B30C", Offset = "0x3F5730C", VA = "0x3F5B30C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60024BE")]
		[Address(RVA = "0x3F5CFCC", Offset = "0x3F58FCC", VA = "0x3F5CFCC", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__348))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60024BF")]
		[Address(RVA = "0x3F5B72C", Offset = "0x3F5772C", VA = "0x3F5B72C", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60024C0")]
		[Address(RVA = "0x3F5CFC0", Offset = "0x3F58FC0", VA = "0x3F5CFC0")]
		public ArtifactEntryRefreshPanelComponents()
		{
		}
	}
}
