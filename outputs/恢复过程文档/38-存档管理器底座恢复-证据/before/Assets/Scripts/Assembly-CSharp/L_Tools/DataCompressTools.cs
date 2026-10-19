using Il2CppDummyDll;

namespace L_Tools
{
	[Token(Token = "0x2000FB1")]
	public static class DataCompressTools
	{
		[Token(Token = "0x4006B91")]
		[FieldOffset(Offset = "0x0")]
		private static string _swapString;

		[Token(Token = "0x4006B92")]
		[FieldOffset(Offset = "0x8")]
		private static byte _encryptKey;

		[Token(Token = "0x6005E08")]
		[Address(RVA = "0x43F8990", Offset = "0x43F4990", VA = "0x43F8990")]
		public static string EncryptString(string rawString)
		{
			return null;
		}

		[Token(Token = "0x6005E09")]
		[Address(RVA = "0x43F8B04", Offset = "0x43F4B04", VA = "0x43F8B04")]
		public static string DecryptString(string encryptedString)
		{
			return null;
		}

		[Token(Token = "0x6005E0A")]
		[Address(RVA = "0x43F8164", Offset = "0x43F4164", VA = "0x43F8164")]
		public static string GZipCompressString(string rawString)
		{
			return null;
		}

		[Token(Token = "0x6005E0B")]
		[Address(RVA = "0x43F8DE0", Offset = "0x43F4DE0", VA = "0x43F8DE0")]
		private static byte[] Compress(byte[] rawData)
		{
			return null;
		}

		[Token(Token = "0x6005E0C")]
		[Address(RVA = "0x43F7E58", Offset = "0x43F3E58", VA = "0x43F7E58")]
		public static string GZipDecompressString(string zippedString)
		{
			return null;
		}

		[Token(Token = "0x6005E0D")]
		[Address(RVA = "0x43F9134", Offset = "0x43F5134", VA = "0x43F9134")]
		private static byte[] Decompress(byte[] zippedData)
		{
			return null;
		}
	}
}
