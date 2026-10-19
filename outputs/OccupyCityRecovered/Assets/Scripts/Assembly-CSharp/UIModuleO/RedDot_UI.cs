using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;

namespace UIModuleO
{
	[Token(Token = "0x2000ACC")]
	public class RedDot_UI : RedDot_UIComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000ACD")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__1 : IAsyncStateMachine
		{
			[Token(Token = "0x4004F52")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004F53")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004F54")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public RedDot_UI _003C_003E4__this;

			[Token(Token = "0x4004F55")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6004143")]
			[Address(RVA = "0x41B8670", Offset = "0x41B4670", VA = "0x41B8670", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6004144")]
			[Address(RVA = "0x41B8930", Offset = "0x41B4930", VA = "0x41B8930", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004F51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private string badgeName;

		[Token(Token = "0x600413E")]
		[Address(RVA = "0x41B818C", Offset = "0x41B418C", VA = "0x41B818C", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__1))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x600413F")]
		[Address(RVA = "0x41B8220", Offset = "0x41B4220", VA = "0x41B8220", Slot = "9")]
		public override void UpdateInfo(params object[] args)
		{
		}

		[Token(Token = "0x6004140")]
		[Address(RVA = "0x41B84B4", Offset = "0x41B44B4", VA = "0x41B84B4")]
		private void UpdateBadgeNumberText(int number)
		{
		}

		[Token(Token = "0x6004141")]
		[Address(RVA = "0x41B85C8", Offset = "0x41B45C8", VA = "0x41B85C8")]
		public RedDot_UI()
		{
		}
	}
}
