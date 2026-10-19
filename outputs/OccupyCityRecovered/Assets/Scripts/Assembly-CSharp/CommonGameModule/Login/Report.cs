using Il2CppDummyDll;

namespace CommonGameModule.Login
{
	[Token(Token = "0x2000FE9")]
	public class Report
	{
		[Token(Token = "0x4006C79")]
		[FieldOffset(Offset = "0x0")]
		public static string uid;

		[Token(Token = "0x6005F47")]
		[Address(RVA = "0x4404A80", Offset = "0x4400A80", VA = "0x4404A80")]
		public static void ReportLoginRegister()
		{
		}

		[Token(Token = "0x6005F48")]
		[Address(RVA = "0x4404B44", Offset = "0x4400B44", VA = "0x4404B44")]
		public static void ReportLoginBind()
		{
		}

		[Token(Token = "0x6005F49")]
		[Address(RVA = "0x4402964", Offset = "0x43FE964", VA = "0x4402964")]
		public static void ReportLoginRequest(int Login_type)
		{
		}

		[Token(Token = "0x6005F4A")]
		[Address(RVA = "0x4404328", Offset = "0x4400328", VA = "0x4404328")]
		public static void ReportLoginSuccess()
		{
		}

		[Token(Token = "0x6005F4B")]
		[Address(RVA = "0x44043EC", Offset = "0x44003EC", VA = "0x44043EC")]
		public static void ReportLoginFail(string ErrorMsg)
		{
		}

		[Token(Token = "0x6005F4C")]
		[Address(RVA = "0x4404C08", Offset = "0x4400C08", VA = "0x4404C08")]
		public static void ReportLoginEnterFsm(string FsmName)
		{
		}

		[Token(Token = "0x6005F4D")]
		[Address(RVA = "0x4404CB0", Offset = "0x4400CB0", VA = "0x4404CB0")]
		public static void ReportLoginLeaveFsm(string FsmName)
		{
		}

		[Token(Token = "0x6005F4E")]
		[Address(RVA = "0x4404D58", Offset = "0x4400D58", VA = "0x4404D58")]
		public static void ReportLoginSdk(int Result, string ErrorMsg)
		{
		}

		[Token(Token = "0x6005F4F")]
		[Address(RVA = "0x4404E48", Offset = "0x4400E48", VA = "0x4404E48")]
		public static void ReportLoginStartServer(string login_usreid)
		{
		}

		[Token(Token = "0x6005F50")]
		[Address(RVA = "0x4404EF0", Offset = "0x4400EF0", VA = "0x4404EF0")]
		public static void ReportLoginServer(long Login_uid, int Result, string ErrorMsg, bool IsNewDevice, bool IsNewPlayer)
		{
		}

		[Token(Token = "0x6005F51")]
		[Address(RVA = "0x4405080", Offset = "0x4401080", VA = "0x4405080")]
		public static void ReportLoginSynDataFsmSuccess()
		{
		}

		[Token(Token = "0x6005F52")]
		[Address(RVA = "0x44033CC", Offset = "0x43FF3CC", VA = "0x44033CC")]
		public static void ReportLogoutPopup()
		{
		}

		[Token(Token = "0x6005F53")]
		[Address(RVA = "0x4403558", Offset = "0x43FF558", VA = "0x4403558")]
		public static void ReportLogoutRequest()
		{
		}

		[Token(Token = "0x6005F54")]
		[Address(RVA = "0x440384C", Offset = "0x43FF84C", VA = "0x440384C")]
		public static void ReportLogoutServerSuccess()
		{
		}

		[Token(Token = "0x6005F55")]
		[Address(RVA = "0x4403924", Offset = "0x43FF924", VA = "0x4403924")]
		public static void ReportLogoutServerFail()
		{
		}

		[Token(Token = "0x6005F56")]
		[Address(RVA = "0x4405144", Offset = "0x4401144", VA = "0x4405144")]
		public Report()
		{
		}
	}
}
