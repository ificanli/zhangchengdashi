using System;
using System.Collections.Generic;
using System.Numerics;
using Il2CppDummyDll;

namespace ToolModule
{
	[Token(Token = "0x20001A4")]
	public static class StringTool
	{
		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x3F82464", Offset = "0x3F7E464", VA = "0x3F82464")]
		public static BigInteger ToBigInter(this string str)
		{
			return default;
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x3F82510", Offset = "0x3F7E510", VA = "0x3F82510")]
		public static bool ToBool(this string str)
		{
			return default;
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x3F73A70", Offset = "0x3F6FA70", VA = "0x3F73A70")]
		public static int ToInt(this string str)
		{
			return default;
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x3F78C74", Offset = "0x3F74C74", VA = "0x3F78C74")]
		public static float ToFloat(this string str)
		{
			return default;
		}

		[Token(Token = "0x60006B1")]
		public static T ToEnum<T>(this string str)
		{
			return (T)null;
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x3F826A4", Offset = "0x3F7E6A4", VA = "0x3F826A4")]
		public static List<string> ToList(this string content, char separator = ',')
		{
			return null;
		}

		[Token(Token = "0x60006B3")]
		public static Dictionary<T, TV> ToDictionary<T, TV>(this string content)
		{
			return null;
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x3F82770", Offset = "0x3F7E770", VA = "0x3F82770")]
		public static byte[] ToBase64Bytes(this string content)
		{
			return null;
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x3F8089C", Offset = "0x3F7C89C", VA = "0x3F8089C")]
		public static string ToBase64String(this byte[] bytes)
		{
			return null;
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x3F82848", Offset = "0x3F7E848", VA = "0x3F82848")]
		private static bool IsListString(Type type)
		{
			return default;
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x3F75418", Offset = "0x3F71418", VA = "0x3F75418")]
		public static bool IsNullOrEmpty(this string s, bool trimSpaces = true)
		{
			return default;
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x3F82994", Offset = "0x3F7E994", VA = "0x3F82994")]
		public static string GetLocalization(this string key, params object[] args)
		{
			return null;
		}
	}
}
