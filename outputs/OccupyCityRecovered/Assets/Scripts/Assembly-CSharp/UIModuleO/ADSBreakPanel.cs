using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;

namespace UIModuleO
{
	[Token(Token = "0x20006A1")]
	public class ADSBreakPanel : ADSBreakPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20006A2")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__0 : IAsyncStateMachine
		{
			[Token(Token = "0x4003545")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003546")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003547")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ADSBreakPanel _003C_003E4__this;

			[Token(Token = "0x4003548")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x600231F")]
			[Address(RVA = "0x3F41DE8", Offset = "0x3F3DDE8", VA = "0x3F41DE8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002320")]
			[Address(RVA = "0x3F41FC8", Offset = "0x3F3DFC8", VA = "0x3F41FC8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x600231C")]
		[Address(RVA = "0x3F41CAC", Offset = "0x3F3DCAC", VA = "0x3F41CAC", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__0))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x600231D")]
		[Address(RVA = "0x3F41D40", Offset = "0x3F3DD40", VA = "0x3F41D40")]
		public ADSBreakPanel()
		{
		}
	}
}
