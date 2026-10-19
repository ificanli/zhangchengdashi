
namespace L_Tools
{
	public static class DataCompressTools
	{
		private static string _swapString;
		private static byte _encryptKey;
		public static string EncryptString(string rawString)
		{
    if (string.IsNullOrEmpty(rawString))
        return string.Empty;
    byte[] data = System.Text.Encoding.UTF8.GetBytes(rawString);
    for (int i = 0; i < data.Length; i++)
        data[i] ^= unchecked((byte)~_encryptKey);
    return System.Convert.ToBase64String(data) + _swapString;
}
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
		public static string GZipCompressString(string rawString)
		{
    if (string.IsNullOrEmpty(rawString) || rawString.Length == 0)
        return string.Empty;
    byte[] data = System.Text.Encoding.UTF8.GetBytes(rawString.ToString());
    return EncryptString(System.Convert.ToBase64String(Compress(data)));
}
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
		public static string GZipDecompressString(string zippedString)
		{
    if (string.IsNullOrEmpty(zippedString) || zippedString.Length == 0)
        return string.Empty;
    byte[] data = System.Convert.FromBase64String(DecryptString(zippedString).ToString());
    return System.Text.Encoding.UTF8.GetString(Decompress(data));
}
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
static DataCompressTools()
{
    _swapString = "1234567890";
    _encryptKey = 90;
}	}
}
