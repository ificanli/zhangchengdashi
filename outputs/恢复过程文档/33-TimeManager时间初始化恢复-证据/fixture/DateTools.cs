using System;

namespace L_Tools
{
	public class DateTools
	{
		public static DateTime StartTime;
		public static DateTime StartTime_UTC;
		private static bool UseLocalTime;
		private static DateTime m_Now;
		private static DateTime m_UTCNow;
		private static DateTime Now
		{
			get
			{
				return default;
			}
		}
		private static DateTime UTCNow
		{
			get
			{
				return default;
			}
		}
		public static bool NowIsServerTime()
		{
    return !UseLocalTime;
}
		public static void UpdateTime(long serverTime)
		{
    if (UseLocalTime)
        UseLocalTime = false;
    m_Now = StampToDatetime(serverTime, false).ToLocalTime();
    m_UTCNow = StampToDatetime(serverTime, false);
}
		public static DateTime GetNow()
		{
    return m_Now;
}
		public static DateTime GetNowDate()
		{
			return default;
		}
		public static DateTime GetUTCNow()
		{
    return m_UTCNow;
}
		public static DateTime GetUTCDate()
		{
			return default;
		}
		public static long GetNowZero()
		{
			return default;
		}
		public static long GetNowZeroOffset(int day, int hours, int min, int sec = 0)
		{
			return default;
		}
		public static DateTime StampToDatetime(long TimeStamp, bool isMinSeconds = false)
		{
    return isMinSeconds ? StartTime_UTC.AddMilliseconds(TimeStamp) : StartTime_UTC.AddSeconds(TimeStamp);
}
		public static DateTime ConvertMillisecondsToDateTime(long milliseconds)
		{
			return default;
		}
		public static long ConvertDateTimeToLong_Local(DateTime dateTime)
		{
			return default;
		}
		public static long ConvertDateTimeToLong_UTC(DateTime dateTime)
		{
			return default;
		}
		public static string SecondToHours(int second)
		{
			return null;
		}
		public static string SecondToHours(long second)
		{
			return null;
		}
		public static long GetCurrentTotalSecond_Long()
		{
			return default;
		}
		public static long GetCurrentTime_TotalMilliseconds()
		{
			return default;
		}
		public static bool CheckPassTime(long span, int passTime)
		{
			return default;
		}
		public static string SecondToHoursWithoutSecond(long second)
		{
			return null;
		}
		public static long GetZeroToday(long time)
		{
			return default;
		}
		public static string FormatToDay(int sec)
		{
			return null;
		}
		public DateTools()
		{
		}
static DateTools()
{
    StartTime = new DateTime(1970, 1, 1, 8, 0, 0, DateTimeKind.Utc);
    StartTime_UTC = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
    UseLocalTime = true;
}	}
}
