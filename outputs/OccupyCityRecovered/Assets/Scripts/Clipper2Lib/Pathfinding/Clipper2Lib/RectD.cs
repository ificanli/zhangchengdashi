using Il2CppDummyDll;

namespace Pathfinding.Clipper2Lib
{
	[Token(Token = "0x200000A")]
	public struct RectD
	{
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x0")]
		public double left;

		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x8")]
		public double top;

		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x10")]
		public double right;

		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x18")]
		public double bottom;

		[Token(Token = "0x17000003")]
		public double Width
		{
			[Token(Token = "0x6000031")]
			[Address(RVA = "0x45FFADC", Offset = "0x45FBADC", VA = "0x45FFADC")]
			readonly get
			{
				return default;
			}
			[Token(Token = "0x6000032")]
			[Address(RVA = "0x45FFAEC", Offset = "0x45FBAEC", VA = "0x45FFAEC")]
			set
			{
			}
		}

		[Token(Token = "0x17000004")]
		public double Height
		{
			[Token(Token = "0x6000033")]
			[Address(RVA = "0x45FFAFC", Offset = "0x45FBAFC", VA = "0x45FFAFC")]
			readonly get
			{
				return default;
			}
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x45FFB0C", Offset = "0x45FBB0C", VA = "0x45FFB0C")]
			set
			{
			}
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x45FFA98", Offset = "0x45FBA98", VA = "0x45FFA98")]
		public RectD(double l, double t, double r, double b)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED RectD..ctor RVA=0x45FFA98 Token=0x600002E");
}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x45FFAA4", Offset = "0x45FBAA4", VA = "0x45FFAA4")]
		public RectD(RectD rec)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED RectD..ctor RVA=0x45FFAA4 Token=0x600002F");
}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x45FFAB0", Offset = "0x45FBAB0", VA = "0x45FFAB0")]
		public RectD(bool isValid)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED RectD..ctor RVA=0x45FFAB0 Token=0x6000030");
}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x45FFB1C", Offset = "0x45FBB1C", VA = "0x45FFB1C")]
		public readonly bool IsEmpty()
		{
			return default;
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x45FFB48", Offset = "0x45FBB48", VA = "0x45FFB48")]
		public readonly PointD MidPoint()
		{
			return default;
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x45FFB60", Offset = "0x45FBB60", VA = "0x45FFB60")]
		public readonly bool Contains(PointD pt)
		{
			return default;
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x45FFB9C", Offset = "0x45FBB9C", VA = "0x45FFB9C")]
		public readonly bool Contains(RectD rec)
		{
			return default;
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x45FFBD8", Offset = "0x45FBBD8", VA = "0x45FFBD8")]
		public readonly bool Intersects(RectD rec)
		{
			return default;
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x45FFCD0", Offset = "0x45FBCD0", VA = "0x45FFCD0")]
		public readonly PathD AsPath()
		{
			return null;
		}
	}
}
