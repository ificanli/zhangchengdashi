using GameFramework.Fsm;
using GameFramework.Procedure;
using Il2CppDummyDll;

namespace ljzs_lt.Procedure
{
	[Token(Token = "0x2000F50")]
	public class ProcedureExitGame : ProcedureBase
	{
		[Token(Token = "0x40069D1")]
		[FieldOffset(Offset = "0x18")]
		private IFsm<IProcedureManager> m_ProcedureOwner;

		[Token(Token = "0x6005BAD")]
		[Address(RVA = "0x439F784", Offset = "0x439B784", VA = "0x439F784", Slot = "4")]
		public override void OnInit(IFsm<IProcedureManager> procedureOwner)
		{
		}

		[Token(Token = "0x6005BAE")]
		[Address(RVA = "0x439F7AC", Offset = "0x439B7AC", VA = "0x439F7AC", Slot = "5")]
		public override void OnEnter(IFsm<IProcedureManager> procedureOwner)
		{
		}

		[Token(Token = "0x6005BAF")]
		[Address(RVA = "0x439F7C0", Offset = "0x439B7C0", VA = "0x439F7C0")]
		private void ExitGame()
		{
		}

		[Token(Token = "0x6005BB0")]
		[Address(RVA = "0x439F830", Offset = "0x439B830", VA = "0x439F830", Slot = "7")]
		public override void OnUpdate(IFsm<IProcedureManager> procedureOwner, float elapseSeconds, float realElapseSeconds)
		{
		}

		[Token(Token = "0x6005BB1")]
		[Address(RVA = "0x439F838", Offset = "0x439B838", VA = "0x439F838", Slot = "8")]
		public override void OnLeave(IFsm<IProcedureManager> procedureOwner, bool isShutdown)
		{
		}

		[Token(Token = "0x6005BB2")]
		[Address(RVA = "0x439F844", Offset = "0x439B844", VA = "0x439F844", Slot = "9")]
		public override void OnDestroy(IFsm<IProcedureManager> procedureOwner)
		{
		}

		[Token(Token = "0x6005BB3")]
		[Address(RVA = "0x439BC84", Offset = "0x4397C84", VA = "0x439BC84")]
		public ProcedureExitGame()
		{
		}
	}
}
