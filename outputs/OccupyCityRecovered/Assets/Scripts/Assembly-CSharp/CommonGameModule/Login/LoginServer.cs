using GameFramework.Fsm;
using GameFramework.Net.Http;
using Il2CppDummyDll;

namespace CommonGameModule.Login
{
	[Token(Token = "0x2000FEF")]
	public class LoginServer : LoginStateBase
	{
		[Token(Token = "0x6005F86")]
		[Address(RVA = "0x4408748", Offset = "0x4404748", VA = "0x4408748", Slot = "4")]
		public override void OnInit(IFsm<LoginProcedureBase> procedureOwner)
		{
		}

		[Token(Token = "0x6005F87")]
		[Address(RVA = "0x440876C", Offset = "0x440476C", VA = "0x440876C", Slot = "5")]
		public override void OnEnter(IFsm<LoginProcedureBase> procedureOwner)
		{
		}

		[Token(Token = "0x6005F88")]
		[Address(RVA = "0x4408EB8", Offset = "0x4404EB8", VA = "0x4408EB8")]
		private void ReceiveLogin(object[] parms)
		{
		}

		[Token(Token = "0x6005F89")]
		[Address(RVA = "0x4409F64", Offset = "0x4405F64", VA = "0x4409F64", Slot = "10")]
		protected override void HttpError(int pId, string errorMsg)
		{
		}

		[Token(Token = "0x6005F8A")]
		[Address(RVA = "0x4409FE4", Offset = "0x4405FE4", VA = "0x4409FE4")]
		private void LoginBindResult(IFsm<LoginProcedureBase> fsm, object sender, object userData)
		{
		}

		[Token(Token = "0x6005F8B")]
		[Address(RVA = "0x4409028", Offset = "0x4405028", VA = "0x4409028")]
		private void Fail(string ErrorMsg)
		{
		}

		[Token(Token = "0x6005F8C")]
		[Address(RVA = "0x4409154", Offset = "0x4405154", VA = "0x4409154")]
		private void Success(ResponseLoginInfo.Data useInfo)
		{
		}

		[Token(Token = "0x6005F8D")]
		[Address(RVA = "0x440A124", Offset = "0x4406124", VA = "0x440A124")]
		private void GoLogin()
		{
		}

		[Token(Token = "0x6005F8E")]
		[Address(RVA = "0x440A070", Offset = "0x4406070", VA = "0x440A070")]
		private void GoBindLogin()
		{
		}

		[Token(Token = "0x6005F8F")]
		[Address(RVA = "0x440A390", Offset = "0x4406390", VA = "0x440A390", Slot = "7")]
		public override void OnUpdate(IFsm<LoginProcedureBase> procedureOwner, float elapseSeconds, float realElapseSeconds)
		{
		}

		[Token(Token = "0x6005F90")]
		[Address(RVA = "0x440A428", Offset = "0x4406428", VA = "0x440A428", Slot = "8")]
		public override void OnLeave(IFsm<LoginProcedureBase> procedureOwner, bool isShutdown)
		{
		}

		[Token(Token = "0x6005F91")]
		[Address(RVA = "0x440A55C", Offset = "0x440655C", VA = "0x440A55C", Slot = "9")]
		public override void OnDestroy(IFsm<LoginProcedureBase> procedureOwner)
		{
		}

		[Token(Token = "0x6005F92")]
		[Address(RVA = "0x4402508", Offset = "0x43FE508", VA = "0x4402508")]
		public LoginServer()
		{
		}
	}
}
