using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace UIModuleO
{
	[Token(Token = "0x2000715")]
	public class BenefitValueItem : benefitValueItemComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000717")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__0 : IAsyncStateMachine
		{
			[Token(Token = "0x400384B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400384C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400384D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string ipaId;

			[Token(Token = "0x400384E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public BenefitValueItem _003C_003E4__this;

			[Token(Token = "0x6002696")]
			[Address(RVA = "0x3F966F8", Offset = "0x3F926F8", VA = "0x3F966F8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002697")]
			[Address(RVA = "0x3F96934", Offset = "0x3F92934", VA = "0x3F96934", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x6002691")]
		[Address(RVA = "0x3F964CC", Offset = "0x3F924CC", VA = "0x3F964CC")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__0))]
		public void Init(string ipaId)
		{
		}

		[Token(Token = "0x6002692")]
		[Address(RVA = "0x3F96568", Offset = "0x3F92568", VA = "0x3F96568")]
		public void Init(int value)
		{
		}

		[Token(Token = "0x6002693")]
		[Address(RVA = "0x3F966C0", Offset = "0x3F926C0", VA = "0x3F966C0")]
		public BenefitValueItem()
		{
		}
	}
}
