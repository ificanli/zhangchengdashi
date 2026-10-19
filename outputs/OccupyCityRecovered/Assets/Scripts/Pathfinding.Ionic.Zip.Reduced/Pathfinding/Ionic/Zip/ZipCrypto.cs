using Il2CppDummyDll;
using Pathfinding.Ionic.Crc;

namespace Pathfinding.Ionic.Zip
{
	[Token(Token = "0x2000027")]
	internal class ZipCrypto
	{
		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x10")]
		private uint[] _Keys;

		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x18")]
		private CRC32 crc32;

		[Token(Token = "0x17000021")]
		private byte MagicByte
		{
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0x78400A0", Offset = "0x783C0A0", VA = "0x78400A0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x783FABC", Offset = "0x783BABC", VA = "0x783FABC")]
		private ZipCrypto()
		{
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x783FB6C", Offset = "0x783BB6C", VA = "0x783FB6C")]
		public static ZipCrypto ForWrite(string password)
		{
			return null;
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x783FCD0", Offset = "0x783BCD0", VA = "0x783FCD0")]
		public static ZipCrypto ForRead(string password, ZipEntry e)
		{
			return null;
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x783FF24", Offset = "0x783BF24", VA = "0x783FF24")]
		public byte[] DecryptMessage(byte[] cipherText, int length)
		{
			return null;
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x784019C", Offset = "0x783C19C", VA = "0x784019C")]
		public byte[] EncryptMessage(byte[] plainText, int length)
		{
			return null;
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x783FC1C", Offset = "0x783BC1C", VA = "0x783FC1C")]
		public void InitCipher(string passphrase)
		{
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x78400E4", Offset = "0x783C0E4", VA = "0x78400E4")]
		private void UpdateKeys(byte byteValue)
		{
		}
	}
}
