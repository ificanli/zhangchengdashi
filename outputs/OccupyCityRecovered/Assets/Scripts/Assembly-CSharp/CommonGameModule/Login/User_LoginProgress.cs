using Il2CppDummyDll;

namespace CommonGameModule.Login
{
	[Token(Token = "0x2000FE5")]
	public enum User_LoginProgress
	{
		[Token(Token = "0x4006C4A")]
		E_CheckServerConnection_Begin = 0,
		[Token(Token = "0x4006C4B")]
		E_CheckServerConnection_Failed = 1,
		[Token(Token = "0x4006C4C")]
		E_CheckServerConnection_Success = 2,
		[Token(Token = "0x4006C4D")]
		E_LoginSDK_Begin = 3,
		[Token(Token = "0x4006C4E")]
		E_LoginSDK_Failed = 4,
		[Token(Token = "0x4006C4F")]
		E_LoginSDK_Success = 5,
		[Token(Token = "0x4006C50")]
		E_LoginServer_Begin = 6,
		[Token(Token = "0x4006C51")]
		E_LoginServer_Failed = 7,
		[Token(Token = "0x4006C52")]
		E_LoginServer_Success = 8,
		[Token(Token = "0x4006C53")]
		E_Lobby_Connect = 9,
		[Token(Token = "0x4006C54")]
		E_Lobby_ConnectFailed = 10,
		[Token(Token = "0x4006C55")]
		E_Lobby_BeginLogin = 11,
		[Token(Token = "0x4006C56")]
		E_Lobby_LoginFailed = 12,
		[Token(Token = "0x4006C57")]
		E_Lobby_LoginSuccess = 13
	}
}
