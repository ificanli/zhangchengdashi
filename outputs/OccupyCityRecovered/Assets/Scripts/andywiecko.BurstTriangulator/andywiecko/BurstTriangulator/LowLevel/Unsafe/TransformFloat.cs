using Il2CppDummyDll;
using Unity.Collections;
using Unity.Mathematics;

namespace andywiecko.BurstTriangulator.LowLevel.Unsafe
{
	[Token(Token = "0x2000027")]
	internal readonly struct TransformFloat : ITransform<TransformFloat, float, float2>
	{
		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x0")]
		private readonly float2x2 rotScale;

		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0x10")]
		private readonly float2 translation;

		[Token(Token = "0x1700002B")]
		public TransformFloat Identity
		{
			[Token(Token = "0x60000CC")]
			[Address(RVA = "0x3CF4E08", Offset = "0x3CF0E08", VA = "0x3CF4E08", Slot = "5")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700002C")]
		public float AreaScalingFactor
		{
			[Token(Token = "0x60000CD")]
			[Address(RVA = "0x3CF4E94", Offset = "0x3CF0E94", VA = "0x3CF4E94", Slot = "4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x3CF4E84", Offset = "0x3CF0E84", VA = "0x3CF4E84")]
		public TransformFloat(float2x2 rotScale, float2 translation)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED TransformFloat..ctor RVA=0x3CF4E84 Token=0x60000CE");
}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x3CF4EAC", Offset = "0x3CF0EAC", VA = "0x3CF4EAC")]
		private static TransformFloat Translate(float2 offset)
		{
			return default;
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x3CF4F10", Offset = "0x3CF0F10", VA = "0x3CF4F10")]
		private static TransformFloat Scale(float2 scale)
		{
			return default;
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x3CF4F7C", Offset = "0x3CF0F7C", VA = "0x3CF4F7C")]
		private static TransformFloat Rotate(float2x2 rotation)
		{
			return default;
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x3CF4FF4", Offset = "0x3CF0FF4", VA = "0x3CF4FF4")]
		public static TransformFloat operator *(TransformFloat lhs, TransformFloat rhs)
		{
			return default;
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x3CF5074", Offset = "0x3CF1074", VA = "0x3CF5074", Slot = "6")]
		public TransformFloat Inverse()
		{
			return default;
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x3CF50D8", Offset = "0x3CF10D8", VA = "0x3CF50D8", Slot = "7")]
		public float2 Transform(float2 point)
		{
			return default;
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x3CF50FC", Offset = "0x3CF10FC", VA = "0x3CF50FC", Slot = "8")]
		public TransformFloat CalculatePCATransformation(NativeArray<float2> positions)
		{
			return default;
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x3CF57FC", Offset = "0x3CF17FC", VA = "0x3CF57FC", Slot = "9")]
		public TransformFloat CalculateLocalTransformation(NativeArray<float2> positions)
		{
			return default;
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x3CF5590", Offset = "0x3CF1590", VA = "0x3CF5590")]
		private static void Eigen(float2x2 matrix, out float2 eigval, out float2x2 eigvec)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED TransformFloat.Eigen RVA=0x3CF5590 Token=0x60000D7");
}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x3CF5530", Offset = "0x3CF1530", VA = "0x3CF5530")]
		private static float2x2 Kron(float2 a, float2 b)
		{
			return default;
		}
	}
}
