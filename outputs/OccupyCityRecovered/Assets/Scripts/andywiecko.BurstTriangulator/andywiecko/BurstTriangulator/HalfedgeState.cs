using Il2CppDummyDll;

namespace andywiecko.BurstTriangulator
{
	[Token(Token = "0x200000C")]
	public enum HalfedgeState : byte
	{
		[Token(Token = "0x4000033")]
		Unconstrained = 0,
		[Token(Token = "0x4000034")]
		Constrained = 1,
		[Token(Token = "0x4000035")]
		ConstrainedAndHoleBoundary = 2
	}
}
