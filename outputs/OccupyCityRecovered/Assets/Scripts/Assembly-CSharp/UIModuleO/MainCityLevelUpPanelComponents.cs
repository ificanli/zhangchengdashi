using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UIFramework;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000944")]
	public class MainCityLevelUpPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000945")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__465 : IAsyncStateMachine
		{
			[Token(Token = "0x400457E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400457F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004580")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MainCityLevelUpPanelComponents _003C_003E4__this;

			[Token(Token = "0x4004581")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60035F8")]
			[Address(RVA = "0x40C201C", Offset = "0x40BE01C", VA = "0x40C201C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60035F9")]
			[Address(RVA = "0x40C2294", Offset = "0x40BE294", VA = "0x40C2294", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400455D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Button _buttonBG;

		[Token(Token = "0x400455E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RectTransform _rectTransformLord;

		[Token(Token = "0x400455F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RectTransform _rectTransformImgLight;

		[Token(Token = "0x4004560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Image _imageImgLight;

		[Token(Token = "0x4004561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Image _imageImgNewLord;

		[Token(Token = "0x4004562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private CanvasGroup _canvasGroupLevel;

		[Token(Token = "0x4004563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private TextMeshProUGUI _textMeshProUGUITxtLvUpDes;

		[Token(Token = "0x4004564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private TextMeshProUGUI _textMeshProUGUITxtLevelOldDes;

		[Token(Token = "0x4004565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private TextMeshProUGUI _textMeshProUGUITxtLevelNewDes;

		[Token(Token = "0x4004566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private CanvasGroup _canvasGroupPropertyRootNew;

		[Token(Token = "0x4004567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private TextMeshProUGUI _textMeshProUGUITxtDesNew;

		[Token(Token = "0x4004568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private RectTransform _rectTransformImgAtkNumBg;

		[Token(Token = "0x4004569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private CanvasGroup _canvasGroupImgAtkNumBg;

		[Token(Token = "0x400456A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private TextMeshProUGUI _textMeshProUGUITxtAtkDes;

		[Token(Token = "0x400456B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private TextMeshProUGUI _textMeshProUGUITxtAtkNum;

		[Token(Token = "0x400456C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private TextMeshProUGUI _textMeshProUGUITxtAtkAddNum;

		[Token(Token = "0x400456D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private RectTransform _rectTransformImgHpNumBg;

		[Token(Token = "0x400456E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private CanvasGroup _canvasGroupImgHpNumBg;

		[Token(Token = "0x400456F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private TextMeshProUGUI _textMeshProUGUITxtHpDes;

		[Token(Token = "0x4004570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private TextMeshProUGUI _textMeshProUGUITxtHpNum;

		[Token(Token = "0x4004571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private TextMeshProUGUI _textMeshProUGUITxtHpAddNum;

		[Token(Token = "0x4004572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private RectTransform _rectTransformImgOutPutNumBg;

		[Token(Token = "0x4004573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private CanvasGroup _canvasGroupImgOutPutNumBg;

		[Token(Token = "0x4004574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private TextMeshProUGUI _textMeshProUGUITxtOutPutDes;

		[Token(Token = "0x4004575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private TextMeshProUGUI _textMeshProUGUITxtOutPutNum;

		[Token(Token = "0x4004576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private TextMeshProUGUI _textMeshProUGUITxtOutPutAddNum;

		[Token(Token = "0x4004577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private CanvasGroup _canvasGroupIdleRewards;

		[Token(Token = "0x4004578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private TextMeshProUGUI _textMeshProUGUIIdleRewardDes;

		[Token(Token = "0x4004579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Image _imageImgReward1;

		[Token(Token = "0x400457A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private TextMeshProUGUI _textMeshProUGUITxtReward1Num;

		[Token(Token = "0x400457B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Image _imageImgReward2;

		[Token(Token = "0x400457C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private TextMeshProUGUI _textMeshProUGUITxtReward2Num;

		[Token(Token = "0x400457D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private TextMeshProUGUI _textMeshProUGUITxtTapToContinue;

		[Token(Token = "0x1700079D")]
		public Button ButtonBG
		{
			[Token(Token = "0x60035D0")]
			[Address(RVA = "0x40C03EC", Offset = "0x40BC3EC", VA = "0x40C03EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700079E")]
		public RectTransform RectTransformLord
		{
			[Token(Token = "0x60035D1")]
			[Address(RVA = "0x40C04B4", Offset = "0x40BC4B4", VA = "0x40C04B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700079F")]
		public RectTransform RectTransformImgLight
		{
			[Token(Token = "0x60035D2")]
			[Address(RVA = "0x40C057C", Offset = "0x40BC57C", VA = "0x40C057C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007A0")]
		public Image ImageImgLight
		{
			[Token(Token = "0x60035D3")]
			[Address(RVA = "0x40C0644", Offset = "0x40BC644", VA = "0x40C0644")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007A1")]
		public Image ImageImgNewLord
		{
			[Token(Token = "0x60035D4")]
			[Address(RVA = "0x40C070C", Offset = "0x40BC70C", VA = "0x40C070C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007A2")]
		public CanvasGroup CanvasGroupLevel
		{
			[Token(Token = "0x60035D5")]
			[Address(RVA = "0x40C07D4", Offset = "0x40BC7D4", VA = "0x40C07D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007A3")]
		public TextMeshProUGUI TextMeshProUGUITxtLvUpDes
		{
			[Token(Token = "0x60035D6")]
			[Address(RVA = "0x40C089C", Offset = "0x40BC89C", VA = "0x40C089C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007A4")]
		public TextMeshProUGUI TextMeshProUGUITxtLevelOldDes
		{
			[Token(Token = "0x60035D7")]
			[Address(RVA = "0x40C0964", Offset = "0x40BC964", VA = "0x40C0964")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007A5")]
		public TextMeshProUGUI TextMeshProUGUITxtLevelNewDes
		{
			[Token(Token = "0x60035D8")]
			[Address(RVA = "0x40C0A2C", Offset = "0x40BCA2C", VA = "0x40C0A2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007A6")]
		public CanvasGroup CanvasGroupPropertyRootNew
		{
			[Token(Token = "0x60035D9")]
			[Address(RVA = "0x40C0AF4", Offset = "0x40BCAF4", VA = "0x40C0AF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007A7")]
		public TextMeshProUGUI TextMeshProUGUITxtDesNew
		{
			[Token(Token = "0x60035DA")]
			[Address(RVA = "0x40C0BBC", Offset = "0x40BCBBC", VA = "0x40C0BBC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007A8")]
		public RectTransform RectTransformImgAtkNumBg
		{
			[Token(Token = "0x60035DB")]
			[Address(RVA = "0x40C0C84", Offset = "0x40BCC84", VA = "0x40C0C84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007A9")]
		public CanvasGroup CanvasGroupImgAtkNumBg
		{
			[Token(Token = "0x60035DC")]
			[Address(RVA = "0x40C0D4C", Offset = "0x40BCD4C", VA = "0x40C0D4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007AA")]
		public TextMeshProUGUI TextMeshProUGUITxtAtkDes
		{
			[Token(Token = "0x60035DD")]
			[Address(RVA = "0x40C0E14", Offset = "0x40BCE14", VA = "0x40C0E14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007AB")]
		public TextMeshProUGUI TextMeshProUGUITxtAtkNum
		{
			[Token(Token = "0x60035DE")]
			[Address(RVA = "0x40C0EDC", Offset = "0x40BCEDC", VA = "0x40C0EDC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007AC")]
		public TextMeshProUGUI TextMeshProUGUITxtAtkAddNum
		{
			[Token(Token = "0x60035DF")]
			[Address(RVA = "0x40C0FA4", Offset = "0x40BCFA4", VA = "0x40C0FA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007AD")]
		public RectTransform RectTransformImgHpNumBg
		{
			[Token(Token = "0x60035E0")]
			[Address(RVA = "0x40C106C", Offset = "0x40BD06C", VA = "0x40C106C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007AE")]
		public CanvasGroup CanvasGroupImgHpNumBg
		{
			[Token(Token = "0x60035E1")]
			[Address(RVA = "0x40C1134", Offset = "0x40BD134", VA = "0x40C1134")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007AF")]
		public TextMeshProUGUI TextMeshProUGUITxtHpDes
		{
			[Token(Token = "0x60035E2")]
			[Address(RVA = "0x40C11FC", Offset = "0x40BD1FC", VA = "0x40C11FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007B0")]
		public TextMeshProUGUI TextMeshProUGUITxtHpNum
		{
			[Token(Token = "0x60035E3")]
			[Address(RVA = "0x40C12C4", Offset = "0x40BD2C4", VA = "0x40C12C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007B1")]
		public TextMeshProUGUI TextMeshProUGUITxtHpAddNum
		{
			[Token(Token = "0x60035E4")]
			[Address(RVA = "0x40C138C", Offset = "0x40BD38C", VA = "0x40C138C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007B2")]
		public RectTransform RectTransformImgOutPutNumBg
		{
			[Token(Token = "0x60035E5")]
			[Address(RVA = "0x40C1454", Offset = "0x40BD454", VA = "0x40C1454")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007B3")]
		public CanvasGroup CanvasGroupImgOutPutNumBg
		{
			[Token(Token = "0x60035E6")]
			[Address(RVA = "0x40C151C", Offset = "0x40BD51C", VA = "0x40C151C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007B4")]
		public TextMeshProUGUI TextMeshProUGUITxtOutPutDes
		{
			[Token(Token = "0x60035E7")]
			[Address(RVA = "0x40C15E4", Offset = "0x40BD5E4", VA = "0x40C15E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007B5")]
		public TextMeshProUGUI TextMeshProUGUITxtOutPutNum
		{
			[Token(Token = "0x60035E8")]
			[Address(RVA = "0x40C16AC", Offset = "0x40BD6AC", VA = "0x40C16AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007B6")]
		public TextMeshProUGUI TextMeshProUGUITxtOutPutAddNum
		{
			[Token(Token = "0x60035E9")]
			[Address(RVA = "0x40C1774", Offset = "0x40BD774", VA = "0x40C1774")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007B7")]
		public CanvasGroup CanvasGroupIdleRewards
		{
			[Token(Token = "0x60035EA")]
			[Address(RVA = "0x40C183C", Offset = "0x40BD83C", VA = "0x40C183C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007B8")]
		public TextMeshProUGUI TextMeshProUGUIIdleRewardDes
		{
			[Token(Token = "0x60035EB")]
			[Address(RVA = "0x40C1904", Offset = "0x40BD904", VA = "0x40C1904")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007B9")]
		public Image ImageImgReward1
		{
			[Token(Token = "0x60035EC")]
			[Address(RVA = "0x40C19CC", Offset = "0x40BD9CC", VA = "0x40C19CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007BA")]
		public TextMeshProUGUI TextMeshProUGUITxtReward1Num
		{
			[Token(Token = "0x60035ED")]
			[Address(RVA = "0x40C1A94", Offset = "0x40BDA94", VA = "0x40C1A94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007BB")]
		public Image ImageImgReward2
		{
			[Token(Token = "0x60035EE")]
			[Address(RVA = "0x40C1B5C", Offset = "0x40BDB5C", VA = "0x40C1B5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007BC")]
		public TextMeshProUGUI TextMeshProUGUITxtReward2Num
		{
			[Token(Token = "0x60035EF")]
			[Address(RVA = "0x40C1C24", Offset = "0x40BDC24", VA = "0x40C1C24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007BD")]
		public TextMeshProUGUI TextMeshProUGUITxtTapToContinue
		{
			[Token(Token = "0x60035F0")]
			[Address(RVA = "0x40C1CEC", Offset = "0x40BDCEC", VA = "0x40C1CEC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60035F1")]
		[Address(RVA = "0x40C1DB4", Offset = "0x40BDDB4", VA = "0x40C1DB4")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x60035F2")]
		[Address(RVA = "0x40C1E3C", Offset = "0x40BDE3C", VA = "0x40C1E3C", Slot = "12")]
		protected virtual void OnButtonBGClicked()
		{
		}

		[Token(Token = "0x60035F3")]
		[Address(RVA = "0x40C1EA8", Offset = "0x40BDEA8", VA = "0x40C1EA8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60035F4")]
		[Address(RVA = "0x40C1EC4", Offset = "0x40BDEC4", VA = "0x40C1EC4", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__465))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60035F5")]
		[Address(RVA = "0x40C1F58", Offset = "0x40BDF58", VA = "0x40C1F58", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60035F6")]
		[Address(RVA = "0x40C200C", Offset = "0x40BE00C", VA = "0x40C200C")]
		public MainCityLevelUpPanelComponents()
		{
		}
	}
}
