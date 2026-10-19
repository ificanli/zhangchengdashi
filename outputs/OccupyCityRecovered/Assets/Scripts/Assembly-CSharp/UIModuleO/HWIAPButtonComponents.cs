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
	[Token(Token = "0x200091B")]
	public class HWIAPButtonComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200091C")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__33 : IAsyncStateMachine
		{
			[Token(Token = "0x4004471")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004472")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004473")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HWIAPButtonComponents _003C_003E4__this;

			[Token(Token = "0x4004474")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60034B1")]
			[Address(RVA = "0x40ABADC", Offset = "0x40A7ADC", VA = "0x40ABADC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60034B2")]
			[Address(RVA = "0x40ABD54", Offset = "0x40A7D54", VA = "0x40ABD54", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400446F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ButtonExtend _buttonExtendHWIAPButton;

		[Token(Token = "0x4004470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TextMeshProUGUI _textMeshProUGUIPriceText;

		[Token(Token = "0x1700074B")]
		public ButtonExtend ButtonExtendHWIAPButton
		{
			[Token(Token = "0x60034A8")]
			[Address(RVA = "0x40AB860", Offset = "0x40A7860", VA = "0x40AB860")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700074C")]
		public TextMeshProUGUI TextMeshProUGUIPriceText
		{
			[Token(Token = "0x60034A9")]
			[Address(RVA = "0x40AB24C", Offset = "0x40A724C", VA = "0x40AB24C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60034AA")]
		[Address(RVA = "0x40AB904", Offset = "0x40A7904", VA = "0x40AB904")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x60034AB")]
		[Address(RVA = "0x40AB388", Offset = "0x40A7388", VA = "0x40AB388", Slot = "12")]
		protected virtual void OnButtonExtendHWIAPButtonClicked()
		{
		}

		[Token(Token = "0x60034AC")]
		[Address(RVA = "0x40AADDC", Offset = "0x40A6DDC", VA = "0x40AADDC", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60034AD")]
		[Address(RVA = "0x40AB98C", Offset = "0x40A798C", VA = "0x40AB98C", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__33))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60034AE")]
		[Address(RVA = "0x40ABA20", Offset = "0x40A7A20", VA = "0x40ABA20", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60034AF")]
		[Address(RVA = "0x40AB3FC", Offset = "0x40A73FC", VA = "0x40AB3FC")]
		public HWIAPButtonComponents()
		{
		}
	}
}
