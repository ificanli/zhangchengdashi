using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;

namespace UIModuleO
{
	[Token(Token = "0x20008A3")]
	public class FundRewardItem_Line : FundRewardItem_LineComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20008A4")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__4 : IAsyncStateMachine
		{
			[Token(Token = "0x4004160")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004161")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004162")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public FundRewardItem_Line _003C_003E4__this;

			[Token(Token = "0x4004163")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60030E4")]
			[Address(RVA = "0x405491C", Offset = "0x405091C", VA = "0x405491C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60030E5")]
			[Address(RVA = "0x40561B8", Offset = "0x40521B8", VA = "0x40561B8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400415D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private List<FundRewardItem> _fundRewardItems2;

		[Token(Token = "0x400415E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private List<FundRewardItem> _fundRewardItems3;

		[Token(Token = "0x400415F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int currentUseItmes;

		[Token(Token = "0x60030E0")]
		[Address(RVA = "0x40545A4", Offset = "0x40505A4", VA = "0x40545A4", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60030E1")]
		[Address(RVA = "0x40547E0", Offset = "0x40507E0", VA = "0x40547E0", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__4))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60030E2")]
		[Address(RVA = "0x4054874", Offset = "0x4050874", VA = "0x4054874")]
		public FundRewardItem_Line()
		{
		}
	}
}
