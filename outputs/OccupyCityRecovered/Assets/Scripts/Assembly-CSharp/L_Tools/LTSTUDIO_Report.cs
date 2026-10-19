using Il2CppDummyDll;

namespace L_Tools
{
	[Token(Token = "0x2000F9E")]
	public class LTSTUDIO_Report
	{
		[Token(Token = "0x4006B57")]
		[FieldOffset(Offset = "0x0")]
		private static int levelID;

		[Token(Token = "0x4006B58")]
		[FieldOffset(Offset = "0x8")]
		private static string ModeName;

		[Token(Token = "0x6005D90")]
		[Address(RVA = "0x43B9B98", Offset = "0x43B5B98", VA = "0x43B9B98")]
		private static void NewEventReport(string eventName, string eventValue = "")
		{
		}

		[Token(Token = "0x6005D91")]
		[Address(RVA = "0x43B6C2C", Offset = "0x43B2C2C", VA = "0x43B6C2C")]
		public static void ReportMultVideoPlay(string videoId, string item, int progress, int count)
		{
		}

		[Token(Token = "0x6005D92")]
		[Address(RVA = "0x43B6A88", Offset = "0x43B2A88", VA = "0x43B6A88")]
		public static void ReportMultVideoPlayFinsh(string videoId, string item, int progress, int count)
		{
		}

		[Token(Token = "0x6005D93")]
		[Address(RVA = "0x43B9D7C", Offset = "0x43B5D7C", VA = "0x43B9D7C")]
		public LTSTUDIO_Report()
		{
		}
	}
}
