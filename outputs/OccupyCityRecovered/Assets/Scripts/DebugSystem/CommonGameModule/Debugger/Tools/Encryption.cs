using Il2CppDummyDll;

namespace CommonGameModule.Debugger.Tools
{
	[Token(Token = "0x200001E")]
	public class Encryption
	{
		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string key;

		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x8")]
		private static readonly string iv;

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x4637DAC", Offset = "0x4633DAC", VA = "0x4637DAC")]
		public static string Encrypt(string plainText)
		{
			return null;
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x4634B28", Offset = "0x4630B28", VA = "0x4634B28")]
		public static string Decrypt(string cipherText)
		{
			return null;
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x46384CC", Offset = "0x46344CC", VA = "0x46384CC")]
		public Encryption()
		{
		}
	}
}
