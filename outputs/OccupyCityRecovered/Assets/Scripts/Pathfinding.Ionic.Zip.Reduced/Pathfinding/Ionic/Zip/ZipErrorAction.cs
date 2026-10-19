using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zip
{
	[Token(Token = "0x2000030")]
	public enum ZipErrorAction
	{
		[Token(Token = "0x40000DC")]
		Throw = 0,
		[Token(Token = "0x40000DD")]
		Skip = 1,
		[Token(Token = "0x40000DE")]
		Retry = 2,
		[Token(Token = "0x40000DF")]
		InvokeErrorEvent = 3
	}
}
