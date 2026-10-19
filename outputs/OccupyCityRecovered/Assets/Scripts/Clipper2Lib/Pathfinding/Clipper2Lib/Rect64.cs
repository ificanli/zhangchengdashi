using System.Collections.Generic;
using Il2CppDummyDll;

namespace Pathfinding.Clipper2Lib
{
	[Token(Token = "0x2000009")]
	public struct Rect64
	{
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x0")]
		public long left;

		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x8")]
		public long top;

		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x10")]
		public long right;

		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x18")]
		public long bottom;

		[Token(Token = "0x17000001")]
		public long Width
		{
			[Token(Token = "0x6000023")]
			[Address(RVA = "0x45FF698", Offset = "0x45FB698", VA = "0x45FF698")]
			readonly get
			{
				return default;
			}
			[Token(Token = "0x6000024")]
			[Address(RVA = "0x45FF6A8", Offset = "0x45FB6A8", VA = "0x45FF6A8")]
			set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public long Height
		{
			[Token(Token = "0x6000025")]
			[Address(RVA = "0x45FF6B8", Offset = "0x45FB6B8", VA = "0x45FF6B8")]
			readonly get
			{
				return default;
			}
			[Token(Token = "0x6000026")]
			[Address(RVA = "0x45FF6C8", Offset = "0x45FB6C8", VA = "0x45FF6C8")]
			set
			{
			}
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x45FF648", Offset = "0x45FB648", VA = "0x45FF648")]
		public Rect64(long l, long t, long r, long b)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED Rect64..ctor RVA=0x45FF648 Token=0x6000020");
}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x45FF654", Offset = "0x45FB654", VA = "0x45FF654")]
		public Rect64(bool isValid)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED Rect64..ctor RVA=0x45FF654 Token=0x6000021");
}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x45FF674", Offset = "0x45FB674", VA = "0x45FF674")]
		public Rect64(Rect64 rec)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED Rect64..ctor RVA=0x45FF674 Token=0x6000022");
}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x45FF6D8", Offset = "0x45FB6D8", VA = "0x45FF6D8")]
		public readonly bool IsEmpty()
		{
			return default;
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x45FF704", Offset = "0x45FB704", VA = "0x45FF704")]
		public readonly bool IsValid()
		{
			return default;
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x45FF718", Offset = "0x45FB718", VA = "0x45FF718")]
		public readonly Point64 MidPoint()
		{
			return default;
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x45FF744", Offset = "0x45FB744", VA = "0x45FF744")]
		public readonly bool Contains(Point64 pt)
		{
			return default;
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x45FF780", Offset = "0x45FB780", VA = "0x45FF780")]
		public readonly bool Contains(Rect64 rec)
		{
			return default;
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x45FF7CC", Offset = "0x45FB7CC", VA = "0x45FF7CC")]
		public readonly bool Intersects(Rect64 rec)
		{
			return default;
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x45FF8B0", Offset = "0x45FB8B0", VA = "0x45FF8B0")]
		public readonly List<Point64> AsPath()
		{
			return null;
		}
	}
}
