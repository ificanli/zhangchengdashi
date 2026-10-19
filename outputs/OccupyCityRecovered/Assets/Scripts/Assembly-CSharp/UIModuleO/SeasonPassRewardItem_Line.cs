using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;

namespace UIModuleO
{
	[Token(Token = "0x2000B00")]
	public class SeasonPassRewardItem_Line : SeasonPassRewardItem_LineComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B01")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__3 : IAsyncStateMachine
		{
			[Token(Token = "0x40050A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40050A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40050A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SeasonPassRewardItem_Line _003C_003E4__this;

			[Token(Token = "0x40050A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60042AC")]
			[Address(RVA = "0x41D1B74", Offset = "0x41CDB74", VA = "0x41D1B74", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60042AD")]
			[Address(RVA = "0x41D289C", Offset = "0x41CE89C", VA = "0x41D289C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400509F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int itemLevel;

		[Token(Token = "0x17000ABE")]
		public int ItemLevel
		{
			[Token(Token = "0x60042A8")]
			[Address(RVA = "0x41D1A30", Offset = "0x41CDA30", VA = "0x41D1A30")]
			get
			{
				return itemLevel;
			}
		}

		[Token(Token = "0x60042A9")]
		[Address(RVA = "0x41D1A38", Offset = "0x41CDA38", VA = "0x41D1A38", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__3))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60042AA")]
		[Address(RVA = "0x41D1ACC", Offset = "0x41CDACC", VA = "0x41D1ACC")]
		public SeasonPassRewardItem_Line()
		{
		}
	}
}
