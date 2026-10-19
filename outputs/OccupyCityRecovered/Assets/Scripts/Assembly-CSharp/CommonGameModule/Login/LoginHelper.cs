using Il2CppDummyDll;

namespace CommonGameModule.Login
{
	[Token(Token = "0x2000FE1")]
	public class LoginHelper
	{
		[Token(Token = "0x4006C34")]
		[FieldOffset(Offset = "0x0")]
		private static int m_selectLobby;

		[Token(Token = "0x4006C35")]
		[FieldOffset(Offset = "0x8")]
		private static string userChannel;

		[Token(Token = "0x4006C36")]
		[FieldOffset(Offset = "0x10")]
		private static string appVersion;

		[Token(Token = "0x6005EF7")]
		[Address(RVA = "0x4400230", Offset = "0x43FC230", VA = "0x4400230")]
		public static void SetSelectLobby(int selectLobby)
		{
		}

		[Token(Token = "0x6005EF8")]
		[Address(RVA = "0x440028C", Offset = "0x43FC28C", VA = "0x440028C")]
		public static int GetSelectLobby()
		{
			return default;
		}

		[Token(Token = "0x6005EF9")]
		[Address(RVA = "0x44002E4", Offset = "0x43FC2E4", VA = "0x44002E4")]
		public static void SetUserChannel(string parametric)
		{
		}

		[Token(Token = "0x6005EFA")]
		[Address(RVA = "0x4400340", Offset = "0x43FC340", VA = "0x4400340")]
		public static string GetUserChannerl()
		{
			return null;
		}

		[Token(Token = "0x6005EFB")]
		[Address(RVA = "0x4400398", Offset = "0x43FC398", VA = "0x4400398")]
		public static string GetAppVersion()
		{
			return null;
		}

		[Token(Token = "0x6005EFC")]
		[Address(RVA = "0x44003F0", Offset = "0x43FC3F0", VA = "0x44003F0")]
		public static void SetAppVersion(string ver)
		{
		}

		[Token(Token = "0x6005EFD")]
		[Address(RVA = "0x43FFFE8", Offset = "0x43FBFE8", VA = "0x43FFFE8")]
		public static string GetDeviceID()
		{
			return null;
		}

		[Token(Token = "0x6005EFE")]
		[Address(RVA = "0x43FFF08", Offset = "0x43FBF08", VA = "0x43FFF08")]
		public static string GetOperatingSystem()
		{
			return null;
		}

		[Token(Token = "0x6005EFF")]
		[Address(RVA = "0x440006C", Offset = "0x43FC06C", VA = "0x440006C")]
		public static string GetDeviceModel()
		{
			return null;
		}

		[Token(Token = "0x6005F00")]
		[Address(RVA = "0x43FFF64", Offset = "0x43FBF64", VA = "0x43FFF64")]
		public static string GetNetType()
		{
			return null;
		}

		[Token(Token = "0x6005F01")]
		[Address(RVA = "0x44000C8", Offset = "0x43FC0C8", VA = "0x44000C8")]
		public static string GetPlatform()
		{
			return null;
		}

		[Token(Token = "0x6005F02")]
		[Address(RVA = "0x4400188", Offset = "0x43FC188", VA = "0x4400188")]
		public static string GetAppChannel()
		{
			return null;
		}

		[Token(Token = "0x6005F03")]
		[Address(RVA = "0x44001DC", Offset = "0x43FC1DC", VA = "0x44001DC")]
		public static string GetCountry()
		{
			return null;
		}

		[Token(Token = "0x6005F04")]
		[Address(RVA = "0x440045C", Offset = "0x43FC45C", VA = "0x440045C")]
		public static string GetPackageName()
		{
			return null;
		}

		[Token(Token = "0x6005F05")]
		[Address(RVA = "0x44004E0", Offset = "0x43FC4E0", VA = "0x44004E0")]
		public static string GetVersionName()
		{
			return null;
		}

		[Token(Token = "0x6005F06")]
		[Address(RVA = "0x4400564", Offset = "0x43FC564", VA = "0x4400564")]
		public static OSType GetOSType()
		{
			return default;
		}

		[Token(Token = "0x6005F07")]
		[Address(RVA = "0x440056C", Offset = "0x43FC56C", VA = "0x440056C")]
		public LoginHelper()
		{
		}
	}
}
