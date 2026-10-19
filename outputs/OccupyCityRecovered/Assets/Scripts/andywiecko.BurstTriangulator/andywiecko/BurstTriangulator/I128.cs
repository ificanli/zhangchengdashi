using Il2CppDummyDll;

namespace andywiecko.BurstTriangulator
{
	[Token(Token = "0x2000014")]
	internal struct I128
	{
		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x0")]
		private ulong hi;

		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x8")]
		private ulong lo;

		[Token(Token = "0x17000028")]
		public bool IsNegative
		{
			[Token(Token = "0x6000065")]
			[Address(RVA = "0x3CF3CBC", Offset = "0x3CEFCBC", VA = "0x3CF3CBC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x3CF3CC8", Offset = "0x3CEFCC8", VA = "0x3CF3CC8")]
		public I128(ulong hi, ulong lo)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED I128..ctor RVA=0x3CF3CC8 Token=0x6000066");
}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x3CF3CD0", Offset = "0x3CEFCD0", VA = "0x3CF3CD0")]
		public static I128 operator +(I128 a, I128 b)
		{
			return default;
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x3CF3CE0", Offset = "0x3CEFCE0", VA = "0x3CF3CE0")]
		public static I128 operator -(I128 a, I128 b)
		{
			return default;
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x3CF3CF4", Offset = "0x3CEFCF4", VA = "0x3CF3CF4")]
		public static I128 operator -(I128 a)
		{
			return default;
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x3CF3D0C", Offset = "0x3CEFD0C", VA = "0x3CF3D0C")]
		public static I128 Multiply(long slhs, long srhs)
		{
			return default;
		}
	}
}
