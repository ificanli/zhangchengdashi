using Il2CppDummyDll;

namespace andywiecko.BurstTriangulator
{
	[Token(Token = "0x200000B")]
	public enum ConstraintType : byte
	{
		[Token(Token = "0x4000030")]
		Constrained = 0,
		[Token(Token = "0x4000031")]
		ConstrainedAndHoleBoundary = 1
	}
}
