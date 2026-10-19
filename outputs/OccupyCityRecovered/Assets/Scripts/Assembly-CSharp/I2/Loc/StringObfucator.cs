using Il2CppDummyDll;

namespace I2.Loc
{
	[Token(Token = "0x2000DC6")]
	public class StringObfucator
	{
		[Token(Token = "0x40060CA")]
		[FieldOffset(Offset = "0x0")]
		public static char[] StringObfuscatorPassword;

		[Token(Token = "0x6005540")]
		[Address(RVA = "0x4330218", Offset = "0x432C218", VA = "0x4330218")]
		public static string Encode(string NormalString)
		{
			return null;
		}

		[Token(Token = "0x6005541")]
		[Address(RVA = "0x433050C", Offset = "0x432C50C", VA = "0x433050C")]
		public static string Decode(string ObfucatedString)
		{
			return null;
		}

		[Token(Token = "0x6005542")]
		[Address(RVA = "0x4330488", Offset = "0x432C488", VA = "0x4330488")]
		private static string ToBase64(string regularString)
		{
			return null;
		}

		[Token(Token = "0x6005543")]
		[Address(RVA = "0x43305E4", Offset = "0x432C5E4", VA = "0x43305E4")]
		private static string FromBase64(string base64string)
		{
			return null;
		}

		[Token(Token = "0x6005544")]
		[Address(RVA = "0x43302F0", Offset = "0x432C2F0", VA = "0x43302F0")]
		private static string XoREncode(string NormalString)
		{
			return null;
		}

		[Token(Token = "0x6005545")]
		[Address(RVA = "0x4330670", Offset = "0x432C670", VA = "0x4330670")]
		public StringObfucator()
		{
		}
	}
}
