using Il2CppDummyDll;

namespace Pathfinding
{
	[Token(Token = "0x2000042")]
	public enum PathCompleteState
	{
		[Token(Token = "0x40001BF")]
		NotCalculated = 0,
		[Token(Token = "0x40001C0")]
		Error = 1,
		[Token(Token = "0x40001C1")]
		Complete = 2,
		[Token(Token = "0x40001C2")]
		Partial = 3
	}
}
