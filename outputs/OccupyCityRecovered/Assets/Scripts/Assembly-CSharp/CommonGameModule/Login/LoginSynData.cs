using GameFramework.Fsm;
using Il2CppDummyDll;

namespace CommonGameModule.Login
{
	[Token(Token = "0x2000FF2")]
	public class LoginSynData : LoginStateBase
	{
		[Token(Token = "0x4006C82")]
		[FieldOffset(Offset = "0x0")]
		public static bool Compareing;

		[Token(Token = "0x4006C83")]
		[FieldOffset(Offset = "0x28")]
		private string lastUid;

		[Token(Token = "0x6005FA6")]
		[Address(RVA = "0x440ACD8", Offset = "0x4406CD8", VA = "0x440ACD8", Slot = "4")]
		public override void OnInit(IFsm<LoginProcedureBase> procedureOwner)
		{
		}

		[Token(Token = "0x6005FA7")]
		[Address(RVA = "0x440ACDC", Offset = "0x4406CDC", VA = "0x440ACDC", Slot = "5")]
		public override void OnEnter(IFsm<LoginProcedureBase> procedureOwner)
		{
		}

		[Token(Token = "0x6005FA8")]
		[Address(RVA = "0x440AFD8", Offset = "0x4406FD8", VA = "0x440AFD8")]
		private void LoginSynDataOver(object[] Args)
		{
		}

		[Token(Token = "0x6005FA9")]
		[Address(RVA = "0x440B0A8", Offset = "0x44070A8", VA = "0x440B0A8")]
		private void SendNewPlayerUpdateloadData()
		{
		}

		[Token(Token = "0x6005FAA")]
		[Address(RVA = "0x440B1F0", Offset = "0x44071F0", VA = "0x440B1F0")]
		private void ReceiveDataUploaded(object[] Args)
		{
		}

		[Token(Token = "0x6005FAB")]
		[Address(RVA = "0x440B110", Offset = "0x4407110", VA = "0x440B110")]
		private void GoLoginSuccess()
		{
		}

		[Token(Token = "0x6005FAC")]
		[Address(RVA = "0x440B1F4", Offset = "0x44071F4", VA = "0x440B1F4", Slot = "7")]
		public override void OnUpdate(IFsm<LoginProcedureBase> procedureOwner, float elapseSeconds, float realElapseSeconds)
		{
		}

		[Token(Token = "0x6005FAD")]
		[Address(RVA = "0x440B344", Offset = "0x4407344", VA = "0x440B344", Slot = "8")]
		public override void OnLeave(IFsm<LoginProcedureBase> procedureOwner, bool isShutdown)
		{
		}

		[Token(Token = "0x6005FAE")]
		[Address(RVA = "0x440B458", Offset = "0x4407458", VA = "0x440B458", Slot = "9")]
		public override void OnDestroy(IFsm<LoginProcedureBase> procedureOwner)
		{
		}

		[Token(Token = "0x6005FAF")]
		[Address(RVA = "0x440250C", Offset = "0x43FE50C", VA = "0x440250C")]
		public LoginSynData()
		{
		}
	}
}
