using Il2CppDummyDll;

namespace Pathfinding.Clipper2Lib
{
	[Token(Token = "0x2000017")]
	internal readonly struct LocalMinima
	{
		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x0")]
		public readonly Vertex vertex;

		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x8")]
		public readonly PathType polytype;

		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0xC")]
		public readonly bool isOpen;

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x460C0D8", Offset = "0x46080D8", VA = "0x460C0D8")]
		public LocalMinima(Vertex vertex, PathType polytype, bool isOpen = false)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED LocalMinima..ctor RVA=0x460C0D8 Token=0x60000BE");
}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x460C0EC", Offset = "0x46080EC", VA = "0x460C0EC")]
		public static bool operator ==(LocalMinima lm1, LocalMinima lm2)
		{
			return default;
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x460C0F8", Offset = "0x46080F8", VA = "0x460C0F8")]
		public static bool operator !=(LocalMinima lm1, LocalMinima lm2)
		{
			return default;
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x460C104", Offset = "0x4608104", VA = "0x460C104", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default;
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x460C17C", Offset = "0x460817C", VA = "0x460C17C", Slot = "2")]
		public override int GetHashCode()
		{
			return default;
		}
	}
}
