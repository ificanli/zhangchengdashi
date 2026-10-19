using Il2CppDummyDll;
using Unity.Collections;
using Unity.Mathematics;

namespace andywiecko.BurstTriangulator
{
	[Token(Token = "0x2000006")]
	public struct Status
	{
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x0")]
		private int value1;

		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x4")]
		private int value2;

		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x8")]
		private int value3;

		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0xC")]
		private int value4;

		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x10")]
		public TriangulatorErrorType type;

		[Token(Token = "0x17000001")]
		public bool IsError
		{
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x3CF2D10", Offset = "0x3CEED10", VA = "0x3CF2D10")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000002")]
		public static Status Ok
		{
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x3CF2D20", Offset = "0x3CEED20", VA = "0x3CF2D20")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000003")]
		public static Status DegenerateInput
		{
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x3CF2E24", Offset = "0x3CEEE24", VA = "0x3CF2E24")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000004")]
		public static Status SloanMaxItersExceeded
		{
			[Token(Token = "0x6000010")]
			[Address(RVA = "0x3CF2E3C", Offset = "0x3CEEE3C", VA = "0x3CF2E3C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000005")]
		public static Status IntegersDoNotSupportMeshRefinement
		{
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x3CF2E54", Offset = "0x3CEEE54", VA = "0x3CF2E54")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000006")]
		public static Status RedudantHolesArray
		{
			[Token(Token = "0x6000014")]
			[Address(RVA = "0x3CF2EA8", Offset = "0x3CEEEA8", VA = "0x3CF2EA8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000007")]
		public static Status ConstraintEdgesMissingForAutoHolesAndBoundary
		{
			[Token(Token = "0x6000015")]
			[Address(RVA = "0x3CF2EC0", Offset = "0x3CEEEC0", VA = "0x3CF2EC0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000008")]
		public static Status ConstraintEdgesMissingForRestoreBoundary
		{
			[Token(Token = "0x6000016")]
			[Address(RVA = "0x3CF2ED8", Offset = "0x3CEEED8", VA = "0x3CF2ED8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000009")]
		public static Status RefinementNotSupportedForCoordinateType
		{
			[Token(Token = "0x6000017")]
			[Address(RVA = "0x3CF2EF0", Offset = "0x3CEEEF0", VA = "0x3CF2EF0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700000A")]
		public static Status RefinementThresholdAreaMustBePositive
		{
			[Token(Token = "0x6000019")]
			[Address(RVA = "0x3CF2F28", Offset = "0x3CEEF28", VA = "0x3CF2F28")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700000B")]
		public static Status RefinementThresholdAngleOutOfRange
		{
			[Token(Token = "0x600001A")]
			[Address(RVA = "0x3CF2F40", Offset = "0x3CEEF40", VA = "0x3CF2F40")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x3CF2D2C", Offset = "0x3CEED2C", VA = "0x3CF2D2C")]
		public static Status PositionsLengthLessThan3(int length)
		{
			return default;
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x3CF2D4C", Offset = "0x3CEED4C", VA = "0x3CF2D4C")]
		public static Status PositionsMustBeFinite(int index)
		{
			return default;
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x3CF2D6C", Offset = "0x3CEED6C", VA = "0x3CF2D6C")]
		public static Status ConstraintsLengthNotDivisibleBy2(int length)
		{
			return default;
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x3CF2D8C", Offset = "0x3CEED8C", VA = "0x3CF2D8C")]
		public static Status DuplicatePosition(int index)
		{
			return default;
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x3CF2DAC", Offset = "0x3CEEDAC", VA = "0x3CF2DAC")]
		public static Status DuplicateConstraint(int index1, int index2)
		{
			return default;
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x3CF2DC8", Offset = "0x3CEEDC8", VA = "0x3CF2DC8")]
		public static Status ConstraintOutOfBounds(int index, int2 constraint, int positionLength)
		{
			return default;
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x3CF2DE8", Offset = "0x3CEEDE8", VA = "0x3CF2DE8")]
		public static Status ConstraintSelfLoop(int index, int2 constraint)
		{
			return default;
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x3CF2E08", Offset = "0x3CEEE08", VA = "0x3CF2E08")]
		public static Status ConstraintIntersection(int index1, int index2)
		{
			return default;
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x3CF2E6C", Offset = "0x3CEEE6C", VA = "0x3CF2E6C")]
		public static Status ConstraintArrayLengthMismatch(int constraintLength, int constraintTypeLength)
		{
			return default;
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x3CF2E88", Offset = "0x3CEEE88", VA = "0x3CF2E88")]
		public static Status HoleMustBeFinite(int index)
		{
			return default;
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x3CF2F08", Offset = "0x3CEEF08", VA = "0x3CF2F08")]
		public static Status SloanMaxItersMustBePositive(int sloanMaxIters)
		{
			return default;
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x3CF2F58", Offset = "0x3CEEF58", VA = "0x3CF2F58")]
		internal FixedString64Bytes ToFixedString()
		{
			return default;
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x3CF2FF0", Offset = "0x3CEEFF0", VA = "0x3CF2FF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
