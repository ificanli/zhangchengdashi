using System;
using System.Text;
using Il2CppDummyDll;

namespace Pathfinding.Util
{
	[Token(Token = "0x20002A3")]
	public struct Guid
	{
		[Token(Token = "0x4000BF8")]
		private const string hex = "0123456789ABCDEF";

		[Token(Token = "0x4000BF9")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Guid zero;

		[Token(Token = "0x4000BFA")]
		[FieldOffset(Offset = "0x10")]
		public static readonly string zeroString;

		[Token(Token = "0x4000BFB")]
		[FieldOffset(Offset = "0x0")]
		private readonly ulong _a;

		[Token(Token = "0x4000BFC")]
		[FieldOffset(Offset = "0x8")]
		private readonly ulong _b;

		[Token(Token = "0x4000BFD")]
		[FieldOffset(Offset = "0x18")]
		private static Random random;

		[Token(Token = "0x4000BFE")]
		[FieldOffset(Offset = "0x20")]
		private static StringBuilder text;

		[Token(Token = "0x60010BF")]
		[Address(RVA = "0x4497978", Offset = "0x4493978", VA = "0x4497978")]
		public Guid(byte[] bytes)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED Guid..ctor RVA=0x4497978 Token=0x60010BF");
}

		[Token(Token = "0x60010C0")]
		[Address(RVA = "0x4497AC4", Offset = "0x4493AC4", VA = "0x4497AC4")]
		public Guid(string str)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED Guid..ctor RVA=0x4497AC4 Token=0x60010C0");
}

		[Token(Token = "0x60010C1")]
		[Address(RVA = "0x4497DB0", Offset = "0x4493DB0", VA = "0x4497DB0")]
		public static Guid Parse(string input)
		{
			return default;
		}

		[Token(Token = "0x60010C2")]
		[Address(RVA = "0x4497ABC", Offset = "0x4493ABC", VA = "0x4497ABC")]
		private static ulong SwapEndianness(ulong value)
		{
			return default;
		}

		[Token(Token = "0x60010C3")]
		[Address(RVA = "0x4497DD8", Offset = "0x4493DD8", VA = "0x4497DD8")]
		public static Guid NewGuid()
		{
			return default;
		}

		[Token(Token = "0x60010C4")]
		[Address(RVA = "0x4497E8C", Offset = "0x4493E8C", VA = "0x4497E8C")]
		public static bool operator ==(Guid lhs, Guid rhs)
		{
			return default;
		}

		[Token(Token = "0x60010C5")]
		[Address(RVA = "0x4497EA4", Offset = "0x4493EA4", VA = "0x4497EA4")]
		public static bool operator !=(Guid lhs, Guid rhs)
		{
			return default;
		}

		[Token(Token = "0x60010C6")]
		[Address(RVA = "0x4497EBC", Offset = "0x4493EBC", VA = "0x4497EBC", Slot = "0")]
		public override bool Equals(object _rhs)
		{
			return default;
		}

		[Token(Token = "0x60010C7")]
		[Address(RVA = "0x4497F44", Offset = "0x4493F44", VA = "0x4497F44", Slot = "2")]
		public override int GetHashCode()
		{
			return default;
		}

		[Token(Token = "0x60010C8")]
		[Address(RVA = "0x4497F58", Offset = "0x4493F58", VA = "0x4497F58", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
