using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UIFramework;
using UIModuleO.UIAnim;

namespace UIModuleO
{
	[Token(Token = "0x200078C")]
	public class BuyBoxSlotPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200078D")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__170 : IAsyncStateMachine
		{
			[Token(Token = "0x4003AA3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003AA4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003AA5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BuyBoxSlotPanelComponents _003C_003E4__this;

			[Token(Token = "0x4003AA6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6002980")]
			[Address(RVA = "0x3FC4624", Offset = "0x3FC0624", VA = "0x3FC4624", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002981")]
			[Address(RVA = "0x3FC489C", Offset = "0x3FC089C", VA = "0x3FC489C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003A9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ButtonExtend _buttonExtendBG;

		[Token(Token = "0x4003A9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ButtonExtend _buttonExtendBtnClose;

		[Token(Token = "0x4003A9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TextMeshProUGUI _textMeshProUGUITxtCointCount;

		[Token(Token = "0x4003AA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private TextMeshProUGUI _textMeshProUGUITxtDiamondCount;

		[Token(Token = "0x4003AA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private HWIAPButton _hWIAPButtonHWIAPButton;

		[Token(Token = "0x4003AA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private ButtonExtend _buttonExtendHWIAPButton;

		[Token(Token = "0x170003EF")]
		public ButtonExtend ButtonExtendBG
		{
			[Token(Token = "0x6002971")]
			[Address(RVA = "0x3FC418C", Offset = "0x3FC018C", VA = "0x3FC418C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003F0")]
		public ButtonExtend ButtonExtendBtnClose
		{
			[Token(Token = "0x6002972")]
			[Address(RVA = "0x3FC4254", Offset = "0x3FC0254", VA = "0x3FC4254")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003F1")]
		public TextMeshProUGUI TextMeshProUGUITxtCointCount
		{
			[Token(Token = "0x6002973")]
			[Address(RVA = "0x3FC3FF0", Offset = "0x3FBFFF0", VA = "0x3FC3FF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003F2")]
		public TextMeshProUGUI TextMeshProUGUITxtDiamondCount
		{
			[Token(Token = "0x6002974")]
			[Address(RVA = "0x3FC40B8", Offset = "0x3FC00B8", VA = "0x3FC40B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003F3")]
		public HWIAPButton HWIAPButtonHWIAPButton
		{
			[Token(Token = "0x6002975")]
			[Address(RVA = "0x3FC3668", Offset = "0x3FBF668", VA = "0x3FC3668")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003F4")]
		public ButtonExtend ButtonExtendHWIAPButton
		{
			[Token(Token = "0x6002976")]
			[Address(RVA = "0x3FC431C", Offset = "0x3FC031C", VA = "0x3FC431C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002977")]
		[Address(RVA = "0x3FC43E4", Offset = "0x3FC03E4", VA = "0x3FC43E4")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6002978")]
		[Address(RVA = "0x3FC37DC", Offset = "0x3FBF7DC", VA = "0x3FC37DC", Slot = "12")]
		protected virtual void OnButtonExtendBGClicked()
		{
		}

		[Token(Token = "0x6002979")]
		[Address(RVA = "0x3FC3750", Offset = "0x3FBF750", VA = "0x3FC3750", Slot = "13")]
		protected virtual void OnButtonExtendBtnCloseClicked()
		{
		}

		[Token(Token = "0x600297A")]
		[Address(RVA = "0x3FC44FC", Offset = "0x3FC04FC", VA = "0x3FC44FC", Slot = "14")]
		protected virtual void OnButtonExtendHWIAPButtonClicked()
		{
		}

		[Token(Token = "0x600297B")]
		[Address(RVA = "0x3FC33FC", Offset = "0x3FBF3FC", VA = "0x3FC33FC", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600297C")]
		[Address(RVA = "0x3FC39CC", Offset = "0x3FBF9CC", VA = "0x3FC39CC", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__170))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x600297D")]
		[Address(RVA = "0x3FC4568", Offset = "0x3FC0568", VA = "0x3FC4568", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x600297E")]
		[Address(RVA = "0x3FC39C0", Offset = "0x3FBF9C0", VA = "0x3FC39C0")]
		public BuyBoxSlotPanelComponents()
		{
		}
	}
}
