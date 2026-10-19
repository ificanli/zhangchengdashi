using Il2CppDummyDll;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	[Token(Token = "0x20000BD")]
	public struct DVector2
	{
		[Token(Token = "0x40002D3")]
		[FieldOffset(Offset = "0x0")]
		private static double epsilon;

		[Token(Token = "0x40002D4")]
		[FieldOffset(Offset = "0x0")]
		public double x;

		[Token(Token = "0x40002D5")]
		[FieldOffset(Offset = "0x8")]
		public double y;

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x74835A4", Offset = "0x747F5A4", VA = "0x74835A4")]
		public static DVector2 Subtract(DVector2 a, DVector2 b)
		{
			return default;
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x74835B0", Offset = "0x747F5B0", VA = "0x74835B0")]
		public DVector2(double xx, double yy)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED DVector2..ctor RVA=0x74835B0 Token=0x60003A4");
}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x74835B8", Offset = "0x747F5B8", VA = "0x74835B8")]
		public DVector2(DVector2 r)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED DVector2..ctor RVA=0x74835B8 Token=0x60003A5");
}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x74835C0", Offset = "0x747F5C0", VA = "0x74835C0")]
		public Vector2 GetVector2()
		{
			return default;
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x74835D0", Offset = "0x747F5D0", VA = "0x74835D0")]
		public bool IsContainedIn(DRect r)
		{
			return default;
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x7483610", Offset = "0x747F610", VA = "0x7483610")]
		public bool IsContainedInWithMargin(DRect r)
		{
			return default;
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x7483730", Offset = "0x747F730", VA = "0x7483730", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x74837D8", Offset = "0x747F7D8", VA = "0x74837D8")]
		public string ToString(string formatS)
		{
			return null;
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x748385C", Offset = "0x747F85C", VA = "0x748385C")]
		public static double Distance(DVector2 a, DVector2 b)
		{
			return default;
		}
	}
}
