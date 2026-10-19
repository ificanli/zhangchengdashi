using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x20003BF")]
	public class XiShengQiYueTalent : TalentBase
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20003C0")]
		[CompilerGenerated]
		private struct _003CStartPeriodicTask_003Ed__7 : IAsyncStateMachine
		{
			[Token(Token = "0x400264B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400264C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400264D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public XiShengQiYueTalent _003C_003E4__this;

			[Token(Token = "0x400264E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public CancellationToken token;

			[Token(Token = "0x400264F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60010DB")]
			[Address(RVA = "0x3DA67A0", Offset = "0x3DA27A0", VA = "0x3DA67A0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60010DC")]
			[Address(RVA = "0x3DA6BEC", Offset = "0x3DA2BEC", VA = "0x3DA6BEC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4002647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		private bool canPact;

		[Token(Token = "0x4002648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<RoleBehaviour> nearTeamMate;

		[Token(Token = "0x4002649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private RoleBehaviour rolesource;

		[Token(Token = "0x400264A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private CancellationTokenSource cts;

		[Token(Token = "0x60010D7")]
		[Address(RVA = "0x3DA63C8", Offset = "0x3DA23C8", VA = "0x3DA63C8")]
		public XiShengQiYueTalent(string talentId, GameEventType eventType, float value) : base(talentId, eventType, value)
		{
		}

		[Token(Token = "0x60010D8")]
		[Address(RVA = "0x3DA63D0", Offset = "0x3DA23D0", VA = "0x3DA63D0", Slot = "6")]
		protected override void HandleEvent(GameEventArgs args)
		{
		}

		[Token(Token = "0x60010D9")]
		[Address(RVA = "0x3DA66D8", Offset = "0x3DA26D8", VA = "0x3DA66D8", Slot = "7")]
		public override void Clear()
		{
		}

		[Token(Token = "0x60010DA")]
		[Address(RVA = "0x3DA6640", Offset = "0x3DA2640", VA = "0x3DA6640")]
		[AsyncStateMachine(typeof(_003CStartPeriodicTask_003Ed__7))]
		private void StartPeriodicTask(CancellationToken token)
		{
		}
	}
}
