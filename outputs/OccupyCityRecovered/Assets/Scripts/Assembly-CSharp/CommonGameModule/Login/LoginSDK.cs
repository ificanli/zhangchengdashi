using GameFramework.Fsm;
using GameFramework.Login;
using Il2CppDummyDll;

namespace CommonGameModule.Login
{
	[Token(Token = "0x2000FED")]
	public class LoginSDK : LoginStateBase
	{
		[Token(Token = "0x4006C7A")]
		[FieldOffset(Offset = "0x28")]
		private SdkLoginType sdkLoginType;

		[Token(Token = "0x4006C7B")]
		[FieldOffset(Offset = "0x2C")]
		private bool mGamePause;

		[Token(Token = "0x4006C7C")]
		[FieldOffset(Offset = "0x30")]
		private float duringTime;

		[Token(Token = "0x6005F6F")]
		[Address(RVA = "0x4406F80", Offset = "0x4402F80", VA = "0x4406F80", Slot = "4")]
		public override void OnInit(IFsm<LoginProcedureBase> procedureOwner)
		{
		}

		[Token(Token = "0x6005F70")]
		[Address(RVA = "0x4406FA4", Offset = "0x4402FA4", VA = "0x4406FA4", Slot = "5")]
		public override void OnEnter(IFsm<LoginProcedureBase> procedureOwner)
		{
		}

		[Token(Token = "0x6005F71")]
		[Address(RVA = "0x44076B4", Offset = "0x44036B4", VA = "0x44076B4")]
		private bool CanGetSDKLogin()
		{
			return default;
		}

		[Token(Token = "0x6005F72")]
		[Address(RVA = "0x4407238", Offset = "0x4403238", VA = "0x4407238")]
		private void Login()
		{
		}

		[Token(Token = "0x6005F73")]
		[Address(RVA = "0x44071B4", Offset = "0x44031B4", VA = "0x44071B4")]
		private void CutoverLogin()
		{
		}

		[Token(Token = "0x6005F74")]
		[Address(RVA = "0x4407A68", Offset = "0x4403A68", VA = "0x4407A68")]
		private void LoginCallback(IFsm<LoginProcedureBase> fsm, object sender, object userData)
		{
		}

		[Token(Token = "0x6005F75")]
		[Address(RVA = "0x4407878", Offset = "0x4403878", VA = "0x4407878")]
		private void SDKLoginSuccess(LoginUserData sdkUser)
		{
		}

		[Token(Token = "0x6005F76")]
		[Address(RVA = "0x4407E38", Offset = "0x4403E38", VA = "0x4407E38", Slot = "7")]
		public override void OnUpdate(IFsm<LoginProcedureBase> procedureOwner, float elapseSeconds, float realElapseSeconds)
		{
		}

		[Token(Token = "0x6005F77")]
		[Address(RVA = "0x4407F14", Offset = "0x4403F14", VA = "0x4407F14", Slot = "8")]
		public override void OnLeave(IFsm<LoginProcedureBase> procedureOwner, bool isShutdown)
		{
		}

		[Token(Token = "0x6005F78")]
		[Address(RVA = "0x4407FD0", Offset = "0x4403FD0", VA = "0x4407FD0", Slot = "9")]
		public override void OnDestroy(IFsm<LoginProcedureBase> procedureOwner)
		{
		}

		[Token(Token = "0x6005F79")]
		[Address(RVA = "0x4407708", Offset = "0x4403708", VA = "0x4407708")]
		private void StartPauseGameStatus()
		{
		}

		[Token(Token = "0x6005F7A")]
		[Address(RVA = "0x4407C24", Offset = "0x4403C24", VA = "0x4407C24")]
		public void ResetPauseGameStatus()
		{
		}

		[Token(Token = "0x6005F7B")]
		[Address(RVA = "0x44024AC", Offset = "0x43FE4AC", VA = "0x44024AC")]
		public LoginSDK()
		{
		}
	}
}
