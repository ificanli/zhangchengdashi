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
	[Token(Token = "0x2000C3D")]
	public class WeeklyGoldCardGiftPackPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000C3E")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__370 : IAsyncStateMachine
		{
			[Token(Token = "0x4005818")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005819")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400581A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public WeeklyGoldCardGiftPackPanelComponents _003C_003E4__this;

			[Token(Token = "0x400581B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6004BF1")]
			[Address(RVA = "0x4270FE0", Offset = "0x426CFE0", VA = "0x4270FE0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004BF2")]
			[Address(RVA = "0x4271258", Offset = "0x426D258", VA = "0x4271258", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4005802")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Image _imageBg;

		[Token(Token = "0x4005803")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Button _buttonBg;

		[Token(Token = "0x4005804")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RectTransform _rectTransformContents;

		[Token(Token = "0x4005805")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Image _imageImgCardIcon;

		[Token(Token = "0x4005806")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private RectTransform _rectTransformCardItem;

		[Token(Token = "0x4005807")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private ButtonExtend _buttonExtendImgBg;

		[Token(Token = "0x4005808")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Image _imageImgCardIcon1;

		[Token(Token = "0x4005809")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private TextMeshProUGUI _textMeshProUGUICardNumber;

		[Token(Token = "0x400580A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private TextMeshProUGUI _textMeshProUGUITxtCardName;

		[Token(Token = "0x400580B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private RectTransform _rectTransformImgRewardBg;

		[Token(Token = "0x400580C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Image _imageImgRewardDuiHao1;

		[Token(Token = "0x400580D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Image _imageImgRewardDuiHao2;

		[Token(Token = "0x400580E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Image _imageImgRewardDuiHao3;

		[Token(Token = "0x400580F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private HWIAPButton _hWIAPButtonHWIAPButton;

		[Token(Token = "0x4005810")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private ButtonExtend _buttonExtendHWIAPButton;

		[Token(Token = "0x4005811")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private ButtonExtend _buttonExtendBtnInfo;

		[Token(Token = "0x4005812")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private ButtonExtend _buttonExtendBtnClose;

		[Token(Token = "0x4005813")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private ToggleGroup _toggleGroupToggleList;

		[Token(Token = "0x4005814")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Toggle _toggleBtnChangeGiftToogle1;

		[Token(Token = "0x4005815")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Toggle _toggleBtnChangeGiftToogle2;

		[Token(Token = "0x4005816")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Toggle _toggleBtnChangeGiftToogle3;

		[Token(Token = "0x4005817")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private RectTransform _rectTransformAnimeTarget;

		[Token(Token = "0x17000D6E")]
		public Image ImageBg
		{
			[Token(Token = "0x6004BCD")]
			[Address(RVA = "0x426E268", Offset = "0x426A268", VA = "0x426E268")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D6F")]
		public Button ButtonBg
		{
			[Token(Token = "0x6004BCE")]
			[Address(RVA = "0x4270818", Offset = "0x426C818", VA = "0x4270818")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D70")]
		public RectTransform RectTransformContents
		{
			[Token(Token = "0x6004BCF")]
			[Address(RVA = "0x426D218", Offset = "0x4269218", VA = "0x426D218")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D71")]
		public Image ImageImgCardIcon
		{
			[Token(Token = "0x6004BD0")]
			[Address(RVA = "0x427067C", Offset = "0x426C67C", VA = "0x427067C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D72")]
		public RectTransform RectTransformCardItem
		{
			[Token(Token = "0x6004BD1")]
			[Address(RVA = "0x426E4B0", Offset = "0x426A4B0", VA = "0x426E4B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D73")]
		public ButtonExtend ButtonExtendImgBg
		{
			[Token(Token = "0x6004BD2")]
			[Address(RVA = "0x42708E0", Offset = "0x426C8E0", VA = "0x42708E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D74")]
		public Image ImageImgCardIcon1
		{
			[Token(Token = "0x6004BD3")]
			[Address(RVA = "0x4270744", Offset = "0x426C744", VA = "0x4270744")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D75")]
		public TextMeshProUGUI TextMeshProUGUICardNumber
		{
			[Token(Token = "0x6004BD4")]
			[Address(RVA = "0x42705B4", Offset = "0x426C5B4", VA = "0x42705B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D76")]
		public TextMeshProUGUI TextMeshProUGUITxtCardName
		{
			[Token(Token = "0x6004BD5")]
			[Address(RVA = "0x42704EC", Offset = "0x426C4EC", VA = "0x42704EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D77")]
		public RectTransform RectTransformImgRewardBg
		{
			[Token(Token = "0x6004BD6")]
			[Address(RVA = "0x426D088", Offset = "0x4269088", VA = "0x426D088")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D78")]
		public Image ImageImgRewardDuiHao1
		{
			[Token(Token = "0x6004BD7")]
			[Address(RVA = "0x4270294", Offset = "0x426C294", VA = "0x4270294")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D79")]
		public Image ImageImgRewardDuiHao2
		{
			[Token(Token = "0x6004BD8")]
			[Address(RVA = "0x427035C", Offset = "0x426C35C", VA = "0x427035C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D7A")]
		public Image ImageImgRewardDuiHao3
		{
			[Token(Token = "0x6004BD9")]
			[Address(RVA = "0x4270424", Offset = "0x426C424", VA = "0x4270424")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D7B")]
		public HWIAPButton HWIAPButtonHWIAPButton
		{
			[Token(Token = "0x6004BDA")]
			[Address(RVA = "0x42701CC", Offset = "0x426C1CC", VA = "0x42701CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D7C")]
		public ButtonExtend ButtonExtendHWIAPButton
		{
			[Token(Token = "0x6004BDB")]
			[Address(RVA = "0x42709A8", Offset = "0x426C9A8", VA = "0x42709A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D7D")]
		public ButtonExtend ButtonExtendBtnInfo
		{
			[Token(Token = "0x6004BDC")]
			[Address(RVA = "0x4270A70", Offset = "0x426CA70", VA = "0x4270A70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D7E")]
		public ButtonExtend ButtonExtendBtnClose
		{
			[Token(Token = "0x6004BDD")]
			[Address(RVA = "0x4270B38", Offset = "0x426CB38", VA = "0x4270B38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D7F")]
		public ToggleGroup ToggleGroupToggleList
		{
			[Token(Token = "0x6004BDE")]
			[Address(RVA = "0x426D150", Offset = "0x4269150", VA = "0x426D150")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D80")]
		public Toggle ToggleBtnChangeGiftToogle1
		{
			[Token(Token = "0x6004BDF")]
			[Address(RVA = "0x426D81C", Offset = "0x426981C", VA = "0x426D81C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D81")]
		public Toggle ToggleBtnChangeGiftToogle2
		{
			[Token(Token = "0x6004BE0")]
			[Address(RVA = "0x426D8E4", Offset = "0x42698E4", VA = "0x426D8E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D82")]
		public Toggle ToggleBtnChangeGiftToogle3
		{
			[Token(Token = "0x6004BE1")]
			[Address(RVA = "0x426D9AC", Offset = "0x42699AC", VA = "0x426D9AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D83")]
		public RectTransform RectTransformAnimeTarget
		{
			[Token(Token = "0x6004BE2")]
			[Address(RVA = "0x426D550", Offset = "0x4269550", VA = "0x426D550")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004BE3")]
		[Address(RVA = "0x4270C00", Offset = "0x426CC00", VA = "0x4270C00")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6004BE4")]
		[Address(RVA = "0x426DF60", Offset = "0x4269F60", VA = "0x426DF60", Slot = "12")]
		protected virtual void OnButtonBgClicked()
		{
		}

		[Token(Token = "0x6004BE5")]
		[Address(RVA = "0x4270E94", Offset = "0x426CE94", VA = "0x4270E94", Slot = "13")]
		protected virtual void OnButtonExtendImgBgClicked()
		{
		}

		[Token(Token = "0x6004BE6")]
		[Address(RVA = "0x4270F00", Offset = "0x426CF00", VA = "0x4270F00", Slot = "14")]
		protected virtual void OnButtonExtendHWIAPButtonClicked()
		{
		}

		[Token(Token = "0x6004BE7")]
		[Address(RVA = "0x4270F6C", Offset = "0x426CF6C", VA = "0x4270F6C", Slot = "15")]
		protected virtual void OnButtonExtendBtnInfoClicked()
		{
		}

		[Token(Token = "0x6004BE8")]
		[Address(RVA = "0x426DED4", Offset = "0x4269ED4", VA = "0x426DED4", Slot = "16")]
		protected virtual void OnButtonExtendBtnCloseClicked()
		{
		}

		[Token(Token = "0x6004BE9")]
		[Address(RVA = "0x426DB30", Offset = "0x4269B30", VA = "0x426DB30", Slot = "17")]
		protected virtual void OnToggleBtnChangeGiftToogle1ValueChanged(bool arg)
		{
		}

		[Token(Token = "0x6004BEA")]
		[Address(RVA = "0x426DC9C", Offset = "0x4269C9C", VA = "0x426DC9C", Slot = "18")]
		protected virtual void OnToggleBtnChangeGiftToogle2ValueChanged(bool arg)
		{
		}

		[Token(Token = "0x6004BEB")]
		[Address(RVA = "0x426DE08", Offset = "0x4269E08", VA = "0x426DE08", Slot = "19")]
		protected virtual void OnToggleBtnChangeGiftToogle3ValueChanged(bool arg)
		{
		}

		[Token(Token = "0x6004BEC")]
		[Address(RVA = "0x426D06C", Offset = "0x426906C", VA = "0x426D06C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6004BED")]
		[Address(RVA = "0x426E58C", Offset = "0x426A58C", VA = "0x426E58C", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__370))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6004BEE")]
		[Address(RVA = "0x426E648", Offset = "0x426A648", VA = "0x426E648", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6004BEF")]
		[Address(RVA = "0x426E580", Offset = "0x426A580", VA = "0x426E580")]
		public WeeklyGoldCardGiftPackPanelComponents()
		{
		}
	}
}
