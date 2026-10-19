using GameFramework.Fsm;
using Il2CppDummyDll;

namespace CommonGameModule.Login
{
	[Token(Token = "0x2000FF4")]
	public class ServerConnectionOver : LoginStateBase
	{
		[Token(Token = "0x6005FB2")]
		[Address(RVA = "0x440B6F4", Offset = "0x44076F4", VA = "0x440B6F4", Slot = "4")]
		public override void OnInit(IFsm<LoginProcedureBase> procedureOwner)
		{
		}

		[Token(Token = "0x6005FB3")]
		[Address(RVA = "0x440B718", Offset = "0x4407718", VA = "0x440B718", Slot = "5")]
		public override void OnEnter(IFsm<LoginProcedureBase> procedureOwner)
		{
		}

		[Token(Token = "0x6005FB4")]
		[Address(RVA = "0x440B85C", Offset = "0x440785C", VA = "0x440B85C")]
		private void GoProxyLogin(IFsm<LoginProcedureBase> fsm, object sender, object userData)
		{
		}

		[Token(Token = "0x6005FB5")]
		[Address(RVA = "0x440B910", Offset = "0x4407910", VA = "0x440B910")]
		private void GoCutoverLogin(IFsm<LoginProcedureBase> fsm, object sender, object userData)
		{
		}

		[Token(Token = "0x6005FB6")]
		[Address(RVA = "0x440B9C4", Offset = "0x44079C4", VA = "0x440B9C4")]
		private void GoLoginSdk(IFsm<LoginProcedureBase> fsm, object sender, object userData)
		{
		}

		[Token(Token = "0x6005FB7")]
		[Address(RVA = "0x440BACC", Offset = "0x4407ACC", VA = "0x440BACC", Slot = "7")]
		public override void OnUpdate(IFsm<LoginProcedureBase> procedureOwner, float elapseSeconds, float realElapseSeconds)
		{
		}

		[Token(Token = "0x6005FB8")]
		[Address(RVA = "0x440BAD0", Offset = "0x4407AD0", VA = "0x440BAD0", Slot = "8")]
		public override void OnLeave(IFsm<LoginProcedureBase> procedureOwner, bool isShutdown)
		{
		}

		[Token(Token = "0x6005FB9")]
		[Address(RVA = "0x440BBD8", Offset = "0x4407BD8", VA = "0x440BBD8", Slot = "9")]
		public override void OnDestroy(IFsm<LoginProcedureBase> procedureOwner)
		{
		}

		[Token(Token = "0x6005FBA")]
		[Address(RVA = "0x44024A8", Offset = "0x43FE4A8", VA = "0x44024A8")]
		public ServerConnectionOver()
		{
		}
	}
}
