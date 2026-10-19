using Il2CppDummyDll;

namespace DigitalOpus.MB.Core
{
	[Token(Token = "0x200003F")]
	public class MB2_Log
	{
		[Token(Token = "0x6000114")]
		[Address(RVA = "0x74479DC", Offset = "0x74439DC", VA = "0x74479DC")]
		public static void Log(MB2_LogLevel l, string msg, MB2_LogLevel currentThreshold)
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x7447C00", Offset = "0x7443C00", VA = "0x7447C00")]
		public static string Error(string msg, params object[] args)
		{
			return null;
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x7447CEC", Offset = "0x7443CEC", VA = "0x7447CEC")]
		public static string Warn(string msg, params object[] args)
		{
			return null;
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x7447DD8", Offset = "0x7443DD8", VA = "0x7447DD8")]
		public static string Info(string msg, params object[] args)
		{
			return null;
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x7447EC4", Offset = "0x7443EC4", VA = "0x7447EC4")]
		public static string LogDebug(string msg, params object[] args)
		{
			return null;
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x7447FB0", Offset = "0x7443FB0", VA = "0x7447FB0")]
		public static string Trace(string msg, params object[] args)
		{
			return null;
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x744809C", Offset = "0x744409C", VA = "0x744809C")]
		public MB2_Log()
		{
		}
	}
}
