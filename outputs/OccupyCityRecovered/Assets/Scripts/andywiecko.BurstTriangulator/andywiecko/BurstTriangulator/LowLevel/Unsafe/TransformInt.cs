using Il2CppDummyDll;
using Unity.Collections;
using Unity.Mathematics;

namespace andywiecko.BurstTriangulator.LowLevel.Unsafe
{
	[Token(Token = "0x2000029")]
	internal readonly struct TransformInt : ITransform<TransformInt, int, int2>
	{
		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x0")]
		private readonly int2 translation;

		[Token(Token = "0x1700002F")]
		public TransformInt Identity
		{
			[Token(Token = "0x60000E6")]
			[Address(RVA = "0x3CF68F8", Offset = "0x3CF28F8", VA = "0x3CF68F8", Slot = "5")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000030")]
		public int AreaScalingFactor
		{
			[Token(Token = "0x60000E7")]
			[Address(RVA = "0x3CF6940", Offset = "0x3CF2940", VA = "0x3CF6940", Slot = "4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x3CF6948", Offset = "0x3CF2948", VA = "0x3CF6948")]
		public TransformInt(int2 translation)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED TransformInt..ctor RVA=0x3CF6948 Token=0x60000E8");
}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x3CF6950", Offset = "0x3CF2950", VA = "0x3CF6950", Slot = "6")]
		public TransformInt Inverse()
		{
			return default;
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x3CF6964", Offset = "0x3CF2964", VA = "0x3CF6964", Slot = "7")]
		public int2 Transform(int2 point)
		{
			return default;
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x3CF6980", Offset = "0x3CF2980", VA = "0x3CF6980", Slot = "8")]
		public TransformInt CalculatePCATransformation(NativeArray<int2> positions)
		{
			return default;
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x3CF69CC", Offset = "0x3CF29CC", VA = "0x3CF69CC", Slot = "9")]
		public TransformInt CalculateLocalTransformation(NativeArray<int2> positions)
		{
			return default;
		}
	}
}
