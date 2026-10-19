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
	[Token(Token = "0x200084E")]
	public class ConfirmPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200084F")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__112 : IAsyncStateMachine
		{
			[Token(Token = "0x4003F34")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003F35")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003F36")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ConfirmPanelComponents _003C_003E4__this;

			[Token(Token = "0x4003F37")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6002EC2")]
			[Address(RVA = "0x402516C", Offset = "0x402116C", VA = "0x402516C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002EC3")]
			[Address(RVA = "0x40253E4", Offset = "0x40213E4", VA = "0x40253E4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003F2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ButtonExtend _buttonExtendBlack;

		[Token(Token = "0x4003F30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TextMeshProUGUI _textMeshProUGUITxtTitle;

		[Token(Token = "0x4003F31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TextMeshProUGUI _textMeshProUGUIContent;

		[Token(Token = "0x4003F32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ButtonExtend _buttonExtendDoneBtn;

		[Token(Token = "0x4003F33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TextMeshProUGUI _textMeshProUGUIDoneBtnText;

		[Token(Token = "0x17000570")]
		public ButtonExtend ButtonExtendBlack
		{
			[Token(Token = "0x6002EB5")]
			[Address(RVA = "0x4024E24", Offset = "0x4020E24", VA = "0x4024E24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000571")]
		public TextMeshProUGUI TextMeshProUGUITxtTitle
		{
			[Token(Token = "0x6002EB6")]
			[Address(RVA = "0x4024BCC", Offset = "0x4020BCC", VA = "0x4024BCC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000572")]
		public TextMeshProUGUI TextMeshProUGUIContent
		{
			[Token(Token = "0x6002EB7")]
			[Address(RVA = "0x4024C94", Offset = "0x4020C94", VA = "0x4024C94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000573")]
		public ButtonExtend ButtonExtendDoneBtn
		{
			[Token(Token = "0x6002EB8")]
			[Address(RVA = "0x4024EF8", Offset = "0x4020EF8", VA = "0x4024EF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000574")]
		public TextMeshProUGUI TextMeshProUGUIDoneBtnText
		{
			[Token(Token = "0x6002EB9")]
			[Address(RVA = "0x4024D5C", Offset = "0x4020D5C", VA = "0x4024D5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002EBA")]
		[Address(RVA = "0x4024FC0", Offset = "0x4020FC0", VA = "0x4024FC0")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6002EBB")]
		[Address(RVA = "0x40245E4", Offset = "0x40205E4", VA = "0x40245E4", Slot = "12")]
		protected virtual void OnButtonExtendBlackClicked()
		{
		}

		[Token(Token = "0x6002EBC")]
		[Address(RVA = "0x402468C", Offset = "0x402068C", VA = "0x402468C", Slot = "13")]
		protected virtual void OnButtonExtendDoneBtnClicked()
		{
		}

		[Token(Token = "0x6002EBD")]
		[Address(RVA = "0x4025094", Offset = "0x4021094", VA = "0x4025094", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002EBE")]
		[Address(RVA = "0x402470C", Offset = "0x402070C", VA = "0x402470C", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__112))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002EBF")]
		[Address(RVA = "0x40250B0", Offset = "0x40210B0", VA = "0x40250B0", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6002EC0")]
		[Address(RVA = "0x4024700", Offset = "0x4020700", VA = "0x4024700")]
		public ConfirmPanelComponents()
		{
		}
	}
}
