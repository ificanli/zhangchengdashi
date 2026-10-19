using Il2CppDummyDll;
using Unity.Collections;
using Unity.Mathematics;

namespace andywiecko.BurstTriangulator.LowLevel.Unsafe
{
	[Token(Token = "0x2000028")]
	internal readonly struct TransformDouble : ITransform<TransformDouble, double, double2>
	{
		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0x0")]
		private readonly double2x2 rotScale;

		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x20")]
		private readonly double2 translation;

		[Token(Token = "0x1700002D")]
		public TransformDouble Identity
		{
			[Token(Token = "0x60000D9")]
			[Address(RVA = "0x3CF5AC4", Offset = "0x3CF1AC4", VA = "0x3CF5AC4", Slot = "5")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700002E")]
		public double AreaScalingFactor
		{
			[Token(Token = "0x60000DA")]
			[Address(RVA = "0x3CF5B50", Offset = "0x3CF1B50", VA = "0x3CF5B50", Slot = "4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x3CF5B40", Offset = "0x3CF1B40", VA = "0x3CF5B40")]
		public TransformDouble(double2x2 rotScale, double2 translation)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED TransformDouble..ctor RVA=0x3CF5B40 Token=0x60000DB");
}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x3CF5B68", Offset = "0x3CF1B68", VA = "0x3CF5B68")]
		private static TransformDouble Translate(double2 offset)
		{
			return default;
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x3CF5BCC", Offset = "0x3CF1BCC", VA = "0x3CF5BCC")]
		private static TransformDouble Scale(double2 scale)
		{
			return default;
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x3CF5C38", Offset = "0x3CF1C38", VA = "0x3CF5C38")]
		private static TransformDouble Rotate(double2x2 rotation)
		{
			return default;
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x3CF5CB0", Offset = "0x3CF1CB0", VA = "0x3CF5CB0")]
		public static TransformDouble operator *(TransformDouble lhs, TransformDouble rhs)
		{
			return default;
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x3CF5D2C", Offset = "0x3CF1D2C", VA = "0x3CF5D2C", Slot = "6")]
		public TransformDouble Inverse()
		{
			return default;
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x3CF5D90", Offset = "0x3CF1D90", VA = "0x3CF5D90", Slot = "7")]
		public double2 Transform(double2 point)
		{
			return default;
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x3CF5DB4", Offset = "0x3CF1DB4", VA = "0x3CF5DB4", Slot = "8")]
		public TransformDouble CalculatePCATransformation(NativeArray<double2> positions)
		{
			return default;
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x3CF6574", Offset = "0x3CF2574", VA = "0x3CF6574", Slot = "9")]
		public TransformDouble CalculateLocalTransformation(NativeArray<double2> positions)
		{
			return default;
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x3CF6314", Offset = "0x3CF2314", VA = "0x3CF6314")]
		private static void Eigen(double2x2 matrix, out double2 eigval, out double2x2 eigvec)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED TransformDouble.Eigen RVA=0x3CF6314 Token=0x60000E4");
}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x3CF62AC", Offset = "0x3CF22AC", VA = "0x3CF62AC")]
		private static double2x2 Kron(double2 a, double2 b)
		{
			return default;
		}
	}
}
