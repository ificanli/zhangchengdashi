using GameFramework.Fsm;
using Il2CppDummyDll;

namespace CommonGameModule.Login
{
	[Token(Token = "0x2000FF3")]
	public class ProxyLogin : LoginStateBase
	{
		[Token(Token = "0x4006C84")]
		[FieldOffset(Offset = "0x28")]
		private string _userId;

		[Token(Token = "0x6005FB0")]
		[Address(RVA = "0x440B45C", Offset = "0x440745C", VA = "0x440B45C", Slot = "5")]
		public override void OnEnter(IFsm<LoginProcedureBase> procedureOwner)
		{
		}

		[Token(Token = "0x6005FB1")]
		[Address(RVA = "0x44024B0", Offset = "0x43FE4B0", VA = "0x44024B0")]
		public ProxyLogin()
		{
		}
	}
}
