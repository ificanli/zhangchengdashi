using GameFramework.Fsm;
using Il2CppDummyDll;

namespace CommonGameModule.Login
{
	[Token(Token = "0x2000FF0")]
	public abstract class LoginStateBase : FsmState<LoginProcedureBase>
	{
		[Token(Token = "0x4006C7E")]
		[FieldOffset(Offset = "0x18")]
		protected IFsm<LoginProcedureBase> m_ProcedureOwner;

		[Token(Token = "0x4006C7F")]
		[FieldOffset(Offset = "0x20")]
		protected int LoginTimeOut;

		[Token(Token = "0x4006C80")]
		[FieldOffset(Offset = "0x24")]
		protected float timer;

		[Token(Token = "0x4006C81")]
		[FieldOffset(Offset = "0x0")]
		protected static bool LoginSuccess;

		[Token(Token = "0x6005F93")]
		[Address(RVA = "0x4405170", Offset = "0x4401170", VA = "0x4405170", Slot = "4")]
		public override void OnInit(IFsm<LoginProcedureBase> procedureOwner)
		{
		}

		[Token(Token = "0x6005F94")]
		[Address(RVA = "0x440A560", Offset = "0x4406560", VA = "0x440A560")]
		private void HttpWebRequestError(object[] parms)
		{
		}

		[Token(Token = "0x6005F95")]
		[Address(RVA = "0x440A640", Offset = "0x4406640", VA = "0x440A640")]
		private void HttpServerErrorCode(object[] parms)
		{
		}

		[Token(Token = "0x6005F96")]
		[Address(RVA = "0x44059C4", Offset = "0x44019C4", VA = "0x44059C4", Slot = "10")]
		protected virtual void HttpError(int pId, string errorMsg)
		{
		}

		[Token(Token = "0x6005F97")]
		[Address(RVA = "0x4405434", Offset = "0x4401434", VA = "0x4405434", Slot = "5")]
		public override void OnEnter(IFsm<LoginProcedureBase> procedureOwner)
		{
		}

		[Token(Token = "0x6005F98")]
		[Address(RVA = "0x440605C", Offset = "0x440205C", VA = "0x440605C", Slot = "7")]
		public override void OnUpdate(IFsm<LoginProcedureBase> procedureOwner, float elapseSeconds, float realElapseSeconds)
		{
		}

		[Token(Token = "0x6005F99")]
		[Address(RVA = "0x4406184", Offset = "0x4402184", VA = "0x4406184", Slot = "8")]
		public override void OnLeave(IFsm<LoginProcedureBase> procedureOwner, bool isShutdown)
		{
		}

		[Token(Token = "0x6005F9A")]
		[Address(RVA = "0x44063BC", Offset = "0x44023BC", VA = "0x44063BC", Slot = "9")]
		public override void OnDestroy(IFsm<LoginProcedureBase> procedureOwner)
		{
		}

		[Token(Token = "0x6005F9B")]
		[Address(RVA = "0x4405B14", Offset = "0x4401B14", VA = "0x4405B14")]
		protected void FireLoginError(LoginFailCode loginFailCode, string ErrorMsg)
		{
		}

		[Token(Token = "0x6005F9C")]
		[Address(RVA = "0x4406414", Offset = "0x4402414", VA = "0x4406414")]
		protected LoginStateBase()
		{
		}
	}
}
