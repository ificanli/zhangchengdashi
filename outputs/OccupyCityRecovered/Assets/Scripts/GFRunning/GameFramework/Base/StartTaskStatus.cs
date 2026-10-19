using Il2CppDummyDll;

namespace GameFramework.Base
{
	[Token(Token = "0x20004C3")]
	public enum StartTaskStatus : byte
	{
		[Token(Token = "0x4001F81")]
		Done = 0,
		[Token(Token = "0x4001F82")]
		CanResume = 1,
		[Token(Token = "0x4001F83")]
		HasToWait = 2,
		[Token(Token = "0x4001F84")]
		UnknownError = 3
	}
}
