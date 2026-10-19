using System;
using System.Buffers;
using System.IO;
using System.IO.Compression;
using System.Text;
using Il2CppDummyDll;

namespace ToolModule
{
	[Token(Token = "0x200019D")]
	public static class GZipTool
	{
		[Token(Token = "0x4001ABF")]
		private const int BufferSize = 81920;

		[Token(Token = "0x4001AC0")]
		private const CompressionLevel Level = CompressionLevel.Optimal;

		[Token(Token = "0x4001AC1")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Encoding DefaultEncoding = Encoding.UTF8;

		[Token(Token = "0x6000698")]
		[Address(RVA = "0x3F8045C", Offset = "0x3F7C45C", VA = "0x3F8045C")]
		public static string CompressToBase64(string json)
		{
			return null;
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0x3F80924", Offset = "0x3F7C924", VA = "0x3F80924")]
		public static byte[] Compress(byte[] input)
		{
			return null;
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0x3F80514", Offset = "0x3F7C514", VA = "0x3F80514")]
		private static byte[] CompressCore(byte[] input)
		{
			return null;
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0x3F80978", Offset = "0x3F7C978", VA = "0x3F80978")]
		public static string DecompressFromBase64(string base64Data)
		{
		    if (string.IsNullOrEmpty(base64Data))
		    {
		        return string.Empty;
		    }
		    try
		    {
		        byte[] compressedData = Convert.FromBase64String(base64Data);
		        return DefaultEncoding.GetString(DecompressCore(compressedData));
		    }
		    catch (Exception error)
		    {
		        UnityEngine.Debug.LogError("解压失败：" + base64Data);
		        Console.WriteLine(error);
		        throw;
		    }
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0x3F8121C", Offset = "0x3F7D21C", VA = "0x3F8121C")]
		public static byte[] Decompress(byte[] compressedData)
		{
		    return DecompressCore(compressedData);
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0x3F80B3C", Offset = "0x3F7CB3C", VA = "0x3F80B3C")]
		private static byte[] DecompressCore(byte[] compressedData)
		{
		    if (compressedData == null || compressedData.Length == 0)
		    {
		        return compressedData;
		    }
		    try
		    {
		        using (MemoryStream inputStream = new MemoryStream(compressedData))
		        using (GZipStream gzipStream = new GZipStream(inputStream, CompressionMode.Decompress))
		        using (MemoryStream outputStream = new MemoryStream())
		        {
		            byte[] buffer = ArrayPool<byte>.Shared.Rent(BufferSize);
		            try
		            {
		                int count;
		                while ((count = gzipStream.Read(buffer, 0, BufferSize)) > 0)
		                {
		                    outputStream.Write(buffer, 0, count);
		                }
		            }
		            finally
		            {
		                ArrayPool<byte>.Shared.Return(buffer, false);
		            }
		            return outputStream.ToArray();
		        }
		    }
		    catch (Exception)
		    {
		        return compressedData;
		    }
		}
	}
}
