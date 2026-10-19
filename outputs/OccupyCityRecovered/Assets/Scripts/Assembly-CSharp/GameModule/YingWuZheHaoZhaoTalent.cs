using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x20003C1")]
	public class YingWuZheHaoZhaoTalent : TalentBase
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20003C2")]
		[CompilerGenerated]
		private struct _003CStartPeriodicTask_003Ed__7 : IAsyncStateMachine
		{
			[Token(Token = "0x4002654")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002655")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002656")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public YingWuZheHaoZhaoTalent _003C_003E4__this;

			[Token(Token = "0x4002657")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public CancellationToken token;

			[Token(Token = "0x4002658")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60010E1")]
			[Address(RVA = "0x3DA6FF4", Offset = "0x3DA2FF4", VA = "0x3DA6FF4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60010E2")]
			[Address(RVA = "0x3DA7B74", Offset = "0x3DA3B74", VA = "0x3DA7B74", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4002650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<RoleBehaviour> tempNearTeamMate;

		[Token(Token = "0x4002651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Dictionary<RoleBehaviour, float> NearTeamMate;

		[Token(Token = "0x4002652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private RoleBehaviour rolesource;

		[Token(Token = "0x4002653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private CancellationTokenSource cts;

		[Token(Token = "0x60010DD")]
		[Address(RVA = "0x3DA6BF8", Offset = "0x3DA2BF8", VA = "0x3DA6BF8")]
		public YingWuZheHaoZhaoTalent(string talentId, GameEventType eventType, float value) : base(talentId, eventType, value)
		{
			throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED YingWuZheHaoZhaoTalent..ctor RVA=0x3DA6BF8 Token=0x060010DD; original base constructor arguments recovered; remaining original constructor body pending.");
		}

		[Token(Token = "0x60010DE")]
		[Address(RVA = "0x3DA6C9C", Offset = "0x3DA2C9C", VA = "0x3DA6C9C", Slot = "6")]
		protected override void HandleEvent(GameEventArgs args)
		{
		}

		[Token(Token = "0x60010DF")]
		[Address(RVA = "0x3DA6E30", Offset = "0x3DA2E30", VA = "0x3DA6E30", Slot = "7")]
		public override void Clear()
		{
		}

		[Token(Token = "0x60010E0")]
		[Address(RVA = "0x3DA6D94", Offset = "0x3DA2D94", VA = "0x3DA6D94")]
		[AsyncStateMachine(typeof(_003CStartPeriodicTask_003Ed__7))]
		private void StartPeriodicTask(CancellationToken token)
		{
		}
	}
}
