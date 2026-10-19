using GameFramework.Fsm;
using Il2CppDummyDll;

namespace CommonGameModule.Login
{
	[Token(Token = "0x2000FEA")]
	public class CheckServerConnection : LoginStateBase
	{
		[Token(Token = "0x6005F57")]
		[Address(RVA = "0x440514C", Offset = "0x440114C", VA = "0x440514C", Slot = "4")]
		public override void OnInit(IFsm<LoginProcedureBase> procedureOwner)
		{
		}

		[Token(Token = "0x6005F58")]
		[Address(RVA = "0x4405254", Offset = "0x4401254", VA = "0x4405254", Slot = "5")]
		public override void OnEnter(IFsm<LoginProcedureBase> procedureOwner)
		{
		}

		[Token(Token = "0x6005F59")]
		[Address(RVA = "0x4405788", Offset = "0x4401788", VA = "0x4405788")]
		private void ReceiveServerTime(object[] parms)
		{
		}

		[Token(Token = "0x6005F5A")]
		[Address(RVA = "0x4405988", Offset = "0x4401988", VA = "0x4405988", Slot = "10")]
		protected override void HttpError(int pId, string errorMsg)
		{
		}

		[Token(Token = "0x6005F5B")]
		[Address(RVA = "0x4405654", Offset = "0x4401654", VA = "0x4405654")]
		private void ConnectionToServerFail(int code)
		{
		}

		[Token(Token = "0x6005F5C")]
		[Address(RVA = "0x440578C", Offset = "0x440178C", VA = "0x440578C")]
		private void ConnectionToServerSucc()
		{
		}

		[Token(Token = "0x6005F5D")]
		[Address(RVA = "0x4406010", Offset = "0x4402010", VA = "0x4406010", Slot = "7")]
		public override void OnUpdate(IFsm<LoginProcedureBase> procedureOwner, float elapseSeconds, float realElapseSeconds)
		{
		}

		[Token(Token = "0x6005F5E")]
		[Address(RVA = "0x44060CC", Offset = "0x44020CC", VA = "0x44060CC", Slot = "8")]
		public override void OnLeave(IFsm<LoginProcedureBase> procedureOwner, bool isShutdown)
		{
		}

		[Token(Token = "0x6005F5F")]
		[Address(RVA = "0x44063B8", Offset = "0x44023B8", VA = "0x44063B8", Slot = "9")]
		public override void OnDestroy(IFsm<LoginProcedureBase> procedureOwner)
		{
		}

		[Token(Token = "0x6005F60")]
		[Address(RVA = "0x44024A4", Offset = "0x43FE4A4", VA = "0x44024A4")]
		public CheckServerConnection()
		{
		}
	}
}
