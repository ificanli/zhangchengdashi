using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;

[Token(Token = "0x2000006")]
public static class AwaitExtensions
{
	[Token(Token = "0x2000007")]
	private sealed class _0083w_0082_0099_0086_007C
	{
		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public TaskCompletionSource<int> tcs;

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Process process;

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x706D52C", Offset = "0x706952C", VA = "0x706D52C")]
		public _0083w_0082_0099_0086_007C()
		{
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x706D5C4", Offset = "0x70695C4", VA = "0x706D5C4")]
		internal void _00A6WM_0097m_00AD(object s, EventArgs e)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000008")]
	private struct _0089Q_0089_00BC_0060T : IAsyncStateMachine
	{
		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Task task;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x706D62C", Offset = "0x706962C", VA = "0x706D62C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x706D794", Offset = "0x7069794", VA = "0x706D794", Slot = "5")]
		[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x706D390", Offset = "0x7069390", VA = "0x706D390")]
	public static TaskAwaiter<int> GetAwaiter(this Process _00B1_00ADs_00B2_008A_0099)
	{
		return default;
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x706D534", Offset = "0x7069534", VA = "0x706D534")]
	[AsyncStateMachine(typeof(_0089Q_0089_00BC_0060T))]
	public static void WrapErrors(this Task Z_00B6_0093D_0098q)
	{
	}
}
