using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;

namespace UIModuleO
{
	[Token(Token = "0x2000B9B")]
	public class TabGroup : TabGroupComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B9C")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__0 : IAsyncStateMachine
		{
			[Token(Token = "0x4005454")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005455")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005456")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public TabGroup _003C_003E4__this;

			[Token(Token = "0x4005457")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6004727")]
			[Address(RVA = "0x421F650", Offset = "0x421B650", VA = "0x421F650", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004728")]
			[Address(RVA = "0x421F830", Offset = "0x421B830", VA = "0x421F830", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x6004724")]
		[Address(RVA = "0x421F514", Offset = "0x421B514", VA = "0x421F514", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__0))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6004725")]
		[Address(RVA = "0x421F5A8", Offset = "0x421B5A8", VA = "0x421F5A8")]
		public TabGroup()
		{
		}
	}
}
