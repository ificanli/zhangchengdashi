using Il2CppDummyDll;
using Unity.Mathematics;

namespace Pathfinding
{
	[Token(Token = "0x2000062")]
	public struct IntBounds
	{
		[Token(Token = "0x400021F")]
		[FieldOffset(Offset = "0x0")]
		public int3 min;

		[Token(Token = "0x4000220")]
		[FieldOffset(Offset = "0xC")]
		public int3 max;

		[Token(Token = "0x170000D9")]
		public int3 size
		{
			[Token(Token = "0x60003D3")]
			[Address(RVA = "0x44F6508", Offset = "0x44F2508", VA = "0x44F6508")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000DA")]
		public int volume
		{
			[Token(Token = "0x60003D4")]
			[Address(RVA = "0x44F6534", Offset = "0x44F2534", VA = "0x44F6534")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x44F64E4", Offset = "0x44F24E4", VA = "0x44F64E4")]
		public IntBounds(int xmin, int ymin, int zmin, int xmax, int ymax, int zmax)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED IntBounds..ctor RVA=0x44F64E4 Token=0x60003D1");
}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x44F64F4", Offset = "0x44F24F4", VA = "0x44F64F4")]
		public IntBounds(int3 min, int3 max)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED IntBounds..ctor RVA=0x44F64F4 Token=0x60003D2");
}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x44F6564", Offset = "0x44F2564", VA = "0x44F6564")]
		public static IntBounds Intersection(IntBounds a, IntBounds b)
		{
			return default;
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x44F65E0", Offset = "0x44F25E0", VA = "0x44F65E0")]
		public static bool Intersects(IntBounds a, IntBounds b)
		{
			return default;
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x44F6650", Offset = "0x44F2650", VA = "0x44F6650")]
		public IntBounds Offset(int3 offset)
		{
			return default;
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x44F66A0", Offset = "0x44F26A0", VA = "0x44F66A0")]
		public bool Contains(IntBounds other)
		{
			return default;
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x44F6714", Offset = "0x44F2714", VA = "0x44F6714", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x44F6944", Offset = "0x44F2944", VA = "0x44F6944", Slot = "0")]
		public override bool Equals(object _b)
		{
			return default;
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x44F6A94", Offset = "0x44F2A94", VA = "0x44F6A94", Slot = "2")]
		public override int GetHashCode()
		{
			return default;
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x44F6A20", Offset = "0x44F2A20", VA = "0x44F6A20")]
		public static bool operator ==(IntBounds a, IntBounds b)
		{
			return default;
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x44F6B0C", Offset = "0x44F2B0C", VA = "0x44F6B0C")]
		public static bool operator !=(IntBounds a, IntBounds b)
		{
			return default;
		}
	}
}
