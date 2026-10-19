using System;
using Il2CppDummyDll;

namespace ToolModule
{
	[Token(Token = "0x2000192")]
	public static class DateTimeExtend
	{
		[Token(Token = "0x6000664")]
		[Address(RVA = "0x3F7C664", Offset = "0x3F78664", VA = "0x3F7C664")]
		public static long ToLong(this DateTime dt)
		{
			return default;
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0x3F7C728", Offset = "0x3F78728", VA = "0x3F7C728")]
		public static DateTime ToDateTime(this long seconds)
		{
			return default;
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0x3F7C79C", Offset = "0x3F7879C", VA = "0x3F7C79C")]
		public static DateTime ToDateTime(this string str)
		{
			return default;
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0x3F7C85C", Offset = "0x3F7885C", VA = "0x3F7C85C")]
		public static string ToString(this DateTime date)
		{
			return null;
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x3F7C968", Offset = "0x3F78968", VA = "0x3F7C968")]
		public static bool IsAfterDays(this DateTime lastTime, int interval = 1, bool isZero = true)
		{
			return default;
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0x3F7CA84", Offset = "0x3F78A84", VA = "0x3F7CA84")]
		public static long MinutesToLong(int minutes)
		{
			return default;
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0x3F7CA94", Offset = "0x3F78A94", VA = "0x3F7CA94")]
		public static bool TryParseDateTime(this string dateTimeString, out DateTime time)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED DateTimeExtend.TryParseDateTime RVA=0x3F7CA94 Token=0x600066A");
}
	}
}
