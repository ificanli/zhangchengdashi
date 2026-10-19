using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using UIFramework;

namespace UIModuleO
{
	[Token(Token = "0x20006A3")]
	public class ADSBreakPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20006A4")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__47 : IAsyncStateMachine
		{
			[Token(Token = "0x4003549")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400354A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400354B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ADSBreakPanelComponents _003C_003E4__this;

			[Token(Token = "0x400354C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6002327")]
			[Address(RVA = "0x3F4209C", Offset = "0x3F3E09C", VA = "0x3F4209C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002328")]
			[Address(RVA = "0x3F42314", Offset = "0x3F3E314", VA = "0x3F42314", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x6002321")]
		[Address(RVA = "0x3F41FD4", Offset = "0x3F3DFD4", VA = "0x3F41FD4")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6002322")]
		[Address(RVA = "0x3F41FD8", Offset = "0x3F3DFD8", VA = "0x3F41FD8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002323")]
		[Address(RVA = "0x3F41D54", Offset = "0x3F3DD54", VA = "0x3F41D54", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__47))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002324")]
		[Address(RVA = "0x3F41FE0", Offset = "0x3F3DFE0", VA = "0x3F41FE0", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6002325")]
		[Address(RVA = "0x3F41D48", Offset = "0x3F3DD48", VA = "0x3F41D48")]
		public ADSBreakPanelComponents()
		{
		}
	}
}
