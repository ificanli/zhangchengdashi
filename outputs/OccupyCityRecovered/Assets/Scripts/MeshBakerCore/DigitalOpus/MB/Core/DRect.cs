using Il2CppDummyDll;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Token(Token = "0x20000BE")]
	public struct DRect
	{
		[Token(Token = "0x40002D6")]
		[FieldOffset(Offset = "0x0")]
		public double x;

		[Token(Token = "0x40002D7")]
		[FieldOffset(Offset = "0x8")]
		public double y;

		[Token(Token = "0x40002D8")]
		[FieldOffset(Offset = "0x10")]
		public double width;

		[Token(Token = "0x40002D9")]
		[FieldOffset(Offset = "0x18")]
		public double height;

		[Token(Token = "0x17000074")]
		public DVector2 minD
		{
			[Token(Token = "0x60003B3")]
			[Address(RVA = "0x74839C0", Offset = "0x747F9C0", VA = "0x74839C0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000075")]
		public DVector2 maxD
		{
			[Token(Token = "0x60003B4")]
			[Address(RVA = "0x74839C8", Offset = "0x747F9C8", VA = "0x74839C8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000076")]
		public Vector2 min
		{
			[Token(Token = "0x60003B5")]
			[Address(RVA = "0x74839D8", Offset = "0x747F9D8", VA = "0x74839D8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000077")]
		public Vector2 max
		{
			[Token(Token = "0x60003B6")]
			[Address(RVA = "0x74839E8", Offset = "0x747F9E8", VA = "0x74839E8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000078")]
		public Vector2 size
		{
			[Token(Token = "0x60003B7")]
			[Address(RVA = "0x74839FC", Offset = "0x747F9FC", VA = "0x74839FC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000079")]
		public DVector2 center
		{
			[Token(Token = "0x60003B8")]
			[Address(RVA = "0x7483A0C", Offset = "0x747FA0C", VA = "0x7483A0C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x7483938", Offset = "0x747F938", VA = "0x7483938")]
		public DRect(Rect r)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED DRect..ctor RVA=0x7483938 Token=0x60003AD");
}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x7483954", Offset = "0x747F954", VA = "0x7483954")]
		public DRect(Vector2 o, Vector2 s)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED DRect..ctor RVA=0x7483954 Token=0x60003AE");
}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x7483970", Offset = "0x747F970", VA = "0x7483970")]
		public DRect(DRect r)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED DRect..ctor RVA=0x7483970 Token=0x60003AF");
}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x748397C", Offset = "0x747F97C", VA = "0x748397C")]
		public DRect(float xx, float yy, float w, float h)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED DRect..ctor RVA=0x748397C Token=0x60003B0");
}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x7483998", Offset = "0x747F998", VA = "0x7483998")]
		public DRect(double xx, double yy, double w, double h)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED DRect..ctor RVA=0x7483998 Token=0x60003B1");
}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x74839A4", Offset = "0x747F9A4", VA = "0x74839A4")]
		public Rect GetRect()
		{
			return default;
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x7483A24", Offset = "0x747FA24", VA = "0x7483A24", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default;
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x7483AE0", Offset = "0x747FAE0", VA = "0x7483AE0")]
		public static bool operator ==(DRect a, DRect b)
		{
			return default;
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x7483B70", Offset = "0x747FB70", VA = "0x7483B70")]
		public static bool operator !=(DRect a, DRect b)
		{
			return default;
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x7483C04", Offset = "0x747FC04", VA = "0x7483C04", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x7483D94", Offset = "0x747FD94", VA = "0x7483D94")]
		public void Expand(float amt)
		{
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x7483DBC", Offset = "0x747FDBC", VA = "0x7483DBC")]
		public bool Encloses(DRect smallToTestIfFits)
		{
			return default;
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x7483E2C", Offset = "0x747FE2C", VA = "0x7483E2C", Slot = "2")]
		public override int GetHashCode()
		{
			return default;
		}
	}
}
