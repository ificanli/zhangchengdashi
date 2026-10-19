using Il2CppDummyDll;

namespace Pathfinding
{
	[Token(Token = "0x2000041")]
	public enum PathState
	{
		[Token(Token = "0x40001B8")]
		Created = 0,
		[Token(Token = "0x40001B9")]
		PathQueue = 1,
		[Token(Token = "0x40001BA")]
		Processing = 2,
		[Token(Token = "0x40001BB")]
		ReturnQueue = 3,
		[Token(Token = "0x40001BC")]
		Returning = 4,
		[Token(Token = "0x40001BD")]
		Returned = 5
	}
}
