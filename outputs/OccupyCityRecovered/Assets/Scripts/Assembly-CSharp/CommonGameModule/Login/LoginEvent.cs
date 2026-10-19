using Il2CppDummyDll;

namespace CommonGameModule.Login
{
	[Token(Token = "0x2000FDB")]
	public class LoginEvent
	{
		[Token(Token = "0x4006C11")]
		public const string LoginProgress = "LoginProgress";

		[Token(Token = "0x4006C12")]
		public const string CutOverLogin = "CutOverLogin";

		[Token(Token = "0x6005EF1")]
		[Address(RVA = "0x43FFDD0", Offset = "0x43FBDD0", VA = "0x43FFDD0")]
		public LoginEvent()
		{
		}
	}
}
