using GameFramework.Fsm;
using Il2CppDummyDll;

namespace CommonGameModule.Login
{
	[Token(Token = "0x2000FEB")]
	public class CutoverLoginSynData : LoginStateBase
	{
		[Token(Token = "0x6005F61")]
		[Address(RVA = "0x4406464", Offset = "0x4402464", VA = "0x4406464", Slot = "4")]
		public override void OnInit(IFsm<LoginProcedureBase> procedureOwner)
		{
		}

		[Token(Token = "0x6005F62")]
		[Address(RVA = "0x4406488", Offset = "0x4402488", VA = "0x4406488", Slot = "5")]
		public override void OnEnter(IFsm<LoginProcedureBase> procedureOwner)
		{
		}

		[Token(Token = "0x6005F63")]
		[Address(RVA = "0x4406700", Offset = "0x4402700", VA = "0x4406700")]
		private void ServerBindOver(object[] Args)
		{
		}

		[Token(Token = "0x6005F64")]
		[Address(RVA = "0x4406BD0", Offset = "0x4402BD0", VA = "0x4406BD0", Slot = "7")]
		public override void OnUpdate(IFsm<LoginProcedureBase> procedureOwner, float elapseSeconds, float realElapseSeconds)
		{
		}

		[Token(Token = "0x6005F65")]
		[Address(RVA = "0x4406C6C", Offset = "0x4402C6C", VA = "0x4406C6C", Slot = "8")]
		public override void OnLeave(IFsm<LoginProcedureBase> procedureOwner, bool isShutdown)
		{
		}

		[Token(Token = "0x6005F66")]
		[Address(RVA = "0x4406D24", Offset = "0x4402D24", VA = "0x4406D24", Slot = "9")]
		public override void OnDestroy(IFsm<LoginProcedureBase> procedureOwner)
		{
		}

		[Token(Token = "0x6005F67")]
		[Address(RVA = "0x4402510", Offset = "0x43FE510", VA = "0x4402510")]
		public CutoverLoginSynData()
		{
		}
	}
}
