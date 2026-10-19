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
	[Token(Token = "0x2000AA6")]
	public class PropFastPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000AA7")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__278 : IAsyncStateMachine
		{
			[Token(Token = "0x4004E74")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004E75")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004E76")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public PropFastPanelComponents _003C_003E4__this;

			[Token(Token = "0x4004E77")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6004049")]
			[Address(RVA = "0x41A5AC0", Offset = "0x41A1AC0", VA = "0x41A5AC0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600404A")]
			[Address(RVA = "0x41A5D38", Offset = "0x41A1D38", VA = "0x41A5D38", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004E65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Button _buttonBtnCloseBg;

		[Token(Token = "0x4004E66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RectTransform _rectTransformImgTopBg;

		[Token(Token = "0x4004E67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Image _imageImgPropTitleBg;

		[Token(Token = "0x4004E68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private TextMeshProUGUI _textMeshProUGUITxtPropName;

		[Token(Token = "0x4004E69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Image _imageImgPropIcon;

		[Token(Token = "0x4004E6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Image _imageImgPropProgress;

		[Token(Token = "0x4004E6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private TextMeshProUGUI _textMeshProUGUITxtPropProgress;

		[Token(Token = "0x4004E6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private TextMeshProUGUI _textMeshProUGUITxtNowLevelPropDes;

		[Token(Token = "0x4004E6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private TextMeshProUGUI _textMeshProUGUITxtNowLevel;

		[Token(Token = "0x4004E6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private TextMeshProUGUI _textMeshProUGUITxtNextLevelPropDes;

		[Token(Token = "0x4004E6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private TextMeshProUGUI _textMeshProUGUITxtNextLevel;

		[Token(Token = "0x4004E70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private ButtonExtend _buttonExtendBtnReplace;

		[Token(Token = "0x4004E71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private ButtonExtend _buttonExtendBtnUpgrade;

		[Token(Token = "0x4004E72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private TextMeshProUGUI _textMeshProUGUITxtUpgrade;

		[Token(Token = "0x4004E73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private TextMeshProUGUI _textMeshProUGUITxtUpgradeRequireNum;

		[Token(Token = "0x170009F9")]
		public Button ButtonBtnCloseBg
		{
			[Token(Token = "0x6004031")]
			[Address(RVA = "0x41A57F4", Offset = "0x41A17F4", VA = "0x41A57F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009FA")]
		public RectTransform RectTransformImgTopBg
		{
			[Token(Token = "0x6004032")]
			[Address(RVA = "0x41A3290", Offset = "0x419F290", VA = "0x41A3290")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009FB")]
		public Image ImageImgPropTitleBg
		{
			[Token(Token = "0x6004033")]
			[Address(RVA = "0x41A5720", Offset = "0x41A1720", VA = "0x41A5720")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009FC")]
		public TextMeshProUGUI TextMeshProUGUITxtPropName
		{
			[Token(Token = "0x6004034")]
			[Address(RVA = "0x41A50E0", Offset = "0x41A10E0", VA = "0x41A50E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009FD")]
		public Image ImageImgPropIcon
		{
			[Token(Token = "0x6004035")]
			[Address(RVA = "0x41A5018", Offset = "0x41A1018", VA = "0x41A5018")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009FE")]
		public Image ImageImgPropProgress
		{
			[Token(Token = "0x6004036")]
			[Address(RVA = "0x41A5270", Offset = "0x41A1270", VA = "0x41A5270")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009FF")]
		public TextMeshProUGUI TextMeshProUGUITxtPropProgress
		{
			[Token(Token = "0x6004037")]
			[Address(RVA = "0x41A2CF8", Offset = "0x419ECF8", VA = "0x41A2CF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A00")]
		public TextMeshProUGUI TextMeshProUGUITxtNowLevelPropDes
		{
			[Token(Token = "0x6004038")]
			[Address(RVA = "0x41A54C8", Offset = "0x41A14C8", VA = "0x41A54C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A01")]
		public TextMeshProUGUI TextMeshProUGUITxtNowLevel
		{
			[Token(Token = "0x6004039")]
			[Address(RVA = "0x41A5338", Offset = "0x41A1338", VA = "0x41A5338")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A02")]
		public TextMeshProUGUI TextMeshProUGUITxtNextLevelPropDes
		{
			[Token(Token = "0x600403A")]
			[Address(RVA = "0x41A5590", Offset = "0x41A1590", VA = "0x41A5590")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A03")]
		public TextMeshProUGUI TextMeshProUGUITxtNextLevel
		{
			[Token(Token = "0x600403B")]
			[Address(RVA = "0x41A5400", Offset = "0x41A1400", VA = "0x41A5400")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A04")]
		public ButtonExtend ButtonExtendBtnReplace
		{
			[Token(Token = "0x600403C")]
			[Address(RVA = "0x41A58BC", Offset = "0x41A18BC", VA = "0x41A58BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A05")]
		public ButtonExtend ButtonExtendBtnUpgrade
		{
			[Token(Token = "0x600403D")]
			[Address(RVA = "0x41A3034", Offset = "0x419F034", VA = "0x41A3034")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A06")]
		public TextMeshProUGUI TextMeshProUGUITxtUpgrade
		{
			[Token(Token = "0x600403E")]
			[Address(RVA = "0x41A51A8", Offset = "0x41A11A8", VA = "0x41A51A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A07")]
		public TextMeshProUGUI TextMeshProUGUITxtUpgradeRequireNum
		{
			[Token(Token = "0x600403F")]
			[Address(RVA = "0x41A5658", Offset = "0x41A1658", VA = "0x41A5658")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004040")]
		[Address(RVA = "0x41A5984", Offset = "0x41A1984", VA = "0x41A5984")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6004041")]
		[Address(RVA = "0x41A24FC", Offset = "0x419E4FC", VA = "0x41A24FC", Slot = "12")]
		protected virtual void OnButtonBtnCloseBgClicked()
		{
		}

		[Token(Token = "0x6004042")]
		[Address(RVA = "0x41A3404", Offset = "0x419F404", VA = "0x41A3404", Slot = "13")]
		protected virtual void OnButtonExtendBtnReplaceClicked()
		{
		}

		[Token(Token = "0x6004043")]
		[Address(RVA = "0x41A2C8C", Offset = "0x419EC8C", VA = "0x41A2C8C", Slot = "14")]
		protected virtual void OnButtonExtendBtnUpgradeClicked()
		{
		}

		[Token(Token = "0x6004044")]
		[Address(RVA = "0x41A5A9C", Offset = "0x41A1A9C", VA = "0x41A5A9C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6004045")]
		[Address(RVA = "0x41A336C", Offset = "0x419F36C", VA = "0x41A336C", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__278))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6004046")]
		[Address(RVA = "0x41A3474", Offset = "0x419F474", VA = "0x41A3474", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6004047")]
		[Address(RVA = "0x41A3360", Offset = "0x419F360", VA = "0x41A3360")]
		public PropFastPanelComponents()
		{
		}
	}
}
