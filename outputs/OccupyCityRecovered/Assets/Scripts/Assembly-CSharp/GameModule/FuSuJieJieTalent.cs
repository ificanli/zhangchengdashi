using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x20003AE")]
	public class FuSuJieJieTalent : TalentBase
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20003AF")]
		[CompilerGenerated]
		private struct _003CStartPeriodicTask_003Ed__6 : IAsyncStateMachine
		{
			[Token(Token = "0x4002624")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002625")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002626")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public FuSuJieJieTalent _003C_003E4__this;

			[Token(Token = "0x4002627")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public CancellationToken token;

			[Token(Token = "0x4002628")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60010AF")]
			[Address(RVA = "0x3DA2A40", Offset = "0x3D9EA40", VA = "0x3DA2A40", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60010B0")]
			[Address(RVA = "0x3DA2F9C", Offset = "0x3D9EF9C", VA = "0x3DA2F9C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4002621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CancellationTokenSource cts;

		[Token(Token = "0x4002622")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<RoleBehaviour> nearTeamMate;

		[Token(Token = "0x4002623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private EntityBase sorce;

		[Token(Token = "0x60010AB")]
		[Address(RVA = "0x3DA28B4", Offset = "0x3D9E8B4", VA = "0x3DA28B4")]
		public FuSuJieJieTalent(string talentId, GameEventType eventType, float value) : base(talentId, eventType, value)
		{
		}

		[Token(Token = "0x60010AC")]
		[Address(RVA = "0x3DA28BC", Offset = "0x3D9E8BC", VA = "0x3DA28BC", Slot = "6")]
		protected override void HandleEvent(GameEventArgs args)
		{
		}

		[Token(Token = "0x60010AD")]
		[Address(RVA = "0x3DA2A04", Offset = "0x3D9EA04", VA = "0x3DA2A04", Slot = "7")]
		public override void Clear()
		{
		}

		[Token(Token = "0x60010AE")]
		[Address(RVA = "0x3DA2968", Offset = "0x3D9E968", VA = "0x3DA2968")]
		[AsyncStateMachine(typeof(_003CStartPeriodicTask_003Ed__6))]
		private void StartPeriodicTask(CancellationToken token)
		{
		}
	}
}
