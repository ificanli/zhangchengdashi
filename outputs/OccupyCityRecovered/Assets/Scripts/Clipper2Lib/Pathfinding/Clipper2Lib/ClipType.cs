using Il2CppDummyDll;

namespace Pathfinding.Clipper2Lib
{
	[Token(Token = "0x200000D")]
	public enum ClipType
	{
		[Token(Token = "0x4000010")]
		None = 0,
		[Token(Token = "0x4000011")]
		Intersection = 1,
		[Token(Token = "0x4000012")]
		Union = 2,
		[Token(Token = "0x4000013")]
		Difference = 3,
		[Token(Token = "0x4000014")]
		Xor = 4
	}
}
