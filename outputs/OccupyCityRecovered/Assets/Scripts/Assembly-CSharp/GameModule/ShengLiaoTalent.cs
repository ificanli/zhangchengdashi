using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x20003B9")]
	public class ShengLiaoTalent : TalentBase
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20003BA")]
		[CompilerGenerated]
		private struct _003CStartPeriodicTask_003Ed__6 : IAsyncStateMachine
		{
			[Token(Token = "0x4002640")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002641")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002642")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ShengLiaoTalent _003C_003E4__this;

			[Token(Token = "0x4002643")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public CancellationToken token;

			[Token(Token = "0x4002644")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60010CC")]
			[Address(RVA = "0x3DA5838", Offset = "0x3DA1838", VA = "0x3DA5838", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60010CD")]
			[Address(RVA = "0x3DA5D88", Offset = "0x3DA1D88", VA = "0x3DA5D88", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400263D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CancellationTokenSource cts;

		[Token(Token = "0x400263E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private RoleBehaviour rolesource;

		[Token(Token = "0x400263F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool periodicTasking;

		[Token(Token = "0x60010C8")]
		[Address(RVA = "0x3DA5668", Offset = "0x3DA1668", VA = "0x3DA5668")]
		public ShengLiaoTalent(string talentId, GameEventType eventType, float value) : base(talentId, eventType, value)
		{
		}

		[Token(Token = "0x60010C9")]
		[Address(RVA = "0x3DA5670", Offset = "0x3DA1670", VA = "0x3DA5670", Slot = "6")]
		protected override void HandleEvent(GameEventArgs args)
		{
		}

		[Token(Token = "0x60010CA")]
		[Address(RVA = "0x3DA57FC", Offset = "0x3DA17FC", VA = "0x3DA57FC", Slot = "7")]
		public override void Clear()
		{
		}

		[Token(Token = "0x60010CB")]
		[Address(RVA = "0x3DA5760", Offset = "0x3DA1760", VA = "0x3DA5760")]
		[AsyncStateMachine(typeof(_003CStartPeriodicTask_003Ed__6))]
		private void StartPeriodicTask(CancellationToken token)
		{
		}
	}
}
