using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using GameModule;
using Il2CppDummyDll;

namespace UIModuleO
{
	[Token(Token = "0x2000819")]
	public class BackpackItem : BackpackItemComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200081A")]
		[CompilerGenerated]
		private struct _003CInitItem_003Ed__0 : IAsyncStateMachine
		{
			[Token(Token = "0x4003DF4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003DF5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003DF6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BackpackItem _003C_003E4__this;

			[Token(Token = "0x4003DF7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public BackpackData backpackData;

			[Token(Token = "0x6002D3E")]
			[Address(RVA = "0x400B868", Offset = "0x4007868", VA = "0x400B868", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002D3F")]
			[Address(RVA = "0x400C0CC", Offset = "0x40080CC", VA = "0x400C0CC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x6002D3C")]
		[Address(RVA = "0x400B7BC", Offset = "0x40077BC", VA = "0x400B7BC")]
		[AsyncStateMachine(typeof(_003CInitItem_003Ed__0))]
		public void InitItem(BackpackData backpackData)
		{
		}

		[Token(Token = "0x6002D3D")]
		[Address(RVA = "0x400B858", Offset = "0x4007858", VA = "0x400B858")]
		public BackpackItem()
		{
		}
	}
}
