using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UIFramework;

namespace UIModuleO
{
	[Token(Token = "0x2000718")]
	public class benefitValueItemComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000719")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__32 : IAsyncStateMachine
		{
			[Token(Token = "0x4003850")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003851")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003852")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public benefitValueItemComponents _003C_003E4__this;

			[Token(Token = "0x4003853")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x600269F")]
			[Address(RVA = "0x3F96A9C", Offset = "0x3F92A9C", VA = "0x3F96A9C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60026A0")]
			[Address(RVA = "0x3F96D14", Offset = "0x3F92D14", VA = "0x3F96D14", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400384F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TextMeshProUGUI _textMeshProUGUIBenefitText1;

		[Token(Token = "0x1700031B")]
		public TextMeshProUGUI TextMeshProUGUIBenefitText1
		{
			[Token(Token = "0x6002698")]
			[Address(RVA = "0x3F965F8", Offset = "0x3F925F8", VA = "0x3F965F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002699")]
		[Address(RVA = "0x3F96940", Offset = "0x3F92940", VA = "0x3F96940")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x600269A")]
		[Address(RVA = "0x3F96944", Offset = "0x3F92944", VA = "0x3F96944", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600269B")]
		[Address(RVA = "0x3F9694C", Offset = "0x3F9294C", VA = "0x3F9694C", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__32))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x600269C")]
		[Address(RVA = "0x3F969E0", Offset = "0x3F929E0", VA = "0x3F969E0", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x600269D")]
		[Address(RVA = "0x3F966C8", Offset = "0x3F926C8", VA = "0x3F966C8")]
		public benefitValueItemComponents()
		{
		}
	}
}
