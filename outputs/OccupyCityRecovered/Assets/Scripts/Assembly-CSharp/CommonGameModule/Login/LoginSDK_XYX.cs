using GameFramework.Fsm;
using GameFramework.Login;
using Il2CppDummyDll;

namespace CommonGameModule.Login
{
	[Token(Token = "0x2000FEE")]
	public class LoginSDK_XYX : LoginStateBase
	{
		[Token(Token = "0x4006C7D")]
		[FieldOffset(Offset = "0x28")]
		private SdkLoginType sdkLoginType;

		[Token(Token = "0x6005F7C")]
		[Address(RVA = "0x4407FD4", Offset = "0x4403FD4", VA = "0x4407FD4", Slot = "4")]
		public override void OnInit(IFsm<LoginProcedureBase> procedureOwner)
		{
		}

		[Token(Token = "0x6005F7D")]
		[Address(RVA = "0x4407FF8", Offset = "0x4403FF8", VA = "0x4407FF8", Slot = "5")]
		public override void OnEnter(IFsm<LoginProcedureBase> procedureOwner)
		{
		}

		[Token(Token = "0x6005F7E")]
		[Address(RVA = "0x4408280", Offset = "0x4404280", VA = "0x4408280")]
		private void Login()
		{
		}

		[Token(Token = "0x6005F7F")]
		[Address(RVA = "0x4408204", Offset = "0x4404204", VA = "0x4408204")]
		private void CutoverLogin()
		{
		}

		[Token(Token = "0x6005F80")]
		[Address(RVA = "0x4408384", Offset = "0x4404384", VA = "0x4408384")]
		private void LoginCallback(IFsm<LoginProcedureBase> fsm, object sender, object userData)
		{
		}

		[Token(Token = "0x6005F81")]
		[Address(RVA = "0x440849C", Offset = "0x440449C", VA = "0x440849C")]
		private void SDKLoginSuccess(LoginUserData sdkUser)
		{
		}

		[Token(Token = "0x6005F82")]
		[Address(RVA = "0x4408684", Offset = "0x4404684", VA = "0x4408684", Slot = "7")]
		public override void OnUpdate(IFsm<LoginProcedureBase> procedureOwner, float elapseSeconds, float realElapseSeconds)
		{
		}

		[Token(Token = "0x6005F83")]
		[Address(RVA = "0x4408688", Offset = "0x4404688", VA = "0x4408688", Slot = "8")]
		public override void OnLeave(IFsm<LoginProcedureBase> procedureOwner, bool isShutdown)
		{
		}

		[Token(Token = "0x6005F84")]
		[Address(RVA = "0x4408744", Offset = "0x4404744", VA = "0x4408744", Slot = "9")]
		public override void OnDestroy(IFsm<LoginProcedureBase> procedureOwner)
		{
		}

		[Token(Token = "0x6005F85")]
		[Address(RVA = "0x4402504", Offset = "0x43FE504", VA = "0x4402504")]
		public LoginSDK_XYX()
		{
		}
	}
}
