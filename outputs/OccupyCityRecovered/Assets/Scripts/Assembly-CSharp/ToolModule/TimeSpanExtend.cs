using System;
using Il2CppDummyDll;

namespace ToolModule
{
	[Token(Token = "0x2000197")]
	public static class TimeSpanExtend
	{
		[Token(Token = "0x4001AB4")]
		private const string DayUnit = "天";

		[Token(Token = "0x4001AB5")]
		private const string HourUnit = "时";

		[Token(Token = "0x4001AB6")]
		private const string MinuteUnit = "分";

		[Token(Token = "0x4001AB7")]
		private const string SecondUnit = "秒";

		[Token(Token = "0x6000684")]
		[Address(RVA = "0x3F6CDE8", Offset = "0x3F68DE8", VA = "0x3F6CDE8")]
		public static string GetFormattedString(this TimeSpan timeSpan, int unit = 5, bool addSpace = true)
		{
			return null;
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0x3F7DE9C", Offset = "0x3F79E9C", VA = "0x3F7DE9C")]
		public static string GetFormattedRemainingTime(this TimeSpan timeSpan, int unit = 5)
		{
			return null;
		}
	}
}
