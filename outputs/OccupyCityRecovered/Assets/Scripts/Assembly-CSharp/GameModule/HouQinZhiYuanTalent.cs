using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x20003B2")]
	public class HouQinZhiYuanTalent : TalentBase
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20003B3")]
		[CompilerGenerated]
		private struct _003CStartPeriodicTask_003Ed__7 : IAsyncStateMachine
		{
			[Token(Token = "0x4002630")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002631")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002632")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public HouQinZhiYuanTalent _003C_003E4__this;

			[Token(Token = "0x4002633")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public CancellationToken token;

			[Token(Token = "0x4002634")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60010BA")]
			[Address(RVA = "0x3DA3FA8", Offset = "0x3D9FFA8", VA = "0x3DA3FA8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60010BB")]
			[Address(RVA = "0x3DA4774", Offset = "0x3DA0774", VA = "0x3DA4774", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400262C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<RoleBehaviour> nearTeamMate;

		[Token(Token = "0x400262D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<RoleBehaviour> addNearTeamMate;

		[Token(Token = "0x400262E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private CancellationTokenSource cts;

		[Token(Token = "0x400262F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private EntityBase sorce;

		[Token(Token = "0x60010B6")]
		[Address(RVA = "0x3DA3684", Offset = "0x3D9F684", VA = "0x3DA3684")]
		public HouQinZhiYuanTalent(string talentId, GameEventType eventType, float value) : base(talentId, eventType, value)
		{
			throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED HouQinZhiYuanTalent..ctor RVA=0x3DA3684 Token=0x060010B6; original base constructor arguments recovered; remaining original constructor body pending.");
		}

		[Token(Token = "0x60010B7")]
		[Address(RVA = "0x3DA3728", Offset = "0x3D9F728", VA = "0x3DA3728", Slot = "6")]
		protected override void HandleEvent(GameEventArgs args)
		{
		}

		[Token(Token = "0x60010B8")]
		[Address(RVA = "0x3DA3868", Offset = "0x3D9F868", VA = "0x3DA3868", Slot = "7")]
		public override void Clear()
		{
		}

		[Token(Token = "0x60010B9")]
		[Address(RVA = "0x3DA37CC", Offset = "0x3D9F7CC", VA = "0x3DA37CC")]
		[AsyncStateMachine(typeof(_003CStartPeriodicTask_003Ed__7))]
		private void StartPeriodicTask(CancellationToken token)
		{
		}
	}
}
