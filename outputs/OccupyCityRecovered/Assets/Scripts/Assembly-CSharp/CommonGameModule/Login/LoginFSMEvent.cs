using Il2CppDummyDll;

namespace CommonGameModule.Login
{
	[Token(Token = "0x2000FDA")]
	public class LoginFSMEvent
	{
		[Token(Token = "0x4006C09")]
		public const int GoCheckServerConnection = 1;

		[Token(Token = "0x4006C0A")]
		public const int GoLoginSdk = 2;

		[Token(Token = "0x4006C0B")]
		public const int GoCutoverLogin = 3;

		[Token(Token = "0x4006C0C")]
		public const int LoginCallback = 4;

		[Token(Token = "0x4006C0D")]
		public const int LoginOut = 5;

		[Token(Token = "0x4006C0E")]
		public const int LoginBindResult = 6;

		[Token(Token = "0x4006C0F")]
		public const int LoginInvalid = 7;

		[Token(Token = "0x4006C10")]
		public const int GoProxyLogin = 8;

		[Token(Token = "0x6005EF0")]
		[Address(RVA = "0x43FFDC8", Offset = "0x43FBDC8", VA = "0x43FFDC8")]
		public LoginFSMEvent()
		{
		}
	}
}
