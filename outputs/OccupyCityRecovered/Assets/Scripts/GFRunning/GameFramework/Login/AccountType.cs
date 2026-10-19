using Il2CppDummyDll;

namespace GameFramework.Login
{
	[Token(Token = "0x20004ED")]
	public enum AccountType
	{
		[Token(Token = "0x400200E")]
		None = 10,
		[Token(Token = "0x400200F")]
		TryGame = 1,
		[Token(Token = "0x4002010")]
		OnlyLogin = 2,
		[Token(Token = "0x4002011")]
		Tourist = 11,
		[Token(Token = "0x4002012")]
		Account = 12,
		[Token(Token = "0x4002013")]
		ProxyLogin = 13
	}
}
