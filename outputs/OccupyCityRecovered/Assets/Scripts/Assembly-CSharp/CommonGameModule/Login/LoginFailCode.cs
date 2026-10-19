using Il2CppDummyDll;

namespace CommonGameModule.Login
{
	[Token(Token = "0x2000FE4")]
	public enum LoginFailCode
	{
		[Token(Token = "0x4006C40")]
		unknown = 0,
		[Token(Token = "0x4006C41")]
		ServerConnection = 1,
		[Token(Token = "0x4006C42")]
		LoginSDK = 2,
		[Token(Token = "0x4006C43")]
		LoginServer = 3,
		[Token(Token = "0x4006C44")]
		SynData = 4,
		[Token(Token = "0x4006C45")]
		SDKCutoverLogin = 5,
		[Token(Token = "0x4006C46")]
		ServerCutoverLogin = 6,
		[Token(Token = "0x4006C47")]
		CheckConnectionOften = 7,
		[Token(Token = "0x4006C48")]
		FSMStateError = 8
	}
}
