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
	[Token(Token = "0x20007EA")]
	public class ChooseBoxToUnlockPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20007EB")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__459 : IAsyncStateMachine
		{
			[Token(Token = "0x4003CFA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003CFB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003CFC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ChooseBoxToUnlockPanelComponents _003C_003E4__this;

			[Token(Token = "0x4003CFD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6002C33")]
			[Address(RVA = "0x3FF7D84", Offset = "0x3FF3D84", VA = "0x3FF7D84", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002C34")]
			[Address(RVA = "0x3FF7FFC", Offset = "0x3FF3FFC", VA = "0x3FF7FFC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003CE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ButtonExtend _buttonExtendBG;

		[Token(Token = "0x4003CE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ButtonExtend _buttonExtendBtnClose;

		[Token(Token = "0x4003CEA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private ScrollRect _scrollRectChooseBoxSR;

		[Token(Token = "0x4003CEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private RectTransform _rectTransformContent;

		[Token(Token = "0x4003CEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TextMeshProUGUI _textMeshProUGUITxtCoinNum;

		[Token(Token = "0x4003CED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private TextMeshProUGUI _textMeshProUGUITxtCoinDes;

		[Token(Token = "0x4003CEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private TextMeshProUGUI _textMeshProUGUITxtWoodNum;

		[Token(Token = "0x4003CEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private TextMeshProUGUI _textMeshProUGUITxtWoodDes;

		[Token(Token = "0x4003CF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private TextMeshProUGUI _textMeshProUGUITxtCommon;

		[Token(Token = "0x4003CF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private TextMeshProUGUI _textMeshProUGUITxtCommonCount;

		[Token(Token = "0x4003CF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private TextMeshProUGUI _textMeshProUGUITxtRare;

		[Token(Token = "0x4003CF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private TextMeshProUGUI _textMeshProUGUITxtRareCount;

		[Token(Token = "0x4003CF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private TextMeshProUGUI _textMeshProUGUITxtEpic;

		[Token(Token = "0x4003CF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private TextMeshProUGUI _textMeshProUGUITxtEpicCount;

		[Token(Token = "0x4003CF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private TextMeshProUGUI _textMeshProUGUITxtGold;

		[Token(Token = "0x4003CF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private TextMeshProUGUI _textMeshProUGUITxtGoldCount;

		[Token(Token = "0x4003CF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private ButtonExtend _buttonExtendBtnUnlock;

		[Token(Token = "0x4003CF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private TextMeshProUGUI _textMeshProUGUITxtTime;

		[Token(Token = "0x170004C6")]
		public ButtonExtend ButtonExtendBG
		{
			[Token(Token = "0x6002C17")]
			[Address(RVA = "0x3FF78D0", Offset = "0x3FF38D0", VA = "0x3FF78D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004C7")]
		public ButtonExtend ButtonExtendBtnClose
		{
			[Token(Token = "0x6002C18")]
			[Address(RVA = "0x3FF7998", Offset = "0x3FF3998", VA = "0x3FF7998")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004C8")]
		public ScrollRect ScrollRectChooseBoxSR
		{
			[Token(Token = "0x6002C19")]
			[Address(RVA = "0x3FF7A60", Offset = "0x3FF3A60", VA = "0x3FF7A60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004C9")]
		public RectTransform RectTransformContent
		{
			[Token(Token = "0x6002C1A")]
			[Address(RVA = "0x3FF6ADC", Offset = "0x3FF2ADC", VA = "0x3FF6ADC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004CA")]
		public TextMeshProUGUI TextMeshProUGUITxtCoinNum
		{
			[Token(Token = "0x6002C1B")]
			[Address(RVA = "0x3FF4EF0", Offset = "0x3FF0EF0", VA = "0x3FF4EF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004CB")]
		public TextMeshProUGUI TextMeshProUGUITxtCoinDes
		{
			[Token(Token = "0x6002C1C")]
			[Address(RVA = "0x3FF7734", Offset = "0x3FF3734", VA = "0x3FF7734")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004CC")]
		public TextMeshProUGUI TextMeshProUGUITxtWoodNum
		{
			[Token(Token = "0x6002C1D")]
			[Address(RVA = "0x3FF4FB8", Offset = "0x3FF0FB8", VA = "0x3FF4FB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004CD")]
		public TextMeshProUGUI TextMeshProUGUITxtWoodDes
		{
			[Token(Token = "0x6002C1E")]
			[Address(RVA = "0x3FF77FC", Offset = "0x3FF37FC", VA = "0x3FF77FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004CE")]
		public TextMeshProUGUI TextMeshProUGUITxtCommon
		{
			[Token(Token = "0x6002C1F")]
			[Address(RVA = "0x3FF7414", Offset = "0x3FF3414", VA = "0x3FF7414")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004CF")]
		public TextMeshProUGUI TextMeshProUGUITxtCommonCount
		{
			[Token(Token = "0x6002C20")]
			[Address(RVA = "0x3FF5080", Offset = "0x3FF1080", VA = "0x3FF5080")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004D0")]
		public TextMeshProUGUI TextMeshProUGUITxtRare
		{
			[Token(Token = "0x6002C21")]
			[Address(RVA = "0x3FF74DC", Offset = "0x3FF34DC", VA = "0x3FF74DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004D1")]
		public TextMeshProUGUI TextMeshProUGUITxtRareCount
		{
			[Token(Token = "0x6002C22")]
			[Address(RVA = "0x3FF5148", Offset = "0x3FF1148", VA = "0x3FF5148")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004D2")]
		public TextMeshProUGUI TextMeshProUGUITxtEpic
		{
			[Token(Token = "0x6002C23")]
			[Address(RVA = "0x3FF75A4", Offset = "0x3FF35A4", VA = "0x3FF75A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004D3")]
		public TextMeshProUGUI TextMeshProUGUITxtEpicCount
		{
			[Token(Token = "0x6002C24")]
			[Address(RVA = "0x3FF5210", Offset = "0x3FF1210", VA = "0x3FF5210")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004D4")]
		public TextMeshProUGUI TextMeshProUGUITxtGold
		{
			[Token(Token = "0x6002C25")]
			[Address(RVA = "0x3FF766C", Offset = "0x3FF366C", VA = "0x3FF766C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004D5")]
		public TextMeshProUGUI TextMeshProUGUITxtGoldCount
		{
			[Token(Token = "0x6002C26")]
			[Address(RVA = "0x3FF52D8", Offset = "0x3FF12D8", VA = "0x3FF52D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004D6")]
		public ButtonExtend ButtonExtendBtnUnlock
		{
			[Token(Token = "0x6002C27")]
			[Address(RVA = "0x3FF6A14", Offset = "0x3FF2A14", VA = "0x3FF6A14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004D7")]
		public TextMeshProUGUI TextMeshProUGUITxtTime
		{
			[Token(Token = "0x6002C28")]
			[Address(RVA = "0x3FF53A0", Offset = "0x3FF13A0", VA = "0x3FF53A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002C29")]
		[Address(RVA = "0x3FF7B28", Offset = "0x3FF3B28", VA = "0x3FF7B28")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6002C2A")]
		[Address(RVA = "0x3FF5CE0", Offset = "0x3FF1CE0", VA = "0x3FF5CE0", Slot = "12")]
		protected virtual void OnButtonExtendBGClicked()
		{
		}

		[Token(Token = "0x6002C2B")]
		[Address(RVA = "0x3FF5C54", Offset = "0x3FF1C54", VA = "0x3FF5C54", Slot = "13")]
		protected virtual void OnButtonExtendBtnCloseClicked()
		{
		}

		[Token(Token = "0x6002C2C")]
		[Address(RVA = "0x3FF7CAC", Offset = "0x3FF3CAC", VA = "0x3FF7CAC", Slot = "14")]
		protected virtual void OnScrollRectChooseBoxSRValueChanged(Vector2 arg)
		{
		}

		[Token(Token = "0x6002C2D")]
		[Address(RVA = "0x3FF59FC", Offset = "0x3FF19FC", VA = "0x3FF59FC", Slot = "15")]
		protected virtual void OnButtonExtendBtnUnlockClicked()
		{
		}

		[Token(Token = "0x6002C2E")]
		[Address(RVA = "0x3FF7D60", Offset = "0x3FF3D60", VA = "0x3FF7D60", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002C2F")]
		[Address(RVA = "0x3FF5EF0", Offset = "0x3FF1EF0", VA = "0x3FF5EF0", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__459))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002C30")]
		[Address(RVA = "0x3FF5D64", Offset = "0x3FF1D64", VA = "0x3FF5D64", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6002C31")]
		[Address(RVA = "0x3FF5EE4", Offset = "0x3FF1EE4", VA = "0x3FF5EE4")]
		public ChooseBoxToUnlockPanelComponents()
		{
		}
	}
}
