using Il2CppDummyDll;

namespace andywiecko.BurstTriangulator
{
	[Token(Token = "0x2000007")]
	public enum TriangulatorErrorType : byte
	{
		[Token(Token = "0x400000C")]
		Ok = 0,
		[Token(Token = "0x400000D")]
		PositionsLengthLessThan3 = 1,
		[Token(Token = "0x400000E")]
		PositionsMustBeFinite = 2,
		[Token(Token = "0x400000F")]
		ConstraintsLengthNotDivisibleBy2 = 3,
		[Token(Token = "0x4000010")]
		DuplicatePosition = 4,
		[Token(Token = "0x4000011")]
		DuplicateConstraint = 5,
		[Token(Token = "0x4000012")]
		ConstraintOutOfBounds = 6,
		[Token(Token = "0x4000013")]
		ConstraintSelfLoop = 7,
		[Token(Token = "0x4000014")]
		ConstraintIntersection = 8,
		[Token(Token = "0x4000015")]
		DegenerateInput = 9,
		[Token(Token = "0x4000016")]
		SloanMaxItersExceeded = 10,
		[Token(Token = "0x4000017")]
		IntegersDoNotSupportMeshRefinement = 11,
		[Token(Token = "0x4000018")]
		ConstraintArrayLengthMismatch = 12,
		[Token(Token = "0x4000019")]
		HoleMustBeFinite = 13,
		[Token(Token = "0x400001A")]
		RedudantHolesArray = 14,
		[Token(Token = "0x400001B")]
		ConstraintEdgesMissingForAutoHolesAndBoundary = 15,
		[Token(Token = "0x400001C")]
		ConstraintEdgesMissingForRestoreBoundary = 16,
		[Token(Token = "0x400001D")]
		RefinementNotSupportedForCoordinateType = 17,
		[Token(Token = "0x400001E")]
		SloanMaxItersMustBePositive = 18,
		[Token(Token = "0x400001F")]
		RefinementThresholdAreaMustBePositive = 19,
		[Token(Token = "0x4000020")]
		RefinementThresholdAngleOutOfRange = 20
	}
}
