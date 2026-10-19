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
    if (string.IsNullOrEmpty(rawString))
        return string.Empty;
    byte[] data = System.Text.Encoding.UTF8.GetBytes(rawString);
    for (int i = 0; i < data.Length; i++)
        data[i] ^= unchecked((byte)~_encryptKey);
    return System.Convert.ToBase64String(data) + _swapString;
}

		[Token(Token = "0x6005E09")]
		[Address(RVA = "0x43F8B04", Offset = "0x43F4B04", VA = "0x43F8B04")]
		public static string DecryptString(string encryptedString)
		{
    if (string.IsNullOrEmpty(encryptedString))
        return string.Empty;
    if (!encryptedString.EndsWith(_swapString))
        return encryptedString;
    byte[] data = System.Convert.FromBase64String(encryptedString.Substring(0, encryptedString.Length - _swapString.Length));
    for (int i = 0; i < data.Length; i++)
        data[i] ^= unchecked((byte)~_encryptKey);
    return System.Text.Encoding.UTF8.GetString(data);
}

		[Token(Token = "0x6005E0A")]
		[Address(RVA = "0x43F8164", Offset = "0x43F4164", VA = "0x43F8164")]
		public static string GZipCompressString(string rawString)
		{
    if (string.IsNullOrEmpty(rawString) || rawString.Length == 0)
        return string.Empty;
    byte[] data = System.Text.Encoding.UTF8.GetBytes(rawString.ToString());
    return EncryptString(System.Convert.ToBase64String(Compress(data)));
}

		[Token(Token = "0x6005E0B")]
		[Address(RVA = "0x43F8DE0", Offset = "0x43F4DE0", VA = "0x43F8DE0")]
		private static byte[] Compress(byte[] rawData)
		{
    using (var stream = new System.IO.MemoryStream())
    {
        using (var gzip = new System.IO.Compression.GZipStream(stream, System.IO.Compression.CompressionMode.Compress, true))
        {
            gzip.Write(rawData, 0, rawData.Length);
            gzip.Close();
        }

        return stream.ToArray();
    }
}

		[Token(Token = "0x6005E0C")]
		[Address(RVA = "0x43F7E58", Offset = "0x43F3E58", VA = "0x43F7E58")]
		public static string GZipDecompressString(string zippedString)
		{
    if (string.IsNullOrEmpty(zippedString) || zippedString.Length == 0)
        return string.Empty;
    byte[] data = System.Convert.FromBase64String(DecryptString(zippedString).ToString());
    return System.Text.Encoding.UTF8.GetString(Decompress(data));
}

		[Token(Token = "0x6005E0D")]
		[Address(RVA = "0x43F9134", Offset = "0x43F5134", VA = "0x43F9134")]
		private static byte[] Decompress(byte[] zippedData)
		{
    using (var input = new System.IO.MemoryStream(zippedData))
    using (var gzip = new System.IO.Compression.GZipStream(input, System.IO.Compression.CompressionMode.Decompress))
    using (var output = new System.IO.MemoryStream())
    {
        byte[] buffer = new byte[32768];
        int count;
        while ((count = gzip.Read(buffer, 0, buffer.Length)) > 0)
            output.Write(buffer, 0, count);
        return output.ToArray();
    }
}

[Token(Token = "0x6005E0E")]
[Address(RVA = "0x43F9614", Offset = "0x43F5614", VA = "0x43F9614")]
static DataCompressTools()
{
    _swapString = "1234567890";
    _encryptKey = 90;
}	}
}
