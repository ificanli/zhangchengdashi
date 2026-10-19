using Il2CppDummyDll;

namespace Pathfinding
{
	[Token(Token = "0x200003C")]
	public enum Heuristic
	{
		[Token(Token = "0x4000198")]
		Manhattan = 0,
		[Token(Token = "0x4000199")]
		DiagonalManhattan = 1,
		[Token(Token = "0x400019A")]
		Euclidean = 2,
		[Token(Token = "0x400019B")]
		None = 3
	}
}
