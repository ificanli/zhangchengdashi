using GameFramework.Fsm;
using Il2CppDummyDll;

namespace CommonGameModule.Login
{
	[Token(Token = "0x2000FEC")]
	public class IdelState : LoginStateBase
	{
		[Token(Token = "0x6005F68")]
		[Address(RVA = "0x4406D28", Offset = "0x4402D28", VA = "0x4406D28", Slot = "4")]
		public override void OnInit(IFsm<LoginProcedureBase> procedureOwner)
		{
		}

		[Token(Token = "0x6005F69")]
		[Address(RVA = "0x4406D4C", Offset = "0x4402D4C", VA = "0x4406D4C", Slot = "5")]
		public override void OnEnter(IFsm<LoginProcedureBase> procedureOwner)
		{
		}

		[Token(Token = "0x6005F6A")]
		[Address(RVA = "0x4406E00", Offset = "0x4402E00", VA = "0x4406E00")]
		private void GoCheckServerConnectionState(IFsm<LoginProcedureBase> fsm, object sender, object userData)
		{
		}

		[Token(Token = "0x6005F6B")]
		[Address(RVA = "0x4406EBC", Offset = "0x4402EBC", VA = "0x4406EBC", Slot = "7")]
		public override void OnUpdate(IFsm<LoginProcedureBase> procedureOwner, float elapseSeconds, float realElapseSeconds)
		{
		}

		[Token(Token = "0x6005F6C")]
		[Address(RVA = "0x4406EC0", Offset = "0x4402EC0", VA = "0x4406EC0", Slot = "8")]
		public override void OnLeave(IFsm<LoginProcedureBase> procedureOwner, bool isShutdown)
		{
		}

		[Token(Token = "0x6005F6D")]
		[Address(RVA = "0x4406F7C", Offset = "0x4402F7C", VA = "0x4406F7C", Slot = "9")]
		public override void OnDestroy(IFsm<LoginProcedureBase> procedureOwner)
		{
		}

		[Token(Token = "0x6005F6E")]
		[Address(RVA = "0x44024A0", Offset = "0x43FE4A0", VA = "0x44024A0")]
		public IdelState()
		{
		}
	}
}
