using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zlib
{
	[Token(Token = "0x2000064")]
	public sealed class Adler
	{
		[Token(Token = "0x4000366")]
		[FieldOffset(Offset = "0x0")]
		private static readonly uint BASE;

		[Token(Token = "0x4000367")]
		[FieldOffset(Offset = "0x4")]
		private static readonly int NMAX;

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x78743A4", Offset = "0x78703A4", VA = "0x78743A4")]
		public Adler()
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x7870F78", Offset = "0x786CF78", VA = "0x7870F78")]
		public static uint Adler32(uint adler, byte[] buf, int index, int len)
		{
			return default;
		}
	}
}
