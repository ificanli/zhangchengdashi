using GameFramework.Fsm;
using Il2CppDummyDll;

namespace CommonGameModule.Login
{
	[Token(Token = "0x2000FF1")]
	public class LoginSuccess : LoginStateBase
	{
		[Token(Token = "0x6005F9D")]
		[Address(RVA = "0x440A724", Offset = "0x4406724", VA = "0x440A724", Slot = "4")]
		public override void OnInit(IFsm<LoginProcedureBase> procedureOwner)
		{
		}

		[Token(Token = "0x6005F9E")]
		[Address(RVA = "0x440A728", Offset = "0x4406728", VA = "0x440A728", Slot = "5")]
		public override void OnEnter(IFsm<LoginProcedureBase> procedureOwner)
		{
		}

		[Token(Token = "0x6005F9F")]
		[Address(RVA = "0x440A958", Offset = "0x4406958", VA = "0x440A958")]
		private void GoCutoverLogin(IFsm<LoginProcedureBase> fsm, object sender, object userData)
		{
		}

		[Token(Token = "0x6005FA0")]
		[Address(RVA = "0x440AA60", Offset = "0x4406A60", VA = "0x440AA60")]
		private void LoginOut(IFsm<LoginProcedureBase> fsm, object sender, object userData)
		{
		}

		[Token(Token = "0x6005FA1")]
		[Address(RVA = "0x440AB14", Offset = "0x4406B14", VA = "0x440AB14")]
		private void LoginInvalid(IFsm<LoginProcedureBase> fsm, object sender, object userData)
		{
		}

		[Token(Token = "0x6005FA2")]
		[Address(RVA = "0x440ABC8", Offset = "0x4406BC8", VA = "0x440ABC8", Slot = "7")]
		public override void OnUpdate(IFsm<LoginProcedureBase> procedureOwner, float elapseSeconds, float realElapseSeconds)
		{
		}

		[Token(Token = "0x6005FA3")]
		[Address(RVA = "0x440ABCC", Offset = "0x4406BCC", VA = "0x440ABCC", Slot = "8")]
		public override void OnLeave(IFsm<LoginProcedureBase> procedureOwner, bool isShutdown)
		{
		}

		[Token(Token = "0x6005FA4")]
		[Address(RVA = "0x440ACD4", Offset = "0x4406CD4", VA = "0x440ACD4", Slot = "9")]
		public override void OnDestroy(IFsm<LoginProcedureBase> procedureOwner)
		{
		}

		[Token(Token = "0x6005FA5")]
		[Address(RVA = "0x4402514", Offset = "0x43FE514", VA = "0x4402514")]
		public LoginSuccess()
		{
		}
	}
}
