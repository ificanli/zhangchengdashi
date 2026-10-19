using System;
using Il2CppDummyDll;

namespace L_Tools
{
	[Token(Token = "0x2000FB2")]
	public class DateTools
	{
		[Token(Token = "0x4006B93")]
		[FieldOffset(Offset = "0x0")]
		public static DateTime StartTime;

		[Token(Token = "0x4006B94")]
		[FieldOffset(Offset = "0x8")]
		public static DateTime StartTime_UTC;

		[Token(Token = "0x4006B95")]
		[FieldOffset(Offset = "0x10")]
		private static bool UseLocalTime;

		[Token(Token = "0x4006B96")]
		[FieldOffset(Offset = "0x18")]
		private static DateTime m_Now;

		[Token(Token = "0x4006B97")]
		[FieldOffset(Offset = "0x20")]
		private static DateTime m_UTCNow;

		[Token(Token = "0x17000FA2")]
		private static DateTime Now
		{
			[Token(Token = "0x6005E11")]
			[Address(RVA = "0x43F9880", Offset = "0x43F5880", VA = "0x43F9880")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000FA3")]
		private static DateTime UTCNow
		{
			[Token(Token = "0x6005E12")]
			[Address(RVA = "0x43F98D8", Offset = "0x43F58D8", VA = "0x43F98D8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6005E0F")]
		[Address(RVA = "0x43F9684", Offset = "0x43F5684", VA = "0x43F9684")]
		public static bool NowIsServerTime()
		{
			return default;
		}

		[Token(Token = "0x6005E10")]
		[Address(RVA = "0x43F96E4", Offset = "0x43F56E4", VA = "0x43F96E4")]
		public static void UpdateTime(long serverTime)
		{
		}

		[Token(Token = "0x6005E13")]
		[Address(RVA = "0x43F9930", Offset = "0x43F5930", VA = "0x43F9930")]
		public static DateTime GetNow()
		{
			return default;
		}

		[Token(Token = "0x6005E14")]
		[Address(RVA = "0x43F99B8", Offset = "0x43F59B8", VA = "0x43F99B8")]
		public static DateTime GetNowDate()
		{
			return default;
		}

		[Token(Token = "0x6005E15")]
		[Address(RVA = "0x43F9A74", Offset = "0x43F5A74", VA = "0x43F9A74")]
		public static DateTime GetUTCNow()
		{
			return default;
		}

		[Token(Token = "0x6005E16")]
		[Address(RVA = "0x43F9AFC", Offset = "0x43F5AFC", VA = "0x43F9AFC")]
		public static DateTime GetUTCDate()
		{
			return default;
		}

		[Token(Token = "0x6005E17")]
		[Address(RVA = "0x43F9BB8", Offset = "0x43F5BB8", VA = "0x43F9BB8")]
		public static long GetNowZero()
		{
			return default;
		}

		[Token(Token = "0x6005E18")]
		[Address(RVA = "0x43F9CAC", Offset = "0x43F5CAC", VA = "0x43F9CAC")]
		public static long GetNowZeroOffset(int day, int hours, int min, int sec = 0)
		{
			return default;
		}

		[Token(Token = "0x6005E19")]
		[Address(RVA = "0x43F97D8", Offset = "0x43F57D8", VA = "0x43F97D8")]
		public static DateTime StampToDatetime(long TimeStamp, bool isMinSeconds = false)
		{
			return default;
		}

		[Token(Token = "0x6005E1A")]
		[Address(RVA = "0x43F9D4C", Offset = "0x43F5D4C", VA = "0x43F9D4C")]
		public static DateTime ConvertMillisecondsToDateTime(long milliseconds)
		{
			return default;
		}

		[Token(Token = "0x6005E1B")]
		[Address(RVA = "0x43F9DD0", Offset = "0x43F5DD0", VA = "0x43F9DD0")]
		public static long ConvertDateTimeToLong_Local(DateTime dateTime)
		{
			return default;
		}

		[Token(Token = "0x6005E1C")]
		[Address(RVA = "0x43F9F00", Offset = "0x43F5F00", VA = "0x43F9F00")]
		public static long ConvertDateTimeToLong_UTC(DateTime dateTime)
		{
			return default;
		}

		[Token(Token = "0x6005E1D")]
		[Address(RVA = "0x43FA060", Offset = "0x43F6060", VA = "0x43FA060")]
		public static string SecondToHours(int second)
		{
			return null;
		}

		[Token(Token = "0x6005E1E")]
		[Address(RVA = "0x43FA1B0", Offset = "0x43F61B0", VA = "0x43FA1B0")]
		public static string SecondToHours(long second)
		{
			return null;
		}

		[Token(Token = "0x6005E1F")]
		[Address(RVA = "0x43FA2E8", Offset = "0x43F62E8", VA = "0x43FA2E8")]
		public static long GetCurrentTotalSecond_Long()
		{
			return default;
		}

		[Token(Token = "0x6005E20")]
		[Address(RVA = "0x43FA38C", Offset = "0x43F638C", VA = "0x43FA38C")]
		public static long GetCurrentTime_TotalMilliseconds()
		{
			return default;
		}

		[Token(Token = "0x6005E21")]
		[Address(RVA = "0x43FA3E4", Offset = "0x43F63E4", VA = "0x43FA3E4")]
		public static bool CheckPassTime(long span, int passTime)
		{
			return default;
		}

		[Token(Token = "0x6005E22")]
		[Address(RVA = "0x43FA450", Offset = "0x43F6450", VA = "0x43FA450")]
		public static string SecondToHoursWithoutSecond(long second)
		{
			return null;
		}

		[Token(Token = "0x6005E23")]
		[Address(RVA = "0x43FA598", Offset = "0x43F6598", VA = "0x43FA598")]
		public static long GetZeroToday(long time)
		{
			return default;
		}

		[Token(Token = "0x6005E24")]
		[Address(RVA = "0x43FA5C4", Offset = "0x43F65C4", VA = "0x43FA5C4")]
		public static string FormatToDay(int sec)
		{
			return null;
		}

		[Token(Token = "0x6005E25")]
		[Address(RVA = "0x43FA7DC", Offset = "0x43F67DC", VA = "0x43FA7DC")]
		public DateTools()
		{
		}
	}
}
