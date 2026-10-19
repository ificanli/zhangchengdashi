using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zip
{
	[Token(Token = "0x2000024")]
	internal static class SharedUtilities
	{
		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x0")]
		private static Regex doubleDotRegex1;

		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x8")]
		private static Encoding ibm437;

		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x10")]
		private static Encoding utf8;

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x783DDAC", Offset = "0x7839DAC", VA = "0x783DDAC")]
		public static long GetFileLength(string fileName)
		{
			return default;
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x783DF8C", Offset = "0x7839F8C", VA = "0x783DF8C")]
		[Conditional("NETCF")]
		public static void Workaround_Ladybug318918(Stream s)
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x783DFAC", Offset = "0x7839FAC", VA = "0x783DFAC")]
		private static string SimplifyFwdSlashPath(string path)
		{
			return null;
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x783E0B8", Offset = "0x783A0B8", VA = "0x783E0B8")]
		public static string NormalizePathForUseInZipFile(string pathName)
		{
			return null;
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x783E1EC", Offset = "0x783A1EC", VA = "0x783E1EC")]
		internal static byte[] StringToByteArray(string value, Encoding encoding)
		{
			return null;
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x783E218", Offset = "0x783A218", VA = "0x783E218")]
		internal static byte[] StringToByteArray(string value)
		{
			return null;
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x783E28C", Offset = "0x783A28C", VA = "0x783E28C")]
		internal static string Utf8StringFromBuffer(byte[] buf)
		{
			return null;
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x783E2EC", Offset = "0x783A2EC", VA = "0x783E2EC")]
		internal static string StringFromBuffer(byte[] buf, Encoding encoding)
		{
			return null;
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x783E324", Offset = "0x783A324", VA = "0x783E324")]
		internal static int ReadSignature(Stream s)
		{
			return default;
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x783E528", Offset = "0x783A528", VA = "0x783E528")]
		internal static int ReadEntrySignature(Stream s)
		{
			return default;
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x783E744", Offset = "0x783A744", VA = "0x783E744")]
		internal static int ReadInt(Stream s)
		{
			return default;
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x783E40C", Offset = "0x783A40C", VA = "0x783E40C")]
		private static int _ReadFourBytes(Stream s, string message)
		{
			return default;
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x783E7B0", Offset = "0x783A7B0", VA = "0x783E7B0")]
		internal static long FindSignature(Stream stream, int SignatureToFind)
		{
			return default;
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x783E9EC", Offset = "0x783A9EC", VA = "0x783E9EC")]
		internal static DateTime AdjustTime_Reverse(DateTime time)
		{
			return default;
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x783EB80", Offset = "0x783AB80", VA = "0x783EB80")]
		internal static DateTime PackedToDateTime(int packedDateTime)
		{
			return default;
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x783F1C8", Offset = "0x783B1C8", VA = "0x783F1C8")]
		internal static int DateTimeToPacked(DateTime time)
		{
			return default;
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x783F2B4", Offset = "0x783B2B4", VA = "0x783F2B4")]
		public static void CreateAndOpenUniqueTempFile(string dir, out Stream fs, out string filename)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED SharedUtilities.CreateAndOpenUniqueTempFile RVA=0x783F2B4 Token=0x60000B2");
}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x783F440", Offset = "0x783B440", VA = "0x783F440")]
		public static string InternalGetTempFileName()
		{
			return null;
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x783F4D4", Offset = "0x783B4D4", VA = "0x783F4D4")]
		internal static string GenerateRandomStringImpl(int length, int delta)
		{
			return null;
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x783F60C", Offset = "0x783B60C", VA = "0x783F60C")]
		internal static int ReadWithRetry(Stream s, byte[] buffer, int offset, int count, string FileName)
		{
			return default;
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x783F6AC", Offset = "0x783B6AC", VA = "0x783F6AC")]
		private static uint _HRForException(Exception ex1)
		{
			return default;
		}
	}
}
