using GameFramework.Fsm;
using Il2CppDummyDll;

namespace GameFramework.Procedure
{
	[Token(Token = "0x2000452")]
	public abstract class ProcedureBase : FsmState<IProcedureManager>
	{
		[Token(Token = "0x6006A22")]
		[Address(RVA = "0x727A5EC", Offset = "0x72765EC", VA = "0x727A5EC", Slot = "4")]
		public override void OnInit(IFsm<IProcedureManager> procedureOwner)
		{
		}

		[Token(Token = "0x6006A23")]
		[Address(RVA = "0x727A644", Offset = "0x7276644", VA = "0x727A644", Slot = "5")]
		public override void OnEnter(IFsm<IProcedureManager> procedureOwner)
		{
		}

		[Token(Token = "0x6006A24")]
		[Address(RVA = "0x727A790", Offset = "0x7276790", VA = "0x727A790", Slot = "7")]
		public override void OnUpdate(IFsm<IProcedureManager> procedureOwner, float elapseSeconds, float realElapseSeconds)
		{
		}

		[Token(Token = "0x6006A25")]
		[Address(RVA = "0x727A800", Offset = "0x7276800", VA = "0x727A800", Slot = "8")]
		public override void OnLeave(IFsm<IProcedureManager> procedureOwner, bool isShutdown)
		{
		}

		[Token(Token = "0x6006A26")]
		[Address(RVA = "0x727A95C", Offset = "0x727695C", VA = "0x727A95C", Slot = "9")]
		public override void OnDestroy(IFsm<IProcedureManager> procedureOwner)
		{
		}

		[Token(Token = "0x6006A27")]
		[Address(RVA = "0x727A9B4", Offset = "0x72769B4", VA = "0x727A9B4")]
		protected ProcedureBase()
		{
		}
	}
}
